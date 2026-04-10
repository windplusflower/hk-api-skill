# Control

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Control |
| GameObject Name | Grimmchild |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Init |
| FSM PathId | 24995 |
| GameObject PathId | 7888 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Attack Timer | 0 | Single: 0 |
| Away Timer | 0 | Single: 0 |
| Distance | 0 | Single: 0 |
| Flameball Speed | 30 | Single: 30 |
| Hero Scale | 0 | Single: 0 |
| Offset X | 0 | Single: 0 |
| Offset Y | 0 | Single: 0 |
| Radius | 0 | Single: 0 |
| Ray Down Distance | 0 | Single: 0 |
| Speed | 0 | Single: 0 |

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Damage | 0 | Int32: 0 |
| Grimm Level | 0 | Int32: 0 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Away | false | Boolean: false |
| Dream Appear | false | Boolean: false |
| Not Away | false | Boolean: false |
| Scene Appear | false | Boolean: false |

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| Antic Anim |  | String:  |
| Fast Anim |  | String:  |
| Fly Anim |  | String:  |
| Level Str |  | String:  |
| Shoot Anim |  | String:  |
| Sleep Anim |  | String:  |
| Tele In Anim |  | String:  |
| Tele Out Anim |  | String:  |
| TurnFly Anim |  | String:  |
| Wake Anim |  | String:  |

### Vector3s

| Name | Value | Raw/Type |
| --- | --- | --- |
| Absorb Pos | Vector3(0, 0, 0) | Vector3: Vector3(0, 0, 0) |
| Offset | Vector3(0, 0, 0) | Vector3: Vector3(0, 0, 0) |
| Self Pos | Vector3(0, 0, 0) | Vector3: Vector3(0, 0, 0) |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Brumm Target | [null] | NamedAssetPPtr:  |
| Burst | Grimmchild/Burst (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets) | NamedAssetPPtr: Grimmchild/Burst (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets) |
| Burst 2 | Grimmchild/Burst 2 (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets) | NamedAssetPPtr: Grimmchild/Burst 2 (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets) |
| Damager | [null] | NamedAssetPPtr:  |
| Enemy Range | Grimmchild/Enemy Range (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets) | NamedAssetPPtr: Grimmchild/Enemy Range (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets) |
| Flame Burst | Grimmchild/Flame Burst (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets) | NamedAssetPPtr: Grimmchild/Flame Burst (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets) |
| Flame Point | Grimmchild/Flame Point (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets) | NamedAssetPPtr: Grimmchild/Flame Point (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets) |
| Flameball | [null] | NamedAssetPPtr:  |
| Self | [null] | NamedAssetPPtr:  |
| Target | [null] | NamedAssetPPtr:  |
| Voice Loop | Grimmchild/Voice Loop (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets) | NamedAssetPPtr: Grimmchild/Voice Loop (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets) |

## States

### Pause

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. NextFrameEvent

Full Name: HutongGames.PlayMaker.Actions.NextFrameEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent | Event(FINISHED) | Event(FINISHED) |  |  |

##### 2. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| z | 0.0058f | 0.0058f |  |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 3. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Attack Timer | float Attack Timer | Variable |  |
| floatValue | 2f | 2f |  |  |
| everyFrame | false | false |  |  |

##### 4. PlayerDataBoolTrueAndFalse

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTrueAndFalse
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| trueBool | "defeatedNightmareGrimm" | "defeatedNightmareGrimm" |  |  |
| falseBool | "grimmchildAwoken" | "grimmchildAwoken" |  |  |
| isTrue | Event(AWOKEN) | Event(AWOKEN) |  |  |
| isFalse | Event() | Event() |  |  |

##### 5. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Dream Appear | bool Dream Appear | Variable |  |
| isTrue | Event(DREAMGATE SPAWN) | Event(DREAMGATE SPAWN) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 6. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Scene Appear | bool Scene Appear | Variable |  |
| isTrue | Event(QUICK SPAWN) | Event(QUICK SPAWN) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

### Spawn

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| clipName | string Tele In Anim | string Tele In Anim |  |  |
| animationTriggerEvent | Event() | Event() |  |  |
| animationCompleteEvent | Event(FINISHED) | Event(FINISHED) |  |  |

##### 2. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| z | 0.0058f | 0.0058f |  |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 3. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Attack Timer | float Attack Timer | Variable |  |
| floatValue | 2f | 2f |  |  |
| everyFrame | false | false |  |  |

##### 4. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Burst 2 | OwnerDefault Burst 2 |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 5. AudioPlay

Full Name: HutongGames.PlayMaker.Actions.AudioPlay
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| volume | 0.7f | 0.7f |  |  |
| oneShotClip | [] | [] |  |  |
| finishedEvent | Event() | Event() |  |  |

##### 6. AudioPlaySimple

Full Name: HutongGames.PlayMaker.Actions.AudioPlaySimple
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Voice Loop | OwnerDefault Voice Loop |  |  |
| volume | 1f | 1f |  |  |
| oneShotClip | [] | [] |  |  |

##### 7. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [dream_ghost_appear (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [dream_ghost_appear (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| pitchMin | 1.5f | 1.5f |  |  |
| pitchMax | 1.5f | 1.5f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 8. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| z | 0.0058f | 0.0058f |  |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 9. SetRotation

Full Name: HutongGames.PlayMaker.Actions.SetRotation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| quaternion | Quaternion(0, 0, 0, 0) | Quaternion(0, 0, 0, 0) | Variable |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| xAngle | 0f | 0f |  |  |
| yAngle | 0f | 0f |  |  |
| zAngle | 0f | 0f |  |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

### Follow

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. FloatSubtract

Full Name: HutongGames.PlayMaker.Actions.FloatSubtract
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Attack Timer | float Attack Timer | Variable |  |
| subtract | 1f | 1f |  |  |
| everyFrame | true | true |  |  |
| perSecond | true | true |  |  |

##### 2. SetRotation

Full Name: HutongGames.PlayMaker.Actions.SetRotation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| quaternion | Quaternion(0, 0, 0, 0) | Quaternion(0, 0, 0, 0) | Variable |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| xAngle | 0f | 0f |  |  |
| yAngle | 0f | 0f |  |  |
| zAngle | 0f | 0f |  |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 3. AudioPlaySimple

Full Name: HutongGames.PlayMaker.Actions.AudioPlaySimple
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Voice Loop | OwnerDefault Voice Loop |  |  |
| volume | 1f | 1f |  |  |
| oneShotClip | [] | [] |  |  |

##### 4. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float Attack Timer | float Attack Timer |  |  |
| float2 | 0f | 0f |  |  |
| tolerance | 0f | 0f |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event(CHECK) | Event(CHECK) |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | true | true |  |  |

##### 5. SetCircleCollider

Full Name: HutongGames.PlayMaker.Actions.SetCircleCollider
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | true | true |  |  |

##### 6. GrimmChildFly

Full Name: HutongGames.PlayMaker.Actions.GrimmChildFly
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| objectA | GameObject Self | GameObject Self |  |  |
| objectB | [Global] GameObject Hero | [Global] GameObject Hero | Variable |  |
| spriteFacesRight | true | true |  |  |
| playNewAnimation | true | true |  |  |
| newAnimationClip | string TurnFly Anim | string TurnFly Anim |  |  |
| resetFrame | true | true |  |  |
| fastAnimSpeed | 10f | 10f |  |  |
| fastAnimationClip | string Fast Anim | string Fast Anim |  |  |
| normalAnimationClip | string Fly Anim | string Fly Anim |  |  |
| pauseBetweenAnimChange | 0.3f | 0.3f |  |  |
| flyingFast | false | false |  |  |

##### 7. GetDistance

Full Name: HutongGames.PlayMaker.Actions.GetDistance
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| target | [Global] GameObject Hero | [Global] GameObject Hero |  |  |
| storeResult | float Distance | float Distance | Variable |  |
| everyFrame | true | true |  |  |

##### 8. FloatMultiply

Full Name: HutongGames.PlayMaker.Actions.FloatMultiply
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Distance | float Distance | Variable |  |
| multiplyBy | 1.15f | 1.15f |  |  |
| everyFrame | true | true |  |  |

##### 9. FloatTestToBool

Full Name: HutongGames.PlayMaker.Actions.FloatTestToBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float Distance | float Distance |  |  |
| float2 | 10f | 10f |  |  |
| tolerance | 0f | 0f |  |  |
| equalBool | false | false | Variable |  |
| lessThanBool | false | false | Variable |  |
| greaterThanBool | bool Away | bool Away | Variable |  |
| everyFrame | true | true |  |  |

##### 10. FloatOperator

Full Name: HutongGames.PlayMaker.Actions.FloatOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float Distance | float Distance |  |  |
| float2 | 4f | 4f |  |  |
| operation | HutongGames.PlayMaker.Actions.FloatOperator/Operation::Add | 0 |  |  |
| storeResult | float Speed | float Speed | Variable |  |
| everyFrame | true | true |  |  |

##### 11. FloatClamp

Full Name: HutongGames.PlayMaker.Actions.FloatClamp
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Speed | float Speed | Variable |  |
| minValue | 4f | 4f |  |  |
| maxValue | 18f | 18f |  |  |
| everyFrame | true | true |  |  |

##### 12. DistanceFlySmooth

Full Name: HutongGames.PlayMaker.Actions.DistanceFlySmooth
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner | Variable |  |
| target | [Global] GameObject Hero | [Global] GameObject Hero | Variable |  |
| distance | 0f | 0f |  |  |
| speedMax | float Speed | float Speed |  |  |
| accelerationForce | 50f | 50f |  |  |
| targetRadius | float Radius | float Radius |  |  |
| deceleration | 0.9f | 0.9f |  |  |
| offset | Vector3 Offset | Vector3 Offset |  |  |

##### 13. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector3 Self Pos | Vector3 Self Pos | Variable |  |
| x | 0f | 0f | Variable |  |
| y | 0f | 0f | Variable |  |
| z | 0f | 0f | Variable |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | true | true |  |  |

##### 14. FloatAddV2

Full Name: HutongGames.PlayMaker.Actions.FloatAddV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Away Timer | float Away Timer | Variable |  |
| add | 1f | 1f |  |  |
| everyFrame | true | true |  |  |
| perSecond | true | true |  |  |
| fixedUpdate | false | false |  |  |
| activeBool | bool Away | bool Away | Variable |  |

##### 15. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Not Away | bool Not Away | Variable |  |
| boolValue | bool Away | bool Away |  |  |
| everyFrame | true | true |  |  |

##### 16. BoolFlipEveryFrame

Full Name: HutongGames.PlayMaker.Actions.BoolFlipEveryFrame
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Not Away | bool Not Away | Variable |  |
| everyFrame | true | true |  |  |

##### 17. SetFloatValueV2

Full Name: HutongGames.PlayMaker.Actions.SetFloatValueV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Away Timer | float Away Timer | Variable |  |
| floatValue | 0f | 0f |  |  |
| everyFrame | true | true |  |  |
| activeBool | bool Not Away | bool Not Away |  |  |

##### 18. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float Away Timer | float Away Timer |  |  |
| float2 | 2f | 2f |  |  |
| tolerance | 0f | 0f |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event() | Event() |  |  |
| greaterThan | Event(TELE) | Event(TELE) |  |  |
| everyFrame | true | true |  |  |

##### 19. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.25f | 0.25f |  |  |
| finishEvent | Event(CHANGE) | Event(CHANGE) |  |  |
| realTime | false | false |  |  |

### Change

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Scene Appear | bool Scene Appear | Variable |  |
| boolValue | false | false |  |  |
| everyFrame | false | false |  |  |

##### 2. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Offset X | float Offset X | Variable |  |
| floatValue | 2f | 2f |  |  |
| everyFrame | false | false |  |  |

##### 3. GetScale

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

##### 4. FloatMultiply

Full Name: HutongGames.PlayMaker.Actions.FloatMultiply
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Offset X | float Offset X | Variable |  |
| multiplyBy | float Hero Scale | float Hero Scale |  |  |
| everyFrame | false | false |  |  |

##### 5. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min | 1.85f | 1.85f |  |  |
| max | 2f | 2f |  |  |
| storeResult | float Offset Y | float Offset Y | Variable |  |

##### 6. SetVector3XYZ

Full Name: HutongGames.PlayMaker.Actions.SetVector3XYZ
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable | Vector3 Offset | Vector3 Offset | Variable |  |
| vector3Value | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | float Offset X | float Offset X |  |  |
| y | float Offset Y | float Offset Y |  |  |
| z | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 7. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min | 0.25f | 0.25f |  |  |
| max | 0.25f | 0.25f |  |  |
| storeResult | float Radius | float Radius | Variable |  |

### Tele Start

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. DecelerateV2

Full Name: HutongGames.PlayMaker.Actions.DecelerateV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| deceleration | 0.85f | 0.85f |  |  |

##### 2. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| clipName | string Tele Out Anim | string Tele Out Anim |  |  |
| animationTriggerEvent | Event() | Event() |  |  |
| animationCompleteEvent | Event(FINISHED) | Event(FINISHED) |  |  |

##### 3. AudioStop

Full Name: HutongGames.PlayMaker.Actions.AudioStop
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Voice Loop | OwnerDefault Voice Loop |  |  |

##### 4. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [hornet_jump (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [hornet_jump (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| pitchMin | 1.25f | 1.25f |  |  |
| pitchMax | 1.25f | 1.25f |  |  |
| volume | 0.65f | 0.65f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 5

#### Actions

##### 1. GetOwner

Full Name: HutongGames.PlayMaker.Actions.GetOwner
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeGameObject | GameObject Self | GameObject Self | Variable |  |

##### 2. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| z | -0.011f | -0.011f |  |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 3. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | true | true |  |  |

##### 4. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "grimmChildLevel" | "grimmChildLevel" |  |  |
| storeValue | int Grimm Level | int Grimm Level | Variable |  |

##### 5. ConvertIntToString

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Grimm Level | int Grimm Level | Variable |  |
| stringVariable | string Level Str | string Level Str | Variable |  |
| format | "" | "" |  |  |
| everyFrame | false | false |  |  |

##### 6. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | string Level Str | string Level Str |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Rest Pause

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SetVelocity

Full Name: HutongGames.PlayMaker.Actions.SetVelocity
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |

##### 2. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animLibName | "" | "" |  |  |
| clipName | string Fly Anim | string Fly Anim |  |  |

##### 3. IdleBuzzV3

Full Name: HutongGames.PlayMaker.Actions.IdleBuzzV3
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| waitMin | 0.75f | 0.75f |  |  |
| waitMax | 1f | 1f |  |  |
| speedMax | 2f | 2f |  |  |
| accelerationMin | 30f | 30f |  |  |
| accelerationMax | 50f | 50f |  |  |
| roamingRangeX | 1f | 1f |  |  |
| roamingRangeY | 1f | 1f |  |  |
| manualStartPos | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |

##### 4. WaitRandom

Full Name: HutongGames.PlayMaker.Actions.WaitRandom
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| timeMin | 2f | 2f |  |  |
| timeMax | 5f | 5f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

##### 5. FaceDirection

Full Name: HutongGames.PlayMaker.Actions.FaceDirection
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| spriteFacesRight | true | true |  |  |
| playNewAnimation | true | true |  |  |
| newAnimationClip | string TurnFly Anim | string TurnFly Anim |  |  |
| everyFrame | true | true |  |  |
| pauseBetweenTurns | true | true |  |  |
| pauseTime | 0.5f | 0.5f |  |  |

##### 6. AudioStop

Full Name: HutongGames.PlayMaker.Actions.AudioStop
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Voice Loop | OwnerDefault Voice Loop |  |  |

### Lower

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animLibName | "" | "" |  |  |
| clipName | string Fly Anim | string Fly Anim |  |  |

##### 2. AddForce2d

Full Name: HutongGames.PlayMaker.Actions.AddForce2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| forceMode | UnityEngine.ForceMode2D::Force | 0 |  |  |
| atPosition | Vector2(0, 0) | Vector2(0, 0) | Variable |  |
| vector | Vector2(0, 0) | Vector2(0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | -5f | -5f |  |  |
| vector3 | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| everyFrame | true | true |  |  |

##### 3. DecelerateXY

Full Name: HutongGames.PlayMaker.Actions.DecelerateXY
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| decelerationX | 0.85f | 0.85f |  |  |
| decelerationY | 0f | 0f |  |  |

##### 4. FaceDirection

Full Name: HutongGames.PlayMaker.Actions.FaceDirection
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| spriteFacesRight | false | false |  |  |
| playNewAnimation | true | true |  |  |
| newAnimationClip | string TurnFly Anim | string TurnFly Anim |  |  |
| everyFrame | true | true |  |  |
| pauseBetweenTurns | true | true |  |  |
| pauseTime | 0.5f | 0.5f |  |  |

##### 5. CheckCollisionSide

Full Name: HutongGames.PlayMaker.Actions.CheckCollisionSide
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| topHit | false | false | Variable |  |
| rightHit | false | false | Variable |  |
| bottomHit | false | false | Variable |  |
| leftHit | false | false | Variable |  |
| topHitEvent | Event() | Event() |  |  |
| rightHitEvent | Event() | Event() |  |  |
| bottomHitEvent | Event(LAND) | Event(LAND) |  |  |
| leftHitEvent | Event() | Event() |  |  |
| otherLayer | false | false |  |  |
| otherLayerNumber | 0 | 0 |  |  |
| ignoreTriggers | false | false |  |  |

##### 6. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| z | 0.0031f | 0.0031f |  |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

### Rest Start

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. AudioStop

Full Name: HutongGames.PlayMaker.Actions.AudioStop
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |

##### 2. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector2(0, 0) | Vector2(0, 0) |  |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animLibName | "" | "" |  |  |
| clipName | string Sleep Anim | string Sleep Anim |  |  |

### Wake

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| clipName | string Wake Anim | string Wake Anim |  |  |
| animationTriggerEvent | Event() | Event() |  |  |
| animationCompleteEvent | Event(FINISHED) | Event(FINISHED) |  |  |

##### 2. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| z | 0.0058f | 0.0058f |  |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

### At Bench?

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
| boolName | "atBench" | "atBench" |  |  |
| isTrue | Event(BENCH) | Event(BENCH) |  |  |
| isFalse | Event() | Event() |  |  |

### Warp Pause

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. RandomWait

Full Name: HutongGames.PlayMaker.Actions.RandomWait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min | 0.2f | 0.2f |  |  |
| max | 0.7f | 0.7f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

##### 2. DecelerateV2

Full Name: HutongGames.PlayMaker.Actions.DecelerateV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| deceleration | 0.8f | 0.8f |  |  |

##### 3. AudioStop

Full Name: HutongGames.PlayMaker.Actions.AudioStop
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Voice Loop | OwnerDefault Voice Loop |  |  |

### Warp Out

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector2(0, 0) | Vector2(0, 0) |  |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| clipName | string Tele Out Anim | string Tele Out Anim |  |  |
| animationTriggerEvent | Event() | Event() |  |  |
| animationCompleteEvent | Event(FINISHED) | Event(FINISHED) |  |  |

##### 3. SetCircleCollider

Full Name: HutongGames.PlayMaker.Actions.SetCircleCollider
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | false | false |  |  |

##### 4. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [hornet_jump (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [hornet_jump (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| pitchMin | 1.25f | 1.25f |  |  |
| pitchMax | 1.25f | 1.25f |  |  |
| volume | 0.65f | 0.65f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

### Warped Out

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | false | false |  |  |

### Warp In Pause

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. RandomWait

Full Name: HutongGames.PlayMaker.Actions.RandomWait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min | 1.5f | 1.5f |  |  |
| max | 2f | 2f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

##### 2. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | false | false |  |  |

##### 3. AudioStop

Full Name: HutongGames.PlayMaker.Actions.AudioStop
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Voice Loop | OwnerDefault Voice Loop |  |  |

### Level 1

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Antic Anim | string Antic Anim | Variable |  |
| stringValue | "Antic 2" | "Antic 2" | TextArea |  |
| everyFrame | false | false |  |  |

##### 2. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Fly Anim | string Fly Anim | Variable |  |
| stringValue | "Idle 1" | "Idle 1" | TextArea |  |
| everyFrame | false | false |  |  |

##### 3. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Fast Anim | string Fast Anim | Variable |  |
| stringValue | "Fly 1" | "Fly 1" | TextArea |  |
| everyFrame | false | false |  |  |

##### 4. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Shoot Anim | string Shoot Anim | Variable |  |
| stringValue | "Shoot 2" | "Shoot 2" | TextArea |  |
| everyFrame | false | false |  |  |

##### 5. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Sleep Anim | string Sleep Anim | Variable |  |
| stringValue | "Sleep 1" | "Sleep 1" | TextArea |  |
| everyFrame | false | false |  |  |

##### 6. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Wake Anim | string Wake Anim | Variable |  |
| stringValue | "Wake 1" | "Wake 1" | TextArea |  |
| everyFrame | false | false |  |  |

##### 7. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string TurnFly Anim | string TurnFly Anim | Variable |  |
| stringValue | "TurnToIdle 1" | "TurnToIdle 1" | TextArea |  |
| everyFrame | false | false |  |  |

##### 8. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Tele In Anim | string Tele In Anim | Variable |  |
| stringValue | "Tele In 1" | "Tele In 1" | TextArea |  |
| everyFrame | false | false |  |  |

##### 9. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Tele Out Anim | string Tele Out Anim | Variable |  |
| stringValue | "Tele Out 1" | "Tele Out 1" | TextArea |  |
| everyFrame | false | false |  |  |

##### 10. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Ray Down Distance | float Ray Down Distance | Variable |  |
| floatValue | 0.8f | 0.8f |  |  |
| everyFrame | false | false |  |  |

##### 11. SetAudioPitch

Full Name: HutongGames.PlayMaker.Actions.SetAudioPitch
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Voice Loop | OwnerDefault Voice Loop |  |  |
| pitch | 1.5f | 1.5f |  |  |
| everyFrame | false | false |  |  |

### Level 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Damage | int Damage | Variable |  |
| intValue | 5 | 5 |  |  |
| everyFrame | false | false |  |  |

##### 2. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Antic Anim | string Antic Anim | Variable |  |
| stringValue | "Antic 2" | "Antic 2" | TextArea |  |
| everyFrame | false | false |  |  |

##### 3. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Fly Anim | string Fly Anim | Variable |  |
| stringValue | "Idle 2" | "Idle 2" | TextArea |  |
| everyFrame | false | false |  |  |

##### 4. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Fast Anim | string Fast Anim | Variable |  |
| stringValue | "Fly 2" | "Fly 2" | TextArea |  |
| everyFrame | false | false |  |  |

##### 5. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Shoot Anim | string Shoot Anim | Variable |  |
| stringValue | "Shoot 2" | "Shoot 2" | TextArea |  |
| everyFrame | false | false |  |  |

##### 6. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Sleep Anim | string Sleep Anim | Variable |  |
| stringValue | "Sleep 2" | "Sleep 2" | TextArea |  |
| everyFrame | false | false |  |  |

##### 7. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Wake Anim | string Wake Anim | Variable |  |
| stringValue | "Wake 2" | "Wake 2" | TextArea |  |
| everyFrame | false | false |  |  |

##### 8. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string TurnFly Anim | string TurnFly Anim | Variable |  |
| stringValue | "TurnToIdle 2" | "TurnToIdle 2" | TextArea |  |
| everyFrame | false | false |  |  |

##### 9. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Tele In Anim | string Tele In Anim | Variable |  |
| stringValue | "Tele In 2" | "Tele In 2" | TextArea |  |
| everyFrame | false | false |  |  |

##### 10. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Tele Out Anim | string Tele Out Anim | Variable |  |
| stringValue | "Tele Out 2" | "Tele Out 2" | TextArea |  |
| everyFrame | false | false |  |  |

##### 11. SetAudioPitch

Full Name: HutongGames.PlayMaker.Actions.SetAudioPitch
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Voice Loop | OwnerDefault Voice Loop |  |  |
| pitch | 1.5f | 1.5f |  |  |
| everyFrame | false | false |  |  |

### Level 3

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Damage | int Damage | Variable |  |
| intValue | 8 | 8 |  |  |
| everyFrame | false | false |  |  |

##### 2. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Antic Anim | string Antic Anim | Variable |  |
| stringValue | "Antic 3" | "Antic 3" | TextArea |  |
| everyFrame | false | false |  |  |

##### 3. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Fly Anim | string Fly Anim | Variable |  |
| stringValue | "Idle 3" | "Idle 3" | TextArea |  |
| everyFrame | false | false |  |  |

##### 4. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Fast Anim | string Fast Anim | Variable |  |
| stringValue | "Fly 3" | "Fly 3" | TextArea |  |
| everyFrame | false | false |  |  |

##### 5. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Shoot Anim | string Shoot Anim | Variable |  |
| stringValue | "Shoot 3" | "Shoot 3" | TextArea |  |
| everyFrame | false | false |  |  |

##### 6. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Sleep Anim | string Sleep Anim | Variable |  |
| stringValue | "Sleep 3" | "Sleep 3" | TextArea |  |
| everyFrame | false | false |  |  |

##### 7. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Wake Anim | string Wake Anim | Variable |  |
| stringValue | "Wake 3" | "Wake 3" | TextArea |  |
| everyFrame | false | false |  |  |

##### 8. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string TurnFly Anim | string TurnFly Anim | Variable |  |
| stringValue | "TurnToIdle 3" | "TurnToIdle 3" | TextArea |  |
| everyFrame | false | false |  |  |

##### 9. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Tele In Anim | string Tele In Anim | Variable |  |
| stringValue | "Tele In 3" | "Tele In 3" | TextArea |  |
| everyFrame | false | false |  |  |

##### 10. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Tele Out Anim | string Tele Out Anim | Variable |  |
| stringValue | "Tele Out 3" | "Tele Out 3" | TextArea |  |
| everyFrame | false | false |  |  |

##### 11. SetAudioPitch

Full Name: HutongGames.PlayMaker.Actions.SetAudioPitch
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Voice Loop | OwnerDefault Voice Loop |  |  |
| pitch | 1.5f | 1.5f |  |  |
| everyFrame | false | false |  |  |

### Tele

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | float Offset X | float Offset X | Variable |  |
| y | float Offset Y | float Offset Y | Variable |  |
| z | 0f | 0f | Variable |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |

##### 2. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | float Offset X | float Offset X |  |  |
| y | float Offset Y | float Offset Y |  |  |
| z | -0.011f | -0.011f |  |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 3. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [dream_ghost_appear (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [dream_ghost_appear (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| pitchMin | 1.5f | 1.5f |  |  |
| pitchMax | 1.5f | 1.5f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 4. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | true | true |  |  |

### Despawn

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. DecelerateV2

Full Name: HutongGames.PlayMaker.Actions.DecelerateV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| deceleration | 0.85f | 0.85f |  |  |

##### 2. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| clipName | string Tele Out Anim | string Tele Out Anim |  |  |
| animationTriggerEvent | Event() | Event() |  |  |
| animationCompleteEvent | Event(FINISHED) | Event(FINISHED) |  |  |

##### 3. AudioStop

Full Name: HutongGames.PlayMaker.Actions.AudioStop
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Voice Loop | OwnerDefault Voice Loop |  |  |

##### 4. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [hollow_knight_self_stab_prepare (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [hollow_knight_self_stab_prepare (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| pitchMin | 1.25f | 1.25f |  |  |
| pitchMax | 1.25f | 1.25f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

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

### Level 4

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Damage | int Damage | Variable |  |
| intValue | 11 | 11 |  |  |
| everyFrame | false | false |  |  |

##### 2. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Antic Anim | string Antic Anim | Variable |  |
| stringValue | "Antic 4" | "Antic 4" | TextArea |  |
| everyFrame | false | false |  |  |

##### 3. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Fly Anim | string Fly Anim | Variable |  |
| stringValue | "Idle 4" | "Idle 4" | TextArea |  |
| everyFrame | false | false |  |  |

##### 4. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Fast Anim | string Fast Anim | Variable |  |
| stringValue | "Fly 4" | "Fly 4" | TextArea |  |
| everyFrame | false | false |  |  |

##### 5. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Shoot Anim | string Shoot Anim | Variable |  |
| stringValue | "Shoot 4" | "Shoot 4" | TextArea |  |
| everyFrame | false | false |  |  |

##### 6. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Sleep Anim | string Sleep Anim | Variable |  |
| stringValue | "Sleep 4" | "Sleep 4" | TextArea |  |
| everyFrame | false | false |  |  |

##### 7. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Wake Anim | string Wake Anim | Variable |  |
| stringValue | "Wake 4" | "Wake 4" | TextArea |  |
| everyFrame | false | false |  |  |

##### 8. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string TurnFly Anim | string TurnFly Anim | Variable |  |
| stringValue | "TurnToIdle 4" | "TurnToIdle 4" | TextArea |  |
| everyFrame | false | false |  |  |

##### 9. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Tele In Anim | string Tele In Anim | Variable |  |
| stringValue | "Tele In 4" | "Tele In 4" | TextArea |  |
| everyFrame | false | false |  |  |

##### 10. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Tele Out Anim | string Tele Out Anim | Variable |  |
| stringValue | "Tele Out 4" | "Tele Out 4" | TextArea |  |
| everyFrame | false | false |  |  |

##### 11. SetAudioPitch

Full Name: HutongGames.PlayMaker.Actions.SetAudioPitch
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Voice Loop | OwnerDefault Voice Loop |  |  |
| pitch | 1.25f | 1.25f |  |  |
| everyFrame | false | false |  |  |

### Check For Target

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Grimm Level | int Grimm Level |  |  |
| integer2 | 1 | 1 |  |  |
| equal | Event(1) | Event(1) |  |  |
| lessThan | Event(1) | Event(1) |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 2. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Enemy Range | OwnerDefault Enemy Range |  |  |
| behaviour | "GrimmEnemyRange" | "GrimmEnemyRange" | Behaviour |  |
| methodName | "GetTarget" | "GetTarget" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var Target =  | Var Target =  | Variable | Store Result |

##### 3. GameObjectIsNull

Full Name: HutongGames.PlayMaker.Actions.GameObjectIsNull
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Target | GameObject Target | Variable |  |
| isNull | Event(NO TARGET) | Event(NO TARGET) |  |  |
| isNotNull | Event(TARGET) | Event(TARGET) |  |  |
| storeResult | false | false | Variable |  |
| everyFrame | false | false |  |  |

### No Target

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Attack Timer | float Attack Timer | Variable |  |
| floatValue | 0.75f | 0.75f |  |  |
| everyFrame | false | false |  |  |

### Antic

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GameObjectIsNull

Full Name: HutongGames.PlayMaker.Actions.GameObjectIsNull
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Target | GameObject Target | Variable |  |
| isNull | Event(CANCEL) | Event(CANCEL) |  |  |
| isNotNull | Event() | Event() |  |  |
| storeResult | false | false | Variable |  |
| everyFrame | false | false |  |  |

##### 2. FaceObject

Full Name: HutongGames.PlayMaker.Actions.FaceObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| objectA | GameObject Self | GameObject Self |  |  |
| objectB | GameObject Target | GameObject Target | Variable |  |
| spriteFacesRight | true | true |  |  |
| playNewAnimation | false | false |  |  |
| newAnimationClip | "" | "" |  |  |
| resetFrame | false | false |  |  |
| everyFrame | false | false |  |  |

##### 3. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| clipName | string Antic Anim | string Antic Anim |  |  |
| animationTriggerEvent | Event() | Event() |  |  |
| animationCompleteEvent | Event(FINISHED) | Event(FINISHED) |  |  |

##### 4. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min | 1.5f | 1.5f |  |  |
| max | 1.5f | 1.5f |  |  |
| storeResult | float Attack Timer | float Attack Timer | Variable |  |

##### 5. DistanceFlySmooth

Full Name: HutongGames.PlayMaker.Actions.DistanceFlySmooth
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner | Variable |  |
| target | [Global] GameObject Hero | [Global] GameObject Hero | Variable |  |
| distance | 0f | 0f |  |  |
| speedMax | float Speed | float Speed |  |  |
| accelerationForce | 50f | 50f |  |  |
| targetRadius | float Radius | float Radius |  |  |
| deceleration | 0.9f | 0.9f |  |  |
| offset | Vector3 Offset | Vector3 Offset |  |  |

##### 6. AudioStop

Full Name: HutongGames.PlayMaker.Actions.AudioStop
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Voice Loop | OwnerDefault Voice Loop |  |  |

##### 7. AudioPlayerOneShot

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShot
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClips | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| weights | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| pitchMin | 1.45f | 1.45f |  |  |
| pitchMax | 1.55f | 1.55f |  |  |
| volume | 0.6f | 0.6f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

### Lv 1

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Attack Timer | float Attack Timer | Variable |  |
| floatValue | 9999f | 9999f |  |  |
| everyFrame | false | false |  |  |

### Shoot

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GameObjectIsNull

Full Name: HutongGames.PlayMaker.Actions.GameObjectIsNull
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Target | GameObject Target | Variable |  |
| isNull | Event(CANCEL) | Event(CANCEL) |  |  |
| isNotNull | Event() | Event() |  |  |
| storeResult | false | false | Variable |  |
| everyFrame | false | false |  |  |

##### 2. FaceObject

Full Name: HutongGames.PlayMaker.Actions.FaceObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| objectA | GameObject Self | GameObject Self |  |  |
| objectB | GameObject Target | GameObject Target | Variable |  |
| spriteFacesRight | true | true |  |  |
| playNewAnimation | false | false |  |  |
| newAnimationClip | "" | "" |  |  |
| resetFrame | false | false |  |  |
| everyFrame | false | false |  |  |

##### 3. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| clipName | string Shoot Anim | string Shoot Anim |  |  |
| animationTriggerEvent | Event() | Event() |  |  |
| animationCompleteEvent | Event(FINISHED) | Event(FINISHED) |  |  |

##### 4. DecelerateV2

Full Name: HutongGames.PlayMaker.Actions.DecelerateV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| deceleration | 0.8f | 0.8f |  |  |

##### 5. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Grimmball (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Grimmball (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | [Grimmchild/Flame Point (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Grimmchild/Flame Point (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| rotation | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| storeObject | GameObject Flameball | GameObject Flameball | Variable |  |

##### 6. GetChild

Full Name: HutongGames.PlayMaker.Actions.GetChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Flameball | OwnerDefault Flameball |  |  |
| childName | "Enemy Damager" | "Enemy Damager" |  |  |
| withTag | "Untagged" | "Untagged" | Tag |  |
| storeResult | GameObject Damager | GameObject Damager | Variable |  |

##### 7. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Damager | OwnerDefault Damager |  |  |
| fsmName | "Attack" | "Attack" | FsmName |  |
| variableName | "Damage" | "Damage" | FsmInt |  |
| setValue | int Damage | int Damage |  |  |
| everyFrame | false | false |  |  |

##### 8. FireAtTarget

Full Name: HutongGames.PlayMaker.Actions.FireAtTarget
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Flameball | OwnerDefault Flameball |  |  |
| target | GameObject Target | GameObject Target |  |  |
| speed | float Flameball Speed | float Flameball Speed |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| spread | 15f | 15f |  |  |
| everyFrame | false | false |  |  |

##### 9. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Flame Burst | OwnerDefault Flame Burst |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 10. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [grimmchild_fireball_shoot (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [grimmchild_fireball_shoot (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| pitchMin | 0.9f | 0.9f |  |  |
| pitchMax | 1.1f | 1.1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

### Burst Out

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Burst | OwnerDefault Burst |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 2. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | false | false |  |  |

##### 3. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.16f | 0.16f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Burst Out 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Burst | OwnerDefault Burst |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 2. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | false | false |  |  |

##### 3. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.16f | 0.16f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Absorb Tween

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetScale

Full Name: HutongGames.PlayMaker.Actions.SetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 1f | 1f |  |  |
| y | 0f | 0f |  |  |
| z | 0f | 0f |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 2. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector2(0, 0) | Vector2(0, 0) |  |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Fly 2" | "Fly 2" |  |  |

##### 4. iTweenMoveTo

Full Name: HutongGames.PlayMaker.Actions.iTweenMoveTo
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| id | "" | "" |  |  |
| transformPosition |  |  |  |  |
| vectorPosition | Vector3 Absorb Pos | Vector3 Absorb Pos |  |  |
| time | 0.5f | 0.5f |  |  |
| delay | 0f | 0f |  |  |
| speed | 0f | 0f |  |  |
| space | UnityEngine.Space::World | 0 |  |  |
| easeType | iTween/EaseType::easeInSine | 12 |  |  |
| loopType | iTween/LoopType::none | 0 |  |  |
| orientToPath | false | false |  | LookAt |
| lookAtObject |  |  |  |  |
| lookAtVector | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| lookTime | 0f | 0f |  |  |
| axis | HutongGames.PlayMaker.Actions.iTweenFsmAction/AxisRestriction::none | 0 |  |  |
| moveToPath | false | false |  | Path |
| lookAhead | 0f | 0f |  |  |
| transforms | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| vectors | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| reverse | false | false |  |  |
| startEvent | Event() | Event() |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |
| stopOnExit | true | true |  |  |
| loopDontFinish | true | true |  |  |

##### 5. AudioStop

Full Name: HutongGames.PlayMaker.Actions.AudioStop
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Voice Loop | OwnerDefault Voice Loop |  |  |

##### 6. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| z | 0.001f | 0.001f |  |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

### Absorb

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(BroadcastAll):FSM Owner | EventTarget(BroadcastAll):FSM Owner |  |  |
| sendEvent | "ABSORB END" | "ABSORB END" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | false | false |  |  |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 4. AudioStop

Full Name: HutongGames.PlayMaker.Actions.AudioStop
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |

### Set Pos

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 80.6f | 80.6f |  |  |
| y | 9.8f | 9.8f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 2. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | true | true |  |  |

##### 3. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Enemy Range | OwnerDefault Enemy Range |  |  |
| behaviour | "GrimmEnemyRange" | "GrimmEnemyRange" | Behaviour |  |
| methodName | "ClearEnemyList" | "ClearEnemyList" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var unnamed = 0 | Var unnamed = 0 | Variable | Store Result |

### Brumm Shoulder

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
| clipName | string TurnFly Anim | string TurnFly Anim |  |  |

##### 2. SetScale

Full Name: HutongGames.PlayMaker.Actions.SetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | -1f | -1f |  |  |
| y | 0f | 0f |  |  |
| z | 0f | 0f |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 3. FindGameObject

Full Name: HutongGames.PlayMaker.Actions.FindGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| objectName | "Brumm Shoulder" | "Brumm Shoulder" |  |  |
| withTag | "Extra Tag" | "Extra Tag" | Tag |  |
| store | GameObject Brumm Target | GameObject Brumm Target | Variable |  |

##### 4. DistanceFlySmooth

Full Name: HutongGames.PlayMaker.Actions.DistanceFlySmooth
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner | Variable |  |
| target | GameObject Brumm Target | GameObject Brumm Target | Variable |  |
| distance | 0f | 0f |  |  |
| speedMax | float Speed | float Speed |  |  |
| accelerationForce | 50f | 50f |  |  |
| targetRadius | 0.25f | 0.25f |  |  |
| deceleration | 0.9f | 0.9f |  |  |
| offset | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |

##### 5. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector2(0, 0) | Vector2(0, 0) |  |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Reset Anim

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
| clipName | string Fly Anim | string Fly Anim |  |  |

##### 2. Tk2dPlayFrame

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayFrame
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| frame | 1 | 1 |  |  |

### Awake Ready

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName | "grimmchildAwoken" | "grimmchildAwoken" |  |  |
| value | true | true |  |  |

##### 2. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animLibName | "" | "" |  |  |
| clipName | string Sleep Anim | string Sleep Anim |  |  |

##### 3. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector2(0, -5) | Vector2(0, -5) |  |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| everyFrame | true | true |  |  |

##### 4. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 4f | 4f |  |  |
| y | 0f | 0f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::World | 0 |  |  |
| perSecond | false | false |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |
| fixedUpdate | false | false |  |  |

##### 5. SetScale

Full Name: HutongGames.PlayMaker.Actions.SetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | -1f | -1f |  |  |
| y | 0f | 0f |  |  |
| z | 0f | 0f |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

### Awoken Pause

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 1f | 1f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Idle Anim

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
| clipName | string Fly Anim | string Fly Anim |  |  |

### Audio

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [dream_ghost_appear (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [dream_ghost_appear (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| pitchMin | 1.5f | 1.5f |  |  |
| pitchMax | 1.5f | 1.5f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 2. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | true | true |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Pause | FINISHED | Spawn | 0 | 0 | 0 |
| Pause | AWOKEN | Awake Ready | 0 | 0 | 0 |
| Spawn | FINISHED | Idle Anim | 0 | 0 | 0 |
| Follow | CHANGE | Change | 0 | 0 | 0 |
| Follow | TELE | Tele Start | 0 | 0 | 0 |
| Follow | CHECK | Check For Target | 0 | 0 | 0 |
| Change | FINISHED | Follow | 0 | 0 | 0 |
| Tele Start | FINISHED | Burst Out | 0 | 0 | 0 |
| Init | 1 | Level 1 | 0 | 0 | 0 |
| Init | 2 | Level 2 | 0 | 0 | 0 |
| Init | 3 | Level 3 | 0 | 0 | 0 |
| Init | 4 | Level 4 | 0 | 0 | 0 |
| Init | FINISHED | Level 1 | 0 | 0 | 0 |
| Rest Pause | FINISHED | Lower | 0 | 0 | 0 |
| Rest Pause | BENCHREST END | Follow | 0 | 0 | 0 |
| Lower | FINISHED |  | 0 | 0 | 0 |
| Lower | BENCHREST END | Follow | 0 | 0 | 0 |
| Lower | LAND | Rest Start | 0 | 0 | 0 |
| Rest Start | BENCHREST END | Wake | 0 | 0 | 0 |
| Wake | FINISHED | Reset Anim | 0 | 0 | 0 |
| At Bench? | FINISHED | Change | 0 | 0 | 0 |
| At Bench? | BENCH | Rest Pause | 0 | 0 | 0 |
| Warp Pause | FINISHED | Warp Out | 0 | 0 | 0 |
| Warp Out | FINISHED | Warped Out | 0 | 0 | 0 |
| Warp In Pause | FINISHED | Audio | 0 | 0 | 0 |
| Level 1 | FINISHED | Pause | 0 | 0 | 0 |
| Level 2 | FINISHED | Pause | 0 | 0 | 0 |
| Level 3 | FINISHED | Pause | 0 | 0 | 0 |
| Tele | FINISHED | Spawn | 0 | 0 | 0 |
| Despawn | FINISHED | Burst Out 2 | 0 | 0 | 0 |
| Level 4 | FINISHED | Pause | 0 | 0 | 0 |
| Check For Target | TARGET | Antic | 0 | 0 | 0 |
| Check For Target | NO TARGET | No Target | 0 | 0 | 0 |
| Check For Target | 1 | Lv 1 | 0 | 0 | 0 |
| No Target | FINISHED | Follow | 0 | 0 | 0 |
| Antic | FINISHED | Shoot | 0 | 0 | 0 |
| Antic | CANCEL | Reset Anim | 0 | 0 | 0 |
| Lv 1 | FINISHED | Follow | 0 | 0 | 0 |
| Shoot | FINISHED | Reset Anim | 0 | 0 | 0 |
| Shoot | CANCEL | Reset Anim | 0 | 0 | 0 |
| Burst Out | FINISHED | Tele | 0 | 0 | 0 |
| Burst Out 2 | FINISHED | Recycle | 0 | 0 | 0 |
| Absorb Tween | FINISHED | Absorb | 0 | 0 | 0 |
| Set Pos | FINISHED | Init | 0 | 0 | 0 |
| Brumm Shoulder | BRUMM END | Follow | 0 | 0 | 0 |
| Reset Anim | FINISHED | Follow | 0 | 0 | 0 |
| Awake Ready | DREAM WAKE | Awoken Pause | 0 | 0 | 0 |
| Awoken Pause | FINISHED | Wake | 0 | 0 | 0 |
| Idle Anim | FINISHED | At Bench? | 0 | 0 | 0 |
| Audio | FINISHED | Spawn | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| QUICK SPAWN | Change | 0 | 0 | 0 |
| BENCHREST | Rest Pause | 0 | 0 | 0 |
| DREAMGATE OUT | Warp Pause | 0 | 0 | 0 |
| DREAMGATE SPAWN | Warp In Pause | 0 | 0 | 0 |
| HAZARD RELOAD | Tele Start | 0 | 0 | 0 |
| DESPAWN | Despawn | 0 | 0 | 0 |
| LEVEL UP | Init | 0 | 0 | 0 |
| BG CLOSE | Tele Start | 0 | 0 | 0 |
| ABSORB | Absorb Tween | 0 | 0 | 0 |
| LEVEL UP 2 | Set Pos | 0 | 0 | 0 |
| ALL CHARMS END | Despawn | 0 | 0 | 0 |
| BRUMM SHOULDER | Brumm Shoulder | 0 | 0 | 0 |
| LANTERN DESTROY | Recycle | 0 | 0 | 0 |
| QUIT TO MENU | Recycle | 0 | 0 | 0 |
| LEVEL LOADED | Recycle | 0 | 0 | 0 |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| LEVEL LOADED | false |
| 1 | false |
| 2 | false |
| 3 | false |
| 4 | false |
| ABSORB | false |
| ALL CHARMS END | false |
| AWOKEN | false |
| BENCH | false |
| BENCHREST | false |
| BENCHREST END | false |
| BG CLOSE | false |
| BRUMM END | false |
| BRUMM SHOULDER | false |
| CANCEL | false |
| CHANGE | false |
| CHECK | false |
| DESPAWN | true |
| DREAM WAKE | false |
| DREAMGATE OUT | false |
| DREAMGATE SPAWN | false |
| HAZARD RELOAD | false |
| LAND | false |
| LANTERN DESTROY | false |
| LEAVING SCENE | false |
| LEVEL UP | false |
| LEVEL UP 2 | false |
| NO TARGET | false |
| QUICK SPAWN | false |
| QUIT TO MENU | true |
| TARGET | false |
| TELE | false |

