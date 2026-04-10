# Control Mesh Renderer

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Control Mesh Renderer |
| GameObject Name | Bound Charms Icon |
| GameObject Path | _GameCameras/HudCamera/Hud Canvas/Extras |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Hide |
| FSM PathId | 26058 |
| GameObject PathId | 8138 |

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
| HIDE BOUND CHARMS | Hide | 0 | 0 | 0 |
| SHOW BOUND CHARMS | Show | 0 | 0 | 0 |

## Events

| Name | Global |
| --- | --- |
| HIDE BOUND CHARMS | true |
| SHOW BOUND CHARMS | true |

