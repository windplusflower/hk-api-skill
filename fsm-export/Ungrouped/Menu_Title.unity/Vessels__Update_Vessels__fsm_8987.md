# Update Vessels

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Update Vessels |
| GameObject Name | Vessels |
| GameObject Path | _GameCameras/HudCamera/Hud Canvas/Soul Orb/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level1 |
| Start State | Init |
| FSM PathId | 8987 |
| GameObject PathId | 791 |

## Variables

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Vessel 1 | [null] | NamedAssetPPtr: [null] |
| Vessel 2 | [null] | NamedAssetPPtr: [null] |
| Vessel 3 | [null] | NamedAssetPPtr: [null] |
| Vessel 4 | [null] | NamedAssetPPtr: [null] |

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
| childName |   | "Vessel 1" |   |   |
| storeResult |   | GameObject Vessel 1 | Variable |   |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Vessel 2" |   |   |
| storeResult |   | GameObject Vessel 2 | Variable |   |

##### 3. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Vessel 3" |   |   |
| storeResult |   | GameObject Vessel 3 | Variable |   |

##### 4. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Vessel 4" |   |   |
| storeResult |   | GameObject Vessel 4 | Variable |   |

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
| MP RESERVE UP | Send Up Msg | 0 | |
| MP RESERVE DOWN | Send Down Msg | 0 | |

### Send Up Msg

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventToGameObjectOptimized

Full Name: HutongGames.PlayMaker.Actions.SendEventToGameObjectOptimized
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target |   | OwnerDefault Vessel 1 |   |   |
| sendEvent |   | "MP RESERVE UP" |   |   |
| everyFrame |   | false |   |   |

##### 2. SendEventToGameObjectOptimized

Full Name: HutongGames.PlayMaker.Actions.SendEventToGameObjectOptimized
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target |   | OwnerDefault Vessel 2 |   |   |
| sendEvent |   | "MP RESERVE UP" |   |   |
| everyFrame |   | false |   |   |

##### 3. SendEventToGameObjectOptimized

Full Name: HutongGames.PlayMaker.Actions.SendEventToGameObjectOptimized
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target |   | OwnerDefault Vessel 3 |   |   |
| sendEvent |   | "MP RESERVE UP" |   |   |
| everyFrame |   | false |   |   |

##### 4. SendEventToGameObjectOptimized

Full Name: HutongGames.PlayMaker.Actions.SendEventToGameObjectOptimized
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target |   | OwnerDefault Vessel 4 |   |   |
| sendEvent |   | "MP RESERVE UP" |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Idle | 0 | |

### Send Down Msg

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventToGameObjectOptimized

Full Name: HutongGames.PlayMaker.Actions.SendEventToGameObjectOptimized
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target |   | OwnerDefault Vessel 1 |   |   |
| sendEvent |   | "MP RESERVE DOWN" |   |   |
| everyFrame |   | false |   |   |

##### 2. SendEventToGameObjectOptimized

Full Name: HutongGames.PlayMaker.Actions.SendEventToGameObjectOptimized
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target |   | OwnerDefault Vessel 2 |   |   |
| sendEvent |   | "MP RESERVE DOWN" |   |   |
| everyFrame |   | false |   |   |

##### 3. SendEventToGameObjectOptimized

Full Name: HutongGames.PlayMaker.Actions.SendEventToGameObjectOptimized
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target |   | OwnerDefault Vessel 3 |   |   |
| sendEvent |   | "MP RESERVE DOWN" |   |   |
| everyFrame |   | false |   |   |

##### 4. SendEventToGameObjectOptimized

Full Name: HutongGames.PlayMaker.Actions.SendEventToGameObjectOptimized
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target |   | OwnerDefault Vessel 4 |   |   |
| sendEvent |   | "MP RESERVE DOWN" |   |   |
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
| MP RESERVE DOWN | false |
| MP RESERVE UP | false |

