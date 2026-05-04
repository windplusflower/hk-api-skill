# Damage Flash

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Damage Flash |
| GameObject Name | Dummy |
| GameObject Path | Battle Scene/Mawlek Body/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level485 |
| Start State | Idle |
| FSM PathId | 1786 |
| GameObject PathId | 39 |

## Variables

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
| DAMAGE FLASH | State 1 | 0 | |

### State 1

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |   |   |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |   |   |
| functionCall |   | flashInfected(???) |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Idle | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| DAMAGE FLASH | false |
| FINISHED | false |

