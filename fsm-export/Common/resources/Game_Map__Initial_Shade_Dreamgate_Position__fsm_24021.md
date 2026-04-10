# Initial Shade Dreamgate Position

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Initial Shade Dreamgate Position |
| GameObject Name | Game_Map |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Pause |
| FSM PathId | 24021 |
| GameObject PathId | 4791 |

## Variables

### Vector3s

| Name | Value | Raw/Type |
| --- | --- | --- |
| Dreamgate Pos | Vector3(0, 0, 0) | Vector3: Vector3(0, 0, 0) |
| Shade Pos | Vector3(0, 0, 0) | Vector3: Vector3(0, 0, 0) |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Dream_Gate_Pin | [null] | NamedAssetPPtr:  |
| Shade Pos Obj | [null] | NamedAssetPPtr:  |

## States

### Pause

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.5f | 0.5f |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

### Position

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Shade Pos" | "Shade Pos" |  |  |
| storeResult | GameObject Shade Pos Obj | GameObject Shade Pos Obj | Variable |  |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Dream_Gate_Pin" | "Dream_Gate_Pin" |  |  |
| storeResult | GameObject Dream_Gate_Pin | GameObject Dream_Gate_Pin | Variable |  |

##### 3. GetPlayerDataVector3

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataVector3
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| vector3Name | "shadeMapPos" | "shadeMapPos" |  |  |
| storeValue | Vector3 Shade Pos | Vector3 Shade Pos | Variable |  |

##### 4. GetPlayerDataVector3

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataVector3
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| vector3Name | "dreamgateMapPos" | "dreamgateMapPos" |  |  |
| storeValue | Vector3 Dreamgate Pos | Vector3 Dreamgate Pos | Variable |  |

##### 5. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Shade Pos Obj | OwnerDefault Shade Pos Obj |  |  |
| vector | Vector3 Shade Pos | Vector3 Shade Pos | Variable |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 6. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Dream_Gate_Pin | OwnerDefault Dream_Gate_Pin |  |  |
| vector | Vector3 Dreamgate Pos | Vector3 Dreamgate Pos | Variable |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Pause | FINISHED | Position | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |

