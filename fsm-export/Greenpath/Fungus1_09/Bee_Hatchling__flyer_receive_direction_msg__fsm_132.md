# flyer_receive_direction_msg

## Summary

| Field | Value |
| --- | --- |
| FSM Name | flyer_receive_direction_msg |
| GameObject Name | Bee Hatchling |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets138.assets |
| Start State | Idle |
| FSM PathId | 132 |
| GameObject PathId | 24 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Velocity | 0 | Single: 0 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Reset Rotation | false | Boolean: false |

## States

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

_None_

### Go Right

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.GetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector2(0, 0) | Vector2(0, 0) | Variable |  |
| x | float Velocity | float Velocity | Variable |  |
| y | 0f | 0f | Variable |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |

##### 2. FloatClamp

Full Name: HutongGames.PlayMaker.Actions.FloatClamp
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Velocity | float Velocity | Variable |  |
| minValue | 0f | 0f |  |  |
| maxValue | 9999f | 9999f |  |  |
| everyFrame | false | false |  |  |

##### 3. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector2(0, 0) | Vector2(0, 0) |  |  |
| x | float Velocity | float Velocity |  |  |
| y | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 4. AddForce2dV2

Full Name: HutongGames.PlayMaker.Actions.AddForce2dV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| atPosition | Vector2(0, 0) | Vector2(0, 0) | Variable |  |
| vector | Vector2(0, 0) | Vector2(0, 0) | Variable |  |
| x | 40f | 40f |  |  |
| y | 0f | 0f |  |  |
| vector3 | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| maxSpeed | 0f | 0f |  |  |
| maxSpeedX | 10f | 10f |  |  |
| maxSpeedY | 0f | 0f |  |  |
| everyFrame | true | true |  |  |

##### 5. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 1f | 1f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Reset Rotate?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Reset Rotation | bool Reset Rotation | Variable |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(RETURN) | Event(RETURN) |  |  |
| everyFrame | false | false |  |  |

##### 2. SetRotation

Full Name: HutongGames.PlayMaker.Actions.SetRotation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| quaternion | Quaternion(0, 0, 0, 0) | Quaternion(0, 0, 0, 0) | Variable |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| xAngle | 0f | 0f |  |  |
| yAngle | 0f | 0f |  |  |
| zAngle | 0f | 0f |  |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

### Go Left

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.GetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector2(0, 0) | Vector2(0, 0) | Variable |  |
| x | float Velocity | float Velocity | Variable |  |
| y | 0f | 0f | Variable |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |

##### 2. FloatClamp

Full Name: HutongGames.PlayMaker.Actions.FloatClamp
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Velocity | float Velocity | Variable |  |
| minValue | -9999f | -9999f |  |  |
| maxValue | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector2(0, 0) | Vector2(0, 0) |  |  |
| x | float Velocity | float Velocity |  |  |
| y | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 4. AddForce2dV2

Full Name: HutongGames.PlayMaker.Actions.AddForce2dV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| atPosition | Vector2(0, 0) | Vector2(0, 0) | Variable |  |
| vector | Vector2(0, 0) | Vector2(0, 0) | Variable |  |
| x | -40f | -40f |  |  |
| y | 0f | 0f |  |  |
| vector3 | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| maxSpeed | 0f | 0f |  |  |
| maxSpeedX | 10f | 10f |  |  |
| maxSpeedY | 0f | 0f |  |  |
| everyFrame | true | true |  |  |

##### 5. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 1f | 1f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Go Down

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.GetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector2(0, 0) | Vector2(0, 0) | Variable |  |
| x | 0f | 0f | Variable |  |
| y | float Velocity | float Velocity | Variable |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |

##### 2. FloatClamp

Full Name: HutongGames.PlayMaker.Actions.FloatClamp
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Velocity | float Velocity | Variable |  |
| minValue | -9999f | -9999f |  |  |
| maxValue | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector2(0, 0) | Vector2(0, 0) |  |  |
| x | 0f | 0f |  |  |
| y | float Velocity | float Velocity |  |  |
| everyFrame | false | false |  |  |

##### 4. AddForce2dV2

Full Name: HutongGames.PlayMaker.Actions.AddForce2dV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| atPosition | Vector2(0, 0) | Vector2(0, 0) | Variable |  |
| vector | Vector2(0, 0) | Vector2(0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | -40f | -40f |  |  |
| vector3 | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| maxSpeed | 0f | 0f |  |  |
| maxSpeedX | 0f | 0f |  |  |
| maxSpeedY | 10f | 10f |  |  |
| everyFrame | true | true |  |  |

##### 5. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 1f | 1f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Go Up

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.GetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector2(0, 0) | Vector2(0, 0) | Variable |  |
| x | 0f | 0f | Variable |  |
| y | float Velocity | float Velocity | Variable |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |

##### 2. FloatClamp

Full Name: HutongGames.PlayMaker.Actions.FloatClamp
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Velocity | float Velocity | Variable |  |
| minValue | 0f | 0f |  |  |
| maxValue | 9999f | 9999f |  |  |
| everyFrame | false | false |  |  |

##### 3. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector2(0, 0) | Vector2(0, 0) |  |  |
| x | 0f | 0f |  |  |
| y | float Velocity | float Velocity |  |  |
| everyFrame | false | false |  |  |

##### 4. AddForce2dV2

Full Name: HutongGames.PlayMaker.Actions.AddForce2dV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| atPosition | Vector2(0, 0) | Vector2(0, 0) | Variable |  |
| vector | Vector2(0, 0) | Vector2(0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | 40f | 40f |  |  |
| vector3 | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| maxSpeed | 0f | 0f |  |  |
| maxSpeedX | 0f | 0f |  |  |
| maxSpeedY | 10f | 10f |  |  |
| everyFrame | true | true |  |  |

##### 5. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 1f | 1f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Notify Self

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:FSM Owner | EventTarget(GameObject)[SendToChildren]:FSM Owner |  |  |
| sendEvent | "DIR MSG" | "DIR MSG" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Go Right | FINISHED | Reset Rotate? | 0 | 0 | 0 |
| Reset Rotate? | RETURN | Notify Self | 0 | 0 | 0 |
| Reset Rotate? | FINISHED | Notify Self | 0 | 0 | 0 |
| Go Left | FINISHED | Reset Rotate? | 0 | 0 | 0 |
| Go Down | FINISHED | Reset Rotate? | 0 | 0 | 0 |
| Go Up | FINISHED | Reset Rotate? | 0 | 0 | 0 |
| Notify Self | FINISHED | Idle | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| GO UP | Go Up | 0 | 0 | 0 |
| GO DOWN | Go Down | 0 | 0 | 0 |
| GO LEFT | Go Left | 0 | 0 | 0 |
| GO RIGHT | Go Right | 0 | 0 | 0 |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| GO DOWN | false |
| GO LEFT | false |
| GO RIGHT | false |
| GO UP | false |
| RETURN | false |

