# FSM

## Summary

| Field | Value |
| --- | --- |
| FSM Name | FSM |
| GameObject Name | Pin_Backer Ghost |
| GameObject Path | Game_Map/Green_Path/Fungus1_34 |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Check |
| FSM PathId | 19636 |
| GameObject PathId | 4500 |

## Variables

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| Completed Bool | killedGhostNoEyes | String: killedGhostNoEyes |
| Pin Type Bool | hasPinGhost | String: hasPinGhost |
| Specific Bool | noEyesPinned | String: noEyesPinned |

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
| boolName | string Completed Bool | string Completed Bool |  |  |
| isTrue | Event(INACTIVE) | Event(INACTIVE) |  |  |
| isFalse | Event() | Event() |  |  |

##### 2. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | string Pin Type Bool | string Pin Type Bool |  |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(INACTIVE) | Event(INACTIVE) |  |  |

##### 3. StringCompare

Full Name: HutongGames.PlayMaker.Actions.StringCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Specific Bool | string Specific Bool | Variable |  |
| compareTo | "" | "" |  |  |
| equalEvent | Event(ACTIVATE) | Event(ACTIVATE) |  |  |
| notEqualEvent | Event() | Event() |  |  |
| storeResult | false | false | Variable |  |
| everyFrame | false | false |  |  |

##### 4. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | string Specific Bool | string Specific Bool |  |  |
| isTrue | Event(ACTIVATE) | Event(ACTIVATE) |  |  |
| isFalse | Event(INACTIVE) | Event(INACTIVE) |  |  |

### Activate

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SetSpriteRenderer

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | true | true |  |  |

### Inactive

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SetSpriteRenderer

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Check | ACTIVATE | Activate | 0 | 0 | 0 |
| Check | INACTIVE | Inactive | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| ACTIVATE | false |
| INACTIVE | false |

