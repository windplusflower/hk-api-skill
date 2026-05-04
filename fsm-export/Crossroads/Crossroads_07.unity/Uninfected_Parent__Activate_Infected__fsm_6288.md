# Activate Infected

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Activate Infected |
| GameObject Name | Uninfected Parent |
| GameObject Path |   |
| Source Asset | Hollow Knight/hollow_knight_Data/level43 |
| Start State | Pause |
| FSM PathId | 6288 |
| GameObject PathId | 1038 |

## Variables

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Active If Bool True | false | Boolean: false |

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| PD Bool Name | crossroadsInfected | String: crossroadsInfected |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Self | [null] | NamedAssetPPtr: [null] |

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
Local Transitions: 2

#### Actions

##### 1. GetOwner

Full Name: HutongGames.PlayMaker.Actions.GetOwner
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeGameObject |   | GameObject Self | Variable |   |

##### 2. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| boolName |   | string PD Bool Name |   |   |
| isTrue |   | Event(TRUE) |   |   |
| isFalse |   | Event(FALSE) |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| TRUE | True | 0 | |
| FALSE | False | 0 | |

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
| boolVariable |   | bool Active If Bool True | Variable |   |
| isTrue |   | Event(ACTIVE) |   |   |
| isFalse |   | Event(INACTIVE) |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| ACTIVE | Active | 0 | |
| INACTIVE | Inactive | 0 | |

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
| boolVariable |   | bool Active If Bool True | Variable |   |
| isTrue |   | Event(INACTIVE) |   |   |
| isFalse |   | Event(ACTIVE) |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| ACTIVE | Active | 0 | |
| INACTIVE | Inactive | 0 | |

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
| gameObject |   | GameObject Self | Variable |   |
| activate |   | true |   |   |

#### Transitions

(none)

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
| gameObject |   | GameObject Self | Variable |   |
| activate |   | false |   |   |

#### Transitions

(none)

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| ACTIVE | false |
| FALSE | false |
| FINISHED | false |
| INACTIVE | false |
| TRUE | false |

