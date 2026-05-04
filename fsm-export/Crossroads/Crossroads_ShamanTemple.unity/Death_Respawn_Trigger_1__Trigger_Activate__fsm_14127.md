# Trigger Activate

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Trigger Activate |
| GameObject Name | Death Respawn Trigger 1 |
| GameObject Path | _Areas/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level76 |
| Start State | Idle |
| FSM PathId | 14127 |
| GameObject PathId | 1906 |

## Variables

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Shaman | 0 | Int32: 0 |

## States

### Idle

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
| storeValue |   | int Shaman | Variable |   |

##### 2. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Shaman |   |   |
| integer2 |   | 5 |   |   |
| equal |   | Event() |   |   |
| lessThan |   | Event() |   |   |
| greaterThan |   | Event(ACTIVATE RESPAWN TRIGGER) |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| ACTIVATE RESPAWN TRIGGER | Activate | 0 | |

### Activate

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SetCollider

Full Name: HutongGames.PlayMaker.Actions.SetCollider
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| active |   | true |   |   |

#### Transitions

(none)

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| ACTIVATE RESPAWN TRIGGER | false |

