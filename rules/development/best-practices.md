---
title: HK Modding Best Practices
impact: HIGH
impactDescription: Critical patterns and anti-patterns for stable mods
tags: hk-api, best-practices, fsm, hooks, optimization
---

# Best Practices

## 概述

基于 5 个 HK API 仓库的分析，总结以下最佳实践。

## 1. FSM 操作最佳实践

### 1.1 FSM 状态复制

```csharp
// 复制现有状态创建变体
fsm.CopyState("Leap Start", "Leap Start " + skillName);
fsm.ChangeTransition("Leap Start " + skillName, "FINISHED", "Leap Launch " + skillName);
```

### 1.2 FSM 自定义动作插入

```csharp
// 在状态中插入自定义 C# 动作
var state = fsm.GetState(stateName);
state.InsertCustomAction(() => { /* custom logic */ }, index);
```

### 1.3 FSM 变量访问

```csharp
// 访问和修改 FSM 变量
var variable = fsm.FsmVariables.FindFsmFloat("VariableName").Value;
fsm.FsmVariables.FindFsmFloat("VariableName").Value = newValue;
```

## 2. Hook 最佳实践

### 2.1 On.Hook 注册

```csharp
// 在 Initialize 中注册 hooks
On.HeroController.Start += HeroController_Start;
On.PlayMakerFSM.OnEnable += PlayMakerFSM_OnEnable;
```

### 2.2 ModHooks 使用

```csharp
// 使用 ModHooks 拦截游戏逻辑
ModHooks.LanguageGetHook += (orig, key, sheet) => {
    if (key == "MY_KEY") return "自定义文本";
    return orig(key, sheet);
};
```

## 3. 护符检测最佳实践

```csharp
// 检测护符装备状态
if (heroController.instance.cState.equippedCharm_25) {
    // 易碎/坚固力量生效
    damageMultiplier *= 1.5f;
}

if (heroController.instance.cState.equippedCharm_6 && 
    playerData.GetInt("health") == 1) {
    // 亡者之怒生效
    damageMultiplier *= 1.75f;
}
```

## 4. 预加载物品提取

```csharp
// 从预加载对象中提取模板
var preloaded = preloadedObjects["SceneName"]["ObjectPath"];
var template = preloaded.LocateMyFSM("FSM Name")
    .GetAction<SpawnObjectFromGlobalPool>("Action", index)
    .gameObject.Value;
```

## 5. 对象池模式

```csharp
// 使用对象池管理频繁创建/销毁的对象
private Queue<GameObject> pool = new Queue<GameObject>();

GameObject GetFromPool() {
    return pool.Count > 0 ? pool.Dequeue() : Instantiate(prefab);
}

void ReturnToPool(GameObject obj) {
    obj.SetActive(false);
    pool.Enqueue(obj);
}
```

## 6. 状态机模式

```csharp
// 使用自定义状态机管理复杂行为
[State]
private IEnumerator<Transition> Idle() {
    // 空闲状态逻辑
    yield return new ToState { State = nameof(Choose) };
}

[State]
private IEnumerator<Transition> Choose() {
    // 选择攻击状态
    var nextSkill = skillSelector.Get();
    yield return new ToState { State = nextSkill };
}
```

## 7. 日志最佳实践

```csharp
// 优先使用 Modding API 日志，进入 ModLog.txt
Log("Orb system initialized");
LogDebug($"Filled slots = {filledSlots}");
LogWarn("Orb runtime was missing during scene change");
LogError("Failed to rebuild orb runtime");

// 或显式使用 Modding.Logger
Modding.Logger.Log("[DeVectMod] - Orb system initialized");
Modding.Logger.LogDebug("[DeVectMod] - Filled slots = 3");
```

- 模组业务日志默认应进入 `ModLog.txt`，不要把 `UnityEngine.Debug.Log*` 当作 HK mod 的主日志通道。
- 排障时优先读取 `ModLog.txt`，常见目录是 `C:\Users\33361\AppData\LocalLow\Team Cherry\Hollow Knight\ModLog.txt`。
- `Player.log` 只作为 Unity / 游戏主流程异常的补充参考。


### Fallback Learning (2026-03-15)
<!-- evolution:a9c508bfc034 -->
- Question: HK mod代码里的日志应该走哪个接口，ModLog一般在哪
- Facts:
  - Mod继承自Loggable，mod类内的Log/LogDebug/LogWarn/LogError都走Modding.Logger而不是UnityEngine.Debug。
  - Loggable.Log会把消息格式化为带类名前缀的文本，再转发到Logger.Log。
  - Logger.InitializeFileStream会在Application.persistentDataPath下创建ModLog.txt，并把历史日志归档到Old ModLogs目录。
  - Logger.WriteToFile会把日志写入ModLog.txt，并同步到ModHooks.LogConsole。
- Sources:
  - `hkapi/Modding/Mod.cs:25`
  - `hkapi/Modding/Loggable.cs:71`
  - `hkapi/Modding/Logger.cs:20`
  - `hkapi/Modding/Logger.cs:25`
  - `hkapi/Modding/Logger.cs:42`
