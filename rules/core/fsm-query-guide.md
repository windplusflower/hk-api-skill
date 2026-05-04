---
title: FSM Query Guide
impact: HIGH
impactDescription: Operational guide for locating concrete FSM files in the bundled dataset
tags: hk-api, fsm, query, manifest, boss
---

# FSM Query Guide

## 目的

本文档回答的是“怎么找到具体 FSM 文件”，不是“怎么改代码”。

当用户给出 Boss 名、scene 名、GameObject 名、FSM 名，或者只描述一个行为流程时，优先按本文流程查询本地 FSM 数据集。

## 先去哪看

| 用户已知信息 | 先看哪里 | 下一步 |
| --- | --- | --- |
| Boss / 战斗场景 | [../../fsm-index/fsm-manifest.tsv](../../fsm-index/fsm-manifest.tsv) | 再用 [../../fsm-index/boss-shortcuts.md](../../fsm-index/boss-shortcuts.md) 浏览候选 |
| Scene 名 | [../../fsm-index/fsm-manifest.tsv](../../fsm-index/fsm-manifest.tsv) | 先按 scene 名过滤候选文件 |
| GameObject 名 | [../../fsm-index/fsm-manifest.tsv](../../fsm-index/fsm-manifest.tsv) | 按 `gameobject_segment` 过滤 |
| FSM 名 | [../../fsm-index/fsm-manifest.tsv](../../fsm-index/fsm-manifest.tsv) | 联合 `scene` / `fsm_id` 消歧 |
| 只有行为描述 | 先推测 scene 或对象，再查 manifest | 必要时回到系统文档补上下文 |

## Manifest 字段怎么用

`fsm-manifest.tsv` 每行字段顺序：

`group, scene, gameobject_segment, fsm_name, fsm_id, relative_path, source_asset, content_hash`

含义：

- `group`: 大区域，如 `Godhome`
- `scene`: 当前导出中的场景目录名，通常是 Unity scene 文件名，如 `GG_Vengefly.unity`
- `gameobject_segment`: GameObject 路径片段
- `fsm_name`: FSM 名，如 `Control`
- `fsm_id`: 唯一 PathId
- `relative_path`: 相对 `fsm-export/` 根目录的 Markdown 路径
- `source_asset`: 原始资源文件路径
- `content_hash`: 导出内容哈希

## 常用查询范式

### 1. 按 Boss 查

先查 `fsm-manifest.tsv`，再用 `boss-shortcuts.md` 快速浏览高频战斗场景。

如果还要继续精确筛选，再查 manifest：

```bash
rg -n 'Radiance|Hornet|Grimm|Mantis|Zote' /home/windflower/.codex/skills/hk-api/fsm-index/fsm-manifest.tsv
```

### 2. 按 scene 查

如果用户说“`GG_Vengefly` 里有哪些 FSM”：

```bash
rg -n 'GG_Vengefly(\.unity)?' /home/windflower/.codex/skills/hk-api/fsm-index/fsm-manifest.tsv
```

如果只知道 scene，不确定 group，也可以直接搜 scene 名：

```bash
rg -n 'GG_Vengefly|Abyss_01\.unity' /home/windflower/.codex/skills/hk-api/fsm-index/fsm-manifest.tsv
```

### 3. 按 GameObject 查

如果用户说“找 `Boss_Control_Radiance` 上的 FSM”：

```bash
rg -n 'Boss_Control_Radiance' /home/windflower/.codex/skills/hk-api/fsm-index/fsm-manifest.tsv
```

### 4. 按 FSM 名查

如果用户只说“找某个 `Control`”：

```bash
rg -n $'\tControl\t' /home/windflower/.codex/skills/hk-api/fsm-index/fsm-manifest.tsv
```

这类查询通常结果很多，必须再加 scene 或 GameObject 条件：

```bash
rg -n 'GG_Vengefly|GG_Radiance|Boss_Control_Radiance.*\tControl\t' /home/windflower/.codex/skills/hk-api/fsm-index/fsm-manifest.tsv
```

## 歧义消解规则

同名 `Control`、`FSM`、`damages_hero` 非常多。回答前至少要做这几步：

1. 确认 `scene`
2. 确认 `gameobject_segment`
3. 如仍重复，使用 `fsm_id`
4. 最后再打开导出 Markdown 看状态 / 动作内容是否匹配

## 打开导出文件后重点看什么

面对一个候选 `fsm-export/...md` 文件，优先看：

1. `Summary` 里的 `GameObject Path`、`Start State`、`FSM PathId`
2. `States` 中是否出现用户描述的状态名 / 行为名
3. 动作类型是否包含目标行为，比如攻击、对话、伤害、传送
4. `Transitions` / `Global Transitions` 是否有对应事件

## 推荐回答格式

当你已经找到目标 FSM，尽量这样组织答案：

1. 先给定位信息：`scene`、`GameObject`、`fsm_name`、`fsm_id`
2. 再给文件路径：`relative_path`
3. 再给结构摘要：起始状态、关键状态、关键动作、关键事件
4. 如果要改代码，再补运行时 `LocateMyFSM(...)` 和可能的 Hook 点

## 什么时候导出数据还不够

这些场景需要回到源码或运行时验证：

- 用户要找的是 Hook 点，而不是 FSM 结构
- 用户要确认某个 Mod 是否在运行时改写了 FSM
- 多个候选 FSM 在静态结构上都相似
- 动作参数依赖运行时变量或外部对象状态

这种情况下，把导出数据当作“定位器”，再结合 `hkapi/` 源码和日志验证。
