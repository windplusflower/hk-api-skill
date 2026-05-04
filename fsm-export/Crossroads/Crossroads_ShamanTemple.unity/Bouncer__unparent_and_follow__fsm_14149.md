# unparent_and_follow

## Summary

| Field | Value |
| --- | --- |
| FSM Name | unparent_and_follow |
| GameObject Name | Bouncer |
| GameObject Path | _Enemies/Roller/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level76 |
| Start State | State 1 |
| FSM PathId | 14149 |
| GameObject PathId | 2107 |

## Variables

### Vector3s

| Name | Value | Raw/Type |
| --- | --- | --- |
| Parent Pos | Vector2(0, 0) | Vector2: Vector2(0, 0) |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Parent | [null] | NamedAssetPPtr: [null] |

## States

### State 1

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. GetParent

Full Name: HutongGames.PlayMaker.Actions.GetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| storeResult |   | GameObject Parent | Variable |   |

##### 2. SetParent

Full Name: HutongGames.PlayMaker.Actions.SetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| parent |   |   |   |   |
| resetLocalPosition |   | false |   |   |
| resetLocalRotation |   | false |   |   |

##### 3. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Parent |   |   |
| vector |   | Vector3 Parent Pos | Variable |   |
| x |   | 0f | Variable |   |
| y |   | 0f | Variable |   |
| z |   | 0f | Variable |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | true |   |   |

##### 4. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector3 Parent Pos | Variable |   |
| x |   | 0f |   |   |
| y |   | 0f |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | true |   |   |
| lateUpdate |   | false |   |   |

#### Transitions

(none)

## Global Transitions

(none)

## Events

(none)

