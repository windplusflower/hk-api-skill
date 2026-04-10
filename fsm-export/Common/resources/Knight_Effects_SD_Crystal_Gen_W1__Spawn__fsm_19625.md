# Spawn

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Spawn |
| GameObject Name | SD Crystal Gen W1 |
| GameObject Path | Knight/Effects |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Init |
| FSM PathId | 19625 |
| GameObject PathId | 4705 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Hero Scale | 0 | Single: 0 |
| Scale | 0 | Single: 0 |
| Tilt | 10 | Single: 10 |
| Tilt Crt | 0 | Single: 0 |

### Vector3s

| Name | Value | Raw/Type |
| --- | --- | --- |
| Gen Pos | Vector3(0, 0, 0) | Vector3: Vector3(0, 0, 0) |
| Init Pos | Vector3(0, -1.42, -0.001) | Vector3: Vector3(0, -1.42, -0.001) |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Crystal | [null] | NamedAssetPPtr:  |
| Self | [null] | NamedAssetPPtr:  |

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
| storeGameObject | GameObject Self | GameObject Self | Variable |  |

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

_None_

### Gen Pause

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.09f | 0.09f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Gen Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Scale | float Scale | Variable |  |
| floatValue | 0.5f | 0.5f |  |  |
| everyFrame | false | false |  |  |

##### 2. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Tilt Crt | float Tilt Crt | Variable |  |
| floatValue | float Tilt | float Tilt |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEventByScale

Full Name: HutongGames.PlayMaker.Actions.SendEventByScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| xScale | true | true |  |  |
| positiveEvent | Event(R) | Event(R) |  |  |
| negativeEvent | Event(L) | Event(L) |  |  |
| space | UnityEngine.Space::World | 0 |  |  |

### Gen

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [SD Crystal (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [SD Crystal (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| position | Vector3 Gen Pos | Vector3 Gen Pos |  |  |
| rotation | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| storeObject | GameObject Crystal | GameObject Crystal | Variable |  |

##### 2. SetRotation

Full Name: HutongGames.PlayMaker.Actions.SetRotation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Crystal | OwnerDefault Crystal |  |  |
| quaternion | Quaternion(0, 0, 0, 0) | Quaternion(0, 0, 0, 0) | Variable |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| xAngle | 0f | 0f |  |  |
| yAngle | 0f | 0f |  |  |
| zAngle | float Tilt Crt | float Tilt Crt |  |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 3. SetScale

Full Name: HutongGames.PlayMaker.Actions.SetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Crystal | OwnerDefault Crystal |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | float Scale | float Scale |  |  |
| y | float Scale | float Scale |  |  |
| z | 0f | 0f |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 4. FloatAdd

Full Name: HutongGames.PlayMaker.Actions.FloatAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Scale | float Scale | Variable |  |
| add | 0.12f | 0.12f |  |  |
| everyFrame | false | false |  |  |
| perSecond | false | false |  |  |

### Wall R

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. FloatAdd

Full Name: HutongGames.PlayMaker.Actions.FloatAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Tilt Crt | float Tilt Crt | Variable |  |
| add | -90f | -90f |  |  |
| everyFrame | false | false |  |  |
| perSecond | false | false |  |  |

##### 2. SetVector3Value

Full Name: HutongGames.PlayMaker.Actions.SetVector3Value
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable | Vector3 Gen Pos | Vector3 Gen Pos | Variable |  |
| vector3Value | Vector3(-0.5, 0, 0) | Vector3(-0.5, 0, 0) |  |  |
| everyFrame | false | false |  |  |

### Wall L

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. FloatAdd

Full Name: HutongGames.PlayMaker.Actions.FloatAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Tilt Crt | float Tilt Crt | Variable |  |
| add | 90f | 90f |  |  |
| everyFrame | false | false |  |  |
| perSecond | false | false |  |  |

##### 2. SetVector3Value

Full Name: HutongGames.PlayMaker.Actions.SetVector3Value
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable | Vector3 Gen Pos | Vector3 Gen Pos | Variable |  |
| vector3Value | Vector3(0.5, 0, 0) | Vector3(0.5, 0, 0) |  |  |
| everyFrame | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Init | FINISHED | Idle | 0 | 0 | 0 |
| Idle | SUPERDASH CHARGING W | Gen Init | 0 | 0 | 0 |
| Gen Pause | FINISHED | Gen | 0 | 0 | 0 |
| Gen Init | R | Wall R | 0 | 0 | 0 |
| Gen Init | L | Wall L | 0 | 0 | 0 |
| Gen | FINISHED | Gen Pause | 0 | 0 | 0 |
| Wall R | FINISHED | Gen Pause | 0 | 0 | 0 |
| Wall L | FINISHED | Gen Pause | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| SUPERDASH BLAST | Idle | 0 | 0 | 0 |
| SUPERDASH CANCEL | Idle | 0 | 0 | 0 |
| SUPERDASH READY | Idle | 0 | 0 | 0 |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| L | false |
| NO FLOOR | false |
| R | false |
| SUPERDASH BLAST | false |
| SUPERDASH CANCEL | false |
| SUPERDASH CHARGING W | false |
| SUPERDASH READY | false |

