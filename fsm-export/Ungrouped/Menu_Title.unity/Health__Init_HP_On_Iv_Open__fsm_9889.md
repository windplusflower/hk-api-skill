# Init HP On Iv Open

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Init HP On Iv Open |
| GameObject Name | Health |
| GameObject Path | _GameCameras/HudCamera/Hud Canvas/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level1 |
| Start State | Init |
| FSM PathId | 9889 |
| GameObject PathId | 1412 |

## Variables

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Health 1 | [null] | NamedAssetPPtr: [null] |
| Health 10 | [null] | NamedAssetPPtr: [null] |
| Health 11 | [null] | NamedAssetPPtr: [null] |
| Health 2 | [null] | NamedAssetPPtr: [null] |
| Health 3 | [null] | NamedAssetPPtr: [null] |
| Health 4 | [null] | NamedAssetPPtr: [null] |
| Health 5 | [null] | NamedAssetPPtr: [null] |
| Health 6 | [null] | NamedAssetPPtr: [null] |
| Health 7 | [null] | NamedAssetPPtr: [null] |
| Health 8 | [null] | NamedAssetPPtr: [null] |
| Health 9 | [null] | NamedAssetPPtr: [null] |

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
| childName |   | "Health 1" |   |   |
| storeResult |   | GameObject Health 1 | Variable |   |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Health 2" |   |   |
| storeResult |   | GameObject Health 2 | Variable |   |

##### 3. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Health 3" |   |   |
| storeResult |   | GameObject Health 3 | Variable |   |

##### 4. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Health 4" |   |   |
| storeResult |   | GameObject Health 4 | Variable |   |

##### 5. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Health 5" |   |   |
| storeResult |   | GameObject Health 5 | Variable |   |

##### 6. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Health 6" |   |   |
| storeResult |   | GameObject Health 6 | Variable |   |

##### 7. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Health 7" |   |   |
| storeResult |   | GameObject Health 7 | Variable |   |

##### 8. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Health 8" |   |   |
| storeResult |   | GameObject Health 8 | Variable |   |

##### 9. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Health 9" |   |   |
| storeResult |   | GameObject Health 9 | Variable |   |

##### 10. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Health 10" |   |   |
| storeResult |   | GameObject Health 10 | Variable |   |

##### 11. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Health 11" |   |   |
| storeResult |   | GameObject Health 11 | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| INVENTORY OPENED | Set | 0 | |

### Set

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Health 1 |   |   |
| fsmName |   | "health_display" | FsmName |   |
| variableName |   | "Initialised" | FsmBool |   |
| setValue |   | true |   |   |
| everyFrame |   | false |   |   |

##### 2. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Health 2 |   |   |
| fsmName |   | "health_display" | FsmName |   |
| variableName |   | "Initialised" | FsmBool |   |
| setValue |   | true |   |   |
| everyFrame |   | false |   |   |

##### 3. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Health 3 |   |   |
| fsmName |   | "health_display" | FsmName |   |
| variableName |   | "Initialised" | FsmBool |   |
| setValue |   | true |   |   |
| everyFrame |   | false |   |   |

##### 4. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Health 4 |   |   |
| fsmName |   | "health_display" | FsmName |   |
| variableName |   | "Initialised" | FsmBool |   |
| setValue |   | true |   |   |
| everyFrame |   | false |   |   |

##### 5. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Health 5 |   |   |
| fsmName |   | "health_display" | FsmName |   |
| variableName |   | "Initialised" | FsmBool |   |
| setValue |   | true |   |   |
| everyFrame |   | false |   |   |

##### 6. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Health 6 |   |   |
| fsmName |   | "health_display" | FsmName |   |
| variableName |   | "Initialised" | FsmBool |   |
| setValue |   | true |   |   |
| everyFrame |   | false |   |   |

##### 7. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Health 7 |   |   |
| fsmName |   | "health_display" | FsmName |   |
| variableName |   | "Initialised" | FsmBool |   |
| setValue |   | true |   |   |
| everyFrame |   | false |   |   |

##### 8. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Health 8 |   |   |
| fsmName |   | "health_display" | FsmName |   |
| variableName |   | "Initialised" | FsmBool |   |
| setValue |   | true |   |   |
| everyFrame |   | false |   |   |

##### 9. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Health 9 |   |   |
| fsmName |   | "health_display" | FsmName |   |
| variableName |   | "Initialised" | FsmBool |   |
| setValue |   | true |   |   |
| everyFrame |   | false |   |   |

##### 10. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Health 10 |   |   |
| fsmName |   | "health_display" | FsmName |   |
| variableName |   | "Initialised" | FsmBool |   |
| setValue |   | true |   |   |
| everyFrame |   | false |   |   |

##### 11. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Health 11 |   |   |
| fsmName |   | "health_display" | FsmName |   |
| variableName |   | "Initialised" | FsmBool |   |
| setValue |   | true |   |   |
| everyFrame |   | false |   |   |

#### Transitions

(none)

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| INVENTORY OPENED | false |

