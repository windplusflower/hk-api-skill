# FSM

## Summary

| Field | Value |
| --- | --- |
| FSM Name | FSM |
| GameObject Name | Warrior |
| GameObject Path |   |
| Source Asset | Hollow Knight/hollow_knight_Data/level490 |
| Start State | Wait |
| FSM PathId | 1103 |
| GameObject PathId | 195 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Wait Time | 2 | Single: 2 |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Enable GameObject | Warrior/Ghost Warrior Markoth (Hollow Knight/hollow_knight_Data\level490) | NamedAssetPPtr: [Warrior/Ghost Warrior Markoth (Hollow Knight/hollow_knight_Data\level490)] |

## States

### Wait

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. PreSpawnCorpse

Full Name: PreSpawnCorpse
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target |   | OwnerDefault Warrior/Ghost Warrior Markoth | Variable |   |

##### 2. PreBuildTK2DSprites

Full Name: HutongGames.PlayMaker.Actions.PreBuildTK2DSprites
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Warrior/Ghost Warrior Markoth (Hollow Knight/hollow_knight_Data\level490)] |   |   |
| useChildren |   | true |   |   |

##### 3. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | float Wait Time |   |   |
| finishEvent |   | FINISHED |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Enable | 0 | |

### Enable

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer |   | [Global] [Audio Player Actor (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | [Warrior/Ghost Warrior Markoth (Hollow Knight/hollow_knight_Data\level490)] |   |   |
| audioClip |   | [dream_ghost_appear (AudioClip) (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| pitchMin |   | 1f |   |   |
| pitchMax |   | 1f |   |   |
| volume |   | 1f |   |   |
| delay |   | 0f |   |   |
| storePlayer |   |   |   |   |

##### 2. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Dream Impact (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | [Warrior/Ghost Warrior Markoth (Hollow Knight/hollow_knight_Data\level490)] |   |   |
| position |   | Vector3(0, 0, 0) |   |   |
| rotation |   | Vector3(0, 0, 0) |   |   |
| storeObject |   |   | Variable |   |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Enable GameObject |   |   |
| activate |   | true |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

#### Transitions

(none)

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |

