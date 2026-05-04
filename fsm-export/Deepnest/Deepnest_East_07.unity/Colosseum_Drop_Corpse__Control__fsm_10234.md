# Control

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Control |
| GameObject Name | Colosseum Drop Corpse |
| GameObject Path | Col Drop Corpse 03/ |
| Source Asset | D:/SteamLibrary/steamapps/common/Hollow Knight/hollow_knight_Data/level311 |
| Start State | Init |
| FSM PathId | 10234 |
| GameObject PathId | 1968 |

## Variables

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| Fall Anim |   | String:  |
| Land Anim | Corpse Land 2 | String: Corpse Land 2 |
| Number |   | String:  |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Bone | Col Drop Corpse 01/Colosseum Drop Corpse/Bone (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\sharedassets311.assets) | NamedAssetPPtr: [Col Drop Corpse 01/Colosseum Drop Corpse/Bone (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\sharedassets311.assets)] |
| Self | [null] | NamedAssetPPtr: [null] |

## States

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SelectRandomString

Full Name: HutongGames.PlayMaker.Actions.SelectRandomString
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| strings |   | FSMViewAvalonia2.FsmArray2 |   |   |
| weights |   | FSMViewAvalonia2.FsmArray2 |   |   |
| storeString |   | string Number | Variable |   |

##### 2. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts |   | FSMViewAvalonia2.FsmArray2 |   |   |
| separator |   | "" |   |   |
| addToEnd |   | true |   |   |
| storeResult |   | string Fall Anim | Variable |   |
| everyFrame |   | false |   |   |

##### 3. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts |   | FSMViewAvalonia2.FsmArray2 |   |   |
| separator |   | "" |   |   |
| addToEnd |   | true |   |   |
| storeResult |   | string Land Anim = "Corpse Land 2" | Variable |   |
| everyFrame |   | false |   |   |

##### 4. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| animLibName |   | "" |   |   |
| clipName |   | string Fall Anim |   |   |

##### 5. GetOwner

Full Name: HutongGames.PlayMaker.Actions.GetOwner
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeGameObject |   | GameObject Self | Variable |   |

##### 6. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector2(0, 0) |   |   |
| x |   | 0f |   |   |
| y |   | -40f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Falling | 0 | |

### Falling

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Collision2dEvent

Full Name: HutongGames.PlayMaker.Actions.Collision2dEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| collision | HutongGames.PlayMaker.Collision2DType::OnCollisionEnter2D | 0 |   |   |
| collideTag |   | "" | Tag |   |
| sendEvent |   | Event(LAND) |   |   |
| storeCollider |   |   | Variable |   |
| storeForce |   | 0f | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| LAND | Land | 0 | |

### Land

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| animLibName |   | "" |   |   |
| clipName |   | string Land Anim = "Corpse Land 2" |   |   |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):CameraParent |   |   |
| sendEvent |   | "EnemyKillShake" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 3. AudioPlayerOneShot

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShot
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer |   | [Global] [Audio Player Actor (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| audioClips |   | FSMViewAvalonia2.FsmArray2 |   |   |
| weights |   | FSMViewAvalonia2.FsmArray2 |   |   |
| pitchMin |   | 0.9f |   |   |
| pitchMax |   | 1.1f |   |   |
| volume |   | 1f |   |   |
| delay |   | 0f |   |   |
| storePlayer |   |   |   |   |

##### 4. PlayParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.PlayParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Bone |   |   |
| emit |   | 0 |   |   |

#### Transitions

(none)

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| LAND | false |

