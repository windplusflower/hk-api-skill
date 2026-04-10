# UI Charms

## Summary

| Field | Value |
| --- | --- |
| FSM Name | UI Charms |
| GameObject Name | Charms |
| GameObject Path | _GameCameras/HudCamera/Inventory |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Init |
| FSM PathId | 20191 |
| GameObject PathId | 6719 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Target Charm X | 0 | Single: 0 |

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Charm Num | 0 | Int32: 0 |
| Collection Pos | 0 | Int32: 0 |
| Cool Number | 0 | Int32: 0 |
| Current Item Number | 0 | Int32: 0 |
| Grimmchild Lv | 0 | Int32: 0 |
| Item Number Alt | 0 | Int32: 0 |
| New Charm ID | 0 | Int32: 0 |
| Notch Cost | 0 | Int32: 0 |
| Notches | 0 | Int32: 0 |
| Notches Filled | 0 | Int32: 0 |
| Overcharm Attempts | 0 | Int32: 0 |
| Overcharm Notches | 0 | Int32: 0 |
| Prev Current Item Num | 0 | Int32: 0 |
| Royal Charm State | 0 | Int32: 0 |
| Slots | 0 | Int32: 0 |
| Slots Filled | 0 | Int32: 0 |
| Target List Num | 0 | Int32: 0 |
| UI Items | 0 | Int32: 0 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Glass Attack Broken | false | Boolean: false |
| Glass Attack Selected | false | Boolean: false |
| Glass Geo Broken | false | Boolean: false |
| Glass Geo Selected | false | Boolean: false |
| Glass HP Broken | false | Boolean: false |
| Glass HP Selected | false | Boolean: false |
| Got Charm | false | Boolean: false |
| Idle Collection | false | Boolean: false |
| On Notch | false | Boolean: false |
| Open Slot | false | Boolean: false |
| Overcharm Ending | false | Boolean: false |
| Repeating | false | Boolean: false |

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| BB Num String |  | String:  |
| Build String |  | String:  |
| Convo Desc |  | String:  |
| Convo Name |  | String:  |
| Current BB Name |  | String:  |
| Current Item Name |  | String:  |
| Item Name |  | String:  |
| Item Num String |  | String:  |
| Newly Equipped Name |  | String:  |
| PlayerData Var Name |  | String:  |
| String Equip |  | String:  |
| String Unequip |  | String:  |

### Vector3s

| Name | Value | Raw/Type |
| --- | --- | --- |
| Cursor Start Pos | Vector3(0, 0, 0) | Vector3: Vector3(0, 0, 0) |
| OC Crack Pos | Vector3(0, 0, 0) | Vector3: Vector3(0, 0, 0) |
| Open Notch Pos | Vector3(0, 0, 0) | Vector3: Vector3(0, 0, 0) |
| Source Charm Pos | Vector3(0, 0, 0) | Vector3: Vector3(0, 0, 0) |
| Target Charm Pos | Vector3(0, 0, 0) | Vector3: Vector3(0, 0, 0) |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Arrow L | [null] | NamedAssetPPtr:  |
| Arrow R | [null] | NamedAssetPPtr:  |
| Backboards | [null] | NamedAssetPPtr:  |
| Border | [null] | NamedAssetPPtr:  |
| Charm Equip Msg | [null] | NamedAssetPPtr:  |
| Collected Charms | [null] | NamedAssetPPtr:  |
| Confirm Action | [null] | NamedAssetPPtr:  |
| Confirm Action Text | [null] | NamedAssetPPtr:  |
| Cost Details | [null] | NamedAssetPPtr:  |
| Current BB | [null] | NamedAssetPPtr:  |
| Current Item | [null] | NamedAssetPPtr:  |
| Cursor | [null] | NamedAssetPPtr:  |
| Cursor Back | [null] | NamedAssetPPtr:  |
| Cursor Glow | [null] | NamedAssetPPtr:  |
| Detail Sprite | [null] | NamedAssetPPtr:  |
| Details Folder | [null] | NamedAssetPPtr:  |
| Equipped Ch Folder | [null] | NamedAssetPPtr:  |
| Equipped Charms | [null] | NamedAssetPPtr:  |
| Grimm Flame UI | [null] | NamedAssetPPtr:  |
| Notches Folder | [null] | NamedAssetPPtr:  |
| OC Backboard | [null] | NamedAssetPPtr:  |
| OC Break | [null] | NamedAssetPPtr:  |
| OC Crack 1 | [null] | NamedAssetPPtr:  |
| OC Crack 2 | [null] | NamedAssetPPtr:  |
| OC Fail Tink | [null] | NamedAssetPPtr:  |
| OC Set Effect | [null] | NamedAssetPPtr:  |
| Open Notch | [null] | NamedAssetPPtr:  |
| Over Indicator | [null] | NamedAssetPPtr:  |
| Overcharm Folder | [null] | NamedAssetPPtr:  |
| Parent | [null] | NamedAssetPPtr:  |
| Self | [null] | NamedAssetPPtr:  |
| Source Charm | [null] | NamedAssetPPtr:  |
| Source Sprite | [null] | NamedAssetPPtr:  |
| Target Charm | [null] | NamedAssetPPtr:  |
| Text Desc | [null] | NamedAssetPPtr:  |
| Text Equipped | [null] | NamedAssetPPtr:  |
| Text Name | [null] | NamedAssetPPtr:  |
| Text Overcharmed | [null] | NamedAssetPPtr:  |
| Tweener Charm | [null] | NamedAssetPPtr:  |
| Tweener Charm Particle | [null] | NamedAssetPPtr:  |

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

##### 3. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Parent | OwnerDefault Parent |  |  |
| childName | "Border" | "Border" |  |  |
| storeResult | GameObject Border | GameObject Border | Variable |  |

##### 4. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Border | OwnerDefault Border |  |  |
| childName | "Arrow Right" | "Arrow Right" |  |  |
| storeResult | GameObject Arrow R | GameObject Arrow R | Variable |  |

##### 5. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Border | OwnerDefault Border |  |  |
| childName | "Arrow Left" | "Arrow Left" |  |  |
| storeResult | GameObject Arrow L | GameObject Arrow L | Variable |  |

##### 6. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Cursor" | "Cursor" |  |  |
| storeResult | GameObject Cursor | GameObject Cursor | Variable |  |

##### 7. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Backboards" | "Backboards" |  |  |
| storeResult | GameObject Backboards | GameObject Backboards | Variable |  |

##### 8. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Equipped Charms" | "Equipped Charms" |  |  |
| storeResult | GameObject Equipped Charms | GameObject Equipped Charms | Variable |  |

##### 9. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Equipped Charms | OwnerDefault Equipped Charms |  |  |
| childName | "Next Dot" | "Next Dot" |  |  |
| storeResult | GameObject Open Notch | GameObject Open Notch | Variable |  |

##### 10. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Equipped Charms | OwnerDefault Equipped Charms |  |  |
| childName | "Text Equipped" | "Text Equipped" |  |  |
| storeResult | GameObject Text Equipped | GameObject Text Equipped | Variable |  |

##### 11. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Equipped Charms | OwnerDefault Equipped Charms |  |  |
| childName | "Text Overcharmed" | "Text Overcharmed" |  |  |
| storeResult | GameObject Text Overcharmed | GameObject Text Overcharmed | Variable |  |

##### 12. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Tweener Charm" | "Tweener Charm" |  |  |
| storeResult | GameObject Tweener Charm | GameObject Tweener Charm | Variable |  |

##### 13. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Tweener Charm | OwnerDefault Tweener Charm |  |  |
| childName | "Appear Trail" | "Appear Trail" |  |  |
| storeResult | GameObject Tweener Charm Particle | GameObject Tweener Charm Particle | Variable |  |

##### 14. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Collected Charms" | "Collected Charms" |  |  |
| storeResult | GameObject Collected Charms | GameObject Collected Charms | Variable |  |

##### 15. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Equipped Charms | OwnerDefault Equipped Charms |  |  |
| childName | "Charms" | "Charms" |  |  |
| storeResult | GameObject Equipped Ch Folder | GameObject Equipped Ch Folder | Variable |  |

##### 16. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Details" | "Details" |  |  |
| storeResult | GameObject Details Folder | GameObject Details Folder | Variable |  |

##### 17. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Details Folder | OwnerDefault Details Folder |  |  |
| childName | "Cost" | "Cost" |  |  |
| storeResult | GameObject Cost Details | GameObject Cost Details | Variable |  |

##### 18. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Details Folder | OwnerDefault Details Folder |  |  |
| childName | "Detail Sprite" | "Detail Sprite" |  |  |
| storeResult | GameObject Detail Sprite | GameObject Detail Sprite | Variable |  |

##### 19. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Equipped Charms | OwnerDefault Equipped Charms |  |  |
| childName | "Notches" | "Notches" |  |  |
| storeResult | GameObject Notches Folder | GameObject Notches Folder | Variable |  |

##### 20. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Notches Folder | OwnerDefault Notches Folder |  |  |
| childName | "Over Indicator" | "Over Indicator" |  |  |
| storeResult | GameObject Over Indicator | GameObject Over Indicator | Variable |  |

##### 21. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Overcharm" | "Overcharm" |  |  |
| storeResult | GameObject Overcharm Folder | GameObject Overcharm Folder | Variable |  |

##### 22. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Overcharm Folder | OwnerDefault Overcharm Folder |  |  |
| childName | "Overcharm_crack1" | "Overcharm_crack1" |  |  |
| storeResult | GameObject OC Crack 1 | GameObject OC Crack 1 | Variable |  |

##### 23. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Overcharm Folder | OwnerDefault Overcharm Folder |  |  |
| childName | "Overcharm_crack2" | "Overcharm_crack2" |  |  |
| storeResult | GameObject OC Crack 2 | GameObject OC Crack 2 | Variable |  |

##### 24. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Overcharm Folder | OwnerDefault Overcharm Folder |  |  |
| childName | "Overcharm_Break" | "Overcharm_Break" |  |  |
| storeResult | GameObject OC Break | GameObject OC Break | Variable |  |

##### 25. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Overcharm Folder | OwnerDefault Overcharm Folder |  |  |
| childName | "OC Backboard" | "OC Backboard" |  |  |
| storeResult | GameObject OC Backboard | GameObject OC Backboard | Variable |  |

##### 26. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Overcharm Folder | OwnerDefault Overcharm Folder |  |  |
| childName | "Overcharm Set" | "Overcharm Set" |  |  |
| storeResult | GameObject OC Set Effect | GameObject OC Set Effect | Variable |  |

##### 27. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Overcharm Folder | OwnerDefault Overcharm Folder |  |  |
| childName | "Fail Tink" | "Fail Tink" |  |  |
| storeResult | GameObject OC Fail Tink | GameObject OC Fail Tink | Variable |  |

##### 28. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Cursor | OwnerDefault Cursor |  |  |
| childName | "Back" | "Back" |  |  |
| storeResult | GameObject Cursor Back | GameObject Cursor Back | Variable |  |

##### 29. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Cursor Back | OwnerDefault Cursor Back |  |  |
| childName | "Glow" | "Glow" |  |  |
| storeResult | GameObject Cursor Glow | GameObject Cursor Glow | Variable |  |

##### 30. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Confirm Action" | "Confirm Action" |  |  |
| storeResult | GameObject Confirm Action | GameObject Confirm Action | Variable |  |

##### 31. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Grimm Flame UI" | "Grimm Flame UI" |  |  |
| storeResult | GameObject Grimm Flame UI | GameObject Grimm Flame UI | Variable |  |

##### 32. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Confirm Action | OwnerDefault Confirm Action |  |  |
| childName | "Text" | "Text" |  |  |
| storeResult | GameObject Confirm Action Text | GameObject Confirm Action Text | Variable |  |

##### 33. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault OC Break | OwnerDefault OC Break |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 34. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "UI" | "UI" |  |  |
| convName | "CTRL_EQUIP" | "CTRL_EQUIP" |  |  |
| storeValue | string String Equip | string String Equip | Variable |  |

##### 35. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "UI" | "UI" |  |  |
| convName | "CTRL_UNEQUIP" | "CTRL_UNEQUIP" |  |  |
| storeValue | string String Unequip | string String Unequip | Variable |  |

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
| eventTarget | EventTarget(GameObject):Self | EventTarget(GameObject):Self |  |  |
| sendEvent | "UI INACTIVE" | "UI INACTIVE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Text Desc" | "Text Desc" |  |  |
| storeResult | GameObject Text Desc | GameObject Text Desc | Variable |  |

##### 3. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Text Name" | "Text Name" |  |  |
| storeResult | GameObject Text Name | GameObject Text Name | Variable |  |

##### 4. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Text Desc | OwnerDefault Text Desc |  |  |
| textString | "" | "" |  |  |

##### 5. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Text Name | OwnerDefault Text Name |  |  |
| textString | "" | "" |  |  |

##### 6. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Cost Details | OwnerDefault Cost Details |  |  |
| fsmName | "Charm Details Cost" | "Charm Details Cost" | FsmName |  |
| variableName | "Cost" | "Cost" | FsmInt |  |
| setValue | 0 | 0 |  |  |
| everyFrame | false | false |  |  |

##### 7. SetSpriteRendererSprite

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRendererSprite
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Detail Sprite | OwnerDefault Detail Sprite |  |  |
| sprite | [] | [] |  |  |

##### 8. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Cost Details | EventTarget(GameObject):Cost Details |  |  |
| sendEvent | "UPDATE" | "UPDATE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

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
| eventTarget | EventTarget(GameObject)[SendToChildren]:Cursor | EventTarget(GameObject)[SendToChildren]:Cursor |  |  |
| sendEvent | "DOWN" | "DOWN" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Confirm Action | OwnerDefault Confirm Action |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

### Activate

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
| intName | "royalCharmState" | "royalCharmState" |  |  |
| storeValue | int Royal Charm State | int Royal Charm State | Variable |  |

##### 2. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "grimmChildLevel" | "grimmChildLevel" |  |  |
| storeValue | int Grimmchild Lv | int Grimmchild Lv | Variable |  |

##### 3. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Overcharm Attempts | int Overcharm Attempts | Variable |  |
| intValue | 0 | 0 |  |  |
| everyFrame | false | false |  |  |

##### 4. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Collection Pos | int Collection Pos | Variable |  |
| intValue | int New Charm ID | int New Charm ID |  |  |
| everyFrame | false | false |  |  |

##### 5. SetSpriteRenderer

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Tweener Charm | OwnerDefault Tweener Charm |  |  |
| active | false | false |  |  |

##### 6. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Cursor | EventTarget(GameObject):Cursor |  |  |
| sendEvent | "CURSOR ACTIVATE" | "CURSOR ACTIVATE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 7. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Self | EventTarget(GameObject):Self |  |  |
| sendEvent | "UI ACTIVE" | "UI ACTIVE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 8. ConvertIntToString

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Collection Pos | int Collection Pos | Variable |  |
| stringVariable | string BB Num String | string BB Num String | Variable |  |
| format | "" | "" |  |  |
| everyFrame | false | false |  |  |

##### 9. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string Current BB Name | string Current BB Name | Variable |  |
| everyFrame | false | false |  |  |

##### 10. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Backboards | OwnerDefault Backboards |  |  |
| childName | string Current BB Name | string Current BB Name |  |  |
| storeResult | GameObject Current BB | GameObject Current BB | Variable |  |

##### 11. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Current BB | OwnerDefault Current BB |  |  |
| vector | Vector3 Cursor Start Pos | Vector3 Cursor Start Pos | Variable |  |
| x | 0f | 0f | Variable |  |
| y | 0f | 0f | Variable |  |
| z | 0f | 0f | Variable |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |

##### 12. Vector3AddXYZ

Full Name: HutongGames.PlayMaker.Actions.Vector3AddXYZ
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable | Vector3 Cursor Start Pos | Vector3 Cursor Start Pos | Variable |  |
| addX | -0.01f | -0.01f |  |  |
| addY | 0.01f | 0.01f |  |  |
| addZ | 0f | 0f |  |  |
| everyFrame | false | false |  |  |
| perSecond | false | false |  |  |

##### 13. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Cursor | OwnerDefault Cursor |  |  |
| vector | Vector3 Cursor Start Pos | Vector3 Cursor Start Pos | Variable |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| z | -4.5f | -4.5f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 14. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Detail Sprite | OwnerDefault Detail Sprite |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | -5.59f | -5.59f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

### Idle Collection

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 6

#### Actions

##### 1. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Idle Collection | bool Idle Collection | Variable |  |
| boolValue | true | true |  |  |
| everyFrame | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "CONFIRM CANCEL" | "CONFIRM CANCEL" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Down

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Collection Pos | int Collection Pos |  |  |
| integer2 | 30 | 30 |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event() | Event() |  |  |
| greaterThan | Event(FINISHED) | Event(FINISHED) |  |  |
| everyFrame | false | false |  |  |

##### 2. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Collection Pos | int Collection Pos | Variable |  |
| add | 10 | 10 |  |  |
| everyFrame | false | false |  |  |

### Update Cursor

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetSpriteRendererOrder

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRendererOrder
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Cursor Glow | OwnerDefault Cursor Glow |  |  |
| order | 0 | 0 |  |  |
| delay | 0f | 0f |  |  |

##### 2. IntClamp

Full Name: HutongGames.PlayMaker.Actions.IntClamp
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Current Item Number | int Current Item Number | Variable |  |
| minValue | 1 | 1 |  |  |
| maxValue | 40 | 40 |  |  |
| everyFrame | false | false |  |  |

##### 3. ConvertIntToString

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Current Item Number | int Current Item Number | Variable |  |
| stringVariable | string Item Num String | string Item Num String | Variable |  |
| format | "" | "" |  |  |
| everyFrame | false | false |  |  |

##### 4. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string Current Item Name | string Current Item Name | Variable |  |
| everyFrame | false | false |  |  |

##### 5. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Backboards | OwnerDefault Backboards |  |  |
| childName | string Current Item Name | string Current Item Name |  |  |
| storeResult | GameObject Current Item | GameObject Current Item | Variable |  |

##### 6. SetFsmGameObject

Full Name: HutongGames.PlayMaker.Actions.SetFsmGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Update Cursor" | "Update Cursor" | FsmName |  |
| variableName | "Item" | "Item" | FsmGameObject |  |
| setValue | GameObject Current BB | GameObject Current BB |  |  |
| everyFrame | false | false |  |  |

##### 7. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "UPDATE CURSOR" | "UPDATE CURSOR" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 8. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Current BB | EventTarget(GameObject):Current BB |  |  |
| sendEvent | "SELECTED" | "SELECTED" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 9. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Update Text" | "Update Text" | FsmName |  |
| variableName | "Convo Name" | "Convo Name" | FsmString |  |
| setValue | "" | "" |  |  |
| everyFrame | false | false |  |  |

##### 10. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Update Text" | "Update Text" | FsmName |  |
| variableName | "Convo Desc" | "Convo Desc" | FsmString |  |
| setValue | "" | "" |  |  |
| everyFrame | false | false |  |  |

### Left

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. IntSwitch

Full Name: HutongGames.PlayMaker.Actions.IntSwitch
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Collection Pos | int Collection Pos | Variable |  |
| compareTo | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| sendEvent | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| everyFrame | false | false |  |  |

##### 2. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Collection Pos | int Collection Pos | Variable |  |
| add | -1 | -1 |  |  |
| everyFrame | false | false |  |  |

### Right

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. IntSwitch

Full Name: HutongGames.PlayMaker.Actions.IntSwitch
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Collection Pos | int Collection Pos | Variable |  |
| compareTo | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| sendEvent | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| everyFrame | false | false |  |  |

##### 2. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Collection Pos | int Collection Pos | Variable |  |
| add | 1 | 1 |  |  |
| everyFrame | false | false |  |  |

### Up

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Collection Pos | int Collection Pos |  |  |
| integer2 | 11 | 11 |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event(TO TOP) | Event(TO TOP) |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 2. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Collection Pos | int Collection Pos | Variable |  |
| add | -10 | -10 |  |  |
| everyFrame | false | false |  |  |

### Arrow L

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. SetFsmGameObject

Full Name: HutongGames.PlayMaker.Actions.SetFsmGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Update Cursor" | "Update Cursor" | FsmName |  |
| variableName | "Item" | "Item" | FsmGameObject |  |
| setValue | GameObject Arrow L | GameObject Arrow L |  |  |
| everyFrame | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Grimm Flame UI | EventTarget(GameObject):Grimm Flame UI |  |  |
| sendEvent | "HIDE" | "HIDE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. SetSpriteRendererOrder

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRendererOrder
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Cursor Glow | OwnerDefault Cursor Glow |  |  |
| order | 10 | 10 |  |  |
| delay | 0.15f | 0.15f |  |  |

##### 4. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Update Text" | "Update Text" | FsmName |  |
| variableName | "Convo Name" | "Convo Name" | FsmString |  |
| setValue | "UI_BLANK" | "UI_BLANK" |  |  |
| everyFrame | false | false |  |  |

##### 5. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Update Text" | "Update Text" | FsmName |  |
| variableName | "Convo Desc" | "Convo Desc" | FsmString |  |
| setValue | "UI_BLANK" | "UI_BLANK" |  |  |
| everyFrame | false | false |  |  |

##### 6. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "UPDATE CURSOR" | "UPDATE CURSOR" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 7. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Cost Details | OwnerDefault Cost Details |  |  |
| fsmName | "Charm Details Cost" | "Charm Details Cost" | FsmName |  |
| variableName | "Cost" | "Cost" | FsmInt |  |
| setValue | 0 | 0 |  |  |
| everyFrame | false | false |  |  |

##### 8. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Detail Sprite | OwnerDefault Detail Sprite |  |  |
| fsmName | "Update Sprite" | "Update Sprite" | FsmName |  |
| variableName | "ID" | "ID" | FsmInt |  |
| setValue | 0 | 0 |  |  |
| everyFrame | false | false |  |  |

##### 9. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:Details Folder | EventTarget(GameObject)[SendToChildren]:Details Folder |  |  |
| sendEvent | "UPDATE" | "UPDATE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Shift Pane L

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

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
| eventTarget | EventTarget(GameObject):Parent | EventTarget(GameObject):Parent |  |  |
| sendEvent | "MOVE PANE L" | "MOVE PANE L" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Arrow R

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. SetFsmGameObject

Full Name: HutongGames.PlayMaker.Actions.SetFsmGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Update Cursor" | "Update Cursor" | FsmName |  |
| variableName | "Item" | "Item" | FsmGameObject |  |
| setValue | GameObject Arrow R | GameObject Arrow R |  |  |
| everyFrame | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Grimm Flame UI | EventTarget(GameObject):Grimm Flame UI |  |  |
| sendEvent | "HIDE" | "HIDE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. SetSpriteRendererOrder

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRendererOrder
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Cursor Glow | OwnerDefault Cursor Glow |  |  |
| order | 10 | 10 |  |  |
| delay | 0.15f | 0.15f |  |  |

##### 4. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Update Text" | "Update Text" | FsmName |  |
| variableName | "Convo Name" | "Convo Name" | FsmString |  |
| setValue | "UI_BLANK" | "UI_BLANK" |  |  |
| everyFrame | false | false |  |  |

##### 5. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Update Text" | "Update Text" | FsmName |  |
| variableName | "Convo Desc" | "Convo Desc" | FsmString |  |
| setValue | "UI_BLANK" | "UI_BLANK" |  |  |
| everyFrame | false | false |  |  |

##### 6. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "UPDATE CURSOR" | "UPDATE CURSOR" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 7. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Cost Details | OwnerDefault Cost Details |  |  |
| fsmName | "Charm Details Cost" | "Charm Details Cost" | FsmName |  |
| variableName | "Cost" | "Cost" | FsmInt |  |
| setValue | 0 | 0 |  |  |
| everyFrame | false | false |  |  |

##### 8. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Detail Sprite | OwnerDefault Detail Sprite |  |  |
| fsmName | "Update Sprite" | "Update Sprite" | FsmName |  |
| variableName | "ID" | "ID" | FsmInt |  |
| setValue | 0 | 0 |  |  |
| everyFrame | false | false |  |  |

##### 9. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:Details Folder | EventTarget(GameObject)[SendToChildren]:Details Folder |  |  |
| sendEvent | "UPDATE" | "UPDATE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Shift Pane R

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

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
| eventTarget | EventTarget(GameObject):Parent | EventTarget(GameObject):Parent |  |  |
| sendEvent | "MOVE PANE R" | "MOVE PANE R" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Charm Collected?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. ConvertIntToString

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Collection Pos | int Collection Pos | Variable |  |
| stringVariable | string BB Num String | string BB Num String | Variable |  |
| format | "" | "" |  |  |
| everyFrame | false | false |  |  |

##### 2. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string Current BB Name | string Current BB Name | Variable |  |
| everyFrame | false | false |  |  |

##### 3. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Backboards | OwnerDefault Backboards |  |  |
| childName | string Current BB Name | string Current BB Name |  |  |
| storeResult | GameObject Current BB | GameObject Current BB | Variable |  |

##### 4. GetCharmNum

Full Name: GetCharmNum
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault Current BB | OwnerDefault Current BB | Variable |  |
| storeValue | int Current Item Number | int Current Item Number |  |  |

##### 5. GetFsmInt

Full Name: HutongGames.PlayMaker.Actions.GetFsmInt
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Current BB | OwnerDefault Current BB |  |  |
| fsmName | "bb_charm" | "bb_charm" | FsmName |  |
| variableName | "Charm ID" | "Charm ID" | FsmInt |  |
| storeValue | int Current Item Number | int Current Item Number | Variable |  |
| everyFrame | false | false |  |  |

##### 6. ConvertIntToString

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToString
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Current Item Number | int Current Item Number | Variable |  |
| stringVariable | string Item Num String | string Item Num String | Variable |  |
| format | "" | "" |  |  |
| everyFrame | false | false |  |  |

##### 7. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string Build String | string Build String | Variable |  |
| everyFrame | false | false |  |  |

##### 8. GetCharmString

Full Name: GetCharmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault Current BB | OwnerDefault Current BB | Variable |  |
| storeValue | string Build String | string Build String |  |  |

##### 9. GetCharmNumString

Full Name: GetCharmNumString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault Current BB | OwnerDefault Current BB | Variable |  |
| storeValue | string Item Num String | string Item Num String |  |  |

##### 10. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | string Build String | string Build String |  |  |
| isTrue | Event(COLLECTED) | Event(COLLECTED) |  |  |
| isFalse | Event(UNCOLLECTED) | Event(UNCOLLECTED) |  |  |

### Collected

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Got Charm | bool Got Charm | Variable |  |
| boolValue | true | true |  |  |
| everyFrame | false | false |  |  |

##### 2. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Confirm Action | OwnerDefault Confirm Action |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 3. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string Convo Name | string Convo Name | Variable |  |
| everyFrame | false | false |  |  |

##### 4. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string Convo Desc | string Convo Desc | Variable |  |
| everyFrame | false | false |  |  |

##### 5. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Update Text" | "Update Text" | FsmName |  |
| variableName | "Convo Name" | "Convo Name" | FsmString |  |
| setValue | string Convo Name | string Convo Name |  |  |
| everyFrame | false | false |  |  |

##### 6. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Update Text" | "Update Text" | FsmName |  |
| variableName | "Convo Desc" | "Convo Desc" | FsmString |  |
| setValue | string Convo Desc | string Convo Desc |  |  |
| everyFrame | false | false |  |  |

##### 7. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string PlayerData Var Name | string PlayerData Var Name | Variable |  |
| everyFrame | false | false |  |  |

##### 8. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | string PlayerData Var Name | string PlayerData Var Name |  |  |
| storeValue | int Notch Cost | int Notch Cost | Variable |  |

##### 9. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Cost Details | OwnerDefault Cost Details |  |  |
| fsmName | "Charm Details Cost" | "Charm Details Cost" | FsmName |  |
| variableName | "Cost" | "Cost" | FsmInt |  |
| setValue | int Notch Cost | int Notch Cost |  |  |
| everyFrame | false | false |  |  |

##### 10. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Detail Sprite | OwnerDefault Detail Sprite |  |  |
| fsmName | "Update Sprite" | "Update Sprite" | FsmName |  |
| variableName | "ID" | "ID" | FsmInt |  |
| setValue | int Current Item Number | int Current Item Number |  |  |
| everyFrame | false | false |  |  |

### Uncollected

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Got Charm | bool Got Charm | Variable |  |
| boolValue | false | false |  |  |
| everyFrame | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Grimm Flame UI | EventTarget(GameObject):Grimm Flame UI |  |  |
| sendEvent | "HIDE" | "HIDE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Confirm Action | OwnerDefault Confirm Action |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 4. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Update Text" | "Update Text" | FsmName |  |
| variableName | "Convo Name" | "Convo Name" | FsmString |  |
| setValue | "UI_BLANK" | "UI_BLANK" |  |  |
| everyFrame | false | false |  |  |

##### 5. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Update Text" | "Update Text" | FsmName |  |
| variableName | "Convo Desc" | "Convo Desc" | FsmString |  |
| setValue | "UI_BLANK" | "UI_BLANK" |  |  |
| everyFrame | false | false |  |  |

##### 6. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Cost Details | OwnerDefault Cost Details |  |  |
| fsmName | "Charm Details Cost" | "Charm Details Cost" | FsmName |  |
| variableName | "Cost" | "Cost" | FsmInt |  |
| setValue | 0 | 0 |  |  |
| everyFrame | false | false |  |  |

##### 7. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Detail Sprite | OwnerDefault Detail Sprite |  |  |
| fsmName | "Update Sprite" | "Update Sprite" | FsmName |  |
| variableName | "ID" | "ID" | FsmInt |  |
| setValue | 0 | 0 |  |  |
| everyFrame | false | false |  |  |

##### 8. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:Details Folder | EventTarget(GameObject)[SendToChildren]:Details Folder |  |  |
| sendEvent | "UPDATE" | "UPDATE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Build Equipped

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. DestroyAllChildren

Full Name: HutongGames.PlayMaker.Actions.DestroyAllChildren
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Equipped Ch Folder | GameObject Equipped Ch Folder |  |  |
| disable | false | false |  |  |

##### 2. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Equipped Charms | OwnerDefault Equipped Charms |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | BuildCharmList(???) | BuildCharmList(???) |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:Equipped Charms | EventTarget(GameObject)[SendToChildren]:Equipped Charms |  |  |
| sendEvent | "UP" | "UP" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Tween Up

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. CreateObject

Full Name: HutongGames.PlayMaker.Actions.CreateObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Tween Charm Trail U (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Tween Charm Trail U (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Tweener Charm | GameObject Tweener Charm |  |  |
| position | Vector3(0, 0, 1) | Vector3(0, 0, 1) |  |  |
| rotation | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| storeObject | GameObject Tweener Charm Particle | GameObject Tweener Charm Particle | Variable |  |
| networkInstantiate | false | false |  |  |
| networkGroup | 0 | 0 |  |  |

##### 2. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player UI (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player UI (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [ui_button_confirm (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets0.assets)] | [ui_button_confirm (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets0.assets)] |  |  |
| pitchMin | 1.15f | 1.15f |  |  |
| pitchMax | 1.15f | 1.15f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 3. SetParent

Full Name: HutongGames.PlayMaker.Actions.SetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Tweener Charm Particle | OwnerDefault Tweener Charm Particle |  |  |
| parent | GameObject Tweener Charm | GameObject Tweener Charm |  |  |
| resetLocalPosition | false | false |  |  |
| resetLocalRotation | false | false |  |  |

##### 4. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Collected Charms | OwnerDefault Collected Charms |  |  |
| childName | string Item Num String | string Item Num String |  |  |
| storeResult | GameObject Source Charm | GameObject Source Charm | Variable |  |

##### 5. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Source Charm | OwnerDefault Source Charm |  |  |
| childName | "Sprite" | "Sprite" |  |  |
| storeResult | GameObject Source Sprite | GameObject Source Sprite | Variable |  |

##### 6. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Source Charm | EventTarget(GameObject):Source Charm |  |  |
| sendEvent | "EQUIP" | "EQUIP" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 7. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Open Notch | OwnerDefault Open Notch |  |  |
| vector | Vector3 Open Notch Pos | Vector3 Open Notch Pos | Variable |  |
| x | 0f | 0f | Variable |  |
| y | 0f | 0f | Variable |  |
| z | 0f | 0f | Variable |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |

##### 8. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Source Charm | OwnerDefault Source Charm |  |  |
| vector | Vector3 Source Charm Pos | Vector3 Source Charm Pos | Variable |  |
| x | 0f | 0f | Variable |  |
| y | 0f | 0f | Variable |  |
| z | 0f | 0f | Variable |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |

##### 9. GetSpriteRendererSprite

Full Name: HutongGames.PlayMaker.Actions.GetSpriteRendererSprite
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Source Sprite | OwnerDefault Source Sprite |  |  |
| sprite | object Sprite | object Sprite |  |  |

##### 10. SetSpriteRendererSprite

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRendererSprite
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Tweener Charm | OwnerDefault Tweener Charm |  |  |
| sprite | object Sprite | object Sprite |  |  |

##### 11. SetSpriteRenderer

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Tweener Charm | OwnerDefault Tweener Charm |  |  |
| active | true | true |  |  |

##### 12. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Tweener Charm | OwnerDefault Tweener Charm |  |  |
| vector | Vector3 Source Charm Pos | Vector3 Source Charm Pos | Variable |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| z | -10f | -10f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 13. SetVector3XYZ

Full Name: HutongGames.PlayMaker.Actions.SetVector3XYZ
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable | Vector3 Open Notch Pos | Vector3 Open Notch Pos | Variable |  |
| vector3Value | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| z | -10f | -10f |  |  |
| everyFrame | false | false |  |  |

##### 14. iTweenMoveTo

Full Name: HutongGames.PlayMaker.Actions.iTweenMoveTo
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Tweener Charm | OwnerDefault Tweener Charm |  |  |
| id | "" | "" |  |  |
| transformPosition |  |  |  |  |
| vectorPosition | Vector3 Open Notch Pos | Vector3 Open Notch Pos |  |  |
| time | 0.25f | 0.25f |  |  |
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
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |
| stopOnExit | true | true |  |  |
| loopDontFinish | true | true |  |  |

### Activate UI

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | CharmUpdate(???) | CharmUpdate(???) |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Self | EventTarget(GameObject):Self |  |  |
| sendEvent | "UI ACTIVE" | "UI ACTIVE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Parent | OwnerDefault Parent |  |  |
| fsmName | "Inventory Control" | "Inventory Control" | FsmName |  |
| variableName | "Do Not Close" | "Do Not Close" | FsmBool |  |
| setValue | false | false |  |  |
| everyFrame | false | false |  |  |

##### 4. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(BroadcastAll):FSM Owner | EventTarget(BroadcastAll):FSM Owner |  |  |
| sendEvent | "CHARM INDICATOR CHECK" | "CHARM INDICATOR CHECK" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 5. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(BroadcastAll):FSM Owner | EventTarget(BroadcastAll):FSM Owner |  |  |
| sendEvent | "UPDATE BLUE HEALTH" | "UPDATE BLUE HEALTH" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Check Points

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. StopParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.StopParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Tweener Charm Particle | OwnerDefault Tweener Charm Particle |  |  |

##### 2. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string PlayerData Var Name | string PlayerData Var Name | Variable |  |
| everyFrame | false | false |  |  |

##### 3. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | string PlayerData Var Name | string PlayerData Var Name |  |  |
| storeValue | int Notch Cost | int Notch Cost | Variable |  |

##### 4. PlayerDataIntAdd

Full Name: HutongGames.PlayMaker.Actions.PlayerDataIntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "charmSlotsFilled" | "charmSlotsFilled" |  |  |
| amount | int Notch Cost | int Notch Cost | Variable |  |

##### 5. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "charmSlots" | "charmSlots" |  |  |
| storeValue | int Notches | int Notches | Variable |  |

##### 6. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "charmSlotsFilled" | "charmSlotsFilled" |  |  |
| storeValue | int Notches Filled | int Notches Filled | Variable |  |

##### 7. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Notches Filled | int Notches Filled |  |  |
| integer2 | int Notches | int Notches |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event() | Event() |  |  |
| greaterThan | Event(OVER) | Event(OVER) |  |  |
| everyFrame | false | false |  |  |

### Set

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetSpriteRenderer

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Tweener Charm | OwnerDefault Tweener Charm |  |  |
| active | false | false |  |  |

##### 2. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player UI (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player UI (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [shiny_item_pickup (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [shiny_item_pickup (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 3. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player UI (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player UI (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [charm_click_in (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [charm_click_in (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 4. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Confirm Action Text | OwnerDefault Confirm Action Text |  |  |
| textString | string String Unequip | string String Unequip |  |  |

##### 5. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Newly Equipped Name | string Newly Equipped Name | Variable |  |
| stringValue | string Item Num String | string Item Num String | TextArea |  |
| everyFrame | false | false |  |  |

##### 6. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | EquipCharm(Current Item Number=int Current Item Number) | EquipCharm(Current Item Number=int Current Item Number) |  |  |

##### 7. DestroyAllChildren

Full Name: HutongGames.PlayMaker.Actions.DestroyAllChildren
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Equipped Ch Folder | GameObject Equipped Ch Folder |  |  |
| disable | false | false |  |  |

##### 8. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Equipped Charms | OwnerDefault Equipped Charms |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | BuildCharmList(???) | BuildCharmList(???) |  |  |

##### 9. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Equipped Ch Folder | EventTarget(GameObject):Equipped Ch Folder |  |  |
| sendEvent | "UP INSTANT" | "UP INSTANT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 10. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:Equipped Ch Folder | EventTarget(GameObject)[SendToChildren]:Equipped Ch Folder |  |  |
| sendEvent | "CHECK NEW" | "CHECK NEW" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 11. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string PlayerData Var Name | string PlayerData Var Name | Variable |  |
| everyFrame | false | false |  |  |

##### 12. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName | string PlayerData Var Name | string PlayerData Var Name |  |  |
| value | true | true |  |  |

##### 13. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | PlayRegularPlace(???) | PlayRegularPlace(???) |  |  |

### Deactivate UI

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 4

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "CONFIRM CANCEL" | "CONFIRM CANCEL" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Got Charm | bool Got Charm | Variable |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(CANCEL) | Event(CANCEL) |  |  |
| everyFrame | false | false |  |  |

##### 3. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "atBench" | "atBench" |  |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(NOT BENCH) | Event(NOT BENCH) |  |  |

##### 4. GGCheckBoundCharms

Full Name: GGCheckBoundCharms
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| trueEvent | Event(CHARM BOUND) | Event(CHARM BOUND) |  |  |
| falseEvent | Event() | Event() |  |  |

##### 5. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Parent | OwnerDefault Parent |  |  |
| fsmName | "Inventory Control" | "Inventory Control" | FsmName |  |
| variableName | "Do Not Close" | "Do Not Close" | FsmBool |  |
| setValue | true | true |  |  |
| everyFrame | false | false |  |  |

##### 6. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Self | EventTarget(GameObject):Self |  |  |
| sendEvent | "UI INACTIVE" | "UI INACTIVE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Equipped?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. ConvertIntToString

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Current Item Number | int Current Item Number | Variable |  |
| stringVariable | string Item Num String | string Item Num String | Variable |  |
| format | "" | "" |  |  |
| everyFrame | false | false |  |  |

##### 2. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string PlayerData Var Name | string PlayerData Var Name | Variable |  |
| everyFrame | false | false |  |  |

##### 3. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | string PlayerData Var Name | string PlayerData Var Name |  |  |
| isTrue | Event(EQUIPPED) | Event(EQUIPPED) |  |  |
| isFalse | Event(UNEQUIPPED) | Event(UNEQUIPPED) |  |  |

### Tween Down

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. CreateObject

Full Name: HutongGames.PlayMaker.Actions.CreateObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Tween Charm Trail D (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Tween Charm Trail D (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Tweener Charm | GameObject Tweener Charm |  |  |
| position | Vector3(0, 0, 1) | Vector3(0, 0, 1) |  |  |
| rotation | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| storeObject | GameObject Tweener Charm Particle | GameObject Tweener Charm Particle | Variable |  |
| networkInstantiate | false | false |  |  |
| networkGroup | 0 | 0 |  |  |

##### 2. SetParent

Full Name: HutongGames.PlayMaker.Actions.SetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Tweener Charm Particle | OwnerDefault Tweener Charm Particle |  |  |
| parent | GameObject Tweener Charm | GameObject Tweener Charm |  |  |
| resetLocalPosition | false | false |  |  |
| resetLocalRotation | false | false |  |  |

##### 3. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Collected Charms | OwnerDefault Collected Charms |  |  |
| childName | string Item Num String | string Item Num String |  |  |
| storeResult | GameObject Source Charm | GameObject Source Charm | Variable |  |

##### 4. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Source Charm | OwnerDefault Source Charm |  |  |
| childName | "Sprite" | "Sprite" |  |  |
| storeResult | GameObject Source Sprite | GameObject Source Sprite | Variable |  |

##### 5. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Source Charm | OwnerDefault Source Charm |  |  |
| vector | Vector3 Source Charm Pos | Vector3 Source Charm Pos | Variable |  |
| x | 0f | 0f | Variable |  |
| y | 0f | 0f | Variable |  |
| z | 0f | 0f | Variable |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |

##### 6. GetSpriteRendererSprite

Full Name: HutongGames.PlayMaker.Actions.GetSpriteRendererSprite
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Source Sprite | OwnerDefault Source Sprite |  |  |
| sprite | object Sprite | object Sprite |  |  |

##### 7. SetSpriteRendererSprite

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRendererSprite
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Tweener Charm | OwnerDefault Tweener Charm |  |  |
| sprite | object Sprite | object Sprite |  |  |

##### 8. SetSpriteRenderer

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Tweener Charm | OwnerDefault Tweener Charm |  |  |
| active | true | true |  |  |

##### 9. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Equipped Ch Folder | OwnerDefault Equipped Ch Folder |  |  |
| childName | string Item Num String | string Item Num String |  |  |
| storeResult | GameObject Target Charm | GameObject Target Charm | Variable |  |

##### 10. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Target Charm | OwnerDefault Target Charm |  |  |
| behaviour | "CharmItem" | "CharmItem" | Behaviour |  |
| methodName | "GetListNumber" | "GetListNumber" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var Target List Num = 0 | Var Target List Num = 0 | Variable | Store Result |

##### 11. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Target List Num | int Target List Num | Variable |  |
| add | 1 | 1 |  |  |
| everyFrame | false | false |  |  |

##### 12. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Target Charm | OwnerDefault Target Charm |  |  |
| vector | Vector3 Target Charm Pos | Vector3 Target Charm Pos | Variable |  |
| x | float Target Charm X | float Target Charm X | Variable |  |
| y | 0f | 0f | Variable |  |
| z | 0f | 0f | Variable |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |

##### 13. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:Equipped Charms | EventTarget(GameObject)[SendToChildren]:Equipped Charms |  |  |
| sendEvent | "UNEQUIP SHIFT" | "UNEQUIP SHIFT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 14. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Tweener Charm | OwnerDefault Tweener Charm |  |  |
| vector | Vector3 Target Charm Pos | Vector3 Target Charm Pos | Variable |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| z | -10f | -10f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 15. SetVector3XYZ

Full Name: HutongGames.PlayMaker.Actions.SetVector3XYZ
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable | Vector3 Source Charm Pos | Vector3 Source Charm Pos | Variable |  |
| vector3Value | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| z | -10f | -10f |  |  |
| everyFrame | false | false |  |  |

##### 16. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Target Charm | OwnerDefault Target Charm |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 17. DestroyObject

Full Name: HutongGames.PlayMaker.Actions.DestroyObject
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Target Charm | GameObject Target Charm |  |  |
| delay | 0f | 0f |  |  |
| detachChildren | false | false |  |  |

##### 18. iTweenMoveTo

Full Name: HutongGames.PlayMaker.Actions.iTweenMoveTo
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Tweener Charm | OwnerDefault Tweener Charm |  |  |
| id | "" | "" |  |  |
| transformPosition |  |  |  |  |
| vectorPosition | Vector3 Source Charm Pos | Vector3 Source Charm Pos |  |  |
| time | 0.25f | 0.25f |  |  |
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
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |
| stopOnExit | true | true |  |  |
| loopDontFinish | true | true |  |  |

### Unequip

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
| storeResult | string PlayerData Var Name | string PlayerData Var Name | Variable |  |
| everyFrame | false | false |  |  |

##### 2. SetSpriteRenderer

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Tweener Charm | OwnerDefault Tweener Charm |  |  |
| active | false | false |  |  |

##### 3. StopParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.StopParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Tweener Charm Particle | OwnerDefault Tweener Charm Particle |  |  |

##### 4. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Open Slot | bool Open Slot | Variable |  |
| boolValue | true | true |  |  |
| everyFrame | false | false |  |  |

##### 5. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName | string PlayerData Var Name | string PlayerData Var Name |  |  |
| value | false | false |  |  |

##### 6. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Source Charm | EventTarget(GameObject):Source Charm |  |  |
| sendEvent | "UPDATE" | "UPDATE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 7. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | UnequipCharm(Current Item Number=int Current Item Number) | UnequipCharm(Current Item Number=int Current Item Number) |  |  |

##### 8. DestroyAllChildren

Full Name: HutongGames.PlayMaker.Actions.DestroyAllChildren
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Equipped Ch Folder | GameObject Equipped Ch Folder |  |  |
| disable | false | false |  |  |

##### 9. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Equipped Charms | OwnerDefault Equipped Charms |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | BuildCharmList(???) | BuildCharmList(???) |  |  |

##### 10. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:Equipped Charms | EventTarget(GameObject)[SendToChildren]:Equipped Charms |  |  |
| sendEvent | "UP INSTANT" | "UP INSTANT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Return Points

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Confirm Action Text | OwnerDefault Confirm Action Text |  |  |
| textString | string String Equip | string String Equip |  |  |

##### 2. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player UI (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player UI (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [ui_button_confirm (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets0.assets)] | [ui_button_confirm (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets0.assets)] |  |  |
| pitchMin | 1.15f | 1.15f |  |  |
| pitchMax | 1.15f | 1.15f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 3. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player UI (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player UI (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [soul_pickup_1 (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [soul_pickup_1 (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| pitchMin | 1.15f | 1.15f |  |  |
| pitchMax | 1.15f | 1.15f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 4. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string PlayerData Var Name | string PlayerData Var Name | Variable |  |
| everyFrame | false | false |  |  |

##### 5. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | string PlayerData Var Name | string PlayerData Var Name |  |  |
| storeValue | int Notch Cost | int Notch Cost | Variable |  |

##### 6. IntOperator

Full Name: HutongGames.PlayMaker.Actions.IntOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Notch Cost | int Notch Cost |  |  |
| integer2 | -1 | -1 |  |  |
| operation | HutongGames.PlayMaker.Actions.IntOperator/Operation::Multiply | 2 |  |  |
| storeResult | int Notch Cost | int Notch Cost | Variable |  |
| everyFrame | false | false |  |  |

##### 7. PlayerDataIntAdd

Full Name: HutongGames.PlayMaker.Actions.PlayerDataIntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "charmSlotsFilled" | "charmSlotsFilled" |  |  |
| amount | int Notch Cost | int Notch Cost | Variable |  |

### Open Slot?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "charmSlots" | "charmSlots" |  |  |
| storeValue | int Slots | int Slots | Variable |  |

##### 2. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "charmSlotsFilled" | "charmSlotsFilled" |  |  |
| storeValue | int Slots Filled | int Slots Filled | Variable |  |

##### 3. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Slots Filled | int Slots Filled |  |  |
| integer2 | int Slots | int Slots |  |  |
| equal | Event(FULL) | Event(FULL) |  |  |
| lessThan | Event(NOT FULL) | Event(NOT FULL) |  |  |
| greaterThan | Event(FULL) | Event(FULL) |  |  |
| everyFrame | false | false |  |  |

### No Open Slot

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Open Slot | bool Open Slot | Variable |  |
| boolValue | false | false |  |  |
| everyFrame | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Open Notch | EventTarget(GameObject):Open Notch |  |  |
| sendEvent | "NOTCH DOWN" | "NOTCH DOWN" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Open Slot

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Open Slot | bool Open Slot | Variable |  |
| boolValue | true | true |  |  |
| everyFrame | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Open Notch | EventTarget(GameObject):Open Notch |  |  |
| sendEvent | "NOTCH DEF UP" | "NOTCH DEF UP" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### To Equipment

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Current Item Number | int Current Item Number | Variable |  |
| intValue | 1 | 1 |  |  |
| everyFrame | false | false |  |  |

### Idle Equipped

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 5

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Self | EventTarget(GameObject):Self |  |  |
| sendEvent | "UI ACTIVE" | "UI ACTIVE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Idle Collection | bool Idle Collection | Variable |  |
| boolValue | false | false |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "CONFIRM CANCEL" | "CONFIRM CANCEL" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Get Selected

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Equipped Charms | OwnerDefault Equipped Charms |  |  |
| behaviour | "BuildEquippedCharms" | "BuildEquippedCharms" | Behaviour |  |
| methodName | "GetObjectAt" | "GetObjectAt" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var Current Item =  | Var Current Item =  | Variable | Store Result |

##### 2. SetFsmGameObject

Full Name: HutongGames.PlayMaker.Actions.SetFsmGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Update Cursor" | "Update Cursor" | FsmName |  |
| variableName | "Item" | "Item" | FsmGameObject |  |
| setValue | GameObject Current Item | GameObject Current Item |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "UPDATE CURSOR" | "UPDATE CURSOR" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 4. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "UPDATE TEXT" | "UPDATE TEXT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### To Bot

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Collection Pos | int Collection Pos | Variable |  |
| intValue | 1 | 1 |  |  |
| everyFrame | false | false |  |  |

### Move Left

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Current Item Number | int Current Item Number |  |  |
| integer2 | 1 | 1 |  |  |
| equal | Event(TO LEFT) | Event(TO LEFT) |  |  |
| lessThan | Event(TO LEFT) | Event(TO LEFT) |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 2. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Current Item Number | int Current Item Number | Variable |  |
| add | -1 | -1 |  |  |
| everyFrame | false | false |  |  |

### Move Right

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Equipped Charms | OwnerDefault Equipped Charms |  |  |
| behaviour | "BuildEquippedCharms" | "BuildEquippedCharms" | Behaviour |  |
| methodName | "GetUICount" | "GetUICount" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var UI Items = 0 | Var UI Items = 0 | Variable | Store Result |

##### 2. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Current Item Number | int Current Item Number |  |  |
| integer2 | int UI Items | int UI Items |  |  |
| equal | Event(FINISHED) | Event(FINISHED) |  |  |
| lessThan | Event() | Event() |  |  |
| greaterThan | Event(FINISHED) | Event(FINISHED) |  |  |
| everyFrame | false | false |  |  |

##### 3. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Current Item Number | int Current Item Number | Variable |  |
| add | 1 | 1 |  |  |
| everyFrame | false | false |  |  |

### Notch?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 4

#### Actions

##### 1. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Equipped Charms | OwnerDefault Equipped Charms |  |  |
| behaviour | "BuildEquippedCharms" | "BuildEquippedCharms" | Behaviour |  |
| methodName | "GetItemName" | "GetItemName" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var Current Item Name =  | Var Current Item Name =  | Variable | Store Result |

##### 2. StringCompare

Full Name: HutongGames.PlayMaker.Actions.StringCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Current Item Name | string Current Item Name | Variable |  |
| compareTo | "Next Dot" | "Next Dot" |  |  |
| equalEvent | Event() | Event() |  |  |
| notEqualEvent | Event(CHARM) | Event(CHARM) |  |  |
| storeResult | false | false | Variable |  |
| everyFrame | false | false |  |  |

##### 3. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool On Notch | bool On Notch | Variable |  |
| boolValue | true | true |  |  |
| everyFrame | false | false |  |  |

##### 4. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Update Text" | "Update Text" | FsmName |  |
| variableName | "Convo Name" | "Convo Name" | FsmString |  |
| setValue | "UI_BLANK" | "UI_BLANK" |  |  |
| everyFrame | false | false |  |  |

##### 5. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Update Text" | "Update Text" | FsmName |  |
| variableName | "Convo Desc" | "Convo Desc" | FsmString |  |
| setValue | "UI_BLANK" | "UI_BLANK" |  |  |
| everyFrame | false | false |  |  |

##### 6. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Cost Details | OwnerDefault Cost Details |  |  |
| fsmName | "Charm Details Cost" | "Charm Details Cost" | FsmName |  |
| variableName | "Cost" | "Cost" | FsmInt |  |
| setValue | 0 | 0 |  |  |
| everyFrame | false | false |  |  |

##### 7. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Detail Sprite | OwnerDefault Detail Sprite |  |  |
| fsmName | "Update Sprite" | "Update Sprite" | FsmName |  |
| variableName | "ID" | "ID" | FsmInt |  |
| setValue | 0 | 0 |  |  |
| everyFrame | false | false |  |  |

##### 8. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:Details Folder | EventTarget(GameObject)[SendToChildren]:Details Folder |  |  |
| sendEvent | "UPDATE" | "UPDATE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 9. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Equipped Charms | OwnerDefault Equipped Charms |  |  |
| behaviour | "BuildEquippedCharms" | "BuildEquippedCharms" | Behaviour |  |
| methodName | "GetUICount" | "GetUICount" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var UI Items = 0 | Var UI Items = 0 | Variable | Store Result |

##### 10. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int UI Items | int UI Items |  |  |
| integer2 | 1 | 1 |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event() | Event() |  |  |
| greaterThan | Event(FINISHED) | Event(FINISHED) |  |  |
| everyFrame | false | false |  |  |

##### 11. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "atBench" | "atBench" |  |  |
| isTrue | Event(BENCH) | Event(BENCH) |  |  |
| isFalse | Event(NOT BENCH) | Event(NOT BENCH) |  |  |

##### 12. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Confirm Action | OwnerDefault Confirm Action |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 13. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Update Text" | "Update Text" | FsmName |  |
| variableName | "Convo Desc" | "Convo Desc" | FsmString |  |
| setValue | "CHARM_ALERT_NONE_BENCH" | "CHARM_ALERT_NONE_BENCH" |  |  |
| everyFrame | false | false |  |  |

### Bench

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Update Text" | "Update Text" | FsmName |  |
| variableName | "Convo Desc" | "Convo Desc" | FsmString |  |
| setValue | "CHARM_ALERT_NONE_BENCH" | "CHARM_ALERT_NONE_BENCH" |  |  |
| everyFrame | false | false |  |  |

##### 2. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Confirm Action | OwnerDefault Confirm Action |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

### Not Bench

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Update Text" | "Update Text" | FsmName |  |
| variableName | "Convo Desc" | "Convo Desc" | FsmString |  |
| setValue | "CHARM_ALERT_NONE" | "CHARM_ALERT_NONE" |  |  |
| everyFrame | false | false |  |  |

##### 2. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Confirm Action | OwnerDefault Confirm Action |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

### Charm

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Confirm Action Text | OwnerDefault Confirm Action Text |  |  |
| textString | string String Unequip | string String Unequip |  |  |

##### 2. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Confirm Action | OwnerDefault Confirm Action |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 3. ConvertStringToInt

Full Name: HutongGames.PlayMaker.Actions.ConvertStringToInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Current Item Name | string Current Item Name | Variable |  |
| intVariable | int Cool Number | int Cool Number | Variable |  |
| everyFrame | false | false |  |  |

##### 4. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string Convo Name | string Convo Name | Variable |  |
| everyFrame | false | false |  |  |

##### 5. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string Convo Desc | string Convo Desc | Variable |  |
| everyFrame | false | false |  |  |

##### 6. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Update Text" | "Update Text" | FsmName |  |
| variableName | "Convo Name" | "Convo Name" | FsmString |  |
| setValue | string Convo Name | string Convo Name |  |  |
| everyFrame | false | false |  |  |

##### 7. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Update Text" | "Update Text" | FsmName |  |
| variableName | "Convo Desc" | "Convo Desc" | FsmString |  |
| setValue | string Convo Desc | string Convo Desc |  |  |
| everyFrame | false | false |  |  |

##### 8. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool On Notch | bool On Notch | Variable |  |
| boolValue | false | false |  |  |
| everyFrame | false | false |  |  |

##### 9. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string PlayerData Var Name | string PlayerData Var Name | Variable |  |
| everyFrame | false | false |  |  |

##### 10. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | string PlayerData Var Name | string PlayerData Var Name |  |  |
| storeValue | int Notch Cost | int Notch Cost | Variable |  |

##### 11. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Cost Details | OwnerDefault Cost Details |  |  |
| fsmName | "Charm Details Cost" | "Charm Details Cost" | FsmName |  |
| variableName | "Cost" | "Cost" | FsmInt |  |
| setValue | int Notch Cost | int Notch Cost |  |  |
| everyFrame | false | false |  |  |

##### 12. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Detail Sprite | OwnerDefault Detail Sprite |  |  |
| fsmName | "Update Sprite" | "Update Sprite" | FsmName |  |
| variableName | "ID" | "ID" | FsmInt |  |
| setValue | int Cool Number | int Cool Number |  |  |
| everyFrame | false | false |  |  |

### Set Current Item Num

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool On Notch | bool On Notch | Variable |  |
| isTrue | Event(CANCEL) | Event(CANCEL) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 2. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "atBench" | "atBench" |  |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(CANCEL) | Event(CANCEL) |  |  |

##### 3. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Prev Current Item Num | int Prev Current Item Num | Variable |  |
| intValue | int Current Item Number | int Current Item Number |  |  |
| everyFrame | false | false |  |  |

##### 4. ConvertStringToInt

Full Name: HutongGames.PlayMaker.Actions.ConvertStringToInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Current Item Name | string Current Item Name | Variable |  |
| intVariable | int Current Item Number | int Current Item Number | Variable |  |
| everyFrame | false | false |  |  |

##### 5. ConvertIntToString

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Current Item Number | int Current Item Number | Variable |  |
| stringVariable | string Item Num String | string Item Num String | Variable |  |
| format | "" | "" |  |  |
| everyFrame | false | false |  |  |

##### 6. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Parent | OwnerDefault Parent |  |  |
| fsmName | "Inventory Control" | "Inventory Control" | FsmName |  |
| variableName | "Do Not Close" | "Do Not Close" | FsmBool |  |
| setValue | true | true |  |  |
| everyFrame | false | false |  |  |

##### 7. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Self | EventTarget(GameObject):Self |  |  |
| sendEvent | "UI INACTIVE" | "UI INACTIVE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Activate UI Equipped

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | CharmUpdate(???) | CharmUpdate(???) |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Self | EventTarget(GameObject):Self |  |  |
| sendEvent | "UI ACTIVE" | "UI ACTIVE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Parent | OwnerDefault Parent |  |  |
| fsmName | "Inventory Control" | "Inventory Control" | FsmName |  |
| variableName | "Do Not Close" | "Do Not Close" | FsmBool |  |
| setValue | false | false |  |  |
| everyFrame | false | false |  |  |

##### 4. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Current Item Number | int Current Item Number | Variable |  |
| intValue | int Prev Current Item Num | int Prev Current Item Num |  |  |
| everyFrame | false | false |  |  |

##### 5. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(BroadcastAll):FSM Owner | EventTarget(BroadcastAll):FSM Owner |  |  |
| sendEvent | "CHARM INDICATOR CHECK" | "CHARM INDICATOR CHECK" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 6. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(BroadcastAll):FSM Owner | EventTarget(BroadcastAll):FSM Owner |  |  |
| sendEvent | "UPDATE BLUE HEALTH" | "UPDATE BLUE HEALTH" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Slot Open?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string PlayerData Var Name | string PlayerData Var Name | Variable |  |
| everyFrame | false | false |  |  |

##### 2. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "charmSlots" | "charmSlots" |  |  |
| storeValue | int Notches | int Notches | Variable |  |

##### 3. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "charmSlotsFilled" | "charmSlotsFilled" |  |  |
| storeValue | int Notches Filled | int Notches Filled | Variable |  |

##### 4. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Notches Filled | int Notches Filled |  |  |
| integer2 | int Notches | int Notches |  |  |
| equal | Event(CANCEL) | Event(CANCEL) |  |  |
| lessThan | Event() | Event() |  |  |
| greaterThan | Event(CANCEL) | Event(CANCEL) |  |  |
| everyFrame | false | false |  |  |

### Fail Back

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. IntOperator

Full Name: HutongGames.PlayMaker.Actions.IntOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Notch Cost | int Notch Cost |  |  |
| integer2 | -1 | -1 |  |  |
| operation | HutongGames.PlayMaker.Actions.IntOperator/Operation::Multiply | 2 |  |  |
| storeResult | int Notch Cost | int Notch Cost | Variable |  |
| everyFrame | false | false |  |  |

##### 2. CreateObject

Full Name: HutongGames.PlayMaker.Actions.CreateObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Tween Charm Trail D (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Tween Charm Trail D (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Tweener Charm | GameObject Tweener Charm |  |  |
| position | Vector3(0, 0, 1) | Vector3(0, 0, 1) |  |  |
| rotation | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| storeObject | GameObject Tweener Charm Particle | GameObject Tweener Charm Particle | Variable |  |
| networkInstantiate | false | false |  |  |
| networkGroup | 0 | 0 |  |  |

##### 3. SetParent

Full Name: HutongGames.PlayMaker.Actions.SetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Tweener Charm Particle | OwnerDefault Tweener Charm Particle |  |  |
| parent | GameObject Tweener Charm | GameObject Tweener Charm |  |  |
| resetLocalPosition | false | false |  |  |
| resetLocalRotation | false | false |  |  |

##### 4. PlayerDataIntAdd

Full Name: HutongGames.PlayMaker.Actions.PlayerDataIntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "charmSlotsFilled" | "charmSlotsFilled" |  |  |
| amount | int Notch Cost | int Notch Cost | Variable |  |

##### 5. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Equipped Charms | OwnerDefault Equipped Charms |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | UpdateNotches(???) | UpdateNotches(???) |  |  |

##### 6. iTweenMoveTo

Full Name: HutongGames.PlayMaker.Actions.iTweenMoveTo
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Tweener Charm | OwnerDefault Tweener Charm |  |  |
| id | "" | "" |  |  |
| transformPosition |  |  |  |  |
| vectorPosition | Vector3 Source Charm Pos | Vector3 Source Charm Pos |  |  |
| time | 0.25f | 0.25f |  |  |
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
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |
| stopOnExit | true | true |  |  |
| loopDontFinish | true | true |  |  |

### Fail

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. ObjectJitter

Full Name: HutongGames.PlayMaker.Actions.ObjectJitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Tweener Charm | OwnerDefault Tweener Charm |  |  |
| x | 0.1f | 0.1f |  |  |
| y | 0.1f | 0.1f |  |  |
| z | 0f | 0f |  |  |
| allowMovement | false | false |  |  |

##### 2. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string PlayerData Var Name | string PlayerData Var Name | Variable |  |
| everyFrame | false | false |  |  |

##### 3. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | string PlayerData Var Name | string PlayerData Var Name |  |  |
| storeValue | int Notch Cost | int Notch Cost | Variable |  |

##### 4. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Over Indicator | OwnerDefault Over Indicator |  |  |
| fsmName | "Over Control" | "Over Control" | FsmName |  |
| variableName | "Cost" | "Cost" | FsmInt |  |
| setValue | int Notch Cost | int Notch Cost |  |  |
| everyFrame | false | false |  |  |

##### 5. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Over Indicator | EventTarget(GameObject):Over Indicator |  |  |
| sendEvent | "DISPLAY OVER" | "DISPLAY OVER" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 6. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.5f | 0.5f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

##### 7. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Equipped Charms | OwnerDefault Equipped Charms |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | UpdateNotches(???) | UpdateNotches(???) |  |  |

### Fail Finish

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetSpriteRenderer

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Tweener Charm | OwnerDefault Tweener Charm |  |  |
| active | false | false |  |  |

##### 2. StopParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.StopParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Tweener Charm Particle | OwnerDefault Tweener Charm Particle |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Source Charm | EventTarget(GameObject):Source Charm |  |  |
| sendEvent | "UPDATE" | "UPDATE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Bench Reminder

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. FindGameObject

Full Name: HutongGames.PlayMaker.Actions.FindGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| objectName | "Charm Equip Msg(Clone)" | "Charm Equip Msg(Clone)" |  |  |
| withTag | "Untagged" | "Untagged" | Tag |  |
| store | GameObject Charm Equip Msg | GameObject Charm Equip Msg | Variable |  |

##### 2. GameObjectIsNull

Full Name: HutongGames.PlayMaker.Actions.GameObjectIsNull
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Charm Equip Msg | GameObject Charm Equip Msg | Variable |  |
| isNull | Event() | Event() |  |  |
| isNotNull | Event(FINISHED) | Event(FINISHED) |  |  |
| storeResult | false | false | Variable |  |
| everyFrame | false | false |  |  |

##### 3. CreateObject

Full Name: HutongGames.PlayMaker.Actions.CreateObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Charm Equip Msg (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Charm Equip Msg (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint |  |  |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| rotation | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| storeObject |  |  | Variable |  |
| networkInstantiate | false | false |  |  |
| networkGroup | 0 | 0 |  |  |

##### 4. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.25f | 0.25f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Open Slot? 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Open Notch | OwnerDefault Open Notch |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | -3.86f | -3.86f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 2. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "charmSlots" | "charmSlots" |  |  |
| storeValue | int Slots | int Slots | Variable |  |

##### 3. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "charmSlotsFilled" | "charmSlotsFilled" |  |  |
| storeValue | int Slots Filled | int Slots Filled | Variable |  |

##### 4. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Slots Filled | int Slots Filled |  |  |
| integer2 | int Slots | int Slots |  |  |
| equal | Event(FULL) | Event(FULL) |  |  |
| lessThan | Event(NOT FULL) | Event(NOT FULL) |  |  |
| greaterThan | Event(FULL) | Event(FULL) |  |  |
| everyFrame | false | false |  |  |

### No Open Slot 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Open Slot | bool Open Slot | Variable |  |
| boolValue | false | false |  |  |
| everyFrame | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Open Notch | EventTarget(GameObject):Open Notch |  |  |
| sendEvent | "NOTCH DOWN" | "NOTCH DOWN" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Open Slot 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Open Slot | bool Open Slot | Variable |  |
| boolValue | true | true |  |  |
| everyFrame | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Open Notch | EventTarget(GameObject):Open Notch |  |  |
| sendEvent | "NOTCH DEF UP" | "NOTCH DEF UP" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Glass HP

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Current Item Number | int Current Item Number |  |  |
| integer2 | 23 | 23 |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event(FINISHED) | Event(FINISHED) |  |  |
| greaterThan | Event(FINISHED) | Event(FINISHED) |  |  |
| everyFrame | false | false |  |  |

##### 2. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "fragileHealth_unbreakable" | "fragileHealth_unbreakable" |  |  |
| isTrue | Event(UNBREAKABLE) | Event(UNBREAKABLE) |  |  |
| isFalse | Event() | Event() |  |  |

##### 3. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "brokenCharm_23" | "brokenCharm_23" |  |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(FINISHED) | Event(FINISHED) |  |  |

##### 4. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Update Text" | "Update Text" | FsmName |  |
| variableName | "Convo Desc" | "Convo Desc" | FsmString |  |
| setValue | "CHARM_DESC_23_BROKEN" | "CHARM_DESC_23_BROKEN" |  |  |
| everyFrame | false | false |  |  |

### Glass Geo

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Current Item Number | int Current Item Number |  |  |
| integer2 | 24 | 24 |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event(FINISHED) | Event(FINISHED) |  |  |
| greaterThan | Event(FINISHED) | Event(FINISHED) |  |  |
| everyFrame | false | false |  |  |

##### 2. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "fragileGreed_unbreakable" | "fragileGreed_unbreakable" |  |  |
| isTrue | Event(UNBREAKABLE) | Event(UNBREAKABLE) |  |  |
| isFalse | Event() | Event() |  |  |

##### 3. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "brokenCharm_24" | "brokenCharm_24" |  |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(FINISHED) | Event(FINISHED) |  |  |

##### 4. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Update Text" | "Update Text" | FsmName |  |
| variableName | "Convo Desc" | "Convo Desc" | FsmString |  |
| setValue | "CHARM_DESC_24_BROKEN" | "CHARM_DESC_24_BROKEN" |  |  |
| everyFrame | false | false |  |  |

### Glass Attack

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Current Item Number | int Current Item Number |  |  |
| integer2 | 25 | 25 |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event(FINISHED) | Event(FINISHED) |  |  |
| greaterThan | Event(FINISHED) | Event(FINISHED) |  |  |
| everyFrame | false | false |  |  |

##### 2. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "fragileStrength_unbreakable" | "fragileStrength_unbreakable" |  |  |
| isTrue | Event(UNBREAKABLE) | Event(UNBREAKABLE) |  |  |
| isFalse | Event() | Event() |  |  |

##### 3. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "brokenCharm_25" | "brokenCharm_25" |  |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(FINISHED) | Event(FINISHED) |  |  |

##### 4. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Update Text" | "Update Text" | FsmName |  |
| variableName | "Convo Desc" | "Convo Desc" | FsmString |  |
| setValue | "CHARM_DESC_25_BROKEN" | "CHARM_DESC_25_BROKEN" |  |  |
| everyFrame | false | false |  |  |

### Update

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:Details Folder | EventTarget(GameObject)[SendToChildren]:Details Folder |  |  |
| sendEvent | "UPDATE" | "UPDATE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Glass HP 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Cool Number | int Cool Number |  |  |
| integer2 | 23 | 23 |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event(FINISHED) | Event(FINISHED) |  |  |
| greaterThan | Event(FINISHED) | Event(FINISHED) |  |  |
| everyFrame | false | false |  |  |

##### 2. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "fragileHealth_unbreakable" | "fragileHealth_unbreakable" |  |  |
| isTrue | Event(UNBREAKABLE) | Event(UNBREAKABLE) |  |  |
| isFalse | Event() | Event() |  |  |

##### 3. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "brokenCharm_23" | "brokenCharm_23" |  |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(FINISHED) | Event(FINISHED) |  |  |

##### 4. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Update Text" | "Update Text" | FsmName |  |
| variableName | "Convo Desc" | "Convo Desc" | FsmString |  |
| setValue | "CHARM_DESC_23_BROKEN" | "CHARM_DESC_23_BROKEN" |  |  |
| everyFrame | false | false |  |  |

### Glass Geo 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Cool Number | int Cool Number |  |  |
| integer2 | 24 | 24 |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event(FINISHED) | Event(FINISHED) |  |  |
| greaterThan | Event(FINISHED) | Event(FINISHED) |  |  |
| everyFrame | false | false |  |  |

##### 2. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "fragileGreed_unbreakable" | "fragileGreed_unbreakable" |  |  |
| isTrue | Event(UNBREAKABLE) | Event(UNBREAKABLE) |  |  |
| isFalse | Event() | Event() |  |  |

##### 3. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "brokenCharm_24" | "brokenCharm_24" |  |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(FINISHED) | Event(FINISHED) |  |  |

##### 4. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Update Text" | "Update Text" | FsmName |  |
| variableName | "Convo Desc" | "Convo Desc" | FsmString |  |
| setValue | "CHARM_DESC_24_BROKEN" | "CHARM_DESC_24_BROKEN" |  |  |
| everyFrame | false | false |  |  |

### Glass Attack 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Cool Number | int Cool Number |  |  |
| integer2 | 25 | 25 |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event(FINISHED) | Event(FINISHED) |  |  |
| greaterThan | Event(FINISHED) | Event(FINISHED) |  |  |
| everyFrame | false | false |  |  |

##### 2. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "fragileStrength_unbreakable" | "fragileStrength_unbreakable" |  |  |
| isTrue | Event(UNBREAKABLE) | Event(UNBREAKABLE) |  |  |
| isFalse | Event() | Event() |  |  |

##### 3. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "brokenCharm_25" | "brokenCharm_25" |  |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(FINISHED) | Event(FINISHED) |  |  |

##### 4. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Update Text" | "Update Text" | FsmName |  |
| variableName | "Convo Desc" | "Convo Desc" | FsmString |  |
| setValue | "CHARM_DESC_25_BROKEN" | "CHARM_DESC_25_BROKEN" |  |  |
| everyFrame | false | false |  |  |

### Update 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:Details Folder | EventTarget(GameObject)[SendToChildren]:Details Folder |  |  |
| sendEvent | "UPDATE" | "UPDATE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Broken?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. IntTestToBool

Full Name: HutongGames.PlayMaker.Actions.IntTestToBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| int1 | int Current Item Number | int Current Item Number |  |  |
| int2 | 23 | 23 |  |  |
| equalBool | bool Glass HP Selected | bool Glass HP Selected | Variable |  |
| lessThanBool | false | false | Variable |  |
| greaterThanBool | false | false | Variable |  |
| everyFrame | false | false |  |  |

##### 2. IntTestToBool

Full Name: HutongGames.PlayMaker.Actions.IntTestToBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| int1 | int Current Item Number | int Current Item Number |  |  |
| int2 | 24 | 24 |  |  |
| equalBool | bool Glass Geo Selected | bool Glass Geo Selected | Variable |  |
| lessThanBool | false | false | Variable |  |
| greaterThanBool | false | false | Variable |  |
| everyFrame | false | false |  |  |

##### 3. IntTestToBool

Full Name: HutongGames.PlayMaker.Actions.IntTestToBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| int1 | int Current Item Number | int Current Item Number |  |  |
| int2 | 25 | 25 |  |  |
| equalBool | bool Glass Attack Selected | bool Glass Attack Selected | Variable |  |
| lessThanBool | false | false | Variable |  |
| greaterThanBool | false | false | Variable |  |
| everyFrame | false | false |  |  |

##### 4. BoolNoneTrue

Full Name: HutongGames.PlayMaker.Actions.BoolNoneTrue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariables | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 | Variable |  |
| sendEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| storeResult | false | false | Variable |  |
| everyFrame | false | false |  |  |

##### 5. GetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName | "brokenCharm_23" | "brokenCharm_23" |  |  |
| storeValue | bool Glass HP Broken | bool Glass HP Broken | Variable |  |

##### 6. GetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName | "brokenCharm_24" | "brokenCharm_24" |  |  |
| storeValue | bool Glass Geo Broken | bool Glass Geo Broken | Variable |  |

##### 7. GetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName | "brokenCharm_25" | "brokenCharm_25" |  |  |
| storeValue | bool Glass Attack Broken | bool Glass Attack Broken | Variable |  |

##### 8. BoolAllTrue

Full Name: HutongGames.PlayMaker.Actions.BoolAllTrue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariables | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 | Variable |  |
| sendEvent | Event(CANCEL) | Event(CANCEL) |  |  |
| storeResult | false | false | Variable |  |
| everyFrame | false | false |  |  |

##### 9. BoolAllTrue

Full Name: HutongGames.PlayMaker.Actions.BoolAllTrue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariables | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 | Variable |  |
| sendEvent | Event(CANCEL) | Event(CANCEL) |  |  |
| storeResult | false | false | Variable |  |
| everyFrame | false | false |  |  |

##### 10. BoolAllTrue

Full Name: HutongGames.PlayMaker.Actions.BoolAllTrue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariables | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 | Variable |  |
| sendEvent | Event(CANCEL) | Event(CANCEL) |  |  |
| storeResult | false | false | Variable |  |
| everyFrame | false | false |  |  |

### Unequippable

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Parent | OwnerDefault Parent |  |  |
| fsmName | "Inventory Control" | "Inventory Control" | FsmName |  |
| variableName | "Do Not Close" | "Do Not Close" | FsmBool |  |
| setValue | false | false |  |  |
| everyFrame | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Self | EventTarget(GameObject):Self |  |  |
| sendEvent | "UI ACTIVE" | "UI ACTIVE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Overcharm Check

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 5

#### Actions

##### 1. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "canOvercharm" | "canOvercharm" |  |  |
| isTrue | Event(OVERCHARM) | Event(OVERCHARM) |  |  |
| isFalse | Event() | Event() |  |  |

##### 2. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Overcharm Attempts | int Overcharm Attempts | Variable |  |
| add | 1 | 1 |  |  |
| everyFrame | false | false |  |  |

##### 3. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Overcharm Attempts | int Overcharm Attempts |  |  |
| integer2 | 2 | 2 |  |  |
| equal | Event(CANCEL) | Event(CANCEL) |  |  |
| lessThan | Event(CANCEL) | Event(CANCEL) |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 4. IntSwitch

Full Name: HutongGames.PlayMaker.Actions.IntSwitch
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Overcharm Attempts | int Overcharm Attempts | Variable |  |
| compareTo | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| sendEvent | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| everyFrame | false | false |  |  |

##### 5. IntSwitch

Full Name: HutongGames.PlayMaker.Actions.IntSwitch
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Overcharm Attempts | int Overcharm Attempts | Variable |  |
| compareTo | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| sendEvent | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| everyFrame | false | false |  |  |

##### 6. IntSwitch

Full Name: HutongGames.PlayMaker.Actions.IntSwitch
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Overcharm Attempts | int Overcharm Attempts | Variable |  |
| compareTo | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| sendEvent | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| everyFrame | false | false |  |  |

### Crack 1

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Tweener Charm | OwnerDefault Tweener Charm |  |  |
| vector | Vector3 OC Crack Pos | Vector3 OC Crack Pos | Variable |  |
| x | 0f | 0f | Variable |  |
| y | 0f | 0f | Variable |  |
| z | 0f | 0f | Variable |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |

##### 2. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player UI (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player UI (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [dream_damage (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [dream_damage (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 3. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player UI (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player UI (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [sword_hit_window_1 (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [sword_hit_window_1 (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 4. SetVector3XYZ

Full Name: HutongGames.PlayMaker.Actions.SetVector3XYZ
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable | Vector3 OC Crack Pos | Vector3 OC Crack Pos | Variable |  |
| vector3Value | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| z | -11f | -11f |  |  |
| everyFrame | false | false |  |  |

##### 5. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault OC Crack 1 | OwnerDefault OC Crack 1 |  |  |
| vector | Vector3 OC Crack Pos | Vector3 OC Crack Pos | Variable |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 6. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault OC Crack 1 | OwnerDefault OC Crack 1 |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 7. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | PlayOvercharmHit(???) | PlayOvercharmHit(???) |  |  |

### Crack 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Tweener Charm | OwnerDefault Tweener Charm |  |  |
| vector | Vector3 OC Crack Pos | Vector3 OC Crack Pos | Variable |  |
| x | 0f | 0f | Variable |  |
| y | 0f | 0f | Variable |  |
| z | 0f | 0f | Variable |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |

##### 2. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player UI (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player UI (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [dream_damage (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [dream_damage (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| pitchMin | 1.15f | 1.15f |  |  |
| pitchMax | 1.15f | 1.15f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 3. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player UI (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player UI (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [sword_hit_window_1 (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [sword_hit_window_1 (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 4. SetVector3XYZ

Full Name: HutongGames.PlayMaker.Actions.SetVector3XYZ
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable | Vector3 OC Crack Pos | Vector3 OC Crack Pos | Variable |  |
| vector3Value | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| z | -11f | -11f |  |  |
| everyFrame | false | false |  |  |

##### 5. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault OC Crack 2 | OwnerDefault OC Crack 2 |  |  |
| vector | Vector3 OC Crack Pos | Vector3 OC Crack Pos | Variable |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 6. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault OC Crack 2 | OwnerDefault OC Crack 2 |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 7. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | PlayOvercharmHit(???) | PlayOvercharmHit(???) |  |  |

### Break

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName | "canOvercharm" | "canOvercharm" |  |  |
| value | true | true |  |  |

##### 2. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player UI (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player UI (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [mage_lord_glass_floor_break (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [mage_lord_glass_floor_break (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 3. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Tweener Charm | OwnerDefault Tweener Charm |  |  |
| vector | Vector3 OC Crack Pos | Vector3 OC Crack Pos | Variable |  |
| x | 0f | 0f | Variable |  |
| y | 0f | 0f | Variable |  |
| z | 0f | 0f | Variable |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |

##### 4. SetVector3XYZ

Full Name: HutongGames.PlayMaker.Actions.SetVector3XYZ
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable | Vector3 OC Crack Pos | Vector3 OC Crack Pos | Variable |  |
| vector3Value | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| z | -11f | -11f |  |  |
| everyFrame | false | false |  |  |

##### 5. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault OC Break | OwnerDefault OC Break |  |  |
| vector | Vector3 OC Crack Pos | Vector3 OC Crack Pos | Variable |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 6. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault OC Break | OwnerDefault OC Break |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 7. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | PlayOvercharmFinalHit(???) | PlayOvercharmFinalHit(???) |  |  |

### Set Overcharm

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName | "overcharmed" | "overcharmed" |  |  |
| value | true | true |  |  |

##### 2. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Text Equipped | OwnerDefault Text Equipped |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Text Overcharmed | OwnerDefault Text Overcharmed |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 4. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player UI (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player UI (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [ghost_dialogue_death_explode (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [ghost_dialogue_death_explode (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 5. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player UI (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player UI (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [mage_lord_projectile_impact (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [mage_lord_projectile_impact (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 6. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Confirm Action Text | OwnerDefault Confirm Action Text |  |  |
| textString | string String Unequip | string String Unequip |  |  |

##### 7. iTweenShakePosition

Full Name: HutongGames.PlayMaker.Actions.iTweenShakePosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| id | "" | "" |  |  |
| vector | Vector3(0.15, 0.15, 0) | Vector3(0.15, 0.15, 0) |  |  |
| time | 0.5f | 0.5f |  |  |
| delay | 0f | 0f |  |  |
| loopType | iTween/LoopType::none | 0 |  |  |
| space | UnityEngine.Space::World | 0 |  |  |
| axis | HutongGames.PlayMaker.Actions.iTweenFsmAction/AxisRestriction::none | 0 |  |  |
| startEvent | Event() | Event() |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |
| stopOnExit | false | false |  |  |
| loopDontFinish | true | true |  |  |

##### 8. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault OC Backboard | OwnerDefault OC Backboard |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | -3.91f | -3.91f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 9. SetSpriteRenderer

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Tweener Charm | OwnerDefault Tweener Charm |  |  |
| active | false | false |  |  |

##### 10. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Newly Equipped Name | string Newly Equipped Name | Variable |  |
| stringValue | string Item Num String | string Item Num String | TextArea |  |
| everyFrame | false | false |  |  |

##### 11. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | EquipCharm(Current Item Number=int Current Item Number) | EquipCharm(Current Item Number=int Current Item Number) |  |  |

##### 12. DestroyAllChildren

Full Name: HutongGames.PlayMaker.Actions.DestroyAllChildren
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Equipped Ch Folder | GameObject Equipped Ch Folder |  |  |
| disable | false | false |  |  |

##### 13. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Equipped Charms | OwnerDefault Equipped Charms |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | BuildCharmList(???) | BuildCharmList(???) |  |  |

##### 14. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:Equipped Ch Folder | EventTarget(GameObject)[SendToChildren]:Equipped Ch Folder |  |  |
| sendEvent | "UP INSTANT" | "UP INSTANT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 15. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:Equipped Ch Folder | EventTarget(GameObject)[SendToChildren]:Equipped Ch Folder |  |  |
| sendEvent | "CHECK NEW" | "CHECK NEW" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 16. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string PlayerData Var Name | string PlayerData Var Name | Variable |  |
| everyFrame | false | false |  |  |

##### 17. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName | string PlayerData Var Name | string PlayerData Var Name |  |  |
| value | true | true |  |  |

##### 18. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Open Slot | bool Open Slot | Variable |  |
| boolValue | false | false |  |  |
| everyFrame | false | false |  |  |

##### 19. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Open Notch | EventTarget(GameObject):Open Notch |  |  |
| sendEvent | "NOTCH DOWN" | "NOTCH DOWN" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 20. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Text Equipped | OwnerDefault Text Equipped |  |  |
| active | false | false |  |  |

##### 21. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Text Overcharmed | OwnerDefault Text Overcharmed |  |  |
| active | true | true |  |  |

##### 22. SetMeshRendererChildren

Full Name: HutongGames.PlayMaker.Actions.SetMeshRendererChildren
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Text Equipped | OwnerDefault Text Equipped |  |  |
| active | false | false |  |  |

##### 23. SetMeshRendererChildren

Full Name: HutongGames.PlayMaker.Actions.SetMeshRendererChildren
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Text Overcharmed | OwnerDefault Text Overcharmed |  |  |
| active | true | true |  |  |

##### 24. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(BroadcastAll):FSM Owner | EventTarget(BroadcastAll):FSM Owner |  |  |
| sendEvent | "CHARM INDICATOR CHECK" | "CHARM INDICATOR CHECK" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Set Notch Out

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Open Notch | OwnerDefault Open Notch |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | -50f | -50f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 2. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Detail Sprite | OwnerDefault Detail Sprite |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | -50f | -50f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

### Over Notches

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
| intName | "charmSlotsFilled" | "charmSlotsFilled" |  |  |
| storeValue | int Overcharm Notches | int Overcharm Notches | Variable |  |

##### 2. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "charmSlots" | "charmSlots" |  |  |
| storeValue | int Notches | int Notches | Variable |  |

##### 3. IntOperator

Full Name: HutongGames.PlayMaker.Actions.IntOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Overcharm Notches | int Overcharm Notches |  |  |
| integer2 | int Notches | int Notches |  |  |
| operation | HutongGames.PlayMaker.Actions.IntOperator/Operation::Subtract | 1 |  |  |
| storeResult | int Overcharm Notches | int Overcharm Notches | Variable |  |
| everyFrame | false | false |  |  |

##### 4. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Over Indicator | OwnerDefault Over Indicator |  |  |
| fsmName | "Over Control" | "Over Control" | FsmName |  |
| variableName | "Cost" | "Cost" | FsmInt |  |
| setValue | int Overcharm Notches | int Overcharm Notches |  |  |
| everyFrame | false | false |  |  |

##### 5. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Over Indicator | OwnerDefault Over Indicator |  |  |
| fsmName | "Over Control" | "Over Control" | FsmName |  |
| variableName | "Overcharmed" | "Overcharmed" | FsmBool |  |
| setValue | true | true |  |  |
| everyFrame | false | false |  |  |

##### 6. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Over Indicator | OwnerDefault Over Indicator |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0.81f | 0.81f |  |  |
| y | 0f | 0f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| perSecond | false | false |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |
| fixedUpdate | false | false |  |  |

##### 7. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Over Indicator | EventTarget(GameObject):Over Indicator |  |  |
| sendEvent | "DISPLAY OVER" | "DISPLAY OVER" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Overcharmed?

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
| boolName | "overcharmed" | "overcharmed" |  |  |
| isTrue | Event(OVERCHARM) | Event(OVERCHARM) |  |  |
| isFalse | Event() | Event() |  |  |

### Over Notches 2

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
| intName | "charmSlotsFilled" | "charmSlotsFilled" |  |  |
| storeValue | int Overcharm Notches | int Overcharm Notches | Variable |  |

##### 2. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Text Overcharmed | OwnerDefault Text Overcharmed |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Text Equipped | OwnerDefault Text Equipped |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 4. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "charmSlots" | "charmSlots" |  |  |
| storeValue | int Notches | int Notches | Variable |  |

##### 5. IntOperator

Full Name: HutongGames.PlayMaker.Actions.IntOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Overcharm Notches | int Overcharm Notches |  |  |
| integer2 | int Notches | int Notches |  |  |
| operation | HutongGames.PlayMaker.Actions.IntOperator/Operation::Subtract | 1 |  |  |
| storeResult | int Overcharm Notches | int Overcharm Notches | Variable |  |
| everyFrame | false | false |  |  |

##### 6. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Over Indicator | OwnerDefault Over Indicator |  |  |
| fsmName | "Over Control" | "Over Control" | FsmName |  |
| variableName | "Cost" | "Cost" | FsmInt |  |
| setValue | int Overcharm Notches | int Overcharm Notches |  |  |
| everyFrame | false | false |  |  |

##### 7. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Over Indicator | OwnerDefault Over Indicator |  |  |
| fsmName | "Over Control" | "Over Control" | FsmName |  |
| variableName | "Overcharmed" | "Overcharmed" | FsmBool |  |
| setValue | true | true |  |  |
| everyFrame | false | false |  |  |

##### 8. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Over Indicator | OwnerDefault Over Indicator |  |  |
| fsmName | "Over Control" | "Over Control" | FsmName |  |
| variableName | "Display Overcharm Start" | "Display Overcharm Start" | FsmBool |  |
| setValue | true | true |  |  |
| everyFrame | false | false |  |  |

### OC Set

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Tweener Charm | OwnerDefault Tweener Charm |  |  |
| vector | Vector3 OC Crack Pos | Vector3 OC Crack Pos | Variable |  |
| x | 0f | 0f | Variable |  |
| y | 0f | 0f | Variable |  |
| z | 0f | 0f | Variable |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |

##### 2. SetVector3XYZ

Full Name: HutongGames.PlayMaker.Actions.SetVector3XYZ
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable | Vector3 OC Crack Pos | Vector3 OC Crack Pos | Variable |  |
| vector3Value | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| z | -11f | -11f |  |  |
| everyFrame | false | false |  |  |

##### 3. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault OC Set Effect | OwnerDefault OC Set Effect |  |  |
| vector | Vector3 OC Crack Pos | Vector3 OC Crack Pos | Variable |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 4. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault OC Set Effect | OwnerDefault OC Set Effect |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 5. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | PlayOvercharmPlace(???) | PlayOvercharmPlace(???) |  |  |

### Unequip Return

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Idle Collection | bool Idle Collection | Variable |  |
| isTrue | Event(TO COLLECTION) | Event(TO COLLECTION) |  |  |
| isFalse | Event(TO EQUIPPED) | Event(TO EQUIPPED) |  |  |
| everyFrame | false | false |  |  |

### End Overcharm?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "overcharmed" | "overcharmed" |  |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(FINISHED) | Event(FINISHED) |  |  |

##### 2. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "charmSlots" | "charmSlots" |  |  |
| storeValue | int Notches | int Notches | Variable |  |

##### 3. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "charmSlotsFilled" | "charmSlotsFilled" |  |  |
| storeValue | int Notches Filled | int Notches Filled | Variable |  |

##### 4. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Notches Filled | int Notches Filled |  |  |
| integer2 | int Notches | int Notches |  |  |
| equal | Event(END) | Event(END) |  |  |
| lessThan | Event(END) | Event(END) |  |  |
| greaterThan | Event(OVERCHARM) | Event(OVERCHARM) |  |  |
| everyFrame | false | false |  |  |

### End Overcharm

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName | "overcharmed" | "overcharmed" |  |  |
| value | false | false |  |  |

##### 2. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Text Equipped | OwnerDefault Text Equipped |  |  |
| active | true | true |  |  |

##### 3. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Text Overcharmed | OwnerDefault Text Overcharmed |  |  |
| active | false | false |  |  |

##### 4. SetMeshRendererChildren

Full Name: HutongGames.PlayMaker.Actions.SetMeshRendererChildren
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Text Equipped | OwnerDefault Text Equipped |  |  |
| active | true | true |  |  |

##### 5. SetMeshRendererChildren

Full Name: HutongGames.PlayMaker.Actions.SetMeshRendererChildren
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Text Overcharmed | OwnerDefault Text Overcharmed |  |  |
| active | false | false |  |  |

##### 6. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault OC Backboard | OwnerDefault OC Backboard |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | -50f | -50f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 7. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Overcharm Ending | bool Overcharm Ending | Variable |  |
| boolValue | true | true |  |  |
| everyFrame | false | false |  |  |

##### 8. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Text Overcharmed | OwnerDefault Text Overcharmed |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 9. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Text Equipped | OwnerDefault Text Equipped |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

### End Overcharm Indicator

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Overcharm Ending | bool Overcharm Ending | Variable |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(FINISHED) | Event(FINISHED) |  |  |
| everyFrame | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Over Indicator | EventTarget(GameObject):Over Indicator |  |  |
| sendEvent | "OVERCHARM END" | "OVERCHARM END" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Overcharm Ending | bool Overcharm Ending | Variable |  |
| boolValue | false | false |  |  |
| everyFrame | false | false |  |  |

### Remain Overcharmed

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
| intName | "charmSlotsFilled" | "charmSlotsFilled" |  |  |
| storeValue | int Overcharm Notches | int Overcharm Notches | Variable |  |

##### 2. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "charmSlots" | "charmSlots" |  |  |
| storeValue | int Notches | int Notches | Variable |  |

##### 3. IntOperator

Full Name: HutongGames.PlayMaker.Actions.IntOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Overcharm Notches | int Overcharm Notches |  |  |
| integer2 | int Notches | int Notches |  |  |
| operation | HutongGames.PlayMaker.Actions.IntOperator/Operation::Subtract | 1 |  |  |
| storeResult | int Overcharm Notches | int Overcharm Notches | Variable |  |
| everyFrame | false | false |  |  |

##### 4. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Over Indicator | OwnerDefault Over Indicator |  |  |
| fsmName | "Over Control" | "Over Control" | FsmName |  |
| variableName | "Cost" | "Cost" | FsmInt |  |
| setValue | int Overcharm Notches | int Overcharm Notches |  |  |
| everyFrame | false | false |  |  |

##### 5. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Over Indicator | OwnerDefault Over Indicator |  |  |
| fsmName | "Over Control" | "Over Control" | FsmName |  |
| variableName | "Overcharmed" | "Overcharmed" | FsmBool |  |
| setValue | true | true |  |  |
| everyFrame | false | false |  |  |

##### 6. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Over Indicator | OwnerDefault Over Indicator |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0.81f | 0.81f |  |  |
| y | 0f | 0f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| perSecond | false | false |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |
| fixedUpdate | false | false |  |  |

##### 7. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Over Indicator | EventTarget(GameObject):Over Indicator |  |  |
| sendEvent | "DISPLAY OVER" | "DISPLAY OVER" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Open Notch?

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
| intName | "charmSlots" | "charmSlots" |  |  |
| storeValue | int Notches | int Notches | Variable |  |

##### 2. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "charmSlotsFilled" | "charmSlotsFilled" |  |  |
| storeValue | int Notches Filled | int Notches Filled | Variable |  |

##### 3. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Notches Filled | int Notches Filled |  |  |
| integer2 | int Notches | int Notches |  |  |
| equal | Event(FINISHED) | Event(FINISHED) |  |  |
| lessThan | Event() | Event() |  |  |
| greaterThan | Event(FINISHED) | Event(FINISHED) |  |  |
| everyFrame | false | false |  |  |

##### 4. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Open Notch | EventTarget(GameObject):Open Notch |  |  |
| sendEvent | "NOTCH UP" | "NOTCH UP" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Tink

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player UI (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player UI (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [sword_hit_reject (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [sword_hit_reject (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 2. SetRandomRotation

Full Name: HutongGames.PlayMaker.Actions.SetRandomRotation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault OC Fail Tink | OwnerDefault OC Fail Tink |  |  |
| x | false | false |  |  |
| y | false | false |  |  |
| z | true | true |  |  |

##### 3. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Tweener Charm | OwnerDefault Tweener Charm |  |  |
| vector | Vector3 OC Crack Pos | Vector3 OC Crack Pos | Variable |  |
| x | 0f | 0f | Variable |  |
| y | 0f | 0f | Variable |  |
| z | 0f | 0f | Variable |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |

##### 4. SetVector3XYZ

Full Name: HutongGames.PlayMaker.Actions.SetVector3XYZ
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable | Vector3 OC Crack Pos | Vector3 OC Crack Pos | Variable |  |
| vector3Value | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| z | -11f | -11f |  |  |
| everyFrame | false | false |  |  |

##### 5. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault OC Fail Tink | OwnerDefault OC Fail Tink |  |  |
| vector | Vector3 OC Crack Pos | Vector3 OC Crack Pos | Variable |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 6. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault OC Fail Tink | OwnerDefault OC Fail Tink |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 7. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | PlayFailedPlace(???) | PlayFailedPlace(???) |  |  |

### Not overcharmed

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Text Equipped | OwnerDefault Text Equipped |  |  |
| active | true | true |  |  |

##### 2. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Text Overcharmed | OwnerDefault Text Overcharmed |  |  |
| active | false | false |  |  |

##### 3. SetMeshRendererChildren

Full Name: HutongGames.PlayMaker.Actions.SetMeshRendererChildren
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Text Equipped | OwnerDefault Text Equipped |  |  |
| active | true | true |  |  |

##### 4. SetMeshRendererChildren

Full Name: HutongGames.PlayMaker.Actions.SetMeshRendererChildren
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Text Overcharmed | OwnerDefault Text Overcharmed |  |  |
| active | false | false |  |  |

##### 5. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault OC Backboard | OwnerDefault OC Backboard |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | -50f | -50f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 6. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Text Overcharmed | OwnerDefault Text Overcharmed |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 7. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Text Equipped | OwnerDefault Text Equipped |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

### Final Charm

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 5

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Current Item Number | int Current Item Number |  |  |
| integer2 | 36 | 36 |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event(FINISHED) | Event(FINISHED) |  |  |
| greaterThan | Event(FINISHED) | Event(FINISHED) |  |  |
| everyFrame | false | false |  |  |

##### 2. IntSwitch

Full Name: HutongGames.PlayMaker.Actions.IntSwitch
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Royal Charm State | int Royal Charm State | Variable |  |
| compareTo | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| sendEvent | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| everyFrame | false | false |  |  |

### R Single

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Update Text" | "Update Text" | FsmName |  |
| variableName | "Convo Name" | "Convo Name" | FsmString |  |
| setValue | "CHARM_NAME_36_A" | "CHARM_NAME_36_A" |  |  |
| everyFrame | false | false |  |  |

##### 2. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Update Text" | "Update Text" | FsmName |  |
| variableName | "Convo Desc" | "Convo Desc" | FsmString |  |
| setValue | "CHARM_DESC_36_A" | "CHARM_DESC_36_A" |  |  |
| everyFrame | false | false |  |  |

### R Final

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Update Text" | "Update Text" | FsmName |  |
| variableName | "Convo Name" | "Convo Name" | FsmString |  |
| setValue | "CHARM_NAME_36_B" | "CHARM_NAME_36_B" |  |  |
| everyFrame | false | false |  |  |

##### 2. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Update Text" | "Update Text" | FsmName |  |
| variableName | "Convo Desc" | "Convo Desc" | FsmString |  |
| setValue | "CHARM_DESC_36_B" | "CHARM_DESC_36_B" |  |  |
| everyFrame | false | false |  |  |

### R Shade

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Update Text" | "Update Text" | FsmName |  |
| variableName | "Convo Name" | "Convo Name" | FsmString |  |
| setValue | "CHARM_NAME_36_C" | "CHARM_NAME_36_C" |  |  |
| everyFrame | false | false |  |  |

##### 2. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Update Text" | "Update Text" | FsmName |  |
| variableName | "Convo Desc" | "Convo Desc" | FsmString |  |
| setValue | "CHARM_DESC_36_C" | "CHARM_DESC_36_C" |  |  |
| everyFrame | false | false |  |  |

### Royal?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Current Item Number | int Current Item Number |  |  |
| integer2 | 36 | 36 |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event(FINISHED) | Event(FINISHED) |  |  |
| greaterThan | Event(FINISHED) | Event(FINISHED) |  |  |
| everyFrame | false | false |  |  |

##### 2. IntSwitch

Full Name: HutongGames.PlayMaker.Actions.IntSwitch
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Royal Charm State | int Royal Charm State | Variable |  |
| compareTo | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| sendEvent | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| everyFrame | false | false |  |  |

### Black Charm?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Current Item Number | int Current Item Number |  |  |
| integer2 | 36 | 36 |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event(FINISHED) | Event(FINISHED) |  |  |
| greaterThan | Event(FINISHED) | Event(FINISHED) |  |  |
| everyFrame | false | false |  |  |

##### 2. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Royal Charm State | int Royal Charm State |  |  |
| integer2 | 4 | 4 |  |  |
| equal | Event(CANCEL) | Event(CANCEL) |  |  |
| lessThan | Event() | Event() |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

### Black Charm? 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Current Item Number | int Current Item Number |  |  |
| integer2 | 36 | 36 |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event(FINISHED) | Event(FINISHED) |  |  |
| greaterThan | Event(FINISHED) | Event(FINISHED) |  |  |
| everyFrame | false | false |  |  |

##### 2. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Royal Charm State | int Royal Charm State |  |  |
| integer2 | 4 | 4 |  |  |
| equal | Event(CANCEL) | Event(CANCEL) |  |  |
| lessThan | Event() | Event() |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

### Final Charm 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 5

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Cool Number | int Cool Number |  |  |
| integer2 | 36 | 36 |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event(FINISHED) | Event(FINISHED) |  |  |
| greaterThan | Event(FINISHED) | Event(FINISHED) |  |  |
| everyFrame | false | false |  |  |

##### 2. IntSwitch

Full Name: HutongGames.PlayMaker.Actions.IntSwitch
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Royal Charm State | int Royal Charm State | Variable |  |
| compareTo | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| sendEvent | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| everyFrame | false | false |  |  |

### R Single 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Update Text" | "Update Text" | FsmName |  |
| variableName | "Convo Name" | "Convo Name" | FsmString |  |
| setValue | "CHARM_NAME_36_A" | "CHARM_NAME_36_A" |  |  |
| everyFrame | false | false |  |  |

##### 2. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Update Text" | "Update Text" | FsmName |  |
| variableName | "Convo Desc" | "Convo Desc" | FsmString |  |
| setValue | "CHARM_DESC_36_A" | "CHARM_DESC_36_A" |  |  |
| everyFrame | false | false |  |  |

### R Final 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Update Text" | "Update Text" | FsmName |  |
| variableName | "Convo Name" | "Convo Name" | FsmString |  |
| setValue | "CHARM_NAME_36_B" | "CHARM_NAME_36_B" |  |  |
| everyFrame | false | false |  |  |

##### 2. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Update Text" | "Update Text" | FsmName |  |
| variableName | "Convo Desc" | "Convo Desc" | FsmString |  |
| setValue | "CHARM_DESC_36_B" | "CHARM_DESC_36_B" |  |  |
| everyFrame | false | false |  |  |

### R Shade 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Update Text" | "Update Text" | FsmName |  |
| variableName | "Convo Name" | "Convo Name" | FsmString |  |
| setValue | "CHARM_NAME_36_C" | "CHARM_NAME_36_C" |  |  |
| everyFrame | false | false |  |  |

##### 2. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Update Text" | "Update Text" | FsmName |  |
| variableName | "Convo Desc" | "Convo Desc" | FsmString |  |
| setValue | "CHARM_DESC_36_C" | "CHARM_DESC_36_C" |  |  |
| everyFrame | false | false |  |  |

### Equip Prompt

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Confirm Action | OwnerDefault Confirm Action |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | -50f | -50f |  |  |
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
| boolName | "atBench" | "atBench" |  |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(FINISHED) | Event(FINISHED) |  |  |

##### 3. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Confirm Action | OwnerDefault Confirm Action |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | -3.36f | -3.36f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

### Equip or Unequip Prompt

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Confirm Action Text | OwnerDefault Confirm Action Text |  |  |
| textString | string String Equip | string String Equip |  |  |

##### 2. ConvertIntToString

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Current Item Number | int Current Item Number | Variable |  |
| stringVariable | string Item Num String | string Item Num String | Variable |  |
| format | "" | "" |  |  |
| everyFrame | false | false |  |  |

##### 3. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string PlayerData Var Name | string PlayerData Var Name | Variable |  |
| everyFrame | false | false |  |  |

##### 4. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | string PlayerData Var Name | string PlayerData Var Name |  |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(FINISHED) | Event(FINISHED) |  |  |

##### 5. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Confirm Action Text | OwnerDefault Confirm Action Text |  |  |
| textString | string String Unequip | string String Unequip |  |  |

### Con Action Down

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Confirm Action | OwnerDefault Confirm Action |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

### Inventory Closed

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

_None_

### Unbreakable Heart

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Update Text" | "Update Text" | FsmName |  |
| variableName | "Convo Name" | "Convo Name" | FsmString |  |
| setValue | "CHARM_NAME_23_G" | "CHARM_NAME_23_G" |  |  |
| everyFrame | false | false |  |  |

##### 2. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Update Text" | "Update Text" | FsmName |  |
| variableName | "Convo Desc" | "Convo Desc" | FsmString |  |
| setValue | "CHARM_DESC_23_G" | "CHARM_DESC_23_G" |  |  |
| everyFrame | false | false |  |  |

### Unbreakable Greed

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Update Text" | "Update Text" | FsmName |  |
| variableName | "Convo Name" | "Convo Name" | FsmString |  |
| setValue | "CHARM_NAME_24_G" | "CHARM_NAME_24_G" |  |  |
| everyFrame | false | false |  |  |

##### 2. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Update Text" | "Update Text" | FsmName |  |
| variableName | "Convo Desc" | "Convo Desc" | FsmString |  |
| setValue | "CHARM_DESC_24_G" | "CHARM_DESC_24_G" |  |  |
| everyFrame | false | false |  |  |

### Unbreakable Attack

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Update Text" | "Update Text" | FsmName |  |
| variableName | "Convo Name" | "Convo Name" | FsmString |  |
| setValue | "CHARM_NAME_25_G" | "CHARM_NAME_25_G" |  |  |
| everyFrame | false | false |  |  |

##### 2. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Update Text" | "Update Text" | FsmName |  |
| variableName | "Convo Desc" | "Convo Desc" | FsmString |  |
| setValue | "CHARM_DESC_25_G" | "CHARM_DESC_25_G" |  |  |
| everyFrame | false | false |  |  |

### Unbreakable Heart 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Update Text" | "Update Text" | FsmName |  |
| variableName | "Convo Name" | "Convo Name" | FsmString |  |
| setValue | "CHARM_NAME_23_G" | "CHARM_NAME_23_G" |  |  |
| everyFrame | false | false |  |  |

##### 2. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Update Text" | "Update Text" | FsmName |  |
| variableName | "Convo Desc" | "Convo Desc" | FsmString |  |
| setValue | "CHARM_DESC_23_G" | "CHARM_DESC_23_G" |  |  |
| everyFrame | false | false |  |  |

### Unbreakable Greed 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Update Text" | "Update Text" | FsmName |  |
| variableName | "Convo Name" | "Convo Name" | FsmString |  |
| setValue | "CHARM_NAME_24_G" | "CHARM_NAME_24_G" |  |  |
| everyFrame | false | false |  |  |

##### 2. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Update Text" | "Update Text" | FsmName |  |
| variableName | "Convo Desc" | "Convo Desc" | FsmString |  |
| setValue | "CHARM_DESC_24_G" | "CHARM_DESC_24_G" |  |  |
| everyFrame | false | false |  |  |

### Unbreakable Attack 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Update Text" | "Update Text" | FsmName |  |
| variableName | "Convo Name" | "Convo Name" | FsmString |  |
| setValue | "CHARM_NAME_25_G" | "CHARM_NAME_25_G" |  |  |
| everyFrame | false | false |  |  |

##### 2. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Update Text" | "Update Text" | FsmName |  |
| variableName | "Convo Desc" | "Convo Desc" | FsmString |  |
| setValue | "CHARM_DESC_25_G" | "CHARM_DESC_25_G" |  |  |
| everyFrame | false | false |  |  |

### Grimm?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Current Item Number | int Current Item Number |  |  |
| integer2 | 40 | 40 |  |  |
| equal | Event(SHOW) | Event(SHOW) |  |  |
| lessThan | Event(HIDE) | Event(HIDE) |  |  |
| greaterThan | Event(HIDE) | Event(HIDE) |  |  |
| everyFrame | false | false |  |  |

### G Show

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Grimm Flame UI | EventTarget(GameObject):Grimm Flame UI |  |  |
| sendEvent | "SHOW" | "SHOW" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### G Hide

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Grimm Flame UI | EventTarget(GameObject):Grimm Flame UI |  |  |
| sendEvent | "HIDE" | "HIDE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Grimm? 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Cool Number | int Cool Number |  |  |
| integer2 | 40 | 40 |  |  |
| equal | Event(SHOW) | Event(SHOW) |  |  |
| lessThan | Event(HIDE) | Event(HIDE) |  |  |
| greaterThan | Event(HIDE) | Event(HIDE) |  |  |
| everyFrame | false | false |  |  |

### G Show 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Grimm Flame UI | EventTarget(GameObject):Grimm Flame UI |  |  |
| sendEvent | "SHOW" | "SHOW" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### G Hide 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Grimm Flame UI | EventTarget(GameObject):Grimm Flame UI |  |  |
| sendEvent | "HIDE" | "HIDE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Grimm Text

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 4

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Current Item Number | int Current Item Number |  |  |
| integer2 | 40 | 40 |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event(FINISHED) | Event(FINISHED) |  |  |
| greaterThan | Event(FINISHED) | Event(FINISHED) |  |  |
| everyFrame | false | false |  |  |

##### 2. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Grimmchild Lv | int Grimmchild Lv |  |  |
| integer2 | 4 | 4 |  |  |
| equal | Event(GRIMM 2) | Event(GRIMM 2) |  |  |
| lessThan | Event(GRIMM 1) | Event(GRIMM 1) |  |  |
| greaterThan | Event(NYMM) | Event(NYMM) |  |  |
| everyFrame | false | false |  |  |

### Grimm Flame

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Update Text" | "Update Text" | FsmName |  |
| variableName | "Convo Name" | "Convo Name" | FsmString |  |
| setValue | "CHARM_NAME_40" | "CHARM_NAME_40" |  |  |
| everyFrame | false | false |  |  |

##### 2. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Update Text" | "Update Text" | FsmName |  |
| variableName | "Convo Desc" | "Convo Desc" | FsmString |  |
| setValue | "CHARM_DESC_40" | "CHARM_DESC_40" |  |  |
| everyFrame | false | false |  |  |

### Grimm Complete

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Update Text" | "Update Text" | FsmName |  |
| variableName | "Convo Name" | "Convo Name" | FsmString |  |
| setValue | "CHARM_NAME_40" | "CHARM_NAME_40" |  |  |
| everyFrame | false | false |  |  |

##### 2. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Update Text" | "Update Text" | FsmName |  |
| variableName | "Convo Desc" | "Convo Desc" | FsmString |  |
| setValue | "CHARM_DESC_40_F" | "CHARM_DESC_40_F" |  |  |
| everyFrame | false | false |  |  |

### Grimm Text 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 4

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Cool Number | int Cool Number |  |  |
| integer2 | 40 | 40 |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event(FINISHED) | Event(FINISHED) |  |  |
| greaterThan | Event(FINISHED) | Event(FINISHED) |  |  |
| everyFrame | false | false |  |  |

##### 2. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Grimmchild Lv | int Grimmchild Lv |  |  |
| integer2 | 4 | 4 |  |  |
| equal | Event(GRIMM 2) | Event(GRIMM 2) |  |  |
| lessThan | Event(GRIMM 1) | Event(GRIMM 1) |  |  |
| greaterThan | Event(NYMM) | Event(NYMM) |  |  |
| everyFrame | false | false |  |  |

### Grimm Flame 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Update Text" | "Update Text" | FsmName |  |
| variableName | "Convo Name" | "Convo Name" | FsmString |  |
| setValue | "CHARM_NAME_40" | "CHARM_NAME_40" |  |  |
| everyFrame | false | false |  |  |

##### 2. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Update Text" | "Update Text" | FsmName |  |
| variableName | "Convo Desc" | "Convo Desc" | FsmString |  |
| setValue | "CHARM_DESC_40" | "CHARM_DESC_40" |  |  |
| everyFrame | false | false |  |  |

### Grimm Complete 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Update Text" | "Update Text" | FsmName |  |
| variableName | "Convo Name" | "Convo Name" | FsmString |  |
| setValue | "CHARM_NAME_40" | "CHARM_NAME_40" |  |  |
| everyFrame | false | false |  |  |

##### 2. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Update Text" | "Update Text" | FsmName |  |
| variableName | "Convo Desc" | "Convo Desc" | FsmString |  |
| setValue | "CHARM_DESC_40_F" | "CHARM_DESC_40_F" |  |  |
| everyFrame | false | false |  |  |

### Nymm

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Update Text" | "Update Text" | FsmName |  |
| variableName | "Convo Name" | "Convo Name" | FsmString |  |
| setValue | "CHARM_NAME_40_N" | "CHARM_NAME_40_N" |  |  |
| everyFrame | false | false |  |  |

##### 2. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Update Text" | "Update Text" | FsmName |  |
| variableName | "Convo Desc" | "Convo Desc" | FsmString |  |
| setValue | "CHARM_DESC_40_N" | "CHARM_DESC_40_N" |  |  |
| everyFrame | false | false |  |  |

### Nymm 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Update Text" | "Update Text" | FsmName |  |
| variableName | "Convo Name" | "Convo Name" | FsmString |  |
| setValue | "CHARM_NAME_40_N" | "CHARM_NAME_40_N" |  |  |
| everyFrame | false | false |  |  |

##### 2. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Update Text" | "Update Text" | FsmName |  |
| variableName | "Convo Desc" | "Convo Desc" | FsmString |  |
| setValue | "CHARM_DESC_40_N" | "CHARM_DESC_40_N" |  |  |
| everyFrame | false | false |  |  |

### Bound Reminder

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. FindGameObject

Full Name: HutongGames.PlayMaker.Actions.FindGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| objectName | "Bound Charm Msg(Clone)" | "Bound Charm Msg(Clone)" |  |  |
| withTag | "Untagged" | "Untagged" | Tag |  |
| store | GameObject Charm Equip Msg | GameObject Charm Equip Msg | Variable |  |

##### 2. GameObjectIsNull

Full Name: HutongGames.PlayMaker.Actions.GameObjectIsNull
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Charm Equip Msg | GameObject Charm Equip Msg | Variable |  |
| isNull | Event() | Event() |  |  |
| isNotNull | Event(FINISHED) | Event(FINISHED) |  |  |
| storeResult | false | false | Variable |  |
| everyFrame | false | false |  |  |

##### 3. CreateObject

Full Name: HutongGames.PlayMaker.Actions.CreateObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Bound Charm Msg (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Bound Charm Msg (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint |  |  |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| rotation | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| storeObject |  |  | Variable |  |
| networkInstantiate | false | false |  |  |
| networkGroup | 0 | 0 |  |  |

##### 4. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.25f | 0.25f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Init | FINISHED | Build Equipped | 0 | 0 | 0 |
| Inactive | ACTIVATE | Activate | 0 | 0 | 0 |
| Cursor Down | FINISHED | Build Equipped | 0 | 0 | 0 |
| Activate | FINISHED | Equip Prompt | 0 | 0 | 0 |
| Idle Collection | UI DOWN | Down | 0 | 0 | 0 |
| Idle Collection | UI LEFT | Left | 0 | 0 | 0 |
| Idle Collection | UI RIGHT | Right | 0 | 0 | 0 |
| Idle Collection | UI UP | Up | 0 | 0 | 0 |
| Idle Collection | UI CONFIRM | Deactivate UI | 0 | 0 | 0 |
| Idle Collection | UI RS UP | To Equipment | 0 | 0 | 0 |
| Down | FINISHED | Charm Collected? | 0 | 0 | 0 |
| Update Cursor | FINISHED | Idle Collection | 0 | 0 | 0 |
| Left | FINISHED | Charm Collected? | 0 | 0 | 0 |
| Left | TO LEFT | Arrow L | 0 | 0 | 0 |
| Right | FINISHED | Charm Collected? | 0 | 0 | 0 |
| Right | TO RIGHT | Arrow R | 0 | 0 | 0 |
| Up | FINISHED | Charm Collected? | 0 | 0 | 0 |
| Up | TO TOP | To Equipment | 0 | 0 | 0 |
| Arrow L | UI LEFT | Shift Pane L | 0 | 0 | 0 |
| Arrow L | UI CONFIRM | Shift Pane L | 0 | 0 | 0 |
| Arrow L | UI RIGHT | Charm Collected? | 0 | 0 | 0 |
| Shift Pane L | CANCEL | Arrow L | 0 | 0 | 0 |
| Arrow R | UI LEFT | Charm Collected? | 0 | 0 | 0 |
| Arrow R | UI CONFIRM | Shift Pane R | 0 | 0 | 0 |
| Arrow R | UI RIGHT | Shift Pane R | 0 | 0 | 0 |
| Shift Pane R | CANCEL | Arrow R | 0 | 0 | 0 |
| Charm Collected? | COLLECTED | Collected | 0 | 0 | 0 |
| Charm Collected? | UNCOLLECTED | Uncollected | 0 | 0 | 0 |
| Collected | FINISHED | Equip or Unequip Prompt | 0 | 0 | 0 |
| Uncollected | FINISHED | Update Cursor | 0 | 0 | 0 |
| Build Equipped | FINISHED | Overcharmed? | 0 | 0 | 0 |
| Tween Up | FINISHED | Check Points | 0 | 0 | 0 |
| Activate UI | FINISHED | Idle Collection | 0 | 0 | 0 |
| Check Points | FINISHED | Set | 0 | 0 | 0 |
| Check Points | OVER | Overcharm Check | 0 | 0 | 0 |
| Set | FINISHED | Open Slot? | 0 | 0 | 0 |
| Deactivate UI | FINISHED | Broken? | 0 | 0 | 0 |
| Deactivate UI | CANCEL | Idle Collection | 0 | 0 | 0 |
| Deactivate UI | NOT BENCH | Bench Reminder | 0 | 0 | 0 |
| Deactivate UI | CHARM BOUND | Bound Reminder | 0 | 0 | 0 |
| Equipped? | EQUIPPED | Black Charm? 2 | 0 | 0 | 0 |
| Equipped? | UNEQUIPPED | Slot Open? | 0 | 0 | 0 |
| Tween Down | FINISHED | Unequip | 0 | 0 | 0 |
| Unequip | FINISHED | End Overcharm Indicator | 0 | 0 | 0 |
| Return Points | FINISHED | End Overcharm? | 0 | 0 | 0 |
| Open Slot? | FULL | No Open Slot | 0 | 0 | 0 |
| Open Slot? | NOT FULL | Open Slot | 0 | 0 | 0 |
| No Open Slot | FINISHED | Activate UI | 0 | 0 | 0 |
| Open Slot | FINISHED | Activate UI | 0 | 0 | 0 |
| To Equipment | FINISHED | Notch? | 0 | 0 | 0 |
| Idle Equipped | UI DOWN | To Bot | 0 | 0 | 0 |
| Idle Equipped | UI LEFT | Move Left | 0 | 0 | 0 |
| Idle Equipped | UI RIGHT | Move Right | 0 | 0 | 0 |
| Idle Equipped | UI CONFIRM | Set Current Item Num | 0 | 0 | 0 |
| Idle Equipped | UI RS DOWN | To Bot | 0 | 0 | 0 |
| Get Selected | FINISHED | Idle Equipped | 0 | 0 | 0 |
| To Bot | FINISHED | Charm Collected? | 0 | 0 | 0 |
| Move Left | TO LEFT | Arrow L | 0 | 0 | 0 |
| Move Left | FINISHED | Notch? | 0 | 0 | 0 |
| Move Right | FINISHED | Notch? | 0 | 0 | 0 |
| Notch? | CHARM | Charm | 0 | 0 | 0 |
| Notch? | FINISHED | Con Action Down | 0 | 0 | 0 |
| Notch? | BENCH | Bench | 0 | 0 | 0 |
| Notch? | NOT BENCH | Not Bench | 0 | 0 | 0 |
| Bench | FINISHED | Get Selected | 0 | 0 | 0 |
| Not Bench | FINISHED | Get Selected | 0 | 0 | 0 |
| Charm | FINISHED | Glass HP 2 | 0 | 0 | 0 |
| Set Current Item Num | FINISHED | Black Charm? | 0 | 0 | 0 |
| Set Current Item Num | CANCEL | Idle Equipped | 0 | 0 | 0 |
| Activate UI Equipped | FINISHED | Notch? | 0 | 0 | 0 |
| Slot Open? | FINISHED | Tween Up | 0 | 0 | 0 |
| Slot Open? | CANCEL | Activate UI | 0 | 0 | 0 |
| Fail Back | FINISHED | Fail Finish | 0 | 0 | 0 |
| Fail | FINISHED | Fail Back | 0 | 0 | 0 |
| Fail Finish | FINISHED | Activate UI | 0 | 0 | 0 |
| Bench Reminder | FINISHED | Idle Collection | 0 | 0 | 0 |
| Open Slot? 2 | FULL | No Open Slot 2 | 0 | 0 | 0 |
| Open Slot? 2 | NOT FULL | Open Slot 2 | 0 | 0 | 0 |
| No Open Slot 2 | FINISHED | Charm Collected? | 0 | 0 | 0 |
| Open Slot 2 | FINISHED | Charm Collected? | 0 | 0 | 0 |
| Glass HP | FINISHED | Glass Geo | 0 | 0 | 0 |
| Glass HP | UNBREAKABLE | Unbreakable Heart | 0 | 0 | 0 |
| Glass Geo | FINISHED | Glass Attack | 0 | 0 | 0 |
| Glass Geo | UNBREAKABLE | Unbreakable Greed | 0 | 0 | 0 |
| Glass Attack | FINISHED | Final Charm | 0 | 0 | 0 |
| Glass Attack | UNBREAKABLE | Unbreakable Attack | 0 | 0 | 0 |
| Update | FINISHED | Grimm? | 0 | 0 | 0 |
| Glass HP 2 | FINISHED | Glass Geo 2 | 0 | 0 | 0 |
| Glass HP 2 | UNBREAKABLE | Unbreakable Heart 2 | 0 | 0 | 0 |
| Glass Geo 2 | FINISHED | Glass Attack 2 | 0 | 0 | 0 |
| Glass Geo 2 | UNBREAKABLE | Unbreakable Greed 2 | 0 | 0 | 0 |
| Glass Attack 2 | FINISHED | Final Charm 2 | 0 | 0 | 0 |
| Glass Attack 2 | UNBREAKABLE | Unbreakable Attack 2 | 0 | 0 | 0 |
| Update 2 | FINISHED | Grimm? 2 | 0 | 0 | 0 |
| Broken? | CANCEL | Unequippable | 0 | 0 | 0 |
| Broken? | FINISHED | Royal? | 0 | 0 | 0 |
| Unequippable | FINISHED | Idle Collection | 0 | 0 | 0 |
| Overcharm Check | CANCEL | Tink | 0 | 0 | 0 |
| Overcharm Check | OVERCHARM CRACK 1 | Crack 1 | 0 | 0 | 0 |
| Overcharm Check | OVERCHARM CRACK 2 | Crack 2 | 0 | 0 | 0 |
| Overcharm Check | OVERCHARM BREAK | Break | 0 | 0 | 0 |
| Overcharm Check | OVERCHARM | OC Set | 0 | 0 | 0 |
| Crack 1 | FINISHED | Fail | 0 | 0 | 0 |
| Crack 2 | FINISHED | Fail | 0 | 0 | 0 |
| Break | FINISHED | Over Notches | 0 | 0 | 0 |
| Set Overcharm | FINISHED | Activate UI | 0 | 0 | 0 |
| Set Notch Out | FINISHED | Inactive | 0 | 0 | 0 |
| Over Notches | FINISHED | Set Overcharm | 0 | 0 | 0 |
| Overcharmed? | FINISHED | Not overcharmed | 0 | 0 | 0 |
| Overcharmed? | OVERCHARM | Over Notches 2 | 0 | 0 | 0 |
| Over Notches 2 | FINISHED | Set Notch Out | 0 | 0 | 0 |
| OC Set | FINISHED | Over Notches | 0 | 0 | 0 |
| Unequip Return | TO COLLECTION | Activate UI | 0 | 0 | 0 |
| Unequip Return | TO EQUIPPED | Activate UI Equipped | 0 | 0 | 0 |
| End Overcharm? | FINISHED | Tween Down | 0 | 0 | 0 |
| End Overcharm? | END | End Overcharm | 0 | 0 | 0 |
| End Overcharm? | OVERCHARM | Remain Overcharmed | 0 | 0 | 0 |
| End Overcharm | FINISHED | Tween Down | 0 | 0 | 0 |
| End Overcharm Indicator | FINISHED | Open Notch? | 0 | 0 | 0 |
| Remain Overcharmed | FINISHED | Tween Down | 0 | 0 | 0 |
| Open Notch? | FINISHED | Unequip Return | 0 | 0 | 0 |
| Tink | FINISHED | Fail | 0 | 0 | 0 |
| Not overcharmed | FINISHED | Set Notch Out | 0 | 0 | 0 |
| Final Charm | FINISHED | Grimm Text | 0 | 0 | 0 |
| Final Charm | R KING | R Single | 0 | 0 | 0 |
| Final Charm | R QUEEN | R Single | 0 | 0 | 0 |
| Final Charm | R FINAL | R Final | 0 | 0 | 0 |
| Final Charm | R SHADE | R Shade | 0 | 0 | 0 |
| R Single | FINISHED | Update | 0 | 0 | 0 |
| R Final | FINISHED | Update | 0 | 0 | 0 |
| R Shade | FINISHED | Update | 0 | 0 | 0 |
| Royal? | FINISHED | Equipped? | 0 | 0 | 0 |
| Royal? | CANCEL | Unequippable | 0 | 0 | 0 |
| Black Charm? | FINISHED | Return Points | 0 | 0 | 0 |
| Black Charm? | CANCEL | Activate UI Equipped | 0 | 0 | 0 |
| Black Charm? 2 | FINISHED | Return Points | 0 | 0 | 0 |
| Black Charm? 2 | CANCEL | Unequippable | 0 | 0 | 0 |
| Final Charm 2 | FINISHED | Grimm Text 2 | 0 | 0 | 0 |
| Final Charm 2 | R KING | R Single 2 | 0 | 0 | 0 |
| Final Charm 2 | R QUEEN | R Single 2 | 0 | 0 | 0 |
| Final Charm 2 | R FINAL | R Final 2 | 0 | 0 | 0 |
| Final Charm 2 | R SHADE | R Shade 2 | 0 | 0 | 0 |
| R Single 2 | FINISHED | Update 2 | 0 | 0 | 0 |
| R Final 2 | FINISHED | Update 2 | 0 | 0 | 0 |
| R Shade 2 | FINISHED | Update 2 | 0 | 0 | 0 |
| Equip Prompt | FINISHED | Open Slot? 2 | 0 | 0 | 0 |
| Equip or Unequip Prompt | FINISHED | Glass HP | 0 | 0 | 0 |
| Con Action Down | FINISHED | Get Selected | 0 | 0 | 0 |
| Unbreakable Heart | FINISHED | Update | 0 | 0 | 0 |
| Unbreakable Greed | FINISHED | Update | 0 | 0 | 0 |
| Unbreakable Attack | FINISHED | Update | 0 | 0 | 0 |
| Unbreakable Heart 2 | FINISHED | Update 2 | 0 | 0 | 0 |
| Unbreakable Greed 2 | FINISHED | Update 2 | 0 | 0 | 0 |
| Unbreakable Attack 2 | FINISHED | Update 2 | 0 | 0 | 0 |
| Grimm? | SHOW | G Show | 0 | 0 | 0 |
| Grimm? | HIDE | G Hide | 0 | 0 | 0 |
| G Show | FINISHED | Update Cursor | 0 | 0 | 0 |
| G Hide | FINISHED | Update Cursor | 0 | 0 | 0 |
| Grimm? 2 | SHOW | G Show 2 | 0 | 0 | 0 |
| Grimm? 2 | HIDE | G Hide 2 | 0 | 0 | 0 |
| G Show 2 | FINISHED | Get Selected | 0 | 0 | 0 |
| G Hide 2 | FINISHED | Get Selected | 0 | 0 | 0 |
| Grimm Text | FINISHED | Update | 0 | 0 | 0 |
| Grimm Text | GRIMM 1 | Grimm Flame | 0 | 0 | 0 |
| Grimm Text | GRIMM 2 | Grimm Complete | 0 | 0 | 0 |
| Grimm Text | NYMM | Nymm | 0 | 0 | 0 |
| Grimm Flame | FINISHED | Update | 0 | 0 | 0 |
| Grimm Complete | FINISHED | Update | 0 | 0 | 0 |
| Grimm Text 2 | FINISHED | Update 2 | 0 | 0 | 0 |
| Grimm Text 2 | GRIMM 1 | Grimm Flame 2 | 0 | 0 | 0 |
| Grimm Text 2 | GRIMM 2 | Grimm Complete 2 | 0 | 0 | 0 |
| Grimm Text 2 | NYMM | Nymm 2 | 0 | 0 | 0 |
| Grimm Flame 2 | FINISHED | Update 2 | 0 | 0 | 0 |
| Grimm Complete 2 | FINISHED | Update 2 | 0 | 0 | 0 |
| Nymm | FINISHED | Update | 0 | 0 | 0 |
| Nymm 2 | FINISHED | Update 2 | 0 | 0 | 0 |
| Bound Reminder | FINISHED | Idle Collection | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| PANE RESET | Cursor Down | 0 | 0 | 0 |
| INVENTORY CLOSED | Inventory Closed | 0 | 0 | 0 |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| ACTIVATE | false |
| BENCH | false |
| CANCEL | false |
| CHARM | false |
| CHARM BOUND | false |
| COLLECTED | false |
| END | false |
| EQUIPPED | false |
| FULL | false |
| GRIMM 1 | false |
| GRIMM 2 | false |
| HIDE | false |
| INVENTORY CLOSED | false |
| NOT BENCH | false |
| NOT FULL | false |
| NYMM | false |
| OVER | false |
| OVERCHARM | false |
| OVERCHARM BREAK | false |
| OVERCHARM CRACK 1 | false |
| OVERCHARM CRACK 2 | false |
| PANE RESET | false |
| R FINAL | false |
| R KING | false |
| R QUEEN | false |
| R SHADE | false |
| SHOW | false |
| TO COLLECTION | false |
| TO EQUIPPED | false |
| TO LEFT | false |
| TO RIGHT | false |
| TO TOP | false |
| UI CONFIRM | false |
| UI DOWN | false |
| UI LEFT | false |
| UI RIGHT | false |
| UI RS DOWN | false |
| UI RS UP | false |
| UI UP | false |
| UNBREAKABLE | false |
| UNCOLLECTED | false |
| UNEQUIPPED | false |

