# Superdash Blast

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Superdash Blast |
| GameObject Name | Glow |
| GameObject Path | Super Dash Get/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level270 |
| Start State | Idle |
| FSM PathId | 6465 |
| GameObject PathId | 1337 |

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
| SUPERDASH BLAST | Destroy | 0 | |

### Destroy

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. DestroySelf

Full Name: HutongGames.PlayMaker.Actions.DestroySelf
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| detachChildren |   | false |   |   |

#### Transitions

(none)

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| SUPERDASH BLAST | false |

