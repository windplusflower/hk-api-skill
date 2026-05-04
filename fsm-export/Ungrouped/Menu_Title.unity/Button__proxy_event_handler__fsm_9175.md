# proxy_event_handler

## Summary

| Field | Value |
| --- | --- |
| FSM Name | proxy_event_handler |
| GameObject Name | Button |
| GameObject Path | _GameCameras/HudCamera/Prompts/First Map/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level1 |
| Start State | Init |
| FSM PathId | 9175 |
| GameObject PathId | 874 |

## Variables

## States

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 6

#### Actions

(none)

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| DOWN | Send Down | 0 | |
| UP | Send Up | 0 | |
| DOWN INSTANT |   | 0 | |
| UP INSTANT |   | 0 | |
| STOP |   | 0 | |
| PULSE DOWN |   | 0 | |

### Send Down

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):_GameCameras/HudCamera/Prompts/First Map/Button/Label |   |   |
| sendEvent |   | "DOWN" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Init | 0 | |

### Send Up

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):_GameCameras/HudCamera/Prompts/First Map/Button/Label |   |   |
| sendEvent |   | "UP" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Init | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| DOWN | false |
| DOWN INSTANT | false |
| FINISHED | false |
| PULSE DOWN | false |
| STOP | false |
| UP | false |
| UP INSTANT | false |

