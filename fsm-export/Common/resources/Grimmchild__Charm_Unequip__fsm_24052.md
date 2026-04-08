# Charm Unequip

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Charm Unequip |
| GameObject Name | Grimmchild |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Idle |
| FSM PathId | 24052 |
| GameObject PathId | 7888 |

## Variables

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| Scene Name |  | String:  |

## States

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

_None_

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
| boolName | "equippedCharm_40" | "equippedCharm_40" |  |  |
| isTrue | EQUIPPED | EQUIPPED |  |  |
| isFalse | UNEQUIPPED | UNEQUIPPED |  |  |

### Unequipped

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "DESPAWN" | "DESPAWN" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Check | EQUIPPED | Idle | 0 | 0 | 0 |
| Check | UNEQUIPPED | Unequipped | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| CHARM EQUIP CHECK | Check | 0 | 0 | 0 |

## Events

| Name | Global |
| --- | --- |
| CHARM EQUIP CHECK | false |
| EQUIPPED | false |
| FALSE | false |
| TRUE | false |
| UNEQUIPPED | false |

