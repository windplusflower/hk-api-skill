# bob_in_air

## Summary

| Field | Value |
| --- | --- |
| FSM Name | bob_in_air |
| GameObject Name | dream_lamp_01 (5) |
| GameObject Path |   |
| Source Asset | D:/SteamLibrary/steamapps/common/Hollow Knight/hollow_knight_Data/level394 |
| Start State | Bob |
| FSM PathId | 3601 |
| GameObject PathId | 169 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Bob Y | 0 | Single: 0 |
| Speed | 0 | Single: 0 |
| Speed Max | 0.400000006 | Single: 0.400000006 |
| Speed Min | 0.200000003 | Single: 0.200000003 |
| Y Max | 2.0999999 | Single: 2.0999999 |
| Y Min | 1.20000005 | Single: 1.20000005 |

### Vector3s

| Name | Value | Raw/Type |
| --- | --- | --- |
| Bob Vector | Vector2(0, 0) | Vector2: Vector2(0, 0) |

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
| min |   | float Speed Min |   |   |
| max |   | float Speed Max |   |   |
| storeResult |   | float Speed | Variable |   |

##### 2. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min |   | float Speed Min |   |   |
| max |   | float Speed Max |   |   |
| storeResult |   | float Bob Y | Variable |   |

##### 3. SetVector3XYZ

Full Name: HutongGames.PlayMaker.Actions.SetVector3XYZ
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable |   | Vector3 Bob Vector | Variable |   |
| vector3Value |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | float Bob Y |   |   |
| z |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 4. iTweenMoveBy

Full Name: HutongGames.PlayMaker.Actions.iTweenMoveBy
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| id |   | "" |   |   |
| vector |   | Vector3 Bob Vector |   |   |
| time |   | 0f |   |   |
| delay |   | 0f |   |   |
| speed |   | float Speed |   |   |
| easeType | iTween/EaseType::easeInOutSine | 14 |   |   |
| loopType | iTween/LoopType::pingPong | 2 |   |   |
| space | UnityEngine.Space::World | 0 |   |   |
| orientToPath |   | false |   | LookAt |
| lookAtObject |   |   |   |   |
| lookAtVector |   | Vector3(0, 0, 0) |   |   |
| lookTime |   | 0f |   |   |
| axis | HutongGames.PlayMaker.Actions.iTweenFsmAction/AxisRestriction::none | 0 |   |   |
| startEvent |   | Event() |   |   |
| finishEvent |   | Event() |   |   |
| realTime |   | false |   |   |
| stopOnExit |   | true |   |   |
| loopDontFinish |   | true |   |   |

#### Transitions

(none)

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| GET | false |

