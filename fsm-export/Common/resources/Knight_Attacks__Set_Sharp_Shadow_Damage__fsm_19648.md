# Set Sharp Shadow Damage

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Set Sharp Shadow Damage |
| GameObject Name | Attacks |
| GameObject Path | Knight |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Init |
| FSM PathId | 19648 |
| GameObject PathId | 4748 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Nail Damage Float | 0 | Single: 0 |

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Base | 5 | Int32: 5 |
| Dashmaster | 10 | Int32: 10 |
| nailDamage | 0 | Int32: 0 |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Sharp Shadow | [null] | NamedAssetPPtr:  |

## States

### Init

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
| childName | "Sharp Shadow" | "Sharp Shadow" |  |  |
| storeResult | GameObject Sharp Shadow | GameObject Sharp Shadow | Variable |  |

### Check

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "nailDamage" | "nailDamage" |  |  |
| storeValue | int nailDamage | int nailDamage | Variable |  |

##### 2. ConvertIntToFloat

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int nailDamage | int nailDamage | Variable |  |
| floatVariable | float Nail Damage Float | float Nail Damage Float | Variable |  |
| everyFrame | false | false |  |  |

##### 3. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "equippedCharm_31" | "equippedCharm_31" |  |  |
| isTrue | Event(MASTER) | Event(MASTER) |  |  |
| isFalse | Event(BASE) | Event(BASE) |  |  |

### Base

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Sharp Shadow | OwnerDefault Sharp Shadow |  |  |
| fsmName | "damages_enemy" | "damages_enemy" | FsmName |  |
| variableName | "damageDealt" | "damageDealt" | FsmInt |  |
| setValue | int Base | int Base |  |  |
| everyFrame | false | false |  |  |

### Master

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Sharp Shadow | OwnerDefault Sharp Shadow |  |  |
| fsmName | "damages_enemy" | "damages_enemy" | FsmName |  |
| variableName | "damageDealt" | "damageDealt" | FsmInt |  |
| setValue | int Dashmaster | int Dashmaster |  |  |
| everyFrame | false | false |  |  |

##### 2. FloatMultiplyV2

Full Name: HutongGames.PlayMaker.Actions.FloatMultiplyV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Nail Damage Float | float Nail Damage Float | Variable |  |
| multiplyBy | 1.5f | 1.5f |  |  |
| everyFrame | false | false |  |  |
| fixedUpdate | false | false |  |  |

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

_None_

### Set

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. ConvertFloatToInt

Full Name: HutongGames.PlayMaker.Actions.ConvertFloatToInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Nail Damage Float | float Nail Damage Float | Variable |  |
| intVariable | int nailDamage | int nailDamage | Variable |  |
| rounding | HutongGames.PlayMaker.Actions.ConvertFloatToInt/FloatRounding::Nearest | 2 |  |  |
| everyFrame | false | false |  |  |

##### 2. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Sharp Shadow | OwnerDefault Sharp Shadow |  |  |
| fsmName | "damages_enemy" | "damages_enemy" | FsmName |  |
| variableName | "damageDealt" | "damageDealt" | FsmInt |  |
| setValue | int nailDamage | int nailDamage |  |  |
| everyFrame | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Init | FINISHED | Check | 0 | 0 | 0 |
| Check | BASE | Base | 0 | 0 | 0 |
| Check | MASTER | Master | 0 | 0 | 0 |
| Base | FINISHED | Set | 0 | 0 | 0 |
| Master | FINISHED | Set | 0 | 0 | 0 |
| Idle | CHARM INDICATOR CHECK | Check | 0 | 0 | 0 |
| Set | FINISHED | Idle | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| BASE | false |
| CHARM INDICATOR CHECK | false |
| MASTER | false |

