# zap drift

## Summary

| Field | Value |
| --- | --- |
| FSM Name | zap drift |
| GameObject Name | Zap Cloud (2) |
| GameObject Path |   |
| Source Asset | D:/SteamLibrary/steamapps/common/Hollow Knight/hollow_knight_Data/level213 |
| Start State | State 1 |
| FSM PathId | 4023 |
| GameObject PathId | 833 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Speed Max | 0.800000012 | Single: 0.800000012 |

## States

### State 1

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. IdleBuzz

Full Name: HutongGames.PlayMaker.Actions.IdleBuzz
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| waitMin |   | 0.75f |   |   |
| waitMax |   | 1f |   |   |
| speedMax |   | float Speed Max |   |   |
| accelerationMax |   | 8f |   |   |
| roamingRange |   | 0.4f |   |   |

#### Transitions

(none)

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| MOVESTART | true |
| MOVESTOP | true |

