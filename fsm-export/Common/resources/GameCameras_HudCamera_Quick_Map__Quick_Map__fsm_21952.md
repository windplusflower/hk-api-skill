# Quick Map

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Quick Map |
| GameObject Name | Quick Map |
| GameObject Path | _GameCameras/HudCamera |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Globalise |
| FSM PathId | 21952 |
| GameObject PathId | 4027 |

## Variables

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Map Key Pref | 0 | Int32: 0 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| In Room | false | Boolean: false |

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| Area Name |  | String:  |
| Map Zone |  | String:  |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Area Name Txt | [null] | NamedAssetPPtr:  |
| BG | [null] | NamedAssetPPtr:  |
| No Map Msg | [null] | NamedAssetPPtr:  |
| Self | [null] | NamedAssetPPtr:  |

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
| childName | "No Map" | "No Map" |  |  |
| storeResult | GameObject No Map Msg | GameObject No Map Msg | Variable |  |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "BG" | "BG" |  |  |
| storeResult | GameObject BG | GameObject BG | Variable |  |

##### 3. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Area Name" | "Area Name" |  |  |
| storeResult | GameObject Area Name Txt | GameObject Area Name Txt | Variable |  |

##### 4. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault No Map Msg | OwnerDefault No Map Msg |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 5. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Area Name Txt | OwnerDefault Area Name Txt |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

_None_

### Check Area

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 28

#### Actions

##### 1. SetScale

Full Name: HutongGames.PlayMaker.Actions.SetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Game Map | OwnerDefault Game Map |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 1.55f | 1.55f |  |  |
| y | 1.55f | 1.55f |  |  |
| z | 0f | 0f |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | string Map Zone | string Map Zone |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | "NONE" | "NONE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Crossroads

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
| isTrue | Event() | Event() |  |  |
| isFalse | Event(NO MAP) | Event(NO MAP) |  |  |

##### 2. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Map Zones" | "Map Zones" |  |  |
| convName | "CROSSROADS" | "CROSSROADS" |  |  |
| storeValue | string Area Name | string Area Name | Variable |  |

##### 3. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Area Name Txt | OwnerDefault Area Name Txt |  |  |
| textString | string Area Name | string Area Name |  |  |

##### 4. FadeGroupUp

Full Name: FadeGroupUp
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault Area Name Txt | OwnerDefault Area Name Txt | Variable |  |

##### 5. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:Area Name Txt | EventTarget(GameObject)[SendToChildren]:Area Name Txt |  |  |
| sendEvent | "UP" | "UP" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 6. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Game Map | OwnerDefault Game Map |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | QuickMapCrossroads(???) | QuickMapCrossroads(???) |  |  |

##### 7. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Game Map | OwnerDefault Game Map |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | -0.04f | -0.04f |  |  |
| y | -7.88f | -7.88f |  |  |
| z | 18f | 18f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

### No Map

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. FadeGroupUp

Full Name: FadeGroupUp
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault No Map Msg | OwnerDefault No Map Msg | Variable |  |

### Close

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Game Map | OwnerDefault Game Map |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | CloseQuickMap(???) | CloseQuickMap(???) |  |  |

##### 2. FadeGroupDown

Full Name: FadeGroupDown
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault Area Name Txt | OwnerDefault Area Name Txt | Variable |  |
| fast | false | false |  |  |

##### 3. FadeGroupDown

Full Name: FadeGroupDown
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault BG | OwnerDefault BG | Variable |  |
| fast | false | false |  |  |

##### 4. FadeGroupDown

Full Name: FadeGroupDown
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault No Map Msg | OwnerDefault No Map Msg | Variable |  |
| fast | false | false |  |  |

### Greenpath

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
| isTrue | Event() | Event() |  |  |
| isFalse | Event(NO MAP) | Event(NO MAP) |  |  |

##### 2. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Map Zones" | "Map Zones" |  |  |
| convName | "GREEN_PATH" | "GREEN_PATH" |  |  |
| storeValue | string Area Name | string Area Name | Variable |  |

##### 3. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Area Name Txt | OwnerDefault Area Name Txt |  |  |
| textString | string Area Name | string Area Name |  |  |

##### 4. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Game Map | OwnerDefault Game Map |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | QuickMapGreenpath(???) | QuickMapGreenpath(???) |  |  |

##### 5. FadeGroupUp

Full Name: FadeGroupUp
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault Area Name Txt | OwnerDefault Area Name Txt | Variable |  |

##### 6. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Game Map | OwnerDefault Game Map |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 16.31f | 16.31f |  |  |
| y | -7.87f | -7.87f |  |  |
| z | 18f | 18f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

### Fungal Wastes

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
| isTrue | Event() | Event() |  |  |
| isFalse | Event(NO MAP) | Event(NO MAP) |  |  |

##### 2. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Map Zones" | "Map Zones" |  |  |
| convName | "WASTES" | "WASTES" |  |  |
| storeValue | string Area Name | string Area Name | Variable |  |

##### 3. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Area Name Txt | OwnerDefault Area Name Txt |  |  |
| textString | string Area Name | string Area Name |  |  |

##### 4. FadeGroupUp

Full Name: FadeGroupUp
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault Area Name Txt | OwnerDefault Area Name Txt | Variable |  |

##### 5. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Game Map | OwnerDefault Game Map |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | QuickMapFungalWastes(???) | QuickMapFungalWastes(???) |  |  |

##### 6. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Game Map | OwnerDefault Game Map |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 5.05f | 5.05f |  |  |
| y | 0.47f | 0.47f |  |  |
| z | 18f | 18f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

### Open

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Game Map | OwnerDefault Game Map |  |  |
| fsmName | "Map FSM State" | "Map FSM State" | FsmName |  |
| variableName | "Display Next Area" | "Display Next Area" | FsmBool |  |
| setValue | true | true |  |  |
| everyFrame | false | false |  |  |

##### 2. SetCameraCullingMask

Full Name: HutongGames.PlayMaker.Actions.SetCameraCullingMask
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault HUD Camera | OwnerDefault HUD Camera |  |  |
| cullingMask | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 | Layer |  |
| invertMask | false | false |  |  |
| everyFrame | false | false |  |  |

##### 3. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.2f | 0.2f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

##### 4. FadeGroupUp

Full Name: FadeGroupUp
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault BG | OwnerDefault BG | Variable |  |

### Dirtmouth

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Map Zones" | "Map Zones" |  |  |
| convName | "TOWN" | "TOWN" |  |  |
| storeValue | string Area Name | string Area Name | Variable |  |

##### 2. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Area Name Txt | OwnerDefault Area Name Txt |  |  |
| textString | string Area Name | string Area Name |  |  |

##### 3. FadeGroupUp

Full Name: FadeGroupUp
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault Area Name Txt | OwnerDefault Area Name Txt | Variable |  |

##### 4. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Game Map | OwnerDefault Game Map |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | QuickMapDirtmouth(???) | QuickMapDirtmouth(???) |  |  |

##### 5. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Game Map | OwnerDefault Game Map |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 4.07f | 4.07f |  |  |
| y | -11.62f | -11.62f |  |  |
| z | 18f | 18f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

### Reset Override

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool In Room | bool In Room | Variable |  |
| boolValue | false | false |  |  |
| everyFrame | false | false |  |  |

### In Room?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool In Room | bool In Room | Variable |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(FINISHED) | Event(FINISHED) |  |  |
| everyFrame | false | false |  |  |

##### 2. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Game Map | OwnerDefault Game Map |  |  |
| behaviour | "GameMap" | "GameMap" | Behaviour |  |
| methodName | "GetDoorMapZone" | "GetDoorMapZone" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var Map Zone =  | Var Map Zone =  | Variable | Store Result |

### Get Map Zone

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| behaviour | "GameManager" | "GameManager" | Behaviour |  |
| methodName | "GetCurrentMapZone" | "GetCurrentMapZone" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var Map Zone =  | Var Map Zone =  | Variable | Store Result |

### Globalise

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

##### 2. SetGameObject

Full Name: HutongGames.PlayMaker.Actions.SetGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variable | [Global] GameObject Quick Map | [Global] GameObject Quick Map | Variable |  |
| gameObject | GameObject Self | GameObject Self |  |  |
| everyFrame | false | false |  |  |

### Cliffs

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
| isTrue | Event() | Event() |  |  |
| isFalse | Event(NO MAP) | Event(NO MAP) |  |  |

##### 2. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Map Zones" | "Map Zones" |  |  |
| convName | "CLIFFS" | "CLIFFS" |  |  |
| storeValue | string Area Name | string Area Name | Variable |  |

##### 3. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Area Name Txt | OwnerDefault Area Name Txt |  |  |
| textString | string Area Name | string Area Name |  |  |

##### 4. FadeGroupUp

Full Name: FadeGroupUp
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault Area Name Txt | OwnerDefault Area Name Txt | Variable |  |

##### 5. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Game Map | OwnerDefault Game Map |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | QuickMapCliffs(???) | QuickMapCliffs(???) |  |  |

##### 6. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Game Map | OwnerDefault Game Map |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 13.89f | 13.89f |  |  |
| y | -14.17f | -14.17f |  |  |
| z | 18f | 18f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

### City

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
| isTrue | Event() | Event() |  |  |
| isFalse | Event(NO MAP) | Event(NO MAP) |  |  |

##### 2. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Map Zones" | "Map Zones" |  |  |
| convName | "CITY" | "CITY" |  |  |
| storeValue | string Area Name | string Area Name | Variable |  |

##### 3. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Area Name Txt | OwnerDefault Area Name Txt |  |  |
| textString | string Area Name | string Area Name |  |  |

##### 4. FadeGroupUp

Full Name: FadeGroupUp
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault Area Name Txt | OwnerDefault Area Name Txt | Variable |  |

##### 5. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Game Map | OwnerDefault Game Map |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | QuickMapCity(???) | QuickMapCity(???) |  |  |

##### 6. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Game Map | OwnerDefault Game Map |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | -11.98f | -11.98f |  |  |
| y | 0.65f | 0.65f |  |  |
| z | 18f | 18f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

### Mines

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
| isTrue | Event() | Event() |  |  |
| isFalse | Event(NO MAP) | Event(NO MAP) |  |  |

##### 2. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Map Zones" | "Map Zones" |  |  |
| convName | "MINES" | "MINES" |  |  |
| storeValue | string Area Name | string Area Name | Variable |  |

##### 3. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Area Name Txt | OwnerDefault Area Name Txt |  |  |
| textString | string Area Name | string Area Name |  |  |

##### 4. FadeGroupUp

Full Name: FadeGroupUp
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault Area Name Txt | OwnerDefault Area Name Txt | Variable |  |

##### 5. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Game Map | OwnerDefault Game Map |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | QuickMapCrystalPeak(???) | QuickMapCrystalPeak(???) |  |  |

##### 6. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Game Map | OwnerDefault Game Map |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | -9.17f | -9.17f |  |  |
| y | -12.8f | -12.8f |  |  |
| z | 18f | 18f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

### Resting Grounds

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
| isTrue | Event() | Event() |  |  |
| isFalse | Event(NO MAP) | Event(NO MAP) |  |  |

##### 2. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Map Zones" | "Map Zones" |  |  |
| convName | "RESTING_GROUNDS" | "RESTING_GROUNDS" |  |  |
| storeValue | string Area Name | string Area Name | Variable |  |

##### 3. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Area Name Txt | OwnerDefault Area Name Txt |  |  |
| textString | string Area Name | string Area Name |  |  |

##### 4. FadeGroupUp

Full Name: FadeGroupUp
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault Area Name Txt | OwnerDefault Area Name Txt | Variable |  |

##### 5. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Game Map | OwnerDefault Game Map |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | QuickMapRestingGrounds(???) | QuickMapRestingGrounds(???) |  |  |

##### 6. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Game Map | OwnerDefault Game Map |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | -14.6f | -14.6f |  |  |
| y | -7f | -7f |  |  |
| z | 18f | 18f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

### Fog Canyon

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
| isTrue | Event() | Event() |  |  |
| isFalse | Event(NO MAP) | Event(NO MAP) |  |  |

##### 2. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Map Zones" | "Map Zones" |  |  |
| convName | "FOG_CANYON" | "FOG_CANYON" |  |  |
| storeValue | string Area Name | string Area Name | Variable |  |

##### 3. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Area Name Txt | OwnerDefault Area Name Txt |  |  |
| textString | string Area Name | string Area Name |  |  |

##### 4. FadeGroupUp

Full Name: FadeGroupUp
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault Area Name Txt | OwnerDefault Area Name Txt | Variable |  |

##### 5. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Game Map | OwnerDefault Game Map |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | QuickMapFogCanyon(???) | QuickMapFogCanyon(???) |  |  |

##### 6. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Game Map | OwnerDefault Game Map |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 11.3f | 11.3f |  |  |
| y | -3.3f | -3.3f |  |  |
| z | 18f | 18f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

### Royal Gardens

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
| isTrue | Event() | Event() |  |  |
| isFalse | Event(NO MAP) | Event(NO MAP) |  |  |

##### 2. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Map Zones" | "Map Zones" |  |  |
| convName | "ROYAL_GARDENS" | "ROYAL_GARDENS" |  |  |
| storeValue | string Area Name | string Area Name | Variable |  |

##### 3. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Area Name Txt | OwnerDefault Area Name Txt |  |  |
| textString | string Area Name | string Area Name |  |  |

##### 4. FadeGroupUp

Full Name: FadeGroupUp
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault Area Name Txt | OwnerDefault Area Name Txt | Variable |  |

##### 5. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Game Map | OwnerDefault Game Map |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | QuickMapQueensGardens(???) | QuickMapQueensGardens(???) |  |  |

##### 6. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Game Map | OwnerDefault Game Map |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 19.7f | 19.7f |  |  |
| y | -0.3f | -0.3f |  |  |
| z | 18f | 18f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

### Deepnest

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
| isTrue | Event() | Event() |  |  |
| isFalse | Event(NO MAP) | Event(NO MAP) |  |  |

##### 2. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Map Zones" | "Map Zones" |  |  |
| convName | "DEEPNEST" | "DEEPNEST" |  |  |
| storeValue | string Area Name | string Area Name | Variable |  |

##### 3. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Area Name Txt | OwnerDefault Area Name Txt |  |  |
| textString | string Area Name | string Area Name |  |  |

##### 4. FadeGroupUp

Full Name: FadeGroupUp
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault Area Name Txt | OwnerDefault Area Name Txt | Variable |  |

##### 5. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Game Map | OwnerDefault Game Map |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | QuickMapDeepnest(???) | QuickMapDeepnest(???) |  |  |

##### 6. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Game Map | OwnerDefault Game Map |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 16f | 16f |  |  |
| y | 6.7f | 6.7f |  |  |
| z | 18f | 18f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

### Waterways

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
| isTrue | Event() | Event() |  |  |
| isFalse | Event(NO MAP) | Event(NO MAP) |  |  |

##### 2. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Map Zones" | "Map Zones" |  |  |
| convName | "WATERWAYS" | "WATERWAYS" |  |  |
| storeValue | string Area Name | string Area Name | Variable |  |

##### 3. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Area Name Txt | OwnerDefault Area Name Txt |  |  |
| textString | string Area Name | string Area Name |  |  |

##### 4. FadeGroupUp

Full Name: FadeGroupUp
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault Area Name Txt | OwnerDefault Area Name Txt | Variable |  |

##### 5. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Game Map | OwnerDefault Game Map |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | QuickMapWaterways(???) | QuickMapWaterways(???) |  |  |

##### 6. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Game Map | OwnerDefault Game Map |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | -8.1f | -8.1f |  |  |
| y | 7.4f | 7.4f |  |  |
| z | 18f | 18f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

### Abyss

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
| isTrue | Event() | Event() |  |  |
| isFalse | Event(NO MAP) | Event(NO MAP) |  |  |

##### 2. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Map Zones" | "Map Zones" |  |  |
| convName | "ABYSS" | "ABYSS" |  |  |
| storeValue | string Area Name | string Area Name | Variable |  |

##### 3. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Area Name Txt | OwnerDefault Area Name Txt |  |  |
| textString | string Area Name | string Area Name |  |  |

##### 4. FadeGroupUp

Full Name: FadeGroupUp
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault Area Name Txt | OwnerDefault Area Name Txt | Variable |  |

##### 5. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Game Map | OwnerDefault Game Map |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | QuickMapAncientBasin(???) | QuickMapAncientBasin(???) |  |  |

##### 6. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Game Map | OwnerDefault Game Map |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | -8.3f | -8.3f |  |  |
| y | 14.6f | 14.6f |  |  |
| z | 18f | 18f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

### Outskirts

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
| isTrue | Event() | Event() |  |  |
| isFalse | Event(NO MAP) | Event(NO MAP) |  |  |

##### 2. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Map Zones" | "Map Zones" |  |  |
| convName | "OUTSKIRTS" | "OUTSKIRTS" |  |  |
| storeValue | string Area Name | string Area Name | Variable |  |

##### 3. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Area Name Txt | OwnerDefault Area Name Txt |  |  |
| textString | string Area Name | string Area Name |  |  |

##### 4. FadeGroupUp

Full Name: FadeGroupUp
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault Area Name Txt | OwnerDefault Area Name Txt | Variable |  |

##### 5. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Game Map | OwnerDefault Game Map |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | QuickMapKingdomsEdge(???) | QuickMapKingdomsEdge(???) |  |  |

##### 6. SetScale

Full Name: HutongGames.PlayMaker.Actions.SetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Game Map | OwnerDefault Game Map |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 1.45f | 1.45f |  |  |
| y | 1.45f | 1.45f |  |  |
| z | 0f | 0f |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 7. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Game Map | OwnerDefault Game Map |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | -21.9f | -21.9f |  |  |
| y | 4f | 4f |  |  |
| z | 18f | 18f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

### Check State

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
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

### Pin On

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetCameraCullingMask

Full Name: HutongGames.PlayMaker.Actions.SetCameraCullingMask
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault HUD Camera | OwnerDefault HUD Camera |  |  |
| cullingMask | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 | Layer |  |
| invertMask | false | false |  |  |
| everyFrame | false | false |  |  |

### Pin Off

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetCameraCullingMask

Full Name: HutongGames.PlayMaker.Actions.SetCameraCullingMask
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault HUD Camera | OwnerDefault HUD Camera |  |  |
| cullingMask | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 | Layer |  |
| invertMask | false | false |  |  |
| everyFrame | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Init | FINISHED | Idle | 0 | 0 | 0 |
| Idle | OPEN QUICK MAP | Open | 0 | 0 | 0 |
| Check Area | CROSSROADS | Crossroads | 0 | 0 | 0 |
| Check Area | FOG_CANYON | Fog Canyon | 0 | 0 | 0 |
| Check Area | GREEN_PATH | Greenpath | 0 | 0 | 0 |
| Check Area | WASTES | Fungal Wastes | 0 | 0 | 0 |
| Check Area | CITY | City | 0 | 0 | 0 |
| Check Area | WATERWAYS | Waterways | 0 | 0 | 0 |
| Check Area | MINES | Mines | 0 | 0 | 0 |
| Check Area | DEEPNEST | Deepnest | 0 | 0 | 0 |
| Check Area | TOWN | Dirtmouth | 0 | 0 | 0 |
| Check Area | CLIFFS | Cliffs | 0 | 0 | 0 |
| Check Area | NONE | No Map | 0 | 0 | 0 |
| Check Area | TEST_AREA | No Map | 0 | 0 | 0 |
| Check Area | KINGS_PASS | Dirtmouth | 0 | 0 | 0 |
| Check Area | ROYAL_GARDENS | Royal Gardens | 0 | 0 | 0 |
| Check Area | SHAMAN_TEMPLE | Crossroads | 0 | 0 | 0 |
| Check Area | QUEENS_STATION | Fungal Wastes | 0 | 0 | 0 |
| Check Area | RESTING_GROUNDS | Resting Grounds | 0 | 0 | 0 |
| Check Area | ABYSS | Abyss | 0 | 0 | 0 |
| Check Area | KINGS_STATION | City | 0 | 0 | 0 |
| Check Area | OUTSKIRTS | Outskirts | 0 | 0 | 0 |
| Check Area | HIVE | Outskirts | 0 | 0 | 0 |
| Check Area | COLOSSEUM | Outskirts | 0 | 0 | 0 |
| Check Area | SOUL_SOCIETY | City | 0 | 0 | 0 |
| Check Area | MONOMON_ARCHIVE | Fog Canyon | 0 | 0 | 0 |
| Check Area | BEASTS_DEN | Deepnest | 0 | 0 | 0 |
| Check Area | LURIENS_TOWER | City | 0 | 0 | 0 |
| Check Area | FINISHED | No Map | 0 | 0 | 0 |
| Check Area | GODSEEKER_WASTE | Waterways | 0 | 0 | 0 |
| Crossroads | CLOSE QUICK MAP | Check State | 0 | 0 | 0 |
| No Map | CLOSE QUICK MAP | Check State | 0 | 0 | 0 |
| Close | OPEN QUICK MAP | Open | 0 | 0 | 0 |
| Greenpath | CLOSE QUICK MAP | Check State | 0 | 0 | 0 |
| Fungal Wastes | CLOSE QUICK MAP | Check State | 0 | 0 | 0 |
| Open | FINISHED | Get Map Zone | 0 | 0 | 0 |
| Open | CLOSE QUICK MAP | Close | 0 | 0 | 0 |
| Dirtmouth | CLOSE QUICK MAP | Check State | 0 | 0 | 0 |
| Reset Override | FINISHED | Idle | 0 | 0 | 0 |
| In Room? | FINISHED | Check Area | 0 | 0 | 0 |
| Get Map Zone | FINISHED | In Room? | 0 | 0 | 0 |
| Globalise | FINISHED | Init | 0 | 0 | 0 |
| Cliffs | CLOSE QUICK MAP | Check State | 0 | 0 | 0 |
| City | CLOSE QUICK MAP | Check State | 0 | 0 | 0 |
| Mines | CLOSE QUICK MAP | Check State | 0 | 0 | 0 |
| Resting Grounds | CLOSE QUICK MAP | Check State | 0 | 0 | 0 |
| Fog Canyon | CLOSE QUICK MAP | Check State | 0 | 0 | 0 |
| Royal Gardens | CLOSE QUICK MAP | Check State | 0 | 0 | 0 |
| Deepnest | CLOSE QUICK MAP | Check State | 0 | 0 | 0 |
| Waterways | CLOSE QUICK MAP | Check State | 0 | 0 | 0 |
| Abyss | CLOSE QUICK MAP | Check State | 0 | 0 | 0 |
| Outskirts | CLOSE QUICK MAP | Check State | 0 | 0 | 0 |
| Check State | KEY AND PIN | Pin On | 0 | 0 | 0 |
| Check State | PIN | Pin On | 0 | 0 | 0 |
| Check State | NONE | Pin Off | 0 | 0 | 0 |
| Pin On | FINISHED | Close | 0 | 0 | 0 |
| Pin Off | FINISHED | Close | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| NO MAP | No Map | 0 | 0 | 0 |
| LEVEL LOADED | Reset Override | 0 | 0 | 0 |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| LEVEL LOADED | false |
| ABYSS | false |
| BEASTS_DEN | false |
| CITY | false |
| CLIFFS | false |
| CLOSE QUICK MAP | false |
| COLOSSEUM | false |
| CROSSROADS | false |
| DEEPNEST | false |
| FOG_CANYON | false |
| GODSEEKER_WASTE | false |
| GREEN_PATH | false |
| HIVE | false |
| KEY AND PIN | false |
| KINGS_PASS | false |
| KINGS_STATION | false |
| LURIENS_TOWER | false |
| MINES | false |
| MONOMON_ARCHIVE | false |
| NO MAP | false |
| NONE | false |
| OPEN QUICK MAP | false |
| OUTSKIRTS | false |
| PIN | false |
| QUEENS_STATION | false |
| RESTING_GROUNDS | false |
| ROYAL_GARDENS | false |
| SHAMAN_TEMPLE | false |
| SOUL_SOCIETY | false |
| TEST_AREA | false |
| TOWN | false |
| WASTES | false |
| WATERWAYS | false |

