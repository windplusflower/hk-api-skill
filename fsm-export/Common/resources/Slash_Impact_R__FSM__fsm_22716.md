# FSM

## Summary

| Field | Value |
| --- | --- |
| FSM Name | FSM |
| GameObject Name | Slash Impact R |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Choose Anim |
| FSM PathId | 22716 |
| GameObject PathId | 3985 |

## Variables

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Chooser | false | Boolean: false |

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| Anim |  | String:  |

## States

### Choose Anim

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Chooser | bool Chooser | Variable |  |
| isTrue | Event(TRUE) | Event(TRUE) |  |  |
| isFalse | Event(FALSE) | Event(FALSE) |  |  |
| everyFrame | false | false |  |  |

##### 2. RandomBool

Full Name: HutongGames.PlayMaker.Actions.RandomBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeResult | bool Chooser | bool Chooser | Variable |  |

### Anim 1

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Anim | string Anim | Variable |  |
| stringValue | "Slash Impact 1 " | "Slash Impact 1 " | TextArea |  |
| everyFrame | false | false |  |  |

### Anim 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Anim | string Anim | Variable |  |
| stringValue | "Slash Impact 2" | "Slash Impact 2" | TextArea |  |
| everyFrame | false | false |  |  |

### Anim

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| clipName | string Anim | string Anim |  |  |
| animationTriggerEvent | Event() | Event() |  |  |
| animationCompleteEvent | Event(FINISHED) | Event(FINISHED) |  |  |

##### 2. Tk2dPlayFrame

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayFrame
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| frame | 0 | 0 |  |  |

##### 3. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.17f | 0.17f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Recycle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. RecycleSelf

Full Name: HutongGames.PlayMaker.Actions.RecycleSelf
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

### Reset

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
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 1f | 1f |  |  |
| y | 1f | 1f |  |  |
| z | 0f | 0f |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

### Dormant

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

_None_

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Choose Anim | TRUE | Anim 1 | 0 | 0 | 0 |
| Choose Anim | FALSE | Anim 2 | 0 | 0 | 0 |
| Anim 1 | FINISHED | Anim | 0 | 0 | 0 |
| Anim 2 | FINISHED | Anim | 0 | 0 | 0 |
| Anim | FINISHED | Recycle | 0 | 0 | 0 |
| Reset | FINISHED | Dormant | 0 | 0 | 0 |
| Dormant | A SPAWN | Anim | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| A RECYCLE | Reset | 0 | 0 | 0 |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| FALSE | false |
| TRUE | false |
| A SPAWN | false |
| A RECYCLE | false |

