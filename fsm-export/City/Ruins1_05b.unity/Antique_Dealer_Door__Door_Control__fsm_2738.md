# Door Control

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Door Control |
| GameObject Name | Antique Dealer Door |
| GameObject Path |   |
| Source Asset | Hollow Knight/hollow_knight_Data/level93 |
| Start State | Pause |
| FSM PathId | 2738 |
| GameObject PathId | 262 |

## Variables

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
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| boolName |   | "metRelicDealer" |   |   |
| isTrue |   | Event(DESTROY) |   |   |
| isFalse |   | Event() |   |   |

##### 2. PlayerDataBoolTrueAndFalse

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTrueAndFalse
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| trueBool |   | "marmOutside" |   |   |
| falseBool |   | "marmOutsideConvo" |   |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(DESTROY) |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| DESTROY | Destroy | 0 | |

### Destroy

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. DestroySelf

Full Name: HutongGames.PlayMaker.Actions.DestroySelf
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| detachChildren |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| DESTROY |   | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| DESTROY | false |
| FINISHED | false |

