# Screen Shake

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Screen Shake |
| GameObject Name | Warp |
| GameObject Path | Ghost Warrior NPC/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level194 |
| Start State | Shake |
| FSM PathId | 2162 |
| GameObject PathId | 62 |

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

