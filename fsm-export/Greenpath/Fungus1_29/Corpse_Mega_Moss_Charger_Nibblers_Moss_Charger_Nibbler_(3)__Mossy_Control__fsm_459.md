# Mossy Control

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Mossy Control |
| GameObject Name | Moss Charger Nibbler (3) |
| GameObject Path | Corpse Mega Moss Charger/Nibblers |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets156.assets |
| Start State | Start |
| FSM PathId | 459 |
| GameObject PathId | 30 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Accel | 0.13 | Single: 0.13 |
| Appear X | 0 | Single: 0 |
| Attack Direction | 0 | Single: 0 |
| Attack Range Length | 0 | Single: 0 |
| Charge Speed | 18 | Single: 18 |
| Chooser | 0 | Single: 0 |
| Current Charge Speed | 0 | Single: 0 |
| Emerge Speed | 0 | Single: 0 |
| Hero X | 0 | Single: 0 |
| Max Speed L | -6 | Single: -6 |
| Max Speed R | 6 | Single: 6 |
| Random | 0 | Single: 0 |
| Start X | 0 | Single: 0 |
| Start Y | 0 | Single: 0 |
| Velocity | 0 | Single: 0 |
| X Max | 0 | Single: 0 |
| X Min | 0 | Single: 0 |

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Looper | 0 | Int32: 0 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Dig Check | false | Boolean: false |
| Ground Ahead | false | Boolean: false |
| Grounded | false | Boolean: false |
| Grounded2 | false | Boolean: false |
| In Attack Range | false | Boolean: false |
| RayDown1 | false | Boolean: false |
| left | false | Boolean: false |
| right | false | Boolean: false |

### Vector2s

| Name | Value | Raw/Type |
| --- | --- | --- |
| RayDown X | Vector2(0, 0) | Vector2: Vector2(0, 0) |
| RayForward Direction | Vector2(0, 0) | Vector2: Vector2(0, 0) |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Attack Range | [null] | NamedAssetPPtr:  |
| Camera | [null] | NamedAssetPPtr:  |
| Charge Grass | [null] | NamedAssetPPtr:  |
| G Explode 1 | [null] | NamedAssetPPtr:  |
| Grass Burst | [null] | NamedAssetPPtr:  |
| Grass Burst Down | [null] | NamedAssetPPtr:  |
| Grass Dig | [null] | NamedAssetPPtr:  |
| Grass Submerge | [null] | NamedAssetPPtr:  |
| Hero | [null] | NamedAssetPPtr:  |
| Hit Effect | [null] | NamedAssetPPtr:  |
| Range Grass | [null] | NamedAssetPPtr:  |
| Self | [null] | NamedAssetPPtr:  |
| Tent Box | Jellyfish/Tentacle Box (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets156.assets) | NamedAssetPPtr: Jellyfish/Tentacle Box (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets156.assets) |

## States

### Get Up

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| clipName | "Get Up" | "Get Up" |  |  |
| animationTriggerEvent | Event() | Event() |  |  |
| animationCompleteEvent | Event(FINISHED) | Event(FINISHED) |  |  |

### Run L

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. Tk2dPlayFrame

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayFrame
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| frame | 0 | 0 |  |  |

##### 2. SetScale

Full Name: HutongGames.PlayMaker.Actions.SetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | -1f | -1f |  |  |
| y | 0f | 0f |  |  |
| z | 0f | 0f |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 3. AccelerateVelocity

Full Name: HutongGames.PlayMaker.Actions.AccelerateVelocity
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| xAccel | -0.5f | -0.5f |  |  |
| yAccel | 0f | 0f |  |  |
| xMaxSpeed | 10f | 10f |  |  |
| yMaxSpeed | 0f | 0f |  |  |

##### 4. CheckTargetDirection

Full Name: HutongGames.PlayMaker.Actions.CheckTargetDirection
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| target | GameObject Hero | GameObject Hero |  |  |
| aboveEvent | Event() | Event() |  |  |
| belowEvent | Event() | Event() |  |  |
| rightEvent | Event() | Event() |  |  |
| leftEvent | Event(LEFT) | Event(LEFT) |  |  |
| aboveBool | false | false | Variable |  |
| belowBool | false | false | Variable |  |
| rightBool | bool right | bool right | Variable |  |
| leftBool | bool left | bool left | Variable |  |
| everyFrame | true | true |  |  |

##### 5. RayCast2d

Full Name: HutongGames.PlayMaker.Actions.RayCast2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| fromGameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  | Setup |
| fromPosition | Vector2(0, 0) | Vector2(0, 0) |  |  |
| direction | Vector2(-1, 0) | Vector2(-1, 0) |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| distance | 2f | 2f |  |  |
| minDepth | 0 | 0 |  |  |
| maxDepth | 0 | 0 |  |  |
| hitEvent | Event(SUBMERGE) | Event(SUBMERGE) | Variable | Result |
| storeDidHit | false | false | Variable |  |
| storeHitObject |  |  | Variable |  |
| storeHitPoint | Vector2(0, 0) | Vector2(0, 0) | Variable |  |
| storeHitNormal | Vector2(0, 0) | Vector2(0, 0) | Variable |  |
| storeHitDistance | 0f | 0f | Variable |  |
| storeHitFraction | 0f | 0f | Variable |  |
| repeatInterval | 1 | 1 |  | Filter |
| layerMask | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 | Layer |  |
| invertMask | false | false |  |  |
| debugColor | Color(1, 0.92156863, 0.015686275, 1) | Color(1, 0.92156863, 0.015686275, 1) |  | Debug |
| debug | true | true |  |  |

##### 6. RayCast2d

Full Name: HutongGames.PlayMaker.Actions.RayCast2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| fromGameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  | Setup |
| fromPosition | Vector2(-3, 0) | Vector2(-3, 0) |  |  |
| direction | Vector2(0, -1) | Vector2(0, -1) |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| distance | 1.3f | 1.3f |  |  |
| minDepth | 0 | 0 |  |  |
| maxDepth | 0 | 0 |  |  |
| hitEvent | Event() | Event() | Variable | Result |
| storeDidHit | bool Ground Ahead | bool Ground Ahead | Variable |  |
| storeHitObject |  |  | Variable |  |
| storeHitPoint | Vector2(0, 0) | Vector2(0, 0) | Variable |  |
| storeHitNormal | Vector2(0, 0) | Vector2(0, 0) | Variable |  |
| storeHitDistance | 0f | 0f | Variable |  |
| storeHitFraction | 0f | 0f | Variable |  |
| repeatInterval | 1 | 1 |  | Filter |
| layerMask | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 | Layer |  |
| invertMask | false | false |  |  |
| debugColor | Color(1, 0.92156863, 0.015686275, 1) | Color(1, 0.92156863, 0.015686275, 1) |  | Debug |
| debug | true | true |  |  |

##### 7. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Ground Ahead | bool Ground Ahead | Variable |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(SUBMERGE) | Event(SUBMERGE) |  |  |
| everyFrame | true | true |  |  |

##### 8. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 1f | 1f |  |  |
| finishEvent | Event(SUBMERGE) | Event(SUBMERGE) |  |  |
| realTime | false | false |  |  |

### Run R

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. Tk2dPlayFrame

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayFrame
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| frame | 0 | 0 |  |  |

##### 2. SetScale

Full Name: HutongGames.PlayMaker.Actions.SetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 1f | 1f |  |  |
| y | 0f | 0f |  |  |
| z | 0f | 0f |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 3. AccelerateVelocity

Full Name: HutongGames.PlayMaker.Actions.AccelerateVelocity
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| xAccel | 0.5f | 0.5f |  |  |
| yAccel | 0f | 0f |  |  |
| xMaxSpeed | 10f | 10f |  |  |
| yMaxSpeed | 0f | 0f |  |  |

##### 4. CheckTargetDirection

Full Name: HutongGames.PlayMaker.Actions.CheckTargetDirection
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| target | GameObject Hero | GameObject Hero |  |  |
| aboveEvent | Event() | Event() |  |  |
| belowEvent | Event() | Event() |  |  |
| rightEvent | Event(RIGHT) | Event(RIGHT) |  |  |
| leftEvent | Event() | Event() |  |  |
| aboveBool | false | false | Variable |  |
| belowBool | false | false | Variable |  |
| rightBool | bool right | bool right | Variable |  |
| leftBool | bool left | bool left | Variable |  |
| everyFrame | true | true |  |  |

##### 5. RayCast2d

Full Name: HutongGames.PlayMaker.Actions.RayCast2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| fromGameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  | Setup |
| fromPosition | Vector2(0, 0) | Vector2(0, 0) |  |  |
| direction | Vector2(1, 0) | Vector2(1, 0) |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| distance | 2f | 2f |  |  |
| minDepth | 0 | 0 |  |  |
| maxDepth | 0 | 0 |  |  |
| hitEvent | Event(SUBMERGE) | Event(SUBMERGE) | Variable | Result |
| storeDidHit | false | false | Variable |  |
| storeHitObject |  |  | Variable |  |
| storeHitPoint | Vector2(0, 0) | Vector2(0, 0) | Variable |  |
| storeHitNormal | Vector2(0, 0) | Vector2(0, 0) | Variable |  |
| storeHitDistance | 0f | 0f | Variable |  |
| storeHitFraction | 0f | 0f | Variable |  |
| repeatInterval | 1 | 1 |  | Filter |
| layerMask | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 | Layer |  |
| invertMask | false | false |  |  |
| debugColor | Color(1, 0.92156863, 0.015686275, 1) | Color(1, 0.92156863, 0.015686275, 1) |  | Debug |
| debug | true | true |  |  |

##### 6. RayCast2d

Full Name: HutongGames.PlayMaker.Actions.RayCast2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| fromGameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  | Setup |
| fromPosition | Vector2(3, 0) | Vector2(3, 0) |  |  |
| direction | Vector2(0, -1) | Vector2(0, -1) |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| distance | 1.3f | 1.3f |  |  |
| minDepth | 0 | 0 |  |  |
| maxDepth | 0 | 0 |  |  |
| hitEvent | Event() | Event() | Variable | Result |
| storeDidHit | bool Ground Ahead | bool Ground Ahead | Variable |  |
| storeHitObject |  |  | Variable |  |
| storeHitPoint | Vector2(0, 0) | Vector2(0, 0) | Variable |  |
| storeHitNormal | Vector2(0, 0) | Vector2(0, 0) | Variable |  |
| storeHitDistance | 0f | 0f | Variable |  |
| storeHitFraction | 0f | 0f | Variable |  |
| repeatInterval | 1 | 1 |  | Filter |
| layerMask | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 | Layer |  |
| invertMask | false | false |  |  |
| debugColor | Color(1, 0.92156863, 0.015686275, 1) | Color(1, 0.92156863, 0.015686275, 1) |  | Debug |
| debug | true | true |  |  |

##### 7. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Ground Ahead | bool Ground Ahead | Variable |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(SUBMERGE) | Event(SUBMERGE) |  |  |
| everyFrame | true | true |  |  |

##### 8. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 1f | 1f |  |  |
| finishEvent | Event(SUBMERGE) | Event(SUBMERGE) |  |  |
| realTime | false | false |  |  |

### Direction

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
| clipName | "TurnRun" | "TurnRun" |  |  |

##### 2. Tk2dPlayFrame

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayFrame
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| frame | 2 | 2 |  |  |

##### 3. CheckTargetDirection

Full Name: HutongGames.PlayMaker.Actions.CheckTargetDirection
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| target | GameObject Hero | GameObject Hero |  |  |
| aboveEvent | Event() | Event() |  |  |
| belowEvent | Event() | Event() |  |  |
| rightEvent | Event(RIGHT) | Event(RIGHT) |  |  |
| leftEvent | Event(LEFT) | Event(LEFT) |  |  |
| aboveBool | false | false | Variable |  |
| belowBool | false | false | Variable |  |
| rightBool | false | false | Variable |  |
| leftBool | false | false | Variable |  |
| everyFrame | false | false |  |  |

### In Air

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "health_manager_enemy" | "health_manager_enemy" | FsmName |  |
| variableName | "Invincible" | "Invincible" | FsmBool |  |
| setValue | false | false |  |  |
| everyFrame | false | false |  |  |

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
| bottomHitEvent | Event(DOWN) | Event(DOWN) |  |  |
| leftHitEvent | Event() | Event() |  |  |
| otherLayer | false | false |  |  |
| otherLayerNumber | 0 | 0 |  |  |
| ignoreTriggers | false | false |  |  |

##### 3. CheckCollisionSideEnter

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
| bottomHitEvent | Event(DOWN) | Event(DOWN) |  |  |
| leftHitEvent | Event() | Event() |  |  |
| otherLayer | false | false |  |  |
| otherLayerNumber | 0 | 0 |  |  |
| ignoreTriggers | false | false |  |  |

##### 4. SetCollider

Full Name: HutongGames.PlayMaker.Actions.SetCollider
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | true | true |  |  |

##### 5. SetGravity2dScale

Full Name: HutongGames.PlayMaker.Actions.SetGravity2dScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| gravityScale | 0f | 0f |  |  |

##### 6. SetGravity2dScale

Full Name: HutongGames.PlayMaker.Actions.SetGravity2dScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| gravityScale | 1.5f | 1.5f |  |  |

##### 7. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Stun" | "Stun" |  |  |

##### 8. StopParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.StopParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Grass Dig | OwnerDefault Grass Dig |  |  |

### Land

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector2(0, 0) | Vector2(0, 0) |  |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Dig Start

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "CANCEL RECOIL" | "CANCEL RECOIL" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. SetCollider

Full Name: HutongGames.PlayMaker.Actions.SetCollider
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | false | false |  |  |

##### 3. SetGravity2dScale

Full Name: HutongGames.PlayMaker.Actions.SetGravity2dScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| gravityScale | 0f | 0f |  |  |

##### 4. Decelerate

Full Name: HutongGames.PlayMaker.Actions.Decelerate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| deceleration | 0.4f | 0.4f |  |  |

##### 5. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| clipName | "Escape" | "Escape" |  |  |
| animationTriggerEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| animationCompleteEvent | Event() | Event() |  |  |

##### 6. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "health_manager_enemy" | "health_manager_enemy" | FsmName |  |
| variableName | "Invincible" | "Invincible" | FsmBool |  |
| setValue | false | false |  |  |
| everyFrame | false | false |  |  |

##### 7. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | SetActive(true) | SetActive(true) |  |  |

##### 8. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Dig Check | bool Dig Check | Variable |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(FALL) | Event(FALL) |  |  |
| everyFrame | true | true |  |  |

### On Ground?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. CheckCollisionSideEnter

Full Name: HutongGames.PlayMaker.Actions.CheckCollisionSideEnter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| topHit | false | false | Variable |  |
| rightHit | false | false | Variable |  |
| bottomHit | bool Grounded2 | bool Grounded2 | Variable |  |
| leftHit | false | false | Variable |  |
| topHitEvent | Event() | Event() |  |  |
| rightHitEvent | Event() | Event() |  |  |
| bottomHitEvent | Event() | Event() |  |  |
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
| bottomHit | bool Grounded | bool Grounded | Variable |  |
| leftHit | false | false | Variable |  |
| topHitEvent | Event() | Event() |  |  |
| rightHitEvent | Event() | Event() |  |  |
| bottomHitEvent | Event() | Event() |  |  |
| leftHitEvent | Event() | Event() |  |  |
| otherLayer | false | false |  |  |
| otherLayerNumber | 0 | 0 |  |  |
| ignoreTriggers | false | false |  |  |

##### 3. BoolAnyTrue

Full Name: HutongGames.PlayMaker.Actions.BoolAnyTrue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariables | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 | Variable |  |
| sendEvent | Event(DOWN) | Event(DOWN) |  |  |
| storeResult | false | false | Variable |  |
| everyFrame | true | true |  |  |

### Dig

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. PlayParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.PlayParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Grass Dig | OwnerDefault Grass Dig |  |  |
| emit | 0 | 0 |  |  |

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

##### 3. AudioPlayRandom

Full Name: HutongGames.PlayMaker.Actions.AudioPlayRandom
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Self | GameObject Self |  |  |
| audioClips | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| weights | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |

##### 4. Tk2dWatchAnimationEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dWatchAnimationEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animationTriggerEvent | Event() | Event() |  |  |
| animationCompleteEvent | Event(FINISHED) | Event(FINISHED) |  |  |

##### 5. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Dig Check | bool Dig Check | Variable |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(FALL) | Event(FALL) |  |  |
| everyFrame | true | true |  |  |

### Start

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetParent

Full Name: HutongGames.PlayMaker.Actions.SetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| parent |  |  |  |  |
| resetLocalPosition | false | false |  |  |
| resetLocalRotation | false | false |  |  |

##### 2. SetScale

Full Name: HutongGames.PlayMaker.Actions.SetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 1f | 1f |  |  |
| y | 0f | 0f |  |  |
| z | 0f | 0f |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 3. GetOwner

Full Name: HutongGames.PlayMaker.Actions.GetOwner
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeGameObject | GameObject Self | GameObject Self | Variable |  |

##### 4. FindGameObject

Full Name: HutongGames.PlayMaker.Actions.FindGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| objectName | "" | "" |  |  |
| withTag | "CameraParent" | "CameraParent" | Tag |  |
| store | GameObject Camera | GameObject Camera | Variable |  |

##### 5. FindGameObject

Full Name: HutongGames.PlayMaker.Actions.FindGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| objectName | "" | "" |  |  |
| withTag | "Player" | "Player" | Tag |  |
| store | GameObject Hero | GameObject Hero | Variable |  |

##### 6. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "INVULN" | "INVULN" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 7. PlayParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.PlayParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault G Explode 1 | OwnerDefault G Explode 1 |  |  |
| emit | 0 | 0 |  |  |

##### 8. StopParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.StopParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Charge Grass | OwnerDefault Charge Grass |  |  |

##### 9. StopParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.StopParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Charge Grass | OwnerDefault Charge Grass |  |  |

##### 10. SetGravity2dScale

Full Name: HutongGames.PlayMaker.Actions.SetGravity2dScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| gravityScale | 1.5f | 1.5f |  |  |

##### 11. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObjectFSM)[SendToFSM: CameraShake]:Camera | EventTarget(GameObjectFSM)[SendToFSM: CameraShake]:Camera |  |  |
| sendEvent | "EnemyKillShake" | "EnemyKillShake" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 12. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Stun" | "Stun" |  |  |

##### 13. GetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.GetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "health_manager_enemy" | "health_manager_enemy" | FsmName |  |
| variableName | "Attack Direction" | "Attack Direction" | FsmFloat |  |
| storeValue | float Attack Direction | float Attack Direction | Variable |  |
| everyFrame | false | false |  |  |

##### 14. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min | 60f | 60f |  |  |
| max | 120f | 120f |  |  |
| storeResult | float Chooser | float Chooser | Variable |  |

##### 15. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min | 28f | 28f |  |  |
| max | 38f | 38f |  |  |
| storeResult | float Random | float Random | Variable |  |

##### 16. SetVelocityAsAngle

Full Name: HutongGames.PlayMaker.Actions.SetVelocityAsAngle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| angle | float Chooser | float Chooser |  |  |
| speed | float Random | float Random |  |  |
| everyFrame | false | false |  |  |

##### 17. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min | -100f | -100f |  |  |
| max | -80f | -80f |  |  |
| storeResult | float Chooser | float Chooser | Variable |  |

##### 18. SetRotation

Full Name: HutongGames.PlayMaker.Actions.SetRotation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hit Effect | OwnerDefault Hit Effect |  |  |
| quaternion | Quaternion(0, 0, 0, 0) | Quaternion(0, 0, 0, 0) | Variable |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| xAngle | 0f | 0f |  |  |
| yAngle | 0f | 0f |  |  |
| zAngle | float Chooser | float Chooser |  |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 19. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Grass Dig" | "Grass Dig" |  |  |
| storeResult | GameObject Grass Dig | GameObject Grass Dig | Variable |  |

### Destroy

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. DestroySelf

Full Name: HutongGames.PlayMaker.Actions.DestroySelf
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| detachChildren | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Get Up | FINISHED | Direction | 0 | 0 | 0 |
| Run L | LEFT | Run R | 0 | 0 | 0 |
| Run L | SUBMERGE | On Ground? | 0 | 0 | 0 |
| Run R | RIGHT | Run L | 0 | 0 | 0 |
| Run R | SUBMERGE | On Ground? | 0 | 0 | 0 |
| Direction | LEFT | Run R | 0 | 0 | 0 |
| Direction | RIGHT | Run L | 0 | 0 | 0 |
| In Air | DOWN | Land | 0 | 0 | 0 |
| Land | FINISHED | Get Up | 0 | 0 | 0 |
| Dig Start | FINISHED | Dig | 0 | 0 | 0 |
| On Ground? | DOWN | Dig Start | 0 | 0 | 0 |
| On Ground? | FINISHED | Run L | 0 | 0 | 0 |
| Dig | FINISHED | Destroy | 0 | 0 | 0 |
| Start | FINISHED | In Air | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| BLOCKED HIT | true |
| CANCEL | false |
| DOWN | false |
| FALL | false |
| TAKE DAMAGE | false |
| IN RANGE | false |
| LAND | false |
| LEFT | false |
| LOOP COMPLETE | false |
| RIGHT | false |
| SUBMERGE | false |
| UP | false |
| ZERO HP | false |

