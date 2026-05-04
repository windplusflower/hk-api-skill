# Hit Count

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Hit Count |
| GameObject Name | Pale Lurker |
| GameObject Path | Lurker Control/ |
| Source Asset | D:/SteamLibrary/steamapps/common/Hollow Knight/hollow_knight_Data/level451 |
| Start State | Idle |
| FSM PathId | 11041 |
| GameObject PathId | 139 |

## Variables

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Hit Count | 0 | Int32: 0 |
| Hit Count | 0 | Int32: 0 |

## States

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

(none)

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| TOOK DAMAGE | Hit | 0 | |

### Hit

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetFsmInt

Full Name: HutongGames.PlayMaker.Actions.GetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| fsmName |   | "Lurker Control" | FsmName |   |
| variableName |   | "Hit Count" | FsmInt |   |
| storeValue |   | int Hit Count | Variable |   |
| everyFrame |   | false |   |   |

##### 2. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Hit Count | Variable |   |
| add |   | -1 |   |   |
| everyFrame |   | false |   |   |

##### 3. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| fsmName |   | "Lurker Control" | FsmName |   |
| variableName |   | "Hit Count" | FsmInt |   |
| setValue |   | int Hit Count |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Idle | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| TOOK DAMAGE | false |

