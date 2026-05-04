# Open

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Open |
| GameObject Name | Halfway Glow |
| GameObject Path | Grimm Control/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level444 |
| Start State | Init |
| FSM PathId | 2415 |
| GameObject PathId | 313 |

## Variables

## States

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

(none)

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| HEART HALFWAY | Open | 0 | |

### Open

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. FadeGroupUp

Full Name: FadeGroupUp
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target |   | OwnerDefault FSM Owner | Variable |   |

#### Transitions

(none)

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| HEART HALFWAY | false |

