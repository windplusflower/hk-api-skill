---
title: Spell System Interception
impact: HIGH
impactDescription: Custom spells require FSM modification
tags: hk-api, spells, fsm, spell-control, mana
---

## Spell System

### Spell Interception Overview

Spells are controlled by the "Spell Control" FSM on HeroController. To intercept spells, you need to inject custom actions into this FSM.

### ⚠️ Important: Input Detection Timing

**Do NOT read FSM variables** (like "Pressed Up" or "Pressed Down") in your injected Action. These variables are set by `ListenForUp` / `ListenForDown` actions which can execute AFTER your injected action.

**Do NOT default to `UnityEngine.Input.GetAxisRaw()` for spell routing.** Hollow Knight gameplay input is driven through `InputHandler.Instance.inputActions` and `HeroActions`.

**Correct approach**: Read current `HeroActions` state directly, for example `inputActions.up.IsPressed`, `inputActions.down.IsPressed`, `inputActions.left.IsPressed`, `inputActions.right.IsPressed`, or `inputActions.moveVector.Vector`.

---

### FSM Injection Method

```csharp
public class SpellInterceptor
{
    private static bool _fsmModified = false;
    
    public static void Init()
    {
        ModifySpellControlFSM();
    }
    
    private static void ModifySpellControlFSM()
    {
        if (HeroController.instance == null)
        {
            GameManager.instance.StartCoroutine(RetryModify());
            return;
        }
        
        var fsm = HeroController.instance.gameObject.LocateMyFSM("Spell Control");
        if (fsm == null || _fsmModified) return;
        
        // Inject into key states
        InjectSpellAction(fsm, "Spell Choice");  // Normal spell cast
        InjectSpellAction(fsm, "QC");            // Quick Cast
        
        _fsmModified = true;
    }
    
    private static void InjectSpellAction(PlayMakerFSM fsm, string stateName)
    {
        var state = fsm.Fsm.GetState(stateName);
        if (state == null) return;
        
        var action = new CustomSpellAction();
        
        // Insert at beginning
        var newActions = new FsmStateAction[state.Actions.Length + 1];
        newActions[0] = action;
        for (int i = 0; i < state.Actions.Length; i++)
        {
            newActions[i + 1] = state.Actions[i];
        }
        state.Actions = newActions;
    }
}
```

---

### Custom Spell Action

```csharp
public class CustomSpellAction : FsmStateAction
{
    public override void OnEnter()
    {
        HeroActions? inputActions = InputHandler.Instance?.inputActions;
        bool upPressed = inputActions != null && inputActions.up.IsPressed;
        bool downPressed = inputActions != null && inputActions.down.IsPressed;
        bool leftPressed = inputActions != null && inputActions.left.IsPressed;
        bool rightPressed = inputActions != null && inputActions.right.IsPressed;

        // Determine spell type and direction.
        // Priority: Up/Down intent first, then horizontal intent, then facing direction.
        if (upPressed)
        {
            CastCustomSpell(SpellType.Shriek, Vector2.up);
        }
        else if (downPressed)
        {
            CastCustomSpell(SpellType.Quake, Vector2.down);
        }
        else
        {
            Vector2 fireballDir;
            if (rightPressed && !leftPressed)
                fireballDir = Vector2.right;
            else if (leftPressed && !rightPressed)
                fireballDir = Vector2.left;
            else
                fireballDir = HeroController.instance.cState.facingRight ? Vector2.right : Vector2.left;

            CastCustomSpell(SpellType.Fireball, fireballDir);
        }

        Fsm.Event("FSM CANCEL");
        Finish();
    }
}

public enum SpellType
{
    Fireball,  // Vengeful Spirit / Shade Soul - Left/Right
    Shriek,    // Howling Wraiths / Abyss Shriek - Upward
    Quake,     // Desolate Dive / Descending Dark - Downward
}
```

如果你完全取消了原始施法分支，需要手动补回原版的魂消耗与 UI 更新，例如 `PlayerData.TakeMP(...)` 和 `GameCameras.instance?.soulOrbFSM?.SendEvent("MP LOSE")`。

> ⚠️ **重要**: 必须调用 `Finish()`，否则 FSM 会卡住。详见 [Best Practices](../development/best-practices.md)。

---

### Spell Input Detection Reference

```csharp
HeroActions? inputActions = InputHandler.Instance?.inputActions;

if (inputActions != null && inputActions.up.IsPressed)
    // Player pressed UP -> Shriek
else if (inputActions != null && inputActions.down.IsPressed)
    // Player pressed DOWN -> Quake
else if (inputActions != null && inputActions.right.IsPressed && !inputActions.left.IsPressed)
    // Player pressed RIGHT -> Fireball Right
else if (inputActions != null && inputActions.left.IsPressed && !inputActions.right.IsPressed)
    // Player pressed LEFT -> Fireball Left
else
    // No directional input -> Fireball based on facing direction
```

---

### Spell Upgrade Status

```csharp
// Check if spells are upgraded to shade versions
bool hasShadeFireball = PlayerData.instance?.shadeFireballLevel >= 2;
bool hasShadeScream = PlayerData.instance?.shadeScreamLevel >= 2;
bool hasShadeQuake = PlayerData.instance?.shadeQuakeLevel >= 2;

// Damage multipliers
int GetSpellMultiplier(SpellType type)
{
    switch (type)
    {
        case SpellType.Fireball:
            return PlayerData.instance?.shadeFireballLevel >= 2 ? 3 : 2;
        case SpellType.Shriek:
            return PlayerData.instance?.shadeScreamLevel >= 2 ? 3 : 2;
        case SpellType.Quake:
            return PlayerData.instance?.shadeQuakeLevel >= 2 ? 3 : 2;
        default:
            return 2;
    }
}

// Shaman Stone bonus
bool hasShamanStone = PlayerData.instance?.GetBool("equippedCharm_19") ?? false;
int damageMultiplier = baseMultiplier + (hasShamanStone ? 1 : 0);
```

---

### Spell Interception Comparison

| Aspect | Original Spell | Custom Interception |
|--------|---------------|---------------------|
| Input Detection | `InputHandler` / `HeroActions` via FSM listen actions | Read current `inputActions` directly |
| Mana Cost | Automatic | Manual if you cancel the original branch |
| UI Update | Automatic | Send "MP LOSE" event |
| Animation | Automatic | May need custom |
| Cancel | - | `Fsm.Event("FSM CANCEL")` |

---

### Common Pitfalls

1. **Don't read FSM variables in injected actions** - Read `InputHandler.Instance?.inputActions` instead
2. **QC and Spell Choice both need injection** - They handle quick cast vs normal cast
3. **Fireball has two directions** - Left and Right based on input or facing
4. **Always call `Finish()`** - Or the FSM will hang
5. **If you bypass the vanilla cast branch, restore side effects manually** - Soul cost and `"MP LOSE"` will not happen by themselves

### Fallback Learning (2026-04-11)
<!-- evolution:3990162f446c -->
- Question: 修复 SpellDetectAction 法术方向判定时，HK mod 应该读取哪个输入系统
- Facts:
  - 不要在施法拦截里默认使用 UnityEngine.Input.GetAxisRaw 来判定上下法术方向，Hollow Knight 的动作输入主链是 InputHandler.Instance.inputActions / HeroActions。
  - InputHandler 会在 Awake 中初始化 inputActions = new HeroActions()，因此运行时应优先从 InputHandler/HeroActions 读取当前输入状态。
  - 原版 PlayMaker 的 ListenForUp / ListenForDown 动作也是通过 inputHandler.inputActions.up/down 的 WasPressed、WasReleased、IsPressed 来驱动 FSM 事件和布尔值。
  - 自定义 SpellDetectAction 只需要区分上、下、默认三分支时，可直接读取 inputActions.up.IsPressed 和 inputActions.down.IsPressed；DeVect 的修复已验证该模式。
- Sources:
  - `hkapi/InputHandler.cs:46`
  - `hkapi/HeroActions.cs:8`
  - `hkapi/HutongGames/PlayMaker/Actions/ListenForUp.cs:35`
  - `hkapi/HutongGames/PlayMaker/Actions/ListenForDown.cs:35`
  - `custom mod implementation: SpellDetectAction.cs:20`
  - `custom mod spec: DeVectSpellInputHandlerFixAndPush.md:20`
