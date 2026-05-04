# Play Control

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Play Control |
| GameObject Name | Shake Dust Long (1) |
| GameObject Path |   |
| Source Asset | Hollow Knight/hollow_knight_Data/level80 |
| Start State | Idle |
| FSM PathId | 819 |
| GameObject PathId | 43 |

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
| MANTIS FLOOR FINISH | Start | 0 | |

### Start

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. PlayParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.PlayParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| emit |   | 0 |   |   |

#### Transitions

(none)

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| MANTIS FLOOR FINISH | false |
| MANTIS FLOOR RUMBLE | false |

