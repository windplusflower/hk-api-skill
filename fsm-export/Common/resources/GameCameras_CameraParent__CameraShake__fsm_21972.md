# CameraShake

## Summary

| Field | Value |
| --- | --- |
| FSM Name | CameraShake |
| GameObject Name | CameraParent |
| GameObject Path | _GameCameras |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Init |
| FSM PathId | 21972 |
| GameObject PathId | 5338 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Big Shake Time | 0 | Single: 0 |
| FPS Limit | 60 | Single: 60 |
| Priority | 0 | Single: 0 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| RumblingBig | false | Boolean: false |
| RumblingFall | false | Boolean: false |
| RumblingFocus | false | Boolean: false |
| RumblingFocus2 | false | Boolean: false |
| RumblingHuge | false | Boolean: false |
| RumblingMed | false | Boolean: false |
| RumblingSmall | false | Boolean: false |

### Vector3s

| Name | Value | Raw/Type |
| --- | --- | --- |
| AverageShake | Vector3(0.15, 0.15, 0) | Vector3: Vector3(0.15, 0.15, 0) |
| BigShake | Vector3(0.5, 0.5, 0) | Vector3: Vector3(0.5, 0.5, 0) |
| EnemyKillShake | Vector3(0.105, 0.105, 0) | Vector3: Vector3(0.105, 0.105, 0) |
| SmallShake | Vector3(0.08, 0.08, 0) | Vector3: Vector3(0.08, 0.08, 0) |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Self | [null] | NamedAssetPPtr:  |

## States

### Normal

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 8

#### Actions

##### 1. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Priority | float Priority | Variable |  |
| floatValue | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool RumblingHuge | bool RumblingHuge | Variable |  |
| isTrue | Event(HugeRumble) | Event(HugeRumble) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | true | true |  |  |

##### 3. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool RumblingBig | bool RumblingBig | Variable |  |
| isTrue | Event(BigRumble) | Event(BigRumble) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | true | true |  |  |

##### 4. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool RumblingMed | bool RumblingMed | Variable |  |
| isTrue | Event(MedRumble) | Event(MedRumble) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | true | true |  |  |

##### 5. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool RumblingSmall | bool RumblingSmall | Variable |  |
| isTrue | Event(SmallRumble) | Event(SmallRumble) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | true | true |  |  |

##### 6. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool RumblingFocus | bool RumblingFocus | Variable |  |
| isTrue | Event(FocusRumble) | Event(FocusRumble) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | true | true |  |  |

##### 7. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool RumblingFocus2 | bool RumblingFocus2 | Variable |  |
| isTrue | Event(FocusRumble2) | Event(FocusRumble2) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | true | true |  |  |

##### 8. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool RumblingFall | bool RumblingFall | Variable |  |
| isTrue | Event(Fall Rumble) | Event(Fall Rumble) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | true | true |  |  |

##### 9. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

### ShakingBig

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Priority | float Priority | Variable |  |
| floatValue | 10f | 10f |  |  |
| everyFrame | false | false |  |  |

##### 2. ShakePositionV2

Full Name: HutongGames.PlayMaker.Actions.ShakePositionV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| Target | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| Extents | Vector3 BigShake | Vector3 BigShake |  |  |
| Duration | 1f | 1f |  |  |
| IsLooping | false | false |  |  |
| StopEvent | Event(DoneShaking) | Event(DoneShaking) |  |  |
| FpsLimit | float FPS Limit | float FPS Limit |  |  |
| IsCameraShake | true | true |  |  |

##### 3. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 4. FloatAdd

Full Name: HutongGames.PlayMaker.Actions.FloatAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Big Shake Time | float Big Shake Time | Variable |  |
| add | -1f | -1f |  |  |
| everyFrame | true | true |  |  |
| perSecond | true | true |  |  |

##### 5. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float Big Shake Time | float Big Shake Time |  |  |
| float2 | 0f | 0f |  |  |
| tolerance | 0f | 0f |  |  |
| equal | Event(DoneShaking) | Event(DoneShaking) |  |  |
| lessThan | Event(DoneShaking) | Event(DoneShaking) |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | true | true |  |  |

##### 6. PlayVibration

Full Name: PlayVibration
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| lowFidelityVibration | Enum(LowFidelityVibrations, 0) | Enum(LowFidelityVibrations, 0) |  |  |
| highFidelityVibration | [shake_loop (TextAsset) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [shake_loop (TextAsset) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| motors | Enum(VibrationMotors, 3) | Enum(VibrationMotors, 3) |  |  |
| loopTime | 0f | 0f |  |  |
| isLooping | false | false |  |  |
| tag | "" | "" |  |  |
| gamepadVibration | [LargeRumble (Script GamepadVibration) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [LargeRumble (Script GamepadVibration) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |

### ShakingAverage

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Priority | float Priority | Variable |  |
| floatValue | 7f | 7f |  |  |
| everyFrame | false | false |  |  |

##### 2. ShakePositionV2

Full Name: HutongGames.PlayMaker.Actions.ShakePositionV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| Target | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| Extents | Vector3 AverageShake | Vector3 AverageShake |  |  |
| Duration | 1f | 1f |  |  |
| IsLooping | false | false |  |  |
| StopEvent | Event(DoneShaking) | Event(DoneShaking) |  |  |
| FpsLimit | float FPS Limit | float FPS Limit |  |  |
| IsCameraShake | true | true |  |  |

##### 3. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 4. PlayVibration

Full Name: PlayVibration
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| lowFidelityVibration | Enum(LowFidelityVibrations, 0) | Enum(LowFidelityVibrations, 0) |  |  |
| highFidelityVibration | [mid_hit_enemy_death (TextAsset) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [mid_hit_enemy_death (TextAsset) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| motors | Enum(VibrationMotors, 3) | Enum(VibrationMotors, 3) |  |  |
| loopTime | 0f | 0f |  |  |
| isLooping | false | false |  |  |
| tag | "" | "" |  |  |
| gamepadVibration | [SmallRumble (Script GamepadVibration) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [SmallRumble (Script GamepadVibration) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |

### ShakingSmall

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Priority | float Priority | Variable |  |
| floatValue | 3f | 3f |  |  |
| everyFrame | false | false |  |  |

##### 2. ShakePositionV2

Full Name: HutongGames.PlayMaker.Actions.ShakePositionV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| Target | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| Extents | Vector3 SmallShake | Vector3 SmallShake |  |  |
| Duration | 0.5f | 0.5f |  |  |
| IsLooping | false | false |  |  |
| StopEvent | Event(DoneShaking) | Event(DoneShaking) |  |  |
| FpsLimit | float FPS Limit | float FPS Limit |  |  |
| IsCameraShake | true | true |  |  |

##### 3. PlayVibration

Full Name: PlayVibration
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| lowFidelityVibration | Enum(LowFidelityVibrations, 0) | Enum(LowFidelityVibrations, 0) |  |  |
| highFidelityVibration | [low_hit_nail_impact (TextAsset) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [low_hit_nail_impact (TextAsset) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| motors | Enum(VibrationMotors, 3) | Enum(VibrationMotors, 3) |  |  |
| loopTime | 0f | 0f |  |  |
| isLooping | false | false |  |  |
| tag | "" | "" |  |  |
| gamepadVibration | [SmallImpact (Script GamepadVibration) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [SmallImpact (Script GamepadVibration) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |

### ShakingKill

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Priority | float Priority | Variable |  |
| floatValue | 6f | 6f |  |  |
| everyFrame | false | false |  |  |

##### 2. ShakePositionV2

Full Name: HutongGames.PlayMaker.Actions.ShakePositionV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| Target | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| Extents | Vector3 EnemyKillShake | Vector3 EnemyKillShake |  |  |
| Duration | 0.5f | 0.5f |  |  |
| IsLooping | false | false |  |  |
| StopEvent | Event(DoneShaking) | Event(DoneShaking) |  |  |
| FpsLimit | float FPS Limit | float FPS Limit |  |  |
| IsCameraShake | true | true |  |  |

##### 3. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 4. PlayVibration

Full Name: PlayVibration
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| lowFidelityVibration | Enum(LowFidelityVibrations, 0) | Enum(LowFidelityVibrations, 0) |  |  |
| highFidelityVibration | [low_hit_nail_impact (TextAsset) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [low_hit_nail_impact (TextAsset) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| motors | Enum(VibrationMotors, 3) | Enum(VibrationMotors, 3) |  |  |
| loopTime | 0f | 0f |  |  |
| isLooping | false | false |  |  |
| tag | "" | "" |  |  |
| gamepadVibration | [SmallImpact (Script GamepadVibration) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [SmallImpact (Script GamepadVibration) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |

### RumblingSmall

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Priority | float Priority | Variable |  |
| floatValue | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. ShakePositionV2

Full Name: HutongGames.PlayMaker.Actions.ShakePositionV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| Target | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| Extents | Vector3 SmallShake | Vector3 SmallShake |  |  |
| Duration | 1f | 1f |  |  |
| IsLooping | true | true |  |  |
| StopEvent | Event() | Event() |  |  |
| FpsLimit | float FPS Limit | float FPS Limit |  |  |
| IsCameraShake | true | true |  |  |

##### 3. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool RumblingSmall | bool RumblingSmall | Variable |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(StopRumble) | Event(StopRumble) |  |  |
| everyFrame | true | true |  |  |

##### 4. PlayVibration

Full Name: PlayVibration
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| lowFidelityVibration | Enum(LowFidelityVibrations, 0) | Enum(LowFidelityVibrations, 0) |  |  |
| highFidelityVibration | [low_hit_nail_impact (TextAsset) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [low_hit_nail_impact (TextAsset) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| motors | Enum(VibrationMotors, 3) | Enum(VibrationMotors, 3) |  |  |
| loopTime | 0.15f | 0.15f |  |  |
| isLooping | false | false |  |  |
| tag | "" | "" |  |  |
| gamepadVibration | [SmallRumble (Script GamepadVibration) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [SmallRumble (Script GamepadVibration) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |

### To Big Shake

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Big Shake Time | float Big Shake Time | Variable |  |
| floatValue | 1f | 1f |  |  |
| everyFrame | false | false |  |  |

##### 2. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float Priority | float Priority |  |  |
| float2 | 10f | 10f |  |  |
| tolerance | 0f | 0f |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event(FINISHED) | Event(FINISHED) |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 3. GotoPreviousState

Full Name: HutongGames.PlayMaker.Actions.GotoPreviousState
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

### To Average Shake

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float Priority | float Priority |  |  |
| float2 | 7f | 7f |  |  |
| tolerance | 0f | 0f |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event(FINISHED) | Event(FINISHED) |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 2. GotoPreviousState

Full Name: HutongGames.PlayMaker.Actions.GotoPreviousState
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

### To Kill Shake

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float Priority | float Priority |  |  |
| float2 | 6f | 6f |  |  |
| tolerance | 0f | 0f |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event(FINISHED) | Event(FINISHED) |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 2. GotoPreviousState

Full Name: HutongGames.PlayMaker.Actions.GotoPreviousState
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

### To Small Shake

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float Priority | float Priority |  |  |
| float2 | 3f | 3f |  |  |
| tolerance | 0f | 0f |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event(FINISHED) | Event(FINISHED) |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 2. GotoPreviousState

Full Name: HutongGames.PlayMaker.Actions.GotoPreviousState
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

### RumblingMed

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Priority | float Priority | Variable |  |
| floatValue | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. ShakePositionV2

Full Name: HutongGames.PlayMaker.Actions.ShakePositionV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| Target | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| Extents | Vector3 AverageShake | Vector3 AverageShake |  |  |
| Duration | 1f | 1f |  |  |
| IsLooping | true | true |  |  |
| StopEvent | Event() | Event() |  |  |
| FpsLimit | float FPS Limit | float FPS Limit |  |  |
| IsCameraShake | true | true |  |  |

##### 3. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool RumblingMed | bool RumblingMed | Variable |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(StopRumble) | Event(StopRumble) |  |  |
| everyFrame | true | true |  |  |

##### 4. PlayVibration

Full Name: PlayVibration
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| lowFidelityVibration | Enum(LowFidelityVibrations, 0) | Enum(LowFidelityVibrations, 0) |  |  |
| highFidelityVibration | [mid_hit_enemy_death (TextAsset) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [mid_hit_enemy_death (TextAsset) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| motors | Enum(VibrationMotors, 3) | Enum(VibrationMotors, 3) |  |  |
| loopTime | 0.3f | 0.3f |  |  |
| isLooping | false | false |  |  |
| tag | "" | "" |  |  |
| gamepadVibration | [SmallRumble (Script GamepadVibration) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [SmallRumble (Script GamepadVibration) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |

### RumblingFocus

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Priority | float Priority | Variable |  |
| floatValue | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. ShakePositionV2

Full Name: HutongGames.PlayMaker.Actions.ShakePositionV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| Target | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| Extents | Vector3(0.015, 0.015, 0) | Vector3(0.015, 0.015, 0) |  |  |
| Duration | 1f | 1f |  |  |
| IsLooping | true | true |  |  |
| StopEvent | Event() | Event() |  |  |
| FpsLimit | float FPS Limit | float FPS Limit |  |  |
| IsCameraShake | true | true |  |  |

##### 3. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool RumblingFocus | bool RumblingFocus | Variable |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(StopRumble) | Event(StopRumble) |  |  |
| everyFrame | true | true |  |  |

##### 4. PlayVibration

Full Name: PlayVibration
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| lowFidelityVibration | Enum(LowFidelityVibrations, 0) | Enum(LowFidelityVibrations, 0) |  |  |
| highFidelityVibration | [low_hit_nail_impact (TextAsset) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [low_hit_nail_impact (TextAsset) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| motors | Enum(VibrationMotors, 3) | Enum(VibrationMotors, 3) |  |  |
| loopTime | 0.15f | 0.15f |  |  |
| isLooping | false | false |  |  |
| tag | "" | "" |  |  |
| gamepadVibration | [SmallRumble (Script GamepadVibration) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [SmallRumble (Script GamepadVibration) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |

### RumblingFall

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Priority | float Priority | Variable |  |
| floatValue | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. ShakePositionV2

Full Name: HutongGames.PlayMaker.Actions.ShakePositionV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| Target | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| Extents | Vector3(0.015, 0.015, 0) | Vector3(0.015, 0.015, 0) |  |  |
| Duration | 1f | 1f |  |  |
| IsLooping | true | true |  |  |
| StopEvent | Event() | Event() |  |  |
| FpsLimit | float FPS Limit | float FPS Limit |  |  |
| IsCameraShake | true | true |  |  |

##### 3. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool RumblingFall | bool RumblingFall | Variable |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(StopRumble) | Event(StopRumble) |  |  |
| everyFrame | true | true |  |  |

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

##### 2. SetGameObject

Full Name: HutongGames.PlayMaker.Actions.SetGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variable | [Global] GameObject CameraParent | [Global] GameObject CameraParent | Variable |  |
| gameObject | GameObject Self | GameObject Self |  |  |
| everyFrame | false | false |  |  |

### RumblingFocus 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Priority | float Priority | Variable |  |
| floatValue | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. ShakePositionV2

Full Name: HutongGames.PlayMaker.Actions.ShakePositionV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| Target | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| Extents | Vector3(0.03, 0.03, 0) | Vector3(0.03, 0.03, 0) |  |  |
| Duration | 1f | 1f |  |  |
| IsLooping | true | true |  |  |
| StopEvent | Event() | Event() |  |  |
| FpsLimit | float FPS Limit | float FPS Limit |  |  |
| IsCameraShake | true | true |  |  |

##### 3. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool RumblingFocus2 | bool RumblingFocus2 | Variable |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(StopRumble) | Event(StopRumble) |  |  |
| everyFrame | true | true |  |  |

##### 4. PlayVibration

Full Name: PlayVibration
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| lowFidelityVibration | Enum(LowFidelityVibrations, 0) | Enum(LowFidelityVibrations, 0) |  |  |
| highFidelityVibration | [low_hit_nail_impact (TextAsset) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [low_hit_nail_impact (TextAsset) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| motors | Enum(VibrationMotors, 3) | Enum(VibrationMotors, 3) |  |  |
| loopTime | 0.15f | 0.15f |  |  |
| isLooping | false | false |  |  |
| tag | "" | "" |  |  |
| gamepadVibration | [SmallRumble (Script GamepadVibration) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [SmallRumble (Script GamepadVibration) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |

### To SD Shake

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float Priority | float Priority |  |  |
| float2 | 8f | 8f |  |  |
| tolerance | 0f | 0f |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event(FINISHED) | Event(FINISHED) |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 2. GotoPreviousState

Full Name: HutongGames.PlayMaker.Actions.GotoPreviousState
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

### Shaking Super Dash

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Priority | float Priority | Variable |  |
| floatValue | 8f | 8f |  |  |
| everyFrame | false | false |  |  |

##### 2. ShakePositionV2

Full Name: HutongGames.PlayMaker.Actions.ShakePositionV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| Target | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| Extents | Vector3(0.25, 0.25, 0) | Vector3(0.25, 0.25, 0) |  |  |
| Duration | 1f | 1f |  |  |
| IsLooping | false | false |  |  |
| StopEvent | Event(DoneShaking) | Event(DoneShaking) |  |  |
| FpsLimit | float FPS Limit | float FPS Limit |  |  |
| IsCameraShake | true | true |  |  |

### Tram Shake

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. ShakePositionV2

Full Name: HutongGames.PlayMaker.Actions.ShakePositionV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| Target | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| Extents | Vector3(0.075, 0.075, 0) | Vector3(0.075, 0.075, 0) |  |  |
| Duration | 2.5f | 2.5f |  |  |
| IsLooping | false | false |  |  |
| StopEvent | Event(DoneShaking) | Event(DoneShaking) |  |  |
| FpsLimit | float FPS Limit | float FPS Limit |  |  |
| IsCameraShake | true | true |  |  |

##### 2. PlayVibration

Full Name: PlayVibration
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| lowFidelityVibration | Enum(LowFidelityVibrations, 0) | Enum(LowFidelityVibrations, 0) |  |  |
| highFidelityVibration | [mid_hit_enemy_death (TextAsset) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [mid_hit_enemy_death (TextAsset) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| motors | Enum(VibrationMotors, 3) | Enum(VibrationMotors, 3) |  |  |
| loopTime | 0.5f | 0.5f |  |  |
| isLooping | false | false |  |  |
| tag | "" | "" |  |  |
| gamepadVibration | [SmallRumble (Script GamepadVibration) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [SmallRumble (Script GamepadVibration) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |

### New Scene Reset

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool RumblingFall | bool RumblingFall | Variable |  |
| boolValue | false | false |  |  |
| everyFrame | false | false |  |  |

##### 2. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool RumblingFocus | bool RumblingFocus | Variable |  |
| boolValue | false | false |  |  |
| everyFrame | false | false |  |  |

##### 3. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool RumblingFocus2 | bool RumblingFocus2 | Variable |  |
| boolValue | false | false |  |  |
| everyFrame | false | false |  |  |

##### 4. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool RumblingMed | bool RumblingMed | Variable |  |
| boolValue | false | false |  |  |
| everyFrame | false | false |  |  |

##### 5. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool RumblingSmall | bool RumblingSmall | Variable |  |
| boolValue | false | false |  |  |
| everyFrame | false | false |  |  |

### RumblingBig

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Priority | float Priority | Variable |  |
| floatValue | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. ShakePositionV2

Full Name: HutongGames.PlayMaker.Actions.ShakePositionV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| Target | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| Extents | Vector3 BigShake | Vector3 BigShake |  |  |
| Duration | 1f | 1f |  |  |
| IsLooping | true | true |  |  |
| StopEvent | Event() | Event() |  |  |
| FpsLimit | float FPS Limit | float FPS Limit |  |  |
| IsCameraShake | true | true |  |  |

##### 3. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool RumblingBig | bool RumblingBig | Variable |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(StopRumble) | Event(StopRumble) |  |  |
| everyFrame | true | true |  |  |

##### 4. PlayVibration

Full Name: PlayVibration
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| lowFidelityVibration | Enum(LowFidelityVibrations, 0) | Enum(LowFidelityVibrations, 0) |  |  |
| highFidelityVibration | [mid_hit_enemy_death (TextAsset) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [mid_hit_enemy_death (TextAsset) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| motors | Enum(VibrationMotors, 3) | Enum(VibrationMotors, 3) |  |  |
| loopTime | 0.4f | 0.4f |  |  |
| isLooping | false | false |  |  |
| tag | "" | "" |  |  |
| gamepadVibration | [LargeRumble (Script GamepadVibration) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [LargeRumble (Script GamepadVibration) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |

### Blizzard Shake

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. ShakePositionV2

Full Name: HutongGames.PlayMaker.Actions.ShakePositionV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| Target | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| Extents | Vector3 AverageShake | Vector3 AverageShake |  |  |
| Duration | 3f | 3f |  |  |
| IsLooping | false | false |  |  |
| StopEvent | Event(DoneShaking) | Event(DoneShaking) |  |  |
| FpsLimit | float FPS Limit | float FPS Limit |  |  |
| IsCameraShake | true | true |  |  |

### RumblingHuge

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Priority | float Priority | Variable |  |
| floatValue | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. ShakePositionV2

Full Name: HutongGames.PlayMaker.Actions.ShakePositionV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| Target | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| Extents | Vector3(1, 1, 0) | Vector3(1, 1, 0) |  |  |
| Duration | 1f | 1f |  |  |
| IsLooping | true | true |  |  |
| StopEvent | Event() | Event() |  |  |
| FpsLimit | float FPS Limit | float FPS Limit |  |  |
| IsCameraShake | true | true |  |  |

##### 3. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool RumblingHuge | bool RumblingHuge | Variable |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(StopRumble) | Event(StopRumble) |  |  |
| everyFrame | true | true |  |  |

##### 4. PlayVibration

Full Name: PlayVibration
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| lowFidelityVibration | Enum(LowFidelityVibrations, 0) | Enum(LowFidelityVibrations, 0) |  |  |
| highFidelityVibration | [mid_hit_enemy_death (TextAsset) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [mid_hit_enemy_death (TextAsset) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| motors | Enum(VibrationMotors, 3) | Enum(VibrationMotors, 3) |  |  |
| loopTime | 0.4f | 0.4f |  |  |
| isLooping | false | false |  |  |
| tag | "" | "" |  |  |
| gamepadVibration | [LargeRumble (Script GamepadVibration) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [LargeRumble (Script GamepadVibration) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |

### CancelAllShake

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Priority | float Priority | Variable |  |
| floatValue | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

### ShakingHuge

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Priority | float Priority | Variable |  |
| floatValue | 12f | 12f |  |  |
| everyFrame | false | false |  |  |

##### 2. ShakePositionV2

Full Name: HutongGames.PlayMaker.Actions.ShakePositionV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| Target | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| Extents | Vector3(0.65, 0.65, 0) | Vector3(0.65, 0.65, 0) |  |  |
| Duration | 1f | 1f |  |  |
| IsLooping | false | false |  |  |
| StopEvent | Event(DoneShaking) | Event(DoneShaking) |  |  |
| FpsLimit | float FPS Limit | float FPS Limit |  |  |
| IsCameraShake | true | true |  |  |

##### 3. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 4. PlayVibration

Full Name: PlayVibration
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| lowFidelityVibration | Enum(LowFidelityVibrations, 0) | Enum(LowFidelityVibrations, 0) |  |  |
| highFidelityVibration | [shake_loop (TextAsset) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [shake_loop (TextAsset) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| motors | Enum(VibrationMotors, 3) | Enum(VibrationMotors, 3) |  |  |
| loopTime | 0f | 0f |  |  |
| isLooping | false | false |  |  |
| tag | "" | "" |  |  |
| gamepadVibration | [LargeRumble (Script GamepadVibration) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [LargeRumble (Script GamepadVibration) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Normal | SmallShake | ShakingSmall | 0 | 0 | 0 |
| Normal | SmallRumble | RumblingSmall | 0 | 0 | 0 |
| Normal | MedRumble | RumblingMed | 0 | 0 | 0 |
| Normal | FocusRumble | RumblingFocus | 0 | 0 | 0 |
| Normal | Fall Rumble | RumblingFall | 0 | 0 | 0 |
| Normal | FocusRumble2 | RumblingFocus 2 | 0 | 0 | 0 |
| Normal | BigRumble | RumblingBig | 0 | 0 | 0 |
| Normal | HugeRumble | RumblingHuge | 0 | 0 | 0 |
| ShakingBig | DoneShaking | Normal | 0 | 0 | 0 |
| ShakingAverage | DoneShaking | Normal | 0 | 0 | 0 |
| ShakingSmall | DoneShaking | Normal | 0 | 0 | 0 |
| ShakingKill | DoneShaking | Normal | 0 | 0 | 0 |
| RumblingSmall | StopRumble | Normal | 0 | 0 | 0 |
| To Big Shake | FINISHED | ShakingBig | 0 | 0 | 0 |
| To Average Shake | FINISHED | ShakingAverage | 0 | 0 | 0 |
| To Kill Shake | FINISHED | ShakingKill | 0 | 0 | 0 |
| To Small Shake | FINISHED | ShakingSmall | 0 | 0 | 0 |
| RumblingMed | StopRumble | Normal | 0 | 0 | 0 |
| RumblingFocus | StopRumble | Normal | 0 | 0 | 0 |
| RumblingFall | StopRumble | Normal | 0 | 0 | 0 |
| Init | FINISHED | Normal | 0 | 0 | 0 |
| RumblingFocus 2 | StopRumble | Normal | 0 | 0 | 0 |
| To SD Shake | FINISHED | Shaking Super Dash | 0 | 0 | 0 |
| Shaking Super Dash | DoneShaking | Normal | 0 | 0 | 0 |
| Tram Shake | DoneShaking | Normal | 0 | 0 | 0 |
| New Scene Reset | FINISHED | Init | 0 | 0 | 0 |
| RumblingBig | StopRumble | Normal | 0 | 0 | 0 |
| Blizzard Shake | DoneShaking | Normal | 0 | 0 | 0 |
| RumblingHuge | StopRumble | Normal | 0 | 0 | 0 |
| CancelAllShake | RESUME SHAKE | Normal | 0 | 0 | 0 |
| ShakingHuge | DoneShaking | Normal | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| BigShake | To Big Shake | 0 | 0 | 0 |
| AverageShake | To Average Shake | 0 | 0 | 0 |
| EnemyKillShake | To Kill Shake | 0 | 0 | 0 |
| SmallShake | To Small Shake | 0 | 0 | 0 |
| SuperDashShake | To SD Shake | 0 | 0 | 0 |
| TramShake | Tram Shake | 0 | 0 | 0 |
| LEVEL LOADED | New Scene Reset | 0 | 0 | 0 |
| BlizzardShake | Blizzard Shake | 0 | 0 | 0 |
| HugeShake | ShakingHuge | 0 | 0 | 0 |
| CANCEL SHAKE | CancelAllShake | 0 | 0 | 0 |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| LEVEL LOADED | false |
| AverageShake | false |
| BigRumble | false |
| BigShake | false |
| BlizzardShake | false |
| CANCEL SHAKE | false |
| DoneShaking | false |
| EnemyKillShake | false |
| Fall Rumble | false |
| FallRumble | false |
| FocusRumble | false |
| FocusRumble2 | false |
| HugeRumble | false |
| HugeShake | false |
| MedRumble | false |
| RESUME SHAKE | false |
| SmallRumble | false |
| SmallShake | false |
| StopRumble | false |
| SuperDashShake | false |
| TramShake | false |

