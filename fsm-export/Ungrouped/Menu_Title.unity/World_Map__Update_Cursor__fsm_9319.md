# Update Cursor

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Update Cursor |
| GameObject Name | World Map |
| GameObject Path | _GameCameras/HudCamera/Inventory/Map/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level1 |
| Start State | Init |
| FSM PathId | 9319 |
| GameObject PathId | 850 |

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
| Parent | [null] | NamedAssetPPtr: [null] |

## States

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetParent

Full Name: HutongGames.PlayMaker.Actions.GetParent
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| storeResult |   | GameObject Parent | Variable |   |

##### 2. FindChild

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

##### 2. BoundsBoxCollider

Full Name: HutongGames.PlayMaker.Actions.BoundsBoxCollider
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject1 |   | OwnerDefault Item |   |   |
| scaleVector2 |   | Vector2 Box Bounds | Variable |   |
| scaleX |   | 0f | Variable |   |
| scaleY |   | 0f | Variable |   |
| everyFrame |   | false |   |   |

##### 3. BoxColliderOffset

Full Name: HutongGames.PlayMaker.Actions.BoxColliderOffset
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject1 |   | OwnerDefault Item |   |   |
| offsetVector2 |   | Vector2(0, 0) | Variable |   |
| offsetX |   | float Box Offset X | Variable |   |
| offsetY |   | float Box Offset Y | Variable |   |
| everyFrame |   | false |   |   |

##### 4. SetFsmVector3

Full Name: HutongGames.PlayMaker.Actions.SetFsmVector3
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Cursor |   |   |
| fsmName |   | "Cursor Movement" | FsmName |   |
| variableName |   | "MoveToPos" | FsmVector3 |   |
| setValue |   | Vector3 Item Pos |   |   |
| everyFrame |   | false |   |   |

##### 5. SetFsmVector2

Full Name: HutongGames.PlayMaker.Actions.SetFsmVector2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Cursor |   |   |
| fsmName |   | "Cursor Movement" | FsmName |   |
| variableName |   | "ColliderBounds" | FsmVector2 |   |
| setValue |   | Vector2 Box Bounds |   |   |
| everyFrame |   | false |   |   |

##### 6. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Cursor |   |   |
| fsmName |   | "Cursor Movement" | FsmName |   |
| variableName |   | "Box Offset X" | FsmFloat |   |
| setValue |   | float Box Offset X |   |   |
| everyFrame |   | false |   |   |

##### 7. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Cursor |   |   |
| fsmName |   | "Cursor Movement" | FsmName |   |
| variableName |   | "Box Offset Y" | FsmFloat |   |
| setValue |   | float Box Offset Y |   |   |
| everyFrame |   | false |   |   |

##### 8. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Cursor |   |   |
| sendEvent |   | "CURSOR MOVE" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 9. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):FSM Owner |   |   |
| sendEvent |   | "UPDATE TEXT" |   |   |
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

