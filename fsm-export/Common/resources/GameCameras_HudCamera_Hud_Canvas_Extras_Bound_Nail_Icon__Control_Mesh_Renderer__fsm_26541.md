# Control Mesh Renderer

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Control Mesh Renderer |
| GameObject Name | Bound Nail Icon |
| GameObject Path | _GameCameras/HudCamera/Hud Canvas/Extras |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Hide |
| FSM PathId | 26541 |
| GameObject PathId | 8256 |

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
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | false | false |  |  |

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
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | true | true |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |  |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| HIDE BOUND NAIL | Hide | 0 | 0 | 0 |
| SHOW BOUND NAIL | Show | 0 | 0 | 0 |

## Events

| Name | Global |
| --- | --- |
| HIDE BOUND NAIL | true |
| SHOW BOUND NAIL | true |

