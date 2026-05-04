# Set

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Set |
| GameObject Name | Set Kings Station Display |
| GameObject Path |   |
| Source Asset | Hollow Knight/hollow_knight_Data/level118 |
| Start State | Pause |
| FSM PathId | 5027 |
| GameObject PathId | 37 |

## Variables

## States

### Set

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName |   | "kingsStationNonDisplay" |   |   |
| value |   | true |   |   |

#### Transitions

(none)

### Pause

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 0.5f |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Set | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |

