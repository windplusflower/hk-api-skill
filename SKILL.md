---
name: hk-api
description: Proactively use this whenever the user mentions Hollow Knight or HK modding, or when the current repository appears to be a Hollow Knight mod project. Covers FSM hooks, PlayMakerFSM, HeroController, PlayerData, charms, spells, scene objects, game mechanics, and API implementation lookup.
compatibility: opencode
---

# Hollow Knight API Guide

## 🚀 快速开始

**新手？** 从 [rules/INDEX.md](rules/INDEX.md) 开始，找到你需要的文档类别。

**有具体任务？** 查看 [rules/INDEX.md](rules/INDEX.md#-按任务查找) 的任务导向导航。

---

## Overview

This provides API knowledge for Hollow Knight modding, locating source code, and explaining game mechanics.

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

When triggered, load this skill before answering so you can use the rules and `hkapi/` source effectively.

## Important: FSM Implementation

> **Note**: All FSM (Finite State Machine) implementations are **not present in the source code** and will not appear in any code files. Each FSM has at most **one instance** in the entire game. When you need to understand or work with FSMs, **you must ask the user** for specific FSM details rather than searching through code files.

## What I do

1. **Query API Knowledge**: Find and explain HeroController, HealthManager, PlayMakerFSM, and other core classes
2. **Locate Source Code**: Search in the included `hkapi/` directory
3. **Explain Implementations**: Read and interpret game internal logic
4. **Provide Best Practices**: Common patterns and caveats in HK modding

## When to Use

- Proactively on any Hollow Knight or HK modding question, even if the user did not explicitly ask for this skill
- Proactively when the current repository appears to be a Hollow Knight mod project
- Looking for specific HK class or method usage
- Understanding game internal mechanics
- Finding implementation of a feature in source code
- Solving API-related issues in mod development
- Bootstrapping a new HK mod template from an empty directory

## Source Code Location

`hkapi/` - Contains Hollow Knight decompiled source files (~2000+ .cs files).

## Standard Query Workflow

When you ask about an API, I will:

0. **Trigger early**: if the prompt or repository matches Hollow Knight modding signals, load this skill first
1. **Search for class definition** using `glob` or `grep` in the source directory
2. **Read source code** using `read` tool on found .cs files
3. **Analyze and explain** the class functionality, members, and usage
4. **Provide examples** for mod development

## Logging Rules

When working on Hollow Knight mods, treat logging as part of the API contract:

1. **Code logging**: prefer Modding API logging interfaces such as `Mod.Log(...)`, `LogDebug(...)`, `LogWarn(...)`, `LogError(...)`, or `Modding.Logger.*`.
2. **Do not default to Unity logging**: avoid using `UnityEngine.Debug.Log*` as the main channel for mod business/debug logs unless the task is specifically about Unity engine-level diagnostics.
3. **Log file priority**: when investigating a mod issue, check `ModLog.txt` first, then use `Player.log` only as a supplemental Unity/game trace.
4. **Common ModLog location**: `Application.persistentDataPath` maps on this machine to `C:\Users\33361\AppData\LocalLow\Team Cherry\Hollow Knight`, so the usual file is `C:\Users\33361\AppData\LocalLow\Team Cherry\Hollow Knight\ModLog.txt`.

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
python scripts/evolution_record.py \
  --question "How does HealthManager damage flow work?" \
  --target rules/core/core-classes.md \
  --fact "HealthManager.ApplyExtraDamage applies damage modifiers before hp reduction." \
  --fact "On death, HealthManager sends death events consumed by multiple systems." \
  --source hkapi/HealthManager.cs:212 \
  --source hkapi/HealthManager.cs:398 \
  --risk low
```

The command creates an entry in `rules/_pending/` and logs to `EVOLUTION_LOG.md`. Low-risk entries are auto-appended to the target rule file.

## 📚 Rule Categories

详细规则文档已按类别组织：

### 🔰 Core（核心参考）

基础 API 和数据结构。

| 文档 | 用途 |
|------|------|
| [Core Classes](rules/core/core-classes.md) | HeroController, PlayerData, HealthManager |
| [FSM Reference](rules/core/fsm-reference.md) | FSM 列表、状态、事件 |
| [Item IDs](rules/core/item-ids.md) | 护符 ID、PlayerData 字段 |
| [Preload Names](rules/core/preload-names.md) | 预加载物品和场景对象 |

### ⚔️ Systems（游戏系统）

特定游戏系统的修改方法。

| 文档 | 用途 |
|------|------|
| [Combat System](rules/systems/combat-system.md) | 伤害计算、攻击检测 |
| [Spell System](rules/systems/spell-system.md) | 法术拦截和修改 |
| [Nail Arts](rules/systems/nail-arts.md) | 骨钉技拦截 |
| [Audio System](rules/systems/audio-system.md) | 音效和音频管理 |

### 🛠️ Development（开发指南）

开发工具和最佳实践。

| 文档 | 用途 |
|------|------|
| [Common Hooks](rules/development/common-hooks.md) | 常用 Hook 模式 |
| [Code Patterns](rules/development/code-patterns.md) | 常见代码模式 |
| [Resource Management](rules/development/resources.md) | 资源加载和管理 |
| [Best Practices](rules/development/best-practices.md) | 最佳实践和技巧 |
| [Template Bootstrap](rules/development/mod-template-bootstrap.md) | 从空目录创建 HK Mod 模板 |

Template bootstrap rule: once user machine `GameDir` is known and verified, prefer writing it directly into `.csproj` instead of requiring `-p:GameDir` each build.

## 📖 完整索引

查看所有文档的分类索引：[rules/INDEX.md](rules/INDEX.md)

## Key Classes Quick Reference

| Class | Purpose | Key Members |
|-------|---------|-------------|
| HeroController | Player control | instance, transform, AddMPCharge() |
| PlayerData | Player data | GetBool(), GetInt(), nailDamage |
| HealthManager | Enemy health | hp, Hit(), ApplyExtraDamage() |
| DamageHero | Damage player | damageDealt |
| PlayMakerFSM | State machine | SendEvent(), ChangeState() |
| HitInstance | Damage instance | DamageDealt, AttackType |

## Learn More

- **完整索引**: [rules/INDEX.md](rules/INDEX.md)
- **按任务查找**: [rules/INDEX.md#-按任务查找](rules/INDEX.md#-按任务查找)
- **最佳实践**: [rules/development/best-practices.md](rules/development/best-practices.md)
- **进化机制**: [EVOLUTION.md](EVOLUTION.md)
