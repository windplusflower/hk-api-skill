# Fader

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Fader |
| GameObject Name | Low Health Light |
| GameObject Path | _GameCameras/HudCamera/Hud Canvas/Health/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level1 |
| Start State | Init |
| FSM PathId | 8929 |
| GameObject PathId | 947 |

## Variables

### Colors

| Name | Value | Raw/Type |
| --- | --- | --- |
| New Colour | Color(0, 0, 0, 1) | UnityColor: Color(0, 0, 0, 1) |
| Prev Colour | Color(1, 1, 1, 1) | UnityColor: Color(1, 1, 1, 1) |

## States

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetMaterialColor

Full Name: HutongGames.PlayMaker.Actions.SetMaterialColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| materialIndex |   | 0 |   |   |
| material |   | [FsmMaterial not implemented] |   |   |
| namedColor |   | "_Color" | NamedColor |   |
| color |   | Color(1, 1, 1, 1) |   |   |
| everyFrame |   | false |   |   |

##### 2. SetSpriteRenderer

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| active |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Down | 0 | |

### Up

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. FadeGroupUp

Full Name: FadeGroupUp
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target |   | OwnerDefault FSM Owner | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| DOWN | Down | 0 | |

### Down

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. FadeGroupDown

Full Name: FadeGroupDown
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target |   | OwnerDefault FSM Owner | Variable |   |
| fast |   | false |   |   |

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
| FINISHED | false |
| UP | false |

