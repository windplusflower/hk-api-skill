# Deactivate

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Deactivate |
| GameObject Name | GG_secret_door |
| GameObject Path | Land of Storms Doors/ |
| Source Asset | D:/SteamLibrary/steamapps/common/Hollow Knight/hollow_knight_Data/level473 |
| Start State | Get Bindings |
| FSM PathId | 4801 |
| GameObject PathId | 51 |

## Variables

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Completed | 0 | Int32: 0 |
| Total | 0 | Int32: 0 |

## States

### Get Bindings

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GGGetTotalBindings

Full Name: GGGetTotalBindings
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeValue |   | int Total |   |   |

##### 2. GGGetCompletedBindings

Full Name: GGGetCompletedBindings
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeValue |   | int Completed |   |   |

##### 3. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Completed |   |   |
| integer2 |   | int Total |   |   |
| equal |   |   |   |   |
| lessThan |   | DISABLE |   |   |
| greaterThan |   |   |   |   |
| everyFrame |   | false |   |   |

##### 4. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| boolName |   | "killedGodseekerMask" |   |   |
| isTrue |   | DISABLE |   |   |
| isFalse |   |   |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Inert | 0 | |
| DISABLE | Wait | 0 | |

### Inert

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

(none)

#### Transitions

(none)

### Disable

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

### Wait

Description: Wait just in case something goes wrong and player is returning through this door.
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. WaitForHeroInPosition

Full Name: WaitForHeroInPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent |   | FINISHED |   |   |
| skipIfAlreadyPositioned |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Disable | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| DISABLE | false |
| FINISHED | false |

