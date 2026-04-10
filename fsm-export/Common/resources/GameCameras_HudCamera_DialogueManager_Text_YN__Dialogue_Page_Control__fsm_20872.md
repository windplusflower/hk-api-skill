# Dialogue Page Control

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Dialogue Page Control |
| GameObject Name | Text YN |
| GameObject Path | _GameCameras/HudCamera/DialogueManager |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Init |
| FSM PathId | 20872 |
| GameObject PathId | 5488 |

## Variables

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Item Number | 0 | Int32: 0 |
| Toll Cost | 0 | Int32: 0 |

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| Toll Cost String |  | String:  |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Geo Text | [null] | NamedAssetPPtr:  |
| Requester | [null] | NamedAssetPPtr:  |
| Stop | [null] | NamedAssetPPtr:  |
| UI List | [null] | NamedAssetPPtr:  |

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
| childName | "Stop" | "Stop" |  |  |
| storeResult | GameObject Stop | GameObject Stop | Variable |  |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Geo Text" | "Geo Text" |  |  |
| storeResult | GameObject Geo Text | GameObject Geo Text | Variable |  |

##### 3. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "UI List" | "UI List" |  |  |
| storeResult | GameObject UI List | GameObject UI List | Variable |  |

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

_None_

### Conversation End

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault UI List | OwnerDefault UI List |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

### End Conversation

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| behaviour | "DialogueBox" | "DialogueBox" | Behaviour |  |
| methodName | "HideText" | "HideText" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var unnamed = 0 | Var unnamed = 0 | Variable | Store Result |

##### 2. GetFsmInt

Full Name: HutongGames.PlayMaker.Actions.GetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault UI List | OwnerDefault UI List |  |  |
| fsmName | "ui_list" | "ui_list" | FsmName |  |
| variableName | "Current Item" | "Current Item" | FsmInt |  |
| storeValue | int Item Number | int Item Number | Variable |  |
| everyFrame | false | false |  |  |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault UI List | OwnerDefault UI List |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 4. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Geo Text | OwnerDefault Geo Text |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 5. IntSwitch

Full Name: HutongGames.PlayMaker.Actions.IntSwitch
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Item Number | int Item Number | Variable |  |
| compareTo | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| sendEvent | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| everyFrame | false | false |  |  |

### Take Geo

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Toll Cost | int Toll Cost |  |  |
| integer2 | 0 | 0 |  |  |
| equal | Event(FINISHED) | Event(FINISHED) |  |  |
| lessThan | Event(FINISHED) | Event(FINISHED) |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 2. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| behaviour | "HeroController" | "HeroController" | Behaviour |  |
| methodName | "TakeGeo" | "TakeGeo" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var unnamed = 0 | Var unnamed = 0 | Variable | Store Result |

##### 3. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 1f | 1f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### No

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Requester | EventTarget(GameObject):Requester |  |  |
| sendEvent | "NO" | "NO" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Yes

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Requester | EventTarget(GameObject):Requester |  |  |
| sendEvent | "YES" | "YES" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Activate Geo Text?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Geo Text | OwnerDefault Geo Text |  |  |
| activate | true | true |  |  |
| recursive | true | true |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 2. ConvertIntToString

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Toll Cost | int Toll Cost | Variable |  |
| stringVariable | string Toll Cost String | string Toll Cost String | Variable |  |
| format | "" | "" |  |  |
| everyFrame | false | false |  |  |

##### 3. SetTextMeshText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Geo Text | OwnerDefault Geo Text |  |  |
| textString | string Toll Cost String | string Toll Cost String |  |  |

##### 4. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Toll Cost | int Toll Cost |  |  |
| integer2 | 0 | 0 |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event() | Event() |  |  |
| greaterThan | Event(FINISHED) | Event(FINISHED) |  |  |
| everyFrame | false | false |  |  |

##### 5. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Geo Text | OwnerDefault Geo Text |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 6. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | "NO" | "NO" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Ready for Input

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

_None_

### Pause

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.2f | 0.2f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Hero Damaged

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
| behaviour | "DialogueBox" | "DialogueBox" | Behaviour |  |
| methodName | "HideText" | "HideText" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var unnamed = 0 | Var unnamed = 0 | Variable | Store Result |

##### 2. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault UI List | OwnerDefault UI List |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Geo Text | OwnerDefault Geo Text |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Init | FINISHED | Idle | 0 | 0 | 0 |
| Idle | PAGE_END |  | 0 | 0 | 0 |
| Idle | CONVERSATION_END | Activate Geo Text? | 0 | 0 | 0 |
| Conversation End | FINISHED | Ready for Input | 0 | 0 | 0 |
| End Conversation | YES | Take Geo | 0 | 0 | 0 |
| End Conversation | NO | No | 0 | 0 | 0 |
| Take Geo | FINISHED | Yes | 0 | 0 | 0 |
| No | FINISHED | Idle | 0 | 0 | 0 |
| Yes | FINISHED | Idle | 0 | 0 | 0 |
| Activate Geo Text? | FINISHED | Pause | 0 | 0 | 0 |
| Activate Geo Text? | NO | Conversation End | 0 | 0 | 0 |
| Ready for Input | UI SELECTION MADE | End Conversation | 0 | 0 | 0 |
| Pause | FINISHED | Conversation End | 0 | 0 | 0 |
| Hero Damaged | FINISHED | Idle | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| HERO DAMAGED | Hero Damaged | 0 | 0 | 0 |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| CONVERSATION_END | false |
| HERO DAMAGED | true |
| NEXT | false |
| NO | false |
| PAGE_END | false |
| UI SELECTION MADE | false |
| YES | false |

