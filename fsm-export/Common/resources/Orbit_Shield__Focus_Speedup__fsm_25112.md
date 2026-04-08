# Focus Speedup

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Focus Speedup |
| GameObject Name | Orbit Shield |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Idle |
| FSM PathId | 25112 |
| GameObject PathId | 7800 |

## Variables

## States

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Control" | "Control" | FsmName |  |
| variableName | "Speed" | "Speed" | FsmFloat |  |
| setValue | 110f | 110f |  |  |
| everyFrame | false | false |  |  |

### Focus

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Control" | "Control" | FsmName |  |
| variableName | "Speed" | "Speed" | FsmFloat |  |
| setValue | 300f | 300f |  |  |
| everyFrame | false | false |  |  |

##### 2. AudioPlayInState

Full Name: HutongGames.PlayMaker.Actions.AudioPlayInState
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| volume | 0.6f | 0.6f |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Idle | HERO FOCUS START | Focus | 0 | 0 | 0 |
| Focus | HERO FOCUS END | Idle | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| HERO FOCUS END | false |
| HERO FOCUS START | false |

