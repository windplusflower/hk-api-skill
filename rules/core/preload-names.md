---
title: Preload Names and Object Paths
impact: HIGH
impactDescription: Required for loading game objects and prefabs
tags: hk-api, preload, prefabs, game-objects, scenes
---

# Preload Names Reference

## 概述

本文档整理了预加载物品和场景对象的名称及路径。

## 预加载物品列表

### Boss 相关

| 场景 | 路径 | 用途 |
|------|------|------|
| GG_Radiance | Boss Control/Absolute Radiance | 辐光 Boss 预制体 |
| GG_Radiance | Boss Control/Absolute Radiance/Eye Beam Glow/Burst 1/Radiant Beam | 光束攻击预制体 |
| GG_Hollow_Knight | Battle Scene/HK Prime | 空洞骑士预制体 |
| GG_Hollow_Knight | Battle Scene/HK Prime/Tendrils | 触手效果 |

### 敌人相关

| 场景 | 路径 | 用途 |
|------|------|------|
| Tutorial_01 | _Enemies/Buzzer | 蜜蜂敌人模板 |
| RestingGrounds_08 | Ghost revek | 幽灵敌人模板 |
| Mines_19 | _Scenery/stomper_1/mines_stomper_02 | 压碎机敌人 |

### 场景物件

| 场景 | 路径 | 用途 |
|------|------|------|
| White_Palace_05 | wp_saw | 锯子预制体 |
| White_Palace_03 | White_ Spikes | 尖刺预制体 |
| GG_Workshop | gg_plat_float_wide | 浮动平台 |
| GG_Ghost_Hu | Ring Holder/1 | 技能环 |

### 地图/UI 相关

| 场景 | 路径 | 用途 |
|------|------|------|
| Crossroads_33 | scatter_map 1/2/3 | 地图碎片精灵 (64x64) |
| Grimm_Divine | Charm Holder | 护符拾取发光物 |
| Town | _Props/Stag_station/open/door_station | 设置指南针点位 FSM 源 |
| Room_mapper | _SceneManager | map_isroom FSM 源 |

## 代码示例

### 预加载对象

```csharp
public override List<(string, string)> GetPreloadNames() {
    return new List<(string, string)> {
        ("GG_Radiance", "Boss Control/Absolute Radiance"),
        ("Tutorial_01", "_Enemies/Buzzer"),
    };
}
```

### 从预加载提取

```csharp
var preloaded = preloadedObjects["SceneName"]["ObjectPath"];
var fsm = preloaded.LocateMyFSM("FSM Name");
```

### 实例化预加载对象

```csharp
var template = preloadedObjects["Tutorial_01"]["_Enemies/Buzzer"];
var instance = Instantiate(template, position, Quaternion.identity);
```

### 清理组件

```csharp
var template = preloadedObjects["GG_Radiance"]["Boss Control/Absolute Radiance"];
Destroy(template.GetComponent<PersistentBoolItem>());
Destroy(template.GetComponent<ConstrainPosition>());
```
