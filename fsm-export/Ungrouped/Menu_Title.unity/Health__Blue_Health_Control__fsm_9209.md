# Blue Health Control

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Blue Health Control |
| GameObject Name | Health |
| GameObject Path | _GameCameras/HudCamera/Hud Canvas/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level1 |
| Start State | Init |
| FSM PathId | 9209 |
| GameObject PathId | 1412 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Blue Spawn X | 0 | Single: 0 |
| Blue Spawn Y | 0 | Single: 0 |
| Spawn Offset Multiplier | 0 | Single: 0 |
| Spawn X Offset | 0 | Single: 0 |

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Blue HP | 0 | Int32: 0 |
| Blue HP counter | 0 | Int32: 0 |
| Blues Added | 0 | Int32: 0 |
| Joni HP Counter | 0 | Int32: 0 |
| Max HP | 0 | Int32: 0 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Init | false | Boolean: false |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Blue HP Object | [null] | NamedAssetPPtr: [null] |
| Joni Health Object | [null] | NamedAssetPPtr: [null] |
| Self | [null] | NamedAssetPPtr: [null] |

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

##### 2. NextFrameEvent

Full Name: HutongGames.PlayMaker.Actions.NextFrameEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent |   | Event(FINISHED) |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Wait | 0 | |

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

(none)

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| ADD BLUE HEALTH | Add Blue Health | 0 | |
| UPDATE BLUE HEALTH | Hive Check | 0 | |

### Add Blue Health

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
| intName |   | "healthBlue" |   |   |
| storeValue |   | int Blue HP | Variable |   |

##### 2. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| intName |   | "maxHealth" |   |   |
| storeValue |   | int Max HP | Variable |   |

##### 3. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Max HP | Variable |   |
| add |   | int Blue HP |   |   |
| everyFrame |   | false |   |   |

##### 4. ConvertIntToFloat

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Max HP | Variable |   |
| floatVariable |   | float Spawn Offset Multiplier | Variable |   |
| everyFrame |   | false |   |   |

##### 5. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Blue HP | Variable |   |
| add |   | 1 |   |   |
| everyFrame |   | false |   |   |

##### 6. SetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intName |   | "healthBlue" |   |   |
| value |   | int Blue HP |   |   |

##### 7. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Blue Spawn X | Variable |   |
| floatValue |   | -10.32f |   |   |
| everyFrame |   | false |   |   |

##### 8. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Spawn X Offset | Variable |   |
| floatValue |   | 0.94f |   |   |
| everyFrame |   | false |   |   |

##### 9. FloatMultiply

Full Name: HutongGames.PlayMaker.Actions.FloatMultiply
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Spawn X Offset | Variable |   |
| multiplyBy |   | float Spawn Offset Multiplier |   |   |
| everyFrame |   | false |   |   |

##### 10. FloatAdd

Full Name: HutongGames.PlayMaker.Actions.FloatAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Blue Spawn X | Variable |   |
| add |   | float Spawn X Offset |   |   |
| everyFrame |   | false |   |   |
| perSecond |   | false |   |   |

##### 11. CreateObject

Full Name: HutongGames.PlayMaker.Actions.CreateObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Blue Health (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   |   |   |   |
| position |   | Vector3(0, 0, 0) |   |   |
| rotation |   | Vector3(0, 0, 0) |   |   |
| storeObject |   | GameObject Blue HP Object | Variable |   |
| networkInstantiate |   | false |   |   |
| networkGroup |   | 0 |   |   |

##### 12. SetParent

Full Name: HutongGames.PlayMaker.Actions.SetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Blue HP Object |   |   |
| parent |   | GameObject Self |   |   |
| resetLocalPosition |   | false |   |   |
| resetLocalRotation |   | false |   |   |

##### 13. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Blue HP Object |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | float Blue Spawn X |   |   |
| y |   | 7.68f |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

##### 14. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Blue HP Object |   |   |
| fsmName |   | "blue_health_display" | FsmName |   |
| variableName |   | "Start Idle" | FsmBool |   |
| setValue |   | false |   |   |
| everyFrame |   | false |   |   |

##### 15. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Blue HP Object |   |   |
| fsmName |   | "blue_health_display" | FsmName |   |
| variableName |   | "Health Number" | FsmInt |   |
| setValue |   | int Blue HP |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Idle | 0 | |

### Add Existing?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Joni HP Counter |   |   |
| integer2 |   | 0 |   |   |
| equal |   | Event() |   |   |
| lessThan |   | Event() |   |   |
| greaterThan |   | Event(ADD JONI HEALTH) |   |   |
| everyFrame |   | false |   |   |

##### 2. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Blue HP counter |   |   |
| integer2 |   | 0 |   |   |
| equal |   | Event() |   |   |
| lessThan |   | Event() |   |   |
| greaterThan |   | Event(ADD BLUE HEALTH) |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| ADD BLUE HEALTH | Add Blue Health 2 | 0 | |
| FINISHED | Idle | 0 | |
| ADD JONI HEALTH | Add Joni Health | 0 | |

### Add Blue Health 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. IntOperator

Full Name: HutongGames.PlayMaker.Actions.IntOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Blue HP counter |   |   |
| integer2 |   | 1 |   |   |
| operation | HutongGames.PlayMaker.Actions.IntOperator/Operation::Subtract | 1 |   |   |
| storeResult |   | int Blue HP counter | Variable |   |
| everyFrame |   | false |   |   |

##### 2. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| intName |   | "maxHealth" |   |   |
| storeValue |   | int Max HP | Variable |   |

##### 3. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Max HP | Variable |   |
| add |   | int Blues Added |   |   |
| everyFrame |   | false |   |   |

##### 4. ConvertIntToFloat

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Max HP | Variable |   |
| floatVariable |   | float Spawn Offset Multiplier | Variable |   |
| everyFrame |   | false |   |   |

##### 5. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Blue Spawn X | Variable |   |
| floatValue |   | -10.32f |   |   |
| everyFrame |   | false |   |   |

##### 6. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Spawn X Offset | Variable |   |
| floatValue |   | 0.94f |   |   |
| everyFrame |   | false |   |   |

##### 7. FloatMultiply

Full Name: HutongGames.PlayMaker.Actions.FloatMultiply
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Spawn X Offset | Variable |   |
| multiplyBy |   | float Spawn Offset Multiplier |   |   |
| everyFrame |   | false |   |   |

##### 8. FloatAdd

Full Name: HutongGames.PlayMaker.Actions.FloatAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Blue Spawn X | Variable |   |
| add |   | float Spawn X Offset |   |   |
| everyFrame |   | false |   |   |
| perSecond |   | false |   |   |

##### 9. CreateObject

Full Name: HutongGames.PlayMaker.Actions.CreateObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Blue Health (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   |   |   |   |
| position |   | Vector3(0, 0, 0) |   |   |
| rotation |   | Vector3(0, 0, 0) |   |   |
| storeObject |   | GameObject Blue HP Object | Variable |   |
| networkInstantiate |   | false |   |   |
| networkGroup |   | 0 |   |   |

##### 10. SetParent

Full Name: HutongGames.PlayMaker.Actions.SetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Blue HP Object |   |   |
| parent |   | GameObject Self |   |   |
| resetLocalPosition |   | false |   |   |
| resetLocalRotation |   | false |   |   |

##### 11. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Blue HP Object |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | float Blue Spawn X |   |   |
| y |   | 7.68f |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

##### 12. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Blues Added | Variable |   |
| add |   | 1 |   |   |
| everyFrame |   | false |   |   |

##### 13. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Blue HP Object |   |   |
| fsmName |   | "blue_health_display" | FsmName |   |
| variableName |   | "Start Idle" | FsmBool |   |
| setValue |   | false |   |   |
| everyFrame |   | false |   |   |

##### 14. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Blue HP Object |   |   |
| fsmName |   | "blue_health_display" | FsmName |   |
| variableName |   | "Init" | FsmBool |   |
| setValue |   | true |   |   |
| everyFrame |   | false |   |   |

##### 15. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Blue HP Object |   |   |
| fsmName |   | "blue_health_display" | FsmName |   |
| variableName |   | "Health Number" | FsmInt |   |
| setValue |   | int Blues Added |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Add Existing? | 0 | |

### Set Blue

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(BroadcastAll):FSM Owner |   |   |
| sendEvent |   | "REMOVE BLUE HEALTH" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 2. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Blues Added | Variable |   |
| add |   | 0 |   |   |
| everyFrame |   | false |   |   |

##### 3. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Blues Added | Variable |   |
| intValue |   | 0 |   |   |
| everyFrame |   | false |   |   |

##### 4. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |   |   |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |   |   |
| functionCall |   | UpdateBlueHealth(???) |   |   |

##### 5. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| intName |   | "healthBlue" |   |   |
| storeValue |   | int Blue HP counter | Variable |   |

##### 6. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| intName |   | "joniHealthBlue" |   |   |
| storeValue |   | int Joni HP Counter | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Add Existing? | 0 | |

### Add Joni Health

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. IntOperator

Full Name: HutongGames.PlayMaker.Actions.IntOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Joni HP Counter |   |   |
| integer2 |   | 1 |   |   |
| operation | HutongGames.PlayMaker.Actions.IntOperator/Operation::Subtract | 1 |   |   |
| storeResult |   | int Joni HP Counter | Variable |   |
| everyFrame |   | false |   |   |

##### 2. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| intName |   | "maxHealth" |   |   |
| storeValue |   | int Max HP | Variable |   |

##### 3. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Max HP | Variable |   |
| add |   | int Blues Added |   |   |
| everyFrame |   | false |   |   |

##### 4. ConvertIntToFloat

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Max HP | Variable |   |
| floatVariable |   | float Spawn Offset Multiplier | Variable |   |
| everyFrame |   | false |   |   |

##### 5. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Blue Spawn X | Variable |   |
| floatValue |   | -10.32f |   |   |
| everyFrame |   | false |   |   |

##### 6. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Spawn X Offset | Variable |   |
| floatValue |   | 0.94f |   |   |
| everyFrame |   | false |   |   |

##### 7. FloatMultiply

Full Name: HutongGames.PlayMaker.Actions.FloatMultiply
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Spawn X Offset | Variable |   |
| multiplyBy |   | float Spawn Offset Multiplier |   |   |
| everyFrame |   | false |   |   |

##### 8. FloatAdd

Full Name: HutongGames.PlayMaker.Actions.FloatAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Blue Spawn X | Variable |   |
| add |   | float Spawn X Offset |   |   |
| everyFrame |   | false |   |   |
| perSecond |   | false |   |   |

##### 9. GGCheckBoundHeart

Full Name: GGCheckBoundHeart
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| healthNumber |   | int Blues Added |   |   |
| checkSource | GGCheckBoundHeart/CheckSource::Joni | 1 |   |   |
| trueEvent |   | Event(FINISHED) |   |   |
| falseEvent |   | Event() |   |   |

##### 10. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Blues Added | Variable |   |
| add |   | 1 |   |   |
| everyFrame |   | false |   |   |

##### 11. CreateObject

Full Name: HutongGames.PlayMaker.Actions.CreateObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | GameObject Joni Health Object |   |   |
| spawnPoint |   |   |   |   |
| position |   | Vector3(0, 0, 0) |   |   |
| rotation |   | Vector3(0, 0, 0) |   |   |
| storeObject |   | GameObject Blue HP Object | Variable |   |
| networkInstantiate |   | false |   |   |
| networkGroup |   | 0 |   |   |

##### 12. SetParent

Full Name: HutongGames.PlayMaker.Actions.SetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Blue HP Object |   |   |
| parent |   | GameObject Self |   |   |
| resetLocalPosition |   | false |   |   |
| resetLocalRotation |   | false |   |   |

##### 13. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Blue HP Object |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | float Blue Spawn X |   |   |
| y |   | 7.68f |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

##### 14. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Blue HP Object |   |   |
| fsmName |   | "blue_health_display" | FsmName |   |
| variableName |   | "Start Idle" | FsmBool |   |
| setValue |   | false |   |   |
| everyFrame |   | false |   |   |

##### 15. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Blue HP Object |   |   |
| fsmName |   | "blue_health_display" | FsmName |   |
| variableName |   | "Health Number" | FsmInt |   |
| setValue |   | int Blues Added |   |   |
| everyFrame |   | false |   |   |

##### 16. IncrementPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.IncrementPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| intName |   | "healthBlue" |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Add Existing? | 0 | |

### Wait

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. NextFrameEvent

Full Name: HutongGames.PlayMaker.Actions.NextFrameEvent
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent |   | Event(FINISHED) |   |   |

##### 2. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 1.75f |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |

##### 3. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Init | Variable |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(LAST HP ADDED) |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| LAST HP ADDED | Hive Check | 0 | |
| INVENTORY OPENED | Hive Check | 0 | |

### Hive Check

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetGameObject

Full Name: HutongGames.PlayMaker.Actions.SetGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variable |   | GameObject Joni Health Object | Variable |   |
| gameObject |   | [Global] [Blue Health (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| everyFrame |   | false |   |   |

##### 2. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| boolName |   | "equippedCharm_29" |   |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(FINISHED) |   |   |

##### 3. SetGameObject

Full Name: HutongGames.PlayMaker.Actions.SetGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variable |   | GameObject Joni Health Object | Variable |   |
| gameObject |   | [Global] [Blue Health Hive (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Set Blue | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| ADD BLUE HEALTH | false |
| ADD JONI HEALTH | false |
| FINISHED | false |
| INVENTORY OPENED | false |
| LAST HP ADDED | false |
| UPDATE BLUE HEALTH | false |

