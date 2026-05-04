# FSM

## Summary

| Field | Value |
| --- | --- |
| FSM Name | FSM |
| GameObject Name | White_Palace__0001_wp_glow_door_orb_1 |
| GameObject Path | White_Palace__0002_wp_glow_door/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level367 |
| Start State | Pause |
| FSM PathId | 7641 |
| GameObject PathId | 1483 |

## Variables

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| playerData bool | whitePalaceOrb_2 | String: whitePalaceOrb_2 |

## States

### Pause

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. NextFrameEvent

Full Name: HutongGames.PlayMaker.Actions.NextFrameEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent |   | Event(FINISHED) |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Check | 0 | |

### Check

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| boolName |   | string playerData bool |   |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(DEACTIVATE) |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| DEACTIVATE | Deactivate | 0 | |

### Deactivate

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| activate |   | false |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

#### Transitions

(none)

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| DEACTIVATE | false |
| FINISHED | false |

