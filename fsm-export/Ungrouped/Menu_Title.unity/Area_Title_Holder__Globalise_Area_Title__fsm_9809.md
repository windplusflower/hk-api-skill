# Globalise Area Title

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Globalise Area Title |
| GameObject Name | Area Title Holder |
| GameObject Path | _GameCameras/HudCamera/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level1 |
| Start State | Globalise |
| FSM PathId | 9809 |
| GameObject PathId | 1882 |

## Variables

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Area Title | [null] | NamedAssetPPtr: [null] |

## States

### Globalise

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Area Title" |   |   |
| storeResult |   | GameObject Area Title | Variable |   |

##### 2. SetGameObject

Full Name: HutongGames.PlayMaker.Actions.SetGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variable |   | [Global] GameObject AreaTitle | Variable |   |
| gameObject |   | GameObject Area Title |   |   |
| everyFrame |   | false |   |   |

#### Transitions

(none)

## Global Transitions

(none)

## Events

(none)

