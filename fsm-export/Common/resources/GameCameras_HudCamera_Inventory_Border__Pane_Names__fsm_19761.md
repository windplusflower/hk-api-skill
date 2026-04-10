# Pane Names

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Pane Names |
| GameObject Name | Border |
| GameObject Path | _GameCameras/HudCamera/Inventory |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Init |
| FSM PathId | 19761 |
| GameObject PathId | 7069 |

## Variables

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| Current Pane Str |  | String:  |
| L Pane Str |  | String:  |
| R Pane Str |  | String:  |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Current Pane | [null] | NamedAssetPPtr:  |
| Pane L | [null] | NamedAssetPPtr:  |
| Pane R | [null] | NamedAssetPPtr:  |

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
| childName | "Pane Name" | "Pane Name" |  |  |
| storeResult | GameObject Current Pane | GameObject Current Pane | Variable |  |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Pane Name L" | "Pane Name L" |  |  |
| storeResult | GameObject Pane L | GameObject Pane L | Variable |  |

##### 3. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Pane Name R" | "Pane Name R" |  |  |
| storeResult | GameObject Pane R | GameObject Pane R | Variable |  |

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

_None_

### Down

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:FSM Owner | EventTarget(GameObject)[SendToChildren]:FSM Owner |  |  |
| sendEvent | "CHANGE DOWN" | "CHANGE DOWN" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.15f | 0.15f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Update text

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Current Pane | OwnerDefault Current Pane |  |  |
| textString | string Current Pane Str | string Current Pane Str |  |  |

##### 2. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Pane L | OwnerDefault Pane L |  |  |
| textString | string L Pane Str | string L Pane Str |  |  |

##### 3. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Pane R | OwnerDefault Pane R |  |  |
| textString | string R Pane Str | string R Pane Str |  |  |

### Up

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:FSM Owner | EventTarget(GameObject)[SendToChildren]:FSM Owner |  |  |
| sendEvent | "CHANGE UP" | "CHANGE UP" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Init | FINISHED | Idle | 0 | 0 | 0 |
| Idle | UPDATE | Down | 0 | 0 | 0 |
| Down | FINISHED | Update text | 0 | 0 | 0 |
| Update text | FINISHED | Up | 0 | 0 | 0 |
| Up | FINISHED | Idle | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| UPDATE | false |

