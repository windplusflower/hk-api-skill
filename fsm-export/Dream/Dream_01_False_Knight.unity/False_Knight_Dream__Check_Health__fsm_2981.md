# Check Health

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Check Health |
| GameObject Name | False Knight Dream |
| GameObject Path |   |
| Source Asset | Hollow Knight/hollow_knight_Data/level395 |
| Start State | Init |
| FSM PathId | 2981 |
| GameObject PathId | 761 |

## Variables

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| HP | 0 | Int32: 0 |
| Recover HP | 0 | Int32: 0 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Stun 1 | false | Boolean: false |
| Stun 2 | false | Boolean: false |

## States

### Init

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
| FINISHED | Get Health | 0 | |

### Check

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetHPEveryFrame

Full Name: GetHPEveryFrame
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target |   | OwnerDefault FSM Owner | Variable |   |
| storeValue |   | int HP | Variable |   |

##### 2. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int HP |   |   |
| integer2 |   | 0 |   |   |
| equal |   | Event(STUN) |   |   |
| lessThan |   | Event(STUN) |   |   |
| greaterThan |   | Event() |   |   |
| everyFrame |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| STUN | Stun | 0 | |

### Stun

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObjectFSM)[SendToFSM: FalseyControl]:FSM Owner |   |   |
| sendEvent |   | "STUN" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 2. GetHP

Full Name: GetHP
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target |   | OwnerDefault FSM Owner | Variable |   |
| storeValue |   | int HP | Variable |   |

##### 3. SetHP

Full Name: SetHP
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target |   | OwnerDefault FSM Owner | Variable |   |
| hp |   | int Recover HP |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Check | 0 | |

### Get Health

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetHP

Full Name: GetHP
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target |   | OwnerDefault FSM Owner | Variable |   |
| storeValue |   | int Recover HP | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Check | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| STUN | false |

