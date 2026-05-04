# Hit Crystals

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Hit Crystals |
| GameObject Name | Mines Crawler (2) |
| GameObject Path |   |
| Source Asset | Hollow Knight/hollow_knight_Data/level273 |
| Start State | Idle |
| FSM PathId | 2500 |
| GameObject PathId | 206 |

## Variables

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Hit Crystals | Mines Crawler (2)/Hit Crystals Effect (Hollow Knight/hollow_knight_Data\level273) | NamedAssetPPtr: [Mines Crawler (2)/Hit Crystals Effect (Hollow Knight/hollow_knight_Data\level273)] |

## States

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Hit Crystals |   |   |
| emission |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| BLOCKED HIT | Fire | 0 | |

### Fire

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 0.1f |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |

##### 2. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Hit Crystals |   |   |
| emission |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Idle | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| BLOCKED HIT | true |
| FINISHED | false |

