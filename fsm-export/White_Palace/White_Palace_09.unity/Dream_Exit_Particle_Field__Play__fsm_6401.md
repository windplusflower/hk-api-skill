# Play

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Play |
| GameObject Name | Dream Exit Particle Field |
| GameObject Path |   |
| Source Asset | Hollow Knight/hollow_knight_Data/level373 |
| Start State | Idle |
| FSM PathId | 6401 |
| GameObject PathId | 2144 |

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
| WHITE PALACE END | Play | 0 | |

### Play

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
| WHITE PALACE END | false |

