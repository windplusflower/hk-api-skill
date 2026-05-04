# Screen Shake

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Screen Shake |
| GameObject Name | Warp Out |
| GameObject Path | Warrior/Ghost Warrior Xero/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level440 |
| Start State | Shake |
| FSM PathId | 1771 |
| GameObject PathId | 55 |

## Variables

## States

### Shake

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):CameraParent |   |   |
| sendEvent |   | "EnemyKillShake" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

(none)

## Global Transitions

(none)

## Events

(none)

