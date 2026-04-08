# shockwave

## Summary

| Field | Value |
| --- | --- |
| FSM Name | shockwave |
| GameObject Name | Shockwave Wave |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets48.assets |
| Start State | Pause |
| FSM PathId | 149 |
| GameObject PathId | 63 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Angle Max | 0 | Single: 0 |
| Angle Min | 0 | Single: 0 |
| Direction | 0 | Single: 0 |
| Incrementer | 0 | Single: 0 |
| Scale X | 0 | Single: 0 |
| Scale Y | 0 | Single: 0 |
| Speed | 0 | Single: 0 |
| SpeedMax | 0 | Single: 0 |
| SpurtScaleX | 0 | Single: 0 |
| Y Rotate | 0 | Single: 0 |
| speedMin | 0 | Single: 0 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Facing Right | false | Boolean: false |
| On Ground | false | Boolean: false |

### Vector2s

| Name | Value | Raw/Type |
| --- | --- | --- |
| Raycast From | Vector2(0, 0) | Vector2: Vector2(0, 0) |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Burst Rocks Stomp | [null] | NamedAssetPPtr:  |
| Collider | [null] | NamedAssetPPtr:  |
| Duster | Shockwave Wave/Roll Dust (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets48.assets) | NamedAssetPPtr: Shockwave Wave/Roll Dust (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets48.assets) |
| Self | [null] | NamedAssetPPtr:  |
| Shockwave Object | [null] | NamedAssetPPtr:  |

## States

### Start

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GetScale

Full Name: HutongGames.PlayMaker.Actions.GetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| xScale | float Scale X | float Scale X | Variable |  |
| yScale | float Scale Y | float Scale Y | Variable |  |
| zScale | 0f | 0f | Variable |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |

##### 2. GetOwner

Full Name: HutongGames.PlayMaker.Actions.GetOwner
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeGameObject | GameObject Self | GameObject Self | Variable |  |

##### 3. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Burst Rocks Stomp" | "Burst Rocks Stomp" |  |  |
| storeResult | GameObject Burst Rocks Stomp | GameObject Burst Rocks Stomp | Variable |  |

##### 4. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Facing Right | bool Facing Right | Variable |  |
| isTrue | Event(RIGHT) | Event(RIGHT) |  |  |
| isFalse | Event(LEFT) | Event(LEFT) |  |  |
| everyFrame | false | false |  |  |

### Right

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetVector2XY

Full Name: HutongGames.PlayMaker.Actions.SetVector2XY
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector2Variable | Vector2 Raycast From | Vector2 Raycast From | Variable |  |
| vector2Value | Vector2(0, 0) | Vector2(0, 0) | Variable |  |
| x | 1f | 1f |  |  |
| y | 1f | 1f |  |  |
| everyFrame | false | false |  |  |

##### 2. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float SpeedMax | float SpeedMax | Variable |  |
| floatValue | float Speed | float Speed |  |  |
| everyFrame | false | false |  |  |

##### 3. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float speedMin | float speedMin | Variable |  |
| floatValue | float SpeedMax | float SpeedMax |  |  |
| everyFrame | false | false |  |  |

##### 4. FloatMultiplyV2

Full Name: HutongGames.PlayMaker.Actions.FloatMultiplyV2
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float speedMin | float speedMin | Variable |  |
| multiplyBy | -1f | -1f |  |  |
| everyFrame | false | false |  |  |
| fixedUpdate | false | false |  |  |

##### 5. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Angle Min | float Angle Min | Variable |  |
| floatValue | 95f | 95f |  |  |
| everyFrame | false | false |  |  |

##### 6. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Angle Max | float Angle Max | Variable |  |
| floatValue | 105f | 105f |  |  |
| everyFrame | false | false |  |  |

##### 7. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Direction | float Direction | Variable |  |
| floatValue | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 8. SetGameObject

Full Name: HutongGames.PlayMaker.Actions.SetGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variable | GameObject Shockwave Object | GameObject Shockwave Object | Variable |  |
| gameObject | [Global] [Shockwave Spurt (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets48.assets)] | [Global] [Shockwave Spurt (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets48.assets)] |  |  |
| everyFrame | false | false |  |  |

### Move

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool On Ground | bool On Ground | Variable |  |
| boolValue | true | true |  |  |
| everyFrame | false | false |  |  |

##### 2. FloatAdd

Full Name: HutongGames.PlayMaker.Actions.FloatAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Speed | float Speed | Variable |  |
| add | float Incrementer | float Incrementer |  |  |
| everyFrame | true | true |  |  |
| perSecond | true | true |  |  |

##### 3. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector2(0, 0) | Vector2(0, 0) |  |  |
| x | float Speed | float Speed |  |  |
| y | 0f | 0f |  |  |
| everyFrame | true | true |  |  |

##### 4. Trigger2dEventLayer

Full Name: HutongGames.PlayMaker.Actions.Trigger2dEventLayer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerEnter2D | 0 |  |  |
| collideTag | "" | "" | Tag |  |
| collideLayer | 8 | 8 | Layer |  |
| sendEvent | Event(WALL) | Event(WALL) |  |  |
| storeCollider | GameObject Collider | GameObject Collider | Variable |  |

##### 5. RayCast2d

Full Name: HutongGames.PlayMaker.Actions.RayCast2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| fromGameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  | Setup |
| fromPosition | Vector2 Raycast From | Vector2 Raycast From |  |  |
| direction | Vector2(0, -1) | Vector2(0, -1) |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| distance | 1.6f | 1.6f |  |  |
| minDepth | 0 | 0 |  |  |
| maxDepth | 0 | 0 |  |  |
| hitEvent | Event() | Event() | Variable | Result |
| storeDidHit | bool On Ground | bool On Ground | Variable |  |
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

##### 6. SpawnObjectFromGlobalPoolOverTimeV2

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPoolOverTimeV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Shockwave Object | GameObject Shockwave Object |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| rotation | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| frequency | 0.005f | 0.005f |  |  |
| scaleMin | float Scale X | float Scale X |  |  |
| scaleMax | float Scale X | float Scale X |  |  |

##### 7. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool On Ground | bool On Ground | Variable |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(HIT) | Event(HIT) |  |  |
| everyFrame | true | true |  |  |

### End Particle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. StopParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.StopParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Duster | OwnerDefault Duster |  |  |

##### 2. StopParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.StopParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Burst Rocks Stomp | OwnerDefault Burst Rocks Stomp |  |  |

##### 3. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 1f | 1f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Left

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetVector2XY

Full Name: HutongGames.PlayMaker.Actions.SetVector2XY
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector2Variable | Vector2 Raycast From | Vector2 Raycast From | Variable |  |
| vector2Value | Vector2(0, 0) | Vector2(0, 0) | Variable |  |
| x | -1f | -1f |  |  |
| y | 1f | 1f |  |  |
| everyFrame | false | false |  |  |

##### 2. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float SpeedMax | float SpeedMax | Variable |  |
| floatValue | float Speed | float Speed |  |  |
| everyFrame | false | false |  |  |

##### 3. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float speedMin | float speedMin | Variable |  |
| floatValue | float SpeedMax | float SpeedMax |  |  |
| everyFrame | false | false |  |  |

##### 4. FloatMultiplyV2

Full Name: HutongGames.PlayMaker.Actions.FloatMultiplyV2
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float speedMin | float speedMin | Variable |  |
| multiplyBy | -1f | -1f |  |  |
| everyFrame | false | false |  |  |
| fixedUpdate | false | false |  |  |

##### 5. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Direction | float Direction | Variable |  |
| floatValue | 180f | 180f |  |  |
| everyFrame | false | false |  |  |

##### 6. SetScale

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

##### 7. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Angle Min | float Angle Min | Variable |  |
| floatValue | 75f | 75f |  |  |
| everyFrame | false | false |  |  |

##### 8. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Angle Max | float Angle Max | Variable |  |
| floatValue | 85f | 85f |  |  |
| everyFrame | false | false |  |  |

##### 9. FloatMultiplyV2

Full Name: HutongGames.PlayMaker.Actions.FloatMultiplyV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Speed | float Speed | Variable |  |
| multiplyBy | -1f | -1f |  |  |
| everyFrame | false | false |  |  |
| fixedUpdate | false | false |  |  |

##### 10. SetGameObject

Full Name: HutongGames.PlayMaker.Actions.SetGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variable | GameObject Shockwave Object | GameObject Shockwave Object | Variable |  |
| gameObject | [Global] [Shockwave Spurt L (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets48.assets)] | [Global] [Shockwave Spurt L (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets48.assets)] |  |  |
| everyFrame | false | false |  |  |

### Start Move

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Incrementer | float Incrementer | Variable |  |
| floatValue | float Speed | float Speed |  |  |
| everyFrame | false | false |  |  |

##### 2. FloatMultiply

Full Name: HutongGames.PlayMaker.Actions.FloatMultiply
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Incrementer | float Incrementer | Variable |  |
| multiplyBy | 50f | 50f |  |  |
| everyFrame | false | false |  |  |

##### 3. FloatOperator

Full Name: HutongGames.PlayMaker.Actions.FloatOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float Speed | float Speed |  |  |
| float2 | 2f | 2f |  |  |
| operation | HutongGames.PlayMaker.Actions.FloatOperator/Operation::Multiply | 2 |  |  |
| storeResult | float Incrementer | float Incrementer | Variable |  |
| everyFrame | false | false |  |  |

##### 4. FloatMultiplyV2

Full Name: HutongGames.PlayMaker.Actions.FloatMultiplyV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Speed | float Speed | Variable |  |
| multiplyBy | 0.025f | 0.025f |  |  |
| everyFrame | false | false |  |  |
| fixedUpdate | false | false |  |  |

### Recycle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. RecycleSelf

Full Name: HutongGames.PlayMaker.Actions.RecycleSelf
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

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

### End Pause

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.15f | 0.15f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

##### 2. SpawnObjectFromGlobalPoolOverTimeV2

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPoolOverTimeV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Shockwave Object | GameObject Shockwave Object |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| rotation | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| frequency | 0.005f | 0.005f |  |  |
| scaleMin | float Scale X | float Scale X |  |  |
| scaleMax | float Scale X | float Scale X |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Start | RIGHT | Right | 0 | 0 | 0 |
| Start | LEFT | Left | 0 | 0 | 0 |
| Right | FINISHED | Start Move | 0 | 0 | 0 |
| Move | HIT | End Particle | 0 | 0 | 0 |
| Move | WALL | End Pause | 0 | 0 | 0 |
| End Particle | FINISHED | Recycle | 0 | 0 | 0 |
| Left | FINISHED | Start Move | 0 | 0 | 0 |
| Start Move | FINISHED | Move | 0 | 0 | 0 |
| Pause | FINISHED | Start | 0 | 0 | 0 |
| End Pause | FINISHED | End Particle | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| HIT | true |
| LEFT | false |
| RIGHT | false |
| WALL | false |

