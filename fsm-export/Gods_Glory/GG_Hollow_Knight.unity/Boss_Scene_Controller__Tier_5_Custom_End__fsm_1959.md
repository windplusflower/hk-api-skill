# Tier 5 Custom End

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Tier 5 Custom End |
| GameObject Name | Boss Scene Controller |
| GameObject Path |   |
| Source Asset | Hollow Knight/hollow_knight_Data/level447 |
| Start State | Check Tier |
| FSM PathId | 1959 |
| GameObject PathId | 429 |

## Variables

## States

### Check Tier

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GGCheckBossSequenceList

Full Name: GGCheckBossSequenceList
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| tierList |   | [Boss Sequence Tier 5 (Script BossSequence) (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| trueEvent |   | TIER 5 |   |   |
| falseEvent |   | FINISHED |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| TIER 5 | Tier 5 | 0 | |
| FINISHED | Inert | 0 | |

### Inert

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

(none)

#### Transitions

(none)

### Tier 5

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SetProperty

Full Name: HutongGames.PlayMaker.Actions.SetProperty
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| targetProperty |   | Property {[ (Script BossSceneController) (Hollow Knight/hollow_knight_Data\level447)]}.doTransitionOut |   |   |
| everyFrame |   | false |   |   |

#### Transitions

(none)

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| TIER 5 | false |

