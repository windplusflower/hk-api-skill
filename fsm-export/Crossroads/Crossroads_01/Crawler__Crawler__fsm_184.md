# Crawler

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Crawler |
| GameObject Name | Crawler |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets37.assets |
| Start State | Walk |
| FSM PathId | 184 |
| GameObject PathId | 76 |

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
| boolVariable | bool First Crawler | bool First Crawler | Variable |  |
| isTrue | FIRST | FIRST |  |  |
| isFalse |  |  |  |  |
| everyFrame | false | false |  |  |

##### 2. WalkLeftRight

Full Name: HutongGames.PlayMaker.Actions.WalkLeftRight
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| walkSpeed | 4 | 4 |  |  |
| spriteFacesLeft | true | true |  |  |
| groundLayer | "Terrain" | "Terrain" |  |  |
| turnDelay | 1 | 1 |  |  |
| walkAnimName | "walk" | "walk" |  |  |
| turnAnimName | "turn" | "turn" |  |  |
| startLeft | false | false |  |  |
| startRight | false | false |  |  |
| keepDirection | false | false |  |  |

### Wait

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

_None_

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
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| walkSpeed | 4 | 4 |  |  |
| spriteFacesLeft | true | true |  |  |
| groundLayer | "Terrain" | "Terrain" |  |  |
| turnDelay | 1 | 1 |  |  |
| walkAnimName | "walk" | "walk" |  |  |
| turnAnimName | "turn" | "turn" |  |  |
| startLeft | true | true |  |  |
| startRight | false | false |  |  |
| keepDirection | false | false |  |  |

##### 2. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.5f | 0.5f |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | true | true |  |  |

##### 3. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | -0.1f | -0.1f |  |  |
| y | 0f | 0f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| perSecond | false | false |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |
| fixedUpdate | false | false |  |  |

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
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| walkSpeed | 4 | 4 |  |  |
| spriteFacesLeft | true | true |  |  |
| groundLayer | "Terrain" | "Terrain" |  |  |
| turnDelay | 1 | 1 |  |  |
| walkAnimName | "walk" | "walk" |  |  |
| turnAnimName | "turn" | "turn" |  |  |
| startLeft | false | false |  |  |
| startRight | true | true |  |  |
| keepDirection | false | false |  |  |

##### 2. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.5f | 0.5f |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

##### 3. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0.1f | 0.1f |  |  |
| y | 0f | 0f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| perSecond | false | false |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |
| fixedUpdate | false | false |  |  |

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
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| walkSpeed | 4 | 4 |  |  |
| spriteFacesLeft | true | true |  |  |
| groundLayer | "Terrain" | "Terrain" |  |  |
| turnDelay | 1 | 1 |  |  |
| walkAnimName | "walk" | "walk" |  |  |
| turnAnimName | "turn" | "turn" |  |  |
| startLeft | false | false |  |  |
| startRight | false | false |  |  |
| keepDirection | true | true |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Walk | FIRST | Wait | 0 | 0 | 0 |
| Walk | GO LEFT | Start L | 0 | 0 | 0 |
| Walk | GO RIGHT | Start R | 0 | 0 | 0 |
| Start L | FINISHED | Maintain | 0 | 0 | 0 |
| Start R | FINISHED | Maintain | 0 | 0 | 0 |
| Maintain | GO LEFT | Start L | 0 | 0 | 0 |
| Maintain | GO RIGHT | Start R | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| FIRST | false |
| GO LEFT | false |
| GO RIGHT | false |
| MOVE | false |

