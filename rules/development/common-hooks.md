---
title: Common Hooks Reference
impact: HIGH
impactDescription: Essential hooks for intercepting game logic
tags: hk-api, hooks, on-hooks, modhooks, il-hooks
---

# Common Hooks Reference

## 概述

本文档整理了常用的 Hook 模式和用法。

## Hook 类型

### On.Hooks

拦截并调用原始方法：

```csharp
On.HeroController.Attack += (orig, self, dir) => {
    orig(self, dir);  // 调用原始方法
    // 自定义逻辑
};
```

### ModHooks

全局游戏事件钩子：

```csharp
ModHooks.LanguageGetHook += (orig, key, sheet, ret) => {
    if (key == "SOME_KEY") return "Custom Text";
    return ret;
};
```

### IL Hooks

IL 代码注入：

```csharp
IL.HeroController.SoulGain += (ctx) => {
    // 修改 IL 代码
};
```

## 常用 Hook 列表

### 游戏管理相关

| Hook | 用途 |
|------|------|
| `GameManager.StartNewGame` | 新游戏开始拦截 |
| `GameManager.ContinueGame` | 继续游戏拦截 |
| `GameManager.SetGameMap` | 地图设置拦截 |

### 地图相关

| Hook | 用途 |
|------|------|
| `GameMap.QuickMap*` | 快速地图定位（多个区域） |
| `GameMap.CloseQuickMap` | 关闭快速地图 |
| `GameMap.WorldMap` | 世界地图 IL 注入 |
| `GameMap.PositionCompass` | 指南针位置 IL 注入 |
| `SceneManager.AddSceneMapped` | 场景映射添加拦截 |
| `SceneManager.activeSceneChanged` | 场景切换事件 |

### 玩家控制相关

| Hook | 用途 |
|------|------|
| `On.HeroController.Attack` | 攻击输入拦截 |
| `On.HeroController.Start` | 玩家初始化 |
| `On.HeroController.CanWallJump` | 墙跳检测拦截 |
| `On.HeroController.CanWallSlide` | 墙滑检测拦截 |

### FSM 相关

| Hook | 用途 |
|------|------|
| `On.PlayMakerFSM.OnEnable` | FSM 启用时拦截（最常用） |
| `PlayMakerFSM.Start` | FSM 启动时拦截 |

### 本地化相关

| Hook | 用途 |
|------|------|
| `ModHooks.LanguageGetHook` | 本地化文本替换 |
| `GameMap.GetPlayerBoolHook` | 玩家布尔值获取拦截 |
| `GameMap.SetPlayerBoolHook` | 玩家布尔值设置拦截 |

### 战斗相关

| Hook | 用途 |
|------|------|
| `ModHooks.SlashHitHook` | 攻击命中检测 |

### 相机相关

| Hook | 用途 |
|------|------|
| `On.CameraController.LateUpdate` | 相机更新拦截（用于锁定相机） |

## 代码示例

### FSM 启用拦截

```csharp
On.PlayMakerFSM.OnEnable += (orig, self) => {
    orig(self);
    
    if (self.FsmName == "Target FSM" && 
        self.gameObject.name == "Target Object") {
        // 注入自定义逻辑
        InjectCustomAction(self, "State Name");
    }
};
```

### 相机锁定

```csharp
private static readonly FieldInfo xLockField = typeof(CameraController)
    .GetField("xLockPos", BindingFlags.Instance | BindingFlags.NonPublic);
private static readonly FieldInfo yLockField = typeof(CameraController)
    .GetField("yLockPos", BindingFlags.Instance | BindingFlags.NonPublic);

On.CameraController.LateUpdate += (orig, self) => {
    orig(self);
    
    if (lockCamera) {
        self.mode = CameraController.CameraMode.FROZEN;
        self.transform.position = lockPosition;
        
        xLockField?.SetValue(self, lockPosition.x);
        yLockField?.SetValue(self, lockPosition.y);
        
        if (GameCameras.instance.tk2dCam != null) {
            GameCameras.instance.tk2dCam.ZoomFactor = zoomFactor;
        }
    }
};
```

### 玩家攻击拦截

```csharp
On.HeroController.Attack += (orig, self, dir) => {
    if (customAttackMode) {
        FireCustomProjectile(self, dir);
        return;  // 不调用原始方法
    }
    orig(self, dir);
};
```

### 本地化文本替换

```csharp
ModHooks.LanguageGetHook += (key, sheet, orig) => {
    if (key == "BOSS_NAME") {
        return "自定义 Boss 名称";
    }
    return orig;
};
```

### 场景切换处理

```csharp
UnityEngine.SceneManagement.SceneManager.activeSceneChanged += (from, to) => {
    if (from.name == "BossScene") {
        // 清理 Boss 战资源
        CleanupBossResources();
    }
    
    if (to.name == "PlayerScene") {
        // 初始化玩家场景
        InitPlayerScene();
    }
};
```

### 墙跳/墙滑禁用

```csharp
On.HeroController.CanWallJump += (orig, self) => {
    if (disableWallJump) {
        return false;
    }
    return orig(self);
};

On.HeroController.CanWallSlide += (orig, self) => {
    if (disableWallSlide) {
        return false;
    }
    return orig(self);
};
```
