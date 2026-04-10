# Init HP On Iv Open

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Init HP On Iv Open |
| GameObject Name | Health |
| GameObject Path | _GameCameras/HudCamera/Hud Canvas |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Init |
| FSM PathId | 24967 |
| GameObject PathId | 5640 |

## Variables

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Health 1 | [null] | NamedAssetPPtr:  |
| Health 10 | [null] | NamedAssetPPtr:  |
| Health 11 | [null] | NamedAssetPPtr:  |
| Health 2 | [null] | NamedAssetPPtr:  |
| Health 3 | [null] | NamedAssetPPtr:  |
| Health 4 | [null] | NamedAssetPPtr:  |
| Health 5 | [null] | NamedAssetPPtr:  |
| Health 6 | [null] | NamedAssetPPtr:  |
| Health 7 | [null] | NamedAssetPPtr:  |
| Health 8 | [null] | NamedAssetPPtr:  |
| Health 9 | [null] | NamedAssetPPtr:  |

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
| childName | "Health 1" | "Health 1" |  |  |
| storeResult | GameObject Health 1 | GameObject Health 1 | Variable |  |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Health 2" | "Health 2" |  |  |
| storeResult | GameObject Health 2 | GameObject Health 2 | Variable |  |

##### 3. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Health 3" | "Health 3" |  |  |
| storeResult | GameObject Health 3 | GameObject Health 3 | Variable |  |

##### 4. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Health 4" | "Health 4" |  |  |
| storeResult | GameObject Health 4 | GameObject Health 4 | Variable |  |

##### 5. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Health 5" | "Health 5" |  |  |
| storeResult | GameObject Health 5 | GameObject Health 5 | Variable |  |

##### 6. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Health 6" | "Health 6" |  |  |
| storeResult | GameObject Health 6 | GameObject Health 6 | Variable |  |

##### 7. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Health 7" | "Health 7" |  |  |
| storeResult | GameObject Health 7 | GameObject Health 7 | Variable |  |

##### 8. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Health 8" | "Health 8" |  |  |
| storeResult | GameObject Health 8 | GameObject Health 8 | Variable |  |

##### 9. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Health 9" | "Health 9" |  |  |
| storeResult | GameObject Health 9 | GameObject Health 9 | Variable |  |

##### 10. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Health 10" | "Health 10" |  |  |
| storeResult | GameObject Health 10 | GameObject Health 10 | Variable |  |

##### 11. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Health 11" | "Health 11" |  |  |
| storeResult | GameObject Health 11 | GameObject Health 11 | Variable |  |

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
| gameObject | OwnerDefault Health 1 | OwnerDefault Health 1 |  |  |
| fsmName | "health_display" | "health_display" | FsmName |  |
| variableName | "Initialised" | "Initialised" | FsmBool |  |
| setValue | true | true |  |  |
| everyFrame | false | false |  |  |

##### 2. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Health 2 | OwnerDefault Health 2 |  |  |
| fsmName | "health_display" | "health_display" | FsmName |  |
| variableName | "Initialised" | "Initialised" | FsmBool |  |
| setValue | true | true |  |  |
| everyFrame | false | false |  |  |

##### 3. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Health 3 | OwnerDefault Health 3 |  |  |
| fsmName | "health_display" | "health_display" | FsmName |  |
| variableName | "Initialised" | "Initialised" | FsmBool |  |
| setValue | true | true |  |  |
| everyFrame | false | false |  |  |

##### 4. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Health 4 | OwnerDefault Health 4 |  |  |
| fsmName | "health_display" | "health_display" | FsmName |  |
| variableName | "Initialised" | "Initialised" | FsmBool |  |
| setValue | true | true |  |  |
| everyFrame | false | false |  |  |

##### 5. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Health 5 | OwnerDefault Health 5 |  |  |
| fsmName | "health_display" | "health_display" | FsmName |  |
| variableName | "Initialised" | "Initialised" | FsmBool |  |
| setValue | true | true |  |  |
| everyFrame | false | false |  |  |

##### 6. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Health 6 | OwnerDefault Health 6 |  |  |
| fsmName | "health_display" | "health_display" | FsmName |  |
| variableName | "Initialised" | "Initialised" | FsmBool |  |
| setValue | true | true |  |  |
| everyFrame | false | false |  |  |

##### 7. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Health 7 | OwnerDefault Health 7 |  |  |
| fsmName | "health_display" | "health_display" | FsmName |  |
| variableName | "Initialised" | "Initialised" | FsmBool |  |
| setValue | true | true |  |  |
| everyFrame | false | false |  |  |

##### 8. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Health 8 | OwnerDefault Health 8 |  |  |
| fsmName | "health_display" | "health_display" | FsmName |  |
| variableName | "Initialised" | "Initialised" | FsmBool |  |
| setValue | true | true |  |  |
| everyFrame | false | false |  |  |

##### 9. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Health 9 | OwnerDefault Health 9 |  |  |
| fsmName | "health_display" | "health_display" | FsmName |  |
| variableName | "Initialised" | "Initialised" | FsmBool |  |
| setValue | true | true |  |  |
| everyFrame | false | false |  |  |

##### 10. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Health 10 | OwnerDefault Health 10 |  |  |
| fsmName | "health_display" | "health_display" | FsmName |  |
| variableName | "Initialised" | "Initialised" | FsmBool |  |
| setValue | true | true |  |  |
| everyFrame | false | false |  |  |

##### 11. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Health 11 | OwnerDefault Health 11 |  |  |
| fsmName | "health_display" | "health_display" | FsmName |  |
| variableName | "Initialised" | "Initialised" | FsmBool |  |
| setValue | true | true |  |  |
| everyFrame | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Init | INVENTORY OPENED | Set | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| INVENTORY OPENED | false |

