# Music Region

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Music Region |
| GameObject Name | Unnamed |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets348.assets |
| Start State | Pause |
| FSM PathId | 57 |
| GameObject PathId |  |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Enter Delay | 0 | Single: 0 |
| Enter Transition Time | 2 | Single: 2 |
| Enter Transition Time Init | 0 | Single: 0 |
| Exit Transition Time | 3 | Single: 3 |

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Current Track | 0 | Int32: 0 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Dirtmouth | false | Boolean: false |
| Init | false | Boolean: false |

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| Enter Track Event | DIRTMOUTH | String: DIRTMOUTH |
| Exit Track Event | DIRTMOUTH | String: DIRTMOUTH |

### Objects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Enter Music Cue | [null] | NamedAssetPPtr:  |
| Enter Music Snapshot | Normal (AudioMixerSnapshotController) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets) | NamedAssetPPtr: Normal (AudioMixerSnapshotController) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets) |
| Exit Music Cue | [null] | NamedAssetPPtr:  |
| Exit Music Snapshot | Silent (AudioMixerSnapshotController) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets) | NamedAssetPPtr: Silent (AudioMixerSnapshotController) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets) |

## States

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

_None_

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Trigger2dEvent

Full Name: HutongGames.PlayMaker.Actions.Trigger2dEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerEnter2D | 0 |  |  |
| collideTag | "" | "" | Tag |  |
| collideLayer | "" | "" | Layer |  |
| sendEvent | Event(ENTER) | Event(ENTER) |  |  |
| storeCollider |  |  | Variable |  |

##### 2. Trigger2dEvent

Full Name: HutongGames.PlayMaker.Actions.Trigger2dEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerStay2D | 1 |  |  |
| collideTag | "" | "" | Tag |  |
| collideLayer | "" | "" | Layer |  |
| sendEvent | Event(ENTER) | Event(ENTER) |  |  |
| storeCollider |  |  | Variable |  |

### Enter

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. TransitionToAudioSnapshot

Full Name: HutongGames.PlayMaker.Actions.TransitionToAudioSnapshot
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| snapshot | object Enter Music Snapshot = [Normal (AudioMixerSnapshotController) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | object Enter Music Snapshot = [Normal (AudioMixerSnapshotController) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| transitionTime | float Enter Transition Time | float Enter Transition Time |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):AudioManager | EventTarget(GameObject):AudioManager |  |  |
| sendEvent | string Enter Track Event = "DIRTMOUTH" | string Enter Track Event = "DIRTMOUTH" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. Trigger2dEvent

Full Name: HutongGames.PlayMaker.Actions.Trigger2dEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerExit2D | 2 |  |  |
| collideTag | "" | "" | Tag |  |
| collideLayer | "" | "" | Layer |  |
| sendEvent | Event(EXIT) | Event(EXIT) |  |  |
| storeCollider |  |  | Variable |  |

### Exit

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. TransitionToAudioSnapshot

Full Name: HutongGames.PlayMaker.Actions.TransitionToAudioSnapshot
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| snapshot | object Exit Music Snapshot = [Silent (AudioMixerSnapshotController) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | object Exit Music Snapshot = [Silent (AudioMixerSnapshotController) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| transitionTime | float Exit Transition Time | float Exit Transition Time |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):AudioManager | EventTarget(GameObject):AudioManager |  |  |
| sendEvent | string Exit Track Event = "DIRTMOUTH" | string Exit Track Event = "DIRTMOUTH" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. Trigger2dEvent

Full Name: HutongGames.PlayMaker.Actions.Trigger2dEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerEnter2D | 0 |  |  |
| collideTag | "" | "" | Tag |  |
| collideLayer | "" | "" | Layer |  |
| sendEvent | Event(ENTER) | Event(ENTER) |  |  |
| storeCollider |  |  | Variable |  |

##### 4. Trigger2dEvent

Full Name: HutongGames.PlayMaker.Actions.Trigger2dEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerStay2D | 1 |  |  |
| collideTag | "" | "" | Tag |  |
| collideLayer | "" | "" | Layer |  |
| sendEvent | Event(ENTER) | Event(ENTER) |  |  |
| storeCollider |  |  | Variable |  |

##### 5. ApplyMusicCue

Full Name: HutongGames.PlayMaker.Actions.ApplyMusicCue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| musicCue | object Exit Music Cue | object Exit Music Cue |  |  |
| delayTime | 0f | 0f |  |  |
| transitionTime | 0f | 0f |  |  |

### Pause

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. NextFrameEvent

Full Name: HutongGames.PlayMaker.Actions.NextFrameEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent | Event(FINISHED) | Event(FINISHED) |  |  |

### Mines Delay

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | false | false | Variable |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(FINISHED) | Event(FINISHED) |  |  |
| everyFrame | false | false |  |  |

##### 2. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | float Enter Delay | float Enter Delay |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Dirtmouth Check

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Dirtmouth | bool Dirtmouth | Variable |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(NON) | Event(NON) |  |  |
| everyFrame | false | false |  |  |

##### 2. GetFsmInt

Full Name: HutongGames.PlayMaker.Actions.GetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault AudioManager | OwnerDefault AudioManager |  |  |
| fsmName | "Load Music Into Groups" | "Load Music Into Groups" | FsmName |  |
| variableName | "Current Track" | "Current Track" | FsmInt |  |
| storeValue | int Current Track | int Current Track | Variable |  |
| everyFrame | false | false |  |  |

##### 3. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Current Track | int Current Track |  |  |
| integer2 | 1 | 1 |  |  |
| equal | Event(NON) | Event(NON) |  |  |
| lessThan | Event() | Event() |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 4. TransitionToAudioSnapshot

Full Name: HutongGames.PlayMaker.Actions.TransitionToAudioSnapshot
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| snapshot | object Enter Music Snapshot = [Normal (AudioMixerSnapshotController) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | object Enter Music Snapshot = [Normal (AudioMixerSnapshotController) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| transitionTime | 0f | 0f |  |  |

##### 5. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):AudioManager | EventTarget(GameObject):AudioManager |  |  |
| sendEvent | string Enter Track Event = "DIRTMOUTH" | string Enter Track Event = "DIRTMOUTH" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 6. Trigger2dEvent

Full Name: HutongGames.PlayMaker.Actions.Trigger2dEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerExit2D | 2 |  |  |
| collideTag | "" | "" | Tag |  |
| collideLayer | "" | "" | Layer |  |
| sendEvent | Event(EXIT) | Event(EXIT) |  |  |
| storeCollider |  |  | Variable |  |

### Enter Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Init | bool Init | Variable |  |
| isTrue | Event(INIT) | Event(INIT) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 2. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Init | bool Init | Variable |  |
| boolValue | true | true |  |  |
| everyFrame | false | false |  |  |

##### 3. TransitionToAudioSnapshot

Full Name: HutongGames.PlayMaker.Actions.TransitionToAudioSnapshot
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| snapshot | object Enter Music Snapshot = [Normal (AudioMixerSnapshotController) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | object Enter Music Snapshot = [Normal (AudioMixerSnapshotController) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| transitionTime | float Enter Transition Time Init | float Enter Transition Time Init |  |  |

##### 4. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):AudioManager | EventTarget(GameObject):AudioManager |  |  |
| sendEvent | string Enter Track Event = "DIRTMOUTH" | string Enter Track Event = "DIRTMOUTH" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 5. Trigger2dEvent

Full Name: HutongGames.PlayMaker.Actions.Trigger2dEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerExit2D | 2 |  |  |
| collideTag | "" | "" | Tag |  |
| collideLayer | "" | "" | Layer |  |
| sendEvent | Event(EXIT) | Event(EXIT) |  |  |
| storeCollider |  |  | Variable |  |

##### 6. ApplyMusicCue

Full Name: HutongGames.PlayMaker.Actions.ApplyMusicCue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| musicCue | object Enter Music Cue | object Enter Music Cue |  |  |
| delayTime | 0f | 0f |  |  |
| transitionTime | 0f | 0f |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Init | FINISHED | Idle | 0 | 0 | 0 |
| Idle | ENTER | Dirtmouth Check | 0 | 0 | 0 |
| Enter | EXIT | Exit | 0 | 0 | 0 |
| Exit | ENTER | Mines Delay | 0 | 0 | 0 |
| Pause | FINISHED | Init | 0 | 0 | 0 |
| Mines Delay | FINISHED | Enter Init | 0 | 0 | 0 |
| Dirtmouth Check | NON | Mines Delay | 0 | 0 | 0 |
| Dirtmouth Check | EXIT | Exit | 0 | 0 | 0 |
| Enter Init | INIT | Enter | 0 | 0 | 0 |
| Enter Init | EXIT | Exit | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| ENTER | false |
| EXIT | false |
| INIT | false |
| NON | false |

