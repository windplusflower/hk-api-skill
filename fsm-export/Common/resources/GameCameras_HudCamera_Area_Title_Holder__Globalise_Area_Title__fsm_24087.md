# Globalise Area Title

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Globalise Area Title |
| GameObject Name | Area Title Holder |
| GameObject Path | _GameCameras/HudCamera |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Globalise |
| FSM PathId | 24087 |
| GameObject PathId | 7774 |

## Variables

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Area Title | [null] | NamedAssetPPtr:  |

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
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Area Title" | "Area Title" |  |  |
| storeResult | GameObject Area Title | GameObject Area Title | Variable |  |

##### 2. SetGameObject

Full Name: HutongGames.PlayMaker.Actions.SetGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variable | [Global] GameObject AreaTitle | [Global] GameObject AreaTitle | Variable |  |
| gameObject | GameObject Area Title | GameObject Area Title |  |  |
| everyFrame | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |  |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| _(none)_ |  |

