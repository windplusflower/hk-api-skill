# Scene Index (lazy-dump architecture)

Static index over every Hollow Knight scene's GameObjects. Pairs with the
`fsm-export/` dataset to answer "what's in this scene / where is X /
what's attached to it" without exporting a markdown for every GO.

## Files

| File | Purpose |
| --- | --- |
| `scene-objects.tsv` | One row per GameObject across all built scenes (medium-tier index) |
| `scene-map.tsv` | `scene` → `scene_path` → `level_file` mapping (built from `globalgamemanagers.BuildSettings`) |

## Architecture

Two layers, mirroring (but inverting the cost profile of) `fsm-export/`:

1. **Index** (`scene-objects.tsv`) — committed, ~MB-scale, answers most questions on its own:
   - "what's in scene X" → grep the scene column
   - "where is GameObject X" → row already has world position
   - "find all damage triggers" → filter on `collider_type` + `is_trigger` etc.

2. **On-demand dump** (`../scripts/dump_gameobject.py`) — runs against the
   local Hollow Knight install (`D:/SteamLibrary/steamapps/common/Hollow Knight/hollow_knight_Data`)
   to emit full per-GO markdown with all component fields, child tree, and
   linked FSMs. Output goes to `../scene-cache/<scene>/<go_pathid>__<name>.md`.

The skill repo only stores the index; full GO detail is rebuilt when needed.

## Schema (`scene-objects.tsv`)

| Column | Meaning |
| --- | --- |
| `scene` | Scene basename, e.g. `Abyss_01` (no `.unity` suffix) |
| `go_path` | Full hierarchy path, e.g. `_Scenery/cd_wall_02` |
| `go_pathid` | Unity SerializedFile PathId for this GameObject (unique within scene) |
| `level_file` | `levelN` file under `hollow_knight_Data/` containing this GO |
| `parent_go_pathid` | Parent GameObject PathId (empty for scene roots) |
| `pos_x` / `pos_y` / `pos_z` | World-space position (transform tree accumulated, additive only — HK is 2D) |
| `scale_x` / `scale_y` | Local scale (Z omitted; HK uses negative X for sprite flip) |
| `collider_type` | One of `box2d`, `circle2d`, `polygon2d`, `edge2d`, `capsule2d`, `tilemap2d`, `composite2d`, or empty |
| `renderer_type` | One of `sprite`, `mesh`, `particle`, `tilemap`, `skinned_mesh`, `line`, `trail`, or empty |
| `fsm_count` | Number of PlayMakerFSM components attached, joined exactly via GO PathId from `fsm-export/` markdowns |
| `child_count` | Direct child count in the Transform hierarchy |
| `active` | `1` / `0` from `m_IsActive` |

`fsm_count` is **authoritative**: counts come from parsing `| GameObject PathId | N |`
out of every `fsm-export/.../*.md` for that scene, then matching by PathId.
Name-based joins were tried first and over-stamped (many GOs share short
names like `White Flash`).

## Building

```bash
python scripts/rebuild_scene_index.py --scene Abyss_01     # one scene
python scripts/rebuild_scene_index.py --level 327          # by level index
python scripts/rebuild_scene_index.py --all                # full rebuild (~500 scenes)
```

Requires `pip install UnityPy` (tested with UnityPy 1.25 on Python 3.13).

A full build takes minutes and produces a few MB. Re-run only when the HK
install changes (HK is feature-frozen pre-Silksong, so this is rare).

## Querying examples

```bash
# Cheap: index-only

# What GOs in Abyss_01 have a polygon collider?
awk -F'\t' '$1=="Abyss_01" && $11=="polygon2d"' scene-index/scene-objects.tsv

# Where is "Hollow_Shade Marker (1)"?
awk -F'\t' '$1=="Abyss_01" && $2 ~ /Hollow_Shade Marker \(1\)/' scene-index/scene-objects.tsv

# Heavy: full GO dump

python scripts/dump_gameobject.py --scene Abyss_01 --pathid 924 --children 2
```

## Limitations

- **Only ships GOs present in the level file.** Anything `Instantiate`'d at
  runtime (projectiles, spawned enemies, scene-load hooks) won't appear.
  For runtime introspection use **UnityExplorer** mod in-game.
- **World position is additive.** HK is 2D and rotations are almost always
  identity for layout-relevant objects, so the position is good enough for
  spatial queries. Don't use it for skinned characters with non-trivial
  rotations.
- **MonoBehaviour fields aren't serialized into the index** — only their
  presence/count via FSM join. Use `dump_gameobject.py` for component
  details, or the `fsm-export/` data for FSM internals.
- **Cross-file MonoScript class names don't resolve in level-only envs**,
  which is why FSM detection routes through `fsm-export/` rather than
  reading `m_Script.m_ClassName` directly.
