# Attacking

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Attacking |
| GameObject Name | Ghost Warrior Markoth |
| GameObject Path | Warrior/ |
| Source Asset | D:/SteamLibrary/steamapps/common/Hollow Knight/hollow_knight_Data/level437 |
| Start State | Init |
| FSM PathId | 1573 |
| GameObject PathId | 73 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Shot Angle | 0 | Single: 0 |

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Double HP | 140 | Int32: 140 |
| HP | 0 | Int32: 0 |
| Repeats | 0 | Int32: 0 |
| Triple HP | 70 | Int32: 70 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Hero Away | false | Boolean: false |
| Rage | false | Boolean: false |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Attack Pt | Warrior/Ghost Warrior Markoth/Attack Pt (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level437) | NamedAssetPPtr: [Warrior/Ghost Warrior Markoth/Attack Pt (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level437)] |
| Self | [null] | NamedAssetPPtr: [null] |
| Shield 1 | [null] | NamedAssetPPtr: [null] |
| Shield 2 | [null] | NamedAssetPPtr: [null] |
| Shot | [null] | NamedAssetPPtr: [null] |

## States

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetOwner

Full Name: HutongGames.PlayMaker.Actions.GetOwner
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeGameObject |   | GameObject Self | Variable |   |

##### 2. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer |   | [Global] [Audio Player Actor (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| audioClip |   | [Markoth_cast_calm (AudioClip) (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\sharedassets314.assets)] |   |   |
| pitchMin |   | 1f |   |   |
| pitchMax |   | 1f |   |   |
| volume |   | 1f |   |   |
| delay |   | 0f |   |   |
| storePlayer |   |   |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| READY | Wait | 0 | |

### Wait

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 4

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Rage | Variable |   |
| isTrue |   | Event(RAGE) |   |   |
| isFalse |   | Event() |   |   |
| everyFrame |   | false |   |   |

##### 2. WaitRandom

Full Name: HutongGames.PlayMaker.Actions.WaitRandom
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| timeMin |   | 1f |   |   |
| timeMax |   | 2f |   |   |
| finishEvent |   | Event(ATTACK) |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED |   | 0 | |
| TOOK DAMAGE |   | 0 | |
| ATTACK | Nail | 0 | |
| RAGE | Wait rage | 0 | |

### Attack Stop

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

(none)

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| ATTACK OK | Wait | 0 | |

### Nail

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Shot Markoth Nail (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\sharedassets314.assets)] |   |   |
| spawnPoint |   |   |   |   |
| position |   | Vector3(0, 0, 0) |   |   |
| rotation |   | Vector3(0, 0, 0) |   |   |
| storeObject |   |   | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Wait | 0 | |

### Wait rage

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. WaitRandom

Full Name: HutongGames.PlayMaker.Actions.WaitRandom
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| timeMin |   | 0.75f |   |   |
| timeMax |   | 1.25f |   |   |
| finishEvent |   | Event(ATTACK) |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Nail | 0 | |

## Global Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| ATTACK STOP | Attack Stop | 0 | |

## Events

| Name | Global |
| --- | --- |
| ATTACK | false |
| ATTACK OK | false |
| ATTACK STOP | false |
| CANCEL | false |
| DOUBLE | false |
| FINISHED | false |
| RAGE | false |
| READY | false |
| REPEAT | false |
| TOOK DAMAGE | false |
| TRIPLE | false |

