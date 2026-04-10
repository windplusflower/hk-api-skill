# Bob

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Bob |
| GameObject Name | Unnamed |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets394.assets |
| Start State | Bob |
| FSM PathId | 456 |
| GameObject PathId |  |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Bob Y | 0 | Single: 0 |
| Speed | 0 | Single: 0 |
| Speed Max | 0 | Single: 0 |
| Speed Min | 0 | Single: 0 |
| Y Max | 0 | Single: 0 |
| Y Min | 0 | Single: 0 |

### Vector3s

| Name | Value | Raw/Type |
| --- | --- | --- |
| Bob Vector | Vector3(0, 0, 0) | Vector3: Vector3(0, 0, 0) |

## States

### Bob

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min | float Speed Min | float Speed Min |  |  |
| max | float Speed Max | float Speed Max |  |  |
| storeResult | float Speed | float Speed | Variable |  |

##### 2. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min | float Speed Min | float Speed Min |  |  |
| max | float Speed Max | float Speed Max |  |  |
| storeResult | float Bob Y | float Bob Y | Variable |  |

##### 3. SetVector3XYZ

Full Name: HutongGames.PlayMaker.Actions.SetVector3XYZ
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable | Vector3 Bob Vector | Vector3 Bob Vector | Variable |  |
| vector3Value | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | float Bob Y | float Bob Y |  |  |
| z | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 4. iTweenMoveBy

Full Name: HutongGames.PlayMaker.Actions.iTweenMoveBy
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| id | "" | "" |  |  |
| vector | Vector3 Bob Vector | Vector3 Bob Vector |  |  |
| time | 0f | 0f |  |  |
| delay | 0f | 0f |  |  |
| speed | float Speed | float Speed |  |  |
| easeType | iTween/EaseType::easeInOutSine | 14 |  |  |
| loopType | iTween/LoopType::pingPong | 2 |  |  |
| space | UnityEngine.Space::World | 0 |  |  |
| orientToPath | false | false |  | LookAt |
| lookAtObject |  |  |  |  |
| lookAtVector | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| lookTime | 0f | 0f |  |  |
| axis | HutongGames.PlayMaker.Actions.iTweenFsmAction/AxisRestriction::none | 0 |  |  |
| startEvent | Event() | Event() |  |  |
| finishEvent | Event() | Event() |  |  |
| realTime | false | false |  |  |
| stopOnExit | true | true |  |  |
| loopDontFinish | true | true |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |  |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| GET | false |

