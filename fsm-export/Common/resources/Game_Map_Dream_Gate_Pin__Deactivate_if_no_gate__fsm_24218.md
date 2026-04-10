# Deactivate if no gate

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Deactivate if no gate |
| GameObject Name | Dream_Gate_Pin |
| GameObject Path | Game_Map |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Check |
| FSM PathId | 24218 |
| GameObject PathId | 7907 |

## Variables

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| Scene |  | String:  |

## States

### Check

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetPlayerDataString

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| stringName | "dreamGateScene" | "dreamGateScene" |  |  |
| storeValue | string Scene | string Scene | Variable |  |

##### 2. StringCompare

Full Name: HutongGames.PlayMaker.Actions.StringCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Scene | string Scene | Variable |  |
| compareTo | "" | "" |  |  |
| equalEvent | DEACTIVATE | DEACTIVATE |  |  |
| notEqualEvent |  |  |  |  |
| storeResult | false | false | Variable |  |
| everyFrame | false | false |  |  |

##### 3. StringCompare

Full Name: HutongGames.PlayMaker.Actions.StringCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Scene | string Scene | Variable |  |
| compareTo | " " | " " |  |  |
| equalEvent | DEACTIVATE | DEACTIVATE |  |  |
| notEqualEvent |  |  |  |  |
| storeResult | false | false | Variable |  |
| everyFrame | false | false |  |  |

### Deactivate

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Check | DEACTIVATE | Deactivate | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| DEACTIVATE | false |

