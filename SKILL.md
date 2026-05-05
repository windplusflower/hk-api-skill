---
name: hk-api
description: Proactively use this whenever the user mentions Hollow Knight or HK modding, or when the current repository appears to be a Hollow Knight mod project. Covers FSM hooks, PlayMakerFSM, HeroController, PlayerData, charms, spells, scene objects, game mechanics, API implementation lookup, and custom C# state machine patterns including RingLib.
compatibility: opencode
---

# Hollow Knight API Guide

## 快速开始

**新手？** 从 [rules/INDEX.md](rules/INDEX.md) 开始。

**要查 FSM？** 先看 [fsm-index/README.md](fsm-index/README.md) 和 [rules/core/fsm-query-guide.md](rules/core/fsm-query-guide.md)。

**有具体 Boss / 场景？** 先看 [fsm-index/fsm-manifest.tsv](fsm-index/fsm-manifest.tsv)，再按需打开 [fsm-index/boss-shortcuts.md](fsm-index/boss-shortcuts.md) 和 [fsm-index/scene-summary.md](fsm-index/scene-summary.md)。

**要做自定义状态机？** 先看 [rules/libraries/ringlib.md](rules/libraries/ringlib.md) 和 [rules/libraries/ringlib-src-index.md](rules/libraries/ringlib-src-index.md)。

## Overview

This skill provides Hollow Knight API knowledge, source-code lookup, local FSM dataset lookup, and custom C# state machine guidance for modding tasks.

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

When triggered, load this skill before answering so you can use the rules, FSM dataset, and `hkapi/` source effectively.

## What This Skill Covers

1. Query API knowledge for `HeroController`, `HealthManager`, `PlayMakerFSM`, `PlayerData` and related classes.
2. Locate source code inside `hkapi/`.
3. Locate FSM instances, states, actions, transitions, and events from the bundled `fsm-export/` dataset.
4. Explain how source code and FSM behavior connect in actual modding work.
5. Provide implementation patterns and caveats for HK mods.
6. Recommend when to keep using PlayMaker FSM hooks versus when to build a custom C# state machine with `RingLib`.

## When to Use

- Proactively on any Hollow Knight or HK modding question, even if the user did not explicitly ask for this skill
- Proactively when the current repository appears to be a Hollow Knight mod project
- Looking for a specific HK class, method, or field
- Understanding game internal mechanics
- Finding implementation of a feature in source code
- Locating a concrete PlayMaker FSM instance in a scene
- Finding states, actions, events, or transitions for a boss / NPC / UI flow
- Solving API-related or FSM-related issues in mod development
- Bootstrapping a new HK mod template from an empty directory
- Designing a Boss / enemy / projectile behavior system that is too large or awkward for ad-hoc FSM patching

## Custom State Machine Selection

When a Hollow Knight modding task involves behavior orchestration, choose the approach deliberately instead of defaulting to one tool.

Prefer existing PlayMaker FSM modification when:

- the target behavior already exists in a game FSM and only needs a small patch
- the task is a state edit, transition redirect, inserted action, or variable tweak
- the object lifecycle is still mostly owned by the original game object and FSM

Prefer a custom C# state machine with `RingLib` when:

- creating a brand new Boss, enemy, projectile controller, or multi-phase encounter flow
- the behavior needs many explicit states, waits, chained sequences, or interrupt rules
- using plain `Update()` / `switch` code would become large and hard to maintain
- multiple child routines or staged attacks need to be expressed in readable coroutine form
- the mod is effectively taking control away from the original FSM instead of lightly patching it

`RingLib` should be treated as the default in-skill recommendation for custom C# state machines in HK mods, but it remains an optional source dependency rather than a mandatory template dependency.

For implementation details, see:

- [rules/libraries/ringlib.md](rules/libraries/ringlib.md)
- [rules/libraries/ringlib-src-index.md](rules/libraries/ringlib-src-index.md)

## Important: FSM Lookup Workflow

PlayMaker FSM 的大部分行为图并不直接以易检索的 C# 逻辑形式存在于 `hkapi/` 源码中，所以 FSM 查询不能只靠搜代码。

本技能现在自带一套本地 FSM 导出数据：

- `fsm-export/`: 24701 个 FSM Markdown 文件，按 `group/scene/file.md` 组织，`scene` 目前采用导出时的 Unity scene 文件名，例如 `Abyss_01.unity`、`GG_Vengefly.unity`
- `fsm-index/fsm-manifest.tsv`: 24701 条索引，字段为 `group, scene, gameobject_segment, fsm_name, fsm_id, relative_path, source_asset, content_hash`
- `fsm-index/scene-summary.md`: 当前导出的 scene 汇总入口
- `fsm-index/boss-shortcuts.md`: 当前导出的 Boss / 关键战斗场景快速入口

处理 FSM 任务时，先查这套本地索引和导出，再决定是否回到源码或运行时 Hook。

同名 FSM 很常见，必须联合 `scene + gameobject_segment + fsm_id` 判断；需要落地修改时，再结合 Hook、日志和运行时验证。

## Data Locations

- `hkapi/`: Hollow Knight decompiled source files
- `fsm-export/`: 24701 PlayMaker FSM Markdown files, organized by `group/scene/`
- `fsm-index/`: FSM navigation layer (manifest, scene summary, boss shortcuts)

## Standard Query Workflow

### API / Source Queries

0. **Trigger early**: if the prompt or repository matches Hollow Knight modding signals, load this skill first.
1. Search class or method definitions inside `hkapi/`.
2. Read the relevant `.cs` files.
3. Explain members, call paths, and modding implications.

### FSM Queries

1. If the user knows the boss or encounter, search [fsm-index/fsm-manifest.tsv](fsm-index/fsm-manifest.tsv) first, then use [fsm-index/boss-shortcuts.md](fsm-index/boss-shortcuts.md) as a convenience view.
2. If the user knows the scene, first search [fsm-index/fsm-manifest.tsv](fsm-index/fsm-manifest.tsv) for the scene name. Current scenes usually use Unity export names such as `Abyss_01.unity` or `GG_Vengefly.unity`.
3. If the user only knows a GameObject or FSM name, search [fsm-index/fsm-manifest.tsv](fsm-index/fsm-manifest.tsv).
4. Open the matching `fsm-export/<group>/<scene>/<file>.md` file for full details.
5. Use `fsm_id` and `relative_path` to disambiguate duplicate `Control` / `FSM` / `damages_hero` style entries.

## Logging Rules

When working on Hollow Knight mods, treat logging as part of the API contract:

1. **Code logging**: prefer Modding API logging interfaces such as `Mod.Log(...)`, `LogDebug(...)`, `LogWarn(...)`, `LogError(...)`, or `Modding.Logger.*`.
2. **Do not default to Unity logging**: avoid using `UnityEngine.Debug.Log*` as the main channel for mod business/debug logs unless the task is specifically about Unity engine-level diagnostics.
3. **Log file priority**: when investigating a mod issue, check `ModLog.txt` first, then use `Player.log` only as a supplemental Unity/game trace.
4. **Common ModLog location**: the usual file is `<persistentDataPath>/ModLog.txt`. On Windows this commonly resolves under `AppData/LocalLow/Team Cherry/Hollow Knight/ModLog.txt`.

## Build & Dependency Rules

When bootstrapping a new Hollow Knight mod project:

1. Prefer real DLLs already present on the user's machine.
2. On a machine where HK Modding API is already installed into the game, treat `Managed/Assembly-CSharp.dll` as the modded assembly that also provides the Modding API surface.
3. Do not assume there is a separate `Modding.dll` unless the user or repository proves that layout.
4. Keep machine-specific paths in a local untracked config file such as `LocalBuildProperties.props`.
5. Normal builds should auto-install the mod output and generated zip into `Managed/Mods/<ModName>`.

## Gameplay Input Rules

When a Hollow Knight modding task depends on current gameplay input:

1. Prefer `InputHandler.Instance?.inputActions` / `HeroActions`.
2. Do not default to `UnityEngine.Input.GetAxisRaw()` for gameplay direction checks such as spells, attacks, or nail arts.
3. If an injected FSM action runs before `ListenForUp` / `ListenForDown` / similar listen actions, do not trust FSM booleans like `Pressed Up`; read current `inputActions` directly.

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

## Rule Categories

详细规则文档已按类别组织。

### Core（核心参考）

| 文档 | 用途 |
|------|------|
| [Core Classes](rules/core/core-classes.md) | HeroController, PlayerData, HealthManager |
| [FSM Reference](rules/core/fsm-reference.md) | FSM 数据集、常见命名、运行时操作 |
| [FSM Query Guide](rules/core/fsm-query-guide.md) | 按 Boss / 场景 / 名称查 FSM 的具体流程 |
| [Item IDs](rules/core/item-ids.md) | 护符 ID、PlayerData 字段 |
| [Preload Names](rules/core/preload-names.md) | 预加载物品和场景对象 |

### Systems（游戏系统）

| 文档 | 用途 |
|------|------|
| [Combat System](rules/systems/combat-system.md) | 伤害计算、攻击检测 |
| [Spell System](rules/systems/spell-system.md) | 法术拦截和修改 |
| [Nail Arts](rules/systems/nail-arts.md) | 骨钉技拦截 |
| [Audio System](rules/systems/audio-system.md) | 音效和音频管理 |
| [Game Modification Patterns](rules/systems/game-modification-patterns.md) | 商店、Boss、敌人、场景等系统修改模式 |

### Development（开发指南）

| 文档 | 用途 |
|------|------|
| [Common Hooks](rules/development/common-hooks.md) | 常用 Hook 模式 |
| [Code Patterns](rules/development/code-patterns.md) | 常见代码模式 |
| [Resource Management](rules/development/resources.md) | 资源加载和管理 |
| [Best Practices](rules/development/best-practices.md) | 最佳实践和技巧 |
| [Template Bootstrap](rules/development/mod-template-bootstrap.md) | 从空目录创建 HK Mod 模板 |

### Libraries（第三方库）

| 文档 | 用途 |
|------|------|
| [RingLib](rules/libraries/ringlib.md) | 自定义 C# 协程状态机的选型、接入方式与 HK mod 用法 |
| [RingLib Source Index](rules/libraries/ringlib-src-index.md) | `RingLib` 内置源码索引 |
| [Satchel](rules/libraries/satchel.md) | `Satchel` 工具库 |
| [Satchel Source Index](rules/libraries/satchel-src-index.md) | `Satchel` 源代码索引 |

Template bootstrap rule: for new mod projects, keep machine-specific DLL and game paths in a local untracked config file such as `LocalBuildProperties.props`, prefer resolving references against real DLLs already present on the user's machine, ask when any required DLL cannot be found, and make normal builds auto-install the mod output plus zip into `Managed/Mods/<ModName>`.

## Key Classes Quick Reference

| Class | Purpose | Key Members |
|-------|---------|-------------|
| HeroController | Player control | `instance`, `transform`, `AddMPCharge()` |
| PlayerData | Player data | `GetBool()`, `GetInt()`, `nailDamage` |
| HealthManager | Enemy health | `hp`, `Hit()`, `ApplyExtraDamage()` |
| DamageHero | Damage player | `damageDealt` |
| PlayMakerFSM | State machine | `SendEvent()`, `ChangeState()` |
| HitInstance | Damage instance | `DamageDealt`, `AttackType` |

## Error Handling & Troubleshooting

### 1) 未找到目标类/方法

- 可能原因：类名或方法名拼写错误、版本差异、目标逻辑主要存在于 FSM 而不是 C#。
- 回退策略：先搜索相似名称。
- 回退策略：如果是流程行为问题，切换到 `fsm-index/` 和 `fsm-export/` 查询。
- 回退策略：查阅 `rules/development/` 下的 Hook 与代码模式文档，寻找替代拦截点。

### 2) FSM 相关限制

- FSM 图本身优先以本地导出数据为准，而不是单纯依赖 `hkapi/` 文本搜索。
- 同名 FSM 很常见，必须联合 `scene + gameobject_segment + fsm_id` 判断。
- 导出文件能覆盖状态、动作、变量、转移、事件，但运行时动态注入或运行期改写仍需结合 Hook / 日志验证。

### 3) 版本漂移处理

- 不同 HKAPI / 游戏版本可能存在 API 变动。
- 输出结论时建议标注置信度：**确定** 表示已在当前源码或导出文件中明确定位并验证。
- 输出结论时建议标注置信度：**可能** 表示存在高相似实现但缺少运行时确认。
- 输出结论时建议标注置信度：**需确认** 表示仅有推断，需用户提供版本或日志。

### 4) 失败排查入口

- 总索引：[`rules/INDEX.md`](rules/INDEX.md)
- FSM 索引入口：[`fsm-index/README.md`](fsm-index/README.md)
- 按 Boss 查：[`fsm-index/fsm-manifest.tsv`](fsm-index/fsm-manifest.tsv) 与 [`fsm-index/boss-shortcuts.md`](fsm-index/boss-shortcuts.md)
- 按 scene 查：[`fsm-index/fsm-manifest.tsv`](fsm-index/fsm-manifest.tsv) 与 [`fsm-index/scene-summary.md`](fsm-index/scene-summary.md)
- 按名称查：[`rules/core/fsm-query-guide.md`](rules/core/fsm-query-guide.md)

## Learn More

- **完整索引**: [rules/INDEX.md](rules/INDEX.md)
- **按任务查找**: [rules/INDEX.md#-按任务查找](rules/INDEX.md#-按任务查找)
- **最佳实践**: [rules/development/best-practices.md](rules/development/best-practices.md)
- [fsm-index/README.md](fsm-index/README.md) - FSM 数据集入口
- [rules/core/fsm-reference.md](rules/core/fsm-reference.md) - FSM 数据集概况
- [rules/core/fsm-query-guide.md](rules/core/fsm-query-guide.md) - FSM 查询流程
- **进化机制**: [EVOLUTION.md](EVOLUTION.md)
