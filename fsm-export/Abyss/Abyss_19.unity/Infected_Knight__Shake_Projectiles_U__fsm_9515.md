# Shake Projectiles U

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Shake Projectiles U |
| GameObject Name | Infected Knight |
| GameObject Path |   |
| Source Asset | D:/SteamLibrary/steamapps/common/Hollow Knight/hollow_knight_Data/level343 |
| Start State | Idle |
| FSM PathId | 9515 |
| GameObject PathId | 78 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Multiplier | 1 | Single: 1 |
| Prev Speed | 0 | Single: 0 |
| X Velocity | 0 | Single: 0 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Adjacent 1 | false | Boolean: false |
| Adjacent 2 | false | Boolean: false |
| Prev Adjacent | false | Boolean: false |
| Was Adjacent | false | Boolean: false |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Projectile | [null] | NamedAssetPPtr: [null] |
| Self | [null] | NamedAssetPPtr: [null] |

## States

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetOwner

Full Name: HutongGames.PlayMaker.Actions.GetOwner
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeGameObject |   | GameObject Self | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| SHAKE START | Spawn | 0 | |

### Spawn

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [IK Projectile SH (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\sharedassets343.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| position |   | Vector3(0, 0, 0) |   |   |
| rotation |   | Vector3(0, 0, 0) |   |   |
| storeObject |   | GameObject Projectile | Variable |   |

##### 2. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float X Velocity | Variable |   |
| floatValue |   | 1f |   |   |
| everyFrame |   | false |   |   |

##### 3. FloatMultiply

Full Name: HutongGames.PlayMaker.Actions.FloatMultiply
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float X Velocity | Variable |   |
| multiplyBy |   | float Multiplier |   |   |
| everyFrame |   | false |   |   |

##### 4. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Projectile |   |   |
| vector |   | Vector2(0, 0) |   |   |
| x |   | float X Velocity |   |   |
| y |   | 0f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Pause | 0 | |
| REDO |   | 0 | |

### Pause

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 0.7f |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |

##### 2. FloatMultiply

Full Name: HutongGames.PlayMaker.Actions.FloatMultiply
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Multiplier | Variable |   |
| multiplyBy |   | -1f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Spawn | 0 | |

## Global Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| SHAKE END | Idle | 0 | |

## Events

| Name | Global |
| --- | --- |
| 1 | false |
| 2 | false |
| 3 | false |
| 4 | false |
| 5 | false |
| FINISHED | false |
| REDO | false |
| SHAKE END | false |
| SHAKE START | false |

