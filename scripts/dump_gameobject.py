"""On-demand: dump one GameObject's full component detail as Markdown.

Pairs with rebuild_scene_index.py — the index points you at
(scene, go_pathid); this script does the heavy parse against the
local Unity level file and writes a single GO's report.

Usage:
    python dump_gameobject.py --scene Abyss_01 --pathid 924
    python dump_gameobject.py --scene Abyss_01 --name "Ruins Flying Sentry"
    python dump_gameobject.py --scene Abyss_01 --pathid 924 --children 2
"""
from __future__ import annotations

import argparse
import csv
import re
import sys
from pathlib import Path
from typing import Any

from _preflight import check_unitypy, resolve_hk_data

SKILL_ROOT = Path(__file__).resolve().parent.parent
HK_DATA: Path  # populated by main() via resolve_hk_data()
SCENE_MAP_TSV = SKILL_ROOT / "scene-index" / "scene-map.tsv"
SCENE_CACHE_DIR = SKILL_ROOT / "scene-cache"
FSM_MANIFEST = SKILL_ROOT / "fsm-index" / "fsm-manifest.tsv"
FSM_EXPORT_ROOT = SKILL_ROOT / "fsm-export"

_GO_PATHID_RE = re.compile(r"^\|\s*GameObject PathId\s*\|\s*(\d+)\s*\|", re.MULTILINE)
_SAFE_NAME_RE = re.compile(r"[^\w.-]+")


def safe_filename(s: str) -> str:
    return _SAFE_NAME_RE.sub("_", s).strip("_") or "unnamed"


def resolve_level(scene_name: str) -> Path:
    if not SCENE_MAP_TSV.exists():
        raise SystemExit(
            f"scene-map.tsv missing at {SCENE_MAP_TSV}. Run rebuild_scene_index.py once first."
        )
    with SCENE_MAP_TSV.open(encoding="utf-8", newline="") as f:
        for row in csv.DictReader(f, delimiter="\t"):
            if row["scene"] == scene_name:
                return HK_DATA / row["level_file"]
    raise SystemExit(f"scene {scene_name!r} not in scene-map.tsv")


def load_level(level_path: Path) -> tuple[Any, dict[int, Any]]:
    env = UnityPy.load(str(level_path))
    by_pid = {obj.path_id: obj for obj in env.objects}
    return env, by_pid


def vec_str(v: Any, dims: int = 3) -> str:
    if v is None:
        return ""
    parts = []
    for k in ("x", "y", "z", "w")[:dims]:
        parts.append(f"{float(getattr(v, k, 0.0)):.4f}")
    return f"({', '.join(parts)})"


def collect_transforms(by_pid: dict[int, Any]) -> dict[int, dict]:
    """tpid -> {go_pathid, parent_t_pathid, local_pos, local_scale, children: [tpid]}"""
    out: dict[int, dict] = {}
    for pid, obj in by_pid.items():
        if obj.type.name not in ("Transform", "RectTransform"):
            continue
        try:
            t = obj.read()
        except Exception:
            continue
        out[pid] = {
            "go_pathid": getattr(getattr(t, "m_GameObject", None), "path_id", 0),
            "parent_t_pathid": getattr(getattr(t, "m_Father", None), "path_id", 0),
            "local_pos": getattr(t, "m_LocalPosition", None),
            "local_scale": getattr(t, "m_LocalScale", None),
            "local_rot": getattr(t, "m_LocalRotation", None),
            "children_t_pathids": [
                getattr(c, "path_id", 0) for c in (getattr(t, "m_Children", None) or [])
            ],
        }
    return out


def world_position(tpid: int, transforms: dict[int, dict], depth: int = 0) -> tuple[float, float, float]:
    if not tpid or tpid not in transforms or depth > 64:
        return (0.0, 0.0, 0.0)
    t = transforms[tpid]
    px, py, pz = world_position(t["parent_t_pathid"], transforms, depth + 1)
    lp = t["local_pos"]
    if lp is None:
        return (px, py, pz)
    return (px + float(lp.x), py + float(lp.y), pz + float(lp.z))


def find_go_by_name(by_pid: dict[int, Any], name: str) -> list[int]:
    hits: list[int] = []
    for pid, obj in by_pid.items():
        if obj.type.name != "GameObject":
            continue
        try:
            go = obj.read()
        except Exception:
            continue
        if (getattr(go, "m_Name", "") or "") == name:
            hits.append(pid)
    return hits


def _fmt_collider(t_name: str, comp: Any) -> list[tuple[str, str]]:
    rows: list[tuple[str, str]] = []
    offset = getattr(comp, "m_Offset", None)
    if offset is not None:
        rows.append(("Offset", vec_str(offset, 2)))
    if t_name == "BoxCollider2D":
        size = getattr(comp, "m_Size", None)
        if size is not None:
            rows.append(("Size", vec_str(size, 2)))
    elif t_name == "CircleCollider2D":
        radius = getattr(comp, "m_Radius", None)
        if radius is not None:
            rows.append(("Radius", f"{float(radius):.4f}"))
    elif t_name == "PolygonCollider2D":
        paths = getattr(comp, "m_Points", None) or []
        rows.append(("Path count", str(len(paths))))
        for i, path in enumerate(paths[:3]):
            pts = getattr(path, "points", None) or path
            try:
                n = len(list(pts))
            except TypeError:
                n = "?"
            rows.append((f"Path[{i}] points", str(n)))
        if len(paths) > 3:
            rows.append(("...", f"{len(paths) - 3} more paths"))
    elif t_name == "EdgeCollider2D":
        pts = getattr(comp, "m_Points", None) or []
        rows.append(("Edge points", str(len(pts))))
        radius = getattr(comp, "m_EdgeRadius", None)
        if radius is not None:
            rows.append(("Edge radius", f"{float(radius):.4f}"))
    is_trigger = getattr(comp, "m_IsTrigger", None)
    if is_trigger is not None:
        rows.append(("IsTrigger", str(bool(is_trigger))))
    return rows


def _fmt_sprite_renderer(comp: Any) -> list[tuple[str, str]]:
    rows: list[tuple[str, str]] = []
    sprite_pptr = getattr(comp, "m_Sprite", None)
    sprite_name = ""
    if sprite_pptr is not None and getattr(sprite_pptr, "path_id", 0):
        try:
            s = sprite_pptr.read()
            sprite_name = getattr(s, "m_Name", "") or ""
        except Exception:
            sprite_name = f"<unresolved pid={sprite_pptr.path_id}>"
    if sprite_name:
        rows.append(("Sprite", sprite_name))
    color = getattr(comp, "m_Color", None)
    if color is not None:
        rows.append(("Color (RGBA)", vec_str(color, 4)))
    rows.append(("FlipX", str(bool(getattr(comp, "m_FlipX", False)))))
    rows.append(("FlipY", str(bool(getattr(comp, "m_FlipY", False)))))
    rows.append(("SortingLayerID", str(getattr(comp, "m_SortingLayerID", ""))))
    rows.append(("SortingOrder", str(getattr(comp, "m_SortingOrder", ""))))
    return rows


def fsm_links_for_go(scene_name: str, go_pathid: int) -> list[tuple[str, str, str, str]]:
    """Return [(fsm_name, fsm_id, gameobject_segment, relative_path)]."""
    if not FSM_MANIFEST.exists():
        return []
    target_scene = f"{scene_name}.unity"
    out: list[tuple[str, str, str, str]] = []
    with FSM_MANIFEST.open(encoding="utf-8", newline="") as f:
        for row in csv.DictReader(f, delimiter="\t"):
            if row.get("scene") != target_scene:
                continue
            rel = row.get("relative_path") or ""
            md = FSM_EXPORT_ROOT / rel
            try:
                m = _GO_PATHID_RE.search(md.read_text(encoding="utf-8"))
            except OSError:
                continue
            if m and int(m.group(1)) == go_pathid:
                out.append((
                    row.get("fsm_name", ""),
                    row.get("fsm_id", ""),
                    row.get("gameobject_segment", ""),
                    rel,
                ))
    return out


def render_markdown(
    scene_name: str,
    level_path: Path,
    go_pathid: int,
    by_pid: dict[int, Any],
    transforms: dict[int, dict],
    children_depth: int,
) -> str:
    obj = by_pid.get(go_pathid)
    if obj is None or obj.type.name != "GameObject":
        raise SystemExit(f"path_id {go_pathid} is not a GameObject in {level_path.name}")
    go = obj.read()
    name = getattr(go, "m_Name", "") or ""
    components = list(getattr(go, "m_Component", []) or [])

    transform_pid = 0
    for cp in components:
        pp = getattr(cp, "component", None) or cp
        pid = getattr(pp, "path_id", 0)
        if pid in transforms:
            transform_pid = pid
            break

    parent_go_pid = 0
    if transform_pid:
        pt = transforms[transform_pid]["parent_t_pathid"]
        if pt and pt in transforms:
            parent_go_pid = transforms[pt]["go_pathid"]

    local_pos = transforms.get(transform_pid, {}).get("local_pos") if transform_pid else None
    local_scale = transforms.get(transform_pid, {}).get("local_scale") if transform_pid else None
    wp = world_position(transform_pid, transforms) if transform_pid else (0.0, 0.0, 0.0)

    lines: list[str] = [f"# GameObject: {name}", ""]
    lines.append("## Summary")
    lines.append("")
    lines.append("| Field | Value |")
    lines.append("| --- | --- |")
    lines.append(f"| Scene | {scene_name} |")
    lines.append(f"| Level file | {level_path.name} |")
    lines.append(f"| Name | {name} |")
    lines.append(f"| GameObject PathId | {go_pathid} |")
    lines.append(f"| Parent GameObject PathId | {parent_go_pid or ''} |")
    lines.append(f"| Active | {bool(getattr(go, 'm_IsActive', True))} |")
    lines.append(f"| Layer | {getattr(go, 'm_Layer', '')} |")
    lines.append(f"| Tag | {getattr(go, 'm_TagString', '') or getattr(go, 'm_Tag', '')} |")
    lines.append(f"| Local position | {vec_str(local_pos)} |")
    lines.append(f"| Local scale | {vec_str(local_scale)} |")
    lines.append(f"| World position | ({wp[0]:.4f}, {wp[1]:.4f}, {wp[2]:.4f}) |")
    lines.append(f"| Component count | {len(components)} |")
    lines.append("")

    lines.append("## Components")
    lines.append("")
    for i, cp in enumerate(components, 1):
        pp = getattr(cp, "component", None) or cp
        pid = getattr(pp, "path_id", 0)
        target = by_pid.get(pid)
        t_name = target.type.name if target else "?"
        lines.append(f"### {i}. {t_name}  (path_id={pid})")
        lines.append("")
        try:
            comp = pp.read() if pid else None
        except Exception as e:
            lines.append(f"_unreadable: {e.__class__.__name__}: {e}_")
            lines.append("")
            continue
        rows: list[tuple[str, str]] = []
        if t_name in ("Transform", "RectTransform"):
            rows.append(("Local position", vec_str(getattr(comp, "m_LocalPosition", None))))
            rows.append(("Local rotation", vec_str(getattr(comp, "m_LocalRotation", None), 4)))
            rows.append(("Local scale", vec_str(getattr(comp, "m_LocalScale", None))))
            rows.append(("Children", str(len(getattr(comp, "m_Children", None) or []))))
        elif t_name in {"BoxCollider2D", "CircleCollider2D", "PolygonCollider2D", "EdgeCollider2D"}:
            rows.extend(_fmt_collider(t_name, comp))
        elif t_name == "SpriteRenderer":
            rows.extend(_fmt_sprite_renderer(comp))
        elif t_name == "MonoBehaviour":
            sp = getattr(comp, "m_Script", None)
            cls = ""
            if sp is not None and getattr(sp, "path_id", 0):
                try:
                    s = sp.read()
                    cls = getattr(s, "m_ClassName", "") or ""
                except Exception:
                    cls = f"<unresolved pid={sp.path_id}>"
            rows.append(("Script class", cls or "<unknown>"))
            mname = getattr(comp, "m_Name", "") or ""
            if mname:
                rows.append(("m_Name", mname))
        else:
            rows.append(("Type", t_name))
        if rows:
            lines.append("| Field | Value |")
            lines.append("| --- | --- |")
            for k, v in rows:
                lines.append(f"| {k} | {v} |")
            lines.append("")

    fsms = fsm_links_for_go(scene_name, go_pathid)
    lines.append("## Attached FSMs")
    lines.append("")
    if not fsms:
        lines.append("(none — no FSM in fsm-export targets this PathId)")
    else:
        lines.append("| FSM Name | FSM PathId | GameObject Segment | Export |")
        lines.append("| --- | --- | --- | --- |")
        for fname, fid, seg, rel in fsms:
            lines.append(f"| {fname} | {fid} | {seg} | [`{rel}`](../fsm-export/{rel}) |")
    lines.append("")

    if children_depth > 0 and transform_pid:
        lines.append(f"## Children (depth ≤ {children_depth})")
        lines.append("")
        lines.append("| Depth | GO PathId | Name | Local Pos | Components |")
        lines.append("| --- | --- | --- | --- | --- |")
        emit_children(transform_pid, transforms, by_pid, children_depth, 1, lines)
        lines.append("")

    return "\n".join(lines).rstrip() + "\n"


def emit_children(
    parent_tpid: int,
    transforms: dict[int, dict],
    by_pid: dict[int, Any],
    max_depth: int,
    depth: int,
    out: list[str],
) -> None:
    t = transforms.get(parent_tpid)
    if not t:
        return
    for ctpid in t["children_t_pathids"]:
        ct = transforms.get(ctpid)
        if not ct:
            continue
        cgo_pid = ct["go_pathid"]
        cgo = by_pid.get(cgo_pid)
        cname = ""
        ccount = 0
        if cgo and cgo.type.name == "GameObject":
            try:
                cgo_data = cgo.read()
                cname = getattr(cgo_data, "m_Name", "") or ""
                ccount = len(list(getattr(cgo_data, "m_Component", None) or []))
            except Exception:
                pass
        out.append(
            f"| {depth} | {cgo_pid} | {cname} | {vec_str(ct['local_pos'])} | {ccount} |"
        )
        if depth < max_depth:
            emit_children(ctpid, transforms, by_pid, max_depth, depth + 1, out)


def main() -> int:
    ap = argparse.ArgumentParser()
    ap.add_argument("--scene", required=True, help="Scene basename (e.g. Abyss_01)")
    g = ap.add_mutually_exclusive_group(required=True)
    g.add_argument("--pathid", type=int, help="GameObject PathId from scene-objects.tsv")
    g.add_argument("--name", help="GameObject m_Name (must be unique in scene)")
    ap.add_argument("--children", type=int, default=1, help="Children expansion depth (default 1)")
    ap.add_argument("--out", type=Path, default=None, help="Output file (default scene-cache/...)")
    ap.add_argument("--stdout", action="store_true", help="Print to stdout instead of writing")
    args = ap.parse_args()

    check_unitypy()
    global HK_DATA
    HK_DATA = resolve_hk_data()
    global UnityPy  # type: ignore[name-defined]
    import UnityPy as _up  # noqa: E402
    UnityPy = _up

    level_path = resolve_level(args.scene)
    if not level_path.exists():
        raise SystemExit(f"level file missing: {level_path}")
    env, by_pid = load_level(level_path)
    transforms = collect_transforms(by_pid)

    if args.pathid is not None:
        pid = args.pathid
    else:
        hits = find_go_by_name(by_pid, args.name)
        if not hits:
            raise SystemExit(f"no GameObject named {args.name!r} in {args.scene}")
        if len(hits) > 1:
            raise SystemExit(
                f"name {args.name!r} matches multiple GOs in {args.scene}: {hits}. "
                f"Pass --pathid to disambiguate."
            )
        pid = hits[0]

    md = render_markdown(args.scene, level_path, pid, by_pid, transforms, args.children)

    if args.stdout:
        print(md)
        return 0

    if args.out is None:
        SCENE_CACHE_DIR.mkdir(parents=True, exist_ok=True)
        scene_dir = SCENE_CACHE_DIR / args.scene
        scene_dir.mkdir(parents=True, exist_ok=True)
        # Determine name for filename
        try:
            name = getattr(by_pid[pid].read(), "m_Name", "") or ""
        except Exception:
            name = ""
        args.out = scene_dir / f"{pid}__{safe_filename(name)}.md"
    args.out.parent.mkdir(parents=True, exist_ok=True)
    args.out.write_text(md, encoding="utf-8")
    print(f"wrote {args.out}", file=sys.stderr)
    return 0


if __name__ == "__main__":
    raise SystemExit(main())
