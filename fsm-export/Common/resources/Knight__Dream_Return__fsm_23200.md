# Dream Return

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Dream Return |
| GameObject Name | Knight |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Init |
| FSM PathId | 23200 |
| GameObject PathId | 3895 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Gate X | 0 | Single: 0 |
| Gate X | 0 | Single: 0 |
| Gate Y | 0 | Single: 0 |
| Gate Y | 0 | Single: 0 |
| X Velocity | 0 | Single: 0 |
| Y Velocity | 0 | Single: 0 |

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Decrement | -1 | Int32: -1 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Dream Return Long | false | Boolean: false |
| Dream Returning | false | Boolean: false |
| Gate Returning | false | Boolean: false |
| Grimm Return | false | Boolean: false |
| Skip Remove Orbs | false | Boolean: false |

### Vector3s

| Name | Value | Raw/Type |
| --- | --- | --- |
| Respawn Pos | Vector3(0, 0, 0) | Vector3: Vector3(0, 0, 0) |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| DG Set Impact | [null] | NamedAssetPPtr:  |
| Dream Effects | [null] | NamedAssetPPtr:  |
| Hero | [null] | NamedAssetPPtr:  |
| HeroBox | [null] | NamedAssetPPtr:  |
| Self | [null] | NamedAssetPPtr:  |
| Warp In Pt | [null] | NamedAssetPPtr:  |

## States

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "HeroBox" | "HeroBox" |  |  |
| storeResult | GameObject HeroBox | GameObject HeroBox | Variable |  |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Dream Effects" | "Dream Effects" |  |  |
| storeResult | GameObject Dream Effects | GameObject Dream Effects | Variable |  |

##### 3. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Dream Effects | OwnerDefault Dream Effects |  |  |
| childName | "DG Set Impact" | "DG Set Impact" |  |  |
| storeResult | GameObject DG Set Impact | GameObject DG Set Impact | Variable |  |

##### 4. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Dream Effects | OwnerDefault Dream Effects |  |  |
| childName | "Warp In Pt" | "Warp In Pt" |  |  |
| storeResult | GameObject Warp In Pt | GameObject Warp In Pt | Variable |  |

##### 5. GetOwner

Full Name: HutongGames.PlayMaker.Actions.GetOwner
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeGameObject | GameObject Self | GameObject Self | Variable |  |

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

_None_

### Check

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Dream Returning | bool Dream Returning | Variable |  |
| isTrue | Event(DREAM RETURN) | Event(DREAM RETURN) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 2. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Gate Returning | bool Gate Returning | Variable |  |
| isTrue | Event(GATE RETURN) | Event(GATE RETURN) |  |  |
| isFalse | Event(FINISHED) | Event(FINISHED) |  |  |
| everyFrame | false | false |  |  |

### Prostrate

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Dream Returning | bool Dream Returning | Variable |  |
| boolValue | false | false |  |  |
| everyFrame | false | false |  |  |

##### 2. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Gate Returning | bool Gate Returning | Variable |  |
| boolValue | false | false |  |  |
| everyFrame | false | false |  |  |

##### 3. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Dream Return Long | bool Dream Return Long | Variable |  |
| boolValue | false | false |  |  |
| everyFrame | false | false |  |  |

##### 4. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | EnableRenderer(???) | EnableRenderer(???) |  |  |

##### 5. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | RelinquishControl(???) | RelinquishControl(???) |  |  |

##### 6. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | StopAnimationControl(???) | StopAnimationControl(???) |  |  |

##### 7. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Prostrate" | "Prostrate" |  |  |

##### 8. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):HUD Blanker | EventTarget(GameObject):HUD Blanker |  |  |
| sendEvent | "FADE OUT" | "FADE OUT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 9. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):HUD Blanker White | EventTarget(GameObject):HUD Blanker White |  |  |
| sendEvent | "FADE OUT" | "FADE OUT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 10. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| behaviour | "HeroController" | "HeroController" | Behaviour |  |
| methodName | "MaxHealth" | "MaxHealth" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var unnamed = 0 | Var unnamed = 0 | Variable | Store Result |

##### 11. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(BroadcastAll):FSM Owner | EventTarget(BroadcastAll):FSM Owner |  |  |
| sendEvent | "UPDATE BLUE HEALTH" | "UPDATE BLUE HEALTH" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 12. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.5f | 0.5f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Pause

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

### Ready

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. ListenForDown

Full Name: HutongGames.PlayMaker.Actions.ListenForDown
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| wasPressed | Event(GET UP) | Event(GET UP) |  |  |
| wasReleased | Event() | Event() |  |  |
| isPressed | Event() | Event() |  |  |
| isNotPressed | Event() | Event() |  |  |
| isPressedBool | false | false | Variable |  |
| stateEntryOnly | false | false |  |  |

##### 2. ListenForUp

Full Name: HutongGames.PlayMaker.Actions.ListenForUp
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| wasPressed | Event(GET UP) | Event(GET UP) |  |  |
| wasReleased | Event() | Event() |  |  |
| isPressed | Event() | Event() |  |  |
| isNotPressed | Event() | Event() |  |  |
| isPressedBool | false | false | Variable |  |
| stateEntryOnly | false | false |  |  |

##### 3. ListenForRight

Full Name: HutongGames.PlayMaker.Actions.ListenForRight
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| wasPressed | Event(GET UP) | Event(GET UP) |  |  |
| wasReleased | Event() | Event() |  |  |
| isPressed | Event() | Event() |  |  |
| isNotPressed | Event() | Event() |  |  |

##### 4. ListenForLeft

Full Name: HutongGames.PlayMaker.Actions.ListenForLeft
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| wasPressed | Event(GET UP) | Event(GET UP) |  |  |
| wasReleased | Event() | Event() |  |  |
| isPressed | Event() | Event() |  |  |
| isNotPressed | Event() | Event() |  |  |

##### 5. ListenForAttack

Full Name: HutongGames.PlayMaker.Actions.ListenForAttack
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| wasPressed | Event(GET UP) | Event(GET UP) |  |  |
| wasReleased | Event() | Event() |  |  |
| isPressed | Event() | Event() |  |  |
| isNotPressed | Event() | Event() |  |  |

##### 6. ListenForJump

Full Name: HutongGames.PlayMaker.Actions.ListenForJump
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| wasPressed | Event(GET UP) | Event(GET UP) |  |  |
| wasReleased | Event() | Event() |  |  |
| isPressed | Event() | Event() |  |  |
| isNotPressed | Event() | Event() |  |  |

### Get Up

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(BroadcastAll):FSM Owner | EventTarget(BroadcastAll):FSM Owner |  |  |
| sendEvent | "DREAM WAKE" | "DREAM WAKE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| clipName | "Prostrate Rise" | "Prostrate Rise" |  |  |
| animationTriggerEvent | Event() | Event() |  |  |
| animationCompleteEvent | Event(FINISHED) | Event(FINISHED) |  |  |

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

##### 3. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::RequireReceiver | 0 |  |  |
| functionCall | QuakeInvuln(???) | QuakeInvuln(???) |  |  |

##### 4. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault HeroBox | OwnerDefault HeroBox |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 5. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| behaviour | "HeroController" | "HeroController" | Behaviour |  |
| methodName | "SetDamageModeFSM" | "SetDamageModeFSM" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var | Var | Variable | Store Result |

### Long?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 2f | 2f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

##### 2. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Dream Return Long | bool Dream Return Long | Variable |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(FINISHED) | Event(FINISHED) |  |  |
| everyFrame | false | false |  |  |

### GC Pause

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.5f | 0.5f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Time Pause

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.5f | 0.5f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

##### 2. SetIsKinematic2d

Full Name: HutongGames.PlayMaker.Actions.SetIsKinematic2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| isKinematic | true | true |  |  |

##### 3. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | false | false |  |  |

##### 4. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName | "isInvincible" | "isInvincible" |  |  |
| value | true | true |  |  |

##### 5. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| behaviour | "HeroController" | "HeroController" | Behaviour |  |
| methodName | "SetDamageModeFSM" | "SetDamageModeFSM" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var | Var | Variable | Store Result |

##### 6. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | RelinquishControl(???) | RelinquishControl(???) |  |  |

##### 7. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName | "disablePause" | "disablePause" |  |  |
| value | true | true |  |  |

### Frame Pause

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

### Position

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetPlayerDataFloat

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| floatName | "dreamGateX" | "dreamGateX" |  |  |
| storeValue | float Gate X | float Gate X | Variable |  |

##### 2. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName | "disablePause" | "disablePause" |  |  |
| value | true | true |  |  |

##### 3. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | RelinquishControl(???) | RelinquishControl(???) |  |  |

##### 4. GetPlayerDataFloat

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| floatName | "dreamGateY" | "dreamGateY" |  |  |
| storeValue | float Gate Y | float Gate Y | Variable |  |

##### 5. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | float Gate X | float Gate X |  |  |
| y | float Gate Y | float Gate Y |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 6. SetIsKinematic2d

Full Name: HutongGames.PlayMaker.Actions.SetIsKinematic2d
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| isKinematic | false | false |  |  |

##### 7. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 1f | 1f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

##### 8. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault MainCamera | OwnerDefault MainCamera |  |  |
| behaviour | "CameraController" | "CameraController" | Behaviour |  |
| methodName | "SnapTo" | "SnapTo" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var | Var | Variable | Store Result |

### Gate Fade

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Dream Returning | bool Dream Returning | Variable |  |
| boolValue | false | false |  |  |
| everyFrame | false | false |  |  |

##### 2. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Gate Returning | bool Gate Returning | Variable |  |
| boolValue | false | false |  |  |
| everyFrame | false | false |  |  |

##### 3. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Dream Return Long | bool Dream Return Long | Variable |  |
| boolValue | false | false |  |  |
| everyFrame | false | false |  |  |

##### 4. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | EnableRenderer(???) | EnableRenderer(???) |  |  |

##### 5. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | RelinquishControl(???) | RelinquishControl(???) |  |  |

##### 6. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | StopAnimationControl(???) | StopAnimationControl(???) |  |  |

##### 7. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Prostrate" | "Prostrate" |  |  |

##### 8. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):HUD Blanker | EventTarget(GameObject):HUD Blanker |  |  |
| sendEvent | "FADE OUT" | "FADE OUT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 9. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):HUD Blanker White | EventTarget(GameObject):HUD Blanker White |  |  |
| sendEvent | "FADE OUT" | "FADE OUT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 10. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 1f | 1f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Warp In

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| clipName | "DG Warp In" | "DG Warp In" |  |  |
| animationTriggerEvent | Event() | Event() |  |  |
| animationCompleteEvent | Event(FINISHED) | Event(FINISHED) |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):CameraParent | EventTarget(GameObject):CameraParent |  |  |
| sendEvent | "AverageShake" | "AverageShake" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | true | true |  |  |

##### 4. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [dream_enter_pt_2 (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [dream_enter_pt_2 (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| pitchMin | 1.2f | 1.2f |  |  |
| pitchMax | 1.2f | 1.2f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 5. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault DG Set Impact | OwnerDefault DG Set Impact |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 6. PlayParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.PlayParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Warp In Pt | OwnerDefault Warp In Pt |  |  |
| emit | 0 | 0 |  |  |

##### 7. GetStaticVariable

Full Name: GetStaticVariable
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variableName | "skipRemoveDreamOrbs" | "skipRemoveDreamOrbs" |  |  |
| storeValue | Var Skip Remove Orbs = False | Var Skip Remove Orbs = False | Variable |  |

##### 8. SetStaticVariable

Full Name: SetStaticVariable
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variableName | "skipRemoveDreamOrbs" | "skipRemoveDreamOrbs" |  |  |
| setValue | Var unnamed = False | Var unnamed = False |  |  |

##### 9. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Skip Remove Orbs | bool Skip Remove Orbs | Variable |  |
| isTrue | Event(FINISHED) | Event(FINISHED) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 10. PlayerDataIntAdd

Full Name: HutongGames.PlayMaker.Actions.PlayerDataIntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "dreamOrbs" | "dreamOrbs" |  |  |
| amount | int Decrement | int Decrement | Variable |  |

##### 11. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(BroadcastAll):FSM Owner | EventTarget(BroadcastAll):FSM Owner |  |  |
| sendEvent | "DREAM ORB COLLECT" | "DREAM ORB COLLECT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 12. IncrementPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.IncrementPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "dreamOrbsSpent" | "dreamOrbsSpent" |  |  |

### On Ground?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. RayCast2d

Full Name: HutongGames.PlayMaker.Actions.RayCast2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| fromGameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  | Setup |
| fromPosition | Vector2(0, 0) | Vector2(0, 0) |  |  |
| direction | Vector2(0, -1) | Vector2(0, -1) |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| distance | 2f | 2f |  |  |
| minDepth | 0 | 0 |  |  |
| maxDepth | 0 | 0 |  |  |
| hitEvent | Event(GROUND) | Event(GROUND) | Variable | Result |
| storeDidHit | false | false | Variable |  |
| storeHitObject |  |  | Variable |  |
| storeHitPoint | Vector2(0, 0) | Vector2(0, 0) | Variable |  |
| storeHitNormal | Vector2(0, 0) | Vector2(0, 0) | Variable |  |
| storeHitDistance | 0f | 0f | Variable |  |
| storeHitFraction | 0f | 0f | Variable |  |
| repeatInterval | 1 | 1 |  | Filter |
| layerMask | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 | Layer |  |
| invertMask | false | false |  |  |
| debugColor | Color(1, 0.92156863, 0.015686275, 1) | Color(1, 0.92156863, 0.015686275, 1) |  | Debug |
| debug | false | false |  |  |

##### 2. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.2f | 0.2f |  |  |
| finishEvent | Event(AIR) | Event(AIR) |  |  |
| realTime | false | false |  |  |

##### 3. NextFrameEvent

Full Name: HutongGames.PlayMaker.Actions.NextFrameEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent | Event(AIR) | Event(AIR) |  |  |

### Land

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| clipName | "Super Hard Land" | "Super Hard Land" |  |  |
| animationTriggerEvent | Event() | Event() |  |  |
| animationCompleteEvent | Event(FINISHED) | Event(FINISHED) |  |  |

##### 2. SetIsKinematic2d

Full Name: HutongGames.PlayMaker.Actions.SetIsKinematic2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| isKinematic | false | false |  |  |

##### 3. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector3 Respawn Pos | Vector3 Respawn Pos | Variable |  |
| x | 0f | 0f | Variable |  |
| y | 0f | 0f | Variable |  |
| z | 0f | 0f | Variable |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |

##### 4. SetVector3XYZ

Full Name: HutongGames.PlayMaker.Actions.SetVector3XYZ
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable | Vector3 Respawn Pos | Vector3 Respawn Pos | Variable |  |
| vector3Value | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| z | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 5. Vector3AddXYZ

Full Name: HutongGames.PlayMaker.Actions.Vector3AddXYZ
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable | Vector3 Respawn Pos | Vector3 Respawn Pos | Variable |  |
| addX | 0f | 0f |  |  |
| addY | 1f | 1f |  |  |
| addZ | 0f | 0f |  |  |
| everyFrame | false | false |  |  |
| perSecond | false | false |  |  |

##### 6. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| behaviour | "HeroController" | "HeroController" | Behaviour |  |
| methodName | "SetHazardRespawn" | "SetHazardRespawn" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var unnamed = 0 | Var unnamed = 0 | Variable | Store Result |

### Ready 2

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
| functionCall | FlashingSuperDash(???) | FlashingSuperDash(???) |  |  |

##### 2. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName | "disablePause" | "disablePause" |  |  |
| value | false | false |  |  |

##### 3. ListenForDown

Full Name: HutongGames.PlayMaker.Actions.ListenForDown
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| wasPressed | Event(GET UP) | Event(GET UP) |  |  |
| wasReleased | Event() | Event() |  |  |
| isPressed | Event() | Event() |  |  |
| isNotPressed | Event() | Event() |  |  |
| isPressedBool | false | false | Variable |  |
| stateEntryOnly | false | false |  |  |

##### 4. ListenForUp

Full Name: HutongGames.PlayMaker.Actions.ListenForUp
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| wasPressed | Event(GET UP) | Event(GET UP) |  |  |
| wasReleased | Event() | Event() |  |  |
| isPressed | Event() | Event() |  |  |
| isNotPressed | Event() | Event() |  |  |
| isPressedBool | false | false | Variable |  |
| stateEntryOnly | false | false |  |  |

##### 5. ListenForRight

Full Name: HutongGames.PlayMaker.Actions.ListenForRight
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| wasPressed | Event(GET UP) | Event(GET UP) |  |  |
| wasReleased | Event() | Event() |  |  |
| isPressed | Event() | Event() |  |  |
| isNotPressed | Event() | Event() |  |  |

##### 6. ListenForLeft

Full Name: HutongGames.PlayMaker.Actions.ListenForLeft
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| wasPressed | Event(GET UP) | Event(GET UP) |  |  |
| wasReleased | Event() | Event() |  |  |
| isPressed | Event() | Event() |  |  |
| isNotPressed | Event() | Event() |  |  |

##### 7. ListenForAttack

Full Name: HutongGames.PlayMaker.Actions.ListenForAttack
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| wasPressed | Event(GET UP) | Event(GET UP) |  |  |
| wasReleased | Event() | Event() |  |  |
| isPressed | Event() | Event() |  |  |
| isNotPressed | Event() | Event() |  |  |

##### 8. ListenForJump

Full Name: HutongGames.PlayMaker.Actions.ListenForJump
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| wasPressed | Event(GET UP) | Event(GET UP) |  |  |
| wasReleased | Event() | Event() |  |  |
| isPressed | Event() | Event() |  |  |
| isNotPressed | Event() | Event() |  |  |

##### 9. GetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.GetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector2(0, 0) | Vector2(0, 0) | Variable |  |
| x | float X Velocity | float X Velocity | Variable |  |
| y | float Y Velocity | float Y Velocity | Variable |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |

##### 10. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float X Velocity | float X Velocity |  |  |
| float2 | 0f | 0f |  |  |
| tolerance | 0f | 0f |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event(CANCEL) | Event(CANCEL) |  |  |
| greaterThan | Event(CANCEL) | Event(CANCEL) |  |  |
| everyFrame | false | false |  |  |

##### 11. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float Y Velocity | float Y Velocity |  |  |
| float2 | 0f | 0f |  |  |
| tolerance | 0f | 0f |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event(CANCEL) | Event(CANCEL) |  |  |
| greaterThan | Event(CANCEL) | Event(CANCEL) |  |  |
| everyFrame | false | false |  |  |

##### 12. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector2(0, 0) | Vector2(0, 0) |  |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| everyFrame | true | true |  |  |

### Get Up 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| clipName | "Collect Normal 3" | "Collect Normal 3" |  |  |
| animationTriggerEvent | Event() | Event() |  |  |
| animationCompleteEvent | Event(FINISHED) | Event(FINISHED) |  |  |

##### 2. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | CancelFlash(???) | CancelFlash(???) |  |  |

### Air Regain

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetIsKinematic2d

Full Name: HutongGames.PlayMaker.Actions.SetIsKinematic2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| isKinematic | false | false |  |  |

##### 2. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName | "disablePause" | "disablePause" |  |  |
| value | false | false |  |  |

##### 3. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | CancelFlash(???) | CancelFlash(???) |  |  |

##### 4. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector3 Respawn Pos | Vector3 Respawn Pos | Variable |  |
| x | 0f | 0f | Variable |  |
| y | 0f | 0f | Variable |  |
| z | 0f | 0f | Variable |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |

##### 5. SetVector3XYZ

Full Name: HutongGames.PlayMaker.Actions.SetVector3XYZ
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable | Vector3 Respawn Pos | Vector3 Respawn Pos | Variable |  |
| vector3Value | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| z | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 6. Vector3AddXYZ

Full Name: HutongGames.PlayMaker.Actions.Vector3AddXYZ
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable | Vector3 Respawn Pos | Vector3 Respawn Pos | Variable |  |
| addX | 0f | 0f |  |  |
| addY | 1f | 1f |  |  |
| addZ | 0f | 0f |  |  |
| everyFrame | false | false |  |  |
| perSecond | false | false |  |  |

##### 7. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| behaviour | "HeroController" | "HeroController" | Behaviour |  |
| methodName | "SetHazardRespawn" | "SetHazardRespawn" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var unnamed = 0 | Var unnamed = 0 | Variable | Store Result |

### Save

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | TimePasses(???) | TimePasses(???) |  |  |

##### 2. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | SaveGame(???) | SaveGame(???) |  |  |

### Longer Grimm Return?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Grimm Return | bool Grimm Return | Variable |  |
| isTrue | Event(GRIMM) | Event(GRIMM) |  |  |
| isFalse | Event(FINISHED) | Event(FINISHED) |  |  |
| everyFrame | false | false |  |  |

### Prostrate Grimm

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Dream Returning | bool Dream Returning | Variable |  |
| boolValue | false | false |  |  |
| everyFrame | false | false |  |  |

##### 2. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Grimm Return | bool Grimm Return | Variable |  |
| boolValue | false | false |  |  |
| everyFrame | false | false |  |  |

##### 3. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Gate Returning | bool Gate Returning | Variable |  |
| boolValue | false | false |  |  |
| everyFrame | false | false |  |  |

##### 4. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Dream Return Long | bool Dream Return Long | Variable |  |
| boolValue | false | false |  |  |
| everyFrame | false | false |  |  |

##### 5. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | EnableRenderer(???) | EnableRenderer(???) |  |  |

##### 6. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | RelinquishControl(???) | RelinquishControl(???) |  |  |

##### 7. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | StopAnimationControl(???) | StopAnimationControl(???) |  |  |

##### 8. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Prostrate" | "Prostrate" |  |  |

##### 9. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault HUD Blanker | OwnerDefault HUD Blanker |  |  |
| fsmName | "Blanker Control" | "Blanker Control" | FsmName |  |
| variableName | "Fade Time" | "Fade Time" | FsmFloat |  |
| setValue | 3f | 3f |  |  |
| everyFrame | false | false |  |  |

##### 10. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):HUD Blanker | EventTarget(GameObject):HUD Blanker |  |  |
| sendEvent | "FADE OUT" | "FADE OUT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 11. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| behaviour | "HeroController" | "HeroController" | Behaviour |  |
| methodName | "MaxHealth" | "MaxHealth" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var unnamed = 0 | Var unnamed = 0 | Variable | Store Result |

##### 12. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(BroadcastAll):FSM Owner | EventTarget(BroadcastAll):FSM Owner |  |  |
| sendEvent | "UPDATE BLUE HEALTH" | "UPDATE BLUE HEALTH" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 13. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 3f | 3f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Grimm Pause

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 2f | 2f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Abyss Check

Description: Hornet Abyss NPC should not appear in Abyss_06 if player dream-gates out of abyss after getting shade cloak.
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "hasShadowDash" | "hasShadowDash" |  |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(FINISHED) | Event(FINISHED) |  |  |

##### 2. CheckCurrentMapZone

Full Name: CheckCurrentMapZone
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| mapZone | "ABYSS" | "ABYSS" |  |  |
| equalEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| notEqualEvent | Event() | Event() |  |  |

##### 3. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName | "hornetAbyssEncounter" | "hornetAbyssEncounter" |  |  |
| value | true | true |  |  |

### GG Return

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. CheckStaticBool

Full Name: CheckStaticBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variableName | "finishedBossReturning" | "finishedBossReturning" |  |  |
| trueEvent | Event() | Event() |  |  |
| falseEvent | Event(CANCEL) | Event(CANCEL) |  |  |

##### 2. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | EnableRenderer(???) | EnableRenderer(???) |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(BroadcastAll):FSM Owner | EventTarget(BroadcastAll):FSM Owner |  |  |
| sendEvent | "DREAM WAKE" | "DREAM WAKE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 4. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):HUD Blanker | EventTarget(GameObject):HUD Blanker |  |  |
| sendEvent | "FADE OUT" | "FADE OUT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 5. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):HUD Blanker White | EventTarget(GameObject):HUD Blanker White |  |  |
| sendEvent | "FADE OUT" | "FADE OUT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Wait until after

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

### GG Return?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. CheckSceneName

Full Name: CheckSceneName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sceneName | "GG_Atrium" | "GG_Atrium" |  |  |
| equalEvent | Event(GODS GLORY) | Event(GODS GLORY) |  |  |
| notEqualEvent | Event() | Event() |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Init | FINISHED | Idle | 0 | 0 | 0 |
| Idle | LEVEL LOADED | Wait until after | 0 | 0 | 0 |
| Check | FINISHED | Idle | 0 | 0 | 0 |
| Check | DREAM RETURN | GG Return? | 0 | 0 | 0 |
| Check | GATE RETURN | Time Pause | 0 | 0 | 0 |
| Prostrate | FINISHED | Ready | 0 | 0 | 0 |
| Pause | FINISHED | GC Pause | 0 | 0 | 0 |
| Ready | GET UP | Get Up | 0 | 0 | 0 |
| Get Up | FINISHED | Save | 0 | 0 | 0 |
| Regain Control | FINISHED | Idle | 0 | 0 | 0 |
| Long? | FINISHED | Pause | 0 | 0 | 0 |
| GC Pause | FINISHED | Longer Grimm Return? | 0 | 0 | 0 |
| Time Pause | FINISHED | Frame Pause | 0 | 0 | 0 |
| Frame Pause | FINISHED | Position | 0 | 0 | 0 |
| Position | FINISHED | Gate Fade | 0 | 0 | 0 |
| Gate Fade | FINISHED | Warp In | 0 | 0 | 0 |
| Warp In | FINISHED | Abyss Check | 0 | 0 | 0 |
| On Ground? | AIR | Air Regain | 0 | 0 | 0 |
| On Ground? | GROUND | Land | 0 | 0 | 0 |
| Land | FINISHED | Ready 2 | 0 | 0 | 0 |
| Ready 2 | GET UP | Get Up 2 | 0 | 0 | 0 |
| Ready 2 | CANCEL | Air Regain | 0 | 0 | 0 |
| Get Up 2 | FINISHED | Regain Control | 0 | 0 | 0 |
| Air Regain | FINISHED | Regain Control | 0 | 0 | 0 |
| Save | FINISHED | Regain Control | 0 | 0 | 0 |
| Longer Grimm Return? | FINISHED | Prostrate | 0 | 0 | 0 |
| Longer Grimm Return? | GRIMM | Grimm Pause | 0 | 0 | 0 |
| Prostrate Grimm | FINISHED | Ready | 0 | 0 | 0 |
| Grimm Pause | FINISHED | Prostrate Grimm | 0 | 0 | 0 |
| Abyss Check | FINISHED | On Ground? | 0 | 0 | 0 |
| GG Return | FINISHED | Save | 0 | 0 | 0 |
| GG Return | CANCEL | Pause | 0 | 0 | 0 |
| Wait until after | FINISHED | Check | 0 | 0 | 0 |
| GG Return? | FINISHED | Long? | 0 | 0 | 0 |
| GG Return? | GODS GLORY | GG Return | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| TEST | Pause | 0 | 0 | 0 |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| LEVEL LOADED | false |
| AIR | false |
| CANCEL | false |
| DREAM RETURN | false |
| GATE RETURN | false |
| GET UP | false |
| GODS GLORY | false |
| GRIMM | false |
| GROUND | false |
| TEST | false |

