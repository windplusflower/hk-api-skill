# FSM

## Summary

| Field | Value |
| --- | --- |
| FSM Name | FSM |
| GameObject Name | Galien Mini Hammer |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets298.assets |
| Start State | Initialise |
| FSM PathId | 66 |
| GameObject PathId | 33 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Angle | 0 | Single: 0 |
| Distance | 0 | Single: 0 |
| Normal X | 0 | Single: 0 |
| Normal Y | 0 | Single: 0 |
| Raycast Down | 0 | Single: 0 |
| Raycast Left | 0 | Single: 0 |
| Raycast Right | 0 | Single: 0 |
| Raycast X | 0 | Single: 0 |
| Speed | 10 | Single: 10 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Facing Right | false | Boolean: false |
| Moving Up | false | Boolean: false |
| Start Up | true | Boolean: true |
| Starts Inactive | false | Boolean: false |

### Vector2s

| Name | Value | Raw/Type |
| --- | --- | --- |
| Bounds | Vector2(0, 0) | Vector2: Vector2(0, 0) |
| Origin | Vector2(0, 0) | Vector2: Vector2(0, 0) |

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

##### 2. FindGameObject

Full Name: HutongGames.PlayMaker.Actions.FindGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| objectName | "" | "" |  |  |
| withTag | "MainCamera" | "MainCamera" | Tag |  |
| store | GameObject Camera | GameObject Camera | Variable |  |

##### 3. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Starts Inactive | bool Starts Inactive | Variable |  |
| isTrue | Event(STOP) | Event(STOP) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 4. GetDistance

Full Name: HutongGames.PlayMaker.Actions.GetDistance
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| target | GameObject Camera | GameObject Camera |  |  |
| storeResult | float Distance | float Distance | Variable |  |
| everyFrame | true | true |  |  |

##### 5. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float Distance | float Distance |  |  |
| float2 | 44f | 44f |  |  |
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

##### 1. FloatSwitch

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

##### 1. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Facing Right | bool Facing Right | Variable |  |
| boolValue | false | false |  |  |
| everyFrame | false | false |  |  |

### Face Right

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Facing Right | bool Facing Right | Variable |  |
| boolValue | true | true |  |  |
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
Local Transitions: 4

#### Actions

##### 1. FaceDirection

Full Name: HutongGames.PlayMaker.Actions.FaceDirection
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| spriteFacesRight | false | false |  |  |
| playNewAnimation | false | false |  |  |
| newAnimationClip | "" | "" |  |  |
| everyFrame | true | true |  |  |
| pauseBetweenTurns | false | false |  |  |
| pauseTime | 0f | 0f |  |  |

##### 2. SetVelocityAsAngle

Full Name: HutongGames.PlayMaker.Actions.SetVelocityAsAngle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| angle | float Angle | float Angle |  |  |
| speed | float Speed | float Speed |  |  |
| everyFrame | true | true |  |  |

##### 3. Collision2dEvent

Full Name: HutongGames.PlayMaker.Actions.Collision2dEvent
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| collision | HutongGames.PlayMaker.Collision2DType::OnCollisionStay2D | 1 |  |  |
| collideTag | "" | "" | Tag |  |
| sendEvent | Event(COLLISION STAY 2D) | Event(COLLISION STAY 2D) |  |  |
| storeCollider |  |  | Variable |  |
| storeForce | 0f | 0f | Variable |  |

##### 4. CheckCollisionSide

Full Name: HutongGames.PlayMaker.Actions.CheckCollisionSide
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| topHit | false | false | Variable |  |
| rightHit | false | false | Variable |  |
| bottomHit | false | false | Variable |  |
| leftHit | false | false | Variable |  |
| topHitEvent | Event(BONK UP) | Event(BONK UP) |  |  |
| rightHitEvent | Event(BONK RIGHT) | Event(BONK RIGHT) |  |  |
| bottomHitEvent | Event(BONK DOWN) | Event(BONK DOWN) |  |  |
| leftHitEvent | Event(BONK LEFT) | Event(BONK LEFT) |  |  |
| otherLayer | false | false |  |  |
| otherLayerNumber | 0 | 0 |  |  |
| ignoreTriggers | false | false |  |  |

##### 5. CheckCollisionSideEnter

Full Name: HutongGames.PlayMaker.Actions.CheckCollisionSideEnter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| topHit | false | false | Variable |  |
| rightHit | false | false | Variable |  |
| bottomHit | false | false | Variable |  |
| leftHit | false | false | Variable |  |
| topHitEvent | Event(BONK UP) | Event(BONK UP) |  |  |
| rightHitEvent | Event(BONK RIGHT) | Event(BONK RIGHT) |  |  |
| bottomHitEvent | Event(BONK DOWN) | Event(BONK DOWN) |  |  |
| leftHitEvent | Event(BONK LEFT) | Event(BONK LEFT) |  |  |
| otherLayer | false | false |  |  |
| otherLayerNumber | 0 | 0 |  |  |
| ignoreTriggers | false | false |  |  |

##### 6. CheckCollisionSide

Full Name: HutongGames.PlayMaker.Actions.CheckCollisionSide
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| topHit | false | false | Variable |  |
| rightHit | false | false | Variable |  |
| bottomHit | false | false | Variable |  |
| leftHit | false | false | Variable |  |
| topHitEvent | Event(BONK UP) | Event(BONK UP) |  |  |
| rightHitEvent | Event(BONK RIGHT) | Event(BONK RIGHT) |  |  |
| bottomHitEvent | Event(BONK DOWN) | Event(BONK DOWN) |  |  |
| leftHitEvent | Event(BONK LEFT) | Event(BONK LEFT) |  |  |
| otherLayer | true | true |  |  |
| otherLayerNumber | 25 | 25 |  |  |
| ignoreTriggers | false | false |  |  |

##### 7. CheckCollisionSideEnter

Full Name: HutongGames.PlayMaker.Actions.CheckCollisionSideEnter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| topHit | false | false | Variable |  |
| rightHit | false | false | Variable |  |
| bottomHit | false | false | Variable |  |
| leftHit | false | false | Variable |  |
| topHitEvent | Event(BONK UP) | Event(BONK UP) |  |  |
| rightHitEvent | Event(BONK RIGHT) | Event(BONK RIGHT) |  |  |
| bottomHitEvent | Event(BONK DOWN) | Event(BONK DOWN) |  |  |
| leftHitEvent | Event(BONK LEFT) | Event(BONK LEFT) |  |  |
| otherLayer | true | true |  |  |
| otherLayerNumber | 25 | 25 |  |  |
| ignoreTriggers | false | false |  |  |

##### 8. CheckCollisionSide

Full Name: HutongGames.PlayMaker.Actions.CheckCollisionSide
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| topHit | false | false | Variable |  |
| rightHit | false | false | Variable |  |
| bottomHit | false | false | Variable |  |
| leftHit | false | false | Variable |  |
| topHitEvent | Event(BONK UP) | Event(BONK UP) |  |  |
| rightHitEvent | Event(BONK RIGHT) | Event(BONK RIGHT) |  |  |
| bottomHitEvent | Event(BONK DOWN) | Event(BONK DOWN) |  |  |
| leftHitEvent | Event(BONK LEFT) | Event(BONK LEFT) |  |  |
| otherLayer | true | true |  |  |
| otherLayerNumber | 24 | 24 |  |  |
| ignoreTriggers | false | false |  |  |

##### 9. CheckCollisionSideEnter

Full Name: HutongGames.PlayMaker.Actions.CheckCollisionSideEnter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| topHit | false | false | Variable |  |
| rightHit | false | false | Variable |  |
| bottomHit | false | false | Variable |  |
| leftHit | false | false | Variable |  |
| topHitEvent | Event(BONK UP) | Event(BONK UP) |  |  |
| rightHitEvent | Event(BONK RIGHT) | Event(BONK RIGHT) |  |  |
| bottomHitEvent | Event(BONK DOWN) | Event(BONK DOWN) |  |  |
| leftHitEvent | Event(BONK LEFT) | Event(BONK LEFT) |  |  |
| otherLayer | true | true |  |  |
| otherLayerNumber | 24 | 24 |  |  |
| ignoreTriggers | false | false |  |  |

### Stopped

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetBoolValue

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

##### 1. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min | 0f | 0f |  |  |
| max | 360f | 360f |  |  |
| storeResult | float Angle | float Angle | Variable |  |

##### 2. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Start Up | bool Start Up | Variable |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(FINISHED) | Event(FINISHED) |  |  |
| everyFrame | false | false |  |  |

##### 3. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Angle | float Angle | Variable |  |
| floatValue | 90f | 90f |  |  |
| everyFrame | false | false |  |  |

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
| min | 20f | 20f |  |  |
| max | 160f | 160f |  |  |
| storeResult | float Angle | float Angle | Variable |  |

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
| min | -70f | -70f |  |  |
| max | 70f | 70f |  |  |
| storeResult | float Angle | float Angle | Variable |  |

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
| min | 110f | 110f |  |  |
| max | 250f | 250f |  |  |
| storeResult | float Angle | float Angle | Variable |  |

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
| min | 200f | 200f |  |  |
| max | 340f | 340f |  |  |
| storeResult | float Angle | float Angle | Variable |  |

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
| Fly 2 | BONK DOWN | Hit Down | 0 | 0 | 0 |
| Fly 2 | BONK LEFT | Hit Left | 0 | 0 | 0 |
| Fly 2 | BONK RIGHT | Hit Right | 0 | 0 | 0 |
| Fly 2 | BONK UP | Hit Up | 0 | 0 | 0 |
| Stopped | WAKE | Aim | 0 | 0 | 0 |
| Aim | FINISHED | Left or Right? | 0 | 0 | 0 |
| Go Up | FINISHED | Left or Right? | 0 | 0 | 0 |
| Go Right | FINISHED | Left or Right? | 0 | 0 | 0 |
| Go Left | FINISHED | Left or Right? | 0 | 0 | 0 |
| Go Down | FINISHED | Left or Right? | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| GO DOWN | Go Down | 0 | 0 | 0 |
| GO LEFT | Go Left | 0 | 0 | 0 |
| GO RIGHT | Go Right | 0 | 0 | 0 |
| STOP | Stopped | 0 | 0 | 0 |
| GO UP | Go Up | 0 | 0 | 0 |

## Events

| Name | Global |
| --- | --- |
| COLLISION STAY | false |
| FINISHED | false |
| BONK DOWN | false |
| BONK LEFT | false |
| BONK RIGHT | false |
| BONK UP | false |
| COLLISION ENTER 2D | true |
| COLLISION STAY 2D | true |
| DOWN | false |
| GO DOWN | false |
| GO LEFT | false |
| GO RIGHT | false |
| GO UP | false |
| LEFT | false |
| RIGHT | false |
| STOP | false |
| UP | false |
| WAKE | true |

