# Attack

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Attack |
| GameObject Name | Flip Hopper (2) |
| GameObject Path |   |
| Source Asset | Hollow Knight/hollow_knight_Data/level356 |
| Start State | Init |
| FSM PathId | 3241 |
| GameObject PathId | 590 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Jump Height | 0 | Single: 0 |
| Random Sign | 0 | Single: 0 |
| X Scale | 0 | Single: 0 |
| X Vel | 0 | Single: 0 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Facing Right | false | Boolean: false |
| Hero Range | false | Boolean: false |
| Hero Right | false | Boolean: false |
| Side A | false | Boolean: false |
| isFlipping | false | Boolean: false |

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| FlipAnim |   | String:  |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Hopper Hit | [null] | NamedAssetPPtr: [null] |
| Self | [null] | NamedAssetPPtr: [null] |
| Walker Hit | [null] | NamedAssetPPtr: [null] |

## States

### Init

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

##### 2. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Side A | Variable |   |
| boolValue |   | true |   |   |
| everyFrame |   | false |   |   |

##### 3. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool isFlipping | Variable |   |
| boolValue |   | false |   |   |
| everyFrame |   | false |   |   |

##### 4. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable |   | string FlipAnim | Variable |   |
| stringValue |   | "Flip" | TextArea |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Idle | 0 | |

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool isFlipping | Variable |   |
| boolValue |   | false |   |   |
| everyFrame |   | false |   |   |

##### 2. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Side A | Variable |   |
| isTrue |   | Event(Side A) |   |   |
| isFalse |   | Event(Side B) |   |   |
| everyFrame |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| Side A | Side A | 0 | |
| Side B | Check Collison 2 | 0 | |

### Side A

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. GetScale

Full Name: HutongGames.PlayMaker.Actions.GetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| xScale |   | float X Scale | Variable |   |
| yScale |   | 0f | Variable |   |
| zScale |   | 0f | Variable |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |

##### 2. FloatTestToBool

Full Name: HutongGames.PlayMaker.Actions.FloatTestToBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 |   | float X Scale |   |   |
| float2 |   | 0f |   |   |
| tolerance |   | 0f |   |   |
| equalBool |   | false | Variable |   |
| lessThanBool |   | bool Facing Right | Variable |   |
| greaterThanBool |   | false | Variable |   |
| everyFrame |   | false |   |   |

##### 3. SetWalkerFacing

Full Name: SetWalkerFacing
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| walkRight |   | bool Facing Right |   |   |
| randomStartDir |   | false |   |   |
| target |   | OwnerDefault FSM Owner |   |   |
| everyFrame |   | false |   |   |

##### 4. StartWalker

Full Name: StartWalker
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| walkRight |   | false |   |   |
| target |   | OwnerDefault FSM Owner |   |   |
| everyFrame |   | false |   |   |

##### 5. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable |   | string FlipAnim | Variable |   |
| stringValue |   | "Flip" | TextArea |   |
| everyFrame |   | false |   |   |

##### 6. SetBoxCollider2DSize

Full Name: HutongGames.PlayMaker.Actions.SetBoxCollider2DSize
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject1 |   | OwnerDefault FSM Owner |   |   |
| width |   | 2.137f |   |   |
| height |   | 1.511f |   |   |
| offsetX |   | -0.2667122f |   |   |
| offsetY |   | -0.533f |   |   |

#### Transitions

(none)

### Side B

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "Side B Hop" |   |   |

##### 2. AudioPlaySimple

Full Name: HutongGames.PlayMaker.Actions.AudioPlaySimple
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| volume |   | 1f |   |   |
| oneShotClip |   | [flip_hopper_jump (AudioClip) (Hollow Knight/hollow_knight_Data\sharedassets349.assets)] |   |   |

##### 3. GetScale

Full Name: HutongGames.PlayMaker.Actions.GetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| xScale |   | float Random Sign | Variable |   |
| yScale |   | 0f | Variable |   |
| zScale |   | 0f | Variable |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |

##### 4. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min |   | 5f |   |   |
| max |   | 12f |   |   |
| storeResult |   | float X Vel | Variable |   |

##### 5. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min |   | 20f |   |   |
| max |   | 25f |   |   |
| storeResult |   | float Jump Height | Variable |   |

##### 6. FloatMultiply

Full Name: HutongGames.PlayMaker.Actions.FloatMultiply
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float X Vel | Variable |   |
| multiplyBy |   | float Random Sign |   |   |
| everyFrame |   | false |   |   |

##### 7. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector2(0, 0) |   |   |
| x |   | float X Vel |   |   |
| y |   | float Jump Height |   |   |
| everyFrame |   | false |   |   |

##### 8. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 1f |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |

##### 9. NextFrameEvent

Full Name: HutongGames.PlayMaker.Actions.NextFrameEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent |   | Event(FINISHED) |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Check Collison | 0 | |

### Flip

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool isFlipping | Variable |   |
| isTrue |   | Event(FINISHED) |   |   |
| isFalse |   | Event() |   |   |
| everyFrame |   | false |   |   |

##### 2. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer |   | [Global] [Audio Player Actor (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| audioClip |   | [flip_hopper_flip (AudioClip) (Hollow Knight/hollow_knight_Data\sharedassets349.assets)] |   |   |
| pitchMin |   | 1f |   |   |
| pitchMax |   | 1f |   |   |
| volume |   | 1f |   |   |
| delay |   | 0f |   |   |
| storePlayer |   |   |   |   |

##### 3. BoolFlip

Full Name: HutongGames.PlayMaker.Actions.BoolFlip
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Side A | Variable |   |

##### 4. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| animLibName |   | "" |   |   |
| clipName |   | string FlipAnim |   |   |

##### 5. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool isFlipping | Variable |   |
| boolValue |   | true |   |   |
| everyFrame |   | false |   |   |

##### 6. Tk2dWatchAnimationEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dWatchAnimationEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| animationTriggerEvent |   | Event() |   |   |
| animationCompleteEvent |   | Event(FINISHED) |   |   |

##### 7. StopWalker

Full Name: StopWalker
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target |   | OwnerDefault FSM Owner |   |   |
| everyFrame |   | false |   |   |

##### 8. SetVelocity2d

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
| FINISHED | Idle | 0 | |

### Hop Start

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByNameV2

Full Name: HutongGames.PlayMaker.Actions.SendEventByNameV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):FSM Owner |   |   |
| sendEvent |   | "MOVESTOP" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 2. AudioPlaySimple

Full Name: HutongGames.PlayMaker.Actions.AudioPlaySimple
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| volume |   | 1f |   |   |
| oneShotClip |   | [flip_hopper_jump (AudioClip) (Hollow Knight/hollow_knight_Data\sharedassets349.assets)] |   |   |

##### 3. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector2(0, 0) |   |   |
| x |   | 0f |   |   |
| y |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 4. FaceObject

Full Name: HutongGames.PlayMaker.Actions.FaceObject
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| objectA |   | GameObject Self |   |   |
| objectB |   | [Global] GameObject Hero | Variable |   |
| spriteFacesRight |   | true |   |   |
| playNewAnimation |   | true |   |   |
| newAnimationClip |   | "Side B Turn" |   |   |
| resetFrame |   | false |   |   |
| everyFrame |   | false |   |   |

##### 5. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable |   | string FlipAnim | Variable |   |
| stringValue |   | "Flip B" | TextArea |   |
| everyFrame |   | false |   |   |

##### 6. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| clipName |   | "Hop Start" |   |   |
| animationTriggerEvent |   | Event() |   |   |
| animationCompleteEvent |   | Event(FINISHED) |   |   |

##### 7. SetBoxCollider2DSize

Full Name: HutongGames.PlayMaker.Actions.SetBoxCollider2DSize
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject1 |   | OwnerDefault FSM Owner |   |   |
| width |   | 2.137f |   |   |
| height |   | 1.512f |   |   |
| offsetX |   | 0.137f |   |   |
| offsetY |   | -0.533f |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Side B | 0 | |

### Hop Recover

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector2(0, 0) |   |   |
| x |   | 0f |   |   |
| y |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 2. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| clipName |   | "Hop Recover" |   |   |
| animationTriggerEvent |   | Event() |   |   |
| animationCompleteEvent |   | Event(FINISHED) |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Hero Check | 0 | |

### Check Collison

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. CheckCollisionSide

Full Name: HutongGames.PlayMaker.Actions.CheckCollisionSide
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| topHit |   | false | Variable |   |
| rightHit |   | false | Variable |   |
| bottomHit |   | false | Variable |   |
| leftHit |   | false | Variable |   |
| topHitEvent |   | Event() |   |   |
| rightHitEvent |   | Event() |   |   |
| bottomHitEvent |   | Event(HitGround) |   |   |
| leftHitEvent |   | Event() |   |   |
| otherLayer |   | false |   |   |
| otherLayerNumber |   | 0 |   |   |
| ignoreTriggers |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| HitGround | Hop Recover | 0 | |

### Turn?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GetScale

Full Name: HutongGames.PlayMaker.Actions.GetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| xScale |   | float X Scale | Variable |   |
| yScale |   | 0f | Variable |   |
| zScale |   | 0f | Variable |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |

##### 2. FloatTestToBool

Full Name: HutongGames.PlayMaker.Actions.FloatTestToBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 |   | float X Scale |   |   |
| float2 |   | 0f |   |   |
| tolerance |   | 0f |   |   |
| equalBool |   | false | Variable |   |
| lessThanBool |   | false | Variable |   |
| greaterThanBool |   | bool Facing Right | Variable |   |
| everyFrame |   | false |   |   |

##### 3. CheckTargetDirection

Full Name: HutongGames.PlayMaker.Actions.CheckTargetDirection
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| target |   | [Global] GameObject Hero |   |   |
| aboveEvent |   | Event() |   |   |
| belowEvent |   | Event() |   |   |
| rightEvent |   | Event() |   |   |
| leftEvent |   | Event() |   |   |
| aboveBool |   | false | Variable |   |
| belowBool |   | false | Variable |   |
| rightBool |   | bool Hero Right | Variable |   |
| leftBool |   | false | Variable |   |
| everyFrame |   | false |   |   |

##### 4. BoolTestMulti

Full Name: HutongGames.PlayMaker.Actions.BoolTestMulti
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariables |   | FSMViewAvalonia2.FsmArray2 | Variable |   |
| boolStates |   | FSMViewAvalonia2.FsmArray2 |   |   |
| trueEvent |   | Event(CANCEL) |   |   |
| falseEvent |   | Event() |   |   |
| storeResult |   | false | Variable |   |
| everyFrame |   | false |   |   |

##### 5. BoolTestMulti

Full Name: HutongGames.PlayMaker.Actions.BoolTestMulti
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariables |   | FSMViewAvalonia2.FsmArray2 | Variable |   |
| boolStates |   | FSMViewAvalonia2.FsmArray2 |   |   |
| trueEvent |   | Event(CANCEL) |   |   |
| falseEvent |   | Event() |   |   |
| storeResult |   | false | Variable |   |
| everyFrame |   | false |   |   |

##### 6. FlipScale

Full Name: HutongGames.PlayMaker.Actions.FlipScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| flipHorizontally |   | true |   |   |
| flipVertically |   | false |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

##### 7. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| clipName |   | "Side B Turn" |   |   |
| animationTriggerEvent |   | Event() |   |   |
| animationCompleteEvent |   | Event(FINISHED) |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Hop Start | 0 | |
| CANCEL | Hop Start | 0 | |

### Flip Scale

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. FlipScale

Full Name: HutongGames.PlayMaker.Actions.FlipScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| flipHorizontally |   | true |   |   |
| flipVertically |   | false |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Hop Start | 0 | |

### Hero Check

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Hero Range | Variable |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(FLIP) |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Idle | 0 | |
| FLIP | Flip | 0 | |

### Check Collison 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. CheckCollisionSide

Full Name: HutongGames.PlayMaker.Actions.CheckCollisionSide
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| topHit |   | false | Variable |   |
| rightHit |   | false | Variable |   |
| bottomHit |   | false | Variable |   |
| leftHit |   | false | Variable |   |
| topHitEvent |   | Event() |   |   |
| rightHitEvent |   | Event() |   |   |
| bottomHitEvent |   | Event(HitGround) |   |   |
| leftHitEvent |   | Event() |   |   |
| otherLayer |   | false |   |   |
| otherLayerNumber |   | 0 |   |   |
| ignoreTriggers |   | false |   |   |

##### 2. CheckCollisionSideEnter

Full Name: HutongGames.PlayMaker.Actions.CheckCollisionSideEnter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| topHit |   | false | Variable |   |
| rightHit |   | false | Variable |   |
| bottomHit |   | false | Variable |   |
| leftHit |   | false | Variable |   |
| topHitEvent |   | Event() |   |   |
| rightHitEvent |   | Event() |   |   |
| bottomHitEvent |   | Event(HitGround) |   |   |
| leftHitEvent |   | Event() |   |   |
| otherLayer |   | false |   |   |
| otherLayerNumber |   | 0 |   |   |
| ignoreTriggers |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| HitGround | Turn? | 0 | |

## Global Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| TOOK DAMAGE | Flip | 0 | |

## Events

| Name | Global |
| --- | --- |
| CANCEL | false |
| FINISHED | false |
| FLIP | false |
| HitGround | false |
| Side A | false |
| Side B | false |
| TOOK DAMAGE | false |

