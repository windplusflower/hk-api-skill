# Spell Destroy

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Spell Destroy |
| GameObject Name | Plank Solid Bunch 2 |
| GameObject Path | _Props/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level76 |
| Start State | Idle |
| FSM PathId | 14017 |
| GameObject PathId | 490 |

## Variables

## States

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Trigger2dEvent

Full Name: HutongGames.PlayMaker.Actions.Trigger2dEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerEnter2D | 0 |   |   |
| collideTag |   | "Hero Spell" | Tag |   |
| collideLayer |   | "" | Layer |   |
| sendEvent |   | Event(SPELL) |   |   |
| storeCollider |   |   | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| SPELL | Destroy | 0 | |

### Destroy

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject)[SendToChildren]:FSM Owner |   |   |
| sendEvent |   | "INSTA BREAK" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

(none)

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| SPELL | false |

