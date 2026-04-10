# Update Cursor

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Update Cursor |
| GameObject Name | Charms |
| GameObject Path | _GameCameras/HudCamera/Inventory |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Init |
| FSM PathId | 20290 |
| GameObject PathId | 6719 |

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
| Item Pos | Vector3(0, 0, 0) | Vector3: Vector3(0, 0, 0) |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Cursor | [null] | NamedAssetPPtr:  |
| Item | [null] | NamedAssetPPtr:  |

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
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Cursor" | "Cursor" |  |  |
| storeResult | GameObject Cursor | GameObject Cursor | Variable |  |

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
| gameObject | OwnerDefault Item | OwnerDefault Item |  |  |
| vector | Vector3 Item Pos | Vector3 Item Pos | Variable |  |
| x | 0f | 0f | Variable |  |
| y | 0f | 0f | Variable |  |
| z | 0f | 0f | Variable |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |

##### 2. SelectCharmBackboard

Full Name: SelectCharmBackboard
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault Item | OwnerDefault Item | Variable |  |

##### 3. BoundsBoxCollider

Full Name: HutongGames.PlayMaker.Actions.BoundsBoxCollider
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject1 | OwnerDefault Item | OwnerDefault Item |  |  |
| scaleVector2 | Vector2 Box Bounds | Vector2 Box Bounds | Variable |  |
| scaleX | 0f | 0f | Variable |  |
| scaleY | 0f | 0f | Variable |  |
| everyFrame | false | false |  |  |

##### 4. BoxColliderOffset

Full Name: HutongGames.PlayMaker.Actions.BoxColliderOffset
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject1 | OwnerDefault Item | OwnerDefault Item |  |  |
| offsetVector2 | Vector2(0, 0) | Vector2(0, 0) | Variable |  |
| offsetX | float Box Offset X | float Box Offset X | Variable |  |
| offsetY | float Box Offset Y | float Box Offset Y | Variable |  |
| everyFrame | false | false |  |  |

##### 5. SetVector3XYZ

Full Name: HutongGames.PlayMaker.Actions.SetVector3XYZ
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable | Vector3 Item Pos | Vector3 Item Pos | Variable |  |
| vector3Value | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| z | -4.5f | -4.5f |  |  |
| everyFrame | false | false |  |  |

##### 6. SetFsmVector3

Full Name: HutongGames.PlayMaker.Actions.SetFsmVector3
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Cursor | OwnerDefault Cursor |  |  |
| fsmName | "Cursor Movement" | "Cursor Movement" | FsmName |  |
| variableName | "MoveToPos" | "MoveToPos" | FsmVector3 |  |
| setValue | Vector3 Item Pos | Vector3 Item Pos |  |  |
| everyFrame | false | false |  |  |

##### 7. SetFsmVector2

Full Name: HutongGames.PlayMaker.Actions.SetFsmVector2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Cursor | OwnerDefault Cursor |  |  |
| fsmName | "Cursor Movement" | "Cursor Movement" | FsmName |  |
| variableName | "ColliderBounds" | "ColliderBounds" | FsmVector2 |  |
| setValue | Vector2 Box Bounds | Vector2 Box Bounds |  |  |
| everyFrame | false | false |  |  |

##### 8. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Cursor | OwnerDefault Cursor |  |  |
| fsmName | "Cursor Movement" | "Cursor Movement" | FsmName |  |
| variableName | "Box Offset X" | "Box Offset X" | FsmFloat |  |
| setValue | float Box Offset X | float Box Offset X |  |  |
| everyFrame | false | false |  |  |

##### 9. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Cursor | OwnerDefault Cursor |  |  |
| fsmName | "Cursor Movement" | "Cursor Movement" | FsmName |  |
| variableName | "Box Offset Y" | "Box Offset Y" | FsmFloat |  |
| setValue | float Box Offset Y | float Box Offset Y |  |  |
| everyFrame | false | false |  |  |

##### 10. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Cursor | EventTarget(GameObject):Cursor |  |  |
| sendEvent | "CURSOR MOVE" | "CURSOR MOVE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

_None_

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Init | FINISHED | Idle | 0 | 0 | 0 |
| Update | FINISHED | Idle | 0 | 0 | 0 |
| Idle | UPDATE CURSOR | Update | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| UPDATE CURSOR | false |

