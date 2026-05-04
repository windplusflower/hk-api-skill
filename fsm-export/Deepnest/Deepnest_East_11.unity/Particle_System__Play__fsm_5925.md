# Play

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Play |
| GameObject Name | Particle System |
| GameObject Path | Breakable Wall top/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level315 |
| Start State | State 1 |
| FSM PathId | 5925 |
| GameObject PathId | 1445 |

## Variables

## States

### State 1

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

(none)

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| BREAK | State 2 | 0 | |

### State 2

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
| BREAK | false |

