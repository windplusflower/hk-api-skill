# Climb

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Climb |
| GameObject Name | Mimic Spider |
| GameObject Path |   |
| Source Asset | D:/SteamLibrary/steamapps/common/Hollow Knight/hollow_knight_Data/level455 |
| Start State | Init |
| FSM PathId | 1844 |
| GameObject PathId | 79 |

## Variables

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Wall L | false | Boolean: false |
| Wall R | false | Boolean: false |

## States

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

(none)

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Idle | 0 | |

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

(none)

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| CHARGE START | Not Climbing | 0 | |

### Not Climbing

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. CheckCollisionSide

Full Name: HutongGames.PlayMaker.Actions.CheckCollisionSide
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| topHit |   | false | Variable |   |
| rightHit |   | bool Wall R | Variable |   |
| bottomHit |   | false | Variable |   |
| leftHit |   | bool Wall L | Variable |   |
| topHitEvent |   | Event() |   |   |
| rightHitEvent |   | Event() |   |   |
| bottomHitEvent |   | Event() |   |   |
| leftHitEvent |   | Event() |   |   |
| otherLayer |   | false |   |   |
| otherLayerNumber |   | 0 |   |   |
| ignoreTriggers |   | false |   |   |

##### 2. CheckCollisionSideEnter

Full Name: HutongGames.PlayMaker.Actions.CheckCollisionSideEnter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| topHit |   | false | Variable |   |
| rightHit |   | bool Wall R | Variable |   |
| bottomHit |   | false | Variable |   |
| leftHit |   | bool Wall L | Variable |   |
| topHitEvent |   | Event() |   |   |
| rightHitEvent |   | Event() |   |   |
| bottomHitEvent |   | Event() |   |   |
| leftHitEvent |   | Event() |   |   |
| otherLayer |   | false |   |   |
| otherLayerNumber |   | 0 |   |   |
| ignoreTriggers |   | false |   |   |

##### 3. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Wall R | Variable |   |
| isTrue |   | Event(SWAP) |   |   |
| isFalse |   | Event() |   |   |
| everyFrame |   | true |   |   |

##### 4. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Wall L | Variable |   |
| isTrue |   | Event(SWAP) |   |   |
| isFalse |   | Event() |   |   |
| everyFrame |   | true |   |   |

##### 5. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector2(0, 0) |   |   |
| x |   | 0f |   |   |
| y |   | 0f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| SWAP | Climbing | 0 | |

### Climbing

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. CheckCollisionSide

Full Name: HutongGames.PlayMaker.Actions.CheckCollisionSide
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| topHit |   | false | Variable |   |
| rightHit |   | bool Wall R | Variable |   |
| bottomHit |   | false | Variable |   |
| leftHit |   | bool Wall L | Variable |   |
| topHitEvent |   | Event() |   |   |
| rightHitEvent |   | Event() |   |   |
| bottomHitEvent |   | Event() |   |   |
| leftHitEvent |   | Event() |   |   |
| otherLayer |   | false |   |   |
| otherLayerNumber |   | 0 |   |   |
| ignoreTriggers |   | false |   |   |

##### 2. CheckCollisionSideEnter

Full Name: HutongGames.PlayMaker.Actions.CheckCollisionSideEnter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| topHit |   | false | Variable |   |
| rightHit |   | bool Wall R | Variable |   |
| bottomHit |   | false | Variable |   |
| leftHit |   | bool Wall L | Variable |   |
| topHitEvent |   | Event() |   |   |
| rightHitEvent |   | Event() |   |   |
| bottomHitEvent |   | Event() |   |   |
| leftHitEvent |   | Event() |   |   |
| otherLayer |   | false |   |   |
| otherLayerNumber |   | 0 |   |   |
| ignoreTriggers |   | false |   |   |

##### 3. BoolNoneTrue

Full Name: HutongGames.PlayMaker.Actions.BoolNoneTrue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariables |   | FSMViewAvalonia2.FsmArray2 | Variable |   |
| sendEvent |   | Event(SWAP) |   |   |
| storeResult |   | false | Variable |   |
| everyFrame |   | true |   |   |

##### 4. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Wall R | Variable |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(SWAP) |   |   |
| everyFrame |   | true |   |   |

##### 5. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector2(0, 0) |   |   |
| x |   | 0f |   |   |
| y |   | 20f |   |   |
| everyFrame |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| SWAP | Not Climbing | 0 | |

## Global Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| CHARGE END | Idle | 0 | |

## Events

| Name | Global |
| --- | --- |
| CHARGE END | false |
| CHARGE START | false |
| FINISHED | false |
| SWAP | false |

