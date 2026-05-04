# Battle Control

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Battle Control |
| GameObject Name | Grub Scene |
| GameObject Path |   |
| Source Asset | Hollow Knight/hollow_knight_Data/level113 |
| Start State | Pause |
| FSM PathId | 4650 |
| GameObject PathId | 294 |

## Variables

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Battle Enemies | 1 | Int32: 1 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Activated | false | Boolean: false |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Self | [null] | NamedAssetPPtr: [null] |
| Shield Zombie | [null] | NamedAssetPPtr: [null] |

## States

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
| FINISHED | Idle | 0 | |

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Battle Enemies |   |   |
| integer2 |   | 0 |   |   |
| equal |   | Event(OPEN) |   |   |
| lessThan |   | Event(OPEN) |   |   |
| greaterThan |   | Event() |   |   |
| everyFrame |   | true |   |   |

##### 2. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Activated | Variable |   |
| isTrue |   | Event(ACTIVATE) |   |   |
| isFalse |   | Event() |   |   |
| everyFrame |   | false |   |   |

##### 3. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Great Shield Zombie" |   |   |
| storeResult |   | GameObject Shield Zombie | Variable |   |

##### 4. GetOwner

Full Name: HutongGames.PlayMaker.Actions.GetOwner
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeGameObject |   | GameObject Self | Variable |   |

##### 5. SetFsmGameObject

Full Name: HutongGames.PlayMaker.Actions.SetFsmGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Shield Zombie |   |   |
| fsmName |   | "health_manager_enemy" | FsmName |   |
| variableName |   | "Battle Scene" | FsmGameObject |   |
| setValue |   | GameObject Self |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| OPEN | Open Pause | 0 | |
| ACTIVATE | Activate | 0 | |

### Open Pause

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

##### 2. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Activated | Variable |   |
| boolValue |   | true |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Open | 0 | |

### Open

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject)[SendToChildren]:FSM Owner |   |   |
| sendEvent |   | "BG OPEN" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

(none)

### Activate

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| activate |   | false |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

#### Transitions

(none)

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| ACTIVATE | false |
| FINISHED | false |
| OPEN | false |

