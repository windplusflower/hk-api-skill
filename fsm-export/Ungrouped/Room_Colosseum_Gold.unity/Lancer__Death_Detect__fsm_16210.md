# Death Detect

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Death Detect |
| GameObject Name | Lancer |
| GameObject Path | Colosseum Manager/Waves/Lobster Lancer/Entry Object/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level34 |
| Start State | Idle |
| FSM PathId | 16210 |
| GameObject PathId | 4570 |

## Variables

## States

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

(none)

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| LOBSTER KILLED | Set | 0 | |
| ZERO HP | Set | 0 | |

### Set

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| fsmName |   | "Control" | FsmName |   |
| variableName |   | "Death" | FsmBool |   |
| setValue |   | true |   |   |
| everyFrame |   | false |   |   |

##### 2. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| fsmName |   | "recoil" | FsmName |   |
| variableName |   | "Recoil per second" | FsmInt |   |
| setValue |   | 0 |   |   |
| everyFrame |   | false |   |   |

#### Transitions

(none)

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| LOBSTER KILLED | false |
| ZERO HP | false |

