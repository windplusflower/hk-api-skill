---
name: hk-api
description: Query Hollow Knight API knowledge and source code locations to assist with mod development. Use when working with Hollow Knight modding, FSM hooks, game mechanics, or finding API implementations.
---

# Hollow Knight API Guide

## 🚀 快速开始

**新手？** 从 [rules/INDEX.md](rules/INDEX.md) 开始，找到你需要的文档类别。

**有具体任务？** 查看 [rules/INDEX.md](rules/INDEX.md#-按任务查找) 的任务导向导航。

---

## Overview

This provides API knowledge for Hollow Knight modding, locating source code, and explaining game mechanics.

## Important: FSM Implementation

> **Note**: All FSM (Finite State Machine) implementations are **not present in the source code** and will not appear in any code files. Each FSM has at most **one instance** in the entire game. When you need to understand or work with FSMs, **you must ask the user** for specific FSM details rather than searching through code files.

## What I do

1. **Query API Knowledge**: Find and explain HeroController, HealthManager, PlayMakerFSM, and other core classes
2. **Locate Source Code**: Search in the included `hkapi/Assembly-CSharp/` directory
3. **Explain Implementations**: Read and interpret game internal logic
4. **Provide Best Practices**: Common patterns and caveats in HK modding

## When to Use

- Looking for specific HK class or method usage
- Understanding game internal mechanics
- Finding implementation of a feature in source code
- Solving API-related issues in mod development

## Source Code Location

`hkapi/Assembly-CSharp/` - Contains all Hollow Knight game source code (~2000+ .cs files).

## Standard Query Workflow

When you ask about an API, I will:

1. **Search for class definition** using `glob` or `grep` in the source directory
2. **Read source code** using `read` tool on found .cs files
3. **Analyze and explain** the class functionality, members, and usage
4. **Provide examples** for mod development

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
