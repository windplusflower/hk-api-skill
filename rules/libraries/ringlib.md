# RingLib

`RingLib` 是一个以源码形式内联到 mod 项目中的轻量级协程状态机库。在 `MossBeast` 中，它没有作为独立 DLL 引用，而是直接放在仓库里的 `RingLib/` 目录并与 mod 一起编译。

## 适用场景

- 需要用 `IEnumerator<Transition>` 描述复杂 Boss/敌人行为流
- 需要显式状态切换，而不想把整套逻辑塞进 PlayMaker FSM
- 需要统一处理等待、并行协程、状态切换、碰撞事件投递
- 希望用 C# 状态机替代部分大型 `Update()` / `switch` 逻辑

## 不适用场景

- 只做普通 Hook
- 只改一两个 PlayMaker 状态或事件
- 只做简单 UI、菜单、存档、预加载
- 项目还没有明确的复杂行为状态需求

RingLib 不是 HK mod 模板默认依赖。只有当项目确实需要自定义协程状态机层时，再把它作为源码依赖加入。

## 来源与目录

- 当前 skill 内置源码位置：`third_party/RingLib/`
- 来源仓库：`../MossBeast`

当前复制的源码目录结构：

```text
third_party/RingLib/
├── Config.cs
├── Log.cs
├── EntityManagement/
│   ├── DeactivateOnStart.cs
│   └── DestroyAfterSeconds.cs
├── Entities/
│   └── Water/
│       ├── Water.cs
│       └── WaterSegment.cs
├── StateMachine/
│   ├── Coroutine.cs
│   ├── EntityStateMachine.cs
│   ├── GameObjectExtension.cs
│   ├── StateCollector.cs
│   ├── StateMachine.cs
│   └── Transition.cs
└── Utils/
    ├── ColliderRenderer.cs
    ├── InputManager.cs
    ├── RandomSelector.cs
    └── RingAnimator.cs
```

## 核心组成

### 1. `RingLib.StateMachine.StateMachine`

核心状态机基类，继承自 `MonoBehaviour`。

关键点：

- 状态方法通过 `[State]` 特性标记
- 每个状态方法返回 `IEnumerator<Transition>`
- `StartState` 决定初始状态
- `CurrentState` 记录当前状态名
- 每帧在 `Update()` 中推进当前状态协程
- 支持两类流转：
  - `StateTransition`：切状态
  - `CoroutineTransition`：挂起并运行子协程

常见成员：

- `SetState(string state)`：主动切状态
- `ReceiveEvent(Event event_)`：接收事件
- `BroadcastEvent(Event event_)`：向所有实例广播事件
- `CheckInStateEvents<T>()`：读取当前状态内收到的事件

实现参考：`third_party/RingLib/StateMachine/StateMachine.cs`

### 2. `[State]` + `StateCollector`

`StateCollector` 会在运行时扫描当前程序集里所有 `StateMachine` 子类，把带 `[State]` 的实例方法收集成状态表。

约束：

- 状态名默认就是方法名
- 不要把状态方法命名成 `Awake`、`Start`、`Update`、`FixedUpdate`
- 状态方法必须和委托签名匹配：`IEnumerator<Transition>`

实现参考：`third_party/RingLib/StateMachine/StateCollector.cs`

### 3. `Transition` 模型

RingLib 用返回值而不是回调来描述状态推进。

常用类型：

- `NoTransition`：本帧不切状态
- `ToState { State = ... }`：切到指定状态
- `WaitFor { Seconds = ... }`：等待若干秒
- `WaitForRealtime { Seconds = ... }`：按 `unscaledDeltaTime` 等待
- `WaitTill { Condition = ... }`：等到条件成立
- `CoroutineTransition { Routine = ... }`：运行一个子协程
- `CoroutineTransition { Routines = new object[] { ... } }`：并行运行多个子协程

辅助静态方法：

- `Wait.Seconds(float seconds)`
- `Wait.Until(Func<bool> condition)`

实现参考：`third_party/RingLib/StateMachine/Transition.cs`

### 4. `Coroutine`

`Coroutine` 是 RingLib 自己的协程执行器，不是 Unity 的 `StartCoroutine` 封装。

它负责：

- 推进当前状态协程
- 处理嵌套 / 并行 `CoroutineTransition`
- 把子协程返回的 `ToState` 冒泡到父状态机

实现参考：`third_party/RingLib/StateMachine/Coroutine.cs`

### 5. `EntityStateMachine`

给 2D 实体行为准备的扩展状态机，常用于敌人或子弹。

内置能力：

- 缓存 `BoxCollider2D`、`Rigidbody2D`
- 暴露 `Position`、`Velocity`、`Direction()`、`Turn()`
- 用射线检测地面 / 左墙 / 右墙
- 在接触地形时向状态机树广播 `CollisionEvent`
- 可选水平拐角修正

构造参数：

- `startState`
- `globalTransitions`
- `terrainLayer`
- `epsilon`
- `horizontalCornerCorrection`
- `spriteFacingLeft`

实现参考：`third_party/RingLib/StateMachine/EntityStateMachine.cs`

### 6. 工具类

- `GameObjectExtension`：在对象树里广播 RingLib 事件
- `RingAnimator`：包装 `Animator`，返回可 `yield` 的动画协程
- `InputManager`：输入缓冲、瞬时输入、互斥输入组
- `RandomSelector`：带权重、连发限制、保底 miss 计数的随机选择器
- `ColliderRenderer`：调试碰撞体可视化
- `DestroyAfterSeconds` / `DeactivateOnStart`：简单生命周期工具

## 在 HK mod 项目里的接入方式

RingLib 当前更适合作为源码依赖，而不是预编译库。

推荐做法：

1. 将 `third_party/RingLib/` 复制到你的 mod 仓库
2. 让 `.csproj` 把这些 `.cs` 文件一起编译
3. 按实际用途决定是否保留全部工具目录

如果只需要状态机核心，最小可复制集合通常是：

```text
RingLib/
├── Log.cs
├── StateMachine/
│   ├── Coroutine.cs
│   ├── EntityStateMachine.cs
│   ├── GameObjectExtension.cs
│   ├── StateCollector.cs
│   ├── StateMachine.cs
│   └── Transition.cs
└── Utils/
    └── RandomSelector.cs   # 可选
```

如果你不需要：

- 水体模拟
- `Animator` 包装
- 输入系统
- 碰撞体调试绘制

可以不带 `Entities/Water`、`RingAnimator`、`InputManager`、`ColliderRenderer`。

## 项目引用要求

按 `MossBeast.csproj` 的实际用法，RingLib 源码本身会依赖：

- `Assembly-CSharp.dll`
- `UnityEngine.dll`
- `UnityEngine.CoreModule.dll`
- `UnityEngine.Physics2DModule.dll`
- `UnityEngine.AnimationModule.dll`（如果用 `RingAnimator`）
- `UnityEngine.AudioModule.dll`（如果用 `RingAnimator` 播音效）

如果你的状态机类还直接访问 HK 类型或 PlayMaker，则额外补：

- `PlayMaker.dll`
- `MMHOOK_Assembly-CSharp.dll`
- `MMHOOK_PlayMaker.dll`
- `MonoMod.Utils.dll`

## 最小使用模式

### 1. 定义状态机类

```csharp
using System;
using System.Collections.Generic;
using RingLib.StateMachine;
using UnityEngine;

public class MyEnemyStateMachine : EntityStateMachine
{
    public MyEnemyStateMachine()
        : base(
            startState: nameof(Idle),
            globalTransitions: new Dictionary<Type, string>(),
            terrainLayer: "Terrain",
            epsilon: 0.02f,
            horizontalCornerCorrection: false,
            spriteFacingLeft: true
        ) { }

    protected override void EntityStateMachineStart()
    {
        // 初始化组件、引用、血量等
    }
}
```

### 2. 编写状态方法

```csharp
using System.Collections.Generic;
using RingLib.StateMachine;

public partial class MyEnemyStateMachine
{
    [State]
    private IEnumerator<Transition> Idle()
    {
        while (true)
        {
            if (HeroController.instance != null)
            {
                float dx = HeroController.instance.transform.position.x - transform.position.x;
                if (UnityEngine.Mathf.Abs(dx) < 5f)
                {
                    yield return new ToState { State = nameof(Attack) };
                }
            }

            yield return new NoTransition();
        }
    }

    [State]
    private IEnumerator<Transition> Attack()
    {
        yield return new WaitFor { Seconds = 0.4f };
        yield return new ToState { State = nameof(Idle) };
    }
}
```

### 3. 挂到对象上

```csharp
var enemy = new GameObject("MyEnemy");
enemy.AddComponent<BoxCollider2D>();
enemy.AddComponent<Rigidbody2D>();
enemy.AddComponent<MyEnemyStateMachine>();
```

状态机会在 Unity `Update()` 中自动启动并推进，不需要你手动调用 `StartCoroutine`。

## 事件模型

RingLib 有一套轻量事件系统，可以用来做“当前状态内事件消费”或“全局跳转”。

### 局部事件

如果事件类型不在 `globalTransitions` 里：

- 事件会进入 `inStateEvents`
- 当前状态可以通过 `CheckInStateEvents<T>()` 读取
- 每帧 `Update()` 结束后缓存会清空

这适合做：

- 命中检测
- 碰撞响应
- 当前状态的一次性输入消费

### 全局事件跳转

如果事件类型在 `globalTransitions` 里：

- `ReceiveEvent` 会立即切到映射状态
- 不需要当前状态自己轮询事件

这适合做：

- 受击打断
- 死亡打断
- 紧急切相

示例：

```csharp
public class StunnedEvent : Event { }

public MyEnemyStateMachine()
    : base(
        startState: nameof(Idle),
        globalTransitions: new Dictionary<Type, string>
        {
            { typeof(StunnedEvent), nameof(Stunned) },
        },
        terrainLayer: "Terrain",
        epsilon: 0.02f,
        horizontalCornerCorrection: false,
        spriteFacingLeft: true
    ) { }
```

## `MossBeast` 中的实际使用方式

`MossBeast` 用 RingLib 主要有两种模式：

### 1. Boss 主状态机继承 `EntityStateMachine`

示例：`MossBeastStateMachine`、`BaseHorsemanStateMachine`

特点：

- 构造函数里声明起始状态和碰撞参数
- `EntityStateMachineStart()` 中做资源、组件、音频、旧 FSM 接管初始化
- 每个 Boss 技能 / 阶段都拆成 `[State]` 方法

参考文件：

- `../MossBeast/MossBeastStateMachine.cs`
- `../MossBeast/States/IntroState.cs`
- `../MossBeast/States/Choose.cs`
- `../MossBeast/States/BaseHorsemanStateMachine.cs`

### 2. 状态内通过 `yield return` 串联完整行为

例如：

- 先播动画
- 等待若干秒
- 执行消失序列子协程
- 最后切到下一状态

这比把行为拆到多个 Unity 协程 + 回调更直观。

`IntroState` 示例模式：

```csharp
[State]
private IEnumerator<Transition> IntroState()
{
    yield return new WaitFor { Seconds = 3.0f };
    yield return new CoroutineTransition { Routine = PlayDisappearSequence() };
    yield return new ToState { State = nameof(Famine) };
}
```

## 与 Hollow Knight / PlayMaker 的关系

RingLib 不替代 HK 原生 PlayMaker FSM，它更像是：

- 你自己写的 C# 行为层
- 用来承载大型 Boss / 敌人 / 子弹逻辑
- 必要时再和现有 PlayMaker FSM 交互

在 HK mod 中，常见做法是：

1. 预加载或找到原游戏对象
2. 读取原 FSM 中的 prefab、音频、变量、发射器引用
3. 禁用原 FSM 的部分控制逻辑
4. 挂上自定义 RingLib 状态机接管行为

`MossBeast` 就有这类模式，例如从旧 FSM 中提取 `roarWavePrefab` 和音乐 cue，再让自己的状态机管理完整战斗流。

## 日志注意事项

原始 RingLib 的 `Log.cs` 默认把日志发到 `UnityEngine.Debug.Log` / `LogError`。

对 HK mod 项目，更推荐：

- 将 `RingLib.Log.LoggerInfo`
- `RingLib.Log.LoggerError`

重定向到 `Modding.Logger` 或你的 `Mod.Log*` 封装。

否则诊断信息主要会落在 `Player.log`，不利于按 HK mod 常规排查。

## 集成建议

1. 默认把 RingLib 视为源码依赖，不要假设存在官方发行 DLL
2. 首次接入时优先复制最小状态机集合，而不是整包
3. 如果项目要长期使用，建议在本项目里把 `Log.cs` 改造成接入 `Modding.Logger`
4. 如果只为一个 Boss 使用，不要把整个项目都改成 RingLib 风格
5. 需要与 HK 输入系统对接时，优先使用 `InputHandler.Instance?.inputActions`，不要因为 RingLib 有 `InputManager` 就退回 `UnityEngine.Input` 风格

## 相关文件

- `third_party/RingLib/StateMachine/StateMachine.cs`
- `third_party/RingLib/StateMachine/EntityStateMachine.cs`
- `third_party/RingLib/StateMachine/Transition.cs`
- `third_party/RingLib/StateMachine/Coroutine.cs`
- `third_party/RingLib/Utils/RandomSelector.cs`
- `../MossBeast/MossBeastStateMachine.cs`
- `../MossBeast/States/IntroState.cs`
- `../MossBeast/States/Choose.cs`
