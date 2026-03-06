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

