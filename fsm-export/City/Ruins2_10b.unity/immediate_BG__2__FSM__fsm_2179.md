# FSM

## Summary

| Field | Value |
| --- | --- |
| FSM Name | FSM |
| GameObject Name | immediate_BG (2) |
| GameObject Path | _Scenery/ |
| Source Asset | D:/SteamLibrary/steamapps/common/Hollow Knight/hollow_knight_Data/level123 |
| Start State | Pause |
| FSM PathId | 2179 |
| GameObject PathId | 676 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Offset X | 0 | Single: 0 |
| Offset Y | 0 | Single: 0 |
| Pos X | 0 | Single: 0 |
| Pos Y | 0 | Single: 0 |
| X Max | 6.79000092 | Single: 6.79000092 |
| X Min | 6.79000092 | Single: 6.79000092 |
| Y Max | 2000 | Single: 2000 |
| Y Min | 65.0999985 | Single: 65.0999985 |

### Vector2s

| Name | Value | Raw/Type |
| --- | --- | --- |
| Offset | Vector2(0, 0) | Vector2: Vector2(0, 0) |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Camera | [null] | NamedAssetPPtr: [null] |

## States

### Follow

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SetGameObject

Full Name: HutongGames.PlayMaker.Actions.SetGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variable |   | GameObject Camera | Variable |   |
| gameObject |   | [Global] GameObject MainCamera |   |   |
| everyFrame |   | false |   |   |

##### 2. GetVector2XY

Full Name: HutongGames.PlayMaker.Actions.GetVector2XY
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector2Variable |   | Vector2 Offset | Variable |   |
| storeX |   | float Offset X | Variable |   |
| storeY |   | float Offset Y | Variable |   |
| everyFrame |   | false |   |   |

##### 3. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Camera |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | float Pos X | Variable |   |
| y |   | float Pos Y | Variable |   |
| z |   | 0f | Variable |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | true |   |   |

##### 4. FloatAdd

Full Name: HutongGames.PlayMaker.Actions.FloatAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Pos X | Variable |   |
| add |   | float Offset X |   |   |
| everyFrame |   | true |   |   |
| perSecond |   | false |   |   |

##### 5. FloatAdd

Full Name: HutongGames.PlayMaker.Actions.FloatAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Pos Y | Variable |   |
| add |   | float Offset Y |   |   |
| everyFrame |   | true |   |   |
| perSecond |   | false |   |   |

##### 6. FloatClamp

Full Name: HutongGames.PlayMaker.Actions.FloatClamp
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Pos X | Variable |   |
| minValue |   | float X Min |   |   |
| maxValue |   | float X Max |   |   |
| everyFrame |   | true |   |   |

##### 7. FloatClamp

Full Name: HutongGames.PlayMaker.Actions.FloatClamp
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Pos Y | Variable |   |
| minValue |   | float Y Min |   |   |
| maxValue |   | float Y Max |   |   |
| everyFrame |   | true |   |   |

##### 8. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | float Pos X |   |   |
| y |   | float Pos Y |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | true |   |   |
| lateUpdate |   | false |   |   |

#### Transitions

(none)

### Pause

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

(none)

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Follow | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |

