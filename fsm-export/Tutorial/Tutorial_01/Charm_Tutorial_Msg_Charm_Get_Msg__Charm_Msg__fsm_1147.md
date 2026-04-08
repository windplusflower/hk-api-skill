# Charm Msg

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Charm Msg |
| GameObject Name | Charm Get Msg |
| GameObject Path | Charm Tutorial Msg |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets |
| Start State | Pause |
| FSM PathId | 1147 |
| GameObject PathId | 457 |

## Variables

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| ID | 0 | Int32: 0 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Full | false | Boolean: false |

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| Anim Down |  | String:  |
| ID String |  | String:  |
| Name |  | String:  |
| Name Convo |  | String:  |
| Text Str |  | String:  |

### Vector3s

| Name | Value | Raw/Type |
| --- | --- | --- |
| Position | Vector3(-11.91, -6.22, 0) | Vector3: Vector3(-11.91, -6.22, 0) |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Icon | [null] | NamedAssetPPtr:  |
| Self | [null] | NamedAssetPPtr:  |
| Text | [null] | NamedAssetPPtr:  |

### Objects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Sprite | [null] | NamedAssetPPtr:  |

## States

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetOwner

Full Name: HutongGames.PlayMaker.Actions.GetOwner
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeGameObject | GameObject Self | GameObject Self | Variable |  |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Icon" | "Icon" |  |  |
| storeResult | GameObject Icon | GameObject Icon | Variable |  |

##### 3. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Text" | "Text" |  |  |
| storeResult | GameObject Text | GameObject Text | Variable |  |

##### 4. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Charm Icons | OwnerDefault Charm Icons |  |  |
| behaviour | "CharmIconList" | "CharmIconList" | Behaviour |  |
| methodName | "GetSprite" | "GetSprite" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var Sprite =  | Var Sprite =  | Variable | Store Result |

##### 5. SetSpriteRendererSprite

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRendererSprite
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Icon | OwnerDefault Icon |  |  |
| sprite | object Sprite | object Sprite |  |  |

##### 6. ConvertIntToString

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int ID | int ID | Variable |  |
| stringVariable | string ID String | string ID String | Variable |  |
| format | "" | "" |  |  |
| everyFrame | false | false |  |  |

##### 7. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string Name Convo | string Name Convo | Variable |  |
| everyFrame | false | false |  |  |

##### 8. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "UI" | "UI" |  |  |
| convName | string Name Convo | string Name Convo |  |  |
| storeValue | string Name | string Name | Variable |  |

##### 9. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Text | OwnerDefault Text |  |  |
| textString | string Name | string Name |  |  |

### Pause

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. NextFrameEvent

Full Name: HutongGames.PlayMaker.Actions.NextFrameEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent | Event(FINISHED) | Event(FINISHED) |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Init | FINISHED |  | 0 | 0 | 0 |
| Pause | FINISHED | Init | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| DESTROY JOURNAL MSG | false |
| FULL | false |
| HALF | false |

