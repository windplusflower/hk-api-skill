# Spin Control

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Spin Control |
| GameObject Name | Orb Spinner |
| GameObject Path | Dream Mage Lord Phase2 |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets407.assets |
| Start State | Init |
| FSM PathId | 244 |
| GameObject PathId | 88 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Spin Speed | 240 | Single: 240 |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Parent | [null] | NamedAssetPPtr:  |

## States

### Spin

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. Rotate

Full Name: HutongGames.PlayMaker.Actions.Rotate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| xAngle | 0f | 0f |  |  |
| yAngle | 0f | 0f |  |  |
| zAngle | 240f | 240f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| perSecond | true | true |  |  |
| everyFrame | true | true |  |  |
| lateUpdate | false | false |  |  |
| fixedUpdate | false | false |  |  |

##### 2. GameObjectIsNull

Full Name: HutongGames.PlayMaker.Actions.GameObjectIsNull
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Parent | GameObject Parent | Variable |  |
| isNull | Event(PARENT NULL) | Event(PARENT NULL) |  |  |
| isNotNull | Event() | Event() |  |  |
| storeResult | false | false | Variable |  |
| everyFrame | true | true |  |  |

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GameObjectIsNull

Full Name: HutongGames.PlayMaker.Actions.GameObjectIsNull
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Parent | GameObject Parent | Variable |  |
| isNull | Event(PARENT NULL) | Event(PARENT NULL) |  |  |
| isNotNull | Event() | Event() |  |  |
| storeResult | false | false | Variable |  |
| everyFrame | true | true |  |  |

##### 2. Rotate

Full Name: HutongGames.PlayMaker.Actions.Rotate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| xAngle | 0f | 0f |  |  |
| yAngle | 0f | 0f |  |  |
| zAngle | float Spin Speed | float Spin Speed |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| perSecond | true | true |  |  |
| everyFrame | true | true |  |  |
| lateUpdate | false | false |  |  |
| fixedUpdate | false | false |  |  |

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetParent

Full Name: HutongGames.PlayMaker.Actions.GetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| storeResult | GameObject Parent | GameObject Parent | Variable |  |

### Mage Killed

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:FSM Owner | EventTarget(GameObject)[SendToChildren]:FSM Owner |  |  |
| sendEvent | "DISSIPATE" | "DISSIPATE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Spin | STOP | Idle | 0 | 0 | 0 |
| Spin | PARENT NULL | Mage Killed | 0 | 0 | 0 |
| Idle | SPIN | Spin | 0 | 0 | 0 |
| Idle | PARENT NULL | Mage Killed | 0 | 0 | 0 |
| Init | FINISHED | Idle | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| PARENT NULL | false |
| SPIN | false |
| STOP | false |

