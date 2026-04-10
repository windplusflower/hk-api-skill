# proj control

## Summary

| Field | Value |
| --- | --- |
| FSM Name | proj control |
| GameObject Name | Shot Orange LG 0.7 |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets138.assets |
| Start State | Idle |
| FSM PathId | 163 |
| GameObject PathId | 19 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Angle | 0 | Single: 0 |
| Angle Max | 0 | Single: 0 |
| Angle Min | 0 | Single: 0 |
| Chooser | 0 | Single: 0 |
| X Normal | 0 | Single: 0 |
| Y Normal | 0 | Single: 0 |

### Vector3s

| Name | Value | Raw/Type |
| --- | --- | --- |
| Contact Normal | Vector3(0, 0, 0) | Vector3: Vector3(0, 0, 0) |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Audio Player | [null] | NamedAssetPPtr:  |
| Self | [null] | NamedAssetPPtr:  |

## States

### Idle

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

##### 2. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Idle" | "Idle" |  |  |

##### 3. FaceAngle

Full Name: HutongGames.PlayMaker.Actions.FaceAngle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| angleOffset | 0f | 0f |  |  |
| everyFrame | true | true |  |  |

##### 4. ProjectileSquash

Full Name: HutongGames.PlayMaker.Actions.ProjectileSquash
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| stretchFactor | 1.4f | 1.4f |  |  |
| stretchMinX | 0.5 | 0.5 |  |  |
| stretchMaxY | 2 | 2 |  |  |
| scaleModifier | 0.7f | 0.7f |  |  |
| everyFrame | true | true |  |  |

##### 5. Collision2dEvent

Full Name: HutongGames.PlayMaker.Actions.Collision2dEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| collision | HutongGames.PlayMaker.Collision2DType::OnCollisionEnter2D | 0 |  |  |
| collideTag | "" | "" | Tag |  |
| sendEvent | Event(COLLISION ENTER 2D) | Event(COLLISION ENTER 2D) |  |  |
| storeCollider |  |  | Variable |  |
| storeForce | 0f | 0f | Variable |  |

##### 6. SetCollider

Full Name: HutongGames.PlayMaker.Actions.SetCollider
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | true | true |  |  |

### Impact

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetCollider

Full Name: HutongGames.PlayMaker.Actions.SetCollider
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | false | false |  |  |

##### 2. FlingObjectsFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.FlingObjectsFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Spatter Orange (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Spatter Orange (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| spawnMin | 5 | 5 |  |  |
| spawnMax | 8 | 8 |  |  |
| speedMin | 10f | 10f |  |  |
| speedMax | 15f | 15f |  |  |
| angleMin | float Angle Min | float Angle Min |  |  |
| angleMax | float Angle Max | float Angle Max |  |  |
| originVariationX | 0f | 0f |  |  |
| originVariationY | 0f | 0f |  |  |
| FSM | "" | "" |  |  |
| FSMEvent | "" | "" |  |  |

##### 3. CreateObject

Full Name: HutongGames.PlayMaker.Actions.CreateObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| rotation | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| storeObject | GameObject Audio Player | GameObject Audio Player | Variable |  |
| networkInstantiate | false | false |  |  |
| networkGroup | 0 | 0 |  |  |

##### 4. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min | 0.8f | 0.8f |  |  |
| max | 1.2f | 1.2f |  |  |
| storeResult | float Chooser | float Chooser | Variable |  |

##### 5. SetAudioPitch

Full Name: HutongGames.PlayMaker.Actions.SetAudioPitch
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Audio Player | OwnerDefault Audio Player |  |  |
| pitch | float Chooser | float Chooser |  |  |
| everyFrame | false | false |  |  |

##### 6. AudioPlay

Full Name: HutongGames.PlayMaker.Actions.AudioPlay
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Audio Player | OwnerDefault Audio Player |  |  |
| volume | 1f | 1f |  |  |
| oneShotClip | [orange_shot_impact (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets32.assets)] | [orange_shot_impact (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets32.assets)] |  |  |
| finishedEvent | Event() | Event() |  |  |

##### 7. Tk2dWatchAnimationEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dWatchAnimationEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animationTriggerEvent | Event() | Event() |  |  |
| animationCompleteEvent | Event(WAIT) | Event(WAIT) |  |  |

### Destroy

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SetIsKinematic2d

Full Name: HutongGames.PlayMaker.Actions.SetIsKinematic2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| isKinematic | false | false |  |  |

##### 2. RecycleSelf

Full Name: HutongGames.PlayMaker.Actions.RecycleSelf
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

### Check Normal

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 5

#### Actions

##### 1. GetCollision2dInfo

Full Name: HutongGames.PlayMaker.Actions.GetCollision2dInfo
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObjectHit |  |  | Variable |  |
| relativeVelocity | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| relativeSpeed | 0f | 0f | Variable |  |
| contactPoint | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| contactNormal | Vector3 Contact Normal | Vector3 Contact Normal | Variable |  |
| shapeCount | 0 | 0 | Variable |  |
| physics2dMaterialName | "" | "" | Variable |  |

##### 2. SetIsKinematic2d

Full Name: HutongGames.PlayMaker.Actions.SetIsKinematic2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| isKinematic | true | true |  |  |

##### 3. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector2(0, 0) | Vector2(0, 0) |  |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 4. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Impact" | "Impact" |  |  |

##### 5. GetVector3XYZ

Full Name: HutongGames.PlayMaker.Actions.GetVector3XYZ
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable | Vector3 Contact Normal | Vector3 Contact Normal | Variable |  |
| storeX | float X Normal | float X Normal | Variable |  |
| storeY | float Y Normal | float Y Normal | Variable |  |
| storeZ | 0f | 0f | Variable |  |
| everyFrame | false | false |  |  |

##### 6. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float Y Normal | float Y Normal |  |  |
| float2 | 1f | 1f |  |  |
| tolerance | 0f | 0f |  |  |
| equal | Event(DOWN) | Event(DOWN) |  |  |
| lessThan | Event() | Event() |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 7. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float Y Normal | float Y Normal |  |  |
| float2 | -1f | -1f |  |  |
| tolerance | 0f | 0f |  |  |
| equal | Event(UP) | Event(UP) |  |  |
| lessThan | Event() | Event() |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 8. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float X Normal | float X Normal |  |  |
| float2 | 1f | 1f |  |  |
| tolerance | 0f | 0f |  |  |
| equal | Event(LEFT) | Event(LEFT) |  |  |
| lessThan | Event() | Event() |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 9. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float X Normal | float X Normal |  |  |
| float2 | -1f | -1f |  |  |
| tolerance | 0f | 0f |  |  |
| equal | Event(RIGHT) | Event(RIGHT) |  |  |
| lessThan | Event() | Event() |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 10. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0f | 0f |  |  |
| finishEvent | Event(WAIT) | Event(WAIT) |  |  |
| realTime | false | false |  |  |

### Hit Up

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetRotation

Full Name: HutongGames.PlayMaker.Actions.GetRotation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| quaternion | Quaternion(0, 0, 0, 0) | Quaternion(0, 0, 0, 0) | Variable |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| xAngle | 0f | 0f | Variable |  |
| yAngle | 0f | 0f | Variable |  |
| zAngle | float Angle | float Angle | Variable |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |

##### 2. ReflectAngle

Full Name: HutongGames.PlayMaker.Actions.ReflectAngle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| angle | float Angle | float Angle |  |  |
| reflectHorizontally | false | false |  |  |
| reflectVertically | true | true |  |  |
| storeResult | float Angle | float Angle | Variable |  |

##### 3. FloatClamp

Full Name: HutongGames.PlayMaker.Actions.FloatClamp
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Angle Max | float Angle Max | Variable |  |
| minValue | 40f | 40f |  |  |
| maxValue | 140f | 140f |  |  |
| everyFrame | false | false |  |  |

##### 4. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Angle Min | float Angle Min | Variable |  |
| floatValue | float Angle | float Angle |  |  |
| everyFrame | false | false |  |  |

##### 5. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Angle Max | float Angle Max | Variable |  |
| floatValue | float Angle | float Angle |  |  |
| everyFrame | false | false |  |  |

##### 6. FloatAdd

Full Name: HutongGames.PlayMaker.Actions.FloatAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Angle Max | float Angle Max | Variable |  |
| add | 20f | 20f |  |  |
| everyFrame | false | false |  |  |
| perSecond | false | false |  |  |

##### 7. FloatSubtract

Full Name: HutongGames.PlayMaker.Actions.FloatSubtract
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Angle Min | float Angle Min | Variable |  |
| subtract | 20f | 20f |  |  |
| everyFrame | false | false |  |  |
| perSecond | false | false |  |  |

##### 8. SetRotation

Full Name: HutongGames.PlayMaker.Actions.SetRotation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| quaternion | Quaternion(0, 0, 0, 0) | Quaternion(0, 0, 0, 0) | Variable |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| xAngle | 0f | 0f |  |  |
| yAngle | 0f | 0f |  |  |
| zAngle | 180f | 180f |  |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

### Hit Right

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetRotation

Full Name: HutongGames.PlayMaker.Actions.GetRotation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| quaternion | Quaternion(0, 0, 0, 0) | Quaternion(0, 0, 0, 0) | Variable |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| xAngle | 0f | 0f | Variable |  |
| yAngle | 0f | 0f | Variable |  |
| zAngle | float Angle | float Angle | Variable |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |

##### 2. ReflectAngle

Full Name: HutongGames.PlayMaker.Actions.ReflectAngle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| angle | float Angle | float Angle |  |  |
| reflectHorizontally | true | true |  |  |
| reflectVertically | false | false |  |  |
| storeResult | float Angle | float Angle | Variable |  |

##### 3. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Angle Min | float Angle Min | Variable |  |
| floatValue | float Angle | float Angle |  |  |
| everyFrame | false | false |  |  |

##### 4. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Angle Max | float Angle Max | Variable |  |
| floatValue | float Angle | float Angle |  |  |
| everyFrame | false | false |  |  |

##### 5. FloatAdd

Full Name: HutongGames.PlayMaker.Actions.FloatAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Angle Max | float Angle Max | Variable |  |
| add | 20f | 20f |  |  |
| everyFrame | false | false |  |  |
| perSecond | false | false |  |  |

##### 6. FloatSubtract

Full Name: HutongGames.PlayMaker.Actions.FloatSubtract
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Angle Min | float Angle Min | Variable |  |
| subtract | 20f | 20f |  |  |
| everyFrame | false | false |  |  |
| perSecond | false | false |  |  |

##### 7. SetRotation

Full Name: HutongGames.PlayMaker.Actions.SetRotation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| quaternion | Quaternion(0, 0, 0, 0) | Quaternion(0, 0, 0, 0) | Variable |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| xAngle | 0f | 0f |  |  |
| yAngle | 0f | 0f |  |  |
| zAngle | 90f | 90f |  |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

### Hit Left

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetRotation

Full Name: HutongGames.PlayMaker.Actions.GetRotation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| quaternion | Quaternion(0, 0, 0, 0) | Quaternion(0, 0, 0, 0) | Variable |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| xAngle | 0f | 0f | Variable |  |
| yAngle | 0f | 0f | Variable |  |
| zAngle | float Angle | float Angle | Variable |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |

##### 2. ReflectAngle

Full Name: HutongGames.PlayMaker.Actions.ReflectAngle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| angle | float Angle | float Angle |  |  |
| reflectHorizontally | true | true |  |  |
| reflectVertically | false | false |  |  |
| storeResult | float Angle | float Angle | Variable |  |

##### 3. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Angle Min | float Angle Min | Variable |  |
| floatValue | float Angle | float Angle |  |  |
| everyFrame | false | false |  |  |

##### 4. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Angle Max | float Angle Max | Variable |  |
| floatValue | float Angle | float Angle |  |  |
| everyFrame | false | false |  |  |

##### 5. FloatAdd

Full Name: HutongGames.PlayMaker.Actions.FloatAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Angle Max | float Angle Max | Variable |  |
| add | 20f | 20f |  |  |
| everyFrame | false | false |  |  |
| perSecond | false | false |  |  |

##### 6. FloatSubtract

Full Name: HutongGames.PlayMaker.Actions.FloatSubtract
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Angle Min | float Angle Min | Variable |  |
| subtract | 20f | 20f |  |  |
| everyFrame | false | false |  |  |
| perSecond | false | false |  |  |

##### 7. SpawnRandomObjects

Full Name: HutongGames.PlayMaker.Actions.SpawnRandomObjects
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Spatter Orange (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Spatter Orange (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| spawnMin | 5 | 5 |  |  |
| spawnMax | 8 | 8 |  |  |
| speedMin | 10f | 10f |  |  |
| speedMax | 15f | 15f |  |  |
| angleMin | float Angle Min | float Angle Min |  |  |
| angleMax | float Angle Max | float Angle Max |  |  |
| originVariation | 0f | 0f |  |  |

##### 8. SetRotation

Full Name: HutongGames.PlayMaker.Actions.SetRotation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| quaternion | Quaternion(0, 0, 0, 0) | Quaternion(0, 0, 0, 0) | Variable |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| xAngle | 0f | 0f |  |  |
| yAngle | 0f | 0f |  |  |
| zAngle | 270f | 270f |  |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

### Dunno

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

_None_

### Hit Down

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetRotation

Full Name: HutongGames.PlayMaker.Actions.GetRotation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| quaternion | Quaternion(0, 0, 0, 0) | Quaternion(0, 0, 0, 0) | Variable |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| xAngle | 0f | 0f | Variable |  |
| yAngle | 0f | 0f | Variable |  |
| zAngle | float Angle | float Angle | Variable |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |

##### 2. ReflectAngle

Full Name: HutongGames.PlayMaker.Actions.ReflectAngle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| angle | float Angle | float Angle |  |  |
| reflectHorizontally | false | false |  |  |
| reflectVertically | true | true |  |  |
| storeResult | float Angle | float Angle | Variable |  |

##### 3. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Angle Min | float Angle Min | Variable |  |
| floatValue | float Angle | float Angle |  |  |
| everyFrame | false | false |  |  |

##### 4. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Angle Max | float Angle Max | Variable |  |
| floatValue | float Angle | float Angle |  |  |
| everyFrame | false | false |  |  |

##### 5. FloatAdd

Full Name: HutongGames.PlayMaker.Actions.FloatAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Angle Max | float Angle Max | Variable |  |
| add | 20f | 20f |  |  |
| everyFrame | false | false |  |  |
| perSecond | false | false |  |  |

##### 6. FloatSubtract

Full Name: HutongGames.PlayMaker.Actions.FloatSubtract
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Angle Min | float Angle Min | Variable |  |
| subtract | 20f | 20f |  |  |
| everyFrame | false | false |  |  |
| perSecond | false | false |  |  |

##### 7. SetRotation

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

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Idle | COLLISION ENTER 2D | Check Normal | 0 | 0 | 0 |
| Impact | WAIT | Destroy | 0 | 0 | 0 |
| Check Normal | DOWN | Hit Down | 0 | 0 | 0 |
| Check Normal | RIGHT | Hit Right | 0 | 0 | 0 |
| Check Normal | WAIT | Dunno | 0 | 0 | 0 |
| Check Normal | UP | Hit Up | 0 | 0 | 0 |
| Check Normal | LEFT | Hit Left | 0 | 0 | 0 |
| Hit Up | FINISHED | Impact | 0 | 0 | 0 |
| Hit Right | FINISHED | Impact | 0 | 0 | 0 |
| Hit Left | FINISHED | Impact | 0 | 0 | 0 |
| Dunno | FINISHED | Hit Down | 0 | 0 | 0 |
| Hit Down | FINISHED | Impact | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| COLLIDE | false |
| COLLISION ENTER 2D | true |
| DOWN | false |
| LEFT | false |
| RIGHT | false |
| UP | false |
| WAIT | true |

