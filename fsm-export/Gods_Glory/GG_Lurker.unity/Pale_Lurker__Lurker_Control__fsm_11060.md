# Lurker Control

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Lurker Control |
| GameObject Name | Pale Lurker |
| GameObject Path | Lurker Control/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level451 |
| Start State | Init |
| FSM PathId | 11060 |
| GameObject PathId | 139 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Crt Jump | 0 | Single: 0 |
| Crt Speed | 0 | Single: 0 |
| Distance | 0 | Single: 0 |
| Gravity | 2 | Single: 2 |
| Hero Y | 0 | Single: 0 |
| Hop X Force | -14 | Single: -14 |
| Hop Y Force | 45 | Single: 45 |
| Jump X Force | -13 | Single: -13 |
| Jump Y Force | 50 | Single: 50 |
| Left Pos | 122.099998 | Single: 122.099998 |
| Mid Y | 96.5999985 | Single: 96.5999985 |
| Right Pos | 196 | Single: 196 |
| X Pos | 0 | Single: 0 |
| X Scale | 0 | Single: 0 |

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Ct Dig | 0 | Int32: 0 |
| Ct Hop | 0 | Int32: 0 |
| Ct ThrowDownN | 0 | Int32: 0 |
| Ct ThrowDownY | 0 | Int32: 0 |
| Ct ThrowUpN | 0 | Int32: 0 |
| Ct ThrowUpY | 0 | Int32: 0 |
| Hit Count | 0 | Int32: 0 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Ceiling Above | false | Boolean: false |
| Facing Left | false | Boolean: false |
| Ground Below 1 | false | Boolean: false |
| Ground Below 2 | false | Boolean: false |
| Hero Is Right | false | Boolean: false |
| Hero L | false | Boolean: false |
| Hero R | false | Boolean: false |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Burst Line | [null] | NamedAssetPPtr: [null] |
| Dig Dust | [null] | NamedAssetPPtr: [null] |
| Pt Jump | Lurker Control/Tele High (Hollow Knight/hollow_knight_Data\level451) | NamedAssetPPtr: [Lurker Control/Tele High (Hollow Knight/hollow_knight_Data\level451)] |
| Self | Lurker Control/Tele Low (Hollow Knight/hollow_knight_Data\level451) | NamedAssetPPtr: [Lurker Control/Tele Low (Hollow Knight/hollow_knight_Data\level451)] |
| Slash Ball | Lurker Control/Tele High (Hollow Knight/hollow_knight_Data\level451) | NamedAssetPPtr: [Lurker Control/Tele High (Hollow Knight/hollow_knight_Data\level451)] |
| Tele High | Lurker Control/Tele High (Hollow Knight/hollow_knight_Data\level451) | NamedAssetPPtr: [Lurker Control/Tele High (Hollow Knight/hollow_knight_Data\level451)] |
| Tele Low | Lurker Control/Tele Low (Hollow Knight/hollow_knight_Data\level451) | NamedAssetPPtr: [Lurker Control/Tele Low (Hollow Knight/hollow_knight_Data\level451)] |
| Tele Point | [null] | NamedAssetPPtr: [null] |
| Throw Point | Lurker Control/Pale Lurker/Throw Point (Hollow Knight/hollow_knight_Data\level451) | NamedAssetPPtr: [Lurker Control/Pale Lurker/Throw Point (Hollow Knight/hollow_knight_Data\level451)] |
| Voice Player | [null] | NamedAssetPPtr: [null] |

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

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Pt Jump" |   |   |
| storeResult |   | GameObject Pt Jump | Variable |   |

##### 3. SetGravity2dScale

Full Name: HutongGames.PlayMaker.Actions.SetGravity2dScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| gravityScale |   | float Gravity |   |   |

##### 4. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Slash Ball" |   |   |
| storeResult |   | GameObject Slash Ball | Variable |   |

##### 5. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Burst Line" |   |   |
| storeResult |   | GameObject Burst Line | Variable |   |

##### 6. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Dig Dust" |   |   |
| storeResult |   | GameObject Dig Dust | Variable |   |

##### 7. RandomInt

Full Name: HutongGames.PlayMaker.Actions.RandomInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min |   | 3 |   |   |
| max |   | 4 |   |   |
| storeResult |   | int Hit Count | Variable |   |
| inclusiveMax |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Dormant | 0 | |

### Hop Air

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "Fall" |   |   |

##### 2. PlayParticleEmitterInState

Full Name: HutongGames.PlayMaker.Actions.PlayParticleEmitterInState
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Pt Jump |   |   |

##### 3. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Ground Below 1 | Variable |   |
| boolValue |   | true |   |   |
| everyFrame |   | false |   |   |

##### 4. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Ground Below 2 | Variable |   |
| boolValue |   | true |   |   |
| everyFrame |   | false |   |   |

##### 5. CheckCollisionSide

Full Name: HutongGames.PlayMaker.Actions.CheckCollisionSide
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| topHit |   | false | Variable |   |
| rightHit |   | false | Variable |   |
| bottomHit |   | false | Variable |   |
| leftHit |   | false | Variable |   |
| topHitEvent |   |   |   |   |
| rightHitEvent |   | WALL |   |   |
| bottomHitEvent |   | LAND |   |   |
| leftHitEvent |   | WALL |   |   |
| otherLayer |   | false |   |   |
| otherLayerNumber |   | 0 |   |   |
| ignoreTriggers |   | false |   |   |

##### 6. CheckCollisionSideEnter

Full Name: HutongGames.PlayMaker.Actions.CheckCollisionSideEnter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| topHit |   | false | Variable |   |
| rightHit |   | false | Variable |   |
| bottomHit |   | false | Variable |   |
| leftHit |   | false | Variable |   |
| topHitEvent |   |   |   |   |
| rightHitEvent |   | WALL |   |   |
| bottomHitEvent |   | LAND |   |   |
| leftHitEvent |   | WALL |   |   |
| otherLayer |   | false |   |   |
| otherLayerNumber |   | 0 |   |   |
| ignoreTriggers |   | false |   |   |

##### 7. RayCast2dV2

Full Name: HutongGames.PlayMaker.Actions.RayCast2dV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| fromGameObject |   | OwnerDefault FSM Owner |   | Setup |
| fromPosition |   | Vector2(-0.8, 0) |   |   |
| direction |   | Vector2(0, -1) |   |   |
| space | UnityEngine.Space::World | 0 |   |   |
| distance |   | 10f |   |   |
| minDepth |   | 0 |   |   |
| maxDepth |   | 0 |   |   |
| hitEvent |   |   | Variable | Result |
| storeDidHit |   | bool Ground Below 1 | Variable |   |
| storeHitObject |   |   | Variable |   |
| storeHitPoint |   | Vector2(0, 0) | Variable |   |
| storeHitNormal |   | Vector2(0, 0) | Variable |   |
| storeHitDistance |   | 0f | Variable |   |
| storeDistance |   | 0f | Variable |   |
| repeatInterval |   | 1 |   | Filter |
| layerMask |   | FSMViewAvalonia2.FsmArray2 | Layer |   |
| invertMask |   | false |   |   |
| debugColor |   | Color(1, 0.92156863, 0.015686275, 1) |   | Debug |
| debug |   | true |   |   |

##### 8. RayCast2dV2

Full Name: HutongGames.PlayMaker.Actions.RayCast2dV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| fromGameObject |   | OwnerDefault FSM Owner |   | Setup |
| fromPosition |   | Vector2(0.8, 0) |   |   |
| direction |   | Vector2(0, -1) |   |   |
| space | UnityEngine.Space::World | 0 |   |   |
| distance |   | 10f |   |   |
| minDepth |   | 0 |   |   |
| maxDepth |   | 0 |   |   |
| hitEvent |   |   | Variable | Result |
| storeDidHit |   | bool Ground Below 2 | Variable |   |
| storeHitObject |   |   | Variable |   |
| storeHitPoint |   | Vector2(0, 0) | Variable |   |
| storeHitNormal |   | Vector2(0, 0) | Variable |   |
| storeHitDistance |   | 0f | Variable |   |
| storeDistance |   | 0f | Variable |   |
| repeatInterval |   | 1 |   | Filter |
| layerMask |   | FSMViewAvalonia2.FsmArray2 | Layer |   |
| invertMask |   | false |   |   |
| debugColor |   | Color(1, 0.92156863, 0.015686275, 1) |   | Debug |
| debug |   | true |   |   |

##### 9. BoolNoneTrue

Full Name: HutongGames.PlayMaker.Actions.BoolNoneTrue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariables |   | FSMViewAvalonia2.FsmArray2 | Variable |   |
| sendEvent |   | FALL |   |   |
| storeResult |   | false | Variable |   |
| everyFrame |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| WALL | Wall Cling | 0 | |
| LAND | Hopland | 0 | |
| FALL | Fall | 0 | |

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
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector2(0, 0) |   |   |
| x |   | 0f |   |   |
| y |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 2. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| clipName |   | "Land" |   |   |
| animationTriggerEvent |   |   |   |   |
| animationCompleteEvent |   |   |   |   |

##### 3. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 0.5f |   |   |
| finishEvent |   | FINISHED |   |   |
| realTime |   | false |   |   |

##### 4. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer |   | [Global] [Audio Player Actor (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| audioClip |   | [hornet_ground_land (AudioClip) (Hollow Knight/hollow_knight_Data\sharedassets28.assets)] |   |   |
| pitchMin |   | 0.9f |   |   |
| pitchMax |   | 1.1f |   |   |
| volume |   | 1f |   |   |
| delay |   | 0f |   |   |
| storePlayer |   |   |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Hop Antic | 0 | |

### Wall Cling

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector2(0, 0) |   |   |
| x |   | 0f |   |   |
| y |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 2. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "Wall Cling" |   |   |

##### 3. SetGravity2dScale

Full Name: HutongGames.PlayMaker.Actions.SetGravity2dScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| gravityScale |   | 0f |   |   |

##### 4. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 0.25f |   |   |
| finishEvent |   | FINISHED |   |   |
| realTime |   | false |   |   |

##### 5. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer |   | [Global] [Audio Player Actor (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| audioClip |   | [hornet_wall_land (AudioClip) (Hollow Knight/hollow_knight_Data\sharedassets15.assets)] |   |   |
| pitchMin |   | 0.9f |   |   |
| pitchMax |   | 1.1f |   |   |
| volume |   | 1f |   |   |
| delay |   | 0f |   |   |
| storePlayer |   |   |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Wallbarb | 0 | |

### Walljump Antic

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
| clipName |   | "Wallhop Antic" |   |   |
| animationTriggerEvent |   |   |   |   |
| animationCompleteEvent |   | FINISHED |   |   |

##### 2. FlipScale

Full Name: HutongGames.PlayMaker.Actions.FlipScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| flipHorizontally |   | true |   |   |
| flipVertically |   | false |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Walljump | 0 | |

### Walljump

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. FlipScale

Full Name: HutongGames.PlayMaker.Actions.FlipScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| flipHorizontally |   | true |   |   |
| flipVertically |   | false |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

##### 2. AudioPlayRandom

Full Name: HutongGames.PlayMaker.Actions.AudioPlayRandom
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | GameObject Self |   |   |
| audioClips |   | FSMViewAvalonia2.FsmArray2 |   |   |
| weights |   | FSMViewAvalonia2.FsmArray2 |   |   |
| pitchMin |   | 1f |   |   |
| pitchMax |   | 1f |   |   |

##### 3. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "Hop" |   |   |

##### 4. GetScale

Full Name: HutongGames.PlayMaker.Actions.GetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| xScale |   | float X Scale | Variable |   |
| yScale |   | 0f | Variable |   |
| zScale |   | 0f | Variable |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |

##### 5. FloatOperator

Full Name: HutongGames.PlayMaker.Actions.FloatOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 |   | float Jump X Force |   |   |
| float2 |   | float X Scale |   |   |
| operation | HutongGames.PlayMaker.Actions.FloatOperator/Operation::Multiply | 2 |   |   |
| storeResult |   | float Crt Speed | Variable |   |
| everyFrame |   | false |   |   |

##### 6. FloatOperator

Full Name: HutongGames.PlayMaker.Actions.FloatOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 |   | float Jump Y Force |   |   |
| float2 |   | 0.9f |   |   |
| operation | HutongGames.PlayMaker.Actions.FloatOperator/Operation::Multiply | 2 |   |   |
| storeResult |   | float Crt Jump | Variable |   |
| everyFrame |   | false |   |   |

##### 7. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector2(0, 0) |   |   |
| x |   | float Crt Speed |   |   |
| y |   | float Crt Jump |   |   |
| everyFrame |   | false |   |   |

##### 8. NextFrameEvent

Full Name: HutongGames.PlayMaker.Actions.NextFrameEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent |   | FINISHED |   |   |

##### 9. SetGravity2dScale

Full Name: HutongGames.PlayMaker.Actions.SetGravity2dScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| gravityScale |   | float Gravity |   |   |

##### 10. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer |   | [Global] [Audio Player Actor (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| audioClip |   | [brkn_wand_jump (AudioClip) (Hollow Knight/hollow_knight_Data\sharedassets34.assets)] |   |   |
| pitchMin |   | 1f |   |   |
| pitchMax |   | 1.2f |   |   |
| volume |   | 1f |   |   |
| delay |   | 0f |   |   |
| storePlayer |   |   |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Jump Air | 0 | |

### Wallthrow

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
| clipName |   | "Throw" |   |   |
| animationTriggerEvent |   |   |   |   |
| animationCompleteEvent |   | FINISHED |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Walljump Antic | 0 | |

### Wallbarb

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. FlipScale

Full Name: HutongGames.PlayMaker.Actions.FlipScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| flipHorizontally |   | true |   |   |
| flipVertically |   | false |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

##### 2. GetScale

Full Name: HutongGames.PlayMaker.Actions.GetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| xScale |   | float X Scale | Variable |   |
| yScale |   | 0f | Variable |   |
| zScale |   | 0f | Variable |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |

##### 3. FloatOperator

Full Name: HutongGames.PlayMaker.Actions.FloatOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 |   | float X Scale |   |   |
| float2 |   | -25f |   |   |
| operation | HutongGames.PlayMaker.Actions.FloatOperator/Operation::Multiply | 2 |   |   |
| storeResult |   | float Crt Speed | Variable |   |
| everyFrame |   | false |   |   |

##### 4. FlingObjectsFromGlobalPoolVel

Full Name: HutongGames.PlayMaker.Actions.FlingObjectsFromGlobalPoolVel
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Lurker Barb (Hollow Knight/hollow_knight_Data\sharedassets451.assets)] |   |   |
| spawnPoint |   | [Lurker Control/Pale Lurker/Throw Point (Hollow Knight/hollow_knight_Data\level451)] |   |   |
| position |   | Vector3(0, 0, 0) |   |   |
| spawnMin |   | 1 |   |   |
| spawnMax |   | 1 |   |   |
| speedMinX |   | float Crt Speed |   |   |
| speedMaxX |   | float Crt Speed |   |   |
| speedMinY |   | -5f |   |   |
| speedMaxY |   | 5f |   |   |
| originVariationX |   | 0f |   |   |
| originVariationY |   | 0f |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Wallthrow | 0 | |

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 4

#### Actions

##### 1. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "Idle" |   |   |

##### 2. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Hero L | Variable |   |
| isTrue |   | HERO L |   |   |
| isFalse |   |   |   |   |
| everyFrame |   | true |   |   |

##### 3. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Hero R | Variable |   |
| isTrue |   | HERO R |   |   |
| isFalse |   |   |   |   |
| everyFrame |   | true |   |   |

##### 4. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 2f |   |   |
| finishEvent |   | SLASH |   |   |
| realTime |   | false |   |   |

##### 5. AudioPlayInState

Full Name: HutongGames.PlayMaker.Actions.AudioPlayInState
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| volume |   | 1f |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| HERO L | Alert Anim | 0 | |
| HERO R | Alert Anim | 0 | |
| TOOK DAMAGE | Alert Anim | 0 | |
| HERO CAST SPELL | Dig 1 | 0 | |

### Hop Antic

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. FaceObject

Full Name: HutongGames.PlayMaker.Actions.FaceObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| objectA |   | GameObject Self |   |   |
| objectB |   | [Global] GameObject Hero | Variable |   |
| spriteFacesRight |   | true |   |   |
| playNewAnimation |   | false |   |   |
| newAnimationClip |   | "" |   |   |
| resetFrame |   | false |   |   |
| everyFrame |   | false |   |   |

##### 2. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| clipName |   | "Hop Antic" |   |   |
| animationTriggerEvent |   |   |   |   |
| animationCompleteEvent |   | FINISHED |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED |  Hop | 0 | |
| HERO CAST SPELL | Dig 1 | 0 | |

###  Hop

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "Hop" |   |   |

##### 2. AudioPlayRandom

Full Name: HutongGames.PlayMaker.Actions.AudioPlayRandom
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | GameObject Self |   |   |
| audioClips |   | FSMViewAvalonia2.FsmArray2 |   |   |
| weights |   | FSMViewAvalonia2.FsmArray2 |   |   |
| pitchMin |   | 1f |   |   |
| pitchMax |   | 1f |   |   |

##### 3. GetScale

Full Name: HutongGames.PlayMaker.Actions.GetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| xScale |   | float X Scale | Variable |   |
| yScale |   | 0f | Variable |   |
| zScale |   | 0f | Variable |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |

##### 4. FloatOperator

Full Name: HutongGames.PlayMaker.Actions.FloatOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 |   | float Hop X Force |   |   |
| float2 |   | float X Scale |   |   |
| operation | HutongGames.PlayMaker.Actions.FloatOperator/Operation::Multiply | 2 |   |   |
| storeResult |   | float Crt Speed | Variable |   |
| everyFrame |   | false |   |   |

##### 5. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min |   | 30f |   |   |
| max |   | 35f |   |   |
| storeResult |   | float Hop Y Force | Variable |   |

##### 6. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector2(0, 0) |   |   |
| x |   | float Crt Speed |   |   |
| y |   | float Hop Y Force |   |   |
| everyFrame |   | false |   |   |

##### 7. NextFrameEvent

Full Name: HutongGames.PlayMaker.Actions.NextFrameEvent
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent |   | FINISHED |   |   |

##### 8. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer |   | [Global] [Audio Player Actor (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| audioClip |   | [brkn_wand_jump (AudioClip) (Hollow Knight/hollow_knight_Data\sharedassets34.assets)] |   |   |
| pitchMin |   | 1f |   |   |
| pitchMax |   | 1.2f |   |   |
| volume |   | 1f |   |   |
| delay |   | 0f |   |   |
| storePlayer |   |   |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Hopthrow Antic | 0 | |

### After Land

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. GetXDistance

Full Name: HutongGames.PlayMaker.Actions.GetXDistance
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| target |   | [Global] GameObject Hero |   |   |
| storeResult |   | float Distance | Variable |   |
| everyFrame |   | false |   |   |

##### 2. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Hit Count |   |   |
| integer2 |   | 0 |   |   |
| equal |   | SLASH |   |   |
| lessThan |   | SLASH |   |   |
| greaterThan |   |   |   |   |
| everyFrame |   | false |   |   |

##### 3. GetDistance

Full Name: HutongGames.PlayMaker.Actions.GetDistance
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| target |   | [Global] GameObject Hero |   |   |
| storeResult |   | float Distance | Variable |   |
| everyFrame |   | true |   |   |

##### 4. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 |   | float Distance |   |   |
| float2 |   | 25f |   |   |
| tolerance |   | 0f |   |   |
| equal |   | HOP |   |   |
| lessThan |   | HOP |   |   |
| greaterThan |   | IDLE |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| HOP | Hop Antic | 0 | |
| IDLE | Alert | 0 | |
| SLASH | Slash Antic | 0 | |

### Jump Air

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. CheckCollisionSide

Full Name: HutongGames.PlayMaker.Actions.CheckCollisionSide
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| topHit |   | false | Variable |   |
| rightHit |   | false | Variable |   |
| bottomHit |   | false | Variable |   |
| leftHit |   | false | Variable |   |
| topHitEvent |   |   |   |   |
| rightHitEvent |   | WALL |   |   |
| bottomHitEvent |   | LAND |   |   |
| leftHitEvent |   | WALL |   |   |
| otherLayer |   | false |   |   |
| otherLayerNumber |   | 0 |   |   |
| ignoreTriggers |   | false |   |   |

##### 2. CheckCollisionSideEnter

Full Name: HutongGames.PlayMaker.Actions.CheckCollisionSideEnter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| topHit |   | false | Variable |   |
| rightHit |   | false | Variable |   |
| bottomHit |   | false | Variable |   |
| leftHit |   | false | Variable |   |
| topHitEvent |   |   |   |   |
| rightHitEvent |   | WALL |   |   |
| bottomHitEvent |   | LAND |   |   |
| leftHitEvent |   | WALL |   |   |
| otherLayer |   | false |   |   |
| otherLayerNumber |   | 0 |   |   |
| ignoreTriggers |   | false |   |   |

##### 3. PlayParticleEmitterInState

Full Name: HutongGames.PlayMaker.Actions.PlayParticleEmitterInState
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Pt Jump |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| WALL | Wall Cling | 0 | |
| LAND | Land | 0 | |

### Fall

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. CheckCollisionSide

Full Name: HutongGames.PlayMaker.Actions.CheckCollisionSide
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| topHit |   | false | Variable |   |
| rightHit |   | false | Variable |   |
| bottomHit |   | false | Variable |   |
| leftHit |   | false | Variable |   |
| topHitEvent |   |   |   |   |
| rightHitEvent |   | WALL |   |   |
| bottomHitEvent |   | LAND |   |   |
| leftHitEvent |   | WALL |   |   |
| otherLayer |   | false |   |   |
| otherLayerNumber |   | 0 |   |   |
| ignoreTriggers |   | false |   |   |

##### 2. CheckCollisionSideEnter

Full Name: HutongGames.PlayMaker.Actions.CheckCollisionSideEnter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| topHit |   | false | Variable |   |
| rightHit |   | false | Variable |   |
| bottomHit |   | false | Variable |   |
| leftHit |   | false | Variable |   |
| topHitEvent |   |   |   |   |
| rightHitEvent |   | WALL |   |   |
| bottomHitEvent |   | LAND |   |   |
| leftHitEvent |   | WALL |   |   |
| otherLayer |   | false |   |   |
| otherLayerNumber |   | 0 |   |   |
| ignoreTriggers |   | false |   |   |

##### 3. DecelerateXY

Full Name: HutongGames.PlayMaker.Actions.DecelerateXY
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| decelerationX |   | 0.9f |   |   |
| decelerationY |   | 0f |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| LAND | After Fall | 0 | |

### Alert

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 6

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Hit Count |   |   |
| integer2 |   | 0 |   |   |
| equal |   | SLASH |   |   |
| lessThan |   | SLASH |   |   |
| greaterThan |   |   |   |   |
| everyFrame |   | false |   |   |

##### 2. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "Idle" |   |   |

##### 3. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Hero L | Variable |   |
| isTrue |   | HERO L |   |   |
| isFalse |   |   |   |   |
| everyFrame |   | true |   |   |

##### 4. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Hero R | Variable |   |
| isTrue |   | HERO R |   |   |
| isFalse |   |   |   |   |
| everyFrame |   | true |   |   |

##### 5. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 3f |   |   |
| finishEvent |   | DIG |   |   |
| realTime |   | false |   |   |

##### 6. AudioPlayInState

Full Name: HutongGames.PlayMaker.Actions.AudioPlayInState
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| volume |   | 1f |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| HERO L | Hop Antic | 0 | |
| HERO R | Hop Antic | 0 | |
| DIG | Dig 1 | 0 | |
| SLASH | Slash Antic | 0 | |
| TOOK DAMAGE | Hop Antic | 0 | |
| HERO CAST SPELL | Dig 1 | 0 | |

### After Fall

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | float X Pos | Variable |   |
| y |   | 0f | Variable |   |
| z |   | 0f | Variable |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |

##### 2. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 |   | float X Pos |   |   |
| float2 |   | float Left Pos |   |   |
| tolerance |   | 0f |   |   |
| equal |   |   |   |   |
| lessThan |   | R |   |   |
| greaterThan |   |   |   |   |
| everyFrame |   | false |   |   |

##### 3. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 |   | float X Pos |   |   |
| float2 |   | float Right Pos |   |   |
| tolerance |   | 0f |   |   |
| equal |   |   |   |   |
| lessThan |   |   |   |   |
| greaterThan |   | L |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| L | Face Left | 0 | |
| R | Face Right | 0 | |
| FINISHED | Hop Antic | 0 | |

### Face Left

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetScale

Full Name: HutongGames.PlayMaker.Actions.SetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 1f |   |   |
| y |   | 0f |   |   |
| z |   | 0f |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

##### 2. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| clipName |   | "Hop Antic" |   |   |
| animationTriggerEvent |   |   |   |   |
| animationCompleteEvent |   | FINISHED |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED |  Hop | 0 | |

### Face Right

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetScale

Full Name: HutongGames.PlayMaker.Actions.SetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | -1f |   |   |
| y |   | 0f |   |   |
| z |   | 0f |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

##### 2. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| clipName |   | "Hop Antic" |   |   |
| animationTriggerEvent |   |   |   |   |
| animationCompleteEvent |   | FINISHED |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED |  Hop | 0 | |

### Hopthrow Antic

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. SendRandomEventV2

Full Name: HutongGames.PlayMaker.Actions.SendRandomEventV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| events |   | FSMViewAvalonia2.FsmArray2 |   |   |
| weights |   | FSMViewAvalonia2.FsmArray2 |   |   |
| trackingInts |   | FSMViewAvalonia2.FsmArray2 | Variable |   |
| eventMax |   | FSMViewAvalonia2.FsmArray2 |   |   |

##### 2. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| clipName |   | "Throw Antic" |   |   |
| animationTriggerEvent |   |   |   |   |
| animationCompleteEvent |   | FINISHED |   |   |

##### 3. CheckCollisionSide

Full Name: HutongGames.PlayMaker.Actions.CheckCollisionSide
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| topHit |   | false | Variable |   |
| rightHit |   | false | Variable |   |
| bottomHit |   | false | Variable |   |
| leftHit |   | false | Variable |   |
| topHitEvent |   |   |   |   |
| rightHitEvent |   | WALL |   |   |
| bottomHitEvent |   | LAND |   |   |
| leftHitEvent |   | WALL |   |   |
| otherLayer |   | false |   |   |
| otherLayerNumber |   | 0 |   |   |
| ignoreTriggers |   | false |   |   |

##### 4. CheckCollisionSideEnter

Full Name: HutongGames.PlayMaker.Actions.CheckCollisionSideEnter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| topHit |   | false | Variable |   |
| rightHit |   | false | Variable |   |
| bottomHit |   | false | Variable |   |
| leftHit |   | false | Variable |   |
| topHitEvent |   |   |   |   |
| rightHitEvent |   | WALL |   |   |
| bottomHitEvent |   | LAND |   |   |
| leftHitEvent |   | WALL |   |   |
| otherLayer |   | false |   |   |
| otherLayerNumber |   | 0 |   |   |
| ignoreTriggers |   | false |   |   |

##### 5. RayCast2dV2

Full Name: HutongGames.PlayMaker.Actions.RayCast2dV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| fromGameObject |   | OwnerDefault FSM Owner |   | Setup |
| fromPosition |   | Vector2(-0.8, 0) |   |   |
| direction |   | Vector2(0, -1) |   |   |
| space | UnityEngine.Space::World | 0 |   |   |
| distance |   | 10f |   |   |
| minDepth |   | 0 |   |   |
| maxDepth |   | 0 |   |   |
| hitEvent |   |   | Variable | Result |
| storeDidHit |   | bool Ground Below 1 | Variable |   |
| storeHitObject |   |   | Variable |   |
| storeHitPoint |   | Vector2(0, 0) | Variable |   |
| storeHitNormal |   | Vector2(0, 0) | Variable |   |
| storeHitDistance |   | 0f | Variable |   |
| storeDistance |   | 0f | Variable |   |
| repeatInterval |   | 1 |   | Filter |
| layerMask |   | FSMViewAvalonia2.FsmArray2 | Layer |   |
| invertMask |   | false |   |   |
| debugColor |   | Color(1, 0.92156863, 0.015686275, 1) |   | Debug |
| debug |   | true |   |   |

##### 6. RayCast2dV2

Full Name: HutongGames.PlayMaker.Actions.RayCast2dV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| fromGameObject |   | OwnerDefault FSM Owner |   | Setup |
| fromPosition |   | Vector2(0.8, 0) |   |   |
| direction |   | Vector2(0, -1) |   |   |
| space | UnityEngine.Space::World | 0 |   |   |
| distance |   | 10f |   |   |
| minDepth |   | 0 |   |   |
| maxDepth |   | 0 |   |   |
| hitEvent |   |   | Variable | Result |
| storeDidHit |   | bool Ground Below 2 | Variable |   |
| storeHitObject |   |   | Variable |   |
| storeHitPoint |   | Vector2(0, 0) | Variable |   |
| storeHitNormal |   | Vector2(0, 0) | Variable |   |
| storeHitDistance |   | 0f | Variable |   |
| storeDistance |   | 0f | Variable |   |
| repeatInterval |   | 1 |   | Filter |
| layerMask |   | FSMViewAvalonia2.FsmArray2 | Layer |   |
| invertMask |   | false |   |   |
| debugColor |   | Color(1, 0.92156863, 0.015686275, 1) |   | Debug |
| debug |   | true |   |   |

##### 7. BoolNoneTrue

Full Name: HutongGames.PlayMaker.Actions.BoolNoneTrue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariables |   | FSMViewAvalonia2.FsmArray2 | Variable |   |
| sendEvent |   | FALL |   |   |
| storeResult |   | false | Variable |   |
| everyFrame |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Hopthrow | 0 | |
| WALL | Wall Cling | 0 | |
| CANCEL | Hop Air | 0 | |

### Hopthrow

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| clipName |   | "Throw" |   |   |
| animationTriggerEvent |   |   |   |   |
| animationCompleteEvent |   | FINISHED |   |   |

##### 2. FlingObjectsFromGlobalPoolVel

Full Name: HutongGames.PlayMaker.Actions.FlingObjectsFromGlobalPoolVel
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Lurker Barb (Hollow Knight/hollow_knight_Data\sharedassets451.assets)] |   |   |
| spawnPoint |   | [Lurker Control/Pale Lurker/Throw Point (Hollow Knight/hollow_knight_Data\level451)] |   |   |
| position |   | Vector3(0, 0, 0) |   |   |
| spawnMin |   | 1 |   |   |
| spawnMax |   | 1 |   |   |
| speedMinX |   | -8f |   |   |
| speedMaxX |   | 8f |   |   |
| speedMinY |   | -40f |   |   |
| speedMaxY |   | -40f |   |   |
| originVariationX |   | 0f |   |   |
| originVariationY |   | 0f |   |   |

##### 3. CheckCollisionSide

Full Name: HutongGames.PlayMaker.Actions.CheckCollisionSide
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| topHit |   | false | Variable |   |
| rightHit |   | false | Variable |   |
| bottomHit |   | false | Variable |   |
| leftHit |   | false | Variable |   |
| topHitEvent |   |   |   |   |
| rightHitEvent |   | WALL |   |   |
| bottomHitEvent |   | LAND |   |   |
| leftHitEvent |   | WALL |   |   |
| otherLayer |   | false |   |   |
| otherLayerNumber |   | 0 |   |   |
| ignoreTriggers |   | false |   |   |

##### 4. CheckCollisionSideEnter

Full Name: HutongGames.PlayMaker.Actions.CheckCollisionSideEnter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| topHit |   | false | Variable |   |
| rightHit |   | false | Variable |   |
| bottomHit |   | false | Variable |   |
| leftHit |   | false | Variable |   |
| topHitEvent |   |   |   |   |
| rightHitEvent |   | WALL |   |   |
| bottomHitEvent |   | LAND |   |   |
| leftHitEvent |   | WALL |   |   |
| otherLayer |   | false |   |   |
| otherLayerNumber |   | 0 |   |   |
| ignoreTriggers |   | false |   |   |

##### 5. RayCast2dV2

Full Name: HutongGames.PlayMaker.Actions.RayCast2dV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| fromGameObject |   | OwnerDefault FSM Owner |   | Setup |
| fromPosition |   | Vector2(-0.8, 0) |   |   |
| direction |   | Vector2(0, -1) |   |   |
| space | UnityEngine.Space::World | 0 |   |   |
| distance |   | 10f |   |   |
| minDepth |   | 0 |   |   |
| maxDepth |   | 0 |   |   |
| hitEvent |   |   | Variable | Result |
| storeDidHit |   | bool Ground Below 1 | Variable |   |
| storeHitObject |   |   | Variable |   |
| storeHitPoint |   | Vector2(0, 0) | Variable |   |
| storeHitNormal |   | Vector2(0, 0) | Variable |   |
| storeHitDistance |   | 0f | Variable |   |
| storeDistance |   | 0f | Variable |   |
| repeatInterval |   | 1 |   | Filter |
| layerMask |   | FSMViewAvalonia2.FsmArray2 | Layer |   |
| invertMask |   | false |   |   |
| debugColor |   | Color(1, 0.92156863, 0.015686275, 1) |   | Debug |
| debug |   | true |   |   |

##### 6. RayCast2dV2

Full Name: HutongGames.PlayMaker.Actions.RayCast2dV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| fromGameObject |   | OwnerDefault FSM Owner |   | Setup |
| fromPosition |   | Vector2(0.8, 0) |   |   |
| direction |   | Vector2(0, -1) |   |   |
| space | UnityEngine.Space::World | 0 |   |   |
| distance |   | 10f |   |   |
| minDepth |   | 0 |   |   |
| maxDepth |   | 0 |   |   |
| hitEvent |   |   | Variable | Result |
| storeDidHit |   | bool Ground Below 2 | Variable |   |
| storeHitObject |   |   | Variable |   |
| storeHitPoint |   | Vector2(0, 0) | Variable |   |
| storeHitNormal |   | Vector2(0, 0) | Variable |   |
| storeHitDistance |   | 0f | Variable |   |
| storeDistance |   | 0f | Variable |   |
| repeatInterval |   | 1 |   | Filter |
| layerMask |   | FSMViewAvalonia2.FsmArray2 | Layer |   |
| invertMask |   | false |   |   |
| debugColor |   | Color(1, 0.92156863, 0.015686275, 1) |   | Debug |
| debug |   | true |   |   |

##### 7. BoolNoneTrue

Full Name: HutongGames.PlayMaker.Actions.BoolNoneTrue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariables |   | FSMViewAvalonia2.FsmArray2 | Variable |   |
| sendEvent |   | FALL |   |   |
| storeResult |   | false | Variable |   |
| everyFrame |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Hop Air | 0 | |
| WALL | Wall Cling | 0 | |
| FALL | Fall | 0 | |

### Hopland

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector2(0, 0) |   |   |
| x |   | 0f |   |   |
| y |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 2. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| clipName |   | "Land" |   |   |
| animationTriggerEvent |   |   |   |   |
| animationCompleteEvent |   | FINISHED |   |   |

##### 3. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer |   | [Global] [Audio Player Actor (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| audioClip |   | [hornet_ground_land (AudioClip) (Hollow Knight/hollow_knight_Data\sharedassets28.assets)] |   |   |
| pitchMin |   | 0.9f |   |   |
| pitchMax |   | 1.1f |   |   |
| volume |   | 1f |   |   |
| delay |   | 0f |   |   |
| storePlayer |   |   |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Throw Up Antic | 0 | |

### Throw Up Antic

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. RayCast2dV2

Full Name: HutongGames.PlayMaker.Actions.RayCast2dV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| fromGameObject |   | OwnerDefault Throw Point |   | Setup |
| fromPosition |   | Vector2(0, 0) |   |   |
| direction |   | Vector2(0, -1) |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| distance |   | 10f |   |   |
| minDepth |   | 0 |   |   |
| maxDepth |   | 0 |   |   |
| hitEvent |   |   | Variable | Result |
| storeDidHit |   | bool Ceiling Above | Variable |   |
| storeHitObject |   |   | Variable |   |
| storeHitPoint |   | Vector2(0, 0) | Variable |   |
| storeHitNormal |   | Vector2(0, 0) | Variable |   |
| storeHitDistance |   | 0f | Variable |   |
| storeDistance |   | 0f | Variable |   |
| repeatInterval |   | 1 |   | Filter |
| layerMask |   | FSMViewAvalonia2.FsmArray2 | Layer |   |
| invertMask |   | false |   |   |
| debugColor |   | Color(1, 0.92156863, 0.015686275, 1) |   | Debug |
| debug |   | false |   |   |

##### 2. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Ceiling Above | Variable |   |
| isTrue |   |   |   |   |
| isFalse |   | CANCEL |   |   |
| everyFrame |   | false |   |   |

##### 3. SendRandomEventV2

Full Name: HutongGames.PlayMaker.Actions.SendRandomEventV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| events |   | FSMViewAvalonia2.FsmArray2 |   |   |
| weights |   | FSMViewAvalonia2.FsmArray2 |   |   |
| trackingInts |   | FSMViewAvalonia2.FsmArray2 | Variable |   |
| eventMax |   | FSMViewAvalonia2.FsmArray2 |   |   |

##### 4. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| clipName |   | "Throw Antic" |   |   |
| animationTriggerEvent |   |   |   |   |
| animationCompleteEvent |   | FINISHED |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Throw Up | 0 | |
| CANCEL | After Land | 0 | |

### Throw Up

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
| clipName |   | "Throw" |   |   |
| animationTriggerEvent |   |   |   |   |
| animationCompleteEvent |   | FINISHED |   |   |

##### 2. FlingObjectsFromGlobalPoolVel

Full Name: HutongGames.PlayMaker.Actions.FlingObjectsFromGlobalPoolVel
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Lurker Barb (Hollow Knight/hollow_knight_Data\sharedassets451.assets)] |   |   |
| spawnPoint |   | [Lurker Control/Pale Lurker/Throw Point (Hollow Knight/hollow_knight_Data\level451)] |   |   |
| position |   | Vector3(0, 0, 0) |   |   |
| spawnMin |   | 1 |   |   |
| spawnMax |   | 1 |   |   |
| speedMinX |   | -4f |   |   |
| speedMaxX |   | 4f |   |   |
| speedMinY |   | 40f |   |   |
| speedMaxY |   | 40f |   |   |
| originVariationX |   | 0f |   |   |
| originVariationY |   | 0f |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | After Land | 0 | |

### Dig 1

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. RayCast2dV2

Full Name: HutongGames.PlayMaker.Actions.RayCast2dV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| fromGameObject |   | OwnerDefault FSM Owner |   | Setup |
| fromPosition |   | Vector2(-0.8, 0) |   |   |
| direction |   | Vector2(0, -1) |   |   |
| space | UnityEngine.Space::World | 0 |   |   |
| distance |   | 1f |   |   |
| minDepth |   | 0 |   |   |
| maxDepth |   | 0 |   |   |
| hitEvent |   |   | Variable | Result |
| storeDidHit |   | bool Ground Below 1 | Variable |   |
| storeHitObject |   |   | Variable |   |
| storeHitPoint |   | Vector2(0, 0) | Variable |   |
| storeHitNormal |   | Vector2(0, 0) | Variable |   |
| storeHitDistance |   | 0f | Variable |   |
| storeDistance |   | 0f | Variable |   |
| repeatInterval |   | 0 |   | Filter |
| layerMask |   | FSMViewAvalonia2.FsmArray2 | Layer |   |
| invertMask |   | false |   |   |
| debugColor |   | Color(1, 0.92156863, 0.015686275, 1) |   | Debug |
| debug |   | true |   |   |

##### 2. AudioPlayRandom

Full Name: HutongGames.PlayMaker.Actions.AudioPlayRandom
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | GameObject Self |   |   |
| audioClips |   | FSMViewAvalonia2.FsmArray2 |   |   |
| weights |   | FSMViewAvalonia2.FsmArray2 |   |   |
| pitchMin |   | 1f |   |   |
| pitchMax |   | 1f |   |   |

##### 3. RayCast2dV2

Full Name: HutongGames.PlayMaker.Actions.RayCast2dV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| fromGameObject |   | OwnerDefault FSM Owner |   | Setup |
| fromPosition |   | Vector2(0.8, 0) |   |   |
| direction |   | Vector2(0, -1) |   |   |
| space | UnityEngine.Space::World | 0 |   |   |
| distance |   | 1f |   |   |
| minDepth |   | 0 |   |   |
| maxDepth |   | 0 |   |   |
| hitEvent |   |   | Variable | Result |
| storeDidHit |   | bool Ground Below 2 | Variable |   |
| storeHitObject |   |   | Variable |   |
| storeHitPoint |   | Vector2(0, 0) | Variable |   |
| storeHitNormal |   | Vector2(0, 0) | Variable |   |
| storeHitDistance |   | 0f | Variable |   |
| storeDistance |   | 0f | Variable |   |
| repeatInterval |   | 0 |   | Filter |
| layerMask |   | FSMViewAvalonia2.FsmArray2 | Layer |   |
| invertMask |   | false |   |   |
| debugColor |   | Color(1, 0.92156863, 0.015686275, 1) |   | Debug |
| debug |   | true |   |   |

##### 4. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| clipName |   | "DigIn 1" |   |   |
| animationTriggerEvent |   |   |   |   |
| animationCompleteEvent |   | FINISHED |   |   |

##### 5. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer |   | [Global] [Audio Player Actor (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| audioClip |   | [hopper_jump (AudioClip) (Hollow Knight/hollow_knight_Data\sharedassets33.assets)] |   |   |
| pitchMin |   | 1f |   |   |
| pitchMax |   | 1f |   |   |
| volume |   | 1f |   |   |
| delay |   | 0f |   |   |
| storePlayer |   |   |   |   |

##### 6. TransitionToAudioSnapshot

Full Name: HutongGames.PlayMaker.Actions.TransitionToAudioSnapshot
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| snapshot |   | [Silent (AudioMixerSnapshotController) (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| transitionTime |   | 6f |   |   |

##### 7. SetRecoilSpeed

Full Name: SetRecoilSpeed
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target |   | OwnerDefault FSM Owner | Variable |   |
| newRecoilSpeed |   | 0f |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| CANCEL | Alert | 0 | |
| FINISHED | Dig 2 | 0 | |

### Dig 2

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
| clipName |   | "DigIn 2" |   |   |
| animationTriggerEvent |   |   |   |   |
| animationCompleteEvent |   | FINISHED |   |   |

##### 2. SetCollider

Full Name: HutongGames.PlayMaker.Actions.SetCollider
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| active |   | false |   |   |

##### 3. SetIsKinematic2d

Full Name: HutongGames.PlayMaker.Actions.SetIsKinematic2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| isKinematic |   | true |   |   |

##### 4. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer |   | [Global] [Audio Player Actor (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| audioClip |   | [grub_burrow (AudioClip) (Hollow Knight/hollow_knight_Data\sharedassets39.assets)] |   |   |
| pitchMin |   | 0.9f |   |   |
| pitchMax |   | 0.9f |   |   |
| volume |   | 1f |   |   |
| delay |   | 0f |   |   |
| storePlayer |   |   |   |   |

##### 5. PlayParticleEmitterInState

Full Name: HutongGames.PlayMaker.Actions.PlayParticleEmitterInState
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Dig Dust |   |   |

##### 6. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector2(0, 0) |   |   |
| x |   | 0f |   |   |
| y |   | 0f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Tele Height | 0 | |

### Teleport

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetPositionToObject

Full Name: HutongGames.PlayMaker.Actions.SetPositionToObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| targetObject |   | GameObject Tele Point |   |   |
| xOffset |   | 0f |   |   |
| yOffset |   | 0f |   |   |
| zOffset |   | 0f |   |   |

##### 2. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector2(0, 0) |   |   |
| x |   | 0f |   |   |
| y |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 3. SetRecoilSpeed

Full Name: SetRecoilSpeed
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target |   | OwnerDefault FSM Owner | Variable |   |
| newRecoilSpeed |   | 15f |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Dig Out | 0 | |

### Tele Height

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Hero |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f | Variable |   |
| y |   | float Hero Y | Variable |   |
| z |   | 0f | Variable |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |

##### 2. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 |   | float Hero Y |   |   |
| float2 |   | float Mid Y |   |   |
| tolerance |   | 0f |   |   |
| equal |   | LOW |   |   |
| lessThan |   | HIGH |   |   |
| greaterThan |   | LOW |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| HIGH | Get High | 0 | |
| LOW | Get Low | 0 | |

### Get High

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetRandomChild

Full Name: HutongGames.PlayMaker.Actions.GetRandomChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Tele High |   |   |
| storeResult |   | GameObject Tele Point | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Teleport | 0 | |

### Get Low

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetRandomChild

Full Name: HutongGames.PlayMaker.Actions.GetRandomChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Tele Low |   |   |
| storeResult |   | GameObject Tele Point | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Teleport | 0 | |

### Slash Antic

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
| clipName |   | "Slash Antic" |   |   |

##### 2. AudioPlayRandom

Full Name: HutongGames.PlayMaker.Actions.AudioPlayRandom
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | GameObject Self |   |   |
| audioClips |   | FSMViewAvalonia2.FsmArray2 |   |   |
| weights |   | FSMViewAvalonia2.FsmArray2 |   |   |
| pitchMin |   | 1f |   |   |
| pitchMax |   | 1f |   |   |

##### 3. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 0.4f |   |   |
| finishEvent |   | FINISHED |   |   |
| realTime |   | false |   |   |

##### 4. RandomInt

Full Name: HutongGames.PlayMaker.Actions.RandomInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min |   | 3 |   |   |
| max |   | 4 |   |   |
| storeResult |   | int Hit Count | Variable |   |
| inclusiveMax |   | false |   |   |

##### 5. SetRecoilSpeed

Full Name: SetRecoilSpeed
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target |   | OwnerDefault FSM Owner | Variable |   |
| newRecoilSpeed |   | 0f |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Slash 1 | 0 | |

### Slash 1

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
| clipName |   | "Slash 1" |   |   |
| animationTriggerEvent |   |   |   |   |
| animationCompleteEvent |   | FINISHED |   |   |

##### 2. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer |   | [Global] [Audio Player Actor (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| audioClip |   | [brkn_wand_jump (AudioClip) (Hollow Knight/hollow_knight_Data\sharedassets34.assets)] |   |   |
| pitchMin |   | 1f |   |   |
| pitchMax |   | 1f |   |   |
| volume |   | 1f |   |   |
| delay |   | 0f |   |   |
| storePlayer |   |   |   |   |

##### 3. AudioPlayRandom

Full Name: HutongGames.PlayMaker.Actions.AudioPlayRandom
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | GameObject Self |   |   |
| audioClips |   | FSMViewAvalonia2.FsmArray2 |   |   |
| weights |   | FSMViewAvalonia2.FsmArray2 |   |   |
| pitchMin |   | 1f |   |   |
| pitchMax |   | 1f |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Slash 2 | 0 | |

### Slash 2

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
| clipName |   | "Slash 2" |   |   |

##### 2. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Slash Ball |   |   |
| activate |   | true |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Burst Line |   |   |
| activate |   | true |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 4. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):CameraParent |   |   |
| sendEvent |   | "EnemyKillShake" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 5. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer |   | [Global] [Audio Player Actor (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| audioClip |   | [hornet_needle_thow (AudioClip) (Hollow Knight/hollow_knight_Data\sharedassets133.assets)] |   |   |
| pitchMin |   | 1f |   |   |
| pitchMax |   | 1f |   |   |
| volume |   | 1f |   |   |
| delay |   | 0f |   |   |
| storePlayer |   |   |   |   |

##### 6. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 1f |   |   |
| finishEvent |   | FINISHED |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Slash End | 0 | |

### Slash End

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
| clipName |   | "Slash End" |   |   |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Slash Ball |   |   |
| sendEvent |   | "OUT" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 3. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 0.6f |   |   |
| finishEvent |   | FINISHED |   |   |
| realTime |   | false |   |   |

##### 4. SetRecoilSpeed

Full Name: SetRecoilSpeed
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target |   | OwnerDefault FSM Owner | Variable |   |
| newRecoilSpeed |   | 15f |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Dig? | 0 | |

### Alert Anim

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. TransitionToAudioSnapshot

Full Name: HutongGames.PlayMaker.Actions.TransitionToAudioSnapshot
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| snapshot |   | [Action Only (AudioMixerSnapshotController) (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| transitionTime |   | 2f |   |   |

##### 2. AudioPlayRandom

Full Name: HutongGames.PlayMaker.Actions.AudioPlayRandom
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | GameObject Self |   |   |
| audioClips |   | FSMViewAvalonia2.FsmArray2 |   |   |
| weights |   | FSMViewAvalonia2.FsmArray2 |   |   |
| pitchMin |   | 1f |   |   |
| pitchMax |   | 1f |   |   |

##### 3. GetScale

Full Name: HutongGames.PlayMaker.Actions.GetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| xScale |   | float X Scale | Variable |   |
| yScale |   | 0f | Variable |   |
| zScale |   | 0f | Variable |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |

##### 4. FloatTestToBool

Full Name: HutongGames.PlayMaker.Actions.FloatTestToBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 |   | float X Scale |   |   |
| float2 |   | 1f |   |   |
| tolerance |   | 0f |   |   |
| equalBool |   | bool Facing Left | Variable |   |
| lessThanBool |   | false | Variable |   |
| greaterThanBool |   | false | Variable |   |
| everyFrame |   | false |   |   |

##### 5. CheckTargetDirection

Full Name: HutongGames.PlayMaker.Actions.CheckTargetDirection
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| target |   | [Global] GameObject Hero |   |   |
| aboveEvent |   |   |   |   |
| belowEvent |   |   |   |   |
| rightEvent |   |   |   |   |
| leftEvent |   |   |   |   |
| aboveBool |   | false | Variable |   |
| belowBool |   | false | Variable |   |
| rightBool |   | bool Hero Is Right | Variable |   |
| leftBool |   | false | Variable |   |
| everyFrame |   | false |   |   |

##### 6. BoolTestMulti

Full Name: HutongGames.PlayMaker.Actions.BoolTestMulti
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariables |   | FSMViewAvalonia2.FsmArray2 | Variable |   |
| boolStates |   | FSMViewAvalonia2.FsmArray2 |   |   |
| trueEvent |   | BACK |   |   |
| falseEvent |   |   |   |   |
| storeResult |   | false | Variable |   |
| everyFrame |   | false |   |   |

##### 7. BoolTestMulti

Full Name: HutongGames.PlayMaker.Actions.BoolTestMulti
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariables |   | FSMViewAvalonia2.FsmArray2 | Variable |   |
| boolStates |   | FSMViewAvalonia2.FsmArray2 |   |   |
| trueEvent |   | FORWARD |   |   |
| falseEvent |   |   |   |   |
| storeResult |   | false | Variable |   |
| everyFrame |   | false |   |   |

##### 8. BoolTestMulti

Full Name: HutongGames.PlayMaker.Actions.BoolTestMulti
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariables |   | FSMViewAvalonia2.FsmArray2 | Variable |   |
| boolStates |   | FSMViewAvalonia2.FsmArray2 |   |   |
| trueEvent |   | FORWARD |   |   |
| falseEvent |   |   |   |   |
| storeResult |   | false | Variable |   |
| everyFrame |   | false |   |   |

##### 9. BoolTestMulti

Full Name: HutongGames.PlayMaker.Actions.BoolTestMulti
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariables |   | FSMViewAvalonia2.FsmArray2 | Variable |   |
| boolStates |   | FSMViewAvalonia2.FsmArray2 |   |   |
| trueEvent |   | BACK |   |   |
| falseEvent |   |   |   |   |
| storeResult |   | false | Variable |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| BACK | Back | 0 | |
| FORWARD | Forward | 0 | |

### Back

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
| clipName |   | "LookBack" |   |   |

##### 2. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 0.2f |   |   |
| finishEvent |   | END |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| END | Hop Antic | 0 | |

### Forward

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
| clipName |   | "LookForward" |   |   |

##### 2. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 0.2f |   |   |
| finishEvent |   | END |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| END | Hop Antic | 0 | |

### Dig Out

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
| clipName |   | "DigOut" |   |   |
| animationTriggerEvent |   |   |   |   |
| animationCompleteEvent |   | FINISHED |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Reset | 0 | |

### Reset

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetCollider

Full Name: HutongGames.PlayMaker.Actions.SetCollider
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| active |   | true |   |   |

##### 2. SetIsKinematic2d

Full Name: HutongGames.PlayMaker.Actions.SetIsKinematic2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| isKinematic |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Idle | 0 | |

### Dormant

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

(none)

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| START | Get High | 0 | |

### Musix

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. TransitionToAudioSnapshot

Full Name: HutongGames.PlayMaker.Actions.TransitionToAudioSnapshot
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| snapshot |   | [Action Only (AudioMixerSnapshotController) (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| transitionTime |   | 2f |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Hop Antic | 0 | |

### Dig?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SendRandomEventV2

Full Name: HutongGames.PlayMaker.Actions.SendRandomEventV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| events |   | FSMViewAvalonia2.FsmArray2 |   |   |
| weights |   | FSMViewAvalonia2.FsmArray2 |   |   |
| trackingInts |   | FSMViewAvalonia2.FsmArray2 | Variable |   |
| eventMax |   | FSMViewAvalonia2.FsmArray2 |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| DIG | Dig 1 | 0 | |
| FINISHED | Hop Antic | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| BACK | false |
| CANCEL | false |
| DIG | false |
| END | false |
| EXTRA SLASH | false |
| FALL | false |
| FINISHED | false |
| FORWARD | false |
| HERO CAST SPELL | false |
| HERO L | false |
| HERO R | false |
| HIGH | false |
| HOP | false |
| IDLE | false |
| L | false |
| LAND | false |
| LOW | false |
| R | false |
| SLASH | false |
| START | false |
| TOOK DAMAGE | false |
| WALL | false |

