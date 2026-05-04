---
title: FSM Reference Guide
impact: HIGH
impactDescription: Essential for understanding and modifying game state machines
tags: hk-api, fsm, playmaker, state-machine, boss-control
---

# FSM Reference

## 相关文档

- [FSM Query Guide](fsm-query-guide.md) - 按 Boss / scene / 名称检索具体 FSM
- [FSM Index README](../../fsm-index/README.md) - 数据集入口和字段说明
- [Scene Summary](../../fsm-index/scene-summary.md) - 按区域 / scene 汇总
- [Boss Shortcuts](../../fsm-index/boss-shortcuts.md) - Boss / 战斗场景快捷入口
- [Code Patterns](../development/code-patterns.md) - 通用代码模式
- [Game Modification Patterns](../systems/game-modification-patterns.md) - 商店、Boss、敌人等系统修改模式

## 概述

本技能内置了一套本地 FSM 导出数据，用来回答“这个场景有哪些 FSM”“某个 Boss 的 Control 在哪里”“某个状态里有什么动作”这类问题。

这套数据优先于单纯搜索 `hkapi/` 源码，因为很多 PlayMaker 逻辑图并不会完整体现在 C# 文本里。

## Dataset Snapshot

| Item | Value |
| --- | --- |
| FSM markdown files | 24701 |
| Groups | 23 |
| Scenes | Current export uses Unity scene file names such as `Abyss_01.unity` and `GG_Vengefly.unity` |
| Export root | [`../../fsm-export/`](../../fsm-export/) |
| Manifest | [`../../fsm-index/fsm-manifest.tsv`](../../fsm-index/fsm-manifest.tsv) |
| Scene summary | [`../../fsm-index/scene-summary.md`](../../fsm-index/scene-summary.md) |
| Boss shortcuts | [`../../fsm-index/boss-shortcuts.md`](../../fsm-index/boss-shortcuts.md) |

## 每个导出文件包含什么

单个 `fsm-export/<group>/<scene>/<file>.md` 文件通常包含：

- `Summary`: FSM 名、GameObject 名 / 路径、源 asset、起始状态、`FSM PathId`
- `Variables`: 按类型分组的变量值
- `States`: 每个状态的描述、动作列表、动作参数
- `Transitions`: 局部转移
- `Global Transitions`: 全局转移
- `Events`: FSM 事件列表

这意味着大多数“状态名是什么”“某个动作参数当前是多少”“某个事件跳到哪里”都可以直接回答，不需要猜。

## 推荐查询顺序

1. 已知 Boss / 战斗场景：优先查 [fsm-manifest.tsv](../../fsm-index/fsm-manifest.tsv)，再用 [Boss Shortcuts](../../fsm-index/boss-shortcuts.md) 快速浏览
2. 已知 scene：优先直接查 [fsm-manifest.tsv](../../fsm-index/fsm-manifest.tsv) 中的 `scene` 列，必要时再用 [Scene Summary](../../fsm-index/scene-summary.md) 浏览该 scene 全量文件
3. 只知道 GameObject / FSM 名：查 [fsm-manifest.tsv](../../fsm-index/fsm-manifest.tsv)
4. 确认候选后：打开对应 `fsm-export/...md` 读取状态 / 动作 / 转移细节
5. 同名候选很多时：用 `scene + gameobject_segment + fsm_id` 消歧

## 常见 FSM 名模式

这些名字在数据集中高频出现，通常不是唯一实例：

| FSM 名 | 常见含义 | 查询建议 |
| --- | --- | --- |
| `Control` | 主控制 FSM，常见于敌人、Boss、特效、UI | 必须联合 scene 和 GameObject 看 |
| `FSM` | 通用默认名，信息量最低 | 先看 GameObject，再看 `fsm_id` |
| `npc_control` | NPC 行为 / 对话流程 | 配合 `Conversation_Control` 一起看 |
| `damages_hero` | 对玩家造成伤害 | 常见于碰撞器、弹体、特效 |
| `Orb_Control` / `Ball_Control` | 投射物 / 球体控制 | 多出现在 Boss 战或特效对象 |
| `Music_Region` / `Enviro_Region` | 区域环境 / 音乐控制 | 往往不是战斗核心 FSM |
| `Set_Compass_Point` / `map_isroom` | 地图 / 指南针 / 房间标记 | 常见于 UI / 地图对象 |

## 常见事件名

| 事件名 | 常见用途 |
| --- | --- |
| `FINISHED` | 当前状态完成后的默认转移 |
| `CANCEL` | 取消当前流程 |
| `START` | 初始化 / 开始 |
| `END` | 收尾 / 结束 |
| `FIRE` | 发射 / 攻击 / 触发输出 |
| `ANTIC` | 攻击前摇 / 预备 |

具体事件仍以对应导出文件里的 `Transitions` / `Global Transitions` 为准。

## 运行时代码示例

### 定位 FSM

```csharp
var fsm = gameObject.LocateMyFSM("Control");
```

### 发送事件

```csharp
fsm.SendEvent("FINISHED");
```

### 修改转移

```csharp
fsm.ChangeTransition("Idle", "FINISHED", "Attack");
```

### 注入自定义动作

```csharp
private void InjectCustomAction(PlayMakerFSM fsm, string stateName)
{
    var state = fsm.Fsm.GetState(stateName);
    if (state == null) return;

    var newActions = new FsmStateAction[state.Actions.Length + 1];
    newActions[0] = new CustomAction();
    Array.Copy(state.Actions, 0, newActions, 1, state.Actions.Length);
    state.Actions = newActions;
}
```

### 禁用某个伤害 FSM

```csharp
var fsm = gameObject.LocateMyFSM("damages_hero");
if (fsm != null)
{
    fsm.enabled = false;
}
```

## 回答 FSM 问题时应包含什么

如果用户问的是具体 FSM，回答里尽量包含这些定位信息：

- `group`
- `scene`
- `gameobject_segment`
- `fsm_name`
- `fsm_id`
- `relative_path`

如果进一步分析状态 / 动作，则再补：

- 起始状态
- 关键状态名
- 关键动作类型
- 关键事件 / 转移

## 适用边界

- 本地导出数据非常适合回答“结构是什么”。
- 运行时动态注入、Hook 顺序、Mod 改写冲突，仍然要结合源码和实际运行验证。
- 同名 `Control` / `FSM` 很多，不要只凭一个名字下结论。
