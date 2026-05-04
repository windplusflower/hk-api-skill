# Crawler

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Crawler |
| GameObject Name | Crawler |
| GameObject Path | _Enemies/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level39 |
| Start State | Walk |
| FSM PathId | 5098 |
| GameObject PathId | 233 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Hero X | 0 | Single: 0 |
| Start Scale | 1 | Single: 1 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| First Crawler | false | Boolean: false |

## States

### Walk

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool First Crawler | Variable |   |
| isTrue |   | FIRST |   |   |
| isFalse |   |   |   |   |
| everyFrame |   | false |   |   |

##### 2. WalkLeftRight

Full Name: HutongGames.PlayMaker.Actions.WalkLeftRight
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| walkSpeed |   | 4 |   |   |
| spriteFacesLeft |   | true |   |   |
| groundLayer |   | "Terrain" |   |   |
| turnDelay |   | 1 |   |   |
| walkAnimName |   | "walk" |   |   |
| turnAnimName |   | "turn" |   |   |
| startLeft |   | false |   |   |
| startRight |   | false |   |   |
| keepDirection |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FIRST | Wait | 0 | |
| GO LEFT | Start L | 0 | |
| GO RIGHT | Start R | 0 | |

### Wait

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

(none)

#### Transitions

(none)

### Start L

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. WalkLeftRight

Full Name: HutongGames.PlayMaker.Actions.WalkLeftRight
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| walkSpeed |   | 4 |   |   |
| spriteFacesLeft |   | true |   |   |
| groundLayer |   | "Terrain" |   |   |
| turnDelay |   | 1 |   |   |
| walkAnimName |   | "walk" |   |   |
| turnAnimName |   | "turn" |   |   |
| startLeft |   | true |   |   |
| startRight |   | false |   |   |
| keepDirection |   | false |   |   |

##### 2. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 0.5f |   |   |
| finishEvent |   | FINISHED |   |   |
| realTime |   | true |   |   |

##### 3. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | -0.1f |   |   |
| y |   | 0f |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| perSecond |   | false |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |
| fixedUpdate |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Maintain | 0 | |

### Start R

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. WalkLeftRight

Full Name: HutongGames.PlayMaker.Actions.WalkLeftRight
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| walkSpeed |   | 4 |   |   |
| spriteFacesLeft |   | true |   |   |
| groundLayer |   | "Terrain" |   |   |
| turnDelay |   | 1 |   |   |
| walkAnimName |   | "walk" |   |   |
| turnAnimName |   | "turn" |   |   |
| startLeft |   | false |   |   |
| startRight |   | true |   |   |
| keepDirection |   | false |   |   |

##### 2. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 0.5f |   |   |
| finishEvent |   | FINISHED |   |   |
| realTime |   | false |   |   |

##### 3. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0.1f |   |   |
| y |   | 0f |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| perSecond |   | false |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |
| fixedUpdate |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Maintain | 0 | |

### Maintain

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. WalkLeftRight

Full Name: HutongGames.PlayMaker.Actions.WalkLeftRight
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| walkSpeed |   | 4 |   |   |
| spriteFacesLeft |   | true |   |   |
| groundLayer |   | "Terrain" |   |   |
| turnDelay |   | 1 |   |   |
| walkAnimName |   | "walk" |   |   |
| turnAnimName |   | "turn" |   |   |
| startLeft |   | false |   |   |
| startRight |   | false |   |   |
| keepDirection |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| GO LEFT | Start L | 0 | |
| GO RIGHT | Start R | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| FIRST | false |
| GO LEFT | false |
| GO RIGHT | false |
| MOVE | false |

