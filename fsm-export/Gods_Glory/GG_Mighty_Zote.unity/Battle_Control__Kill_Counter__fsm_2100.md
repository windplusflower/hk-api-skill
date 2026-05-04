# Kill Counter

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Kill Counter |
| GameObject Name | Battle Control |
| GameObject Path |   |
| Source Asset | D:/SteamLibrary/steamapps/common/Hollow Knight/hollow_knight_Data/level481 |
| Start State | Idle |
| FSM PathId | 2100 |
| GameObject PathId | 226 |

## Variables

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Kills | 0 | Int32: 0 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Counter Activated | false | Boolean: false |
| Is Gold | false | Boolean: false |

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| Text |   | String:  |
| Tick Anim | Counter Tick | String: Counter Tick |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Counter Flash | Battle Control/Counter Flash (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level481) | NamedAssetPPtr: [Battle Control/Counter Flash (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level481)] |
| Counter Icon | Battle Control/Counter Icon (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level481) | NamedAssetPPtr: [Battle Control/Counter Icon (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level481)] |
| Counter Text | Battle Control/Counter Text (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level481) | NamedAssetPPtr: [Battle Control/Counter Text (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level481)] |
| Event Sender | [null] | NamedAssetPPtr: [null] |

## States

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

(none)

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| ZOTE WARRIOR KILLED | Increment | 0 | |
| ZOTELING KILLED | Increment | 0 | |

### Increment

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetEventSender

Full Name: HutongGames.PlayMaker.Actions.GetEventSender
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sentByGameObject |   | GameObject Event Sender | Variable |   |

##### 2. GetFsmInt

Full Name: HutongGames.PlayMaker.Actions.GetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| fsmName |   | "Control" | FsmName |   |
| variableName |   | "Kills" | FsmInt |   |
| storeValue |   | int Kills | Variable |   |
| everyFrame |   | false |   |   |

##### 3. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Kills | Variable |   |
| add |   | 1 |   |   |
| everyFrame |   | false |   |   |

##### 4. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| fsmName |   | "Control" | FsmName |   |
| variableName |   | "Kills" | FsmInt |   |
| setValue |   | int Kills |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Counter Active? | 0 | |

### Counter Active?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Counter Activated | Variable |   |
| isTrue |   | ACTIVATED |   |   |
| isFalse |   |   |   |   |
| everyFrame |   | false |   |   |

##### 2. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Counter Activated | Variable |   |
| boolValue |   | true |   |   |
| everyFrame |   | false |   |   |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Counter Icon |   |   |
| activate |   | true |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| ACTIVATED | Do Gold? | 0 | |
| FINISHED | Set Text | 0 | |

### Set Text

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. ConvertIntToString

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Kills | Variable |   |
| stringVariable |   | string Text | Variable |   |
| format |   | "" |   |   |
| everyFrame |   | false |   |   |

##### 2. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Counter Text |   |   |
| textString |   | string Text |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Idle | 0 | |

### Counter Tick

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Counter Icon |   |   |
| animLibName |   | "" |   |   |
| clipName |   | string Tick Anim = "Counter Tick" |   |   |

##### 2. Tk2dPlayFrame

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayFrame
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Counter Icon |   |   |
| frame |   | 0 |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Set Text | 0 | |

### Do Gold?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Is Gold | Variable |   |
| isTrue |   | FINISHED |   |   |
| isFalse |   |   |   |   |
| everyFrame |   | false |   |   |

##### 2. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Kills |   |   |
| integer2 |   | 57 |   |   |
| equal |   | GOLD |   |   |
| lessThan |   |   |   |   |
| greaterThan |   | GOLD |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Counter Tick | 0 | |
| GOLD | Become Gold | 0 | |

### Become Gold

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Is Gold | Variable |   |
| boolValue |   | true |   |   |
| everyFrame |   | false |   |   |

##### 2. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Counter Flash |   |   |
| activate |   | true |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 3. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable |   | string Tick Anim = "Counter Tick" | Variable |   |
| stringValue |   | "Counter Tick Gold" | TextArea |   |
| everyFrame |   | false |   |   |

##### 4. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer |   | [Global] [Audio Player Actor 2D (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | [Global] GameObject Hero |   |   |
| audioClip |   | [boss_stun (AudioClip) (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\resources.assets)] |   |   |
| pitchMin |   | 1.25f |   |   |
| pitchMax |   | 1.25f |   |   |
| volume |   | 1f |   |   |
| delay |   | 0f |   |   |
| storePlayer |   |   |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Counter Tick | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| ACTIVATED | false |
| FINISHED | false |
| GOLD | false |
| ZOTE WARRIOR KILLED | false |
| ZOTELING KILLED | false |

