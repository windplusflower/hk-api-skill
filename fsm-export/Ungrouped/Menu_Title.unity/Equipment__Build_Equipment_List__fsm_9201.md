# Build Equipment List

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Build Equipment List |
| GameObject Name | Equipment |
| GameObject Path | _GameCameras/HudCamera/Inventory/Inv/ |
| Source Asset | D:/SteamLibrary/steamapps/common/Hollow Knight/hollow_knight_Data/level1 |
| Start State | Init |
| FSM PathId | 9201 |
| GameObject PathId | 1408 |

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
| Desc variable Name |   | String:  |
| GO Variable Name |   | String:  |
| Item num String |   | String:  |
| Title Variable Name |   | String:  |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Current Item | [null] | NamedAssetPPtr: [null] |
| Inv Top | [null] | NamedAssetPPtr: [null] |
| Self | [null] | NamedAssetPPtr: [null] |
| Trinket Backboard | _GameCameras/HudCamera/Inventory/Inv/trinket_backboard (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level1) | NamedAssetPPtr: [_GameCameras/HudCamera/Inventory/Inv/trinket_backboard (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level1)] |

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
| storeGameObject |   | GameObject Self | Variable |   |

##### 2. GetParent

Full Name: HutongGames.PlayMaker.Actions.GetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| storeResult |   | GameObject Inv Top | Variable |   |

##### 3. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Next Item Num | Variable |   |
| intValue |   | 1 |   |   |
| everyFrame |   | false |   |   |

##### 4. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Equipment Slots Filled | Variable |   |
| intValue |   | 0 |   |   |
| everyFrame |   | false |   |   |

##### 5. ActivateAllChildren

Full Name: HutongGames.PlayMaker.Actions.ActivateAllChildren
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | GameObject Self | Variable |   |
| activate |   | false |   |   |

##### 6. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Max Shifted | Variable |   |
| boolValue |   | false |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Dash | 0 | |

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
| gameObject |   | OwnerDefault GameManager |   |   |
| boolName |   | "hasDash" |   |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(FINISHED) |   |   |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Dash Cloak" |   |   |
| storeResult |   | GameObject Current Item | Variable |   |

##### 3. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Equipment Slots Filled | Variable |   |
| add |   | 1 |   |   |
| everyFrame |   | false |   |   |

##### 4. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Current Item |   |   |
| activate |   | true |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 5. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Current Item |   |   |
| fsmName |   | "equip_position" | FsmName |   |
| variableName |   | "Item Number" | FsmInt |   |
| setValue |   | int Next Item Num |   |   |
| everyFrame |   | false |   |   |

##### 6. ConvertIntToString

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Next Item Num | Variable |   |
| stringVariable |   | string Item num String | Variable |   |
| format |   | "" |   |   |
| everyFrame |   | false |   |   |

##### 7. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts |   | FSMViewAvalonia2.FsmArray2 |   |   |
| separator |   | "" |   |   |
| addToEnd |   | true |   |   |
| storeResult |   | string GO Variable Name | Variable |   |
| everyFrame |   | false |   |   |

##### 8. SetFsmGameObject

Full Name: HutongGames.PlayMaker.Actions.SetFsmGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inv Top |   |   |
| fsmName |   | "UI Inventory" | FsmName |   |
| variableName |   | string GO Variable Name | FsmGameObject |   |
| setValue |   | GameObject Current Item |   |   |
| everyFrame |   | false |   |   |

##### 9. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts |   | FSMViewAvalonia2.FsmArray2 |   |   |
| separator |   | "" |   |   |
| addToEnd |   | true |   |   |
| storeResult |   | string Title Variable Name | Variable |   |
| everyFrame |   | false |   |   |

##### 10. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts |   | FSMViewAvalonia2.FsmArray2 |   |   |
| separator |   | "" |   |   |
| addToEnd |   | true |   |   |
| storeResult |   | string Desc variable Name | Variable |   |
| everyFrame |   | false |   |   |

##### 11. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inv Top |   |   |
| fsmName |   | "UI Inventory" | FsmName |   |
| variableName |   | string Title Variable Name | FsmString |   |
| setValue |   | "INV_NAME_DASH" |   |   |
| everyFrame |   | false |   |   |

##### 12. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inv Top |   |   |
| fsmName |   | "UI Inventory" | FsmName |   |
| variableName |   | string Desc variable Name | FsmString |   |
| setValue |   | "INV_DESC_DASH" |   |   |
| everyFrame |   | false |   |   |

##### 13. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Next Item Num | Variable |   |
| add |   | 1 |   |   |
| everyFrame |   | false |   |   |

##### 14. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| boolName |   | "hasShadowDash" |   |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(FINISHED) |   |   |

##### 15. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inv Top |   |   |
| fsmName |   | "UI Inventory" | FsmName |   |
| variableName |   | string Title Variable Name | FsmString |   |
| setValue |   | "INV_NAME_SHADOWDASH" |   |   |
| everyFrame |   | false |   |   |

##### 16. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inv Top |   |   |
| fsmName |   | "UI Inventory" | FsmName |   |
| variableName |   | string Desc variable Name | FsmString |   |
| setValue |   | "INV_DESC_SHADOWDASH" |   |   |
| everyFrame |   | false |   |   |

##### 17. SetSpriteRendererSprite

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRendererSprite
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Current Item |   |   |
| sprite |   | [items__0004_shade_cloak (Sprite) (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\resources.assets)] |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Walljump | 0 | |

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
| gameObject |   | OwnerDefault GameManager |   |   |
| boolName |   | "hasWalljump" |   |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(FINISHED) |   |   |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Mantis Claw" |   |   |
| storeResult |   | GameObject Current Item | Variable |   |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Current Item |   |   |
| activate |   | true |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 4. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Current Item |   |   |
| fsmName |   | "equip_position" | FsmName |   |
| variableName |   | "Item Number" | FsmInt |   |
| setValue |   | int Next Item Num |   |   |
| everyFrame |   | false |   |   |

##### 5. ConvertIntToString

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Next Item Num | Variable |   |
| stringVariable |   | string Item num String | Variable |   |
| format |   | "" |   |   |
| everyFrame |   | false |   |   |

##### 6. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts |   | FSMViewAvalonia2.FsmArray2 |   |   |
| separator |   | "" |   |   |
| addToEnd |   | true |   |   |
| storeResult |   | string GO Variable Name | Variable |   |
| everyFrame |   | false |   |   |

##### 7. SetFsmGameObject

Full Name: HutongGames.PlayMaker.Actions.SetFsmGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inv Top |   |   |
| fsmName |   | "UI Inventory" | FsmName |   |
| variableName |   | string GO Variable Name | FsmGameObject |   |
| setValue |   | GameObject Current Item |   |   |
| everyFrame |   | false |   |   |

##### 8. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts |   | FSMViewAvalonia2.FsmArray2 |   |   |
| separator |   | "" |   |   |
| addToEnd |   | true |   |   |
| storeResult |   | string Title Variable Name | Variable |   |
| everyFrame |   | false |   |   |

##### 9. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts |   | FSMViewAvalonia2.FsmArray2 |   |   |
| separator |   | "" |   |   |
| addToEnd |   | true |   |   |
| storeResult |   | string Desc variable Name | Variable |   |
| everyFrame |   | false |   |   |

##### 10. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inv Top |   |   |
| fsmName |   | "UI Inventory" | FsmName |   |
| variableName |   | string Title Variable Name | FsmString |   |
| setValue |   | "INV_NAME_WALLJUMP" |   |   |
| everyFrame |   | false |   |   |

##### 11. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inv Top |   |   |
| fsmName |   | "UI Inventory" | FsmName |   |
| variableName |   | string Desc variable Name | FsmString |   |
| setValue |   | "INV_DESC_WALLJUMP" |   |   |
| everyFrame |   | false |   |   |

##### 12. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Next Item Num | Variable |   |
| add |   | 1 |   |   |
| everyFrame |   | false |   |   |

##### 13. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Equipment Slots Filled | Variable |   |
| add |   | 1 |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Super Dash | 0 | |

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
| gameObject |   | OwnerDefault GameManager |   |   |
| boolName |   | "hasSuperDash" |   |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(FINISHED) |   |   |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Super Dash" |   |   |
| storeResult |   | GameObject Current Item | Variable |   |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Current Item |   |   |
| activate |   | true |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 4. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Current Item |   |   |
| fsmName |   | "equip_position" | FsmName |   |
| variableName |   | "Item Number" | FsmInt |   |
| setValue |   | int Next Item Num |   |   |
| everyFrame |   | false |   |   |

##### 5. ConvertIntToString

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Next Item Num | Variable |   |
| stringVariable |   | string Item num String | Variable |   |
| format |   | "" |   |   |
| everyFrame |   | false |   |   |

##### 6. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts |   | FSMViewAvalonia2.FsmArray2 |   |   |
| separator |   | "" |   |   |
| addToEnd |   | true |   |   |
| storeResult |   | string GO Variable Name | Variable |   |
| everyFrame |   | false |   |   |

##### 7. SetFsmGameObject

Full Name: HutongGames.PlayMaker.Actions.SetFsmGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inv Top |   |   |
| fsmName |   | "UI Inventory" | FsmName |   |
| variableName |   | string GO Variable Name | FsmGameObject |   |
| setValue |   | GameObject Current Item |   |   |
| everyFrame |   | false |   |   |

##### 8. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts |   | FSMViewAvalonia2.FsmArray2 |   |   |
| separator |   | "" |   |   |
| addToEnd |   | true |   |   |
| storeResult |   | string Title Variable Name | Variable |   |
| everyFrame |   | false |   |   |

##### 9. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts |   | FSMViewAvalonia2.FsmArray2 |   |   |
| separator |   | "" |   |   |
| addToEnd |   | true |   |   |
| storeResult |   | string Desc variable Name | Variable |   |
| everyFrame |   | false |   |   |

##### 10. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inv Top |   |   |
| fsmName |   | "UI Inventory" | FsmName |   |
| variableName |   | string Title Variable Name | FsmString |   |
| setValue |   | "INV_NAME_SUPERDASH" |   |   |
| everyFrame |   | false |   |   |

##### 11. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inv Top |   |   |
| fsmName |   | "UI Inventory" | FsmName |   |
| variableName |   | string Desc variable Name | FsmString |   |
| setValue |   | "INV_DESC_SUPERDASH" |   |   |
| everyFrame |   | false |   |   |

##### 12. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Next Item Num | Variable |   |
| add |   | 1 |   |   |
| everyFrame |   | false |   |   |

##### 13. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Equipment Slots Filled | Variable |   |
| add |   | 1 |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Double Jump | 0 | |

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
| gameObject |   | OwnerDefault GameManager |   |   |
| boolName |   | "hasDreamNail" |   |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(FINISHED) |   |   |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Dream Nail" |   |   |
| storeResult |   | GameObject Current Item | Variable |   |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Current Item |   |   |
| activate |   | true |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 4. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Current Item |   |   |
| fsmName |   | "equip_position" | FsmName |   |
| variableName |   | "Item Number" | FsmInt |   |
| setValue |   | int Next Item Num |   |   |
| everyFrame |   | false |   |   |

##### 5. ConvertIntToString

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Next Item Num | Variable |   |
| stringVariable |   | string Item num String | Variable |   |
| format |   | "" |   |   |
| everyFrame |   | false |   |   |

##### 6. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts |   | FSMViewAvalonia2.FsmArray2 |   |   |
| separator |   | "" |   |   |
| addToEnd |   | true |   |   |
| storeResult |   | string GO Variable Name | Variable |   |
| everyFrame |   | false |   |   |

##### 7. SetFsmGameObject

Full Name: HutongGames.PlayMaker.Actions.SetFsmGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inv Top |   |   |
| fsmName |   | "UI Inventory" | FsmName |   |
| variableName |   | string GO Variable Name | FsmGameObject |   |
| setValue |   | GameObject Current Item |   |   |
| everyFrame |   | false |   |   |

##### 8. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts |   | FSMViewAvalonia2.FsmArray2 |   |   |
| separator |   | "" |   |   |
| addToEnd |   | true |   |   |
| storeResult |   | string Title Variable Name | Variable |   |
| everyFrame |   | false |   |   |

##### 9. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts |   | FSMViewAvalonia2.FsmArray2 |   |   |
| separator |   | "" |   |   |
| addToEnd |   | true |   |   |
| storeResult |   | string Desc variable Name | Variable |   |
| everyFrame |   | false |   |   |

##### 10. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inv Top |   |   |
| fsmName |   | "UI Inventory" | FsmName |   |
| variableName |   | string Title Variable Name | FsmString |   |
| setValue |   | "INV_NAME_DREAMNAIL" |   |   |
| everyFrame |   | false |   |   |

##### 11. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inv Top |   |   |
| fsmName |   | "UI Inventory" | FsmName |   |
| variableName |   | string Desc variable Name | FsmString |   |
| setValue |   | "INV_DESC_DREAMNAIL" |   |   |
| everyFrame |   | false |   |   |

##### 12. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Next Item Num | Variable |   |
| add |   | 1 |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Dream Nail | 0 | |

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
| gameObject |   | OwnerDefault GameManager |   |   |
| boolName |   | "hasLantern" |   |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(FINISHED) |   |   |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Lantern" |   |   |
| storeResult |   | GameObject Current Item | Variable |   |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Current Item |   |   |
| activate |   | true |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 4. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Current Item |   |   |
| fsmName |   | "equip_position" | FsmName |   |
| variableName |   | "Item Number" | FsmInt |   |
| setValue |   | int Next Item Num |   |   |
| everyFrame |   | false |   |   |

##### 5. ConvertIntToString

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Next Item Num | Variable |   |
| stringVariable |   | string Item num String | Variable |   |
| format |   | "" |   |   |
| everyFrame |   | false |   |   |

##### 6. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts |   | FSMViewAvalonia2.FsmArray2 |   |   |
| separator |   | "" |   |   |
| addToEnd |   | true |   |   |
| storeResult |   | string GO Variable Name | Variable |   |
| everyFrame |   | false |   |   |

##### 7. SetFsmGameObject

Full Name: HutongGames.PlayMaker.Actions.SetFsmGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inv Top |   |   |
| fsmName |   | "UI Inventory" | FsmName |   |
| variableName |   | string GO Variable Name | FsmGameObject |   |
| setValue |   | GameObject Current Item |   |   |
| everyFrame |   | false |   |   |

##### 8. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts |   | FSMViewAvalonia2.FsmArray2 |   |   |
| separator |   | "" |   |   |
| addToEnd |   | true |   |   |
| storeResult |   | string Title Variable Name | Variable |   |
| everyFrame |   | false |   |   |

##### 9. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts |   | FSMViewAvalonia2.FsmArray2 |   |   |
| separator |   | "" |   |   |
| addToEnd |   | true |   |   |
| storeResult |   | string Desc variable Name | Variable |   |
| everyFrame |   | false |   |   |

##### 10. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inv Top |   |   |
| fsmName |   | "UI Inventory" | FsmName |   |
| variableName |   | string Title Variable Name | FsmString |   |
| setValue |   | "INV_NAME_LANTERN" |   |   |
| everyFrame |   | false |   |   |

##### 11. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inv Top |   |   |
| fsmName |   | "UI Inventory" | FsmName |   |
| variableName |   | string Desc variable Name | FsmString |   |
| setValue |   | "INV_DESC_LANTERN" |   |   |
| everyFrame |   | false |   |   |

##### 12. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Next Item Num | Variable |   |
| add |   | 1 |   |   |
| everyFrame |   | false |   |   |

##### 13. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Equipment Slots Filled | Variable |   |
| add |   | 1 |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Map Quill Check | 0 | |

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
| gameObject |   | OwnerDefault GameManager |   |   |
| boolName |   | "hasDoubleJump" |   |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(FINISHED) |   |   |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Double Jump" |   |   |
| storeResult |   | GameObject Current Item | Variable |   |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Current Item |   |   |
| activate |   | true |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 4. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Current Item |   |   |
| fsmName |   | "equip_position" | FsmName |   |
| variableName |   | "Item Number" | FsmInt |   |
| setValue |   | int Next Item Num |   |   |
| everyFrame |   | false |   |   |

##### 5. ConvertIntToString

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Next Item Num | Variable |   |
| stringVariable |   | string Item num String | Variable |   |
| format |   | "" |   |   |
| everyFrame |   | false |   |   |

##### 6. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts |   | FSMViewAvalonia2.FsmArray2 |   |   |
| separator |   | "" |   |   |
| addToEnd |   | true |   |   |
| storeResult |   | string GO Variable Name | Variable |   |
| everyFrame |   | false |   |   |

##### 7. SetFsmGameObject

Full Name: HutongGames.PlayMaker.Actions.SetFsmGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inv Top |   |   |
| fsmName |   | "UI Inventory" | FsmName |   |
| variableName |   | string GO Variable Name | FsmGameObject |   |
| setValue |   | GameObject Current Item |   |   |
| everyFrame |   | false |   |   |

##### 8. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts |   | FSMViewAvalonia2.FsmArray2 |   |   |
| separator |   | "" |   |   |
| addToEnd |   | true |   |   |
| storeResult |   | string Title Variable Name | Variable |   |
| everyFrame |   | false |   |   |

##### 9. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts |   | FSMViewAvalonia2.FsmArray2 |   |   |
| separator |   | "" |   |   |
| addToEnd |   | true |   |   |
| storeResult |   | string Desc variable Name | Variable |   |
| everyFrame |   | false |   |   |

##### 10. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inv Top |   |   |
| fsmName |   | "UI Inventory" | FsmName |   |
| variableName |   | string Title Variable Name | FsmString |   |
| setValue |   | "INV_NAME_DOUBLEJUMP" |   |   |
| everyFrame |   | false |   |   |

##### 11. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inv Top |   |   |
| fsmName |   | "UI Inventory" | FsmName |   |
| variableName |   | string Desc variable Name | FsmString |   |
| setValue |   | "INV_DESC_DOUBLEJUMP" |   |   |
| everyFrame |   | false |   |   |

##### 12. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Next Item Num | Variable |   |
| add |   | 1 |   |   |
| everyFrame |   | false |   |   |

##### 13. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Equipment Slots Filled | Variable |   |
| add |   | 1 |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Acid Armour | 0 | |

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
| gameObject |   | OwnerDefault GameManager |   |   |
| boolName |   | "hasAcidArmour" |   |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(FINISHED) |   |   |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Acid Armour" |   |   |
| storeResult |   | GameObject Current Item | Variable |   |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Current Item |   |   |
| activate |   | true |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 4. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Current Item |   |   |
| fsmName |   | "equip_position" | FsmName |   |
| variableName |   | "Item Number" | FsmInt |   |
| setValue |   | int Next Item Num |   |   |
| everyFrame |   | false |   |   |

##### 5. ConvertIntToString

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Next Item Num | Variable |   |
| stringVariable |   | string Item num String | Variable |   |
| format |   | "" |   |   |
| everyFrame |   | false |   |   |

##### 6. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts |   | FSMViewAvalonia2.FsmArray2 |   |   |
| separator |   | "" |   |   |
| addToEnd |   | true |   |   |
| storeResult |   | string GO Variable Name | Variable |   |
| everyFrame |   | false |   |   |

##### 7. SetFsmGameObject

Full Name: HutongGames.PlayMaker.Actions.SetFsmGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inv Top |   |   |
| fsmName |   | "UI Inventory" | FsmName |   |
| variableName |   | string GO Variable Name | FsmGameObject |   |
| setValue |   | GameObject Current Item |   |   |
| everyFrame |   | false |   |   |

##### 8. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts |   | FSMViewAvalonia2.FsmArray2 |   |   |
| separator |   | "" |   |   |
| addToEnd |   | true |   |   |
| storeResult |   | string Title Variable Name | Variable |   |
| everyFrame |   | false |   |   |

##### 9. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts |   | FSMViewAvalonia2.FsmArray2 |   |   |
| separator |   | "" |   |   |
| addToEnd |   | true |   |   |
| storeResult |   | string Desc variable Name | Variable |   |
| everyFrame |   | false |   |   |

##### 10. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inv Top |   |   |
| fsmName |   | "UI Inventory" | FsmName |   |
| variableName |   | string Title Variable Name | FsmString |   |
| setValue |   | "INV_NAME_ACIDARMOUR" |   |   |
| everyFrame |   | false |   |   |

##### 11. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inv Top |   |   |
| fsmName |   | "UI Inventory" | FsmName |   |
| variableName |   | string Desc variable Name | FsmString |   |
| setValue |   | "INV_DESC_ACIDARMOUR" |   |   |
| everyFrame |   | false |   |   |

##### 12. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Next Item Num | Variable |   |
| add |   | 1 |   |   |
| everyFrame |   | false |   |   |

##### 13. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Equipment Slots Filled | Variable |   |
| add |   | 1 |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Lantern | 0 | |

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
| gameObject |   | OwnerDefault GameManager |   |   |
| boolName |   | "hasSlykey" |   |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(FINISHED) |   |   |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Store Key" |   |   |
| storeResult |   | GameObject Current Item | Variable |   |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Current Item |   |   |
| activate |   | true |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 4. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Current Item |   |   |
| fsmName |   | "equip_position" | FsmName |   |
| variableName |   | "Item Number" | FsmInt |   |
| setValue |   | int Next Item Num |   |   |
| everyFrame |   | false |   |   |

##### 5. ConvertIntToString

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Next Item Num | Variable |   |
| stringVariable |   | string Item num String | Variable |   |
| format |   | "" |   |   |
| everyFrame |   | false |   |   |

##### 6. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts |   | FSMViewAvalonia2.FsmArray2 |   |   |
| separator |   | "" |   |   |
| addToEnd |   | true |   |   |
| storeResult |   | string GO Variable Name | Variable |   |
| everyFrame |   | false |   |   |

##### 7. SetFsmGameObject

Full Name: HutongGames.PlayMaker.Actions.SetFsmGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inv Top |   |   |
| fsmName |   | "UI Inventory" | FsmName |   |
| variableName |   | string GO Variable Name | FsmGameObject |   |
| setValue |   | GameObject Current Item |   |   |
| everyFrame |   | false |   |   |

##### 8. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts |   | FSMViewAvalonia2.FsmArray2 |   |   |
| separator |   | "" |   |   |
| addToEnd |   | true |   |   |
| storeResult |   | string Title Variable Name | Variable |   |
| everyFrame |   | false |   |   |

##### 9. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts |   | FSMViewAvalonia2.FsmArray2 |   |   |
| separator |   | "" |   |   |
| addToEnd |   | true |   |   |
| storeResult |   | string Desc variable Name | Variable |   |
| everyFrame |   | false |   |   |

##### 10. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inv Top |   |   |
| fsmName |   | "UI Inventory" | FsmName |   |
| variableName |   | string Title Variable Name | FsmString |   |
| setValue |   | "INV_NAME_STOREKEY" |   |   |
| everyFrame |   | false |   |   |

##### 11. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inv Top |   |   |
| fsmName |   | "UI Inventory" | FsmName |   |
| variableName |   | string Desc variable Name | FsmString |   |
| setValue |   | "INV_DESC_STOREKEY" |   |   |
| everyFrame |   | false |   |   |

##### 12. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Next Item Num | Variable |   |
| add |   | 1 |   |   |
| everyFrame |   | false |   |   |

##### 13. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Equipment Slots Filled | Variable |   |
| add |   | 1 |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | White Key | 0 | |

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
| gameObject |   | OwnerDefault GameManager |   |   |
| boolName |   | "hasShadowDash" |   |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(FINISHED) |   |   |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Shadow Dash" |   |   |
| storeResult |   | GameObject Current Item | Variable |   |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Current Item |   |   |
| activate |   | true |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 4. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Current Item |   |   |
| fsmName |   | "equip_position" | FsmName |   |
| variableName |   | "Item Number" | FsmInt |   |
| setValue |   | int Next Item Num |   |   |
| everyFrame |   | false |   |   |

##### 5. ConvertIntToString

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Next Item Num | Variable |   |
| stringVariable |   | string Item num String | Variable |   |
| format |   | "" |   |   |
| everyFrame |   | false |   |   |

##### 6. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts |   | FSMViewAvalonia2.FsmArray2 |   |   |
| separator |   | "" |   |   |
| addToEnd |   | true |   |   |
| storeResult |   | string GO Variable Name | Variable |   |
| everyFrame |   | false |   |   |

##### 7. SetFsmGameObject

Full Name: HutongGames.PlayMaker.Actions.SetFsmGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inv Top |   |   |
| fsmName |   | "UI Inventory" | FsmName |   |
| variableName |   | string GO Variable Name | FsmGameObject |   |
| setValue |   | GameObject Current Item |   |   |
| everyFrame |   | false |   |   |

##### 8. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts |   | FSMViewAvalonia2.FsmArray2 |   |   |
| separator |   | "" |   |   |
| addToEnd |   | true |   |   |
| storeResult |   | string Title Variable Name | Variable |   |
| everyFrame |   | false |   |   |

##### 9. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts |   | FSMViewAvalonia2.FsmArray2 |   |   |
| separator |   | "" |   |   |
| addToEnd |   | true |   |   |
| storeResult |   | string Desc variable Name | Variable |   |
| everyFrame |   | false |   |   |

##### 10. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inv Top |   |   |
| fsmName |   | "UI Inventory" | FsmName |   |
| variableName |   | string Title Variable Name | FsmString |   |
| setValue |   | "INV_NAME_SHADOWDASH" |   |   |
| everyFrame |   | false |   |   |

##### 11. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inv Top |   |   |
| fsmName |   | "UI Inventory" | FsmName |   |
| variableName |   | string Desc variable Name | FsmString |   |
| setValue |   | "INV_DESC_SHADOWDASH" |   |   |
| everyFrame |   | false |   |   |

##### 12. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Next Item Num | Variable |   |
| add |   | 1 |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Shadow Dash | 0 | |

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
| gameObject |   | OwnerDefault GameManager |   |   |
| boolName |   | "hasSlykey" |   |   |
| isTrue |   | Event(FINISHED) |   |   |
| isFalse |   | Event() |   |   |

##### 2. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| boolName |   | "hasWhiteKey" |   |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(FINISHED) |   |   |

##### 3. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| boolName |   | "usedWhiteKey" |   |   |
| isTrue |   | Event(FINISHED) |   |   |
| isFalse |   | Event() |   |   |

##### 4. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "White Key" |   |   |
| storeResult |   | GameObject Current Item | Variable |   |

##### 5. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Current Item |   |   |
| activate |   | true |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 6. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Current Item |   |   |
| fsmName |   | "equip_position" | FsmName |   |
| variableName |   | "Item Number" | FsmInt |   |
| setValue |   | int Next Item Num |   |   |
| everyFrame |   | false |   |   |

##### 7. ConvertIntToString

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Next Item Num | Variable |   |
| stringVariable |   | string Item num String | Variable |   |
| format |   | "" |   |   |
| everyFrame |   | false |   |   |

##### 8. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts |   | FSMViewAvalonia2.FsmArray2 |   |   |
| separator |   | "" |   |   |
| addToEnd |   | true |   |   |
| storeResult |   | string GO Variable Name | Variable |   |
| everyFrame |   | false |   |   |

##### 9. SetFsmGameObject

Full Name: HutongGames.PlayMaker.Actions.SetFsmGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inv Top |   |   |
| fsmName |   | "UI Inventory" | FsmName |   |
| variableName |   | string GO Variable Name | FsmGameObject |   |
| setValue |   | GameObject Current Item |   |   |
| everyFrame |   | false |   |   |

##### 10. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts |   | FSMViewAvalonia2.FsmArray2 |   |   |
| separator |   | "" |   |   |
| addToEnd |   | true |   |   |
| storeResult |   | string Title Variable Name | Variable |   |
| everyFrame |   | false |   |   |

##### 11. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts |   | FSMViewAvalonia2.FsmArray2 |   |   |
| separator |   | "" |   |   |
| addToEnd |   | true |   |   |
| storeResult |   | string Desc variable Name | Variable |   |
| everyFrame |   | false |   |   |

##### 12. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inv Top |   |   |
| fsmName |   | "UI Inventory" | FsmName |   |
| variableName |   | string Title Variable Name | FsmString |   |
| setValue |   | "INV_NAME_WHITEKEY" |   |   |
| everyFrame |   | false |   |   |

##### 13. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inv Top |   |   |
| fsmName |   | "UI Inventory" | FsmName |   |
| variableName |   | string Desc variable Name | FsmString |   |
| setValue |   | "INV_DESC_WHITEKEY" |   |   |
| everyFrame |   | false |   |   |

##### 14. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Next Item Num | Variable |   |
| add |   | 1 |   |   |
| everyFrame |   | false |   |   |

##### 15. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Equipment Slots Filled | Variable |   |
| add |   | 1 |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Love Key | 0 | |

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
| intVariable |   | int Next Item Num | Variable |   |
| add |   | -1 |   |   |
| everyFrame |   | false |   |   |

##### 2. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inv Top |   |   |
| fsmName |   | "UI Inventory" | FsmName |   |
| variableName |   | "Equip Items Amount" | FsmInt |   |
| setValue |   | int Next Item Num |   |   |
| everyFrame |   | false |   |   |

#### Transitions

(none)

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
| gameObject |   | OwnerDefault Trinket Backboard |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | -10.87f |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

##### 2. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| boolName |   | "foundTrinket4" |   |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(FINISHED) |   |   |

##### 3. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Trinket4" |   |   |
| storeResult |   | GameObject Current Item | Variable |   |

##### 4. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Current Item |   |   |
| activate |   | true |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 5. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Current Item |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | -10.74f |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

##### 6. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Max Shifted | Variable |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(FINISHED) |   |   |
| everyFrame |   | false |   |   |

##### 7. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Trinket Backboard |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | -12.37f |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

##### 8. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Current Item |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | -1.5f |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| perSecond |   | false |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |
| fixedUpdate |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Trink 1 | 0 | |

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
| gameObject |   | OwnerDefault GameManager |   |   |
| boolName |   | "foundTrinket1" |   |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(FINISHED) |   |   |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Trinket1" |   |   |
| storeResult |   | GameObject Current Item | Variable |   |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Current Item |   |   |
| activate |   | true |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 4. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Current Item |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | -10.74f |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

##### 5. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Max Shifted | Variable |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(FINISHED) |   |   |
| everyFrame |   | false |   |   |

##### 6. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Trinket Backboard |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | -12.37f |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

##### 7. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Current Item |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | -1.5f |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| perSecond |   | false |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |
| fixedUpdate |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Trink 2 | 0 | |

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
| gameObject |   | OwnerDefault GameManager |   |   |
| boolName |   | "foundTrinket2" |   |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(FINISHED) |   |   |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Trinket2" |   |   |
| storeResult |   | GameObject Current Item | Variable |   |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Current Item |   |   |
| activate |   | true |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 4. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Current Item |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | -10.74f |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

##### 5. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Max Shifted | Variable |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(FINISHED) |   |   |
| everyFrame |   | false |   |   |

##### 6. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Trinket Backboard |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | -12.37f |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

##### 7. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Current Item |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | -1.5f |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| perSecond |   | false |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |
| fixedUpdate |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Trink 3 | 0 | |

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
| gameObject |   | OwnerDefault GameManager |   |   |
| boolName |   | "foundTrinket3" |   |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(FINISHED) |   |   |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Trinket3" |   |   |
| storeResult |   | GameObject Current Item | Variable |   |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Current Item |   |   |
| activate |   | true |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 4. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Current Item |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | -10.74f |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

##### 5. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Max Shifted | Variable |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(FINISHED) |   |   |
| everyFrame |   | false |   |   |

##### 6. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Trinket Backboard |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | -12.37f |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

##### 7. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Current Item |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | -1.5f |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| perSecond |   | false |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |
| fixedUpdate |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | All Done :) | 0 | |

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
| gameObject |   | OwnerDefault GameManager |   |   |
| boolName |   | "hasXunFlower" |   |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(FINISHED) |   |   |

##### 2. PlayerDataBoolAllTrue

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolAllTrue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| stringVariables |   | FSMViewAvalonia2.FsmArray2 |   |   |
| trueEvent |   | Event(FINISHED) |   |   |
| falseEvent |   | Event() |   |   |
| storeResult |   | false | Variable |   |
| everyFrame |   | false |   |   |

##### 3. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Xun Flower" |   |   |
| storeResult |   | GameObject Current Item | Variable |   |

##### 4. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Current Item |   |   |
| activate |   | true |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 5. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Current Item |   |   |
| fsmName |   | "equip_position" | FsmName |   |
| variableName |   | "Item Number" | FsmInt |   |
| setValue |   | int Next Item Num |   |   |
| everyFrame |   | false |   |   |

##### 6. ConvertIntToString

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Next Item Num | Variable |   |
| stringVariable |   | string Item num String | Variable |   |
| format |   | "" |   |   |
| everyFrame |   | false |   |   |

##### 7. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts |   | FSMViewAvalonia2.FsmArray2 |   |   |
| separator |   | "" |   |   |
| addToEnd |   | true |   |   |
| storeResult |   | string GO Variable Name | Variable |   |
| everyFrame |   | false |   |   |

##### 8. SetFsmGameObject

Full Name: HutongGames.PlayMaker.Actions.SetFsmGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inv Top |   |   |
| fsmName |   | "UI Inventory" | FsmName |   |
| variableName |   | string GO Variable Name | FsmGameObject |   |
| setValue |   | GameObject Current Item |   |   |
| everyFrame |   | false |   |   |

##### 9. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Next Item Num | Variable |   |
| add |   | 1 |   |   |
| everyFrame |   | false |   |   |

##### 10. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Equipment Slots Filled | Variable |   |
| add |   | 1 |   |   |
| everyFrame |   | false |   |   |

##### 11. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(Self):FSM Owner |   |   |
| sendEvent |   | Event(CHECK) |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Simple Key | 0 | |
| CHECK | Flower Text | 0 | |

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
| gameObject |   | OwnerDefault GameManager |   |   |
| boolName |   | "hasTramPass" |   |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(FINISHED) |   |   |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Tram Pass" |   |   |
| storeResult |   | GameObject Current Item | Variable |   |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Current Item |   |   |
| activate |   | true |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 4. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Current Item |   |   |
| fsmName |   | "equip_position" | FsmName |   |
| variableName |   | "Item Number" | FsmInt |   |
| setValue |   | int Next Item Num |   |   |
| everyFrame |   | false |   |   |

##### 5. ConvertIntToString

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Next Item Num | Variable |   |
| stringVariable |   | string Item num String | Variable |   |
| format |   | "" |   |   |
| everyFrame |   | false |   |   |

##### 6. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts |   | FSMViewAvalonia2.FsmArray2 |   |   |
| separator |   | "" |   |   |
| addToEnd |   | true |   |   |
| storeResult |   | string GO Variable Name | Variable |   |
| everyFrame |   | false |   |   |

##### 7. SetFsmGameObject

Full Name: HutongGames.PlayMaker.Actions.SetFsmGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inv Top |   |   |
| fsmName |   | "UI Inventory" | FsmName |   |
| variableName |   | string GO Variable Name | FsmGameObject |   |
| setValue |   | GameObject Current Item |   |   |
| everyFrame |   | false |   |   |

##### 8. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts |   | FSMViewAvalonia2.FsmArray2 |   |   |
| separator |   | "" |   |   |
| addToEnd |   | true |   |   |
| storeResult |   | string Title Variable Name | Variable |   |
| everyFrame |   | false |   |   |

##### 9. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts |   | FSMViewAvalonia2.FsmArray2 |   |   |
| separator |   | "" |   |   |
| addToEnd |   | true |   |   |
| storeResult |   | string Desc variable Name | Variable |   |
| everyFrame |   | false |   |   |

##### 10. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inv Top |   |   |
| fsmName |   | "UI Inventory" | FsmName |   |
| variableName |   | string Title Variable Name | FsmString |   |
| setValue |   | "INV_NAME_TRAM_PASS" |   |   |
| everyFrame |   | false |   |   |

##### 11. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inv Top |   |   |
| fsmName |   | "UI Inventory" | FsmName |   |
| variableName |   | string Desc variable Name | FsmString |   |
| setValue |   | "INV_DESC_TRAM_PASS" |   |   |
| everyFrame |   | false |   |   |

##### 12. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Next Item Num | Variable |   |
| add |   | 1 |   |   |
| everyFrame |   | false |   |   |

##### 13. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Equipment Slots Filled | Variable |   |
| add |   | 1 |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | City Key | 0 | |

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
| gameObject |   | OwnerDefault GameManager |   |   |
| boolName |   | "hasWaterwaysKey" |   |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(FINISHED) |   |   |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Waterway Key" |   |   |
| storeResult |   | GameObject Current Item | Variable |   |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Current Item |   |   |
| activate |   | true |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 4. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Current Item |   |   |
| fsmName |   | "equip_position" | FsmName |   |
| variableName |   | "Item Number" | FsmInt |   |
| setValue |   | int Next Item Num |   |   |
| everyFrame |   | false |   |   |

##### 5. ConvertIntToString

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Next Item Num | Variable |   |
| stringVariable |   | string Item num String | Variable |   |
| format |   | "" |   |   |
| everyFrame |   | false |   |   |

##### 6. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts |   | FSMViewAvalonia2.FsmArray2 |   |   |
| separator |   | "" |   |   |
| addToEnd |   | true |   |   |
| storeResult |   | string GO Variable Name | Variable |   |
| everyFrame |   | false |   |   |

##### 7. SetFsmGameObject

Full Name: HutongGames.PlayMaker.Actions.SetFsmGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inv Top |   |   |
| fsmName |   | "UI Inventory" | FsmName |   |
| variableName |   | string GO Variable Name | FsmGameObject |   |
| setValue |   | GameObject Current Item |   |   |
| everyFrame |   | false |   |   |

##### 8. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts |   | FSMViewAvalonia2.FsmArray2 |   |   |
| separator |   | "" |   |   |
| addToEnd |   | true |   |   |
| storeResult |   | string Title Variable Name | Variable |   |
| everyFrame |   | false |   |   |

##### 9. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts |   | FSMViewAvalonia2.FsmArray2 |   |   |
| separator |   | "" |   |   |
| addToEnd |   | true |   |   |
| storeResult |   | string Desc variable Name | Variable |   |
| everyFrame |   | false |   |   |

##### 10. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inv Top |   |   |
| fsmName |   | "UI Inventory" | FsmName |   |
| variableName |   | string Title Variable Name | FsmString |   |
| setValue |   | "INV_NAME_WATERWAYSKEY" |   |   |
| everyFrame |   | false |   |   |

##### 11. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inv Top |   |   |
| fsmName |   | "UI Inventory" | FsmName |   |
| variableName |   | string Desc variable Name | FsmString |   |
| setValue |   | "INV_DESC_WATERWAYSKEY" |   |   |
| everyFrame |   | false |   |   |

##### 12. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Next Item Num | Variable |   |
| add |   | 1 |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Waterway Key | 0 | |

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
| gameObject |   | OwnerDefault GameManager |   |   |
| intName |   | "ore" |   |   |
| storeValue |   | int Items | Variable |   |

##### 2. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Items |   |   |
| integer2 |   | 0 |   |   |
| equal |   | Event(FINISHED) |   |   |
| lessThan |   | Event(FINISHED) |   |   |
| greaterThan |   | Event() |   |   |
| everyFrame |   | false |   |   |

##### 3. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Ore" |   |   |
| storeResult |   | GameObject Current Item | Variable |   |

##### 4. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Current Item |   |   |
| activate |   | true |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 5. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Current Item |   |   |
| fsmName |   | "equip_position" | FsmName |   |
| variableName |   | "Item Number" | FsmInt |   |
| setValue |   | int Next Item Num |   |   |
| everyFrame |   | false |   |   |

##### 6. ConvertIntToString

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Next Item Num | Variable |   |
| stringVariable |   | string Item num String | Variable |   |
| format |   | "" |   |   |
| everyFrame |   | false |   |   |

##### 7. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts |   | FSMViewAvalonia2.FsmArray2 |   |   |
| separator |   | "" |   |   |
| addToEnd |   | true |   |   |
| storeResult |   | string GO Variable Name | Variable |   |
| everyFrame |   | false |   |   |

##### 8. SetFsmGameObject

Full Name: HutongGames.PlayMaker.Actions.SetFsmGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inv Top |   |   |
| fsmName |   | "UI Inventory" | FsmName |   |
| variableName |   | string GO Variable Name | FsmGameObject |   |
| setValue |   | GameObject Current Item |   |   |
| everyFrame |   | false |   |   |

##### 9. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts |   | FSMViewAvalonia2.FsmArray2 |   |   |
| separator |   | "" |   |   |
| addToEnd |   | true |   |   |
| storeResult |   | string Title Variable Name | Variable |   |
| everyFrame |   | false |   |   |

##### 10. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts |   | FSMViewAvalonia2.FsmArray2 |   |   |
| separator |   | "" |   |   |
| addToEnd |   | true |   |   |
| storeResult |   | string Desc variable Name | Variable |   |
| everyFrame |   | false |   |   |

##### 11. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inv Top |   |   |
| fsmName |   | "UI Inventory" | FsmName |   |
| variableName |   | string Title Variable Name | FsmString |   |
| setValue |   | "INV_NAME_ORE" |   |   |
| everyFrame |   | false |   |   |

##### 12. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inv Top |   |   |
| fsmName |   | "UI Inventory" | FsmName |   |
| variableName |   | string Desc variable Name | FsmString |   |
| setValue |   | "INV_DESC_ORE" |   |   |
| everyFrame |   | false |   |   |

##### 13. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Next Item Num | Variable |   |
| add |   | 1 |   |   |
| everyFrame |   | false |   |   |

##### 14. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Equipment Slots Filled | Variable |   |
| add |   | 1 |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Rancid Egg | 0 | |

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
| gameObject |   | OwnerDefault GameManager |   |   |
| boolName |   | "hasCityKey" |   |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(FINISHED) |   |   |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "City Key" |   |   |
| storeResult |   | GameObject Current Item | Variable |   |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Current Item |   |   |
| activate |   | true |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 4. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Current Item |   |   |
| fsmName |   | "equip_position" | FsmName |   |
| variableName |   | "Item Number" | FsmInt |   |
| setValue |   | int Next Item Num |   |   |
| everyFrame |   | false |   |   |

##### 5. ConvertIntToString

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Next Item Num | Variable |   |
| stringVariable |   | string Item num String | Variable |   |
| format |   | "" |   |   |
| everyFrame |   | false |   |   |

##### 6. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts |   | FSMViewAvalonia2.FsmArray2 |   |   |
| separator |   | "" |   |   |
| addToEnd |   | true |   |   |
| storeResult |   | string GO Variable Name | Variable |   |
| everyFrame |   | false |   |   |

##### 7. SetFsmGameObject

Full Name: HutongGames.PlayMaker.Actions.SetFsmGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inv Top |   |   |
| fsmName |   | "UI Inventory" | FsmName |   |
| variableName |   | string GO Variable Name | FsmGameObject |   |
| setValue |   | GameObject Current Item |   |   |
| everyFrame |   | false |   |   |

##### 8. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts |   | FSMViewAvalonia2.FsmArray2 |   |   |
| separator |   | "" |   |   |
| addToEnd |   | true |   |   |
| storeResult |   | string Title Variable Name | Variable |   |
| everyFrame |   | false |   |   |

##### 9. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts |   | FSMViewAvalonia2.FsmArray2 |   |   |
| separator |   | "" |   |   |
| addToEnd |   | true |   |   |
| storeResult |   | string Desc variable Name | Variable |   |
| everyFrame |   | false |   |   |

##### 10. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inv Top |   |   |
| fsmName |   | "UI Inventory" | FsmName |   |
| variableName |   | string Title Variable Name | FsmString |   |
| setValue |   | "INV_NAME_CITYKEY" |   |   |
| everyFrame |   | false |   |   |

##### 11. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inv Top |   |   |
| fsmName |   | "UI Inventory" | FsmName |   |
| variableName |   | string Desc variable Name | FsmString |   |
| setValue |   | "INV_DESC_CITYKEY" |   |   |
| everyFrame |   | false |   |   |

##### 12. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Next Item Num | Variable |   |
| add |   | 1 |   |   |
| everyFrame |   | false |   |   |

##### 13. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Equipment Slots Filled | Variable |   |
| add |   | 1 |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Store Key | 0 | |

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
| gameObject |   | OwnerDefault GameManager |   |   |
| boolName |   | "hasLoveKey" |   |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(FINISHED) |   |   |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Love Key" |   |   |
| storeResult |   | GameObject Current Item | Variable |   |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Current Item |   |   |
| activate |   | true |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 4. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Current Item |   |   |
| fsmName |   | "equip_position" | FsmName |   |
| variableName |   | "Item Number" | FsmInt |   |
| setValue |   | int Next Item Num |   |   |
| everyFrame |   | false |   |   |

##### 5. ConvertIntToString

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Next Item Num | Variable |   |
| stringVariable |   | string Item num String | Variable |   |
| format |   | "" |   |   |
| everyFrame |   | false |   |   |

##### 6. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts |   | FSMViewAvalonia2.FsmArray2 |   |   |
| separator |   | "" |   |   |
| addToEnd |   | true |   |   |
| storeResult |   | string GO Variable Name | Variable |   |
| everyFrame |   | false |   |   |

##### 7. SetFsmGameObject

Full Name: HutongGames.PlayMaker.Actions.SetFsmGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inv Top |   |   |
| fsmName |   | "UI Inventory" | FsmName |   |
| variableName |   | string GO Variable Name | FsmGameObject |   |
| setValue |   | GameObject Current Item |   |   |
| everyFrame |   | false |   |   |

##### 8. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts |   | FSMViewAvalonia2.FsmArray2 |   |   |
| separator |   | "" |   |   |
| addToEnd |   | true |   |   |
| storeResult |   | string Title Variable Name | Variable |   |
| everyFrame |   | false |   |   |

##### 9. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts |   | FSMViewAvalonia2.FsmArray2 |   |   |
| separator |   | "" |   |   |
| addToEnd |   | true |   |   |
| storeResult |   | string Desc variable Name | Variable |   |
| everyFrame |   | false |   |   |

##### 10. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inv Top |   |   |
| fsmName |   | "UI Inventory" | FsmName |   |
| variableName |   | string Title Variable Name | FsmString |   |
| setValue |   | "INV_NAME_LOVEKEY" |   |   |
| everyFrame |   | false |   |   |

##### 11. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inv Top |   |   |
| fsmName |   | "UI Inventory" | FsmName |   |
| variableName |   | string Desc variable Name | FsmString |   |
| setValue |   | "INV_DESC_LOVEKEY" |   |   |
| everyFrame |   | false |   |   |

##### 12. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Next Item Num | Variable |   |
| add |   | 1 |   |   |
| everyFrame |   | false |   |   |

##### 13. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Equipment Slots Filled | Variable |   |
| add |   | 1 |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Xun Flower | 0 | |

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
| gameObject |   | OwnerDefault GameManager |   |   |
| boolName |   | "hasKingsBrand" |   |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(FINISHED) |   |   |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Kings Brand" |   |   |
| storeResult |   | GameObject Current Item | Variable |   |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Current Item |   |   |
| activate |   | true |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 4. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Current Item |   |   |
| fsmName |   | "equip_position" | FsmName |   |
| variableName |   | "Item Number" | FsmInt |   |
| setValue |   | int Next Item Num |   |   |
| everyFrame |   | false |   |   |

##### 5. ConvertIntToString

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Next Item Num | Variable |   |
| stringVariable |   | string Item num String | Variable |   |
| format |   | "" |   |   |
| everyFrame |   | false |   |   |

##### 6. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts |   | FSMViewAvalonia2.FsmArray2 |   |   |
| separator |   | "" |   |   |
| addToEnd |   | true |   |   |
| storeResult |   | string GO Variable Name | Variable |   |
| everyFrame |   | false |   |   |

##### 7. SetFsmGameObject

Full Name: HutongGames.PlayMaker.Actions.SetFsmGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inv Top |   |   |
| fsmName |   | "UI Inventory" | FsmName |   |
| variableName |   | string GO Variable Name | FsmGameObject |   |
| setValue |   | GameObject Current Item |   |   |
| everyFrame |   | false |   |   |

##### 8. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts |   | FSMViewAvalonia2.FsmArray2 |   |   |
| separator |   | "" |   |   |
| addToEnd |   | true |   |   |
| storeResult |   | string Title Variable Name | Variable |   |
| everyFrame |   | false |   |   |

##### 9. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts |   | FSMViewAvalonia2.FsmArray2 |   |   |
| separator |   | "" |   |   |
| addToEnd |   | true |   |   |
| storeResult |   | string Desc variable Name | Variable |   |
| everyFrame |   | false |   |   |

##### 10. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inv Top |   |   |
| fsmName |   | "UI Inventory" | FsmName |   |
| variableName |   | string Title Variable Name | FsmString |   |
| setValue |   | "INV_NAME_KINGSBRAND" |   |   |
| everyFrame |   | false |   |   |

##### 11. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inv Top |   |   |
| fsmName |   | "UI Inventory" | FsmName |   |
| variableName |   | string Desc variable Name | FsmString |   |
| setValue |   | "INV_DESC_KINGSBRAND" |   |   |
| everyFrame |   | false |   |   |

##### 12. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Next Item Num | Variable |   |
| add |   | 1 |   |   |
| everyFrame |   | false |   |   |

##### 13. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Equipment Slots Filled | Variable |   |
| add |   | 1 |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Tram Pass | 0 | |

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
| gameObject |   | OwnerDefault GameManager |   |   |
| intName |   | "simpleKeys" |   |   |
| storeValue |   | int Items | Variable |   |

##### 2. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Items |   |   |
| integer2 |   | 0 |   |   |
| equal |   | Event(FINISHED) |   |   |
| lessThan |   | Event(FINISHED) |   |   |
| greaterThan |   | Event() |   |   |
| everyFrame |   | false |   |   |

##### 3. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Simple Key" |   |   |
| storeResult |   | GameObject Current Item | Variable |   |

##### 4. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Current Item |   |   |
| activate |   | true |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 5. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Current Item |   |   |
| fsmName |   | "equip_position" | FsmName |   |
| variableName |   | "Item Number" | FsmInt |   |
| setValue |   | int Next Item Num |   |   |
| everyFrame |   | false |   |   |

##### 6. ConvertIntToString

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Next Item Num | Variable |   |
| stringVariable |   | string Item num String | Variable |   |
| format |   | "" |   |   |
| everyFrame |   | false |   |   |

##### 7. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts |   | FSMViewAvalonia2.FsmArray2 |   |   |
| separator |   | "" |   |   |
| addToEnd |   | true |   |   |
| storeResult |   | string GO Variable Name | Variable |   |
| everyFrame |   | false |   |   |

##### 8. SetFsmGameObject

Full Name: HutongGames.PlayMaker.Actions.SetFsmGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inv Top |   |   |
| fsmName |   | "UI Inventory" | FsmName |   |
| variableName |   | string GO Variable Name | FsmGameObject |   |
| setValue |   | GameObject Current Item |   |   |
| everyFrame |   | false |   |   |

##### 9. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts |   | FSMViewAvalonia2.FsmArray2 |   |   |
| separator |   | "" |   |   |
| addToEnd |   | true |   |   |
| storeResult |   | string Title Variable Name | Variable |   |
| everyFrame |   | false |   |   |

##### 10. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts |   | FSMViewAvalonia2.FsmArray2 |   |   |
| separator |   | "" |   |   |
| addToEnd |   | true |   |   |
| storeResult |   | string Desc variable Name | Variable |   |
| everyFrame |   | false |   |   |

##### 11. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inv Top |   |   |
| fsmName |   | "UI Inventory" | FsmName |   |
| variableName |   | string Title Variable Name | FsmString |   |
| setValue |   | "INV_NAME_SIMPLEKEY" |   |   |
| everyFrame |   | false |   |   |

##### 12. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inv Top |   |   |
| fsmName |   | "UI Inventory" | FsmName |   |
| variableName |   | string Desc variable Name | FsmString |   |
| setValue |   | "INV_DESC_SIMPLEKEY" |   |   |
| everyFrame |   | false |   |   |

##### 13. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Next Item Num | Variable |   |
| add |   | 1 |   |   |
| everyFrame |   | false |   |   |

##### 14. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Equipment Slots Filled | Variable |   |
| add |   | 1 |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Ore | 0 | |

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
| gameObject |   | OwnerDefault GameManager |   |   |
| intName |   | "rancidEggs" |   |   |
| storeValue |   | int Items | Variable |   |

##### 2. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Items |   |   |
| integer2 |   | 0 |   |   |
| equal |   | Event(FINISHED) |   |   |
| lessThan |   | Event(FINISHED) |   |   |
| greaterThan |   | Event() |   |   |
| everyFrame |   | false |   |   |

##### 3. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Rancid Egg" |   |   |
| storeResult |   | GameObject Current Item | Variable |   |

##### 4. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Current Item |   |   |
| activate |   | true |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 5. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Current Item |   |   |
| fsmName |   | "equip_position" | FsmName |   |
| variableName |   | "Item Number" | FsmInt |   |
| setValue |   | int Next Item Num |   |   |
| everyFrame |   | false |   |   |

##### 6. ConvertIntToString

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Next Item Num | Variable |   |
| stringVariable |   | string Item num String | Variable |   |
| format |   | "" |   |   |
| everyFrame |   | false |   |   |

##### 7. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts |   | FSMViewAvalonia2.FsmArray2 |   |   |
| separator |   | "" |   |   |
| addToEnd |   | true |   |   |
| storeResult |   | string GO Variable Name | Variable |   |
| everyFrame |   | false |   |   |

##### 8. SetFsmGameObject

Full Name: HutongGames.PlayMaker.Actions.SetFsmGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inv Top |   |   |
| fsmName |   | "UI Inventory" | FsmName |   |
| variableName |   | string GO Variable Name | FsmGameObject |   |
| setValue |   | GameObject Current Item |   |   |
| everyFrame |   | false |   |   |

##### 9. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts |   | FSMViewAvalonia2.FsmArray2 |   |   |
| separator |   | "" |   |   |
| addToEnd |   | true |   |   |
| storeResult |   | string Title Variable Name | Variable |   |
| everyFrame |   | false |   |   |

##### 10. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts |   | FSMViewAvalonia2.FsmArray2 |   |   |
| separator |   | "" |   |   |
| addToEnd |   | true |   |   |
| storeResult |   | string Desc variable Name | Variable |   |
| everyFrame |   | false |   |   |

##### 11. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inv Top |   |   |
| fsmName |   | "UI Inventory" | FsmName |   |
| variableName |   | string Title Variable Name | FsmString |   |
| setValue |   | "INV_NAME_RANCIDEGG" |   |   |
| everyFrame |   | false |   |   |

##### 12. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inv Top |   |   |
| fsmName |   | "UI Inventory" | FsmName |   |
| variableName |   | string Desc variable Name | FsmString |   |
| setValue |   | "INV_DESC_RANCIDEGG" |   |   |
| everyFrame |   | false |   |   |

##### 13. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Next Item Num | Variable |   |
| add |   | 1 |   |   |
| everyFrame |   | false |   |   |

##### 14. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Equipment Slots Filled | Variable |   |
| add |   | 1 |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Pause | 0 | |

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
| stringParts |   | FSMViewAvalonia2.FsmArray2 |   |   |
| separator |   | "" |   |   |
| addToEnd |   | true |   |   |
| storeResult |   | string Title Variable Name | Variable |   |
| everyFrame |   | false |   |   |

##### 2. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts |   | FSMViewAvalonia2.FsmArray2 |   |   |
| separator |   | "" |   |   |
| addToEnd |   | true |   |   |
| storeResult |   | string Desc variable Name | Variable |   |
| everyFrame |   | false |   |   |

##### 3. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inv Top |   |   |
| fsmName |   | "UI Inventory" | FsmName |   |
| variableName |   | string Title Variable Name | FsmString |   |
| setValue |   | "INV_NAME_FLOWER" |   |   |
| everyFrame |   | false |   |   |

##### 4. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inv Top |   |   |
| fsmName |   | "UI Inventory" | FsmName |   |
| variableName |   | string Desc variable Name | FsmString |   |
| setValue |   | "INV_DESC_FLOWER" |   |   |
| everyFrame |   | false |   |   |

##### 5. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| boolName |   | "xunFlowerBroken" |   |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(FINISHED) |   |   |

##### 6. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inv Top |   |   |
| fsmName |   | "UI Inventory" | FsmName |   |
| variableName |   | string Title Variable Name | FsmString |   |
| setValue |   | "INV_NAME_FLOWER_BROKEN" |   |   |
| everyFrame |   | false |   |   |

##### 7. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inv Top |   |   |
| fsmName |   | "UI Inventory" | FsmName |   |
| variableName |   | string Desc variable Name | FsmString |   |
| setValue |   | "INV_DESC_FLOWER_BROKEN" |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Extra Flower? | 0 | |

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
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Map and Quill" |   |   |
| storeResult |   | GameObject Current Item | Variable |   |

##### 2. SetSpriteRendererSprite

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRendererSprite
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Current Item |   |   |
| sprite |   | [inv_item__0008_jar_col_map (Sprite) (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\resources.assets)] |   |   |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Current Item |   |   |
| activate |   | true |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 4. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Current Item |   |   |
| fsmName |   | "equip_position" | FsmName |   |
| variableName |   | "Item Number" | FsmInt |   |
| setValue |   | int Next Item Num |   |   |
| everyFrame |   | false |   |   |

##### 5. ConvertIntToString

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Next Item Num | Variable |   |
| stringVariable |   | string Item num String | Variable |   |
| format |   | "" |   |   |
| everyFrame |   | false |   |   |

##### 6. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts |   | FSMViewAvalonia2.FsmArray2 |   |   |
| separator |   | "" |   |   |
| addToEnd |   | true |   |   |
| storeResult |   | string GO Variable Name | Variable |   |
| everyFrame |   | false |   |   |

##### 7. SetFsmGameObject

Full Name: HutongGames.PlayMaker.Actions.SetFsmGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inv Top |   |   |
| fsmName |   | "UI Inventory" | FsmName |   |
| variableName |   | string GO Variable Name | FsmGameObject |   |
| setValue |   | GameObject Current Item |   |   |
| everyFrame |   | false |   |   |

##### 8. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts |   | FSMViewAvalonia2.FsmArray2 |   |   |
| separator |   | "" |   |   |
| addToEnd |   | true |   |   |
| storeResult |   | string Title Variable Name | Variable |   |
| everyFrame |   | false |   |   |

##### 9. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts |   | FSMViewAvalonia2.FsmArray2 |   |   |
| separator |   | "" |   |   |
| addToEnd |   | true |   |   |
| storeResult |   | string Desc variable Name | Variable |   |
| everyFrame |   | false |   |   |

##### 10. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inv Top |   |   |
| fsmName |   | "UI Inventory" | FsmName |   |
| variableName |   | string Title Variable Name | FsmString |   |
| setValue |   | "INV_NAME_MAP" |   |   |
| everyFrame |   | false |   |   |

##### 11. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inv Top |   |   |
| fsmName |   | "UI Inventory" | FsmName |   |
| variableName |   | string Desc variable Name | FsmString |   |
| setValue |   | "INV_DESC_MAP" |   |   |
| everyFrame |   | false |   |   |

##### 12. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Next Item Num | Variable |   |
| add |   | 1 |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Kings Brand | 0 | |

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
| boolName |   | "hasMap" |   |   |
| storeValue |   | bool Has Map | Variable |   |

##### 2. GetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName |   | "hasQuill" |   |   |
| storeValue |   | bool Has Quill | Variable |   |

##### 3. BoolNoneTrue

Full Name: HutongGames.PlayMaker.Actions.BoolNoneTrue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariables |   | FSMViewAvalonia2.FsmArray2 | Variable |   |
| sendEvent |   | Event(NONE) |   |   |
| storeResult |   | false | Variable |   |
| everyFrame |   | false |   |   |

##### 4. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Equipment Slots Filled | Variable |   |
| add |   | 1 |   |   |
| everyFrame |   | false |   |   |

##### 5. BoolAllTrue

Full Name: HutongGames.PlayMaker.Actions.BoolAllTrue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariables |   | FSMViewAvalonia2.FsmArray2 | Variable |   |
| sendEvent |   | Event(MAP AND QUILL) |   |   |
| storeResult |   | false | Variable |   |
| everyFrame |   | false |   |   |

##### 6. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Has Map | Variable |   |
| isTrue |   | Event(MAP) |   |   |
| isFalse |   | Event() |   |   |
| everyFrame |   | false |   |   |

##### 7. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Has Quill | Variable |   |
| isTrue |   | Event(QUILL) |   |   |
| isFalse |   | Event() |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| NONE | Kings Brand | 0 | |
| MAP | Map | 0 | |
| QUILL | Quill | 0 | |
| MAP AND QUILL | Map and Quill | 0 | |

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
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Map and Quill" |   |   |
| storeResult |   | GameObject Current Item | Variable |   |

##### 2. SetSpriteRendererSprite

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRendererSprite
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Current Item |   |   |
| sprite |   | [inv_item__0004_quill (Sprite) (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\resources.assets)] |   |   |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Current Item |   |   |
| activate |   | true |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 4. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Current Item |   |   |
| fsmName |   | "equip_position" | FsmName |   |
| variableName |   | "Item Number" | FsmInt |   |
| setValue |   | int Next Item Num |   |   |
| everyFrame |   | false |   |   |

##### 5. ConvertIntToString

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Next Item Num | Variable |   |
| stringVariable |   | string Item num String | Variable |   |
| format |   | "" |   |   |
| everyFrame |   | false |   |   |

##### 6. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts |   | FSMViewAvalonia2.FsmArray2 |   |   |
| separator |   | "" |   |   |
| addToEnd |   | true |   |   |
| storeResult |   | string GO Variable Name | Variable |   |
| everyFrame |   | false |   |   |

##### 7. SetFsmGameObject

Full Name: HutongGames.PlayMaker.Actions.SetFsmGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inv Top |   |   |
| fsmName |   | "UI Inventory" | FsmName |   |
| variableName |   | string GO Variable Name | FsmGameObject |   |
| setValue |   | GameObject Current Item |   |   |
| everyFrame |   | false |   |   |

##### 8. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts |   | FSMViewAvalonia2.FsmArray2 |   |   |
| separator |   | "" |   |   |
| addToEnd |   | true |   |   |
| storeResult |   | string Title Variable Name | Variable |   |
| everyFrame |   | false |   |   |

##### 9. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts |   | FSMViewAvalonia2.FsmArray2 |   |   |
| separator |   | "" |   |   |
| addToEnd |   | true |   |   |
| storeResult |   | string Desc variable Name | Variable |   |
| everyFrame |   | false |   |   |

##### 10. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inv Top |   |   |
| fsmName |   | "UI Inventory" | FsmName |   |
| variableName |   | string Title Variable Name | FsmString |   |
| setValue |   | "INV_NAME_QUILL" |   |   |
| everyFrame |   | false |   |   |

##### 11. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inv Top |   |   |
| fsmName |   | "UI Inventory" | FsmName |   |
| variableName |   | string Desc variable Name | FsmString |   |
| setValue |   | "INV_DESC_QUILL" |   |   |
| everyFrame |   | false |   |   |

##### 12. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Next Item Num | Variable |   |
| add |   | 1 |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Kings Brand | 0 | |

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
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Map and Quill" |   |   |
| storeResult |   | GameObject Current Item | Variable |   |

##### 2. SetSpriteRendererSprite

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRendererSprite
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Current Item |   |   |
| sprite |   | [inv_item_map_quill_combined (Sprite) (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\resources.assets)] |   |   |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Current Item |   |   |
| activate |   | true |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 4. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Current Item |   |   |
| fsmName |   | "equip_position" | FsmName |   |
| variableName |   | "Item Number" | FsmInt |   |
| setValue |   | int Next Item Num |   |   |
| everyFrame |   | false |   |   |

##### 5. ConvertIntToString

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Next Item Num | Variable |   |
| stringVariable |   | string Item num String | Variable |   |
| format |   | "" |   |   |
| everyFrame |   | false |   |   |

##### 6. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts |   | FSMViewAvalonia2.FsmArray2 |   |   |
| separator |   | "" |   |   |
| addToEnd |   | true |   |   |
| storeResult |   | string GO Variable Name | Variable |   |
| everyFrame |   | false |   |   |

##### 7. SetFsmGameObject

Full Name: HutongGames.PlayMaker.Actions.SetFsmGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inv Top |   |   |
| fsmName |   | "UI Inventory" | FsmName |   |
| variableName |   | string GO Variable Name | FsmGameObject |   |
| setValue |   | GameObject Current Item |   |   |
| everyFrame |   | false |   |   |

##### 8. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts |   | FSMViewAvalonia2.FsmArray2 |   |   |
| separator |   | "" |   |   |
| addToEnd |   | true |   |   |
| storeResult |   | string Title Variable Name | Variable |   |
| everyFrame |   | false |   |   |

##### 9. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts |   | FSMViewAvalonia2.FsmArray2 |   |   |
| separator |   | "" |   |   |
| addToEnd |   | true |   |   |
| storeResult |   | string Desc variable Name | Variable |   |
| everyFrame |   | false |   |   |

##### 10. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inv Top |   |   |
| fsmName |   | "UI Inventory" | FsmName |   |
| variableName |   | string Title Variable Name | FsmString |   |
| setValue |   | "INV_NAME_MAPQUILL" |   |   |
| everyFrame |   | false |   |   |

##### 11. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inv Top |   |   |
| fsmName |   | "UI Inventory" | FsmName |   |
| variableName |   | string Desc variable Name | FsmString |   |
| setValue |   | "INV_DESC_MAPQUILL" |   |   |
| everyFrame |   | false |   |   |

##### 12. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Next Item Num | Variable |   |
| add |   | 1 |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Kings Brand | 0 | |

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
| integer1 |   | int Equipment Slots Filled |   |   |
| integer2 |   | 13 |   |   |
| equal |   | Event() |   |   |
| lessThan |   | Event(FINISHED) |   |   |
| greaterThan |   | Event() |   |   |
| everyFrame |   | false |   |   |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(BroadcastAll):FSM Owner |   |   |
| sendEvent |   | "EQUIPMENT OVERMAX SHIFT" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 3. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Max Shifted | Variable |   |
| boolValue |   | true |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Trink 4 | 0 | |

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
| sendEvent |   | Event(FINISHED) |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Shift? | 0 | |

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
| gameObject |   | OwnerDefault GameManager |   |   |
| boolName |   | "extraFlowerAppear" |   |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(FINISHED) |   |   |

##### 2. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inv Top |   |   |
| fsmName |   | "UI Inventory" | FsmName |   |
| variableName |   | string Title Variable Name | FsmString |   |
| setValue |   | "INV_NAME_FLOWER" |   |   |
| everyFrame |   | false |   |   |

##### 3. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inv Top |   |   |
| fsmName |   | "UI Inventory" | FsmName |   |
| variableName |   | string Desc variable Name | FsmString |   |
| setValue |   | "INV_DESC_FLOWER_QG" |   |   |
| everyFrame |   | false |   |   |

##### 4. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| boolName |   | "xunFlowerBroken" |   |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(FINISHED) |   |   |

##### 5. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inv Top |   |   |
| fsmName |   | "UI Inventory" | FsmName |   |
| variableName |   | string Title Variable Name | FsmString |   |
| setValue |   | "INV_NAME_FLOWER_BROKEN" |   |   |
| everyFrame |   | false |   |   |

##### 6. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inv Top |   |   |
| fsmName |   | "UI Inventory" | FsmName |   |
| variableName |   | string Desc variable Name | FsmString |   |
| setValue |   | "INV_DESC_FLOWER_BROKEN_QG" |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Simple Key | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| CHECK | false |
| FINISHED | false |
| MAP | false |
| MAP AND QUILL | false |
| NONE | false |
| QUILL | false |

