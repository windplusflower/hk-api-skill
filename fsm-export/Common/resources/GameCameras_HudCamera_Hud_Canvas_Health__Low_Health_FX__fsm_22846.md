# Low Health FX

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Low Health FX |
| GameObject Name | Health |
| GameObject Path | _GameCameras/HudCamera/Hud Canvas |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Pre Init |
| FSM PathId | 22846 |
| GameObject PathId | 5640 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Wait Time | 0 | Single: 0 |

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Blue HP | 0 | Int32: 0 |
| HP | 0 | Int32: 0 |

### Vector3s

| Name | Value | Raw/Type |
| --- | --- | --- |
| H1 Initial Pos | Vector3(0, 0, 0) | Vector3: Vector3(0, 0, 0) |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Health 1 | [null] | NamedAssetPPtr:  |
| Joni Health | [null] | NamedAssetPPtr:  |
| Low Health Leak | [null] | NamedAssetPPtr:  |
| Low Health Light | [null] | NamedAssetPPtr:  |
| Low Health Particles | [null] | NamedAssetPPtr:  |
| Low Health Vignette | [null] | NamedAssetPPtr:  |
| My HUD Camera | [null] | NamedAssetPPtr:  |
| OC Backboard | [null] | NamedAssetPPtr:  |
| Parent | [null] | NamedAssetPPtr:  |

## States

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "equippedCharm_27" | "equippedCharm_27" |  |  |
| isTrue | Event(FINISHED) | Event(FINISHED) |  |  |
| isFalse | Event() | Event() |  |  |

##### 2. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "health" | "health" |  |  |
| storeValue | int HP | int HP | Variable |  |

##### 3. SetParticleEmissionRate

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmissionRate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Low Health Leak | OwnerDefault Low Health Leak |  |  |
| emissionRate | 18f | 18f |  |  |
| everyFrame | false | false |  |  |

##### 4. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int HP | int HP |  |  |
| integer2 | 1 | 1 |  |  |
| equal | Event(LOW) | Event(LOW) |  |  |
| lessThan | Event() | Event() |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Low Health Particles | OwnerDefault Low Health Particles |  |  |
| emission | false | false |  |  |

##### 2. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Low Health Leak | OwnerDefault Low Health Leak |  |  |
| emission | false | false |  |  |

##### 3. SetParticleEmissionRate

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmissionRate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Low Health Particles | OwnerDefault Low Health Particles |  |  |
| emissionRate | 40f | 40f |  |  |
| everyFrame | false | false |  |  |

##### 4. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Low Health Light | EventTarget(GameObject):Low Health Light |  |  |
| sendEvent | "DOWN" | "DOWN" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 5. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Health 1 | OwnerDefault Health 1 |  |  |
| vector | Vector3 H1 Initial Pos | Vector3 H1 Initial Pos | Variable |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 6. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Joni Health | OwnerDefault Joni Health |  |  |
| vector | Vector3 H1 Initial Pos | Vector3 H1 Initial Pos | Variable |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| z | -3f | -3f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 7. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Low Health Vignette | EventTarget(GameObject):Low Health Vignette |  |  |
| sendEvent | "DOWN" | "DOWN" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Low Health?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "health" | "health" |  |  |
| storeValue | int HP | int HP | Variable |  |

##### 2. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "healthBlue" | "healthBlue" |  |  |
| storeValue | int Blue HP | int Blue HP | Variable |  |

##### 3. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Blue HP | int Blue HP |  |  |
| integer2 | 0 | 0 |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event() | Event() |  |  |
| greaterThan | Event(FINISHED) | Event(FINISHED) |  |  |
| everyFrame | false | false |  |  |

##### 4. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int HP | int HP |  |  |
| integer2 | 1 | 1 |  |  |
| equal | Event(LOW) | Event(LOW) |  |  |
| lessThan | Event() | Event() |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

### Low Health

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 5

#### Actions

##### 1. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Wait Time | float Wait Time | Variable |  |
| floatValue | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):AudioManager | EventTarget(GameObject):AudioManager |  |  |
| sendEvent | "HERO LOW HEALTH" | "HERO LOW HEALTH" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. SetParticleEmissionRate

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmissionRate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Low Health Leak | OwnerDefault Low Health Leak |  |  |
| emissionRate | 18f | 18f |  |  |
| everyFrame | false | false |  |  |

##### 4. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Low Health Particles | OwnerDefault Low Health Particles |  |  |
| emission | true | true |  |  |

##### 5. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Low Health Leak | OwnerDefault Low Health Leak |  |  |
| emission | true | true |  |  |

##### 6. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Low Health Light | EventTarget(GameObject):Low Health Light |  |  |
| sendEvent | "UP" | "UP" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 7. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Low Health Vignette | EventTarget(GameObject):Low Health Vignette |  |  |
| sendEvent | "UP" | "UP" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 8. iTweenShakePosition

Full Name: HutongGames.PlayMaker.Actions.iTweenShakePosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Health 1 | OwnerDefault Health 1 |  |  |
| id | "" | "" |  |  |
| vector | Vector3(0.075, 0.075, 0) | Vector3(0.075, 0.075, 0) |  |  |
| time | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| loopType | iTween/LoopType::loop | 1 |  |  |
| space | UnityEngine.Space::World | 0 |  |  |
| axis | HutongGames.PlayMaker.Actions.iTweenFsmAction/AxisRestriction::none | 0 |  |  |
| startEvent | Event() | Event() |  |  |
| finishEvent | Event() | Event() |  |  |
| realTime | false | false |  |  |
| stopOnExit | true | true |  |  |
| loopDontFinish | true | true |  |  |

##### 9. iTweenShakePosition

Full Name: HutongGames.PlayMaker.Actions.iTweenShakePosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Joni Health | OwnerDefault Joni Health |  |  |
| id | "" | "" |  |  |
| vector | Vector3(0.075, 0.075, 0) | Vector3(0.075, 0.075, 0) |  |  |
| time | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| loopType | iTween/LoopType::loop | 1 |  |  |
| space | UnityEngine.Space::World | 0 |  |  |
| axis | HutongGames.PlayMaker.Actions.iTweenFsmAction/AxisRestriction::none | 0 |  |  |
| startEvent | Event() | Event() |  |  |
| finishEvent | Event() | Event() |  |  |
| realTime | false | false |  |  |
| stopOnExit | true | true |  |  |
| loopDontFinish | true | true |  |  |

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
| sendEvent | Event(FINISHED) | Event(FINISHED) |  |  |

##### 2. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.5f | 0.5f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Low Health On Entry

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 5

#### Actions

##### 1. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Low Health Particles | OwnerDefault Low Health Particles |  |  |
| emission | true | true |  |  |

##### 2. SetParticleEmissionRate

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmissionRate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Low Health Particles | OwnerDefault Low Health Particles |  |  |
| emissionRate | 40f | 40f |  |  |
| everyFrame | false | false |  |  |

##### 3. SetParticleEmissionRate

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmissionRate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Low Health Leak | OwnerDefault Low Health Leak |  |  |
| emissionRate | 18f | 18f |  |  |
| everyFrame | false | false |  |  |

##### 4. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Low Health Leak | OwnerDefault Low Health Leak |  |  |
| emission | true | true |  |  |

##### 5. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Low Health Light | EventTarget(GameObject):Low Health Light |  |  |
| sendEvent | "UP" | "UP" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 6. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Low Health Vignette | EventTarget(GameObject):Low Health Vignette |  |  |
| sendEvent | "UP" | "UP" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 7. iTweenShakePosition

Full Name: HutongGames.PlayMaker.Actions.iTweenShakePosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Health 1 | OwnerDefault Health 1 |  |  |
| id | "" | "" |  |  |
| vector | Vector3(0.075, 0.075, 0) | Vector3(0.075, 0.075, 0) |  |  |
| time | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| loopType | iTween/LoopType::loop | 1 |  |  |
| space | UnityEngine.Space::World | 0 |  |  |
| axis | HutongGames.PlayMaker.Actions.iTweenFsmAction/AxisRestriction::none | 0 |  |  |
| startEvent | Event() | Event() |  |  |
| finishEvent | Event() | Event() |  |  |
| realTime | false | false |  |  |
| stopOnExit | true | true |  |  |
| loopDontFinish | true | true |  |  |

##### 8. iTweenShakePosition

Full Name: HutongGames.PlayMaker.Actions.iTweenShakePosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Joni Health | OwnerDefault Joni Health |  |  |
| id | "" | "" |  |  |
| vector | Vector3(0.075, 0.075, 0) | Vector3(0.075, 0.075, 0) |  |  |
| time | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| loopType | iTween/LoopType::loop | 1 |  |  |
| space | UnityEngine.Space::World | 0 |  |  |
| axis | HutongGames.PlayMaker.Actions.iTweenFsmAction/AxisRestriction::none | 0 |  |  |
| startEvent | Event() | Event() |  |  |
| finishEvent | Event() | Event() |  |  |
| realTime | false | false |  |  |
| stopOnExit | true | true |  |  |
| loopDontFinish | true | true |  |  |

### HUD In HP Check

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "health" | "health" |  |  |
| storeValue | int HP | int HP | Variable |  |

##### 2. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "healthBlue" | "healthBlue" |  |  |
| storeValue | int Blue HP | int Blue HP | Variable |  |

##### 3. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Blue HP | int Blue HP |  |  |
| integer2 | 0 | 0 |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event() | Event() |  |  |
| greaterThan | Event(FINISHED) | Event(FINISHED) |  |  |
| everyFrame | false | false |  |  |

##### 4. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int HP | int HP |  |  |
| integer2 | 1 | 1 |  |  |
| equal | Event(LOW) | Event(LOW) |  |  |
| lessThan | Event() | Event() |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

### Overcharmed Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "OC Backboard" | "OC Backboard" |  |  |
| storeResult | GameObject OC Backboard | GameObject OC Backboard | Variable |  |

##### 2. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault OC Backboard | OwnerDefault OC Backboard |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 3. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "overcharmed" | "overcharmed" |  |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(FINISHED) | Event(FINISHED) |  |  |

##### 4. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault OC Backboard | OwnerDefault OC Backboard |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

### Overcharmed?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault OC Backboard | OwnerDefault OC Backboard |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 2. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "overcharmed" | "overcharmed" |  |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(FINISHED) | Event(FINISHED) |  |  |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault OC Backboard | OwnerDefault OC Backboard |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

### Init Wait

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 2.4f | 2.4f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Pre Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Low Health Vignette" | "Low Health Vignette" |  |  |
| storeResult | GameObject Low Health Vignette | GameObject Low Health Vignette | Variable |  |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Health 1" | "Health 1" |  |  |
| storeResult | GameObject Health 1 | GameObject Health 1 | Variable |  |

##### 3. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Joni Health" | "Joni Health" |  |  |
| storeResult | GameObject Joni Health | GameObject Joni Health | Variable |  |

##### 4. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Low Health Particles" | "Low Health Particles" |  |  |
| storeResult | GameObject Low Health Particles | GameObject Low Health Particles | Variable |  |

##### 5. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Low Health Light" | "Low Health Light" |  |  |
| storeResult | GameObject Low Health Light | GameObject Low Health Light | Variable |  |

##### 6. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| childName | "Low Health Leak" | "Low Health Leak" |  |  |
| storeResult | GameObject Low Health Leak | GameObject Low Health Leak | Variable |  |

##### 7. GetParent

Full Name: HutongGames.PlayMaker.Actions.GetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| storeResult | GameObject Parent | GameObject Parent | Variable |  |

##### 8. GetNamedParent

Full Name: HutongGames.PlayMaker.Actions.GetNamedParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| parentName | "HudCamera" | "HudCamera" |  |  |
| withTag | "" | "" | Tag |  |
| storeResult | GameObject My HUD Camera | GameObject My HUD Camera | Variable |  |

##### 9. SetParent

Full Name: HutongGames.PlayMaker.Actions.SetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Low Health Vignette | OwnerDefault Low Health Vignette |  |  |
| parent | GameObject My HUD Camera | GameObject My HUD Camera |  |  |
| resetLocalPosition | false | false |  |  |
| resetLocalRotation | false | false |  |  |

##### 10. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Health 1 | OwnerDefault Health 1 |  |  |
| vector | Vector3 H1 Initial Pos | Vector3 H1 Initial Pos | Variable |  |
| x | 0f | 0f | Variable |  |
| y | 0f | 0f | Variable |  |
| z | 0f | 0f | Variable |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |

### Low Health Pause

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. NextFrameEvent

Full Name: HutongGames.PlayMaker.Actions.NextFrameEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent | Event(FINISHED) | Event(FINISHED) |  |  |

### Wait

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | float Wait Time | float Wait Time |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Init | FINISHED | Idle | 0 | 0 | 0 |
| Init | LOW | Low Health On Entry | 0 | 0 | 0 |
| Idle | HERO DAMAGED | Low Health Pause | 0 | 0 | 0 |
| Low Health? | LOW | Wait | 0 | 0 | 0 |
| Low Health? | FINISHED | Idle | 0 | 0 | 0 |
| Low Health | HERO HEALED | Idle | 0 | 0 | 0 |
| Low Health | HERO HEALED FULL | Idle | 0 | 0 | 0 |
| Low Health | HERO LEAVE | Idle | 0 | 0 | 0 |
| Low Health | LOW HEALTH END | Idle | 0 | 0 | 0 |
| Low Health | ADD BLUE HEALTH | Idle | 0 | 0 | 0 |
| Pause | FINISHED | Init Wait | 0 | 0 | 0 |
| Low Health On Entry | HERO HEALED | Idle | 0 | 0 | 0 |
| Low Health On Entry | HERO HEALED FULL | Idle | 0 | 0 | 0 |
| Low Health On Entry | HERO LEAVE | Idle | 0 | 0 | 0 |
| Low Health On Entry | LOW HEALTH END | Idle | 0 | 0 | 0 |
| Low Health On Entry | ADD BLUE HEALTH | Idle | 0 | 0 | 0 |
| HUD In HP Check | LOW | Low Health On Entry | 0 | 0 | 0 |
| HUD In HP Check | FINISHED | Idle | 0 | 0 | 0 |
| Overcharmed Init | FINISHED | Init | 0 | 0 | 0 |
| Overcharmed? | FINISHED | HUD In HP Check | 0 | 0 | 0 |
| Init Wait | FINISHED | Overcharmed Init | 0 | 0 | 0 |
| Pre Init | FINISHED | Pause | 0 | 0 | 0 |
| Low Health Pause | FINISHED | Low Health? | 0 | 0 | 0 |
| Wait | FINISHED | Low Health | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| HUD OUT | Idle | 0 | 0 | 0 |
| HUD IN | Overcharmed? | 0 | 0 | 0 |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| ADD BLUE HEALTH | false |
| HERO DAMAGED | true |
| HERO HEALED | false |
| HERO HEALED FULL | false |
| HERO LEAVE | false |
| HUD IN | false |
| HUD OUT | false |
| LOW | false |
| LOW HEALTH END | false |

