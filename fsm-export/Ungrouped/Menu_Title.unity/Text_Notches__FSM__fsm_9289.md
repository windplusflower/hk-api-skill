# FSM

## Summary

| Field | Value |
| --- | --- |
| FSM Name | FSM |
| GameObject Name | Text Notches |
| GameObject Path | _GameCameras/HudCamera/Inventory/Charms/Equipped Charms/Notches/ |
| Source Asset | D:/SteamLibrary/steamapps/common/Hollow Knight/hollow_knight_Data/level1 |
| Start State | Get Text |
| FSM PathId | 9289 |
| GameObject PathId | 979 |

## Variables

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| Convo Name | CHARM_TXT_NOTCHES | String: CHARM_TXT_NOTCHES |
| Sheet Name | UI | String: UI |
| Text |   | String:  |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Self | [null] | NamedAssetPPtr: [null] |

## States

### Get Text

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

##### 2. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName |   | string Sheet Name = "Prompts" |   |   |
| convName |   | string Convo Name = "GET_ITEM_INTRO1" |   |   |
| storeValue |   | string Text | Variable |   |

##### 3. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Self |   |   |
| textString |   | string Text |   |   |

#### Transitions

(none)

## Global Transitions

(none)

## Events

(none)

