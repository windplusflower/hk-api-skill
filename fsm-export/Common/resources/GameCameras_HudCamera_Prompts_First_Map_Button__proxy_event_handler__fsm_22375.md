# proxy_event_handler

## Summary

| Field | Value |
| --- | --- |
| FSM Name | proxy_event_handler |
| GameObject Name | Button |
| GameObject Path | _GameCameras/HudCamera/Prompts/First Map |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Init |
| FSM PathId | 22375 |
| GameObject PathId | 4319 |

## Variables

## States

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 6

#### Actions

_None_

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
| eventTarget | EventTarget(GameObject):_GameCameras/HudCamera/Prompts/First Map/Button/Label | EventTarget(GameObject):_GameCameras/HudCamera/Prompts/First Map/Button/Label |  |  |
| sendEvent | "DOWN" | "DOWN" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

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
| eventTarget | EventTarget(GameObject):_GameCameras/HudCamera/Prompts/First Map/Button/Label | EventTarget(GameObject):_GameCameras/HudCamera/Prompts/First Map/Button/Label |  |  |
| sendEvent | "UP" | "UP" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Init | DOWN | Send Down | 0 | 0 | 0 |
| Init | UP | Send Up | 0 | 0 | 0 |
| Init | DOWN INSTANT |  | 0 | 0 | 0 |
| Init | UP INSTANT |  | 0 | 0 | 0 |
| Init | STOP |  | 0 | 0 | 0 |
| Init | PULSE DOWN |  | 0 | 0 | 0 |
| Send Down | FINISHED | Init | 0 | 0 | 0 |
| Send Up | FINISHED | Init | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| DOWN | false |
| DOWN INSTANT | false |
| PULSE DOWN | false |
| STOP | false |
| UP | false |
| UP INSTANT | false |

