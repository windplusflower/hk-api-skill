# Enough Geo?

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Enough Geo? |
| GameObject Name | Not Enough Sub |
| GameObject Path | Shop Menu/Confirm/UI List/Yes/Not Enough/ |
| Source Asset | D:/SteamLibrary/steamapps/common/Hollow Knight/hollow_knight_Data/level18 |
| Start State | Init |
| FSM PathId | 1025 |
| GameObject PathId | 172 |

## Variables

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Geo | 0 | Int32: 0 |
| Toll Cost | 0 | Int32: 0 |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Text YN | [null] | NamedAssetPPtr: [null] |
| UI List | [null] | NamedAssetPPtr: [null] |

## States

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| intName |   | "geo" |   |   |
| storeValue |   | int Geo | Variable |   |

##### 2. GetParent

Full Name: HutongGames.PlayMaker.Actions.GetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| storeResult |   | GameObject UI List | Variable |   |

##### 3. GetParent

Full Name: HutongGames.PlayMaker.Actions.GetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault UI List |   |   |
| storeResult |   | GameObject Text YN | Variable |   |

##### 4. GetFsmInt

Full Name: HutongGames.PlayMaker.Actions.GetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Text YN |   |   |
| fsmName |   | "Dialogue Page Control" | FsmName |   |
| variableName |   | "Toll Cost" | FsmInt |   |
| storeValue |   | int Toll Cost | Variable |   |
| everyFrame |   | false |   |   |

##### 5. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Toll Cost |   |   |
| integer2 |   | int Geo |   |   |
| equal |   | Event() |   |   |
| lessThan |   | Event() |   |   |
| greaterThan |   | Event(NOT ENOUGH) |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| NOT ENOUGH | Not Enuff | 0 | |

### Not Enuff

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SetMaterialColor

Full Name: HutongGames.PlayMaker.Actions.SetMaterialColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| materialIndex |   | 0 |   |   |
| material |   | [FsmMaterial not implemented] |   |   |
| namedColor |   | "_Color" | NamedColor |   |
| color |   | Color(0.6691177, 0.6691177, 0.6691177, 1) |   |   |
| everyFrame |   | false |   |   |

#### Transitions

(none)

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| NOT ENOUGH | false |

