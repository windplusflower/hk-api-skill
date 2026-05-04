# Bouncer Control

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Bouncer Control |
| GameObject Name | Bursting Bouncer (5) |
| GameObject Path | Infected Parent/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level43 |
| Start State | Initialise |
| FSM PathId | 6242 |
| GameObject PathId | 615 |

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
| Speed | 6.5 | Single: 6.5 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Facing Right | false | Boolean: false |
| Moving Up | false | Boolean: false |
| Start Up | false | Boolean: false |
| Starts Inactive | false | Boolean: false |

### Vector2s

| Name | Value | Raw/Type |
| --- | --- | --- |
| Bounds | Vector2(0, 0) | Vector2: Vector2(0, 0) |
| Origin | Vector2(0, 0) | Vector2: Vector2(0, 0) |

### Vector3s

| Name | Value | Raw/Type |
| --- | --- | --- |
| Contact Normal | Vector2(0, 0) | Vector2: Vector2(0, 0) |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Camera | [null] | NamedAssetPPtr: [null] |
| Hero | [null] | NamedAssetPPtr: [null] |
| Self | [null] | NamedAssetPPtr: [null] |

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
| storeGameObject |   | GameObject Self | Variable |   |

##### 2. FindGameObject

Full Name: HutongGames.PlayMaker.Actions.FindGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| objectName |   | "" |   |   |
| withTag |   | "MainCamera" | Tag |   |
| store |   | GameObject Camera | Variable |   |

##### 3. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Starts Inactive | Variable |   |
| isTrue |   | Event(STOP) |   |   |
| isFalse |   | Event() |   |   |
| everyFrame |   | false |   |   |

##### 4. GetDistance

Full Name: HutongGames.PlayMaker.Actions.GetDistance
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Self |   |   |
| target |   | GameObject Camera |   |   |
| storeResult |   | float Distance | Variable |   |
| everyFrame |   | true |   |   |

##### 5. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 |   | float Distance |   |   |
| float2 |   | 44f |   |   |
| tolerance |   | 0f |   |   |
| equal |   | Event() |   |   |
| lessThan |   | Event(FINISHED) |   |   |
| greaterThan |   | Event() |   |   |
| everyFrame |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Aim | 0 | |

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
| floatVariable |   | float Angle | Variable |   |
| lessThan |   | FSMViewAvalonia2.FsmArray2 |   |   |
| sendEvent |   | FSMViewAvalonia2.FsmArray2 |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| LEFT | Face Left | 0 | |
| RIGHT | Face Right | 0 | |

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
| boolVariable |   | bool Facing Right | Variable |   |
| boolValue |   | false |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Fly 2 | 0 | |

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
| boolVariable |   | bool Facing Right | Variable |   |
| boolValue |   | true |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Fly 2 | 0 | |

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
| boolVariable |   | bool Facing Right | Variable |   |
| isTrue |   | Event(RIGHT) |   |   |
| isFalse |   | Event(LEFT) |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| RIGHT | Up Right | 0 | |
| LEFT | Up Left | 0 | |

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
| min |   | 320f |   |   |
| max |   | 350f |   |   |
| storeResult |   | float Angle | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Left or Right? | 0 | |

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
| min |   | 190f |   |   |
| max |   | 220f |   |   |
| storeResult |   | float Angle | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Left or Right? | 0 | |

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
| boolVariable |   | bool Facing Right | Variable |   |
| isTrue |   | Event(RIGHT) |   |   |
| isFalse |   | Event(LEFT) |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| RIGHT | Down Right | 0 | |
| LEFT | Up Left 2 | 0 | |

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
| min |   | 10f |   |   |
| max |   | 40f |   |   |
| storeResult |   | float Angle | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Left or Right? | 0 | |

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
| min |   | 140f |   |   |
| max |   | 170f |   |   |
| storeResult |   | float Angle | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Left or Right? | 0 | |

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
| floatVariable |   | float Angle | Variable |   |
| lessThan |   | FSMViewAvalonia2.FsmArray2 |   |   |
| sendEvent |   | FSMViewAvalonia2.FsmArray2 |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| UP | Down Right 2 | 0 | |
| DOWN | Right Down | 0 | |

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
| min |   | 190f |   |   |
| max |   | 220f |   |   |
| storeResult |   | float Angle | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Left or Right? | 0 | |

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
| min |   | 140f |   |   |
| max |   | 170f |   |   |
| storeResult |   | float Angle | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Left or Right? | 0 | |

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
| floatVariable |   | float Angle | Variable |   |
| lessThan |   | FSMViewAvalonia2.FsmArray2 |   |   |
| sendEvent |   | FSMViewAvalonia2.FsmArray2 |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| UP | Left Up | 0 | |
| DOWN | Left Down | 0 | |

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
| min |   | 320f |   |   |
| max |   | 350f |   |   |
| storeResult |   | float Angle | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Left or Right? | 0 | |

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
| min |   | 10f |   |   |
| max |   | 40f |   |   |
| storeResult |   | float Angle | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Left or Right? | 0 | |

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
| gameObject |   | OwnerDefault FSM Owner |   |   |
| spriteFacesRight |   | false |   |   |
| playNewAnimation |   | false |   |   |
| newAnimationClip |   | "" |   |   |
| everyFrame |   | true |   |   |
| pauseBetweenTurns |   | false |   |   |
| pauseTime |   | 0f |   |   |

##### 2. SetVelocityAsAngle

Full Name: HutongGames.PlayMaker.Actions.SetVelocityAsAngle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Self |   |   |
| angle |   | float Angle |   |   |
| speed |   | float Speed |   |   |
| everyFrame |   | true |   |   |

##### 3. Collision2dEvent

Full Name: HutongGames.PlayMaker.Actions.Collision2dEvent
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| collision | HutongGames.PlayMaker.Collision2DType::OnCollisionStay2D | 1 |   |   |
| collideTag |   | "" | Tag |   |
| sendEvent |   | Event(COLLISION STAY 2D) |   |   |
| storeCollider |   |   | Variable |   |
| storeForce |   | 0f | Variable |   |

##### 4. CheckCollisionSide

Full Name: HutongGames.PlayMaker.Actions.CheckCollisionSide
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| topHit |   | false | Variable |   |
| rightHit |   | false | Variable |   |
| bottomHit |   | false | Variable |   |
| leftHit |   | false | Variable |   |
| topHitEvent |   | Event(BONK UP) |   |   |
| rightHitEvent |   | Event(BONK RIGHT) |   |   |
| bottomHitEvent |   | Event(BONK DOWN) |   |   |
| leftHitEvent |   | Event(BONK LEFT) |   |   |
| otherLayer |   | false |   |   |
| otherLayerNumber |   | 0 |   |   |
| ignoreTriggers |   | false |   |   |

##### 5. CheckCollisionSideEnter

Full Name: HutongGames.PlayMaker.Actions.CheckCollisionSideEnter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| topHit |   | false | Variable |   |
| rightHit |   | false | Variable |   |
| bottomHit |   | false | Variable |   |
| leftHit |   | false | Variable |   |
| topHitEvent |   | Event(BONK UP) |   |   |
| rightHitEvent |   | Event(BONK RIGHT) |   |   |
| bottomHitEvent |   | Event(BONK DOWN) |   |   |
| leftHitEvent |   | Event(BONK LEFT) |   |   |
| otherLayer |   | false |   |   |
| otherLayerNumber |   | 0 |   |   |
| ignoreTriggers |   | false |   |   |

##### 6. CheckCollisionSide

Full Name: HutongGames.PlayMaker.Actions.CheckCollisionSide
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| topHit |   | false | Variable |   |
| rightHit |   | false | Variable |   |
| bottomHit |   | false | Variable |   |
| leftHit |   | false | Variable |   |
| topHitEvent |   | Event(BONK UP) |   |   |
| rightHitEvent |   | Event(BONK RIGHT) |   |   |
| bottomHitEvent |   | Event(BONK DOWN) |   |   |
| leftHitEvent |   | Event(BONK LEFT) |   |   |
| otherLayer |   | true |   |   |
| otherLayerNumber |   | 25 |   |   |
| ignoreTriggers |   | false |   |   |

##### 7. CheckCollisionSideEnter

Full Name: HutongGames.PlayMaker.Actions.CheckCollisionSideEnter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| topHit |   | false | Variable |   |
| rightHit |   | false | Variable |   |
| bottomHit |   | false | Variable |   |
| leftHit |   | false | Variable |   |
| topHitEvent |   | Event(BONK UP) |   |   |
| rightHitEvent |   | Event(BONK RIGHT) |   |   |
| bottomHitEvent |   | Event(BONK DOWN) |   |   |
| leftHitEvent |   | Event(BONK LEFT) |   |   |
| otherLayer |   | true |   |   |
| otherLayerNumber |   | 25 |   |   |
| ignoreTriggers |   | false |   |   |

##### 8. CheckCollisionSide

Full Name: HutongGames.PlayMaker.Actions.CheckCollisionSide
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| topHit |   | false | Variable |   |
| rightHit |   | false | Variable |   |
| bottomHit |   | false | Variable |   |
| leftHit |   | false | Variable |   |
| topHitEvent |   | Event(BONK UP) |   |   |
| rightHitEvent |   | Event(BONK RIGHT) |   |   |
| bottomHitEvent |   | Event(BONK DOWN) |   |   |
| leftHitEvent |   | Event(BONK LEFT) |   |   |
| otherLayer |   | true |   |   |
| otherLayerNumber |   | 24 |   |   |
| ignoreTriggers |   | false |   |   |

##### 9. CheckCollisionSideEnter

Full Name: HutongGames.PlayMaker.Actions.CheckCollisionSideEnter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| topHit |   | false | Variable |   |
| rightHit |   | false | Variable |   |
| bottomHit |   | false | Variable |   |
| leftHit |   | false | Variable |   |
| topHitEvent |   | Event(BONK UP) |   |   |
| rightHitEvent |   | Event(BONK RIGHT) |   |   |
| bottomHitEvent |   | Event(BONK DOWN) |   |   |
| leftHitEvent |   | Event(BONK LEFT) |   |   |
| otherLayer |   | true |   |   |
| otherLayerNumber |   | 24 |   |   |
| ignoreTriggers |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| BONK DOWN | Hit Down | 0 | |
| BONK LEFT | Hit Left | 0 | |
| BONK RIGHT | Hit Right | 0 | |
| BONK UP | Hit Up | 0 | |

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
| boolVariable |   | bool Starts Inactive | Variable |   |
| boolValue |   | false |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| WAKE | Aim | 0 | |

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
| min |   | 0f |   |   |
| max |   | 360f |   |   |
| storeResult |   | float Angle | Variable |   |

##### 2. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Start Up | Variable |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(FINISHED) |   |   |
| everyFrame |   | false |   |   |

##### 3. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Angle | Variable |   |
| floatValue |   | 90f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Left or Right? | 0 | |

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
| min |   | 20f |   |   |
| max |   | 160f |   |   |
| storeResult |   | float Angle | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Left or Right? | 0 | |

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
| min |   | -70f |   |   |
| max |   | 70f |   |   |
| storeResult |   | float Angle | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Left or Right? | 0 | |

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
| min |   | 110f |   |   |
| max |   | 250f |   |   |
| storeResult |   | float Angle | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Left or Right? | 0 | |

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
| min |   | 200f |   |   |
| max |   | 340f |   |   |
| storeResult |   | float Angle | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Left or Right? | 0 | |

## Global Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| GO DOWN | Go Down | 0 | |
| GO LEFT | Go Left | 0 | |
| GO RIGHT | Go Right | 0 | |
| STOP | Stopped | 0 | |
| GO UP | Go Up | 0 | |

## Events

| Name | Global |
| --- | --- |
| BONK DOWN | false |
| BONK LEFT | false |
| BONK RIGHT | false |
| BONK UP | false |
| COLLISION ENTER 2D | true |
| COLLISION STAY | false |
| COLLISION STAY 2D | true |
| DOWN | false |
| FINISHED | false |
| GO DOWN | false |
| GO LEFT | false |
| GO RIGHT | false |
| GO UP | false |
| LEFT | false |
| RIGHT | false |
| STOP | false |
| UP | false |
| WAKE | true |

