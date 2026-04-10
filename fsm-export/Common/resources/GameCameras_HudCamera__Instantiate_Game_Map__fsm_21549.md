# Instantiate Game Map

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Instantiate Game Map |
| GameObject Name | HudCamera |
| GameObject Path | _GameCameras |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Pause |
| FSM PathId | 21549 |
| GameObject PathId | 4135 |

## Variables

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Map Key Pref | 0 | Int32: 0 |

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| Str Hide Key |  | String:  |
| Str Hide Pins |  | String:  |
| Str Show Both |  | String:  |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Action | _GameCameras/HudCamera/Inventory/Map Key/Action (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets) | NamedAssetPPtr: _GameCameras/HudCamera/Inventory/Map Key/Action (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets) |
| Action Text | _GameCameras/HudCamera/Inventory/Map Key/Action/Text (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets) | NamedAssetPPtr: _GameCameras/HudCamera/Inventory/Map Key/Action/Text (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets) |
| Arrow D | [null] | NamedAssetPPtr:  |
| Arrow L | [null] | NamedAssetPPtr:  |
| Arrow R | [null] | NamedAssetPPtr:  |
| Arrow U | [null] | NamedAssetPPtr:  |
| Backboard Key | _GameCameras/HudCamera/Inventory/Map Key/Backboard Key (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets) | NamedAssetPPtr: _GameCameras/HudCamera/Inventory/Map Key/Backboard Key (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets) |
| HUD Map | [null] | NamedAssetPPtr:  |
| Inventory | [null] | NamedAssetPPtr:  |
| Keys | _GameCameras/HudCamera/Inventory/Map Key/Keys (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets) | NamedAssetPPtr: _GameCameras/HudCamera/Inventory/Map Key/Keys (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets) |
| Map | [null] | NamedAssetPPtr:  |
| Pan Arrows | [null] | NamedAssetPPtr:  |
| Self | [null] | NamedAssetPPtr:  |
| World Map | [null] | NamedAssetPPtr:  |

## States

### Init Setup

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Map | OwnerDefault Map |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | SetupMap(false) | SetupMap(false) |  |  |

##### 2. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Map | OwnerDefault Map |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | GetDoorValues(false) | GetDoorValues(false) |  |  |

##### 3. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| behaviour | "GameManager" | "GameManager" | Behaviour |  |
| methodName | "SetGameMap" | "SetGameMap" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var unnamed = 0 | Var unnamed = 0 | Variable | Store Result |

##### 4. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Map | OwnerDefault Map |  |  |
| behaviour | "GameMap" | "GameMap" | Behaviour |  |
| methodName | "PositionDreamGateMarker" | "PositionDreamGateMarker" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var | Var | Variable | Store Result |

### Instantiate

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

##### 2. CreateObject

Full Name: HutongGames.PlayMaker.Actions.CreateObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Game_Map (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Game_Map (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| position | Vector3(0, 0, 38.1) | Vector3(0, 0, 38.1) |  |  |
| rotation | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| storeObject | GameObject Map | GameObject Map | Variable |  |
| networkInstantiate | false | false |  |  |
| networkGroup | 0 | 0 |  |  |

##### 3. SetParent

Full Name: HutongGames.PlayMaker.Actions.SetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Map | OwnerDefault Map |  |  |
| parent | GameObject Self | GameObject Self |  |  |
| resetLocalPosition | false | false |  |  |
| resetLocalRotation | false | false |  |  |

##### 4. SetGameObject

Full Name: HutongGames.PlayMaker.Actions.SetGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variable | [Global] GameObject Game Map | [Global] GameObject Game Map | Variable |  |
| gameObject | GameObject Map | GameObject Map |  |  |
| everyFrame | false | false |  |  |

##### 5. NextFrameEvent

Full Name: HutongGames.PlayMaker.Actions.NextFrameEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent | Event(FINISHED) | Event(FINISHED) |  |  |

### Set Pan Arrows

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
| childName | "Inventory" | "Inventory" |  |  |
| storeResult | GameObject Inventory | GameObject Inventory | Variable |  |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inventory | OwnerDefault Inventory |  |  |
| childName | "Map" | "Map" |  |  |
| storeResult | GameObject HUD Map | GameObject HUD Map | Variable |  |

##### 3. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault HUD Map | OwnerDefault HUD Map |  |  |
| childName | "World Map" | "World Map" |  |  |
| storeResult | GameObject World Map | GameObject World Map | Variable |  |

##### 4. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault World Map | OwnerDefault World Map |  |  |
| childName | "Pan Arrows" | "Pan Arrows" |  |  |
| storeResult | GameObject Pan Arrows | GameObject Pan Arrows | Variable |  |

##### 5. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Pan Arrows | OwnerDefault Pan Arrows |  |  |
| childName | "Arrow U" | "Arrow U" |  |  |
| storeResult | GameObject Arrow U | GameObject Arrow U | Variable |  |

##### 6. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Pan Arrows | OwnerDefault Pan Arrows |  |  |
| childName | "Arrow D" | "Arrow D" |  |  |
| storeResult | GameObject Arrow D | GameObject Arrow D | Variable |  |

##### 7. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Pan Arrows | OwnerDefault Pan Arrows |  |  |
| childName | "Arrow L" | "Arrow L" |  |  |
| storeResult | GameObject Arrow L | GameObject Arrow L | Variable |  |

##### 8. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Pan Arrows | OwnerDefault Pan Arrows |  |  |
| childName | "Arrow R" | "Arrow R" |  |  |
| storeResult | GameObject Arrow R | GameObject Arrow R | Variable |  |

##### 9. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Game Map | OwnerDefault Game Map |  |  |
| behaviour | "GameMap" | "GameMap" | Behaviour |  |
| methodName | "SetPanArrows" | "SetPanArrows" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var unnamed = 0 | Var unnamed = 0 | Variable | Store Result |

### Key And Pin

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SetCameraCullingMask

Full Name: HutongGames.PlayMaker.Actions.SetCameraCullingMask
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| cullingMask | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 | Layer |  |
| invertMask | false | false |  |  |
| everyFrame | false | false |  |  |

### Check Map Key Pref

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault  | OwnerDefault  |  |  |
| intName | "mapKeyPref" | "mapKeyPref" |  |  |
| storeValue | int Map Key Pref | int Map Key Pref | Variable |  |

##### 2. IntSwitch

Full Name: HutongGames.PlayMaker.Actions.IntSwitch
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Map Key Pref | int Map Key Pref | Variable |  |
| compareTo | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| sendEvent | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| everyFrame | false | false |  |  |

### Pin

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SetCameraCullingMask

Full Name: HutongGames.PlayMaker.Actions.SetCameraCullingMask
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| cullingMask | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 | Layer |  |
| invertMask | false | false |  |  |
| everyFrame | false | false |  |  |

### None

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SetCameraCullingMask

Full Name: HutongGames.PlayMaker.Actions.SetCameraCullingMask
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| cullingMask | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 | Layer |  |
| invertMask | false | false |  |  |
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

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Init Setup | FINISHED | Set Pan Arrows | 0 | 0 | 0 |
| Instantiate | FINISHED | Init Setup | 0 | 0 | 0 |
| Set Pan Arrows | FINISHED | Check Map Key Pref | 0 | 0 | 0 |
| Check Map Key Pref | KEY AND PIN | Key And Pin | 0 | 0 | 0 |
| Check Map Key Pref | PIN | Pin | 0 | 0 | 0 |
| Check Map Key Pref | NONE | None | 0 | 0 | 0 |
| Pause | FINISHED | Instantiate | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| MAP KEY DOWN | false |
| ACTION | false |
| KEY AND PIN | false |
| PIN | false |
| NONE | false |

