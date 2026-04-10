# Update Text

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Update Text |
| GameObject Name | Charms |
| GameObject Path | _GameCameras/HudCamera/Inventory |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Init |
| FSM PathId | 20753 |
| GameObject PathId | 6719 |

## Variables

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| Convo Desc |  | String:  |
| Convo Name |  | String:  |
| Desc String |  | String:  |
| Name String |  | String:  |
| Sheet | UI | String: UI |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Text Desc | [null] | NamedAssetPPtr:  |
| Text Name | [null] | NamedAssetPPtr:  |

## States

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

_None_

### Idle

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
| childName | "Text Desc" | "Text Desc" |  |  |
| storeResult | GameObject Text Desc | GameObject Text Desc | Variable |  |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Text Name" | "Text Name" |  |  |
| storeResult | GameObject Text Name | GameObject Text Name | Variable |  |

### Fade Down

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Text Desc | EventTarget(GameObject):Text Desc |  |  |
| sendEvent | "CHANGE DOWN" | "CHANGE DOWN" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Text Name | EventTarget(GameObject):Text Name |  |  |
| sendEvent | "CHANGE DOWN" | "CHANGE DOWN" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.15f | 0.15f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Fade Up

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Text Desc | EventTarget(GameObject):Text Desc |  |  |
| sendEvent | "CHANGE UP" | "CHANGE UP" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Text Name | EventTarget(GameObject):Text Name |  |  |
| sendEvent | "CHANGE UP" | "CHANGE UP" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Pane Reset

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Text Desc | EventTarget(GameObject):Text Desc |  |  |
| sendEvent | "CHANGE DOWN" | "CHANGE DOWN" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Text Name | EventTarget(GameObject):Text Name |  |  |
| sendEvent | "CHANGE DOWN" | "CHANGE DOWN" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Change Text

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | string Sheet = "UI" | string Sheet = "UI" |  |  |
| convName | string Convo Name | string Convo Name |  |  |
| storeValue | string Name String | string Name String | Variable |  |

##### 2. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | string Sheet = "UI" | string Sheet = "UI" |  |  |
| convName | string Convo Desc | string Convo Desc |  |  |
| storeValue | string Desc String | string Desc String | Variable |  |

##### 3. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Text Name | OwnerDefault Text Name |  |  |
| textString | string Name String | string Name String |  |  |

##### 4. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Text Desc | OwnerDefault Text Desc |  |  |
| textString | string Desc String | string Desc String |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Init | FINISHED | Idle | 0 | 0 | 0 |
| Idle | UPDATE TEXT | Change Text | 0 | 0 | 0 |
| Fade Down | FINISHED | Change Text | 0 | 0 | 0 |
| Fade Up | FINISHED | Idle | 0 | 0 | 0 |
| Pane Reset | FINISHED | Idle | 0 | 0 | 0 |
| Change Text | FINISHED | Idle | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| PANE RESET | Pane Reset | 0 | 0 | 0 |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| PANE RESET | false |
| UPDATE TEXT | false |

