# FSM

## Summary

| Field | Value |
| --- | --- |
| FSM Name | FSM |
| GameObject Name | Particle Rock Tiny Transient 5 |
| GameObject Path | colosseum gold trophy/Debris/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level35 |
| Start State | Wait |
| FSM PathId | 1574 |
| GameObject PathId | 248 |

## Variables

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Vis Check | false | Boolean: false |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Self | [null] | NamedAssetPPtr: [null] |

## States

### Detect

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetOwner

Full Name: HutongGames.PlayMaker.Actions.GetOwner
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeGameObject |   | GameObject Self | Variable |   |

##### 2. GameObjectIsVisible

Full Name: HutongGames.PlayMaker.Actions.GameObjectIsVisible
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Self |   |   |
| trueEvent |   | Event() |   |   |
| falseEvent |   | Event(FALSE) |   |   |
| storeResult |   | false | Variable |   |
| everyFrame |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FALSE | Destroy | 0 | |

### Destroy

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. DestroyObject

Full Name: HutongGames.PlayMaker.Actions.DestroyObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | GameObject Self |   |   |
| delay |   | 0f |   |   |
| detachChildren |   | false |   |   |

#### Transitions

(none)

### Wait

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 0.5f |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Detect | 0 | |

## Global Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| HAZARD RELOAD | Destroy | 0 | |

## Events

| Name | Global |
| --- | --- |
| FALSE | false |
| FINISHED | false |
| HAZARD RELOAD | false |

