# Ascend

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Ascend |
| GameObject Name | Abyss Pit |
| GameObject Path | Boss Control/ |
| Source Asset | D:/SteamLibrary/steamapps/common/Hollow Knight/hollow_knight_Data/level459 |
| Start State | Idle |
| FSM PathId | 3382 |
| GameObject PathId | 622 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Hero Y | 0 | Single: 0 |
| Self Y | 0 | Single: 0 |

### Vector3s

| Name | Value | Raw/Type |
| --- | --- | --- |
| Tween Pos | Vector2(0, 0) | Vector2: Vector2(0, 0) |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Next Shade | [null] | NamedAssetPPtr: [null] |
| Shades | [null] | NamedAssetPPtr: [null] |

## States

### Idle

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
| childName |   | "Shades" |   |   |
| storeResult |   | GameObject Shades | Variable |   |

##### 2. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 61.77f |   |   |
| y |   | 12.1f |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| ASCEND | Ascend | 0 | |

### Ascend

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. FloatAdd

Full Name: HutongGames.PlayMaker.Actions.FloatAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Hero Y | Variable |   |
| add |   | -3f |   |   |
| everyFrame |   | false |   |   |
| perSecond |   | false |   |   |

##### 2. SetVector3XYZ

Full Name: HutongGames.PlayMaker.Actions.SetVector3XYZ
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable |   | Vector3 Tween Pos | Variable |   |
| vector3Value |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 56.5f |   |   |
| y |   | float Hero Y |   |   |
| z |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 3. iTweenMoveTo

Full Name: HutongGames.PlayMaker.Actions.iTweenMoveTo
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| id |   | "" |   |   |
| transformPosition |   |   |   |   |
| vectorPosition |   | Vector3 Tween Pos |   |   |
| time |   | 4f |   |   |
| delay |   | 0f |   |   |
| speed |   | 0f |   |   |
| space | UnityEngine.Space::World | 0 |   |   |
| easeType | iTween/EaseType::easeInOutCubic | 5 |   |   |
| loopType | iTween/LoopType::none | 0 |   |   |
| orientToPath |   | false |   | LookAt |
| lookAtObject |   |   |   |   |
| lookAtVector |   | Vector3(0, 0, 0) |   |   |
| lookTime |   | 0f |   |   |
| axis | HutongGames.PlayMaker.Actions.iTweenFsmAction/AxisRestriction::none | 0 |   |   |
| moveToPath |   | false |   | Path |
| lookAhead |   | 0f |   |   |
| transforms |   | FSMViewAvalonia2.FsmArray2 |   |   |
| vectors |   | FSMViewAvalonia2.FsmArray2 |   |   |
| reverse |   | false |   |   |
| startEvent |   |   |   |   |
| finishEvent |   |   |   |   |
| realTime |   | false |   |   |
| stopOnExit |   | true |   |   |
| loopDontFinish |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| ASCEND | Reset | 0 | |

### Reset

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

(none)

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Ascend | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| ABYSS RISE | false |
| ASCEND | false |
| FINISHED | false |
| HERO RESPAWNED | false |

