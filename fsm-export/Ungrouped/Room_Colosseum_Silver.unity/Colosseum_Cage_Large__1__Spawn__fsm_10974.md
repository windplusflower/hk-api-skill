# Spawn

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Spawn |
| GameObject Name | Colosseum Cage Large (1) |
| GameObject Path | Colosseum Manager/Waves/Wave 6/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level33 |
| Start State | Init |
| FSM PathId | 10974 |
| GameObject PathId | 2001 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Self X | 1 | Single: 1 |
| Self Y | 0 | Single: 0 |
| Spawn Pause | 0 | Single: 0 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Stunner | false | Boolean: false |
| Summoner | false | Boolean: false |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Anim | Colosseum Manager/Waves/Wave 6/Colosseum Cage Large (1)/Anim (Hollow Knight/hollow_knight_Data\level33) | NamedAssetPPtr: [Colosseum Manager/Waves/Wave 6/Colosseum Cage Large (1)/Anim (Hollow Knight/hollow_knight_Data\level33)] |
| Colosseum Manager | [null] | NamedAssetPPtr: [null] |
| Corpse Instance | [null] | NamedAssetPPtr: [null] |
| Corpse to Instantiate | Colosseum_Flying_Sentry (Hollow Knight/hollow_knight_Data\sharedassets33.assets) | NamedAssetPPtr: [Colosseum_Flying_Sentry (Hollow Knight/hollow_knight_Data\sharedassets33.assets)] |
| Enemy | [null] | NamedAssetPPtr: [null] |
| Enemy Type | [null] | NamedAssetPPtr: [null] |
| Self | [null] | NamedAssetPPtr: [null] |
| Strike | Colosseum Manager/Waves/Wave 6/Colosseum Cage Large (1)/Strike Nail (Hollow Knight/hollow_knight_Data\level33) | NamedAssetPPtr: [Colosseum Manager/Waves/Wave 6/Colosseum Cage Large (1)/Strike Nail (Hollow Knight/hollow_knight_Data\level33)] |

## States

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GetOwner

Full Name: HutongGames.PlayMaker.Actions.GetOwner
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeGameObject |   | GameObject Self | Variable |   |

##### 2. FindGameObject

Full Name: HutongGames.PlayMaker.Actions.FindGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| objectName |   | "" |   |   |
| withTag |   | "Colosseum Manager" | Tag |   |
| store |   | GameObject Colosseum Manager | Variable |   |

##### 3. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Anim" |   |   |
| storeResult |   | [Colosseum Manager/Waves/Wave 6/Colosseum Cage Large (1)/Anim (Hollow Knight/hollow_knight_Data\level33)] | Variable |   |

##### 4. SetSpriteRenderer

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| active |   | false |   |   |

##### 5. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Summoner | Variable |   |
| isTrue |   | Event(SUMMON) |   |   |
| isFalse |   | Event() |   |   |
| everyFrame |   | false |   |   |

##### 6. CreateObject

Full Name: HutongGames.PlayMaker.Actions.CreateObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | GameObject Corpse to Instantiate |   |   |
| spawnPoint |   | GameObject Self |   |   |
| position |   | Vector3(0, 0, 0) |   |   |
| rotation |   | Vector3(0, 0, 0) |   |   |
| storeObject |   | GameObject Enemy | Variable |   |
| networkInstantiate |   | false |   |   |
| networkGroup |   | 0 |   |   |

##### 7. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Enemy |   |   |
| activate |   | false |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 8. SetBattleScene

Full Name: SetBattleScene
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target |   | OwnerDefault Enemy | Variable |   |
| battleScene |   | GameObject Colosseum Manager | Variable |   |

##### 9. SetGeoDrop

Full Name: SetGeoDrop
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target |   | OwnerDefault Enemy | Variable |   |
| smallGeo |   | 0 |   |   |
| mediumGeo |   | 0 |   |   |
| largeGeo |   | 0 |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| SUMMON | Summon Init | 0 | |
| FINISHED | Summon Idle | 0 | |

### Anim

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Anim |   |   |
| activate |   | true |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 2. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 1.25f |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(BroadcastAll):FSM Owner |   |   |
| sendEvent |   | "AUDIO CAGE UP" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Spawn | 0 | |

### Spawn

Description: (none)
Flags: breakpoint=true, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Summoner | Variable |   |
| isTrue |   | Event(SUMMON) |   |   |
| isFalse |   | Event() |   |   |
| everyFrame |   | false |   |   |

##### 2. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Enemy |   |   |
| activate |   | true |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Strike |   |   |
| activate |   | true |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 4. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(BroadcastAll):FSM Owner |   |   |
| sendEvent |   | "AUDIO CAGE OPEN" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 5. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Stunner | Variable |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(FINISHED) |   |   |
| everyFrame |   | false |   |   |

##### 6. SetSendKilledToObject

Full Name: SetSendKilledToObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target |   | OwnerDefault Enemy | Variable |   |
| killedObject |   | GameObject Self |   |   |

##### 7. SetFsmGameObject

Full Name: HutongGames.PlayMaker.Actions.SetFsmGameObject
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Enemy |   |   |
| fsmName |   | "health_manager_enemy" | FsmName |   |
| variableName |   | "KILLED GameObject" | FsmGameObject |   |
| setValue |   | GameObject Self |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Pause | 0 | |
| SUMMON | Summon | 0 | |

### End

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Anim |   |   |
| activate |   | false |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| KILLED | Stun | 0 | |

### Spawn Pause

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | float Spawn Pause |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Anim | 0 | |

### Pause

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 1.5f |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | End | 0 | |
| KILLED | Stun | 0 | |

### Stun

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. CreateObject

Full Name: HutongGames.PlayMaker.Actions.CreateObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Stun Effect (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | GameObject Enemy |   |   |
| position |   | Vector3(0, 0, 0) |   |   |
| rotation |   | Vector3(0, 0, 0) |   |   |
| storeObject |   |   | Variable |   |
| networkInstantiate |   | false |   |   |
| networkGroup |   | 0 |   |   |

#### Transitions

(none)

### Summon

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
| sendEvent |   | "AUDIO CAGE OPEN" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 2. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Strike |   |   |
| activate |   | true |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 3. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Enemy Type |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | float Self X |   |   |
| y |   | float Self Y |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Pause | 0 | |

### Summon Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFsmGameObject

Full Name: HutongGames.PlayMaker.Actions.SetFsmGameObject
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Enemy Type |   |   |
| fsmName |   | "health_manager_enemy" | FsmName |   |
| variableName |   | "Battle Scene" | FsmGameObject |   |
| setValue |   | GameObject Colosseum Manager |   |   |
| everyFrame |   | false |   |   |

##### 2. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Enemy Type |   |   |
| fsmName |   | "health_manager_enemy" | FsmName |   |
| variableName |   | "Geo Small" | FsmInt |   |
| setValue |   | 0 |   |   |
| everyFrame |   | false |   |   |

##### 3. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Enemy Type |   |   |
| fsmName |   | "health_manager_enemy" | FsmName |   |
| variableName |   | "Geo Medium" | FsmInt |   |
| setValue |   | 0 |   |   |
| everyFrame |   | false |   |   |

##### 4. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Enemy Type |   |   |
| fsmName |   | "health_manager_enemy" | FsmName |   |
| variableName |   | "Geo Large" | FsmInt |   |
| setValue |   | 0 |   |   |
| everyFrame |   | false |   |   |

##### 5. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | float Self X | Variable |   |
| y |   | float Self Y | Variable |   |
| z |   | 0f | Variable |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| SPAWN | Spawn Pause | 0 | |

### Create Corpse

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetFsmGameObject

Full Name: HutongGames.PlayMaker.Actions.GetFsmGameObject
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Enemy |   |   |
| fsmName |   | "health_manager_enemy" | FsmName |   |
| variableName |   | "Corpse" | FsmGameObject |   |
| storeValue |   | GameObject Enemy Type | Variable |   |
| everyFrame |   | false |   |   |

##### 2. SetFsmGameObject

Full Name: HutongGames.PlayMaker.Actions.SetFsmGameObject
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Enemy |   |   |
| fsmName |   | "health_manager_enemy" | FsmName |   |
| variableName |   | "Corpse" | FsmGameObject |   |
| setValue |   |   |   |   |
| everyFrame |   | false |   |   |

##### 3. CreateObject

Full Name: HutongGames.PlayMaker.Actions.CreateObject
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | GameObject Enemy Type |   |   |
| spawnPoint |   | GameObject Enemy |   |   |
| position |   | Vector3(0, 0, 0) |   |   |
| rotation |   | Vector3(0, 0, 0) |   |   |
| storeObject |   | GameObject Corpse Instance | Variable |   |
| networkInstantiate |   | false |   |   |
| networkGroup |   | 0 |   |   |

##### 4. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Corpse Instance |   |   |
| activate |   | false |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 5. SetParent

Full Name: HutongGames.PlayMaker.Actions.SetParent
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Corpse Instance |   |   |
| parent |   | GameObject Enemy |   |   |
| resetLocalPosition |   | false |   |   |
| resetLocalRotation |   | false |   |   |

##### 6. SetFsmGameObject

Full Name: HutongGames.PlayMaker.Actions.SetFsmGameObject
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Enemy |   |   |
| fsmName |   | "health_manager_enemy" | FsmName |   |
| variableName |   | "Corpse Instance" | FsmGameObject |   |
| setValue |   | GameObject Corpse Instance |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Summon Idle | 0 | |

### Summon Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

(none)

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| SPAWN | Spawn Pause | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| KILLED | false |
| SPAWN | true |
| STUNNER | false |
| SUMMON | false |

