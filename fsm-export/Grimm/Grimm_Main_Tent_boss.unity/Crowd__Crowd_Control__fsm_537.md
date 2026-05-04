# Crowd Control

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Crowd Control |
| GameObject Name | Crowd |
| GameObject Path |   |
| Source Asset | Hollow Knight/hollow_knight_Data/level392 |
| Start State | Init |
| FSM PathId | 537 |
| GameObject PathId | 14 |

## Variables

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Clap | [null] | NamedAssetPPtr: [null] |
| Idle | [null] | NamedAssetPPtr: [null] |
| Murmur | [null] | NamedAssetPPtr: [null] |
| Still | [null] | NamedAssetPPtr: [null] |

## States

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Clap" |   |   |
| storeResult |   | GameObject Clap | Variable |   |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Idle" |   |   |
| storeResult |   | GameObject Idle | Variable |   |

##### 3. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Still" |   |   |
| storeResult |   | GameObject Still | Variable |   |

##### 4. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Murmur" |   |   |
| storeResult |   | GameObject Murmur | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Idle | 0 | |

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Idle |   |   |
| activate |   | true |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 2. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Clap |   |   |
| activate |   | false |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Still |   |   |
| activate |   | false |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 4. FadeAudio

Full Name: HutongGames.PlayMaker.Actions.FadeAudio
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| startVolume |   | 1f |   |   |
| endVolume |   | 0f |   |   |
| time |   | 1f |   |   |

#### Transitions

(none)

### Clap

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 3.6f |   |   |
| finishEvent |   | FINISHED |   |   |
| realTime |   | false |   |   |

##### 2. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Idle |   |   |
| activate |   | false |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Clap |   |   |
| activate |   | true |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 4. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Still |   |   |
| activate |   | false |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 5. FadeAudio

Full Name: HutongGames.PlayMaker.Actions.FadeAudio
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| startVolume |   | 0f |   |   |
| endVolume |   | 1f |   |   |
| time |   | 0.5f |   |   |

##### 6. AudioPlaySimple

Full Name: HutongGames.PlayMaker.Actions.AudioPlaySimple
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| volume |   | 0f |   |   |
| oneShotClip |   | [] |   |   |

##### 7. AudioStop

Full Name: HutongGames.PlayMaker.Actions.AudioStop
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Murmur |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Play Murmur | 0 | |

### Still

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Idle |   |   |
| activate |   | false |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 2. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Clap |   |   |
| activate |   | false |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Still |   |   |
| activate |   | true |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 4. AudioStop

Full Name: HutongGames.PlayMaker.Actions.AudioStop
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Murmur |   |   |

#### Transitions

(none)

### Delay

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 1.15f |   |   |
| finishEvent |   | FINISHED |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Clap | 0 | |

### Play Murmur

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. AudioPlaySimple

Full Name: HutongGames.PlayMaker.Actions.AudioPlaySimple
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Murmur |   |   |
| volume |   | 1f |   |   |
| oneShotClip |   | [] |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Idle | 0 | |

### Go Silent

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. FadeAudio

Full Name: HutongGames.PlayMaker.Actions.FadeAudio
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Murmur |   |   |
| startVolume |   | 1f |   |   |
| endVolume |   | 0f |   |   |
| time |   | 1f |   |   |

#### Transitions

(none)

## Global Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| CROWD CLAP | Clap | 0 | |
| CROWD STILL | Still | 0 | |
| CROWD IDLE | Idle | 0 | |
| CROWD CLAP DELAY | Delay | 0 | |
| BATTLE END | Go Silent | 0 | |

## Events

| Name | Global |
| --- | --- |
| BATTLE END | false |
| CROWD CLAP | false |
| CROWD CLAP DELAY | false |
| CROWD IDLE | false |
| CROWD STILL | false |
| FINISHED | false |

