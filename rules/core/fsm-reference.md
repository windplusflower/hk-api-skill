---
title: FSM Reference Guide
impact: HIGH
impactDescription: Essential for understanding and modifying game state machines
tags: hk-api, fsm, playmaker, state-machine, boss-control
---

# FSM Reference

## 相关文档

- [Code Patterns](../development/code-patterns.md) - 通用代码模式（Hook、对象池、数据访问等）
- [Game Modification Patterns](../systems/game-modification-patterns.md) - 游戏系统修改模式（商店、Boss、敌人等）
- [Core Classes](core-classes.md) - 核心类参考（HeroController、PlayerData、HealthManager）

## 概述

本文档整理了常见的 PlayMaker FSM 相关信息，包括 FSM 名称、状态、事件等。

**本文档范围**：FSM 基础操作、FSM 列表、事件列表、代码示例。

## 常用 FSM 列表

### Boss 相关

| FSM 名称 | 用途 |
|----------|------|
| Mossy Control | Boss 行为控制 |
| Attack Commands | Boss 攻击生成控制 |
| Control | 预制体行为控制 |
| Orb Control | 轨道球控制 |

### 玩家相关

| FSM 名称 | 用途 |
|----------|------|
| Spell Control | 法术施放控制 |
| Nail Arts | 骨钉技控制 |
| Roar Lock | 吼叫锁定（Boss 战期间锁定玩家） |

### 效果相关

| FSM 名称 | 用途 |
|----------|------|
| CameraShake | 相机震动效果 |
| emitter | 粒子发射器控制 |
| Appear | 出现动画 |
| npc_control | NPC 行为控制 |

### 地图/UI 相关

| FSM 名称 | 用途 |
|----------|------|
| UI Control | UI 控制 |
| Quick Map | 快速地图 |
| Shiny Control | 发光物品控制 |
| Set Compass Point | 设置指南针点位 |
| map_isroom | 地图房间标识 |
| deactivate | 区域可见性控制 |

### 伤害相关

| FSM 名称 | 用途 |
|----------|------|
| damages_hero | 对玩家造成伤害 |
| Spike Hit Effect | 尖刺击中效果 |

## 常用事件

| 事件名 | 用途 |
|--------|------|
| FINISHED | 状态完成过渡 |
| CANCEL | 取消当前状态 |
| FSM CANCEL | FSM 取消 |
| FIRE | 触发攻击/发射 |
| ANTIC | 预备动作 |
| START | 开始 |
| END | 结束 |

## 代码示例

### 定位 FSM

```csharp
var fsm = gameObject.LocateMyFSM("FSM Name");
```

### 发送事件

```csharp
fsm.SendEvent("EVENT_NAME");
```

### 复制状态

```csharp
fsm.CopyState("Source State", "New State");
```

### 修改过渡

```csharp
fsm.ChangeTransition("State", "Event", "NewTargetState");
```

### 注入自定义动作

```csharp
private void InjectCustomAction(PlayMakerFSM fsm, string stateName) {
    var state = fsm.Fsm.GetState(stateName);
    if (state == null) return;
    
    var newActions = new FsmStateAction[state.Actions.Length + 1];
    newActions[0] = new CustomAction();
    Array.Copy(state.Actions, 0, newActions, 1, state.Actions.Length);
    state.Actions = newActions;
}
```

### 禁用 FSM

```csharp
var fsm = gameObject.LocateMyFSM("damages_hero");
if (fsm != null) {
    fsm.enabled = false;
}
```
