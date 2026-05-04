# Snore Control

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Snore Control |
| GameObject Name | Snore |
| GameObject Path | _Enemies/Giant Fly/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level484 |
| Start State | State 1 |
| FSM PathId | 1502 |
| GameObject PathId | 71 |

## Variables

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Frame | 0 | Int32: 0 |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Parent | [null] | NamedAssetPPtr: [null] |

## States

### State 1

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetParent

Full Name: HutongGames.PlayMaker.Actions.GetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| storeResult |   | GameObject Parent | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | State 2 | 0 | |

### State 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetParticleEmissionRate

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmissionRate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| emissionRate |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 2. Tk2dSpriteGetId

Full Name: HutongGames.PlayMaker.Actions.Tk2dSpriteGetId
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Parent |   |   |
| spriteID |   | int Frame | FsmInt |   |
| everyframe |   | true |   |   |

##### 3. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Frame |   |   |
| integer2 |   | 16 |   |   |
| equal |   | Event(SNORE) |   |   |
| lessThan |   | Event() |   |   |
| greaterThan |   | Event() |   |   |
| everyFrame |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| SNORE | Snore | 0 | |

### Snore

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetParticleEmissionRate

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmissionRate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| emissionRate |   | 40f |   |   |
| everyFrame |   | false |   |   |

##### 2. Tk2dSpriteGetId

Full Name: HutongGames.PlayMaker.Actions.Tk2dSpriteGetId
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Parent |   |   |
| spriteID |   | int Frame | FsmInt |   |
| everyframe |   | true |   |   |

##### 3. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Frame |   |   |
| integer2 |   | 16 |   |   |
| equal |   | Event() |   |   |
| lessThan |   | Event(RETURN) |   |   |
| greaterThan |   | Event(RETURN) |   |   |
| everyFrame |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| RETURN | State 2 | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| RETURN | false |
| SNORE | false |

