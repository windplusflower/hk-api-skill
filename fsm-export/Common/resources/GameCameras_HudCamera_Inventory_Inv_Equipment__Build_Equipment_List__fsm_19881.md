# Build Equipment List

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Build Equipment List |
| GameObject Name | Equipment |
| GameObject Path | _GameCameras/HudCamera/Inventory/Inv |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Init |
| FSM PathId | 19881 |
| GameObject PathId | 5661 |

## Variables

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Equipment Slots Filled | 0 | Int32: 0 |
| Items | 0 | Int32: 0 |
| Next Item Num | 0 | Int32: 0 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Has Map | false | Boolean: false |
| Has Quill | false | Boolean: false |
| Max Shifted | false | Boolean: false |

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| Desc variable Name |  | String:  |
| GO Variable Name |  | String:  |
| Item num String |  | String:  |
| Title Variable Name |  | String:  |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Current Item | [null] | NamedAssetPPtr:  |
| Inv Top | [null] | NamedAssetPPtr:  |
| Self | [null] | NamedAssetPPtr:  |
| Trinket Backboard | _GameCameras/HudCamera/Inventory/Inv/trinket_backboard (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets) | NamedAssetPPtr: _GameCameras/HudCamera/Inventory/Inv/trinket_backboard (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets) |

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
| storeResult | GameObject Inv Top | GameObject Inv Top | Variable |  |

##### 3. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Next Item Num | int Next Item Num | Variable |  |
| intValue | 1 | 1 |  |  |
| everyFrame | false | false |  |  |

##### 4. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Equipment Slots Filled | int Equipment Slots Filled | Variable |  |
| intValue | 0 | 0 |  |  |
| everyFrame | false | false |  |  |

##### 5. ActivateAllChildren

Full Name: HutongGames.PlayMaker.Actions.ActivateAllChildren
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Self | GameObject Self | Variable |  |
| activate | false | false |  |  |

##### 6. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Max Shifted | bool Max Shifted | Variable |  |
| boolValue | false | false |  |  |
| everyFrame | false | false |  |  |

### Dash

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
| boolName | "hasDash" | "hasDash" |  |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(FINISHED) | Event(FINISHED) |  |  |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Dash Cloak" | "Dash Cloak" |  |  |
| storeResult | GameObject Current Item | GameObject Current Item | Variable |  |

##### 3. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Equipment Slots Filled | int Equipment Slots Filled | Variable |  |
| add | 1 | 1 |  |  |
| everyFrame | false | false |  |  |

##### 4. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Current Item | OwnerDefault Current Item |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 5. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Current Item | OwnerDefault Current Item |  |  |
| fsmName | "equip_position" | "equip_position" | FsmName |  |
| variableName | "Item Number" | "Item Number" | FsmInt |  |
| setValue | int Next Item Num | int Next Item Num |  |  |
| everyFrame | false | false |  |  |

##### 6. ConvertIntToString

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Next Item Num | int Next Item Num | Variable |  |
| stringVariable | string Item num String | string Item num String | Variable |  |
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
| storeResult | string GO Variable Name | string GO Variable Name | Variable |  |
| everyFrame | false | false |  |  |

##### 8. SetFsmGameObject

Full Name: HutongGames.PlayMaker.Actions.SetFsmGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inv Top | OwnerDefault Inv Top |  |  |
| fsmName | "UI Inventory" | "UI Inventory" | FsmName |  |
| variableName | string GO Variable Name | string GO Variable Name | FsmGameObject |  |
| setValue | GameObject Current Item | GameObject Current Item |  |  |
| everyFrame | false | false |  |  |

##### 9. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string Title Variable Name | string Title Variable Name | Variable |  |
| everyFrame | false | false |  |  |

##### 10. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string Desc variable Name | string Desc variable Name | Variable |  |
| everyFrame | false | false |  |  |

##### 11. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inv Top | OwnerDefault Inv Top |  |  |
| fsmName | "UI Inventory" | "UI Inventory" | FsmName |  |
| variableName | string Title Variable Name | string Title Variable Name | FsmString |  |
| setValue | "INV_NAME_DASH" | "INV_NAME_DASH" |  |  |
| everyFrame | false | false |  |  |

##### 12. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inv Top | OwnerDefault Inv Top |  |  |
| fsmName | "UI Inventory" | "UI Inventory" | FsmName |  |
| variableName | string Desc variable Name | string Desc variable Name | FsmString |  |
| setValue | "INV_DESC_DASH" | "INV_DESC_DASH" |  |  |
| everyFrame | false | false |  |  |

##### 13. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Next Item Num | int Next Item Num | Variable |  |
| add | 1 | 1 |  |  |
| everyFrame | false | false |  |  |

##### 14. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "hasShadowDash" | "hasShadowDash" |  |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(FINISHED) | Event(FINISHED) |  |  |

##### 15. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inv Top | OwnerDefault Inv Top |  |  |
| fsmName | "UI Inventory" | "UI Inventory" | FsmName |  |
| variableName | string Title Variable Name | string Title Variable Name | FsmString |  |
| setValue | "INV_NAME_SHADOWDASH" | "INV_NAME_SHADOWDASH" |  |  |
| everyFrame | false | false |  |  |

##### 16. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inv Top | OwnerDefault Inv Top |  |  |
| fsmName | "UI Inventory" | "UI Inventory" | FsmName |  |
| variableName | string Desc variable Name | string Desc variable Name | FsmString |  |
| setValue | "INV_DESC_SHADOWDASH" | "INV_DESC_SHADOWDASH" |  |  |
| everyFrame | false | false |  |  |

##### 17. SetSpriteRendererSprite

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRendererSprite
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Current Item | OwnerDefault Current Item |  |  |
| sprite | [items__0004_shade_cloak (Sprite) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [items__0004_shade_cloak (Sprite) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |

### Walljump

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
| boolName | "hasWalljump" | "hasWalljump" |  |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(FINISHED) | Event(FINISHED) |  |  |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Mantis Claw" | "Mantis Claw" |  |  |
| storeResult | GameObject Current Item | GameObject Current Item | Variable |  |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Current Item | OwnerDefault Current Item |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 4. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Current Item | OwnerDefault Current Item |  |  |
| fsmName | "equip_position" | "equip_position" | FsmName |  |
| variableName | "Item Number" | "Item Number" | FsmInt |  |
| setValue | int Next Item Num | int Next Item Num |  |  |
| everyFrame | false | false |  |  |

##### 5. ConvertIntToString

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Next Item Num | int Next Item Num | Variable |  |
| stringVariable | string Item num String | string Item num String | Variable |  |
| format | "" | "" |  |  |
| everyFrame | false | false |  |  |

##### 6. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string GO Variable Name | string GO Variable Name | Variable |  |
| everyFrame | false | false |  |  |

##### 7. SetFsmGameObject

Full Name: HutongGames.PlayMaker.Actions.SetFsmGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inv Top | OwnerDefault Inv Top |  |  |
| fsmName | "UI Inventory" | "UI Inventory" | FsmName |  |
| variableName | string GO Variable Name | string GO Variable Name | FsmGameObject |  |
| setValue | GameObject Current Item | GameObject Current Item |  |  |
| everyFrame | false | false |  |  |

##### 8. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string Title Variable Name | string Title Variable Name | Variable |  |
| everyFrame | false | false |  |  |

##### 9. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string Desc variable Name | string Desc variable Name | Variable |  |
| everyFrame | false | false |  |  |

##### 10. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inv Top | OwnerDefault Inv Top |  |  |
| fsmName | "UI Inventory" | "UI Inventory" | FsmName |  |
| variableName | string Title Variable Name | string Title Variable Name | FsmString |  |
| setValue | "INV_NAME_WALLJUMP" | "INV_NAME_WALLJUMP" |  |  |
| everyFrame | false | false |  |  |

##### 11. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inv Top | OwnerDefault Inv Top |  |  |
| fsmName | "UI Inventory" | "UI Inventory" | FsmName |  |
| variableName | string Desc variable Name | string Desc variable Name | FsmString |  |
| setValue | "INV_DESC_WALLJUMP" | "INV_DESC_WALLJUMP" |  |  |
| everyFrame | false | false |  |  |

##### 12. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Next Item Num | int Next Item Num | Variable |  |
| add | 1 | 1 |  |  |
| everyFrame | false | false |  |  |

##### 13. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Equipment Slots Filled | int Equipment Slots Filled | Variable |  |
| add | 1 | 1 |  |  |
| everyFrame | false | false |  |  |

### Super Dash

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
| boolName | "hasSuperDash" | "hasSuperDash" |  |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(FINISHED) | Event(FINISHED) |  |  |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Super Dash" | "Super Dash" |  |  |
| storeResult | GameObject Current Item | GameObject Current Item | Variable |  |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Current Item | OwnerDefault Current Item |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 4. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Current Item | OwnerDefault Current Item |  |  |
| fsmName | "equip_position" | "equip_position" | FsmName |  |
| variableName | "Item Number" | "Item Number" | FsmInt |  |
| setValue | int Next Item Num | int Next Item Num |  |  |
| everyFrame | false | false |  |  |

##### 5. ConvertIntToString

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Next Item Num | int Next Item Num | Variable |  |
| stringVariable | string Item num String | string Item num String | Variable |  |
| format | "" | "" |  |  |
| everyFrame | false | false |  |  |

##### 6. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string GO Variable Name | string GO Variable Name | Variable |  |
| everyFrame | false | false |  |  |

##### 7. SetFsmGameObject

Full Name: HutongGames.PlayMaker.Actions.SetFsmGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inv Top | OwnerDefault Inv Top |  |  |
| fsmName | "UI Inventory" | "UI Inventory" | FsmName |  |
| variableName | string GO Variable Name | string GO Variable Name | FsmGameObject |  |
| setValue | GameObject Current Item | GameObject Current Item |  |  |
| everyFrame | false | false |  |  |

##### 8. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string Title Variable Name | string Title Variable Name | Variable |  |
| everyFrame | false | false |  |  |

##### 9. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string Desc variable Name | string Desc variable Name | Variable |  |
| everyFrame | false | false |  |  |

##### 10. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inv Top | OwnerDefault Inv Top |  |  |
| fsmName | "UI Inventory" | "UI Inventory" | FsmName |  |
| variableName | string Title Variable Name | string Title Variable Name | FsmString |  |
| setValue | "INV_NAME_SUPERDASH" | "INV_NAME_SUPERDASH" |  |  |
| everyFrame | false | false |  |  |

##### 11. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inv Top | OwnerDefault Inv Top |  |  |
| fsmName | "UI Inventory" | "UI Inventory" | FsmName |  |
| variableName | string Desc variable Name | string Desc variable Name | FsmString |  |
| setValue | "INV_DESC_SUPERDASH" | "INV_DESC_SUPERDASH" |  |  |
| everyFrame | false | false |  |  |

##### 12. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Next Item Num | int Next Item Num | Variable |  |
| add | 1 | 1 |  |  |
| everyFrame | false | false |  |  |

##### 13. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Equipment Slots Filled | int Equipment Slots Filled | Variable |  |
| add | 1 | 1 |  |  |
| everyFrame | false | false |  |  |

### Dream Nail

Description: Deprecated
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "hasDreamNail" | "hasDreamNail" |  |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(FINISHED) | Event(FINISHED) |  |  |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Dream Nail" | "Dream Nail" |  |  |
| storeResult | GameObject Current Item | GameObject Current Item | Variable |  |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Current Item | OwnerDefault Current Item |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 4. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Current Item | OwnerDefault Current Item |  |  |
| fsmName | "equip_position" | "equip_position" | FsmName |  |
| variableName | "Item Number" | "Item Number" | FsmInt |  |
| setValue | int Next Item Num | int Next Item Num |  |  |
| everyFrame | false | false |  |  |

##### 5. ConvertIntToString

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Next Item Num | int Next Item Num | Variable |  |
| stringVariable | string Item num String | string Item num String | Variable |  |
| format | "" | "" |  |  |
| everyFrame | false | false |  |  |

##### 6. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string GO Variable Name | string GO Variable Name | Variable |  |
| everyFrame | false | false |  |  |

##### 7. SetFsmGameObject

Full Name: HutongGames.PlayMaker.Actions.SetFsmGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inv Top | OwnerDefault Inv Top |  |  |
| fsmName | "UI Inventory" | "UI Inventory" | FsmName |  |
| variableName | string GO Variable Name | string GO Variable Name | FsmGameObject |  |
| setValue | GameObject Current Item | GameObject Current Item |  |  |
| everyFrame | false | false |  |  |

##### 8. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string Title Variable Name | string Title Variable Name | Variable |  |
| everyFrame | false | false |  |  |

##### 9. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string Desc variable Name | string Desc variable Name | Variable |  |
| everyFrame | false | false |  |  |

##### 10. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inv Top | OwnerDefault Inv Top |  |  |
| fsmName | "UI Inventory" | "UI Inventory" | FsmName |  |
| variableName | string Title Variable Name | string Title Variable Name | FsmString |  |
| setValue | "INV_NAME_DREAMNAIL" | "INV_NAME_DREAMNAIL" |  |  |
| everyFrame | false | false |  |  |

##### 11. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inv Top | OwnerDefault Inv Top |  |  |
| fsmName | "UI Inventory" | "UI Inventory" | FsmName |  |
| variableName | string Desc variable Name | string Desc variable Name | FsmString |  |
| setValue | "INV_DESC_DREAMNAIL" | "INV_DESC_DREAMNAIL" |  |  |
| everyFrame | false | false |  |  |

##### 12. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Next Item Num | int Next Item Num | Variable |  |
| add | 1 | 1 |  |  |
| everyFrame | false | false |  |  |

### Lantern

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
| boolName | "hasLantern" | "hasLantern" |  |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(FINISHED) | Event(FINISHED) |  |  |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Lantern" | "Lantern" |  |  |
| storeResult | GameObject Current Item | GameObject Current Item | Variable |  |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Current Item | OwnerDefault Current Item |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 4. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Current Item | OwnerDefault Current Item |  |  |
| fsmName | "equip_position" | "equip_position" | FsmName |  |
| variableName | "Item Number" | "Item Number" | FsmInt |  |
| setValue | int Next Item Num | int Next Item Num |  |  |
| everyFrame | false | false |  |  |

##### 5. ConvertIntToString

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Next Item Num | int Next Item Num | Variable |  |
| stringVariable | string Item num String | string Item num String | Variable |  |
| format | "" | "" |  |  |
| everyFrame | false | false |  |  |

##### 6. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string GO Variable Name | string GO Variable Name | Variable |  |
| everyFrame | false | false |  |  |

##### 7. SetFsmGameObject

Full Name: HutongGames.PlayMaker.Actions.SetFsmGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inv Top | OwnerDefault Inv Top |  |  |
| fsmName | "UI Inventory" | "UI Inventory" | FsmName |  |
| variableName | string GO Variable Name | string GO Variable Name | FsmGameObject |  |
| setValue | GameObject Current Item | GameObject Current Item |  |  |
| everyFrame | false | false |  |  |

##### 8. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string Title Variable Name | string Title Variable Name | Variable |  |
| everyFrame | false | false |  |  |

##### 9. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string Desc variable Name | string Desc variable Name | Variable |  |
| everyFrame | false | false |  |  |

##### 10. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inv Top | OwnerDefault Inv Top |  |  |
| fsmName | "UI Inventory" | "UI Inventory" | FsmName |  |
| variableName | string Title Variable Name | string Title Variable Name | FsmString |  |
| setValue | "INV_NAME_LANTERN" | "INV_NAME_LANTERN" |  |  |
| everyFrame | false | false |  |  |

##### 11. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inv Top | OwnerDefault Inv Top |  |  |
| fsmName | "UI Inventory" | "UI Inventory" | FsmName |  |
| variableName | string Desc variable Name | string Desc variable Name | FsmString |  |
| setValue | "INV_DESC_LANTERN" | "INV_DESC_LANTERN" |  |  |
| everyFrame | false | false |  |  |

##### 12. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Next Item Num | int Next Item Num | Variable |  |
| add | 1 | 1 |  |  |
| everyFrame | false | false |  |  |

##### 13. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Equipment Slots Filled | int Equipment Slots Filled | Variable |  |
| add | 1 | 1 |  |  |
| everyFrame | false | false |  |  |

### Double Jump

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
| boolName | "hasDoubleJump" | "hasDoubleJump" |  |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(FINISHED) | Event(FINISHED) |  |  |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Double Jump" | "Double Jump" |  |  |
| storeResult | GameObject Current Item | GameObject Current Item | Variable |  |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Current Item | OwnerDefault Current Item |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 4. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Current Item | OwnerDefault Current Item |  |  |
| fsmName | "equip_position" | "equip_position" | FsmName |  |
| variableName | "Item Number" | "Item Number" | FsmInt |  |
| setValue | int Next Item Num | int Next Item Num |  |  |
| everyFrame | false | false |  |  |

##### 5. ConvertIntToString

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Next Item Num | int Next Item Num | Variable |  |
| stringVariable | string Item num String | string Item num String | Variable |  |
| format | "" | "" |  |  |
| everyFrame | false | false |  |  |

##### 6. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string GO Variable Name | string GO Variable Name | Variable |  |
| everyFrame | false | false |  |  |

##### 7. SetFsmGameObject

Full Name: HutongGames.PlayMaker.Actions.SetFsmGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inv Top | OwnerDefault Inv Top |  |  |
| fsmName | "UI Inventory" | "UI Inventory" | FsmName |  |
| variableName | string GO Variable Name | string GO Variable Name | FsmGameObject |  |
| setValue | GameObject Current Item | GameObject Current Item |  |  |
| everyFrame | false | false |  |  |

##### 8. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string Title Variable Name | string Title Variable Name | Variable |  |
| everyFrame | false | false |  |  |

##### 9. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string Desc variable Name | string Desc variable Name | Variable |  |
| everyFrame | false | false |  |  |

##### 10. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inv Top | OwnerDefault Inv Top |  |  |
| fsmName | "UI Inventory" | "UI Inventory" | FsmName |  |
| variableName | string Title Variable Name | string Title Variable Name | FsmString |  |
| setValue | "INV_NAME_DOUBLEJUMP" | "INV_NAME_DOUBLEJUMP" |  |  |
| everyFrame | false | false |  |  |

##### 11. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inv Top | OwnerDefault Inv Top |  |  |
| fsmName | "UI Inventory" | "UI Inventory" | FsmName |  |
| variableName | string Desc variable Name | string Desc variable Name | FsmString |  |
| setValue | "INV_DESC_DOUBLEJUMP" | "INV_DESC_DOUBLEJUMP" |  |  |
| everyFrame | false | false |  |  |

##### 12. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Next Item Num | int Next Item Num | Variable |  |
| add | 1 | 1 |  |  |
| everyFrame | false | false |  |  |

##### 13. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Equipment Slots Filled | int Equipment Slots Filled | Variable |  |
| add | 1 | 1 |  |  |
| everyFrame | false | false |  |  |

### Acid Armour

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
| boolName | "hasAcidArmour" | "hasAcidArmour" |  |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(FINISHED) | Event(FINISHED) |  |  |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Acid Armour" | "Acid Armour" |  |  |
| storeResult | GameObject Current Item | GameObject Current Item | Variable |  |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Current Item | OwnerDefault Current Item |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 4. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Current Item | OwnerDefault Current Item |  |  |
| fsmName | "equip_position" | "equip_position" | FsmName |  |
| variableName | "Item Number" | "Item Number" | FsmInt |  |
| setValue | int Next Item Num | int Next Item Num |  |  |
| everyFrame | false | false |  |  |

##### 5. ConvertIntToString

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Next Item Num | int Next Item Num | Variable |  |
| stringVariable | string Item num String | string Item num String | Variable |  |
| format | "" | "" |  |  |
| everyFrame | false | false |  |  |

##### 6. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string GO Variable Name | string GO Variable Name | Variable |  |
| everyFrame | false | false |  |  |

##### 7. SetFsmGameObject

Full Name: HutongGames.PlayMaker.Actions.SetFsmGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inv Top | OwnerDefault Inv Top |  |  |
| fsmName | "UI Inventory" | "UI Inventory" | FsmName |  |
| variableName | string GO Variable Name | string GO Variable Name | FsmGameObject |  |
| setValue | GameObject Current Item | GameObject Current Item |  |  |
| everyFrame | false | false |  |  |

##### 8. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string Title Variable Name | string Title Variable Name | Variable |  |
| everyFrame | false | false |  |  |

##### 9. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string Desc variable Name | string Desc variable Name | Variable |  |
| everyFrame | false | false |  |  |

##### 10. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inv Top | OwnerDefault Inv Top |  |  |
| fsmName | "UI Inventory" | "UI Inventory" | FsmName |  |
| variableName | string Title Variable Name | string Title Variable Name | FsmString |  |
| setValue | "INV_NAME_ACIDARMOUR" | "INV_NAME_ACIDARMOUR" |  |  |
| everyFrame | false | false |  |  |

##### 11. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inv Top | OwnerDefault Inv Top |  |  |
| fsmName | "UI Inventory" | "UI Inventory" | FsmName |  |
| variableName | string Desc variable Name | string Desc variable Name | FsmString |  |
| setValue | "INV_DESC_ACIDARMOUR" | "INV_DESC_ACIDARMOUR" |  |  |
| everyFrame | false | false |  |  |

##### 12. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Next Item Num | int Next Item Num | Variable |  |
| add | 1 | 1 |  |  |
| everyFrame | false | false |  |  |

##### 13. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Equipment Slots Filled | int Equipment Slots Filled | Variable |  |
| add | 1 | 1 |  |  |
| everyFrame | false | false |  |  |

### Store Key

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
| boolName | "hasSlykey" | "hasSlykey" |  |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(FINISHED) | Event(FINISHED) |  |  |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Store Key" | "Store Key" |  |  |
| storeResult | GameObject Current Item | GameObject Current Item | Variable |  |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Current Item | OwnerDefault Current Item |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 4. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Current Item | OwnerDefault Current Item |  |  |
| fsmName | "equip_position" | "equip_position" | FsmName |  |
| variableName | "Item Number" | "Item Number" | FsmInt |  |
| setValue | int Next Item Num | int Next Item Num |  |  |
| everyFrame | false | false |  |  |

##### 5. ConvertIntToString

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Next Item Num | int Next Item Num | Variable |  |
| stringVariable | string Item num String | string Item num String | Variable |  |
| format | "" | "" |  |  |
| everyFrame | false | false |  |  |

##### 6. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string GO Variable Name | string GO Variable Name | Variable |  |
| everyFrame | false | false |  |  |

##### 7. SetFsmGameObject

Full Name: HutongGames.PlayMaker.Actions.SetFsmGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inv Top | OwnerDefault Inv Top |  |  |
| fsmName | "UI Inventory" | "UI Inventory" | FsmName |  |
| variableName | string GO Variable Name | string GO Variable Name | FsmGameObject |  |
| setValue | GameObject Current Item | GameObject Current Item |  |  |
| everyFrame | false | false |  |  |

##### 8. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string Title Variable Name | string Title Variable Name | Variable |  |
| everyFrame | false | false |  |  |

##### 9. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string Desc variable Name | string Desc variable Name | Variable |  |
| everyFrame | false | false |  |  |

##### 10. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inv Top | OwnerDefault Inv Top |  |  |
| fsmName | "UI Inventory" | "UI Inventory" | FsmName |  |
| variableName | string Title Variable Name | string Title Variable Name | FsmString |  |
| setValue | "INV_NAME_STOREKEY" | "INV_NAME_STOREKEY" |  |  |
| everyFrame | false | false |  |  |

##### 11. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inv Top | OwnerDefault Inv Top |  |  |
| fsmName | "UI Inventory" | "UI Inventory" | FsmName |  |
| variableName | string Desc variable Name | string Desc variable Name | FsmString |  |
| setValue | "INV_DESC_STOREKEY" | "INV_DESC_STOREKEY" |  |  |
| everyFrame | false | false |  |  |

##### 12. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Next Item Num | int Next Item Num | Variable |  |
| add | 1 | 1 |  |  |
| everyFrame | false | false |  |  |

##### 13. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Equipment Slots Filled | int Equipment Slots Filled | Variable |  |
| add | 1 | 1 |  |  |
| everyFrame | false | false |  |  |

### Shadow Dash

Description: Deprecated 
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "hasShadowDash" | "hasShadowDash" |  |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(FINISHED) | Event(FINISHED) |  |  |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Shadow Dash" | "Shadow Dash" |  |  |
| storeResult | GameObject Current Item | GameObject Current Item | Variable |  |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Current Item | OwnerDefault Current Item |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 4. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Current Item | OwnerDefault Current Item |  |  |
| fsmName | "equip_position" | "equip_position" | FsmName |  |
| variableName | "Item Number" | "Item Number" | FsmInt |  |
| setValue | int Next Item Num | int Next Item Num |  |  |
| everyFrame | false | false |  |  |

##### 5. ConvertIntToString

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Next Item Num | int Next Item Num | Variable |  |
| stringVariable | string Item num String | string Item num String | Variable |  |
| format | "" | "" |  |  |
| everyFrame | false | false |  |  |

##### 6. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string GO Variable Name | string GO Variable Name | Variable |  |
| everyFrame | false | false |  |  |

##### 7. SetFsmGameObject

Full Name: HutongGames.PlayMaker.Actions.SetFsmGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inv Top | OwnerDefault Inv Top |  |  |
| fsmName | "UI Inventory" | "UI Inventory" | FsmName |  |
| variableName | string GO Variable Name | string GO Variable Name | FsmGameObject |  |
| setValue | GameObject Current Item | GameObject Current Item |  |  |
| everyFrame | false | false |  |  |

##### 8. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string Title Variable Name | string Title Variable Name | Variable |  |
| everyFrame | false | false |  |  |

##### 9. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string Desc variable Name | string Desc variable Name | Variable |  |
| everyFrame | false | false |  |  |

##### 10. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inv Top | OwnerDefault Inv Top |  |  |
| fsmName | "UI Inventory" | "UI Inventory" | FsmName |  |
| variableName | string Title Variable Name | string Title Variable Name | FsmString |  |
| setValue | "INV_NAME_SHADOWDASH" | "INV_NAME_SHADOWDASH" |  |  |
| everyFrame | false | false |  |  |

##### 11. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inv Top | OwnerDefault Inv Top |  |  |
| fsmName | "UI Inventory" | "UI Inventory" | FsmName |  |
| variableName | string Desc variable Name | string Desc variable Name | FsmString |  |
| setValue | "INV_DESC_SHADOWDASH" | "INV_DESC_SHADOWDASH" |  |  |
| everyFrame | false | false |  |  |

##### 12. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Next Item Num | int Next Item Num | Variable |  |
| add | 1 | 1 |  |  |
| everyFrame | false | false |  |  |

### White Key

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
| boolName | "hasSlykey" | "hasSlykey" |  |  |
| isTrue | Event(FINISHED) | Event(FINISHED) |  |  |
| isFalse | Event() | Event() |  |  |

##### 2. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "hasWhiteKey" | "hasWhiteKey" |  |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(FINISHED) | Event(FINISHED) |  |  |

##### 3. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "usedWhiteKey" | "usedWhiteKey" |  |  |
| isTrue | Event(FINISHED) | Event(FINISHED) |  |  |
| isFalse | Event() | Event() |  |  |

##### 4. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "White Key" | "White Key" |  |  |
| storeResult | GameObject Current Item | GameObject Current Item | Variable |  |

##### 5. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Current Item | OwnerDefault Current Item |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 6. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Current Item | OwnerDefault Current Item |  |  |
| fsmName | "equip_position" | "equip_position" | FsmName |  |
| variableName | "Item Number" | "Item Number" | FsmInt |  |
| setValue | int Next Item Num | int Next Item Num |  |  |
| everyFrame | false | false |  |  |

##### 7. ConvertIntToString

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Next Item Num | int Next Item Num | Variable |  |
| stringVariable | string Item num String | string Item num String | Variable |  |
| format | "" | "" |  |  |
| everyFrame | false | false |  |  |

##### 8. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string GO Variable Name | string GO Variable Name | Variable |  |
| everyFrame | false | false |  |  |

##### 9. SetFsmGameObject

Full Name: HutongGames.PlayMaker.Actions.SetFsmGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inv Top | OwnerDefault Inv Top |  |  |
| fsmName | "UI Inventory" | "UI Inventory" | FsmName |  |
| variableName | string GO Variable Name | string GO Variable Name | FsmGameObject |  |
| setValue | GameObject Current Item | GameObject Current Item |  |  |
| everyFrame | false | false |  |  |

##### 10. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string Title Variable Name | string Title Variable Name | Variable |  |
| everyFrame | false | false |  |  |

##### 11. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string Desc variable Name | string Desc variable Name | Variable |  |
| everyFrame | false | false |  |  |

##### 12. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inv Top | OwnerDefault Inv Top |  |  |
| fsmName | "UI Inventory" | "UI Inventory" | FsmName |  |
| variableName | string Title Variable Name | string Title Variable Name | FsmString |  |
| setValue | "INV_NAME_WHITEKEY" | "INV_NAME_WHITEKEY" |  |  |
| everyFrame | false | false |  |  |

##### 13. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inv Top | OwnerDefault Inv Top |  |  |
| fsmName | "UI Inventory" | "UI Inventory" | FsmName |  |
| variableName | string Desc variable Name | string Desc variable Name | FsmString |  |
| setValue | "INV_DESC_WHITEKEY" | "INV_DESC_WHITEKEY" |  |  |
| everyFrame | false | false |  |  |

##### 14. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Next Item Num | int Next Item Num | Variable |  |
| add | 1 | 1 |  |  |
| everyFrame | false | false |  |  |

##### 15. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Equipment Slots Filled | int Equipment Slots Filled | Variable |  |
| add | 1 | 1 |  |  |
| everyFrame | false | false |  |  |

### All Done :)

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Next Item Num | int Next Item Num | Variable |  |
| add | -1 | -1 |  |  |
| everyFrame | false | false |  |  |

##### 2. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inv Top | OwnerDefault Inv Top |  |  |
| fsmName | "UI Inventory" | "UI Inventory" | FsmName |  |
| variableName | "Equip Items Amount" | "Equip Items Amount" | FsmInt |  |
| setValue | int Next Item Num | int Next Item Num |  |  |
| everyFrame | false | false |  |  |

### Trink 4

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Trinket Backboard | OwnerDefault Trinket Backboard |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | -10.87f | -10.87f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 2. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "foundTrinket4" | "foundTrinket4" |  |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(FINISHED) | Event(FINISHED) |  |  |

##### 3. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Trinket4" | "Trinket4" |  |  |
| storeResult | GameObject Current Item | GameObject Current Item | Variable |  |

##### 4. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Current Item | OwnerDefault Current Item |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 5. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Current Item | OwnerDefault Current Item |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | -10.74f | -10.74f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 6. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Max Shifted | bool Max Shifted | Variable |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(FINISHED) | Event(FINISHED) |  |  |
| everyFrame | false | false |  |  |

##### 7. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Trinket Backboard | OwnerDefault Trinket Backboard |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | -12.37f | -12.37f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 8. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Current Item | OwnerDefault Current Item |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | -1.5f | -1.5f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| perSecond | false | false |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |
| fixedUpdate | false | false |  |  |

### Trink 1

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
| boolName | "foundTrinket1" | "foundTrinket1" |  |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(FINISHED) | Event(FINISHED) |  |  |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Trinket1" | "Trinket1" |  |  |
| storeResult | GameObject Current Item | GameObject Current Item | Variable |  |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Current Item | OwnerDefault Current Item |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 4. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Current Item | OwnerDefault Current Item |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | -10.74f | -10.74f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 5. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Max Shifted | bool Max Shifted | Variable |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(FINISHED) | Event(FINISHED) |  |  |
| everyFrame | false | false |  |  |

##### 6. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Trinket Backboard | OwnerDefault Trinket Backboard |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | -12.37f | -12.37f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 7. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Current Item | OwnerDefault Current Item |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | -1.5f | -1.5f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| perSecond | false | false |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |
| fixedUpdate | false | false |  |  |

### Trink 2

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
| boolName | "foundTrinket2" | "foundTrinket2" |  |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(FINISHED) | Event(FINISHED) |  |  |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Trinket2" | "Trinket2" |  |  |
| storeResult | GameObject Current Item | GameObject Current Item | Variable |  |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Current Item | OwnerDefault Current Item |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 4. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Current Item | OwnerDefault Current Item |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | -10.74f | -10.74f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 5. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Max Shifted | bool Max Shifted | Variable |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(FINISHED) | Event(FINISHED) |  |  |
| everyFrame | false | false |  |  |

##### 6. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Trinket Backboard | OwnerDefault Trinket Backboard |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | -12.37f | -12.37f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 7. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Current Item | OwnerDefault Current Item |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | -1.5f | -1.5f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| perSecond | false | false |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |
| fixedUpdate | false | false |  |  |

### Trink 3

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
| boolName | "foundTrinket3" | "foundTrinket3" |  |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(FINISHED) | Event(FINISHED) |  |  |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Trinket3" | "Trinket3" |  |  |
| storeResult | GameObject Current Item | GameObject Current Item | Variable |  |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Current Item | OwnerDefault Current Item |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 4. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Current Item | OwnerDefault Current Item |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | -10.74f | -10.74f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 5. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Max Shifted | bool Max Shifted | Variable |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(FINISHED) | Event(FINISHED) |  |  |
| everyFrame | false | false |  |  |

##### 6. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Trinket Backboard | OwnerDefault Trinket Backboard |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | -12.37f | -12.37f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 7. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Current Item | OwnerDefault Current Item |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | -1.5f | -1.5f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| perSecond | false | false |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |
| fixedUpdate | false | false |  |  |

### Xun Flower

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "hasXunFlower" | "hasXunFlower" |  |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(FINISHED) | Event(FINISHED) |  |  |

##### 2. PlayerDataBoolAllTrue

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolAllTrue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| stringVariables | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| trueEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| falseEvent | Event() | Event() |  |  |
| storeResult | false | false | Variable |  |
| everyFrame | false | false |  |  |

##### 3. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Xun Flower" | "Xun Flower" |  |  |
| storeResult | GameObject Current Item | GameObject Current Item | Variable |  |

##### 4. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Current Item | OwnerDefault Current Item |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 5. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Current Item | OwnerDefault Current Item |  |  |
| fsmName | "equip_position" | "equip_position" | FsmName |  |
| variableName | "Item Number" | "Item Number" | FsmInt |  |
| setValue | int Next Item Num | int Next Item Num |  |  |
| everyFrame | false | false |  |  |

##### 6. ConvertIntToString

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Next Item Num | int Next Item Num | Variable |  |
| stringVariable | string Item num String | string Item num String | Variable |  |
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
| storeResult | string GO Variable Name | string GO Variable Name | Variable |  |
| everyFrame | false | false |  |  |

##### 8. SetFsmGameObject

Full Name: HutongGames.PlayMaker.Actions.SetFsmGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inv Top | OwnerDefault Inv Top |  |  |
| fsmName | "UI Inventory" | "UI Inventory" | FsmName |  |
| variableName | string GO Variable Name | string GO Variable Name | FsmGameObject |  |
| setValue | GameObject Current Item | GameObject Current Item |  |  |
| everyFrame | false | false |  |  |

##### 9. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Next Item Num | int Next Item Num | Variable |  |
| add | 1 | 1 |  |  |
| everyFrame | false | false |  |  |

##### 10. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Equipment Slots Filled | int Equipment Slots Filled | Variable |  |
| add | 1 | 1 |  |  |
| everyFrame | false | false |  |  |

##### 11. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | Event(CHECK) | Event(CHECK) |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Tram Pass

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
| boolName | "hasTramPass" | "hasTramPass" |  |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(FINISHED) | Event(FINISHED) |  |  |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Tram Pass" | "Tram Pass" |  |  |
| storeResult | GameObject Current Item | GameObject Current Item | Variable |  |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Current Item | OwnerDefault Current Item |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 4. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Current Item | OwnerDefault Current Item |  |  |
| fsmName | "equip_position" | "equip_position" | FsmName |  |
| variableName | "Item Number" | "Item Number" | FsmInt |  |
| setValue | int Next Item Num | int Next Item Num |  |  |
| everyFrame | false | false |  |  |

##### 5. ConvertIntToString

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Next Item Num | int Next Item Num | Variable |  |
| stringVariable | string Item num String | string Item num String | Variable |  |
| format | "" | "" |  |  |
| everyFrame | false | false |  |  |

##### 6. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string GO Variable Name | string GO Variable Name | Variable |  |
| everyFrame | false | false |  |  |

##### 7. SetFsmGameObject

Full Name: HutongGames.PlayMaker.Actions.SetFsmGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inv Top | OwnerDefault Inv Top |  |  |
| fsmName | "UI Inventory" | "UI Inventory" | FsmName |  |
| variableName | string GO Variable Name | string GO Variable Name | FsmGameObject |  |
| setValue | GameObject Current Item | GameObject Current Item |  |  |
| everyFrame | false | false |  |  |

##### 8. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string Title Variable Name | string Title Variable Name | Variable |  |
| everyFrame | false | false |  |  |

##### 9. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string Desc variable Name | string Desc variable Name | Variable |  |
| everyFrame | false | false |  |  |

##### 10. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inv Top | OwnerDefault Inv Top |  |  |
| fsmName | "UI Inventory" | "UI Inventory" | FsmName |  |
| variableName | string Title Variable Name | string Title Variable Name | FsmString |  |
| setValue | "INV_NAME_TRAM_PASS" | "INV_NAME_TRAM_PASS" |  |  |
| everyFrame | false | false |  |  |

##### 11. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inv Top | OwnerDefault Inv Top |  |  |
| fsmName | "UI Inventory" | "UI Inventory" | FsmName |  |
| variableName | string Desc variable Name | string Desc variable Name | FsmString |  |
| setValue | "INV_DESC_TRAM_PASS" | "INV_DESC_TRAM_PASS" |  |  |
| everyFrame | false | false |  |  |

##### 12. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Next Item Num | int Next Item Num | Variable |  |
| add | 1 | 1 |  |  |
| everyFrame | false | false |  |  |

##### 13. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Equipment Slots Filled | int Equipment Slots Filled | Variable |  |
| add | 1 | 1 |  |  |
| everyFrame | false | false |  |  |

### Waterway Key

Description: Deprectaed 
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "hasWaterwaysKey" | "hasWaterwaysKey" |  |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(FINISHED) | Event(FINISHED) |  |  |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Waterway Key" | "Waterway Key" |  |  |
| storeResult | GameObject Current Item | GameObject Current Item | Variable |  |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Current Item | OwnerDefault Current Item |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 4. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Current Item | OwnerDefault Current Item |  |  |
| fsmName | "equip_position" | "equip_position" | FsmName |  |
| variableName | "Item Number" | "Item Number" | FsmInt |  |
| setValue | int Next Item Num | int Next Item Num |  |  |
| everyFrame | false | false |  |  |

##### 5. ConvertIntToString

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Next Item Num | int Next Item Num | Variable |  |
| stringVariable | string Item num String | string Item num String | Variable |  |
| format | "" | "" |  |  |
| everyFrame | false | false |  |  |

##### 6. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string GO Variable Name | string GO Variable Name | Variable |  |
| everyFrame | false | false |  |  |

##### 7. SetFsmGameObject

Full Name: HutongGames.PlayMaker.Actions.SetFsmGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inv Top | OwnerDefault Inv Top |  |  |
| fsmName | "UI Inventory" | "UI Inventory" | FsmName |  |
| variableName | string GO Variable Name | string GO Variable Name | FsmGameObject |  |
| setValue | GameObject Current Item | GameObject Current Item |  |  |
| everyFrame | false | false |  |  |

##### 8. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string Title Variable Name | string Title Variable Name | Variable |  |
| everyFrame | false | false |  |  |

##### 9. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string Desc variable Name | string Desc variable Name | Variable |  |
| everyFrame | false | false |  |  |

##### 10. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inv Top | OwnerDefault Inv Top |  |  |
| fsmName | "UI Inventory" | "UI Inventory" | FsmName |  |
| variableName | string Title Variable Name | string Title Variable Name | FsmString |  |
| setValue | "INV_NAME_WATERWAYSKEY" | "INV_NAME_WATERWAYSKEY" |  |  |
| everyFrame | false | false |  |  |

##### 11. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inv Top | OwnerDefault Inv Top |  |  |
| fsmName | "UI Inventory" | "UI Inventory" | FsmName |  |
| variableName | string Desc variable Name | string Desc variable Name | FsmString |  |
| setValue | "INV_DESC_WATERWAYSKEY" | "INV_DESC_WATERWAYSKEY" |  |  |
| everyFrame | false | false |  |  |

##### 12. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Next Item Num | int Next Item Num | Variable |  |
| add | 1 | 1 |  |  |
| everyFrame | false | false |  |  |

### Ore

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
| intName | "ore" | "ore" |  |  |
| storeValue | int Items | int Items | Variable |  |

##### 2. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Items | int Items |  |  |
| integer2 | 0 | 0 |  |  |
| equal | Event(FINISHED) | Event(FINISHED) |  |  |
| lessThan | Event(FINISHED) | Event(FINISHED) |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 3. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Ore" | "Ore" |  |  |
| storeResult | GameObject Current Item | GameObject Current Item | Variable |  |

##### 4. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Current Item | OwnerDefault Current Item |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 5. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Current Item | OwnerDefault Current Item |  |  |
| fsmName | "equip_position" | "equip_position" | FsmName |  |
| variableName | "Item Number" | "Item Number" | FsmInt |  |
| setValue | int Next Item Num | int Next Item Num |  |  |
| everyFrame | false | false |  |  |

##### 6. ConvertIntToString

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Next Item Num | int Next Item Num | Variable |  |
| stringVariable | string Item num String | string Item num String | Variable |  |
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
| storeResult | string GO Variable Name | string GO Variable Name | Variable |  |
| everyFrame | false | false |  |  |

##### 8. SetFsmGameObject

Full Name: HutongGames.PlayMaker.Actions.SetFsmGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inv Top | OwnerDefault Inv Top |  |  |
| fsmName | "UI Inventory" | "UI Inventory" | FsmName |  |
| variableName | string GO Variable Name | string GO Variable Name | FsmGameObject |  |
| setValue | GameObject Current Item | GameObject Current Item |  |  |
| everyFrame | false | false |  |  |

##### 9. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string Title Variable Name | string Title Variable Name | Variable |  |
| everyFrame | false | false |  |  |

##### 10. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string Desc variable Name | string Desc variable Name | Variable |  |
| everyFrame | false | false |  |  |

##### 11. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inv Top | OwnerDefault Inv Top |  |  |
| fsmName | "UI Inventory" | "UI Inventory" | FsmName |  |
| variableName | string Title Variable Name | string Title Variable Name | FsmString |  |
| setValue | "INV_NAME_ORE" | "INV_NAME_ORE" |  |  |
| everyFrame | false | false |  |  |

##### 12. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inv Top | OwnerDefault Inv Top |  |  |
| fsmName | "UI Inventory" | "UI Inventory" | FsmName |  |
| variableName | string Desc variable Name | string Desc variable Name | FsmString |  |
| setValue | "INV_DESC_ORE" | "INV_DESC_ORE" |  |  |
| everyFrame | false | false |  |  |

##### 13. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Next Item Num | int Next Item Num | Variable |  |
| add | 1 | 1 |  |  |
| everyFrame | false | false |  |  |

##### 14. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Equipment Slots Filled | int Equipment Slots Filled | Variable |  |
| add | 1 | 1 |  |  |
| everyFrame | false | false |  |  |

### City Key

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
| boolName | "hasCityKey" | "hasCityKey" |  |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(FINISHED) | Event(FINISHED) |  |  |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "City Key" | "City Key" |  |  |
| storeResult | GameObject Current Item | GameObject Current Item | Variable |  |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Current Item | OwnerDefault Current Item |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 4. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Current Item | OwnerDefault Current Item |  |  |
| fsmName | "equip_position" | "equip_position" | FsmName |  |
| variableName | "Item Number" | "Item Number" | FsmInt |  |
| setValue | int Next Item Num | int Next Item Num |  |  |
| everyFrame | false | false |  |  |

##### 5. ConvertIntToString

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Next Item Num | int Next Item Num | Variable |  |
| stringVariable | string Item num String | string Item num String | Variable |  |
| format | "" | "" |  |  |
| everyFrame | false | false |  |  |

##### 6. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string GO Variable Name | string GO Variable Name | Variable |  |
| everyFrame | false | false |  |  |

##### 7. SetFsmGameObject

Full Name: HutongGames.PlayMaker.Actions.SetFsmGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inv Top | OwnerDefault Inv Top |  |  |
| fsmName | "UI Inventory" | "UI Inventory" | FsmName |  |
| variableName | string GO Variable Name | string GO Variable Name | FsmGameObject |  |
| setValue | GameObject Current Item | GameObject Current Item |  |  |
| everyFrame | false | false |  |  |

##### 8. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string Title Variable Name | string Title Variable Name | Variable |  |
| everyFrame | false | false |  |  |

##### 9. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string Desc variable Name | string Desc variable Name | Variable |  |
| everyFrame | false | false |  |  |

##### 10. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inv Top | OwnerDefault Inv Top |  |  |
| fsmName | "UI Inventory" | "UI Inventory" | FsmName |  |
| variableName | string Title Variable Name | string Title Variable Name | FsmString |  |
| setValue | "INV_NAME_CITYKEY" | "INV_NAME_CITYKEY" |  |  |
| everyFrame | false | false |  |  |

##### 11. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inv Top | OwnerDefault Inv Top |  |  |
| fsmName | "UI Inventory" | "UI Inventory" | FsmName |  |
| variableName | string Desc variable Name | string Desc variable Name | FsmString |  |
| setValue | "INV_DESC_CITYKEY" | "INV_DESC_CITYKEY" |  |  |
| everyFrame | false | false |  |  |

##### 12. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Next Item Num | int Next Item Num | Variable |  |
| add | 1 | 1 |  |  |
| everyFrame | false | false |  |  |

##### 13. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Equipment Slots Filled | int Equipment Slots Filled | Variable |  |
| add | 1 | 1 |  |  |
| everyFrame | false | false |  |  |

### Love Key

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
| boolName | "hasLoveKey" | "hasLoveKey" |  |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(FINISHED) | Event(FINISHED) |  |  |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Love Key" | "Love Key" |  |  |
| storeResult | GameObject Current Item | GameObject Current Item | Variable |  |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Current Item | OwnerDefault Current Item |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 4. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Current Item | OwnerDefault Current Item |  |  |
| fsmName | "equip_position" | "equip_position" | FsmName |  |
| variableName | "Item Number" | "Item Number" | FsmInt |  |
| setValue | int Next Item Num | int Next Item Num |  |  |
| everyFrame | false | false |  |  |

##### 5. ConvertIntToString

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Next Item Num | int Next Item Num | Variable |  |
| stringVariable | string Item num String | string Item num String | Variable |  |
| format | "" | "" |  |  |
| everyFrame | false | false |  |  |

##### 6. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string GO Variable Name | string GO Variable Name | Variable |  |
| everyFrame | false | false |  |  |

##### 7. SetFsmGameObject

Full Name: HutongGames.PlayMaker.Actions.SetFsmGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inv Top | OwnerDefault Inv Top |  |  |
| fsmName | "UI Inventory" | "UI Inventory" | FsmName |  |
| variableName | string GO Variable Name | string GO Variable Name | FsmGameObject |  |
| setValue | GameObject Current Item | GameObject Current Item |  |  |
| everyFrame | false | false |  |  |

##### 8. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string Title Variable Name | string Title Variable Name | Variable |  |
| everyFrame | false | false |  |  |

##### 9. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string Desc variable Name | string Desc variable Name | Variable |  |
| everyFrame | false | false |  |  |

##### 10. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inv Top | OwnerDefault Inv Top |  |  |
| fsmName | "UI Inventory" | "UI Inventory" | FsmName |  |
| variableName | string Title Variable Name | string Title Variable Name | FsmString |  |
| setValue | "INV_NAME_LOVEKEY" | "INV_NAME_LOVEKEY" |  |  |
| everyFrame | false | false |  |  |

##### 11. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inv Top | OwnerDefault Inv Top |  |  |
| fsmName | "UI Inventory" | "UI Inventory" | FsmName |  |
| variableName | string Desc variable Name | string Desc variable Name | FsmString |  |
| setValue | "INV_DESC_LOVEKEY" | "INV_DESC_LOVEKEY" |  |  |
| everyFrame | false | false |  |  |

##### 12. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Next Item Num | int Next Item Num | Variable |  |
| add | 1 | 1 |  |  |
| everyFrame | false | false |  |  |

##### 13. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Equipment Slots Filled | int Equipment Slots Filled | Variable |  |
| add | 1 | 1 |  |  |
| everyFrame | false | false |  |  |

### Kings Brand

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
| boolName | "hasKingsBrand" | "hasKingsBrand" |  |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(FINISHED) | Event(FINISHED) |  |  |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Kings Brand" | "Kings Brand" |  |  |
| storeResult | GameObject Current Item | GameObject Current Item | Variable |  |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Current Item | OwnerDefault Current Item |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 4. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Current Item | OwnerDefault Current Item |  |  |
| fsmName | "equip_position" | "equip_position" | FsmName |  |
| variableName | "Item Number" | "Item Number" | FsmInt |  |
| setValue | int Next Item Num | int Next Item Num |  |  |
| everyFrame | false | false |  |  |

##### 5. ConvertIntToString

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Next Item Num | int Next Item Num | Variable |  |
| stringVariable | string Item num String | string Item num String | Variable |  |
| format | "" | "" |  |  |
| everyFrame | false | false |  |  |

##### 6. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string GO Variable Name | string GO Variable Name | Variable |  |
| everyFrame | false | false |  |  |

##### 7. SetFsmGameObject

Full Name: HutongGames.PlayMaker.Actions.SetFsmGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inv Top | OwnerDefault Inv Top |  |  |
| fsmName | "UI Inventory" | "UI Inventory" | FsmName |  |
| variableName | string GO Variable Name | string GO Variable Name | FsmGameObject |  |
| setValue | GameObject Current Item | GameObject Current Item |  |  |
| everyFrame | false | false |  |  |

##### 8. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string Title Variable Name | string Title Variable Name | Variable |  |
| everyFrame | false | false |  |  |

##### 9. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string Desc variable Name | string Desc variable Name | Variable |  |
| everyFrame | false | false |  |  |

##### 10. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inv Top | OwnerDefault Inv Top |  |  |
| fsmName | "UI Inventory" | "UI Inventory" | FsmName |  |
| variableName | string Title Variable Name | string Title Variable Name | FsmString |  |
| setValue | "INV_NAME_KINGSBRAND" | "INV_NAME_KINGSBRAND" |  |  |
| everyFrame | false | false |  |  |

##### 11. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inv Top | OwnerDefault Inv Top |  |  |
| fsmName | "UI Inventory" | "UI Inventory" | FsmName |  |
| variableName | string Desc variable Name | string Desc variable Name | FsmString |  |
| setValue | "INV_DESC_KINGSBRAND" | "INV_DESC_KINGSBRAND" |  |  |
| everyFrame | false | false |  |  |

##### 12. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Next Item Num | int Next Item Num | Variable |  |
| add | 1 | 1 |  |  |
| everyFrame | false | false |  |  |

##### 13. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Equipment Slots Filled | int Equipment Slots Filled | Variable |  |
| add | 1 | 1 |  |  |
| everyFrame | false | false |  |  |

### Simple Key

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
| intName | "simpleKeys" | "simpleKeys" |  |  |
| storeValue | int Items | int Items | Variable |  |

##### 2. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Items | int Items |  |  |
| integer2 | 0 | 0 |  |  |
| equal | Event(FINISHED) | Event(FINISHED) |  |  |
| lessThan | Event(FINISHED) | Event(FINISHED) |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 3. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Simple Key" | "Simple Key" |  |  |
| storeResult | GameObject Current Item | GameObject Current Item | Variable |  |

##### 4. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Current Item | OwnerDefault Current Item |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 5. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Current Item | OwnerDefault Current Item |  |  |
| fsmName | "equip_position" | "equip_position" | FsmName |  |
| variableName | "Item Number" | "Item Number" | FsmInt |  |
| setValue | int Next Item Num | int Next Item Num |  |  |
| everyFrame | false | false |  |  |

##### 6. ConvertIntToString

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Next Item Num | int Next Item Num | Variable |  |
| stringVariable | string Item num String | string Item num String | Variable |  |
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
| storeResult | string GO Variable Name | string GO Variable Name | Variable |  |
| everyFrame | false | false |  |  |

##### 8. SetFsmGameObject

Full Name: HutongGames.PlayMaker.Actions.SetFsmGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inv Top | OwnerDefault Inv Top |  |  |
| fsmName | "UI Inventory" | "UI Inventory" | FsmName |  |
| variableName | string GO Variable Name | string GO Variable Name | FsmGameObject |  |
| setValue | GameObject Current Item | GameObject Current Item |  |  |
| everyFrame | false | false |  |  |

##### 9. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string Title Variable Name | string Title Variable Name | Variable |  |
| everyFrame | false | false |  |  |

##### 10. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string Desc variable Name | string Desc variable Name | Variable |  |
| everyFrame | false | false |  |  |

##### 11. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inv Top | OwnerDefault Inv Top |  |  |
| fsmName | "UI Inventory" | "UI Inventory" | FsmName |  |
| variableName | string Title Variable Name | string Title Variable Name | FsmString |  |
| setValue | "INV_NAME_SIMPLEKEY" | "INV_NAME_SIMPLEKEY" |  |  |
| everyFrame | false | false |  |  |

##### 12. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inv Top | OwnerDefault Inv Top |  |  |
| fsmName | "UI Inventory" | "UI Inventory" | FsmName |  |
| variableName | string Desc variable Name | string Desc variable Name | FsmString |  |
| setValue | "INV_DESC_SIMPLEKEY" | "INV_DESC_SIMPLEKEY" |  |  |
| everyFrame | false | false |  |  |

##### 13. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Next Item Num | int Next Item Num | Variable |  |
| add | 1 | 1 |  |  |
| everyFrame | false | false |  |  |

##### 14. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Equipment Slots Filled | int Equipment Slots Filled | Variable |  |
| add | 1 | 1 |  |  |
| everyFrame | false | false |  |  |

### Rancid Egg

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
| intName | "rancidEggs" | "rancidEggs" |  |  |
| storeValue | int Items | int Items | Variable |  |

##### 2. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Items | int Items |  |  |
| integer2 | 0 | 0 |  |  |
| equal | Event(FINISHED) | Event(FINISHED) |  |  |
| lessThan | Event(FINISHED) | Event(FINISHED) |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 3. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Rancid Egg" | "Rancid Egg" |  |  |
| storeResult | GameObject Current Item | GameObject Current Item | Variable |  |

##### 4. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Current Item | OwnerDefault Current Item |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 5. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Current Item | OwnerDefault Current Item |  |  |
| fsmName | "equip_position" | "equip_position" | FsmName |  |
| variableName | "Item Number" | "Item Number" | FsmInt |  |
| setValue | int Next Item Num | int Next Item Num |  |  |
| everyFrame | false | false |  |  |

##### 6. ConvertIntToString

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Next Item Num | int Next Item Num | Variable |  |
| stringVariable | string Item num String | string Item num String | Variable |  |
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
| storeResult | string GO Variable Name | string GO Variable Name | Variable |  |
| everyFrame | false | false |  |  |

##### 8. SetFsmGameObject

Full Name: HutongGames.PlayMaker.Actions.SetFsmGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inv Top | OwnerDefault Inv Top |  |  |
| fsmName | "UI Inventory" | "UI Inventory" | FsmName |  |
| variableName | string GO Variable Name | string GO Variable Name | FsmGameObject |  |
| setValue | GameObject Current Item | GameObject Current Item |  |  |
| everyFrame | false | false |  |  |

##### 9. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string Title Variable Name | string Title Variable Name | Variable |  |
| everyFrame | false | false |  |  |

##### 10. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string Desc variable Name | string Desc variable Name | Variable |  |
| everyFrame | false | false |  |  |

##### 11. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inv Top | OwnerDefault Inv Top |  |  |
| fsmName | "UI Inventory" | "UI Inventory" | FsmName |  |
| variableName | string Title Variable Name | string Title Variable Name | FsmString |  |
| setValue | "INV_NAME_RANCIDEGG" | "INV_NAME_RANCIDEGG" |  |  |
| everyFrame | false | false |  |  |

##### 12. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inv Top | OwnerDefault Inv Top |  |  |
| fsmName | "UI Inventory" | "UI Inventory" | FsmName |  |
| variableName | string Desc variable Name | string Desc variable Name | FsmString |  |
| setValue | "INV_DESC_RANCIDEGG" | "INV_DESC_RANCIDEGG" |  |  |
| everyFrame | false | false |  |  |

##### 13. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Next Item Num | int Next Item Num | Variable |  |
| add | 1 | 1 |  |  |
| everyFrame | false | false |  |  |

##### 14. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Equipment Slots Filled | int Equipment Slots Filled | Variable |  |
| add | 1 | 1 |  |  |
| everyFrame | false | false |  |  |

### Flower Text

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string Title Variable Name | string Title Variable Name | Variable |  |
| everyFrame | false | false |  |  |

##### 2. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string Desc variable Name | string Desc variable Name | Variable |  |
| everyFrame | false | false |  |  |

##### 3. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inv Top | OwnerDefault Inv Top |  |  |
| fsmName | "UI Inventory" | "UI Inventory" | FsmName |  |
| variableName | string Title Variable Name | string Title Variable Name | FsmString |  |
| setValue | "INV_NAME_FLOWER" | "INV_NAME_FLOWER" |  |  |
| everyFrame | false | false |  |  |

##### 4. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inv Top | OwnerDefault Inv Top |  |  |
| fsmName | "UI Inventory" | "UI Inventory" | FsmName |  |
| variableName | string Desc variable Name | string Desc variable Name | FsmString |  |
| setValue | "INV_DESC_FLOWER" | "INV_DESC_FLOWER" |  |  |
| everyFrame | false | false |  |  |

##### 5. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "xunFlowerBroken" | "xunFlowerBroken" |  |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(FINISHED) | Event(FINISHED) |  |  |

##### 6. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inv Top | OwnerDefault Inv Top |  |  |
| fsmName | "UI Inventory" | "UI Inventory" | FsmName |  |
| variableName | string Title Variable Name | string Title Variable Name | FsmString |  |
| setValue | "INV_NAME_FLOWER_BROKEN" | "INV_NAME_FLOWER_BROKEN" |  |  |
| everyFrame | false | false |  |  |

##### 7. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inv Top | OwnerDefault Inv Top |  |  |
| fsmName | "UI Inventory" | "UI Inventory" | FsmName |  |
| variableName | string Desc variable Name | string Desc variable Name | FsmString |  |
| setValue | "INV_DESC_FLOWER_BROKEN" | "INV_DESC_FLOWER_BROKEN" |  |  |
| everyFrame | false | false |  |  |

### Map

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
| childName | "Map and Quill" | "Map and Quill" |  |  |
| storeResult | GameObject Current Item | GameObject Current Item | Variable |  |

##### 2. SetSpriteRendererSprite

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRendererSprite
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Current Item | OwnerDefault Current Item |  |  |
| sprite | [inv_item__0008_jar_col_map (Sprite) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [inv_item__0008_jar_col_map (Sprite) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Current Item | OwnerDefault Current Item |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 4. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Current Item | OwnerDefault Current Item |  |  |
| fsmName | "equip_position" | "equip_position" | FsmName |  |
| variableName | "Item Number" | "Item Number" | FsmInt |  |
| setValue | int Next Item Num | int Next Item Num |  |  |
| everyFrame | false | false |  |  |

##### 5. ConvertIntToString

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Next Item Num | int Next Item Num | Variable |  |
| stringVariable | string Item num String | string Item num String | Variable |  |
| format | "" | "" |  |  |
| everyFrame | false | false |  |  |

##### 6. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string GO Variable Name | string GO Variable Name | Variable |  |
| everyFrame | false | false |  |  |

##### 7. SetFsmGameObject

Full Name: HutongGames.PlayMaker.Actions.SetFsmGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inv Top | OwnerDefault Inv Top |  |  |
| fsmName | "UI Inventory" | "UI Inventory" | FsmName |  |
| variableName | string GO Variable Name | string GO Variable Name | FsmGameObject |  |
| setValue | GameObject Current Item | GameObject Current Item |  |  |
| everyFrame | false | false |  |  |

##### 8. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string Title Variable Name | string Title Variable Name | Variable |  |
| everyFrame | false | false |  |  |

##### 9. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string Desc variable Name | string Desc variable Name | Variable |  |
| everyFrame | false | false |  |  |

##### 10. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inv Top | OwnerDefault Inv Top |  |  |
| fsmName | "UI Inventory" | "UI Inventory" | FsmName |  |
| variableName | string Title Variable Name | string Title Variable Name | FsmString |  |
| setValue | "INV_NAME_MAP" | "INV_NAME_MAP" |  |  |
| everyFrame | false | false |  |  |

##### 11. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inv Top | OwnerDefault Inv Top |  |  |
| fsmName | "UI Inventory" | "UI Inventory" | FsmName |  |
| variableName | string Desc variable Name | string Desc variable Name | FsmString |  |
| setValue | "INV_DESC_MAP" | "INV_DESC_MAP" |  |  |
| everyFrame | false | false |  |  |

##### 12. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Next Item Num | int Next Item Num | Variable |  |
| add | 1 | 1 |  |  |
| everyFrame | false | false |  |  |

### Map Quill Check

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 4

#### Actions

##### 1. GetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName | "hasMap" | "hasMap" |  |  |
| storeValue | bool Has Map | bool Has Map | Variable |  |

##### 2. GetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName | "hasQuill" | "hasQuill" |  |  |
| storeValue | bool Has Quill | bool Has Quill | Variable |  |

##### 3. BoolNoneTrue

Full Name: HutongGames.PlayMaker.Actions.BoolNoneTrue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariables | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 | Variable |  |
| sendEvent | Event(NONE) | Event(NONE) |  |  |
| storeResult | false | false | Variable |  |
| everyFrame | false | false |  |  |

##### 4. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Equipment Slots Filled | int Equipment Slots Filled | Variable |  |
| add | 1 | 1 |  |  |
| everyFrame | false | false |  |  |

##### 5. BoolAllTrue

Full Name: HutongGames.PlayMaker.Actions.BoolAllTrue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariables | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 | Variable |  |
| sendEvent | Event(MAP AND QUILL) | Event(MAP AND QUILL) |  |  |
| storeResult | false | false | Variable |  |
| everyFrame | false | false |  |  |

##### 6. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Has Map | bool Has Map | Variable |  |
| isTrue | Event(MAP) | Event(MAP) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 7. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Has Quill | bool Has Quill | Variable |  |
| isTrue | Event(QUILL) | Event(QUILL) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

### Quill

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
| childName | "Map and Quill" | "Map and Quill" |  |  |
| storeResult | GameObject Current Item | GameObject Current Item | Variable |  |

##### 2. SetSpriteRendererSprite

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRendererSprite
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Current Item | OwnerDefault Current Item |  |  |
| sprite | [inv_item__0004_quill (Sprite) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [inv_item__0004_quill (Sprite) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Current Item | OwnerDefault Current Item |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 4. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Current Item | OwnerDefault Current Item |  |  |
| fsmName | "equip_position" | "equip_position" | FsmName |  |
| variableName | "Item Number" | "Item Number" | FsmInt |  |
| setValue | int Next Item Num | int Next Item Num |  |  |
| everyFrame | false | false |  |  |

##### 5. ConvertIntToString

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Next Item Num | int Next Item Num | Variable |  |
| stringVariable | string Item num String | string Item num String | Variable |  |
| format | "" | "" |  |  |
| everyFrame | false | false |  |  |

##### 6. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string GO Variable Name | string GO Variable Name | Variable |  |
| everyFrame | false | false |  |  |

##### 7. SetFsmGameObject

Full Name: HutongGames.PlayMaker.Actions.SetFsmGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inv Top | OwnerDefault Inv Top |  |  |
| fsmName | "UI Inventory" | "UI Inventory" | FsmName |  |
| variableName | string GO Variable Name | string GO Variable Name | FsmGameObject |  |
| setValue | GameObject Current Item | GameObject Current Item |  |  |
| everyFrame | false | false |  |  |

##### 8. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string Title Variable Name | string Title Variable Name | Variable |  |
| everyFrame | false | false |  |  |

##### 9. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string Desc variable Name | string Desc variable Name | Variable |  |
| everyFrame | false | false |  |  |

##### 10. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inv Top | OwnerDefault Inv Top |  |  |
| fsmName | "UI Inventory" | "UI Inventory" | FsmName |  |
| variableName | string Title Variable Name | string Title Variable Name | FsmString |  |
| setValue | "INV_NAME_QUILL" | "INV_NAME_QUILL" |  |  |
| everyFrame | false | false |  |  |

##### 11. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inv Top | OwnerDefault Inv Top |  |  |
| fsmName | "UI Inventory" | "UI Inventory" | FsmName |  |
| variableName | string Desc variable Name | string Desc variable Name | FsmString |  |
| setValue | "INV_DESC_QUILL" | "INV_DESC_QUILL" |  |  |
| everyFrame | false | false |  |  |

##### 12. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Next Item Num | int Next Item Num | Variable |  |
| add | 1 | 1 |  |  |
| everyFrame | false | false |  |  |

### Map and Quill

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
| childName | "Map and Quill" | "Map and Quill" |  |  |
| storeResult | GameObject Current Item | GameObject Current Item | Variable |  |

##### 2. SetSpriteRendererSprite

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRendererSprite
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Current Item | OwnerDefault Current Item |  |  |
| sprite | [inv_item_map_quill_combined (Sprite) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [inv_item_map_quill_combined (Sprite) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Current Item | OwnerDefault Current Item |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 4. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Current Item | OwnerDefault Current Item |  |  |
| fsmName | "equip_position" | "equip_position" | FsmName |  |
| variableName | "Item Number" | "Item Number" | FsmInt |  |
| setValue | int Next Item Num | int Next Item Num |  |  |
| everyFrame | false | false |  |  |

##### 5. ConvertIntToString

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Next Item Num | int Next Item Num | Variable |  |
| stringVariable | string Item num String | string Item num String | Variable |  |
| format | "" | "" |  |  |
| everyFrame | false | false |  |  |

##### 6. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string GO Variable Name | string GO Variable Name | Variable |  |
| everyFrame | false | false |  |  |

##### 7. SetFsmGameObject

Full Name: HutongGames.PlayMaker.Actions.SetFsmGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inv Top | OwnerDefault Inv Top |  |  |
| fsmName | "UI Inventory" | "UI Inventory" | FsmName |  |
| variableName | string GO Variable Name | string GO Variable Name | FsmGameObject |  |
| setValue | GameObject Current Item | GameObject Current Item |  |  |
| everyFrame | false | false |  |  |

##### 8. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string Title Variable Name | string Title Variable Name | Variable |  |
| everyFrame | false | false |  |  |

##### 9. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string Desc variable Name | string Desc variable Name | Variable |  |
| everyFrame | false | false |  |  |

##### 10. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inv Top | OwnerDefault Inv Top |  |  |
| fsmName | "UI Inventory" | "UI Inventory" | FsmName |  |
| variableName | string Title Variable Name | string Title Variable Name | FsmString |  |
| setValue | "INV_NAME_MAPQUILL" | "INV_NAME_MAPQUILL" |  |  |
| everyFrame | false | false |  |  |

##### 11. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inv Top | OwnerDefault Inv Top |  |  |
| fsmName | "UI Inventory" | "UI Inventory" | FsmName |  |
| variableName | string Desc variable Name | string Desc variable Name | FsmString |  |
| setValue | "INV_DESC_MAPQUILL" | "INV_DESC_MAPQUILL" |  |  |
| everyFrame | false | false |  |  |

##### 12. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Next Item Num | int Next Item Num | Variable |  |
| add | 1 | 1 |  |  |
| everyFrame | false | false |  |  |

### Shift?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Equipment Slots Filled | int Equipment Slots Filled |  |  |
| integer2 | 13 | 13 |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event(FINISHED) | Event(FINISHED) |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(BroadcastAll):FSM Owner | EventTarget(BroadcastAll):FSM Owner |  |  |
| sendEvent | "EQUIPMENT OVERMAX SHIFT" | "EQUIPMENT OVERMAX SHIFT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Max Shifted | bool Max Shifted | Variable |  |
| boolValue | true | true |  |  |
| everyFrame | false | false |  |  |

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

### Extra Flower?

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
| boolName | "extraFlowerAppear" | "extraFlowerAppear" |  |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(FINISHED) | Event(FINISHED) |  |  |

##### 2. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inv Top | OwnerDefault Inv Top |  |  |
| fsmName | "UI Inventory" | "UI Inventory" | FsmName |  |
| variableName | string Title Variable Name | string Title Variable Name | FsmString |  |
| setValue | "INV_NAME_FLOWER" | "INV_NAME_FLOWER" |  |  |
| everyFrame | false | false |  |  |

##### 3. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inv Top | OwnerDefault Inv Top |  |  |
| fsmName | "UI Inventory" | "UI Inventory" | FsmName |  |
| variableName | string Desc variable Name | string Desc variable Name | FsmString |  |
| setValue | "INV_DESC_FLOWER_QG" | "INV_DESC_FLOWER_QG" |  |  |
| everyFrame | false | false |  |  |

##### 4. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "xunFlowerBroken" | "xunFlowerBroken" |  |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(FINISHED) | Event(FINISHED) |  |  |

##### 5. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inv Top | OwnerDefault Inv Top |  |  |
| fsmName | "UI Inventory" | "UI Inventory" | FsmName |  |
| variableName | string Title Variable Name | string Title Variable Name | FsmString |  |
| setValue | "INV_NAME_FLOWER_BROKEN" | "INV_NAME_FLOWER_BROKEN" |  |  |
| everyFrame | false | false |  |  |

##### 6. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inv Top | OwnerDefault Inv Top |  |  |
| fsmName | "UI Inventory" | "UI Inventory" | FsmName |  |
| variableName | string Desc variable Name | string Desc variable Name | FsmString |  |
| setValue | "INV_DESC_FLOWER_BROKEN_QG" | "INV_DESC_FLOWER_BROKEN_QG" |  |  |
| everyFrame | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Init | FINISHED | Dash | 0 | 0 | 0 |
| Dash | FINISHED | Walljump | 0 | 0 | 0 |
| Walljump | FINISHED | Super Dash | 0 | 0 | 0 |
| Super Dash | FINISHED | Double Jump | 0 | 0 | 0 |
| Dream Nail | FINISHED | Dream Nail | 0 | 0 | 0 |
| Lantern | FINISHED | Map Quill Check | 0 | 0 | 0 |
| Double Jump | FINISHED | Acid Armour | 0 | 0 | 0 |
| Acid Armour | FINISHED | Lantern | 0 | 0 | 0 |
| Store Key | FINISHED | White Key | 0 | 0 | 0 |
| Shadow Dash | FINISHED | Shadow Dash | 0 | 0 | 0 |
| White Key | FINISHED | Love Key | 0 | 0 | 0 |
| Trink 4 | FINISHED | Trink 1 | 0 | 0 | 0 |
| Trink 1 | FINISHED | Trink 2 | 0 | 0 | 0 |
| Trink 2 | FINISHED | Trink 3 | 0 | 0 | 0 |
| Trink 3 | FINISHED | All Done :) | 0 | 0 | 0 |
| Xun Flower | FINISHED | Simple Key | 0 | 0 | 0 |
| Xun Flower | CHECK | Flower Text | 0 | 0 | 0 |
| Tram Pass | FINISHED | City Key | 0 | 0 | 0 |
| Waterway Key | FINISHED | Waterway Key | 0 | 0 | 0 |
| Ore | FINISHED | Rancid Egg | 0 | 0 | 0 |
| City Key | FINISHED | Store Key | 0 | 0 | 0 |
| Love Key | FINISHED | Xun Flower | 0 | 0 | 0 |
| Kings Brand | FINISHED | Tram Pass | 0 | 0 | 0 |
| Simple Key | FINISHED | Ore | 0 | 0 | 0 |
| Rancid Egg | FINISHED | Pause | 0 | 0 | 0 |
| Flower Text | FINISHED | Extra Flower? | 0 | 0 | 0 |
| Map | FINISHED | Kings Brand | 0 | 0 | 0 |
| Map Quill Check | NONE | Kings Brand | 0 | 0 | 0 |
| Map Quill Check | MAP | Map | 0 | 0 | 0 |
| Map Quill Check | QUILL | Quill | 0 | 0 | 0 |
| Map Quill Check | MAP AND QUILL | Map and Quill | 0 | 0 | 0 |
| Quill | FINISHED | Kings Brand | 0 | 0 | 0 |
| Map and Quill | FINISHED | Kings Brand | 0 | 0 | 0 |
| Shift? | FINISHED | Trink 4 | 0 | 0 | 0 |
| Pause | FINISHED | Shift? | 0 | 0 | 0 |
| Extra Flower? | FINISHED | Simple Key | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| CHECK | false |
| MAP | false |
| MAP AND QUILL | false |
| NONE | false |
| QUILL | false |

