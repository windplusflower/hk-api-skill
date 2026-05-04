# Play Control

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Play Control |
| GameObject Name | Shake Dust Long (15) |
| GameObject Path | Mantis Floor Gate/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level178 |
| Start State | Idle |
| FSM PathId | 7596 |
| GameObject PathId | 1815 |

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

