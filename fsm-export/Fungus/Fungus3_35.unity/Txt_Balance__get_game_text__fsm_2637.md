# get_game_text

## Summary

| Field | Value |
| --- | --- |
| FSM Name | get_game_text |
| GameObject Name | Txt Balance |
| GameObject Path | Bank Menu/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level218 |
| Start State | Get Text |
| FSM PathId | 2637 |
| GameObject PathId | 74 |

## Variables

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| Convo Name | BANK_YOURBALANCE | String: BANK_YOURBALANCE |
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

