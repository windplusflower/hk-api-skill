# Divine Charm Return

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Divine Charm Return |
| GameObject Name | Charm Notch |
| GameObject Path |   |
| Source Asset | Hollow Knight/hollow_knight_Data/level7 |
| Start State | Pause |
| FSM PathId | 3979 |
| GameObject PathId | 779 |

## Variables

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Shiny Item | [null] | NamedAssetPPtr: [null] |

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
| sendEvent |   | FINISHED |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Check | 0 | |

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
| gameObject |   | OwnerDefault GameManager |   |   |
| boolName |   | "destroyedNightmareLantern" |   |   |
| isTrue |   |   |   |   |
| isFalse |   | INACTIVE |   |   |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Shiny Item" |   |   |
| storeResult |   | GameObject Shiny Item | Variable |   |

##### 3. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| boolName |   | "gotGrimmNotch" |   |   |
| isTrue |   |   |   |   |
| isFalse |   | NOTCH |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| INACTIVE | Inactive | 0 | |
| NOTCH | Activate | 0 | |

### Inactive

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

(none)

#### Transitions

(none)

### Activate

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Shiny Item |   |   |
| activate |   | true |   |   |
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
| FINISHED | false |
| GEO | false |
| HEART | false |
| INACTIVE | false |
| NOTCH | false |
| STRENGTH | false |

