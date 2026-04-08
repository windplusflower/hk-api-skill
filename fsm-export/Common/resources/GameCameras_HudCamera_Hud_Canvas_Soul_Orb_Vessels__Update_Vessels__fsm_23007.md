# Update Vessels

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Update Vessels |
| GameObject Name | Vessels |
| GameObject Path | _GameCameras/HudCamera/Hud Canvas/Soul Orb |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Init |
| FSM PathId | 23007 |
| GameObject PathId | 3959 |

## Variables

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Vessel 1 | [null] | NamedAssetPPtr:  |
| Vessel 2 | [null] | NamedAssetPPtr:  |
| Vessel 3 | [null] | NamedAssetPPtr:  |
| Vessel 4 | [null] | NamedAssetPPtr:  |

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
| childName | "Vessel 1" | "Vessel 1" |  |  |
| storeResult | GameObject Vessel 1 | GameObject Vessel 1 | Variable |  |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Vessel 2" | "Vessel 2" |  |  |
| storeResult | GameObject Vessel 2 | GameObject Vessel 2 | Variable |  |

##### 3. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Vessel 3" | "Vessel 3" |  |  |
| storeResult | GameObject Vessel 3 | GameObject Vessel 3 | Variable |  |

##### 4. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Vessel 4" | "Vessel 4" |  |  |
| storeResult | GameObject Vessel 4 | GameObject Vessel 4 | Variable |  |

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

_None_

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
| target | OwnerDefault Vessel 1 | OwnerDefault Vessel 1 |  |  |
| sendEvent | "MP RESERVE UP" | "MP RESERVE UP" |  |  |
| everyFrame | false | false |  |  |

##### 2. SendEventToGameObjectOptimized

Full Name: HutongGames.PlayMaker.Actions.SendEventToGameObjectOptimized
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault Vessel 2 | OwnerDefault Vessel 2 |  |  |
| sendEvent | "MP RESERVE UP" | "MP RESERVE UP" |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEventToGameObjectOptimized

Full Name: HutongGames.PlayMaker.Actions.SendEventToGameObjectOptimized
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault Vessel 3 | OwnerDefault Vessel 3 |  |  |
| sendEvent | "MP RESERVE UP" | "MP RESERVE UP" |  |  |
| everyFrame | false | false |  |  |

##### 4. SendEventToGameObjectOptimized

Full Name: HutongGames.PlayMaker.Actions.SendEventToGameObjectOptimized
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault Vessel 4 | OwnerDefault Vessel 4 |  |  |
| sendEvent | "MP RESERVE UP" | "MP RESERVE UP" |  |  |
| everyFrame | false | false |  |  |

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
| target | OwnerDefault Vessel 1 | OwnerDefault Vessel 1 |  |  |
| sendEvent | "MP RESERVE DOWN" | "MP RESERVE DOWN" |  |  |
| everyFrame | false | false |  |  |

##### 2. SendEventToGameObjectOptimized

Full Name: HutongGames.PlayMaker.Actions.SendEventToGameObjectOptimized
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault Vessel 2 | OwnerDefault Vessel 2 |  |  |
| sendEvent | "MP RESERVE DOWN" | "MP RESERVE DOWN" |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEventToGameObjectOptimized

Full Name: HutongGames.PlayMaker.Actions.SendEventToGameObjectOptimized
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault Vessel 3 | OwnerDefault Vessel 3 |  |  |
| sendEvent | "MP RESERVE DOWN" | "MP RESERVE DOWN" |  |  |
| everyFrame | false | false |  |  |

##### 4. SendEventToGameObjectOptimized

Full Name: HutongGames.PlayMaker.Actions.SendEventToGameObjectOptimized
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault Vessel 4 | OwnerDefault Vessel 4 |  |  |
| sendEvent | "MP RESERVE DOWN" | "MP RESERVE DOWN" |  |  |
| everyFrame | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Init | FINISHED | Idle | 0 | 0 | 0 |
| Idle | MP RESERVE UP | Send Up Msg | 0 | 0 | 0 |
| Idle | MP RESERVE DOWN | Send Down Msg | 0 | 0 | 0 |
| Send Up Msg | FINISHED | Idle | 0 | 0 | 0 |
| Send Down Msg | FINISHED | Idle | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| MP RESERVE DOWN | false |
| MP RESERVE UP | false |

