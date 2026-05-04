# FSM

## Summary

| Field | Value |
| --- | --- |
| FSM Name | FSM |
| GameObject Name | Battle Range |
| GameObject Path | _Enemies/Giant Fly/ |
| Source Asset | D:/SteamLibrary/steamapps/common/Hollow Knight/hollow_knight_Data/level445 |
| Start State | Init |
| FSM PathId | 1430 |
| GameObject PathId | 75 |

## Variables

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Deparent | false | Boolean: false |
| Send to Parent | true | Boolean: true |

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| Enter Event | HERO ENTER | String: HERO ENTER |
| Exit Event | HERO EXIT | String: HERO EXIT |
| Stay Event |   | String:  |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Parent | [null] | NamedAssetPPtr: [null] |
| Self | [null] | NamedAssetPPtr: [null] |

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

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Send to Parent? | 0 | |

### Send to Parent?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Send to Parent | Variable |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(FINISHED) |   |   |
| everyFrame |   | false |   |   |

##### 2. GetParent

Full Name: HutongGames.PlayMaker.Actions.GetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Self |   |   |
| storeResult |   | GameObject Parent | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Deparent? | 0 | |

### Detect

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SendTrigger2DEventByName

Full Name: HutongGames.PlayMaker.Actions.SendTrigger2DEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Parent |   |   |
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerEnter2D | 0 |   |   |
| collideTag |   | "" | Tag |   |
| collideLayer |   | 0 | Layer |   |
| sendEvent |   | string Enter Event |   |   |
| storeCollider |   |   | Variable |   |

##### 2. SendTrigger2DEventByName

Full Name: HutongGames.PlayMaker.Actions.SendTrigger2DEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Parent |   |   |
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerStay2D | 1 |   |   |
| collideTag |   | "" | Tag |   |
| collideLayer |   | 0 | Layer |   |
| sendEvent |   | string Stay Event |   |   |
| storeCollider |   |   | Variable |   |

##### 3. SendTrigger2DEventByName

Full Name: HutongGames.PlayMaker.Actions.SendTrigger2DEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Parent |   |   |
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerExit2D | 2 |   |   |
| collideTag |   | "" | Tag |   |
| collideLayer |   | 0 | Layer |   |
| sendEvent |   | string Exit Event |   |   |
| storeCollider |   |   | Variable |   |

#### Transitions

(none)

### On Stay?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. StringCompare

Full Name: HutongGames.PlayMaker.Actions.StringCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable |   | string Stay Event | Variable |   |
| compareTo |   | "" |   |   |
| equalEvent |   | Event(NO STAY) |   |   |
| notEqualEvent |   | Event(STAY) |   |   |
| storeResult |   | false | Variable |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| STAY | Detect | 0 | |
| NO STAY | Detect No Stay | 0 | |

### Detect No Stay

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SendTrigger2DEventByName

Full Name: HutongGames.PlayMaker.Actions.SendTrigger2DEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Parent |   |   |
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerEnter2D | 0 |   |   |
| collideTag |   | "" | Tag |   |
| collideLayer |   | 0 | Layer |   |
| sendEvent |   | string Enter Event |   |   |
| storeCollider |   |   | Variable |   |

##### 2. SendTrigger2DEventByName

Full Name: HutongGames.PlayMaker.Actions.SendTrigger2DEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Parent |   |   |
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerExit2D | 2 |   |   |
| collideTag |   | "" | Tag |   |
| collideLayer |   | 0 | Layer |   |
| sendEvent |   | string Exit Event |   |   |
| storeCollider |   |   | Variable |   |

#### Transitions

(none)

### Deparent?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Deparent | Variable |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(FINISHED) |   |   |
| everyFrame |   | false |   |   |

##### 2. SetParent

Full Name: HutongGames.PlayMaker.Actions.SetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| parent |   |   |   |   |
| resetLocalPosition |   | false |   |   |
| resetLocalRotation |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | On Stay? | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| NO STAY | false |
| STAY | false |

