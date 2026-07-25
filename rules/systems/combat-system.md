---
title: Combat System Mechanics
impact: HIGH
impactDescription: Understanding damage and hit detection is crucial
tags: hk-api, combat, damage, hit-detection, attacks
---

## Combat System

### HitTaker Hook

**Purpose**: Intercept all damage dealt in the game

**Location**: Global hook point

**Usage**:
```csharp
On.HitTaker.Hit += (orig, target, hitInstance, depth) =>
{
    // Check for custom component
    var customEnemy = target.GetComponent<CustomEnemy>();
    if (customEnemy != null)
    {
        customEnemy.TakeDamage(hitInstance.DamageDealt);
        
        // Play hit sound (with cooldown)
        if (Time.time - lastHitTime >= 0.2f)
        {
            lastHitTime = Time.time;
            PlayHitSound();
        }
        
        // Trigger soul gain (if nail attack)
        if (hitInstance.AttackType == AttackTypes.Nail)
        {
            ApplySoulGain();
        }
        return;  // Don't call orig for custom enemies
    }
    
    orig(target, hitInstance, depth);
};
```

---

### Attack Interception

**Hook Attack Method**:
```csharp
On.HeroController.Attack += (orig, self, dir) =>
{
    if (ShouldIntercept)
    {
        FireCustomBullet(self, dir);
        // return;  // Uncomment to block original
    }
    
    orig(self, dir);
};
```

**Control Attack Animation**:
```csharp
On.HeroController.DoAttack += (orig, self) =>
{
    orig(self);
    
    // Control slash visibility
    string[] slashFields = { "slashComponent", "normalSlash", "upSlash", "downSlash" };
    foreach (string fieldName in slashFields)
    {
        try
        {
            object rawObj = ReflectionHelper.GetField<HeroController, object>(self, fieldName);
            if (rawObj == null) continue;
            
            bool shouldShowSlash = !IsCustomMode;
            
            if (rawObj is GameObject go)
                go.SetActive(shouldShowSlash);
            else if (rawObj is MonoBehaviour mb)
                mb.gameObject.SetActive(shouldShowSlash);
        }
        catch { }
    }
};
```

---

### Complete Damage Example

```csharp
void DealDamageToEnemy(Collider2D target, int damage, float direction)
{
    var hm = target.GetComponentInParent<global::HealthManager>();
    if (hm != null && !hm.isDead)
    {
        HitInstance hi = new HitInstance
        {
            DamageDealt = damage,
            Source = HeroController.instance?.gameObject,
            AttackType = AttackTypes.Nail,
            Direction = direction,
            Multiplier = 1f,
            MagnitudeMultiplier = 1f,
            SpecialType = SpecialTypes.None,
        };
        
        hm.Hit(hi);
        if (hm.hp > 0)
            hm.ApplyExtraDamage(0);
    }
}
```

---

### Attack Types

| Type | Description |
|------|-------------|
| `AttackTypes.Nail` | Nail/weapon attacks |
| `AttackTypes.Spell` | Spell attacks |
| `AttackTypes.Generic` | Other damage sources |

---

### InfectedEnemyEffects

**Purpose**: Visual/audio effects for infected enemies

**Location**: `InfectedEnemyEffects.cs`

**Key Members**:
```csharp
public AudioEvent impactAudio;  // Hit sound effect
public void RecieveHitEffect(); // Called on hit
```

**AudioEvent Structure**:
```csharp
public struct AudioEvent
{
    public float PitchMin;    // Default: 0.75
    public float PitchMax;    // Default: 1.25
    public float Volume;      // Default: 1.0
}
```

### Fallback Learning (2026-06-14)
<!-- evolution:dd5ff006ee62 -->
- Question: How do enemy contact and weapon hitboxes damage the Knight?
- Facts:
  - HeroBox checks the Collider2D GameObject that touched the hero; if that object has a damages_hero FSM, the FSM damageDealt and hazardType variables are used.
  - If no damages_hero FSM is present, HeroBox reads DamageHero from the same Collider2D GameObject, so adding DamageHero only to a parent object does not make child weapon colliders hurt the hero.
  - DamageHero defaults to damageDealt=1 and hazardType=1, and resetOnEnable can reset damageDealt when the component is enabled.
- Sources:
  - `hkapi/HeroBox.cs:35`
  - `hkapi/HeroBox.cs:37`
  - `hkapi/HeroBox.cs:57`
  - `hkapi/DamageHero.cs:5`
  - `hkapi/DamageHero.cs:22`

### Fallback Learning (2026-06-27)
<!-- evolution:fbce4bf1c09d -->
- Question: Why can an enemy take damage but miss directional hit recoil events?
- Facts:
  - HealthManager.Hit returns while evasionByHitRemaining is positive; NonFatalHit sets that timer to 0.2 seconds for normal non-fatal hits.
  - HealthManager.TakeDamage sends HIT and TOOK DAMAGE, then calls Recoil.RecoilByDirection when a Recoil component is present.
  - Recoil.Reset gives the component a default recoilDuration of 0.5 seconds, and RecoilByDirection returns immediately unless the Recoil state is Ready.
  - When RecoilByDirection runs while Ready, it emits directional FSM events HIT RIGHT, HIT UP, HIT LEFT, or HIT DOWN to the owner GameObject.
- Sources:
  - `hkapi/HealthManager.cs:126`
  - `hkapi/HealthManager.cs:130`
  - `hkapi/HealthManager.cs:136`
  - `hkapi/HealthManager.cs:249`
  - `hkapi/HealthManager.cs:251`
  - `hkapi/HealthManager.cs:258`
  - `hkapi/HealthManager.cs:343`
  - `hkapi/Recoil.cs:47`
  - `hkapi/Recoil.cs:85`
  - `hkapi/Recoil.cs:111`
  - `hkapi/Recoil.cs:114`
  - `hkapi/Recoil.cs:118`
  - `hkapi/Recoil.cs:121`
