---
name: hk-api
description: Proactively use this whenever the user mentions Hollow Knight or HK modding, or when the current repository appears to be a Hollow Knight mod project. Covers FSM hooks, PlayMakerFSM, HeroController, PlayerData, charms, spells, scene objects, game mechanics, and API implementation lookup.
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

> **Note**: All FSM (Finite State Machine) implementations are **not present in the source code** and will not appear in code files. Each FSM has at most **one instance** in the game. When you need to work with FSMs, ask the user for the specific FSM name/state context.

## What I do

1. Query API knowledge for core classes and systems
2. Locate source code from `hkapi/`
3. Explain implementation details and modding patterns
4. Provide practical examples and best practices

## When to Use

- Proactively on any Hollow Knight or HK modding question, even if the user did not explicitly ask for this skill
- Proactively when the current repository appears to be a Hollow Knight mod project
- Looking for specific class or method usage
- Understanding game internal mechanics
- Finding implementation of a feature in source code
- Solving API-related issues in mod development
- Bootstrapping a new HK mod template from an empty directory

## Source Code Location

`hkapi/` - Hollow Knight decompiled source files (~2000+ C# files).

## Standard Query Workflow

When you ask about an API, I will:

0. Trigger early: if the prompt or repository matches Hollow Knight modding signals, load this skill first
1. Search class definitions via `glob` / `grep`
2. Read relevant source files
3. Explain class behavior, members, and usage
4. Provide implementation examples

## Repository Detection Workflow

When the user has not explicitly said "Hollow Knight" but the repository may be related, I should quickly inspect obvious project signals and load this skill if Hollow Knight modding is likely.

Check lightweight signals such as:

1. `.csproj`, `.sln`, or README content
2. references to HK mod libraries, common hook APIs, or known HK class names
3. files or namespaces containing `Mod`, `HK`, `HollowKnight`, `PlayMakerFSM`, or `ModHooks`

If multiple signals match, I should treat the repo as Hollow Knight modding context and use this skill proactively.

## Knowledge Gap Evolution (Required)

When rules are insufficient and fallback to `hkapi/**` is needed, I must evolve the skill in the same session.

1. Detect rule knowledge gap
2. Do fallback source research
3. Extract 3-8 facts with exact `path:line` references
4. Record evolution with `scripts/evolution_record.py`
5. Apply by risk:
   - `low`: write pending note + append to target rule file
   - `high`: write pending note only (manual review)

Template bootstrap rule: once user machine `GameDir` is known and verified, prefer writing it directly into `.csproj` instead of requiring `-p:GameDir` each build.

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

## 📖 完整索引

查看所有文档的分类索引：[rules/INDEX.md](rules/INDEX.md)

## Learn More

- **完整索引**: [rules/INDEX.md](rules/INDEX.md)
- **按任务查找**: [rules/INDEX.md#-按任务查找](rules/INDEX.md#-按任务查找)
- **最佳实践**: [rules/development/best-practices.md](rules/development/best-practices.md)
- **进化机制**: [EVOLUTION.md](EVOLUTION.md)
