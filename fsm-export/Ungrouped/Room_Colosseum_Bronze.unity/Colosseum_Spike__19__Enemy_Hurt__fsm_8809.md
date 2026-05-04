# Enemy Hurt

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Enemy Hurt |
| GameObject Name | Colosseum Spike (19) |
| GameObject Path | Colosseum Manager/Ground Spikes/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level32 |
| Start State | Hurt |
| FSM PathId | 8809 |
| GameObject PathId | 12 |

## Variables

## States

### Hurt

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| fsmName |   | "damages_enemy" | FsmName |   |
| variableName |   | "damageDealt" | FsmInt |   |
| setValue |   | 9999 |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| UNHURT ENEMY | Unhurt | 0 | |

### Unhurt

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| fsmName |   | "damages_enemy" | FsmName |   |
| variableName |   | "damageDealt" | FsmInt |   |
| setValue |   | 0 |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| HURT ENEMY | Hurt | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| HURT ENEMY | false |
| UNHURT ENEMY | false |

