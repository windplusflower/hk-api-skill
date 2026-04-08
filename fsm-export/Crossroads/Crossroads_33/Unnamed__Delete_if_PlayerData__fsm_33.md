# Delete if PlayerData

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Delete if PlayerData |
| GameObject Name | Unnamed |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets64.assets |
| Start State | Check |
| FSM PathId | 33 |
| GameObject PathId |  |

## Variables

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Activate | false | Boolean: false |
| Check if Player Data is | false | Boolean: false |
| Player Data Bool | false | Boolean: false |

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| Player Data name |  | String:  |

## States

### Check

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName | string Player Data name | string Player Data name |  |  |
| storeValue | bool Player Data Bool | bool Player Data Bool | Variable |  |

##### 2. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Check if Player Data is | bool Check if Player Data is | Variable |  |
| isTrue | Event(CHECK TRUE) | Event(CHECK TRUE) |  |  |
| isFalse | Event(CHECK FALSE) | Event(CHECK FALSE) |  |  |
| everyFrame | false | false |  |  |

### Check True

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Player Data Bool | bool Player Data Bool | Variable |  |
| isTrue | Event(CHANGE) | Event(CHANGE) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

### Check False

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Player Data Bool | bool Player Data Bool | Variable |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(CHANGE) | Event(CHANGE) |  |  |
| everyFrame | false | false |  |  |

### Check Activation

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
| activate | bool Activate | bool Activate |  |  |
| recursive | true | true |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Check | CHECK TRUE | Check True | 0 | 0 | 0 |
| Check | CHECK FALSE | Check False | 0 | 0 | 0 |
| Check True | CHANGE | Check Activation | 0 | 0 | 0 |
| Check False | CHANGE | Check Activation | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| CHANGE | false |
| CHECK FALSE | false |
| CHECK TRUE | false |

