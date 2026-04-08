# Geo Pool

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Geo Pool |
| GameObject Name | Unnamed |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets32.assets |
| Start State | Init |
| FSM PathId | 681 |
| GameObject PathId |  |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Centre X | 102.51 | Single: 102.51 |
| Fling X | 0 | Single: 0 |
| Fling Y | 0 | Single: 0 |
| Spawn X | 0 | Single: 0 |

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Decrement | 0 | Int32: 0 |
| Geo Value | 0 | Int32: 0 |
| Pool Min | 0 | Int32: 0 |
| Starting Pool | 0 | Int32: 0 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Shiny Item | false | Boolean: false |

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| Completion PD Bool |  | String:  |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Geo Object | [null] | NamedAssetPPtr:  |
| Geo Type | [null] | NamedAssetPPtr:  |
| Reward | [null] | NamedAssetPPtr:  |
| Shiny Obj | [null] | NamedAssetPPtr:  |
| Spawn | [null] | NamedAssetPPtr:  |
| Throw 1 | [null] | NamedAssetPPtr:  |
| Throw 2 | [null] | NamedAssetPPtr:  |
| Throw 3 | [null] | NamedAssetPPtr:  |
| Throw 4 | [null] | NamedAssetPPtr:  |
| Throw 5 | [null] | NamedAssetPPtr:  |
| Throw 6 | [null] | NamedAssetPPtr:  |
| Walls | [null] | NamedAssetPPtr:  |

## States

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

_None_

### Decrement

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. IntOperator

Full Name: HutongGames.PlayMaker.Actions.IntOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Starting Pool | int Starting Pool |  |  |
| integer2 | int Decrement | int Decrement |  |  |
| operation | HutongGames.PlayMaker.Actions.IntOperator/Operation::Subtract | 1 |  |  |
| storeResult | int Starting Pool | int Starting Pool | Variable |  |
| everyFrame | false | false |  |  |

##### 2. IntClamp

Full Name: HutongGames.PlayMaker.Actions.IntClamp
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Starting Pool | int Starting Pool | Variable |  |
| minValue | int Pool Min | int Pool Min |  |  |
| maxValue | 99999999 | 99999999 |  |  |
| everyFrame | false | false |  |  |

##### 3. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Starting Pool | int Starting Pool |  |  |
| integer2 | int Pool Min | int Pool Min |  |  |
| equal | Event(MIN) | Event(MIN) |  |  |
| lessThan | Event(MIN) | Event(MIN) |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

### At min

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

_None_

### Give

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 6

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Starting Pool | int Starting Pool |  |  |
| integer2 | 0 | 0 |  |  |
| equal | Event(COMPLETED) | Event(COMPLETED) |  |  |
| lessThan | Event(COMPLETED) | Event(COMPLETED) |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 2. StringSwitch

Full Name: HutongGames.PlayMaker.Actions.StringSwitch
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Completion PD Bool | string Completion PD Bool | Variable |  |
| compareTo | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| sendEvent | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| everyFrame | false | false |  |  |

##### 3. SendRandomEvent

Full Name: HutongGames.PlayMaker.Actions.SendRandomEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| events | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| weights | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| delay | 0f | 0f |  |  |

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
| childName | "Walls" | "Walls" |  |  |
| storeResult | GameObject Walls | GameObject Walls | Variable |  |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Reward" | "Reward" |  |  |
| storeResult | GameObject Reward | GameObject Reward | Variable |  |

##### 3. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Reward | OwnerDefault Reward |  |  |
| childName | "Throw 1" | "Throw 1" |  |  |
| storeResult | GameObject Throw 1 | GameObject Throw 1 | Variable |  |

##### 4. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Reward | OwnerDefault Reward |  |  |
| childName | "Throw 2" | "Throw 2" |  |  |
| storeResult | GameObject Throw 2 | GameObject Throw 2 | Variable |  |

##### 5. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Reward | OwnerDefault Reward |  |  |
| childName | "Throw 3" | "Throw 3" |  |  |
| storeResult | GameObject Throw 3 | GameObject Throw 3 | Variable |  |

##### 6. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Reward | OwnerDefault Reward |  |  |
| childName | "Throw 4" | "Throw 4" |  |  |
| storeResult | GameObject Throw 4 | GameObject Throw 4 | Variable |  |

##### 7. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Reward | OwnerDefault Reward |  |  |
| childName | "Throw 5" | "Throw 5" |  |  |
| storeResult | GameObject Throw 5 | GameObject Throw 5 | Variable |  |

##### 8. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Reward | OwnerDefault Reward |  |  |
| childName | "Throw 6" | "Throw 6" |  |  |
| storeResult | GameObject Throw 6 | GameObject Throw 6 | Variable |  |

### Open Gates

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(BroadcastAll):FSM Owner | EventTarget(BroadcastAll):FSM Owner |  |  |
| sendEvent | "GATE OPEN" | "GATE OPEN" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Walls | OwnerDefault Walls |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 3. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor 2D (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor 2D (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | [Global] GameObject Hero | [Global] GameObject Hero |  |  |
| audioClip | [switch_gate_gate (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets30.assets)] | [switch_gate_gate (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets30.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

### Small

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetGameObject

Full Name: HutongGames.PlayMaker.Actions.SetGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variable | GameObject Geo Type | GameObject Geo Type | Variable |  |
| gameObject | [Global] [Geo Small (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Geo Small (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| everyFrame | false | false |  |  |

##### 2. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Geo Value | int Geo Value | Variable |  |
| intValue | 1 | 1 |  |  |
| everyFrame | false | false |  |  |

### Med

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetGameObject

Full Name: HutongGames.PlayMaker.Actions.SetGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variable | GameObject Geo Type | GameObject Geo Type | Variable |  |
| gameObject | [Global] [Geo Med (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Geo Med (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| everyFrame | false | false |  |  |

##### 2. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Geo Value | int Geo Value | Variable |  |
| intValue | 5 | 5 |  |  |
| everyFrame | false | false |  |  |

### Large

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetGameObject

Full Name: HutongGames.PlayMaker.Actions.SetGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variable | GameObject Geo Type | GameObject Geo Type | Variable |  |
| gameObject | [Global] [Geo Large (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Geo Large (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| everyFrame | false | false |  |  |

##### 2. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Geo Value | int Geo Value | Variable |  |
| intValue | 25 | 25 |  |  |
| everyFrame | false | false |  |  |

### Spawn

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. CreateObject

Full Name: HutongGames.PlayMaker.Actions.CreateObject
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Geo Type | GameObject Geo Type |  |  |
| spawnPoint | GameObject Spawn | GameObject Spawn |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| rotation | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| storeObject | GameObject Geo Object | GameObject Geo Object | Variable |  |
| networkInstantiate | false | false |  |  |
| networkGroup | 0 | 0 |  |  |

##### 2. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Geo Type | GameObject Geo Type |  |  |
| spawnPoint | GameObject Spawn | GameObject Spawn |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| rotation | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| storeObject | GameObject Geo Object | GameObject Geo Object | Variable |  |

##### 3. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min | 30f | 30f |  |  |
| max | 35f | 35f |  |  |
| storeResult | float Fling Y | float Fling Y | Variable |  |

##### 4. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Geo Object | OwnerDefault Geo Object |  |  |
| vector | Vector2(0, 0) | Vector2(0, 0) |  |  |
| x | float Fling X | float Fling X |  |  |
| y | float Fling Y | float Fling Y |  |  |
| everyFrame | false | false |  |  |

##### 5. IntOperator

Full Name: HutongGames.PlayMaker.Actions.IntOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Starting Pool | int Starting Pool |  |  |
| integer2 | int Geo Value | int Geo Value |  |  |
| operation | HutongGames.PlayMaker.Actions.IntOperator/Operation::Subtract | 1 |  |  |
| storeResult | int Starting Pool | int Starting Pool | Variable |  |
| everyFrame | false | false |  |  |

##### 6. WaitRandom

Full Name: HutongGames.PlayMaker.Actions.WaitRandom
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| timeMin | 0.01f | 0.01f |  |  |
| timeMax | 0.02f | 0.02f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Throw Direction

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GetRandomChild

Full Name: HutongGames.PlayMaker.Actions.GetRandomChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Reward | OwnerDefault Reward |  |  |
| storeResult | GameObject Spawn | GameObject Spawn | Variable |  |

##### 2. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Spawn | OwnerDefault Spawn |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | float Spawn X | float Spawn X | Variable |  |
| y | 0f | 0f | Variable |  |
| z | 0f | 0f | Variable |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |

##### 3. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float Spawn X | float Spawn X |  |  |
| float2 | float Centre X | float Centre X |  |  |
| tolerance | 0f | 0f |  |  |
| equal | Event(R) | Event(R) |  |  |
| lessThan | Event(R) | Event(R) |  |  |
| greaterThan | Event(L) | Event(L) |  |  |
| everyFrame | false | false |  |  |

### Fling R

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min | 1f | 1f |  |  |
| max | 15f | 15f |  |  |
| storeResult | float Fling X | float Fling X | Variable |  |

### Fling L

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min | -15f | -15f |  |  |
| max | -1f | -1f |  |  |
| storeResult | float Fling X | float Fling X | Variable |  |

### Give Shiny?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(BroadcastAll):FSM Owner | EventTarget(BroadcastAll):FSM Owner |  |  |
| sendEvent | "CROWD IDLE" | "CROWD IDLE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Shiny Item | bool Shiny Item | Variable |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(NO) | Event(NO) |  |  |
| everyFrame | false | false |  |  |

##### 3. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | string Completion PD Bool | string Completion PD Bool |  |  |
| isTrue | Event(NO) | Event(NO) |  |  |
| isFalse | Event() | Event() |  |  |

##### 4. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Shiny Item" | "Shiny Item" |  |  |
| storeResult | GameObject Shiny Obj | GameObject Shiny Obj | Variable |  |

##### 5. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Shiny Obj | OwnerDefault Shiny Obj |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

### Geo Given Pause

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 1f | 1f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Achieve Check

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName | string Completion PD Bool | string Completion PD Bool |  |  |
| value | true | true |  |  |

##### 2. StringSwitch

Full Name: HutongGames.PlayMaker.Actions.StringSwitch
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Completion PD Bool | string Completion PD Bool | Variable |  |
| compareTo | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| sendEvent | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | Event(BRONZE) | Event(BRONZE) |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Bronze

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
| methodName | "AwardAchievement" | "AwardAchievement" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var | Var | Variable | Store Result |

### Silver

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
| methodName | "AwardAchievement" | "AwardAchievement" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var | Var | Variable | Store Result |

### Gold

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName | string Completion PD Bool | string Completion PD Bool |  |  |
| value | true | true |  |  |

##### 2. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| behaviour | "GameManager" | "GameManager" | Behaviour |  |
| methodName | "AwardAchievement" | "AwardAchievement" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var | Var | Variable | Store Result |

### Gold Geo

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SendRandomEvent

Full Name: HutongGames.PlayMaker.Actions.SendRandomEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| events | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| weights | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| delay | 0f | 0f |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Idle | HERO DAMAGED | Decrement | 0 | 0 | 0 |
| Decrement | FINISHED | Idle | 0 | 0 | 0 |
| Decrement | MIN | At min | 0 | 0 | 0 |
| Give | SMALL | Small | 0 | 0 | 0 |
| Give | MED | Med | 0 | 0 | 0 |
| Give | LARGE | Large | 0 | 0 | 0 |
| Give | COMPLETED | Achieve Check | 0 | 0 | 0 |
| Give | GOLD | Gold Geo | 0 | 0 | 0 |
| Give | SILVER | Gold Geo | 0 | 0 | 0 |
| Init | FINISHED | Idle | 0 | 0 | 0 |
| Small | FINISHED | Throw Direction | 0 | 0 | 0 |
| Med | FINISHED | Throw Direction | 0 | 0 | 0 |
| Large | FINISHED | Throw Direction | 0 | 0 | 0 |
| Spawn | FINISHED | Give | 0 | 0 | 0 |
| Throw Direction | R | Fling R | 0 | 0 | 0 |
| Throw Direction | L | Fling L | 0 | 0 | 0 |
| Fling R | FINISHED | Spawn | 0 | 0 | 0 |
| Fling L | FINISHED | Spawn | 0 | 0 | 0 |
| Give Shiny? | NO | Geo Given Pause | 0 | 0 | 0 |
| Give Shiny? | SHINY PICKED UP | Open Gates | 0 | 0 | 0 |
| Geo Given Pause | FINISHED | Open Gates | 0 | 0 | 0 |
| Achieve Check | BRONZE | Bronze | 0 | 0 | 0 |
| Achieve Check | SILVER | Silver | 0 | 0 | 0 |
| Achieve Check | GOLD | Gold | 0 | 0 | 0 |
| Bronze | FINISHED | Give Shiny? | 0 | 0 | 0 |
| Silver | FINISHED | Give Shiny? | 0 | 0 | 0 |
| Gold | FINISHED | Give Shiny? | 0 | 0 | 0 |
| Gold Geo | MED | Med | 0 | 0 | 0 |
| Gold Geo | LARGE | Large | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| GIVE GEO | Give | 0 | 0 | 0 |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| BRONZE | false |
| COMPLETED | false |
| GIVE GEO | false |
| GOLD | false |
| HERO DAMAGED | true |
| L | false |
| LARGE | false |
| MED | false |
| MIN | false |
| NO | false |
| R | false |
| SHINY PICKED UP | false |
| SILVER | false |
| SMALL | false |

