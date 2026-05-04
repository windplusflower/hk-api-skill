# Update Cursor

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Update Cursor |
| GameObject Name | Charms |
| GameObject Path | _GameCameras/HudCamera/Inventory/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level1 |
| Start State | Init |
| FSM PathId | 9263 |
| GameObject PathId | 1167 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Box Offset X | 0 | Single: 0 |
| Box Offset Y | 0 | Single: 0 |

### Vector2s

| Name | Value | Raw/Type |
| --- | --- | --- |
| Box Bounds | Vector2(0, 0) | Vector2: Vector2(0, 0) |

### Vector3s

| Name | Value | Raw/Type |
| --- | --- | --- |
| Item Pos | Vector2(0, 0) | Vector2: Vector2(0, 0) |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Cursor | [null] | NamedAssetPPtr: [null] |
| Item | [null] | NamedAssetPPtr: [null] |

## States

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Cursor" |   |   |
| storeResult |   | GameObject Cursor | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Idle | 0 | |

### Update

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Item |   |   |
| vector |   | Vector3 Item Pos | Variable |   |
| x |   | 0f | Variable |   |
| y |   | 0f | Variable |   |
| z |   | 0f | Variable |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| everyFrame |   | false |   |   |

##### 2. SelectCharmBackboard

Full Name: SelectCharmBackboard
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target |   | OwnerDefault Item | Variable |   |

##### 3. BoundsBoxCollider

Full Name: HutongGames.PlayMaker.Actions.BoundsBoxCollider
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject1 |   | OwnerDefault Item |   |   |
| scaleVector2 |   | Vector2 Box Bounds | Variable |   |
| scaleX |   | 0f | Variable |   |
| scaleY |   | 0f | Variable |   |
| everyFrame |   | false |   |   |

##### 4. BoxColliderOffset

Full Name: HutongGames.PlayMaker.Actions.BoxColliderOffset
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject1 |   | OwnerDefault Item |   |   |
| offsetVector2 |   | Vector2(0, 0) | Variable |   |
| offsetX |   | float Box Offset X | Variable |   |
| offsetY |   | float Box Offset Y | Variable |   |
| everyFrame |   | false |   |   |

##### 5. SetVector3XYZ

Full Name: HutongGames.PlayMaker.Actions.SetVector3XYZ
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable |   | Vector3 Item Pos | Variable |   |
| vector3Value |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | 0f |   |   |
| z |   | -4.5f |   |   |
| everyFrame |   | false |   |   |

##### 6. SetFsmVector3

Full Name: HutongGames.PlayMaker.Actions.SetFsmVector3
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Cursor |   |   |
| fsmName |   | "Cursor Movement" | FsmName |   |
| variableName |   | "MoveToPos" | FsmVector3 |   |
| setValue |   | Vector3 Item Pos |   |   |
| everyFrame |   | false |   |   |

##### 7. SetFsmVector2

Full Name: HutongGames.PlayMaker.Actions.SetFsmVector2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Cursor |   |   |
| fsmName |   | "Cursor Movement" | FsmName |   |
| variableName |   | "ColliderBounds" | FsmVector2 |   |
| setValue |   | Vector2 Box Bounds |   |   |
| everyFrame |   | false |   |   |

##### 8. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Cursor |   |   |
| fsmName |   | "Cursor Movement" | FsmName |   |
| variableName |   | "Box Offset X" | FsmFloat |   |
| setValue |   | float Box Offset X |   |   |
| everyFrame |   | false |   |   |

##### 9. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Cursor |   |   |
| fsmName |   | "Cursor Movement" | FsmName |   |
| variableName |   | "Box Offset Y" | FsmFloat |   |
| setValue |   | float Box Offset Y |   |   |
| everyFrame |   | false |   |   |

##### 10. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Cursor |   |   |
| sendEvent |   | "CURSOR MOVE" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Idle | 0 | |

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

(none)

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| UPDATE CURSOR | Update | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| UPDATE CURSOR | false |

