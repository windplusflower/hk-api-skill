# Beam Extender

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Beam Extender |
| GameObject Name | Beam |
| GameObject Path | Laser Turret (4)/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level270 |
| Start State | Init |
| FSM PathId | 6299 |
| GameObject PathId | 175 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Hit Point X | 0 | Single: 0 |
| Hit Point Y | 0 | Single: 0 |
| Ray Distance | 0 | Single: 0 |
| Rotation | 0 | Single: 0 |

### Vector2s

| Name | Value | Raw/Type |
| --- | --- | --- |
| Hit Point | Vector2(0, 0) | Vector2: Vector2(0, 0) |

### Vector3s

| Name | Value | Raw/Type |
| --- | --- | --- |
| Impact Pos | Vector2(0, 0) | Vector2: Vector2(0, 0) |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Beam Impact | [null] | NamedAssetPPtr: [null] |
| Parent | [null] | NamedAssetPPtr: [null] |
| Self | [null] | NamedAssetPPtr: [null] |

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

##### 2. GetParent

Full Name: HutongGames.PlayMaker.Actions.GetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| storeResult |   | GameObject Parent | Variable |   |

##### 3. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Parent |   |   |
| childName |   | "Beam Impact" |   |   |
| storeResult |   | GameObject Beam Impact | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Extend | 0 | |

### Extend

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. RayCast2dV2

Full Name: HutongGames.PlayMaker.Actions.RayCast2dV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| fromGameObject |   | OwnerDefault FSM Owner |   | Setup |
| fromPosition |   | Vector2(0, 0) |   |   |
| direction |   | Vector2(1, 0) |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| distance |   | 100f |   |   |
| minDepth |   | 0 |   |   |
| maxDepth |   | 0 |   |   |
| hitEvent |   | Event() | Variable | Result |
| storeDidHit |   | false | Variable |   |
| storeHitObject |   |   | Variable |   |
| storeHitPoint |   | Vector2 Hit Point | Variable |   |
| storeHitNormal |   | Vector2(0, 0) | Variable |   |
| storeHitDistance |   | 0f | Variable |   |
| storeDistance |   | float Ray Distance | Variable |   |
| repeatInterval |   | 1 |   | Filter |
| layerMask |   | FSMViewAvalonia2.FsmArray2 | Layer |   |
| invertMask |   | false |   |   |
| debugColor |   | Color(1, 0.92156863, 0.015686275, 1) |   | Debug |
| debug |   | true |   |   |

##### 2. FloatDivide

Full Name: HutongGames.PlayMaker.Actions.FloatDivide
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Ray Distance | Variable |   |
| divideBy |   | 1.7f |   |   |
| everyFrame |   | true |   |   |

##### 3. SetScale

Full Name: HutongGames.PlayMaker.Actions.SetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | float Ray Distance |   |   |
| y |   | 0f |   |   |
| z |   | 0f |   |   |
| everyFrame |   | true |   |   |
| lateUpdate |   | false |   |   |

##### 4. GetVector2XY

Full Name: HutongGames.PlayMaker.Actions.GetVector2XY
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector2Variable |   | Vector2 Hit Point | Variable |   |
| storeX |   | float Hit Point X | Variable |   |
| storeY |   | float Hit Point Y | Variable |   |
| everyFrame |   | true |   |   |

##### 5. SetVector3XYZ

Full Name: HutongGames.PlayMaker.Actions.SetVector3XYZ
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable |   | Vector3 Impact Pos | Variable |   |
| vector3Value |   | Vector3(0, 0, 0) | Variable |   |
| x |   | float Hit Point X |   |   |
| y |   | float Hit Point Y |   |   |
| z |   | 0.001f |   |   |
| everyFrame |   | true |   |   |

##### 6. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Beam Impact |   |   |
| vector |   | Vector3 Impact Pos | Variable |   |
| x |   | 0f |   |   |
| y |   | 0f |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | true |   |   |
| lateUpdate |   | false |   |   |

##### 7. GetRotation

Full Name: HutongGames.PlayMaker.Actions.GetRotation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| quaternion |   | Quaternion(0, 0, 0, 0) | Variable |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| xAngle |   | 0f | Variable |   |
| yAngle |   | 0f | Variable |   |
| zAngle |   | float Rotation | Variable |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | true |   |   |

##### 8. SetRotation

Full Name: HutongGames.PlayMaker.Actions.SetRotation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Beam Impact |   |   |
| quaternion |   | Quaternion(0, 0, 0, 0) | Variable |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| xAngle |   | 0f |   |   |
| yAngle |   | 0f |   |   |
| zAngle |   | float Rotation |   |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | true |   |   |
| lateUpdate |   | false |   |   |

#### Transitions

(none)

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |

