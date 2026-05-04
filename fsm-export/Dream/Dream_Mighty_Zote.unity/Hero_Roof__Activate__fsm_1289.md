# Activate

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Activate |
| GameObject Name | Hero Roof |
| GameObject Path |   |
| Source Asset | Hollow Knight/hollow_knight_Data/level399 |
| Start State | Idle |
| FSM PathId | 1289 |
| GameObject PathId | 140 |

## Variables

## States

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

(none)

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FIGHT START | Activate | 0 | |

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
| FIGHT START | false |

