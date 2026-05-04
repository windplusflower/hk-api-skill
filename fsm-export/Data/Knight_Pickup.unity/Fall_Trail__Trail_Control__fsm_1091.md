# Trail Control

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Trail Control |
| GameObject Name | Fall Trail |
| GameObject Path | Knight/Effects/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level4 |
| Start State | Idle |
| FSM PathId | 1091 |
| GameObject PathId | 212 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Emission Rate | 0 | Single: 0 |
| Hero Y Velocity | 0 | Single: 0 |

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Environment Type | 0 | Int32: 0 |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Hero | Knight (Hollow Knight/hollow_knight_Data\level4) | NamedAssetPPtr: [Knight (Hollow Knight/hollow_knight_Data\level4)] |

## States

### Playing

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. PlayParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.PlayParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| emit |   | 0 |   |   |

##### 2. SetScale

Full Name: HutongGames.PlayMaker.Actions.SetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 1f |   |   |
| y |   | 1f |   |   |
| z |   | 0f |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

##### 3. iTweenScaleTo

Full Name: HutongGames.PlayMaker.Actions.iTweenScaleTo
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| id |   | "" |   |   |
| transformScale |   |   |   |   |
| vectorScale |   | Vector3(0.2, 0.2, 0.2) |   |   |
| time |   | 0.2f |   |   |
| delay |   | 0f |   |   |
| speed |   | 0f |   |   |
| easeType | iTween/EaseType::linear | 21 |   |   |
| loopType | iTween/LoopType::none | 0 |   |   |
| startEvent |   | Event() |   |   |
| finishEvent |   | Event(FALLING) |   |   |
| realTime |   | false |   |   |
| stopOnExit |   | true |   |   |
| loopDontFinish |   | true |   |   |

##### 4. EaseFloat

Full Name: HutongGames.PlayMaker.Actions.EaseFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| fromValue |   | 400f |   |   |
| toValue |   | 50f |   |   |
| floatVariable |   | float Emission Rate | Variable |   |
| time |   | 0.2f |   |   |
| speed |   | 0f |   |   |
| delay |   | 0f |   |   |
| easeType |   | 21 |   |   |
| reverse |   | false |   |   |
| finishEvent |   | Event() |   |   |
| realTime |   | false |   |   |

##### 5. GetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.GetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Hero |   |   |
| vector |   | Vector2(0, 0) | Variable |   |
| x |   | 0f | Variable |   |
| y |   | float Hero Y Velocity | Variable |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | true |   |   |

##### 6. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 |   | float Hero Y Velocity |   |   |
| float2 |   | 0f |   |   |
| tolerance |   | 0f |   |   |
| equal |   | Event(FALLING) |   |   |
| lessThan |   | Event() |   |   |
| greaterThan |   | Event(FALLING) |   |   |
| everyFrame |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FALLING | End | 0 | |

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
| gameObject |   | OwnerDefault FSM Owner |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Idle | 0 | |

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

(none)

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| PLAY | Playing | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| FALLING | false |
| FINISHED | false |
| PLAY | false |

