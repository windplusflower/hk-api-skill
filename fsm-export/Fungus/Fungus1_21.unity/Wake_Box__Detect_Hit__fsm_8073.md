# Detect Hit

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Detect Hit |
| GameObject Name | Wake Box |
| GameObject Path | Battle Scene/Moss Knight/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level149 |
| Start State | Init |
| FSM PathId | 8073 |
| GameObject PathId | 1835 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Distance | 0 | Single: 0 |

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Damage Dealt | 0 | Int32: 0 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Start Battle | false | Boolean: false |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Damager | [null] | NamedAssetPPtr: [null] |
| Parent | [null] | NamedAssetPPtr: [null] |

## States

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

(none)

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Idle | 0 | |

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. ReceivedDamage

Full Name: HutongGames.PlayMaker.Actions.ReceivedDamage
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| collideTag |   | "Nail Attack" | Tag |   |
| sendEvent |   | Event(HIT) |   |   |
| fsmName |   | "damages_enemy" |   |   |
| storeGameObject |   | GameObject Damager | Variable |   |
| ignoreAcid |   | false |   |   |
| ignoreWater |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| TAKE DAMAGE | Distance Check | 0 | |

### Battle?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Start Battle | Variable |   |
| isTrue |   | Event(BATTLE) |   |   |
| isFalse |   | Event(WAKE) |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| BATTLE | Send Event | 0 | |
| WAKE | Wake | 0 | |

### Send Event

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(BroadcastAll):FSM Owner |   |   |
| sendEvent |   | "BATTLE EARLY START" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

(none)

### Wake

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. GetParent

Full Name: HutongGames.PlayMaker.Actions.GetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| storeResult |   | GameObject Parent | Variable |   |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Parent |   |   |
| sendEvent |   | "WAKE" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

(none)

### Distance Check

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GetXDistance

Full Name: HutongGames.PlayMaker.Actions.GetXDistance
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| target |   | [Global] GameObject Hero |   |   |
| storeResult |   | float Distance | Variable |   |
| everyFrame |   | false |   |   |

##### 2. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 |   | float Distance |   |   |
| float2 |   | 8f |   |   |
| tolerance |   | 0f |   |   |
| equal |   | Event(FINISHED) |   |   |
| lessThan |   | Event(FINISHED) |   |   |
| greaterThan |   | Event(CANCEL) |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Battle? | 0 | |
| CANCEL | Idle | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| BATTLE | false |
| CANCEL | false |
| FINISHED | false |
| TAKE DAMAGE | false |
| WAKE | true |

