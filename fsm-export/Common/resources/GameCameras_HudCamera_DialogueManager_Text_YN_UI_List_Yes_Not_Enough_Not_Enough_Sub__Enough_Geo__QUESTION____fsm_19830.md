# Enough Geo?

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Enough Geo? |
| GameObject Name | Not Enough Sub |
| GameObject Path | _GameCameras/HudCamera/DialogueManager/Text YN/UI List/Yes/Not Enough |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Init |
| FSM PathId | 19830 |
| GameObject PathId | 4266 |

## Variables

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Geo | 0 | Int32: 0 |
| Toll Cost | 0 | Int32: 0 |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Text YN | [null] | NamedAssetPPtr:  |
| UI List | [null] | NamedAssetPPtr:  |

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
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "geo" | "geo" |  |  |
| storeValue | int Geo | int Geo | Variable |  |

##### 2. GetParent

Full Name: HutongGames.PlayMaker.Actions.GetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| storeResult | GameObject UI List | GameObject UI List | Variable |  |

##### 3. GetParent

Full Name: HutongGames.PlayMaker.Actions.GetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault UI List | OwnerDefault UI List |  |  |
| storeResult | GameObject Text YN | GameObject Text YN | Variable |  |

##### 4. GetFsmInt

Full Name: HutongGames.PlayMaker.Actions.GetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Text YN | OwnerDefault Text YN |  |  |
| fsmName | "Dialogue Page Control" | "Dialogue Page Control" | FsmName |  |
| variableName | "Toll Cost" | "Toll Cost" | FsmInt |  |
| storeValue | int Toll Cost | int Toll Cost | Variable |  |
| everyFrame | false | false |  |  |

##### 5. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Toll Cost | int Toll Cost |  |  |
| integer2 | int Geo | int Geo |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event() | Event() |  |  |
| greaterThan | Event(NOT ENOUGH) | Event(NOT ENOUGH) |  |  |
| everyFrame | false | false |  |  |

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
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| materialIndex | 0 | 0 |  |  |
| material | [FsmMaterial not implemented] | [FsmMaterial not implemented] |  |  |
| namedColor | "_Color" | "_Color" | NamedColor |  |
| color | Color(0.6691177, 0.6691177, 0.6691177, 1) | Color(0.6691177, 0.6691177, 0.6691177, 1) |  |  |
| everyFrame | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Init | NOT ENOUGH | Not Enuff | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| NOT ENOUGH | false |

