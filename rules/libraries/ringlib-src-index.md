# RingLib Source Index

本文件用于快速定位 skill 中内置的 `RingLib` 源码。

源码根目录：`third_party/RingLib/`

## Core

- `third_party/RingLib/StateMachine/StateMachine.cs`
  - `StateMachine`
  - `Event`
  - `StateAttribute`
- `third_party/RingLib/StateMachine/Transition.cs`
  - `Transition`
  - `StateTransition`
  - `NoTransition`
  - `ToState`
  - `CoroutineTransition`
  - `WaitFor`
  - `WaitForRealtime`
  - `WaitTill`
  - `Wait`
- `third_party/RingLib/StateMachine/Coroutine.cs`
  - RingLib 自定义协程执行器
- `third_party/RingLib/StateMachine/StateCollector.cs`
  - `[State]` 反射收集
- `third_party/RingLib/StateMachine/EntityStateMachine.cs`
  - 2D 实体扩展状态机
- `third_party/RingLib/StateMachine/GameObjectExtension.cs`
  - GameObject 树内事件广播

## Utilities

- `third_party/RingLib/Utils/RandomSelector.cs`
  - 带权重、连发限制、保底 miss 的选择器
- `third_party/RingLib/Utils/RingAnimator.cs`
  - `Animator` 封装与可 `yield` 动画流程
- `third_party/RingLib/Utils/InputManager.cs`
  - 连续输入、瞬时输入、输入缓冲、互斥输入组
- `third_party/RingLib/Utils/ColliderRenderer.cs`
  - 碰撞体可视化调试

## Entity Helpers

- `third_party/RingLib/EntityManagement/DestroyAfterSeconds.cs`
- `third_party/RingLib/EntityManagement/DeactivateOnStart.cs`

## Specialized Entities

- `third_party/RingLib/Entities/Water/Water.cs`
- `third_party/RingLib/Entities/Water/WaterSegment.cs`

## Basic Runtime Files

- `third_party/RingLib/Log.cs`
- `third_party/RingLib/Config.cs`
