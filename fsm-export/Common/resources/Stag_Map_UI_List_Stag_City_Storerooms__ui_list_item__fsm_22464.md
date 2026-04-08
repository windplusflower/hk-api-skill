# ui_list_item

## Summary

| Field | Value |
| --- | --- |
| FSM Name | ui_list_item |
| GameObject Name | City Storerooms |
| GameObject Path | Stag Map/UI List Stag |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Pause |
| FSM PathId | 22464 |
| GameObject PathId | 7081 |

## Variables

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Current Item | 0 | Int32: 0 |
| Item Number | 6 | Int32: 6 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Selected | false | Boolean: false |
| Unselectable | false | Boolean: false |

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| Selection Name | City Storerooms | String: City Storerooms |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Chosen Effects | [null] | NamedAssetPPtr:  |
| Glow | [null] | NamedAssetPPtr:  |
| List | [null] | NamedAssetPPtr:  |
| Pointer L | [null] | NamedAssetPPtr:  |
| Pointer R | [null] | NamedAssetPPtr:  |
| Self | [null] | NamedAssetPPtr:  |

## States

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GetOwner

Full Name: HutongGames.PlayMaker.Actions.GetOwner
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeGameObject | GameObject Self | GameObject Self | Variable |  |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| childName | "Chosen" | "Chosen" |  |  |
| storeResult | GameObject Chosen Effects | GameObject Chosen Effects | Variable |  |

##### 3. GetParent

Full Name: HutongGames.PlayMaker.Actions.GetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| storeResult | GameObject List | GameObject List | Variable |  |

##### 4. GetFsmInt

Full Name: HutongGames.PlayMaker.Actions.GetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault List | OwnerDefault List |  |  |
| fsmName | "ui_list" | "ui_list" | FsmName |  |
| variableName | "Current Item" | "Current Item" | FsmInt |  |
| storeValue | int Current Item | int Current Item | Variable |  |
| everyFrame | false | false |  |  |

##### 5. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Current Item | int Current Item |  |  |
| integer2 | int Item Number | int Item Number |  |  |
| equal | Event(GET SELECTED) | Event(GET SELECTED) |  |  |
| lessThan | Event(GET UNSELECTED) | Event(GET UNSELECTED) |  |  |
| greaterThan | Event(GET UNSELECTED) | Event(GET UNSELECTED) |  |  |
| everyFrame | false | false |  |  |

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

_None_

### Selected

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault List | OwnerDefault List |  |  |
| fsmName | "ui_list" | "ui_list" | FsmName |  |
| variableName | "Current Selection" | "Current Selection" | FsmString |  |
| setValue | string Selection Name | string Selection Name |  |  |
| everyFrame | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(BroadcastAll):FSM Owner | EventTarget(BroadcastAll):FSM Owner |  |  |
| sendEvent | string Selection Name | string Selection Name |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Selected | bool Selected | Variable |  |
| boolValue | true | true |  |  |
| everyFrame | false | false |  |  |

##### 4. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:Self | EventTarget(GameObject)[SendToChildren]:Self |  |  |
| sendEvent | "SELECTED" | "SELECTED" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Unselected

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Selected | bool Selected | Variable |  |
| boolValue | false | false |  |  |
| everyFrame | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:Self | EventTarget(GameObject)[SendToChildren]:Self |  |  |
| sendEvent | "UNSELECTED" | "UNSELECTED" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Check

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GetFsmInt

Full Name: HutongGames.PlayMaker.Actions.GetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault List | OwnerDefault List |  |  |
| fsmName | "ui_list" | "ui_list" | FsmName |  |
| variableName | "Current Item" | "Current Item" | FsmInt |  |
| storeValue | int Current Item | int Current Item | Variable |  |
| everyFrame | false | false |  |  |

##### 2. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Current Item | int Current Item |  |  |
| integer2 | int Item Number | int Item Number |  |  |
| equal | Event(GET SELECTED) | Event(GET SELECTED) |  |  |
| lessThan | Event(GET UNSELECTED) | Event(GET UNSELECTED) |  |  |
| greaterThan | Event(GET UNSELECTED) | Event(GET UNSELECTED) |  |  |
| everyFrame | false | false |  |  |

### Selection Made

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GetFsmInt

Full Name: HutongGames.PlayMaker.Actions.GetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault List | OwnerDefault List |  |  |
| fsmName | "ui_list" | "ui_list" | FsmName |  |
| variableName | "Current Item" | "Current Item" | FsmInt |  |
| storeValue | int Current Item | int Current Item | Variable |  |
| everyFrame | false | false |  |  |

##### 2. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Current Item | int Current Item |  |  |
| integer2 | int Item Number | int Item Number |  |  |
| equal | Event(GET SELECTED) | Event(GET SELECTED) |  |  |
| lessThan | Event(GET UNSELECTED) | Event(GET UNSELECTED) |  |  |
| greaterThan | Event(GET UNSELECTED) | Event(GET UNSELECTED) |  |  |
| everyFrame | false | false |  |  |

### Chosen

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault List | OwnerDefault List |  |  |
| fsmName | "ui_list" | "ui_list" | FsmName |  |
| variableName | "Selected Unselectable" | "Selected Unselectable" | FsmBool |  |
| setValue | false | false |  |  |
| everyFrame | false | false |  |  |

##### 2. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault List | OwnerDefault List |  |  |
| fsmName | "ui_list" | "ui_list" | FsmName |  |
| variableName | "Current Selection" | "Current Selection" | FsmString |  |
| setValue | string Selection Name | string Selection Name |  |  |
| everyFrame | false | false |  |  |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Chosen Effects | OwnerDefault Chosen Effects |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 4. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:Self | EventTarget(GameObject)[SendToChildren]:Self |  |  |
| sendEvent | "CHOSEN" | "CHOSEN" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 5. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.35f | 0.35f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Selected?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Selected | bool Selected | Variable |  |
| isTrue | Event(FINISHED) | Event(FINISHED) |  |  |
| isFalse | Event(GET SELECTED) | Event(GET SELECTED) |  |  |
| everyFrame | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:Self | EventTarget(GameObject)[SendToChildren]:Self |  |  |
| sendEvent | "SELECTED" | "SELECTED" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Unselectable?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GetFsmBool

Full Name: HutongGames.PlayMaker.Actions.GetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| fsmName | "Enough Geo" | "Enough Geo" | FsmName |  |
| variableName | "Unselectable" | "Unselectable" | FsmBool |  |
| storeValue | bool Unselectable | bool Unselectable | Variable |  |
| everyFrame | false | false |  |  |

##### 2. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Unselectable | bool Unselectable | Variable |  |
| isTrue | Event(GET UNSELECTED) | Event(GET UNSELECTED) |  |  |
| isFalse | Event(GET SELECTED) | Event(GET SELECTED) |  |  |
| everyFrame | false | false |  |  |

### Chosen but Unselectable

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player UI (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player UI (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [sword_hit_reject (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [sword_hit_reject (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| pitchMin | 1.25f | 1.25f |  |  |
| pitchMax | 1.25f | 1.25f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 2. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player UI (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player UI (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [sword_hit_reject (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [sword_hit_reject (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| pitchMin | 0.85f | 0.85f |  |  |
| pitchMax | 0.85f | 0.85f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 3. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault List | OwnerDefault List |  |  |
| fsmName | "ui_list" | "ui_list" | FsmName |  |
| variableName | "Selected Unselectable" | "Selected Unselectable" | FsmBool |  |
| setValue | true | true |  |  |
| everyFrame | false | false |  |  |

##### 4. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:Self | EventTarget(GameObject)[SendToChildren]:Self |  |  |
| sendEvent | "CHOSEN UNSELECTABLE" | "CHOSEN UNSELECTABLE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Pause

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Chosen Effects | OwnerDefault Chosen Effects |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 2. NextFrameEvent

Full Name: HutongGames.PlayMaker.Actions.NextFrameEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent | Event(FINISHED) | Event(FINISHED) |  |  |

### Remove Selection

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:Self | EventTarget(GameObject)[SendToChildren]:Self |  |  |
| sendEvent | "UNSELECTED" | "UNSELECTED" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Selection Made Cancel

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GetFsmInt

Full Name: HutongGames.PlayMaker.Actions.GetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault List | OwnerDefault List |  |  |
| fsmName | "ui_list" | "ui_list" | FsmName |  |
| variableName | "Current Item" | "Current Item" | FsmInt |  |
| storeValue | int Current Item | int Current Item | Variable |  |
| everyFrame | false | false |  |  |

##### 2. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Current Item | int Current Item |  |  |
| integer2 | int Item Number | int Item Number |  |  |
| equal | Event(GET SELECTED) | Event(GET SELECTED) |  |  |
| lessThan | Event(GET UNSELECTED) | Event(GET UNSELECTED) |  |  |
| greaterThan | Event(GET UNSELECTED) | Event(GET UNSELECTED) |  |  |
| everyFrame | false | false |  |  |

### Chosen 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault List | OwnerDefault List |  |  |
| fsmName | "ui_list" | "ui_list" | FsmName |  |
| variableName | "Selected Unselectable" | "Selected Unselectable" | FsmBool |  |
| setValue | false | false |  |  |
| everyFrame | false | false |  |  |

##### 2. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault List | OwnerDefault List |  |  |
| fsmName | "ui_list" | "ui_list" | FsmName |  |
| variableName | "Current Selection" | "Current Selection" | FsmString |  |
| setValue | string Selection Name | string Selection Name |  |  |
| everyFrame | false | false |  |  |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Chosen Effects | OwnerDefault Chosen Effects |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 4. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:Self | EventTarget(GameObject)[SendToChildren]:Self |  |  |
| sendEvent | "CHOSEN" | "CHOSEN" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 5. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.35f | 0.35f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

##### 6. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:Self | EventTarget(GameObject)[SendToChildren]:Self |  |  |
| sendEvent | "UNSELECTED" | "UNSELECTED" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Init | GET UNSELECTED | Unselected | 0 | 0 | 0 |
| Init | GET SELECTED | Selected | 0 | 0 | 0 |
| Idle | SELECT UPDATE | Check | 0 | 0 | 0 |
| Selected | FINISHED | Idle | 0 | 0 | 0 |
| Unselected | FINISHED | Idle | 0 | 0 | 0 |
| Check | GET SELECTED | Selected | 0 | 0 | 0 |
| Check | GET UNSELECTED | Unselected | 0 | 0 | 0 |
| Selection Made | GET SELECTED | Selected? | 0 | 0 | 0 |
| Selection Made | GET UNSELECTED | Unselected | 0 | 0 | 0 |
| Chosen | FINISHED | Remove Selection | 0 | 0 | 0 |
| Selected? | FINISHED | Unselectable? | 0 | 0 | 0 |
| Unselectable? | GET SELECTED | Chosen | 0 | 0 | 0 |
| Unselectable? | GET UNSELECTED | Chosen but Unselectable | 0 | 0 | 0 |
| Chosen but Unselectable | FINISHED | Idle | 0 | 0 | 0 |
| Pause | FINISHED | Init | 0 | 0 | 0 |
| Selection Made Cancel | GET UNSELECTED | Unselected | 0 | 0 | 0 |
| Selection Made Cancel | GET SELECTED | Chosen 2 | 0 | 0 | 0 |
| Chosen 2 | FINISHED |  | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| SELECTION MADE | Selection Made | 0 | 0 | 0 |
| SELECTION MADE CANCEL | Selection Made Cancel | 0 | 0 | 0 |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| GET SELECTED | false |
| GET UNSELECTED | false |
| SELECT UPDATE | false |
| SELECTION MADE | false |
| SELECTION MADE CANCEL | false |

