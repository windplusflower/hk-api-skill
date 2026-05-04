# Appear

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Appear |
| GameObject Name | Quake Fake Parent |
| GameObject Path |   |
| Source Asset | D:/SteamLibrary/steamapps/common/Hollow Knight/hollow_knight_Data/level102 |
| Start State | Idle |
| FSM PathId | 2794 |
| GameObject PathId | 6 |

## Variables

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Fake | [null] | NamedAssetPPtr: [null] |

## States

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetChild

Full Name: HutongGames.PlayMaker.Actions.GetChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Quake Fake" |   |   |
| withTag |   | "Untagged" | Tag |   |
| storeResult |   | GameObject Fake | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| QUAKE FAKE APPEAR | Activate | 0 | |

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
| gameObject |   | OwnerDefault Fake |   |   |
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
| QUAKE FAKE APPEAR | false |

