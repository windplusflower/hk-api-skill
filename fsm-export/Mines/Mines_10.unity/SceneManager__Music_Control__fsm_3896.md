# Music Control

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Music Control |
| GameObject Name | _SceneManager |
| GameObject Path |   |
| Source Asset | Hollow Knight/hollow_knight_Data/level255 |
| Start State | Pause Frame |
| FSM PathId | 3896 |
| GameObject PathId | 503 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Delay | 0 | Single: 0 |
| Transition Time | 2 | Single: 2 |

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| Track Event | CRYSTAL | String: CRYSTAL |

### Objects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Music Snapshot | [Normal (AudioMixerSnapshotController) (Hollow Knight/hollow_knight_Data\resources.assets)] | NamedAssetPPtr: [Normal (AudioMixerSnapshotController) (Hollow Knight/hollow_knight_Data\resources.assets)] |

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
| FINISHED | Delay | 0 | |

### Pause Frame

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. NextFrameEvent

Full Name: HutongGames.PlayMaker.Actions.NextFrameEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent |   | Event(FINISHED) |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Init | 0 | |

### Start

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. TransitionToAudioSnapshot

Full Name: HutongGames.PlayMaker.Actions.TransitionToAudioSnapshot
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| snapshot |   | object Music Snapshot = [Normal (AudioMixerSnapshotController) (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| transitionTime |   | float Transition Time |   |   |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):AudioManager |   |   |
| sendEvent |   | string Track Event = "CROSSROADS" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| EXIT | Started | 0 | |

### Started

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

(none)

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| EXIT |   | 0 | |

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
| time |   | float Delay |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Start | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| ENTER | false |
| EXIT | false |
| FINISHED | false |

