# Add Map Scene

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Add Map Scene |
| GameObject Name | Map Scene Region |
| GameObject Path |   |
| Source Asset | Hollow Knight/hollow_knight_Data/level302 |
| Start State | Detect |
| FSM PathId | 6899 |
| GameObject PathId | 2121 |

## Variables

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| Scene Name | Deepnest_44_b | String: Deepnest_44_b |

## States

### Detect

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
| collideTag |   | "" | Tag |   |
| collideLayer |   | "" | Layer |   |
| sendEvent |   | Event(ENTER) |   |   |
| storeCollider |   |   | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| ENTER | Add | 0 | |

### Add

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| behaviour |   | "GameManager" | Behaviour |   |
| methodName |   | "AddToScenesVisited" | Method |   |
| parameters |   | FSMViewAvalonia2.FsmArray2 |   |   |
| storeResult |   | Var unnamed = 0 | Variable | Store Result |

#### Transitions

(none)

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| ENTER | false |

