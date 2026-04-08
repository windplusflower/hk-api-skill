# FSM

## Summary

| Field | Value |
| --- | --- |
| FSM Name | FSM |
| GameObject Name | Unnamed |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Pause |
| FSM PathId | 19513 |
| GameObject PathId |  |

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
| Blanker | [null] | NamedAssetPPtr:  |
| Scene Manager | [null] | NamedAssetPPtr:  |
| Self | [null] | NamedAssetPPtr:  |
| Start Blanker | [null] | NamedAssetPPtr:  |

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
| colorVariable | Color Fade Colour | Color Fade Colour | Variable |  |
| color | Color(0, 0, 0, 1) | Color(0, 0, 0, 1) |  |  |
| everyFrame | false | false |  |  |

##### 2. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool White Fade In | bool White Fade In | Variable |  |
| boolValue | false | false |  |  |
| everyFrame | false | false |  |  |

##### 3. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool No Fade | bool No Fade | Variable |  |
| boolValue | false | false |  |  |
| everyFrame | false | false |  |  |

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
| color | Color Fade Colour | Color Fade Colour |  |  |
| time | 0.33f | 0.33f |  |  |
| finishEvent |  |  |  |  |
| realTime | false | false |  |  |

##### 2. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::RequireReceiver | 0 |  |  |
| functionCall | FadeToBlack(0.25f) | FadeToBlack(0.25f) |  |  |

##### 3. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.25f | 0.25f |  |  |
| finishEvent | FADE OUT COMPLETE | FADE OUT COMPLETE |  |  |
| realTime | false | false |  |  |

##### 4. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Blanker | OwnerDefault Blanker |  |  |
| fsmName | "Blanker Control" | "Blanker Control" | FsmName |  |
| variableName | "Fade Time" | "Fade Time" | FsmFloat |  |
| setValue | 0.33f | 0.33f |  |  |
| everyFrame | false | false |  |  |

##### 5. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Blanker | EventTarget(GameObject):Blanker |  |  |
| sendEvent | "FADE IN" | "FADE IN" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

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
| color | Color Fade Colour | Color Fade Colour |  |  |
| delay | 0f | 0f |  |  |
| time | 0.5f | 0.5f |  |  |
| finishEvent | FADE IN COMPLETE | FADE IN COMPLETE |  |  |
| realTime | false | false |  |  |

##### 2. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Blanker | OwnerDefault Blanker |  |  |
| fsmName | "Blanker Control" | "Blanker Control" | FsmName |  |
| variableName | "Fade Time" | "Fade Time" | FsmFloat |  |
| setValue | 0.5f | 0.5f |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Blanker | EventTarget(GameObject):Blanker |  |  |
| sendEvent | "FADE OUT" | "FADE OUT" |  |  |
| delay | 0.1f | 0.1f |  |  |
| everyFrame | false | false |  |  |

##### 4. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.6f | 0.6f |  |  |
| finishEvent | FADE IN COMPLETE | FADE IN COMPLETE |  |  |
| realTime | false | false |  |  |

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
| color | Color(0, 0, 0, 1) | Color(0, 0, 0, 1) |  |  |
| time | 50f | 50f |  |  |
| finishEvent |  |  |  |  |
| realTime | false | false |  |  |

##### 2. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::RequireReceiver | 0 |  |  |
| functionCall | LeftScene(???) | LeftScene(???) |  |  |

##### 3. CameraFadeOut

Full Name: HutongGames.PlayMaker.Actions.CameraFadeOut
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| color | Color(0, 0, 0, 1) | Color(0, 0, 0, 1) |  |  |
| time | 0f | 0f |  |  |
| finishEvent | FADE OUT COMPLETE | FADE OUT COMPLETE |  |  |
| realTime | false | false |  |  |

##### 4. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Blanker | OwnerDefault Blanker |  |  |
| fsmName | "Blanker Control" | "Blanker Control" | FsmName |  |
| variableName | "Fade Time" | "Fade Time" | FsmFloat |  |
| setValue | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 5. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Blanker | EventTarget(GameObject):Blanker |  |  |
| sendEvent | "FADE IN" | "FADE IN" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

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
| color | Color(0, 0, 0, 1) | Color(0, 0, 0, 1) |  |  |
| time | 1f | 1f |  |  |
| finishEvent | RESPAWN FADE OUT COMPLETE | RESPAWN FADE OUT COMPLETE |  |  |
| realTime | false | false |  |  |

##### 2. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Blanker | OwnerDefault Blanker |  |  |
| fsmName | "Blanker Control" | "Blanker Control" | FsmName |  |
| variableName | "Fade Time" | "Fade Time" | FsmFloat |  |
| setValue | 0.75f | 0.75f |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Blanker | EventTarget(GameObject):Blanker |  |  |
| sendEvent | "FADE IN" | "FADE IN" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 4. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.75f | 0.75f |  |  |
| finishEvent | RESPAWN FADE OUT COMPLETE | RESPAWN FADE OUT COMPLETE |  |  |
| realTime | false | false |  |  |

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
| color | Color(0, 0, 0, 1) | Color(0, 0, 0, 1) |  |  |
| time | 50f | 50f |  |  |
| finishEvent |  |  |  |  |
| realTime | false | false |  |  |

##### 2. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::RequireReceiver | 0 |  |  |
| functionCall | ReadyForRespawn(???) | ReadyForRespawn(???) |  |  |

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
| color | Color(0, 0, 0, 1) | Color(0, 0, 0, 1) |  |  |
| time | 1f | 1f |  |  |
| finishEvent | HAZARD FADE OUT COMPLETE | HAZARD FADE OUT COMPLETE |  |  |
| realTime | false | false |  |  |

##### 2. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Blanker | OwnerDefault Blanker |  |  |
| fsmName | "Blanker Control" | "Blanker Control" | FsmName |  |
| variableName | "Fade Time" | "Fade Time" | FsmFloat |  |
| setValue | 0.75f | 0.75f |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Blanker | EventTarget(GameObject):Blanker |  |  |
| sendEvent | "FADE IN" | "FADE IN" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 4. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.75f | 0.75f |  |  |
| finishEvent | HAZARD FADE OUT COMPLETE | HAZARD FADE OUT COMPLETE |  |  |
| realTime | false | false |  |  |

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
| color | Color(0, 0, 0, 1) | Color(0, 0, 0, 1) |  |  |
| time | 50f | 50f |  |  |
| finishEvent |  |  |  |  |
| realTime | false | false |  |  |

##### 2. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::RequireReceiver | 0 |  |  |
| functionCall | HazardRespawn(???) | HazardRespawn(???) |  |  |

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
| color | Color(0, 0, 0, 1) | Color(0, 0, 0, 1) |  |  |
| time | 0.25f | 0.25f |  |  |
| finishEvent | FADE OUT COMPLETE | FADE OUT COMPLETE |  |  |
| realTime | true | true |  |  |

##### 2. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Blanker | OwnerDefault Blanker |  |  |
| fsmName | "Blanker Control" | "Blanker Control" | FsmName |  |
| variableName | "Fade Time" | "Fade Time" | FsmFloat |  |
| setValue | 0.25f | 0.25f |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Blanker | EventTarget(GameObject):Blanker |  |  |
| sendEvent | "FADE IN" | "FADE IN" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

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
| color | Color(0, 0, 0, 1) | Color(0, 0, 0, 1) |  |  |
| time | 0f | 0f |  |  |
| finishEvent | FADE OUT COMPLETE | FADE OUT COMPLETE |  |  |
| realTime | false | false |  |  |

##### 2. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Blanker | OwnerDefault Blanker |  |  |
| fsmName | "Blanker Control" | "Blanker Control" | FsmName |  |
| variableName | "Fade Time" | "Fade Time" | FsmFloat |  |
| setValue | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Blanker | EventTarget(GameObject):Blanker |  |  |
| sendEvent | "FADE IN INSTANT" | "FADE IN INSTANT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 4. SetMaterialColor

Full Name: HutongGames.PlayMaker.Actions.SetMaterialColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Blanker | OwnerDefault Blanker |  |  |
| materialIndex | 0 | 0 |  |  |
| material | [FsmMaterial not implemented] | [FsmMaterial not implemented] |  |  |
| namedColor | "_Color" | "_Color" | NamedColor |  |
| color | Color(0, 0, 0, 1) | Color(0, 0, 0, 1) |  |  |
| everyFrame | false | false |  |  |

##### 5. SetSpriteRenderer

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRenderer
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Blanker | OwnerDefault Blanker |  |  |
| active | true | true |  |  |

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
| color | Color(0, 0, 0, 1) | Color(0, 0, 0, 1) |  |  |
| time | 2.3f | 2.3f |  |  |
| finishEvent | FADE OUT COMPLETE | FADE OUT COMPLETE |  |  |
| realTime | false | false |  |  |

##### 2. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Start Blanker | OwnerDefault Start Blanker |  |  |
| fsmName | "Blanker Control" | "Blanker Control" | FsmName |  |
| variableName | "Fade Time" | "Fade Time" | FsmFloat |  |
| setValue | 2.3f | 2.3f |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Start Blanker | EventTarget(GameObject):Start Blanker |  |  |
| sendEvent | "START FADE" | "START FADE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

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
| color | Color(0, 0, 0, 1) | Color(0, 0, 0, 1) |  |  |
| delay | 0f | 0f |  |  |
| time | 3f | 3f |  |  |
| finishEvent | FADE IN COMPLETE | FADE IN COMPLETE |  |  |
| realTime | false | false |  |  |

##### 2. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Blanker | OwnerDefault Blanker |  |  |
| fsmName | "Blanker Control" | "Blanker Control" | FsmName |  |
| variableName | "Fade Time" | "Fade Time" | FsmFloat |  |
| setValue | 3f | 3f |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Blanker | EventTarget(GameObject):Blanker |  |  |
| sendEvent | "FADE IN" | "FADE IN" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 4. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 3f | 3f |  |  |
| finishEvent | FADE IN COMPLETE | FADE IN COMPLETE |  |  |
| realTime | false | false |  |  |

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
| storeGameObject | GameObject Self | GameObject Self | Variable |  |

##### 2. SetGameObject

Full Name: HutongGames.PlayMaker.Actions.SetGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variable | [Global] GameObject MainCamera | [Global] GameObject MainCamera | Variable |  |
| gameObject | GameObject Self | GameObject Self |  |  |
| everyFrame | false | false |  |  |

##### 3. SetGameObject

Full Name: HutongGames.PlayMaker.Actions.SetGameObject
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variable | GameObject Blanker | GameObject Blanker | Variable |  |
| gameObject | [Global] GameObject MainCamera | [Global] GameObject MainCamera |  |  |
| everyFrame | false | false |  |  |

##### 4. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Start Blanker" | "Start Blanker" |  |  |
| storeResult | GameObject Start Blanker | GameObject Start Blanker | Variable |  |

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
| color | Color Fade Colour | Color Fade Colour |  |  |
| time | 0f | 0f |  |  |
| finishEvent | FADE OUT COMPLETE | FADE OUT COMPLETE |  |  |
| realTime | false | false |  |  |

##### 2. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 5f | 5f |  |  |
| finishEvent | FADE SCENE IN | FADE SCENE IN |  |  |
| realTime | false | false |  |  |

##### 3. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Blanker | OwnerDefault Blanker |  |  |
| fsmName | "Blanker Control" | "Blanker Control" | FsmName |  |
| variableName | "Fade Time" | "Fade Time" | FsmFloat |  |
| setValue | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 4. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Blanker | EventTarget(GameObject):Blanker |  |  |
| sendEvent | "FADE IN" | "FADE IN" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

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
| color | Color(0, 0, 0, 1) | Color(0, 0, 0, 1) |  |  |
| delay | 0f | 0f |  |  |
| time | 3f | 3f |  |  |
| finishEvent | FADE IN COMPLETE | FADE IN COMPLETE |  |  |
| realTime | false | false |  |  |

##### 2. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Blanker | OwnerDefault Blanker |  |  |
| fsmName | "Blanker Control" | "Blanker Control" | FsmName |  |
| variableName | "Fade Time" | "Fade Time" | FsmFloat |  |
| setValue | 3f | 3f |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Blanker | EventTarget(GameObject):Blanker |  |  |
| sendEvent | "FADE OUT" | "FADE OUT" |  |  |
| delay | 0.1f | 0.1f |  |  |
| everyFrame | false | false |  |  |

##### 4. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 3.1f | 3.1f |  |  |
| finishEvent | FADE IN COMPLETE | FADE IN COMPLETE |  |  |
| realTime | false | false |  |  |

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
| eventTarget | EventTarget(GameObject):Start Blanker | EventTarget(GameObject):Start Blanker |  |  |
| sendEvent | "OUT" | "OUT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool No Fade | bool No Fade | Variable |  |
| isTrue | NO FADE | NO FADE |  |  |
| isFalse |  |  |  |  |
| everyFrame | false | false |  |  |

##### 3. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool White Fade In | bool White Fade In | Variable |  |
| isTrue | WHITE | WHITE |  |  |
| isFalse | BLACK | BLACK |  |  |
| everyFrame | false | false |  |  |

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
| colorVariable | Color Fade Colour | Color Fade Colour | Variable |  |
| color | Color(0, 0, 0, 1) | Color(0, 0, 0, 1) |  |  |
| everyFrame | false | false |  |  |

##### 2. SetFsmColor

Full Name: HutongGames.PlayMaker.Actions.SetFsmColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Blanker | OwnerDefault Blanker |  |  |
| fsmName | "Blanker Control" | "Blanker Control" | FsmName |  |
| variableName | "Start Colour" | "Start Colour" | FsmColor |  |
| setValue | Color(0, 0, 0, 0) | Color(0, 0, 0, 0) |  |  |
| everyFrame | false | false |  |  |

##### 3. SetFsmColor

Full Name: HutongGames.PlayMaker.Actions.SetFsmColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Blanker | OwnerDefault Blanker |  |  |
| fsmName | "Blanker Control" | "Blanker Control" | FsmName |  |
| variableName | "End Colour" | "End Colour" | FsmColor |  |
| setValue | Color(0, 0, 0, 1) | Color(0, 0, 0, 1) |  |  |
| everyFrame | false | false |  |  |

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
| colorVariable | Color Fade Colour | Color Fade Colour | Variable |  |
| color | Color(1, 1, 1, 1) | Color(1, 1, 1, 1) |  |  |
| everyFrame | false | false |  |  |

##### 2. SetFsmColor

Full Name: HutongGames.PlayMaker.Actions.SetFsmColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Blanker | OwnerDefault Blanker |  |  |
| fsmName | "Blanker Control" | "Blanker Control" | FsmName |  |
| variableName | "Start Colour" | "Start Colour" | FsmColor |  |
| setValue | Color(1, 1, 1, 0) | Color(1, 1, 1, 0) |  |  |
| everyFrame | false | false |  |  |

##### 3. SetFsmColor

Full Name: HutongGames.PlayMaker.Actions.SetFsmColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Blanker | OwnerDefault Blanker |  |  |
| fsmName | "Blanker Control" | "Blanker Control" | FsmName |  |
| variableName | "End Colour" | "End Colour" | FsmColor |  |
| setValue | Color(1, 1, 1, 1) | Color(1, 1, 1, 1) |  |  |
| everyFrame | false | false |  |  |

##### 4. SetMaterialColor

Full Name: HutongGames.PlayMaker.Actions.SetMaterialColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Blanker | OwnerDefault Blanker |  |  |
| materialIndex | 0 | 0 |  |  |
| material | [FsmMaterial not implemented] | [FsmMaterial not implemented] |  |  |
| namedColor | "_Color" | "_Color" | NamedColor |  |
| color | Color(1, 1, 1, 1) | Color(1, 1, 1, 1) |  |  |
| everyFrame | false | false |  |  |

##### 5. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.4f | 0.4f |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

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
| boolVariable | bool White Fade In | bool White Fade In | Variable |  |
| isTrue | WHITE | WHITE |  |  |
| isFalse | BLACK | BLACK |  |  |
| everyFrame | false | false |  |  |

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
| colorVariable | Color Fade Colour | Color Fade Colour | Variable |  |
| color | Color(1, 1, 1, 1) | Color(1, 1, 1, 1) |  |  |
| everyFrame | false | false |  |  |

##### 2. SetFsmColor

Full Name: HutongGames.PlayMaker.Actions.SetFsmColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Blanker | OwnerDefault Blanker |  |  |
| fsmName | "Blanker Control" | "Blanker Control" | FsmName |  |
| variableName | "Start Colour" | "Start Colour" | FsmColor |  |
| setValue | Color(1, 1, 1, 0) | Color(1, 1, 1, 0) |  |  |
| everyFrame | false | false |  |  |

##### 3. SetFsmColor

Full Name: HutongGames.PlayMaker.Actions.SetFsmColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Blanker | OwnerDefault Blanker |  |  |
| fsmName | "Blanker Control" | "Blanker Control" | FsmName |  |
| variableName | "End Colour" | "End Colour" | FsmColor |  |
| setValue | Color(1, 1, 1, 1) | Color(1, 1, 1, 1) |  |  |
| everyFrame | false | false |  |  |

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
| colorVariable | Color Fade Colour | Color Fade Colour | Variable |  |
| color | Color(0, 0, 0, 1) | Color(0, 0, 0, 1) |  |  |
| everyFrame | false | false |  |  |

##### 2. SetFsmColor

Full Name: HutongGames.PlayMaker.Actions.SetFsmColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Blanker | OwnerDefault Blanker |  |  |
| fsmName | "Blanker Control" | "Blanker Control" | FsmName |  |
| variableName | "Start Colour" | "Start Colour" | FsmColor |  |
| setValue | Color(0, 0, 0, 0) | Color(0, 0, 0, 0) |  |  |
| everyFrame | false | false |  |  |

##### 3. SetFsmColor

Full Name: HutongGames.PlayMaker.Actions.SetFsmColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Blanker | OwnerDefault Blanker |  |  |
| fsmName | "Blanker Control" | "Blanker Control" | FsmName |  |
| variableName | "End Colour" | "End Colour" | FsmColor |  |
| setValue | Color(0, 0, 0, 1) | Color(0, 0, 0, 1) |  |  |
| everyFrame | false | false |  |  |

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
| color | Color(0, 0, 0, 1) | Color(0, 0, 0, 1) |  |  |
| delay | 0f | 0f |  |  |
| time | 0.001f | 0.001f |  |  |
| finishEvent | FADE IN COMPLETE | FADE IN COMPLETE |  |  |
| realTime | false | false |  |  |

##### 2. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Blanker | OwnerDefault Blanker |  |  |
| fsmName | "Blanker Control" | "Blanker Control" | FsmName |  |
| variableName | "Fade Time" | "Fade Time" | FsmFloat |  |
| setValue | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Blanker | EventTarget(GameObject):Blanker |  |  |
| sendEvent | "FADE OUT" | "FADE OUT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 4. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0f | 0f |  |  |
| finishEvent | FADE IN COMPLETE | FADE IN COMPLETE |  |  |
| realTime | false | false |  |  |

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
| sendEvent | FINISHED | FINISHED |  |  |

##### 2. GetOwner

Full Name: HutongGames.PlayMaker.Actions.GetOwner
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeGameObject | GameObject Self | GameObject Self | Variable |  |

##### 3. SetGameObject

Full Name: HutongGames.PlayMaker.Actions.SetGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variable | [Global] GameObject MainCamera | [Global] GameObject MainCamera | Variable |  |
| gameObject | GameObject Self | GameObject Self |  |  |
| everyFrame | false | false |  |  |

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
| sendEvent | FINISHED | FINISHED |  |  |

##### 2. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Blanker | OwnerDefault Blanker |  |  |
| fsmName | "Blanker Control" | "Blanker Control" | FsmName |  |
| variableName | "Fade Time" | "Fade Time" | FsmFloat |  |
| setValue | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Blanker | EventTarget(GameObject):Blanker |  |  |
| sendEvent | "FADE IN INSTANT" | "FADE IN INSTANT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

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
| eventTarget | EventTarget(GameObject):Blanker | EventTarget(GameObject):Blanker |  |  |
| sendEvent | "FADE OUT INSTANT" | "FADE OUT INSTANT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

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
| eventTarget | EventTarget(GameObject):Blanker | EventTarget(GameObject):Blanker |  |  |
| sendEvent | "FADE IN INSTANT" | "FADE IN INSTANT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Normal | FADE OUT | FadingOut | 0 | 0 | 0 |
| Normal | RESPAWN FADE | RespawnFadingOut | 0 | 0 | 0 |
| Normal | HAZARD FADE | HazardFadingOut | 0 | 0 | 0 |
| Normal | JUST FADE | Just Fading | 0 | 0 | 0 |
| Normal | FADE INSTANT | Instant Fade | 0 | 0 | 0 |
| Normal | START FADE | Start Fade | 0 | 0 | 0 |
| FadingOut | FADE OUT COMPLETE | White Fade In? 2 | 0 | 0 | 0 |
| FadeIn | FADE IN COMPLETE | Normal | 0 | 0 | 0 |
| FadeIn | JUST FADE | Just Fading | 0 | 0 | 0 |
| Done | LEVEL LOADED | Wait For Fade In | 0 | 0 | 0 |
| RespawnFadingOut | RESPAWN FADE OUT COMPLETE | WaitForRespawn | 0 | 0 | 0 |
| WaitForRespawn | RESPAWN | FadeIn | 0 | 0 | 0 |
| HazardFadingOut | HAZARD FADE OUT COMPLETE | WaitForHazardRespawn | 0 | 0 | 0 |
| WaitForHazardRespawn | RESPAWN | FadeIn | 0 | 0 | 0 |
| Instant Fade | FADE BACK | Fade Back | 0 | 0 | 0 |
| Instant Fade | LEVEL LOADED | Wait For Fade In | 0 | 0 | 0 |
| Fade Back | FADE IN COMPLETE | Normal | 0 | 0 | 0 |
| Init | FINISHED | Wait For Fade In | 0 | 0 | 0 |
| Wait For Fade In | FADE SCENE IN | White Fade In? | 0 | 0 | 0 |
| Slow Fade In | FADE IN COMPLETE | Normal | 0 | 0 | 0 |
| Slow Fade In | JUST FADE | Just Fading | 0 | 0 | 0 |
| White Fade In? | WHITE | Set White | 0 | 0 | 0 |
| White Fade In? | BLACK | Set Black | 0 | 0 | 0 |
| White Fade In? | NO FADE | Insta Fade Out | 0 | 0 | 0 |
| Set Black | FINISHED | FadeIn | 0 | 0 | 0 |
| Set White | FINISHED | FadeIn | 0 | 0 | 0 |
| White Fade In? 2 | WHITE | Set White 2 | 0 | 0 | 0 |
| White Fade In? 2 | BLACK | Set Black 2 | 0 | 0 | 0 |
| Set White 2 | FINISHED | Done | 0 | 0 | 0 |
| Set Black 2 | FINISHED | Done | 0 | 0 | 0 |
| Instant Fade In | FADE IN COMPLETE | Normal | 0 | 0 | 0 |
| Instant Fade In | JUST FADE | Just Fading | 0 | 0 | 0 |
| Pause | FINISHED | Init | 0 | 0 | 0 |
| Pre Fade | FINISHED | White Fade In? | 0 | 0 | 0 |
| Insta Fade Out | FINISHED | Normal | 0 | 0 | 0 |
| Fade Out Instant | FINISHED | White Fade In? 2 | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| FADE OUT | FadingOut | 0 | 0 | 0 |
| FADE SCENE IN SLOWLY | Slow Fade In | 0 | 0 | 0 |
| FADE SCENE IN INSTANT | Instant Fade In | 0 | 0 | 0 |
| FADE SCENE IN | Pre Fade | 0 | 0 | 0 |
| FADE OUT INSTANT | Fade Out Instant | 0 | 0 | 0 |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| LEVEL LOADED | false |
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
| HAZARD FADE | false |
| HAZARD FADE OUT COMPLETE | false |
| JUST FADE | false |
| NO FADE | false |
| RESPAWN | false |
| RESPAWN FADE | false |
| RESPAWN FADE OUT COMPLETE | false |
| START FADE | false |
| STOPMOVE | true |
| WHITE | false |

