# Hero Damaged Effects

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Hero Damaged Effects |
| GameObject Name | AudioManager |
| GameObject Path | _GameManager/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level1 |
| Start State | Idle |
| FSM PathId | 9364 |
| GameObject PathId | 1454 |

## Variables

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| HP | 0 | Int32: 0 |

## States

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

(none)

#### Transitions

(none)

### To Lowpass

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| intName |   | "health" |   |   |
| storeValue |   | int HP | Variable |   |

##### 2. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int HP |   |   |
| integer2 |   | 0 |   |   |
| equal |   | Event(CANCEL) |   |   |
| lessThan |   | Event(CANCEL) |   |   |
| greaterThan |   | Event() |   |   |
| everyFrame |   | false |   |   |

##### 3. TransitionToAudioSnapshot

Full Name: HutongGames.PlayMaker.Actions.TransitionToAudioSnapshot
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| snapshot |   | [Damaged (AudioMixerSnapshotController) (Hollow Knight/hollow_knight_Data\sharedassets0.assets)] |   |   |
| transitionTime |   | 0.1f |   |   |

##### 4. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 0.75f |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Fade Back | 0 | |
| CANCEL | Idle | 0 | |

### Fade Back

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. TransitionToAudioSnapshot

Full Name: HutongGames.PlayMaker.Actions.TransitionToAudioSnapshot
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| snapshot |   | [Normal (AudioMixerSnapshotController) (Hollow Knight/hollow_knight_Data\sharedassets0.assets)] |   |   |
| transitionTime |   | 2f |   |   |

#### Transitions

(none)

## Global Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| DAMAGE LOWPASS | To Lowpass | 0 | |

## Events

| Name | Global |
| --- | --- |
| CANCEL | false |
| DAMAGE LOWPASS | false |
| FINISHED | false |
| HERO DAMAGED | true |

