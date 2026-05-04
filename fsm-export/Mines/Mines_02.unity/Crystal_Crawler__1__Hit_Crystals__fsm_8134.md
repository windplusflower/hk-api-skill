# Hit Crystals

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Hit Crystals |
| GameObject Name | Crystal Crawler (1) |
| GameObject Path |   |
| Source Asset | Hollow Knight/hollow_knight_Data/level249 |
| Start State | Idle |
| FSM PathId | 8134 |
| GameObject PathId | 617 |

## Variables

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Hit Crystals | Crystal Crawler (1)/Hit Crystals Effect (Hollow Knight/hollow_knight_Data\level249) | NamedAssetPPtr: [Crystal Crawler (1)/Hit Crystals Effect (Hollow Knight/hollow_knight_Data\level249)] |

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
| BLOCKED HIT | Particle effect | 0 | |

### Particle effect

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. PlayParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.PlayParticleEmitter
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Hit Crystals |   |   |
| emit |   | 0 |   |   |

##### 2. SetParticleEmissionRate

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmissionRate
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| emissionRate |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 3. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Hit Crystals |   |   |
| emission |   | true |   |   |

##### 4. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 0.1f |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |

##### 5. AudioPlaySimple

Full Name: HutongGames.PlayMaker.Actions.AudioPlaySimple
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| volume |   | 1f |   |   |
| oneShotClip |   | [mines_crawler_hit_top (AudioClip) (Hollow Knight/hollow_knight_Data\sharedassets249.assets)] |   |   |

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

