# FSM

## Summary

| Field | Value |
| --- | --- |
| FSM Name | FSM |
| GameObject Name | left1 |
| GameObject Path | _Transition Gates/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level58 |
| Start State | Pause Frame |
| FSM PathId | 5108 |
| GameObject PathId | 596 |

## Variables

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Cave Wind | false | Boolean: false |
| Fade Music | true | Boolean: true |
| Surface Wind | false | Boolean: false |
| Surface Wind C | false | Boolean: false |
| _Is Door | false | Boolean: false |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Atmos Cave Wind | [null] | NamedAssetPPtr: [null] |
| Atmos Folder | [null] | NamedAssetPPtr: [null] |
| Atmos Surface Wind | [null] | NamedAssetPPtr: [null] |
| Atmos Surface Wind C | [null] | NamedAssetPPtr: [null] |
| Music Folder | [null] | NamedAssetPPtr: [null] |
| Track 1 | [null] | NamedAssetPPtr: [null] |

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
| boolVariable |   | bool _Is Door | Variable |   |
| isTrue |   | Event(DOOR) |   |   |
| isFalse |   | Event(FINISHED) |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Wait | 0 | |
| DOOR | Door Wait | 0 | |

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
| boolVariable |   | bool Cave Wind | Variable |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(OFF) |   |   |
| everyFrame |   | false |   |   |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Atmos |   |   |
| childName |   | "Atmos Cave Wind" |   |   |
| storeResult |   | GameObject Atmos Cave Wind | Variable |   |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObjectFSM)[SendToFSM: Atmos Control]:Atmos Cave Wind |   |   |
| sendEvent |   | "STOP" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Surface Wind | 0 | |
| OFF | Surface Wind | 0 | |

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
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerEnter2D | 0 |   |   |
| collideTag |   | "Player" | Tag |   |
| collideLayer |   | 0 | Layer |   |
| sendEvent |   | Event(TRIGGER) |   |   |
| storeCollider |   |   | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| TRIGGER | Music | 0 | |

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
| sendEvent |   | Event(FINISHED) |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Init | 0 | |

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
| boolVariable |   | bool Surface Wind | Variable |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(OFF) |   |   |
| everyFrame |   | false |   |   |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Atmos |   |   |
| childName |   | "Atmos Surface Wind" |   |   |
| storeResult |   | GameObject Atmos Surface Wind | Variable |   |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObjectFSM)[SendToFSM: Atmos Control]:Atmos Surface Wind |   |   |
| sendEvent |   | "STOP" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Surface Wind C | 0 | |
| OFF | Surface Wind C | 0 | |

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
| boolVariable |   | bool Surface Wind C | Variable |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(OFF) |   |   |
| everyFrame |   | false |   |   |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Atmos |   |   |
| childName |   | "Atmos Surface Wind C" |   |   |
| storeResult |   | GameObject Atmos Surface Wind C | Variable |   |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObjectFSM)[SendToFSM: Atmos Control]:Atmos Surface Wind C |   |   |
| sendEvent |   | "STOP" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED |   | 0 | |
| OFF |   | 0 | |

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
| boolVariable |   | bool Fade Music | Variable |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(OFF) |   |   |
| everyFrame |   | false |   |   |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| childName |   | "Music" |   |   |
| storeResult |   | GameObject Music Folder | Variable |   |

##### 3. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Music Folder |   |   |
| childName |   | "Track 1" |   |   |
| storeResult |   | GameObject Track 1 | Variable |   |

##### 4. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Track 1 |   |   |
| fsmName |   | "Music Player" | FsmName |   |
| variableName |   | "Fade Vol End" | FsmFloat |   |
| setValue |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 5. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Track 1 |   |   |
| fsmName |   | "Music Player" | FsmName |   |
| variableName |   | "Fade Time" | FsmFloat |   |
| setValue |   | 0.3f |   |   |
| everyFrame |   | false |   |   |

##### 6. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Track 1 |   |   |
| sendEvent |   | "FADE" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Cave Wind | 0 | |
| OFF | Cave Wind | 0 | |

### Door Wait

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

(none)

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| DOOR ENTERED | Music | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| DOOR | false |
| DOOR ENTERED | false |
| FINISHED | false |
| OFF | false |
| TRIGGER | false |

