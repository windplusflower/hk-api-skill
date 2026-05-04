# Play Control

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Play Control |
| GameObject Name | Break Dust |
| GameObject Path | mine_break_bridge/ |
| Source Asset | D:/SteamLibrary/steamapps/common/Hollow Knight/hollow_knight_Data/level270 |
| Start State | Idle |
| FSM PathId | 6526 |
| GameObject PathId | 1648 |

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
| SUPERDASH BLAST | Start | 0 | |

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
| MANTIS FLOOR RUMBLE | false |
| SUPERDASH BLAST | false |

