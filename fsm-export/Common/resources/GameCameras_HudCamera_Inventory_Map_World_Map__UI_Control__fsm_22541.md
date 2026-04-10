# UI Control

## Summary

| Field | Value |
| --- | --- |
| FSM Name | UI Control |
| GameObject Name | World Map |
| GameObject Path | _GameCameras/HudCamera/Inventory/Map |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Init |
| FSM PathId | 22541 |
| GameObject PathId | 4223 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Area Map X | 0 | Single: 0 |
| Area Map Y | 0 | Single: 0 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Disable Zoom | false | Boolean: false |
| Display Hive | false | Boolean: false |
| Repeating | false | Boolean: false |
| Zoom Shortcut | false | Boolean: false |

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| Area String |  | String:  |
| Confirm Text Str |  | String:  |
| Current Area |  | String:  |
| Current Selection |  | String:  |
| Marker Text Str |  | String:  |

### Vector3s

| Name | Value | Raw/Type |
| --- | --- | --- |
| Arrow Pos | Vector3(0, 0, 0) | Vector3: Vector3(0, 0, 0) |
| Zoom Back Pos | Vector3(0, 0, 0) | Vector3: Vector3(0, 0, 0) |
| Zoom To Pos | Vector3(0, 0, 0) | Vector3: Vector3(0, 0, 0) |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Ancient Basin | [null] | NamedAssetPPtr:  |
| Area Name | [null] | NamedAssetPPtr:  |
| Arrow L | [null] | NamedAssetPPtr:  |
| Arrow R | [null] | NamedAssetPPtr:  |
| Border | [null] | NamedAssetPPtr:  |
| City | [null] | NamedAssetPPtr:  |
| Cliffs | [null] | NamedAssetPPtr:  |
| Confirm Action | [null] | NamedAssetPPtr:  |
| Confirm Text | [null] | NamedAssetPPtr:  |
| Crossroads | [null] | NamedAssetPPtr:  |
| Cursor | [null] | NamedAssetPPtr:  |
| Deepnest | [null] | NamedAssetPPtr:  |
| Fog Canyon | [null] | NamedAssetPPtr:  |
| Fungal Wastes | [null] | NamedAssetPPtr:  |
| Greenpath | [null] | NamedAssetPPtr:  |
| Hive | [null] | NamedAssetPPtr:  |
| Inventory | [null] | NamedAssetPPtr:  |
| Map Key | [null] | NamedAssetPPtr:  |
| Map Marker Top | [null] | NamedAssetPPtr:  |
| Marker Action | [null] | NamedAssetPPtr:  |
| Marker Text | [null] | NamedAssetPPtr:  |
| Mines | [null] | NamedAssetPPtr:  |
| Outskirts | [null] | NamedAssetPPtr:  |
| Palace Grounds | [null] | NamedAssetPPtr:  |
| Pan Arrows | [null] | NamedAssetPPtr:  |
| Pane Arrow L | [null] | NamedAssetPPtr:  |
| Pane Arrow R | [null] | NamedAssetPPtr:  |
| Pane Name L | [null] | NamedAssetPPtr:  |
| Pane Name R | [null] | NamedAssetPPtr:  |
| Parent | [null] | NamedAssetPPtr:  |
| Resting Grounds | [null] | NamedAssetPPtr:  |
| Royal Gardens | [null] | NamedAssetPPtr:  |
| Self | [null] | NamedAssetPPtr:  |
| Town | [null] | NamedAssetPPtr:  |
| Waterways | [null] | NamedAssetPPtr:  |
| Wide Map | [null] | NamedAssetPPtr:  |
| mm Backboard | [null] | NamedAssetPPtr:  |
| mm Cursor | [null] | NamedAssetPPtr:  |
| mm Marker_b | [null] | NamedAssetPPtr:  |
| mm Marker_r | [null] | NamedAssetPPtr:  |
| mm Marker_w | [null] | NamedAssetPPtr:  |
| mm Marker_y | [null] | NamedAssetPPtr:  |

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

##### 4. ActivateAllChildren

Full Name: HutongGames.PlayMaker.Actions.ActivateAllChildren
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Self | GameObject Self | Variable |  |
| activate | true | true |  |  |

##### 5. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Area Name" | "Area Name" |  |  |
| storeResult | GameObject Area Name | GameObject Area Name | Variable |  |

##### 6. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Wide Map" | "Wide Map" |  |  |
| storeResult | GameObject Wide Map | GameObject Wide Map | Variable |  |

##### 7. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Cursor" | "Cursor" |  |  |
| storeResult | GameObject Cursor | GameObject Cursor | Variable |  |

##### 8. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inventory | OwnerDefault Inventory |  |  |
| childName | "Border" | "Border" |  |  |
| storeResult | GameObject Border | GameObject Border | Variable |  |

##### 9. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Border | OwnerDefault Border |  |  |
| childName | "Arrow Right" | "Arrow Right" |  |  |
| storeResult | GameObject Arrow R | GameObject Arrow R | Variable |  |

##### 10. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Border | OwnerDefault Border |  |  |
| childName | "Arrow Left" | "Arrow Left" |  |  |
| storeResult | GameObject Arrow L | GameObject Arrow L | Variable |  |

##### 11. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Wide Map | OwnerDefault Wide Map |  |  |
| childName | "Crossroads" | "Crossroads" |  |  |
| storeResult | GameObject Crossroads | GameObject Crossroads | Variable |  |

##### 12. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Wide Map | OwnerDefault Wide Map |  |  |
| childName | "Deepnest" | "Deepnest" |  |  |
| storeResult | GameObject Deepnest | GameObject Deepnest | Variable |  |

##### 13. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Wide Map | OwnerDefault Wide Map |  |  |
| childName | "Fog Canyon" | "Fog Canyon" |  |  |
| storeResult | GameObject Fog Canyon | GameObject Fog Canyon | Variable |  |

##### 14. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Wide Map | OwnerDefault Wide Map |  |  |
| childName | "Fungal Wastes" | "Fungal Wastes" |  |  |
| storeResult | GameObject Fungal Wastes | GameObject Fungal Wastes | Variable |  |

##### 15. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Wide Map | OwnerDefault Wide Map |  |  |
| childName | "Greenpath" | "Greenpath" |  |  |
| storeResult | GameObject Greenpath | GameObject Greenpath | Variable |  |

##### 16. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Wide Map | OwnerDefault Wide Map |  |  |
| childName | "Mines" | "Mines" |  |  |
| storeResult | GameObject Mines | GameObject Mines | Variable |  |

##### 17. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Wide Map | OwnerDefault Wide Map |  |  |
| childName | "Resting Grounds" | "Resting Grounds" |  |  |
| storeResult | GameObject Resting Grounds | GameObject Resting Grounds | Variable |  |

##### 18. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Wide Map | OwnerDefault Wide Map |  |  |
| childName | "Town" | "Town" |  |  |
| storeResult | GameObject Town | GameObject Town | Variable |  |

##### 19. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Wide Map | OwnerDefault Wide Map |  |  |
| childName | "Waterways" | "Waterways" |  |  |
| storeResult | GameObject Waterways | GameObject Waterways | Variable |  |

##### 20. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Wide Map | OwnerDefault Wide Map |  |  |
| childName | "City" | "City" |  |  |
| storeResult | GameObject City | GameObject City | Variable |  |

##### 21. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Wide Map | OwnerDefault Wide Map |  |  |
| childName | "Cliffs" | "Cliffs" |  |  |
| storeResult | GameObject Cliffs | GameObject Cliffs | Variable |  |

##### 22. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Wide Map | OwnerDefault Wide Map |  |  |
| childName | "Palace Grounds" | "Palace Grounds" |  |  |
| storeResult | GameObject Palace Grounds | GameObject Palace Grounds | Variable |  |

##### 23. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Wide Map | OwnerDefault Wide Map |  |  |
| childName | "Outskirts" | "Outskirts" |  |  |
| storeResult | GameObject Outskirts | GameObject Outskirts | Variable |  |

##### 24. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Wide Map | OwnerDefault Wide Map |  |  |
| childName | "Royal Gardens" | "Royal Gardens" |  |  |
| storeResult | GameObject Royal Gardens | GameObject Royal Gardens | Variable |  |

##### 25. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Wide Map | OwnerDefault Wide Map |  |  |
| childName | "Ancient Basin" | "Ancient Basin" |  |  |
| storeResult | GameObject Ancient Basin | GameObject Ancient Basin | Variable |  |

##### 26. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Wide Map | OwnerDefault Wide Map |  |  |
| childName | "Hive" | "Hive" |  |  |
| storeResult | GameObject Hive | GameObject Hive | Variable |  |

##### 27. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Pan Arrows" | "Pan Arrows" |  |  |
| storeResult | GameObject Pan Arrows | GameObject Pan Arrows | Variable |  |

##### 28. ActivateAllChildren

Full Name: HutongGames.PlayMaker.Actions.ActivateAllChildren
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Pan Arrows | GameObject Pan Arrows | Variable |  |
| activate | false | false |  |  |

##### 29. ActivateAllChildren

Full Name: HutongGames.PlayMaker.Actions.ActivateAllChildren
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Wide Map | GameObject Wide Map | Variable |  |
| activate | true | true |  |  |

##### 30. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Border | OwnerDefault Border |  |  |
| childName | "Pane Arrow L" | "Pane Arrow L" |  |  |
| storeResult | GameObject Pane Arrow L | GameObject Pane Arrow L | Variable |  |

##### 31. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Border | OwnerDefault Border |  |  |
| childName | "Pane Arrow R" | "Pane Arrow R" |  |  |
| storeResult | GameObject Pane Arrow R | GameObject Pane Arrow R | Variable |  |

##### 32. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Border | OwnerDefault Border |  |  |
| childName | "Pane Name L" | "Pane Name L" |  |  |
| storeResult | GameObject Pane Name L | GameObject Pane Name L | Variable |  |

##### 33. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Border | OwnerDefault Border |  |  |
| childName | "Pane Name R" | "Pane Name R" |  |  |
| storeResult | GameObject Pane Name R | GameObject Pane Name R | Variable |  |

##### 34. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Confirm Action" | "Confirm Action" |  |  |
| storeResult | GameObject Confirm Action | GameObject Confirm Action | Variable |  |

##### 35. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Confirm Action | OwnerDefault Confirm Action |  |  |
| childName | "Text" | "Text" |  |  |
| storeResult | GameObject Confirm Text | GameObject Confirm Text | Variable |  |

##### 36. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inventory | OwnerDefault Inventory |  |  |
| childName | "Map Key" | "Map Key" |  |  |
| storeResult | GameObject Map Key | GameObject Map Key | Variable |  |

##### 37. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Confirm Action | OwnerDefault Confirm Action |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 38. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Map Markers" | "Map Markers" |  |  |
| storeResult | GameObject Map Marker Top | GameObject Map Marker Top | Variable |  |

##### 39. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Backboard" | "Backboard" |  |  |
| storeResult | GameObject mm Backboard | GameObject mm Backboard | Variable |  |

##### 40. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Cursor" | "Cursor" |  |  |
| storeResult | GameObject mm Cursor | GameObject mm Cursor | Variable |  |

##### 41. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Marker_b" | "Marker_b" |  |  |
| storeResult | GameObject mm Marker_b | GameObject mm Marker_b | Variable |  |

##### 42. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Marker_r" | "Marker_r" |  |  |
| storeResult | GameObject mm Marker_r | GameObject mm Marker_r | Variable |  |

##### 43. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Marker_w" | "Marker_w" |  |  |
| storeResult | GameObject mm Marker_w | GameObject mm Marker_w | Variable |  |

##### 44. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Marker_y" | "Marker_y" |  |  |
| storeResult | GameObject mm Marker_y | GameObject mm Marker_y | Variable |  |

##### 45. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Map Marker Action" | "Map Marker Action" |  |  |
| storeResult | GameObject Marker Action | GameObject Marker Action | Variable |  |

##### 46. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Marker Action | OwnerDefault Marker Action |  |  |
| childName | "Text" | "Text" |  |  |
| storeResult | GameObject Marker Text | GameObject Marker Text | Variable |  |

##### 47. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Marker Action | OwnerDefault Marker Action |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

### Crossroads

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
| boolName | "mapCrossroads" | "mapCrossroads" |  |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(TOWN) | Event(TOWN) |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:FSM Owner | EventTarget(GameObject)[SendToChildren]:FSM Owner |  |  |
| sendEvent | "UNSELECT" | "UNSELECT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:Crossroads | EventTarget(GameObject)[SendToChildren]:Crossroads |  |  |
| sendEvent | "SELECT" | "SELECT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 4. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "UI" | "UI" |  |  |
| convName | "MAP_NAME_CROSSROADS" | "MAP_NAME_CROSSROADS" |  |  |
| storeValue | string Area String | string Area String | Variable |  |

##### 5. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Area Name | OwnerDefault Area Name |  |  |
| textString | string Area String | string Area String |  |  |

##### 6. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Current Selection | string Current Selection | Variable |  |
| stringValue | "CROSSROADS" | "CROSSROADS" | TextArea |  |
| everyFrame | false | false |  |  |

##### 7. SetVector3Value

Full Name: HutongGames.PlayMaker.Actions.SetVector3Value
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable | Vector3 Zoom To Pos | Vector3 Zoom To Pos | Variable |  |
| vector3Value | Vector3(-0.04, -7.58, -22) | Vector3(-0.04, -7.58, -22) |  |  |
| everyFrame | false | false |  |  |

##### 8. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Zoom Shortcut | bool Zoom Shortcut | Variable |  |
| isTrue | Event(MAP ZOOM) | Event(MAP ZOOM) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

### City

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
| boolName | "mapCity" | "mapCity" |  |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(TOWN) | Event(TOWN) |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:FSM Owner | EventTarget(GameObject)[SendToChildren]:FSM Owner |  |  |
| sendEvent | "UNSELECT" | "UNSELECT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:City | EventTarget(GameObject)[SendToChildren]:City |  |  |
| sendEvent | "SELECT" | "SELECT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 4. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "UI" | "UI" |  |  |
| convName | "MAP_NAME_CITY" | "MAP_NAME_CITY" |  |  |
| storeValue | string Area String | string Area String | Variable |  |

##### 5. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Area Name | OwnerDefault Area Name |  |  |
| textString | string Area String | string Area String |  |  |

##### 6. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Current Selection | string Current Selection | Variable |  |
| stringValue | "CITY" | "CITY" | TextArea |  |
| everyFrame | false | false |  |  |

##### 7. SetVector3Value

Full Name: HutongGames.PlayMaker.Actions.SetVector3Value
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable | Vector3 Zoom To Pos | Vector3 Zoom To Pos | Variable |  |
| vector3Value | Vector3(-10.17, 1.13, -22) | Vector3(-10.17, 1.13, -22) |  |  |
| everyFrame | false | false |  |  |

##### 8. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Zoom Shortcut | bool Zoom Shortcut | Variable |  |
| isTrue | Event(MAP ZOOM) | Event(MAP ZOOM) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

### Town

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 4

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:FSM Owner | EventTarget(GameObject)[SendToChildren]:FSM Owner |  |  |
| sendEvent | "UNSELECT" | "UNSELECT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:Town | EventTarget(GameObject)[SendToChildren]:Town |  |  |
| sendEvent | "SELECT" | "SELECT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "UI" | "UI" |  |  |
| convName | "MAP_NAME_DIRTMOUTH" | "MAP_NAME_DIRTMOUTH" |  |  |
| storeValue | string Area String | string Area String | Variable |  |

##### 4. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Area Name | OwnerDefault Area Name |  |  |
| textString | string Area String | string Area String |  |  |

##### 5. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Current Selection | string Current Selection | Variable |  |
| stringValue | "TOWN" | "TOWN" | TextArea |  |
| everyFrame | false | false |  |  |

##### 6. SetVector3Value

Full Name: HutongGames.PlayMaker.Actions.SetVector3Value
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable | Vector3 Zoom To Pos | Vector3 Zoom To Pos | Variable |  |
| vector3Value | Vector3(4, -8.642, -22) | Vector3(4, -8.642, -22) |  |  |
| everyFrame | false | false |  |  |

##### 7. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Zoom Shortcut | bool Zoom Shortcut | Variable |  |
| isTrue | Event(MAP ZOOM) | Event(MAP ZOOM) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

### Mines

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 4

#### Actions

##### 1. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapMines" | "mapMines" |  |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(TOWN) | Event(TOWN) |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:FSM Owner | EventTarget(GameObject)[SendToChildren]:FSM Owner |  |  |
| sendEvent | "UNSELECT" | "UNSELECT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:Mines | EventTarget(GameObject)[SendToChildren]:Mines |  |  |
| sendEvent | "SELECT" | "SELECT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 4. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "UI" | "UI" |  |  |
| convName | "MAP_NAME_MINES" | "MAP_NAME_MINES" |  |  |
| storeValue | string Area String | string Area String | Variable |  |

##### 5. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Area Name | OwnerDefault Area Name |  |  |
| textString | string Area String | string Area String |  |  |

##### 6. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Current Selection | string Current Selection | Variable |  |
| stringValue | "MINES" | "MINES" | TextArea |  |
| everyFrame | false | false |  |  |

##### 7. SetVector3Value

Full Name: HutongGames.PlayMaker.Actions.SetVector3Value
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable | Vector3 Zoom To Pos | Vector3 Zoom To Pos | Variable |  |
| vector3Value | Vector3(-9.47, -11.60739, -22) | Vector3(-9.47, -11.60739, -22) |  |  |
| everyFrame | false | false |  |  |

##### 8. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Zoom Shortcut | bool Zoom Shortcut | Variable |  |
| isTrue | Event(MAP ZOOM) | Event(MAP ZOOM) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

### Resting Grounds

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
| boolName | "mapRestingGrounds" | "mapRestingGrounds" |  |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(TOWN) | Event(TOWN) |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:FSM Owner | EventTarget(GameObject)[SendToChildren]:FSM Owner |  |  |
| sendEvent | "UNSELECT" | "UNSELECT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:Resting Grounds | EventTarget(GameObject)[SendToChildren]:Resting Grounds |  |  |
| sendEvent | "SELECT" | "SELECT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 4. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "UI" | "UI" |  |  |
| convName | "MAP_NAME_RESTING_GROUNDS" | "MAP_NAME_RESTING_GROUNDS" |  |  |
| storeValue | string Area String | string Area String | Variable |  |

##### 5. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Area Name | OwnerDefault Area Name |  |  |
| textString | string Area String | string Area String |  |  |

##### 6. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Current Selection | string Current Selection | Variable |  |
| stringValue | "RESTING_GROUNDS" | "RESTING_GROUNDS" | TextArea |  |
| everyFrame | false | false |  |  |

##### 7. SetVector3Value

Full Name: HutongGames.PlayMaker.Actions.SetVector3Value
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable | Vector3 Zoom To Pos | Vector3 Zoom To Pos | Variable |  |
| vector3Value | Vector3(-11.59, -6.9, -22) | Vector3(-11.59, -6.9, -22) |  |  |
| everyFrame | false | false |  |  |

##### 8. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Zoom Shortcut | bool Zoom Shortcut | Variable |  |
| isTrue | Event(MAP ZOOM) | Event(MAP ZOOM) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

### Cliffs

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 4

#### Actions

##### 1. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapCliffs" | "mapCliffs" |  |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(TOWN) | Event(TOWN) |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:FSM Owner | EventTarget(GameObject)[SendToChildren]:FSM Owner |  |  |
| sendEvent | "UNSELECT" | "UNSELECT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:Cliffs | EventTarget(GameObject)[SendToChildren]:Cliffs |  |  |
| sendEvent | "SELECT" | "SELECT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 4. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "UI" | "UI" |  |  |
| convName | "MAP_NAME_CLIFFS" | "MAP_NAME_CLIFFS" |  |  |
| storeValue | string Area String | string Area String | Variable |  |

##### 5. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Area Name | OwnerDefault Area Name |  |  |
| textString | string Area String | string Area String |  |  |

##### 6. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Current Selection | string Current Selection | Variable |  |
| stringValue | "CLIFFS" | "CLIFFS" | TextArea |  |
| everyFrame | false | false |  |  |

##### 7. SetVector3Value

Full Name: HutongGames.PlayMaker.Actions.SetVector3Value
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable | Vector3 Zoom To Pos | Vector3 Zoom To Pos | Variable |  |
| vector3Value | Vector3(8.91, -10.6653, -22) | Vector3(8.91, -10.6653, -22) |  |  |
| everyFrame | false | false |  |  |

##### 8. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Zoom Shortcut | bool Zoom Shortcut | Variable |  |
| isTrue | Event(MAP ZOOM) | Event(MAP ZOOM) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

### Greenpath

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
| boolName | "mapGreenpath" | "mapGreenpath" |  |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(TOWN) | Event(TOWN) |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:FSM Owner | EventTarget(GameObject)[SendToChildren]:FSM Owner |  |  |
| sendEvent | "UNSELECT" | "UNSELECT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:Greenpath | EventTarget(GameObject)[SendToChildren]:Greenpath |  |  |
| sendEvent | "SELECT" | "SELECT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 4. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "UI" | "UI" |  |  |
| convName | "MAP_NAME_GREENPATH" | "MAP_NAME_GREENPATH" |  |  |
| storeValue | string Area String | string Area String | Variable |  |

##### 5. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Area Name | OwnerDefault Area Name |  |  |
| textString | string Area String | string Area String |  |  |

##### 6. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Current Selection | string Current Selection | Variable |  |
| stringValue | "GREEN_PATH" | "GREEN_PATH" | TextArea |  |
| everyFrame | false | false |  |  |

##### 7. SetVector3Value

Full Name: HutongGames.PlayMaker.Actions.SetVector3Value
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable | Vector3 Zoom To Pos | Vector3 Zoom To Pos | Variable |  |
| vector3Value | Vector3(16.42, -7.32, -22) | Vector3(16.42, -7.32, -22) |  |  |
| everyFrame | false | false |  |  |

##### 8. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Zoom Shortcut | bool Zoom Shortcut | Variable |  |
| isTrue | Event(MAP ZOOM) | Event(MAP ZOOM) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

### Fungus

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
| boolName | "mapFungalWastes" | "mapFungalWastes" |  |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(TOWN) | Event(TOWN) |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:FSM Owner | EventTarget(GameObject)[SendToChildren]:FSM Owner |  |  |
| sendEvent | "UNSELECT" | "UNSELECT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:Fungal Wastes | EventTarget(GameObject)[SendToChildren]:Fungal Wastes |  |  |
| sendEvent | "SELECT" | "SELECT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 4. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "UI" | "UI" |  |  |
| convName | "MAP_NAME_FUNGAL_WASTES" | "MAP_NAME_FUNGAL_WASTES" |  |  |
| storeValue | string Area String | string Area String | Variable |  |

##### 5. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Area Name | OwnerDefault Area Name |  |  |
| textString | string Area String | string Area String |  |  |

##### 6. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Current Selection | string Current Selection | Variable |  |
| stringValue | "WASTES" | "WASTES" | TextArea |  |
| everyFrame | false | false |  |  |

##### 7. SetVector3Value

Full Name: HutongGames.PlayMaker.Actions.SetVector3Value
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable | Vector3 Zoom To Pos | Vector3 Zoom To Pos | Variable |  |
| vector3Value | Vector3(4.56, 1.31, -22) | Vector3(4.56, 1.31, -22) |  |  |
| everyFrame | false | false |  |  |

##### 8. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Zoom Shortcut | bool Zoom Shortcut | Variable |  |
| isTrue | Event(MAP ZOOM) | Event(MAP ZOOM) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

### Deepnest

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 4

#### Actions

##### 1. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapDeepnest" | "mapDeepnest" |  |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(TOWN) | Event(TOWN) |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:FSM Owner | EventTarget(GameObject)[SendToChildren]:FSM Owner |  |  |
| sendEvent | "UNSELECT" | "UNSELECT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:Deepnest | EventTarget(GameObject)[SendToChildren]:Deepnest |  |  |
| sendEvent | "SELECT" | "SELECT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 4. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "UI" | "UI" |  |  |
| convName | "MAP_NAME_DEEPNEST" | "MAP_NAME_DEEPNEST" |  |  |
| storeValue | string Area String | string Area String | Variable |  |

##### 5. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Area Name | OwnerDefault Area Name |  |  |
| textString | string Area String | string Area String |  |  |

##### 6. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Current Selection | string Current Selection | Variable |  |
| stringValue | "DEEPNEST" | "DEEPNEST" | TextArea |  |
| everyFrame | false | false |  |  |

##### 7. SetVector3Value

Full Name: HutongGames.PlayMaker.Actions.SetVector3Value
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable | Vector3 Zoom To Pos | Vector3 Zoom To Pos | Variable |  |
| vector3Value | Vector3(15.85, 7.29, -22) | Vector3(15.85, 7.29, -22) |  |  |
| everyFrame | false | false |  |  |

##### 8. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Zoom Shortcut | bool Zoom Shortcut | Variable |  |
| isTrue | Event(MAP ZOOM) | Event(MAP ZOOM) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

### Waterways

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
| boolName | "mapWaterways" | "mapWaterways" |  |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(TOWN) | Event(TOWN) |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:FSM Owner | EventTarget(GameObject)[SendToChildren]:FSM Owner |  |  |
| sendEvent | "UNSELECT" | "UNSELECT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:Waterways | EventTarget(GameObject)[SendToChildren]:Waterways |  |  |
| sendEvent | "SELECT" | "SELECT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 4. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "UI" | "UI" |  |  |
| convName | "MAP_NAME_WATERWAYS" | "MAP_NAME_WATERWAYS" |  |  |
| storeValue | string Area String | string Area String | Variable |  |

##### 5. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Area Name | OwnerDefault Area Name |  |  |
| textString | string Area String | string Area String |  |  |

##### 6. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Current Selection | string Current Selection | Variable |  |
| stringValue | "WATERWAYS" | "WATERWAYS" | TextArea |  |
| everyFrame | false | false |  |  |

##### 7. SetVector3Value

Full Name: HutongGames.PlayMaker.Actions.SetVector3Value
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable | Vector3 Zoom To Pos | Vector3 Zoom To Pos | Variable |  |
| vector3Value | Vector3(-7.39, 6.06, -22) | Vector3(-7.39, 6.06, -22) |  |  |
| everyFrame | false | false |  |  |

##### 8. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Zoom Shortcut | bool Zoom Shortcut | Variable |  |
| isTrue | Event(MAP ZOOM) | Event(MAP ZOOM) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

### Fog Canyon

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
| boolName | "mapFogCanyon" | "mapFogCanyon" |  |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(TOWN) | Event(TOWN) |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:FSM Owner | EventTarget(GameObject)[SendToChildren]:FSM Owner |  |  |
| sendEvent | "UNSELECT" | "UNSELECT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:Fog Canyon | EventTarget(GameObject)[SendToChildren]:Fog Canyon |  |  |
| sendEvent | "SELECT" | "SELECT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 4. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "UI" | "UI" |  |  |
| convName | "MAP_NAME_FOG_CANYON" | "MAP_NAME_FOG_CANYON" |  |  |
| storeValue | string Area String | string Area String | Variable |  |

##### 5. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Area Name | OwnerDefault Area Name |  |  |
| textString | string Area String | string Area String |  |  |

##### 6. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Current Selection | string Current Selection | Variable |  |
| stringValue | "FOG_CANYON" | "FOG_CANYON" | TextArea |  |
| everyFrame | false | false |  |  |

##### 7. SetVector3Value

Full Name: HutongGames.PlayMaker.Actions.SetVector3Value
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable | Vector3 Zoom To Pos | Vector3 Zoom To Pos | Variable |  |
| vector3Value | Vector3(7.13, -3.49, -22) | Vector3(7.13, -3.49, -22) |  |  |
| everyFrame | false | false |  |  |

##### 8. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Zoom Shortcut | bool Zoom Shortcut | Variable |  |
| isTrue | Event(MAP ZOOM) | Event(MAP ZOOM) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

### Pane Reset

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:FSM Owner | EventTarget(GameObject)[SendToChildren]:FSM Owner |  |  |
| sendEvent | "UNSELECT" | "UNSELECT" |  |  |
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

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Marker Action | OwnerDefault Marker Action |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

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
| eventTarget | EventTarget(GameObject):Cursor | EventTarget(GameObject):Cursor |  |  |
| sendEvent | "DOWN" | "DOWN" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Disable Zoom | bool Disable Zoom | Variable |  |
| boolValue | false | false |  |  |
| everyFrame | false | false |  |  |

### Activate

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
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 2. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Marker Action | OwnerDefault Marker Action |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 3. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "UI" | "UI" |  |  |
| convName | "CTRL_ZOOM_IN" | "CTRL_ZOOM_IN" |  |  |
| storeValue | string Confirm Text Str | string Confirm Text Str | Variable |  |

##### 4. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Confirm Text | OwnerDefault Confirm Text |  |  |
| textString | string Confirm Text Str | string Confirm Text Str |  |  |

##### 5. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| behaviour | "GameManager" | "GameManager" | Behaviour |  |
| methodName | "GetCurrentMapZone" | "GetCurrentMapZone" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var Current Area =  | Var Current Area =  | Variable | Store Result |

##### 6. SetFsmGameObject

Full Name: HutongGames.PlayMaker.Actions.SetFsmGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Update Cursor" | "Update Cursor" | FsmName |  |
| variableName | "Item" | "Item" | FsmGameObject |  |
| setValue | GameObject Self | GameObject Self |  |  |
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

##### 8. SetPosition

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

##### 9. PlayerDataBoolAllTrue

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolAllTrue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| stringVariables | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| trueEvent | Event() | Event() |  |  |
| falseEvent | Event() | Event() |  |  |
| storeResult | bool Display Hive | bool Display Hive | Variable |  |
| everyFrame | false | false |  |  |

##### 10. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | string Current Area | string Current Area |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### GP Up

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
| boolName | "mapCliffs" | "mapCliffs" |  |  |
| isTrue | Event(CLIFFS) | Event(CLIFFS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 2. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | Event(TOWN) | Event(TOWN) |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### GP Down

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
| boolName | "mapFogCanyon" | "mapFogCanyon" |  |  |
| isTrue | Event(FOG_CANYON) | Event(FOG_CANYON) |  |  |
| isFalse | Event() | Event() |  |  |

##### 2. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapRoyalGardens" | "mapRoyalGardens" |  |  |
| isTrue | Event(ROYAL_GARDENS) | Event(ROYAL_GARDENS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 3. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapFungalWastes" | "mapFungalWastes" |  |  |
| isTrue | Event(WASTES) | Event(WASTES) |  |  |
| isFalse | Event() | Event() |  |  |

##### 4. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapDeepnest" | "mapDeepnest" |  |  |
| isTrue | Event(DEEPNEST) | Event(DEEPNEST) |  |  |
| isFalse | Event() | Event() |  |  |

##### 5. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapCity" | "mapCity" |  |  |
| isTrue | Event(CITY) | Event(CITY) |  |  |
| isFalse | Event() | Event() |  |  |

##### 6. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapWaterways" | "mapWaterways" |  |  |
| isTrue | Event(WATERWAYS) | Event(WATERWAYS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 7. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapAbyss" | "mapAbyss" |  |  |
| isTrue | Event(ABYSS) | Event(ABYSS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 8. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapOutskirts" | "mapOutskirts" |  |  |
| isTrue | Event(OUTSKIRTS) | Event(OUTSKIRTS) |  |  |
| isFalse | Event() | Event() |  |  |

### GP Right

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
| boolName | "mapCrossroads" | "mapCrossroads" |  |  |
| isTrue | Event(CROSSROADS) | Event(CROSSROADS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 2. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | Event(TOWN) | Event(TOWN) |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### CR Left

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
| boolName | "mapGreenpath" | "mapGreenpath" |  |  |
| isTrue | Event(GREEN_PATH) | Event(GREEN_PATH) |  |  |
| isFalse | Event() | Event() |  |  |

##### 2. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapFogCanyon" | "mapFogCanyon" |  |  |
| isTrue | Event(FOG_CANYON) | Event(FOG_CANYON) |  |  |
| isFalse | Event() | Event() |  |  |

##### 3. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapCliffs" | "mapCliffs" |  |  |
| isTrue | Event(CLIFFS) | Event(CLIFFS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 4. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapRoyalGardens" | "mapRoyalGardens" |  |  |
| isTrue | Event(ROYAL_GARDENS) | Event(ROYAL_GARDENS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 5. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapFungalWastes" | "mapFungalWastes" |  |  |
| isTrue | Event(WASTES) | Event(WASTES) |  |  |
| isFalse | Event() | Event() |  |  |

##### 6. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapDeepnest" | "mapDeepnest" |  |  |
| isTrue | Event(DEEPNEST) | Event(DEEPNEST) |  |  |
| isFalse | Event() | Event() |  |  |

##### 7. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | Event(ARROW L) | Event(ARROW L) |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### CR Up

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | Event(TOWN) | Event(TOWN) |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### CR Right

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
| boolName | "mapRestingGrounds" | "mapRestingGrounds" |  |  |
| isTrue | Event(RESTING_GROUNDS) | Event(RESTING_GROUNDS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 2. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapMines" | "mapMines" |  |  |
| isTrue | Event(MINES) | Event(MINES) |  |  |
| isFalse | Event() | Event() |  |  |

##### 3. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapCity" | "mapCity" |  |  |
| isTrue | Event(CITY) | Event(CITY) |  |  |
| isFalse | Event() | Event() |  |  |

##### 4. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapOutskirts" | "mapOutskirts" |  |  |
| isTrue | Event(OUTSKIRTS) | Event(OUTSKIRTS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 5. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapWaterways" | "mapWaterways" |  |  |
| isTrue | Event(WATERWAYS) | Event(WATERWAYS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 6. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | Event(ARROW R) | Event(ARROW R) |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### CR Down

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
| boolName | "mapCity" | "mapCity" |  |  |
| isTrue | Event(CITY) | Event(CITY) |  |  |
| isFalse | Event() | Event() |  |  |

##### 2. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapFungalWastes" | "mapFungalWastes" |  |  |
| isTrue | Event(WASTES) | Event(WASTES) |  |  |
| isFalse | Event() | Event() |  |  |

##### 3. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapWaterways" | "mapWaterways" |  |  |
| isTrue | Event(WATERWAYS) | Event(WATERWAYS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 4. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapAbyss" | "mapAbyss" |  |  |
| isTrue | Event(ABYSS) | Event(ABYSS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 5. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapDeepnest" | "mapDeepnest" |  |  |
| isTrue | Event(DEEPNEST) | Event(DEEPNEST) |  |  |
| isFalse | Event() | Event() |  |  |

##### 6. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapOutskirts" | "mapOutskirts" |  |  |
| isTrue | Event(OUTSKIRTS) | Event(OUTSKIRTS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 7. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapFogCanyon" | "mapFogCanyon" |  |  |
| isTrue | Event(FOG_CANYON) | Event(FOG_CANYON) |  |  |
| isFalse | Event() | Event() |  |  |

### T Down

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
| boolName | "mapCrossroads" | "mapCrossroads" |  |  |
| isTrue | Event(CROSSROADS) | Event(CROSSROADS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 2. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapFogCanyon" | "mapFogCanyon" |  |  |
| isTrue | Event(FOG_CANYON) | Event(FOG_CANYON) |  |  |
| isFalse | Event() | Event() |  |  |

##### 3. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapFungalWastes" | "mapFungalWastes" |  |  |
| isTrue | Event(WASTES) | Event(WASTES) |  |  |
| isFalse | Event() | Event() |  |  |

##### 4. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapCity" | "mapCity" |  |  |
| isTrue | Event(CITY) | Event(CITY) |  |  |
| isFalse | Event() | Event() |  |  |

##### 5. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapWaterways" | "mapWaterways" |  |  |
| isTrue | Event(WATERWAYS) | Event(WATERWAYS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 6. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapAbyss" | "mapAbyss" |  |  |
| isTrue | Event(ABYSS) | Event(ABYSS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 7. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapRestingGrounds" | "mapRestingGrounds" |  |  |
| isTrue | Event(RESTING_GROUNDS) | Event(RESTING_GROUNDS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 8. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapOutskirts" | "mapOutskirts" |  |  |
| isTrue | Event(OUTSKIRTS) | Event(OUTSKIRTS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 9. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapDeepnest" | "mapDeepnest" |  |  |
| isTrue | Event(DEEPNEST) | Event(DEEPNEST) |  |  |
| isFalse | Event() | Event() |  |  |

##### 10. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapGreenpath" | "mapGreenpath" |  |  |
| isTrue | Event(GREEN_PATH) | Event(GREEN_PATH) |  |  |
| isFalse | Event() | Event() |  |  |

### T Right

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
| boolName | "mapMines" | "mapMines" |  |  |
| isTrue | Event(MINES) | Event(MINES) |  |  |
| isFalse | Event() | Event() |  |  |

##### 2. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapRestingGrounds" | "mapRestingGrounds" |  |  |
| isTrue | Event(RESTING_GROUNDS) | Event(RESTING_GROUNDS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 3. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapCity" | "mapCity" |  |  |
| isTrue | Event(CITY) | Event(CITY) |  |  |
| isFalse | Event() | Event() |  |  |

##### 4. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapOutskirts" | "mapOutskirts" |  |  |
| isTrue | Event(OUTSKIRTS) | Event(OUTSKIRTS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 5. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapAbyss" | "mapAbyss" |  |  |
| isTrue | Event(ABYSS) | Event(ABYSS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 6. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | Event(ARROW R) | Event(ARROW R) |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

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

### Arrow L

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Arrow L | OwnerDefault Arrow L |  |  |
| vector | Vector3 Arrow Pos | Vector3 Arrow Pos | Variable |  |
| x | 0f | 0f | Variable |  |
| y | 0f | 0f | Variable |  |
| z | 0f | 0f | Variable |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |

##### 2. Vector3AddXYZ

Full Name: HutongGames.PlayMaker.Actions.Vector3AddXYZ
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable | Vector3 Arrow Pos | Vector3 Arrow Pos | Variable |  |
| addX | 0.01f | 0.01f |  |  |
| addY | 0f | 0f |  |  |
| addZ | 0f | 0f |  |  |
| everyFrame | false | false |  |  |
| perSecond | false | false |  |  |

##### 3. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Cursor | OwnerDefault Cursor |  |  |
| vector | Vector3 Arrow Pos | Vector3 Arrow Pos | Variable |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 4. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:FSM Owner | EventTarget(GameObject)[SendToChildren]:FSM Owner |  |  |
| sendEvent | "UNSELECT" | "UNSELECT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 5. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Cursor | EventTarget(GameObject):Cursor |  |  |
| sendEvent | "DOWN" | "DOWN" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 6. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Cursor | EventTarget(GameObject):Cursor |  |  |
| sendEvent | "CURSOR ACTIVATE" | "CURSOR ACTIVATE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 7. SetFsmGameObject

Full Name: HutongGames.PlayMaker.Actions.SetFsmGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Update Cursor" | "Update Cursor" | FsmName |  |
| variableName | "Item" | "Item" | FsmGameObject |  |
| setValue | GameObject Arrow L | GameObject Arrow L |  |  |
| everyFrame | false | false |  |  |

##### 8. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "UPDATE CURSOR" | "UPDATE CURSOR" |  |  |
| delay | 0.01f | 0.01f |  |  |
| everyFrame | false | false |  |  |

### GP Left

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | Event(ARROW L) | Event(ARROW L) |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### To Map

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

##### 2. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapRoyalGardens" | "mapRoyalGardens" |  |  |
| isTrue | Event(ROYAL_GARDENS) | Event(ROYAL_GARDENS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 3. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapGreenpath" | "mapGreenpath" |  |  |
| isTrue | Event(GREEN_PATH) | Event(GREEN_PATH) |  |  |
| isFalse | Event() | Event() |  |  |

##### 4. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapDeepnest" | "mapDeepnest" |  |  |
| isTrue | Event(DEEPNEST) | Event(DEEPNEST) |  |  |
| isFalse | Event() | Event() |  |  |

##### 5. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapFogCanyon" | "mapFogCanyon" |  |  |
| isTrue | Event(FOG_CANYON) | Event(FOG_CANYON) |  |  |
| isFalse | Event() | Event() |  |  |

##### 6. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapCliffs" | "mapCliffs" |  |  |
| isTrue | Event(CLIFFS) | Event(CLIFFS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 7. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapFungalWastes" | "mapFungalWastes" |  |  |
| isTrue | Event(WASTES) | Event(WASTES) |  |  |
| isFalse | Event() | Event() |  |  |

##### 8. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | Event(TOWN) | Event(TOWN) |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 9. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapCrossroads" | "mapCrossroads" |  |  |
| isTrue | Event(CROSSROADS) | Event(CROSSROADS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 10. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapWaterways" | "mapWaterways" |  |  |
| isTrue | Event(WATERWAYS) | Event(WATERWAYS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 11. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapCity" | "mapCity" |  |  |
| isTrue | Event(CITY) | Event(CITY) |  |  |
| isFalse | Event() | Event() |  |  |

##### 12. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapMines" | "mapMines" |  |  |
| isTrue | Event(MINES) | Event(MINES) |  |  |
| isFalse | Event() | Event() |  |  |

##### 13. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapRestingGrounds" | "mapRestingGrounds" |  |  |
| isTrue | Event(RESTING_GROUNDS) | Event(RESTING_GROUNDS) |  |  |
| isFalse | Event() | Event() |  |  |

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

### Arrow R

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Arrow R | OwnerDefault Arrow R |  |  |
| vector | Vector3 Arrow Pos | Vector3 Arrow Pos | Variable |  |
| x | 0f | 0f | Variable |  |
| y | 0f | 0f | Variable |  |
| z | 0f | 0f | Variable |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |

##### 2. Vector3AddXYZ

Full Name: HutongGames.PlayMaker.Actions.Vector3AddXYZ
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable | Vector3 Arrow Pos | Vector3 Arrow Pos | Variable |  |
| addX | 0.01f | 0.01f |  |  |
| addY | 0f | 0f |  |  |
| addZ | 0f | 0f |  |  |
| everyFrame | false | false |  |  |
| perSecond | false | false |  |  |

##### 3. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Cursor | OwnerDefault Cursor |  |  |
| vector | Vector3 Arrow Pos | Vector3 Arrow Pos | Variable |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 4. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:FSM Owner | EventTarget(GameObject)[SendToChildren]:FSM Owner |  |  |
| sendEvent | "UNSELECT" | "UNSELECT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 5. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Cursor | EventTarget(GameObject):Cursor |  |  |
| sendEvent | "DOWN" | "DOWN" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 6. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Cursor | EventTarget(GameObject):Cursor |  |  |
| sendEvent | "CURSOR ACTIVATE" | "CURSOR ACTIVATE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 7. SetFsmGameObject

Full Name: HutongGames.PlayMaker.Actions.SetFsmGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Update Cursor" | "Update Cursor" | FsmName |  |
| variableName | "Item" | "Item" | FsmGameObject |  |
| setValue | GameObject Arrow R | GameObject Arrow R |  |  |
| everyFrame | false | false |  |  |

##### 8. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "UPDATE CURSOR" | "UPDATE CURSOR" |  |  |
| delay | 0.01f | 0.01f |  |  |
| everyFrame | false | false |  |  |

### To Map 2

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

##### 2. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapOutskirts" | "mapOutskirts" |  |  |
| isTrue | Event(OUTSKIRTS) | Event(OUTSKIRTS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 3. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapRestingGrounds" | "mapRestingGrounds" |  |  |
| isTrue | Event(RESTING_GROUNDS) | Event(RESTING_GROUNDS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 4. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapCity" | "mapCity" |  |  |
| isTrue | Event(CITY) | Event(CITY) |  |  |
| isFalse | Event() | Event() |  |  |

##### 5. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapMines" | "mapMines" |  |  |
| isTrue | Event(MINES) | Event(MINES) |  |  |
| isFalse | Event() | Event() |  |  |

##### 6. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapWaterways" | "mapWaterways" |  |  |
| isTrue | Event(WATERWAYS) | Event(WATERWAYS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 7. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapAbyss" | "mapAbyss" |  |  |
| isTrue | Event(ABYSS) | Event(ABYSS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 8. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapCrossroads" | "mapCrossroads" |  |  |
| isTrue | Event(CROSSROADS) | Event(CROSSROADS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 9. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | Event(TOWN) | Event(TOWN) |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### T Left

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
| boolName | "mapCliffs" | "mapCliffs" |  |  |
| isTrue | Event(CLIFFS) | Event(CLIFFS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 2. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapGreenpath" | "mapGreenpath" |  |  |
| isTrue | Event(GREEN_PATH) | Event(GREEN_PATH) |  |  |
| isFalse | Event() | Event() |  |  |

##### 3. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapFogCanyon" | "mapFogCanyon" |  |  |
| isTrue | Event(FOG_CANYON) | Event(FOG_CANYON) |  |  |
| isFalse | Event() | Event() |  |  |

##### 4. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapRoyalGardens" | "mapRoyalGardens" |  |  |
| isTrue | Event(ROYAL_GARDENS) | Event(ROYAL_GARDENS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 5. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapDeepnest" | "mapDeepnest" |  |  |
| isTrue | Event(DEEPNEST) | Event(DEEPNEST) |  |  |
| isFalse | Event() | Event() |  |  |

##### 6. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | Event(ARROW L) | Event(ARROW L) |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Cl Right

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | Event(TOWN) | Event(TOWN) |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Cl Left

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | Event(ARROW L) | Event(ARROW L) |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Cl Down

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
| boolName | "mapGreenpath" | "mapGreenpath" |  |  |
| isTrue | Event(GREEN_PATH) | Event(GREEN_PATH) |  |  |
| isFalse | Event() | Event() |  |  |

##### 2. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapFogCanyon" | "mapFogCanyon" |  |  |
| isTrue | Event(FOG_CANYON) | Event(FOG_CANYON) |  |  |
| isFalse | Event() | Event() |  |  |

##### 3. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapFungalWastes" | "mapFungalWastes" |  |  |
| isTrue | Event(WASTES) | Event(WASTES) |  |  |
| isFalse | Event() | Event() |  |  |

##### 4. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapRoyalGardens" | "mapRoyalGardens" |  |  |
| isTrue | Event(ROYAL_GARDENS) | Event(ROYAL_GARDENS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 5. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapDeepnest" | "mapDeepnest" |  |  |
| isTrue | Event(DEEPNEST) | Event(DEEPNEST) |  |  |
| isFalse | Event() | Event() |  |  |

##### 6. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapCrossroads" | "mapCrossroads" |  |  |
| isTrue | Event(CROSSROADS) | Event(CROSSROADS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 7. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapCity" | "mapCity" |  |  |
| isTrue | Event(CITY) | Event(CITY) |  |  |
| isFalse | Event() | Event() |  |  |

##### 8. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapWaterways" | "mapWaterways" |  |  |
| isTrue | Event(WATERWAYS) | Event(WATERWAYS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 9. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "ABYSS" | "ABYSS" |  |  |
| isTrue | Event(ABYSS) | Event(ABYSS) |  |  |
| isFalse | Event() | Event() |  |  |

### Mi Right

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
| boolName | "mapOutskirts" | "mapOutskirts" |  |  |
| isTrue | Event(OUTSKIRTS) | Event(OUTSKIRTS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 2. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | Event(ARROW R) | Event(ARROW R) |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Mi Left

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | Event(TOWN) | Event(TOWN) |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Mi Down

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
| boolName | "mapRestingGrounds" | "mapRestingGrounds" |  |  |
| isTrue | Event(RESTING_GROUNDS) | Event(RESTING_GROUNDS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 2. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapCity" | "mapCity" |  |  |
| isTrue | Event(CITY) | Event(CITY) |  |  |
| isFalse | Event() | Event() |  |  |

##### 3. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapWaterways" | "mapWaterways" |  |  |
| isTrue | Event(WATERWAYS) | Event(WATERWAYS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 4. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapAbyss" | "mapAbyss" |  |  |
| isTrue | Event(ABYSS) | Event(ABYSS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 5. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapOutskirts" | "mapOutskirts" |  |  |
| isTrue | Event(OUTSKIRTS) | Event(OUTSKIRTS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 6. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapCrossroads" | "mapCrossroads" |  |  |
| isTrue | Event(CROSSROADS) | Event(CROSSROADS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 7. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapFungalWastes" | "mapFungalWastes" |  |  |
| isTrue | Event(WASTES) | Event(WASTES) |  |  |
| isFalse | Event() | Event() |  |  |

##### 8. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapDeepnest" | "mapDeepnest" |  |  |
| isTrue | Event(DEEPNEST) | Event(DEEPNEST) |  |  |
| isFalse | Event() | Event() |  |  |

### RG Up

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
| boolName | "mapMines" | "mapMines" |  |  |
| isTrue | Event(MINES) | Event(MINES) |  |  |
| isFalse | Event() | Event() |  |  |

##### 2. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | Event(TOWN) | Event(TOWN) |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### RG Right

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
| boolName | "mapOutskirts" | "mapOutskirts" |  |  |
| isTrue | Event(OUTSKIRTS) | Event(OUTSKIRTS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 2. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | Event(ARROW R) | Event(ARROW R) |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### RG Left

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
| boolName | "mapCrossroads" | "mapCrossroads" |  |  |
| isTrue | Event(CROSSROADS) | Event(CROSSROADS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 2. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapFungalWastes" | "mapFungalWastes" |  |  |
| isTrue | Event(WASTES) | Event(WASTES) |  |  |
| isFalse | Event() | Event() |  |  |

##### 3. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapFogCanyon" | "mapFogCanyon" |  |  |
| isTrue | Event(FOG_CANYON) | Event(FOG_CANYON) |  |  |
| isFalse | Event() | Event() |  |  |

##### 4. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapGreenpath" | "mapGreenpath" |  |  |
| isTrue | Event(GREEN_PATH) | Event(GREEN_PATH) |  |  |
| isFalse | Event() | Event() |  |  |

##### 5. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapRoyalGardens" | "mapRoyalGardens" |  |  |
| isTrue | Event(ROYAL_GARDENS) | Event(ROYAL_GARDENS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 6. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | Event(TOWN) | Event(TOWN) |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### RG Down

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
| boolName | "mapCity" | "mapCity" |  |  |
| isTrue | Event(CITY) | Event(CITY) |  |  |
| isFalse | Event() | Event() |  |  |

##### 2. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapOutskirts" | "mapOutskirts" |  |  |
| isTrue | Event(OUTSKIRTS) | Event(OUTSKIRTS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 3. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapWaterways" | "mapWaterways" |  |  |
| isTrue | Event(WATERWAYS) | Event(WATERWAYS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 4. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapAbyss" | "mapAbyss" |  |  |
| isTrue | Event(ABYSS) | Event(ABYSS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 5. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapFungalWastes" | "mapFungalWastes" |  |  |
| isTrue | Event(WASTES) | Event(WASTES) |  |  |
| isFalse | Event() | Event() |  |  |

##### 6. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapDeepnest" | "mapDeepnest" |  |  |
| isTrue | Event(DEEPNEST) | Event(DEEPNEST) |  |  |
| isFalse | Event() | Event() |  |  |

### FG Up

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
| boolName | "mapGreenpath" | "mapGreenpath" |  |  |
| isTrue | Event(GREEN_PATH) | Event(GREEN_PATH) |  |  |
| isFalse | Event() | Event() |  |  |

##### 2. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapCliffs" | "mapCliffs" |  |  |
| isTrue | Event(CLIFFS) | Event(CLIFFS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 3. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapCrossroads" | "mapCrossroads" |  |  |
| isTrue | Event(CROSSROADS) | Event(CROSSROADS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 4. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | Event(TOWN) | Event(TOWN) |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### FG Left

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
| boolName | "mapRoyalGardens" | "mapRoyalGardens" |  |  |
| isTrue | Event(ROYAL_GARDENS) | Event(ROYAL_GARDENS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 2. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | Event(ARROW L) | Event(ARROW L) |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### FG Down

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
| boolName | "mapFungalWastes" | "mapFungalWastes" |  |  |
| isTrue | Event(WASTES) | Event(WASTES) |  |  |
| isFalse | Event() | Event() |  |  |

##### 2. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapDeepnest" | "mapDeepnest" |  |  |
| isTrue | Event(DEEPNEST) | Event(DEEPNEST) |  |  |
| isFalse | Event() | Event() |  |  |

##### 3. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapWaterways" | "mapWaterways" |  |  |
| isTrue | Event(WATERWAYS) | Event(WATERWAYS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 4. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapAbyss" | "mapAbyss" |  |  |
| isTrue | Event(ABYSS) | Event(ABYSS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 5. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapOutskirts" | "mapOutskirts" |  |  |
| isTrue | Event(OUTSKIRTS) | Event(OUTSKIRTS) |  |  |
| isFalse | Event() | Event() |  |  |

### FW Up

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
| boolName | "mapFogCanyon" | "mapFogCanyon" |  |  |
| isTrue | Event(FOG_CANYON) | Event(FOG_CANYON) |  |  |
| isFalse | Event() | Event() |  |  |

##### 2. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapCrossroads" | "mapCrossroads" |  |  |
| isTrue | Event(CROSSROADS) | Event(CROSSROADS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 3. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapGreenpath" | "mapGreenpath" |  |  |
| isTrue | Event(GREEN_PATH) | Event(GREEN_PATH) |  |  |
| isFalse | Event() | Event() |  |  |

##### 4. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | Event(TOWN) | Event(TOWN) |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### FW Left

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
| boolName | "mapFogCanyon" | "mapFogCanyon" |  |  |
| isTrue | Event(FOG_CANYON) | Event(FOG_CANYON) |  |  |
| isFalse | Event() | Event() |  |  |

##### 2. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapRoyalGardens" | "mapRoyalGardens" |  |  |
| isTrue | Event(ROYAL_GARDENS) | Event(ROYAL_GARDENS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 3. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapDeepnest" | "mapDeepnest" |  |  |
| isTrue | Event(DEEPNEST) | Event(DEEPNEST) |  |  |
| isFalse | Event() | Event() |  |  |

##### 4. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapGreenpath" | "mapGreenpath" |  |  |
| isTrue | Event(GREEN_PATH) | Event(GREEN_PATH) |  |  |
| isFalse | Event() | Event() |  |  |

##### 5. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | Event(ARROW L) | Event(ARROW L) |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### FW Down

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
| boolName | "mapDeepnest" | "mapDeepnest" |  |  |
| isTrue | Event(DEEPNEST) | Event(DEEPNEST) |  |  |
| isFalse | Event() | Event() |  |  |

##### 2. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapWaterways" | "mapWaterways" |  |  |
| isTrue | Event(WATERWAYS) | Event(WATERWAYS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 3. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapAbyss" | "mapAbyss" |  |  |
| isTrue | Event(ABYSS) | Event(ABYSS) |  |  |
| isFalse | Event() | Event() |  |  |

### D Left

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | Event(ARROW L) | Event(ARROW L) |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### D Up

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
| boolName | "mapRoyalGardens" | "mapRoyalGardens" |  |  |
| isTrue | Event(ROYAL_GARDENS) | Event(ROYAL_GARDENS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 2. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapFungalWastes" | "mapFungalWastes" |  |  |
| isTrue | Event(WASTES) | Event(WASTES) |  |  |
| isFalse | Event() | Event() |  |  |

##### 3. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapFogCanyon" | "mapFogCanyon" |  |  |
| isTrue | Event(FOG_CANYON) | Event(FOG_CANYON) |  |  |
| isFalse | Event() | Event() |  |  |

##### 4. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapGreenpath" | "mapGreenpath" |  |  |
| isTrue | Event(GREEN_PATH) | Event(GREEN_PATH) |  |  |
| isFalse | Event() | Event() |  |  |

##### 5. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapCliffs" | "mapCliffs" |  |  |
| isTrue | Event(CLIFFS) | Event(CLIFFS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 6. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapCrossroads" | "mapCrossroads" |  |  |
| isTrue | Event(CROSSROADS) | Event(CROSSROADS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 7. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | Event(TOWN) | Event(TOWN) |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### FW Right

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
| boolName | "mapCity" | "mapCity" |  |  |
| isTrue | Event(CITY) | Event(CITY) |  |  |
| isFalse | Event() | Event() |  |  |

##### 2. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapWaterways" | "mapWaterways" |  |  |
| isTrue | Event(WATERWAYS) | Event(WATERWAYS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 3. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapOutskirts" | "mapOutskirts" |  |  |
| isTrue | Event(OUTSKIRTS) | Event(OUTSKIRTS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 4. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapRestingGrounds" | "mapRestingGrounds" |  |  |
| isTrue | Event(RESTING_GROUNDS) | Event(RESTING_GROUNDS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 5. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapMines" | "mapMines" |  |  |
| isTrue | Event(MINES) | Event(MINES) |  |  |
| isFalse | Event() | Event() |  |  |

##### 6. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | Event(ARROW R) | Event(ARROW R) |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### FG Right

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
| boolName | "mapFungalWastes" | "mapFungalWastes" |  |  |
| isTrue | Event(WASTES) | Event(WASTES) |  |  |
| isFalse | Event() | Event() |  |  |

##### 2. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapCrossroads" | "mapCrossroads" |  |  |
| isTrue | Event(CROSSROADS) | Event(CROSSROADS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 3. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapCity" | "mapCity" |  |  |
| isTrue | Event(CITY) | Event(CITY) |  |  |
| isFalse | Event() | Event() |  |  |

##### 4. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapWaterways" | "mapWaterways" |  |  |
| isTrue | Event(WATERWAYS) | Event(WATERWAYS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 5. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapRestingGrounds" | "mapRestingGrounds" |  |  |
| isTrue | Event(RESTING_GROUNDS) | Event(RESTING_GROUNDS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 6. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapOutskirts" | "mapOutskirts" |  |  |
| isTrue | Event(OUTSKIRTS) | Event(OUTSKIRTS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 7. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | Event(ARROW R) | Event(ARROW R) |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### D Right

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
| boolName | "mapWaterways" | "mapWaterways" |  |  |
| isTrue | Event(WATERWAYS) | Event(WATERWAYS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 2. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapAbyss" | "mapAbyss" |  |  |
| isTrue | Event(ABYSS) | Event(ABYSS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 3. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapOutskirts" | "mapOutskirts" |  |  |
| isTrue | Event(OUTSKIRTS) | Event(OUTSKIRTS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 4. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapFungalWastes" | "mapFungalWastes" |  |  |
| isTrue | Event(WASTES) | Event(WASTES) |  |  |
| isFalse | Event() | Event() |  |  |

##### 5. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapCity" | "mapCity" |  |  |
| isTrue | Event(CITY) | Event(CITY) |  |  |
| isFalse | Event() | Event() |  |  |

##### 6. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapCrossroads" | "mapCrossroads" |  |  |
| isTrue | Event(CROSSROADS) | Event(CROSSROADS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 7. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapRestingGrounds" | "mapRestingGrounds" |  |  |
| isTrue | Event(RESTING_GROUNDS) | Event(RESTING_GROUNDS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 8. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapMines" | "mapMines" |  |  |
| isTrue | Event(MINES) | Event(MINES) |  |  |
| isFalse | Event() | Event() |  |  |

##### 9. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | Event(ARROW R) | Event(ARROW R) |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### C Up

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
| boolName | "mapCrossroads" | "mapCrossroads" |  |  |
| isTrue | Event(CROSSROADS) | Event(CROSSROADS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 2. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapRestingGrounds" | "mapRestingGrounds" |  |  |
| isTrue | Event(RESTING_GROUNDS) | Event(RESTING_GROUNDS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 3. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapMines" | "mapMines" |  |  |
| isTrue | Event(MINES) | Event(MINES) |  |  |
| isFalse | Event() | Event() |  |  |

##### 4. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | Event(TOWN) | Event(TOWN) |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### C Left

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
| boolName | "mapFungalWastes" | "mapFungalWastes" |  |  |
| isTrue | Event(WASTES) | Event(WASTES) |  |  |
| isFalse | Event() | Event() |  |  |

##### 2. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapFogCanyon" | "mapFogCanyon" |  |  |
| isTrue | Event(FOG_CANYON) | Event(FOG_CANYON) |  |  |
| isFalse | Event() | Event() |  |  |

##### 3. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapRoyalGardens" | "mapRoyalGardens" |  |  |
| isTrue | Event(ROYAL_GARDENS) | Event(ROYAL_GARDENS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 4. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapDeepnest" | "mapDeepnest" |  |  |
| isTrue | Event(DEEPNEST) | Event(DEEPNEST) |  |  |
| isFalse | Event() | Event() |  |  |

##### 5. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapGreenpath" | "mapGreenpath" |  |  |
| isTrue | Event(GREEN_PATH) | Event(GREEN_PATH) |  |  |
| isFalse | Event() | Event() |  |  |

##### 6. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapCliffs" | "mapCliffs" |  |  |
| isTrue | Event(CLIFFS) | Event(CLIFFS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 7. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | Event(ARROW L) | Event(ARROW L) |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### C Down

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
| boolName | "mapWaterways" | "mapWaterways" |  |  |
| isTrue | Event(WATERWAYS) | Event(WATERWAYS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 2. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapAbyss" | "mapAbyss" |  |  |
| isTrue | Event(ABYSS) | Event(ABYSS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 3. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapOutskirts" | "mapOutskirts" |  |  |
| isTrue | Event(OUTSKIRTS) | Event(OUTSKIRTS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 4. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapDeepnest" | "mapDeepnest" |  |  |
| isTrue | Event(DEEPNEST) | Event(DEEPNEST) |  |  |
| isFalse | Event() | Event() |  |  |

### C Right

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
| boolName | "mapOutskirts" | "mapOutskirts" |  |  |
| isTrue | Event(OUTSKIRTS) | Event(OUTSKIRTS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 2. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | Event(ARROW R) | Event(ARROW R) |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Wat Up

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
| boolName | "mapCity" | "mapCity" |  |  |
| isTrue | Event(CITY) | Event(CITY) |  |  |
| isFalse | Event() | Event() |  |  |

##### 2. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapRestingGrounds" | "mapRestingGrounds" |  |  |
| isTrue | Event(RESTING_GROUNDS) | Event(RESTING_GROUNDS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 3. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapCrossroads" | "mapCrossroads" |  |  |
| isTrue | Event(CROSSROADS) | Event(CROSSROADS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 4. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapMines" | "mapMines" |  |  |
| isTrue | Event(MINES) | Event(MINES) |  |  |
| isFalse | Event() | Event() |  |  |

##### 5. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | Event(TOWN) | Event(TOWN) |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Wat Left

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
| boolName | "mapDeepnest" | "mapDeepnest" |  |  |
| isTrue | Event(DEEPNEST) | Event(DEEPNEST) |  |  |
| isFalse | Event() | Event() |  |  |

##### 2. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapFungalWastes" | "mapFungalWastes" |  |  |
| isTrue | Event(WASTES) | Event(WASTES) |  |  |
| isFalse | Event() | Event() |  |  |

##### 3. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapFogCanyon" | "mapFogCanyon" |  |  |
| isTrue | Event(FOG_CANYON) | Event(FOG_CANYON) |  |  |
| isFalse | Event() | Event() |  |  |

##### 4. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapRoyalGardens" | "mapRoyalGardens" |  |  |
| isTrue | Event(ROYAL_GARDENS) | Event(ROYAL_GARDENS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 5. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapGreenpath" | "mapGreenpath" |  |  |
| isTrue | Event(GREEN_PATH) | Event(GREEN_PATH) |  |  |
| isFalse | Event() | Event() |  |  |

##### 6. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | Event(ARROW L) | Event(ARROW L) |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Wat Right

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
| boolName | "mapOutskirts" | "mapOutskirts" |  |  |
| isTrue | Event(OUTSKIRTS) | Event(OUTSKIRTS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 2. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | Event(ARROW R) | Event(ARROW R) |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Royal Gardens

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
| boolName | "mapRoyalGardens" | "mapRoyalGardens" |  |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(TOWN) | Event(TOWN) |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:FSM Owner | EventTarget(GameObject)[SendToChildren]:FSM Owner |  |  |
| sendEvent | "UNSELECT" | "UNSELECT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:Royal Gardens | EventTarget(GameObject)[SendToChildren]:Royal Gardens |  |  |
| sendEvent | "SELECT" | "SELECT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 4. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "UI" | "UI" |  |  |
| convName | "MAP_NAME_ROYAL_GARDENS" | "MAP_NAME_ROYAL_GARDENS" |  |  |
| storeValue | string Area String | string Area String | Variable |  |

##### 5. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Area Name | OwnerDefault Area Name |  |  |
| textString | string Area String | string Area String |  |  |

##### 6. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Current Selection | string Current Selection | Variable |  |
| stringValue | "ROYAL_GARDENS" | "ROYAL_GARDENS" | TextArea |  |
| everyFrame | false | false |  |  |

##### 7. SetVector3Value

Full Name: HutongGames.PlayMaker.Actions.SetVector3Value
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable | Vector3 Zoom To Pos | Vector3 Zoom To Pos | Variable |  |
| vector3Value | Vector3(17.3, -0.73, -22) | Vector3(17.3, -0.73, -22) |  |  |
| everyFrame | false | false |  |  |

##### 8. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Zoom Shortcut | bool Zoom Shortcut | Variable |  |
| isTrue | Event(MAP ZOOM) | Event(MAP ZOOM) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

### QG Up

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
| boolName | "mapGreenpath" | "mapGreenpath" |  |  |
| isTrue | Event(GREEN_PATH) | Event(GREEN_PATH) |  |  |
| isFalse | Event() | Event() |  |  |

##### 2. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapCliffs" | "mapCliffs" |  |  |
| isTrue | Event(CLIFFS) | Event(CLIFFS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 3. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | Event(TOWN) | Event(TOWN) |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### QG Left

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | Event(ARROW L) | Event(ARROW L) |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### QG Down

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
| boolName | "mapDeepnest" | "mapDeepnest" |  |  |
| isTrue | Event(DEEPNEST) | Event(DEEPNEST) |  |  |
| isFalse | Event() | Event() |  |  |

##### 2. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapWaterways" | "mapWaterways" |  |  |
| isTrue | Event(WATERWAYS) | Event(WATERWAYS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 3. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapAbyss" | "mapAbyss" |  |  |
| isTrue | Event(ABYSS) | Event(ABYSS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 4. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapOutskirts" | "mapOutskirts" |  |  |
| isTrue | Event(OUTSKIRTS) | Event(OUTSKIRTS) |  |  |
| isFalse | Event() | Event() |  |  |

### QG Right

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
| boolName | "mapFogCanyon" | "mapFogCanyon" |  |  |
| isTrue | Event(FOG_CANYON) | Event(FOG_CANYON) |  |  |
| isFalse | Event() | Event() |  |  |

##### 2. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapFungalWastes" | "mapFungalWastes" |  |  |
| isTrue | Event(WASTES) | Event(WASTES) |  |  |
| isFalse | Event() | Event() |  |  |

##### 3. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapCrossroads" | "mapCrossroads" |  |  |
| isTrue | Event(CROSSROADS) | Event(CROSSROADS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 4. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapCity" | "mapCity" |  |  |
| isTrue | Event(CITY) | Event(CITY) |  |  |
| isFalse | Event() | Event() |  |  |

##### 5. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapWaterways" | "mapWaterways" |  |  |
| isTrue | Event(WATERWAYS) | Event(WATERWAYS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 6. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapRestingGrounds" | "mapRestingGrounds" |  |  |
| isTrue | Event(RESTING_GROUNDS) | Event(RESTING_GROUNDS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 7. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapMines" | "mapMines" |  |  |
| isTrue | Event(MINES) | Event(MINES) |  |  |
| isFalse | Event() | Event() |  |  |

##### 8. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapOutskirts" | "mapOutskirts" |  |  |
| isTrue | Event(OUTSKIRTS) | Event(OUTSKIRTS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 9. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | Event(ARROW R) | Event(ARROW R) |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Wat Down

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
| boolName | "mapAbyss" | "mapAbyss" |  |  |
| isTrue | Event(ABYSS) | Event(ABYSS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 2. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapOutskirts" | "mapOutskirts" |  |  |
| isTrue | Event(OUTSKIRTS) | Event(OUTSKIRTS) |  |  |
| isFalse | Event() | Event() |  |  |

### Ancient Basin

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 4

#### Actions

##### 1. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapAbyss" | "mapAbyss" |  |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(TOWN) | Event(TOWN) |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:FSM Owner | EventTarget(GameObject)[SendToChildren]:FSM Owner |  |  |
| sendEvent | "UNSELECT" | "UNSELECT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:Ancient Basin | EventTarget(GameObject)[SendToChildren]:Ancient Basin |  |  |
| sendEvent | "SELECT" | "SELECT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 4. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "UI" | "UI" |  |  |
| convName | "MAP_NAME_ABYSS" | "MAP_NAME_ABYSS" |  |  |
| storeValue | string Area String | string Area String | Variable |  |

##### 5. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Area Name | OwnerDefault Area Name |  |  |
| textString | string Area String | string Area String |  |  |

##### 6. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Current Selection | string Current Selection | Variable |  |
| stringValue | "ABYSS" | "ABYSS" | TextArea |  |
| everyFrame | false | false |  |  |

##### 7. SetVector3Value

Full Name: HutongGames.PlayMaker.Actions.SetVector3Value
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable | Vector3 Zoom To Pos | Vector3 Zoom To Pos | Variable |  |
| vector3Value | Vector3(-7.64, 14.5, -22) | Vector3(-7.64, 14.5, -22) |  |  |
| everyFrame | false | false |  |  |

##### 8. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Zoom Shortcut | bool Zoom Shortcut | Variable |  |
| isTrue | Event(MAP ZOOM) | Event(MAP ZOOM) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

### Ab Up

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
| boolName | "mapWaterways" | "mapWaterways" |  |  |
| isTrue | Event(WATERWAYS) | Event(WATERWAYS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 2. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapCity" | "mapCity" |  |  |
| isTrue | Event(CITY) | Event(CITY) |  |  |
| isFalse | Event() | Event() |  |  |

##### 3. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapFungalWastes" | "mapFungalWastes" |  |  |
| isTrue | Event(WASTES) | Event(WASTES) |  |  |
| isFalse | Event() | Event() |  |  |

##### 4. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapCrossroads" | "mapCrossroads" |  |  |
| isTrue | Event(CROSSROADS) | Event(CROSSROADS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 5. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapRestingGrounds" | "mapRestingGrounds" |  |  |
| isTrue | Event(RESTING_GROUNDS) | Event(RESTING_GROUNDS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 6. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapMines" | "mapMines" |  |  |
| isTrue | Event(MINES) | Event(MINES) |  |  |
| isFalse | Event() | Event() |  |  |

##### 7. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | Event(TOWN) | Event(TOWN) |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Ab Left

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
| boolName | "mapDeepnest" | "mapDeepnest" |  |  |
| isTrue | Event(DEEPNEST) | Event(DEEPNEST) |  |  |
| isFalse | Event() | Event() |  |  |

##### 2. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapFungalWastes" | "mapFungalWastes" |  |  |
| isTrue | Event(WASTES) | Event(WASTES) |  |  |
| isFalse | Event() | Event() |  |  |

##### 3. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapFogCanyon" | "mapFogCanyon" |  |  |
| isTrue | Event(FOG_CANYON) | Event(FOG_CANYON) |  |  |
| isFalse | Event() | Event() |  |  |

##### 4. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapRoyalGardens" | "mapRoyalGardens" |  |  |
| isTrue | Event(ROYAL_GARDENS) | Event(ROYAL_GARDENS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 5. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapGreenpath" | "mapGreenpath" |  |  |
| isTrue | Event(GREEN_PATH) | Event(GREEN_PATH) |  |  |
| isFalse | Event() | Event() |  |  |

##### 6. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | Event(ARROW L) | Event(ARROW L) |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Ab Right

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
| boolName | "mapOutskirts" | "mapOutskirts" |  |  |
| isTrue | Event(OUTSKIRTS) | Event(OUTSKIRTS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 2. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | Event(ARROW R) | Event(ARROW R) |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Outskirts

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
| boolName | "mapOutskirts" | "mapOutskirts" |  |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(TOWN) | Event(TOWN) |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:FSM Owner | EventTarget(GameObject)[SendToChildren]:FSM Owner |  |  |
| sendEvent | "UNSELECT" | "UNSELECT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:Outskirts | EventTarget(GameObject)[SendToChildren]:Outskirts |  |  |
| sendEvent | "SELECT" | "SELECT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 4. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "UI" | "UI" |  |  |
| convName | "MAP_NAME_OUTSKIRTS" | "MAP_NAME_OUTSKIRTS" |  |  |
| storeValue | string Area String | string Area String | Variable |  |

##### 5. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Area Name | OwnerDefault Area Name |  |  |
| textString | string Area String | string Area String |  |  |

##### 6. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Current Selection | string Current Selection | Variable |  |
| stringValue | "OUTSKIRTS" | "OUTSKIRTS" | TextArea |  |
| everyFrame | false | false |  |  |

##### 7. SetVector3Value

Full Name: HutongGames.PlayMaker.Actions.SetVector3Value
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable | Vector3 Zoom To Pos | Vector3 Zoom To Pos | Variable |  |
| vector3Value | Vector3(-20.94, 4.51, -22) | Vector3(-20.94, 4.51, -22) |  |  |
| everyFrame | false | false |  |  |

##### 8. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Zoom Shortcut | bool Zoom Shortcut | Variable |  |
| isTrue | Event(MAP ZOOM) | Event(MAP ZOOM) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

### Out Up

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
| boolName | "mapRestingGrounds" | "mapRestingGrounds" |  |  |
| isTrue | Event(RESTING_GROUNDS) | Event(RESTING_GROUNDS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 2. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapMines" | "mapMines" |  |  |
| isTrue | Event(MINES) | Event(MINES) |  |  |
| isFalse | Event() | Event() |  |  |

##### 3. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapCrossroads" | "mapCrossroads" |  |  |
| isTrue | Event(CROSSROADS) | Event(CROSSROADS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 4. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | Event(TOWN) | Event(TOWN) |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Out Right

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | Event(ARROW R) | Event(ARROW R) |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Out Left

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
| boolName | "mapCity" | "mapCity" |  |  |
| isTrue | Event(CITY) | Event(CITY) |  |  |
| isFalse | Event() | Event() |  |  |

##### 2. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapWaterways" | "mapWaterways" |  |  |
| isTrue | Event(WATERWAYS) | Event(WATERWAYS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 3. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapFungalWastes" | "mapFungalWastes" |  |  |
| isTrue | Event(WASTES) | Event(WASTES) |  |  |
| isFalse | Event() | Event() |  |  |

##### 4. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapFogCanyon" | "mapFogCanyon" |  |  |
| isTrue | Event(FOG_CANYON) | Event(FOG_CANYON) |  |  |
| isFalse | Event() | Event() |  |  |

##### 5. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapRoyalGardens" | "mapRoyalGardens" |  |  |
| isTrue | Event(ROYAL_GARDENS) | Event(ROYAL_GARDENS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 6. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapDeepnest" | "mapDeepnest" |  |  |
| isTrue | Event(ROYAL_GARDENS) | Event(ROYAL_GARDENS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 7. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapGreenpath" | "mapGreenpath" |  |  |
| isTrue | Event(GREEN_PATH) | Event(GREEN_PATH) |  |  |
| isFalse | Event() | Event() |  |  |

##### 8. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapCrossroads" | "mapCrossroads" |  |  |
| isTrue | Event(CROSSROADS) | Event(CROSSROADS) |  |  |
| isFalse | Event() | Event() |  |  |

##### 9. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | Event(TOWN) | Event(TOWN) |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Out Down

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
| boolName | "visitedHive" | "visitedHive" |  |  |
| isTrue | Event(HIVE) | Event(HIVE) |  |  |
| isFalse | Event() | Event() |  |  |

##### 2. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapAbyss" | "mapAbyss" |  |  |
| isTrue | Event(ABYSS) | Event(ABYSS) |  |  |
| isFalse | Event() | Event() |  |  |

### Hive

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
| boolName | "visitedHive" | "visitedHive" |  |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(TOWN) | Event(TOWN) |  |  |

##### 2. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Display Hive | bool Display Hive | Variable |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(TOWN) | Event(TOWN) |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:FSM Owner | EventTarget(GameObject)[SendToChildren]:FSM Owner |  |  |
| sendEvent | "UNSELECT" | "UNSELECT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 4. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:Hive | EventTarget(GameObject)[SendToChildren]:Hive |  |  |
| sendEvent | "SELECT" | "SELECT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 5. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "UI" | "UI" |  |  |
| convName | "MAP_NAME_HIVE" | "MAP_NAME_HIVE" |  |  |
| storeValue | string Area String | string Area String | Variable |  |

##### 6. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Area Name | OwnerDefault Area Name |  |  |
| textString | string Area String | string Area String |  |  |

##### 7. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Current Selection | string Current Selection | Variable |  |
| stringValue | "HIVE" | "HIVE" | TextArea |  |
| everyFrame | false | false |  |  |

##### 8. SetVector3Value

Full Name: HutongGames.PlayMaker.Actions.SetVector3Value
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable | Vector3 Zoom To Pos | Vector3 Zoom To Pos | Variable |  |
| vector3Value | Vector3(-21.13, 6.39, -22) | Vector3(-21.13, 6.39, -22) |  |  |
| everyFrame | false | false |  |  |

##### 9. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Zoom Shortcut | bool Zoom Shortcut | Variable |  |
| isTrue | Event(MAP ZOOM) | Event(MAP ZOOM) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

### Hive Down

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
| boolName | "mapAbyss" | "mapAbyss" |  |  |
| isTrue | Event(ABYSS) | Event(ABYSS) |  |  |
| isFalse | Event() | Event() |  |  |

### Pos Check

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
| boolName | "mapDeepnest" | "mapDeepnest" |  |  |
| isTrue | Event(POS 3) | Event(POS 3) |  |  |
| isFalse | Event() | Event() |  |  |

##### 2. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapAbyss" | "mapAbyss" |  |  |
| isTrue | Event(POS 3) | Event(POS 3) |  |  |
| isFalse | Event() | Event() |  |  |

##### 3. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapWaterways" | "mapWaterways" |  |  |
| isTrue | Event(POS 3) | Event(POS 3) |  |  |
| isFalse | Event() | Event() |  |  |

##### 4. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapOutskirts" | "mapOutskirts" |  |  |
| isTrue | Event(POS 3) | Event(POS 3) |  |  |
| isFalse | Event() | Event() |  |  |

##### 5. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapRoyalGardens" | "mapRoyalGardens" |  |  |
| isTrue | Event(POS 2) | Event(POS 2) |  |  |
| isFalse | Event() | Event() |  |  |

##### 6. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapFogCanyon" | "mapFogCanyon" |  |  |
| isTrue | Event(POS 2) | Event(POS 2) |  |  |
| isFalse | Event() | Event() |  |  |

##### 7. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapFungalWastes" | "mapFungalWastes" |  |  |
| isTrue | Event(POS 2) | Event(POS 2) |  |  |
| isFalse | Event() | Event() |  |  |

##### 8. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "mapCity" | "mapCity" |  |  |
| isTrue | Event(POS 2) | Event(POS 2) |  |  |
| isFalse | Event() | Event() |  |  |

##### 9. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | Event(POS 1) | Event(POS 1) |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Pos 1

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Wide Map | OwnerDefault Wide Map |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0.52f | 0.52f |  |  |
| y | -2.58f | -2.58f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

### Pos 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Wide Map | OwnerDefault Wide Map |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0.76f | 0.76f |  |  |
| y | -1.41f | -1.41f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

### Pos 3

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Wide Map | OwnerDefault Wide Map |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | -0.15f | -0.15f |  |  |
| y | 0.06f | 0.06f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

### Map Zoom

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Disable Zoom | bool Disable Zoom | Variable |  |
| isTrue | Event(CANCEL) | Event(CANCEL) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 2. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Zoom Shortcut | bool Zoom Shortcut | Variable |  |
| boolValue | false | false |  |  |
| everyFrame | false | false |  |  |

##### 3. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inventory | OwnerDefault Inventory |  |  |
| fsmName | "Inventory Control" | "Inventory Control" | FsmName |  |
| variableName | "Do Not Close" | "Do Not Close" | FsmBool |  |
| setValue | true | true |  |  |
| everyFrame | false | false |  |  |

##### 4. FadeGroupDown

Full Name: FadeGroupDown
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault FSM Owner | OwnerDefault FSM Owner | Variable |  |
| fast | false | false |  |  |

##### 5. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Game Map | OwnerDefault Game Map |  |  |
| fsmName | "Map FSM State" | "Map FSM State" | FsmName |  |
| variableName | "Display Next Area" | "Display Next Area" | FsmBool |  |
| setValue | false | false |  |  |
| everyFrame | false | false |  |  |

##### 6. GetPosition2D

Full Name: HutongGames.PlayMaker.Actions.GetPosition2D
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Wide Map | OwnerDefault Wide Map |  |  |
| vector | Vector2(0, 0) | Vector2(0, 0) | Variable |  |
| x | float Area Map X | float Area Map X | Variable |  |
| y | float Area Map Y | float Area Map Y | Variable |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |

##### 7. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:FSM Owner | EventTarget(GameObject)[SendToChildren]:FSM Owner |  |  |
| sendEvent | "UNSELECT" | "UNSELECT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 8. FloatAdd

Full Name: HutongGames.PlayMaker.Actions.FloatAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Area Map X | float Area Map X | Variable |  |
| add | 3.81f | 3.81f |  |  |
| everyFrame | false | false |  |  |
| perSecond | false | false |  |  |

##### 9. FloatAdd

Full Name: HutongGames.PlayMaker.Actions.FloatAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Area Map Y | float Area Map Y | Variable |  |
| add | -7.77f | -7.77f |  |  |
| everyFrame | false | false |  |  |
| perSecond | false | false |  |  |

##### 10. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Game Map | OwnerDefault Game Map |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | float Area Map X | float Area Map X |  |  |
| y | float Area Map Y | float Area Map Y |  |  |
| z | -22f | -22f |  |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 11. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Game Map | OwnerDefault Game Map |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | WorldMap(???) | WorldMap(???) |  |  |

##### 12. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:FSM Owner | EventTarget(GameObject)[SendToChildren]:FSM Owner |  |  |
| sendEvent | "DOWN" | "DOWN" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 13. SetScale

Full Name: HutongGames.PlayMaker.Actions.SetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Game Map | OwnerDefault Game Map |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0.436f | 0.436f |  |  |
| y | 0.436f | 0.436f |  |  |
| z | 0.436f | 0.436f |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 14. iTweenScaleTo

Full Name: HutongGames.PlayMaker.Actions.iTweenScaleTo
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Game Map | OwnerDefault Game Map |  |  |
| id | "" | "" |  |  |
| transformScale |  |  |  |  |
| vectorScale | Vector3(1.3, 1.3, 1.3) | Vector3(1.3, 1.3, 1.3) |  |  |
| time | 0.4f | 0.4f |  |  |
| delay | 0f | 0f |  |  |
| speed | 0f | 0f |  |  |
| easeType | iTween/EaseType::easeOutSine | 13 |  |  |
| loopType | iTween/LoopType::none | 0 |  |  |
| startEvent | Event() | Event() |  |  |
| finishEvent | Event() | Event() |  |  |
| realTime | false | false |  |  |
| stopOnExit | true | true |  |  |
| loopDontFinish | true | true |  |  |

##### 15. iTweenMoveTo

Full Name: HutongGames.PlayMaker.Actions.iTweenMoveTo
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Game Map | OwnerDefault Game Map |  |  |
| id | "" | "" |  |  |
| transformPosition |  |  |  |  |
| vectorPosition | Vector3 Zoom To Pos | Vector3 Zoom To Pos |  |  |
| time | 0.4f | 0.4f |  |  |
| delay | 0f | 0f |  |  |
| speed | 0f | 0f |  |  |
| space | UnityEngine.Space::World | 0 |  |  |
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

##### 16. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.45f | 0.45f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### To Zoom 1

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | Event(MAP ZOOM) | Event(MAP ZOOM) |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### To Zoom 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | Event(MAP ZOOM) | Event(MAP ZOOM) |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### To Zoom 3

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | Event(MAP ZOOM) | Event(MAP ZOOM) |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### To Zoom 4

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | Event(MAP ZOOM) | Event(MAP ZOOM) |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### To Zoom 5

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | Event(MAP ZOOM) | Event(MAP ZOOM) |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### To Zoom 6

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | Event(MAP ZOOM) | Event(MAP ZOOM) |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### To Zoom 7

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | Event(MAP ZOOM) | Event(MAP ZOOM) |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### To Zoom 8

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | Event(MAP ZOOM) | Event(MAP ZOOM) |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### To Zoom 9

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | Event(MAP ZOOM) | Event(MAP ZOOM) |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### To Zoom 10

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | Event(MAP ZOOM) | Event(MAP ZOOM) |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### To Zoom 11

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | Event(MAP ZOOM) | Event(MAP ZOOM) |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### To Zoom 12

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | Event(MAP ZOOM) | Event(MAP ZOOM) |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### To Zoom 13

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | Event(MAP ZOOM) | Event(MAP ZOOM) |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### To Zoom 14

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | Event(MAP ZOOM) | Event(MAP ZOOM) |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Zoomed In

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. SetScale

Full Name: HutongGames.PlayMaker.Actions.SetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Game Map | OwnerDefault Game Map |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 1.3f | 1.3f |  |  |
| y | 1.3f | 1.3f |  |  |
| z | 1.3f | 1.3f |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Map Key | EventTarget(GameObject):Map Key |  |  |
| sendEvent | "MAP KEY UP" | "MAP KEY UP" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "UI" | "UI" |  |  |
| convName | "CTRL_MARKERS" | "CTRL_MARKERS" |  |  |
| storeValue | string Marker Text Str | string Marker Text Str | Variable |  |

##### 4. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Marker Text | OwnerDefault Marker Text |  |  |
| textString | string Marker Text Str | string Marker Text Str |  |  |

##### 5. SetMenuButtonIconAction

Full Name: SetMenuButtonIconAction
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | GameObject Confirm Action | GameObject Confirm Action |  |  |
| menuAction | Enum(Platform+MenuActions, 2) | Enum(Platform+MenuActions, 2) |  |  |

##### 6. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Confirm Action | OwnerDefault Confirm Action |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 7. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Marker Action | OwnerDefault Marker Action |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 8. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "UI" | "UI" |  |  |
| convName | "CTRL_ZOOM_OUT" | "CTRL_ZOOM_OUT" |  |  |
| storeValue | string Confirm Text Str | string Confirm Text Str | Variable |  |

##### 9. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Confirm Text | OwnerDefault Confirm Text |  |  |
| textString | string Confirm Text Str | string Confirm Text Str |  |  |

##### 10. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Game Map | OwnerDefault Game Map |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | SetCanPan(true) | SetCanPan(true) |  |  |

##### 11. ListenForInventory

Full Name: HutongGames.PlayMaker.Actions.ListenForInventory
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| wasPressed | Event(INVENTORY CANCEL) | Event(INVENTORY CANCEL) |  |  |
| wasReleased | Event() | Event() |  |  |
| isPressed | Event() | Event() |  |  |
| isNotPressed | Event() | Event() |  |  |

##### 12. ListenForQuickMap

Full Name: HutongGames.PlayMaker.Actions.ListenForQuickMap
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| wasPressed | Event(INVENTORY CANCEL) | Event(INVENTORY CANCEL) |  |  |
| wasReleased | Event() | Event() |  |  |
| isPressed | Event() | Event() |  |  |
| isNotPressed | Event() | Event() |  |  |

### Zoom Out

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetVector3XYZ

Full Name: HutongGames.PlayMaker.Actions.SetVector3XYZ
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable | Vector3 Zoom Back Pos | Vector3 Zoom Back Pos | Variable |  |
| vector3Value | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | float Area Map X | float Area Map X |  |  |
| y | float Area Map Y | float Area Map Y |  |  |
| z | -22f | -22f |  |  |
| everyFrame | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Map Key | EventTarget(GameObject):Map Key |  |  |
| sendEvent | "MAP KEY DOWN" | "MAP KEY DOWN" |  |  |
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

##### 4. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Marker Action | OwnerDefault Marker Action |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 5. ActivateAllChildren

Full Name: HutongGames.PlayMaker.Actions.ActivateAllChildren
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Pan Arrows | GameObject Pan Arrows | Variable |  |
| activate | false | false |  |  |

##### 6. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Game Map | OwnerDefault Game Map |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | SetCanPan(false) | SetCanPan(false) |  |  |

##### 7. iTweenScaleTo

Full Name: HutongGames.PlayMaker.Actions.iTweenScaleTo
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Game Map | OwnerDefault Game Map |  |  |
| id | "" | "" |  |  |
| transformScale |  |  |  |  |
| vectorScale | Vector3(0.436, 0.436, 0.436) | Vector3(0.436, 0.436, 0.436) |  |  |
| time | 0.25f | 0.25f |  |  |
| delay | 0f | 0f |  |  |
| speed | 0f | 0f |  |  |
| easeType | iTween/EaseType::linear | 21 |  |  |
| loopType | iTween/LoopType::none | 0 |  |  |
| startEvent | Event() | Event() |  |  |
| finishEvent | Event() | Event() |  |  |
| realTime | false | false |  |  |
| stopOnExit | false | false |  |  |
| loopDontFinish | true | true |  |  |

##### 8. iTweenMoveTo

Full Name: HutongGames.PlayMaker.Actions.iTweenMoveTo
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Game Map | OwnerDefault Game Map |  |  |
| id | "" | "" |  |  |
| transformPosition |  |  |  |  |
| vectorPosition | Vector3 Zoom Back Pos | Vector3 Zoom Back Pos |  |  |
| time | 0.25f | 0.25f |  |  |
| delay | 0f | 0f |  |  |
| speed | 0f | 0f |  |  |
| space | UnityEngine.Space::World | 0 |  |  |
| easeType | iTween/EaseType::linear | 21 |  |  |
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
| stopOnExit | false | false |  |  |
| loopDontFinish | true | true |  |  |

##### 9. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.1f | 0.1f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Reset

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SetFsmGameObject

Full Name: HutongGames.PlayMaker.Actions.SetFsmGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Update Cursor" | "Update Cursor" | FsmName |  |
| variableName | "Item" | "Item" | FsmGameObject |  |
| setValue | GameObject Self | GameObject Self |  |  |
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

##### 3. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "UI" | "UI" |  |  |
| convName | "CTRL_ZOOM_IN" | "CTRL_ZOOM_IN" |  |  |
| storeValue | string Confirm Text Str | string Confirm Text Str | Variable |  |

##### 4. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Confirm Text | OwnerDefault Confirm Text |  |  |
| textString | string Confirm Text Str | string Confirm Text Str |  |  |

##### 5. SetMenuButtonIconAction

Full Name: SetMenuButtonIconAction
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | GameObject Confirm Action | GameObject Confirm Action |  |  |
| menuAction | Enum(Platform+MenuActions, 1) | Enum(Platform+MenuActions, 1) |  |  |

##### 6. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inventory | OwnerDefault Inventory |  |  |
| fsmName | "Inventory Control" | "Inventory Control" | FsmName |  |
| variableName | "Do Not Close" | "Do Not Close" | FsmBool |  |
| setValue | false | false |  |  |
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

##### 8. SetPosition

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

##### 9. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | string Current Selection | string Current Selection |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Map Up

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:FSM Owner | EventTarget(GameObject)[SendToChildren]:FSM Owner |  |  |
| sendEvent | "UP" | "UP" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.15f | 0.15f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

##### 3. FadeGroupUp

Full Name: FadeGroupUp
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault FSM Owner | OwnerDefault FSM Owner | Variable |  |

### Map Off

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.1f | 0.1f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

##### 2. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Game Map | OwnerDefault Game Map |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | CloseQuickMap(???) | CloseQuickMap(???) |  |  |

### To Zoom 15

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | Event(MAP ZOOM) | Event(MAP ZOOM) |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Inventory Cancel

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. ActivateAllChildren

Full Name: HutongGames.PlayMaker.Actions.ActivateAllChildren
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Pan Arrows | GameObject Pan Arrows | Variable |  |
| activate | false | false |  |  |

##### 2. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inventory | OwnerDefault Inventory |  |  |
| fsmName | "Inventory Control" | "Inventory Control" | FsmName |  |
| variableName | "Do Not Close" | "Do Not Close" | FsmBool |  |
| setValue | false | false |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(BroadcastAll):FSM Owner | EventTarget(BroadcastAll):FSM Owner |  |  |
| sendEvent | "MAP KEY DOWN" | "MAP KEY DOWN" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 4. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Inventory | EventTarget(GameObject):Inventory |  |  |
| sendEvent | "CLOSE" | "CLOSE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Have Markers?

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
| boolName | "hasMarker" | "hasMarker" |  |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(CANCEL) | Event(CANCEL) |  |  |

### Marker Select Menu

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. OpenMarkerMenu

Full Name: OpenMarkerMenu
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault Map Marker Top | OwnerDefault Map Marker Top | Variable |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Map Key | EventTarget(GameObject):Map Key |  |  |
| sendEvent | "MAP KEY DOWN" | "MAP KEY DOWN" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Confirm Action | EventTarget(GameObject):Confirm Action |  |  |
| sendEvent | "DOWN" | "DOWN" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 4. MapStopPan

Full Name: MapStopPan
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault Game Map | OwnerDefault Game Map | Variable |  |

##### 5. ListenForInventory

Full Name: HutongGames.PlayMaker.Actions.ListenForInventory
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| wasPressed | Event(INVENTORY CANCEL) | Event(INVENTORY CANCEL) |  |  |
| wasReleased | Event() | Event() |  |  |
| isPressed | Event() | Event() |  |  |
| isNotPressed | Event() | Event() |  |  |

##### 6. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "UI" | "UI" |  |  |
| convName | "CTRL_MARKER_PLACE" | "CTRL_MARKER_PLACE" |  |  |
| storeValue | string Marker Text Str | string Marker Text Str | Variable |  |

##### 7. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Marker Text | OwnerDefault Marker Text |  |  |
| textString | string Marker Text Str | string Marker Text Str |  |  |

##### 8. ListenForMenuCancel

Full Name: HutongGames.PlayMaker.Actions.ListenForMenuCancel
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| wasPressed | Event(UI CANCEL) | Event(UI CANCEL) |  |  |
| wasReleased | Event() | Event() |  |  |
| isPressed | Event() | Event() |  |  |
| isNotPressed | Event() | Event() |  |  |

### Marker Inv Cancel

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. CloseMarkerMenu

Full Name: CloseMarkerMenu
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault Map Marker Top | OwnerDefault Map Marker Top | Variable |  |

### Marker Cancel

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. CloseMarkerMenu

Full Name: CloseMarkerMenu
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault Map Marker Top | OwnerDefault Map Marker Top | Variable |  |

##### 2. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.05f | 0.05f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Inert

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

_None_

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Init | FINISHED | Pos Check | 0 | 0 | 0 |
| Crossroads | UI DOWN | CR Down | 0 | 0 | 0 |
| Crossroads | UI UP | CR Up | 0 | 0 | 0 |
| Crossroads | UI RIGHT | CR Right | 0 | 0 | 0 |
| Crossroads | UI LEFT | CR Left | 0 | 0 | 0 |
| Crossroads | UI CONFIRM | To Zoom 9 | 0 | 0 | 0 |
| City | UI UP | C Up | 0 | 0 | 0 |
| City | UI LEFT | C Left | 0 | 0 | 0 |
| City | UI DOWN | C Down | 0 | 0 | 0 |
| City | UI RIGHT | C Right | 0 | 0 | 0 |
| City | UI CONFIRM | To Zoom 8 | 0 | 0 | 0 |
| Town | UI DOWN | T Down | 0 | 0 | 0 |
| Town | UI RIGHT | T Right | 0 | 0 | 0 |
| Town | UI LEFT | T Left | 0 | 0 | 0 |
| Town | UI CONFIRM | To Zoom 10 | 0 | 0 | 0 |
| Mines | UI LEFT | Mi Left | 0 | 0 | 0 |
| Mines | UI DOWN | Mi Down | 0 | 0 | 0 |
| Mines | UI RIGHT | Mi Right | 0 | 0 | 0 |
| Mines | UI CONFIRM | To Zoom 11 | 0 | 0 | 0 |
| Resting Grounds | UI LEFT | RG Left | 0 | 0 | 0 |
| Resting Grounds | UI DOWN | RG Down | 0 | 0 | 0 |
| Resting Grounds | UI UP | RG Up | 0 | 0 | 0 |
| Resting Grounds | UI RIGHT | RG Right | 0 | 0 | 0 |
| Resting Grounds | UI CONFIRM | To Zoom 12 | 0 | 0 | 0 |
| Cliffs | UI DOWN | Cl Down | 0 | 0 | 0 |
| Cliffs | UI RIGHT | Cl Right | 0 | 0 | 0 |
| Cliffs | UI LEFT | Cl Left | 0 | 0 | 0 |
| Cliffs | UI CONFIRM | To Zoom 1 | 0 | 0 | 0 |
| Greenpath | UI DOWN | GP Down | 0 | 0 | 0 |
| Greenpath | UI RIGHT | GP Right | 0 | 0 | 0 |
| Greenpath | UI UP | GP Up | 0 | 0 | 0 |
| Greenpath | UI LEFT | GP Left | 0 | 0 | 0 |
| Greenpath | UI CONFIRM | To Zoom 2 | 0 | 0 | 0 |
| Fungus | UI DOWN | FW Down | 0 | 0 | 0 |
| Fungus | UI RIGHT | FW Right | 0 | 0 | 0 |
| Fungus | UI UP | FW Up | 0 | 0 | 0 |
| Fungus | UI LEFT | FW Left | 0 | 0 | 0 |
| Fungus | UI CONFIRM | To Zoom 4 | 0 | 0 | 0 |
| Deepnest | UI RIGHT | D Right | 0 | 0 | 0 |
| Deepnest | UI UP | D Up | 0 | 0 | 0 |
| Deepnest | UI LEFT | D Left | 0 | 0 | 0 |
| Deepnest | UI CONFIRM | To Zoom 5 | 0 | 0 | 0 |
| Waterways | UI UP | Wat Up | 0 | 0 | 0 |
| Waterways | UI LEFT | Wat Left | 0 | 0 | 0 |
| Waterways | UI RIGHT | Wat Right | 0 | 0 | 0 |
| Waterways | UI DOWN | Wat Down | 0 | 0 | 0 |
| Waterways | UI CONFIRM | To Zoom 7 | 0 | 0 | 0 |
| Fog Canyon | UI DOWN | FG Down | 0 | 0 | 0 |
| Fog Canyon | UI RIGHT | FG Right | 0 | 0 | 0 |
| Fog Canyon | UI UP | FG Up | 0 | 0 | 0 |
| Fog Canyon | UI LEFT | FG Left | 0 | 0 | 0 |
| Fog Canyon | UI CONFIRM | To Zoom 3 | 0 | 0 | 0 |
| Pane Reset | FINISHED | Inactive | 0 | 0 | 0 |
| Inactive | ACTIVATE | Activate | 0 | 0 | 0 |
| Activate | FINISHED | Town | 0 | 0 | 0 |
| GP Up | FINISHED | Greenpath | 0 | 0 | 0 |
| GP Down | FINISHED | Greenpath | 0 | 0 | 0 |
| GP Right | FINISHED | Greenpath | 0 | 0 | 0 |
| CR Left | FINISHED | Crossroads | 0 | 0 | 0 |
| CR Up | FINISHED | Crossroads | 0 | 0 | 0 |
| CR Right | FINISHED | Crossroads | 0 | 0 | 0 |
| CR Down | FINISHED | Crossroads | 0 | 0 | 0 |
| T Down | FINISHED | Town | 0 | 0 | 0 |
| T Right | FINISHED | Town | 0 | 0 | 0 |
| Move Pane L | FINISHED |  | 0 | 0 | 0 |
| Move Pane L | CANCEL | Arrow L | 0 | 0 | 0 |
| Arrow L | UI LEFT | Move Pane L | 0 | 0 | 0 |
| Arrow L | UI CONFIRM | Move Pane L | 0 | 0 | 0 |
| Arrow L | UI RIGHT | To Map | 0 | 0 | 0 |
| GP Left | FINISHED |  | 0 | 0 | 0 |
| To Map | FINISHED |  | 0 | 0 | 0 |
| Move Pane R | FINISHED |  | 0 | 0 | 0 |
| Move Pane R | CANCEL | Arrow R | 0 | 0 | 0 |
| Arrow R | UI LEFT | To Map 2 | 0 | 0 | 0 |
| Arrow R | UI CONFIRM | Move Pane R | 0 | 0 | 0 |
| Arrow R | UI RIGHT | Move Pane R | 0 | 0 | 0 |
| To Map 2 | FINISHED |  | 0 | 0 | 0 |
| T Left | FINISHED | Town | 0 | 0 | 0 |
| Cl Right | FINISHED | Cliffs | 0 | 0 | 0 |
| Cl Left | FINISHED | Cliffs | 0 | 0 | 0 |
| Cl Down | FINISHED | Cliffs | 0 | 0 | 0 |
| Mi Right | FINISHED | Mines | 0 | 0 | 0 |
| Mi Left | FINISHED | Mines | 0 | 0 | 0 |
| Mi Down | FINISHED | Mines | 0 | 0 | 0 |
| RG Up | FINISHED | Resting Grounds | 0 | 0 | 0 |
| RG Right | FINISHED | Resting Grounds | 0 | 0 | 0 |
| RG Left | FINISHED | Resting Grounds | 0 | 0 | 0 |
| RG Down | FINISHED | Resting Grounds | 0 | 0 | 0 |
| FG Up | FINISHED | Fog Canyon | 0 | 0 | 0 |
| FG Left | FINISHED | Fog Canyon | 0 | 0 | 0 |
| FG Down | FINISHED | Fog Canyon | 0 | 0 | 0 |
| FW Up | FINISHED | Fungus | 0 | 0 | 0 |
| FW Left | FINISHED | Fungus | 0 | 0 | 0 |
| FW Down | FINISHED | Fungus | 0 | 0 | 0 |
| D Left | FINISHED | Deepnest | 0 | 0 | 0 |
| D Up | FINISHED | Deepnest | 0 | 0 | 0 |
| FW Right | FINISHED | Fungus | 0 | 0 | 0 |
| FG Right | FINISHED | Fog Canyon | 0 | 0 | 0 |
| D Right | FINISHED | Deepnest | 0 | 0 | 0 |
| C Up | FINISHED | City | 0 | 0 | 0 |
| C Left | FINISHED | City | 0 | 0 | 0 |
| C Down | FINISHED | City | 0 | 0 | 0 |
| C Right | FINISHED | City | 0 | 0 | 0 |
| Wat Up | FINISHED | Waterways | 0 | 0 | 0 |
| Wat Left | FINISHED | Waterways | 0 | 0 | 0 |
| Wat Right | FINISHED | Waterways | 0 | 0 | 0 |
| Royal Gardens | UI DOWN | QG Down | 0 | 0 | 0 |
| Royal Gardens | UI RIGHT | QG Right | 0 | 0 | 0 |
| Royal Gardens | UI UP | QG Up | 0 | 0 | 0 |
| Royal Gardens | UI LEFT | QG Left | 0 | 0 | 0 |
| Royal Gardens | UI CONFIRM | To Zoom 15 | 0 | 0 | 0 |
| QG Up | FINISHED | Royal Gardens | 0 | 0 | 0 |
| QG Left | FINISHED | Royal Gardens | 0 | 0 | 0 |
| QG Down | FINISHED | Royal Gardens | 0 | 0 | 0 |
| QG Right | FINISHED | Royal Gardens | 0 | 0 | 0 |
| Wat Down | FINISHED | Waterways | 0 | 0 | 0 |
| Ancient Basin | UI UP | Ab Up | 0 | 0 | 0 |
| Ancient Basin | UI LEFT | Ab Left | 0 | 0 | 0 |
| Ancient Basin | UI RIGHT | Ab Right | 0 | 0 | 0 |
| Ancient Basin | UI CONFIRM | To Zoom 6 | 0 | 0 | 0 |
| Ab Up | FINISHED | Ancient Basin | 0 | 0 | 0 |
| Ab Left | FINISHED | Ancient Basin | 0 | 0 | 0 |
| Ab Right | FINISHED | Ancient Basin | 0 | 0 | 0 |
| Outskirts | UI LEFT | Out Left | 0 | 0 | 0 |
| Outskirts | UI DOWN | Out Down | 0 | 0 | 0 |
| Outskirts | UI UP | Out Up | 0 | 0 | 0 |
| Outskirts | UI RIGHT | Out Right | 0 | 0 | 0 |
| Outskirts | UI CONFIRM | To Zoom 13 | 0 | 0 | 0 |
| Out Up | FINISHED | Outskirts | 0 | 0 | 0 |
| Out Right | FINISHED | Outskirts | 0 | 0 | 0 |
| Out Left | FINISHED | Outskirts | 0 | 0 | 0 |
| Out Down | FINISHED | Outskirts | 0 | 0 | 0 |
| Hive | UI LEFT | Outskirts | 0 | 0 | 0 |
| Hive | UI DOWN | Hive Down | 0 | 0 | 0 |
| Hive | UI UP | Outskirts | 0 | 0 | 0 |
| Hive | UI RIGHT | Out Right | 0 | 0 | 0 |
| Hive | UI CONFIRM | To Zoom 14 | 0 | 0 | 0 |
| Hive Down | FINISHED | Hive | 0 | 0 | 0 |
| Pos Check | POS 1 | Pos 1 | 0 | 0 | 0 |
| Pos Check | POS 2 | Pos 2 | 0 | 0 | 0 |
| Pos Check | POS 3 | Pos 3 | 0 | 0 | 0 |
| Pos 1 | FINISHED | Inactive | 0 | 0 | 0 |
| Pos 2 | FINISHED | Inactive | 0 | 0 | 0 |
| Pos 3 | FINISHED | Inactive | 0 | 0 | 0 |
| Map Zoom | FINISHED | Zoomed In | 0 | 0 | 0 |
| Map Zoom | CANCEL | Inert | 0 | 0 | 0 |
| Zoomed In | UI CONFIRM | Have Markers? | 0 | 0 | 0 |
| Zoomed In | UI CANCEL | Zoom Out | 0 | 0 | 0 |
| Zoomed In | INVENTORY CANCEL | Inventory Cancel | 0 | 0 | 0 |
| Zoom Out | FINISHED | Map Up | 0 | 0 | 0 |
| Map Up | FINISHED | Map Off | 0 | 0 | 0 |
| Map Off | FINISHED | Reset | 0 | 0 | 0 |
| Have Markers? | FINISHED | Marker Select Menu | 0 | 0 | 0 |
| Have Markers? | CANCEL | Zoomed In | 0 | 0 | 0 |
| Marker Select Menu | UI CANCEL | Marker Cancel | 0 | 0 | 0 |
| Marker Select Menu | INVENTORY CANCEL | Marker Inv Cancel | 0 | 0 | 0 |
| Marker Inv Cancel | FINISHED | Inventory Cancel | 0 | 0 | 0 |
| Marker Cancel | FINISHED | Zoomed In | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| HIVE | Hive | 0 | 0 | 0 |
| OUTSKIRTS | Outskirts | 0 | 0 | 0 |
| ABYSS | Ancient Basin | 0 | 0 | 0 |
| ROYAL_GARDENS | Royal Gardens | 0 | 0 | 0 |
| ARROW R | Arrow R | 0 | 0 | 0 |
| FOG_CANYON | Fog Canyon | 0 | 0 | 0 |
| WATERWAYS | Waterways | 0 | 0 | 0 |
| DEEPNEST | Deepnest | 0 | 0 | 0 |
| WASTES | Fungus | 0 | 0 | 0 |
| GREEN_PATH | Greenpath | 0 | 0 | 0 |
| CLIFFS | Cliffs | 0 | 0 | 0 |
| RESTING_GROUNDS | Resting Grounds | 0 | 0 | 0 |
| MINES | Mines | 0 | 0 | 0 |
| TOWN | Town | 0 | 0 | 0 |
| CITY | City | 0 | 0 | 0 |
| CROSSROADS | Crossroads | 0 | 0 | 0 |
| PANE RESET | Pane Reset | 0 | 0 | 0 |
| ARROW L | Arrow L | 0 | 0 | 0 |
| MAP ZOOM | Map Zoom | 0 | 0 | 0 |
| KINGS_PASS | Town | 0 | 0 | 0 |
| COLOSSEUM | Outskirts | 0 | 0 | 0 |
| SHAMAN_TEMPLE | Crossroads | 0 | 0 | 0 |
| QUEENS_STATION | Fungus | 0 | 0 | 0 |
| KINGS_STATION | City | 0 | 0 | 0 |
| SOUL_SOCIETY | City | 0 | 0 | 0 |
| LURIENS_TOWER | City | 0 | 0 | 0 |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| ABYSS | false |
| ACTIVATE | false |
| ARROW L | false |
| ARROW R | false |
| ATK PRESSED | false |
| CANCEL | false |
| CITY | false |
| CLIFFS | false |
| COLOSSEUM | false |
| CROSSROADS | false |
| DEEPNEST | false |
| FOG_CANYON | false |
| GREEN_PATH | false |
| HIVE | false |
| INVENTORY CANCEL | false |
| KINGS_PASS | false |
| KINGS_STATION | false |
| LURIENS_TOWER | false |
| MAP ZOOM | false |
| MINES | false |
| NONE | false |
| OUTSKIRTS | false |
| PANE RESET | false |
| POS 1 | false |
| POS 2 | false |
| POS 3 | false |
| QUEENS_STATION | false |
| RESTING_GROUNDS | false |
| ROYAL_GARDENS | false |
| SHAMAN_TEMPLE | false |
| SOUL_SOCIETY | false |
| TEST_AREA | false |
| TOWN | false |
| UI CANCEL | false |
| UI CONFIRM | false |
| UI DOWN | false |
| UI LEFT | false |
| UI RIGHT | false |
| UI UP | false |
| WASTES | false |
| WATERWAYS | false |

