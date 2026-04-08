# Load Animation

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Load Animation |
| GameObject Name | HUD_frame |
| GameObject Path | _GameCameras/HudCamera/Hud Canvas/Soul Orb |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Pause Frame |
| FSM PathId | 22618 |
| GameObject PathId | 4010 |

## Variables

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| PermaDeath Mode | 0 | Int32: 0 |

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| Anim Appear |  | String:  |
| Anim CrackAppear |  | String:  |
| Anim Cracked |  | String:  |
| Anim Idle |  | String:  |

## States

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | false | false |  |  |

### pause

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 1.75f | 1.75f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

##### 2. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName | "enteredTutorialFirstTime" | "enteredTutorialFirstTime" |  |  |
| value | true | true |  |  |

### Appear Normal

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animLibName | "" | "" |  |  |
| clipName | string Anim Appear | string Anim Appear |  |  |

### Cracked?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | true | true |  |  |

##### 2. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "soulLimited" | "soulLimited" |  |  |
| isTrue | Event(CRACKED) | Event(CRACKED) |  |  |
| isFalse | Event(UNCRACKED) | Event(UNCRACKED) |  |  |

### Appear Cracked

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animLibName | "" | "" |  |  |
| clipName | string Anim CrackAppear | string Anim CrackAppear |  |  |

### First Pause

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "bossRushMode" | "bossRushMode" |  |  |
| isTrue | Event(FINISHED) | Event(FINISHED) |  |  |
| isFalse | Event() | Event() |  |  |

##### 2. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "enteredTutorialFirstTime" | "enteredTutorialFirstTime" |  |  |
| isTrue | Event(FINISHED) | Event(FINISHED) |  |  |
| isFalse | Event() | Event() |  |  |

##### 3. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 9.75f | 9.75f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Pause Frame

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. NextFrameEvent

Full Name: HutongGames.PlayMaker.Actions.NextFrameEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent | Event(FINISHED) | Event(FINISHED) |  |  |

### Normal

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animLibName | "" | "" |  |  |
| clipName | string Anim Idle | string Anim Idle |  |  |

### Cracked

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animLibName | "" | "" |  |  |
| clipName | string Anim Cracked | string Anim Cracked |  |  |

### Set Anims

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "bossRushMode" | "bossRushMode" |  |  |
| isTrue | Event(GG MODE) | Event(GG MODE) |  |  |
| isFalse | Event() | Event() |  |  |

##### 2. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Anim Appear | string Anim Appear | Variable |  |
| stringValue | "HUD Frame" | "HUD Frame" | TextArea |  |
| everyFrame | false | false |  |  |

##### 3. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Anim Idle | string Anim Idle | Variable |  |
| stringValue | "HUD Frame Idle" | "HUD Frame Idle" | TextArea |  |
| everyFrame | false | false |  |  |

##### 4. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Anim CrackAppear | string Anim CrackAppear | Variable |  |
| stringValue | "HUD Frame CrackAppear" | "HUD Frame CrackAppear" | TextArea |  |
| everyFrame | false | false |  |  |

##### 5. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Anim Cracked | string Anim Cracked | Variable |  |
| stringValue | "HUD Frame Cracked" | "HUD Frame Cracked" | TextArea |  |
| everyFrame | false | false |  |  |

##### 6. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "permadeathMode" | "permadeathMode" |  |  |
| storeValue | int PermaDeath Mode | int PermaDeath Mode | Variable |  |

##### 7. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int PermaDeath Mode | int PermaDeath Mode |  |  |
| integer2 | 0 | 0 |  |  |
| equal | Event(FINISHED) | Event(FINISHED) |  |  |
| lessThan | Event(FINISHED) | Event(FINISHED) |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 8. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Anim Appear | string Anim Appear | Variable |  |
| stringValue | "HUD Frame St" | "HUD Frame St" | TextArea |  |
| everyFrame | false | false |  |  |

##### 9. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Anim Idle | string Anim Idle | Variable |  |
| stringValue | "HUD Frame Idle St" | "HUD Frame Idle St" | TextArea |  |
| everyFrame | false | false |  |  |

##### 10. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Anim CrackAppear | string Anim CrackAppear | Variable |  |
| stringValue | "HUD Frame CrackAppear St" | "HUD Frame CrackAppear St" | TextArea |  |
| everyFrame | false | false |  |  |

##### 11. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Anim Cracked | string Anim Cracked | Variable |  |
| stringValue | "HUD Frame Cracked St" | "HUD Frame Cracked St" | TextArea |  |
| everyFrame | false | false |  |  |

### Check

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "soulLimited" | "soulLimited" |  |  |
| isTrue | Event(SOUL LIMITER UP) | Event(SOUL LIMITER UP) |  |  |
| isFalse | Event(SOUL LIMITER DOWN) | Event(SOUL LIMITER DOWN) |  |  |

### GG Anims

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Anim Appear | string Anim Appear | Variable |  |
| stringValue | "HUD Frame GG" | "HUD Frame GG" | TextArea |  |
| everyFrame | false | false |  |  |

##### 2. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Anim Idle | string Anim Idle | Variable |  |
| stringValue | "HUD Frame Idle GG" | "HUD Frame Idle GG" | TextArea |  |
| everyFrame | false | false |  |  |

##### 3. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Anim CrackAppear | string Anim CrackAppear | Variable |  |
| stringValue | "HUD Frame CrackAppear" | "HUD Frame CrackAppear" | TextArea |  |
| everyFrame | false | false |  |  |

##### 4. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Anim Cracked | string Anim Cracked | Variable |  |
| stringValue | "HUD Frame Cracked" | "HUD Frame Cracked" | TextArea |  |
| everyFrame | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Init | LOAD | First Pause | 0 | 0 | 0 |
| Init | FINISHED | First Pause | 0 | 0 | 0 |
| pause | FINISHED | Cracked? | 0 | 0 | 0 |
| Appear Normal | SOUL LIMITER UP | Cracked | 0 | 0 | 0 |
| Cracked? | CRACKED | Appear Cracked | 0 | 0 | 0 |
| Cracked? | UNCRACKED | Appear Normal | 0 | 0 | 0 |
| Appear Cracked | SOUL LIMITER DOWN | Normal | 0 | 0 | 0 |
| First Pause | FINISHED | pause | 0 | 0 | 0 |
| Pause Frame | FINISHED | Set Anims | 0 | 0 | 0 |
| Normal | SOUL LIMITER UP | Cracked | 0 | 0 | 0 |
| Normal | LEVEL LOADED | Check | 0 | 0 | 0 |
| Cracked | SOUL LIMITER DOWN | Normal | 0 | 0 | 0 |
| Cracked | LEVEL LOADED | Check | 0 | 0 | 0 |
| Set Anims | FINISHED | Init | 0 | 0 | 0 |
| Set Anims | GG MODE | GG Anims | 0 | 0 | 0 |
| Check | SOUL LIMITER DOWN | Normal | 0 | 0 | 0 |
| Check | SOUL LIMITER UP | Cracked | 0 | 0 | 0 |
| GG Anims | FINISHED | Init | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| LEVEL LOADED | false |
| CRACKED | false |
| GG MODE | false |
| INERT | false |
| LIMIT | false |
| LOAD | false |
| SHORT | false |
| SOUL LIMITER DOWN | false |
| SOUL LIMITER UP | false |
| UNCRACKED | false |

