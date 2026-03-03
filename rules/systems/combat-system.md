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
