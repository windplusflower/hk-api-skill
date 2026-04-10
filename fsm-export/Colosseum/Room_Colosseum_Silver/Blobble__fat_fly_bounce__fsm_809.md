# fat fly bounce

## Summary

| Field | Value |
| --- | --- |
| FSM Name | fat fly bounce |
| GameObject Name | Blobble |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets33.assets |
| Start State | Initialise |
| FSM PathId | 809 |
| GameObject PathId | 140 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Angle | 0 | Single: 0 |
| Distance | 0 | Single: 0 |
| Normal X | 0 | Single: 0 |
| Normal Y | 0 | Single: 0 |
| Raycast Left | 0 | Single: 0 |
| Raycast Right | 0 | Single: 0 |
| Raycast X | 0 | Single: 0 |
| Speed | 4 | Single: 4 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Facing Right | false | Boolean: false |
| Starts Inactive | false | Boolean: false |

### Vector3s

| Name | Value | Raw/Type |
| --- | --- | --- |
| Contact Normal | Vector3(0, 0, 0) | Vector3: Vector3(0, 0, 0) |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Camera | [null] | NamedAssetPPtr:  |
| Hero | [null] | NamedAssetPPtr:  |
| Self | [null] | NamedAssetPPtr:  |

## States

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

##### 2. GetHero

Full Name: GetHero
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeResult | GameObject Hero | GameObject Hero | Variable |  |

##### 3. SetGameObject

Full Name: HutongGames.PlayMaker.Actions.SetGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variable | GameObject Camera | GameObject Camera | Variable |  |
| gameObject | [Global] GameObject MainCamera | [Global] GameObject MainCamera |  |  |
| everyFrame | false | false |  |  |

##### 4. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min | 0f | 0f |  |  |
| max | 360f | 360f |  |  |
| storeResult | float Angle | float Angle | Variable |  |

##### 5. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Starts Inactive | bool Starts Inactive | Variable |  |
| isTrue | Event(STOP) | Event(STOP) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 6. GetDistance

Full Name: HutongGames.PlayMaker.Actions.GetDistance
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| target | GameObject Hero | GameObject Hero |  |  |
| storeResult | float Distance | float Distance | Variable |  |
| everyFrame | true | true |  |  |

##### 7. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float Distance | float Distance |  |  |
| float2 | 25f | 25f |  |  |
| tolerance | 0f | 0f |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event(FINISHED) | Event(FINISHED) |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | true | true |  |  |

### Left or Right?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min | 0f | 0f |  |  |
| max | 360f | 360f |  |  |
| storeResult | float Angle | float Angle | Variable |  |

##### 2. FloatSwitch

Full Name: HutongGames.PlayMaker.Actions.FloatSwitch
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Angle | float Angle | Variable |  |
| lessThan | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| sendEvent | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| everyFrame | false | false |  |  |

### Face Left

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetScale

Full Name: HutongGames.PlayMaker.Actions.SetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 1f | 1f |  |  |
| y | 0f | 0f |  |  |
| z | 0f | 0f |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 2. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Facing Right | bool Facing Right | Variable |  |
| boolValue | false | false |  |  |
| everyFrame | false | false |  |  |

##### 3. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Raycast Right | float Raycast Right | Variable |  |
| floatValue | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 4. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Raycast Left | float Raycast Left | Variable |  |
| floatValue | float Raycast X | float Raycast X |  |  |
| everyFrame | false | false |  |  |

### Face Right

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetScale

Full Name: HutongGames.PlayMaker.Actions.SetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | -1f | -1f |  |  |
| y | 0f | 0f |  |  |
| z | 0f | 0f |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 2. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Facing Right | bool Facing Right | Variable |  |
| boolValue | true | true |  |  |
| everyFrame | false | false |  |  |

##### 3. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Raycast Right | float Raycast Right | Variable |  |
| floatValue | float Raycast X | float Raycast X |  |  |
| everyFrame | false | false |  |  |

##### 4. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Raycast Left | float Raycast Left | Variable |  |
| floatValue | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Hit Up

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Facing Right | bool Facing Right | Variable |  |
| isTrue | Event(RIGHT) | Event(RIGHT) |  |  |
| isFalse | Event(LEFT) | Event(LEFT) |  |  |
| everyFrame | false | false |  |  |

### Up Right

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min | 320f | 320f |  |  |
| max | 350f | 350f |  |  |
| storeResult | float Angle | float Angle | Variable |  |

### Up Left

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min | 190f | 190f |  |  |
| max | 220f | 220f |  |  |
| storeResult | float Angle | float Angle | Variable |  |

### Hit Down

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Facing Right | bool Facing Right | Variable |  |
| isTrue | Event(RIGHT) | Event(RIGHT) |  |  |
| isFalse | Event(LEFT) | Event(LEFT) |  |  |
| everyFrame | false | false |  |  |

### Down Right

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min | 10f | 10f |  |  |
| max | 40f | 40f |  |  |
| storeResult | float Angle | float Angle | Variable |  |

### Up Left 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min | 140f | 140f |  |  |
| max | 170f | 170f |  |  |
| storeResult | float Angle | float Angle | Variable |  |

### Hit Right

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. FloatSwitch

Full Name: HutongGames.PlayMaker.Actions.FloatSwitch
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Angle | float Angle | Variable |  |
| lessThan | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| sendEvent | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| everyFrame | false | false |  |  |

### Right Down

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min | 190f | 190f |  |  |
| max | 220f | 220f |  |  |
| storeResult | float Angle | float Angle | Variable |  |

### Down Right 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min | 140f | 140f |  |  |
| max | 170f | 170f |  |  |
| storeResult | float Angle | float Angle | Variable |  |

### Hit Left

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. FloatSwitch

Full Name: HutongGames.PlayMaker.Actions.FloatSwitch
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Angle | float Angle | Variable |  |
| lessThan | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| sendEvent | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| everyFrame | false | false |  |  |

### Left Down

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min | 320f | 320f |  |  |
| max | 350f | 350f |  |  |
| storeResult | float Angle | float Angle | Variable |  |

### Left Up

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min | 10f | 10f |  |  |
| max | 40f | 40f |  |  |
| storeResult | float Angle | float Angle | Variable |  |

### Fly 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 5

#### Actions

##### 1. SetVelocityAsAngle

Full Name: HutongGames.PlayMaker.Actions.SetVelocityAsAngle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| angle | float Angle | float Angle |  |  |
| speed | float Speed | float Speed |  |  |
| everyFrame | true | true |  |  |

##### 2. Collision2dEvent

Full Name: HutongGames.PlayMaker.Actions.Collision2dEvent
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| collision | HutongGames.PlayMaker.Collision2DType::OnCollisionStay2D | 1 |  |  |
| collideTag | "" | "" | Tag |  |
| sendEvent | Event(COLLISION STAY 2D) | Event(COLLISION STAY 2D) |  |  |
| storeCollider |  |  | Variable |  |
| storeForce | 0f | 0f | Variable |  |

##### 3. Collision2dEvent

Full Name: HutongGames.PlayMaker.Actions.Collision2dEvent
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| collision | HutongGames.PlayMaker.Collision2DType::OnCollisionEnter2D | 0 |  |  |
| collideTag | "" | "" | Tag |  |
| sendEvent | Event(COLLISION STAY 2D) | Event(COLLISION STAY 2D) |  |  |
| storeCollider |  |  | Variable |  |
| storeForce | 0f | 0f | Variable |  |

##### 4. CheckCollisionSideEnter

Full Name: HutongGames.PlayMaker.Actions.CheckCollisionSideEnter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| topHit | false | false | Variable |  |
| rightHit | false | false | Variable |  |
| bottomHit | false | false | Variable |  |
| leftHit | false | false | Variable |  |
| topHitEvent | Event(HIT UP) | Event(HIT UP) |  |  |
| rightHitEvent | Event(HIT RIGHT) | Event(HIT RIGHT) |  |  |
| bottomHitEvent | Event(HIT DOWN) | Event(HIT DOWN) |  |  |
| leftHitEvent | Event(HIT LEFT) | Event(HIT LEFT) |  |  |
| otherLayer | false | false |  |  |
| otherLayerNumber | 0 | 0 |  |  |
| ignoreTriggers | false | false |  |  |

##### 5. CheckCollisionSide

Full Name: HutongGames.PlayMaker.Actions.CheckCollisionSide
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| topHit | false | false | Variable |  |
| rightHit | false | false | Variable |  |
| bottomHit | false | false | Variable |  |
| leftHit | false | false | Variable |  |
| topHitEvent | Event(HIT UP) | Event(HIT UP) |  |  |
| rightHitEvent | Event(HIT RIGHT) | Event(HIT RIGHT) |  |  |
| bottomHitEvent | Event(HIT DOWN) | Event(HIT DOWN) |  |  |
| leftHitEvent | Event(HIT LEFT) | Event(HIT LEFT) |  |  |
| otherLayer | false | false |  |  |
| otherLayerNumber | 0 | 0 |  |  |
| ignoreTriggers | false | false |  |  |

##### 6. CheckCollisionSideEnter

Full Name: HutongGames.PlayMaker.Actions.CheckCollisionSideEnter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| topHit | false | false | Variable |  |
| rightHit | false | false | Variable |  |
| bottomHit | false | false | Variable |  |
| leftHit | false | false | Variable |  |
| topHitEvent | Event(HIT UP) | Event(HIT UP) |  |  |
| rightHitEvent | Event(HIT RIGHT) | Event(HIT RIGHT) |  |  |
| bottomHitEvent | Event(HIT DOWN) | Event(HIT DOWN) |  |  |
| leftHitEvent | Event(HIT LEFT) | Event(HIT LEFT) |  |  |
| otherLayer | true | true |  |  |
| otherLayerNumber | 11 | 11 |  |  |
| ignoreTriggers | false | false |  |  |

##### 7. CheckCollisionSide

Full Name: HutongGames.PlayMaker.Actions.CheckCollisionSide
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| topHit | false | false | Variable |  |
| rightHit | false | false | Variable |  |
| bottomHit | false | false | Variable |  |
| leftHit | false | false | Variable |  |
| topHitEvent | Event(HIT UP) | Event(HIT UP) |  |  |
| rightHitEvent | Event(HIT RIGHT) | Event(HIT RIGHT) |  |  |
| bottomHitEvent | Event(HIT DOWN) | Event(HIT DOWN) |  |  |
| leftHitEvent | Event(HIT LEFT) | Event(HIT LEFT) |  |  |
| otherLayer | true | true |  |  |
| otherLayerNumber | 11 | 11 |  |  |
| ignoreTriggers | false | false |  |  |

### Collision Check

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 5

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
| float1 | float Normal X | float Normal X |  |  |
| float2 | -1f | -1f |  |  |
| tolerance | 0f | 0f |  |  |
| equal | Event(HIT RIGHT) | Event(HIT RIGHT) |  |  |
| lessThan | Event() | Event() |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 4. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float Normal X | float Normal X |  |  |
| float2 | 1f | 1f |  |  |
| tolerance | 0f | 0f |  |  |
| equal | Event(HIT LEFT) | Event(HIT LEFT) |  |  |
| lessThan | Event() | Event() |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 5. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float Normal Y | float Normal Y |  |  |
| float2 | -1f | -1f |  |  |
| tolerance | 0f | 0f |  |  |
| equal | Event(HIT UP) | Event(HIT UP) |  |  |
| lessThan | Event() | Event() |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 6. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float Normal Y | float Normal Y |  |  |
| float2 | 1f | 1f |  |  |
| tolerance | 0f | 0f |  |  |
| equal | Event(HIT DOWN) | Event(HIT DOWN) |  |  |
| lessThan | Event() | Event() |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

### Stopped

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetVelocityAsAngle

Full Name: HutongGames.PlayMaker.Actions.GetVelocityAsAngle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| storeAngle | float Angle | float Angle | Variable |  |
| everyFrame | false | false |  |  |

##### 2. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Starts Inactive | bool Starts Inactive | Variable |  |
| boolValue | false | false |  |  |
| everyFrame | false | false |  |  |

### Aim

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Self | EventTarget(GameObject):Self |  |  |
| sendEvent | "START" | "START" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. GetAngleToTarget2D

Full Name: HutongGames.PlayMaker.Actions.GetAngleToTarget2D
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| target | GameObject Hero | GameObject Hero |  |  |
| offsetX | 0f | 0f |  |  |
| offsetY | 0f | 0f |  |  |
| storeAngle | float Angle | float Angle |  |  |
| everyFrame | false | false |  |  |

##### 3. GetAngleToTarget

Full Name: HutongGames.PlayMaker.Actions.GetAngleToTarget
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| targetObject | GameObject Hero | GameObject Hero |  |  |
| targetPosition | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| ignoreHeight | true | true |  |  |
| storeAngle | float Angle | float Angle | Variable |  |
| everyFrame | false | false |  |  |

### Go Up

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min | 60f | 60f |  |  |
| max | 120f | 120f |  |  |
| storeResult | float Angle | float Angle | Variable |  |

##### 2. FloatSwitch

Full Name: HutongGames.PlayMaker.Actions.FloatSwitch
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Angle | float Angle | Variable |  |
| lessThan | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| sendEvent | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| everyFrame | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Initialise | FINISHED | Aim | 0 | 0 | 0 |
| Left or Right? | LEFT | Face Left | 0 | 0 | 0 |
| Left or Right? | RIGHT | Face Right | 0 | 0 | 0 |
| Face Left | FINISHED | Fly 2 | 0 | 0 | 0 |
| Face Right | FINISHED | Fly 2 | 0 | 0 | 0 |
| Hit Up | RIGHT | Up Right | 0 | 0 | 0 |
| Hit Up | LEFT | Up Left | 0 | 0 | 0 |
| Up Right | FINISHED | Left or Right? | 0 | 0 | 0 |
| Up Left | FINISHED | Left or Right? | 0 | 0 | 0 |
| Hit Down | RIGHT | Down Right | 0 | 0 | 0 |
| Hit Down | LEFT | Up Left 2 | 0 | 0 | 0 |
| Down Right | FINISHED | Left or Right? | 0 | 0 | 0 |
| Up Left 2 | FINISHED | Left or Right? | 0 | 0 | 0 |
| Hit Right | UP | Down Right 2 | 0 | 0 | 0 |
| Hit Right | DOWN | Right Down | 0 | 0 | 0 |
| Right Down | FINISHED | Left or Right? | 0 | 0 | 0 |
| Down Right 2 | FINISHED | Left or Right? | 0 | 0 | 0 |
| Hit Left | UP | Left Up | 0 | 0 | 0 |
| Hit Left | DOWN | Left Down | 0 | 0 | 0 |
| Left Down | FINISHED | Left or Right? | 0 | 0 | 0 |
| Left Up | FINISHED | Left or Right? | 0 | 0 | 0 |
| Fly 2 | COLLISION STAY 2D | Collision Check | 0 | 0 | 0 |
| Fly 2 | HIT DOWN |  | 0 | 0 | 0 |
| Fly 2 | HIT LEFT |  | 0 | 0 | 0 |
| Fly 2 | HIT RIGHT |  | 0 | 0 | 0 |
| Fly 2 | HIT UP |  | 0 | 0 | 0 |
| Collision Check | HIT DOWN | Hit Down | 0 | 0 | 0 |
| Collision Check | HIT LEFT | Hit Left | 0 | 0 | 0 |
| Collision Check | HIT RIGHT | Hit Right | 0 | 0 | 0 |
| Collision Check | HIT UP | Hit Up | 0 | 0 | 0 |
| Collision Check | FINISHED | Hit Right | 0 | 0 | 0 |
| Stopped | WAKE | Left or Right? | 0 | 0 | 0 |
| Aim | FINISHED | Left or Right? | 0 | 0 | 0 |
| Go Up | RIGHT | Face Right | 0 | 0 | 0 |
| Go Up | LEFT | Face Right | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| STOP | Stopped | 0 | 0 | 0 |
| GO UP | Go Up | 0 | 0 | 0 |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| LEFT | false |
| RIGHT | false |
| UP | false |
| DOWN | false |
| COLLISION STAY 2D | true |
| HIT DOWN | false |
| HIT LEFT | false |
| HIT RIGHT | false |
| HIT UP | false |
| WAKE | true |
| STOP | false |
| GO UP | false |

