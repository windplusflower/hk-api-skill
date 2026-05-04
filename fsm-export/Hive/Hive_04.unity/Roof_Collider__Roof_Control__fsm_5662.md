# Roof Control

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Roof Control |
| GameObject Name | Roof Collider |
| GameObject Path | Hive Break Wall/ |
| Source Asset | D:/SteamLibrary/steamapps/common/Hollow Knight/hollow_knight_Data/level388 |
| Start State | Idle |
| FSM PathId | 5662 |
| GameObject PathId | 65 |

## Variables

## States

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Collision2dEvent

Full Name: HutongGames.PlayMaker.Actions.Collision2dEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| collision | HutongGames.PlayMaker.Collision2DType::OnCollisionEnter2D | 0 |   |   |
| collideTag |   | "" | Tag |   |
| sendEvent |   | Event(COLLIDE) |   |   |
| storeCollider |   |   | Variable |   |
| storeForce |   | 0f | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| COLLIDE | Collide | 0 | |

### Collide

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Hero |   |   |
| behaviour |   | "HeroController" | Behaviour |   |
| methodName |   | "CancelHeroJump" | Method |   |
| parameters |   | FSMViewAvalonia2.FsmArray2 |   |   |
| storeResult |   | Var unnamed = 0 | Variable | Store Result |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Idle | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| COLLIDE | false |
| FINISHED | false |

