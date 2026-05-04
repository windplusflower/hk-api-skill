# Instantiate Game Map

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Instantiate Game Map |
| GameObject Name | HudCamera |
| GameObject Path | _GameCameras/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level1 |
| Start State | Pause |
| FSM PathId | 9086 |
| GameObject PathId | 834 |

## Variables

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Map Key Pref | 0 | Int32: 0 |

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| Str Hide Key |   | String:  |
| Str Hide Pins |   | String:  |
| Str Show Both |   | String:  |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Action | _GameCameras/HudCamera/Inventory/Map Key/Action (Hollow Knight/hollow_knight_Data\level1) | NamedAssetPPtr: [_GameCameras/HudCamera/Inventory/Map Key/Action (Hollow Knight/hollow_knight_Data\level1)] |
| Action Text | _GameCameras/HudCamera/Inventory/Map Key/Action/Text (Hollow Knight/hollow_knight_Data\level1) | NamedAssetPPtr: [_GameCameras/HudCamera/Inventory/Map Key/Action/Text (Hollow Knight/hollow_knight_Data\level1)] |
| Arrow D | [null] | NamedAssetPPtr: [null] |
| Arrow L | [null] | NamedAssetPPtr: [null] |
| Arrow R | [null] | NamedAssetPPtr: [null] |
| Arrow U | [null] | NamedAssetPPtr: [null] |
| Backboard Key | _GameCameras/HudCamera/Inventory/Map Key/Backboard Key (Hollow Knight/hollow_knight_Data\level1) | NamedAssetPPtr: [_GameCameras/HudCamera/Inventory/Map Key/Backboard Key (Hollow Knight/hollow_knight_Data\level1)] |
| HUD Map | [null] | NamedAssetPPtr: [null] |
| Inventory | [null] | NamedAssetPPtr: [null] |
| Keys | _GameCameras/HudCamera/Inventory/Map Key/Keys (Hollow Knight/hollow_knight_Data\level1) | NamedAssetPPtr: [_GameCameras/HudCamera/Inventory/Map Key/Keys (Hollow Knight/hollow_knight_Data\level1)] |
| Map | [null] | NamedAssetPPtr: [null] |
| Pan Arrows | [null] | NamedAssetPPtr: [null] |
| Self | [null] | NamedAssetPPtr: [null] |
| World Map | [null] | NamedAssetPPtr: [null] |

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
| gameObject |   | OwnerDefault Map |   |   |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |   |   |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |   |   |
| functionCall |   | SetupMap(false) |   |   |

##### 2. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Map |   |   |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |   |   |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |   |   |
| functionCall |   | GetDoorValues(false) |   |   |

##### 3. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| behaviour |   | "GameManager" | Behaviour |   |
| methodName |   | "SetGameMap" | Method |   |
| parameters |   | FSMViewAvalonia2.FsmArray2 |   |   |
| storeResult |   | Var unnamed = 0 | Variable | Store Result |

##### 4. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Map |   |   |
| behaviour |   | "GameMap" | Behaviour |   |
| methodName |   | "PositionDreamGateMarker" | Method |   |
| parameters |   | FSMViewAvalonia2.FsmArray2 |   |   |
| storeResult |   | Var | Variable | Store Result |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Set Pan Arrows | 0 | |

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
| storeGameObject |   | GameObject Self | Variable |   |

##### 2. CreateObject

Full Name: HutongGames.PlayMaker.Actions.CreateObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Game_Map (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| position |   | Vector3(0, 0, 38.1) |   |   |
| rotation |   | Vector3(0, 0, 0) |   |   |
| storeObject |   | GameObject Map | Variable |   |
| networkInstantiate |   | false |   |   |
| networkGroup |   | 0 |   |   |

##### 3. SetParent

Full Name: HutongGames.PlayMaker.Actions.SetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Map |   |   |
| parent |   | GameObject Self |   |   |
| resetLocalPosition |   | false |   |   |
| resetLocalRotation |   | false |   |   |

##### 4. SetGameObject

Full Name: HutongGames.PlayMaker.Actions.SetGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variable |   | [Global] GameObject Game Map | Variable |   |
| gameObject |   | GameObject Map |   |   |
| everyFrame |   | false |   |   |

##### 5. NextFrameEvent

Full Name: HutongGames.PlayMaker.Actions.NextFrameEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent |   | Event(FINISHED) |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Init Setup | 0 | |

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
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Inventory" |   |   |
| storeResult |   | GameObject Inventory | Variable |   |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inventory |   |   |
| childName |   | "Map" |   |   |
| storeResult |   | GameObject HUD Map | Variable |   |

##### 3. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault HUD Map |   |   |
| childName |   | "World Map" |   |   |
| storeResult |   | GameObject World Map | Variable |   |

##### 4. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault World Map |   |   |
| childName |   | "Pan Arrows" |   |   |
| storeResult |   | GameObject Pan Arrows | Variable |   |

##### 5. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Pan Arrows |   |   |
| childName |   | "Arrow U" |   |   |
| storeResult |   | GameObject Arrow U | Variable |   |

##### 6. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Pan Arrows |   |   |
| childName |   | "Arrow D" |   |   |
| storeResult |   | GameObject Arrow D | Variable |   |

##### 7. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Pan Arrows |   |   |
| childName |   | "Arrow L" |   |   |
| storeResult |   | GameObject Arrow L | Variable |   |

##### 8. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Pan Arrows |   |   |
| childName |   | "Arrow R" |   |   |
| storeResult |   | GameObject Arrow R | Variable |   |

##### 9. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Game Map |   |   |
| behaviour |   | "GameMap" | Behaviour |   |
| methodName |   | "SetPanArrows" | Method |   |
| parameters |   | FSMViewAvalonia2.FsmArray2 |   |   |
| storeResult |   | Var unnamed = 0 | Variable | Store Result |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Check Map Key Pref | 0 | |

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
| gameObject |   | OwnerDefault FSM Owner |   |   |
| cullingMask |   | FSMViewAvalonia2.FsmArray2 | Layer |   |
| invertMask |   | false |   |   |
| everyFrame |   | false |   |   |

#### Transitions

(none)

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
| gameObject |   | OwnerDefault  |   |   |
| intName |   | "mapKeyPref" |   |   |
| storeValue |   | int Map Key Pref | Variable |   |

##### 2. IntSwitch

Full Name: HutongGames.PlayMaker.Actions.IntSwitch
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Map Key Pref | Variable |   |
| compareTo |   | FSMViewAvalonia2.FsmArray2 |   |   |
| sendEvent |   | FSMViewAvalonia2.FsmArray2 |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| KEY AND PIN | Key And Pin | 0 | |
| PIN | Pin | 0 | |
| NONE | None | 0 | |

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
| gameObject |   | OwnerDefault FSM Owner |   |   |
| cullingMask |   | FSMViewAvalonia2.FsmArray2 | Layer |   |
| invertMask |   | false |   |   |
| everyFrame |   | false |   |   |

#### Transitions

(none)

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
| gameObject |   | OwnerDefault FSM Owner |   |   |
| cullingMask |   | FSMViewAvalonia2.FsmArray2 | Layer |   |
| invertMask |   | false |   |   |
| everyFrame |   | false |   |   |

#### Transitions

(none)

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
| FINISHED | Instantiate | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| ACTION | false |
| FINISHED | false |
| KEY AND PIN | false |
| MAP KEY DOWN | false |
| NONE | false |
| PIN | false |

