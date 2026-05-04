# PS4 Map Achievement Fixer

## Summary

| Field | Value |
| --- | --- |
| FSM Name | PS4 Map Achievement Fixer |
| GameObject Name | PS4 Map Achievement Fixer |
| GameObject Path |   |
| Source Asset | Hollow Knight/hollow_knight_Data/level12 |
| Start State | Check Platform |
| FSM PathId | 489 |
| GameObject PathId | 105 |

## Variables

## States

### Check Platform

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SwitchOnPlatform

Full Name: HutongGames.PlayMaker.Actions.SwitchOnPlatform
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| Standalone |   |   |   |   |
| Switch |   |   |   |   |
| PS4 |   | PS4 |   |   |
| XB1 |   |   |   |   |
| Other |   |   |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| PS4 | Wait | 0 | |

### Run

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| behaviour |   | "GameManager" | Behaviour |   |
| methodName |   | "CheckMapAchievement" | Method |   |
| parameters |   | FSMViewAvalonia2.FsmArray2 |   |   |
| storeResult |   | Var | Variable | Store Result |

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
| time |   | 1.5f |   |   |
| finishEvent |   | FINISHED |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Run | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| FINISH | false |
| FINISHED | false |
| PS4 | false |

