# Ball Control X

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Ball Control X |
| GameObject Name | Dung Ball Large W |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets398.assets |
| Start State | Init |
| FSM PathId | 221 |
| GameObject PathId | 26 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Normal X | 0 | Single: 0 |
| Normal Y | 0 | Single: 0 |
| Prev X Speed | 0 | Single: 0 |
| X Speed | 0 | Single: 0 |

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Bounces | 0 | Int32: 0 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Hit Left | false | Boolean: false |
| Hit Right | false | Boolean: false |
| Moving Right | false | Boolean: false |

### Vector3s

| Name | Value | Raw/Type |
| --- | --- | --- |
| Contact Normal | Vector3(0, 0, 0) | Vector3: Vector3(0, 0, 0) |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Collider | [null] | NamedAssetPPtr:  |
| Smoke | Dung Ball Large W/Smoke (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets398.assets) | NamedAssetPPtr: Dung Ball Large W/Smoke (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets398.assets) |

## States

### Detect

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 4

#### Actions

##### 1. Collision2dEvent

Full Name: HutongGames.PlayMaker.Actions.Collision2dEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| collision | HutongGames.PlayMaker.Collision2DType::OnCollisionEnter2D | 0 |  |  |
| collideTag | "Untagged" | "Untagged" | Tag |  |
| sendEvent | Event(COLLISION ENTER 2D) | Event(COLLISION ENTER 2D) |  |  |
| storeCollider | GameObject Collider | GameObject Collider | Variable |  |
| storeForce | 0f | 0f | Variable |  |

##### 2. Collision2dEvent

Full Name: HutongGames.PlayMaker.Actions.Collision2dEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| collision | HutongGames.PlayMaker.Collision2DType::OnCollisionStay2D | 1 |  |  |
| collideTag | "Untagged" | "Untagged" | Tag |  |
| sendEvent | Event(COLLISION STAY 2D) | Event(COLLISION STAY 2D) |  |  |
| storeCollider | GameObject Collider | GameObject Collider | Variable |  |
| storeForce | 0f | 0f | Variable |  |

### Check

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. GetCollision2dInfo

Full Name: HutongGames.PlayMaker.Actions.GetCollision2dInfo
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObjectHit |  |  | Variable |  |
| relativeVelocity | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| relativeSpeed | 0f | 0f | Variable |  |
| contactPoint | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| contactNormal | Vector3 Contact Normal | Vector3 Contact Normal | Variable |  |
| shapeCount | 0 | 0 | Variable |  |
| physics2dMaterialName | "" | "" | Variable |  |

##### 2. GetVector3XYZ

Full Name: HutongGames.PlayMaker.Actions.GetVector3XYZ
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable | Vector3 Contact Normal | Vector3 Contact Normal | Variable |  |
| storeX | float Normal X | float Normal X | Variable |  |
| storeY | float Normal Y | float Normal Y | Variable |  |
| storeZ | 0f | 0f | Variable |  |
| everyFrame | false | false |  |  |

##### 3. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float Normal Y | float Normal Y |  |  |
| float2 | 1f | 1f |  |  |
| tolerance | 0.3f | 0.3f |  |  |
| equal | Event(FINISHED) | Event(FINISHED) |  |  |
| lessThan | Event() | Event() |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 4. FloatTestToBool

Full Name: HutongGames.PlayMaker.Actions.FloatTestToBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float X Speed | float X Speed |  |  |
| float2 | 0f | 0f |  |  |
| tolerance | 0f | 0f |  |  |
| equalBool | false | false | Variable |  |
| lessThanBool | false | false | Variable |  |
| greaterThanBool | bool Moving Right | bool Moving Right | Variable |  |
| everyFrame | false | false |  |  |

##### 5. FloatTestToBool

Full Name: HutongGames.PlayMaker.Actions.FloatTestToBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float Normal X | float Normal X |  |  |
| float2 | -1f | -1f |  |  |
| tolerance | 0.3f | 0.3f |  |  |
| equalBool | bool Hit Right | bool Hit Right | Variable |  |
| lessThanBool | false | false | Variable |  |
| greaterThanBool | false | false | Variable |  |
| everyFrame | false | false |  |  |

##### 6. FloatTestToBool

Full Name: HutongGames.PlayMaker.Actions.FloatTestToBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float Normal X | float Normal X |  |  |
| float2 | 1f | 1f |  |  |
| tolerance | 0.1f | 0.1f |  |  |
| equalBool | bool Hit Left | bool Hit Left | Variable |  |
| lessThanBool | false | false | Variable |  |
| greaterThanBool | false | false | Variable |  |
| everyFrame | false | false |  |  |

##### 7. BoolTestMulti

Full Name: HutongGames.PlayMaker.Actions.BoolTestMulti
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariables | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 | Variable |  |
| boolStates | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| trueEvent | Event(FLIP) | Event(FLIP) |  |  |
| falseEvent | Event() | Event() |  |  |
| storeResult | false | false | Variable |  |
| everyFrame | false | false |  |  |

##### 8. BoolTestMulti

Full Name: HutongGames.PlayMaker.Actions.BoolTestMulti
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariables | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 | Variable |  |
| boolStates | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| trueEvent | Event(FLIP) | Event(FLIP) |  |  |
| falseEvent | Event() | Event() |  |  |
| storeResult | false | false | Variable |  |
| everyFrame | false | false |  |  |

##### 9. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float Normal Y | float Normal Y |  |  |
| float2 | 1f | 1f |  |  |
| tolerance | 0.1f | 0.1f |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event(CANCEL) | Event(CANCEL) |  |  |
| greaterThan | Event(CANCEL) | Event(CANCEL) |  |  |
| everyFrame | false | false |  |  |

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Ball Idle" | "Ball Idle" |  |  |

##### 2. SetGravity2dScale

Full Name: HutongGames.PlayMaker.Actions.SetGravity2dScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| gravityScale | 1f | 1f |  |  |

##### 3. PlayParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.PlayParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Smoke | OwnerDefault Smoke |  |  |
| emit | 0 | 0 |  |  |

##### 4. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | true | true |  |  |

##### 5. SetCircleCollider

Full Name: HutongGames.PlayMaker.Actions.SetCircleCollider
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | true | true |  |  |

##### 6. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Bounces | int Bounces | Variable |  |
| intValue | 7 | 7 |  |  |
| everyFrame | false | false |  |  |

##### 7. NextFrameEvent

Full Name: HutongGames.PlayMaker.Actions.NextFrameEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent | Event(FINISHED) | Event(FINISHED) |  |  |

### Flip

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. FloatMultiply

Full Name: HutongGames.PlayMaker.Actions.FloatMultiply
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float X Speed | float X Speed | Variable |  |
| multiplyBy | -1f | -1f |  |  |
| everyFrame | false | false |  |  |

##### 2. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector2(0, 0) | Vector2(0, 0) |  |  |
| x | float X Speed | float X Speed |  |  |
| y | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Pause Frame

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float Prev X Speed | float Prev X Speed |  |  |
| float2 | 0f | 0f |  |  |
| tolerance | 0f | 0f |  |  |
| equal | Event(BURST) | Event(BURST) |  |  |
| lessThan | Event() | Event() |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 2. NextFrameEvent

Full Name: HutongGames.PlayMaker.Actions.NextFrameEvent
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent | Event(FINISHED) | Event(FINISHED) |  |  |

##### 3. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.25f | 0.25f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Burst

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "JUST BURST" | "JUST BURST" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Get Speed

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.GetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector2(0, 0) | Vector2(0, 0) | Variable |  |
| x | float X Speed | float X Speed | Variable |  |
| y | 0f | 0f | Variable |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Detect | COLLISION ENTER 2D | Check | 0 | 0 | 0 |
| Detect | COLLISION STAY 2D |  | 0 | 0 | 0 |
| Detect | TINK RIGHT | Get Speed | 0 | 0 | 0 |
| Detect | TINK LEFT | Get Speed | 0 | 0 | 0 |
| Check | CANCEL | Detect | 0 | 0 | 0 |
| Check | FINISHED | Detect | 0 | 0 | 0 |
| Check | FLIP | Flip | 0 | 0 | 0 |
| Init | FINISHED | Get Speed | 0 | 0 | 0 |
| Flip | FINISHED | Pause Frame | 0 | 0 | 0 |
| Pause Frame | FINISHED | Detect | 0 | 0 | 0 |
| Pause Frame | BURST | Burst | 0 | 0 | 0 |
| Get Speed | FINISHED | Detect | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| DUNGBALL END | Burst | 0 | 0 | 0 |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| BURST | false |
| CANCEL | false |
| COLLISION ENTER 2D | true |
| COLLISION STAY 2D | true |
| DUNGBALL END | false |
| FLIP | false |
| HIT | true |
| TINK LEFT | false |
| TINK RIGHT | false |

