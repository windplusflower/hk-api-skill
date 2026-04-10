# Phase 

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Phase  |
| GameObject Name | wispy smoke Phase4 |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/level409.assets |
| Start State | Idle |
| FSM PathId | 2415 |
| GameObject PathId | 348 |

## Variables

## States

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

_None_

### Play

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. PlayParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.PlayParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| emit | 0 | 0 |  |  |

### End

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. StopParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.StopParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Idle | PHASE4 | Play | 0 | 0 | 0 |
| Play | FINAL SUCK | End | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINAL SUCK | false |
| PHASE4 | false |

