# Return HUD

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Return HUD |
| GameObject Name | Return HUD On Dream Wake |
| GameObject Path |   |
| Source Asset | Hollow Knight/hollow_knight_Data/level127 |
| Start State | Idle |
| FSM PathId | 4510 |
| GameObject PathId | 1120 |

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
| DREAM WAKE | HUD in | 0 | |

### HUD in

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):HUD Canvas |   |   |
| sendEvent |   | "IN" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

(none)

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| DREAM WAKE | false |

