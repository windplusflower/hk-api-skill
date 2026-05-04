# Control Mesh Renderer

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Control Mesh Renderer |
| GameObject Name | Bound Nail Icon |
| GameObject Path | _GameCameras/HudCamera/Hud Canvas/Extras/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level1 |
| Start State | Hide |
| FSM PathId | 10435 |
| GameObject PathId | 2090 |

## Variables

## States

### Hide

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| active |   | false |   |   |

#### Transitions

(none)

### Show

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| active |   | true |   |   |

#### Transitions

(none)

## Global Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| HIDE BOUND NAIL | Hide | 0 | |
| SHOW BOUND NAIL | Show | 0 | |

## Events

| Name | Global |
| --- | --- |
| HIDE BOUND NAIL | true |
| SHOW BOUND NAIL | true |

