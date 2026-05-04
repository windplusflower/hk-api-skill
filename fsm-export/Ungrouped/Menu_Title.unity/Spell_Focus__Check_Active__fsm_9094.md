# Check Active

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Check Active |
| GameObject Name | Spell Focus |
| GameObject Path | _GameCameras/HudCamera/Inventory/Inv/Inv_Items/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level1 |
| Start State | Check |
| FSM PathId | 9094 |
| GameObject PathId | 1034 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Down Y | -8.71000004 | Single: -8.71000004 |
| Up Y | -7.46000004 | Single: -7.46000004 |

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Spell Level | 0 | Int32: 0 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Check Spell | false | Boolean: false |

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| Spell Name |   | String:  |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Self | [null] | NamedAssetPPtr: [null] |

## States

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
| boolName |   | "hasNailArt" |   |   |
| isTrue |   | Event(ART) |   |   |
| isFalse |   | Event(NO ART) |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| NO ART | Pos Down | 0 | |
| ART | Pos Up | 0 | |

### Pos Down

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | float Down Y |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED |   | 0 | |

### Pos Up

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | float Up Y |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED |   | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| ACTIVE | false |
| ART | false |
| CHECK | false |
| FINISHED | false |
| INACTIVE | false |
| NO ART | false |

