# Pool Flukes

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Pool Flukes |
| GameObject Name | Charm Effects |
| GameObject Path | Knight/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level4 |
| Start State | State 1 |
| FSM PathId | 1125 |
| GameObject PathId | 147 |

## Variables

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Fireball Level | 0 | Int32: 0 |

## States

### State 1

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| intName |   | "fireballLevel" |   |   |
| storeValue |   | int Fireball Level | Variable |   |

##### 2. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Fireball Level |   |   |
| integer2 |   | 1 |   |   |
| equal |   | LEVEL 1 |   |   |
| lessThan |   | FINISHED |   |   |
| greaterThan |   | LEVEL 2 |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| LEVEL 1 | Pool Normal | 0 | |
| LEVEL 2 | Pool Black | 0 | |
| FINISHED | Idle | 0 | |

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

(none)

#### Transitions

(none)

### Pool Black

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. CreateGameObjectPool

Full Name: CreateGameObjectPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| prefab |   | [Global] [Spell Fluke Black (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| amount |   | 64 |   |   |
| useExisting |   | true |   |   |

#### Transitions

(none)

### Pool Normal

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. CreateGameObjectPool

Full Name: CreateGameObjectPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| prefab |   | [Global] [Spell Fluke (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| amount |   | 36 |   |   |
| useExisting |   | true |   |   |

#### Transitions

(none)

## Global Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| CHARM EQUIP CHECK | State 1 | 0 | |

## Events

| Name | Global |
| --- | --- |
| CANCEL | false |
| CHARM EQUIP CHECK | false |
| FINISHED | false |
| LEVEL 1 | false |
| LEVEL 2 | false |

