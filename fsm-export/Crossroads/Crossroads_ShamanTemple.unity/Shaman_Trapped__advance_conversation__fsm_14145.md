# advance_conversation

## Summary

| Field | Value |
| --- | --- |
| FSM Name | advance_conversation |
| GameObject Name | Shaman Trapped |
| GameObject Path | _Props/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level76 |
| Start State | State 1 |
| FSM PathId | 14145 |
| GameObject PathId | 2080 |

## Variables

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Conversing | false | Boolean: false |

## States

### State 1

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetButtonDown

Full Name: HutongGames.PlayMaker.Actions.GetButtonDown
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| buttonName |   | "Jump" |   |   |
| sendEvent |   | Event(PRESS) |   |   |
| storeResult |   | false | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| PRESS | State 2 | 0 | |

### State 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Conversing | Variable |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(FINISHED) |   |   |
| everyFrame |   | false |   |   |

##### 2. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault UIManager |   |   |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |   |   |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |   |   |
| functionCall |   | advanceTypewriter(???) |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | State 1 | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| PRESS | false |

