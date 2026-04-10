# Spell Get Orb Control

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Spell Get Orb Control |
| GameObject Name | Spell Get Orb Black |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets274.assets |
| Start State | Pause |
| FSM PathId | 22 |
| GameObject PathId | 12 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Randomiser | 0 | Single: 0 |
| Speed Self | 0 | Single: 0 |
| Wait | 0 | Single: 0 |
| X Scale | 0 | Single: 0 |
| z | 0 | Single: 0 |

### Vector3s

| Name | Value | Raw/Type |
| --- | --- | --- |
| Hero Pos | Vector3(0, 0, 0) | Vector3: Vector3(0, 0, 0) |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Self | [null] | NamedAssetPPtr:  |
| Trail | Spell Get Orb Black/Trail (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets274.assets) | NamedAssetPPtr: Spell Get Orb Black/Trail (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets274.assets) |

## States

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. FaceAngle

Full Name: HutongGames.PlayMaker.Actions.FaceAngle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| angleOffset | 0f | 0f |  |  |
| everyFrame | true | true |  |  |

##### 2. ProjectileSquash

Full Name: HutongGames.PlayMaker.Actions.ProjectileSquash
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| stretchFactor | 2f | 2f |  |  |
| stretchMinX | 0.5 | 0.5 |  |  |
| stretchMaxY | 2 | 2 |  |  |
| scaleModifier | float Randomiser | float Randomiser |  |  |
| everyFrame | true | true |  |  |

##### 3. GetSpeed2d

Full Name: HutongGames.PlayMaker.Actions.GetSpeed2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| storeResult | float Speed Self | float Speed Self | Variable |  |
| everyFrame | true | true |  |  |

##### 4. WaitRandom

Full Name: HutongGames.PlayMaker.Actions.WaitRandom
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| timeMin | 2f | 2f |  |  |
| timeMax | 4f | 4f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

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
| storeGameObject | GameObject Self | GameObject Self | Variable |  |

##### 2. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min | -6f | -6f |  |  |
| max | 6f | 6f |  |  |
| storeResult | float z | float z | Variable |  |

##### 3. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| z | float z | float z |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 4. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min | 0.2f | 0.2f |  |  |
| max | 0.8f | 0.8f |  |  |
| storeResult | float Randomiser | float Randomiser | Variable |  |

##### 5. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min | 0.65f | 0.65f |  |  |
| max | 0.8f | 0.8f |  |  |
| storeResult | float Wait | float Wait | Variable |  |

### Zoom

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Trail | OwnerDefault Trail |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 2. FaceAngle

Full Name: HutongGames.PlayMaker.Actions.FaceAngle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| angleOffset | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. ProjectileSquash

Full Name: HutongGames.PlayMaker.Actions.ProjectileSquash
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| stretchFactor | 2f | 2f |  |  |
| stretchMinX | 0.5 | 0.5 |  |  |
| stretchMaxY | 2 | 2 |  |  |
| scaleModifier | float Randomiser | float Randomiser |  |  |
| everyFrame | true | true |  |  |

##### 4. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| vector | Vector3 Hero Pos | Vector3 Hero Pos | Variable |  |
| x | 0f | 0f | Variable |  |
| y | 0f | 0f | Variable |  |
| z | 0f | 0f | Variable |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |

##### 5. Vector3AddXYZ

Full Name: HutongGames.PlayMaker.Actions.Vector3AddXYZ
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable | Vector3 Hero Pos | Vector3 Hero Pos | Variable |  |
| addX | 0f | 0f |  |  |
| addY | -0.6f | -0.6f |  |  |
| addZ | 0f | 0f |  |  |
| everyFrame | false | false |  |  |
| perSecond | false | false |  |  |

##### 6. GetScale

Full Name: HutongGames.PlayMaker.Actions.GetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| xScale | float X Scale | float X Scale | Variable |  |
| yScale | 0f | 0f | Variable |  |
| zScale | 0f | 0f | Variable |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | true | true |  |  |

##### 7. SetTrailRenderer

Full Name: HutongGames.PlayMaker.Actions.SetTrailRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Trail | OwnerDefault Trail |  |  |
| startWidth | float X Scale | float X Scale |  |  |
| endWidth | 0f | 0f |  |  |
| time | 0f | 0f |  |  |
| everyFrame | true | true |  |  |

##### 8. iTweenMoveTo

Full Name: HutongGames.PlayMaker.Actions.iTweenMoveTo
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| id | "" | "" |  |  |
| transformPosition |  |  |  |  |
| vectorPosition | Vector3 Hero Pos | Vector3 Hero Pos |  |  |
| time | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| speed | 0f | 0f |  |  |
| space | UnityEngine.Space::World | 0 |  |  |
| easeType | iTween/EaseType::easeInCirc | 18 |  |  |
| loopType | iTween/LoopType::none | 0 |  |  |
| orientToPath | false | false |  | LookAt |
| lookAtObject |  |  |  |  |
| lookAtVector | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| lookTime | 0f | 0f |  |  |
| axis | HutongGames.PlayMaker.Actions.iTweenFsmAction/AxisRestriction::none | 0 |  |  |
| moveToPath | true | true |  | Path |
| lookAhead | 0f | 0f |  |  |
| transforms | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| vectors | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| reverse | false | false |  |  |
| startEvent | Event() | Event() |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |
| stopOnExit | true | true |  |  |
| loopDontFinish | true | true |  |  |

### Get

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. CreateObject

Full Name: HutongGames.PlayMaker.Actions.CreateObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Orb Get Black (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Orb Get Black (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | [Global] GameObject Hero | [Global] GameObject Hero |  |  |
| position | Vector3(0, -0.6, -0.05) | Vector3(0, -0.6, -0.05) |  |  |
| rotation | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| storeObject |  |  | Variable |  |
| networkInstantiate | false | false |  |  |
| networkGroup | 0 | 0 |  |  |

##### 2. DestroySelf

Full Name: HutongGames.PlayMaker.Actions.DestroySelf
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| detachChildren | false | false |  |  |

### Pause

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. NextFrameEvent

Full Name: HutongGames.PlayMaker.Actions.NextFrameEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent | Event(FINISHED) | Event(FINISHED) |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Idle | FINISHED | Zoom | 0 | 0 | 0 |
| Init | FINISHED | Idle | 0 | 0 | 0 |
| Zoom | FINISHED | Get | 0 | 0 | 0 |
| Pause | FINISHED | Init | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |

