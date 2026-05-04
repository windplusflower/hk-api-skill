# Spit

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Spit |
| GameObject Name | Spitting Zombie |
| GameObject Path | Infected Parent/ |
| Source Asset | D:/SteamLibrary/steamapps/common/Hollow Knight/hollow_knight_Data/level40 |
| Start State | Init |
| FSM PathId | 4942 |
| GameObject PathId | 60 |

## Variables

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Self | Infected Parent/Spitting Zombie (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level40) | NamedAssetPPtr: [Infected Parent/Spitting Zombie (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level40)] |
| SpawnPoint | Infected Parent/Spitting Zombie/Spawn Point (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level40) | NamedAssetPPtr: [Infected Parent/Spitting Zombie/Spawn Point (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level40)] |

## States

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendTrigger2DEventByName

Full Name: HutongGames.PlayMaker.Actions.SendTrigger2DEventByName
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):FSM Owner |   |   |
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerStay2D | 1 |   |   |
| collideTag |   | "" | Tag |   |
| collideLayer |   | 0 | Layer |   |
| sendEvent |   | "MOVESTART" |   |   |
| storeCollider |   |   | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| HERO IN RANGE | Attack Wait | 0 | |

### Attack Antic

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. AudioPlayRandom

Full Name: HutongGames.PlayMaker.Actions.AudioPlayRandom
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Infected Parent/Spitting Zombie (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level40)] |   |   |
| audioClips |   | FSMViewAvalonia2.FsmArray2 |   |   |
| weights |   | FSMViewAvalonia2.FsmArray2 |   |   |
| pitchMin |   | 1f |   |   |
| pitchMax |   | 1f |   |   |

##### 2. StopWalker

Full Name: StopWalker
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target |   | OwnerDefault FSM Owner |   |   |
| everyFrame |   | false |   |   |

##### 3. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| animLibName |   | "Infected Zombie 02 Anim" |   |   |
| clipName |   | "Attack" |   |   |

##### 4. Tk2dWatchAnimationEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dWatchAnimationEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| animationTriggerEvent |   | Event(TRIGGER) |   |   |
| animationCompleteEvent |   | Event() |   |   |

##### 5. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector2(0, 0) |   |   |
| x |   | 0f |   |   |
| y |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 6. FaceObject

Full Name: HutongGames.PlayMaker.Actions.FaceObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| objectA |   | [Infected Parent/Spitting Zombie (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level40)] |   |   |
| objectB |   | [Global] GameObject Hero | Variable |   |
| spriteFacesRight |   | false |   |   |
| playNewAnimation |   | false |   |   |
| newAnimationClip |   | "" |   |   |
| resetFrame |   | false |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| TRIGGER | Shoot | 0 | |

### Spawn Bullet R

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetWalkerFacing

Full Name: SetWalkerFacing
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| walkRight |   | true |   |   |
| randomStartDir |   | false |   |   |
| target |   | OwnerDefault FSM Owner |   |   |
| everyFrame |   | false |   |   |

##### 2. FlingObjectsFromGlobalPoolVel

Full Name: HutongGames.PlayMaker.Actions.FlingObjectsFromGlobalPoolVel
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Shot Mawlek (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\sharedassets32.assets)] |   |   |
| spawnPoint |   | [Infected Parent/Spitting Zombie/Spawn Point (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level40)] |   |   |
| position |   | Vector3(0, 0, 0) |   |   |
| spawnMin |   | 2 |   |   |
| spawnMax |   | 3 |   |   |
| speedMinX |   | 1.5f |   |   |
| speedMaxX |   | 8f |   |   |
| speedMinY |   | 15f |   |   |
| speedMaxY |   | 20f |   |   |
| originVariationX |   | 0f |   |   |
| originVariationY |   | 0f |   |   |

##### 3. Tk2dWatchAnimationEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dWatchAnimationEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| animationTriggerEvent |   | Event() |   |   |
| animationCompleteEvent |   | Event(Amin End) |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| Amin End | Cooldown | 0 | |

### Cooldown

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 0.5f |   |   |
| finishEvent |   | Event(WAIT) |   |   |
| realTime |   | false |   |   |

##### 2. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "Idle" |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| WAIT | MoveStart | 0 | |

### MoveStart

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. StartWalker

Full Name: StartWalker
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| walkRight |   | false |   |   |
| target |   | OwnerDefault FSM Owner |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Idle | 0 | |

### Spawn Bullet L

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetWalkerFacing

Full Name: SetWalkerFacing
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| walkRight |   | false |   |   |
| randomStartDir |   | false |   |   |
| target |   | OwnerDefault FSM Owner |   |   |
| everyFrame |   | false |   |   |

##### 2. FlingObjectsFromGlobalPoolVel

Full Name: HutongGames.PlayMaker.Actions.FlingObjectsFromGlobalPoolVel
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Shot Mawlek (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\sharedassets32.assets)] |   |   |
| spawnPoint |   | [Infected Parent/Spitting Zombie/Spawn Point (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level40)] |   |   |
| position |   | Vector3(0, 0, 0) |   |   |
| spawnMin |   | 2 |   |   |
| spawnMax |   | 3 |   |   |
| speedMinX |   | -1.5f |   |   |
| speedMaxX |   | -8f |   |   |
| speedMinY |   | 15f |   |   |
| speedMaxY |   | 20f |   |   |
| originVariationX |   | 0f |   |   |
| originVariationY |   | 0f |   |   |

##### 3. Tk2dWatchAnimationEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dWatchAnimationEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| animationTriggerEvent |   | Event() |   |   |
| animationCompleteEvent |   | Event(Amin End) |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| Amin End | Cooldown | 0 | |

### Shoot

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. AudioPlaySimple

Full Name: HutongGames.PlayMaker.Actions.AudioPlaySimple
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| volume |   | 1f |   |   |
| oneShotClip |   | [spitting_zombie_spit (AudioClip) (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\sharedassets33.assets)] |   |   |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject)[SendToChildren]:FSM Owner |   |   |
| sendEvent |   | "PLAY" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 3. SendEventByScale

Full Name: HutongGames.PlayMaker.Actions.SendEventByScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| eventTarget |   | EventTarget(Self):FSM Owner |   |   |
| xScale |   | true |   |   |
| positiveEvent |   | Event(SHOOTLEFT) |   |   |
| negativeEvent |   | Event(SHOOTRIGHT) |   |   |
| space | UnityEngine.Space::World | 0 |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| SHOOTLEFT | Spawn Bullet L | 0 | |
| SHOOTRIGHT | Spawn Bullet R | 0 | |

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
| storeGameObject |   | [Infected Parent/Spitting Zombie (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level40)] | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Idle | 0 | |

### Attack Wait

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. WaitRandom

Full Name: HutongGames.PlayMaker.Actions.WaitRandom
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| timeMin |   | 0f |   |   |
| timeMax |   | 0.75f |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Attack Antic | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| Amin End | false |
| FAILED | false |
| FINISHED | false |
| HERO IN RANGE | false |
| SHOOTLEFT | false |
| SHOOTRIGHT | false |
| TRIGGER | false |
| WAIT | true |

