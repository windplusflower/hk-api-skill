# Detect Hit

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Detect Hit |
| GameObject Name | Wake Box |
| GameObject Path | Moss Knight |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets159.assets |
| Start State | Init |
| FSM PathId | 149 |
| GameObject PathId | 51 |

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
| Damager | [null] | NamedAssetPPtr:  |
| Parent | [null] | NamedAssetPPtr:  |

## States

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

_None_

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
| collideTag | "Nail Attack" | "Nail Attack" | Tag |  |
| sendEvent | Event(HIT) | Event(HIT) |  |  |
| fsmName | "damages_enemy" | "damages_enemy" |  |  |
| storeGameObject | GameObject Damager | GameObject Damager | Variable |  |
| ignoreAcid | false | false |  |  |
| ignoreWater | false | false |  |  |

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
| boolVariable | bool Start Battle | bool Start Battle | Variable |  |
| isTrue | Event(BATTLE) | Event(BATTLE) |  |  |
| isFalse | Event(WAKE) | Event(WAKE) |  |  |
| everyFrame | false | false |  |  |

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
| eventTarget | EventTarget(BroadcastAll):FSM Owner | EventTarget(BroadcastAll):FSM Owner |  |  |
| sendEvent | "BATTLE EARLY START" | "BATTLE EARLY START" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

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
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| storeResult | GameObject Parent | GameObject Parent | Variable |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Parent | EventTarget(GameObject):Parent |  |  |
| sendEvent | "WAKE" | "WAKE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

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
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| target | [Global] GameObject Hero | [Global] GameObject Hero |  |  |
| storeResult | float Distance | float Distance | Variable |  |
| everyFrame | false | false |  |  |

##### 2. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float Distance | float Distance |  |  |
| float2 | 8f | 8f |  |  |
| tolerance | 0f | 0f |  |  |
| equal | Event(FINISHED) | Event(FINISHED) |  |  |
| lessThan | Event(FINISHED) | Event(FINISHED) |  |  |
| greaterThan | Event(CANCEL) | Event(CANCEL) |  |  |
| everyFrame | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Init | FINISHED | Idle | 0 | 0 | 0 |
| Idle | TAKE DAMAGE | Distance Check | 0 | 0 | 0 |
| Battle? | BATTLE | Send Event | 0 | 0 | 0 |
| Battle? | WAKE | Wake | 0 | 0 | 0 |
| Distance Check | FINISHED | Battle? | 0 | 0 | 0 |
| Distance Check | CANCEL | Idle | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| BATTLE | false |
| CANCEL | false |
| TAKE DAMAGE | false |
| WAKE | true |

