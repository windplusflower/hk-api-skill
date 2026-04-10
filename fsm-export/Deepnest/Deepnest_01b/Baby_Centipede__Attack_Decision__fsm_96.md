# Attack Decision

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Attack Decision |
| GameObject Name | Baby Centipede |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets278.assets |
| Start State | Init |
| FSM PathId | 96 |
| GameObject PathId | 32 |

## Variables

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Attack Range | false | Boolean: false |

## States

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

_None_

### Check

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Attack Range | bool Attack Range | Variable |  |
| isTrue | Event(ATTACK) | Event(ATTACK) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | true | true |  |  |

##### 2. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Attack Range | bool Attack Range | Variable |  |
| boolValue | false | false |  |  |
| everyFrame | false | false |  |  |

### Wait

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. WaitRandom

Full Name: HutongGames.PlayMaker.Actions.WaitRandom
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| timeMin | 0.25f | 0.25f |  |  |
| timeMax | 2f | 2f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Recheck

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Attack Range | bool Attack Range | Variable |  |
| isTrue | Event(ATTACK) | Event(ATTACK) |  |  |
| isFalse | Event(CANCEL) | Event(CANCEL) |  |  |
| everyFrame | false | false |  |  |

### Attack

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "ATTACK" | "ATTACK" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Init | FINISHED | Check | 0 | 0 | 0 |
| Check | ATTACK | Wait | 0 | 0 | 0 |
| Wait | FINISHED | Recheck | 0 | 0 | 0 |
| Recheck | CANCEL | Check | 0 | 0 | 0 |
| Recheck | ATTACK | Attack | 0 | 0 | 0 |
| Attack | FINISHED | Check | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| ATTACK | false |
| CANCEL | false |

