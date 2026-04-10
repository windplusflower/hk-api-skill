# Surface Water

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Surface Water |
| GameObject Name | Knight |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Init |
| FSM PathId | 23022 |
| GameObject PathId | 3895 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Swim Speed | 5 | Single: 5 |
| Swim Speed neg | 0 | Single: 0 |

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| Idle Anim |  | String:  |
| Swim Anim | Surface Swim | String: Surface Swim |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| RC 1 | [null] | NamedAssetPPtr:  |
| RC 2 | [null] | NamedAssetPPtr:  |
| Self | [null] | NamedAssetPPtr:  |
| Sounds | [null] | NamedAssetPPtr:  |
| Swim Audio | [null] | NamedAssetPPtr:  |

## States

### Inactive

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

_None_

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

##### 2. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Swim Speed neg | float Swim Speed neg | Variable |  |
| floatValue | float Swim Speed | float Swim Speed |  |  |
| everyFrame | false | false |  |  |

##### 3. FloatMultiply

Full Name: HutongGames.PlayMaker.Actions.FloatMultiply
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Swim Speed neg | float Swim Speed neg | Variable |  |
| multiplyBy | -1f | -1f |  |  |
| everyFrame | false | false |  |  |

##### 4. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Sounds" | "Sounds" |  |  |
| storeResult | GameObject Sounds | GameObject Sounds | Variable |  |

##### 5. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Sounds | OwnerDefault Sounds |  |  |
| childName | "Swim" | "Swim" |  |  |
| storeResult | GameObject Swim Audio | GameObject Swim Audio | Variable |  |

##### 6. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "RC 1" | "RC 1" |  |  |
| storeResult | GameObject RC 1 | GameObject RC 1 | Variable |  |

##### 7. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "RC 2" | "RC 2" |  |  |
| storeResult | GameObject RC 2 | GameObject RC 2 | Variable |  |

### Cancel All

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. AudioStop

Full Name: HutongGames.PlayMaker.Actions.AudioStop
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Swim Audio | OwnerDefault Swim Audio |  |  |

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
| functionCall | ResetAirMoves(???) | ResetAirMoves(???) |  |  |

##### 2. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | RelinquishControl(???) | RelinquishControl(???) |  |  |

##### 3. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | StopAnimationControl(???) | StopAnimationControl(???) |  |  |

##### 4. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | AffectedByGravity(false) | AffectedByGravity(false) |  |  |

##### 5. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::RequireReceiver | 0 |  |  |
| functionCall | IsSwimming(???) | IsSwimming(???) |  |  |

### Enter

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "FSM CANCEL" | "FSM CANCEL" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| clipName | "Surface In" | "Surface In" |  |  |
| animationTriggerEvent | Event() | Event() |  |  |
| animationCompleteEvent | Event(FINISHED) | Event(FINISHED) |  |  |

##### 3. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector2(0, 0) | Vector2(0, 0) |  |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| everyFrame | true | true |  |  |

##### 4. AudioPlay

Full Name: HutongGames.PlayMaker.Actions.AudioPlay
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Swim Audio | OwnerDefault Swim Audio |  |  |
| volume | 0f | 0f |  |  |
| oneShotClip | [] | [] |  |  |
| finishedEvent | Event() | Event() |  |  |

##### 5. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Idle Anim | string Idle Anim | Variable |  |
| stringValue | "Surface InToIdle" | "Surface InToIdle" | TextArea |  |
| everyFrame | false | false |  |  |

##### 6. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Swim Anim = "Surface Swim" | string Swim Anim = "Surface Swim" | Variable |  |
| stringValue | "Surface InToSwim" | "Surface InToSwim" | TextArea |  |
| everyFrame | false | false |  |  |

##### 7. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| clipName | string Idle Anim | string Idle Anim |  |  |
| animationTriggerEvent | Event() | Event() |  |  |
| animationCompleteEvent | Event() | Event() |  |  |

##### 2. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector2(0, 0) | Vector2(0, 0) |  |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| everyFrame | true | true |  |  |

##### 3. ListenForJump

Full Name: HutongGames.PlayMaker.Actions.ListenForJump
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| wasPressed | Event(JUMP) | Event(JUMP) |  |  |
| wasReleased | Event() | Event() |  |  |
| isPressed | Event() | Event() |  |  |
| isNotPressed | Event() | Event() |  |  |

##### 4. ListenForRight

Full Name: HutongGames.PlayMaker.Actions.ListenForRight
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| wasPressed | Event() | Event() |  |  |
| wasReleased | Event() | Event() |  |  |
| isPressed | Event(RIGHT) | Event(RIGHT) |  |  |
| isNotPressed | Event() | Event() |  |  |

##### 5. ListenForLeft

Full Name: HutongGames.PlayMaker.Actions.ListenForLeft
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| wasPressed | Event() | Event() |  |  |
| wasReleased | Event() | Event() |  |  |
| isPressed | Event(LEFT) | Event(LEFT) |  |  |
| isNotPressed | Event() | Event() |  |  |

##### 6. FadeAudio

Full Name: HutongGames.PlayMaker.Actions.FadeAudio
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Swim Audio | OwnerDefault Swim Audio |  |  |
| startVolume | 0.7f | 0.7f |  |  |
| endVolume | 0.25f | 0.25f |  |  |
| time | 0.5f | 0.5f |  |  |

##### 7. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Swim Anim = "Surface Swim" | string Swim Anim = "Surface Swim" | Variable |  |
| stringValue | "Surface Swim" | "Surface Swim" | TextArea |  |
| everyFrame | false | false |  |  |

### Swim Left

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
| functionCall | FaceLeft(???) | FaceLeft(???) |  |  |

##### 2. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Idle Anim | string Idle Anim | Variable |  |
| stringValue | "Surface Idle" | "Surface Idle" | TextArea |  |
| everyFrame | false | false |  |  |

##### 3. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| clipName | string Swim Anim = "Surface Swim" | string Swim Anim = "Surface Swim" |  |  |
| animationTriggerEvent | Event() | Event() |  |  |
| animationCompleteEvent | Event() | Event() |  |  |

##### 4. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector2(0, 0) | Vector2(0, 0) |  |  |
| x | float Swim Speed neg | float Swim Speed neg |  |  |
| y | 0f | 0f |  |  |
| everyFrame | true | true |  |  |

##### 5. ListenForLeft

Full Name: HutongGames.PlayMaker.Actions.ListenForLeft
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| wasPressed | Event() | Event() |  |  |
| wasReleased | Event() | Event() |  |  |
| isPressed | Event() | Event() |  |  |
| isNotPressed | Event(CANCEL) | Event(CANCEL) |  |  |

##### 6. ListenForJump

Full Name: HutongGames.PlayMaker.Actions.ListenForJump
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| wasPressed | Event(JUMP) | Event(JUMP) |  |  |
| wasReleased | Event() | Event() |  |  |
| isPressed | Event() | Event() |  |  |
| isNotPressed | Event() | Event() |  |  |

##### 7. AudioPlayInState

Full Name: HutongGames.PlayMaker.Actions.AudioPlayInState
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Swim Audio | OwnerDefault Swim Audio |  |  |
| volume | 1f | 1f |  |  |

##### 8. FadeAudio

Full Name: HutongGames.PlayMaker.Actions.FadeAudio
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Swim Audio | OwnerDefault Swim Audio |  |  |
| startVolume | 0.25f | 0.25f |  |  |
| endVolume | 1f | 1f |  |  |
| time | 0.5f | 0.5f |  |  |

##### 9. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Swim Anim = "Surface Swim" | string Swim Anim = "Surface Swim" | Variable |  |
| stringValue | "Surface Swim" | "Surface Swim" | TextArea |  |
| everyFrame | false | false |  |  |

### Swim Right

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
| functionCall | FaceRight(???) | FaceRight(???) |  |  |

##### 2. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Idle Anim | string Idle Anim | Variable |  |
| stringValue | "Surface Idle" | "Surface Idle" | TextArea |  |
| everyFrame | false | false |  |  |

##### 3. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| clipName | string Swim Anim = "Surface Swim" | string Swim Anim = "Surface Swim" |  |  |
| animationTriggerEvent | Event() | Event() |  |  |
| animationCompleteEvent | Event() | Event() |  |  |

##### 4. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector2(0, 0) | Vector2(0, 0) |  |  |
| x | float Swim Speed | float Swim Speed |  |  |
| y | 0f | 0f |  |  |
| everyFrame | true | true |  |  |

##### 5. ListenForRight

Full Name: HutongGames.PlayMaker.Actions.ListenForRight
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| wasPressed | Event() | Event() |  |  |
| wasReleased | Event() | Event() |  |  |
| isPressed | Event() | Event() |  |  |
| isNotPressed | Event(CANCEL) | Event(CANCEL) |  |  |

##### 6. ListenForJump

Full Name: HutongGames.PlayMaker.Actions.ListenForJump
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| wasPressed | Event(JUMP) | Event(JUMP) |  |  |
| wasReleased | Event() | Event() |  |  |
| isPressed | Event() | Event() |  |  |
| isNotPressed | Event() | Event() |  |  |

##### 7. AudioPlayInState

Full Name: HutongGames.PlayMaker.Actions.AudioPlayInState
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Swim Audio | OwnerDefault Swim Audio |  |  |
| volume | 1f | 1f |  |  |

##### 8. FadeAudio

Full Name: HutongGames.PlayMaker.Actions.FadeAudio
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Swim Audio | OwnerDefault Swim Audio |  |  |
| startVolume | 0.25f | 0.25f |  |  |
| endVolume | 1f | 1f |  |  |
| time | 0.5f | 0.5f |  |  |

##### 9. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Swim Anim = "Surface Swim" | string Swim Anim = "Surface Swim" | Variable |  |
| stringValue | "Surface Swim" | "Surface Swim" | TextArea |  |
| everyFrame | false | false |  |  |

### Jump Out

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
| clipName | "Airborne" | "Airborne" |  |  |

##### 2. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector2(0, 0) | Vector2(0, 0) |  |  |
| x | 0f | 0f |  |  |
| y | 10f | 10f |  |  |
| everyFrame | false | false |  |  |

##### 3. AudioStop

Full Name: HutongGames.PlayMaker.Actions.AudioStop
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Swim Audio | OwnerDefault Swim Audio |  |  |

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
| functionCall | SetStartWithJump(???) | SetStartWithJump(???) |  |  |

##### 2. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | RegainControl(???) | RegainControl(???) |  |  |

##### 3. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | StartAnimationControl(???) | StartAnimationControl(???) |  |  |

##### 4. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(BroadcastAll):FSM Owner | EventTarget(BroadcastAll):FSM Owner |  |  |
| sendEvent | "HERO SURFACE EXIT" | "HERO SURFACE EXIT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 5. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::RequireReceiver | 0 |  |  |
| functionCall | NotSwimming(???) | NotSwimming(???) |  |  |

### Translate?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. RayCast2dV2

Full Name: HutongGames.PlayMaker.Actions.RayCast2dV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| fromGameObject | OwnerDefault RC 1 | OwnerDefault RC 1 |  | Setup |
| fromPosition | Vector2(0, 0) | Vector2(0, 0) |  |  |
| direction | Vector2(0, 1) | Vector2(0, 1) |  |  |
| space | UnityEngine.Space::World | 0 |  |  |
| distance | 1.1f | 1.1f |  |  |
| minDepth | 0 | 0 |  |  |
| maxDepth | 0 | 0 |  |  |
| hitEvent | Event(FINISHED) | Event(FINISHED) | Variable | Result |
| storeDidHit | false | false | Variable |  |
| storeHitObject |  |  | Variable |  |
| storeHitPoint | Vector2(0, 0) | Vector2(0, 0) | Variable |  |
| storeHitNormal | Vector2(0, 0) | Vector2(0, 0) | Variable |  |
| storeHitDistance | 0f | 0f | Variable |  |
| storeDistance | 0f | 0f | Variable |  |
| repeatInterval | 1 | 1 |  | Filter |
| layerMask | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 | Layer |  |
| invertMask | false | false |  |  |
| debugColor | Color(1, 0.92156863, 0.015686275, 1) | Color(1, 0.92156863, 0.015686275, 1) |  | Debug |
| debug | false | false |  |  |

##### 2. RayCast2dV2

Full Name: HutongGames.PlayMaker.Actions.RayCast2dV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| fromGameObject | OwnerDefault RC 2 | OwnerDefault RC 2 |  | Setup |
| fromPosition | Vector2(0, 0) | Vector2(0, 0) |  |  |
| direction | Vector2(0, 1) | Vector2(0, 1) |  |  |
| space | UnityEngine.Space::World | 0 |  |  |
| distance | 1.1f | 1.1f |  |  |
| minDepth | 0 | 0 |  |  |
| maxDepth | 0 | 0 |  |  |
| hitEvent | Event(FINISHED) | Event(FINISHED) | Variable | Result |
| storeDidHit | false | false | Variable |  |
| storeHitObject |  |  | Variable |  |
| storeHitPoint | Vector2(0, 0) | Vector2(0, 0) | Variable |  |
| storeHitNormal | Vector2(0, 0) | Vector2(0, 0) | Variable |  |
| storeHitDistance | 0f | 0f | Variable |  |
| storeDistance | 0f | 0f | Variable |  |
| repeatInterval | 1 | 1 |  | Filter |
| layerMask | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 | Layer |  |
| invertMask | false | false |  |  |
| debugColor | Color(1, 0.92156863, 0.015686275, 1) | Color(1, 0.92156863, 0.015686275, 1) |  | Debug |
| debug | false | false |  |  |

##### 3. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | 1f | 1f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::World | 0 |  |  |
| perSecond | false | false |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |
| fixedUpdate | false | false |  |  |

##### 4. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Start Swimming?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. ListenForRight

Full Name: HutongGames.PlayMaker.Actions.ListenForRight
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| wasPressed | Event() | Event() |  |  |
| wasReleased | Event() | Event() |  |  |
| isPressed | Event(RIGHT) | Event(RIGHT) |  |  |
| isNotPressed | Event() | Event() |  |  |

##### 2. ListenForLeft

Full Name: HutongGames.PlayMaker.Actions.ListenForLeft
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| wasPressed | Event() | Event() |  |  |
| wasReleased | Event() | Event() |  |  |
| isPressed | Event(LEFT) | Event(LEFT) |  |  |
| isNotPressed | Event(FINISHED) | Event(FINISHED) |  |  |

### Frame

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. NextFrameEvent

Full Name: HutongGames.PlayMaker.Actions.NextFrameEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent | Event(FINISHED) | Event(FINISHED) |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Inactive | SURFACE ENTER | Take Control | 0 | 0 | 0 |
| Init | FINISHED | Inactive | 0 | 0 | 0 |
| Cancel All | FINISHED | Inactive | 0 | 0 | 0 |
| Take Control | FINISHED | Enter | 0 | 0 | 0 |
| Enter | FINISHED | Start Swimming? | 0 | 0 | 0 |
| Idle | LEFT | Swim Left | 0 | 0 | 0 |
| Idle | RIGHT | Swim Right | 0 | 0 | 0 |
| Idle | JUMP | Jump Out | 0 | 0 | 0 |
| Swim Left | CANCEL | Idle | 0 | 0 | 0 |
| Swim Left | JUMP | Jump Out | 0 | 0 | 0 |
| Swim Right | CANCEL | Idle | 0 | 0 | 0 |
| Swim Right | JUMP | Jump Out | 0 | 0 | 0 |
| Jump Out | FINISHED | Translate? | 0 | 0 | 0 |
| Regain Control | FINISHED | Inactive | 0 | 0 | 0 |
| Translate? | FINISHED | Frame | 0 | 0 | 0 |
| Start Swimming? | LEFT | Swim Left | 0 | 0 | 0 |
| Start Swimming? | RIGHT | Swim Right | 0 | 0 | 0 |
| Start Swimming? | FINISHED | Idle | 0 | 0 | 0 |
| Frame | FINISHED | Regain Control | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| HERO DAMAGED | Cancel All | 0 | 0 | 0 |
| LEAVING SCENE | Cancel All | 0 | 0 | 0 |
|  | Cancel All | 0 | 0 | 0 |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| BUTTON UP | false |
| CANCEL | false |
| END | false |
| HERO DAMAGED | true |
| JUMP | false |
| LEAVING SCENE | false |
| LEFT | false |
| LEFT GROUND | false |
| MAP START | false |
| RIGHT | false |
| STOP WALK | false |
| SURFACE ENTER | false |
| SURFACE EXIT | false |
| THIRD | false |
| TRANSLATE | false |
| WAIT | true |
| WALK LEFT | false |
| WALK RIGHT | false |

