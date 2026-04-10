# FSM

## Summary

| Field | Value |
| --- | --- |
| FSM Name | FSM |
| GameObject Name | Unnamed |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets7.assets |
| Start State | Pause Frame |
| FSM PathId | 632 |
| GameObject PathId |  |

## Variables

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Cave Wind | false | Boolean: false |
| Fade Music | false | Boolean: false |
| Surface Wind | false | Boolean: false |
| Surface Wind C | true | Boolean: true |
| _Is Door | false | Boolean: false |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Atmos Cave Wind | [null] | NamedAssetPPtr:  |
| Atmos Folder | [null] | NamedAssetPPtr:  |
| Atmos Surface Wind | [null] | NamedAssetPPtr:  |
| Atmos Surface Wind C | [null] | NamedAssetPPtr:  |
| Music Folder | [null] | NamedAssetPPtr:  |
| Track 1 | [null] | NamedAssetPPtr:  |

## States

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
| boolVariable | bool _Is Door | bool _Is Door | Variable |  |
| isTrue | Event(DOOR) | Event(DOOR) |  |  |
| isFalse | Event(FINISHED) | Event(FINISHED) |  |  |
| everyFrame | false | false |  |  |

### Cave Wind

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Cave Wind | bool Cave Wind | Variable |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(OFF) | Event(OFF) |  |  |
| everyFrame | false | false |  |  |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Atmos | OwnerDefault Atmos |  |  |
| childName | "Atmos Cave Wind" | "Atmos Cave Wind" |  |  |
| storeResult | GameObject Atmos Cave Wind | GameObject Atmos Cave Wind | Variable |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObjectFSM)[SendToFSM: Atmos Control]:Atmos Cave Wind | EventTarget(GameObjectFSM)[SendToFSM: Atmos Control]:Atmos Cave Wind |  |  |
| sendEvent | "STOP" | "STOP" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Wait

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Trigger2dEventLayer

Full Name: HutongGames.PlayMaker.Actions.Trigger2dEventLayer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerEnter2D | 0 |  |  |
| collideTag | "Player" | "Player" | Tag |  |
| collideLayer | 0 | 0 | Layer |  |
| sendEvent | Event(TRIGGER) | Event(TRIGGER) |  |  |
| storeCollider |  |  | Variable |  |

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

### Surface Wind

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Surface Wind | bool Surface Wind | Variable |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(OFF) | Event(OFF) |  |  |
| everyFrame | false | false |  |  |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Atmos | OwnerDefault Atmos |  |  |
| childName | "Atmos Surface Wind" | "Atmos Surface Wind" |  |  |
| storeResult | GameObject Atmos Surface Wind | GameObject Atmos Surface Wind | Variable |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObjectFSM)[SendToFSM: Atmos Control]:Atmos Surface Wind | EventTarget(GameObjectFSM)[SendToFSM: Atmos Control]:Atmos Surface Wind |  |  |
| sendEvent | "STOP" | "STOP" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Surface Wind C

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Surface Wind C | bool Surface Wind C | Variable |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(OFF) | Event(OFF) |  |  |
| everyFrame | false | false |  |  |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Atmos | OwnerDefault Atmos |  |  |
| childName | "Atmos Surface Wind C" | "Atmos Surface Wind C" |  |  |
| storeResult | GameObject Atmos Surface Wind C | GameObject Atmos Surface Wind C | Variable |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObjectFSM)[SendToFSM: Atmos Control]:Atmos Surface Wind C | EventTarget(GameObjectFSM)[SendToFSM: Atmos Control]:Atmos Surface Wind C |  |  |
| sendEvent | "STOP" | "STOP" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Music

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Fade Music | bool Fade Music | Variable |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(OFF) | Event(OFF) |  |  |
| everyFrame | false | false |  |  |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| childName | "Music" | "Music" |  |  |
| storeResult | GameObject Music Folder | GameObject Music Folder | Variable |  |

##### 3. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Music Folder | OwnerDefault Music Folder |  |  |
| childName | "Track 1" | "Track 1" |  |  |
| storeResult | GameObject Track 1 | GameObject Track 1 | Variable |  |

##### 4. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Track 1 | OwnerDefault Track 1 |  |  |
| fsmName | "Music Player" | "Music Player" | FsmName |  |
| variableName | "Fade Vol End" | "Fade Vol End" | FsmFloat |  |
| setValue | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 5. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Track 1 | OwnerDefault Track 1 |  |  |
| fsmName | "Music Player" | "Music Player" | FsmName |  |
| variableName | "Fade Time" | "Fade Time" | FsmFloat |  |
| setValue | 0.3f | 0.3f |  |  |
| everyFrame | false | false |  |  |

##### 6. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Track 1 | EventTarget(GameObject):Track 1 |  |  |
| sendEvent | "FADE" | "FADE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Door Wait

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

_None_

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Init | FINISHED | Wait | 0 | 0 | 0 |
| Init | DOOR | Door Wait | 0 | 0 | 0 |
| Cave Wind | FINISHED | Surface Wind | 0 | 0 | 0 |
| Cave Wind | OFF | Surface Wind | 0 | 0 | 0 |
| Wait | TRIGGER | Music | 0 | 0 | 0 |
| Pause Frame | FINISHED | Init | 0 | 0 | 0 |
| Surface Wind | FINISHED | Surface Wind C | 0 | 0 | 0 |
| Surface Wind | OFF | Surface Wind C | 0 | 0 | 0 |
| Surface Wind C | FINISHED |  | 0 | 0 | 0 |
| Surface Wind C | OFF |  | 0 | 0 | 0 |
| Music | FINISHED | Cave Wind | 0 | 0 | 0 |
| Music | OFF | Cave Wind | 0 | 0 | 0 |
| Door Wait | DOOR ENTERED | Music | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| DOOR | false |
| DOOR ENTERED | false |
| OFF | false |
| TRIGGER | false |

