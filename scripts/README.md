# Scripts

Maintenance and query tooling for the `hk-api` skill. All scripts use stdlib + `UnityPy`
where noted; install dependencies once with `pip install UnityPy` (tested on UnityPy 1.25,
Python 3.13).

## Tools

| Script | Purpose | Reads | Writes |
| --- | --- | --- | --- |
| [`evolution_record.py`](evolution_record.py) | Log a fallback-to-source learning event and append a source-backed note into the target rule doc | n/a (CLI args) | `rules/evolution-notes/`, `rules/_pending/`, `EVOLUTION_LOG.md`, target rule file |
| [`rebuild_scene_index.py`](rebuild_scene_index.py) | Build `scene-index/scene-objects.tsv` (medium-tier index of every static GameObject) and `scene-index/scene-map.tsv` (scene→levelN mapping) | local Hollow Knight install (`hollow_knight_Data/levelN`, `globalgamemanagers`); `fsm-export/` for FSM PathId join | `scene-index/scene-objects.tsv`, `scene-index/scene-map.tsv` |
| [`dump_gameobject.py`](dump_gameobject.py) | Emit a Markdown report for one GameObject: components, collider sizes, attached FSMs, child tree | `scene-index/scene-map.tsv`, local `levelN`, `fsm-export/` | `scene-cache/<scene>/<pathid>__<name>.md` |

## Common usage

### Record an evolution note (after fallback to `hkapi/`)

```bash
python scripts/evolution_record.py \
  --question "How does HealthManager damage flow work?" \
  --target rules/core/core-classes.md \
  --fact "HealthManager.ApplyExtraDamage applies damage modifiers before hp reduction." \
  --source hkapi/HealthManager.cs:212 \
  --risk low
```

### Rebuild the scene index

```bash
python scripts/rebuild_scene_index.py --scene Abyss_01      # one scene
python scripts/rebuild_scene_index.py --level 327           # by BuildSettings index
python scripts/rebuild_scene_index.py --all                 # full build (~501 scenes, minutes)
```

### Dump one GameObject

```bash
python scripts/dump_gameobject.py --scene Abyss_01 --pathid 924
python scripts/dump_gameobject.py --scene Abyss_01 --name "Inverse Remasker"
python scripts/dump_gameobject.py --scene Abyss_01 --pathid 924 --children 2 --stdout
```

`--pathid` comes from `scene-index/scene-objects.tsv`. `--name` only works when unique
within the scene; otherwise pass `--pathid` to disambiguate.

## Conventions

- Scripts live at the skill root's `scripts/` directory and resolve other skill paths via
  `Path(__file__).resolve().parent.parent`. Don't move them without updating those paths.
- Throwaway probes are named `_probe_*.py` and are gitignored.
- The local Hollow Knight install path is hard-coded to
  `D:/SteamLibrary/steamapps/common/Hollow Knight/hollow_knight_Data` (this machine).
  Change `HK_DATA` at the top of each script if porting to another machine.
