# Vessel Drain

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Vessel Drain |
| GameObject Name | Vessels |
| GameObject Path | _GameCameras/HudCamera/Hud Canvas/Soul Orb/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level1 |
| Start State | Init |
| FSM PathId | 9156 |
| GameObject PathId | 791 |

## Variables

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| MP | 0 | Int32: 0 |
| MP Reserve | 0 | Int32: 0 |
| Max MP | 0 | Int32: 0 |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Particle 1 | _GameCameras/HudCamera/Hud Canvas/Soul Orb/Vessels/Particle 1 (Hollow Knight/hollow_knight_Data\level1) | NamedAssetPPtr: [_GameCameras/HudCamera/Hud Canvas/Soul Orb/Vessels/Particle 1 (Hollow Knight/hollow_knight_Data\level1)] |
| Particle 2 | _GameCameras/HudCamera/Hud Canvas/Soul Orb/Vessels/Particle 2 (Hollow Knight/hollow_knight_Data\level1) | NamedAssetPPtr: [_GameCameras/HudCamera/Hud Canvas/Soul Orb/Vessels/Particle 2 (Hollow Knight/hollow_knight_Data\level1)] |
| Particle 3 | _GameCameras/HudCamera/Hud Canvas/Soul Orb/Vessels/Particle 3 (Hollow Knight/hollow_knight_Data\level1) | NamedAssetPPtr: [_GameCameras/HudCamera/Hud Canvas/Soul Orb/Vessels/Particle 3 (Hollow Knight/hollow_knight_Data\level1)] |
| Particle 4 | _GameCameras/HudCamera/Hud Canvas/Soul Orb/Vessels/Particle 4 (Hollow Knight/hollow_knight_Data\level1) | NamedAssetPPtr: [_GameCameras/HudCamera/Hud Canvas/Soul Orb/Vessels/Particle 4 (Hollow Knight/hollow_knight_Data\level1)] |
| Particle Fill | _GameCameras/HudCamera/Hud Canvas/Soul Orb/Vessels/Particle Fill (Hollow Knight/hollow_knight_Data\level1) | NamedAssetPPtr: [_GameCameras/HudCamera/Hud Canvas/Soul Orb/Vessels/Particle Fill (Hollow Knight/hollow_knight_Data\level1)] |

## States

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

(none)

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Idle | 0 | |

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Particle 1 |   |   |
| emission |   | false |   |   |

##### 2. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Particle 2 |   |   |
| emission |   | false |   |   |

##### 3. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Particle 3 |   |   |
| emission |   | false |   |   |

##### 4. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Particle 4 |   |   |
| emission |   | false |   |   |

##### 5. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Particle Fill |   |   |
| emission |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| MP DRAIN | Drain Pause | 0 | |
| SOUL LIMITER DOWN | Drain Pause | 0 | |

### Drain Pause

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Particle 1 |   |   |
| emission |   | false |   |   |

##### 2. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Particle 2 |   |   |
| emission |   | false |   |   |

##### 3. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Particle 3 |   |   |
| emission |   | false |   |   |

##### 4. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Particle 4 |   |   |
| emission |   | false |   |   |

##### 5. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Particle Fill |   |   |
| emission |   | false |   |   |

##### 6. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 1f |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| MP DRAIN | Reset Pause | 0 | |
| FINISHED | Particle Check | 0 | |
| SOUL LIMITER DOWN | Reset Pause | 0 | |

### Reset Pause

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

(none)

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Drain Pause | 0 | |

### Drain

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 4

#### Actions

##### 1. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| intName |   | "MPReserve" |   |   |
| storeValue |   | int MP Reserve | Variable |   |

##### 2. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| intName |   | "maxMP" |   |   |
| storeValue |   | int Max MP | Variable |   |

##### 3. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int MP Reserve |   |   |
| integer2 |   | 0 |   |   |
| equal |   | Event(CANCEL) |   |   |
| lessThan |   | Event(CANCEL) |   |   |
| greaterThan |   | Event() |   |   |
| everyFrame |   | false |   |   |

##### 4. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| intName |   | "MPCharge" |   |   |
| storeValue |   | int MP | Variable |   |

##### 5. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int MP |   |   |
| integer2 |   | int Max MP |   |   |
| equal |   | Event(CANCEL) |   |   |
| lessThan |   | Event() |   |   |
| greaterThan |   | Event(CANCEL) |   |   |
| everyFrame |   | false |   |   |

##### 6. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Hero |   |   |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |   |   |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |   |   |
| functionCall |   | AddMPChargeSpa(1) |   |   |

##### 7. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Hero |   |   |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |   |   |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |   |   |
| functionCall |   | TakeReserveMP(1) |   |   |

##### 8. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 0.005f |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| MP DRAIN | Drain Pause | 0 | |
| CANCEL | Idle | 0 | |
| FINISHED | Drain Recheck | 0 | |
| SOUL LIMITER DOWN | Drain Pause | 0 | |

### Drain Recheck

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

(none)

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Particle Check | 0 | |

### Particle Check

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 4

#### Actions

##### 1. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Particle Fill |   |   |
| emission |   | true |   |   |

##### 2. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| intName |   | "MPReserve" |   |   |
| storeValue |   | int MP Reserve | Variable |   |

##### 3. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int MP Reserve |   |   |
| integer2 |   | 34 |   |   |
| equal |   | Event() |   |   |
| lessThan |   | Event(1) |   |   |
| greaterThan |   | Event() |   |   |
| everyFrame |   | false |   |   |

##### 4. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int MP Reserve |   |   |
| integer2 |   | 67 |   |   |
| equal |   | Event() |   |   |
| lessThan |   | Event(2) |   |   |
| greaterThan |   | Event() |   |   |
| everyFrame |   | false |   |   |

##### 5. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int MP Reserve |   |   |
| integer2 |   | 100 |   |   |
| equal |   | Event() |   |   |
| lessThan |   | Event(3) |   |   |
| greaterThan |   | Event() |   |   |
| everyFrame |   | false |   |   |

##### 6. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int MP Reserve |   |   |
| integer2 |   | 133 |   |   |
| equal |   | Event() |   |   |
| lessThan |   | Event(4) |   |   |
| greaterThan |   | Event() |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| 1 | 1 | 0 | |
| 2 | 2 | 0 | |
| 3 | 3 | 0 | |
| 4 | 4 | 0 | |

### 1

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Particle 1 |   |   |
| emission |   | true |   |   |

##### 2. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Particle 2 |   |   |
| emission |   | false |   |   |

##### 3. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Particle 3 |   |   |
| emission |   | false |   |   |

##### 4. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Particle 4 |   |   |
| emission |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Drain | 0 | |

### 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Particle 2 |   |   |
| emission |   | true |   |   |

##### 2. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Particle 1 |   |   |
| emission |   | false |   |   |

##### 3. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Particle 3 |   |   |
| emission |   | false |   |   |

##### 4. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Particle 4 |   |   |
| emission |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Drain | 0 | |

### 3

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Particle 3 |   |   |
| emission |   | true |   |   |

##### 2. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Particle 2 |   |   |
| emission |   | false |   |   |

##### 3. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Particle 1 |   |   |
| emission |   | false |   |   |

##### 4. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Particle 4 |   |   |
| emission |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Drain | 0 | |

### 4

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Particle 4 |   |   |
| emission |   | true |   |   |

##### 2. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Particle 2 |   |   |
| emission |   | false |   |   |

##### 3. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Particle 3 |   |   |
| emission |   | false |   |   |

##### 4. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Particle 1 |   |   |
| emission |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Drain | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| 1 | false |
| 2 | false |
| 3 | false |
| 4 | false |
| CANCEL | false |
| FINISHED | false |
| MP DRAIN | false |
| SOUL LIMITER DOWN | false |

