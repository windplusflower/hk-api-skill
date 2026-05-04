# Control

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Control |
| GameObject Name | Music Control |
| GameObject Path | Colosseum Manager/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level33 |
| Start State | Idle |
| FSM PathId | 11252 |
| GameObject PathId | 3362 |

## Variables

### Objects

| Name | Value | Raw/Type |
| --- | --- | --- |
| New Track | [null] | NamedAssetPPtr: [null] |

## States

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

(none)

#### Transitions

(none)

### Sting

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. AudioStop

Full Name: HutongGames.PlayMaker.Actions.AudioStop
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |

##### 2. SetAudioVolume

Full Name: HutongGames.PlayMaker.Actions.SetAudioVolume
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| volume |   | 1f |   |   |
| everyFrame |   | false |   |   |

##### 3. AudioPlaySimple

Full Name: HutongGames.PlayMaker.Actions.AudioPlaySimple
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| volume |   | 1f |   |   |
| oneShotClip |   | [S57 COLOSSEUM STING (AudioClip) (Hollow Knight/hollow_knight_Data\sharedassets32.assets)] |   |   |

#### Transitions

(none)

### Set Music 1

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetObjectValue

Full Name: HutongGames.PlayMaker.Actions.SetObjectValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| objectVariable |   | object New Track | Variable |   |
| objectValue |   | [S57 COLOSSEUM INTENSITY 1 (AudioClip) (Hollow Knight/hollow_knight_Data\sharedassets32.assets)] |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Music Fade | 0 | |

### Music Fade

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. FadeAudio

Full Name: HutongGames.PlayMaker.Actions.FadeAudio
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| startVolume |   | 1f |   |   |
| endVolume |   | 0f |   |   |
| time |   | 0.25f |   |   |

##### 2. Wait

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
| FINISHED | New Track | 0 | |

### New Track

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. AudioStop

Full Name: HutongGames.PlayMaker.Actions.AudioStop
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |

##### 2. SetAudioClip

Full Name: HutongGames.PlayMaker.Actions.SetAudioClip
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| audioClip |   | object New Track |   |   |

##### 3. AudioPlaySimple

Full Name: HutongGames.PlayMaker.Actions.AudioPlaySimple
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| volume |   | 1f |   |   |
| oneShotClip |   | [] |   |   |

#### Transitions

(none)

### Set Music 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetObjectValue

Full Name: HutongGames.PlayMaker.Actions.SetObjectValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| objectVariable |   | object New Track | Variable |   |
| objectValue |   | [S57 COLOSSEUM INTENSITY 2 (AudioClip) (Hollow Knight/hollow_knight_Data\sharedassets32.assets)] |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Music Fade | 0 | |

### None

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. FadeAudio

Full Name: HutongGames.PlayMaker.Actions.FadeAudio
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| startVolume |   | 1f |   |   |
| endVolume |   | 0f |   |   |
| time |   | 0.25f |   |   |

##### 2. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 0.25f |   |   |
| finishEvent |   | FINISHED |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | State 1 | 0 | |

### Set Music 3

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetObjectValue

Full Name: HutongGames.PlayMaker.Actions.SetObjectValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| objectVariable |   | object New Track | Variable |   |
| objectValue |   | [S57 COLOSSEUM INTENSITY 3 (AudioClip) (Hollow Knight/hollow_knight_Data\sharedassets32.assets)] |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Music Fade | 0 | |

### Set Music 4

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetObjectValue

Full Name: HutongGames.PlayMaker.Actions.SetObjectValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| objectVariable |   | object New Track | Variable |   |
| objectValue |   | [S57 COLOSSEUM INTENSITY 4 (AudioClip) (Hollow Knight/hollow_knight_Data\sharedassets32.assets)] |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Music Fade | 0 | |

### Set Music 5

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetObjectValue

Full Name: HutongGames.PlayMaker.Actions.SetObjectValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| objectVariable |   | object New Track | Variable |   |
| objectValue |   | [S57 COLOSSEUM INTENSITY 5 (AudioClip) (Hollow Knight/hollow_knight_Data\sharedassets32.assets)] |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Music Fade | 0 | |

### Set Music 6

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetObjectValue

Full Name: HutongGames.PlayMaker.Actions.SetObjectValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| objectVariable |   | object New Track | Variable |   |
| objectValue |   | [S57 COLOSSEUM INTENSITY 6 (AudioClip) (Hollow Knight/hollow_knight_Data\sharedassets32.assets)] |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Music Fade | 0 | |

### Sting Delay Long

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Wait

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
| FINISHED | Sting | 0 | |

### State 1

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. AudioStop

Full Name: HutongGames.PlayMaker.Actions.AudioStop
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |

#### Transitions

(none)

### Sting Pause

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 0.25f |   |   |
| finishEvent |   | FINISHED |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Sting | 0 | |

### Hero Death

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. FinishFSM

Full Name: HutongGames.PlayMaker.Actions.FinishFSM
Enabled: true

#### Transitions

(none)

## Global Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| MUSIC 6 | Set Music 6 | 0 | |
| MUSIC 5 | Set Music 5 | 0 | |
| MUSIC 4 | Set Music 4 | 0 | |
| MUSIC 3 | Set Music 3 | 0 | |
| MUSIC 2 | Set Music 2 | 0 | |
| MUSIC 1 | Set Music 1 | 0 | |
| MUSIC SILENT | None | 0 | |
| MUSIC STING DELAY | Sting Delay Long | 0 | |
| MUSIC STING | Sting Pause | 0 | |
| HERO LEAVE | Hero Death | 0 | |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| HERO LEAVE | false |
| MUSIC 1 | false |
| MUSIC 2 | false |
| MUSIC 3 | false |
| MUSIC 4 | false |
| MUSIC 5 | false |
| MUSIC 6 | false |
| MUSIC SILENT | false |
| MUSIC STING | false |
| MUSIC STING DELAY | false |

