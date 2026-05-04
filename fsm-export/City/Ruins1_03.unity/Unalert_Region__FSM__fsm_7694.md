# FSM

## Summary

| Field | Value |
| --- | --- |
| FSM Name | FSM |
| GameObject Name | Unalert Region |
| GameObject Path | _Scenery/Ruins Sentry 1 (1)/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level90 |
| Start State | Initialise |
| FSM PathId | 7694 |
| GameObject PathId | 1225 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Distance | 0 | Single: 0 |
| Hero X | 0 | Single: 0 |
| Hero Y | 0 | Single: 0 |
| Raycast X | 0 | Single: 0 |
| Raycast Y | 0 | Single: 0 |
| Self X | 0 | Single: 0 |
| Self Y | 0 | Single: 0 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Can See Hero | false | Boolean: false |
| In Alert Range | false | Boolean: false |
| View Obscured | false | Boolean: false |

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| Bool Name | Unalert Region | String: Unalert Region |
| FSM Name | Ruins Sentry | String: Ruins Sentry |

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

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Alert Range | [null] | NamedAssetPPtr: [null] |
| Collider | [null] | NamedAssetPPtr: [null] |
| Hero | [null] | NamedAssetPPtr: [null] |
| Hit Obj | [null] | NamedAssetPPtr: [null] |
| Parent | [null] | NamedAssetPPtr: [null] |
| Self | [null] | NamedAssetPPtr: [null] |

## States

### Initialise

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

##### 2. GetHero

Full Name: GetHero
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeResult |   | GameObject Hero | Variable |   |

##### 3. GetParent

Full Name: HutongGames.PlayMaker.Actions.GetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Self |   |   |
| storeResult |   | GameObject Parent | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Inactive | 0 | |

### Raycast

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Hero |   |   |
| vector |   | Vector3 Hero Position | Variable |   |
| x |   | float Hero X | Variable |   |
| y |   | float Hero Y | Variable |   |
| z |   | 0f | Variable |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | true |   |   |

##### 2. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Self |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | float Self X | Variable |   |
| y |   | float Self Y | Variable |   |
| z |   | 0f | Variable |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | true |   |   |

##### 3. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Raycast X | Variable |   |
| floatValue |   | float Hero X |   |   |
| everyFrame |   | true |   |   |

##### 4. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Raycast Y | Variable |   |
| floatValue |   | float Hero Y |   |   |
| everyFrame |   | true |   |   |

##### 5. FloatSubtract

Full Name: HutongGames.PlayMaker.Actions.FloatSubtract
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Raycast X | Variable |   |
| subtract |   | float Self X |   |   |
| everyFrame |   | true |   |   |
| perSecond |   | false |   |   |

##### 6. FloatSubtract

Full Name: HutongGames.PlayMaker.Actions.FloatSubtract
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Raycast Y | Variable |   |
| subtract |   | float Self Y |   |   |
| everyFrame |   | true |   |   |
| perSecond |   | false |   |   |

##### 7. SetVector2XY

Full Name: HutongGames.PlayMaker.Actions.SetVector2XY
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector2Variable |   | Vector2 Raycast Vector | Variable |   |
| vector2Value |   | Vector2(0, 0) | Variable |   |
| x |   | float Raycast X |   |   |
| y |   | float Raycast Y |   |   |
| everyFrame |   | true |   |   |

##### 8. SetVector2XY

Full Name: HutongGames.PlayMaker.Actions.SetVector2XY
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector2Variable |   | Vector2 Hero Pos 2D | Variable |   |
| vector2Value |   | Vector2(0, 0) | Variable |   |
| x |   | float Hero X |   |   |
| y |   | float Hero Y |   |   |
| everyFrame |   | true |   |   |

##### 9. SetVector2XY

Full Name: HutongGames.PlayMaker.Actions.SetVector2XY
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector2Variable |   | Vector2 Self Pos 2D | Variable |   |
| vector2Value |   | Vector2(0, 0) | Variable |   |
| x |   | float Self X |   |   |
| y |   | float Self Y |   |   |
| everyFrame |   | true |   |   |

##### 10. DistanceBetweenPoints2D

Full Name: HutongGames.PlayMaker.Actions.DistanceBetweenPoints2D
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| distanceResult |   | float Distance | Variable |   |
| point1 |   | Vector2 Hero Pos 2D |   |   |
| point2 |   | Vector2 Self Pos 2D |   |   |
| everyFrame |   | true |   |   |

##### 11. RayCast2d

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

##### 12. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Can See Hero | Variable |   |
| boolValue |   | bool View Obscured |   |   |
| everyFrame |   | true |   |   |

##### 13. BoolFlipEveryFrame

Full Name: HutongGames.PlayMaker.Actions.BoolFlipEveryFrame
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Can See Hero | Variable |   |
| everyFrame |   | true |   |   |

##### 14. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Parent |   |   |
| fsmName |   | string FSM Name | FsmName |   |
| variableName |   | string Bool Name | FsmBool |   |
| setValue |   | bool Can See Hero |   |   |
| everyFrame |   | true |   |   |

##### 15. Trigger2dEvent

Full Name: HutongGames.PlayMaker.Actions.Trigger2dEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerExit2D | 2 |   |   |
| collideTag |   | "" | Tag |   |
| collideLayer |   | "" | Layer |   |
| sendEvent |   | Event(RAYCAST STOP) |   |   |
| storeCollider |   | GameObject Collider | Variable |   |

##### 16. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 1f |   |   |
| finishEvent |   | Event(RAYCAST STOP) |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| RAYCAST STOP | Inactive | 0 | |

### Inactive

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Trigger2dEvent

Full Name: HutongGames.PlayMaker.Actions.Trigger2dEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerStay2D | 1 |   |   |
| collideTag |   | "" | Tag |   |
| collideLayer |   | "" | Layer |   |
| sendEvent |   | Event(RAYCAST START) |   |   |
| storeCollider |   |   | Variable |   |

##### 2. Trigger2dEvent

Full Name: HutongGames.PlayMaker.Actions.Trigger2dEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerEnter2D | 0 |   |   |
| collideTag |   | "" | Tag |   |
| collideLayer |   | "" | Layer |   |
| sendEvent |   | Event(RAYCAST START) |   |   |
| storeCollider |   |   | Variable |   |

##### 3. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Parent |   |   |
| fsmName |   | string FSM Name | FsmName |   |
| variableName |   | string Bool Name | FsmBool |   |
| setValue |   | false |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| RAYCAST START | Raycast | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| RAYCAST START | true |
| RAYCAST STOP | true |

