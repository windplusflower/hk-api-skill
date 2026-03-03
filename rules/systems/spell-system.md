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

**Do NOT read FSM variables** (like "Pressed Up" or "Pressed Down") in your injected Action. These variables are set by ListenForUp/ListenForDown actions which execute AFTER your injected action.

**Correct approach**: Use `Input.GetAxisRaw()` to read input directly.

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
        // Get input axes directly (DO NOT read FSM variables!)
        float verticalInput = UnityEngine.Input.GetAxisRaw("Vertical");
        float horizontalInput = UnityEngine.Input.GetAxisRaw("Horizontal");
        
        // Determine spell type and direction
        // Priority: Vertical input (Shriek/Quake) > Horizontal input (Fireball direction)
        if (verticalInput > 0.1f)
        {
            // Shriek - upward
            CastCustomSpell(SpellType.Shriek, Vector2.up);
        }
        else if (verticalInput < -0.1f)
        {
            // Quake - downward
            CastCustomSpell(SpellType.Quake, Vector2.down);
        }
        else
        {
            // Fireball - horizontal
            // Check horizontal input first, then fallback to facing direction
            Vector2 fireballDir;
            if (horizontalInput > 0.1f)
                fireballDir = Vector2.right;
            else if (horizontalInput < -0.1f)
                fireballDir = Vector2.left;
            else
                fireballDir = HeroController.instance.cState.facingRight ? Vector2.right : Vector2.left;
            
            CastCustomSpell(SpellType.Fireball, fireballDir);
        }
        
        // Cancel original spell
        Fsm.Event("FSM CANCEL");
        
        // Consume mana manually
        bool hasSpellTwister = PlayerData.instance?.GetBool("equippedCharm_33") ?? false;
        int manaCost = hasSpellTwister ? 22 : 33;
        PlayerData.instance?.TakeMP(manaCost);
        GameCameras.instance?.soulOrbFSM?.SendEvent("MP LOSE");
        
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

> ⚠️ **重要**: 必须调用 `Finish()`，否则 FSM 会卡住。详见 [Best Practices](./best-practices.md#fsmstateactionfinish-行为)。

---

### Spell Input Detection Reference

```csharp
// Detection priority (from QC/Spell Choice state logic)
float vertical = Input.GetAxisRaw("Vertical");
float horizontal = Input.GetAxisRaw("Horizontal");

if (vertical > 0.1f)
    // Player pressed UP -> Shriek
else if (vertical < -0.1f)  
    // Player pressed DOWN -> Quake
else if (horizontal > 0.1f)
    // Player pressed RIGHT -> Fireball Right
else if (horizontal < -0.1f)
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
| Input Detection | FSM variables | `Input.GetAxisRaw()` |
| Mana Cost | Automatic | Manual (22 or 33) |
| UI Update | Automatic | Send "MP LOSE" event |
| Animation | Automatic | May need custom |
| Cancel | - | `Fsm.Event("FSM CANCEL")` |

---

### Common Pitfalls

1. **Don't read FSM variables in injected actions** - Use `Input.GetAxisRaw()` instead
2. **QC and Spell Choice both need injection** - They handle quick cast vs normal cast
3. **Fireball has two directions** - Left and Right based on input or facing
4. **Always call `Finish()`** - Or the FSM will hang
