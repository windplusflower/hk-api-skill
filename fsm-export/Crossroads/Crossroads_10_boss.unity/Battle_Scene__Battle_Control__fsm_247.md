# Battle Control

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Battle Control |
| GameObject Name | Battle Scene |
| GameObject Path |   |
| Source Asset | D:/SteamLibrary/steamapps/common/Hollow Knight/hollow_knight_Data/level48 |
| Start State | Pause |
| FSM PathId | 247 |
| GameObject PathId | 10 |

## Variables

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Battle Enemies | 0 | Int32: 0 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Activated | false | Boolean: false |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Armour | Battle Scene/FK Armour (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level48) | NamedAssetPPtr: [Battle Scene/FK Armour (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level48)] |
| Barger | Battle Scene/Pre Battle Enemies/Zombie Barger (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level48) | NamedAssetPPtr: [Battle Scene/Pre Battle Enemies/Zombie Barger (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level48)] |
| CameraLock 1 | Battle Scene/CameraLockArea B (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level48) | NamedAssetPPtr: [Battle Scene/CameraLockArea B (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level48)] |
| CameraLock 2 | Battle Scene/CameraLockArea B2 (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level48) | NamedAssetPPtr: [Battle Scene/CameraLockArea B2 (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level48)] |
| False Knight | Battle Scene/False Knight New (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level48) | NamedAssetPPtr: [Battle Scene/False Knight New (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level48)] |
| Floor | Battle Scene/FK Floor (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level48) | NamedAssetPPtr: [Battle Scene/FK Floor (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level48)] |
| Hornhead | Battle Scene/Pre Battle Enemies/Zombie Hornhead (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level48) | NamedAssetPPtr: [Battle Scene/Pre Battle Enemies/Zombie Hornhead (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level48)] |
| Pre Battle Enemies | Battle Scene/Pre Battle Enemies (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level48) | NamedAssetPPtr: [Battle Scene/Pre Battle Enemies (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level48)] |
| Runner | Battle Scene/Pre Battle Enemies/Zombie Runner (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level48) | NamedAssetPPtr: [Battle Scene/Pre Battle Enemies/Zombie Runner (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level48)] |
| Tension Region | Battle Scene/Music Region B (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level48) | NamedAssetPPtr: [Battle Scene/Music Region B (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level48)] |

## States

### Detect

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Trigger2dEvent

Full Name: HutongGames.PlayMaker.Actions.Trigger2dEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerEnter2D | 0 |   |   |
| collideTag |   | "" | Tag |   |
| collideLayer |   | "" | Layer |   |
| sendEvent |   | Event(START) |   |   |
| storeCollider |   |   | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| START | Start | 0 | |

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Activated | Variable |   |
| isTrue |   | Event(ACTIVATED) |   |   |
| isFalse |   | Event() |   |   |
| everyFrame |   | false |   |   |

##### 2. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault CameraLock 1 |   |   |
| activate |   | false |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 3. DestroyObject

Full Name: HutongGames.PlayMaker.Actions.DestroyObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Battle Scene/FK Armour (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level48)] |   |   |
| delay |   | 0f |   |   |
| detachChildren |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Detect | 0 | |
| ACTIVATED | Activate | 0 | |

### Start

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Battle Enemies | Variable |   |
| intValue |   | 1 |   |   |
| everyFrame |   | false |   |   |

##### 2. DestroyObject

Full Name: HutongGames.PlayMaker.Actions.DestroyObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Battle Scene/Music Region B (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level48)] |   |   |
| delay |   | 0f |   |   |
| detachChildren |   | false |   |   |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault CameraLock 1 |   |   |
| activate |   | true |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 4. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault CameraLock 2 |   |   |
| activate |   | false |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 5. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(BroadcastAll):FSM Owner |   |   |
| sendEvent |   | "BATTLE START" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 6. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(BroadcastAll):FSM Owner |   |   |
| sendEvent |   | "BG CLOSE" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| END | End Wait | 0 | |
| KILL ALL ENEMIES | Kill Zombies | 0 | |

### End Wait

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Activated | Variable |   |
| boolValue |   | true |   |   |
| everyFrame |   | false |   |   |

##### 2. DestroyObject

Full Name: HutongGames.PlayMaker.Actions.DestroyObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Battle Scene/CameraLockArea B (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level48)] |   |   |
| delay |   | 0f |   |   |
| detachChildren |   | false |   |   |

##### 3. DestroyObject

Full Name: HutongGames.PlayMaker.Actions.DestroyObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Battle Scene/CameraLockArea B2 (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level48)] |   |   |
| delay |   | 0f |   |   |
| detachChildren |   | false |   |   |

##### 4. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 2f |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | End | 0 | |

### End

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(BroadcastAll):FSM Owner |   |   |
| sendEvent |   | "BG OPEN" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

(none)

### Pause

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. NextFrameEvent

Full Name: HutongGames.PlayMaker.Actions.NextFrameEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent |   | Event(FINISHED) |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Init | 0 | |

### Activate

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. DestroyObject

Full Name: HutongGames.PlayMaker.Actions.DestroyObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Battle Scene/Music Region B (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level48)] |   |   |
| delay |   | 0f |   |   |
| detachChildren |   | false |   |   |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(BroadcastAll):FSM Owner |   |   |
| sendEvent |   | "BG QUICK OPEN" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 3. DestroyObject

Full Name: HutongGames.PlayMaker.Actions.DestroyObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Battle Scene/CameraLockArea B (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level48)] |   |   |
| delay |   | 0f |   |   |
| detachChildren |   | false |   |   |

##### 4. DestroyObject

Full Name: HutongGames.PlayMaker.Actions.DestroyObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Battle Scene/CameraLockArea B2 (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level48)] |   |   |
| delay |   | 0f |   |   |
| detachChildren |   | false |   |   |

##### 5. DestroyObject

Full Name: HutongGames.PlayMaker.Actions.DestroyObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Battle Scene/False Knight New (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level48)] |   |   |
| delay |   | 0f |   |   |
| detachChildren |   | false |   |   |

##### 6. DestroyObject

Full Name: HutongGames.PlayMaker.Actions.DestroyObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Battle Scene/Pre Battle Enemies (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level48)] |   |   |
| delay |   | 0f |   |   |
| detachChildren |   | false |   |   |

##### 7. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Floor |   |   |
| sendEvent |   | "ACTIVATE" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

(none)

### Kill Zombies

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Battle Enemies |   |   |
| integer2 |   | 0 |   |   |
| equal |   | Event(END) |   |   |
| lessThan |   | Event(END) |   |   |
| greaterThan |   | Event() |   |   |
| everyFrame |   | true |   |   |

##### 2. SetInvincible

Full Name: SetInvincible
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target |   | OwnerDefault Hornhead | Variable |   |
| Invincible |   | false |   |   |
| InvincibleFromDirection |   | 0 |   |   |

##### 3. TakeDamage

Full Name: HutongGames.PlayMaker.Actions.TakeDamage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| Target |   | [Battle Scene/Pre Battle Enemies/Zombie Hornhead (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level48)] |   |   |
| AttackType |   | 1 |   |   |
| CircleDirection |   | false |   |   |
| DamageDealt |   | 9999 |   |   |
| Direction |   | 90f |   |   |
| IgnoreInvulnerable |   | true |   |   |
| MagnitudeMultiplier |   | 1.5f |   |   |
| MoveAngle |   | 0f |   |   |
| MoveDirection |   | false |   |   |
| Multiplier |   | 0f |   |   |
| SpecialType |   | 0 |   |   |

##### 4. SetInvincible

Full Name: SetInvincible
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target |   | OwnerDefault Runner | Variable |   |
| Invincible |   | false |   |   |
| InvincibleFromDirection |   | 0 |   |   |

##### 5. TakeDamage

Full Name: HutongGames.PlayMaker.Actions.TakeDamage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| Target |   | [Battle Scene/Pre Battle Enemies/Zombie Runner (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level48)] |   |   |
| AttackType |   | 1 |   |   |
| CircleDirection |   | false |   |   |
| DamageDealt |   | 9999 |   |   |
| Direction |   | 90f |   |   |
| IgnoreInvulnerable |   | true |   |   |
| MagnitudeMultiplier |   | 1.5f |   |   |
| MoveAngle |   | 0f |   |   |
| MoveDirection |   | false |   |   |
| Multiplier |   | 0f |   |   |
| SpecialType |   | 0 |   |   |

##### 6. SetInvincible

Full Name: SetInvincible
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target |   | OwnerDefault Barger | Variable |   |
| Invincible |   | false |   |   |
| InvincibleFromDirection |   | 0 |   |   |

##### 7. TakeDamage

Full Name: HutongGames.PlayMaker.Actions.TakeDamage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| Target |   | [Battle Scene/Pre Battle Enemies/Zombie Barger (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level48)] |   |   |
| AttackType |   | 1 |   |   |
| CircleDirection |   | false |   |   |
| DamageDealt |   | 9999 |   |   |
| Direction |   | 90f |   |   |
| IgnoreInvulnerable |   | true |   |   |
| MagnitudeMultiplier |   | 1.5f |   |   |
| MoveAngle |   | 0f |   |   |
| MoveDirection |   | false |   |   |
| Multiplier |   | 0f |   |   |
| SpecialType |   | 0 |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| END | End Wait | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| ACTIVATED | false |
| END | false |
| EXIT | false |
| FINISHED | false |
| KILL ALL ENEMIES | false |
| START | false |

