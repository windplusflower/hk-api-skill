# Set Spell Cost

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Set Spell Cost |
| GameObject Name | Charm Effects |
| GameObject Path | Knight/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level4 |
| Start State | Init |
| FSM PathId | 1021 |
| GameObject PathId | 147 |

## Variables

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Parent | [null] | NamedAssetPPtr: [null] |

## States

### Init

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
| FINISHED | Check | 0 | |

### Check

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| boolName |   | "equippedCharm_33" |   |   |
| isTrue |   | Event(MAGE) |   |   |
| isFalse |   | Event(NORMAL) |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| NORMAL | Normal | 0 | |
| MAGE | Mage | 0 | |

### Normal

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Parent |   |   |
| fsmName |   | "Spell Control" | FsmName |   |
| variableName |   | "MP Cost" | FsmInt |   |
| setValue |   | 33 |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Idle | 0 | |

### Mage

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Parent |   |   |
| fsmName |   | "Spell Control" | FsmName |   |
| variableName |   | "MP Cost" | FsmInt |   |
| setValue |   | 24 |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Idle | 0 | |

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

(none)

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| CHARM INDICATOR CHECK | Check | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| CHARM INDICATOR CHECK | false |
| FINISHED | false |
| MAGE | false |
| NORMAL | false |

