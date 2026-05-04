# Border Display

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Border Display |
| GameObject Name | Border |
| GameObject Path | Stag Map/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level244 |
| Start State | Init |
| FSM PathId | 1776 |
| GameObject PathId | 239 |

## Variables

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Bot | [null] | NamedAssetPPtr: [null] |
| Top | [null] | NamedAssetPPtr: [null] |

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
| childName |   | "Stag_Border_Bottom" |   |   |
| storeResult |   | GameObject Bot | Variable |   |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Stag_Border_Top" |   |   |
| storeResult |   | GameObject Top | Variable |   |

##### 3. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Top |   |   |
| active |   | false |   |   |

##### 4. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Bot |   |   |
| active |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| UP | Up | 0 | |

### Up

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Top |   |   |
| active |   | true |   |   |

##### 2. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Bot |   |   |
| active |   | true |   |   |

##### 3. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Bot |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "Stag_Border_Bottom Up" |   |   |

##### 4. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Top |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "Stag_Border_Top Up" |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| DOWN | Down | 0 | |

### Down

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Bot |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "Stag_Border_Bottom Down" |   |   |

##### 2. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Top |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "Stag_Border_Top Down" |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| UP | Up | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| DOWN | false |
| UP | false |

