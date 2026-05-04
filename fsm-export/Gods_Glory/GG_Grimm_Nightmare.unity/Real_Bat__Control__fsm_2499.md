# Control

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Control |
| GameObject Name | Real Bat |
| GameObject Path | Grimm Control/Grimm Bats/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level444 |
| Start State | Init |
| FSM PathId | 2499 |
| GameObject PathId | 734 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Max Speed X | 0 | Single: 0 |
| Max Speed Y | 0 | Single: 0 |
| Velocity | 0 | Single: 0 |
| X Accel | 0 | Single: 0 |
| X Pos | 0 | Single: 0 |
| Y Accel | 0 | Single: 0 |
| Y Pos | 0 | Single: 0 |
| Z Pos | 0 | Single: 0 |

### Vector3s

| Name | Value | Raw/Type |
| --- | --- | --- |
| Grimm Pos | Vector2(0, 0) | Vector2: Vector2(0, 0) |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Grimm | Grimm Control/Nightmare Grimm Boss (Hollow Knight/hollow_knight_Data\level444) | NamedAssetPPtr: [Grimm Control/Nightmare Grimm Boss (Hollow Knight/hollow_knight_Data\level444)] |
| Self | [null] | NamedAssetPPtr: [null] |

## States

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f | Variable |   |
| y |   | 0f | Variable |   |
| z |   | float Z Pos | Variable |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |

##### 2. GetOwner

Full Name: HutongGames.PlayMaker.Actions.GetOwner
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeGameObject |   | GameObject Self | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| BOSS AWAKE | Dormant | 0 | |

### Go Up

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min |   | 1f |   |   |
| max |   | 4f |   |   |
| storeResult |   | float X Accel | Variable |   |

##### 2. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min |   | 2f |   |   |
| max |   | 3f |   |   |
| storeResult |   | float Y Accel | Variable |   |

##### 3. RandomlyFlipFloat

Full Name: HutongGames.PlayMaker.Actions.RandomlyFlipFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeResult |   | float X Accel | Variable |   |

##### 4. GetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.GetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector2(0, 0) | Variable |   |
| x |   | 0f | Variable |   |
| y |   | float Velocity | Variable |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |

##### 5. FloatMultiply

Full Name: HutongGames.PlayMaker.Actions.FloatMultiply
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Velocity | Variable |   |
| multiplyBy |   | 0.3f |   |   |
| everyFrame |   | false |   |   |

##### 6. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector2(0, 0) |   |   |
| x |   | 0f |   |   |
| y |   | float Velocity |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Set Max X | 0 | |

### Fly

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 5

#### Actions

##### 1. FaceDirection

Full Name: HutongGames.PlayMaker.Actions.FaceDirection
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| spriteFacesRight |   | true |   |   |
| playNewAnimation |   | true |   |   |
| newAnimationClip |   | "Bat TurnToFly" |   |   |
| everyFrame |   | true |   |   |
| pauseBetweenTurns |   | true |   |   |
| pauseTime |   | 0.5f |   |   |

##### 2. AccelerateVelocity

Full Name: HutongGames.PlayMaker.Actions.AccelerateVelocity
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| xAccel |   | float X Accel |   |   |
| yAccel |   | float Y Accel |   |   |
| xMaxSpeed |   | float Max Speed X |   |   |
| yMaxSpeed |   | float Max Speed Y |   |   |

##### 3. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | float X Pos | Variable |   |
| y |   | float Y Pos | Variable |   |
| z |   | 0f | Variable |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | true |   |   |

##### 4. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 |   | float X Pos |   |   |
| float2 |   | 84f |   |   |
| tolerance |   | 0f |   |   |
| equal |   |   |   |   |
| lessThan |   | GO RIGHT |   |   |
| greaterThan |   |   |   |   |
| everyFrame |   | true |   |   |

##### 5. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 |   | float X Pos |   |   |
| float2 |   | 89f |   |   |
| tolerance |   | 0f |   |   |
| equal |   |   |   |   |
| lessThan |   |   |   |   |
| greaterThan |   | GO LEFT |   |   |
| everyFrame |   | true |   |   |

##### 6. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 |   | float Y Pos |   |   |
| float2 |   | 10f |   |   |
| tolerance |   | 0f |   |   |
| equal |   |   |   |   |
| lessThan |   | GO UP |   |   |
| greaterThan |   |   |   |   |
| everyFrame |   | true |   |   |

##### 7. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 |   | float Y Pos |   |   |
| float2 |   | 13f |   |   |
| tolerance |   | 0f |   |   |
| equal |   |   |   |   |
| lessThan |   |   |   |   |
| greaterThan |   | GO DOWN |   |   |
| everyFrame |   | true |   |   |

##### 8. WaitRandom

Full Name: HutongGames.PlayMaker.Actions.WaitRandom
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| timeMin |   | 0.5f |   |   |
| timeMax |   | 1.5f |   |   |
| finishEvent |   | CHOOSE |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| GO UP | Go Up | 0 | |
| GO DOWN | Go Down | 0 | |
| GO LEFT | Go Left | 0 | |
| GO RIGHT | Go Right | 0 | |
| CHOOSE | Choose | 0 | |

### Go Down

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min |   | 1f |   |   |
| max |   | 4f |   |   |
| storeResult |   | float X Accel | Variable |   |

##### 2. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min |   | -2f |   |   |
| max |   | -3f |   |   |
| storeResult |   | float Y Accel | Variable |   |

##### 3. RandomlyFlipFloat

Full Name: HutongGames.PlayMaker.Actions.RandomlyFlipFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeResult |   | float X Accel | Variable |   |

##### 4. GetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.GetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector2(0, 0) | Variable |   |
| x |   | 0f | Variable |   |
| y |   | float Velocity | Variable |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |

##### 5. FloatMultiply

Full Name: HutongGames.PlayMaker.Actions.FloatMultiply
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Velocity | Variable |   |
| multiplyBy |   | 0.3f |   |   |
| everyFrame |   | false |   |   |

##### 6. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector2(0, 0) |   |   |
| x |   | 0f |   |   |
| y |   | float Velocity |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Set Max X | 0 | |

### Fly Start

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 0.2f |   |   |
| finishEvent |   | FINISHED |   |   |
| realTime |   | false |   |   |

##### 2. FaceDirection

Full Name: HutongGames.PlayMaker.Actions.FaceDirection
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| spriteFacesRight |   | true |   |   |
| playNewAnimation |   | true |   |   |
| newAnimationClip |   | "Bat TurnToFly" |   |   |
| everyFrame |   | true |   |   |
| pauseBetweenTurns |   | true |   |   |
| pauseTime |   | 0.5f |   |   |

##### 3. AccelerateVelocity

Full Name: HutongGames.PlayMaker.Actions.AccelerateVelocity
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| xAccel |   | float X Accel |   |   |
| yAccel |   | float Y Accel |   |   |
| xMaxSpeed |   | 15f |   |   |
| yMaxSpeed |   | 10f |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Fly | 0 | |

### Go Left

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min |   | -3f |   |   |
| max |   | -5f |   |   |
| storeResult |   | float X Accel | Variable |   |

##### 2. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min |   | 0.5f |   |   |
| max |   | 2f |   |   |
| storeResult |   | float Y Accel | Variable |   |

##### 3. RandomlyFlipFloat

Full Name: HutongGames.PlayMaker.Actions.RandomlyFlipFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeResult |   | float Y Accel | Variable |   |

##### 4. GetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.GetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector2(0, 0) | Variable |   |
| x |   | float Velocity | Variable |   |
| y |   | 0f | Variable |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |

##### 5. FloatMultiply

Full Name: HutongGames.PlayMaker.Actions.FloatMultiply
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Velocity | Variable |   |
| multiplyBy |   | 0.5f |   |   |
| everyFrame |   | false |   |   |

##### 6. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector2(0, 0) |   |   |
| x |   | float Velocity |   |   |
| y |   | 0f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Set Max X | 0 | |

### Go Right

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min |   | 3f |   |   |
| max |   | 5f |   |   |
| storeResult |   | float X Accel | Variable |   |

##### 2. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min |   | 0.5f |   |   |
| max |   | 2f |   |   |
| storeResult |   | float Y Accel | Variable |   |

##### 3. RandomlyFlipFloat

Full Name: HutongGames.PlayMaker.Actions.RandomlyFlipFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeResult |   | float Y Accel | Variable |   |

##### 4. GetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.GetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector2(0, 0) | Variable |   |
| x |   | float Velocity | Variable |   |
| y |   | 0f | Variable |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |

##### 5. FloatMultiply

Full Name: HutongGames.PlayMaker.Actions.FloatMultiply
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Velocity | Variable |   |
| multiplyBy |   | 0.5f |   |   |
| everyFrame |   | false |   |   |

##### 6. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector2(0, 0) |   |   |
| x |   | float Velocity |   |   |
| y |   | 0f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Set Max X | 0 | |

### Choose

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 4

#### Actions

##### 1. SetCollider

Full Name: HutongGames.PlayMaker.Actions.SetCollider
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| active |   | true |   |   |

##### 2. SendRandomEvent

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
| GO UP | Go Up | 0 | |
| GO DOWN | Go Down | 0 | |
| GO LEFT | Go Left | 0 | |
| GO RIGHT | Go Right | 0 | |

### Dormant

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

(none)

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| BATS OUT | Position | 0 | |

### Set Max X

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. FloatOperator

Full Name: HutongGames.PlayMaker.Actions.FloatOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 |   | float X Accel |   |   |
| float2 |   | 0.25f |   |   |
| operation | HutongGames.PlayMaker.Actions.FloatOperator/Operation::Multiply | 2 |   |   |
| storeResult |   | float X Accel | Variable |   |
| everyFrame |   | false |   |   |

##### 2. FloatOperator

Full Name: HutongGames.PlayMaker.Actions.FloatOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 |   | float X Accel |   |   |
| float2 |   | 10f |   |   |
| operation | HutongGames.PlayMaker.Actions.FloatOperator/Operation::Multiply | 2 |   |   |
| storeResult |   | float Max Speed X | Variable |   |
| everyFrame |   | false |   |   |

##### 3. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 |   | float Max Speed X |   |   |
| float2 |   | 0f |   |   |
| tolerance |   | 0f |   |   |
| equal |   |   |   |   |
| lessThan |   |   |   |   |
| greaterThan |   | FINISHED |   |   |
| everyFrame |   | false |   |   |

##### 4. FloatMultiply

Full Name: HutongGames.PlayMaker.Actions.FloatMultiply
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Max Speed X | Variable |   |
| multiplyBy |   | -1f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Set Max Y | 0 | |

### Set Max Y

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. FloatOperator

Full Name: HutongGames.PlayMaker.Actions.FloatOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 |   | float Y Accel |   |   |
| float2 |   | 0.25f |   |   |
| operation | HutongGames.PlayMaker.Actions.FloatOperator/Operation::Multiply | 2 |   |   |
| storeResult |   | float Y Accel | Variable |   |
| everyFrame |   | false |   |   |

##### 2. FloatOperator

Full Name: HutongGames.PlayMaker.Actions.FloatOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 |   | float Y Accel |   |   |
| float2 |   | 10f |   |   |
| operation | HutongGames.PlayMaker.Actions.FloatOperator/Operation::Multiply | 2 |   |   |
| storeResult |   | float Max Speed Y | Variable |   |
| everyFrame |   | false |   |   |

##### 3. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 |   | float Max Speed Y |   |   |
| float2 |   | 0f |   |   |
| tolerance |   | 0f |   |   |
| equal |   |   |   |   |
| lessThan |   |   |   |   |
| greaterThan |   | FINISHED |   |   |
| everyFrame |   | false |   |   |

##### 4. FloatMultiply

Full Name: HutongGames.PlayMaker.Actions.FloatMultiply
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Max Speed Y | Variable |   |
| multiplyBy |   | -1f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Fly Start | 0 | |

### Position

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Grimm |   |   |
| vector |   | Vector3 Grimm Pos | Variable |   |
| x |   | 0f | Variable |   |
| y |   | 0f | Variable |   |
| z |   | 0f | Variable |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |

##### 2. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector3 Grimm Pos | Variable |   |
| x |   | 0f |   |   |
| y |   | 0f |   |   |
| z |   | float Z Pos |   |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

##### 3. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| active |   | true |   |   |

##### 4. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "Bat Fly" |   |   |

##### 5. SetCollider

Full Name: HutongGames.PlayMaker.Actions.SetCollider
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| active |   | false |   |   |

##### 6. SetHP

Full Name: SetHP
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target |   | OwnerDefault FSM Owner | Variable |   |
| hp |   | 0 |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Face Middle | 0 | |

### Return

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. FaceObject

Full Name: HutongGames.PlayMaker.Actions.FaceObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| objectA |   | GameObject Self |   |   |
| objectB |   | GameObject Grimm | Variable |   |
| spriteFacesRight |   | true |   |   |
| playNewAnimation |   | false |   |   |
| newAnimationClip |   | "" |   |   |
| resetFrame |   | false |   |   |
| everyFrame |   | false |   |   |

##### 2. SetCollider

Full Name: HutongGames.PlayMaker.Actions.SetCollider
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| active |   | false |   |   |

##### 3. iTweenMoveTo

Full Name: HutongGames.PlayMaker.Actions.iTweenMoveTo
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| id |   | "" |   |   |
| transformPosition |   |   |   |   |
| vectorPosition |   | Vector3 Grimm Pos |   |   |
| time |   | 0f |   |   |
| delay |   | 0f |   |   |
| speed |   | 25f |   |   |
| space | UnityEngine.Space::World | 0 |   |   |
| easeType | iTween/EaseType::easeInSine | 12 |   |   |
| loopType | iTween/LoopType::none | 0 |   |   |
| orientToPath |   | false |   | LookAt |
| lookAtObject |   |   |   |   |
| lookAtVector |   | Vector3(0, 0, 0) |   |   |
| lookTime |   | 0f |   |   |
| axis | HutongGames.PlayMaker.Actions.iTweenFsmAction/AxisRestriction::none | 0 |   |   |
| moveToPath |   | false |   | Path |
| lookAhead |   | 0f |   |   |
| transforms |   | FSMViewAvalonia2.FsmArray2 |   |   |
| vectors |   | FSMViewAvalonia2.FsmArray2 |   |   |
| reverse |   | false |   |   |
| startEvent |   |   |   |   |
| finishEvent |   | FINISHED |   |   |
| realTime |   | false |   |   |
| stopOnExit |   | true |   |   |
| loopDontFinish |   | true |   |   |

##### 4. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector2(0, 0) |   |   |
| x |   | 0f |   |   |
| y |   | 0f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | End | 0 | |

### End

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| clipName |   | "Bat End" |   |   |
| animationTriggerEvent |   |   |   |   |
| animationCompleteEvent |   | FINISHED |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Inactive | 0 | |

### Inactive

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| active |   | false |   |   |

##### 2. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | -50f |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Dormant | 0 | |

### Get To Middle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. iTweenMoveTo

Full Name: HutongGames.PlayMaker.Actions.iTweenMoveTo
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| id |   | "" |   |   |
| transformPosition |   |   |   |   |
| vectorPosition |   | Vector3(87.2, 12.6, 0.00510025) |   |   |
| time |   | 1f |   |   |
| delay |   | 0f |   |   |
| speed |   | 20f |   |   |
| space | UnityEngine.Space::World | 0 |   |   |
| easeType | iTween/EaseType::linear | 21 |   |   |
| loopType | iTween/LoopType::none | 0 |   |   |
| orientToPath |   | false |   | LookAt |
| lookAtObject |   |   |   |   |
| lookAtVector |   | Vector3(0, 0, 0) |   |   |
| lookTime |   | 0f |   |   |
| axis | HutongGames.PlayMaker.Actions.iTweenFsmAction/AxisRestriction::none | 0 |   |   |
| moveToPath |   | false |   | Path |
| lookAhead |   | 0f |   |   |
| transforms |   | FSMViewAvalonia2.FsmArray2 |   |   |
| vectors |   | FSMViewAvalonia2.FsmArray2 |   |   |
| reverse |   | false |   |   |
| startEvent |   |   |   |   |
| finishEvent |   | FINISHED |   |   |
| realTime |   | false |   |   |
| stopOnExit |   | true |   |   |
| loopDontFinish |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Choose | 0 | |

### Face Middle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetScale

Full Name: HutongGames.PlayMaker.Actions.SetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 1f |   |   |
| y |   | 0f |   |   |
| z |   | 0f |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

##### 2. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | float X Pos | Variable |   |
| y |   | 0f | Variable |   |
| z |   | 0f | Variable |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |

##### 3. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 |   | float X Pos |   |   |
| float2 |   | 87.2f |   |   |
| tolerance |   | 0f |   |   |
| equal |   |   |   |   |
| lessThan |   | FINISHED |   |   |
| greaterThan |   |   |   |   |
| everyFrame |   | false |   |   |

##### 4. SetScale

Full Name: HutongGames.PlayMaker.Actions.SetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | -1f |   |   |
| y |   | 0f |   |   |
| z |   | 0f |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Get To Middle | 0 | |

## Global Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| BATS IN | Return | 0 | |

## Events

| Name | Global |
| --- | --- |
| BATS IN | false |
| BATS OUT | false |
| BOSS AWAKE | false |
| CHOOSE | false |
| FINISHED | false |
| GO DOWN | false |
| GO LEFT | false |
| GO RIGHT | false |
| GO UP | false |

