# Knight Death Control

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Knight Death Control |
| GameObject Name | Knight Spike Death |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Stab |
| FSM PathId | 22941 |
| GameObject PathId | 6506 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Angle Max | 0 | Single: 0 |
| Angle Min | 0 | Single: 0 |
| Hero Angle | 0 | Single: 0 |
| Hero Scale | 0 | Single: 0 |
| Spike Direction | 0 | Single: 0 |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Pierces | Knight Spike Death/Pierces (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets) | NamedAssetPPtr: Knight Spike Death/Pierces (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets) |
| Self | [null] | NamedAssetPPtr:  |

## States

### Stab

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(BroadcastAll):FSM Owner | EventTarget(BroadcastAll):FSM Owner |  |  |
| sendEvent | "KNIGHT SPIKE HIT" | "KNIGHT SPIKE HIT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. ActivateAllChildren

Full Name: HutongGames.PlayMaker.Actions.ActivateAllChildren
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Knight Spike Death/Pierces (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Knight Spike Death/Pierces (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | Variable |  |
| activate | true | true |  |  |

##### 3. GetOwner

Full Name: HutongGames.PlayMaker.Actions.GetOwner
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeGameObject | GameObject Self | GameObject Self | Variable |  |

##### 4. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| behaviour | "GameManager" | "GameManager" | Behaviour |  |
| methodName | "SaveLevelState" | "SaveLevelState" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var unnamed = 0 | Var unnamed = 0 | Variable | Store Result |

##### 5. AudioPlayerOneShot

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShot
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClips | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| weights | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 6. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Hero | EventTarget(GameObject):Hero |  |  |
| sendEvent | "HAZARD DAMAGE" | "HAZARD DAMAGE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 7. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | FreezeMoment(1) | FreezeMoment(1) |  |  |

##### 8. FloatAdd

Full Name: HutongGames.PlayMaker.Actions.FloatAdd
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Spike Direction | float Spike Direction | Variable |  |
| add | 90f | 90f |  |  |
| everyFrame | false | false |  |  |
| perSecond | false | false |  |  |

##### 9. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObjectFSM)[SendToFSM: CameraShake]:CameraParent | EventTarget(GameObjectFSM)[SendToFSM: CameraShake]:CameraParent |  |  |
| sendEvent | "AverageShake" | "AverageShake" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 10. SetRotation

Full Name: HutongGames.PlayMaker.Actions.SetRotation
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Pierces | OwnerDefault Pierces |  |  |
| quaternion | Quaternion(0, 0, 0, 0) | Quaternion(0, 0, 0, 0) | Variable |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| xAngle | 0f | 0f |  |  |
| yAngle | 0f | 0f |  |  |
| zAngle | float Spike Direction | float Spike Direction |  |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 11. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Angle Min | float Angle Min | Variable |  |
| floatValue | float Spike Direction | float Spike Direction |  |  |
| everyFrame | false | false |  |  |

##### 12. FloatSubtract

Full Name: HutongGames.PlayMaker.Actions.FloatSubtract
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Angle Min | float Angle Min | Variable |  |
| subtract | 20f | 20f |  |  |
| everyFrame | false | false |  |  |
| perSecond | false | false |  |  |

##### 13. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Angle Max | float Angle Max | Variable |  |
| floatValue | float Spike Direction | float Spike Direction |  |  |
| everyFrame | false | false |  |  |

##### 14. FloatSubtract

Full Name: HutongGames.PlayMaker.Actions.FloatSubtract
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Angle Max | float Angle Max | Variable |  |
| subtract | -20f | -20f |  |  |
| everyFrame | false | false |  |  |
| perSecond | false | false |  |  |

##### 15. SetParent

Full Name: HutongGames.PlayMaker.Actions.SetParent
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Pierces | OwnerDefault Pierces |  |  |
| parent |  |  |  |  |
| resetLocalPosition | false | false |  |  |
| resetLocalRotation | false | false |  |  |

##### 16. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.3f | 0.3f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

##### 17. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector2(0, 0) | Vector2(0, 0) |  |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 18. SetGravity2dScale

Full Name: HutongGames.PlayMaker.Actions.SetGravity2dScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| gravityScale | 0f | 0f |  |  |

##### 19. GetScale

Full Name: HutongGames.PlayMaker.Actions.GetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| xScale | float Hero Scale | float Hero Scale | Variable |  |
| yScale | 0f | 0f | Variable |  |
| zScale | 0f | 0f | Variable |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |

##### 20. SetScale

Full Name: HutongGames.PlayMaker.Actions.SetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | float Hero Scale | float Hero Scale |  |  |
| y | 0f | 0f |  |  |
| z | 0f | 0f |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 21. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Spike Death Antic" | "Spike Death Antic" |  |  |

### Fling

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Spike Death" | "Spike Death" |  |  |

##### 2. SetGravity2dScale

Full Name: HutongGames.PlayMaker.Actions.SetGravity2dScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| gravityScale | 0.7f | 0.7f |  |  |

##### 3. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min | 80f | 80f |  |  |
| max | 100f | 100f |  |  |
| storeResult | float Hero Angle | float Hero Angle | Variable |  |

##### 4. SetVelocityAsAngle

Full Name: HutongGames.PlayMaker.Actions.SetVelocityAsAngle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| angle | float Hero Angle | float Hero Angle |  |  |
| speed | 20f | 20f |  |  |
| everyFrame | false | false |  |  |

##### 5. FaceDirection

Full Name: HutongGames.PlayMaker.Actions.FaceDirection
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| spriteFacesRight | true | true |  |  |
| playNewAnimation | false | false |  |  |
| newAnimationClip | "" | "" |  |  |
| everyFrame | true | true |  |  |
| pauseBetweenTurns | false | false |  |  |
| pauseTime | 0f | 0f |  |  |

### Recycle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. RecycleSelf

Full Name: HutongGames.PlayMaker.Actions.RecycleSelf
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Stab | FINISHED | Fling | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| HAZARD RELOAD | Recycle | 0 | 0 | 0 |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| HAZARD RELOAD | false |

