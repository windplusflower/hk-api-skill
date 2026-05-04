# set_thorn_damage

## Summary

| Field | Value |
| --- | --- |
| FSM Name | set_thorn_damage |
| GameObject Name | Hit R |
| GameObject Path | Knight/Charm Effects/Thorn Hit/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level4 |
| Start State | Set |
| FSM PathId | 1071 |
| GameObject PathId | 98 |

## Variables

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Damage | 0 | Int32: 0 |

## States

### Set

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| intName |   | "nailDamage" |   |   |
| storeValue |   | int Damage | Variable |   |

##### 2. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| fsmName |   | "damages_enemy" | FsmName |   |
| variableName |   | "damageDealt" | FsmInt |   |
| setValue |   | int Damage |   |   |
| everyFrame |   | false |   |   |

#### Transitions

(none)

## Global Transitions

(none)

## Events

(none)

