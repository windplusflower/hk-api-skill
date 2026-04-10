# Run Effects

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Run Effects |
| GameObject Name | Run Effects |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Check Enviro |
| FSM PathId | 21016 |
| GameObject PathId | 3917 |

## Variables

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Environment Type | 0 | Int32: 0 |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Bone | Run Effects/Bone (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets) | NamedAssetPPtr: Run Effects/Bone (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets) |
| Dust | Run Effects/Dust (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets) | NamedAssetPPtr: Run Effects/Dust (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets) |
| Grass | Run Effects/Grass (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets) | NamedAssetPPtr: Run Effects/Grass (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets) |
| Particle | [null] | NamedAssetPPtr:  |
| Particle 2 | [null] | NamedAssetPPtr:  |
| Wet | Run Effects/Wet (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets) | NamedAssetPPtr: Run Effects/Wet (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets) |

## States

### Check Enviro

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 8

#### Actions

##### 1. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Bone | OwnerDefault Bone |  |  |
| emission | false | false |  |  |

##### 2. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Dust | OwnerDefault Dust |  |  |
| emission | false | false |  |  |

##### 3. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Wet | OwnerDefault Wet |  |  |
| emission | false | false |  |  |

##### 4. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Grass | OwnerDefault Grass |  |  |
| emission | false | false |  |  |

##### 5. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "environmentType" | "environmentType" |  |  |
| storeValue | int Environment Type | int Environment Type | Variable |  |

##### 6. IntSwitch

Full Name: HutongGames.PlayMaker.Actions.IntSwitch
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Environment Type | int Environment Type | Variable |  |
| compareTo | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| sendEvent | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| everyFrame | false | false |  |  |

### Dust

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Dust" | "Dust" |  |  |
| storeResult | GameObject Particle | GameObject Particle | Variable |  |

##### 2. SetGameObject

Full Name: HutongGames.PlayMaker.Actions.SetGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variable | GameObject Particle 2 | GameObject Particle 2 | Variable |  |
| gameObject |  |  |  |  |
| everyFrame | false | false |  |  |

### Play

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. PlayParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.PlayParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Particle | OwnerDefault Particle |  |  |
| emit | 0 | 0 |  |  |

##### 2. PlayParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.PlayParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Particle 2 | OwnerDefault Particle 2 |  |  |
| emit | 0 | 0 |  |  |

##### 3. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Particle | OwnerDefault Particle |  |  |
| emission | true | true |  |  |

##### 4. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Particle 2 | OwnerDefault Particle 2 |  |  |
| emission | true | true |  |  |

### End

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. StopParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.StopParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Particle | OwnerDefault Particle |  |  |

##### 2. StopParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.StopParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Particle 2 | OwnerDefault Particle 2 |  |  |

##### 3. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 2f | 2f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Grass

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Grass" | "Grass" |  |  |
| storeResult | GameObject Particle | GameObject Particle | Variable |  |

##### 2. SetGameObject

Full Name: HutongGames.PlayMaker.Actions.SetGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variable | GameObject Particle 2 | GameObject Particle 2 | Variable |  |
| gameObject |  |  |  |  |
| everyFrame | false | false |  |  |

### Bone

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Dust" | "Dust" |  |  |
| storeResult | GameObject Particle | GameObject Particle | Variable |  |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Bone" | "Bone" |  |  |
| storeResult | GameObject Particle 2 | GameObject Particle 2 | Variable |  |

### Recycle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. RecycleSelf

Full Name: HutongGames.PlayMaker.Actions.RecycleSelf
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

### Wet

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Wet" | "Wet" |  |  |
| storeResult | GameObject Particle | GameObject Particle | Variable |  |

##### 2. SetGameObject

Full Name: HutongGames.PlayMaker.Actions.SetGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variable | GameObject Particle 2 | GameObject Particle 2 | Variable |  |
| gameObject |  |  |  |  |
| everyFrame | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Check Enviro | DUST | Dust | 0 | 0 | 0 |
| Check Enviro | GRASS | Grass | 0 | 0 | 0 |
| Check Enviro | BONE | Bone | 0 | 0 | 0 |
| Check Enviro | SPA | Wet | 0 | 0 | 0 |
| Check Enviro | METAL | Dust | 0 | 0 | 0 |
| Check Enviro | RUN STOP | End | 0 | 0 | 0 |
| Check Enviro | WET | Wet | 0 | 0 | 0 |
| Check Enviro | FINISHED | Dust | 0 | 0 | 0 |
| Dust | FINISHED | Play | 0 | 0 | 0 |
| Play | RUN STOP | End | 0 | 0 | 0 |
| Play | ENVIRO UPDATE | Check Enviro | 0 | 0 | 0 |
| End | FINISHED | Recycle | 0 | 0 | 0 |
| Grass | FINISHED | Play | 0 | 0 | 0 |
| Bone | FINISHED | Play | 0 | 0 | 0 |
| Wet | FINISHED | Play | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| BONE | false |
| DUST | false |
| ENVIRO UPDATE | false |
| GRASS | false |
| METAL | false |
| RUN STOP | false |
| SPA | false |
| WET | false |

