# advance_conversation

## Summary

| Field | Value |
| --- | --- |
| FSM Name | advance_conversation |
| GameObject Name | Shaman Trapped |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets76.assets |
| Start State | State 1 |
| FSM PathId | 111 |
| GameObject PathId | 69 |

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
| buttonName | "Jump" | "Jump" |  |  |
| sendEvent | Event(PRESS) | Event(PRESS) |  |  |
| storeResult | false | false | Variable |  |

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
| boolVariable | bool Conversing | bool Conversing | Variable |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(FINISHED) | Event(FINISHED) |  |  |
| everyFrame | false | false |  |  |

##### 2. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault UIManager | OwnerDefault UIManager |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | advanceTypewriter(???) | advanceTypewriter(???) |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| State 1 | PRESS | State 2 | 0 | 0 | 0 |
| State 2 | FINISHED | State 1 | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| PRESS | false |

