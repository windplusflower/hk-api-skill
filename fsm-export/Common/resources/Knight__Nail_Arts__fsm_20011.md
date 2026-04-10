# Nail Arts

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Nail Arts |
| GameObject Name | Knight |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Init |
| FSM PathId | 20011 |
| GameObject PathId | 3895 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Cyclone Timer | 0 | Single: 0 |
| Timer | 0 | Single: 0 |
| X Velocity | 0 | Single: 0 |
| Y Velocity | 0 | Single: 0 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Dashing | false | Boolean: false |
| Facing Right | false | Boolean: false |
| Has Cyclone | false | Boolean: false |
| Has Cyclone | false | Boolean: false |
| Has G Slash | false | Boolean: false |
| Return Bool | false | Boolean: false |
| Wall Sliding | false | Boolean: false |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Attack Folder | [null] | NamedAssetPPtr:  |
| Audio Player | [null] | NamedAssetPPtr:  |
| Cyclone Slash | [null] | NamedAssetPPtr:  |
| Dash Slash | [null] | NamedAssetPPtr:  |
| Effect Folder | [null] | NamedAssetPPtr:  |
| Great Slash Effect | [null] | NamedAssetPPtr:  |
| SD Sharp Flash | [null] | NamedAssetPPtr:  |
| Self | [null] | NamedAssetPPtr:  |

## States

### Inactive

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. ListenForAttack

Full Name: HutongGames.PlayMaker.Actions.ListenForAttack
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| wasPressed | Event() | Event() |  |  |
| wasReleased | Event(BUTTON UP) | Event(BUTTON UP) |  |  |
| isPressed | Event() | Event() |  |  |
| isNotPressed | Event() | Event() |  |  |

### Regain Control

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | RegainControl(???) | RegainControl(???) |  |  |

##### 2. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | StartAnimationControl(???) | StartAnimationControl(???) |  |  |

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
| storeGameObject | GameObject Self | GameObject Self | Variable |  |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Attacks" | "Attacks" |  |  |
| storeResult | GameObject Attack Folder | GameObject Attack Folder | Variable |  |

##### 3. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Attack Folder | OwnerDefault Attack Folder |  |  |
| childName | "Cyclone Slash" | "Cyclone Slash" |  |  |
| storeResult | GameObject Cyclone Slash | GameObject Cyclone Slash | Variable |  |

##### 4. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Attack Folder | OwnerDefault Attack Folder |  |  |
| childName | "Great Slash" | "Great Slash" |  |  |
| storeResult | GameObject Great Slash Effect | GameObject Great Slash Effect | Variable |  |

##### 5. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Attack Folder | OwnerDefault Attack Folder |  |  |
| childName | "Dash Slash" | "Dash Slash" |  |  |
| storeResult | GameObject Dash Slash | GameObject Dash Slash | Variable |  |

##### 6. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Effects" | "Effects" |  |  |
| storeResult | GameObject Effect Folder | GameObject Effect Folder | Variable |  |

##### 7. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Effect Folder | OwnerDefault Effect Folder |  |  |
| childName | "SD Sharp Flash" | "SD Sharp Flash" |  |  |
| storeResult | GameObject SD Sharp Flash | GameObject SD Sharp Flash | Variable |  |

### Cancel All

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | EndCyclone(???) | EndCyclone(???) |  |  |

##### 2. DestroyObject

Full Name: HutongGames.PlayMaker.Actions.DestroyObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Audio Player | GameObject Audio Player |  |  |
| delay | 0f | 0f |  |  |
| detachChildren | false | false |  |  |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Great Slash Effect | OwnerDefault Great Slash Effect |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 4. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Cyclone Slash | OwnerDefault Cyclone Slash |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 5. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Dash Slash | OwnerDefault Dash Slash |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

### Can Nail Art?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| behaviour | "HeroController" | "HeroController" | Behaviour |  |
| methodName | "GetState" | "GetState" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var Dashing = False | Var Dashing = False | Variable | Store Result |

##### 2. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| behaviour | "HeroController" | "HeroController" | Behaviour |  |
| methodName | "CanNailArt" | "CanNailArt" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var Return Bool = False | Var Return Bool = False | Variable | Store Result |

##### 3. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Return Bool | bool Return Bool | Variable |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(CANCEL) | Event(CANCEL) |  |  |
| everyFrame | false | false |  |  |

##### 4. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Dashing | bool Dashing | Variable |  |
| isTrue | Event(DASH CHECK) | Event(DASH CHECK) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

### Take Control

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | RelinquishControlNotVelocity(???) | RelinquishControlNotVelocity(???) |  |  |

##### 2. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | StopAnimationControl(???) | StopAnimationControl(???) |  |  |

### Move Choice

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | Event(CYCLONE) | Event(CYCLONE) |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. ListenForDown

Full Name: HutongGames.PlayMaker.Actions.ListenForDown
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| wasPressed | Event() | Event() |  |  |
| wasReleased | Event() | Event() |  |  |
| isPressed | Event(CYCLONE) | Event(CYCLONE) |  |  |
| isNotPressed | Event() | Event() |  |  |
| isPressedBool | false | false | Variable |  |
| stateEntryOnly | false | false |  |  |

##### 3. ListenForUp

Full Name: HutongGames.PlayMaker.Actions.ListenForUp
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| wasPressed | Event() | Event() |  |  |
| wasReleased | Event() | Event() |  |  |
| isPressed | Event(CYCLONE) | Event(CYCLONE) |  |  |
| isNotPressed | Event(GREAT SLASH) | Event(GREAT SLASH) |  |  |
| isPressedBool | false | false | Variable |  |
| stateEntryOnly | false | false |  |  |

### Cyclone Start

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | StartCyclone(???) | StartCyclone(???) |  |  |

##### 2. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| clipName | "NA Cyclone Start" | "NA Cyclone Start" |  |  |
| animationTriggerEvent | Event() | Event() |  |  |
| animationCompleteEvent | Event(FINISHED) | Event(FINISHED) |  |  |

##### 3. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Cyclone Timer | float Cyclone Timer | Variable |  |
| floatValue | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 4. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Timer | float Timer | Variable |  |
| floatValue | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 5. ListenForAttack

Full Name: HutongGames.PlayMaker.Actions.ListenForAttack
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| wasPressed | Event(BUTTON DOWN) | Event(BUTTON DOWN) |  |  |
| wasReleased | Event() | Event() |  |  |
| isPressed | Event() | Event() |  |  |
| isNotPressed | Event() | Event() |  |  |

### Cyclone Spin

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animLibName | "" | "" |  |  |
| clipName | "NA Cyclone" | "NA Cyclone" |  |  |

##### 2. FloatAdd

Full Name: HutongGames.PlayMaker.Actions.FloatAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Timer | float Timer | Variable |  |
| add | 1f | 1f |  |  |
| everyFrame | true | true |  |  |
| perSecond | true | true |  |  |

##### 3. FloatAdd

Full Name: HutongGames.PlayMaker.Actions.FloatAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Cyclone Timer | float Cyclone Timer | Variable |  |
| add | 1f | 1f |  |  |
| everyFrame | true | true |  |  |
| perSecond | true | true |  |  |

##### 4. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float Timer | float Timer |  |  |
| float2 | 0.45f | 0.45f |  |  |
| tolerance | 0f | 0f |  |  |
| equal | Event(END) | Event(END) |  |  |
| lessThan | Event() | Event() |  |  |
| greaterThan | Event(END) | Event(END) |  |  |
| everyFrame | true | true |  |  |

##### 5. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float Cyclone Timer | float Cyclone Timer |  |  |
| float2 | 1.2f | 1.2f |  |  |
| tolerance | 0f | 0f |  |  |
| equal | Event(END) | Event(END) |  |  |
| lessThan | Event() | Event() |  |  |
| greaterThan | Event(END) | Event(END) |  |  |
| everyFrame | true | true |  |  |

##### 6. ListenForAttack

Full Name: HutongGames.PlayMaker.Actions.ListenForAttack
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| wasPressed | Event(BUTTON DOWN) | Event(BUTTON DOWN) |  |  |
| wasReleased | Event() | Event() |  |  |
| isPressed | Event() | Event() |  |  |
| isNotPressed | Event() | Event() |  |  |

### Cyclone Extend

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.GetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector2(0, 0) | Vector2(0, 0) | Variable |  |
| x | 0f | 0f | Variable |  |
| y | float Y Velocity | float Y Velocity | Variable |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | true | true |  |  |

##### 2. FloatClamp

Full Name: HutongGames.PlayMaker.Actions.FloatClamp
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Y Velocity | float Y Velocity | Variable |  |
| minValue | -4f | -4f |  |  |
| maxValue | 9999f | 9999f |  |  |
| everyFrame | true | true |  |  |

##### 3. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector2(0, 0) | Vector2(0, 0) |  |  |
| x | 0f | 0f |  |  |
| y | float Y Velocity | float Y Velocity |  |  |
| everyFrame | true | true |  |  |

##### 4. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | ResetHardLandingTimer(???) | ResetHardLandingTimer(???) |  |  |

##### 5. FloatSubtract

Full Name: HutongGames.PlayMaker.Actions.FloatSubtract
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Timer | float Timer | Variable |  |
| subtract | 0.3f | 0.3f |  |  |
| everyFrame | false | false |  |  |
| perSecond | false | false |  |  |

##### 6. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animLibName | "" | "" |  |  |
| clipName | "NA Cyclone" | "NA Cyclone" |  |  |

##### 7. FloatAdd

Full Name: HutongGames.PlayMaker.Actions.FloatAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Timer | float Timer | Variable |  |
| add | 1f | 1f |  |  |
| everyFrame | true | true |  |  |
| perSecond | true | true |  |  |

##### 8. FloatAdd

Full Name: HutongGames.PlayMaker.Actions.FloatAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Cyclone Timer | float Cyclone Timer | Variable |  |
| add | 1f | 1f |  |  |
| everyFrame | true | true |  |  |
| perSecond | true | true |  |  |

##### 9. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float Timer | float Timer |  |  |
| float2 | 0.45f | 0.45f |  |  |
| tolerance | 0f | 0f |  |  |
| equal | Event(END) | Event(END) |  |  |
| lessThan | Event() | Event() |  |  |
| greaterThan | Event(END) | Event(END) |  |  |
| everyFrame | true | true |  |  |

##### 10. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float Cyclone Timer | float Cyclone Timer |  |  |
| float2 | 1.2f | 1.2f |  |  |
| tolerance | 0f | 0f |  |  |
| equal | Event(END) | Event(END) |  |  |
| lessThan | Event() | Event() |  |  |
| greaterThan | Event(END) | Event(END) |  |  |
| everyFrame | true | true |  |  |

##### 11. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.25f | 0.25f |  |  |
| finishEvent | Event(WAIT) | Event(WAIT) |  |  |
| realTime | false | false |  |  |

### Cyclone End

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. iTweenMoveBy

Full Name: HutongGames.PlayMaker.Actions.iTweenMoveBy
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Audio Player | OwnerDefault Audio Player |  |  |
| id | "" | "" |  |  |
| vector | Vector3(0, 0, 60) | Vector3(0, 0, 60) |  |  |
| time | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| speed | 0f | 0f |  |  |
| easeType | iTween/EaseType::linear | 21 |  |  |
| loopType | iTween/LoopType::none | 0 |  |  |
| space | UnityEngine.Space::World | 0 |  |  |
| orientToPath | false | false |  | LookAt |
| lookAtObject |  |  |  |  |
| lookAtVector | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| lookTime | 0f | 0f |  |  |
| axis | HutongGames.PlayMaker.Actions.iTweenFsmAction/AxisRestriction::none | 0 |  |  |
| startEvent | Event() | Event() |  |  |
| finishEvent | Event() | Event() |  |  |
| realTime | false | false |  |  |
| stopOnExit | false | false |  |  |
| loopDontFinish | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Cyclone Slash | EventTarget(GameObject):Cyclone Slash |  |  |
| sendEvent | "CYCLONE END" | "CYCLONE END" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| clipName | "NA Cyclone End" | "NA Cyclone End" |  |  |
| animationTriggerEvent | Event() | Event() |  |  |
| animationCompleteEvent | Event(FINISHED) | Event(FINISHED) |  |  |

### Cyc Send Msg

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | EndCyclone(???) | EndCyclone(???) |  |  |

### Activate Slash

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Cyclone Slash | OwnerDefault Cyclone Slash |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObjectFSM)[SendToFSM: CameraShake]:CameraParent | EventTarget(GameObjectFSM)[SendToFSM: CameraShake]:CameraParent |  |  |
| sendEvent | "EnemyKillShake" | "EnemyKillShake" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Hover Start

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
| x | 0f | 0f | Variable |  |
| y | float Y Velocity | float Y Velocity | Variable |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |

##### 2. FloatClamp

Full Name: HutongGames.PlayMaker.Actions.FloatClamp
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Y Velocity | float Y Velocity | Variable |  |
| minValue | -4f | -4f |  |  |
| maxValue | 9999f | 9999f |  |  |
| everyFrame | false | false |  |  |

##### 3. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector2(0, 0) | Vector2(0, 0) |  |  |
| x | 0f | 0f |  |  |
| y | float Y Velocity | float Y Velocity |  |  |
| everyFrame | false | false |  |  |

### Flash

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault SD Sharp Flash | OwnerDefault SD Sharp Flash |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

### Wallslide?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| behaviour | "HeroController" | "HeroController" | Behaviour |  |
| methodName | "GetState" | "GetState" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var Wall Sliding = False | Var Wall Sliding = False | Variable | Store Result |

##### 2. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Wall Sliding | bool Wall Sliding | Variable |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(FINISHED) | Event(FINISHED) |  |  |
| everyFrame | false | false |  |  |

##### 3. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | FlipSprite(???) | FlipSprite(???) |  |  |

### Has Cyclone?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. GetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName | "hasCyclone" | "hasCyclone" |  |  |
| storeValue | bool Has Cyclone | bool Has Cyclone | Variable |  |

##### 2. GetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName | "hasDashSlash" | "hasDashSlash" |  |  |
| storeValue | bool Has G Slash | bool Has G Slash | Variable |  |

##### 3. BoolNoneTrue

Full Name: HutongGames.PlayMaker.Actions.BoolNoneTrue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariables | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 | Variable |  |
| sendEvent | Event(CANCEL) | Event(CANCEL) |  |  |
| storeResult | false | false | Variable |  |
| everyFrame | false | false |  |  |

##### 4. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Has Cyclone | bool Has Cyclone | Variable |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(GREAT SLASH) | Event(GREAT SLASH) |  |  |
| everyFrame | false | false |  |  |

### Has G Slash?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. GetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName | "hasCyclone" | "hasCyclone" |  |  |
| storeValue | bool Has Cyclone | bool Has Cyclone | Variable |  |

##### 2. GetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName | "hasDashSlash" | "hasDashSlash" |  |  |
| storeValue | bool Has G Slash | bool Has G Slash | Variable |  |

##### 3. BoolNoneTrue

Full Name: HutongGames.PlayMaker.Actions.BoolNoneTrue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariables | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 | Variable |  |
| sendEvent | Event(CANCEL) | Event(CANCEL) |  |  |
| storeResult | false | false | Variable |  |
| everyFrame | false | false |  |  |

##### 4. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Has G Slash | bool Has G Slash | Variable |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(CYCLONE) | Event(CYCLONE) |  |  |
| everyFrame | false | false |  |  |

### G Slash

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. AudioPlay

Full Name: HutongGames.PlayMaker.Actions.AudioPlay
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| volume | 1f | 1f |  |  |
| oneShotClip | [hero_nail_art_great_slash (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [hero_nail_art_great_slash (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| finishedEvent | Event() | Event() |  |  |

##### 2. PlayVibration

Full Name: PlayVibration
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| lowFidelityVibration | Enum(LowFidelityVibrations, 0) | Enum(LowFidelityVibrations, 0) |  |  |
| highFidelityVibration | [hero_nail_art_great_slash (TextAsset) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [hero_nail_art_great_slash (TextAsset) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| motors | Enum(VibrationMotors, 3) | Enum(VibrationMotors, 3) |  |  |
| loopTime | 0f | 0f |  |  |
| isLooping | false | false |  |  |
| tag | "heroAction" | "heroAction" |  |  |
| gamepadVibration | [GreatSlash (Script GamepadVibration) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [GreatSlash (Script GamepadVibration) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Great Slash Effect | OwnerDefault Great Slash Effect |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 4. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObjectFSM)[SendToFSM: CameraShake]:CameraParent | EventTarget(GameObjectFSM)[SendToFSM: CameraShake]:CameraParent |  |  |
| sendEvent | "EnemyKillShake" | "EnemyKillShake" |  |  |
| delay | 0.15f | 0.15f |  |  |
| everyFrame | false | false |  |  |

##### 5. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| clipName | "NA Big Slash" | "NA Big Slash" |  |  |
| animationTriggerEvent | Event() | Event() |  |  |
| animationCompleteEvent | Event(FINISHED) | Event(FINISHED) |  |  |

##### 6. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector2(0, 0) | Vector2(0, 0) |  |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| everyFrame | true | true |  |  |

##### 7. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.075f | 0.075f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Flash 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault SD Sharp Flash | OwnerDefault SD Sharp Flash |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

### G Slash End

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | ResetHardLandingTimer(???) | ResetHardLandingTimer(???) |  |  |

##### 2. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Great Slash Effect | OwnerDefault Great Slash Effect |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

### Facing?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| behaviour | "HeroController" | "HeroController" | Behaviour |  |
| methodName | "GetState" | "GetState" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var Facing Right = False | Var Facing Right = False | Variable | Store Result |

##### 2. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Facing Right | bool Facing Right | Variable |  |
| isTrue | Event(RIGHT) | Event(RIGHT) |  |  |
| isFalse | Event(LEFT) | Event(LEFT) |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEventByScale

Full Name: HutongGames.PlayMaker.Actions.SendEventByScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| xScale | true | true |  |  |
| positiveEvent | Event(LEFT) | Event(LEFT) |  |  |
| negativeEvent | Event(RIGHT) | Event(RIGHT) |  |  |
| space | UnityEngine.Space::World | 0 |  |  |

### Left

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Great Slash Effect | OwnerDefault Great Slash Effect |  |  |
| fsmName | "damages_enemy" | "damages_enemy" | FsmName |  |
| variableName | "direction" | "direction" | FsmFloat |  |
| setValue | 180f | 180f |  |  |
| everyFrame | false | false |  |  |

##### 2. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float X Velocity | float X Velocity | Variable |  |
| floatValue | -25f | -25f |  |  |
| everyFrame | false | false |  |  |

### Right

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Great Slash Effect | OwnerDefault Great Slash Effect |  |  |
| fsmName | "damages_enemy" | "damages_enemy" | FsmName |  |
| variableName | "direction" | "direction" | FsmFloat |  |
| setValue | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float X Velocity | float X Velocity | Variable |  |
| floatValue | 25f | 25f |  |  |
| everyFrame | false | false |  |  |

### Stop Move

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector2(0, 0) | Vector2(0, 0) |  |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| everyFrame | true | true |  |  |

##### 2. Tk2dWatchAnimationEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dWatchAnimationEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animationTriggerEvent | Event() | Event() |  |  |
| animationCompleteEvent | Event(FINISHED) | Event(FINISHED) |  |  |

### Has Dash?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "hasUpwardSlash" | "hasUpwardSlash" |  |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(CANCEL) | Event(CANCEL) |  |  |

### Dash Slash Ready

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

_None_

### DSlash Start

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | RelinquishControlNotVelocity(???) | RelinquishControlNotVelocity(???) |  |  |

##### 2. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | StopAnimationControl(???) | StopAnimationControl(???) |  |  |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault SD Sharp Flash | OwnerDefault SD Sharp Flash |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

### Facing? 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| behaviour | "HeroController" | "HeroController" | Behaviour |  |
| methodName | "GetState" | "GetState" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var Facing Right = False | Var Facing Right = False | Variable | Store Result |

##### 2. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Facing Right | bool Facing Right | Variable |  |
| isTrue | Event(RIGHT) | Event(RIGHT) |  |  |
| isFalse | Event(LEFT) | Event(LEFT) |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEventByScale

Full Name: HutongGames.PlayMaker.Actions.SendEventByScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| xScale | true | true |  |  |
| positiveEvent | Event(LEFT) | Event(LEFT) |  |  |
| negativeEvent | Event(RIGHT) | Event(RIGHT) |  |  |
| space | UnityEngine.Space::World | 0 |  |  |

### Left 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Dash Slash | OwnerDefault Dash Slash |  |  |
| fsmName | "damages_enemy" | "damages_enemy" | FsmName |  |
| variableName | "direction" | "direction" | FsmFloat |  |
| setValue | 180f | 180f |  |  |
| everyFrame | false | false |  |  |

##### 2. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float X Velocity | float X Velocity | Variable |  |
| floatValue | -20f | -20f |  |  |
| everyFrame | false | false |  |  |

### Right 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Dash Slash | OwnerDefault Dash Slash |  |  |
| fsmName | "damages_enemy" | "damages_enemy" | FsmName |  |
| variableName | "direction" | "direction" | FsmFloat |  |
| setValue | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float X Velocity | float X Velocity | Variable |  |
| floatValue | 20f | 20f |  |  |
| everyFrame | false | false |  |  |

### Dash Slash

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Dash Slash | OwnerDefault Dash Slash |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 2. AudioPlay

Full Name: HutongGames.PlayMaker.Actions.AudioPlay
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| volume | 1f | 1f |  |  |
| oneShotClip | [hero_nail_art_great_slash (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [hero_nail_art_great_slash (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| finishedEvent | Event() | Event() |  |  |

##### 3. PlayVibration

Full Name: PlayVibration
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| lowFidelityVibration | Enum(LowFidelityVibrations, 0) | Enum(LowFidelityVibrations, 0) |  |  |
| highFidelityVibration | [hero_nail_art_great_slash (TextAsset) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [hero_nail_art_great_slash (TextAsset) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| motors | Enum(VibrationMotors, 3) | Enum(VibrationMotors, 3) |  |  |
| loopTime | 0f | 0f |  |  |
| isLooping | false | false |  |  |
| tag | "heroAction" | "heroAction" |  |  |
| gamepadVibration | [DashSlash (Script GamepadVibration) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [DashSlash (Script GamepadVibration) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |

##### 4. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObjectFSM)[SendToFSM: CameraShake]:CameraParent | EventTarget(GameObjectFSM)[SendToFSM: CameraShake]:CameraParent |  |  |
| sendEvent | "EnemyKillShake" | "EnemyKillShake" |  |  |
| delay | 0.15f | 0.15f |  |  |
| everyFrame | false | false |  |  |

##### 5. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| clipName | "NA Dash Slash" | "NA Dash Slash" |  |  |
| animationTriggerEvent | Event() | Event() |  |  |
| animationCompleteEvent | Event(FINISHED) | Event(FINISHED) |  |  |

##### 6. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector2(0, 0) | Vector2(0, 0) |  |  |
| x | float X Velocity | float X Velocity |  |  |
| y | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 7. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.1f | 0.1f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

##### 8. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector2(0, 0) | Vector2(0, 0) |  |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| everyFrame | true | true |  |  |

##### 9. DecelerateXY

Full Name: HutongGames.PlayMaker.Actions.DecelerateXY
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| decelerationX | 0.75f | 0.75f |  |  |
| decelerationY | 0f | 0f |  |  |

### D Slash End

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | ResetHardLandingTimer(???) | ResetHardLandingTimer(???) |  |  |

##### 2. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector2(0, 0) | Vector2(0, 0) |  |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### DSlash Move End

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector2(0, 0) | Vector2(0, 0) |  |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| everyFrame | true | true |  |  |

##### 2. Tk2dWatchAnimationEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dWatchAnimationEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animationTriggerEvent | Event() | Event() |  |  |
| animationCompleteEvent | Event(FINISHED) | Event(FINISHED) |  |  |

### Play Audio

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [hero_nail_art_cyclone_slash_long (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [hero_nail_art_cyclone_slash_long (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer | GameObject Audio Player | GameObject Audio Player |  |  |

##### 2. SetParent

Full Name: HutongGames.PlayMaker.Actions.SetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Audio Player | OwnerDefault Audio Player |  |  |
| parent | GameObject Self | GameObject Self |  |  |
| resetLocalPosition | false | false |  |  |
| resetLocalRotation | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Inactive | BUTTON UP | Can Nail Art? | 0 | 0 | 0 |
| Regain Control | FINISHED | Inactive | 0 | 0 | 0 |
| Init | FINISHED | Inactive | 0 | 0 | 0 |
| Cancel All | FINISHED | Inactive | 0 | 0 | 0 |
| Can Nail Art? | CANCEL | Inactive | 0 | 0 | 0 |
| Can Nail Art? | FINISHED | Wallslide? | 0 | 0 | 0 |
| Can Nail Art? | DASH CHECK | Has Dash? | 0 | 0 | 0 |
| Take Control | FINISHED | Move Choice | 0 | 0 | 0 |
| Move Choice | CYCLONE | Has Cyclone? | 0 | 0 | 0 |
| Move Choice | GREAT SLASH | Has G Slash? | 0 | 0 | 0 |
| Cyclone Start | FINISHED | Activate Slash | 0 | 0 | 0 |
| Cyclone Start | BUTTON DOWN | Hover Start | 0 | 0 | 0 |
| Cyclone Spin | END | Cyclone End | 0 | 0 | 0 |
| Cyclone Spin | BUTTON DOWN | Cyclone Extend | 0 | 0 | 0 |
| Cyclone Extend | END | Cyclone End | 0 | 0 | 0 |
| Cyclone Extend | WAIT | Cyclone Spin | 0 | 0 | 0 |
| Cyclone End | FINISHED | Cyc Send Msg | 0 | 0 | 0 |
| Cyc Send Msg | FINISHED | Regain Control | 0 | 0 | 0 |
| Activate Slash | FINISHED | Play Audio | 0 | 0 | 0 |
| Hover Start | FINISHED | Cyclone Start | 0 | 0 | 0 |
| Flash | FINISHED | Cyclone Start | 0 | 0 | 0 |
| Wallslide? | FINISHED | Take Control | 0 | 0 | 0 |
| Has Cyclone? | FINISHED | Flash | 0 | 0 | 0 |
| Has Cyclone? | GREAT SLASH | Has G Slash? | 0 | 0 | 0 |
| Has Cyclone? | CANCEL | Regain Control | 0 | 0 | 0 |
| Has G Slash? | FINISHED | Flash 2 | 0 | 0 | 0 |
| Has G Slash? | CYCLONE | Has Cyclone? | 0 | 0 | 0 |
| Has G Slash? | CANCEL | Regain Control | 0 | 0 | 0 |
| G Slash | FINISHED | Stop Move | 0 | 0 | 0 |
| Flash 2 | FINISHED | Facing? | 0 | 0 | 0 |
| G Slash End | FINISHED | Regain Control | 0 | 0 | 0 |
| Facing? | LEFT | Left | 0 | 0 | 0 |
| Facing? | RIGHT | Right | 0 | 0 | 0 |
| Left | FINISHED | G Slash | 0 | 0 | 0 |
| Right | FINISHED | G Slash | 0 | 0 | 0 |
| Stop Move | FINISHED | G Slash End | 0 | 0 | 0 |
| Has Dash? | CANCEL | Inactive | 0 | 0 | 0 |
| Has Dash? | FINISHED | Dash Slash Ready | 0 | 0 | 0 |
| Dash Slash Ready | DASH END | DSlash Start | 0 | 0 | 0 |
| DSlash Start | FINISHED | Facing? 2 | 0 | 0 | 0 |
| Facing? 2 | LEFT | Left 2 | 0 | 0 | 0 |
| Facing? 2 | RIGHT | Right 2 | 0 | 0 | 0 |
| Left 2 | FINISHED | Dash Slash | 0 | 0 | 0 |
| Right 2 | FINISHED | Dash Slash | 0 | 0 | 0 |
| Dash Slash | FINISHED | D Slash End | 0 | 0 | 0 |
| D Slash End | FINISHED | Regain Control | 0 | 0 | 0 |
| DSlash Move End | FINISHED | D Slash End | 0 | 0 | 0 |
| Play Audio | FINISHED | Cyclone Spin | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| HERO DAMAGED | Cancel All | 0 | 0 | 0 |
| LEAVING SCENE | Cancel All | 0 | 0 | 0 |
| FSM CANCEL | Cancel All | 0 | 0 | 0 |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| ANIM END | false |
| BUTTON DOWN | false |
| BUTTON UP | false |
| CANCEL | false |
| CYCLONE | false |
| DASH CHECK | false |
| DASH END | false |
| DOUBLE | false |
| DOUBLE PRESS | false |
| END | false |
| FSM CANCEL | false |
| GREAT SLASH | false |
| HERO DAMAGED | true |
| INVENTORY OPENED | false |
| LEAVING SCENE | false |
| LEFT | false |
| LEFT GROUND | false |
| MAP START | false |
| RIGHT | false |
| STOP WALK | false |
| THIRD | false |
| WAIT | true |
| WALK LEFT | false |
| WALK RIGHT | false |

