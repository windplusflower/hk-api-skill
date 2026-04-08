# Set Slash Damage

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Set Slash Damage |
| GameObject Name | Attacks |
| GameObject Path | Knight |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Init |
| FSM PathId | 23027 |
| GameObject PathId | 4748 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Damage Float | 0 | Single: 0 |

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Beam Damage | 0 | Int32: 0 |
| Nail Damage | 0 | Int32: 0 |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| AltSlash | [null] | NamedAssetPPtr:  |
| Cyclone Hits | [null] | NamedAssetPPtr:  |
| Cyclone Slash | [null] | NamedAssetPPtr:  |
| Dash Slash | [null] | NamedAssetPPtr:  |
| DownSlash | [null] | NamedAssetPPtr:  |
| Great Slash | [null] | NamedAssetPPtr:  |
| Hit L | [null] | NamedAssetPPtr:  |
| Hit R | [null] | NamedAssetPPtr:  |
| Slash | [null] | NamedAssetPPtr:  |
| UpSlash | [null] | NamedAssetPPtr:  |
| WallSlash | [null] | NamedAssetPPtr:  |

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
| childName | "AltSlash" | "AltSlash" |  |  |
| storeResult | GameObject AltSlash | GameObject AltSlash | Variable |  |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Cyclone Slash" | "Cyclone Slash" |  |  |
| storeResult | GameObject Cyclone Slash | GameObject Cyclone Slash | Variable |  |

##### 3. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Cyclone Slash | OwnerDefault Cyclone Slash |  |  |
| childName | "Hits" | "Hits" |  |  |
| storeResult | GameObject Cyclone Hits | GameObject Cyclone Hits | Variable |  |

##### 4. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Cyclone Hits | OwnerDefault Cyclone Hits |  |  |
| childName | "Hit L" | "Hit L" |  |  |
| storeResult | GameObject Hit L | GameObject Hit L | Variable |  |

##### 5. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Cyclone Hits | OwnerDefault Cyclone Hits |  |  |
| childName | "Hit R" | "Hit R" |  |  |
| storeResult | GameObject Hit R | GameObject Hit R | Variable |  |

##### 6. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "DownSlash" | "DownSlash" |  |  |
| storeResult | GameObject DownSlash | GameObject DownSlash | Variable |  |

##### 7. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Great Slash" | "Great Slash" |  |  |
| storeResult | GameObject Great Slash | GameObject Great Slash | Variable |  |

##### 8. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Dash Slash" | "Dash Slash" |  |  |
| storeResult | GameObject Dash Slash | GameObject Dash Slash | Variable |  |

##### 9. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Slash" | "Slash" |  |  |
| storeResult | GameObject Slash | GameObject Slash | Variable |  |

##### 10. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "UpSlash" | "UpSlash" |  |  |
| storeResult | GameObject UpSlash | GameObject UpSlash | Variable |  |

##### 11. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "WallSlash" | "WallSlash" |  |  |
| storeResult | GameObject WallSlash | GameObject WallSlash | Variable |  |

##### 12. NextFrameEvent

Full Name: HutongGames.PlayMaker.Actions.NextFrameEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent | Event(FINISHED) | Event(FINISHED) |  |  |

### Set Damage

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault DownSlash | OwnerDefault DownSlash |  |  |
| fsmName | "damages_enemy" | "damages_enemy" | FsmName |  |
| variableName | "damageDealt" | "damageDealt" | FsmInt |  |
| setValue | int Nail Damage | int Nail Damage |  |  |
| everyFrame | false | false |  |  |

##### 2. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault AltSlash | OwnerDefault AltSlash |  |  |
| fsmName | "damages_enemy" | "damages_enemy" | FsmName |  |
| variableName | "damageDealt" | "damageDealt" | FsmInt |  |
| setValue | int Nail Damage | int Nail Damage |  |  |
| everyFrame | false | false |  |  |

##### 3. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Slash | OwnerDefault Slash |  |  |
| fsmName | "damages_enemy" | "damages_enemy" | FsmName |  |
| variableName | "damageDealt" | "damageDealt" | FsmInt |  |
| setValue | int Nail Damage | int Nail Damage |  |  |
| everyFrame | false | false |  |  |

##### 4. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault UpSlash | OwnerDefault UpSlash |  |  |
| fsmName | "damages_enemy" | "damages_enemy" | FsmName |  |
| variableName | "damageDealt" | "damageDealt" | FsmInt |  |
| setValue | int Nail Damage | int Nail Damage |  |  |
| everyFrame | false | false |  |  |

##### 5. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault WallSlash | OwnerDefault WallSlash |  |  |
| fsmName | "damages_enemy" | "damages_enemy" | FsmName |  |
| variableName | "damageDealt" | "damageDealt" | FsmInt |  |
| setValue | int Nail Damage | int Nail Damage |  |  |
| everyFrame | false | false |  |  |

##### 6. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hit L | OwnerDefault Hit L |  |  |
| fsmName | "damages_enemy" | "damages_enemy" | FsmName |  |
| variableName | "damageDealt" | "damageDealt" | FsmInt |  |
| setValue | int Nail Damage | int Nail Damage |  |  |
| everyFrame | false | false |  |  |

##### 7. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hit R | OwnerDefault Hit R |  |  |
| fsmName | "damages_enemy" | "damages_enemy" | FsmName |  |
| variableName | "damageDealt" | "damageDealt" | FsmInt |  |
| setValue | int Nail Damage | int Nail Damage |  |  |
| everyFrame | false | false |  |  |

##### 8. IntOperator

Full Name: HutongGames.PlayMaker.Actions.IntOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Nail Damage | int Nail Damage |  |  |
| integer2 | 2 | 2 |  |  |
| operation | HutongGames.PlayMaker.Actions.IntOperator/Operation::Multiply | 2 |  |  |
| storeResult | int Nail Damage | int Nail Damage | Variable |  |
| everyFrame | false | false |  |  |

##### 9. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Dash Slash | OwnerDefault Dash Slash |  |  |
| fsmName | "damages_enemy" | "damages_enemy" | FsmName |  |
| variableName | "damageDealt" | "damageDealt" | FsmInt |  |
| setValue | int Nail Damage | int Nail Damage |  |  |
| everyFrame | false | false |  |  |

##### 10. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Great Slash | OwnerDefault Great Slash |  |  |
| fsmName | "damages_enemy" | "damages_enemy" | FsmName |  |
| variableName | "damageDealt" | "damageDealt" | FsmInt |  |
| setValue | int Nail Damage | int Nail Damage |  |  |
| everyFrame | false | false |  |  |

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

_None_

### Get Damage

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "nailDamage" | "nailDamage" |  |  |
| storeValue | int Nail Damage | int Nail Damage | Variable |  |

##### 2. GetNailDamage

Full Name: GetNailDamage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeValue | int Nail Damage | int Nail Damage | Variable |  |

### Glass Attack Modifier

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. PlayerDataBoolTrueAndFalse

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTrueAndFalse
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| trueBool | "equippedCharm_25" | "equippedCharm_25" |  |  |
| falseBool | "brokenCharm_25" | "brokenCharm_25" |  |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(FINISHED) | Event(FINISHED) |  |  |

##### 2. ConvertIntToFloat

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Nail Damage | int Nail Damage | Variable |  |
| floatVariable | float Damage Float | float Damage Float | Variable |  |
| everyFrame | false | false |  |  |

##### 3. FloatMultiply

Full Name: HutongGames.PlayMaker.Actions.FloatMultiply
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Damage Float | float Damage Float | Variable |  |
| multiplyBy | 1.5f | 1.5f |  |  |
| everyFrame | false | false |  |  |

##### 4. ConvertFloatToInt

Full Name: HutongGames.PlayMaker.Actions.ConvertFloatToInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Damage Float | float Damage Float | Variable |  |
| intVariable | int Nail Damage | int Nail Damage | Variable |  |
| rounding | HutongGames.PlayMaker.Actions.ConvertFloatToInt/FloatRounding::Nearest | 2 |  |  |
| everyFrame | false | false |  |  |

### Set Beam Damage

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. ConvertIntToFloat

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Nail Damage | int Nail Damage | Variable |  |
| floatVariable | float Damage Float | float Damage Float | Variable |  |
| everyFrame | false | false |  |  |

##### 2. FloatOperator

Full Name: HutongGames.PlayMaker.Actions.FloatOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float Damage Float | float Damage Float |  |  |
| float2 | 0.5f | 0.5f |  |  |
| operation | HutongGames.PlayMaker.Actions.FloatOperator/Operation::Multiply | 2 |  |  |
| storeResult | float Damage Float | float Damage Float | Variable |  |
| everyFrame | false | false |  |  |

##### 3. ConvertFloatToInt

Full Name: HutongGames.PlayMaker.Actions.ConvertFloatToInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Damage Float | float Damage Float | Variable |  |
| intVariable | int Beam Damage | int Beam Damage | Variable |  |
| rounding | HutongGames.PlayMaker.Actions.ConvertFloatToInt/FloatRounding::Nearest | 2 |  |  |
| everyFrame | false | false |  |  |

##### 4. IntClamp

Full Name: HutongGames.PlayMaker.Actions.IntClamp
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Beam Damage | int Beam Damage | Variable |  |
| minValue | 1 | 1 |  |  |
| maxValue | 90 | 90 |  |  |
| everyFrame | false | false |  |  |

##### 5. SetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intName | "beamDamage" | "beamDamage" |  |  |
| value | int Beam Damage | int Beam Damage |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Init | FINISHED | Get Damage | 0 | 0 | 0 |
| Set Damage | FINISHED | Idle | 0 | 0 | 0 |
| Idle | UPDATE NAIL DAMAGE | Get Damage | 0 | 0 | 0 |
| Idle | CHARM INDICATOR CHECK | Get Damage | 0 | 0 | 0 |
| Get Damage | FINISHED | Glass Attack Modifier | 0 | 0 | 0 |
| Glass Attack Modifier | FINISHED | Set Beam Damage | 0 | 0 | 0 |
| Set Beam Damage | FINISHED | Set Damage | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| CHARM INDICATOR CHECK | false |
| UPDATE NAIL DAMAGE | false |

