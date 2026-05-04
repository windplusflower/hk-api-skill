# Perma Check

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Perma Check |
| GameObject Name | congrats body perma |
| GameObject Path | credits object/9 Message from Team Cherry/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level415 |
| Start State | State 1 |
| FSM PathId | 814 |
| GameObject PathId | 21 |

## Variables

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Perma Mode | 0 | Int32: 0 |

## States

### State 1

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
| intName |   | "permadeathMode" |   |   |
| storeValue |   | int Perma Mode | Variable |   |

##### 2. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Perma Mode |   |   |
| integer2 |   | 0 |   |   |
| equal |   | INACTIVE |   |   |
| lessThan |   | INACTIVE |   |   |
| greaterThan |   |   |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| INACTIVE | Inactive | 0 | |

### Inactive

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
| activate |   | false |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

#### Transitions

(none)

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| INACTIVE | false |

