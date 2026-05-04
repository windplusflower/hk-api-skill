# CameraShake

## Summary

| Field | Value |
| --- | --- |
| FSM Name | CameraShake |
| GameObject Name | CameraParent |
| GameObject Path | _GameCameras/ |
| Source Asset | D:/SteamLibrary/steamapps/common/Hollow Knight/hollow_knight_Data/level1 |
| Start State | Init |
| FSM PathId | 9149 |
| GameObject PathId | 1345 |

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
| AverageShake | Vector2(0.15, 0.15) | Vector2: Vector2(0.15, 0.15) |
| BigShake | Vector2(0.5, 0.5) | Vector2: Vector2(0.5, 0.5) |
| EnemyKillShake | Vector2(0.105, 0.105) | Vector2: Vector2(0.105, 0.105) |
| SmallShake | Vector2(0.08, 0.08) | Vector2: Vector2(0.08, 0.08) |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Self | [null] | NamedAssetPPtr: [null] |

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
| floatVariable |   | float Priority | Variable |   |
| floatValue |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 2. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool RumblingHuge | Variable |   |
| isTrue |   | Event(HugeRumble) |   |   |
| isFalse |   | Event() |   |   |
| everyFrame |   | true |   |   |

##### 3. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool RumblingBig | Variable |   |
| isTrue |   | Event(BigRumble) |   |   |
| isFalse |   | Event() |   |   |
| everyFrame |   | true |   |   |

##### 4. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool RumblingMed | Variable |   |
| isTrue |   | Event(MedRumble) |   |   |
| isFalse |   | Event() |   |   |
| everyFrame |   | true |   |   |

##### 5. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool RumblingSmall | Variable |   |
| isTrue |   | Event(SmallRumble) |   |   |
| isFalse |   | Event() |   |   |
| everyFrame |   | true |   |   |

##### 6. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool RumblingFocus | Variable |   |
| isTrue |   | Event(FocusRumble) |   |   |
| isFalse |   | Event() |   |   |
| everyFrame |   | true |   |   |

##### 7. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool RumblingFocus2 | Variable |   |
| isTrue |   | Event(FocusRumble2) |   |   |
| isFalse |   | Event() |   |   |
| everyFrame |   | true |   |   |

##### 8. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool RumblingFall | Variable |   |
| isTrue |   | Event(Fall Rumble) |   |   |
| isFalse |   | Event() |   |   |
| everyFrame |   | true |   |   |

##### 9. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | 0f |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| SmallShake | ShakingSmall | 0 | |
| SmallRumble | RumblingSmall | 0 | |
| MedRumble | RumblingMed | 0 | |
| FocusRumble | RumblingFocus | 0 | |
| Fall Rumble | RumblingFall | 0 | |
| FocusRumble2 | RumblingFocus 2 | 0 | |
| BigRumble | RumblingBig | 0 | |
| HugeRumble | RumblingHuge | 0 | |

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
| floatVariable |   | float Priority | Variable |   |
| floatValue |   | 10f |   |   |
| everyFrame |   | false |   |   |

##### 2. ShakePositionV2

Full Name: HutongGames.PlayMaker.Actions.ShakePositionV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| Target |   | OwnerDefault FSM Owner |   |   |
| Extents |   | Vector3 BigShake |   |   |
| Duration |   | 1f |   |   |
| IsLooping |   | false |   |   |
| StopEvent |   | Event(DoneShaking) |   |   |
| FpsLimit |   | float FPS Limit |   |   |
| IsCameraShake |   | true |   |   |

##### 3. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | 0f |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

##### 4. FloatAdd

Full Name: HutongGames.PlayMaker.Actions.FloatAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Big Shake Time | Variable |   |
| add |   | -1f |   |   |
| everyFrame |   | true |   |   |
| perSecond |   | true |   |   |

##### 5. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 |   | float Big Shake Time |   |   |
| float2 |   | 0f |   |   |
| tolerance |   | 0f |   |   |
| equal |   | Event(DoneShaking) |   |   |
| lessThan |   | Event(DoneShaking) |   |   |
| greaterThan |   | Event() |   |   |
| everyFrame |   | true |   |   |

##### 6. PlayVibration

Full Name: PlayVibration
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| lowFidelityVibration |   | Enum(LowFidelityVibrations, 0) |   |   |
| highFidelityVibration |   | [shake_loop (TextAsset) (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\resources.assets)] |   |   |
| motors |   | Enum(VibrationMotors, 3) |   |   |
| loopTime |   | 0f |   |   |
| isLooping |   | false |   |   |
| tag |   | "" |   |   |
| gamepadVibration |   | [LargeRumble (Script GamepadVibration) (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\resources.assets)] |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| DoneShaking | Normal | 0 | |

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
| floatVariable |   | float Priority | Variable |   |
| floatValue |   | 7f |   |   |
| everyFrame |   | false |   |   |

##### 2. ShakePositionV2

Full Name: HutongGames.PlayMaker.Actions.ShakePositionV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| Target |   | OwnerDefault FSM Owner |   |   |
| Extents |   | Vector3 AverageShake |   |   |
| Duration |   | 1f |   |   |
| IsLooping |   | false |   |   |
| StopEvent |   | Event(DoneShaking) |   |   |
| FpsLimit |   | float FPS Limit |   |   |
| IsCameraShake |   | true |   |   |

##### 3. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | 0f |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

##### 4. PlayVibration

Full Name: PlayVibration
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| lowFidelityVibration |   | Enum(LowFidelityVibrations, 0) |   |   |
| highFidelityVibration |   | [mid_hit_enemy_death (TextAsset) (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\resources.assets)] |   |   |
| motors |   | Enum(VibrationMotors, 3) |   |   |
| loopTime |   | 0f |   |   |
| isLooping |   | false |   |   |
| tag |   | "" |   |   |
| gamepadVibration |   | [SmallRumble (Script GamepadVibration) (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\resources.assets)] |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| DoneShaking | Normal | 0 | |

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
| floatVariable |   | float Priority | Variable |   |
| floatValue |   | 3f |   |   |
| everyFrame |   | false |   |   |

##### 2. ShakePositionV2

Full Name: HutongGames.PlayMaker.Actions.ShakePositionV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| Target |   | OwnerDefault FSM Owner |   |   |
| Extents |   | Vector3 SmallShake |   |   |
| Duration |   | 0.5f |   |   |
| IsLooping |   | false |   |   |
| StopEvent |   | Event(DoneShaking) |   |   |
| FpsLimit |   | float FPS Limit |   |   |
| IsCameraShake |   | true |   |   |

##### 3. PlayVibration

Full Name: PlayVibration
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| lowFidelityVibration |   | Enum(LowFidelityVibrations, 0) |   |   |
| highFidelityVibration |   | [low_hit_nail_impact (TextAsset) (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\resources.assets)] |   |   |
| motors |   | Enum(VibrationMotors, 3) |   |   |
| loopTime |   | 0f |   |   |
| isLooping |   | false |   |   |
| tag |   | "" |   |   |
| gamepadVibration |   | [SmallImpact (Script GamepadVibration) (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\resources.assets)] |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| DoneShaking | Normal | 0 | |

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
| floatVariable |   | float Priority | Variable |   |
| floatValue |   | 6f |   |   |
| everyFrame |   | false |   |   |

##### 2. ShakePositionV2

Full Name: HutongGames.PlayMaker.Actions.ShakePositionV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| Target |   | OwnerDefault FSM Owner |   |   |
| Extents |   | Vector3 EnemyKillShake |   |   |
| Duration |   | 0.5f |   |   |
| IsLooping |   | false |   |   |
| StopEvent |   | Event(DoneShaking) |   |   |
| FpsLimit |   | float FPS Limit |   |   |
| IsCameraShake |   | true |   |   |

##### 3. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | 0f |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

##### 4. PlayVibration

Full Name: PlayVibration
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| lowFidelityVibration |   | Enum(LowFidelityVibrations, 0) |   |   |
| highFidelityVibration |   | [low_hit_nail_impact (TextAsset) (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\resources.assets)] |   |   |
| motors |   | Enum(VibrationMotors, 3) |   |   |
| loopTime |   | 0f |   |   |
| isLooping |   | false |   |   |
| tag |   | "" |   |   |
| gamepadVibration |   | [SmallImpact (Script GamepadVibration) (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\resources.assets)] |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| DoneShaking | Normal | 0 | |

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
| floatVariable |   | float Priority | Variable |   |
| floatValue |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 2. ShakePositionV2

Full Name: HutongGames.PlayMaker.Actions.ShakePositionV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| Target |   | OwnerDefault FSM Owner |   |   |
| Extents |   | Vector3 SmallShake |   |   |
| Duration |   | 1f |   |   |
| IsLooping |   | true |   |   |
| StopEvent |   | Event() |   |   |
| FpsLimit |   | float FPS Limit |   |   |
| IsCameraShake |   | true |   |   |

##### 3. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool RumblingSmall | Variable |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(StopRumble) |   |   |
| everyFrame |   | true |   |   |

##### 4. PlayVibration

Full Name: PlayVibration
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| lowFidelityVibration |   | Enum(LowFidelityVibrations, 0) |   |   |
| highFidelityVibration |   | [low_hit_nail_impact (TextAsset) (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\resources.assets)] |   |   |
| motors |   | Enum(VibrationMotors, 3) |   |   |
| loopTime |   | 0.15f |   |   |
| isLooping |   | false |   |   |
| tag |   | "" |   |   |
| gamepadVibration |   | [SmallRumble (Script GamepadVibration) (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\resources.assets)] |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| StopRumble | Normal | 0 | |

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
| floatVariable |   | float Big Shake Time | Variable |   |
| floatValue |   | 1f |   |   |
| everyFrame |   | false |   |   |

##### 2. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 |   | float Priority |   |   |
| float2 |   | 10f |   |   |
| tolerance |   | 0f |   |   |
| equal |   | Event() |   |   |
| lessThan |   | Event(FINISHED) |   |   |
| greaterThan |   | Event() |   |   |
| everyFrame |   | false |   |   |

##### 3. GotoPreviousState

Full Name: HutongGames.PlayMaker.Actions.GotoPreviousState
Enabled: true

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | ShakingBig | 0 | |

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
| float1 |   | float Priority |   |   |
| float2 |   | 7f |   |   |
| tolerance |   | 0f |   |   |
| equal |   | Event() |   |   |
| lessThan |   | Event(FINISHED) |   |   |
| greaterThan |   | Event() |   |   |
| everyFrame |   | false |   |   |

##### 2. GotoPreviousState

Full Name: HutongGames.PlayMaker.Actions.GotoPreviousState
Enabled: true

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | ShakingAverage | 0 | |

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
| float1 |   | float Priority |   |   |
| float2 |   | 6f |   |   |
| tolerance |   | 0f |   |   |
| equal |   | Event() |   |   |
| lessThan |   | Event(FINISHED) |   |   |
| greaterThan |   | Event() |   |   |
| everyFrame |   | false |   |   |

##### 2. GotoPreviousState

Full Name: HutongGames.PlayMaker.Actions.GotoPreviousState
Enabled: true

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | ShakingKill | 0 | |

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
| float1 |   | float Priority |   |   |
| float2 |   | 3f |   |   |
| tolerance |   | 0f |   |   |
| equal |   | Event() |   |   |
| lessThan |   | Event(FINISHED) |   |   |
| greaterThan |   | Event() |   |   |
| everyFrame |   | false |   |   |

##### 2. GotoPreviousState

Full Name: HutongGames.PlayMaker.Actions.GotoPreviousState
Enabled: true

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | ShakingSmall | 0 | |

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
| floatVariable |   | float Priority | Variable |   |
| floatValue |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 2. ShakePositionV2

Full Name: HutongGames.PlayMaker.Actions.ShakePositionV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| Target |   | OwnerDefault FSM Owner |   |   |
| Extents |   | Vector3 AverageShake |   |   |
| Duration |   | 1f |   |   |
| IsLooping |   | true |   |   |
| StopEvent |   | Event() |   |   |
| FpsLimit |   | float FPS Limit |   |   |
| IsCameraShake |   | true |   |   |

##### 3. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool RumblingMed | Variable |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(StopRumble) |   |   |
| everyFrame |   | true |   |   |

##### 4. PlayVibration

Full Name: PlayVibration
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| lowFidelityVibration |   | Enum(LowFidelityVibrations, 0) |   |   |
| highFidelityVibration |   | [mid_hit_enemy_death (TextAsset) (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\resources.assets)] |   |   |
| motors |   | Enum(VibrationMotors, 3) |   |   |
| loopTime |   | 0.3f |   |   |
| isLooping |   | false |   |   |
| tag |   | "" |   |   |
| gamepadVibration |   | [SmallRumble (Script GamepadVibration) (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\resources.assets)] |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| StopRumble | Normal | 0 | |

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
| floatVariable |   | float Priority | Variable |   |
| floatValue |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 2. ShakePositionV2

Full Name: HutongGames.PlayMaker.Actions.ShakePositionV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| Target |   | OwnerDefault FSM Owner |   |   |
| Extents |   | Vector3(0.015, 0.015, 0) |   |   |
| Duration |   | 1f |   |   |
| IsLooping |   | true |   |   |
| StopEvent |   | Event() |   |   |
| FpsLimit |   | float FPS Limit |   |   |
| IsCameraShake |   | true |   |   |

##### 3. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool RumblingFocus | Variable |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(StopRumble) |   |   |
| everyFrame |   | true |   |   |

##### 4. PlayVibration

Full Name: PlayVibration
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| lowFidelityVibration |   | Enum(LowFidelityVibrations, 0) |   |   |
| highFidelityVibration |   | [low_hit_nail_impact (TextAsset) (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\resources.assets)] |   |   |
| motors |   | Enum(VibrationMotors, 3) |   |   |
| loopTime |   | 0.15f |   |   |
| isLooping |   | false |   |   |
| tag |   | "" |   |   |
| gamepadVibration |   | [SmallRumble (Script GamepadVibration) (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\resources.assets)] |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| StopRumble | Normal | 0 | |

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
| floatVariable |   | float Priority | Variable |   |
| floatValue |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 2. ShakePositionV2

Full Name: HutongGames.PlayMaker.Actions.ShakePositionV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| Target |   | OwnerDefault FSM Owner |   |   |
| Extents |   | Vector3(0.015, 0.015, 0) |   |   |
| Duration |   | 1f |   |   |
| IsLooping |   | true |   |   |
| StopEvent |   | Event() |   |   |
| FpsLimit |   | float FPS Limit |   |   |
| IsCameraShake |   | true |   |   |

##### 3. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool RumblingFall | Variable |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(StopRumble) |   |   |
| everyFrame |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| StopRumble | Normal | 0 | |

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
| storeGameObject |   | GameObject Self | Variable |   |

##### 2. SetGameObject

Full Name: HutongGames.PlayMaker.Actions.SetGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variable |   | [Global] GameObject CameraParent | Variable |   |
| gameObject |   | GameObject Self |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Normal | 0 | |

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
| floatVariable |   | float Priority | Variable |   |
| floatValue |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 2. ShakePositionV2

Full Name: HutongGames.PlayMaker.Actions.ShakePositionV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| Target |   | OwnerDefault FSM Owner |   |   |
| Extents |   | Vector3(0.03, 0.03, 0) |   |   |
| Duration |   | 1f |   |   |
| IsLooping |   | true |   |   |
| StopEvent |   | Event() |   |   |
| FpsLimit |   | float FPS Limit |   |   |
| IsCameraShake |   | true |   |   |

##### 3. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool RumblingFocus2 | Variable |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(StopRumble) |   |   |
| everyFrame |   | true |   |   |

##### 4. PlayVibration

Full Name: PlayVibration
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| lowFidelityVibration |   | Enum(LowFidelityVibrations, 0) |   |   |
| highFidelityVibration |   | [low_hit_nail_impact (TextAsset) (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\resources.assets)] |   |   |
| motors |   | Enum(VibrationMotors, 3) |   |   |
| loopTime |   | 0.15f |   |   |
| isLooping |   | false |   |   |
| tag |   | "" |   |   |
| gamepadVibration |   | [SmallRumble (Script GamepadVibration) (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\resources.assets)] |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| StopRumble | Normal | 0 | |

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
| float1 |   | float Priority |   |   |
| float2 |   | 8f |   |   |
| tolerance |   | 0f |   |   |
| equal |   | Event() |   |   |
| lessThan |   | Event(FINISHED) |   |   |
| greaterThan |   | Event() |   |   |
| everyFrame |   | false |   |   |

##### 2. GotoPreviousState

Full Name: HutongGames.PlayMaker.Actions.GotoPreviousState
Enabled: true

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Shaking Super Dash | 0 | |

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
| floatVariable |   | float Priority | Variable |   |
| floatValue |   | 8f |   |   |
| everyFrame |   | false |   |   |

##### 2. ShakePositionV2

Full Name: HutongGames.PlayMaker.Actions.ShakePositionV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| Target |   | OwnerDefault FSM Owner |   |   |
| Extents |   | Vector3(0.25, 0.25, 0) |   |   |
| Duration |   | 1f |   |   |
| IsLooping |   | false |   |   |
| StopEvent |   | Event(DoneShaking) |   |   |
| FpsLimit |   | float FPS Limit |   |   |
| IsCameraShake |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| DoneShaking | Normal | 0 | |

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
| Target |   | OwnerDefault FSM Owner |   |   |
| Extents |   | Vector3(0.075, 0.075, 0) |   |   |
| Duration |   | 2.5f |   |   |
| IsLooping |   | false |   |   |
| StopEvent |   | Event(DoneShaking) |   |   |
| FpsLimit |   | float FPS Limit |   |   |
| IsCameraShake |   | true |   |   |

##### 2. PlayVibration

Full Name: PlayVibration
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| lowFidelityVibration |   | Enum(LowFidelityVibrations, 0) |   |   |
| highFidelityVibration |   | [mid_hit_enemy_death (TextAsset) (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\resources.assets)] |   |   |
| motors |   | Enum(VibrationMotors, 3) |   |   |
| loopTime |   | 0.5f |   |   |
| isLooping |   | false |   |   |
| tag |   | "" |   |   |
| gamepadVibration |   | [SmallRumble (Script GamepadVibration) (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\resources.assets)] |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| DoneShaking | Normal | 0 | |

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
| boolVariable |   | bool RumblingFall | Variable |   |
| boolValue |   | false |   |   |
| everyFrame |   | false |   |   |

##### 2. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool RumblingFocus | Variable |   |
| boolValue |   | false |   |   |
| everyFrame |   | false |   |   |

##### 3. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool RumblingFocus2 | Variable |   |
| boolValue |   | false |   |   |
| everyFrame |   | false |   |   |

##### 4. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool RumblingMed | Variable |   |
| boolValue |   | false |   |   |
| everyFrame |   | false |   |   |

##### 5. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool RumblingSmall | Variable |   |
| boolValue |   | false |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Init | 0 | |

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
| floatVariable |   | float Priority | Variable |   |
| floatValue |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 2. ShakePositionV2

Full Name: HutongGames.PlayMaker.Actions.ShakePositionV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| Target |   | OwnerDefault FSM Owner |   |   |
| Extents |   | Vector3 BigShake |   |   |
| Duration |   | 1f |   |   |
| IsLooping |   | true |   |   |
| StopEvent |   | Event() |   |   |
| FpsLimit |   | float FPS Limit |   |   |
| IsCameraShake |   | true |   |   |

##### 3. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool RumblingBig | Variable |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(StopRumble) |   |   |
| everyFrame |   | true |   |   |

##### 4. PlayVibration

Full Name: PlayVibration
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| lowFidelityVibration |   | Enum(LowFidelityVibrations, 0) |   |   |
| highFidelityVibration |   | [mid_hit_enemy_death (TextAsset) (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\resources.assets)] |   |   |
| motors |   | Enum(VibrationMotors, 3) |   |   |
| loopTime |   | 0.4f |   |   |
| isLooping |   | false |   |   |
| tag |   | "" |   |   |
| gamepadVibration |   | [LargeRumble (Script GamepadVibration) (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\resources.assets)] |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| StopRumble | Normal | 0 | |

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
| Target |   | OwnerDefault FSM Owner |   |   |
| Extents |   | Vector3 AverageShake |   |   |
| Duration |   | 3f |   |   |
| IsLooping |   | false |   |   |
| StopEvent |   | Event(DoneShaking) |   |   |
| FpsLimit |   | float FPS Limit |   |   |
| IsCameraShake |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| DoneShaking | Normal | 0 | |

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
| floatVariable |   | float Priority | Variable |   |
| floatValue |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 2. ShakePositionV2

Full Name: HutongGames.PlayMaker.Actions.ShakePositionV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| Target |   | OwnerDefault FSM Owner |   |   |
| Extents |   | Vector3(1, 1, 0) |   |   |
| Duration |   | 1f |   |   |
| IsLooping |   | true |   |   |
| StopEvent |   | Event() |   |   |
| FpsLimit |   | float FPS Limit |   |   |
| IsCameraShake |   | true |   |   |

##### 3. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool RumblingHuge | Variable |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(StopRumble) |   |   |
| everyFrame |   | true |   |   |

##### 4. PlayVibration

Full Name: PlayVibration
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| lowFidelityVibration |   | Enum(LowFidelityVibrations, 0) |   |   |
| highFidelityVibration |   | [mid_hit_enemy_death (TextAsset) (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\resources.assets)] |   |   |
| motors |   | Enum(VibrationMotors, 3) |   |   |
| loopTime |   | 0.4f |   |   |
| isLooping |   | false |   |   |
| tag |   | "" |   |   |
| gamepadVibration |   | [LargeRumble (Script GamepadVibration) (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\resources.assets)] |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| StopRumble | Normal | 0 | |

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
| floatVariable |   | float Priority | Variable |   |
| floatValue |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 2. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | 0f |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| RESUME SHAKE | Normal | 0 | |

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
| floatVariable |   | float Priority | Variable |   |
| floatValue |   | 12f |   |   |
| everyFrame |   | false |   |   |

##### 2. ShakePositionV2

Full Name: HutongGames.PlayMaker.Actions.ShakePositionV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| Target |   | OwnerDefault FSM Owner |   |   |
| Extents |   | Vector3(0.65, 0.65, 0) |   |   |
| Duration |   | 1f |   |   |
| IsLooping |   | false |   |   |
| StopEvent |   | Event(DoneShaking) |   |   |
| FpsLimit |   | float FPS Limit |   |   |
| IsCameraShake |   | true |   |   |

##### 3. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | 0f |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

##### 4. PlayVibration

Full Name: PlayVibration
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| lowFidelityVibration |   | Enum(LowFidelityVibrations, 0) |   |   |
| highFidelityVibration |   | [shake_loop (TextAsset) (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\resources.assets)] |   |   |
| motors |   | Enum(VibrationMotors, 3) |   |   |
| loopTime |   | 0f |   |   |
| isLooping |   | false |   |   |
| tag |   | "" |   |   |
| gamepadVibration |   | [LargeRumble (Script GamepadVibration) (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\resources.assets)] |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| DoneShaking | Normal | 0 | |

## Global Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| BigShake | To Big Shake | 0 | |
| AverageShake | To Average Shake | 0 | |
| EnemyKillShake | To Kill Shake | 0 | |
| SmallShake | To Small Shake | 0 | |
| SuperDashShake | To SD Shake | 0 | |
| TramShake | Tram Shake | 0 | |
| LEVEL LOADED | New Scene Reset | 0 | |
| BlizzardShake | Blizzard Shake | 0 | |
| HugeShake | ShakingHuge | 0 | |
| CANCEL SHAKE | CancelAllShake | 0 | |

## Events

| Name | Global |
| --- | --- |
| AverageShake | false |
| BigRumble | false |
| BigShake | false |
| BlizzardShake | false |
| CANCEL SHAKE | false |
| DoneShaking | false |
| EnemyKillShake | false |
| FINISHED | false |
| Fall Rumble | false |
| FallRumble | false |
| FocusRumble | false |
| FocusRumble2 | false |
| HugeRumble | false |
| HugeShake | false |
| LEVEL LOADED | false |
| MedRumble | false |
| RESUME SHAKE | false |
| SmallRumble | false |
| SmallShake | false |
| StopRumble | false |
| SuperDashShake | false |
| TramShake | false |

