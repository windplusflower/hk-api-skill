# Close

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Close |
| GameObject Name | Gate Closer |
| GameObject Path | Battle Scene/Gate Closers/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level290 |
| Start State | Detect |
| FSM PathId | 3572 |
| GameObject PathId | 219 |

## Variables

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Gate | Battle Gate Deepnest (Hollow Knight/hollow_knight_Data\level290) | NamedAssetPPtr: [Battle Gate Deepnest (Hollow Knight/hollow_knight_Data\level290)] |

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
| sendEvent |   | Event(HIT) |   |   |
| storeCollider |   |   | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| HIT | Close | 0 | |

### Close

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Gate |   |   |
| sendEvent |   | "BG CLOSE" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

(none)

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| HIT | true |

