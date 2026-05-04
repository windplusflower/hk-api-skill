# Hatchling Spawn

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Hatchling Spawn |
| GameObject Name | Charm Effects |
| GameObject Path | Knight/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level4 |
| Start State | Init |
| FSM PathId | 972 |
| GameObject PathId | 147 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Hatch Time | 4 | Single: 4 |

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Hatchling Max | 4 | Int32: 4 |
| Hatchlings | 0 | Int32: 0 |
| MP | 0 | Int32: 0 |
| Soul Cost | 8 | Int32: 8 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Dreamgate Entry | false | Boolean: false |
| Is Gameplay Scene | false | Boolean: false |
| Is Gameplay Scene | false | Boolean: false |
| No Charms | false | Boolean: false |

### Vector3s

| Name | Value | Raw/Type |
| --- | --- | --- |
| Hero Pos | Vector2(0, 0) | Vector2: Vector2(0, 0) |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Hatchling Obj | [null] | NamedAssetPPtr: [null] |

## States

### Init

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
| FINISHED | Check Equipped | 0 | |

### Check Equipped

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
| boolName |   | "equippedCharm_22" |   |   |
| isTrue |   | Event(EQUIPPED) |   |   |
| isFalse |   | Event(UNEQUIPPED) |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| EQUIPPED | Wait for Hero | 0 | |
| UNEQUIPPED | Unequipped | 0 | |

### Unequipped

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(BroadcastAll):FSM Owner |   |   |
| sendEvent |   | "K HATCHLING END" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

(none)

### Equipped

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | float Hatch Time |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Can Hatch? | 0 | |

### Can Hatch?

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
| boolName |   | "disablePause" |   |   |
| isTrue |   | Event(CANCEL) |   |   |
| isFalse |   | Event() |   |   |

##### 2. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| intName |   | "MPCharge" |   |   |
| storeValue |   | int MP | Variable |   |

##### 3. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int MP |   |   |
| integer2 |   | int Soul Cost |   |   |
| equal |   | Event() |   |   |
| lessThan |   | Event(CANCEL) |   |   |
| greaterThan |   | Event() |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| CANCEL | Equipped | 0 | |
| FINISHED | Check Count | 0 | |

### Check Count

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GetTagCount

Full Name: HutongGames.PlayMaker.Actions.GetTagCount
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| tag |   | "Knight Hatchling" | Tag |   |
| storeResult |   | int Hatchlings | Variable |   |

##### 2. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Hatchlings |   |   |
| integer2 |   | int Hatchling Max |   |   |
| equal |   | Event(CANCEL) |   |   |
| lessThan |   | Event(FINISHED) |   |   |
| greaterThan |   | Event(CANCEL) |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| CANCEL | Equipped | 0 | |
| FINISHED | Hatch | 0 | |

### Hatch

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Hero |   |   |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |   |   |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |   |   |
| functionCall |   | TakeMP(Soul Cost=int Soul Cost) |   |   |

##### 2. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Hero |   |   |
| vector |   | Vector3 Hero Pos | Variable |   |
| x |   | 0f | Variable |   |
| y |   | 0f | Variable |   |
| z |   | 0f | Variable |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |

##### 3. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Knight Hatchling (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   |   |   |   |
| position |   | Vector3 Hero Pos |   |   |
| rotation |   | Vector3(0, 0, 0) |   |   |
| storeObject |   | GameObject Hatchling Obj | Variable |   |

##### 4. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Hatchling Obj |   |   |
| vector |   | Vector3 Hero Pos | Variable |   |
| x |   | 0f |   |   |
| y |   | 0f |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Equipped | 0 | |

### Count Remaining

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. GetTagCount

Full Name: HutongGames.PlayMaker.Actions.GetTagCount
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| tag |   | "Knight Hatchling" | Tag |   |
| storeResult |   | int Hatchlings | Variable |   |

##### 2. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Hatchlings |   |   |
| integer2 |   | 0 |   |   |
| equal |   | Event(CANCEL) |   |   |
| lessThan |   | Event(CANCEL) |   |   |
| greaterThan |   | Event() |   |   |
| everyFrame |   | false |   |   |

##### 3. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Dreamgate Entry | Variable |   |
| isTrue |   | Event(DREAMGATE) |   |   |
| isFalse |   | Event() |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| LEVEL LOADED | Charms Allowed? | 0 | |
| DREAMGATE | Dreamgate Pause | 0 | |
| CANCEL | Check Equipped | 0 | |

### Respawn Check

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Hatchlings |   |   |
| integer2 |   | 0 |   |   |
| equal |   | Event(CANCEL) |   |   |
| lessThan |   | Event(CANCEL) |   |   |
| greaterThan |   | Event() |   |   |
| everyFrame |   | false |   |   |

##### 2. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | false | Variable |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event() |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| CANCEL | Check Equipped | 0 | |
| FINISHED | Respawn | 0 | |

### Respawn

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Knight Hatchling (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | [Global] GameObject Hero |   |   |
| position |   | Vector3(0, 0, 0) |   |   |
| rotation |   | Vector3(0, 0, 0) |   |   |
| storeObject |   | GameObject Hatchling Obj | Variable |   |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Hatchling Obj |   |   |
| sendEvent |   | "QUICK SPAWN" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 3. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Hatchlings | Variable |   |
| add |   | -1 |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Respawn Check | 0 | |

### Respawn Pause

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 0.1f |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |

##### 2. WaitForHeroInPosition

Full Name: WaitForHeroInPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent |   | Event(FINISHED) |   |   |
| skipIfAlreadyPositioned |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Respawn Check | 0 | |

### Dreamgate Pause

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Dreamgate Entry | Variable |   |
| boolValue |   | false |   |   |
| everyFrame |   | false |   |   |

##### 2. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 1f |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Respawn Check 2 | 0 | |

### Respawn Check 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Hatchlings |   |   |
| integer2 |   | 0 |   |   |
| equal |   | Event(CANCEL) |   |   |
| lessThan |   | Event(CANCEL) |   |   |
| greaterThan |   | Event() |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| CANCEL | Check Equipped | 0 | |
| FINISHED | Respawn 2 | 0 | |

### Respawn 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Knight Hatchling (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | [Global] GameObject Hero |   |   |
| position |   | Vector3(0, 0, 0) |   |   |
| rotation |   | Vector3(0, 0, 0) |   |   |
| storeObject |   | GameObject Hatchling Obj | Variable |   |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Hatchling Obj |   |   |
| sendEvent |   | "DREAMGATE SPAWN" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 3. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Hatchlings | Variable |   |
| add |   | -1 |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Respawn Check 2 | 0 | |

### Charms Allowed?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GetFsmBool

Full Name: HutongGames.PlayMaker.Actions.GetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Hero |   |   |
| fsmName |   | "ProxyFSM" | FsmName |   |
| variableName |   | "No Charms" | FsmBool |   |
| storeValue |   | bool No Charms | Variable |   |
| everyFrame |   | false |   |   |

##### 2. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool No Charms | Variable |   |
| isTrue |   | Event(CANCEL) |   |   |
| isFalse |   | Event() |   |   |
| everyFrame |   | false |   |   |

##### 3. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| behaviour |   | "GameManager" | Behaviour |   |
| methodName |   | "IsGameplayScene" | Method |   |
| parameters |   | FSMViewAvalonia2.FsmArray2 |   |   |
| storeResult |   | Var Is Gameplay Scene = False | Variable | Store Result |

##### 4. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Is Gameplay Scene | Variable |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(CANCEL) |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Respawn Pause | 0 | |
| CANCEL | Unequipped | 0 | |

### Wait for Hero

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. WaitForHeroInPosition

Full Name: WaitForHeroInPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent |   | Event(FINISHED) |   |   |
| skipIfAlreadyPositioned |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Equipped | 0 | |

## Global Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| CHARM EQUIP CHECK | Check Equipped | 0 | |
| LEAVING SCENE | Count Remaining | 0 | |
| ALL CHARMS END | Unequipped | 0 | |

## Events

| Name | Global |
| --- | --- |
| ALL CHARMS END | false |
| CANCEL | false |
| CHARM EQUIP CHECK | false |
| DREAMGATE | false |
| EQUIPPED | false |
| FINISHED | false |
| LEAVING SCENE | false |
| LEVEL LOADED | false |
| UNEQUIPPED | false |

