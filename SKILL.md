---
name: HK API
description: Hollow Knight API - 查询 HKAPI Mod 源码和文档
compatibility: all
user-invocable: true
disable-model-invocation: false
metadata.openclaw: {"skillKey":"hk-api","os":["linux","macos","windows"],"primaryEnv":"HOLLOW_KNIGHT_MOD","requires":{"bins":["grep","find"]},"install":{"type":"none"}}
---

# Hollow Knight API Guide

## 快速开始

**新手？** 从 [rules/INDEX.md](rules/INDEX.md) 开始。

**要查 FSM？** 先看 [fsm-index/README.md](fsm-index/README.md) 和 [rules/core/fsm-query-guide.md](rules/core/fsm-query-guide.md)。

**有具体 Boss / 场景？** 先看 [fsm-index/boss-shortcuts.md](fsm-index/boss-shortcuts.md) 和 [fsm-index/scene-summary.md](fsm-index/scene-summary.md)。

## Overview

This skill provides Hollow Knight API knowledge, source-code lookup, and local FSM dataset lookup for modding tasks.

## Important: FSM Lookup Workflow

PlayMaker FSM 的大部分行为图并不直接以易检索的 C# 逻辑形式存在于 `hkapi/` 源码中，所以 FSM 查询不能只靠搜代码。

本技能现在自带一套本地 FSM 导出数据：

- `fsm-export/`: 2743 个 FSM Markdown 文件，按 `group/scene/file.md` 组织
- `fsm-index/fsm-manifest.tsv`: 2743 条索引，字段为 `group, scene, gameobject_segment, fsm_name, fsm_id, relative_path`
- `fsm-index/scene-summary.md`: 161 个 scene 的汇总入口
- `fsm-index/boss-shortcuts.md`: Boss / 关键战斗场景快速入口

当任务涉及 FSM 时，应先查这套本地索引和导出，再决定是否回到源码或运行时 Hook。

## What I do

1. Query API knowledge for `HeroController`, `HealthManager`, `PlayMakerFSM`, `PlayerData` and related classes.
2. Locate source code inside `hkapi/`.
3. Locate FSM instances, states, actions, transitions, and events from the bundled `fsm-export/` dataset.
4. Explain how source code and FSM behavior connect in actual modding work.
5. Provide implementation patterns and caveats for HK mods.

## When to Use

- Looking for a specific HK class, method, or field
- Understanding game internal mechanics
- Locating a concrete PlayMaker FSM instance in a scene
- Finding states, actions, events, or transitions for a boss / NPC / UI flow
- Solving API-related or FSM-related issues in mod development

## Data Locations

- `hkapi/Assembly-CSharp/`: Hollow Knight decompiled source snapshot
- `fsm-export/`: Full local FSM markdown export
- `fsm-index/`: FSM navigation layer

## Standard Query Workflow

### API / Source Queries

1. Search class or method definitions inside `hkapi/`.
2. Read the relevant `.cs` files.
3. Explain members, call paths, and modding implications.

### FSM Queries

1. If the user knows the boss or encounter, start with [fsm-index/boss-shortcuts.md](fsm-index/boss-shortcuts.md).
2. If the user knows the scene, start with [fsm-index/scene-summary.md](fsm-index/scene-summary.md).
3. If the user only knows a GameObject or FSM name, search [fsm-index/fsm-manifest.tsv](fsm-index/fsm-manifest.tsv).
4. Open the matching `fsm-export/<group>/<scene>/<file>.md` file for full details.
5. Use `fsm_id` and `relative_path` to disambiguate duplicate `Control` / `FSM` / `damages_hero` style entries.

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
- 回退策略：
- 先搜索相似名称。
- 如果是流程行为问题，切换到 `fsm-index/` 和 `fsm-export/` 查询。
- 查阅 `rules/development/` 下的 Hook 与代码模式文档，寻找替代拦截点。

### 2) FSM 相关限制

- FSM 图本身优先以本地导出数据为准，而不是单纯依赖 `hkapi/` 文本搜索。
- 同名 FSM 很常见，必须联合 `scene + gameobject_segment + fsm_id` 判断。
- 导出文件能覆盖状态、动作、变量、转移、事件，但运行时动态注入或运行期改写仍需结合 Hook / 日志验证。

### 3) 版本漂移处理

- 不同 HKAPI / 游戏版本可能存在 API 变动。
- 输出结论时建议标注置信度：
- **确定**：已在当前源码或导出文件中明确定位并验证。
- **可能**：存在高相似实现但缺少运行时确认。
- **需确认**：仅有推断，需用户提供版本或日志。

### 4) 失败排查入口

- 总索引：[`rules/INDEX.md`](rules/INDEX.md)
- FSM 索引入口：[`fsm-index/README.md`](fsm-index/README.md)
- 按 Boss 查：[`fsm-index/boss-shortcuts.md`](fsm-index/boss-shortcuts.md)
- 按 scene 查：[`fsm-index/scene-summary.md`](fsm-index/scene-summary.md)
- 按名称查：[`rules/core/fsm-query-guide.md`](rules/core/fsm-query-guide.md)

## Learn More

- [rules/INDEX.md](rules/INDEX.md)
- [fsm-index/README.md](fsm-index/README.md)
- [rules/core/fsm-reference.md](rules/core/fsm-reference.md)
- [rules/core/fsm-query-guide.md](rules/core/fsm-query-guide.md)
