# health_display

## Summary

| Field | Value |
| --- | --- |
| FSM Name | health_display |
| GameObject Name | Health 9 |
| GameObject Path | _GameCameras/HudCamera/Hud Canvas/Health |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Init |
| FSM PathId | 23316 |
| GameObject PathId | 4287 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Appear Pause | 0 | Single: 0 |
| Health Num Float | 0 | Single: 0 |
| Max Heal Pause | 0 | Single: 0 |

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Current HP | 0 | Int32: 0 |
| Health Number | 9 | Int32: 9 |
| Max HP | 0 | Int32: 0 |
| Max Heal Int | 0 | Int32: 0 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Initialised | false | Boolean: false |
| Respawning Hero | false | Boolean: false |

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| Anim Appear | Health Appear | String: Health Appear |
| Anim Break | Health Break | String: Health Break |
| Anim Empty | Health Empty | String: Health Empty |
| Anim Idle | Health Idle | String: Health Idle |
| Anim Refill | Health Refill | String: Health Refill |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Bound Sprite | [null] | NamedAssetPPtr:  |
| Heal Particles | [null] | NamedAssetPPtr:  |
| Idle Sprite | [null] | NamedAssetPPtr:  |
| Idle Sprite Other | [null] | NamedAssetPPtr:  |
| Max Up | [null] | NamedAssetPPtr:  |
| Parent | [null] | NamedAssetPPtr:  |
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

##### 2. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Initialised | bool Initialised | Variable |  |
| boolValue | false | false |  |  |
| everyFrame | false | false |  |  |

##### 3. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| childName | "Max Up" | "Max Up" |  |  |
| storeResult | GameObject Max Up | GameObject Max Up | Variable |  |

##### 4. GetParent

Full Name: HutongGames.PlayMaker.Actions.GetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| storeResult | GameObject Parent | GameObject Parent | Variable |  |

##### 5. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Idle Sprite | OwnerDefault Idle Sprite |  |  |
| active | false | false |  |  |

##### 6. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| childName | "Idle Bound" | "Idle Bound" |  |  |
| storeResult | GameObject Bound Sprite | GameObject Bound Sprite | Variable |  |

### Check Max HP

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
| intName | "maxHealth" | "maxHealth" |  |  |
| storeValue | int Max HP | int Max HP | Variable |  |

##### 2. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Max HP | int Max HP |  |  |
| integer2 | int Health Number | int Health Number |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event(OVER MAX) | Event(OVER MAX) |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

### Inactive

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| active | false | false |  |  |

##### 2. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Idle Sprite | OwnerDefault Idle Sprite |  |  |
| active | false | false |  |  |

### Check if Full

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
| storeValue | int Current HP | int Current HP | Variable |  |

##### 2. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Current HP | int Current HP |  |  |
| integer2 | int Health Number | int Health Number |  |  |
| equal | Event(FULL) | Event(FULL) |  |  |
| lessThan | Event(EMPTY) | Event(EMPTY) |  |  |
| greaterThan | Event(FULL) | Event(FULL) |  |  |
| everyFrame | false | false |  |  |

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| active | false | false |  |  |

##### 2. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Idle Sprite | OwnerDefault Idle Sprite |  |  |
| active | true | true |  |  |

##### 3. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Idle Sprite Other | OwnerDefault Idle Sprite Other |  |  |
| active | false | false |  |  |

### Empty

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| animLibName | "" | "" |  |  |
| clipName | string Anim Empty = "Health Empty" | string Anim Empty = "Health Empty" |  |  |

### Break?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 4

#### Actions

##### 1. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "health" | "health" |  |  |
| storeValue | int Current HP | int Current HP | Variable |  |

##### 2. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Current HP | int Current HP |  |  |
| integer2 | int Health Number | int Health Number |  |  |
| equal | Event(FULL) | Event(FULL) |  |  |
| lessThan | Event(EMPTY) | Event(EMPTY) |  |  |
| greaterThan | Event(FULL) | Event(FULL) |  |  |
| everyFrame | false | false |  |  |

##### 3. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| active | true | true |  |  |

##### 4. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Idle Sprite | OwnerDefault Idle Sprite |  |  |
| active | false | false |  |  |

##### 5. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| clipName | string Anim Break = "Health Break" | string Anim Break = "Health Break" |  |  |
| animationTriggerEvent | Event() | Event() |  |  |
| animationCompleteEvent | Event(FINISHED) | Event(FINISHED) |  |  |

##### 6. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Parent | EventTarget(GameObject):Parent |  |  |
| sendEvent | "DAMAGE TAKEN" | "DAMAGE TAKEN" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Heal?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "health" | "health" |  |  |
| storeValue | int Current HP | int Current HP | Variable |  |

##### 2. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Current HP | int Current HP |  |  |
| integer2 | int Health Number | int Health Number |  |  |
| equal | Event(FULL) | Event(FULL) |  |  |
| lessThan | Event(EMPTY) | Event(EMPTY) |  |  |
| greaterThan | Event(FULL) | Event(FULL) |  |  |
| everyFrame | false | false |  |  |

##### 3. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| active | true | true |  |  |

##### 4. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Idle Sprite | OwnerDefault Idle Sprite |  |  |
| active | false | false |  |  |

##### 5. CreateObject

Full Name: HutongGames.PlayMaker.Actions.CreateObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Heal Particles | GameObject Heal Particles |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| rotation | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| storeObject |  |  | Variable |  |
| networkInstantiate | false | false |  |  |
| networkGroup | 0 | 0 |  |  |

##### 6. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| clipName | string Anim Refill = "Health Refill" | string Anim Refill = "Health Refill" |  |  |
| animationTriggerEvent | Event() | Event() |  |  |
| animationCompleteEvent | Event(FINISHED) | Event(FINISHED) |  |  |

### Appear?

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
| intName | "maxHealth" | "maxHealth" |  |  |
| storeValue | int Max HP | int Max HP | Variable |  |

##### 2. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Max HP | int Max HP |  |  |
| integer2 | int Health Number | int Health Number |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event(OVER MAX) | Event(OVER MAX) |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

### Max Up Appear

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| active | true | true |  |  |

##### 2. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Idle Sprite | OwnerDefault Idle Sprite |  |  |
| active | false | false |  |  |

##### 3. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| clipName | "Health Max Up" | "Health Max Up" |  |  |
| animationTriggerEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| animationCompleteEvent | Event() | Event() |  |  |

### Max Up Flash

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Max Up | OwnerDefault Max Up |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 2. Tk2dWatchAnimationEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dWatchAnimationEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| animationTriggerEvent | Event() | Event() |  |  |
| animationCompleteEvent | Event(FINISHED) | Event(FINISHED) |  |  |

### Pause

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "health" | "health" |  |  |
| storeValue | int Current HP | int Current HP | Variable |  |

##### 2. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Max Heal Int | int Max Heal Int | Variable |  |
| intValue | int Health Number | int Health Number |  |  |
| everyFrame | false | false |  |  |

##### 3. IntOperator

Full Name: HutongGames.PlayMaker.Actions.IntOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Max Heal Int | int Max Heal Int |  |  |
| integer2 | int Current HP | int Current HP |  |  |
| operation | HutongGames.PlayMaker.Actions.IntOperator/Operation::Subtract | 1 |  |  |
| storeResult | int Max Heal Int | int Max Heal Int | Variable |  |
| everyFrame | false | false |  |  |

##### 4. ConvertIntToFloat

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Max Heal Int | int Max Heal Int | Variable |  |
| floatVariable | float Max Heal Pause | float Max Heal Pause | Variable |  |
| everyFrame | false | false |  |  |

##### 5. FloatMultiply

Full Name: HutongGames.PlayMaker.Actions.FloatMultiply
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Max Heal Pause | float Max Heal Pause | Variable |  |
| multiplyBy | 0.2f | 0.2f |  |  |
| everyFrame | false | false |  |  |

##### 6. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | float Max Heal Pause | float Max Heal Pause |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Max Heal Anim

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| active | true | true |  |  |

##### 2. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Idle Sprite | OwnerDefault Idle Sprite |  |  |
| active | false | false |  |  |

##### 3. CreateObject

Full Name: HutongGames.PlayMaker.Actions.CreateObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Heal Particles | GameObject Heal Particles |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| rotation | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| storeObject |  |  | Variable |  |
| networkInstantiate | false | false |  |  |
| networkGroup | 0 | 0 |  |  |

##### 4. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| clipName | string Anim Refill = "Health Refill" | string Anim Refill = "Health Refill" |  |  |
| animationTriggerEvent | Event() | Event() |  |  |
| animationCompleteEvent | Event(FINISHED) | Event(FINISHED) |  |  |

### Load Animation?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "isFirstGame" | "isFirstGame" |  |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(FULL) | Event(FULL) |  |  |

##### 2. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Initialised | bool Initialised | Variable |  |
| isTrue | Event(FULL) | Event(FULL) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 3. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | false | false |  |  |

##### 4. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Appear Pause | float Appear Pause | Variable |  |
| floatValue | 2.5f | 2.5f |  |  |
| everyFrame | false | false |  |  |

##### 5. ConvertIntToFloat

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Health Number | int Health Number | Variable |  |
| floatVariable | float Health Num Float | float Health Num Float | Variable |  |
| everyFrame | false | false |  |  |

##### 6. FloatMultiply

Full Name: HutongGames.PlayMaker.Actions.FloatMultiply
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Health Num Float | float Health Num Float | Variable |  |
| multiplyBy | 0.2f | 0.2f |  |  |
| everyFrame | false | false |  |  |

##### 7. FloatAdd

Full Name: HutongGames.PlayMaker.Actions.FloatAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Appear Pause | float Appear Pause | Variable |  |
| add | float Health Num Float | float Health Num Float |  |  |
| everyFrame | false | false |  |  |
| perSecond | false | false |  |  |

##### 8. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | float Appear Pause | float Appear Pause |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

##### 9. GetRespawningHero

Full Name: GetRespawningHero
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variable | bool Respawning Hero | bool Respawning Hero | Variable |  |

##### 10. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Respawning Hero | bool Respawning Hero | Variable |  |
| isTrue | Event(RESPAWNING) | Event(RESPAWNING) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

### Load Anim

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | true | true |  |  |

##### 2. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| clipName | string Anim Appear = "Health Appear" | string Anim Appear = "Health Appear" |  |  |
| animationTriggerEvent | Event() | Event() |  |  |
| animationCompleteEvent | Event(FINISHED) | Event(FINISHED) |  |  |

##### 3. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Initialised | bool Initialised | Variable |  |
| boolValue | true | true |  |  |
| everyFrame | false | false |  |  |

### Charm Pause

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.1f | 0.1f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

##### 2. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Initialised | bool Initialised | Variable |  |
| boolValue | true | true |  |  |
| everyFrame | false | false |  |  |

### Check Type

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Bound Sprite | OwnerDefault Bound Sprite |  |  |
| active | false | false |  |  |

##### 2. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "equippedCharm_29" | "equippedCharm_29" |  |  |
| isTrue | Event(HIVE) | Event(HIVE) |  |  |
| isFalse | Event(NORMAL) | Event(NORMAL) |  |  |

### Normal

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| childName | "Idle" | "Idle" |  |  |
| storeResult | GameObject Idle Sprite | GameObject Idle Sprite | Variable |  |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| childName | "Idle Hive" | "Idle Hive" |  |  |
| storeResult | GameObject Idle Sprite Other | GameObject Idle Sprite Other | Variable |  |

##### 3. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Anim Appear = "Health Appear" | string Anim Appear = "Health Appear" | Variable |  |
| stringValue | "Health Appear" | "Health Appear" | TextArea |  |
| everyFrame | false | false |  |  |

##### 4. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Anim Break = "Health Break" | string Anim Break = "Health Break" | Variable |  |
| stringValue | "Health Break" | "Health Break" | TextArea |  |
| everyFrame | false | false |  |  |

##### 5. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Anim Empty = "Health Empty" | string Anim Empty = "Health Empty" | Variable |  |
| stringValue | "Health Empty" | "Health Empty" | TextArea |  |
| everyFrame | false | false |  |  |

##### 6. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Anim Refill = "Health Refill" | string Anim Refill = "Health Refill" | Variable |  |
| stringValue | "Health Refill" | "Health Refill" | TextArea |  |
| everyFrame | false | false |  |  |

##### 7. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Idle Sprite Other | OwnerDefault Idle Sprite Other |  |  |
| active | false | false |  |  |

##### 8. SetGameObject

Full Name: HutongGames.PlayMaker.Actions.SetGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variable | GameObject Heal Particles | GameObject Heal Particles | Variable |  |
| gameObject | [Global] [HP Up Particles (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [HP Up Particles (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| everyFrame | false | false |  |  |

### Hive

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| childName | "Idle Hive" | "Idle Hive" |  |  |
| storeResult | GameObject Idle Sprite | GameObject Idle Sprite | Variable |  |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| childName | "Idle" | "Idle" |  |  |
| storeResult | GameObject Idle Sprite Other | GameObject Idle Sprite Other | Variable |  |

##### 3. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Anim Appear = "Health Appear" | string Anim Appear = "Health Appear" | Variable |  |
| stringValue | "Hive Health Appear" | "Hive Health Appear" | TextArea |  |
| everyFrame | false | false |  |  |

##### 4. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Anim Break = "Health Break" | string Anim Break = "Health Break" | Variable |  |
| stringValue | "Hive Health Break" | "Hive Health Break" | TextArea |  |
| everyFrame | false | false |  |  |

##### 5. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Anim Empty = "Health Empty" | string Anim Empty = "Health Empty" | Variable |  |
| stringValue | "Hive Health Empty" | "Hive Health Empty" | TextArea |  |
| everyFrame | false | false |  |  |

##### 6. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Anim Refill = "Health Refill" | string Anim Refill = "Health Refill" | Variable |  |
| stringValue | "Hive Health Refill" | "Hive Health Refill" | TextArea |  |
| everyFrame | false | false |  |  |

##### 7. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Idle Sprite Other | OwnerDefault Idle Sprite Other |  |  |
| active | false | false |  |  |

##### 8. SetGameObject

Full Name: HutongGames.PlayMaker.Actions.SetGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variable | GameObject Heal Particles | GameObject Heal Particles | Variable |  |
| gameObject | [Global] [HP Up Particles Hive (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [HP Up Particles Hive (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| everyFrame | false | false |  |  |

### First Pause

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "enteredTutorialFirstTime" | "enteredTutorialFirstTime" |  |  |
| isTrue | Event(FINISHED) | Event(FINISHED) |  |  |
| isFalse | Event() | Event() |  |  |

##### 2. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 9.75f | 9.75f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Last HP?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Initialised | bool Initialised | Variable |  |
| boolValue | true | true |  |  |
| everyFrame | false | false |  |  |

##### 2. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Max HP | int Max HP |  |  |
| integer2 | int Health Number | int Health Number |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event(FINISHED) | Event(FINISHED) |  |  |
| greaterThan | Event(FINISHED) | Event(FINISHED) |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(BroadcastAll):FSM Owner | EventTarget(BroadcastAll):FSM Owner |  |  |
| sendEvent | "LAST HP ADDED" | "LAST HP ADDED" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### ReInit

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Initialised | bool Initialised | Variable |  |
| boolValue | false | false |  |  |
| everyFrame | false | false |  |  |

##### 2. GetOwner

Full Name: HutongGames.PlayMaker.Actions.GetOwner
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeGameObject | GameObject Self | GameObject Self | Variable |  |

##### 3. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Initialised | bool Initialised | Variable |  |
| boolValue | false | false |  |  |
| everyFrame | false | false |  |  |

##### 4. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| childName | "Max Up" | "Max Up" |  |  |
| storeResult | GameObject Max Up | GameObject Max Up | Variable |  |

##### 5. GetParent

Full Name: HutongGames.PlayMaker.Actions.GetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| storeResult | GameObject Parent | GameObject Parent | Variable |  |

##### 6. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Idle Sprite | OwnerDefault Idle Sprite |  |  |
| active | false | false |  |  |

### Pause Frame

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

### Blue Refresh

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Health Number | int Health Number |  |  |
| integer2 | 1 | 1 |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event(FINISHED) | Event(FINISHED) |  |  |
| greaterThan | Event(FINISHED) | Event(FINISHED) |  |  |
| everyFrame | false | false |  |  |

##### 2. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "equippedCharm_27" | "equippedCharm_27" |  |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(FINISHED) | Event(FINISHED) |  |  |

##### 3. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Idle Sprite | OwnerDefault Idle Sprite |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Blue Idle" | "Blue Idle" |  |  |

##### 4. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Idle Sprite | OwnerDefault Idle Sprite |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

### Waiting

Description: Waiting for CHARM INDICATOR CHECK event 
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 1f | 1f |  |  |
| finishEvent | Event(WAIT) | Event(WAIT) |  |  |
| realTime | false | false |  |  |

### Check Bound

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GGCheckBoundHeart

Full Name: GGCheckBoundHeart
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| healthNumber | int Health Number | int Health Number |  |  |
| checkSource | GGCheckBoundHeart/CheckSource::Regular | 0 |  |  |
| trueEvent | Event(BOUND) | Event(BOUND) |  |  |
| falseEvent | Event(FINISHED) | Event(FINISHED) |  |  |

### Bound

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Health Bound" | "Health Bound" |  |  |

##### 2. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Idle Sprite | OwnerDefault Idle Sprite |  |  |
| active | false | false |  |  |

##### 3. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Bound Sprite | OwnerDefault Bound Sprite |  |  |
| active | true | true |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Init | FINISHED | Check Type | 0 | 0 | 0 |
| Check Max HP | OVER MAX | Inactive | 0 | 0 | 0 |
| Check Max HP | FINISHED | Check Bound | 0 | 0 | 0 |
| Inactive | MAX HP UP | Appear? | 0 | 0 | 0 |
| Check if Full | FULL | Idle | 0 | 0 | 0 |
| Check if Full | EMPTY | Empty | 0 | 0 | 0 |
| Idle | HERO DAMAGED | Pause Frame | 0 | 0 | 0 |
| Empty | HERO HEALED | Heal? | 0 | 0 | 0 |
| Empty | HERO HEALED FULL | Pause | 0 | 0 | 0 |
| Break? | FULL | Idle | 0 | 0 | 0 |
| Break? | FINISHED | Empty | 0 | 0 | 0 |
| Break? | HERO HEALED | Heal? | 0 | 0 | 0 |
| Break? | HERO HEALED FULL | Pause | 0 | 0 | 0 |
| Heal? | EMPTY | Empty | 0 | 0 | 0 |
| Heal? | FINISHED | Idle | 0 | 0 | 0 |
| Heal? | HERO DAMAGED | Empty | 0 | 0 | 0 |
| Appear? | OVER MAX | Inactive | 0 | 0 | 0 |
| Appear? | FINISHED | Max Up Appear | 0 | 0 | 0 |
| Max Up Appear | FINISHED | Max Up Flash | 0 | 0 | 0 |
| Max Up Flash | FINISHED | Idle | 0 | 0 | 0 |
| Pause | FINISHED | Max Heal Anim | 0 | 0 | 0 |
| Max Heal Anim | FINISHED | Idle | 0 | 0 | 0 |
| Load Animation? | FINISHED | First Pause | 0 | 0 | 0 |
| Load Animation? | FULL | Check if Full | 0 | 0 | 0 |
| Load Animation? | RESPAWNING | Waiting | 0 | 0 | 0 |
| Load Anim | FINISHED | Last HP? | 0 | 0 | 0 |
| Charm Pause | FINISHED | Check Type | 0 | 0 | 0 |
| Check Type | NORMAL | Normal | 0 | 0 | 0 |
| Check Type | HIVE | Hive | 0 | 0 | 0 |
| Normal | FINISHED | Check Max HP | 0 | 0 | 0 |
| Hive | FINISHED | Check Max HP | 0 | 0 | 0 |
| First Pause | FINISHED | Load Anim | 0 | 0 | 0 |
| Last HP? | FINISHED | Check if Full | 0 | 0 | 0 |
| ReInit | FINISHED | Check Type | 0 | 0 | 0 |
| Pause Frame | FINISHED | Break? | 0 | 0 | 0 |
| Blue Refresh | FINISHED | Idle | 0 | 0 | 0 |
| Waiting | WAIT | Charm Pause | 0 | 0 | 0 |
| Check Bound | BOUND | Bound | 0 | 0 | 0 |
| Check Bound | FINISHED | Load Animation? | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| CHARM INDICATOR CHECK | Charm Pause | 0 | 0 | 0 |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| BOUND | false |
| CHARM INDICATOR CHECK | false |
| EMPTY | false |
| FULL | false |
| HERO DAMAGED | true |
| HERO HEALED | false |
| HERO HEALED FULL | false |
| HIVE | false |
| HP UP | false |
| MAX HP UP | false |
| NORMAL | false |
| OVER MAX | false |
| RESPAWNING | false |
| UPDATE BLUE HEALTH | false |
| WAIT | true |

