# get_game_text

## Summary

| Field | Value |
| --- | --- |
| FSM Name | get_game_text |
| GameObject Name | Unnamed |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Get Text |
| FSM PathId | 19528 |
| GameObject PathId |  |

## Variables

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| Convo Name | GET_ITEM_INTRO1 | String: GET_ITEM_INTRO1 |
| Sheet Name | Prompts | String: Prompts |
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

