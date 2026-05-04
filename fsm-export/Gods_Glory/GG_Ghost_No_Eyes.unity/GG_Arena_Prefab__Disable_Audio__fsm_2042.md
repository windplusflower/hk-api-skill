# Disable Audio

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Disable Audio |
| GameObject Name | GG_Arena_Prefab |
| GameObject Path |   |
| Source Asset | Hollow Knight/hollow_knight_Data/level439 |
| Start State | Check Challenge Type |
| FSM PathId | 2042 |
| GameObject PathId | 522 |

## Variables

## States

### Check Challenge Type

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GGCheckIfBossSequence

Full Name: GGCheckIfBossSequence
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| trueEvent |   | SEQUENCE |   |   |
| falseEvent |   | STATUE |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| SEQUENCE | Inert | 0 | |
| STATUE | Disable | 0 | |

### Inert

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

(none)

#### Transitions

(none)

### Disable

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SetAudioSource

Full Name: HutongGames.PlayMaker.Actions.SetAudioSource
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| active |   | false |   |   |

#### Transitions

(none)

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| SEQUENCE | false |
| STATUE | false |

