---
name: hk-api
description: Proactively use this for Hollow Knight modding. Always load the Modding Spec first, then progressively retrieve only the needed API, FSM, system, and implementation knowledge.
compatibility: opencode
---

# Hollow Knight Modding Guide

## Loading Contract

This skill uses a two-layer architecture:

1. **Modding Spec**: always load in full
2. **Modding Knowledge**: read progressively and only when needed

Default mandatory read on trigger:

- [rules/modding-spec.md](rules/modding-spec.md)

Architecture and maintenance notes:

- [rules/ARCHITECTURE.md](rules/ARCHITECTURE.md)

Do not pre-read large knowledge docs by default. Use [rules/INDEX.md](rules/INDEX.md) as the routing index for task-specific lookup.

## Overview

This skill provides Hollow Knight modding conventions plus on-demand lookup for API, FSM, systems, and implementation details.

## Proactive Trigger Rules

Load this skill immediately when either of these is true:

1. The user asks about Hollow Knight, HK, or Hollow Knight modding.
2. The current workspace looks like a Hollow Knight mod repository.

Treat these as strong triggers:

- Hollow Knight, HK, 空洞骑士, 空洞骑士mod, HK mod, Modding API
- FSM, PlayMakerFSM, state machine, hook, detour, IL hook, On., ModHooks
- HeroController, PlayerData, HealthManager, GameManager, HeroAnimationController
- charms, spells, nail arts, scenes, preload names, enemy logic, bosses
- Satchel, HKMirror, ItemChanger, ModCommon, Benchwarp, WeaverCore

Treat the repository as a Hollow Knight mod project when you notice signals such as:

- C# mod structure with references to HollowKnight, Modding, or HK libraries
- `.csproj` files that reference common HK mod assemblies or a `GameDir` build property
- code mentioning `Mod`, `Initialize`, `GetVersion`, `ModHooks`, `On.`, `IL.`, or `PlayMakerFSM`
- folders or docs mentioning hk, hollow knight, charms, spells, enemies, scenes, or FSMs

When triggered, load this skill before answering so you can apply the always-loaded spec first, then progressively consult only the minimum needed knowledge sources.

## What This Skill Covers

1. Apply the always-loaded Hollow Knight modding spec.
2. Route questions to the correct knowledge source.
3. Query API knowledge for `HeroController`, `HealthManager`, `PlayMakerFSM`, `PlayerData` and related classes.
4. Locate source code inside `hkapi/`.
5. Locate FSM instances, states, actions, transitions, and events from the bundled `fsm-export/` dataset.
6. Look up scene GameObjects (position, scale, collider type, FSM count, hierarchy) via the `scene-index/` static index, with on-demand component dumps via `scripts/dump_gameobject.py`.
7. Recommend when to keep using PlayMaker FSM hooks versus when to build a custom C# state machine with `RingLib`.

## When to Use

- Proactively on any Hollow Knight or HK modding question, even if the user did not explicitly ask for this skill
- Proactively when the current repository appears to be a Hollow Knight mod project
- Looking for a specific HK class, method, or field
- Understanding game internal mechanics
- Finding implementation of a feature in source code
- Locating a concrete PlayMaker FSM instance in a scene
- Finding states, actions, events, or transitions for a boss / NPC / UI flow
- Listing GameObjects in a scene, or looking up a GO's world position, collider type, hierarchy path, or attached FSMs
- Solving API-related or FSM-related issues in mod development
- Bootstrapping a new HK mod template from an empty directory
- Designing a Boss / enemy / projectile behavior system that is too large or awkward for ad-hoc FSM patching

## Routing Rules

Use the smallest relevant knowledge source for the task:

- General index or newcomer routing: [rules/INDEX.md](rules/INDEX.md)
- API / class / call-path questions: `rules/core/**`, then `hkapi/**` if needed
- FSM questions: [fsm-index/README.md](fsm-index/README.md), [rules/core/fsm-query-guide.md](rules/core/fsm-query-guide.md), then `fsm-export/**`
- Known Boss or scene lookup: [fsm-index/fsm-manifest.tsv](fsm-index/fsm-manifest.tsv), [fsm-index/boss-shortcuts.md](fsm-index/boss-shortcuts.md), [fsm-index/scene-summary.md](fsm-index/scene-summary.md)
- Scene GameObject / geometry / collider questions: [scene-index/README.md](scene-index/README.md), then `scene-index/scene-objects.tsv` for index-only queries, or `scripts/dump_gameobject.py` for full per-GO detail
- Custom state machine work: [rules/libraries/ringlib.md](rules/libraries/ringlib.md), [rules/libraries/ringlib-src-index.md](rules/libraries/ringlib-src-index.md)

## Data Locations

- `rules/modding-spec.md`: always-loaded spec
- `rules/INDEX.md`: task routing index
- `hkapi/`: decompiled source files
- `fsm-index/`: FSM navigation layer
- `fsm-export/`: full PlayMaker FSM dataset
- `scene-index/`: per-scene GameObject index (lazy-dump architecture; pairs with `scripts/dump_gameobject.py`)
- `scene-cache/`: on-demand single-GO dumps written by `scripts/dump_gameobject.py` (regenerable, gitignored)
- `scripts/`: maintenance and query tools (evolution_record, rebuild_scene_index, dump_gameobject)
- `data/gameDic.json`: HK in-game text dictionary (Chinese localization keys)
- `satchel-src/`: Satchel library source mirror (referenced from `rules/libraries/satchel-src-index.md`)
- `third_party/`: vendored libraries (e.g. `RingLib`)

## Repository Detection Workflow

When the user has not explicitly said "Hollow Knight" but the repository may be related, I should quickly inspect obvious project signals and load this skill if Hollow Knight modding is likely.

Check lightweight signals such as:

1. `.csproj`, `.sln`, or README content
2. references to HK mod libraries, common hook APIs, or known HK class names
3. files or namespaces containing `Mod`, `HK`, `HollowKnight`, `PlayMakerFSM`, or `ModHooks`

If multiple signals match, I should treat the repo as Hollow Knight modding context and use this skill proactively.

## Knowledge Gap Evolution (Required)

When a question cannot be answered from `rules/**` and I need to fallback to `hkapi/**`, I must update the skill knowledge in the same session.

1. **Detect gap**: confirm rules are missing critical details
2. **Fallback research**: read source code and answer the user
3. **Extract learned facts**: 3-8 concrete facts with exact source refs (`path:line`)
4. **Write evolution record** using `scripts/evolution_record.py`
5. **Apply by risk**:
   - `low`: write pending note and append directly into target rule doc
   - `high`: write pending note only, wait for user confirmation before applying

### Required Output Schema (during fallback)

- `question`: original question or intent
- `target_rule_file`: where the knowledge belongs (for example `rules/core/core-classes.md`)
- `learned_facts`: concise bullet facts
- `sources`: exact source locations (`hkapi/SomeClass.cs:123`)
- `risk`: `low` or `high`

### Record Command

```bash
python3 scripts/evolution_record.py \
  --question "How does HealthManager damage flow work?" \
  --target rules/core/core-classes.md \
  --fact "HealthManager.ApplyExtraDamage applies damage modifiers before hp reduction." \
  --fact "On death, HealthManager sends death events consumed by multiple systems." \
  --source hkapi/HealthManager.cs:212 \
  --source hkapi/HealthManager.cs:398 \
  --risk low
```

The command creates a source-backed note and logs to `EVOLUTION_LOG.md`. Low-risk entries go to `rules/evolution-notes/` and are auto-appended to the target rule file. High-risk entries stay in `rules/_pending/` until confirmed.

## Learn More

- [rules/INDEX.md](rules/INDEX.md)
- [rules/ARCHITECTURE.md](rules/ARCHITECTURE.md)
- [EVOLUTION.md](EVOLUTION.md)
