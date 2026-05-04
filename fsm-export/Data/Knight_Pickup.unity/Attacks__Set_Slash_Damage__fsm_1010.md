# Set Slash Damage

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Set Slash Damage |
| GameObject Name | Attacks |
| GameObject Path | Knight/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level4 |
| Start State | Init |
| FSM PathId | 1010 |
| GameObject PathId | 126 |

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
| AltSlash | [null] | NamedAssetPPtr: [null] |
| Cyclone Hits | [null] | NamedAssetPPtr: [null] |
| Cyclone Slash | [null] | NamedAssetPPtr: [null] |
| Dash Slash | [null] | NamedAssetPPtr: [null] |
| DownSlash | [null] | NamedAssetPPtr: [null] |
| Great Slash | [null] | NamedAssetPPtr: [null] |
| Hit L | [null] | NamedAssetPPtr: [null] |
| Hit R | [null] | NamedAssetPPtr: [null] |
| Slash | [null] | NamedAssetPPtr: [null] |
| UpSlash | [null] | NamedAssetPPtr: [null] |
| WallSlash | [null] | NamedAssetPPtr: [null] |

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
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "AltSlash" |   |   |
| storeResult |   | GameObject AltSlash | Variable |   |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Cyclone Slash" |   |   |
| storeResult |   | GameObject Cyclone Slash | Variable |   |

##### 3. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Cyclone Slash |   |   |
| childName |   | "Hits" |   |   |
| storeResult |   | GameObject Cyclone Hits | Variable |   |

##### 4. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Cyclone Hits |   |   |
| childName |   | "Hit L" |   |   |
| storeResult |   | GameObject Hit L | Variable |   |

##### 5. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Cyclone Hits |   |   |
| childName |   | "Hit R" |   |   |
| storeResult |   | GameObject Hit R | Variable |   |

##### 6. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "DownSlash" |   |   |
| storeResult |   | GameObject DownSlash | Variable |   |

##### 7. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Great Slash" |   |   |
| storeResult |   | GameObject Great Slash | Variable |   |

##### 8. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Dash Slash" |   |   |
| storeResult |   | GameObject Dash Slash | Variable |   |

##### 9. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Slash" |   |   |
| storeResult |   | GameObject Slash | Variable |   |

##### 10. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "UpSlash" |   |   |
| storeResult |   | GameObject UpSlash | Variable |   |

##### 11. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "WallSlash" |   |   |
| storeResult |   | GameObject WallSlash | Variable |   |

##### 12. NextFrameEvent

Full Name: HutongGames.PlayMaker.Actions.NextFrameEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent |   | Event(FINISHED) |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Get Damage | 0 | |

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
| gameObject |   | OwnerDefault DownSlash |   |   |
| fsmName |   | "damages_enemy" | FsmName |   |
| variableName |   | "damageDealt" | FsmInt |   |
| setValue |   | int Nail Damage |   |   |
| everyFrame |   | false |   |   |

##### 2. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault AltSlash |   |   |
| fsmName |   | "damages_enemy" | FsmName |   |
| variableName |   | "damageDealt" | FsmInt |   |
| setValue |   | int Nail Damage |   |   |
| everyFrame |   | false |   |   |

##### 3. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Slash |   |   |
| fsmName |   | "damages_enemy" | FsmName |   |
| variableName |   | "damageDealt" | FsmInt |   |
| setValue |   | int Nail Damage |   |   |
| everyFrame |   | false |   |   |

##### 4. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault UpSlash |   |   |
| fsmName |   | "damages_enemy" | FsmName |   |
| variableName |   | "damageDealt" | FsmInt |   |
| setValue |   | int Nail Damage |   |   |
| everyFrame |   | false |   |   |

##### 5. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault WallSlash |   |   |
| fsmName |   | "damages_enemy" | FsmName |   |
| variableName |   | "damageDealt" | FsmInt |   |
| setValue |   | int Nail Damage |   |   |
| everyFrame |   | false |   |   |

##### 6. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Hit L |   |   |
| fsmName |   | "damages_enemy" | FsmName |   |
| variableName |   | "damageDealt" | FsmInt |   |
| setValue |   | int Nail Damage |   |   |
| everyFrame |   | false |   |   |

##### 7. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Hit R |   |   |
| fsmName |   | "damages_enemy" | FsmName |   |
| variableName |   | "damageDealt" | FsmInt |   |
| setValue |   | int Nail Damage |   |   |
| everyFrame |   | false |   |   |

##### 8. IntOperator

Full Name: HutongGames.PlayMaker.Actions.IntOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Nail Damage |   |   |
| integer2 |   | 2 |   |   |
| operation | HutongGames.PlayMaker.Actions.IntOperator/Operation::Multiply | 2 |   |   |
| storeResult |   | int Nail Damage | Variable |   |
| everyFrame |   | false |   |   |

##### 9. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Dash Slash |   |   |
| fsmName |   | "damages_enemy" | FsmName |   |
| variableName |   | "damageDealt" | FsmInt |   |
| setValue |   | int Nail Damage |   |   |
| everyFrame |   | false |   |   |

##### 10. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Great Slash |   |   |
| fsmName |   | "damages_enemy" | FsmName |   |
| variableName |   | "damageDealt" | FsmInt |   |
| setValue |   | int Nail Damage |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Idle | 0 | |

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

(none)

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| UPDATE NAIL DAMAGE | Get Damage | 0 | |
| CHARM INDICATOR CHECK | Get Damage | 0 | |

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
| gameObject |   | OwnerDefault GameManager |   |   |
| intName |   | "nailDamage" |   |   |
| storeValue |   | int Nail Damage | Variable |   |

##### 2. GetNailDamage

Full Name: GetNailDamage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeValue |   | int Nail Damage | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Glass Attack Modifier | 0 | |

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
| gameObject |   | OwnerDefault GameManager |   |   |
| trueBool |   | "equippedCharm_25" |   |   |
| falseBool |   | "brokenCharm_25" |   |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(FINISHED) |   |   |

##### 2. ConvertIntToFloat

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Nail Damage | Variable |   |
| floatVariable |   | float Damage Float | Variable |   |
| everyFrame |   | false |   |   |

##### 3. FloatMultiply

Full Name: HutongGames.PlayMaker.Actions.FloatMultiply
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Damage Float | Variable |   |
| multiplyBy |   | 1.5f |   |   |
| everyFrame |   | false |   |   |

##### 4. ConvertFloatToInt

Full Name: HutongGames.PlayMaker.Actions.ConvertFloatToInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Damage Float | Variable |   |
| intVariable |   | int Nail Damage | Variable |   |
| rounding | HutongGames.PlayMaker.Actions.ConvertFloatToInt/FloatRounding::Nearest | 2 |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Set Beam Damage | 0 | |

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
| intVariable |   | int Nail Damage | Variable |   |
| floatVariable |   | float Damage Float | Variable |   |
| everyFrame |   | false |   |   |

##### 2. FloatOperator

Full Name: HutongGames.PlayMaker.Actions.FloatOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 |   | float Damage Float |   |   |
| float2 |   | 0.5f |   |   |
| operation | HutongGames.PlayMaker.Actions.FloatOperator/Operation::Multiply | 2 |   |   |
| storeResult |   | float Damage Float | Variable |   |
| everyFrame |   | false |   |   |

##### 3. ConvertFloatToInt

Full Name: HutongGames.PlayMaker.Actions.ConvertFloatToInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Damage Float | Variable |   |
| intVariable |   | int Beam Damage | Variable |   |
| rounding | HutongGames.PlayMaker.Actions.ConvertFloatToInt/FloatRounding::Nearest | 2 |   |   |
| everyFrame |   | false |   |   |

##### 4. IntClamp

Full Name: HutongGames.PlayMaker.Actions.IntClamp
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Beam Damage | Variable |   |
| minValue |   | 1 |   |   |
| maxValue |   | 90 |   |   |
| everyFrame |   | false |   |   |

##### 5. SetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intName |   | "beamDamage" |   |   |
| value |   | int Beam Damage |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Set Damage | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| CHARM INDICATOR CHECK | false |
| FINISHED | false |
| UPDATE NAIL DAMAGE | false |

