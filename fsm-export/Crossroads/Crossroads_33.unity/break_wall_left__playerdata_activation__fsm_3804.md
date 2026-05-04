# playerdata_activation

## Summary

| Field | Value |
| --- | --- |
| FSM Name | playerdata_activation |
| GameObject Name | break_wall_left |
| GameObject Path | _Props/ |
| Source Asset | D:/SteamLibrary/steamapps/common/Hollow Knight/hollow_knight_Data/level64 |
| Start State | Check |
| FSM PathId | 3804 |
| GameObject PathId | 19 |

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
| Player Data name | crossroadsMawlekWall | String: crossroadsMawlekWall |

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
| boolName |   | string Player Data name |   |   |
| storeValue |   | bool Player Data Bool | Variable |   |

##### 2. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Check if Player Data is | Variable |   |
| isTrue |   | Event(CHECK TRUE) |   |   |
| isFalse |   | Event(CHECK FALSE) |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| CHECK TRUE | Check True | 0 | |
| CHECK FALSE | Check False | 0 | |

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
| boolVariable |   | bool Player Data Bool | Variable |   |
| isTrue |   | Event(CHANGE) |   |   |
| isFalse |   | Event() |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| CHANGE | Check Activation | 0 | |

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
| boolVariable |   | bool Player Data Bool | Variable |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(CHANGE) |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| CHANGE | Check Activation | 0 | |

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
| gameObject |   | OwnerDefault FSM Owner |   |   |
| activate |   | bool Activate |   |   |
| recursive |   | true |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

#### Transitions

(none)

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| CHANGE | false |
| CHECK FALSE | false |
| CHECK TRUE | false |

