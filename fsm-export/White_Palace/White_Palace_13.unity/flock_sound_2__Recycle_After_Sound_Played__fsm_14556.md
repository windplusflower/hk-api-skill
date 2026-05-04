# Recycle After Sound Played

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Recycle After Sound Played |
| GameObject Name | flock sound 2 |
| GameObject Path | white_butterflies_right (3)/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level376 |
| Start State | Wait |
| FSM PathId | 14556 |
| GameObject PathId | 5022 |

## Variables

## States

### Wait

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 6f |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Recycle | 0 | |
| STOP | Recycle | 0 | |

### Recycle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. RecycleSelf

Full Name: HutongGames.PlayMaker.Actions.RecycleSelf
Enabled: true

#### Transitions

(none)

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| STOP | false |

