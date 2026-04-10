# Prompt Control

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Prompt Control |
| GameObject Name | Arrow Prompt |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Pause |
| FSM PathId | 22014 |
| GameObject PathId | 6130 |

## Variables

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| Prompt Name |  | String:  |

### Colors

| Name | Value | Raw/Type |
| --- | --- | --- |
| New Colour | Color(1, 1, 1, 0) | UnityColor: Color(1, 1, 1, 0) |
| Prev Colour | Color(1, 1, 1, 0) | UnityColor: Color(1, 1, 1, 0) |
| Shad Colour | Color(0, 0, 0, 0) | UnityColor: Color(0, 0, 0, 0) |
| Shad Colour Prev | Color(0, 0, 0, 0) | UnityColor: Color(0, 0, 0, 0) |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Labels Folder | [null] | NamedAssetPPtr:  |
| Self | [null] | NamedAssetPPtr:  |
| Shadow | [null] | NamedAssetPPtr:  |
| Text | [null] | NamedAssetPPtr:  |

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

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Shadow" | "Shadow" |  |  |
| storeResult | GameObject Shadow | GameObject Shadow | Variable |  |

##### 3. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Blank" | "Blank" |  |  |

### Go Up

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. FadeGroupUp

Full Name: FadeGroupUp
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault Labels Folder | OwnerDefault Labels Folder | Variable |  |

##### 2. SetSpriteRenderer

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Shadow | OwnerDefault Shadow |  |  |
| active | true | true |  |  |

##### 3. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| clipName | "Up" | "Up" |  |  |
| animationTriggerEvent | Event() | Event() |  |  |
| animationCompleteEvent | Event() | Event() |  |  |

### Up

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

_None_

### Go Down

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. FadeGroupDown

Full Name: FadeGroupDown
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault Labels Folder | OwnerDefault Labels Folder | Variable |  |
| fast | false | false |  |  |

##### 2. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| clipName | "Down" | "Down" |  |  |
| animationTriggerEvent | Event() | Event() |  |  |
| animationCompleteEvent | Event(FINISHED) | Event(FINISHED) |  |  |

### Select Text

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
| childName | "Labels" | "Labels" |  |  |
| storeResult | GameObject Labels Folder | GameObject Labels Folder | Variable |  |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Labels Folder | OwnerDefault Labels Folder |  |  |
| childName | string Prompt Name | string Prompt Name |  |  |
| storeResult | GameObject Text | GameObject Text | Variable |  |

##### 3. ActivateAllChildren

Full Name: HutongGames.PlayMaker.Actions.ActivateAllChildren
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Labels Folder | GameObject Labels Folder | Variable |  |
| activate | false | false |  |  |

##### 4. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Text | OwnerDefault Text |  |  |
| activate | true | true |  |  |
| recursive | true | true |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

### Change Label

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Labels Folder | OwnerDefault Labels Folder |  |  |
| childName | string Prompt Name | string Prompt Name |  |  |
| storeResult | GameObject Text | GameObject Text | Variable |  |

##### 2. ActivateAllChildren

Full Name: HutongGames.PlayMaker.Actions.ActivateAllChildren
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Labels Folder | GameObject Labels Folder | Variable |  |
| activate | false | false |  |  |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Text | OwnerDefault Text |  |  |
| activate | true | true |  |  |
| recursive | true | true |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 4. GotoPreviousState

Full Name: HutongGames.PlayMaker.Actions.GotoPreviousState
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

### Down

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

_None_

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

##### 2. SetSpriteRenderer

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Shadow | OwnerDefault Shadow |  |  |
| active | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Init | UP | Go Up | 0 | 0 | 0 |
| Go Up | FINISHED | Up | 0 | 0 | 0 |
| Go Up | DOWN | Go Down | 0 | 0 | 0 |
| Go Up | ARROW DOWN | Go Down | 0 | 0 | 0 |
| Up | DOWN | Go Down | 0 | 0 | 0 |
| Up | ARROW DOWN | Go Down | 0 | 0 | 0 |
| Go Down | UP | Go Up | 0 | 0 | 0 |
| Go Down | FINISHED | Down | 0 | 0 | 0 |
| Select Text | FINISHED | Init | 0 | 0 | 0 |
| Down | UP | Go Up | 0 | 0 | 0 |
| Pause | FINISHED | Select Text | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| CHANGE LABEL | Change Label | 0 | 0 | 0 |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| ARROW DOWN | false |
| CHANGE LABEL | false |
| DOWN | false |
| LEAVING SCENE | false |
| UP | false |

