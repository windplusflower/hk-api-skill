---
title: Satchel Library Guide
impact: MEDIUM
impactDescription: Third-party utility library for HK modding
tags: hk-api, satchel, library, better-menus, futils
---

# Satchel Library Guide

## 概述

Satchel 是一个 Hollow Knight Mod 实用工具库，由 PrashantMohta 开发，旨在简化 Mod 开发流程。

**GitHub**: https://github.com/PrashantMohta/Satchel

**官方文档**: https://prashantmohta.github.io/ModdingDocs/Satchel/Satchel.html

---

## 核心功能

### 1. BetterMenus

简化 `ICustomMenuMod` 的实现，只需返回菜单项列表即可自动处理布局。

#### 基本用法

```csharp
using Satchel;
using Satchel.BetterMenus;

public class MyMod : Mod, ICustomMenuMod
{
    public bool ToggleButtonInsideMenu => true;
    
    private static MenuScreen menuScreen;
    
    public override void Initialize(Dictionary<string, Dictionary<string, GameObject>> preloadedObjects)
    {
        // 定义菜单项
        var options = new List<MenuOption>
        {
            new MenuOption("Enable Feature", 
                (cfg) => cfg.Enabled, 
                (cfg, val) => cfg.Enabled = val),
            
            new MenuOption("Difficulty", 
                (cfg) => cfg.Difficulty.ToString(), 
                (cfg, val) => cfg.Difficulty = (Difficulty)Enum.Parse(typeof(Difficulty), val)),
            
            new MenuOption("Reset Progress", 
                (cfg) => "Reset", 
                (cfg, _) => ResetProgress())
        };
        
        // 创建菜单屏幕
        menuScreen = SatchelHelper.BuildModMenu("My Mod", options);
    }
    
    public override MenuScreen GetMainMenu() => menuScreen;
}
```

#### MenuOption 类型

| 类型 | 说明 | 示例 |
|------|------|------|
| Toggle | 开关选项 | `Enable Feature` |
| Slider | 滑动条 | `Volume: 0-100` |
| Dropdown | 下拉菜单 | `Difficulty: Easy/Normal/Hard` |
| Button | 按钮 | `Reset Progress` |
| KeyBind | 按键绑定 | `Jump: Z` |

#### 完整示例

```csharp
using Satchel;
using Satchel.BetterMenus;
using UnityEngine;

public class MyMod : Mod, ICustomMenuMod
{
    public bool ToggleButtonInsideMenu => true;
    
    private static MenuScreen menuScreen;
    private static Settings settings = new();
    
    public override void Initialize(Dictionary<string, Dictionary<string, GameObject>> preloadedObjects)
    {
        var options = new List<MenuOption>
        {
            // 开关选项
            new MenuOption("Enable Mod", 
                (cfg) => cfg.Enabled ? "On" : "Off", 
                (cfg, val) => cfg.Enabled = !cfg.Enabled),
            
            // 滑动条
            new MenuOption("Damage Multiplier", 
                (cfg) => cfg.DamageMultiplier.ToString("F1") + "x", 
                (cfg, val) => {
                    cfg.DamageMultiplier = Mathf.Clamp(cfg.DamageMultiplier + 0.5f, 0.5f, 5.0f);
                }),
            
            // 下拉菜单
            new MenuOption("Game Mode", 
                (cfg) => cfg.GameMode, 
                (cfg, val) => cfg.GameMode = val),
            
            // 按钮
            new MenuOption("Reset All Progress", 
                (cfg) => "Reset", 
                (cfg, _) => {
                    if (DialogBox.Show("Confirm?", "Are you sure?"))
                    {
                        ResetProgress();
                    }
                }),
            
            // 按键绑定
            new MenuOption("Special Attack Key", 
                (cfg) => cfg.SpecialKey.ToString(), 
                (cfg, _) => cfg.SpecialKey = Input.GetKey(KeyCode.Alpha1) ? KeyCode.Alpha1 : KeyCode.Alpha2)
        };
        
        menuScreen = SatchelHelper.BuildModMenu("My Mod", options);
    }
    
    public override MenuScreen GetMainMenu() => menuScreen;
}

[Serializable]
public class Settings
{
    public bool Enabled { get; set; } = true;
    public float DamageMultiplier { get; set; } = 1.0f;
    public string GameMode { get; set; } = "Normal";
    public KeyCode SpecialKey { get; set; } = KeyCode.Z;
}
```

---

### 2. FUtils (FSM Utilities)

简化 PlayMaker FSM 的修改操作。

#### 基本用法

```csharp
using Satchel;
using Satchel.Futils;

// 获取 FSM
var fsm = gameObject.LocateMyFSM("FSM Name");

// 插入自定义方法
fsm.InsertMethod("State Name", 1, () => {
    // 自定义逻辑
    Log("State entered!");
});

// 修改 FSM 过渡
fsm.ChangeTransition("State Name", "FINISHED", "New State");

// 修改 FSM 变量
fsm.FsmVariables.GetFsmFloat("VariableName").Value = 10f;

// 发送 FSM 事件
fsm.SendEvent("CUSTOM_EVENT");
```

#### 常用方法

| 方法 | 说明 | 示例 |
|------|------|------|
| `LocateMyFSM` | 查找 FSM | `gameObject.LocateMyFSM("Control")` |
| `InsertMethod` | 插入自定义方法 | `fsm.InsertMethod("State", 1, () => {})` |
| `ChangeTransition` | 修改过渡 | `fsm.ChangeTransition("State", "FINISHED", "New")` |
| `GetAction<T>` | 获取 FSM 动作 | `fsm.GetAction<SetFsmString>("State", 1)` |
| `SendEvent` | 发送事件 | `fsm.SendEvent("EVENT_NAME")` |

#### 完整示例

```csharp
using Satchel;
using Satchel.Futils;
using Modding;
using UnityEngine;

namespace MyMod;

public class MyMod : Mod
{
    public override void Initialize(Dictionary<string, Dictionary<string, GameObject>> preloadedObjects)
    {
        // 监听 Boss FSM 启用
        On.PlayMakerFSM.OnEnable += ModifyBossFSM;
    }
    
    private void ModifyBossFSM(On.PlayMakerFSM.orig_OnEnable orig, PlayMakerFSM self)
    {
        // 判断是否是目标 Boss
        if (self.gameObject.name == "Boss" && self.FsmName == "Control")
        {
            // 插入自定义方法
            self.InsertMethod("Attack", 1, () => {
                Log("Boss is attacking!");
            });
            
            // 修改过渡
            self.ChangeTransition("Attack", "FINISHED", "Idle");
            
            // 修改 FSM 变量
            self.FsmVariables.GetFsmFloat("Damage").Value = 2;
            
            // 获取并修改 FSM 动作
            var action = self.GetAction<SetFsmString>("Intro", 1);
            if (action != null)
            {
                action.setValue = "Custom Text";
            }
        }
        
        orig(self);
    }
}
```

---

### 3. 自定义 UI 元素

提供简化的 UI 实现，包括互动卡片等。

#### 基本用法

```csharp
using Satchel;
using Satchel.UI;

// 创建互动卡片
var card = new InteractiveCard
{
    Title = "Card Title",
    Description = "Card Description",
    OnClick = () => {
        Log("Card clicked!");
    }
};

// 添加到 UI
SatchelHelper.AddToUI(card);
```

---

## 安装方法

### 方法 1：通过 ModInstaller

在 `modinfo.yaml` 中添加依赖：

```yaml
dependencies:
  - Satchel
```

### 方法 2：手动安装

1. 下载 Satchel.dll
2. 放入 `Mods/Satchel/` 目录
3. 在项目中引用 Satchel.dll

### 方法 3：使用 VS 模板

```xml
<ItemGroup>
  <Reference Include="Satchel">
    <HintPath>$(ModdingAPI)\Mods\Satchel\Satchel.dll</HintPath>
    <Private>false</Private>
  </Reference>
</ItemGroup>
```

---

## 使用示例

### 示例 1：使用 BetterMenus 创建设置菜单

```csharp
using Satchel;
using Satchel.BetterMenus;
using Modding;
using UnityEngine;

namespace MyMod;

public class MyMod : Mod, IGlobalSettings<Settings>, ICustomMenuMod
{
    public bool ToggleButtonInsideMenu => true;
    
    private static Settings settings = new();
    private static MenuScreen menuScreen;
    
    public Settings GetGlobalSettings() => settings;
    public void SetGlobalSettings(Settings s) => settings = s;
    
    public override void Initialize(Dictionary<string, Dictionary<string, GameObject>> preloadedObjects)
    {
        var options = new List<MenuOption>
        {
            new MenuOption("Enable Mod", 
                (cfg) => cfg.Enabled ? "On" : "Off", 
                (cfg, _) => cfg.Enabled = !cfg.Enabled),
            
            new MenuOption("Damage", 
                (cfg) => cfg.Damage.ToString(), 
                (cfg, _) => cfg.Damage = (cfg.Damage + 1) % 10),
            
            new MenuOption("Reset", 
                (cfg) => "Reset", 
                (cfg, _) => ResetSettings())
        };
        
        menuScreen = SatchelHelper.BuildModMenu("My Mod", options);
    }
    
    public override MenuScreen GetMainMenu() => menuScreen;
    
    private void ResetSettings()
    {
        settings = new Settings();
        SaveGlobalSettings();
    }
}

[Serializable]
public class Settings
{
    public bool Enabled { get; set; } = true;
    public int Damage { get; set; } = 1;
}
```

### 示例 2：使用 FUtils 修改 Boss

```csharp
using Satchel;
using Satchel.Futils;
using Modding;
using UnityEngine;

namespace MyMod;

public class MyMod : Mod
{
    public override void Initialize(Dictionary<string, Dictionary<string, GameObject>> preloadedObjects)
    {
        On.PlayMakerFSM.OnEnable += ModifyBoss;
    }
    
    private void ModifyBoss(On.PlayMakerFSM.orig_OnEnable orig, PlayMakerFSM self)
    {
        if (self.gameObject.name == "Radiance" && self.FsmName == "Control")
        {
            // 插入自定义方法
            self.InsertMethod("Attack Combo", 1, () => {
                Log("Radiance is attacking!");
            });
            
            // 修改伤害
            var damageVar = self.FsmVariables.GetFsmInt("Damage");
            if (damageVar != null)
            {
                damageVar.Value = 2;
            }
            
            // 修改过渡
            self.ChangeTransition("Attack", "FINISHED", "Idle");
        }
        
        orig(self);
    }
}
```

### 示例 3：使用 FUtils 修改商店

```csharp
using Satchel;
using Satchel.Futils;
using Modding;
using UnityEngine;

namespace MyMod;

public class MyMod : Mod
{
    public override void Initialize(Dictionary<string, Dictionary<string, GameObject>> preloadedObjects)
    {
        On.PlayMakerFSM.OnEnable += ModifyShop;
    }
    
    private void ModifyShop(On.PlayMakerFSM.orig_OnEnable orig, PlayMakerFSM self)
    {
        if (self.gameObject.name == "Shop Menu" && self.FsmName == "shop_control")
        {
            // 修改商店文本
            self.FsmVariables.GetFsmString("No Stock Event").Value = "CUSTOM_SHOP";
            
            // 插入自定义购买逻辑
            var confirmFsm = self.gameObject.FindGameObjectInChildren("Confirm")
                .FindGameObjectInChildren("UI List")
                .LocateMyFSM("Confirm Control");
            
            if (confirmFsm != null)
            {
                confirmFsm.InsertCustomAction("Special Type?", (fsm) => {
                    // 自定义购买逻辑
                    Log("Item purchased!");
                }, 1);
            }
        }
        
        orig(self);
    }
}
```

---

## 注意事项

### BetterMenus

- ✅ 使用 `ToggleButtonInsideMenu => true` 在菜单内显示开关
- ✅ MenuOption 的回调需要返回字符串
- ✅ 使用 `SatchelHelper.BuildModMenu` 创建菜单

### FUtils

- ✅ 在 `orig(self)` 之前修改 FSM
- ✅ 检查 FSM 是否存在再修改
- ✅ 检查动作数组长度避免重复插入
- ✅ 使用 `LocateMyFSM` 而非 `GetComponent`

### 通用

- ✅ 在 `modinfo.yaml` 中添加 Satchel 依赖
- ✅ 在项目中引用 Satchel.dll
- ✅ 设置 `Private=false` 避免复制 DLL

---

## 相关资源

- **GitHub**: https://github.com/PrashantMohta/Satchel
- **官方文档**: https://prashantmohta.github.io/ModdingDocs/Satchel/Satchel.html
- **BetterMenus 文档**: https://prashantmohta.github.io/ModdingDocs/Satchel/BetterMenus/better-menus.html
- **示例代码**: https://github.com/TheMulhima/Satchel/tree/master/BetterMenus/Example

---

## 已使用 Satchel 的 Mod

- StubbornKnight
- HuKing
- MossBeast
- MossJumper
