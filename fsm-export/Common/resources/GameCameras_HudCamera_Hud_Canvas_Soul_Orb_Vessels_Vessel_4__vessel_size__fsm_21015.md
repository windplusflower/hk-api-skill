# vessel_size

## Summary

| Field | Value |
| --- | --- |
| FSM Name | vessel_size |
| GameObject Name | Vessel 4 |
| GameObject Path | _GameCameras/HudCamera/Hud Canvas/Soul Orb/Vessels |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Init |
| FSM PathId | 21015 |
| GameObject PathId | 4966 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Tween Time | 0.75 | Single: 0.75 |

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Empty Amount | 0 | Int32: 0 |
| Full Amount | 0 | Int32: 0 |
| MP Reserve | 0 | Int32: 0 |
| MP Reserve Max | 0 | Int32: 0 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Small | false | Boolean: false |

### Vector3s

| Name | Value | Raw/Type |
| --- | --- | --- |
| Full Size | Vector3(1, 1, 1) | Vector3: Vector3(1, 1, 1) |
| Small Size | Vector3(0.75, 0.75, 0.75) | Vector3: Vector3(0.75, 0.75, 0.75) |

## States

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

_None_

### Init Check

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
| intName | "MPReserve" | "MPReserve" |  |  |
| storeValue | int MP Reserve | int MP Reserve | Variable |  |

##### 2. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int MP Reserve | int MP Reserve |  |  |
| integer2 | int Empty Amount | int Empty Amount |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event(SMALL) | Event(SMALL) |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 3. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int MP Reserve | int MP Reserve |  |  |
| integer2 | int Full Amount | int Full Amount |  |  |
| equal | Event(SMALL) | Event(SMALL) |  |  |
| lessThan | Event(LARGE) | Event(LARGE) |  |  |
| greaterThan | Event(SMALL) | Event(SMALL) |  |  |
| everyFrame | false | false |  |  |

### Start Small

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetScale

Full Name: HutongGames.PlayMaker.Actions.SetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector3 Small Size | Vector3 Small Size | Variable |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| z | 0f | 0f |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 2. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Small | bool Small | Variable |  |
| boolValue | true | true |  |  |
| everyFrame | false | false |  |  |

### Start Large

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetScale

Full Name: HutongGames.PlayMaker.Actions.SetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector3 Full Size | Vector3 Full Size | Variable |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| z | 0f | 0f |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 2. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Small | bool Small | Variable |  |
| boolValue | false | false |  |  |
| everyFrame | false | false |  |  |

### Check

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
| intName | "MPReserve" | "MPReserve" |  |  |
| storeValue | int MP Reserve | int MP Reserve | Variable |  |

##### 2. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int MP Reserve | int MP Reserve |  |  |
| integer2 | int Empty Amount | int Empty Amount |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event(SMALL) | Event(SMALL) |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 3. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int MP Reserve | int MP Reserve |  |  |
| integer2 | int Full Amount | int Full Amount |  |  |
| equal | Event(SMALL) | Event(SMALL) |  |  |
| lessThan | Event(LARGE) | Event(LARGE) |  |  |
| greaterThan | Event(SMALL) | Event(SMALL) |  |  |
| everyFrame | false | false |  |  |

### Small

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Small | bool Small | Variable |  |
| isTrue | Event(NO CHANGE) | Event(NO CHANGE) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 2. iTweenScaleTo

Full Name: HutongGames.PlayMaker.Actions.iTweenScaleTo
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| id | "" | "" |  |  |
| transformScale |  |  |  |  |
| vectorScale | Vector3 Small Size | Vector3 Small Size |  |  |
| time | float Tween Time | float Tween Time |  |  |
| delay | 0f | 0f |  |  |
| speed | 0f | 0f |  |  |
| easeType | iTween/EaseType::easeOutSine | 13 |  |  |
| loopType | iTween/LoopType::none | 0 |  |  |
| startEvent | Event() | Event() |  |  |
| finishEvent | Event() | Event() |  |  |
| realTime | false | false |  |  |
| stopOnExit | false | false |  |  |
| loopDontFinish | true | true |  |  |

##### 3. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Small | bool Small | Variable |  |
| boolValue | true | true |  |  |
| everyFrame | false | false |  |  |

### Large

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Small | bool Small | Variable |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(NO CHANGE) | Event(NO CHANGE) |  |  |
| everyFrame | false | false |  |  |

##### 2. iTweenScaleTo

Full Name: HutongGames.PlayMaker.Actions.iTweenScaleTo
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| id | "" | "" |  |  |
| transformScale |  |  |  |  |
| vectorScale | Vector3 Full Size | Vector3 Full Size |  |  |
| time | float Tween Time | float Tween Time |  |  |
| delay | 0f | 0f |  |  |
| speed | 0f | 0f |  |  |
| easeType | iTween/EaseType::easeOutSine | 13 |  |  |
| loopType | iTween/LoopType::none | 0 |  |  |
| startEvent | Event() | Event() |  |  |
| finishEvent | Event() | Event() |  |  |
| realTime | false | false |  |  |
| stopOnExit | false | false |  |  |
| loopDontFinish | true | true |  |  |

##### 3. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Small | bool Small | Variable |  |
| boolValue | false | false |  |  |
| everyFrame | false | false |  |  |

### No Change

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

_None_

### Max Inclusive?

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
| intName | "MPReserveMax" | "MPReserveMax" |  |  |
| storeValue | int MP Reserve Max | int MP Reserve Max | Variable |  |

##### 2. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int MP Reserve Max | int MP Reserve Max |  |  |
| integer2 | int Full Amount | int Full Amount |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event(FINISHED) | Event(FINISHED) |  |  |
| greaterThan | Event(FINISHED) | Event(FINISHED) |  |  |
| everyFrame | false | false |  |  |

##### 3. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Full Amount | int Full Amount | Variable |  |
| add | 1 | 1 |  |  |
| everyFrame | false | false |  |  |

### Bound

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SetScale

Full Name: HutongGames.PlayMaker.Actions.SetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector3 Small Size | Vector3 Small Size | Variable |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| z | 0f | 0f |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Init | START | Max Inclusive? | 0 | 0 | 0 |
| Init Check | SMALL | Start Small | 0 | 0 | 0 |
| Init Check | LARGE | Start Large | 0 | 0 | 0 |
| Start Small | SIZE CHECK | Check | 0 | 0 | 0 |
| Start Large | SIZE CHECK | Check | 0 | 0 | 0 |
| Check | SMALL | Small | 0 | 0 | 0 |
| Check | LARGE | Large | 0 | 0 | 0 |
| Small | SIZE CHECK | Check | 0 | 0 | 0 |
| Small | NO CHANGE | No Change | 0 | 0 | 0 |
| Large | SIZE CHECK | Check | 0 | 0 | 0 |
| Large | NO CHANGE | No Change | 0 | 0 | 0 |
| No Change | SIZE CHECK | Check | 0 | 0 | 0 |
| Max Inclusive? | FINISHED | Init Check | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| BIND VESSEL ORB | Bound | 0 | 0 | 0 |
| UNBIND VESSEL ORB | Check | 0 | 0 | 0 |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| BIND VESSEL ORB | true |
| LARGE | false |
| NO CHANGE | false |
| SIZE CHECK | false |
| SMALL | false |
| START | false |
| UNBIND VESSEL ORB | true |

