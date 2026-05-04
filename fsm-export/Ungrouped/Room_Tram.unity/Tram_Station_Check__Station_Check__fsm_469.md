# Station Check

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Station Check |
| GameObject Name | Tram Station Check |
| GameObject Path |   |
| Source Asset | D:/SteamLibrary/steamapps/common/Hollow Knight/hollow_knight_Data/level23 |
| Start State | Set |
| FSM PathId | 469 |
| GameObject PathId | 91 |

## Variables

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| tramLowerPosition | 0 | Int32: 0 |
| tramRestingGroundsPosition | 0 | Int32: 0 |

## States

### Set

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| intName |   | "tramLowerPosition" |   |   |
| storeValue |   | int tramLowerPosition | Variable |   |

##### 2. IntClamp

Full Name: HutongGames.PlayMaker.Actions.IntClamp
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int tramLowerPosition | Variable |   |
| minValue |   | 0 |   |   |
| maxValue |   | 2 |   |   |
| everyFrame |   | false |   |   |

##### 3. SetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intName |   | "tramLowerPosition" |   |   |
| value |   | int tramLowerPosition |   |   |

##### 4. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| intName |   | "tramRestingGroundsPosition" |   |   |
| storeValue |   | int tramRestingGroundsPosition | Variable |   |

##### 5. IntClamp

Full Name: HutongGames.PlayMaker.Actions.IntClamp
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int tramRestingGroundsPosition | Variable |   |
| minValue |   | 0 |   |   |
| maxValue |   | 1 |   |   |
| everyFrame |   | false |   |   |

##### 6. SetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intName |   | "tramRestingGroundsPosition" |   |   |
| value |   | int tramRestingGroundsPosition |   |   |

#### Transitions

(none)

## Global Transitions

(none)

## Events

(none)

