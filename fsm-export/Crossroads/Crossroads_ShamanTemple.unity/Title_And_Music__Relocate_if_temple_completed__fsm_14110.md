# Relocate if temple completed

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Relocate if temple completed |
| GameObject Name | Title And Music |
| GameObject Path | _Managers/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level76 |
| Start State | Init |
| FSM PathId | 14110 |
| GameObject PathId | 1815 |

## Variables

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Shaman State | 0 | Int32: 0 |

## States

### Init

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
| intName |   | "shaman" |   |   |
| storeValue |   | int Shaman State | Variable |   |

##### 2. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Shaman State |   |   |
| integer2 |   | 6 |   |   |
| equal |   | Event(MOVE) |   |   |
| lessThan |   | Event() |   |   |
| greaterThan |   | Event(MOVE) |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| MOVE | Move | 0 | |

### Move

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 3.62f |   |   |
| y |   | 0f |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

#### Transitions

(none)

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| MOVE | false |

