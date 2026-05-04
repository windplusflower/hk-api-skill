# Set PlayerData

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Set PlayerData |
| GameObject Name | Hornet Encounter Control |
| GameObject Path |   |
| Source Asset | Hollow Knight/hollow_knight_Data/level158 |
| Start State | Set |
| FSM PathId | 9249 |
| GameObject PathId | 1441 |

## Variables

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| PlayerData | 0 | Int32: 0 |

## States

### Set

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| intName |   | "hornetGreenpath" |   |   |
| storeValue |   | int PlayerData | Variable |   |

##### 2. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int PlayerData |   |   |
| integer2 |   | 3 |   |   |
| equal |   | Event() |   |   |
| lessThan |   | Event(SET) |   |   |
| greaterThan |   | Event() |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| SET | Set Int | 0 | |

### Set Int

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intName |   | "hornetGreenpath" |   |   |
| value |   | 3 |   |   |

#### Transitions

(none)

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| SET | false |

