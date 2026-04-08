# UI Journal

## Summary

| Field | Value |
| --- | --- |
| FSM Name | UI Journal |
| GameObject Name | Journal |
| GameObject Path | _GameCameras/HudCamera/Inventory |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Init |
| FSM PathId | 22925 |
| GameObject PathId | 4713 |

## Variables

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Amount Int | 0 | Int32: 0 |
| Encountered Int | 0 | Int32: 0 |
| Total Int | 0 | Int32: 0 |

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| Amount Str |  | String:  |
| Encountered Str |  | String:  |
| Total Str |  | String:  |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Amount Obj | [null] | NamedAssetPPtr:  |
| Completion Text | [null] | NamedAssetPPtr:  |
| Enc Total | [null] | NamedAssetPPtr:  |
| Encountered Obj | [null] | NamedAssetPPtr:  |
| Encountered Text | [null] | NamedAssetPPtr:  |
| Enemy List | [null] | NamedAssetPPtr:  |
| Total Obj | [null] | NamedAssetPPtr:  |

## States

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Enemy List" | "Enemy List" |  |  |
| storeResult | GameObject Enemy List | GameObject Enemy List | Variable |  |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Text Completion" | "Text Completion" |  |  |
| storeResult | GameObject Completion Text | GameObject Completion Text | Variable |  |

##### 3. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Completion Text | OwnerDefault Completion Text |  |  |
| childName | "Amount" | "Amount" |  |  |
| storeResult | GameObject Amount Obj | GameObject Amount Obj | Variable |  |

##### 4. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Completion Text | OwnerDefault Completion Text |  |  |
| childName | "Text Encountered" | "Text Encountered" |  |  |
| storeResult | GameObject Encountered Text | GameObject Encountered Text | Variable |  |

##### 5. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Completion Text | OwnerDefault Completion Text |  |  |
| childName | "Total" | "Total" |  |  |
| storeResult | GameObject Total Obj | GameObject Total Obj | Variable |  |

##### 6. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Encountered Text | OwnerDefault Encountered Text |  |  |
| childName | "Total" | "Total" |  |  |
| storeResult | GameObject Enc Total | GameObject Enc Total | Variable |  |

##### 7. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Encountered Text | OwnerDefault Encountered Text |  |  |
| childName | "Amount" | "Amount" |  |  |
| storeResult | GameObject Encountered Obj | GameObject Encountered Obj | Variable |  |

### Inactive

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Enemy List | EventTarget(GameObject):Enemy List |  |  |
| sendEvent | "UI INACTIVE" | "UI INACTIVE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Enemy List | EventTarget(GameObject):Enemy List |  |  |
| sendEvent | "RESET" | "RESET" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Active

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Enemy List | EventTarget(GameObject):Enemy List |  |  |
| sendEvent | "UI ACTIVE" | "UI ACTIVE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Completion?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "unlockedCompletionRate" | "unlockedCompletionRate" |  |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(FINISHED) | Event(FINISHED) |  |  |

##### 2. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Completion Text | OwnerDefault Completion Text |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 3. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "journalNotesCompleted" | "journalNotesCompleted" |  |  |
| storeValue | int Amount Int | int Amount Int | Variable |  |

##### 4. ConvertIntToString

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Amount Int | int Amount Int | Variable |  |
| stringVariable | string Amount Str | string Amount Str | Variable |  |
| format | "" | "" |  |  |
| everyFrame | false | false |  |  |

##### 5. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Amount Obj | OwnerDefault Amount Obj |  |  |
| textString | string Amount Str | string Amount Str |  |  |

##### 6. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "journalEntriesCompleted" | "journalEntriesCompleted" |  |  |
| storeValue | int Encountered Int | int Encountered Int | Variable |  |

##### 7. ConvertIntToString

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Encountered Int | int Encountered Int | Variable |  |
| stringVariable | string Encountered Str | string Encountered Str | Variable |  |
| format | "" | "" |  |  |
| everyFrame | false | false |  |  |

##### 8. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Encountered Obj | OwnerDefault Encountered Obj |  |  |
| textString | string Encountered Str | string Encountered Str |  |  |

##### 9. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "journalEntriesTotal" | "journalEntriesTotal" |  |  |
| storeValue | int Total Int | int Total Int | Variable |  |

##### 10. ConvertIntToString

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Total Int | int Total Int | Variable |  |
| stringVariable | string Total Str | string Total Str | Variable |  |
| format | "" | "" |  |  |
| everyFrame | false | false |  |  |

##### 11. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string Total Str | string Total Str | Variable |  |
| everyFrame | false | false |  |  |

##### 12. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Total Obj | OwnerDefault Total Obj |  |  |
| textString | string Total Str | string Total Str |  |  |

##### 13. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Enc Total | OwnerDefault Enc Total |  |  |
| textString | string Total Str | string Total Str |  |  |

##### 14. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:Completion Text | EventTarget(GameObject)[SendToChildren]:Completion Text |  |  |
| sendEvent | "UP" | "UP" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Init | FINISHED | Inactive | 0 | 0 | 0 |
| Inactive | ACTIVATE | Completion? | 0 | 0 | 0 |
| Active | PANE RESET | Inactive | 0 | 0 | 0 |
| Completion? | FINISHED | Active | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| ACTIVATE | false |
| PANE RESET | false |

