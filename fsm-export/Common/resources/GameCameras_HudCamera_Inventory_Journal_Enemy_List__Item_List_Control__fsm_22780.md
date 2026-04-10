# Item List Control

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Item List Control |
| GameObject Name | Enemy List |
| GameObject Path | _GameCameras/HudCamera/Inventory/Journal |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Init |
| FSM PathId | 22780 |
| GameObject PathId | 4357 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Move Y | 1.75 | Single: 1.75 |
| To Y | 0 | Single: 0 |

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Current Item | 0 | Int32: 0 |
| First New Item | 0 | Int32: 0 |
| Increment Down | 0 | Int32: 0 |
| Increment Up | 0 | Int32: 0 |
| Item Count | 0 | Int32: 0 |
| PD Kills | 0 | Int32: 0 |
| Repeat Inc Down | 3 | Int32: 3 |
| Repeat Inc Up | -3 | Int32: -3 |
| Repeats | 0 | Int32: 0 |
| Repeats Number | 6 | Int32: 6 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Is Ghost | false | Boolean: false |
| Is Grimm | false | Boolean: false |
| Repeating | false | Boolean: false |

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| Item Desc |  | String:  |
| Item Desc Convo |  | String:  |
| Item Name |  | String:  |
| Item Name Convo |  | String:  |
| Item Notes Convo |  | String:  |
| Item notes String |  | String:  |
| Kill Msg 1 |  | String:  |
| Kill Msg 2 |  | String:  |
| Kills String |  | String:  |
| pdKillsName |  | String:  |

### Vector3s

| Name | Value | Raw/Type |
| --- | --- | --- |
| Move To Pos | Vector3(0, 0, -1) | Vector3: Vector3(0, 0, -1) |
| Selector Pos Init | Vector3(0, 0, 0) | Vector3: Vector3(0, 0, 0) |
| Wrong Pos | Vector3(0, 0, -1) | Vector3: Vector3(0, 0, -1) |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Arrow D | [null] | NamedAssetPPtr:  |
| Arrow L | [null] | NamedAssetPPtr:  |
| Arrow R | [null] | NamedAssetPPtr:  |
| Arrow To Move | [null] | NamedAssetPPtr:  |
| Arrow U | [null] | NamedAssetPPtr:  |
| Border | [null] | NamedAssetPPtr:  |
| Cursor | [null] | NamedAssetPPtr:  |
| Cursor Back | [null] | NamedAssetPPtr:  |
| Cursor Glow | [null] | NamedAssetPPtr:  |
| Description Obj | [null] | NamedAssetPPtr:  |
| Enemy List | [null] | NamedAssetPPtr:  |
| Enemy Sprite | [null] | NamedAssetPPtr:  |
| Hunter Symbol | [null] | NamedAssetPPtr:  |
| Inventory | [null] | NamedAssetPPtr:  |
| Item Notes | [null] | NamedAssetPPtr:  |
| Name Obj | [null] | NamedAssetPPtr:  |
| Parent | [null] | NamedAssetPPtr:  |
| Selector | [null] | NamedAssetPPtr:  |
| Self | [null] | NamedAssetPPtr:  |

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

##### 2. GetParent

Full Name: HutongGames.PlayMaker.Actions.GetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| storeResult | GameObject Parent | GameObject Parent | Variable |  |

##### 3. GetParent

Full Name: HutongGames.PlayMaker.Actions.GetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Parent | OwnerDefault Parent |  |  |
| storeResult | GameObject Inventory | GameObject Inventory | Variable |  |

##### 4. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inventory | OwnerDefault Inventory |  |  |
| childName | "Border" | "Border" |  |  |
| storeResult | GameObject Border | GameObject Border | Variable |  |

##### 5. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Border | OwnerDefault Border |  |  |
| childName | "Arrow Right" | "Arrow Right" |  |  |
| storeResult | GameObject Arrow R | GameObject Arrow R | Variable |  |

##### 6. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Border | OwnerDefault Border |  |  |
| childName | "Arrow Left" | "Arrow Left" |  |  |
| storeResult | GameObject Arrow L | GameObject Arrow L | Variable |  |

##### 7. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Parent | OwnerDefault Parent |  |  |
| childName | "Text Desc" | "Text Desc" |  |  |
| storeResult | GameObject Description Obj | GameObject Description Obj | Variable |  |

##### 8. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Parent | OwnerDefault Parent |  |  |
| childName | "Cursor" | "Cursor" |  |  |
| storeResult | GameObject Cursor | GameObject Cursor | Variable |  |

##### 9. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Parent | OwnerDefault Parent |  |  |
| childName | "Text Notes" | "Text Notes" |  |  |
| storeResult | GameObject Item Notes | GameObject Item Notes | Variable |  |

##### 10. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Parent | OwnerDefault Parent |  |  |
| childName | "Text Name" | "Text Name" |  |  |
| storeResult | GameObject Name Obj | GameObject Name Obj | Variable |  |

##### 11. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Parent | OwnerDefault Parent |  |  |
| childName | "Enemy Sprite" | "Enemy Sprite" |  |  |
| storeResult | GameObject Enemy Sprite | GameObject Enemy Sprite | Variable |  |

##### 12. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Name Obj | OwnerDefault Name Obj |  |  |
| textString | "" | "" |  |  |

##### 13. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Description Obj | OwnerDefault Description Obj |  |  |
| textString | "" | "" |  |  |

##### 14. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | BuildItemList(???) | BuildItemList(???) |  |  |

##### 15. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | -7.99f | -7.99f |  |  |
| y | -7.16f | -7.16f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 16. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| behaviour | "JournalList" | "JournalList" | Behaviour |  |
| methodName | "GetYDistance" | "GetYDistance" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var Move Y = 1.75 | Var Move Y = 1.75 | Variable | Store Result |

##### 17. FloatMultiply

Full Name: HutongGames.PlayMaker.Actions.FloatMultiply
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Move Y | float Move Y | Variable |  |
| multiplyBy | -1f | -1f |  |  |
| everyFrame | false | false |  |  |

##### 18. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Current Item | int Current Item | Variable |  |
| intValue | 0 | 0 |  |  |
| everyFrame | false | false |  |  |

##### 19. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| behaviour | "JournalList" | "JournalList" | Behaviour |  |
| methodName | "GetItemCount" | "GetItemCount" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var Item Count = 0 | Var Item Count = 0 | Variable | Store Result |

##### 20. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Current Item | int Current Item | Variable |  |
| intValue | 0 | 0 |  |  |
| everyFrame | false | false |  |  |

##### 21. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Parent | OwnerDefault Parent |  |  |
| childName | "Arrow D" | "Arrow D" |  |  |
| storeResult | GameObject Arrow D | GameObject Arrow D | Variable |  |

##### 22. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Parent | OwnerDefault Parent |  |  |
| childName | "Arrow U" | "Arrow U" |  |  |
| storeResult | GameObject Arrow U | GameObject Arrow U | Variable |  |

##### 23. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Parent | OwnerDefault Parent |  |  |
| childName | "selector" | "selector" |  |  |
| storeResult | GameObject Selector | GameObject Selector | Variable |  |

##### 24. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Parent | OwnerDefault Parent |  |  |
| childName | "hunter_symbol" | "hunter_symbol" |  |  |
| storeResult | GameObject Hunter Symbol | GameObject Hunter Symbol | Variable |  |

##### 25. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Selector | OwnerDefault Selector |  |  |
| vector | Vector3 Selector Pos Init | Vector3 Selector Pos Init | Variable |  |
| x | 0f | 0f | Variable |  |
| y | 0f | 0f | Variable |  |
| z | 0f | 0f | Variable |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |

##### 26. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Cursor | OwnerDefault Cursor |  |  |
| childName | "Back" | "Back" |  |  |
| storeResult | GameObject Cursor Back | GameObject Cursor Back | Variable |  |

##### 27. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Cursor Back | OwnerDefault Cursor Back |  |  |
| childName | "Glow" | "Glow" |  |  |
| storeResult | GameObject Cursor Glow | GameObject Cursor Glow | Variable |  |

##### 28. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Journal" | "Journal" |  |  |
| convName | "KILL_COUNT_1" | "KILL_COUNT_1" |  |  |
| storeValue | string Kill Msg 1 | string Kill Msg 1 | Variable |  |

##### 29. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Journal" | "Journal" |  |  |
| convName | "KILL_COUNT_2" | "KILL_COUNT_2" |  |  |
| storeValue | string Kill Msg 2 | string Kill Msg 2 | Variable |  |

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 6

#### Actions

##### 1. SetSpriteRenderer

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Arrow U | OwnerDefault Arrow U |  |  |
| active | true | true |  |  |

##### 2. SetSpriteRenderer

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Arrow D | OwnerDefault Arrow D |  |  |
| active | true | true |  |  |

##### 3. SetFsmGameObject

Full Name: HutongGames.PlayMaker.Actions.SetFsmGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Update Cursor" | "Update Cursor" | FsmName |  |
| variableName | "Item" | "Item" | FsmGameObject |  |
| setValue | GameObject Selector | GameObject Selector |  |  |
| everyFrame | false | false |  |  |

##### 4. SetMaterialColor

Full Name: HutongGames.PlayMaker.Actions.SetMaterialColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Selector | OwnerDefault Selector |  |  |
| materialIndex | 0 | 0 |  |  |
| material | [FsmMaterial not implemented] | [FsmMaterial not implemented] |  |  |
| namedColor | "_Color" | "_Color" | NamedColor |  |
| color | Color(1, 1, 1, 1) | Color(1, 1, 1, 1) |  |  |
| everyFrame | false | false |  |  |

##### 5. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "UPDATE CURSOR" | "UPDATE CURSOR" |  |  |
| delay | 0.01f | 0.01f |  |  |
| everyFrame | false | false |  |  |

##### 6. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Cursor | OwnerDefault Cursor |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | -5.71f | -5.71f |  |  |
| y | -7.05f | -7.05f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

### Check Down

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Current Item | int Current Item |  |  |
| integer2 | int Item Count | int Item Count |  |  |
| equal | Event(CANCEL) | Event(CANCEL) |  |  |
| lessThan | Event() | Event() |  |  |
| greaterThan | Event(CANCEL) | Event(CANCEL) |  |  |
| everyFrame | false | false |  |  |

### Fail Down

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 4

#### Actions

##### 1. GetFsmBool

Full Name: HutongGames.PlayMaker.Actions.GetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "ui_list_getinput" | "ui_list_getinput" | FsmName |  |
| variableName | "Repeating" | "Repeating" | FsmBool |  |
| storeValue | bool Repeating | bool Repeating | Variable |  |
| everyFrame | false | false |  |  |

##### 2. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Repeating | bool Repeating | Variable |  |
| isTrue | Event(MOVETO) | Event(MOVETO) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Arrow D | EventTarget(GameObject):Arrow D |  |  |
| sendEvent | "MOVE" | "MOVE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 4. ConvertIntToFloat

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Current Item | int Current Item | Variable |  |
| floatVariable | float To Y | float To Y | Variable |  |
| everyFrame | false | false |  |  |

##### 5. FloatMultiply

Full Name: HutongGames.PlayMaker.Actions.FloatMultiply
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float To Y | float To Y | Variable |  |
| multiplyBy | float Move Y | float Move Y |  |  |
| everyFrame | false | false |  |  |

##### 6. FloatAdd

Full Name: HutongGames.PlayMaker.Actions.FloatAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float To Y | float To Y | Variable |  |
| add | -7.16f | -7.16f |  |  |
| everyFrame | false | false |  |  |
| perSecond | false | false |  |  |

##### 7. SetVector3XYZ

Full Name: HutongGames.PlayMaker.Actions.SetVector3XYZ
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable | Vector3 Move To Pos | Vector3 Move To Pos | Variable |  |
| vector3Value | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | -7.99f | -7.99f |  |  |
| y | float To Y | float To Y |  |  |
| z | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 8. SetVector3Value

Full Name: HutongGames.PlayMaker.Actions.SetVector3Value
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable | Vector3 Wrong Pos | Vector3 Wrong Pos | Variable |  |
| vector3Value | Vector3 Move To Pos | Vector3 Move To Pos |  |  |
| everyFrame | false | false |  |  |

##### 9. Vector3AddXYZ

Full Name: HutongGames.PlayMaker.Actions.Vector3AddXYZ
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable | Vector3 Wrong Pos | Vector3 Wrong Pos | Variable |  |
| addX | 0f | 0f |  |  |
| addY | 0.25f | 0.25f |  |  |
| addZ | 0f | 0f |  |  |
| everyFrame | false | false |  |  |
| perSecond | false | false |  |  |

##### 10. iTweenMoveTo

Full Name: HutongGames.PlayMaker.Actions.iTweenMoveTo
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| id | "" | "" |  |  |
| transformPosition |  |  |  |  |
| vectorPosition | Vector3 Wrong Pos | Vector3 Wrong Pos |  |  |
| time | 0.1f | 0.1f |  |  |
| delay | 0f | 0f |  |  |
| speed | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| easeType | iTween/EaseType::easeOutSine | 13 |  |  |
| loopType | iTween/LoopType::none | 0 |  |  |
| orientToPath | false | false |  | LookAt |
| lookAtObject |  |  |  |  |
| lookAtVector | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| lookTime | 0f | 0f |  |  |
| axis | HutongGames.PlayMaker.Actions.iTweenFsmAction/AxisRestriction::none | 0 |  |  |
| moveToPath | false | false |  | Path |
| lookAhead | 0f | 0f |  |  |
| transforms | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| vectors | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| reverse | false | false |  |  |
| startEvent | Event() | Event() |  |  |
| finishEvent | Event() | Event() |  |  |
| realTime | false | false |  |  |
| stopOnExit | true | true |  |  |
| loopDontFinish | true | true |  |  |

##### 11. iTweenMoveTo

Full Name: HutongGames.PlayMaker.Actions.iTweenMoveTo
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| id | "" | "" |  |  |
| transformPosition |  |  |  |  |
| vectorPosition | Vector3 Move To Pos | Vector3 Move To Pos |  |  |
| time | 0.25f | 0.25f |  |  |
| delay | 0.1f | 0.1f |  |  |
| speed | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| easeType | iTween/EaseType::easeOutSine | 13 |  |  |
| loopType | iTween/LoopType::none | 0 |  |  |
| orientToPath | false | false |  | LookAt |
| lookAtObject |  |  |  |  |
| lookAtVector | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| lookTime | 0f | 0f |  |  |
| axis | HutongGames.PlayMaker.Actions.iTweenFsmAction/AxisRestriction::none | 0 |  |  |
| moveToPath | false | false |  | Path |
| lookAhead | 0f | 0f |  |  |
| transforms | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| vectors | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| reverse | false | false |  |  |
| startEvent | Event() | Event() |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |
| stopOnExit | true | true |  |  |
| loopDontFinish | true | true |  |  |

### Move Down

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Current Item | int Current Item | Variable |  |
| add | int Increment Down | int Increment Down |  |  |
| everyFrame | false | false |  |  |

##### 2. IntClamp

Full Name: HutongGames.PlayMaker.Actions.IntClamp
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Current Item | int Current Item | Variable |  |
| minValue | 0 | 0 |  |  |
| maxValue | int Item Count | int Item Count |  |  |
| everyFrame | false | false |  |  |

##### 3. SetGameObject

Full Name: HutongGames.PlayMaker.Actions.SetGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variable | GameObject Arrow To Move | GameObject Arrow To Move | Variable |  |
| gameObject | GameObject Arrow D | GameObject Arrow D |  |  |
| everyFrame | false | false |  |  |

##### 4. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Arrow To Move | EventTarget(GameObject):Arrow To Move |  |  |
| sendEvent | "MOVE" | "MOVE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 5. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player UI (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player UI (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [ui_change_selection (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets0.assets)] | [ui_change_selection (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets0.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 0.65f | 0.65f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

### Check Up

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Current Item | int Current Item |  |  |
| integer2 | 0 | 0 |  |  |
| equal | Event(CANCEL) | Event(CANCEL) |  |  |
| lessThan | Event(CANCEL) | Event(CANCEL) |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

### Fail Up

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 4

#### Actions

##### 1. GetFsmBool

Full Name: HutongGames.PlayMaker.Actions.GetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "ui_list_getinput" | "ui_list_getinput" | FsmName |  |
| variableName | "Repeating" | "Repeating" | FsmBool |  |
| storeValue | bool Repeating | bool Repeating | Variable |  |
| everyFrame | false | false |  |  |

##### 2. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Repeating | bool Repeating | Variable |  |
| isTrue | Event(MOVETO) | Event(MOVETO) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Arrow U | EventTarget(GameObject):Arrow U |  |  |
| sendEvent | "MOVE" | "MOVE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 4. ConvertIntToFloat

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Current Item | int Current Item | Variable |  |
| floatVariable | float To Y | float To Y | Variable |  |
| everyFrame | false | false |  |  |

##### 5. FloatMultiply

Full Name: HutongGames.PlayMaker.Actions.FloatMultiply
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float To Y | float To Y | Variable |  |
| multiplyBy | float Move Y | float Move Y |  |  |
| everyFrame | false | false |  |  |

##### 6. FloatAdd

Full Name: HutongGames.PlayMaker.Actions.FloatAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float To Y | float To Y | Variable |  |
| add | -7.16f | -7.16f |  |  |
| everyFrame | false | false |  |  |
| perSecond | false | false |  |  |

##### 7. SetVector3XYZ

Full Name: HutongGames.PlayMaker.Actions.SetVector3XYZ
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable | Vector3 Move To Pos | Vector3 Move To Pos | Variable |  |
| vector3Value | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | -7.99f | -7.99f |  |  |
| y | float To Y | float To Y |  |  |
| z | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 8. SetVector3Value

Full Name: HutongGames.PlayMaker.Actions.SetVector3Value
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable | Vector3 Wrong Pos | Vector3 Wrong Pos | Variable |  |
| vector3Value | Vector3 Move To Pos | Vector3 Move To Pos |  |  |
| everyFrame | false | false |  |  |

##### 9. Vector3AddXYZ

Full Name: HutongGames.PlayMaker.Actions.Vector3AddXYZ
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable | Vector3 Wrong Pos | Vector3 Wrong Pos | Variable |  |
| addX | 0f | 0f |  |  |
| addY | -0.25f | -0.25f |  |  |
| addZ | 0f | 0f |  |  |
| everyFrame | false | false |  |  |
| perSecond | false | false |  |  |

##### 10. iTweenMoveTo

Full Name: HutongGames.PlayMaker.Actions.iTweenMoveTo
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| id | "" | "" |  |  |
| transformPosition |  |  |  |  |
| vectorPosition | Vector3 Wrong Pos | Vector3 Wrong Pos |  |  |
| time | 0.1f | 0.1f |  |  |
| delay | 0f | 0f |  |  |
| speed | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| easeType | iTween/EaseType::easeOutSine | 13 |  |  |
| loopType | iTween/LoopType::none | 0 |  |  |
| orientToPath | false | false |  | LookAt |
| lookAtObject |  |  |  |  |
| lookAtVector | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| lookTime | 0f | 0f |  |  |
| axis | HutongGames.PlayMaker.Actions.iTweenFsmAction/AxisRestriction::none | 0 |  |  |
| moveToPath | false | false |  | Path |
| lookAhead | 0f | 0f |  |  |
| transforms | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| vectors | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| reverse | false | false |  |  |
| startEvent | Event() | Event() |  |  |
| finishEvent | Event() | Event() |  |  |
| realTime | false | false |  |  |
| stopOnExit | true | true |  |  |
| loopDontFinish | true | true |  |  |

##### 11. iTweenMoveTo

Full Name: HutongGames.PlayMaker.Actions.iTweenMoveTo
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| id | "" | "" |  |  |
| transformPosition |  |  |  |  |
| vectorPosition | Vector3 Move To Pos | Vector3 Move To Pos |  |  |
| time | 0.25f | 0.25f |  |  |
| delay | 0.1f | 0.1f |  |  |
| speed | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| easeType | iTween/EaseType::easeOutSine | 13 |  |  |
| loopType | iTween/LoopType::none | 0 |  |  |
| orientToPath | false | false |  | LookAt |
| lookAtObject |  |  |  |  |
| lookAtVector | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| lookTime | 0f | 0f |  |  |
| axis | HutongGames.PlayMaker.Actions.iTweenFsmAction/AxisRestriction::none | 0 |  |  |
| moveToPath | false | false |  | Path |
| lookAhead | 0f | 0f |  |  |
| transforms | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| vectors | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| reverse | false | false |  |  |
| startEvent | Event() | Event() |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |
| stopOnExit | true | true |  |  |
| loopDontFinish | true | true |  |  |

### Move Up

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Current Item | int Current Item | Variable |  |
| add | int Increment Up | int Increment Up |  |  |
| everyFrame | false | false |  |  |

##### 2. IntClamp

Full Name: HutongGames.PlayMaker.Actions.IntClamp
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Current Item | int Current Item | Variable |  |
| minValue | 0 | 0 |  |  |
| maxValue | int Item Count | int Item Count |  |  |
| everyFrame | false | false |  |  |

##### 3. SetGameObject

Full Name: HutongGames.PlayMaker.Actions.SetGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variable | GameObject Arrow To Move | GameObject Arrow To Move | Variable |  |
| gameObject | GameObject Arrow U | GameObject Arrow U |  |  |
| everyFrame | false | false |  |  |

##### 4. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Arrow To Move | EventTarget(GameObject):Arrow To Move |  |  |
| sendEvent | "MOVE" | "MOVE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 5. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player UI (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player UI (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [ui_change_selection (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets0.assets)] | [ui_change_selection (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets0.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 0.65f | 0.65f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

### MoveTo

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 5

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:FSM Owner | EventTarget(GameObject)[SendToChildren]:FSM Owner |  |  |
| sendEvent | "SHIFT" | "SHIFT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. ConvertIntToFloat

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Current Item | int Current Item | Variable |  |
| floatVariable | float To Y | float To Y | Variable |  |
| everyFrame | false | false |  |  |

##### 3. FloatMultiply

Full Name: HutongGames.PlayMaker.Actions.FloatMultiply
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float To Y | float To Y | Variable |  |
| multiplyBy | float Move Y | float Move Y |  |  |
| everyFrame | false | false |  |  |

##### 4. FloatAdd

Full Name: HutongGames.PlayMaker.Actions.FloatAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float To Y | float To Y | Variable |  |
| add | -7.16f | -7.16f |  |  |
| everyFrame | false | false |  |  |
| perSecond | false | false |  |  |

##### 5. SetVector3XYZ

Full Name: HutongGames.PlayMaker.Actions.SetVector3XYZ
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable | Vector3 Move To Pos | Vector3 Move To Pos | Variable |  |
| vector3Value | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | -7.99f | -7.99f |  |  |
| y | float To Y | float To Y |  |  |
| z | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 6. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector3 Move To Pos | Vector3 Move To Pos | Variable |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 7. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.25f | 0.25f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Get Details

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intName | "lastJournalItem" | "lastJournalItem" |  |  |
| value | int Current Item | int Current Item |  |  |

##### 2. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| behaviour | "JournalList" | "JournalList" | Behaviour |  |
| methodName | "GetNameConvo" | "GetNameConvo" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var Item Name Convo =  | Var Item Name Convo =  | Variable | Store Result |

##### 3. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Journal" | "Journal" |  |  |
| convName | string Item Name Convo | string Item Name Convo |  |  |
| storeValue | string Item Name | string Item Name | Variable |  |

##### 4. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Name Obj | OwnerDefault Name Obj |  |  |
| textString | string Item Name | string Item Name |  |  |

##### 5. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| behaviour | "JournalList" | "JournalList" | Behaviour |  |
| methodName | "GetDescConvo" | "GetDescConvo" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var Item Desc Convo =  | Var Item Desc Convo =  | Variable | Store Result |

##### 6. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| behaviour | "JournalList" | "JournalList" | Behaviour |  |
| methodName | "GetSprite" | "GetSprite" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var Sprite =  | Var Sprite =  | Variable | Store Result |

##### 7. SetSpriteRendererSprite

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRendererSprite
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Enemy Sprite | OwnerDefault Enemy Sprite |  |  |
| sprite | object Sprite | object Sprite |  |  |

##### 8. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Journal" | "Journal" |  |  |
| convName | string Item Desc Convo | string Item Desc Convo |  |  |
| storeValue | string Item Desc | string Item Desc | Variable |  |

##### 9. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Description Obj | OwnerDefault Description Obj |  |  |
| textString | string Item Desc | string Item Desc |  |  |

### Move Pane L

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GetFsmBool

Full Name: HutongGames.PlayMaker.Actions.GetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "ui_list_getinput" | "ui_list_getinput" | FsmName |  |
| variableName | "Repeating" | "Repeating" | FsmBool |  |
| storeValue | bool Repeating | bool Repeating | Variable |  |
| everyFrame | false | false |  |  |

##### 2. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Repeating | bool Repeating | Variable |  |
| isTrue | Event(CANCEL) | Event(CANCEL) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Inventory | EventTarget(GameObject):Inventory |  |  |
| sendEvent | "MOVE PANE L" | "MOVE PANE L" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Move Pane R

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GetFsmBool

Full Name: HutongGames.PlayMaker.Actions.GetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "ui_list_getinput" | "ui_list_getinput" | FsmName |  |
| variableName | "Repeating" | "Repeating" | FsmBool |  |
| storeValue | bool Repeating | bool Repeating | Variable |  |
| everyFrame | false | false |  |  |

##### 2. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Repeating | bool Repeating | Variable |  |
| isTrue | Event(CANCEL) | Event(CANCEL) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Inventory | EventTarget(GameObject):Inventory |  |  |
| sendEvent | "MOVE PANE R" | "MOVE PANE R" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Notes?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| behaviour | "JournalList" | "JournalList" | Behaviour |  |
| methodName | "GetPlayerDataKillsName" | "GetPlayerDataKillsName" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var pdKillsName =  | Var pdKillsName =  | Variable | Store Result |

##### 2. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "fillJournal" | "fillJournal" |  |  |
| isTrue | Event(NOTES) | Event(NOTES) |  |  |
| isFalse | Event() | Event() |  |  |

##### 3. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | string pdKillsName | string pdKillsName |  |  |
| storeValue | int PD Kills | int PD Kills | Variable |  |

##### 4. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int PD Kills | int PD Kills |  |  |
| integer2 | 0 | 0 |  |  |
| equal | Event(NOTES) | Event(NOTES) |  |  |
| lessThan | Event(NOTES) | Event(NOTES) |  |  |
| greaterThan | Event(NO NOTES) | Event(NO NOTES) |  |  |
| everyFrame | false | false |  |  |

### Get Notes

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetTextMeshProColor

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Item Notes | OwnerDefault Item Notes |  |  |
| color | Color(1, 1, 1, 1) | Color(1, 1, 1, 1) |  |  |
| everyFrame | false | false |  |  |

##### 2. SetFsmColor

Full Name: HutongGames.PlayMaker.Actions.SetFsmColor
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Item Notes | OwnerDefault Item Notes |  |  |
| fsmName | "up_color" | "up_color" | FsmName |  |
| variableName | "Up Colour" | "Up Colour" | FsmColor |  |
| setValue | Color(1, 1, 1, 1) | Color(1, 1, 1, 1) |  |  |
| everyFrame | false | false |  |  |

##### 3. SetMaterialColor

Full Name: HutongGames.PlayMaker.Actions.SetMaterialColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hunter Symbol | OwnerDefault Hunter Symbol |  |  |
| materialIndex | 0 | 0 |  |  |
| material | [FsmMaterial not implemented] | [FsmMaterial not implemented] |  |  |
| namedColor | "_Color" | "_Color" | NamedColor |  |
| color | Color(1, 1, 1, 1) | Color(1, 1, 1, 1) |  |  |
| everyFrame | false | false |  |  |

##### 4. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| behaviour | "JournalList" | "JournalList" | Behaviour |  |
| methodName | "GetNotesConvo" | "GetNotesConvo" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var Item Notes Convo =  | Var Item Notes Convo =  | Variable | Store Result |

##### 5. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Journal" | "Journal" |  |  |
| convName | string Item Notes Convo | string Item Notes Convo |  |  |
| storeValue | string Item notes String | string Item notes String | Variable |  |

##### 6. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Item Notes | OwnerDefault Item Notes |  |  |
| textString | string Item notes String | string Item notes String |  |  |

### Display Kills

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetTextMeshProColor

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Item Notes | OwnerDefault Item Notes |  |  |
| color | Color(0.4705882, 0.4705882, 0.4705882, 1) | Color(0.4705882, 0.4705882, 0.4705882, 1) |  |  |
| everyFrame | false | false |  |  |

##### 2. SetFsmColor

Full Name: HutongGames.PlayMaker.Actions.SetFsmColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Item Notes | OwnerDefault Item Notes |  |  |
| fsmName | "up_color" | "up_color" | FsmName |  |
| variableName | "Up Colour" | "Up Colour" | FsmColor |  |
| setValue | Color(0.4705882, 0.4705882, 0.4705882, 1) | Color(0.4705882, 0.4705882, 0.4705882, 1) |  |  |
| everyFrame | false | false |  |  |

##### 3. SetMaterialColor

Full Name: HutongGames.PlayMaker.Actions.SetMaterialColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hunter Symbol | OwnerDefault Hunter Symbol |  |  |
| materialIndex | 0 | 0 |  |  |
| material | [FsmMaterial not implemented] | [FsmMaterial not implemented] |  |  |
| namedColor | "_Color" | "_Color" | NamedColor |  |
| color | Color(0.4705882, 0.4705882, 0.4705882, 1) | Color(0.4705882, 0.4705882, 0.4705882, 1) |  |  |
| everyFrame | false | false |  |  |

##### 4. ConvertIntToString

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int PD Kills | int PD Kills | Variable |  |
| stringVariable | string Kills String | string Kills String | Variable |  |
| format | "" | "" |  |  |
| everyFrame | false | false |  |  |

##### 5. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | " " | " " |  |  |
| addToEnd | false | false |  |  |
| storeResult | string Item notes String | string Item notes String | Variable |  |
| everyFrame | false | false |  |  |

##### 6. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Item Notes | OwnerDefault Item Notes |  |  |
| textString | string Item notes String | string Item notes String |  |  |

### Init Pos

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. ConvertIntToFloat

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Current Item | int Current Item | Variable |  |
| floatVariable | float To Y | float To Y | Variable |  |
| everyFrame | false | false |  |  |

##### 2. FloatMultiply

Full Name: HutongGames.PlayMaker.Actions.FloatMultiply
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float To Y | float To Y | Variable |  |
| multiplyBy | float Move Y | float Move Y |  |  |
| everyFrame | false | false |  |  |

##### 3. FloatAdd

Full Name: HutongGames.PlayMaker.Actions.FloatAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float To Y | float To Y | Variable |  |
| add | -7.16f | -7.16f |  |  |
| everyFrame | false | false |  |  |
| perSecond | false | false |  |  |

##### 4. SetVector3XYZ

Full Name: HutongGames.PlayMaker.Actions.SetVector3XYZ
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable | Vector3 Move To Pos | Vector3 Move To Pos | Variable |  |
| vector3Value | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | -7.99f | -7.99f |  |  |
| y | float To Y | float To Y |  |  |
| z | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 5. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector3 Move To Pos | Vector3 Move To Pos | Variable |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

### New Item?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| behaviour | "JournalList" | "JournalList" | Behaviour |  |
| methodName | "GetFirstNewItem" | "GetFirstNewItem" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var First New Item = 0 | Var First New Item = 0 | Variable | Store Result |

##### 2. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int First New Item | int First New Item |  |  |
| integer2 | -1 | -1 |  |  |
| equal | Event(CANCEL) | Event(CANCEL) |  |  |
| lessThan | Event(CANCEL) | Event(CANCEL) |  |  |
| greaterThan | Event(NEW ITEM) | Event(NEW ITEM) |  |  |
| everyFrame | false | false |  |  |

### Prev Item

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "lastJournalItem" | "lastJournalItem" |  |  |
| storeValue | int Current Item | int Current Item | Variable |  |

### New Item

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Current Item | int Current Item | Variable |  |
| intValue | int First New Item | int First New Item |  |  |
| everyFrame | false | false |  |  |

### RS Up

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Current Item | int Current Item |  |  |
| integer2 | 0 | 0 |  |  |
| equal | Event(CANCEL) | Event(CANCEL) |  |  |
| lessThan | Event(CANCEL) | Event(CANCEL) |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 2. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Current Item | int Current Item | Variable |  |
| add | -6 | -6 |  |  |
| everyFrame | false | false |  |  |

##### 3. IntClamp

Full Name: HutongGames.PlayMaker.Actions.IntClamp
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Current Item | int Current Item | Variable |  |
| minValue | 0 | 0 |  |  |
| maxValue | int Item Count | int Item Count |  |  |
| everyFrame | false | false |  |  |

##### 4. SetGameObject

Full Name: HutongGames.PlayMaker.Actions.SetGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variable | GameObject Arrow To Move | GameObject Arrow To Move | Variable |  |
| gameObject | GameObject Arrow U | GameObject Arrow U |  |  |
| everyFrame | false | false |  |  |

##### 5. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Arrow To Move | EventTarget(GameObject):Arrow To Move |  |  |
| sendEvent | "MOVE" | "MOVE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 6. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player UI (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player UI (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [ui_change_selection (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets0.assets)] | [ui_change_selection (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets0.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 0.65f | 0.65f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

### RS Down

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Current Item | int Current Item |  |  |
| integer2 | int Item Count | int Item Count |  |  |
| equal | Event(CANCEL) | Event(CANCEL) |  |  |
| lessThan | Event() | Event() |  |  |
| greaterThan | Event(CANCEL) | Event(CANCEL) |  |  |
| everyFrame | false | false |  |  |

##### 2. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Current Item | int Current Item | Variable |  |
| add | 6 | 6 |  |  |
| everyFrame | false | false |  |  |

##### 3. IntClamp

Full Name: HutongGames.PlayMaker.Actions.IntClamp
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Current Item | int Current Item | Variable |  |
| minValue | 0 | 0 |  |  |
| maxValue | int Item Count | int Item Count |  |  |
| everyFrame | false | false |  |  |

##### 4. SetGameObject

Full Name: HutongGames.PlayMaker.Actions.SetGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variable | GameObject Arrow To Move | GameObject Arrow To Move | Variable |  |
| gameObject | GameObject Arrow D | GameObject Arrow D |  |  |
| everyFrame | false | false |  |  |

##### 5. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Arrow To Move | EventTarget(GameObject):Arrow To Move |  |  |
| sendEvent | "MOVE" | "MOVE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 6. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player UI (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player UI (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [ui_change_selection (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets0.assets)] | [ui_change_selection (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets0.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 0.65f | 0.65f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

### Check inc

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Increment Up | int Increment Up | Variable |  |
| intValue | -1 | -1 |  |  |
| everyFrame | false | false |  |  |

##### 2. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Increment Down | int Increment Down | Variable |  |
| intValue | 1 | 1 |  |  |
| everyFrame | false | false |  |  |

##### 3. GetFsmInt

Full Name: HutongGames.PlayMaker.Actions.GetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "ui_list_getinput" | "ui_list_getinput" | FsmName |  |
| variableName | "Repeats" | "Repeats" | FsmInt |  |
| storeValue | int Repeats | int Repeats | Variable |  |
| everyFrame | false | false |  |  |

##### 4. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Repeats | int Repeats |  |  |
| integer2 | int Repeats Number | int Repeats Number |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event(FINISHED) | Event(FINISHED) |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 5. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Increment Up | int Increment Up | Variable |  |
| intValue | int Repeat Inc Up | int Repeat Inc Up |  |  |
| everyFrame | false | false |  |  |

##### 6. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Increment Down | int Increment Down | Variable |  |
| intValue | int Repeat Inc Down | int Repeat Inc Down |  |  |
| everyFrame | false | false |  |  |

### Check inc 1

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Increment Up | int Increment Up | Variable |  |
| intValue | -1 | -1 |  |  |
| everyFrame | false | false |  |  |

##### 2. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Increment Down | int Increment Down | Variable |  |
| intValue | 1 | 1 |  |  |
| everyFrame | false | false |  |  |

##### 3. GetFsmInt

Full Name: HutongGames.PlayMaker.Actions.GetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "ui_list_getinput" | "ui_list_getinput" | FsmName |  |
| variableName | "Repeats" | "Repeats" | FsmInt |  |
| storeValue | int Repeats | int Repeats | Variable |  |
| everyFrame | false | false |  |  |

##### 4. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Repeats | int Repeats |  |  |
| integer2 | int Repeats Number | int Repeats Number |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event(FINISHED) | Event(FINISHED) |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 5. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Increment Up | int Increment Up | Variable |  |
| intValue | int Repeat Inc Up | int Repeat Inc Up |  |  |
| everyFrame | false | false |  |  |

##### 6. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Increment Down | int Increment Down | Variable |  |
| intValue | int Repeat Inc Down | int Repeat Inc Down |  |  |
| everyFrame | false | false |  |  |

### Check inc 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Increment Up | int Increment Up | Variable |  |
| intValue | -1 | -1 |  |  |
| everyFrame | false | false |  |  |

##### 2. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Increment Down | int Increment Down | Variable |  |
| intValue | 1 | 1 |  |  |
| everyFrame | false | false |  |  |

##### 3. GetFsmInt

Full Name: HutongGames.PlayMaker.Actions.GetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "ui_list_getinput" | "ui_list_getinput" | FsmName |  |
| variableName | "Repeats" | "Repeats" | FsmInt |  |
| storeValue | int Repeats | int Repeats | Variable |  |
| everyFrame | false | false |  |  |

##### 4. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Repeats | int Repeats |  |  |
| integer2 | int Repeats Number | int Repeats Number |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event(FINISHED) | Event(FINISHED) |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 5. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Increment Up | int Increment Up | Variable |  |
| intValue | int Repeat Inc Up | int Repeat Inc Up |  |  |
| everyFrame | false | false |  |  |

##### 6. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Increment Down | int Increment Down | Variable |  |
| intValue | int Repeat Inc Down | int Repeat Inc Down |  |  |
| everyFrame | false | false |  |  |

### Arrow L

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. SetMaterialColor

Full Name: HutongGames.PlayMaker.Actions.SetMaterialColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Selector | OwnerDefault Selector |  |  |
| materialIndex | 0 | 0 |  |  |
| material | [FsmMaterial not implemented] | [FsmMaterial not implemented] |  |  |
| namedColor | "_Color" | "_Color" | NamedColor |  |
| color | Color(1, 1, 1, 0.522) | Color(1, 1, 1, 0.522) |  |  |
| everyFrame | false | false |  |  |

##### 2. SetSpriteRendererOrder

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRendererOrder
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Cursor Glow | OwnerDefault Cursor Glow |  |  |
| order | 10 | 10 |  |  |
| delay | 0.15f | 0.15f |  |  |

##### 3. SetSpriteRenderer

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Arrow U | OwnerDefault Arrow U |  |  |
| active | false | false |  |  |

##### 4. SetSpriteRenderer

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Arrow D | OwnerDefault Arrow D |  |  |
| active | false | false |  |  |

##### 5. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Cursor | EventTarget(GameObject):Cursor |  |  |
| sendEvent | "CURSOR ACTIVATE" | "CURSOR ACTIVATE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 6. SetFsmGameObject

Full Name: HutongGames.PlayMaker.Actions.SetFsmGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Update Cursor" | "Update Cursor" | FsmName |  |
| variableName | "Item" | "Item" | FsmGameObject |  |
| setValue | GameObject Arrow L | GameObject Arrow L |  |  |
| everyFrame | false | false |  |  |

##### 7. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "UPDATE CURSOR" | "UPDATE CURSOR" |  |  |
| delay | 0.01f | 0.01f |  |  |
| everyFrame | false | false |  |  |

### Arrow R

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Cursor | EventTarget(GameObject):Cursor |  |  |
| sendEvent | "CURSOR ACTIVATE" | "CURSOR ACTIVATE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. SetSpriteRendererOrder

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRendererOrder
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Cursor Glow | OwnerDefault Cursor Glow |  |  |
| order | 10 | 10 |  |  |
| delay | 0.15f | 0.15f |  |  |

##### 3. SetSpriteRenderer

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Arrow U | OwnerDefault Arrow U |  |  |
| active | false | false |  |  |

##### 4. SetSpriteRenderer

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Arrow D | OwnerDefault Arrow D |  |  |
| active | false | false |  |  |

##### 5. SetMaterialColor

Full Name: HutongGames.PlayMaker.Actions.SetMaterialColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Selector | OwnerDefault Selector |  |  |
| materialIndex | 0 | 0 |  |  |
| material | [FsmMaterial not implemented] | [FsmMaterial not implemented] |  |  |
| namedColor | "_Color" | "_Color" | NamedColor |  |
| color | Color(1, 1, 1, 0.522) | Color(1, 1, 1, 0.522) |  |  |
| everyFrame | false | false |  |  |

##### 6. SetFsmGameObject

Full Name: HutongGames.PlayMaker.Actions.SetFsmGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Update Cursor" | "Update Cursor" | FsmName |  |
| variableName | "Item" | "Item" | FsmGameObject |  |
| setValue | GameObject Arrow R | GameObject Arrow R |  |  |
| everyFrame | false | false |  |  |

##### 7. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "UPDATE CURSOR" | "UPDATE CURSOR" |  |  |
| delay | 0.01f | 0.01f |  |  |
| everyFrame | false | false |  |  |

### Back to Mid

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Cursor | EventTarget(GameObject):Cursor |  |  |
| sendEvent | "CURSOR ACTIVATE" | "CURSOR ACTIVATE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. SetSpriteRendererOrder

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRendererOrder
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Cursor Glow | OwnerDefault Cursor Glow |  |  |
| order | 0 | 0 |  |  |
| delay | 0.15f | 0.15f |  |  |

##### 3. SetFsmGameObject

Full Name: HutongGames.PlayMaker.Actions.SetFsmGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Update Cursor" | "Update Cursor" | FsmName |  |
| variableName | "Item" | "Item" | FsmGameObject |  |
| setValue | GameObject Selector | GameObject Selector |  |  |
| everyFrame | false | false |  |  |

##### 4. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "UPDATE CURSOR" | "UPDATE CURSOR" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 5. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.2f | 0.2f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Cursor Down

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Cursor | EventTarget(GameObject):Cursor |  |  |
| sendEvent | "DOWN" | "DOWN" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Reset Cursor

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Cursor | EventTarget(GameObject):Cursor |  |  |
| sendEvent | "DOWN" | "DOWN" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:FSM Owner | EventTarget(GameObject)[SendToChildren]:FSM Owner |  |  |
| sendEvent | "SHIFT INSTANT" | "SHIFT INSTANT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Type

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| behaviour | "JournalList" | "JournalList" | Behaviour |  |
| methodName | "GetWarriorGhost" | "GetWarriorGhost" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var Is Ghost = False | Var Is Ghost = False | Variable | Store Result |

##### 2. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| behaviour | "JournalList" | "JournalList" | Behaviour |  |
| methodName | "GetGrimm" | "GetGrimm" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var Is Grimm = False | Var Is Grimm = False | Variable | Store Result |

##### 3. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Is Ghost | bool Is Ghost | Variable |  |
| isTrue | Event(GHOST) | Event(GHOST) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 4. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Is Grimm | bool Is Grimm | Variable |  |
| isTrue | Event(GRIMM) | Event(GRIMM) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

### Ghost

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetSpriteRendererSprite

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRendererSprite
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hunter Symbol | OwnerDefault Hunter Symbol |  |  |
| sprite | [ghost_symbol (Sprite) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [ghost_symbol (Sprite) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |

### Normal

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetSpriteRendererSprite

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRendererSprite
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hunter Symbol | OwnerDefault Hunter Symbol |  |  |
| sprite | [hunter_symbol (Sprite) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [hunter_symbol (Sprite) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |

### Reset

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Cursor | EventTarget(GameObject):Cursor |  |  |
| sendEvent | "DOWN" | "DOWN" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Grimm

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetSpriteRendererSprite

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRendererSprite
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hunter Symbol | OwnerDefault Hunter Symbol |  |  |
| sprite | [grimm_symbol (Sprite) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [grimm_symbol (Sprite) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Init | FINISHED | New Item? | 0 | 0 | 0 |
| Idle | UI UP | Check Up | 0 | 0 | 0 |
| Idle | UI DOWN | Check Down | 0 | 0 | 0 |
| Idle | UI LEFT | Arrow L | 0 | 0 | 0 |
| Idle | UI RIGHT | Arrow R | 0 | 0 | 0 |
| Idle | UI RS DOWN | RS Down | 0 | 0 | 0 |
| Idle | UI RS UP | RS Up | 0 | 0 | 0 |
| Check Down | CANCEL | Fail Down | 0 | 0 | 0 |
| Check Down | FINISHED | Check inc 2 | 0 | 0 | 0 |
| Fail Down | FINISHED | Get Details | 0 | 0 | 0 |
| Fail Down | MOVETO | Get Details | 0 | 0 | 0 |
| Fail Down | UI UP | Check Up | 0 | 0 | 0 |
| Fail Down | UI RS UP | RS Up | 0 | 0 | 0 |
| Move Down | UI DOWN | Check Down | 0 | 0 | 0 |
| Move Down | FINISHED | Get Details | 0 | 0 | 0 |
| Move Down | UI UP | Check Up | 0 | 0 | 0 |
| Check Up | CANCEL | Fail Up | 0 | 0 | 0 |
| Check Up | FINISHED | Check inc 1 | 0 | 0 | 0 |
| Fail Up | FINISHED | Get Details | 0 | 0 | 0 |
| Fail Up | MOVETO | Get Details | 0 | 0 | 0 |
| Fail Up | UI DOWN | Check Down | 0 | 0 | 0 |
| Fail Up | UI RS DOWN | RS Down | 0 | 0 | 0 |
| Move Up | UI DOWN | Check Down | 0 | 0 | 0 |
| Move Up | FINISHED | Get Details | 0 | 0 | 0 |
| Move Up | UI UP | Check Up | 0 | 0 | 0 |
| MoveTo | FINISHED | Idle | 0 | 0 | 0 |
| MoveTo | UI UP | Check Up | 0 | 0 | 0 |
| MoveTo | UI DOWN | Check Down | 0 | 0 | 0 |
| MoveTo | UI RS DOWN | RS Down | 0 | 0 | 0 |
| MoveTo | UI RS UP | RS Up | 0 | 0 | 0 |
| Get Details | FINISHED | Notes? | 0 | 0 | 0 |
| Move Pane L | FINISHED | Idle | 0 | 0 | 0 |
| Move Pane L | CANCEL | Arrow L | 0 | 0 | 0 |
| Move Pane R | FINISHED | Idle | 0 | 0 | 0 |
| Move Pane R | CANCEL | Arrow R | 0 | 0 | 0 |
| Notes? | NO NOTES | Display Kills | 0 | 0 | 0 |
| Notes? | NOTES | Get Notes | 0 | 0 | 0 |
| Get Notes | FINISHED | Type | 0 | 0 | 0 |
| Display Kills | FINISHED | Type | 0 | 0 | 0 |
| Init Pos | FINISHED | Reset Cursor | 0 | 0 | 0 |
| New Item? | CANCEL | Prev Item | 0 | 0 | 0 |
| New Item? | NEW ITEM | New Item | 0 | 0 | 0 |
| Prev Item | FINISHED | Init Pos | 0 | 0 | 0 |
| New Item | FINISHED | Init Pos | 0 | 0 | 0 |
| RS Up | CANCEL | Fail Up | 0 | 0 | 0 |
| RS Up | FINISHED | Get Details | 0 | 0 | 0 |
| RS Down | CANCEL | Fail Down | 0 | 0 | 0 |
| RS Down | FINISHED | Get Details | 0 | 0 | 0 |
| Check inc | FINISHED | Notes? | 0 | 0 | 0 |
| Check inc 1 | FINISHED | Move Up | 0 | 0 | 0 |
| Check inc 2 | FINISHED | Move Down | 0 | 0 | 0 |
| Arrow L | UI LEFT | Move Pane L | 0 | 0 | 0 |
| Arrow L | UI CONFIRM | Move Pane L | 0 | 0 | 0 |
| Arrow L | UI RIGHT | Back to Mid | 0 | 0 | 0 |
| Arrow R | UI RIGHT | Move Pane R | 0 | 0 | 0 |
| Arrow R | UI CONFIRM | Move Pane R | 0 | 0 | 0 |
| Arrow R | UI LEFT | Back to Mid | 0 | 0 | 0 |
| Back to Mid | FINISHED | Cursor Down | 0 | 0 | 0 |
| Cursor Down | FINISHED | Idle | 0 | 0 | 0 |
| Reset Cursor | FINISHED | Get Details | 0 | 0 | 0 |
| Type | GHOST | Ghost | 0 | 0 | 0 |
| Type | FINISHED | Normal | 0 | 0 | 0 |
| Type | GRIMM | Grimm | 0 | 0 | 0 |
| Ghost | FINISHED | MoveTo | 0 | 0 | 0 |
| Normal | FINISHED | MoveTo | 0 | 0 | 0 |
| Reset | FINISHED | Idle | 0 | 0 | 0 |
| Grimm | FINISHED | MoveTo | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| RESET | Reset | 0 | 0 | 0 |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| CANCEL | false |
| GHOST | false |
| GRIMM | false |
| MOVETO | false |
| NEW ITEM | false |
| NO NOTES | false |
| NOTES | false |
| RESET | false |
| UI CONFIRM | false |
| UI DOWN | false |
| UI LEFT | false |
| UI RIGHT | false |
| UI RS DOWN | false |
| UI RS UP | false |
| UI UP | false |

