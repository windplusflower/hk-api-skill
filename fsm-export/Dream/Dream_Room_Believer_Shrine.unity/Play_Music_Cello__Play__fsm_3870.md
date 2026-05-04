# Play

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Play |
| GameObject Name | Play Music Cello |
| GameObject Path |   |
| Source Asset | Hollow Knight/hollow_knight_Data/level405 |
| Start State | Pause |
| FSM PathId | 3870 |
| GameObject PathId | 999 |

## Variables

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Main | [null] | NamedAssetPPtr: [null] |
| Music | [null] | NamedAssetPPtr: [null] |

## States

### Play

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault AudioManager |   |   |
| childName |   | "Music" |   |   |
| storeResult |   | GameObject Music | Variable |   |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Music |   |   |
| childName |   | "Main" |   |   |
| storeResult |   | GameObject Main | Variable |   |

##### 3. AudioPlaySimple

Full Name: HutongGames.PlayMaker.Actions.AudioPlaySimple
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Main |   |   |
| volume |   | 1f |   |   |
| oneShotClip |   | [] |   |   |

#### Transitions

(none)

### Pause

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

(none)

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Play | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |

