# Check State

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Check State |
| GameObject Name | Bathhouse Door |
| GameObject Path |   |
| Source Asset | D:/SteamLibrary/steamapps/common/Hollow Knight/hollow_knight_Data/level116 |
| Start State | Pause |
| FSM PathId | 5081 |
| GameObject PathId | 661 |

## Variables

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Simple Keys | 0 | Int32: 0 |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Door Closed | Bathhouse Door/Closed (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level116) | NamedAssetPPtr: [Bathhouse Door/Closed (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level116)] |
| Door Object | Bathhouse Door/door_Ruin_Elevator (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level116) | NamedAssetPPtr: [Bathhouse Door/door_Ruin_Elevator (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level116)] |
| Door Open | Bathhouse Door/Open (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level116) | NamedAssetPPtr: [Bathhouse Door/Open (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level116)] |
| Inspect | Bathhouse Door/Inspect (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level116) | NamedAssetPPtr: [Bathhouse Door/Inspect (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level116)] |

## States

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
| FINISHED | Opened? | 0 | |

### Opened?

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
| boolName |   | "bathHouseOpened" |   |   |
| isTrue |   | Event(OPENED) |   |   |
| isFalse |   | Event() |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| OPENED | Opened | 0 | |
| FINISHED | Have Key? | 0 | |

### Opened

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Door Closed |   |   |
| activate |   | false |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 2. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inspect |   |   |
| activate |   | false |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Door Open |   |   |
| activate |   | false |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 4. SetCollider

Full Name: HutongGames.PlayMaker.Actions.SetCollider
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Door Object |   |   |
| active |   | true |   |   |

#### Transitions

(none)

### Have Key?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| boolName |   | "hasSpaKey" |   |   |
| isTrue |   | Event(KEY) |   |   |
| isFalse |   | Event(NO KEY) |   |   |

##### 2. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| intName |   | "simpleKeys" |   |   |
| storeValue |   | int Simple Keys | Variable |   |

##### 3. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Simple Keys |   |   |
| integer2 |   | 0 |   |   |
| equal |   | Event(NO KEY) |   |   |
| lessThan |   | Event(NO KEY) |   |   |
| greaterThan |   | Event(KEY) |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| KEY | Key | 0 | |
| NO KEY | No Key | 0 | |

### Key

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SetCollider

Full Name: HutongGames.PlayMaker.Actions.SetCollider
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Door Object |   |   |
| active |   | false |   |   |

#### Transitions

(none)

### No Key

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Door Object |   |   |
| activate |   | false |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 2. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Inspect |   |   |
| activate |   | false |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

#### Transitions

(none)

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| KEY | false |
| NO KEY | false |
| OPENED | false |

