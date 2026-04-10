# Acid Armour Check

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Acid Armour Check |
| GameObject Name | Surface Water Region |
| GameObject Path | Acid Control v2 |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets173.assets |
| Start State | Pause |
| FSM PathId | 33 |
| GameObject PathId | 13 |

## Variables

## States

### Check

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "hasAcidArmour" | "hasAcidArmour" |  |  |
| isTrue | Event(ENABLE) | Event(ENABLE) |  |  |
| isFalse | Event() | Event() |  |  |

### Enable

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SetCollider

Full Name: HutongGames.PlayMaker.Actions.SetCollider
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | true | true |  |  |

### Recheck

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

_None_

### Pause

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetCollider

Full Name: HutongGames.PlayMaker.Actions.SetCollider
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | false | false |  |  |

##### 2. NextFrameEvent

Full Name: HutongGames.PlayMaker.Actions.NextFrameEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent | Event(FINISHED) | Event(FINISHED) |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Check | ENABLE | Enable | 0 | 0 | 0 |
| Check | GET ACID ARMOUR | Recheck | 0 | 0 | 0 |
| Recheck | FINISHED | Check | 0 | 0 | 0 |
| Pause | FINISHED | Check | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| ENABLE | false |
| GET ACID ARMOUR | false |

