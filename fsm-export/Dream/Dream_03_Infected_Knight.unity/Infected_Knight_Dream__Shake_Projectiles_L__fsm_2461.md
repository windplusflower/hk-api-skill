# Shake Projectiles L

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Shake Projectiles L |
| GameObject Name | Infected Knight Dream |
| GameObject Path |   |
| Source Asset | D:/SteamLibrary/steamapps/common/Hollow Knight/hollow_knight_Data/level397 |
| Start State | Idle |
| FSM PathId | 2461 |
| GameObject PathId | 508 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Multiplier | 1 | Single: 1 |
| Pause Time | 1 | Single: 1 |
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
| SHAKE START | Choose Speed | 0 | |

### Spawn

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Prev Adjacent | Variable |   |
| boolValue |   | bool Was Adjacent |   |   |
| everyFrame |   | false |   |   |

##### 2. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Prev Speed | Variable |   |
| floatValue |   | float X Velocity |   |   |
| everyFrame |   | false |   |   |

##### 3. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [IK Projectile SH (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\sharedassets343.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| position |   | Vector3(0, 0, 0) |   |   |
| rotation |   | Vector3(0, 0, 0) |   |   |
| storeObject |   | GameObject Projectile | Variable |   |

##### 4. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min |   | 6f |   |   |
| max |   | 25f |   |   |
| storeResult |   | float X Velocity | Variable |   |

##### 5. SetVelocity2d

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
| time |   | 0.4f |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Choose Speed | 0 | |

### Choose Speed

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 5

#### Actions

##### 1. SendRandomEvent

Full Name: HutongGames.PlayMaker.Actions.SendRandomEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| events |   | FSMViewAvalonia2.FsmArray2 |   |   |
| weights |   | FSMViewAvalonia2.FsmArray2 |   |   |
| delay |   | 0f |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| 1 | Speed 1 | 0 | |
| 2 | Speed 2 | 0 | |
| 3 | Speed 3 | 0 | |
| 4 | Speed 4 | 0 | |
| 5 | Speed 5 | 0 | |

### Speed 1

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float X Velocity | Variable |   |
| floatValue |   | -5f |   |   |
| everyFrame |   | false |   |   |

##### 2. FloatTestToBool

Full Name: HutongGames.PlayMaker.Actions.FloatTestToBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 |   | float Prev Speed |   |   |
| float2 |   | -8f |   |   |
| tolerance |   | 0f |   |   |
| equalBool |   | bool Adjacent 1 | Variable |   |
| lessThanBool |   | false | Variable |   |
| greaterThanBool |   | false | Variable |   |
| everyFrame |   | false |   |   |

##### 3. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Adjacent 2 | Variable |   |
| boolValue |   | false |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Prev? | 0 | |

### Speed 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float X Velocity | Variable |   |
| floatValue |   | -8f |   |   |
| everyFrame |   | false |   |   |

##### 2. FloatTestToBool

Full Name: HutongGames.PlayMaker.Actions.FloatTestToBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 |   | float Prev Speed |   |   |
| float2 |   | -5f |   |   |
| tolerance |   | 0f |   |   |
| equalBool |   | bool Adjacent 1 | Variable |   |
| lessThanBool |   | false | Variable |   |
| greaterThanBool |   | false | Variable |   |
| everyFrame |   | false |   |   |

##### 3. FloatTestToBool

Full Name: HutongGames.PlayMaker.Actions.FloatTestToBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 |   | float Prev Speed |   |   |
| float2 |   | -11f |   |   |
| tolerance |   | 0f |   |   |
| equalBool |   | bool Adjacent 2 | Variable |   |
| lessThanBool |   | false | Variable |   |
| greaterThanBool |   | false | Variable |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Prev? | 0 | |

### Speed 3

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float X Velocity | Variable |   |
| floatValue |   | -11f |   |   |
| everyFrame |   | false |   |   |

##### 2. FloatTestToBool

Full Name: HutongGames.PlayMaker.Actions.FloatTestToBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 |   | float Prev Speed |   |   |
| float2 |   | -8f |   |   |
| tolerance |   | 0f |   |   |
| equalBool |   | bool Adjacent 1 | Variable |   |
| lessThanBool |   | false | Variable |   |
| greaterThanBool |   | false | Variable |   |
| everyFrame |   | false |   |   |

##### 3. FloatTestToBool

Full Name: HutongGames.PlayMaker.Actions.FloatTestToBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 |   | float Prev Speed |   |   |
| float2 |   | -14f |   |   |
| tolerance |   | 0f |   |   |
| equalBool |   | bool Adjacent 2 | Variable |   |
| lessThanBool |   | false | Variable |   |
| greaterThanBool |   | false | Variable |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Prev? | 0 | |

### Speed 4

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float X Velocity | Variable |   |
| floatValue |   | -14f |   |   |
| everyFrame |   | false |   |   |

##### 2. FloatTestToBool

Full Name: HutongGames.PlayMaker.Actions.FloatTestToBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 |   | float Prev Speed |   |   |
| float2 |   | -11f |   |   |
| tolerance |   | 0f |   |   |
| equalBool |   | bool Adjacent 1 | Variable |   |
| lessThanBool |   | false | Variable |   |
| greaterThanBool |   | false | Variable |   |
| everyFrame |   | false |   |   |

##### 3. FloatTestToBool

Full Name: HutongGames.PlayMaker.Actions.FloatTestToBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 |   | float Prev Speed |   |   |
| float2 |   | -17f |   |   |
| tolerance |   | 0f |   |   |
| equalBool |   | bool Adjacent 2 | Variable |   |
| lessThanBool |   | false | Variable |   |
| greaterThanBool |   | false | Variable |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Prev? | 0 | |

### Speed 5

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float X Velocity | Variable |   |
| floatValue |   | -17f |   |   |
| everyFrame |   | false |   |   |

##### 2. FloatTestToBool

Full Name: HutongGames.PlayMaker.Actions.FloatTestToBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 |   | float Prev Speed |   |   |
| float2 |   | -14f |   |   |
| tolerance |   | 0f |   |   |
| equalBool |   | bool Adjacent 1 | Variable |   |
| lessThanBool |   | false | Variable |   |
| greaterThanBool |   | false | Variable |   |
| everyFrame |   | false |   |   |

##### 3. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Adjacent 2 | Variable |   |
| boolValue |   | false |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Prev? | 0 | |

### Prev?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 |   | float Prev Speed |   |   |
| float2 |   | float X Velocity |   |   |
| tolerance |   | 0f |   |   |
| equal |   | Event(REDO) |   |   |
| lessThan |   | Event() |   |   |
| greaterThan |   | Event() |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| REDO | Choose Speed | 0 | |
| FINISHED | Was Adjacent? | 0 | |

### Was Adjacent?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Was Adjacent | Variable |   |
| boolValue |   | false |   |   |
| everyFrame |   | false |   |   |

##### 2. BoolAnyTrue

Full Name: HutongGames.PlayMaker.Actions.BoolAnyTrue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariables |   | FSMViewAvalonia2.FsmArray2 | Variable |   |
| sendEvent |   | Event() |   |   |
| storeResult |   | bool Was Adjacent | Variable |   |
| everyFrame |   | false |   |   |

##### 3. BoolAllTrue

Full Name: HutongGames.PlayMaker.Actions.BoolAllTrue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariables |   | FSMViewAvalonia2.FsmArray2 | Variable |   |
| sendEvent |   | Event(REDO) |   |   |
| storeResult |   | false | Variable |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| REDO | Choose Speed | 0 | |
| FINISHED | Spawn | 0 | |

### Shake End

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Pause Time | Variable |   |
| floatValue |   | 0.5f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Idle | 0 | |

## Global Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| SHAKE END | Shake End | 0 | |

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

