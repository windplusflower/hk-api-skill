# Check Grub Map Owned

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Check Grub Map Owned |
| GameObject Name | Grub Pins |
| GameObject Path | Game_Map/Crystal Peak |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Pause |
| FSM PathId | 24348 |
| GameObject PathId | 7663 |

## Variables

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Active If Bool True | true | Boolean: true |

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| PD Bool Name | hasPinGrub | String: hasPinGrub |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Self | [null] | NamedAssetPPtr:  |

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
| sendEvent | Event(FINISHED) | Event(FINISHED) |  |  |

### Check

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GetOwner

Full Name: HutongGames.PlayMaker.Actions.GetOwner
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeGameObject | GameObject Self | GameObject Self | Variable |  |

##### 2. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | string PD Bool Name | string PD Bool Name |  |  |
| isTrue | Event(TRUE) | Event(TRUE) |  |  |
| isFalse | Event(FALSE) | Event(FALSE) |  |  |

### True

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Active If Bool True | bool Active If Bool True | Variable |  |
| isTrue | Event(ACTIVE) | Event(ACTIVE) |  |  |
| isFalse | Event(INACTIVE) | Event(INACTIVE) |  |  |
| everyFrame | false | false |  |  |

### False

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Active If Bool True | bool Active If Bool True | Variable |  |
| isTrue | Event(INACTIVE) | Event(INACTIVE) |  |  |
| isFalse | Event(ACTIVE) | Event(ACTIVE) |  |  |
| everyFrame | false | false |  |  |

### Active

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. ActivateAllChildren

Full Name: HutongGames.PlayMaker.Actions.ActivateAllChildren
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Self | GameObject Self | Variable |  |
| activate | true | true |  |  |

### Inactive

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. ActivateAllChildren

Full Name: HutongGames.PlayMaker.Actions.ActivateAllChildren
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Self | GameObject Self | Variable |  |
| activate | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Pause | FINISHED | Check | 0 | 0 | 0 |
| Check | TRUE | True | 0 | 0 | 0 |
| Check | FALSE | False | 0 | 0 | 0 |
| True | ACTIVE | Active | 0 | 0 | 0 |
| True | INACTIVE | Inactive | 0 | 0 | 0 |
| False | ACTIVE | Active | 0 | 0 | 0 |
| False | INACTIVE | Inactive | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| ACTIVE | false |
| FALSE | false |
| INACTIVE | false |
| TRUE | false |

