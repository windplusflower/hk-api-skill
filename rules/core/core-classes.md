---
title: Core Game Classes Reference
impact: HIGH
impactDescription: Essential classes for all HK mod development
tags: hk-api, core-classes, hero-controller, player-data, health-manager
---

## Core Game Classes

### HeroController

**Purpose**: Main player character controller

**Location**: `HeroController.cs`

**Key Members**:
```csharp
public static HeroController instance;  // Global access
public Transform transform;              // Position/movement

// Core actions
public void Attack(AttackDirection dir);
public void Jump();
public void AddMPCharge(int amount);     // Add soul
```

**Common Usage**:
```csharp
// Always check for null
if (HeroController.instance != null)
{
    Vector3 pos = HeroController.instance.transform.position;
    HeroController.instance.AddMPCharge(11);  // Add soul
}
```

---

### PlayerData

**Purpose**: Persistent player data and game state

**Location**: `PlayerData.cs`

**Key Members**:
```csharp
public static PlayerData instance;

// Data access methods
public bool GetBool(string id);
public int GetInt(string id);
public void SetBool(string id, bool value);

// Common fields
public int nailDamage;
public int MPCharge;        // Current soul
public int maxMP;           // Maximum soul
```

**护符检测**：关于护符 ID 的完整列表和检测方法，请参考 [Item IDs](item-ids.md#护符检测)

---

### HealthManager

**Purpose**: Enemy health and damage handling

**⚠️ Required Components** (must be added BEFORE HealthManager):
- `SpriteRenderer` - Sprite rendering
- `tk2dSpriteAnimator` - Animation control
- `SpriteFlash` - Hit flash effect
- `ParticleSystem` - Hit effect (optional)
- `AudioSource` - Hit sound (optional)

**Location**: `HealthManager.cs`

**Key Members**:
```csharp
public int hp;                          // Current HP
public int maxHP;                       // Maximum HP
public bool isDead;                     // Death state

public void Hit(HitInstance hitInstance);
void ApplyExtraDamage(int damage);
void Die(float? attackDirection, AttackTypes attackType, bool ignoreKill, bool doKillFreeze = true);

// Events
event Action OnDeath;                   // Subscribe to death event
```

**Setup Order** (Important!):
```csharp
// 1. Add rendering components FIRST
var sprite = enemy.AddComponent<SpriteRenderer>();
var animator = enemy.AddComponent<tk2dSpriteAnimator>();
var spriteFlash = enemy.AddComponent<SpriteFlash>();

// 2. Add HealthManager LAST
var healthManager = enemy.AddComponent<HealthManager>();
healthManager.hp = 5;
healthManager.maxHP = 5;
healthManager.OnDeath += () => {
    // Death logic
};
```

**Damage Example**:
```csharp
HitInstance hit = new HitInstance
{
    DamageDealt = damage,
    Source = HeroController.instance?.gameObject,
    AttackType = AttackTypes.Nail,
    Direction = 0f,
    Multiplier = 1f,
};
healthManager.Hit(hit);
```

**⚠️ Common Mistake**:
Adding HealthManager without required components will cause null reference errors when the enemy takes damage.

---

### DamageHero

**Purpose**: Component for damaging the player

**Location**: Attached to enemy GameObjects

**Key Members**:
```csharp
public int damageDealt = 1;     // Contact damage amount
public bool hazard = false;     // Is hazard (respawn instead of taking damage)
```

**Usage**:
```csharp
var damager = gameObject.GetComponent<DamageHero>() 
    ?? gameObject.AddComponent<DamageHero>();
damager.damageDealt = 2;  // 2 masks damage
```

---

### PlayMakerFSM

**Purpose**: HK's state machine system

**Location**: `PlayMakerFSM.cs`

**Key Members**:
```csharp
public void SendEvent(string eventName);
public void ChangeState(string stateName);
public FsmVariables FsmVariables;  // Variable access

// Common usage
var fsm = gameObject.LocateMyFSM("FSM Name");
fsm.SendEvent("Event Name");
```

**参考文档**: [FSM Reference](fsm-reference.md) - 完整的 FSM 操作示例和常用 FSM 列表

---

### HitInstance

**Purpose**: Damage instance structure

**Location**: `HitInstance.cs`

**Key Fields**:
```csharp
public int DamageDealt;
public GameObject Source;
public AttackTypes AttackType;      // Nail, Spell, Generic
public float Direction;              // Hit direction
public float Multiplier;
public float MagnitudeMultiplier;
public SpecialTypes SpecialType;
```

---

### BossSceneController

**Purpose**: Control boss fight state and difficulty

**Location**: `BossSceneController.cs`

**Key Members**:
```csharp
public static BossSceneController Instance;  // Global access
public int BossLevel;  // 0 = Normal, >0 = Boss Rush

// Usage
if (BossSceneController.Instance.BossLevel > 0)
{
    // Boss Rush / Challenge mode
}
```

---

### CameraController

**Purpose**: Control game camera

**Location**: `CameraController.cs`

**Key Members**:
```csharp
public enum CameraMode { LOCKED, FROZEN, FOLLOW }

public CameraMode mode;  // Set to control camera behavior

// Lock camera position via reflection
var xLockField = typeof(CameraController).GetField("xLockPos", BindingFlags.Instance | BindingFlags.NonPublic);
var yLockField = typeof(CameraController).GetField("yLockPos", BindingFlags.Instance | BindingFlags.NonPublic);
xLockField?.SetValue(camCtrl, fixedCameraX);
yLockField?.SetValue(camCtrl, fixedCameraY);
```

**GameCameras for zoom control**:
```csharp
// tk2dCam for zoom
GameCameras.instance.tk2dCam.ZoomFactor = 0.82f;

// Hook camera update
On.CameraController.LateUpdate += CameraLateUpdateHook;
```

### Fallback Learning (2026-05-01)
<!-- evolution:4e5af439e9d5 -->
- Question: How can an HK mod derive the hero feet line for aura placement?
- Facts:
  - HeroController caches Rigidbody2D, Collider2D, Transform, and MeshRenderer directly from the hero GameObject during setup.
  - Mods can read HeroController.instance.gameObject collider and renderer bounds directly to derive hero feet and visible height without searching child objects.
- Sources:
  - `hkapi/HeroController.cs:4504`
  - `hkapi/HeroController.cs:4508`

### Fallback Learning (2026-06-13)
<!-- evolution:adb98ee2e8f9 -->
- Question: How does Hollow Knight decide whether to show completion percentage on the ending screen versus normal UI?
- Facts:
  - End_Game_Completion uses GameCompletionScreen.Start, calls PlayerData.CountGameCompletion, and writes SaveStats.GetCompletionPercentage directly to percentageNumber.
  - SaveStats.GetCompletionPercentage only formats completionPercentage with a percent sign; it does not check unlockedCompletionRate.
  - Save-slot UI hides completionText unless SaveStats.unlockedCompletionRate is true.
  - The Black Egg Temple lore tablet in Room_Final_Boss_Atrium has Completion Rate Prompt=true and sets PlayerData bool unlockedCompletionRate to true.
  - Inventory and Journal FSMs test unlockedCompletionRate before activating their completion text.
- Sources:
  - `hkapi/GameCompletionScreen.cs:10`
  - `hkapi/SaveStats.cs:94`
  - `hkapi/UnityEngine/UI/SaveSlotButton.cs:642`
  - `fsm-export/Ungrouped/Room_Final_Boss_Atrium.unity/Tut_tablet_top__Inspection__fsm_2211.md:38`
  - `fsm-export/Ungrouped/Room_Final_Boss_Atrium.unity/Tut_tablet_top__Inspection__fsm_2211.md:1952`
  - `fsm-export/Ungrouped/Menu_Title.unity/Inv__UI_Inventory__fsm_9127.md:7675`
  - `fsm-export/Ungrouped/Menu_Title.unity/Journal__UI_Journal__fsm_8969.md:202`

### Fallback Learning (2026-07-19)
<!-- evolution:fd8d21d62fe0 -->
- Question: 空洞骑士二段跳后冲刺贴墙，冲刺结束并下滑后墙跳只有横向速度而纵向自由下落的原因？
- Facts:
  - Jump() 仅在 jump_steps <= JUMP_STEPS 时持续写入 JUMP_SPEED，并逐次递增 jump_steps；CancelJump() 才会把 jump_steps 清零。
  - DoDoubleJump() 直接把 cState.jumping 设为 false 并开启 doubleJumping，却不调用 CancelJump()，因此一段跳的 jump_steps 可以被保留下来。
  - JumpReleased() 只有在当前纵向速度大于 0 且 jumped_steps 达到最小值时才调用 CancelJump()；若一直按住跳直到冲刺把纵速写成 0 或角色开始下落，之后松键不会清除残留 jump_steps。
  - DoWallJump() 会重置 jumped_steps 但不重置 jump_steps；残留计数达到或超过 JUMP_STEPS 时，墙跳的竖直推力会极短或完全不产生。
  - 墙跳横向速度由 wallLocked 独立写入并持续最多 WJLOCK_STEPS_LONG 个物理步，动画也仅凭 wallLocked 选择 Walljump，因此会出现横速和动作正常但纵向自由下落。
  - BackOnGround() 明确把 jump_steps 设为 0，所以落地后该异常解除。
- Sources:
  - `hkapi/HeroController.cs:628`
  - `hkapi/HeroController.cs:640`
  - `hkapi/HeroController.cs:2945`
  - `hkapi/HeroController.cs:3497`
  - `hkapi/HeroController.cs:3706`
  - `hkapi/HeroController.cs:2903`
  - `hkapi/HeroController.cs:3690`
  - `hkapi/HeroController.cs:396`
  - `hkapi/HeroAnimationController.cs:332`

### Fallback Learning (2026-07-19)
<!-- evolution:72035d23c02c -->
- Question: jump_steps 污染除了落地外，原版哪些情况会恢复正常？
- Facts:
  - HeroController 中 jump_steps 清零只有两个实现入口：CancelJump() 和 BackOnGround()；其他恢复路径都必须间接到达其中之一。
  - 一次异常墙跳会把 cState.jumping 重新设为 true，随后 Jump() 在残留计数超过 JUMP_STEPS 时调用 CancelJump()；因此当前墙跳仍异常，但计数通常已为下一次墙跳清零。
  - JumpReleased() 在纵向速度大于 0、jumped_steps 达到 JUMP_STEPS_MIN、且不在酸液或蘑菇弹跳状态时调用 CancelJump()；所以污染后重新获得向上速度并保持跳跃键松开也能恢复。
  - RecoilDown() 无条件调用 CancelJump()；原版向上挥砍击中地形或可受击对象可进入该路径。
  - 受伤硬直、死亡或刺酸等危险死亡、重生、场景进入、梦门进入、脚本收走控制权和地形侵入保护等流程通过 ResetMotion()/ResetMotionNotVelocity() 间接调用 CancelJump()。
  - 头顶碰撞只在 cState.jumping 为 true 时调用 CancelJump()；处于休眠污染但 jumping 为 false 时，单纯碰天花板不会清除。
  - 结束冲刺、继续滑墙、离墙、CancelDoubleJump、普通横向受击后坐以及在纵速小于等于零时松开跳跃，都不会清除 jump_steps。
- Sources:
  - `hkapi/HeroController.cs:628`
  - `hkapi/HeroController.cs:645`
  - `hkapi/HeroController.cs:3497`
  - `hkapi/HeroController.cs:3626`
  - `hkapi/HeroController.cs:3642`
  - `hkapi/HeroController.cs:3673`
  - `hkapi/HeroController.cs:3706`
  - `hkapi/HeroController.cs:1747`
  - `hkapi/HeroController.cs:3252`
  - `hkapi/HeroController.cs:4333`

### Fallback Learning (2026-07-19)
<!-- evolution:7460787e4983 -->
- Question: 玩家在正常游戏中可以主动执行哪些操作来清除 jump_steps 污染？
- Facts:
  - Knight 的 Spell Control FSM 在 Focus Start、Fireball Antic、Quake Antic、Scream Antic 等状态调用 RelinquishControl()；聚集和全部主动法术会通过 ResetMotion() 清除 jump_steps。
  - Knight 的 Nail Arts FSM 在 Take Control 与 DSlash Start 调用 RelinquishControlNotVelocity()；旋风斩、蓄力斩和冲刺斩均会清除 jump_steps。
  - Knight 的 Superdash FSM 在开始蓄力前的 Relinquish Control 状态调用 RelinquishControl()；从地面或墙面开始水晶冲刺蓄力会清除 jump_steps。
  - Knight 的 Dream Nail FSM 在 Take Control 状态调用 RelinquishControl()，梦之钉会清除 jump_steps；但原版 CanDreamNail 要求 onGround。
  - 玩家还可通过异常墙跳自身的 Jump() 超限、正向速度期间松开跳跃、向上挥砍触发 RecoilDown、受伤、场景切换、危险重生或退出重载来清除污染。
- Sources:
  - `fsm-export/Data/Knight_Pickup.unity/Knight__Spell_Control__fsm_909.md:291`
  - `fsm-export/Data/Knight_Pickup.unity/Knight__Spell_Control__fsm_909.md:430`
  - `fsm-export/Data/Knight_Pickup.unity/Knight__Nail_Arts__fsm_918.md:349`
  - `fsm-export/Data/Knight_Pickup.unity/Knight__Nail_Arts__fsm_918.md:1525`
  - `fsm-export/Data/Knight_Pickup.unity/Knight__Superdash__fsm_944.md:798`
  - `fsm-export/Data/Knight_Pickup.unity/Knight__Dream_Nail__fsm_964.md:582`
  - `hkapi/HeroController.cs:2432`
  - `hkapi/HeroController.cs:2474`
  - `hkapi/HeroController.cs:2480`
