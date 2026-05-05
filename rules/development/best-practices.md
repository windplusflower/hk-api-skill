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

### 6.1 状态机选型原则

- 修改 Hollow Knight 现有对象的小范围行为时，优先保留并修改原 `PlayMakerFSM`
- 当任务变成“自己管理一个复杂行为系统”时，应优先考虑 `RingLib`，而不是继续堆叠 `Update()` / `switch` / 多个零散协程
- 特别是新 Boss、新敌人、新子弹控制器、多阶段技能循环、复杂打断逻辑，默认都应先评估 `RingLib`

### 6.2 何时主动想到 RingLib

出现以下信号时，使用这个 skill 的 AI 应主动检查 `rules/libraries/ringlib.md`：

1. 用户明确说“自定义状态机”
2. 用户要实现全新 Boss / 敌人 / projectile 行为流
3. 逻辑包含大量等待、阶段切换、并行子流程、受击打断
4. 方案如果不用状态机，就会演变成臃肿的 `Update()` / `switch`

`RingLib` 在本 skill 中应被视为 HK mod 自定义 C# 状态机的首选参考实现，但它仍然是按需引入的源码依赖，不是模板默认依赖。

参考： [RingLib](../libraries/ringlib.md)

### 6.3 RingLib 接管模式最佳实践

- 对 HK 里的 Boss / 敌人主行为接管，默认优先 `EntityStateMachine`，不要先入为主地选裸 `StateMachine`。
- 外部入口（如 `On.PlayMakerFSM.OnEnable`）通常只负责命中目标并 `AddComponent<YourStateMachine>()`。
- 宿主依赖抓取、旧 FSM 资源提取、`oldFsm.enabled = false`、Intro 运行前提准备，优先放在 `EntityStateMachineStart()` 里完成。
- 不要默认把主接管路径拆成“外部控制器 `Initialize(...)` 一半，再由状态机继续接手”；这种结构更容易出现初始化顺序错误和原 FSM / 新状态机并行运行。
- 如果状态机已经挂上，但表现像“完全没接管”，优先检查：
  - 状态方法是否缺 `[State]`
  - 旧 FSM 是否仍在并行运行
  - 状态机的关键初始化是不是被放在外部而不是 `EntityStateMachineStart()`

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
- 排障时优先读取 `ModLog.txt`，Windows 上常见目录是 `AppData/LocalLow/Team Cherry/Hollow Knight/ModLog.txt`。
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
