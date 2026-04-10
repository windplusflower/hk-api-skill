# Pool Flukes

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Pool Flukes |
| GameObject Name | Charm Effects |
| GameObject Path | Knight |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | State 1 |
| FSM PathId | 25688 |
| GameObject PathId | 4312 |

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
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "fireballLevel" | "fireballLevel" |  |  |
| storeValue | int Fireball Level | int Fireball Level | Variable |  |

##### 2. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Fireball Level | int Fireball Level |  |  |
| integer2 | 1 | 1 |  |  |
| equal | LEVEL 1 | LEVEL 1 |  |  |
| lessThan | FINISHED | FINISHED |  |  |
| greaterThan | LEVEL 2 | LEVEL 2 |  |  |
| everyFrame | false | false |  |  |

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

_None_

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
| prefab | [Global] [Spell Fluke Black (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Spell Fluke Black (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| amount | 64 | 64 |  |  |
| useExisting | true | true |  |  |

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
| prefab | [Global] [Spell Fluke (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Spell Fluke (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| amount | 36 | 36 |  |  |
| useExisting | true | true |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| State 1 | LEVEL 1 | Pool Normal | 0 | 0 | 0 |
| State 1 | LEVEL 2 | Pool Black | 0 | 0 | 0 |
| State 1 | FINISHED | Idle | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| CHARM EQUIP CHECK | State 1 | 0 | 0 | 0 |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| CANCEL | false |
| CHARM EQUIP CHECK | false |
| LEVEL 1 | false |
| LEVEL 2 | false |

