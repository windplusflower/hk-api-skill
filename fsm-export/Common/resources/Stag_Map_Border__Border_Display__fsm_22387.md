# Border Display

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Border Display |
| GameObject Name | Border |
| GameObject Path | Stag Map |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Init |
| FSM PathId | 22387 |
| GameObject PathId | 5436 |

## Variables

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Bot | [null] | NamedAssetPPtr:  |
| Top | [null] | NamedAssetPPtr:  |

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
| childName | "Stag_Border_Bottom" | "Stag_Border_Bottom" |  |  |
| storeResult | GameObject Bot | GameObject Bot | Variable |  |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Stag_Border_Top" | "Stag_Border_Top" |  |  |
| storeResult | GameObject Top | GameObject Top | Variable |  |

##### 3. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Top | OwnerDefault Top |  |  |
| active | false | false |  |  |

##### 4. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Bot | OwnerDefault Bot |  |  |
| active | false | false |  |  |

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
| gameObject | OwnerDefault Top | OwnerDefault Top |  |  |
| active | true | true |  |  |

##### 2. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Bot | OwnerDefault Bot |  |  |
| active | true | true |  |  |

##### 3. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Bot | OwnerDefault Bot |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Stag_Border_Bottom Up" | "Stag_Border_Bottom Up" |  |  |

##### 4. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Top | OwnerDefault Top |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Stag_Border_Top Up" | "Stag_Border_Top Up" |  |  |

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
| gameObject | OwnerDefault Bot | OwnerDefault Bot |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Stag_Border_Bottom Down" | "Stag_Border_Bottom Down" |  |  |

##### 2. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Top | OwnerDefault Top |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Stag_Border_Top Down" | "Stag_Border_Top Down" |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Init | UP | Up | 0 | 0 | 0 |
| Up | DOWN | Down | 0 | 0 | 0 |
| Down | UP | Up | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| DOWN | false |
| UP | false |

