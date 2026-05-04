# Reactivate After Journal Collected

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Reactivate After Journal Collected |
| GameObject Name | Hunter Eyes |
| GameObject Path |   |
| Source Asset | Hollow Knight/hollow_knight_Data/level137 |
| Start State | Check |
| FSM PathId | 4324 |
| GameObject PathId | 58 |

## Variables

## States

### Check

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

(none)

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| SHINY ITEM GET | Activate Collider | 0 | |

### Activate Collider

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
| SHINY ITEM GET | false |

