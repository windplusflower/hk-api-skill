# PS4 Map Achievement Fixer

## Summary

| Field | Value |
| --- | --- |
| FSM Name | PS4 Map Achievement Fixer |
| GameObject Name | PS4 Banishment Achievement Fixer |
| GameObject Path |   |
| Source Asset | D:/SteamLibrary/steamapps/common/Hollow Knight/hollow_knight_Data/level236 |
| Start State | Check Platform |
| FSM PathId | 1551 |
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
| PS4 | Wait for Touch | 0 | |

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
| methodName |   | "CheckBanishmentAchievement" | Method |   |
| parameters |   | FSMViewAvalonia2.FsmArray2 |   |   |
| storeResult |   | Var | Variable | Store Result |

#### Transitions

(none)

### Wait for Touch

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Trigger2dEvent

Full Name: HutongGames.PlayMaker.Actions.Trigger2dEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerEnter2D | 0 |   |   |
| collideTag |   | "" | Tag |   |
| collideLayer |   | "" | Layer |   |
| sendEvent |   | TRIGGER ENTER 2D |   |   |
| storeCollider |   |   | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| TRIGGER ENTER 2D | Run | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| FINISH | false |
| FINISHED | false |
| PS4 | false |
| TRIGGER ENTER 2D | false |

