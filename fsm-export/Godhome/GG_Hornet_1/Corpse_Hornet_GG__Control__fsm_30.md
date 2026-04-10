# Control

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Control |
| GameObject Name | Corpse Hornet GG |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets448.assets |
| Start State | Blow |
| FSM PathId | 30 |
| GameObject PathId | 3 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Rotation | 0 | Single: 0 |
| X Pos | 0 | Single: 0 |
| X Velocity | 0 | Single: 0 |
| Y Pos | 0 | Single: 0 |

### Vector3s

| Name | Value | Raw/Type |
| --- | --- | --- |
| Leave Vector | Vector3(0, 0, 0) | Vector3: Vector3(0, 0, 0) |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Grass | Corpse Hornet GG/Grass (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets448.assets) | NamedAssetPPtr: Corpse Hornet GG/Grass (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets448.assets) |
| Grass Escape | Corpse Hornet GG/Grass Escape (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets448.assets) | NamedAssetPPtr: Corpse Hornet GG/Grass Escape (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets448.assets) |
| Leave Anim | Corpse Hornet GG/Leave Anim (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets448.assets) | NamedAssetPPtr: Corpse Hornet GG/Leave Anim (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets448.assets) |
| Needle Tink | [null] | NamedAssetPPtr:  |
| Self | [null] | NamedAssetPPtr:  |
| Thread | Corpse Hornet GG/Thread (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets448.assets) | NamedAssetPPtr: Corpse Hornet GG/Thread (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets448.assets) |

## States

### Blow

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

##### 2. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [Hornet_Fight_Death_01 (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets105.assets)] | [Hornet_Fight_Death_01 (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets105.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 3. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::RequireReceiver | 0 |  |  |
| functionCall | FreezeMoment(0) | FreezeMoment(0) |  |  |

##### 4. AudioPlaySimple

Full Name: HutongGames.PlayMaker.Actions.AudioPlaySimple
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| volume | 1f | 1f |  |  |
| oneShotClip | [boss_explode_clean (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [boss_explode_clean (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |

##### 5. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(BroadcastAll):FSM Owner | EventTarget(BroadcastAll):FSM Owner |  |  |
| sendEvent | "HORNET KILLED" | "HORNET KILLED" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 6. FindGameObject

Full Name: HutongGames.PlayMaker.Actions.FindGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| objectName | "Needle Tink" | "Needle Tink" |  |  |
| withTag | "Untagged" | "Untagged" | Tag |  |
| store | GameObject Needle Tink | GameObject Needle Tink | Variable |  |

##### 7. DestroyObject

Full Name: HutongGames.PlayMaker.Actions.DestroyObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Needle Tink | GameObject Needle Tink |  |  |
| delay | 0f | 0f |  |  |
| detachChildren | false | false |  |  |

##### 8. SpawnRandomObjectsV2

Full Name: HutongGames.PlayMaker.Actions.SpawnRandomObjectsV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Slash Effect Ghost1 (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Slash Effect Ghost1 (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| spawnMin | 8 | 8 |  |  |
| spawnMax | 8 | 8 |  |  |
| speedMin | 2f | 2f |  |  |
| speedMax | 35f | 35f |  |  |
| angleMin | 0f | 0f |  |  |
| angleMax | 360f | 360f |  |  |
| originVariationX | 0f | 0f |  |  |
| originVariationY | 0f | 0f |  |  |

##### 9. SpawnRandomObjectsV2

Full Name: HutongGames.PlayMaker.Actions.SpawnRandomObjectsV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Slash Effect Ghost2 (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Slash Effect Ghost2 (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| spawnMin | 2 | 2 |  |  |
| spawnMax | 3 | 3 |  |  |
| speedMin | 2f | 2f |  |  |
| speedMax | 35f | 35f |  |  |
| angleMin | 0f | 0f |  |  |
| angleMax | 360f | 360f |  |  |
| originVariationX | 0f | 0f |  |  |
| originVariationY | 0f | 0f |  |  |

##### 10. CreateObject

Full Name: HutongGames.PlayMaker.Actions.CreateObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [White Wave (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] | [Global] [White Wave (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| rotation | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| storeObject |  |  | Variable |  |
| networkInstantiate | false | false |  |  |
| networkGroup | 0 | 0 |  |  |

##### 11. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | FreezeMoment(0) | FreezeMoment(0) |  |  |

##### 12. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):CameraParent | EventTarget(GameObject):CameraParent |  |  |
| sendEvent | "AverageShake" | "AverageShake" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 13. SetRotation

Full Name: HutongGames.PlayMaker.Actions.SetRotation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| quaternion | Quaternion(0, 0, 0, 0) | Quaternion(0, 0, 0, 0) | Variable |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| xAngle | 0f | 0f |  |  |
| yAngle | 0f | 0f |  |  |
| zAngle | 0f | 0f |  |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 14. TransitionToAudioSnapshot

Full Name: HutongGames.PlayMaker.Actions.TransitionToAudioSnapshot
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| snapshot | [Silent (AudioMixerSnapshotController) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Silent (AudioMixerSnapshotController) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| transitionTime | 1f | 1f |  |  |

### Launch

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. FaceObject

Full Name: HutongGames.PlayMaker.Actions.FaceObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| objectA | GameObject Self | GameObject Self |  |  |
| objectB | [Global] GameObject Hero | [Global] GameObject Hero | Variable |  |
| spriteFacesRight | false | false |  |  |
| playNewAnimation | false | false |  |  |
| newAnimationClip | "" | "" |  |  |
| resetFrame | false | false |  |  |
| everyFrame | false | false |  |  |

##### 2. GetScale

Full Name: HutongGames.PlayMaker.Actions.GetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| xScale | float X Velocity | float X Velocity | Variable |  |
| yScale | 0f | 0f | Variable |  |
| zScale | 0f | 0f | Variable |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |

##### 3. FloatMultiply

Full Name: HutongGames.PlayMaker.Actions.FloatMultiply
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float X Velocity | float X Velocity | Variable |  |
| multiplyBy | 5f | 5f |  |  |
| everyFrame | false | false |  |  |

##### 4. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector2(0, 0) | Vector2(0, 0) |  |  |
| x | float X Velocity | float X Velocity |  |  |
| y | 20f | 20f |  |  |
| everyFrame | false | false |  |  |

##### 5. NextFrameEvent

Full Name: HutongGames.PlayMaker.Actions.NextFrameEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent | Event(FINISHED) | Event(FINISHED) |  |  |

##### 6. SetRotation

Full Name: HutongGames.PlayMaker.Actions.SetRotation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| quaternion | Quaternion(0, 0, 0, 0) | Quaternion(0, 0, 0, 0) | Variable |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| xAngle | 0f | 0f |  |  |
| yAngle | 0f | 0f |  |  |
| zAngle | 0f | 0f |  |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

### In Air

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. CheckCollisionSideEnter

Full Name: HutongGames.PlayMaker.Actions.CheckCollisionSideEnter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| topHit | false | false | Variable |  |
| rightHit | false | false | Variable |  |
| bottomHit | false | false | Variable |  |
| leftHit | false | false | Variable |  |
| topHitEvent | Event() | Event() |  |  |
| rightHitEvent | Event() | Event() |  |  |
| bottomHitEvent | Event(LAND) | Event(LAND) |  |  |
| leftHitEvent | Event() | Event() |  |  |
| otherLayer | false | false |  |  |
| otherLayerNumber | 0 | 0 |  |  |
| ignoreTriggers | false | false |  |  |

##### 2. CheckCollisionSide

Full Name: HutongGames.PlayMaker.Actions.CheckCollisionSide
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| topHit | false | false | Variable |  |
| rightHit | false | false | Variable |  |
| bottomHit | false | false | Variable |  |
| leftHit | false | false | Variable |  |
| topHitEvent | Event() | Event() |  |  |
| rightHitEvent | Event() | Event() |  |  |
| bottomHitEvent | Event(LAND) | Event(LAND) |  |  |
| leftHitEvent | Event() | Event() |  |  |
| otherLayer | false | false |  |  |
| otherLayerNumber | 0 | 0 |  |  |
| ignoreTriggers | false | false |  |  |

##### 3. SetRotation

Full Name: HutongGames.PlayMaker.Actions.SetRotation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| quaternion | Quaternion(0, 0, 0, 0) | Quaternion(0, 0, 0, 0) | Variable |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| xAngle | 0f | 0f |  |  |
| yAngle | 0f | 0f |  |  |
| zAngle | 0f | 0f |  |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 4. SetRotation

Full Name: HutongGames.PlayMaker.Actions.SetRotation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| quaternion | Quaternion(0, 0, 0, 0) | Quaternion(0, 0, 0, 0) | Variable |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| xAngle | 0f | 0f |  |  |
| yAngle | 0f | 0f |  |  |
| zAngle | 0f | 0f |  |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | true | true |  |  |
| lateUpdate | false | false |  |  |

### Land

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Wounded" | "Wounded" |  |  |

##### 2. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector2(0, 0) | Vector2(0, 0) |  |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. SetRotation

Full Name: HutongGames.PlayMaker.Actions.SetRotation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| quaternion | Quaternion(0, 0, 0, 0) | Quaternion(0, 0, 0, 0) | Variable |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| xAngle | 0f | 0f |  |  |
| yAngle | 0f | 0f |  |  |
| zAngle | 0f | 0f |  |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

### Limit Pos

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f | Variable |  |
| y | float Y Pos | float Y Pos | Variable |  |
| z | 0f | 0f | Variable |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |

##### 2. FloatClamp

Full Name: HutongGames.PlayMaker.Actions.FloatClamp
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Y Pos | float Y Pos | Variable |  |
| minValue | 28.75f | 28.75f |  |  |
| maxValue | 99999f | 99999f |  |  |
| everyFrame | false | false |  |  |

##### 3. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | float Y Pos | float Y Pos |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 4. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | float X Pos | float X Pos | Variable |  |
| y | 0f | 0f | Variable |  |
| z | 0f | 0f | Variable |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |

##### 5. FloatClamp

Full Name: HutongGames.PlayMaker.Actions.FloatClamp
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float X Pos | float X Pos | Variable |  |
| minValue | 16f | 16f |  |  |
| maxValue | 37f | 37f |  |  |
| everyFrame | false | false |  |  |

##### 6. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | float X Pos | float X Pos |  |  |
| y | 0f | 0f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Blow | FINISHED | Launch | 0 | 0 | 0 |
| Launch | FINISHED | In Air | 0 | 0 | 0 |
| In Air | LAND | Land | 0 | 0 | 0 |
| Land | FINISHED |  | 0 | 0 | 0 |
| Land | GG BOSS |  | 0 | 0 | 0 |
| Limit Pos | FINISHED | Blow | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| GG BOSS | false |
| L | false |
| LAND | false |
| R | false |

