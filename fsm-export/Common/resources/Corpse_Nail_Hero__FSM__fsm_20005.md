# FSM

## Summary

| Field | Value |
| --- | --- |
| FSM Name | FSM |
| GameObject Name | Corpse Nail Hero |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Initialise |
| FSM PathId | 20005 |
| GameObject PathId | 6637 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Angle | 0 | Single: 0 |
| Clamp Max | 0 | Single: 0 |
| Clamp Min | 0 | Single: 0 |
| Contact X | 0 | Single: 0 |
| Contact Y | 0 | Single: 0 |
| Self Z | 0 | Single: 0 |
| Speed | 0 | Single: 0 |
| Speed | 0 | Single: 0 |
| Speed | 0 | Single: 0 |
| Speed | 0 | Single: 0 |
| Spin Factor | 10 | Single: 10 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| In Range | false | Boolean: false |

### Vector3s

| Name | Value | Raw/Type |
| --- | --- | --- |
| Contact Point | Vector3(0, 0, 0) | Vector3: Vector3(0, 0, 0) |
| Normal | Vector3(0, 0, 0) | Vector3: Vector3(0, 0, 0) |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Dust | [null] | NamedAssetPPtr:  |
| Self | [null] | NamedAssetPPtr:  |

## States

### Detect

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetRotation

Full Name: HutongGames.PlayMaker.Actions.GetRotation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| quaternion | Quaternion(0, 0, 0, 0) | Quaternion(0, 0, 0, 0) | Variable |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| xAngle | 0f | 0f | Variable |  |
| yAngle | 0f | 0f | Variable |  |
| zAngle | float Angle | float Angle | Variable |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | true | true |  |  |

##### 2. Collision2dEvent

Full Name: HutongGames.PlayMaker.Actions.Collision2dEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| collision | HutongGames.PlayMaker.Collision2DType::OnCollisionEnter2D | 0 |  |  |
| collideTag | "" | "" | Tag |  |
| sendEvent | Event(COLLISION ENTER 2D) | Event(COLLISION ENTER 2D) |  |  |
| storeCollider |  |  | Variable |  |
| storeForce | 0f | 0f | Variable |  |

### Check

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GetCollision2dInfo

Full Name: HutongGames.PlayMaker.Actions.GetCollision2dInfo
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObjectHit |  |  | Variable |  |
| relativeVelocity | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| relativeSpeed | 0f | 0f | Variable |  |
| contactPoint | Vector3 Contact Point | Vector3 Contact Point | Variable |  |
| contactNormal | Vector3 Normal | Vector3 Normal | Variable |  |
| shapeCount | 0 | 0 | Variable |  |
| physics2dMaterialName | "" | "" | Variable |  |

##### 2. GetVector3XYZ

Full Name: HutongGames.PlayMaker.Actions.GetVector3XYZ
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable | Vector3 Normal | Vector3 Normal | Variable |  |
| storeX | float Contact X | float Contact X | Variable |  |
| storeY | float Contact Y | float Contact Y | Variable |  |
| storeZ | 0f | 0f | Variable |  |
| everyFrame | false | false |  |  |

##### 3. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float Contact Y | float Contact Y |  |  |
| float2 | 1f | 1f |  |  |
| tolerance | 0f | 0f |  |  |
| equal | Event(HIT GROUND) | Event(HIT GROUND) |  |  |
| lessThan | Event() | Event() |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

### Ground Check

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Clamp Min | float Clamp Min | Variable |  |
| floatValue | 50f | 50f |  |  |
| everyFrame | false | false |  |  |

##### 2. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Clamp Max | float Clamp Max | Variable |  |
| floatValue | 80f | 80f |  |  |
| everyFrame | false | false |  |  |

##### 3. FloatInRange

Full Name: HutongGames.PlayMaker.Actions.FloatInRange
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Angle | float Angle |  |  |
| lowerValue | float Clamp Min | float Clamp Min |  |  |
| upperValue | float Clamp Max | float Clamp Max |  |  |
| boolVariable | bool In Range | bool In Range | Variable |  |
| trueEvent | Event() | Event() |  |  |
| falseEvent | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 4. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool In Range | bool In Range | Variable |  |
| isTrue | Event(TRUE) | Event(TRUE) |  |  |
| isFalse | Event(FALSE) | Event(FALSE) |  |  |
| everyFrame | false | false |  |  |

### Initialise

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetOwner

Full Name: HutongGames.PlayMaker.Actions.GetOwner
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeGameObject | GameObject Self | GameObject Self | Variable |  |

##### 2. SetIsFixedAngle2d

Full Name: HutongGames.PlayMaker.Actions.SetIsFixedAngle2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| isFixedAngle | false | false |  |  |
| everyFrame | false | false |  |  |

##### 3. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| behaviour | "ObjectBounce" | "ObjectBounce" | Behaviour |  |
| methodName | "StartBounce" | "StartBounce" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var | Var | Variable | Store Result |

##### 4. SetGravity2dScale

Full Name: HutongGames.PlayMaker.Actions.SetGravity2dScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| gravityScale | 0.8f | 0.8f |  |  |

### Stick

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Dust Land Small R (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Dust Land Small R (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint |  |  |  |  |
| position | Vector3 Contact Point | Vector3 Contact Point |  |  |
| rotation | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| storeObject |  |  | Variable |  |

##### 2. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Thunk Effect R (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Thunk Effect R (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint |  |  |  |  |
| position | Vector3 Contact Point | Vector3 Contact Point |  |  |
| rotation | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| storeObject |  |  | Variable |  |

##### 3. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f | Variable |  |
| y | 0f | 0f | Variable |  |
| z | float Self Z | float Self Z | Variable |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |

##### 4. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Dust | OwnerDefault Dust |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| z | float Self Z | float Self Z |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 5. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| vector | Vector2(0, 0) | Vector2(0, 0) |  |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| everyFrame | true | true |  |  |

##### 6. GetRotation

Full Name: HutongGames.PlayMaker.Actions.GetRotation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| quaternion | Quaternion(0, 0, 0, 0) | Quaternion(0, 0, 0, 0) | Variable |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| xAngle | 0f | 0f | Variable |  |
| yAngle | 0f | 0f | Variable |  |
| zAngle | float Angle | float Angle | Variable |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | true | true |  |  |

##### 7. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min | 40f | 40f |  |  |
| max | 50f | 50f |  |  |
| storeResult | float Clamp Min | float Clamp Min | Variable |  |

##### 8. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min | 70f | 70f |  |  |
| max | 80f | 80f |  |  |
| storeResult | float Clamp Max | float Clamp Max | Variable |  |

##### 9. FloatClamp

Full Name: HutongGames.PlayMaker.Actions.FloatClamp
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Angle | float Angle | Variable |  |
| minValue | float Clamp Min | float Clamp Min |  |  |
| maxValue | float Clamp Max | float Clamp Max |  |  |
| everyFrame | false | false |  |  |

##### 10. SetRotation

Full Name: HutongGames.PlayMaker.Actions.SetRotation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| quaternion | Quaternion(0, 0, 0, 0) | Quaternion(0, 0, 0, 0) | Variable |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| xAngle | 0f | 0f |  |  |
| yAngle | 0f | 0f |  |  |
| zAngle | float Angle | float Angle |  |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 11. SetIsFixedAngle2d

Full Name: HutongGames.PlayMaker.Actions.SetIsFixedAngle2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| isFixedAngle | true | true |  |  |
| everyFrame | false | false |  |  |

##### 12. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| behaviour | "ObjectBounce" | "ObjectBounce" | Behaviour |  |
| methodName | "StopBounce" | "StopBounce" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var | Var | Variable | Store Result |

##### 13. SetGravity2dScale

Full Name: HutongGames.PlayMaker.Actions.SetGravity2dScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| gravityScale | 0f | 0f |  |  |

### Dormant

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

_None_

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Detect | COLLISION ENTER 2D | Check | 0 | 0 | 0 |
| Check | FINISHED | Detect | 0 | 0 | 0 |
| Check | HIT GROUND | Ground Check | 0 | 0 | 0 |
| Ground Check | FALSE | Detect | 0 | 0 | 0 |
| Ground Check | TRUE | Stick | 0 | 0 | 0 |
| Initialise | FINISHED | Detect | 0 | 0 | 0 |
| Stick | FINISHED | Dormant | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| COLLISION ENTER 2D | true |
| FALSE | false |
| HIT GROUND | false |
| TRUE | false |

