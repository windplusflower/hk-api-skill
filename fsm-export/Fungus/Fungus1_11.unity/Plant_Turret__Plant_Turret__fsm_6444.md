# Plant Turret

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Plant Turret |
| GameObject Name | Plant Turret |
| GameObject Path |   |
| Source Asset | Hollow Knight/hollow_knight_Data/level140 |
| Start State | Initialise |
| FSM PathId | 6444 |
| GameObject PathId | 1589 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Angle Max | 0 | Single: 0 |
| Angle Max Alt | 0 | Single: 0 |
| Angle Min | 0 | Single: 0 |
| Angle Min Alt | 0 | Single: 0 |
| Angle To Hero | 0 | Single: 0 |
| Distance | 0 | Single: 0 |
| Distance Max | 12 | Single: 12 |
| Hero X | 0 | Single: 0 |
| Hero Y | 0 | Single: 0 |
| Hide Distance | 5 | Single: 5 |
| Raycast X | 0 | Single: 0 |
| Raycast Y | 0 | Single: 0 |
| Self Rotation | 0 | Single: 0 |
| Self X | 0 | Single: 0 |
| Self Y | 0 | Single: 0 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Awake | false | Boolean: false |
| Can See Hero | false | Boolean: false |
| Close | false | Boolean: false |
| Facing Right | false | Boolean: false |
| In Range | false | Boolean: false |
| Not Close | false | Boolean: false |
| Over Angle Min | false | Boolean: false |
| Under Angle Max | false | Boolean: false |
| View Obscured | false | Boolean: false |

### Vector2s

| Name | Value | Raw/Type |
| --- | --- | --- |
| Hero Pos 2D | Vector2(0, 0) | Vector2: Vector2(0, 0) |
| Raycast Vector | Vector2(0, 0) | Vector2: Vector2(0, 0) |
| Self Pos 2D | Vector2(0, 0) | Vector2: Vector2(0, 0) |

### Vector3s

| Name | Value | Raw/Type |
| --- | --- | --- |
| Hero Position | Vector2(0, 0) | Vector2: Vector2(0, 0) |
| Rotate Vector | Vector2(0, 0) | Vector2: Vector2(0, 0) |
| Start Angle | Vector2(0, 0) | Vector2: Vector2(0, 0) |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Burst Grass | Plant Turret/Burst Grass (Hollow Knight/hollow_knight_Data\level140) | NamedAssetPPtr: [Plant Turret/Burst Grass (Hollow Knight/hollow_knight_Data\level140)] |
| Cover | Plant Turret/Cover (Hollow Knight/hollow_knight_Data\level140) | NamedAssetPPtr: [Plant Turret/Cover (Hollow Knight/hollow_knight_Data\level140)] |
| Hero | [null] | NamedAssetPPtr: [null] |
| Self | [null] | NamedAssetPPtr: [null] |
| Shot Instance | [null] | NamedAssetPPtr: [null] |
| Shot Spawn | Plant Turret/Shot Spawn (Hollow Knight/hollow_knight_Data\level140) | NamedAssetPPtr: [Plant Turret/Shot Spawn (Hollow Knight/hollow_knight_Data\level140)] |
| Spit Effect | Plant Turret/Spit Effect (Hollow Knight/hollow_knight_Data\level140) | NamedAssetPPtr: [Plant Turret/Spit Effect (Hollow Knight/hollow_knight_Data\level140)] |
| Under | Plant Turret/Under (Hollow Knight/hollow_knight_Data\level140) | NamedAssetPPtr: [Plant Turret/Under (Hollow Knight/hollow_knight_Data\level140)] |

## States

### Initialise

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

##### 2. GetRotation

Full Name: HutongGames.PlayMaker.Actions.GetRotation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| quaternion |   | Quaternion(0, 0, 0, 0) | Variable |   |
| vector |   | Vector3 Start Angle | Variable |   |
| xAngle |   | 0f | Variable |   |
| yAngle |   | 0f | Variable |   |
| zAngle |   | 0f | Variable |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |

##### 3. GetHero

Full Name: GetHero
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeResult |   | GameObject Hero | Variable |   |

##### 4. SetParent

Full Name: HutongGames.PlayMaker.Actions.SetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Cover |   |   |
| parent |   |   |   |   |
| resetLocalPosition |   | false |   |   |
| resetLocalRotation |   | false |   |   |

##### 5. SetParent

Full Name: HutongGames.PlayMaker.Actions.SetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Under |   |   |
| parent |   |   |   |   |
| resetLocalPosition |   | false |   |   |
| resetLocalRotation |   | false |   |   |

##### 6. GetRotation

Full Name: HutongGames.PlayMaker.Actions.GetRotation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| quaternion |   | Quaternion(0, 0, 0, 0) | Variable |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| xAngle |   | 0f | Variable |   |
| yAngle |   | 0f | Variable |   |
| zAngle |   | float Self Rotation | Variable |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |

##### 7. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Angle Min | Variable |   |
| floatValue |   | float Self Rotation |   |   |
| everyFrame |   | false |   |   |

##### 8. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Angle Max | Variable |   |
| floatValue |   | float Self Rotation |   |   |
| everyFrame |   | false |   |   |

##### 9. FloatAdd

Full Name: HutongGames.PlayMaker.Actions.FloatAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Angle Min | Variable |   |
| add |   | 40f |   |   |
| everyFrame |   | false |   |   |
| perSecond |   | false |   |   |

##### 10. FloatAdd

Full Name: HutongGames.PlayMaker.Actions.FloatAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Angle Max | Variable |   |
| add |   | 140f |   |   |
| everyFrame |   | false |   |   |
| perSecond |   | false |   |   |

##### 11. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 |   | float Angle Max |   |   |
| float2 |   | 360f |   |   |
| tolerance |   | 0f |   |   |
| equal |   | Event() |   |   |
| lessThan |   | Event() |   |   |
| greaterThan |   | Event(RIGHT) |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Check | 0 | |
| RIGHT | Check | 0 | |

### Check

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. iTweenRotateTo

Full Name: HutongGames.PlayMaker.Actions.iTweenRotateTo
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| id |   | "" |   |   |
| transformRotation |   |   |   |   |
| vectorRotation |   | Vector3 Start Angle |   |   |
| time |   | 0.5f |   |   |
| delay |   | 0f |   |   |
| speed |   | 0f |   |   |
| easeType | iTween/EaseType::easeInOutCirc | 20 |   |   |
| loopType | iTween/LoopType::none | 0 |   |   |
| space | UnityEngine.Space::World | 0 |   |   |
| startEvent |   | Event() |   |   |
| finishEvent |   | Event() |   |   |
| realTime |   | false |   |   |
| stopOnExit |   | true |   |   |
| loopDontFinish |   | true |   |   |

##### 2. GetAngleToTarget2D

Full Name: HutongGames.PlayMaker.Actions.GetAngleToTarget2D
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| target |   | GameObject Hero |   |   |
| offsetX |   | 0f |   |   |
| offsetY |   | 0f |   |   |
| storeAngle |   | float Angle To Hero |   |   |
| everyFrame |   | true |   |   |

##### 3. FloatAddV2

Full Name: HutongGames.PlayMaker.Actions.FloatAddV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Angle To Hero | Variable |   |
| add |   | 360f |   |   |
| everyFrame |   | true |   |   |
| perSecond |   | false |   |   |
| fixedUpdate |   | false |   |   |
| activeBool |   | bool Facing Right | Variable |   |

##### 4. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Hero |   |   |
| vector |   | Vector3 Hero Position | Variable |   |
| x |   | float Hero X | Variable |   |
| y |   | float Hero Y | Variable |   |
| z |   | 0f | Variable |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| everyFrame |   | true |   |   |

##### 5. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Self |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | float Self X | Variable |   |
| y |   | float Self Y | Variable |   |
| z |   | 0f | Variable |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| everyFrame |   | true |   |   |

##### 6. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Raycast X | Variable |   |
| floatValue |   | float Hero X |   |   |
| everyFrame |   | true |   |   |

##### 7. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Raycast Y | Variable |   |
| floatValue |   | float Hero Y |   |   |
| everyFrame |   | true |   |   |

##### 8. FloatSubtract

Full Name: HutongGames.PlayMaker.Actions.FloatSubtract
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Raycast X | Variable |   |
| subtract |   | float Self X |   |   |
| everyFrame |   | true |   |   |
| perSecond |   | false |   |   |

##### 9. FloatSubtract

Full Name: HutongGames.PlayMaker.Actions.FloatSubtract
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Raycast Y | Variable |   |
| subtract |   | float Self Y |   |   |
| everyFrame |   | true |   |   |
| perSecond |   | false |   |   |

##### 10. SetVector2XY

Full Name: HutongGames.PlayMaker.Actions.SetVector2XY
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector2Variable |   | Vector2 Raycast Vector | Variable |   |
| vector2Value |   | Vector2(0, 0) | Variable |   |
| x |   | float Raycast X |   |   |
| y |   | float Raycast Y |   |   |
| everyFrame |   | true |   |   |

##### 11. SetVector2XY

Full Name: HutongGames.PlayMaker.Actions.SetVector2XY
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector2Variable |   | Vector2 Hero Pos 2D | Variable |   |
| vector2Value |   | Vector2(0, 0) | Variable |   |
| x |   | float Hero X |   |   |
| y |   | float Hero Y |   |   |
| everyFrame |   | true |   |   |

##### 12. SetVector2XY

Full Name: HutongGames.PlayMaker.Actions.SetVector2XY
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector2Variable |   | Vector2 Self Pos 2D | Variable |   |
| vector2Value |   | Vector2(0, 0) | Variable |   |
| x |   | float Self X |   |   |
| y |   | float Self Y |   |   |
| everyFrame |   | true |   |   |

##### 13. DistanceBetweenPoints2D

Full Name: HutongGames.PlayMaker.Actions.DistanceBetweenPoints2D
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| distanceResult |   | float Distance | Variable |   |
| point1 |   | Vector2 Hero Pos 2D |   |   |
| point2 |   | Vector2 Self Pos 2D |   |   |
| everyFrame |   | true |   |   |

##### 14. RayCast2d

Full Name: HutongGames.PlayMaker.Actions.RayCast2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| fromGameObject |   | OwnerDefault Self |   | Setup |
| fromPosition |   | Vector2(0, 0) |   |   |
| direction |   | Vector2 Raycast Vector |   |   |
| space | UnityEngine.Space::World | 0 |   |   |
| distance |   | float Distance |   |   |
| minDepth |   | 0 |   |   |
| maxDepth |   | 0 |   |   |
| hitEvent |   | Event() | Variable | Result |
| storeDidHit |   | bool View Obscured | Variable |   |
| storeHitObject |   |   | Variable |   |
| storeHitPoint |   | Vector2(0, 0) | Variable |   |
| storeHitNormal |   | Vector2(0, 0) | Variable |   |
| storeHitDistance |   | 0f | Variable |   |
| storeHitFraction |   | 0f | Variable |   |
| repeatInterval |   | 1 |   | Filter |
| layerMask |   | FSMViewAvalonia2.FsmArray2 | Layer |   |
| invertMask |   | false |   |   |
| debugColor |   | Color(1, 0.92156863, 0.015686275, 1) |   | Debug |
| debug |   | true |   |   |

##### 15. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Can See Hero | Variable |   |
| boolValue |   | bool View Obscured |   |   |
| everyFrame |   | true |   |   |

##### 16. BoolFlipEveryFrame

Full Name: HutongGames.PlayMaker.Actions.BoolFlipEveryFrame
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Can See Hero | Variable |   |
| everyFrame |   | true |   |   |

##### 17. FloatTestToBool

Full Name: HutongGames.PlayMaker.Actions.FloatTestToBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 |   | float Distance |   |   |
| float2 |   | float Distance Max |   |   |
| tolerance |   | 0f |   |   |
| equalBool |   | false | Variable |   |
| lessThanBool |   | bool In Range | Variable |   |
| greaterThanBool |   | false | Variable |   |
| everyFrame |   | true |   |   |

##### 18. FloatTestToBool

Full Name: HutongGames.PlayMaker.Actions.FloatTestToBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 |   | float Angle To Hero |   |   |
| float2 |   | float Angle Min |   |   |
| tolerance |   | 0f |   |   |
| equalBool |   | false | Variable |   |
| lessThanBool |   | false | Variable |   |
| greaterThanBool |   | bool Over Angle Min | Variable |   |
| everyFrame |   | true |   |   |

##### 19. FloatTestToBool

Full Name: HutongGames.PlayMaker.Actions.FloatTestToBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 |   | float Angle To Hero |   |   |
| float2 |   | float Angle Max |   |   |
| tolerance |   | 0f |   |   |
| equalBool |   | false | Variable |   |
| lessThanBool |   | bool Under Angle Max | Variable |   |
| greaterThanBool |   | false | Variable |   |
| everyFrame |   | true |   |   |

##### 20. FloatTestToBool

Full Name: HutongGames.PlayMaker.Actions.FloatTestToBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 |   | float Distance |   |   |
| float2 |   | float Hide Distance |   |   |
| tolerance |   | 0f |   |   |
| equalBool |   | false | Variable |   |
| lessThanBool |   | bool Close | Variable |   |
| greaterThanBool |   | bool Not Close | Variable |   |
| everyFrame |   | true |   |   |

##### 21. BoolAllTrue

Full Name: HutongGames.PlayMaker.Actions.BoolAllTrue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariables |   | FSMViewAvalonia2.FsmArray2 | Variable |   |
| sendEvent |   | Event(SEE HERO) |   |   |
| storeResult |   | false | Variable |   |
| everyFrame |   | true |   |   |

##### 22. BoolAllTrue

Full Name: HutongGames.PlayMaker.Actions.BoolAllTrue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariables |   | FSMViewAvalonia2.FsmArray2 | Variable |   |
| sendEvent |   | Event(HIDE) |   |   |
| storeResult |   | false | Variable |   |
| everyFrame |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| SEE HERO | Seen | 0 | |

### Seen

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Awake | Variable |   |
| isTrue |   | Event(SHOOT) |   |   |
| isFalse |   | Event(WAKE) |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| WAKE | Wake | 0 | |
| SHOOT | Shot Pause | 0 | |

### Wake

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. AudioPlaySimple

Full Name: HutongGames.PlayMaker.Actions.AudioPlaySimple
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| volume |   | 1f |   |   |
| oneShotClip |   | [plant_turret_emerge (AudioClip) (Hollow Knight/hollow_knight_Data\sharedassets140.assets)] |   |   |

##### 2. PlayParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.PlayParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Burst Grass |   |   |
| emit |   | 0 |   |   |

##### 3. SetInvincible

Full Name: SetInvincible
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target |   | OwnerDefault FSM Owner | Variable |   |
| Invincible |   | false |   |   |
| InvincibleFromDirection |   | 0 |   |   |

##### 4. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Awake | Variable |   |
| boolValue |   | true |   |   |
| everyFrame |   | false |   |   |

##### 5. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| clipName |   | "Wake" |   |   |
| animationTriggerEvent |   | Event() |   |   |
| animationCompleteEvent |   | Event(FINISHED) |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Idle Anim | 0 | |

### Shot Pause

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. LookAt2dGameObjectSmooth

Full Name: HutongGames.PlayMaker.Actions.LookAt2dGameObjectSmooth
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| targetObject |   | GameObject Hero |   |   |
| rotationOffset |   | 90f |   |   |
| speed |   | 3f |   |   |
| debug |   | false |   |   |
| debugLineColor |   | Color(0, 1, 0, 1) |   |   |

##### 2. GetAngleToTarget2D

Full Name: HutongGames.PlayMaker.Actions.GetAngleToTarget2D
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| target |   | GameObject Hero |   |   |
| offsetX |   | 0f |   |   |
| offsetY |   | 0f |   |   |
| storeAngle |   | float Angle To Hero |   |   |
| everyFrame |   | true |   |   |

##### 3. FloatAddV2

Full Name: HutongGames.PlayMaker.Actions.FloatAddV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Angle To Hero | Variable |   |
| add |   | 360f |   |   |
| everyFrame |   | true |   |   |
| perSecond |   | false |   |   |
| fixedUpdate |   | false |   |   |
| activeBool |   | bool Facing Right | Variable |   |

##### 4. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Hero |   |   |
| vector |   | Vector3 Hero Position | Variable |   |
| x |   | float Hero X | Variable |   |
| y |   | float Hero Y | Variable |   |
| z |   | 0f | Variable |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| everyFrame |   | true |   |   |

##### 5. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Self |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | float Self X | Variable |   |
| y |   | float Self Y | Variable |   |
| z |   | 0f | Variable |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| everyFrame |   | true |   |   |

##### 6. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Raycast X | Variable |   |
| floatValue |   | float Hero X |   |   |
| everyFrame |   | true |   |   |

##### 7. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Raycast Y | Variable |   |
| floatValue |   | float Hero Y |   |   |
| everyFrame |   | true |   |   |

##### 8. FloatSubtract

Full Name: HutongGames.PlayMaker.Actions.FloatSubtract
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Raycast X | Variable |   |
| subtract |   | float Self X |   |   |
| everyFrame |   | true |   |   |
| perSecond |   | false |   |   |

##### 9. FloatSubtract

Full Name: HutongGames.PlayMaker.Actions.FloatSubtract
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Raycast Y | Variable |   |
| subtract |   | float Self Y |   |   |
| everyFrame |   | true |   |   |
| perSecond |   | false |   |   |

##### 10. SetVector2XY

Full Name: HutongGames.PlayMaker.Actions.SetVector2XY
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector2Variable |   | Vector2 Raycast Vector | Variable |   |
| vector2Value |   | Vector2(0, 0) | Variable |   |
| x |   | float Raycast X |   |   |
| y |   | float Raycast Y |   |   |
| everyFrame |   | true |   |   |

##### 11. SetVector2XY

Full Name: HutongGames.PlayMaker.Actions.SetVector2XY
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector2Variable |   | Vector2 Hero Pos 2D | Variable |   |
| vector2Value |   | Vector2(0, 0) | Variable |   |
| x |   | float Hero X |   |   |
| y |   | float Hero Y |   |   |
| everyFrame |   | true |   |   |

##### 12. SetVector2XY

Full Name: HutongGames.PlayMaker.Actions.SetVector2XY
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector2Variable |   | Vector2 Self Pos 2D | Variable |   |
| vector2Value |   | Vector2(0, 0) | Variable |   |
| x |   | float Self X |   |   |
| y |   | float Self Y |   |   |
| everyFrame |   | true |   |   |

##### 13. DistanceBetweenPoints2D

Full Name: HutongGames.PlayMaker.Actions.DistanceBetweenPoints2D
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| distanceResult |   | float Distance | Variable |   |
| point1 |   | Vector2 Hero Pos 2D |   |   |
| point2 |   | Vector2 Self Pos 2D |   |   |
| everyFrame |   | true |   |   |

##### 14. RayCast2d

Full Name: HutongGames.PlayMaker.Actions.RayCast2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| fromGameObject |   | OwnerDefault Self |   | Setup |
| fromPosition |   | Vector2(0, 0) |   |   |
| direction |   | Vector2 Raycast Vector |   |   |
| space | UnityEngine.Space::World | 0 |   |   |
| distance |   | float Distance |   |   |
| minDepth |   | 0 |   |   |
| maxDepth |   | 0 |   |   |
| hitEvent |   | Event() | Variable | Result |
| storeDidHit |   | bool View Obscured | Variable |   |
| storeHitObject |   |   | Variable |   |
| storeHitPoint |   | Vector2(0, 0) | Variable |   |
| storeHitNormal |   | Vector2(0, 0) | Variable |   |
| storeHitDistance |   | 0f | Variable |   |
| storeHitFraction |   | 0f | Variable |   |
| repeatInterval |   | 1 |   | Filter |
| layerMask |   | FSMViewAvalonia2.FsmArray2 | Layer |   |
| invertMask |   | false |   |   |
| debugColor |   | Color(1, 0.92156863, 0.015686275, 1) |   | Debug |
| debug |   | true |   |   |

##### 15. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Can See Hero | Variable |   |
| boolValue |   | bool View Obscured |   |   |
| everyFrame |   | true |   |   |

##### 16. BoolFlipEveryFrame

Full Name: HutongGames.PlayMaker.Actions.BoolFlipEveryFrame
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Can See Hero | Variable |   |
| everyFrame |   | true |   |   |

##### 17. FloatTestToBool

Full Name: HutongGames.PlayMaker.Actions.FloatTestToBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 |   | float Distance |   |   |
| float2 |   | float Distance Max |   |   |
| tolerance |   | 0f |   |   |
| equalBool |   | false | Variable |   |
| lessThanBool |   | bool In Range | Variable |   |
| greaterThanBool |   | false | Variable |   |
| everyFrame |   | true |   |   |

##### 18. FloatTestToBool

Full Name: HutongGames.PlayMaker.Actions.FloatTestToBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 |   | float Angle To Hero |   |   |
| float2 |   | float Angle Min |   |   |
| tolerance |   | 0f |   |   |
| equalBool |   | false | Variable |   |
| lessThanBool |   | false | Variable |   |
| greaterThanBool |   | bool Over Angle Min | Variable |   |
| everyFrame |   | true |   |   |

##### 19. FloatTestToBool

Full Name: HutongGames.PlayMaker.Actions.FloatTestToBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 |   | float Angle To Hero |   |   |
| float2 |   | float Angle Max |   |   |
| tolerance |   | 0f |   |   |
| equalBool |   | false | Variable |   |
| lessThanBool |   | bool Under Angle Max | Variable |   |
| greaterThanBool |   | false | Variable |   |
| everyFrame |   | true |   |   |

##### 20. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 |   | float Distance |   |   |
| float2 |   | float Hide Distance |   |   |
| tolerance |   | 0f |   |   |
| equal |   | Event() |   |   |
| lessThan |   | Event(HIDE) |   |   |
| greaterThan |   | Event() |   |   |
| everyFrame |   | true |   |   |

##### 21. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Can See Hero | Variable |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(RETURN) |   |   |
| everyFrame |   | true |   |   |

##### 22. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Over Angle Min | Variable |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(RETURN) |   |   |
| everyFrame |   | true |   |   |

##### 23. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Under Angle Max | Variable |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(RETURN) |   |   |
| everyFrame |   | true |   |   |

##### 24. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool In Range | Variable |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(RETURN) |   |   |
| everyFrame |   | true |   |   |

##### 25. WaitRandom

Full Name: HutongGames.PlayMaker.Actions.WaitRandom
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| timeMin |   | 0.4f |   |   |
| timeMax |   | 0.6f |   |   |
| finishEvent |   | Event(SHOOT) |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| RETURN | Return Pause | 0 | |
| SHOOT | Shoot Antic | 0 | |

### Return Pause

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GetAngleToTarget2D

Full Name: HutongGames.PlayMaker.Actions.GetAngleToTarget2D
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| target |   | GameObject Hero |   |   |
| offsetX |   | 0f |   |   |
| offsetY |   | 0f |   |   |
| storeAngle |   | float Angle To Hero |   |   |
| everyFrame |   | true |   |   |

##### 2. FloatAddV2

Full Name: HutongGames.PlayMaker.Actions.FloatAddV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Angle To Hero | Variable |   |
| add |   | 360f |   |   |
| everyFrame |   | true |   |   |
| perSecond |   | false |   |   |
| fixedUpdate |   | false |   |   |
| activeBool |   | bool Facing Right | Variable |   |

##### 3. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Hero |   |   |
| vector |   | Vector3 Hero Position | Variable |   |
| x |   | float Hero X | Variable |   |
| y |   | float Hero Y | Variable |   |
| z |   | 0f | Variable |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| everyFrame |   | true |   |   |

##### 4. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Self |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | float Self X | Variable |   |
| y |   | float Self Y | Variable |   |
| z |   | 0f | Variable |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| everyFrame |   | true |   |   |

##### 5. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Raycast X | Variable |   |
| floatValue |   | float Hero X |   |   |
| everyFrame |   | true |   |   |

##### 6. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Raycast Y | Variable |   |
| floatValue |   | float Hero Y |   |   |
| everyFrame |   | true |   |   |

##### 7. FloatSubtract

Full Name: HutongGames.PlayMaker.Actions.FloatSubtract
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Raycast X | Variable |   |
| subtract |   | float Self X |   |   |
| everyFrame |   | true |   |   |
| perSecond |   | false |   |   |

##### 8. FloatSubtract

Full Name: HutongGames.PlayMaker.Actions.FloatSubtract
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Raycast Y | Variable |   |
| subtract |   | float Self Y |   |   |
| everyFrame |   | true |   |   |
| perSecond |   | false |   |   |

##### 9. SetVector2XY

Full Name: HutongGames.PlayMaker.Actions.SetVector2XY
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector2Variable |   | Vector2 Raycast Vector | Variable |   |
| vector2Value |   | Vector2(0, 0) | Variable |   |
| x |   | float Raycast X |   |   |
| y |   | float Raycast Y |   |   |
| everyFrame |   | true |   |   |

##### 10. SetVector2XY

Full Name: HutongGames.PlayMaker.Actions.SetVector2XY
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector2Variable |   | Vector2 Hero Pos 2D | Variable |   |
| vector2Value |   | Vector2(0, 0) | Variable |   |
| x |   | float Hero X |   |   |
| y |   | float Hero Y |   |   |
| everyFrame |   | true |   |   |

##### 11. SetVector2XY

Full Name: HutongGames.PlayMaker.Actions.SetVector2XY
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector2Variable |   | Vector2 Self Pos 2D | Variable |   |
| vector2Value |   | Vector2(0, 0) | Variable |   |
| x |   | float Self X |   |   |
| y |   | float Self Y |   |   |
| everyFrame |   | true |   |   |

##### 12. DistanceBetweenPoints2D

Full Name: HutongGames.PlayMaker.Actions.DistanceBetweenPoints2D
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| distanceResult |   | float Distance | Variable |   |
| point1 |   | Vector2 Hero Pos 2D |   |   |
| point2 |   | Vector2 Self Pos 2D |   |   |
| everyFrame |   | true |   |   |

##### 13. RayCast2d

Full Name: HutongGames.PlayMaker.Actions.RayCast2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| fromGameObject |   | OwnerDefault Self |   | Setup |
| fromPosition |   | Vector2(0, 0) |   |   |
| direction |   | Vector2 Raycast Vector |   |   |
| space | UnityEngine.Space::World | 0 |   |   |
| distance |   | float Distance |   |   |
| minDepth |   | 0 |   |   |
| maxDepth |   | 0 |   |   |
| hitEvent |   | Event() | Variable | Result |
| storeDidHit |   | bool View Obscured | Variable |   |
| storeHitObject |   |   | Variable |   |
| storeHitPoint |   | Vector2(0, 0) | Variable |   |
| storeHitNormal |   | Vector2(0, 0) | Variable |   |
| storeHitDistance |   | 0f | Variable |   |
| storeHitFraction |   | 0f | Variable |   |
| repeatInterval |   | 1 |   | Filter |
| layerMask |   | FSMViewAvalonia2.FsmArray2 | Layer |   |
| invertMask |   | false |   |   |
| debugColor |   | Color(1, 0.92156863, 0.015686275, 1) |   | Debug |
| debug |   | true |   |   |

##### 14. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Can See Hero | Variable |   |
| boolValue |   | bool View Obscured |   |   |
| everyFrame |   | true |   |   |

##### 15. BoolFlipEveryFrame

Full Name: HutongGames.PlayMaker.Actions.BoolFlipEveryFrame
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Can See Hero | Variable |   |
| everyFrame |   | true |   |   |

##### 16. FloatTestToBool

Full Name: HutongGames.PlayMaker.Actions.FloatTestToBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 |   | float Distance |   |   |
| float2 |   | float Distance Max |   |   |
| tolerance |   | 0f |   |   |
| equalBool |   | false | Variable |   |
| lessThanBool |   | bool In Range | Variable |   |
| greaterThanBool |   | false | Variable |   |
| everyFrame |   | true |   |   |

##### 17. FloatTestToBool

Full Name: HutongGames.PlayMaker.Actions.FloatTestToBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 |   | float Angle To Hero |   |   |
| float2 |   | float Angle Min |   |   |
| tolerance |   | 0f |   |   |
| equalBool |   | false | Variable |   |
| lessThanBool |   | false | Variable |   |
| greaterThanBool |   | bool Over Angle Min | Variable |   |
| everyFrame |   | true |   |   |

##### 18. FloatTestToBool

Full Name: HutongGames.PlayMaker.Actions.FloatTestToBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 |   | float Angle To Hero |   |   |
| float2 |   | float Angle Max |   |   |
| tolerance |   | 0f |   |   |
| equalBool |   | false | Variable |   |
| lessThanBool |   | bool Under Angle Max | Variable |   |
| greaterThanBool |   | false | Variable |   |
| everyFrame |   | true |   |   |

##### 19. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 |   | float Distance |   |   |
| float2 |   | float Hide Distance |   |   |
| tolerance |   | 0f |   |   |
| equal |   | Event() |   |   |
| lessThan |   | Event(HIDE) |   |   |
| greaterThan |   | Event() |   |   |
| everyFrame |   | true |   |   |

##### 20. BoolAllTrue

Full Name: HutongGames.PlayMaker.Actions.BoolAllTrue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariables |   | FSMViewAvalonia2.FsmArray2 | Variable |   |
| sendEvent |   | Event(SEE HERO) |   |   |
| storeResult |   | false | Variable |   |
| everyFrame |   | true |   |   |

##### 21. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 0.4f |   |   |
| finishEvent |   | Event(RETURN) |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| SEE HERO | Seen | 0 | |
| RETURN | Check | 0 | |

### Hide

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. iTweenRotateTo

Full Name: HutongGames.PlayMaker.Actions.iTweenRotateTo
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| id |   | "" |   |   |
| transformRotation |   |   |   |   |
| vectorRotation |   | Vector3 Start Angle |   |   |
| time |   | 0.5f |   |   |
| delay |   | 0f |   |   |
| speed |   | 0f |   |   |
| easeType | iTween/EaseType::easeOutCirc | 19 |   |   |
| loopType | iTween/LoopType::none | 0 |   |   |
| space | UnityEngine.Space::World | 0 |   |   |
| startEvent |   | Event() |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |
| stopOnExit |   | true |   |   |
| loopDontFinish |   | true |   |   |

##### 2. SetInvincible

Full Name: SetInvincible
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target |   | OwnerDefault FSM Owner | Variable |   |
| Invincible |   | true |   |   |
| InvincibleFromDirection |   | 0 |   |   |

##### 3. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "Hide" |   |   |

##### 4. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Awake | Variable |   |
| boolValue |   | false |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Check | 0 | |

### Shoot Antic

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| clipName |   | "Shoot" |   |   |
| animationTriggerEvent |   | Event(SHOOT) |   |   |
| animationCompleteEvent |   | Event() |   |   |

##### 2. LookAt2dGameObjectSmooth

Full Name: HutongGames.PlayMaker.Actions.LookAt2dGameObjectSmooth
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| targetObject |   | GameObject Hero |   |   |
| rotationOffset |   | 90f |   |   |
| speed |   | 3f |   |   |
| debug |   | false |   |   |
| debugLineColor |   | Color(0, 1, 0, 1) |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| SHOOT | Fire | 0 | |

### Fire

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. AudioPlaySimple

Full Name: HutongGames.PlayMaker.Actions.AudioPlaySimple
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| volume |   | 1f |   |   |
| oneShotClip |   | [plant_turret_spit (AudioClip) (Hollow Knight/hollow_knight_Data\sharedassets140.assets)] |   |   |

##### 2. LookAt2dGameObjectSmooth

Full Name: HutongGames.PlayMaker.Actions.LookAt2dGameObjectSmooth
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| targetObject |   | GameObject Hero |   |   |
| rotationOffset |   | 90f |   |   |
| speed |   | 3f |   |   |
| debug |   | false |   |   |
| debugLineColor |   | Color(0, 1, 0, 1) |   |   |

##### 3. Tk2dWatchAnimationEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dWatchAnimationEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| animationTriggerEvent |   | Event() |   |   |
| animationCompleteEvent |   | Event(FINISHED) |   |   |

##### 4. CreateObject

Full Name: HutongGames.PlayMaker.Actions.CreateObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Spike Ball (Hollow Knight/hollow_knight_Data\sharedassets140.assets)] |   |   |
| spawnPoint |   | [Plant Turret/Shot Spawn (Hollow Knight/hollow_knight_Data\level140)] |   |   |
| position |   | Vector3(0, 0, 0) |   |   |
| rotation |   | Vector3(0, 0, 0) |   |   |
| storeObject |   | GameObject Shot Instance | Variable |   |
| networkInstantiate |   | false |   |   |
| networkGroup |   | 0 |   |   |

##### 5. FireAtTarget

Full Name: HutongGames.PlayMaker.Actions.FireAtTarget
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Shot Instance |   |   |
| target |   | GameObject Hero |   |   |
| speed |   | 12f |   |   |
| position |   | Vector3(0, 0.4, 0) |   |   |
| spread |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 6. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Spit Effect |   |   |
| activate |   | true |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Idle Anim | 0 | |

### Idle Anim

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "Idle" |   |   |

##### 2. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 0.55f |   |   |
| finishEvent |   | Event() |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Check | 0 | |

### Facing Right

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Angle Max Alt | Variable |   |
| floatValue |   | float Angle Max |   |   |
| everyFrame |   | false |   |   |

##### 2. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Angle Min Alt | Variable |   |
| floatValue |   | float Angle Min |   |   |
| everyFrame |   | false |   |   |

##### 3. FloatSubtract

Full Name: HutongGames.PlayMaker.Actions.FloatSubtract
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Angle Max Alt | Variable |   |
| subtract |   | 360f |   |   |
| everyFrame |   | false |   |   |
| perSecond |   | false |   |   |

##### 4. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Angle Min | Variable |   |
| floatValue |   | float Angle Max Alt |   |   |
| everyFrame |   | false |   |   |

##### 5. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Angle Max | Variable |   |
| floatValue |   | float Angle Min Alt |   |   |
| everyFrame |   | false |   |   |

##### 6. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Facing Right | Variable |   |
| boolValue |   | true |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Check | 0 | |

## Global Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| HIDE | Hide | 0 | |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| HIDE | false |
| RAYCAST START | true |
| RAYCAST STOP | true |
| RETURN | false |
| RIGHT | false |
| SEE HERO | false |
| SHOOT | false |
| WAKE | true |

