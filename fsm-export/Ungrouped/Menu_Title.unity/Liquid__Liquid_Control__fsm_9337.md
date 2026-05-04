# Liquid Control

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Liquid Control |
| GameObject Name | Liquid |
| GameObject Path | _GameCameras/HudCamera/Hud Canvas/Soul Orb/SoulOrb_fill/ |
| Source Asset | D:/SteamLibrary/steamapps/common/Hollow Knight/hollow_knight_Data/level1 |
| Start State | Idle |
| FSM PathId | 9337 |
| GameObject PathId | 807 |

## Variables

### Colors

| Name | Value | Raw/Type |
| --- | --- | --- |
| Colour | Color(1, 1, 1, 1) | UnityColor: Color(1, 1, 1, 1) |
| Prev Colour | Color(0, 0, 0, 1) | UnityColor: Color(0, 0, 0, 1) |

## States

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

(none)

#### Transitions

(none)

### Can Heal

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Tk2dSpriteGetColor

Full Name: HutongGames.PlayMaker.Actions.Tk2dSpriteGetColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| color |   | Color Prev Colour | Variable |   |
| everyframe |   | false |   |   |

##### 2. EaseColor

Full Name: HutongGames.PlayMaker.Actions.EaseColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| fromValue |   | Color Prev Colour |   |   |
| toValue |   | Color(1, 1, 1, 1) |   |   |
| colorVariable |   | Color Colour | Variable |   |
| time |   | 0.2f |   |   |
| speed |   | 0f |   |   |
| delay |   | 0f |   |   |
| easeType |   | 21 |   |   |
| reverse |   | false |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |

##### 3. Tk2dSpriteSetColor

Full Name: HutongGames.PlayMaker.Actions.Tk2dSpriteSetColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| color |   | Color Colour | FsmColor |   |
| everyframe |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Idle | 0 | |

### Can't Heal

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Tk2dSpriteGetColor

Full Name: HutongGames.PlayMaker.Actions.Tk2dSpriteGetColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| color |   | Color Prev Colour | Variable |   |
| everyframe |   | false |   |   |

##### 2. EaseColor

Full Name: HutongGames.PlayMaker.Actions.EaseColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| fromValue |   | Color Prev Colour |   |   |
| toValue |   | Color(0.43137255, 0.43137255, 0.43137255, 1) |   |   |
| colorVariable |   | Color Colour | Variable |   |
| time |   | 0.2f |   |   |
| speed |   | 0f |   |   |
| delay |   | 0f |   |   |
| easeType |   | 21 |   |   |
| reverse |   | false |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |

##### 3. Tk2dSpriteSetColor

Full Name: HutongGames.PlayMaker.Actions.Tk2dSpriteSetColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| color |   | Color Colour | FsmColor |   |
| everyframe |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Idle | 0 | |

## Global Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| CANT HEAL | Can't Heal | 0 | |
| CAN HEAL | Can Heal | 0 | |

## Events

| Name | Global |
| --- | --- |
| CAN HEAL | false |
| CANT HEAL | false |
| FINISHED | false |

