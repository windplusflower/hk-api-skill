# Final Burst

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Final Burst |
| GameObject Name | Abyss Pit |
| GameObject Path | Boss Control/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level459 |
| Start State | State 1 |
| FSM PathId | 3383 |
| GameObject PathId | 622 |

## Variables

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Final | [null] | NamedAssetPPtr: [null] |

## States

### State 1

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
| childName |   | "Final" |   |   |
| storeResult |   | GameObject Final | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINAL BURST | State 2 | 0 | |

### State 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Final |   |   |
| activate |   | true |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

#### Transitions

(none)

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| FINAL BURST | false |

