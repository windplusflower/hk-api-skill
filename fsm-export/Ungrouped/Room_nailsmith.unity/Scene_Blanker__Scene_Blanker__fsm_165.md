# Scene Blanker

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Scene Blanker |
| GameObject Name | Scene Blanker |
| GameObject Path |   |
| Source Asset | Hollow Knight/hollow_knight_Data/level16 |
| Start State | Off |
| FSM PathId | 165 |
| GameObject PathId | 45 |

## Variables

## States

### Off

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetSpriteRenderer

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| active |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| SCENE BLANKER ON | On | 0 | |

### On

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetSpriteRenderer

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| active |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| SCENE BLANKER OFF | Off | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| SCENE BLANKER OFF | false |
| SCENE BLANKER ON | false |

