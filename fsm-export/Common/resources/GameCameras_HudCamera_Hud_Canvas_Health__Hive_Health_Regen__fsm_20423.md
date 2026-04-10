# Hive Health Regen

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Hive Health Regen |
| GameObject Name | Health |
| GameObject Path | _GameCameras/HudCamera/Hud Canvas |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Init |
| FSM PathId | 20423 |
| GameObject PathId | 5640 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Blob X | 0 | Single: 0 |
| Recover Time | 5 | Single: 5 |
| Timer | 0 | Single: 0 |

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| HP | 0 | Int32: 0 |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Recovery Blob | [null] | NamedAssetPPtr:  |

## States

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Hive Recovery Blob" | "Hive Recovery Blob" |  |  |
| storeResult | GameObject Recovery Blob | GameObject Recovery Blob | Variable |  |

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

_None_

### Pause

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

### Check

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Recovery Blob | OwnerDefault Recovery Blob |  |  |
| active | false | false |  |  |

##### 2. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "equippedCharm_29" | "equippedCharm_29" |  |  |
| isTrue | Event(HIVE) | Event(HIVE) |  |  |
| isFalse | Event(FINISHED) | Event(FINISHED) |  |  |

### Inert

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

_None_

### Reset Timer

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Timer | float Timer | Variable |  |
| floatValue | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Recovery Blob | OwnerDefault Recovery Blob |  |  |
| active | true | true |  |  |

##### 3. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Recovery Blob | OwnerDefault Recovery Blob |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Hive Health Recover1" | "Hive Health Recover1" |  |  |

##### 4. Tk2dPlayFrame

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayFrame
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Recovery Blob | OwnerDefault Recovery Blob |  |  |
| frame | 0 | 0 |  |  |

##### 5. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "health" | "health" |  |  |
| storeValue | int HP | int HP | Variable |  |

##### 6. ConvertIntToFloat

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int HP | int HP | Variable |  |
| floatVariable | float Blob X | float Blob X | Variable |  |
| everyFrame | false | false |  |  |

##### 7. FloatSubtract

Full Name: HutongGames.PlayMaker.Actions.FloatSubtract
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Blob X | float Blob X | Variable |  |
| subtract | 1f | 1f |  |  |
| everyFrame | false | false |  |  |
| perSecond | false | false |  |  |

##### 8. FloatMultiply

Full Name: HutongGames.PlayMaker.Actions.FloatMultiply
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Blob X | float Blob X | Variable |  |
| multiplyBy | 0.94f | 0.94f |  |  |
| everyFrame | false | false |  |  |

##### 9. FloatAdd

Full Name: HutongGames.PlayMaker.Actions.FloatAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Blob X | float Blob X | Variable |  |
| add | -10.32f | -10.32f |  |  |
| everyFrame | false | false |  |  |
| perSecond | false | false |  |  |

##### 10. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Recovery Blob | OwnerDefault Recovery Blob |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | float Blob X | float Blob X |  |  |
| y | 0f | 0f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

### Start Recovery

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

### Recover 1

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 4

#### Actions

##### 1. FloatAdd

Full Name: HutongGames.PlayMaker.Actions.FloatAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Timer | float Timer | Variable |  |
| add | 1f | 1f |  |  |
| everyFrame | true | true |  |  |
| perSecond | true | true |  |  |

##### 2. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float Timer | float Timer |  |  |
| float2 | float Recover Time | float Recover Time |  |  |
| tolerance | 0f | 0f |  |  |
| equal | Event(NEXT) | Event(NEXT) |  |  |
| lessThan | Event() | Event() |  |  |
| greaterThan | Event(NEXT) | Event(NEXT) |  |  |
| everyFrame | true | true |  |  |

### Recover 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 4

#### Actions

##### 1. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Timer | float Timer | Variable |  |
| floatValue | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Recovery Blob | OwnerDefault Recovery Blob |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Hive Health Recover2" | "Hive Health Recover2" |  |  |

##### 3. FloatAdd

Full Name: HutongGames.PlayMaker.Actions.FloatAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Timer | float Timer | Variable |  |
| add | 1f | 1f |  |  |
| everyFrame | true | true |  |  |
| perSecond | true | true |  |  |

##### 4. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float Timer | float Timer |  |  |
| float2 | float Recover Time | float Recover Time |  |  |
| tolerance | 0f | 0f |  |  |
| equal | Event(NEXT) | Event(NEXT) |  |  |
| lessThan | Event() | Event() |  |  |
| greaterThan | Event(NEXT) | Event(NEXT) |  |  |
| everyFrame | true | true |  |  |

### Recover

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Recovery Blob | OwnerDefault Recovery Blob |  |  |
| active | false | false |  |  |

##### 2. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| behaviour | "HeroController" | "HeroController" | Behaviour |  |
| methodName | "AddHealth" | "AddHealth" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var unnamed = 0 | Var unnamed = 0 | Variable | Store Result |

### Cancel Recovery

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Recovery Blob | OwnerDefault Recovery Blob |  |  |
| active | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Init | FINISHED | Pause | 0 | 0 | 0 |
| Idle | DAMAGE TAKEN | Start Recovery | 0 | 0 | 0 |
| Pause | FINISHED | Check | 0 | 0 | 0 |
| Check | NORMAL | Inert | 0 | 0 | 0 |
| Check | HIVE | Idle | 0 | 0 | 0 |
| Reset Timer | FINISHED | Recover 1 | 0 | 0 | 0 |
| Start Recovery | FINISHED | Reset Timer | 0 | 0 | 0 |
| Recover 1 | DAMAGE TAKEN | Start Recovery | 0 | 0 | 0 |
| Recover 1 | NEXT | Recover 2 | 0 | 0 | 0 |
| Recover 1 | HERO HEALED | Cancel Recovery | 0 | 0 | 0 |
| Recover 1 | HERO HEALED FULL | Cancel Recovery | 0 | 0 | 0 |
| Recover 2 | DAMAGE TAKEN | Start Recovery | 0 | 0 | 0 |
| Recover 2 | NEXT | Recover | 0 | 0 | 0 |
| Recover 2 | HERO HEALED | Cancel Recovery | 0 | 0 | 0 |
| Recover 2 | HERO HEALED FULL | Cancel Recovery | 0 | 0 | 0 |
| Recover | FINISHED | Idle | 0 | 0 | 0 |
| Cancel Recovery | FINISHED | Idle | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| CHARM INDICATOR CHECK | Check | 0 | 0 | 0 |
| HERO LEAVE | Check | 0 | 0 | 0 |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| CHARM INDICATOR CHECK | false |
| DAMAGE TAKEN | false |
| HERO HEALED | false |
| HERO HEALED FULL | false |
| HERO LEAVE | false |
| HIVE | false |
| NEXT | false |
| NORMAL | false |

