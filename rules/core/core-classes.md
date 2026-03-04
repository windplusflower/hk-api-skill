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

**Charm IDs** (Common):
```csharp
const int CHARM_STRENGTH = 25;      // Fragile/Unbreakable Strength
const int CHARM_FURY = 6;           // Fury of the Fallen
const int CHARM_PRIDE = 13;         // Mark of Pride
const int CHARM_LONGNAIL = 18;      // Longnail
const int CHARM_SOUL_CATCHER = 20;  // Soul Catcher
const int CHARM_SOUL_EATER = 21;    // Soul Eater
const int CHARM_SHAMAN_STONE = 19;  // Shaman Stone
const int CHARM_SPELL_TWISTER = 33; // Spell Twister
```

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
