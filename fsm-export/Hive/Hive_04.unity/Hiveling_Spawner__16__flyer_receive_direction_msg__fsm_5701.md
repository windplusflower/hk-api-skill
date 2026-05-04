# flyer_receive_direction_msg

## Summary

| Field | Value |
| --- | --- |
| FSM Name | flyer_receive_direction_msg |
| GameObject Name | Hiveling Spawner (16) |
| GameObject Path | Hatcher Cage (2)/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level388 |
| Start State | Idle |
| FSM PathId | 5701 |
| GameObject PathId | 301 |

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
Local Transitions: 4

#### Actions

(none)

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| GO UP | Go Up | 0 | |
| GO LEFT | Go Left | 0 | |
| GO RIGHT | Go Right | 0 | |
| GO DOWN | Go Down | 0 | |

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
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector2(0, 0) | Variable |   |
| x |   | float Velocity | Variable |   |
| y |   | 0f | Variable |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |

##### 2. FloatClamp

Full Name: HutongGames.PlayMaker.Actions.FloatClamp
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Velocity | Variable |   |
| minValue |   | 0f |   |   |
| maxValue |   | 9999f |   |   |
| everyFrame |   | false |   |   |

##### 3. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector2(0, 0) |   |   |
| x |   | float Velocity |   |   |
| y |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 4. AddForce2dV2

Full Name: HutongGames.PlayMaker.Actions.AddForce2dV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| atPosition |   | Vector2(0, 0) | Variable |   |
| vector |   | Vector2(0, 0) | Variable |   |
| x |   | 40f |   |   |
| y |   | 0f |   |   |
| vector3 |   | Vector3(0, 0, 0) |   |   |
| maxSpeed |   | 0f |   |   |
| maxSpeedX |   | 10f |   |   |
| maxSpeedY |   | 0f |   |   |
| everyFrame |   | true |   |   |

##### 5. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 1f |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Reset Rotate? | 0 | |

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
| boolVariable |   | bool Reset Rotation | Variable |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(RETURN) |   |   |
| everyFrame |   | false |   |   |

##### 2. SetRotation

Full Name: HutongGames.PlayMaker.Actions.SetRotation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| quaternion |   | Quaternion(0, 0, 0, 0) | Variable |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| xAngle |   | 0f |   |   |
| yAngle |   | 0f |   |   |
| zAngle |   | 0f |   |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| RETURN | Notify Self | 0 | |
| FINISHED | Notify Self | 0 | |

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
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector2(0, 0) | Variable |   |
| x |   | float Velocity | Variable |   |
| y |   | 0f | Variable |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |

##### 2. FloatClamp

Full Name: HutongGames.PlayMaker.Actions.FloatClamp
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Velocity | Variable |   |
| minValue |   | -9999f |   |   |
| maxValue |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 3. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector2(0, 0) |   |   |
| x |   | float Velocity |   |   |
| y |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 4. AddForce2dV2

Full Name: HutongGames.PlayMaker.Actions.AddForce2dV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| atPosition |   | Vector2(0, 0) | Variable |   |
| vector |   | Vector2(0, 0) | Variable |   |
| x |   | -40f |   |   |
| y |   | 0f |   |   |
| vector3 |   | Vector3(0, 0, 0) |   |   |
| maxSpeed |   | 0f |   |   |
| maxSpeedX |   | 10f |   |   |
| maxSpeedY |   | 0f |   |   |
| everyFrame |   | true |   |   |

##### 5. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 1f |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Reset Rotate? | 0 | |

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
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector2(0, 0) | Variable |   |
| x |   | 0f | Variable |   |
| y |   | float Velocity | Variable |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |

##### 2. FloatClamp

Full Name: HutongGames.PlayMaker.Actions.FloatClamp
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Velocity | Variable |   |
| minValue |   | -9999f |   |   |
| maxValue |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 3. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector2(0, 0) |   |   |
| x |   | 0f |   |   |
| y |   | float Velocity |   |   |
| everyFrame |   | false |   |   |

##### 4. AddForce2dV2

Full Name: HutongGames.PlayMaker.Actions.AddForce2dV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| atPosition |   | Vector2(0, 0) | Variable |   |
| vector |   | Vector2(0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | -40f |   |   |
| vector3 |   | Vector3(0, 0, 0) |   |   |
| maxSpeed |   | 0f |   |   |
| maxSpeedX |   | 0f |   |   |
| maxSpeedY |   | 10f |   |   |
| everyFrame |   | true |   |   |

##### 5. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 1f |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Reset Rotate? | 0 | |

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
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector2(0, 0) | Variable |   |
| x |   | 0f | Variable |   |
| y |   | float Velocity | Variable |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |

##### 2. FloatClamp

Full Name: HutongGames.PlayMaker.Actions.FloatClamp
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Velocity | Variable |   |
| minValue |   | 0f |   |   |
| maxValue |   | 9999f |   |   |
| everyFrame |   | false |   |   |

##### 3. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector2(0, 0) |   |   |
| x |   | 0f |   |   |
| y |   | float Velocity |   |   |
| everyFrame |   | false |   |   |

##### 4. AddForce2dV2

Full Name: HutongGames.PlayMaker.Actions.AddForce2dV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| atPosition |   | Vector2(0, 0) | Variable |   |
| vector |   | Vector2(0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | 40f |   |   |
| vector3 |   | Vector3(0, 0, 0) |   |   |
| maxSpeed |   | 0f |   |   |
| maxSpeedX |   | 0f |   |   |
| maxSpeedY |   | 10f |   |   |
| everyFrame |   | true |   |   |

##### 5. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 1f |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Reset Rotate? | 0 | |

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
| eventTarget |   | EventTarget(GameObject)[SendToChildren]:FSM Owner |   |   |
| sendEvent |   | "DIR MSG" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Idle | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| GO DOWN | false |
| GO LEFT | false |
| GO RIGHT | false |
| GO UP | false |
| RETURN | false |

