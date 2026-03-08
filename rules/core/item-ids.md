---
title: Item IDs and PlayerData Fields
impact: HIGH
impactDescription: Critical for accessing game data and charm effects
tags: hk-api, items, charms, player-data, ids
---

# Item IDs Reference

## 概述

本文档整理了护符 ID、PlayerData 字段等游戏数据标识符。

## 护符 ID (Charm IDs)

| ID | 常量名 | 名称 | 效果 |
|----|--------|------|------|
| 2 | - | 指南针 (Compass) | 在小地图上显示位置 |
| 6 | CHARM_FURY | 亡者之怒 (Fury of the Fallen) | 血量为 1 时伤害×1.75 |
| 13 | CHARM_PRIDE | 骄傲印记 (Mark of Pride) | 骨钉范围 +30% |
| 18 | CHARM_LONGNAIL | 修长之钉 (Longnail) | 骨钉范围 +40% |
| 19 | CHARM_SHAMAN | 萨满之石 (Shaman Stone) | 法术伤害×1.5 |
| 20 | CHARM_SOUL_CATCHER | 灵魂捕手 (Soul Catcher) | 灵魂获取 +3 (未满) / +2 (已满) |
| 21 | CHARM_SOUL_EATER | 噬魂者 (Soul Eater) | 灵魂获取 +8 (未满) / +6 (已满) |
| 23 | CHARM_FRAGILE_HEART | 无忧旋律 (Fragile/Unbreakable Heart) | 防止死亡惩罚 |
| 25 | CHARM_STRENGTH | 易碎/坚固力量 (Fragile/Unbreakable Strength) | 伤害×1.5 |
| 33 | CHARM_SPELL_TWISTER | 法术扭曲者 (Spell Twister) | 法术消耗 -11 |

## PlayerData 字段

### 基础字段

| 字段名 | 类型 | 用途 |
|--------|------|------|
| health | int | 当前血量 |
| MPCharge | int | 当前灵魂值 |
| maxMP | int | 最大灵魂容量 |
| nailDamage | int | 基础骨钉伤害 |
| shadeFireballLevel | int | 暗影法术升级等级（≥2 为金色） |
| shadeQuakeLevel | int | 暗影地震升级等级（≥2 为金色） |
| shadeScreamLevel | int | 暗影嚎叫升级等级（≥2 为金色） |

### 地图相关

| 字段名 | 类型 | 用途 |
|--------|------|------|
| scenesVisited | List<string> | 已访问的场景列表 |
| scenesMapped | List<string> | 已绘制地图的场景列表 |
| whitePalaceMidWarp | bool | 是否到达白色宫殿中点 |
| whitePalaceOrb_2 | bool | 是否获取右侧宝珠 |
| whitePalaceOrb_3 | bool | 是否获取左侧宝珠 |
| gotKingFragment | bool | 是否获取国王碎片 |
| killedBindingSeal | bool | 是否完成痛苦之路 |

### 自定义存档设置

| 字段名 | 类型 | 用途 |
|--------|------|------|
| gotGHMap | bool | 是否获得 GH 地图 |
| gotWPMap | bool | 是否获得 WP 地图 |

## 护符检测 {#护符检测}

### 读取 PlayerData

```csharp
var pd = HeroController.instance.hero_state;
int health = pd.health;
int maxMP = pd.maxMP;
bool hasCharm = pd.GetBool("equippedCharm_19");
```

### 检查护符

```csharp
if (pd.GetBool("equippedCharm_25")) {
    // 易碎/坚固力量
    damageMultiplier *= 1.5f;
}

if (pd.GetBool("equippedCharm_20")) {
    // 灵魂捕手
    soulGain += 3;
}

if (pd.GetBool("equippedCharm_21")) {
    // 噬魂者
    soulGain += 8;
}
```

### 灵魂获取计算

```csharp
int soulAmount;
var pd = PlayerData.instance;

if (pd.GetInt("MPCharge") < pd.GetInt("maxMP")) {
    // 主魂未满：基础 11 点
    soulAmount = 11;
    if (pd.GetBool("equippedCharm_20")) soulAmount += 3;
    if (pd.GetBool("equippedCharm_21")) soulAmount += 8;
} else {
    // 主魂已满，溢出到魂瓮：基础 6 点
    soulAmount = 6;
    if (pd.GetBool("equippedCharm_20")) soulAmount += 2;
    if (pd.GetBool("equippedCharm_21")) soulAmount += 6;
}

HeroController.instance.AddMPCharge(soulAmount);
```

### 伤害倍数计算

```csharp
float CalculateDamageMultiplier() {
    float multiplier = 1f;
    var pd = PlayerData.instance;
    
    // 力量护符
    if (pd.GetBool("equippedCharm_25")) {
        multiplier *= 1.5f;
    }
    
    // 亡者之怒（残血）
    if (pd.GetBool("equippedCharm_6") && pd.GetInt("health") == 1) {
        multiplier *= 1.75f;
    }
    
    return multiplier;
}
```
