# Update Text

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Update Text |
| GameObject Name | Inv |
| GameObject Path | _GameCameras/HudCamera/Inventory/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level1 |
| Start State | Init |
| FSM PathId | 9069 |
| GameObject PathId | 1185 |

## Variables

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| Convo Desc |   | String:  |
| Convo Name |   | String:  |
| Desc String |   | String:  |
| Name String |   | String:  |
| Sheet | UI | String: UI |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Text Desc | [null] | NamedAssetPPtr: [null] |
| Text Desc Low | [null] | NamedAssetPPtr: [null] |
| Text Name | [null] | NamedAssetPPtr: [null] |

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
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Text Name" |   |   |
| storeResult |   | GameObject Text Name | Variable |   |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Text Desc" |   |   |
| storeResult |   | GameObject Text Desc | Variable |   |

##### 3. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Text Desc Low" |   |   |
| storeResult |   | GameObject Text Desc Low | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Idle | 0 | |

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

(none)

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| UPDATE TEXT | State 1 | 0 | |

### Pane Reset

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Text Desc |   |   |
| sendEvent |   | "CHANGE DOWN" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Text Name |   |   |
| sendEvent |   | "CHANGE DOWN" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 3. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Text Name |   |   |
| textString |   | "" |   |   |

##### 4. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Text Desc |   |   |
| textString |   | "" |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Idle | 0 | |

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
| sheetName |   | string Sheet = "UI" |   |   |
| convName |   | string Convo Name |   |   |
| storeValue |   | string Name String | Variable |   |

##### 2. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName |   | string Sheet = "UI" |   |   |
| convName |   | string Convo Desc |   |   |
| storeValue |   | string Desc String | Variable |   |

##### 3. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Text Name |   |   |
| textString |   | string Name String |   |   |

##### 4. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Text Desc |   |   |
| textString |   | string Desc String |   |   |

##### 5. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Text Desc Low |   |   |
| textString |   | string Desc String |   |   |

##### 6. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):FSM Owner |   |   |
| sendEvent |   | "SET BUTTON CONTROL2" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Idle | 0 | |

### State 1

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. NextFrameEvent

Full Name: HutongGames.PlayMaker.Actions.NextFrameEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent |   | Event(FINISHED) |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Change Text | 0 | |

## Global Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| PANE RESET | Pane Reset | 0 | |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| PANE RESET | false |
| SET BUTTON CONTROL | false |
| UPDATE TEXT | false |

