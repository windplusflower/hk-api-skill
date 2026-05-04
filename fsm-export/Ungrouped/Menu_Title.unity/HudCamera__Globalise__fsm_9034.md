# Globalise

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Globalise |
| GameObject Name | HudCamera |
| GameObject Path | _GameCameras/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level1 |
| Start State | Init |
| FSM PathId | 9034 |
| GameObject PathId | 834 |

## Variables

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Self | [null] | NamedAssetPPtr: [null] |

## States

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. GetOwner

Full Name: HutongGames.PlayMaker.Actions.GetOwner
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeGameObject |   | GameObject Self | Variable |   |

##### 2. SetGameObject

Full Name: HutongGames.PlayMaker.Actions.SetGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variable |   | [Global] GameObject HUD Camera | Variable |   |
| gameObject |   | GameObject Self |   |   |
| everyFrame |   | false |   |   |

#### Transitions

(none)

## Global Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| LEVEL LOADED | Init | 0 | |

## Events

| Name | Global |
| --- | --- |
| LEVEL LOADED | false |

