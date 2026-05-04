# Detect Hero

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Detect Hero |
| GameObject Name | Call Range |
| GameObject Path | _NPCs/Elderbug/Ranges/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level7 |
| Start State | Init |
| FSM PathId | 4046 |
| GameObject PathId | 973 |

## Variables

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Elderbug State | 0 | Int32: 0 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Met Elderbug | false | Boolean: false |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Elderbug | [null] | NamedAssetPPtr: [null] |
| Light | [null] | NamedAssetPPtr: [null] |
| Lit | [null] | NamedAssetPPtr: [null] |
| Parent | [null] | NamedAssetPPtr: [null] |
| Particle B | [null] | NamedAssetPPtr: [null] |
| Particle F | [null] | NamedAssetPPtr: [null] |

## States

### Out

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Elderbug |   |   |
| sendEvent |   | "EXIT RANGE" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 2. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| intName |   | "elderbug" |   |   |
| storeValue |   | int Elderbug State | Variable |   |

##### 3. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Elderbug State |   |   |
| integer2 |   | 1 |   |   |
| equal |   | Event() |   |   |
| lessThan |   | Event() |   |   |
| greaterThan |   | Event(CANCEL) |   |   |
| everyFrame |   | false |   |   |

##### 4. GetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName |   | "metElderbug" |   |   |
| storeValue |   | bool Met Elderbug | Variable |   |

##### 5. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Met Elderbug | Variable |   |
| isTrue |   | Event(CANCEL) |   |   |
| isFalse |   | Event() |   |   |
| everyFrame |   | false |   |   |

##### 6. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Elderbug |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "Reach To Idle" |   |   |

##### 7. Trigger2dEvent

Full Name: HutongGames.PlayMaker.Actions.Trigger2dEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerStay2D | 1 |   |   |
| collideTag |   | "" | Tag |   |
| collideLayer |   | "" | Layer |   |
| sendEvent |   | Event(ENTER) |   |   |
| storeCollider |   |   | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| ENTER | In | 0 | |
| CANCEL | Inert | 0 | |

### In

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| intName |   | "elderbug" |   |   |
| storeValue |   | int Elderbug State | Variable |   |

##### 2. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer |   | [Global] [Audio Player Actor (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | GameObject Elderbug |   |   |
| audioClip |   | [Elderbug_sad (AudioClip) (Hollow Knight/hollow_knight_Data\sharedassets7.assets)] |   |   |
| pitchMin |   | 1f |   |   |
| pitchMax |   | 1f |   |   |
| volume |   | 1f |   |   |
| delay |   | 0f |   |   |
| storePlayer |   |   |   |   |

##### 3. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Elderbug State |   |   |
| integer2 |   | 1 |   |   |
| equal |   | Event() |   |   |
| lessThan |   | Event() |   |   |
| greaterThan |   | Event(CANCEL) |   |   |
| everyFrame |   | false |   |   |

##### 4. SetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intName |   | "elderbug" |   |   |
| value |   | 1 |   |   |

##### 5. GetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName |   | "metElderbug" |   |   |
| storeValue |   | bool Met Elderbug | Variable |   |

##### 6. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Met Elderbug | Variable |   |
| isTrue |   | Event(CANCEL) |   |   |
| isFalse |   | Event() |   |   |
| everyFrame |   | false |   |   |

##### 7. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Elderbug |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "Reach" |   |   |

##### 8. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Elderbug |   |   |
| sendEvent |   | "ENTER RANGE" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 9. Trigger2dEvent

Full Name: HutongGames.PlayMaker.Actions.Trigger2dEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerExit2D | 2 |   |   |
| collideTag |   | "" | Tag |   |
| collideLayer |   | "" | Layer |   |
| sendEvent |   | Event(EXIT) |   |   |
| storeCollider |   |   | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| EXIT | Out | 0 | |
| CANCEL | Inert | 0 | |

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. GetParent

Full Name: HutongGames.PlayMaker.Actions.GetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| storeResult |   | GameObject Parent | Variable |   |

##### 2. GetParent

Full Name: HutongGames.PlayMaker.Actions.GetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Parent |   |   |
| storeResult |   | GameObject Elderbug | Variable |   |

##### 3. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Elderbug |   |   |
| childName |   | "Lit" |   |   |
| storeResult |   | GameObject Lit | Variable |   |

##### 4. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Elderbug |   |   |
| childName |   | "Light" |   |   |
| storeResult |   | GameObject Light | Variable |   |

##### 5. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Elderbug |   |   |
| childName |   | "Particle B" |   |   |
| storeResult |   | GameObject Particle B | Variable |   |

##### 6. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Elderbug |   |   |
| childName |   | "Particle F" |   |   |
| storeResult |   | GameObject Particle F | Variable |   |

##### 7. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| intName |   | "elderbug" |   |   |
| storeValue |   | int Elderbug State | Variable |   |

##### 8. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Elderbug State |   |   |
| integer2 |   | 1 |   |   |
| equal |   | Event() |   |   |
| lessThan |   | Event() |   |   |
| greaterThan |   | Event(CANCEL) |   |   |
| everyFrame |   | false |   |   |

##### 9. GetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName |   | "metElderbug" |   |   |
| storeValue |   | bool Met Elderbug | Variable |   |

##### 10. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Met Elderbug | Variable |   |
| isTrue |   | Event(CANCEL) |   |   |
| isFalse |   | Event() |   |   |
| everyFrame |   | false |   |   |

##### 11. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| boolName |   | "visitedCrossroads" |   |   |
| isTrue |   | Event(CANCEL) |   |   |
| isFalse |   | Event() |   |   |

##### 12. Trigger2dEvent

Full Name: HutongGames.PlayMaker.Actions.Trigger2dEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerExit2D | 2 |   |   |
| collideTag |   | "" | Tag |   |
| collideLayer |   | "" | Layer |   |
| sendEvent |   | Event(EXIT) |   |   |
| storeCollider |   |   | Variable |   |

##### 13. Trigger2dEvent

Full Name: HutongGames.PlayMaker.Actions.Trigger2dEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerStay2D | 1 |   |   |
| collideTag |   | "" | Tag |   |
| collideLayer |   | "" | Layer |   |
| sendEvent |   | Event(ENTER) |   |   |
| storeCollider |   |   | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| ENTER | In | 0 | |
| EXIT | Out | 0 | |
| CANCEL | Inert | 0 | |

### Inert

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

(none)

#### Transitions

(none)

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| CANCEL | false |
| ENTER | false |
| EXIT | false |
| FINISHED | false |

