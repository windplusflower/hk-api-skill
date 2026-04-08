# Darkness Region

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Darkness Region |
| GameObject Name | Darkness Region |
| GameObject Path | Scene Darken Object |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/level409.assets |
| Start State | Pause |
| FSM PathId | 2494 |
| GameObject PathId | 566 |

## Variables

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Darkness | 0 | Int32: 0 |
| Scene Darkness | 0 | Int32: 0 |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Scene Manager | [null] | NamedAssetPPtr:  |
| Vignette | [null] | NamedAssetPPtr:  |

## States

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. FindGameObject

Full Name: HutongGames.PlayMaker.Actions.FindGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| objectName | "_SceneManager" | "_SceneManager" |  |  |
| withTag | "SceneManager" | "SceneManager" | Tag |  |
| store | GameObject Scene Manager | GameObject Scene Manager | Variable |  |

##### 2. FindGameObject

Full Name: HutongGames.PlayMaker.Actions.FindGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| objectName | "Vignette" | "Vignette" |  |  |
| withTag | "Vignette" | "Vignette" | Tag |  |
| store | GameObject Vignette | GameObject Vignette | Variable |  |

##### 3. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Scene Manager | OwnerDefault Scene Manager |  |  |
| behaviour | "SceneManager" | "SceneManager" | Behaviour |  |
| methodName | "GetDarknessLevel" | "GetDarknessLevel" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var Scene Darkness = 0 | Var Scene Darkness = 0 | Variable | Store Result |

### Out

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Trigger2dEvent

Full Name: HutongGames.PlayMaker.Actions.Trigger2dEvent
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerEnter2D | 0 |  |  |
| collideTag | "" | "" | Tag |  |
| collideLayer | "" | "" | Layer |  |
| sendEvent | Event(ENTER) | Event(ENTER) |  |  |
| storeCollider |  |  | Variable |  |

##### 2. Trigger2dEvent

Full Name: HutongGames.PlayMaker.Actions.Trigger2dEvent
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerStay2D | 1 |  |  |
| collideTag | "" | "" | Tag |  |
| collideLayer | "" | "" | Layer |  |
| sendEvent | Event(ENTER) | Event(ENTER) |  |  |
| storeCollider |  |  | Variable |  |

##### 3. CheckTrackTriggerCount

Full Name: CheckTrackTriggerCount
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| count | 0 | 0 |  |  |
| test | Enum(CheckTrackTriggerCount+IntTest, 2) | Enum(CheckTrackTriggerCount+IntTest, 2) |  |  |
| everyFrame | true | true |  |  |
| successEvent | Event(ENTER) | Event(ENTER) |  |  |

### Enter

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Trigger2dEvent

Full Name: HutongGames.PlayMaker.Actions.Trigger2dEvent
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerExit2D | 2 |  |  |
| collideTag | "" | "" | Tag |  |
| collideLayer | "" | "" | Layer |  |
| sendEvent | Event(EXIT) | Event(EXIT) |  |  |
| storeCollider |  |  | Variable |  |

##### 2. CheckTrackTriggerCount

Full Name: CheckTrackTriggerCount
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| count | 0 | 0 |  |  |
| test | Enum(CheckTrackTriggerCount+IntTest, 3) | Enum(CheckTrackTriggerCount+IntTest, 3) |  |  |
| everyFrame | true | true |  |  |
| successEvent | Event(EXIT) | Event(EXIT) |  |  |

##### 3. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | SetDarkness(Darkness=int Darkness) | SetDarkness(Darkness=int Darkness) |  |  |

##### 4. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Vignette | OwnerDefault Vignette |  |  |
| fsmName | "Darkness Control" | "Darkness Control" | FsmName |  |
| variableName | "Darkness Level" | "Darkness Level" | FsmInt |  |
| setValue | int Darkness | int Darkness |  |  |
| everyFrame | false | false |  |  |

##### 5. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Vignette | EventTarget(GameObject):Vignette |  |  |
| sendEvent | "SCENE RESET" | "SCENE RESET" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Exit

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Trigger2dEvent

Full Name: HutongGames.PlayMaker.Actions.Trigger2dEvent
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerEnter2D | 0 |  |  |
| collideTag | "" | "" | Tag |  |
| collideLayer | "" | "" | Layer |  |
| sendEvent | Event(ENTER) | Event(ENTER) |  |  |
| storeCollider |  |  | Variable |  |

##### 2. CheckTrackTriggerCount

Full Name: CheckTrackTriggerCount
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| count | 0 | 0 |  |  |
| test | Enum(CheckTrackTriggerCount+IntTest, 2) | Enum(CheckTrackTriggerCount+IntTest, 2) |  |  |
| everyFrame | true | true |  |  |
| successEvent | Event(ENTER) | Event(ENTER) |  |  |

##### 3. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | SetDarkness(Scene Darkness=int Scene Darkness) | SetDarkness(Scene Darkness=int Scene Darkness) |  |  |

##### 4. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Vignette | OwnerDefault Vignette |  |  |
| fsmName | "Darkness Control" | "Darkness Control" | FsmName |  |
| variableName | "Darkness Level" | "Darkness Level" | FsmInt |  |
| setValue | int Scene Darkness | int Scene Darkness |  |  |
| everyFrame | false | false |  |  |

##### 5. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Vignette | EventTarget(GameObject):Vignette |  |  |
| sendEvent | "SCENE RESET" | "SCENE RESET" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Pause

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. WaitForHeroInPosition

Full Name: WaitForHeroInPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| skipIfAlreadyPositioned | true | true |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Init | FINISHED | Out | 0 | 0 | 0 |
| Out | ENTER | Enter | 0 | 0 | 0 |
| Enter | EXIT | Exit | 0 | 0 | 0 |
| Exit | ENTER | Enter | 0 | 0 | 0 |
| Pause | FINISHED | Init | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| ENTER | false |
| EXIT | false |

