# Show Godfinder

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Show Godfinder |
| GameObject Name | Show Godfinder |
| GameObject Path |   |
| Source Asset | Hollow Knight/hollow_knight_Data/level424 |
| Start State | Wait |
| FSM PathId | 5503 |
| GameObject PathId | 651 |

## Variables

## States

### Show

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. ShowGodfinderIconQueued

Full Name: ShowGodfinderIconQueued
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| delay |   | 0f |   |   |

#### Transitions

(none)

### Wait

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 3f |   |   |
| finishEvent |   | FINISHED |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Show | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |

