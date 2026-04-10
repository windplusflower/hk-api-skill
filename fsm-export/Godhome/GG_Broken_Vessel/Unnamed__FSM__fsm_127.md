# FSM

## Summary

| Field | Value |
| --- | --- |
| FSM Name | FSM |
| GameObject Name | Unnamed |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets425.assets |
| Start State | Init |
| FSM PathId | 127 |
| GameObject PathId |  |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Delay | 0.5 | Single: 0.5 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Has Remix | false | Boolean: false |
| SkipIfNotStatue | false | Boolean: false |
| Wait For Event | false | Boolean: false |

### Objects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Audio Snapshot | Normal (AudioMixerSnapshotController) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets) | NamedAssetPPtr: Normal (AudioMixerSnapshotController) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets) |
| MusicCue | [null] | NamedAssetPPtr:  |
| StatueRegularMusicCue | [null] | NamedAssetPPtr:  |
| StatueRegularSnapshot | Normal (AudioMixerSnapshotController) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets) | NamedAssetPPtr: Normal (AudioMixerSnapshotController) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets) |
| StatueRemixMusicCue | [null] | NamedAssetPPtr:  |
| StatueRemixSnapshot | Normal (AudioMixerSnapshotController) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets) | NamedAssetPPtr: Normal (AudioMixerSnapshotController) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets) |

## States

### Boss Sequence

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | float Delay | float Delay |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

##### 2. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Wait For Event | bool Wait For Event | Variable |  |
| isTrue | EVENT | EVENT |  |  |
| isFalse |  |  |  |  |
| everyFrame | false | false |  |  |

### Transition Down

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor 2D (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor 2D (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | [Global] GameObject Hero | [Global] GameObject Hero |  |  |
| audioClip | [GG9_transition_0.5_second (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets425.assets)] | [GG9_transition_0.5_second (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets425.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 2. TransitionToAudioSnapshot

Full Name: HutongGames.PlayMaker.Actions.TransitionToAudioSnapshot
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| snapshot | [Silent (AudioMixerSnapshotController) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Silent (AudioMixerSnapshotController) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| transitionTime | 0.5f | 0.5f |  |  |

##### 3. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.5f | 0.5f |  |  |
| finishEvent | END | END |  |  |
| realTime | false | false |  |  |

### Transition Up

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. ApplyMusicCue

Full Name: HutongGames.PlayMaker.Actions.ApplyMusicCue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| musicCue | object MusicCue | object MusicCue |  |  |
| delayTime | 0.1f | 0.1f |  |  |
| transitionTime | 0.1f | 0.1f |  |  |

##### 2. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.1f | 0.1f |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

### Wait for Event

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Wait For Event | bool Wait For Event | Variable |  |
| boolValue | false | false |  |  |
| everyFrame | false | false |  |  |

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GGCheckIfBossSequence

Full Name: GGCheckIfBossSequence
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| trueEvent | FINISHED | FINISHED |  |  |
| falseEvent | CANCEL | CANCEL |  |  |

### Boss Statue

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. ApplyMusicCue

Full Name: HutongGames.PlayMaker.Actions.ApplyMusicCue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| musicCue | object StatueRegularMusicCue | object StatueRegularMusicCue |  |  |
| delayTime | 0f | 0f |  |  |
| transitionTime | 0f | 0f |  |  |

##### 2. TransitionToAudioSnapshot

Full Name: HutongGames.PlayMaker.Actions.TransitionToAudioSnapshot
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| snapshot | object StatueRegularSnapshot = [Normal (AudioMixerSnapshotController) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | object StatueRegularSnapshot = [Normal (AudioMixerSnapshotController) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| transitionTime | 0f | 0f |  |  |

### Wait

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. NextFrameEvent

Full Name: HutongGames.PlayMaker.Actions.NextFrameEvent
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent | FINISHED | FINISHED |  |  |

##### 2. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | float Delay | float Delay |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

### Statue Level

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. CheckGGBossLevel

Full Name: CheckGGBossLevel
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| notGG |  |  |  |  |
| level1 | 1 | 1 |  |  |
| level2 | 2 | 2 |  |  |
| level3 | 3 | 3 |  |  |

### Boss Statue Alt

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Has Remix | bool Has Remix | Variable |  |
| isTrue |  |  |  |  |
| isFalse | CANCEL | CANCEL |  |  |
| everyFrame | false | false |  |  |

##### 2. ApplyMusicCue

Full Name: HutongGames.PlayMaker.Actions.ApplyMusicCue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| musicCue | object StatueRemixMusicCue | object StatueRemixMusicCue |  |  |
| delayTime | 0f | 0f |  |  |
| transitionTime | 0f | 0f |  |  |

##### 3. TransitionToAudioSnapshot

Full Name: HutongGames.PlayMaker.Actions.TransitionToAudioSnapshot
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| snapshot | object StatueRemixSnapshot = [Normal (AudioMixerSnapshotController) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | object StatueRemixSnapshot = [Normal (AudioMixerSnapshotController) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| transitionTime | 0f | 0f |  |  |

### Skip?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool SkipIfNotStatue | bool SkipIfNotStatue | Variable |  |
| isTrue | CANCEL | CANCEL |  |  |
| isFalse |  |  |  |  |
| everyFrame | false | false |  |  |

### Inert

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

_None_

### Frame

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. NextFrameEvent

Full Name: HutongGames.PlayMaker.Actions.NextFrameEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent | FINISHED | FINISHED |  |  |

### State 1

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. TransitionToAudioSnapshot

Full Name: HutongGames.PlayMaker.Actions.TransitionToAudioSnapshot
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| snapshot | object Audio Snapshot = [Normal (AudioMixerSnapshotController) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | object Audio Snapshot = [Normal (AudioMixerSnapshotController) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| transitionTime | 0.1f | 0.1f |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Boss Sequence | FINISHED | Transition Down | 0 | 0 | 0 |
| Boss Sequence | EVENT | Wait for Event | 0 | 0 | 0 |
| Transition Down | END | Transition Up | 0 | 0 | 0 |
| Transition Up | FINISHED | Frame | 0 | 0 | 0 |
| Wait for Event | GG MUSIC | Boss Sequence | 0 | 0 | 0 |
| Init | CANCEL | Wait | 0 | 0 | 0 |
| Init | FINISHED | Skip? | 0 | 0 | 0 |
| Wait | FINISHED | Statue Level | 0 | 0 | 0 |
| Statue Level | 1 | Boss Statue | 0 | 0 | 0 |
| Statue Level | 2 | Boss Statue Alt | 0 | 0 | 0 |
| Statue Level | 3 | Boss Statue Alt | 0 | 0 | 0 |
| Boss Statue Alt | CANCEL | Boss Statue | 0 | 0 | 0 |
| Skip? | CANCEL | Inert | 0 | 0 | 0 |
| Skip? | FINISHED | Boss Sequence | 0 | 0 | 0 |
| Frame | FINISHED | State 1 | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| 1 | false |
| 2 | false |
| 3 | false |
| CANCEL | false |
| END | false |
| EVENT | false |
| GG MUSIC | false |

