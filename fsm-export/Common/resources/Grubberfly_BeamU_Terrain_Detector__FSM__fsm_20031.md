# FSM

## Summary

| Field | Value |
| --- | --- |
| FSM Name | FSM |
| GameObject Name | Terrain Detector |
| GameObject Path | Grubberfly BeamU |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Init |
| FSM PathId | 20031 |
| GameObject PathId | 4844 |

## Variables

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Deparent | false | Boolean: false |
| Send to Parent | true | Boolean: true |

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| Enter Event |  | String:  |
| Exit Event |  | String:  |
| Stay Event | TERRAIN HIT | String: TERRAIN HIT |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Parent | [null] | NamedAssetPPtr:  |
| Self | [null] | NamedAssetPPtr:  |

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
| storeGameObject | GameObject Self | GameObject Self | Variable |  |

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
| boolVariable | bool Send to Parent | bool Send to Parent | Variable |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(FINISHED) | Event(FINISHED) |  |  |
| everyFrame | false | false |  |  |

##### 2. GetParent

Full Name: HutongGames.PlayMaker.Actions.GetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| storeResult | GameObject Parent | GameObject Parent | Variable |  |

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
| eventTarget | EventTarget(GameObject):Parent | EventTarget(GameObject):Parent |  |  |
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerEnter2D | 0 |  |  |
| collideTag | "" | "" | Tag |  |
| collideLayer | 0 | 0 | Layer |  |
| sendEvent | string Enter Event | string Enter Event |  |  |
| storeCollider |  |  | Variable |  |

##### 2. SendTrigger2DEventByName

Full Name: HutongGames.PlayMaker.Actions.SendTrigger2DEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Parent | EventTarget(GameObject):Parent |  |  |
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerStay2D | 1 |  |  |
| collideTag | "" | "" | Tag |  |
| collideLayer | 0 | 0 | Layer |  |
| sendEvent | string Stay Event | string Stay Event |  |  |
| storeCollider |  |  | Variable |  |

##### 3. SendTrigger2DEventByName

Full Name: HutongGames.PlayMaker.Actions.SendTrigger2DEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Parent | EventTarget(GameObject):Parent |  |  |
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerExit2D | 2 |  |  |
| collideTag | "" | "" | Tag |  |
| collideLayer | 0 | 0 | Layer |  |
| sendEvent | string Exit Event | string Exit Event |  |  |
| storeCollider |  |  | Variable |  |

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
| stringVariable | string Stay Event | string Stay Event | Variable |  |
| compareTo | "" | "" |  |  |
| equalEvent | Event(NO STAY) | Event(NO STAY) |  |  |
| notEqualEvent | Event(STAY) | Event(STAY) |  |  |
| storeResult | false | false | Variable |  |
| everyFrame | false | false |  |  |

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
| eventTarget | EventTarget(GameObject):Parent | EventTarget(GameObject):Parent |  |  |
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerEnter2D | 0 |  |  |
| collideTag | "" | "" | Tag |  |
| collideLayer | 0 | 0 | Layer |  |
| sendEvent | string Enter Event | string Enter Event |  |  |
| storeCollider |  |  | Variable |  |

##### 2. SendTrigger2DEventByName

Full Name: HutongGames.PlayMaker.Actions.SendTrigger2DEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Parent | EventTarget(GameObject):Parent |  |  |
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerExit2D | 2 |  |  |
| collideTag | "" | "" | Tag |  |
| collideLayer | 0 | 0 | Layer |  |
| sendEvent | string Exit Event | string Exit Event |  |  |
| storeCollider |  |  | Variable |  |

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
| boolVariable | bool Deparent | bool Deparent | Variable |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(FINISHED) | Event(FINISHED) |  |  |
| everyFrame | false | false |  |  |

##### 2. SetParent

Full Name: HutongGames.PlayMaker.Actions.SetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| parent |  |  |  |  |
| resetLocalPosition | false | false |  |  |
| resetLocalRotation | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Init | FINISHED | Send to Parent? | 0 | 0 | 0 |
| Send to Parent? | FINISHED | Deparent? | 0 | 0 | 0 |
| On Stay? | STAY | Detect | 0 | 0 | 0 |
| On Stay? | NO STAY | Detect No Stay | 0 | 0 | 0 |
| Deparent? | FINISHED | On Stay? | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| NO STAY | false |
| STAY | false |

