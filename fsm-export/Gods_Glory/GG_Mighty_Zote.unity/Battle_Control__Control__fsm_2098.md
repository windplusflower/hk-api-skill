# Control

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Control |
| GameObject Name | Battle Control |
| GameObject Path |   |
| Source Asset | Hollow Knight/hollow_knight_Data/level481 |
| Start State | Init |
| FSM PathId | 2098 |
| GameObject PathId | 226 |

## Variables

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Kills | 0 | Int32: 0 |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Balloon | Battle Control/Zote Balloon Ordeal (Hollow Knight/hollow_knight_Data\level481) | NamedAssetPPtr: [Battle Control/Zote Balloon Ordeal (Hollow Knight/hollow_knight_Data\level481)] |
| Dormant Warriors | Battle Control/Dormant Warriors (Hollow Knight/hollow_knight_Data\level481) | NamedAssetPPtr: [Battle Control/Dormant Warriors (Hollow Knight/hollow_knight_Data\level481)] |
| Extra Zotes | Battle Control/Extra Zotes (Hollow Knight/hollow_knight_Data\level481) | NamedAssetPPtr: [Battle Control/Extra Zotes (Hollow Knight/hollow_knight_Data\level481)] |
| Fat 1 | Battle Control/Fat Zotes/Zote Crew Fat (1) (Hollow Knight/hollow_knight_Data\level481) | NamedAssetPPtr: [Battle Control/Fat Zotes/Zote Crew Fat (1) (Hollow Knight/hollow_knight_Data\level481)] |
| Fat 2 | Battle Control/Fat Zotes/Zote Crew Fat (2) (Hollow Knight/hollow_knight_Data\level481) | NamedAssetPPtr: [Battle Control/Fat Zotes/Zote Crew Fat (2) (Hollow Knight/hollow_knight_Data\level481)] |
| Fat 3 | Battle Control/Fat Zotes/Zote Crew Fat (3) (Hollow Knight/hollow_knight_Data\level481) | NamedAssetPPtr: [Battle Control/Fat Zotes/Zote Crew Fat (3) (Hollow Knight/hollow_knight_Data\level481)] |
| First Zote | Battle Control/First Zote (Hollow Knight/hollow_knight_Data\level481) | NamedAssetPPtr: [Battle Control/First Zote (Hollow Knight/hollow_knight_Data\level481)] |
| Music | Battle Control/Music (Hollow Knight/hollow_knight_Data\level481) | NamedAssetPPtr: [Battle Control/Music (Hollow Knight/hollow_knight_Data\level481)] |
| Music Initial | Battle Control/Music Initial (Hollow Knight/hollow_knight_Data\level481) | NamedAssetPPtr: [Battle Control/Music Initial (Hollow Knight/hollow_knight_Data\level481)] |
| Tall 1 | Battle Control/Tall Zotes/Zote Crew Tall (Hollow Knight/hollow_knight_Data\level481) | NamedAssetPPtr: [Battle Control/Tall Zotes/Zote Crew Tall (Hollow Knight/hollow_knight_Data\level481)] |
| Tall 2 | Battle Control/Tall Zotes/Zote Crew Tall (1) (Hollow Knight/hollow_knight_Data\level481) | NamedAssetPPtr: [Battle Control/Tall Zotes/Zote Crew Tall (1) (Hollow Knight/hollow_knight_Data\level481)] |
| Thwomp 1 | Battle Control/Zote Thwomp (Hollow Knight/hollow_knight_Data\level481) | NamedAssetPPtr: [Battle Control/Zote Thwomp (Hollow Knight/hollow_knight_Data\level481)] |
| Title | Battle Control/Title (Hollow Knight/hollow_knight_Data\level481) | NamedAssetPPtr: [Battle Control/Title (Hollow Knight/hollow_knight_Data\level481)] |
| Zote Fluke | Battle Control/Zote Fluke (Hollow Knight/hollow_knight_Data\level481) | NamedAssetPPtr: [Battle Control/Zote Fluke (Hollow Knight/hollow_knight_Data\level481)] |
| Zote Salubra | Battle Control/Zote Salubra (Hollow Knight/hollow_knight_Data\level481) | NamedAssetPPtr: [Battle Control/Zote Salubra (Hollow Knight/hollow_knight_Data\level481)] |
| Zoteling 1 | Battle Control/Zotelings/Ordeal Zoteling (Hollow Knight/hollow_knight_Data\level481) | NamedAssetPPtr: [Battle Control/Zotelings/Ordeal Zoteling (Hollow Knight/hollow_knight_Data\level481)] |
| Zoteling 2 | Battle Control/Zotelings/Ordeal Zoteling (1) (Hollow Knight/hollow_knight_Data\level481) | NamedAssetPPtr: [Battle Control/Zotelings/Ordeal Zoteling (1) (Hollow Knight/hollow_knight_Data\level481)] |

## States

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

(none)

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Start Pause | 0 | |

### Start Pause

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 2f |   |   |
| finishEvent |   | FINISHED |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Open Cage | 0 | |

### Open Cage

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer |   | [Global] [Audio Player Actor (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | [Battle Control/First Zote (Hollow Knight/hollow_knight_Data\level481)] |   |   |
| audioClip |   | [col_cage_open (AudioClip) (Hollow Knight/hollow_knight_Data\sharedassets32.assets)] |   |   |
| pitchMin |   | 1f |   |   |
| pitchMax |   | 1f |   |   |
| volume |   | 1f |   |   |
| delay |   | 0f |   |   |
| storePlayer |   |   |   |   |

##### 2. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer |   | [Global] [Audio Player Actor (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | [Battle Control/First Zote (Hollow Knight/hollow_knight_Data\level481)] |   |   |
| audioClip |   | [Zote_ceiling_drop_02 (AudioClip) (Hollow Knight/hollow_knight_Data\sharedassets399.assets)] |   |   |
| pitchMin |   | 1f |   |   |
| pitchMax |   | 1f |   |   |
| volume |   | 1f |   |   |
| delay |   | 0f |   |   |
| storePlayer |   |   |   |   |

##### 3. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 1f |   |   |
| finishEvent |   | FINISHED |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | First Zote | 0 | |

### First Zote

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault First Zote |   |   |
| activate |   | true |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 2. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 1.5f |   |   |
| finishEvent |   | FINISHED |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Music Init | 0 | |

### Start Warriors

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Dormant Warriors |   |   |
| sendEvent |   | "START" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):FSM Owner |   |   |
| sendEvent |   | "ZOTE WARRIOR KILLED" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 3. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Kills |   |   |
| integer2 |   | 2 |   |   |
| equal |   | NEXT |   |   |
| lessThan |   |   |   |   |
| greaterThan |   | NEXT |   |   |
| everyFrame |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| NEXT | Add Zoteling | 0 | |

### Add Warrior 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Dormant Warriors |   |   |
| fsmName |   | "Spawn" | FsmName |   |
| variableName |   | "Active Max" | FsmInt |   |
| setValue |   | 2 |   |   |
| everyFrame |   | false |   |   |

##### 2. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Kills |   |   |
| integer2 |   | 5 |   |   |
| equal |   | NEXT |   |   |
| lessThan |   |   |   |   |
| greaterThan |   | NEXT |   |   |
| everyFrame |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| NEXT | Add Fatties | 0 | |

### Add Fatties

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Kills |   |   |
| integer2 |   | 15 |   |   |
| equal |   | NEXT |   |   |
| lessThan |   |   |   |   |
| greaterThan |   | NEXT |   |   |
| everyFrame |   | true |   |   |

##### 2. SetParent

Full Name: HutongGames.PlayMaker.Actions.SetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Fat 1 |   |   |
| parent |   | [Battle Control/Dormant Warriors (Hollow Knight/hollow_knight_Data\level481)] |   |   |
| resetLocalPosition |   | false |   |   |
| resetLocalRotation |   | false |   |   |

##### 3. SetParent

Full Name: HutongGames.PlayMaker.Actions.SetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Fat 2 |   |   |
| parent |   | [Battle Control/Dormant Warriors (Hollow Knight/hollow_knight_Data\level481)] |   |   |
| resetLocalPosition |   | false |   |   |
| resetLocalRotation |   | false |   |   |

##### 4. SetParent

Full Name: HutongGames.PlayMaker.Actions.SetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Fat 3 |   |   |
| parent |   | [Battle Control/Dormant Warriors (Hollow Knight/hollow_knight_Data\level481)] |   |   |
| resetLocalPosition |   | false |   |   |
| resetLocalRotation |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| NEXT | Add Turret | 0 | |

### Add Zoteling

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Zoteling 1 |   |   |
| sendEvent |   | "SPAWN" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 2. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Kills |   |   |
| integer2 |   | 8 |   |   |
| equal |   | NEXT |   |   |
| lessThan |   |   |   |   |
| greaterThan |   | NEXT |   |   |
| everyFrame |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| NEXT | Add Fatties | 0 | |

### Add Turret

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Kills |   |   |
| integer2 |   | 20 |   |   |
| equal |   | NEXT |   |   |
| lessThan |   |   |   |   |
| greaterThan |   | NEXT |   |   |
| everyFrame |   | true |   |   |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Extra Zotes |   |   |
| sendEvent |   | "START" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| NEXT | Add Tall | 0 | |

### Add Tall

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Kills |   |   |
| integer2 |   | 25 |   |   |
| equal |   | NEXT |   |   |
| lessThan |   |   |   |   |
| greaterThan |   | NEXT |   |   |
| everyFrame |   | true |   |   |

##### 2. SetParent

Full Name: HutongGames.PlayMaker.Actions.SetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Tall 1 |   |   |
| parent |   | [Battle Control/Dormant Warriors (Hollow Knight/hollow_knight_Data\level481)] |   |   |
| resetLocalPosition |   | false |   |   |
| resetLocalRotation |   | false |   |   |

##### 3. SetParent

Full Name: HutongGames.PlayMaker.Actions.SetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Tall 2 |   |   |
| parent |   | [Battle Control/Dormant Warriors (Hollow Knight/hollow_knight_Data\level481)] |   |   |
| resetLocalPosition |   | false |   |   |
| resetLocalRotation |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| NEXT | Add Thwomp | 0 | |

### Add Balloon

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Kills |   |   |
| integer2 |   | 35 |   |   |
| equal |   | NEXT |   |   |
| lessThan |   |   |   |   |
| greaterThan |   | NEXT |   |   |
| everyFrame |   | true |   |   |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Balloon |   |   |
| sendEvent |   | "BALLOON SPAWN" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| NEXT | Add Fluke | 0 | |

### Add Thwomp

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Kills |   |   |
| integer2 |   | 30 |   |   |
| equal |   | NEXT |   |   |
| lessThan |   |   |   |   |
| greaterThan |   | NEXT |   |   |
| everyFrame |   | true |   |   |

##### 2. SetParent

Full Name: HutongGames.PlayMaker.Actions.SetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Thwomp 1 |   |   |
| parent |   | [Battle Control/Extra Zotes (Hollow Knight/hollow_knight_Data\level481)] |   |   |
| resetLocalPosition |   | false |   |   |
| resetLocalRotation |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| NEXT | Add Balloon | 0 | |

### Add Zoteling 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Zoteling 2 |   |   |
| sendEvent |   | "SPAWN" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 2. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Kills |   |   |
| integer2 |   | 57 |   |   |
| equal |   | NEXT |   |   |
| lessThan |   |   |   |   |
| greaterThan |   | NEXT |   |   |
| everyFrame |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| NEXT | Menu Unlock | 0 | |

### Add Ghost

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Kills |   |   |
| integer2 |   | 52 |   |   |
| equal |   | NEXT |   |   |
| lessThan |   |   |   |   |
| greaterThan |   | NEXT |   |   |
| everyFrame |   | true |   |   |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Zote Salubra |   |   |
| sendEvent |   | "START" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| NEXT | Add Zoteling 2 | 0 | |

### Add Fluke

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Kills |   |   |
| integer2 |   | 40 |   |   |
| equal |   | NEXT |   |   |
| lessThan |   |   |   |   |
| greaterThan |   | NEXT |   |   |
| everyFrame |   | true |   |   |

##### 2. SetParent

Full Name: HutongGames.PlayMaker.Actions.SetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Zote Fluke |   |   |
| parent |   | [Battle Control/Extra Zotes (Hollow Knight/hollow_knight_Data\level481)] |   |   |
| resetLocalPosition |   | false |   |   |
| resetLocalRotation |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| NEXT | Add Ghost | 0 | |

### Add Warrior 3

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Dormant Warriors |   |   |
| fsmName |   | "Spawn" | FsmName |   |
| variableName |   | "Active Max" | FsmInt |   |
| setValue |   | 3 |   |   |
| everyFrame |   | false |   |   |

##### 2. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Kills |   |   |
| integer2 |   | 50 |   |   |
| equal |   | NEXT |   |   |
| lessThan |   |   |   |   |
| greaterThan |   | NEXT |   |   |
| everyFrame |   | true |   |   |

#### Transitions

(none)

### Menu Unlock

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. MenuStyleUnlockAction

Full Name: MenuStyleUnlockAction
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| unlockKey |   | "eternalOrdealMenu" |   |   |

##### 2. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName |   | "ordealAchieved" |   |   |
| value |   | true |   |   |

##### 3. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Kills |   |   |
| integer2 |   | 80 |   |   |
| equal |   | NEXT |   |   |
| lessThan |   |   |   |   |
| greaterThan |   | NEXT |   |   |
| everyFrame |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Add Warrior 3 | 0 | |

### Music Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. AudioPlaySimple

Full Name: HutongGames.PlayMaker.Actions.AudioPlaySimple
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Music Initial |   |   |
| volume |   | 1f |   |   |
| oneShotClip |   | [] |   |   |

##### 2. TransitionToAudioSnapshot

Full Name: HutongGames.PlayMaker.Actions.TransitionToAudioSnapshot
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| snapshot |   | [Normal (AudioMixerSnapshotController) (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| transitionTime |   | 0f |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FIRST ZOTE END | Title Zoom 3 | 0 | |

### Title Zoom 1

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Title |   |   |
| activate |   | true |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 2. SetScale

Full Name: HutongGames.PlayMaker.Actions.SetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Title |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0.57f |   |   |
| y |   | 0.57f |   |   |
| z |   | 0f |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

##### 3. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer |   | [Global] [Audio Player Actor 2D (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | [Global] GameObject Hero |   |   |
| audioClip |   | [col_moving_wall_impact_into_place (AudioClip) (Hollow Knight/hollow_knight_Data\sharedassets32.assets)] |   |   |
| pitchMin |   | 0.9f |   |   |
| pitchMax |   | 0.9f |   |   |
| volume |   | 1f |   |   |
| delay |   | 0f |   |   |
| storePlayer |   |   |   |   |

##### 4. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 0.5f |   |   |
| finishEvent |   | FINISHED |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Title Zoom 2 | 0 | |

### Title Zoom 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetScale

Full Name: HutongGames.PlayMaker.Actions.SetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Title |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 1.41f |   |   |
| y |   | 1.41f |   |   |
| z |   | 0f |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

##### 2. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer |   | [Global] [Audio Player Actor 2D (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | [Global] GameObject Hero |   |   |
| audioClip |   | [col_moving_wall_impact_into_place (AudioClip) (Hollow Knight/hollow_knight_Data\sharedassets32.assets)] |   |   |
| pitchMin |   | 0.9f |   |   |
| pitchMax |   | 0.9f |   |   |
| volume |   | 1f |   |   |
| delay |   | 0f |   |   |
| storePlayer |   |   |   |   |

##### 3. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 0.5f |   |   |
| finishEvent |   | FINISHED |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Title Zoom 3 | 0 | |

### Title Zoom 3

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetScale

Full Name: HutongGames.PlayMaker.Actions.SetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Title |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 2.38f |   |   |
| y |   | 2.38f |   |   |
| z |   | 0f |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

##### 2. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer |   | [Global] [Audio Player Actor 2D (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | [Global] GameObject Hero |   |   |
| audioClip |   | [boss_explode_clean (AudioClip) (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| pitchMin |   | 1f |   |   |
| pitchMax |   | 1f |   |   |
| volume |   | 1f |   |   |
| delay |   | 0f |   |   |
| storePlayer |   |   |   |   |

##### 3. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer |   | [Global] [Audio Player Actor 2D (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | [Global] GameObject Hero |   |   |
| audioClip |   | [explosion_1 (AudioClip) (Hollow Knight/hollow_knight_Data\sharedassets236.assets)] |   |   |
| pitchMin |   | 1f |   |   |
| pitchMax |   | 1f |   |   |
| volume |   | 1f |   |   |
| delay |   | 0f |   |   |
| storePlayer |   |   |   |   |

##### 4. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 2.5f |   |   |
| finishEvent |   | FINISHED |   |   |
| realTime |   | false |   |   |

##### 5. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Title |   |   |
| activate |   | true |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Crash Out | 0 | |

### Crash Out

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer |   | [Global] [Audio Player Actor 2D (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | [Global] GameObject Hero |   |   |
| audioClip |   | [col_moving_wall_impact_into_place (AudioClip) (Hollow Knight/hollow_knight_Data\sharedassets32.assets)] |   |   |
| pitchMin |   | 1.15f |   |   |
| pitchMax |   | 1.15f |   |   |
| volume |   | 1f |   |   |
| delay |   | 0f |   |   |
| storePlayer |   |   |   |   |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):FSM Owner |   |   |
| sendEvent |   | "ZOTE WARRIOR KILLED" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 3. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer |   | [Global] [Audio Player Actor 2D (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | [Global] GameObject Hero |   |   |
| audioClip |   | [boss_explode_clean (AudioClip) (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| pitchMin |   | 1f |   |   |
| pitchMax |   | 1f |   |   |
| volume |   | 1f |   |   |
| delay |   | 0f |   |   |
| storePlayer |   |   |   |   |

##### 4. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Title |   |   |
| activate |   | false |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 5. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(BroadcastAll):FSM Owner |   |   |
| sendEvent |   | "CORPSE END" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 6. AudioPlaySimple

Full Name: HutongGames.PlayMaker.Actions.AudioPlaySimple
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Music |   |   |
| volume |   | 0.8f |   |   |
| oneShotClip |   | [] |   |   |

##### 7. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 2.25f |   |   |
| finishEvent |   | FINISHED |   |   |
| realTime |   | false |   |   |

##### 8. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):CameraParent |   |   |
| sendEvent |   | "BigShake" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Start Warriors | 0 | |

### Music

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. AudioPlaySimple

Full Name: HutongGames.PlayMaker.Actions.AudioPlaySimple
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Music |   |   |
| volume |   | 0.8f |   |   |
| oneShotClip |   | [] |   |   |

##### 2. TransitionToAudioSnapshot

Full Name: HutongGames.PlayMaker.Actions.TransitionToAudioSnapshot
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| snapshot |   | [Normal (AudioMixerSnapshotController) (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| transitionTime |   | 0f |   |   |

##### 3. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 1f |   |   |
| finishEvent |   | FINISHED |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Crash Out | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| FIRST ZOTE END | false |
| NEXT | false |

