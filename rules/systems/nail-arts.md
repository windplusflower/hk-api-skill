---
title: Nail Arts Interception
impact: MEDIUM
impactDescription: Replace charged attacks with custom abilities
tags: hk-api, nail-arts, charged-attacks, cyclone
---

## Nail Arts System

### Overview

骨钉技（Nail Arts）系统由两个主要部分组成：

1. **HeroController** - 处理骨钉技的输入、充能和执行
2. **Nail Arts FSM** - 管理骨泥技的状态流转和动画播放（挂载在小骑士身上）

### Nail Art FSM States

骨钉技 FSM 的状态流转如下：

```
Inactive
  │
  └─> Can Nail Art? ──[CANCEL]──> Inactive
      │  ├─ 检查 HeroController.CanNailArt()
      │  └─ 检查是否正在 Dash
      │
      ├─[DASH CHECK]──> Has Dash? ──[CANCEL]──> Inactive
      │                  │
      │                  └─ 检查 hasUpwardSlash (冲刺劈砍)
      │
      ├─> Wallslide? ──> Has Cyclone? ──[CANCEL]──> Inactive
      │                  │
      │                  ├─ 检查 hasCyclone
      │                  └─ 检查 hasDashSlash
      │
      └─> Take Control ──> Move Choice
                          │
                          ├─[GREAT SLASH]──> Has G Slash?
                          │                  │
                          │                  ├─ 检查 hasCyclone
                          │                  └─ 检查 hasDashSlash
                          │
                          └─[CYCLONE]──> Cyclone Start
```

### Three Nail Art Types

| 剑技 | 玩家数据 Bool | FSM 检查状态 | 输入方式 |
|------|-------------|-------------|----------|
| **Dash Slash** (冲斩) | `hasUpwardSlash` | `Has Dash?` | 冲刺中按攻击 |
| **Cyclone Slash** (旋风斩) | `hasCyclone` | `Has Cyclone?` | 按住上/下 + 攻击 |
| **Great Slash** (大招) | `hasDashSlash` | `Has G Slash?` | 非冲刺时按攻击 |

> ⚠️ **注意**: 游戏开发者在命名时把强力劈砍和冲刺劈砍写反了（开发者失误）：
> - `hasUpwardSlash` = 冲刺劈砍 (Dash Slash)
> - `hasDashSlash` = 强力劈砍 (Great Slash)
> - `hasCyclone` = 旋风斩 (Cyclone Slash)

---

### Interception Methods

有两种拦截方式：

#### 方法 1: Hook HeroController (简单)

适用于简单修改，在 `CanNailArt` 或各技能启动方法处拦截：

```csharp
On.HeroController.CanNailArt += (orig, self) =>
{
    bool result = orig(self);
    
    if (IsCustomMode && result)
    {
        AttackDirection dir = GetAttackDirection(self);
        
        // Fire charged shot / custom ability
        FireChargedShot(self, dir);
        
        // Return false to block original nail art
        return false;
    }
    
    return result;
};
```

#### 方法 2: Modify FSM (精确控制)

适用于需要精确控制每种剑技的情况，在 FSM 状态中插入自定义检查：

```csharp
private void OnEnable(PlayMakerFSM fsm)
{
    if (fsm.name == "Nail Arts")
    {
        // Hook Has Dash? state
        fsm.InsertMethod("Has Dash?", 1, () =>
        {
            if (!AllowNailArt(NailArtType.DashSlash))
            {
                fsm.SendEvent("CANCEL");
            }
        });
        
        // Hook Has Cyclone? state  
        fsm.InsertMethod("Has Cyclone?", 4, () =>
        {
            if (!AllowNailArt(NailArtType.Cyclone))
            {
                fsm.SendEvent("CANCEL");
            }
        });
        
        // Hook Has G Slash? state
        fsm.InsertMethod("Has G Slash?", 4, () =>
        {
            if (!AllowNailArt(NailArtType.GreatSlash))
            {
                fsm.SendEvent("CANCEL");
            }
        });
    }
}

private bool AllowNailArt(NailArtType type)
{
    // Your custom logic here
    return true;
}
```

> ⚠️ **注意**: 使用 `InsertMethod` 时，回调会自动调用 Finish()。如果使用自定义 Action，必须在 OnEnter() 结束时调用 `Finish()`。详见 [Best Practices](./best-practices.md#fsmstateactionfinish-行为)。

---

### Cyclone Slash FSM Details

`Cyclone Start` 状态的 actions：

| Action | 说明 |
|--------|------|
| `SendMessage` | 调用 `StartCyclone(???)` |
| `Tk2dPlayAnimationWithEvents` | 播放 "NA Cyclone Start" 动画 |
| `SetFloatValue` | 重置 `Cyclone Timer` = 0 |
| `SetFloatValue` | 重置 `Timer` = 0 |
| `ListenForAttack` | 监听攻击按钮释放 (BUTTON DOWN) |

`Cyclone Spin` 状态持续播放旋转动画，`Cyclone Extend` 状态延长持续时间。

---

### Great Slash FSM Details

`Has G Slash?` 状态检查流程：

1. `GetPlayerDataBool("hasCyclone")` → `bool Has Cyclone`
2. `GetPlayerDataBool("hasDashSlash")` → `bool Has G Slash`
3. `BoolNoneTrue` - 如果两个都为 false → `Event(CANCEL)`
4. `BoolTest(Has G Slash)` - 如果为 true → 执行 Great Slash

> 注意：`Has G Slash?` 状态实际上检查的是玩家是否拥有**任意**骨钉技，然后根据输入决定执行哪种。

---

### Dash Slash FSM Details

`Has Dash?` 状态检查流程：

1. `PlayerDataBoolTest("hasUpwardSlash")` - 检查玩家是否拥有冲斩
   - `isTrue` → 继续（空事件）
   - `isFalse` → `Event(CANCEL)` 返回 Inactive

---

### Key FSM Events

| Event | 触发条件 | 目标状态 |
|-------|---------|---------|
| `CANCEL` | 检查失败 | `Inactive` |
| `DASH CHECK` | 正在 Dash | `Has Dash?` |
| `GREAT SLASH` | 输入下 + 攻击 | `Has G Slash?` 分支 |
| `CYCLONE` | 输入上 + 攻击 | `Cyclone Start` |
| `FINISHED` | 动画/动作完成 | 下一状态 |
| `BUTTON DOWN` | 攻击键按下 | `Cyclone Start` |
| `BUTTON UP` | 攻击键释放 | `Inactive` / `Regain Control` |

---

### Attack Directions

| Direction | Input | Nail Art | FSM 状态 |
|-----------|-------|----------|----------|
| `normal` | 非冲刺时按攻击 | Great Slash | `Has G Slash?` |
| `upward` | 按住上 + 攻击 | Cyclone Slash | `Has Cyclone?` |
| `downward` | 按住下 + 攻击 | Cyclone Slash | `Has Cyclone?` |
| `dashing` | 冲刺中按攻击 | Dash Slash | `Has Dash?` |

---

### Related Files

- `HeroController.cs` - 玩家控制器，包含 `CanNailArt()`, `StartCyclone()`, `StartGreatSlash()`, `StartDashSlash()`
- `PlayerData.cs` - 玩家数据存储，包含 `hasUpwardSlash`, `hasCyclone`, `hasDashSlash`
- FSM: `Nail Arts` - 骨钉技状态机（挂载在小骑士 Knight 对象上）
