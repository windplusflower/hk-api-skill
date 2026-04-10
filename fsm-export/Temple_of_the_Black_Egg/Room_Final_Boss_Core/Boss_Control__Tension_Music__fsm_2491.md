# Tension Music

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Tension Music |
| GameObject Name | Boss Control |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/level409.assets |
| Start State | 1 |
| FSM PathId | 2491 |
| GameObject PathId | 563 |

## Variables

## States

### 1

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

_None_

### 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. TransitionToAudioSnapshot

Full Name: HutongGames.PlayMaker.Actions.TransitionToAudioSnapshot
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| snapshot | [Action Only (AudioMixerSnapshotController) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Action Only (AudioMixerSnapshotController) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| transitionTime | 1f | 1f |  |  |

### 3

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. TransitionToAudioSnapshot

Full Name: HutongGames.PlayMaker.Actions.TransitionToAudioSnapshot
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| snapshot | [Sub Area (AudioMixerSnapshotController) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Sub Area (AudioMixerSnapshotController) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| transitionTime | 1f | 1f |  |  |

### 4

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. TransitionToAudioSnapshot

Full Name: HutongGames.PlayMaker.Actions.TransitionToAudioSnapshot
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| snapshot | [Tension Only (AudioMixerSnapshotController) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Tension Only (AudioMixerSnapshotController) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| transitionTime | 1f | 1f |  |  |

### Suspense Final

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. AudioPlaySimple

Full Name: HutongGames.PlayMaker.Actions.AudioPlaySimple
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| volume | 1f | 1f |  |  |
| oneShotClip | [S61-161 Suspence 5 (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets409.assets)] | [S61-161 Suspence 5 (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets409.assets)] |  |  |

##### 2. ApplyMusicCue

Full Name: HutongGames.PlayMaker.Actions.ApplyMusicCue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| musicCue | [None (Script MusicCue) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [None (Script MusicCue) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| delayTime | 0f | 0f |  |  |
| transitionTime | 0f | 0f |  |  |

##### 3. TransitionToAudioSnapshot

Full Name: HutongGames.PlayMaker.Actions.TransitionToAudioSnapshot
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| snapshot | [Main Only (AudioMixerSnapshotController) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Main Only (AudioMixerSnapshotController) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| transitionTime | 0f | 0f |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| 1 | BIG CHAIN BREAK | 2 | 0 | 0 | 0 |
| 2 | BIG CHAIN BREAK | 3 | 0 | 0 | 0 |
| 3 | BIG CHAIN BREAK | 4 | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| SUSPENSE FINAL | Suspense Final | 0 | 0 | 0 |

## Events

| Name | Global |
| --- | --- |
| BIG CHAIN BREAK | false |
| SUSPENSE FINAL | false |

