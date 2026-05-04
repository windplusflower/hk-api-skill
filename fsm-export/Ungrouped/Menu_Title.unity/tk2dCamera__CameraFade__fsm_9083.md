# CameraFade

## Summary

| Field | Value |
| --- | --- |
| FSM Name | CameraFade |
| GameObject Name | tk2dCamera |
| GameObject Path | _GameCameras/CameraParent/ |
| Source Asset | D:/SteamLibrary/steamapps/common/Hollow Knight/hollow_knight_Data/level1 |
| Start State | Pause |
| FSM PathId | 9083 |
| GameObject PathId | 1287 |

## Variables

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| No Fade | false | Boolean: false |
| White Fade In | false | Boolean: false |

### Colors

| Name | Value | Raw/Type |
| --- | --- | --- |
| Fade Colour | Color(0, 0, 0, 1) | UnityColor: Color(0, 0, 0, 1) |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Blanker | [null] | NamedAssetPPtr: [null] |
| Scene Manager | [null] | NamedAssetPPtr: [null] |
| Self | [null] | NamedAssetPPtr: [null] |
| Start Blanker | _GameCameras/CameraParent/tk2dCamera/Start Blanker (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level1) | NamedAssetPPtr: [_GameCameras/CameraParent/tk2dCamera/Start Blanker (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level1)] |

## States

### Normal

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 6

#### Actions

##### 1. SetColorValue

Full Name: HutongGames.PlayMaker.Actions.SetColorValue
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| colorVariable |   | Color Fade Colour | Variable |   |
| color |   | Color(0, 0, 0, 1) |   |   |
| everyFrame |   | false |   |   |

##### 2. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool White Fade In | Variable |   |
| boolValue |   | false |   |   |
| everyFrame |   | false |   |   |

##### 3. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool No Fade | Variable |   |
| boolValue |   | false |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FADE OUT | FadingOut | 0 | |
| RESPAWN FADE | RespawnFadingOut | 0 | |
| HAZARD FADE | HazardFadingOut | 0 | |
| JUST FADE | Just Fading | 0 | |
| FADE INSTANT | Instant Fade | 0 | |
| START FADE | Start Fade | 0 | |

### FadingOut

Description: (none)
Flags: breakpoint=false, sequence=true, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. CameraFadeOut

Full Name: HutongGames.PlayMaker.Actions.CameraFadeOut
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| color |   | Color Fade Colour |   |   |
| time |   | 0.33f |   |   |
| finishEvent |   |   |   |   |
| realTime |   | false |   |   |

##### 2. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |   |   |
| options | UnityEngine.SendMessageOptions::RequireReceiver | 0 |   |   |
| functionCall |   | FadeToBlack(0.25f) |   |   |

##### 3. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 0.25f |   |   |
| finishEvent |   | FADE OUT COMPLETE |   |   |
| realTime |   | false |   |   |

##### 4. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Blanker |   |   |
| fsmName |   | "Blanker Control" | FsmName |   |
| variableName |   | "Fade Time" | FsmFloat |   |
| setValue |   | 0.33f |   |   |
| everyFrame |   | false |   |   |

##### 5. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Blanker |   |   |
| sendEvent |   | "FADE IN" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FADE OUT COMPLETE | White Fade In? 2 | 0 | |

### FadeIn

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. CameraFadeInWithDelay

Full Name: HutongGames.PlayMaker.Actions.CameraFadeInWithDelay
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| color |   | Color Fade Colour |   |   |
| delay |   | 0f |   |   |
| time |   | 0.5f |   |   |
| finishEvent |   | FADE IN COMPLETE |   |   |
| realTime |   | false |   |   |

##### 2. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Blanker |   |   |
| fsmName |   | "Blanker Control" | FsmName |   |
| variableName |   | "Fade Time" | FsmFloat |   |
| setValue |   | 0.5f |   |   |
| everyFrame |   | false |   |   |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Blanker |   |   |
| sendEvent |   | "FADE OUT" |   |   |
| delay |   | 0.1f |   |   |
| everyFrame |   | false |   |   |

##### 4. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 0.6f |   |   |
| finishEvent |   | FADE IN COMPLETE |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FADE IN COMPLETE | Normal | 0 | |
| JUST FADE | Just Fading | 0 | |

### Done

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. CameraFadeIn

Full Name: HutongGames.PlayMaker.Actions.CameraFadeIn
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| color |   | Color(0, 0, 0, 1) |   |   |
| time |   | 50f |   |   |
| finishEvent |   |   |   |   |
| realTime |   | false |   |   |

##### 2. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |   |   |
| options | UnityEngine.SendMessageOptions::RequireReceiver | 0 |   |   |
| functionCall |   | LeftScene(???) |   |   |

##### 3. CameraFadeOut

Full Name: HutongGames.PlayMaker.Actions.CameraFadeOut
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| color |   | Color(0, 0, 0, 1) |   |   |
| time |   | 0f |   |   |
| finishEvent |   | FADE OUT COMPLETE |   |   |
| realTime |   | false |   |   |

##### 4. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Blanker |   |   |
| fsmName |   | "Blanker Control" | FsmName |   |
| variableName |   | "Fade Time" | FsmFloat |   |
| setValue |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 5. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Blanker |   |   |
| sendEvent |   | "FADE IN" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| LEVEL LOADED | Wait For Fade In | 0 | |

### RespawnFadingOut

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. CameraFadeOut

Full Name: HutongGames.PlayMaker.Actions.CameraFadeOut
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| color |   | Color(0, 0, 0, 1) |   |   |
| time |   | 1f |   |   |
| finishEvent |   | RESPAWN FADE OUT COMPLETE |   |   |
| realTime |   | false |   |   |

##### 2. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Blanker |   |   |
| fsmName |   | "Blanker Control" | FsmName |   |
| variableName |   | "Fade Time" | FsmFloat |   |
| setValue |   | 0.75f |   |   |
| everyFrame |   | false |   |   |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Blanker |   |   |
| sendEvent |   | "FADE IN" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 4. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 0.75f |   |   |
| finishEvent |   | RESPAWN FADE OUT COMPLETE |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| RESPAWN FADE OUT COMPLETE | WaitForRespawn | 0 | |

### WaitForRespawn

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. CameraFadeIn

Full Name: HutongGames.PlayMaker.Actions.CameraFadeIn
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| color |   | Color(0, 0, 0, 1) |   |   |
| time |   | 50f |   |   |
| finishEvent |   |   |   |   |
| realTime |   | false |   |   |

##### 2. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |   |   |
| options | UnityEngine.SendMessageOptions::RequireReceiver | 0 |   |   |
| functionCall |   | ReadyForRespawn(???) |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| RESPAWN | FadeIn | 0 | |

### HazardFadingOut

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. CameraFadeOut

Full Name: HutongGames.PlayMaker.Actions.CameraFadeOut
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| color |   | Color(0, 0, 0, 1) |   |   |
| time |   | 1f |   |   |
| finishEvent |   | HAZARD FADE OUT COMPLETE |   |   |
| realTime |   | false |   |   |

##### 2. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Blanker |   |   |
| fsmName |   | "Blanker Control" | FsmName |   |
| variableName |   | "Fade Time" | FsmFloat |   |
| setValue |   | 0.75f |   |   |
| everyFrame |   | false |   |   |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Blanker |   |   |
| sendEvent |   | "FADE IN" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 4. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 0.75f |   |   |
| finishEvent |   | HAZARD FADE OUT COMPLETE |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| HAZARD FADE OUT COMPLETE | WaitForHazardRespawn | 0 | |

### WaitForHazardRespawn

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. CameraFadeIn

Full Name: HutongGames.PlayMaker.Actions.CameraFadeIn
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| color |   | Color(0, 0, 0, 1) |   |   |
| time |   | 50f |   |   |
| finishEvent |   |   |   |   |
| realTime |   | false |   |   |

##### 2. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |   |   |
| options | UnityEngine.SendMessageOptions::RequireReceiver | 0 |   |   |
| functionCall |   | HazardRespawn(???) |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| RESPAWN | FadeIn | 0 | |

### Just Fading

Description: (none)
Flags: breakpoint=false, sequence=true, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. CameraFadeOut

Full Name: HutongGames.PlayMaker.Actions.CameraFadeOut
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| color |   | Color(0, 0, 0, 1) |   |   |
| time |   | 0.25f |   |   |
| finishEvent |   | FADE OUT COMPLETE |   |   |
| realTime |   | true |   |   |

##### 2. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Blanker |   |   |
| fsmName |   | "Blanker Control" | FsmName |   |
| variableName |   | "Fade Time" | FsmFloat |   |
| setValue |   | 0.25f |   |   |
| everyFrame |   | false |   |   |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Blanker |   |   |
| sendEvent |   | "FADE IN" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

(none)

### Instant Fade

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. CameraFadeOut

Full Name: HutongGames.PlayMaker.Actions.CameraFadeOut
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| color |   | Color(0, 0, 0, 1) |   |   |
| time |   | 0f |   |   |
| finishEvent |   | FADE OUT COMPLETE |   |   |
| realTime |   | false |   |   |

##### 2. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Blanker |   |   |
| fsmName |   | "Blanker Control" | FsmName |   |
| variableName |   | "Fade Time" | FsmFloat |   |
| setValue |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Blanker |   |   |
| sendEvent |   | "FADE IN INSTANT" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 4. SetMaterialColor

Full Name: HutongGames.PlayMaker.Actions.SetMaterialColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Blanker |   |   |
| materialIndex |   | 0 |   |   |
| material |   | [FsmMaterial not implemented] |   |   |
| namedColor |   | "_Color" | NamedColor |   |
| color |   | Color(0, 0, 0, 1) |   |   |
| everyFrame |   | false |   |   |

##### 5. SetSpriteRenderer

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRenderer
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Blanker |   |   |
| active |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FADE BACK | Fade Back | 0 | |
| LEVEL LOADED | Wait For Fade In | 0 | |

### Start Fade

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. CameraFadeOut

Full Name: HutongGames.PlayMaker.Actions.CameraFadeOut
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| color |   | Color(0, 0, 0, 1) |   |   |
| time |   | 2.3f |   |   |
| finishEvent |   | FADE OUT COMPLETE |   |   |
| realTime |   | false |   |   |

##### 2. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Start Blanker |   |   |
| fsmName |   | "Blanker Control" | FsmName |   |
| variableName |   | "Fade Time" | FsmFloat |   |
| setValue |   | 2.3f |   |   |
| everyFrame |   | false |   |   |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Start Blanker |   |   |
| sendEvent |   | "START FADE" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

(none)

### Fade Back

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. CameraFadeInWithDelay

Full Name: HutongGames.PlayMaker.Actions.CameraFadeInWithDelay
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| color |   | Color(0, 0, 0, 1) |   |   |
| delay |   | 0f |   |   |
| time |   | 3f |   |   |
| finishEvent |   | FADE IN COMPLETE |   |   |
| realTime |   | false |   |   |

##### 2. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Blanker |   |   |
| fsmName |   | "Blanker Control" | FsmName |   |
| variableName |   | "Fade Time" | FsmFloat |   |
| setValue |   | 3f |   |   |
| everyFrame |   | false |   |   |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Blanker |   |   |
| sendEvent |   | "FADE IN" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 4. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 3f |   |   |
| finishEvent |   | FADE IN COMPLETE |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FADE IN COMPLETE | Normal | 0 | |

### Init

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

##### 2. SetGameObject

Full Name: HutongGames.PlayMaker.Actions.SetGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variable |   | [Global] GameObject MainCamera | Variable |   |
| gameObject |   | GameObject Self |   |   |
| everyFrame |   | false |   |   |

##### 3. SetGameObject

Full Name: HutongGames.PlayMaker.Actions.SetGameObject
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variable |   | GameObject Blanker | Variable |   |
| gameObject |   | [Global] GameObject MainCamera |   |   |
| everyFrame |   | false |   |   |

##### 4. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Start Blanker" |   |   |
| storeResult |   | GameObject Start Blanker | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Wait For Fade In | 0 | |

### Wait For Fade In

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. CameraFadeOut

Full Name: HutongGames.PlayMaker.Actions.CameraFadeOut
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| color |   | Color Fade Colour |   |   |
| time |   | 0f |   |   |
| finishEvent |   | FADE OUT COMPLETE |   |   |
| realTime |   | false |   |   |

##### 2. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 5f |   |   |
| finishEvent |   | FADE SCENE IN |   |   |
| realTime |   | false |   |   |

##### 3. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Blanker |   |   |
| fsmName |   | "Blanker Control" | FsmName |   |
| variableName |   | "Fade Time" | FsmFloat |   |
| setValue |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 4. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Blanker |   |   |
| sendEvent |   | "FADE IN" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FADE SCENE IN | White Fade In? | 0 | |

### Slow Fade In

Description: Fades in the camera the same way as the standard fadein, just 3x slower.
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. CameraFadeInWithDelay

Full Name: HutongGames.PlayMaker.Actions.CameraFadeInWithDelay
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| color |   | Color(0, 0, 0, 1) |   |   |
| delay |   | 0f |   |   |
| time |   | 3f |   |   |
| finishEvent |   | FADE IN COMPLETE |   |   |
| realTime |   | false |   |   |

##### 2. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Blanker |   |   |
| fsmName |   | "Blanker Control" | FsmName |   |
| variableName |   | "Fade Time" | FsmFloat |   |
| setValue |   | 3f |   |   |
| everyFrame |   | false |   |   |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Blanker |   |   |
| sendEvent |   | "FADE OUT" |   |   |
| delay |   | 0.1f |   |   |
| everyFrame |   | false |   |   |

##### 4. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 3.1f |   |   |
| finishEvent |   | FADE IN COMPLETE |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FADE IN COMPLETE | Normal | 0 | |
| JUST FADE | Just Fading | 0 | |

### White Fade In?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Start Blanker |   |   |
| sendEvent |   | "OUT" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 2. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool No Fade | Variable |   |
| isTrue |   | NO FADE |   |   |
| isFalse |   |   |   |   |
| everyFrame |   | false |   |   |

##### 3. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool White Fade In | Variable |   |
| isTrue |   | WHITE |   |   |
| isFalse |   | BLACK |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| WHITE | Set White | 0 | |
| BLACK | Set Black | 0 | |
| NO FADE | Insta Fade Out | 0 | |

### Set Black

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetColorValue

Full Name: HutongGames.PlayMaker.Actions.SetColorValue
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| colorVariable |   | Color Fade Colour | Variable |   |
| color |   | Color(0, 0, 0, 1) |   |   |
| everyFrame |   | false |   |   |

##### 2. SetFsmColor

Full Name: HutongGames.PlayMaker.Actions.SetFsmColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Blanker |   |   |
| fsmName |   | "Blanker Control" | FsmName |   |
| variableName |   | "Start Colour" | FsmColor |   |
| setValue |   | Color(0, 0, 0, 0) |   |   |
| everyFrame |   | false |   |   |

##### 3. SetFsmColor

Full Name: HutongGames.PlayMaker.Actions.SetFsmColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Blanker |   |   |
| fsmName |   | "Blanker Control" | FsmName |   |
| variableName |   | "End Colour" | FsmColor |   |
| setValue |   | Color(0, 0, 0, 1) |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | FadeIn | 0 | |

### Set White

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetColorValue

Full Name: HutongGames.PlayMaker.Actions.SetColorValue
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| colorVariable |   | Color Fade Colour | Variable |   |
| color |   | Color(1, 1, 1, 1) |   |   |
| everyFrame |   | false |   |   |

##### 2. SetFsmColor

Full Name: HutongGames.PlayMaker.Actions.SetFsmColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Blanker |   |   |
| fsmName |   | "Blanker Control" | FsmName |   |
| variableName |   | "Start Colour" | FsmColor |   |
| setValue |   | Color(1, 1, 1, 0) |   |   |
| everyFrame |   | false |   |   |

##### 3. SetFsmColor

Full Name: HutongGames.PlayMaker.Actions.SetFsmColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Blanker |   |   |
| fsmName |   | "Blanker Control" | FsmName |   |
| variableName |   | "End Colour" | FsmColor |   |
| setValue |   | Color(1, 1, 1, 1) |   |   |
| everyFrame |   | false |   |   |

##### 4. SetMaterialColor

Full Name: HutongGames.PlayMaker.Actions.SetMaterialColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Blanker |   |   |
| materialIndex |   | 0 |   |   |
| material |   | [FsmMaterial not implemented] |   |   |
| namedColor |   | "_Color" | NamedColor |   |
| color |   | Color(1, 1, 1, 1) |   |   |
| everyFrame |   | false |   |   |

##### 5. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 0.4f |   |   |
| finishEvent |   | FINISHED |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | FadeIn | 0 | |

### White Fade In? 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool White Fade In | Variable |   |
| isTrue |   | WHITE |   |   |
| isFalse |   | BLACK |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| WHITE | Set White 2 | 0 | |
| BLACK | Set Black 2 | 0 | |

### Set White 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetColorValue

Full Name: HutongGames.PlayMaker.Actions.SetColorValue
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| colorVariable |   | Color Fade Colour | Variable |   |
| color |   | Color(1, 1, 1, 1) |   |   |
| everyFrame |   | false |   |   |

##### 2. SetFsmColor

Full Name: HutongGames.PlayMaker.Actions.SetFsmColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Blanker |   |   |
| fsmName |   | "Blanker Control" | FsmName |   |
| variableName |   | "Start Colour" | FsmColor |   |
| setValue |   | Color(1, 1, 1, 0) |   |   |
| everyFrame |   | false |   |   |

##### 3. SetFsmColor

Full Name: HutongGames.PlayMaker.Actions.SetFsmColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Blanker |   |   |
| fsmName |   | "Blanker Control" | FsmName |   |
| variableName |   | "End Colour" | FsmColor |   |
| setValue |   | Color(1, 1, 1, 1) |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Done | 0 | |

### Set Black 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetColorValue

Full Name: HutongGames.PlayMaker.Actions.SetColorValue
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| colorVariable |   | Color Fade Colour | Variable |   |
| color |   | Color(0, 0, 0, 1) |   |   |
| everyFrame |   | false |   |   |

##### 2. SetFsmColor

Full Name: HutongGames.PlayMaker.Actions.SetFsmColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Blanker |   |   |
| fsmName |   | "Blanker Control" | FsmName |   |
| variableName |   | "Start Colour" | FsmColor |   |
| setValue |   | Color(0, 0, 0, 0) |   |   |
| everyFrame |   | false |   |   |

##### 3. SetFsmColor

Full Name: HutongGames.PlayMaker.Actions.SetFsmColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Blanker |   |   |
| fsmName |   | "Blanker Control" | FsmName |   |
| variableName |   | "End Colour" | FsmColor |   |
| setValue |   | Color(0, 0, 0, 1) |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Done | 0 | |

### Instant Fade In

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. CameraFadeInWithDelay

Full Name: HutongGames.PlayMaker.Actions.CameraFadeInWithDelay
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| color |   | Color(0, 0, 0, 1) |   |   |
| delay |   | 0f |   |   |
| time |   | 0.001f |   |   |
| finishEvent |   | FADE IN COMPLETE |   |   |
| realTime |   | false |   |   |

##### 2. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Blanker |   |   |
| fsmName |   | "Blanker Control" | FsmName |   |
| variableName |   | "Fade Time" | FsmFloat |   |
| setValue |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Blanker |   |   |
| sendEvent |   | "FADE OUT" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 4. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 0f |   |   |
| finishEvent |   | FADE IN COMPLETE |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FADE IN COMPLETE | Normal | 0 | |
| JUST FADE | Just Fading | 0 | |

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
| sendEvent |   | FINISHED |   |   |

##### 2. GetOwner

Full Name: HutongGames.PlayMaker.Actions.GetOwner
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeGameObject |   | GameObject Self | Variable |   |

##### 3. SetGameObject

Full Name: HutongGames.PlayMaker.Actions.SetGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variable |   | [Global] GameObject MainCamera | Variable |   |
| gameObject |   | GameObject Self |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Init | 0 | |

### Pre Fade

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. NextFrameEvent

Full Name: HutongGames.PlayMaker.Actions.NextFrameEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent |   | FINISHED |   |   |

##### 2. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Blanker |   |   |
| fsmName |   | "Blanker Control" | FsmName |   |
| variableName |   | "Fade Time" | FsmFloat |   |
| setValue |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Blanker |   |   |
| sendEvent |   | "FADE IN INSTANT" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | White Fade In? | 0 | |

### Insta Fade Out

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Blanker |   |   |
| sendEvent |   | "FADE OUT INSTANT" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Normal | 0 | |

### Fade Out Instant

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Blanker |   |   |
| sendEvent |   | "FADE IN INSTANT" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | White Fade In? 2 | 0 | |

## Global Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FADE OUT | FadingOut | 0 | |
| FADE SCENE IN SLOWLY | Slow Fade In | 0 | |
| FADE SCENE IN INSTANT | Instant Fade In | 0 | |
| FADE SCENE IN | Pre Fade | 0 | |
| FADE OUT INSTANT | Fade Out Instant | 0 | |

## Events

| Name | Global |
| --- | --- |
| BLACK | false |
| FADE BACK | false |
| FADE IN COMPLETE | false |
| FADE INSTANT | false |
| FADE OUT | false |
| FADE OUT COMPLETE | false |
| FADE OUT INSTANT | false |
| FADE SCENE IN | false |
| FADE SCENE IN INSTANT | false |
| FADE SCENE IN SLOWLY | false |
| FINISHED | false |
| HAZARD FADE | false |
| HAZARD FADE OUT COMPLETE | false |
| JUST FADE | false |
| LEVEL LOADED | false |
| NO FADE | false |
| RESPAWN | false |
| RESPAWN FADE | false |
| RESPAWN FADE OUT COMPLETE | false |
| START FADE | false |
| STOPMOVE | true |
| WHITE | false |

