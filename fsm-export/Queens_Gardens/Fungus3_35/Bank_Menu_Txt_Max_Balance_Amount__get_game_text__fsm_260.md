# get_game_text

## Summary

| Field | Value |
| --- | --- |
| FSM Name | get_game_text |
| GameObject Name | Txt Max Balance Amount |
| GameObject Path | Bank Menu |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets218.assets |
| Start State | Get Text |
| FSM PathId | 260 |
| GameObject PathId | 17 |

## Variables

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| Convo Name | BANK_LIMIT | String: BANK_LIMIT |
| Sheet Name | Prices | String: Prices |
| Text |  | String:  |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Self | [null] | NamedAssetPPtr:  |

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
| storeGameObject | GameObject Self | GameObject Self | Variable |  |

##### 2. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | string Sheet Name = "Prompts" | string Sheet Name = "Prompts" |  |  |
| convName | string Convo Name = "GET_ITEM_INTRO1" | string Convo Name = "GET_ITEM_INTRO1" |  |  |
| storeValue | string Text | string Text | Variable |  |

##### 3. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| textString | string Text | string Text |  |  |

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

