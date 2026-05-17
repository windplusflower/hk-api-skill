"""Rebuild the scene-objects index for one or more HK scenes.

Reads Unity SerializedFiles from the local Hollow Knight install and emits
a medium-tier TSV with one row per GameObject:

    scene  go_path  go_pathid  level_file  parent_go_pathid
    pos_x  pos_y  pos_z  scale_x  scale_y
    collider_type  renderer_type  fsm_count  child_count

Designed for "lazy dump" — the index answers cheap questions
("what's in this scene", "where is X") without exploding repo size, and
points dump_gameobject.py at the exact file + path_id when full detail
is needed.

Usage:
    python rebuild_scene_index.py --scene Abyss_01
    python rebuild_scene_index.py --level 327
    python rebuild_scene_index.py --all   # build everything
"""
from __future__ import annotations

import argparse
import csv
import re
import sys
from collections import Counter
from dataclasses import dataclass, field
from pathlib import Path
from typing import Iterable

# Preflight checks are NOT performed at import — they fire when main()
# runs, so importing this module from another script (or for type-checking)
# does not require UnityPy or a local HK install.
from _preflight import check_unitypy, resolve_hk_data

SKILL_ROOT = Path(__file__).resolve().parent.parent
HK_DATA: Path  # populated by main() via resolve_hk_data()
INDEX_DIR = SKILL_ROOT / "scene-index"
INDEX_TSV = INDEX_DIR / "scene-objects.tsv"
SCENE_MAP_TSV = INDEX_DIR / "scene-map.tsv"
FSM_MANIFEST = SKILL_ROOT / "fsm-index" / "fsm-manifest.tsv"
FSM_EXPORT_ROOT = SKILL_ROOT / "fsm-export"

_GO_PATHID_RE = re.compile(r"^\|\s*GameObject PathId\s*\|\s*(\d+)\s*\|", re.MULTILINE)

COLLIDER_TYPES = {
    "BoxCollider2D": "box2d",
    "CircleCollider2D": "circle2d",
    "PolygonCollider2D": "polygon2d",
    "EdgeCollider2D": "edge2d",
    "CapsuleCollider2D": "capsule2d",
    "TilemapCollider2D": "tilemap2d",
    "CompositeCollider2D": "composite2d",
}
RENDERER_TYPES = {
    "SpriteRenderer": "sprite",
    "MeshRenderer": "mesh",
    "ParticleSystemRenderer": "particle",
    "TilemapRenderer": "tilemap",
    "SkinnedMeshRenderer": "skinned_mesh",
    "LineRenderer": "line",
    "TrailRenderer": "trail",
}

COLUMNS = [
    "scene",
    "go_path",
    "go_pathid",
    "level_file",
    "parent_go_pathid",
    "pos_x",
    "pos_y",
    "pos_z",
    "scale_x",
    "scale_y",
    "collider_type",
    "renderer_type",
    "fsm_count",
    "child_count",
    "active",
]


@dataclass
class GoRow:
    name: str
    pathid: int
    transform_pathid: int = 0
    parent_transform_pathid: int = 0
    parent_go_pathid: int = 0
    local_pos: tuple[float, float, float] = (0.0, 0.0, 0.0)
    local_scale: tuple[float, float, float] = (1.0, 1.0, 1.0)
    world_pos: tuple[float, float, float] = (0.0, 0.0, 0.0)
    collider_type: str = ""
    renderer_type: str = ""
    fsm_count: int = 0
    child_count: int = 0
    active: bool = True


def load_scene_map() -> list[str]:
    ggm = UnityPy.load(str(HK_DATA / "globalgamemanagers"))
    for obj in ggm.objects:
        if obj.type.name == "BuildSettings":
            data = obj.read()
            return list(getattr(data, "scenes", []) or [])
    raise RuntimeError("BuildSettings not found in globalgamemanagers")


def scene_basename(scene_path: str) -> str:
    """`Assets/Scenes/Abyss/Abyss_01.unity` -> `Abyss_01`."""
    return Path(scene_path).stem


def load_fsm_counts(scene_name: str) -> Counter[int]:
    """Return Counter keyed by `gameobject_pathid` for the scene.

    The fsm-manifest does not carry GameObject PathId, so we look it up
    by scanning each FSM markdown's `| GameObject PathId | N |` row. This
    is the only reliable join key — name-based joins over-stamp because
    many GOs share short normalized names like "White_Flash".
    """
    counts: Counter[int] = Counter()
    if not FSM_MANIFEST.exists() or not FSM_EXPORT_ROOT.exists():
        return counts
    target_scene = f"{scene_name}.unity"
    with FSM_MANIFEST.open("r", encoding="utf-8", newline="") as f:
        reader = csv.DictReader(f, delimiter="\t")
        for row in reader:
            if row.get("scene") != target_scene:
                continue
            rel = row.get("relative_path") or ""
            if not rel:
                continue
            md_path = FSM_EXPORT_ROOT / rel
            try:
                text = md_path.read_text(encoding="utf-8")
            except OSError:
                continue
            m = _GO_PATHID_RE.search(text)
            if m:
                counts[int(m.group(1))] += 1
    return counts


def write_scene_map(scenes: list[str]) -> None:
    INDEX_DIR.mkdir(parents=True, exist_ok=True)
    with SCENE_MAP_TSV.open("w", encoding="utf-8", newline="") as f:
        w = csv.writer(f, delimiter="\t", lineterminator="\n")
        w.writerow(["scene", "scene_path", "level_file"])
        for i, sp in enumerate(scenes):
            w.writerow([scene_basename(sp), sp, f"level{i}"])


def read_pptr(pptr) -> object | None:
    """UnityPy PPtr -> read object, or None if dangling/cross-file unresolved."""
    if pptr is None:
        return None
    try:
        if not getattr(pptr, "path_id", 0):
            return None
        return pptr.read()
    except Exception:
        return None


def detect_playmaker_fsm(comp_pptr) -> bool:
    """Return True if a MonoBehaviour PPtr resolves to a PlayMakerFSM script."""
    obj = read_pptr(comp_pptr)
    if obj is None:
        return False
    script_pptr = getattr(obj, "m_Script", None)
    script = read_pptr(script_pptr) if script_pptr is not None else None
    if script is None:
        return False
    cls = getattr(script, "m_ClassName", "") or ""
    return cls == "PlayMakerFSM"


def collect_scene(level_idx: int, scene_name: str) -> list[GoRow]:
    level_path = HK_DATA / f"level{level_idx}"
    if not level_path.exists():
        print(f"  skip: {level_path} missing", file=sys.stderr)
        return []

    env = UnityPy.load(str(level_path))

    gos: dict[int, GoRow] = {}
    transforms: dict[int, dict] = {}  # transform_pathid -> {go_pathid, local_pos, local_scale, parent_t_pathid}

    for obj in env.objects:
        if obj.type.name == "GameObject":
            try:
                go = obj.read()
            except Exception as e:
                print(f"  warn: GO {obj.path_id} read failed: {e}", file=sys.stderr)
                continue
            row = GoRow(
                name=getattr(go, "m_Name", "") or "",
                pathid=obj.path_id,
                active=bool(getattr(go, "m_IsActive", True)),
            )
            comp_list = list(getattr(go, "m_Component", []) or [])
            for cp in comp_list:
                pptr = getattr(cp, "component", None) or cp
                # We need the type of the component without reading its body
                # when possible; fall back to read for MonoBehaviour to detect FSM.
                t_name = ""
                pid = getattr(pptr, "path_id", 0)
                if pid:
                    target = env.objects_dict.get(pid) if hasattr(env, "objects_dict") else None
                    if target is None:
                        # Fallback: linear search not great but env may not expose dict
                        for o in env.objects:
                            if o.path_id == pid:
                                target = o
                                break
                    if target is not None:
                        t_name = target.type.name

                if t_name == "Transform" or t_name == "RectTransform":
                    row.transform_pathid = pid
                elif t_name in COLLIDER_TYPES and not row.collider_type:
                    row.collider_type = COLLIDER_TYPES[t_name]
                elif t_name in RENDERER_TYPES and not row.renderer_type:
                    row.renderer_type = RENDERER_TYPES[t_name]
                # NOTE: PlayMakerFSM detection is done via name-join with
                # fsm-manifest.tsv in write_rows(); cross-file MonoScript
                # resolution from a level-only env is unreliable.
            gos[obj.path_id] = row

        elif obj.type.name in ("Transform", "RectTransform"):
            try:
                t = obj.read()
            except Exception:
                continue
            go_pptr = getattr(t, "m_GameObject", None)
            father_pptr = getattr(t, "m_Father", None)
            lp = getattr(t, "m_LocalPosition", None)
            ls = getattr(t, "m_LocalScale", None)
            children = getattr(t, "m_Children", None) or []
            transforms[obj.path_id] = {
                "go_pathid": getattr(go_pptr, "path_id", 0) if go_pptr is not None else 0,
                "parent_t_pathid": getattr(father_pptr, "path_id", 0) if father_pptr is not None else 0,
                "local_pos": (
                    float(getattr(lp, "x", 0.0)) if lp is not None else 0.0,
                    float(getattr(lp, "y", 0.0)) if lp is not None else 0.0,
                    float(getattr(lp, "z", 0.0)) if lp is not None else 0.0,
                ),
                "local_scale": (
                    float(getattr(ls, "x", 1.0)) if ls is not None else 1.0,
                    float(getattr(ls, "y", 1.0)) if ls is not None else 1.0,
                    float(getattr(ls, "z", 1.0)) if ls is not None else 1.0,
                ),
                "child_count": len(list(children)),
            }

    # Stitch transform info into GoRow + compute parent_go and child_count
    for tpid, t in transforms.items():
        go = gos.get(t["go_pathid"])
        if go is None:
            continue
        go.local_pos = t["local_pos"]
        go.local_scale = t["local_scale"]
        go.parent_transform_pathid = t["parent_t_pathid"]
        go.child_count = t["child_count"]

    # Resolve parent_go_pathid via parent transform
    for go in gos.values():
        pt = go.parent_transform_pathid
        if pt and pt in transforms:
            go.parent_go_pathid = transforms[pt]["go_pathid"]

    # Compute world position by walking transform parents
    # (HK is 2D — Z varies for layering but rotation is mostly identity, so
    # plain additive accumulation is good enough for indexing purposes.)
    def world_pos(tpid: int, depth: int = 0) -> tuple[float, float, float]:
        if not tpid or tpid not in transforms or depth > 64:
            return (0.0, 0.0, 0.0)
        t = transforms[tpid]
        px, py, pz = world_pos(t["parent_t_pathid"], depth + 1)
        lx, ly, lz = t["local_pos"]
        return (px + lx, py + ly, pz + lz)

    for go in gos.values():
        if go.transform_pathid:
            go.world_pos = world_pos(go.transform_pathid)

    print(
        f"  level{level_idx} ({scene_name}): {len(gos)} GameObjects, "
        f"{sum(1 for g in gos.values() if g.collider_type)} with collider",
        file=sys.stderr,
    )
    return list(gos.values())


def go_path_for(go: GoRow, all_gos: dict[int, GoRow]) -> str:
    parts: list[str] = []
    cur = go
    seen: set[int] = set()
    while cur and cur.pathid not in seen:
        seen.add(cur.pathid)
        parts.append(cur.name)
        if not cur.parent_go_pathid:
            break
        cur = all_gos.get(cur.parent_go_pathid)
    return "/".join(reversed(parts))


def write_rows(scene_name: str, level_idx: int, gos: list[GoRow], writer) -> None:
    by_pid = {g.pathid: g for g in gos}
    fsm_counts = load_fsm_counts(scene_name)
    matched_gos = 0
    matched_fsms = 0
    for g in gos:
        fsm_n = fsm_counts.get(g.pathid, 0)
        if fsm_n:
            matched_gos += 1
            matched_fsms += fsm_n
        writer.writerow([
            scene_name,
            go_path_for(g, by_pid),
            g.pathid,
            f"level{level_idx}",
            g.parent_go_pathid or "",
            f"{g.world_pos[0]:.3f}",
            f"{g.world_pos[1]:.3f}",
            f"{g.world_pos[2]:.3f}",
            f"{g.local_scale[0]:.3f}",
            f"{g.local_scale[1]:.3f}",
            g.collider_type,
            g.renderer_type,
            fsm_n,
            g.child_count,
            "1" if g.active else "0",
        ])
    if fsm_counts:
        total_fsms = sum(fsm_counts.values())
        print(
            f"  fsm-join: {matched_fsms}/{total_fsms} FSMs joined onto "
            f"{matched_gos} GOs (PathId-exact)",
            file=sys.stderr,
        )


def main() -> int:
    ap = argparse.ArgumentParser()
    g = ap.add_mutually_exclusive_group(required=True)
    g.add_argument("--scene", help="Scene basename, e.g. Abyss_01")
    g.add_argument("--level", type=int, help="Level file index, e.g. 327")
    g.add_argument("--all", action="store_true", help="Build for every scene")
    ap.add_argument(
        "--out",
        type=Path,
        default=None,
        help="Override output TSV path (default: scene-index/scene-objects.tsv)",
    )
    args = ap.parse_args()

    check_unitypy()
    global HK_DATA
    HK_DATA = resolve_hk_data()
    # UnityPy is now safe to import at function level
    global UnityPy  # type: ignore[name-defined]
    import UnityPy as _up  # noqa: E402
    UnityPy = _up

    out_path: Path = args.out or INDEX_TSV
    out_path.parent.mkdir(parents=True, exist_ok=True)

    scenes = load_scene_map()
    write_scene_map(scenes)

    selection: list[tuple[int, str]] = []
    if args.scene:
        for i, sp in enumerate(scenes):
            if scene_basename(sp) == args.scene:
                selection.append((i, args.scene))
                break
        if not selection:
            print(f"scene {args.scene!r} not in BuildSettings", file=sys.stderr)
            return 2
    elif args.level is not None:
        if args.level >= len(scenes):
            print(f"level {args.level} out of range (have {len(scenes)})", file=sys.stderr)
            return 2
        selection.append((args.level, scene_basename(scenes[args.level])))
    else:
        selection = [(i, scene_basename(sp)) for i, sp in enumerate(scenes)]

    print(f"Writing {out_path} (rows for {len(selection)} scene(s))", file=sys.stderr)
    with out_path.open("w", encoding="utf-8", newline="") as f:
        w = csv.writer(f, delimiter="\t", lineterminator="\n")
        w.writerow(COLUMNS)
        for level_idx, scene_name in selection:
            gos = collect_scene(level_idx, scene_name)
            write_rows(scene_name, level_idx, gos, w)
    print("done", file=sys.stderr)
    return 0


if __name__ == "__main__":
    raise SystemExit(main())
