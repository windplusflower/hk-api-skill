# Phase Control

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Phase Control |
| GameObject Name | Radiance |
| GameObject Path | Boss Control |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/level407.assets |
| Start State | Init |
| FSM PathId | 2644 |
| GameObject PathId | 458 |

## Variables

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| HP | 0 | Int32: 0 |
| P2 Spike Waves | 2650 | Int32: 2650 |
| P3 A1 Rage | 2250 | Int32: 2250 |
| P4 Stun1 | 2000 | Int32: 2000 |
| P5 Acend | 1300 | Int32: 1300 |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Battle Corpse | [null] | NamedAssetPPtr:  |

## States

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

_None_

### Idle 1

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

_None_

### Check 1

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GetHP

Full Name: GetHP
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault FSM Owner | OwnerDefault FSM Owner | Variable |  |
| storeValue | int HP | int HP | Variable |  |

##### 2. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int HP | int HP |  |  |
| integer2 | int P2 Spike Waves | int P2 Spike Waves |  |  |
| equal | Event(NEXT) | Event(NEXT) |  |  |
| lessThan | Event(NEXT) | Event(NEXT) |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

### Set Phase 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(BroadcastAll):FSM Owner | EventTarget(BroadcastAll):FSM Owner |  |  |
| sendEvent | "SPIKE WAVES" | "SPIKE WAVES" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Pause 1

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

### Idle 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

_None_

### Check 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GetHP

Full Name: GetHP
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault FSM Owner | OwnerDefault FSM Owner | Variable |  |
| storeValue | int HP | int HP | Variable |  |

##### 2. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int HP | int HP |  |  |
| integer2 | int P3 A1 Rage | int P3 A1 Rage |  |  |
| equal | Event(NEXT) | Event(NEXT) |  |  |
| lessThan | Event(NEXT) | Event(NEXT) |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

### Set Phase 3

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(BroadcastAll):FSM Owner | EventTarget(BroadcastAll):FSM Owner |  |  |
| sendEvent | "SPIKES OUTER" | "SPIKES OUTER" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Control" | "Control" | FsmName |  |
| variableName | "Rage Ready" | "Rage Ready" | FsmBool |  |
| setValue | true | true |  |  |
| everyFrame | false | false |  |  |

### Pause 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.25f | 0.25f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

##### 2. NextFrameEvent

Full Name: HutongGames.PlayMaker.Actions.NextFrameEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent | Event(FINISHED) | Event(FINISHED) |  |  |

### Idle 3

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

_None_

### Check 3

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GetHP

Full Name: GetHP
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault FSM Owner | OwnerDefault FSM Owner | Variable |  |
| storeValue | int HP | int HP | Variable |  |

##### 2. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int HP | int HP |  |  |
| integer2 | int P4 Stun1 | int P4 Stun1 |  |  |
| equal | Event(NEXT) | Event(NEXT) |  |  |
| lessThan | Event(NEXT) | Event(NEXT) |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

### Pause 3

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

### Stun 1

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(BroadcastAll):FSM Owner | EventTarget(BroadcastAll):FSM Owner |  |  |
| sendEvent | "SPIKES NONE" | "SPIKES NONE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "STUN 1" | "STUN 1" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Idle 4

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

_None_

### Check 4

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GetHP

Full Name: GetHP
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault FSM Owner | OwnerDefault FSM Owner | Variable |  |
| storeValue | int HP | int HP | Variable |  |

##### 2. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int HP | int HP |  |  |
| integer2 | int P5 Acend | int P5 Acend |  |  |
| equal | Event(NEXT) | Event(NEXT) |  |  |
| lessThan | Event(NEXT) | Event(NEXT) |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

### Pause 4

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

### Set Ascend

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Control" | "Control" | FsmName |  |
| variableName | "Ascend Ready" | "Ascend Ready" | FsmBool |  |
| setValue | true | true |  |  |
| everyFrame | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Init | FINISHED | Idle 1 | 0 | 0 | 0 |
| Idle 1 | TOOK DAMAGE | Pause 1 | 0 | 0 | 0 |
| Check 1 | NEXT | Set Phase 2 | 0 | 0 | 0 |
| Check 1 | FINISHED | Idle 1 | 0 | 0 | 0 |
| Set Phase 2 | FINISHED | Idle 2 | 0 | 0 | 0 |
| Pause 1 | FINISHED | Check 1 | 0 | 0 | 0 |
| Idle 2 | TOOK DAMAGE | Pause 2 | 0 | 0 | 0 |
| Check 2 | NEXT | Set Phase 3 | 0 | 0 | 0 |
| Check 2 | FINISHED | Idle 2 | 0 | 0 | 0 |
| Set Phase 3 | RAGE START | Idle 3 | 0 | 0 | 0 |
| Pause 2 | FINISHED | Check 2 | 0 | 0 | 0 |
| Idle 3 | TOOK DAMAGE | Pause 3 | 0 | 0 | 0 |
| Check 3 | NEXT | Stun 1 | 0 | 0 | 0 |
| Check 3 | FINISHED | Idle 3 | 0 | 0 | 0 |
| Pause 3 | FINISHED | Check 3 | 0 | 0 | 0 |
| Stun 1 | ARENA 2 START | Idle 4 | 0 | 0 | 0 |
| Idle 4 | TOOK DAMAGE | Pause 4 | 0 | 0 | 0 |
| Check 4 | NEXT | Set Ascend | 0 | 0 | 0 |
| Check 4 | FINISHED | Idle 4 | 0 | 0 | 0 |
| Pause 4 | FINISHED | Check 4 | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| ARENA 2 START | false |
| HORNET | false |
| HORNET CANCELLED | false |
| HORNET READY | false |
| NEXT | false |
| NORMAL | false |
| RAGE START | false |
| TOOK DAMAGE | false |

