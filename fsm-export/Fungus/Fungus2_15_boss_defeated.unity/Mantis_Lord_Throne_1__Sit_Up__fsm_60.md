# Sit Up

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Sit Up |
| GameObject Name | Mantis Lord Throne 1 |
| GameObject Path |   |
| Source Asset | Hollow Knight/hollow_knight_Data/level181 |
| Start State | Idle |
| FSM PathId | 60 |
| GameObject PathId | 1 |

## Variables

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| No Pause | true | Boolean: true |

## States

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

(none)

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| MLORD CHALLENGE ENTER | Enter | 0 | |

### Enter

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "Throne Look Up" |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| MLORD CHALLENGE EXIT | Exit Pause | 0 | |

### Exit

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "Throne Look Down" |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| MLORD CHALLENGE ENTER | Enter | 0 | |

### Exit Pause

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. WaitRandom

Full Name: HutongGames.PlayMaker.Actions.WaitRandom
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| timeMin |   | 0.1f |   |   |
| timeMax |   | 0.5f |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |

##### 2. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool No Pause | Variable |   |
| isTrue |   | Event(FINISHED) |   |   |
| isFalse |   | Event() |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Exit | 0 | |
| MLORD CHALLENGE ENTER | Enter | 0 | |

### Bow

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "Throne Bow" |   |   |

#### Transitions

(none)

## Global Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| MLORD BOW | Bow | 0 | |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| MLORD BOW | false |
| MLORD CHALLENGE ENTER | false |
| MLORD CHALLENGE EXIT | false |

