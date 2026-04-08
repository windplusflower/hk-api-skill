# Menu Control

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Menu Control |
| GameObject Name | Deposit Menu |
| GameObject Path | Bank Menu |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets218.assets |
| Start State | Init |
| FSM PathId | 228 |
| GameObject PathId | 60 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Roller Float | 0 | Single: 0 |

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Balance | 0 | Int32: 0 |
| Balance Display | 0 | Int32: 0 |
| Balance Limit | 0 | Int32: 0 |
| Balance Over | 0 | Int32: 0 |
| Deposit Amount | 0 | Int32: 0 |
| New Balance | 0 | Int32: 0 |
| Player Geo | 0 | Int32: 0 |
| Prev Deposit | 0 | Int32: 0 |
| Repeats | 0 | Int32: 0 |
| Roller Int | 0 | Int32: 0 |
| Transaction Amount | 0 | Int32: 0 |
| Transaction Amount Rpt | 0 | Int32: 0 |
| Transaction Amount Rpt2 | 0 | Int32: 0 |

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| Balance Limit String |  | String:  |
| Balance String |  | String:  |
| Deposit String |  | String:  |
| Tran String |  | String:  |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Arrow D | [null] | NamedAssetPPtr:  |
| Arrow U | [null] | NamedAssetPPtr:  |
| Balance Txt | [null] | NamedAssetPPtr:  |
| Deposit Txt | [null] | NamedAssetPPtr:  |
| Max Up 1 | [null] | NamedAssetPPtr:  |
| Max Up 2 | [null] | NamedAssetPPtr:  |
| Menu 1 | [null] | NamedAssetPPtr:  |
| Parent | [null] | NamedAssetPPtr:  |

## States

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetParent

Full Name: HutongGames.PlayMaker.Actions.GetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| storeResult | GameObject Parent | GameObject Parent | Variable |  |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Parent | OwnerDefault Parent |  |  |
| childName | "Menu 1" | "Menu 1" |  |  |
| storeResult | GameObject Menu 1 | GameObject Menu 1 | Variable |  |

##### 3. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Parent | OwnerDefault Parent |  |  |
| childName | "Txt Balance Amount" | "Txt Balance Amount" |  |  |
| storeResult | GameObject Balance Txt | GameObject Balance Txt | Variable |  |

##### 4. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Arrow D" | "Arrow D" |  |  |
| storeResult | GameObject Arrow D | GameObject Arrow D | Variable |  |

##### 5. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Arrow U" | "Arrow U" |  |  |
| storeResult | GameObject Arrow U | GameObject Arrow U | Variable |  |

##### 6. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Txt Deposit Amount" | "Txt Deposit Amount" |  |  |
| storeResult | GameObject Deposit Txt | GameObject Deposit Txt | Variable |  |

##### 7. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Max Up 1" | "Max Up 1" |  |  |
| storeResult | GameObject Max Up 1 | GameObject Max Up 1 | Variable |  |

##### 8. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Max Up 2" | "Max Up 2" |  |  |
| storeResult | GameObject Max Up 2 | GameObject Max Up 2 | Variable |  |

##### 9. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prices" | "Prices" |  |  |
| convName | "BANK_TRANSACTION_AMOUNT" | "BANK_TRANSACTION_AMOUNT" |  |  |
| storeValue | string Tran String | string Tran String | Variable |  |

##### 10. ConvertStringToInt

Full Name: HutongGames.PlayMaker.Actions.ConvertStringToInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Tran String | string Tran String | Variable |  |
| intVariable | int Transaction Amount | int Transaction Amount | Variable |  |
| everyFrame | false | false |  |  |

##### 11. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Transaction Amount Rpt | int Transaction Amount Rpt | Variable |  |
| intValue | int Transaction Amount | int Transaction Amount |  |  |
| everyFrame | false | false |  |  |

##### 12. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Transaction Amount Rpt2 | int Transaction Amount Rpt2 | Variable |  |
| intValue | int Transaction Amount | int Transaction Amount |  |  |
| everyFrame | false | false |  |  |

##### 13. IntOperator

Full Name: HutongGames.PlayMaker.Actions.IntOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Transaction Amount Rpt | int Transaction Amount Rpt |  |  |
| integer2 | 5 | 5 |  |  |
| operation | HutongGames.PlayMaker.Actions.IntOperator/Operation::Multiply | 2 |  |  |
| storeResult | int Transaction Amount Rpt | int Transaction Amount Rpt | Variable |  |
| everyFrame | false | false |  |  |

##### 14. IntOperator

Full Name: HutongGames.PlayMaker.Actions.IntOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Transaction Amount Rpt2 | int Transaction Amount Rpt2 |  |  |
| integer2 | 10 | 10 |  |  |
| operation | HutongGames.PlayMaker.Actions.IntOperator/Operation::Multiply | 2 |  |  |
| storeResult | int Transaction Amount Rpt2 | int Transaction Amount Rpt2 | Variable |  |
| everyFrame | false | false |  |  |

##### 15. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Deposit Amount | int Deposit Amount | Variable |  |
| intValue | 0 | 0 |  |  |
| everyFrame | false | false |  |  |

##### 16. ConvertIntToString

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Deposit Amount | int Deposit Amount | Variable |  |
| stringVariable | string Deposit String | string Deposit String | Variable |  |
| format | "" | "" |  |  |
| everyFrame | false | false |  |  |

##### 17. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Deposit Txt | OwnerDefault Deposit Txt |  |  |
| textString | string Deposit String | string Deposit String |  |  |

##### 18. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Max Up 1 | OwnerDefault Max Up 1 |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 19. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Max Up 2 | OwnerDefault Max Up 2 |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 20. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prices" | "Prices" |  |  |
| convName | "BANK_LIMIT" | "BANK_LIMIT" |  |  |
| storeValue | string Balance Limit String | string Balance Limit String | Variable |  |

##### 21. ConvertStringToInt

Full Name: HutongGames.PlayMaker.Actions.ConvertStringToInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Balance Limit String | string Balance Limit String | Variable |  |
| intVariable | int Balance Limit | int Balance Limit | Variable |  |
| everyFrame | false | false |  |  |

##### 22. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "bankerBalance" | "bankerBalance" |  |  |
| storeValue | int Balance | int Balance | Variable |  |

### Menu Up

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:FSM Owner | EventTarget(GameObject)[SendToChildren]:FSM Owner |  |  |
| sendEvent | "UP" | "UP" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.3f | 0.3f |  |  |
| finishEvent | Event() | Event() |  |  |
| realTime | false | false |  |  |

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 6

#### Actions

_None_

### Up Pressed

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Arrow U | EventTarget(GameObject):Arrow U |  |  |
| sendEvent | "MOVE" | "MOVE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Prev Deposit | int Prev Deposit | Variable |  |
| intValue | int Deposit Amount | int Deposit Amount |  |  |
| everyFrame | false | false |  |  |

##### 3. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Deposit Amount | int Deposit Amount | Variable |  |
| add | int Transaction Amount | int Transaction Amount |  |  |
| everyFrame | false | false |  |  |

##### 4. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "geo" | "geo" |  |  |
| storeValue | int Player Geo | int Player Geo | Variable |  |

##### 5. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Deposit Amount | int Deposit Amount |  |  |
| integer2 | int Player Geo | int Player Geo |  |  |
| equal | Event(FINISHED) | Event(FINISHED) |  |  |
| lessThan | Event(FINISHED) | Event(FINISHED) |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 6. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Deposit Amount | int Deposit Amount | Variable |  |
| intValue | int Prev Deposit | int Prev Deposit |  |  |
| everyFrame | false | false |  |  |

### Down Pressed

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Arrow D | EventTarget(GameObject):Arrow D |  |  |
| sendEvent | "MOVE" | "MOVE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. IntOperator

Full Name: HutongGames.PlayMaker.Actions.IntOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Deposit Amount | int Deposit Amount |  |  |
| integer2 | int Transaction Amount | int Transaction Amount |  |  |
| operation | HutongGames.PlayMaker.Actions.IntOperator/Operation::Subtract | 1 |  |  |
| storeResult | int Deposit Amount | int Deposit Amount | Variable |  |
| everyFrame | false | false |  |  |

### Refresh Amount

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. ConvertIntToString

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Deposit Amount | int Deposit Amount | Variable |  |
| stringVariable | string Deposit String | string Deposit String | Variable |  |
| format | "" | "" |  |  |
| everyFrame | false | false |  |  |

##### 2. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | [Global] GameObject Hero | [Global] GameObject Hero |  |  |
| audioClip | [ui_option_click (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets0.assets)] | [ui_option_click (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets0.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 3. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Deposit Txt | OwnerDefault Deposit Txt |  |  |
| textString | string Deposit String | string Deposit String |  |  |

### Repeats?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. GetFsmInt

Full Name: HutongGames.PlayMaker.Actions.GetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "ui_list_getinput" | "ui_list_getinput" | FsmName |  |
| variableName | "Repeats" | "Repeats" | FsmInt |  |
| storeValue | int Repeats | int Repeats | Variable |  |
| everyFrame | false | false |  |  |

##### 2. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Repeats | int Repeats |  |  |
| integer2 | 5 | 5 |  |  |
| equal | Event(FINISHED) | Event(FINISHED) |  |  |
| lessThan | Event(FINISHED) | Event(FINISHED) |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 3. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Repeats | int Repeats |  |  |
| integer2 | 10 | 10 |  |  |
| equal | Event(REPEAT) | Event(REPEAT) |  |  |
| lessThan | Event(REPEAT) | Event(REPEAT) |  |  |
| greaterThan | Event(REPEAT 2) | Event(REPEAT 2) |  |  |
| everyFrame | false | false |  |  |

### Up Pressed Rpt

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Arrow U | EventTarget(GameObject):Arrow U |  |  |
| sendEvent | "MOVE" | "MOVE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Prev Deposit | int Prev Deposit | Variable |  |
| intValue | int Deposit Amount | int Deposit Amount |  |  |
| everyFrame | false | false |  |  |

##### 3. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Deposit Amount | int Deposit Amount | Variable |  |
| add | int Transaction Amount Rpt | int Transaction Amount Rpt |  |  |
| everyFrame | false | false |  |  |

##### 4. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "geo" | "geo" |  |  |
| storeValue | int Player Geo | int Player Geo | Variable |  |

##### 5. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Deposit Amount | int Deposit Amount |  |  |
| integer2 | int Player Geo | int Player Geo |  |  |
| equal | Event(FINISHED) | Event(FINISHED) |  |  |
| lessThan | Event(FINISHED) | Event(FINISHED) |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 6. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Deposit Amount | int Deposit Amount | Variable |  |
| intValue | int Prev Deposit | int Prev Deposit |  |  |
| everyFrame | false | false |  |  |

##### 7. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | Event(CANCEL) | Event(CANCEL) |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Down Pressed 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Arrow D | EventTarget(GameObject):Arrow D |  |  |
| sendEvent | "MOVE" | "MOVE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. IntOperator

Full Name: HutongGames.PlayMaker.Actions.IntOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Deposit Amount | int Deposit Amount |  |  |
| integer2 | int Transaction Amount Rpt | int Transaction Amount Rpt |  |  |
| operation | HutongGames.PlayMaker.Actions.IntOperator/Operation::Subtract | 1 |  |  |
| storeResult | int Deposit Amount | int Deposit Amount | Variable |  |
| everyFrame | false | false |  |  |

### Repeats? D

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. GetFsmInt

Full Name: HutongGames.PlayMaker.Actions.GetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "ui_list_getinput" | "ui_list_getinput" | FsmName |  |
| variableName | "Repeats" | "Repeats" | FsmInt |  |
| storeValue | int Repeats | int Repeats | Variable |  |
| everyFrame | false | false |  |  |

##### 2. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Repeats | int Repeats |  |  |
| integer2 | 5 | 5 |  |  |
| equal | Event(FINISHED) | Event(FINISHED) |  |  |
| lessThan | Event(FINISHED) | Event(FINISHED) |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 3. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Repeats | int Repeats |  |  |
| integer2 | 10 | 10 |  |  |
| equal | Event(REPEAT) | Event(REPEAT) |  |  |
| lessThan | Event(REPEAT) | Event(REPEAT) |  |  |
| greaterThan | Event(REPEAT 2) | Event(REPEAT 2) |  |  |
| everyFrame | false | false |  |  |

### Stop at 0

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Deposit Amount | int Deposit Amount |  |  |
| integer2 | 0 | 0 |  |  |
| equal | Event(FINISHED) | Event(FINISHED) |  |  |
| lessThan | Event() | Event() |  |  |
| greaterThan | Event(FINISHED) | Event(FINISHED) |  |  |
| everyFrame | false | false |  |  |

##### 2. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Deposit Amount | int Deposit Amount | Variable |  |
| intValue | 0 | 0 |  |  |
| everyFrame | false | false |  |  |

### Up Pressed Rpt 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Arrow U | EventTarget(GameObject):Arrow U |  |  |
| sendEvent | "MOVE" | "MOVE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Prev Deposit | int Prev Deposit | Variable |  |
| intValue | int Deposit Amount | int Deposit Amount |  |  |
| everyFrame | false | false |  |  |

##### 3. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Deposit Amount | int Deposit Amount | Variable |  |
| add | int Transaction Amount Rpt2 | int Transaction Amount Rpt2 |  |  |
| everyFrame | false | false |  |  |

##### 4. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "geo" | "geo" |  |  |
| storeValue | int Player Geo | int Player Geo | Variable |  |

##### 5. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Deposit Amount | int Deposit Amount |  |  |
| integer2 | int Player Geo | int Player Geo |  |  |
| equal | Event(FINISHED) | Event(FINISHED) |  |  |
| lessThan | Event(FINISHED) | Event(FINISHED) |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 6. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Deposit Amount | int Deposit Amount | Variable |  |
| intValue | int Prev Deposit | int Prev Deposit |  |  |
| everyFrame | false | false |  |  |

##### 7. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | Event(CANCEL) | Event(CANCEL) |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Down Pressed 3

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Arrow D | EventTarget(GameObject):Arrow D |  |  |
| sendEvent | "MOVE" | "MOVE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. IntOperator

Full Name: HutongGames.PlayMaker.Actions.IntOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Deposit Amount | int Deposit Amount |  |  |
| integer2 | int Transaction Amount Rpt2 | int Transaction Amount Rpt2 |  |  |
| operation | HutongGames.PlayMaker.Actions.IntOperator/Operation::Subtract | 1 |  |  |
| storeResult | int Deposit Amount | int Deposit Amount | Variable |  |
| everyFrame | false | false |  |  |

### Confirm

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Max Up 1 | OwnerDefault Max Up 1 |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 2. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | [Global] GameObject Hero | [Global] GameObject Hero |  |  |
| audioClip | [ui_button_confirm (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets0.assets)] | [ui_button_confirm (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets0.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Max Up 2 | OwnerDefault Max Up 2 |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 4. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.5f | 0.5f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Cancel amount

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Deposit Amount | int Deposit Amount | Variable |  |
| intValue | 0 | 0 |  |  |
| everyFrame | false | false |  |  |

##### 2. ConvertIntToString

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Deposit Amount | int Deposit Amount | Variable |  |
| stringVariable | string Deposit String | string Deposit String | Variable |  |
| format | "" | "" |  |  |
| everyFrame | false | false |  |  |

##### 3. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Deposit Txt | OwnerDefault Deposit Txt |  |  |
| textString | string Deposit String | string Deposit String |  |  |

### Not Zero?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Deposit Amount | int Deposit Amount |  |  |
| integer2 | 0 | 0 |  |  |
| equal | Event(END) | Event(END) |  |  |
| lessThan | Event(END) | Event(END) |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

### Menu Down

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:FSM Owner | EventTarget(GameObject)[SendToChildren]:FSM Owner |  |  |
| sendEvent | "DOWN" | "DOWN" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.3f | 0.3f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Menu 1 Up

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Menu 1 | OwnerDefault Menu 1 |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 2. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

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

##### 2. ConvertIntToString

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Deposit Amount | int Deposit Amount | Variable |  |
| stringVariable | string Deposit String | string Deposit String | Variable |  |
| format | "" | "" |  |  |
| everyFrame | false | false |  |  |

### Take Geo

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | TakeGeo(Deposit Amount=int Deposit Amount) | TakeGeo(Deposit Amount=int Deposit Amount) |  |  |

### Confirm Down

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:FSM Owner | EventTarget(GameObject)[SendToChildren]:FSM Owner |  |  |
| sendEvent | "DOWN" | "DOWN" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 1.5f | 1.5f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Increment Balance

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "bankerBalance" | "bankerBalance" |  |  |
| storeValue | int Balance | int Balance | Variable |  |

##### 2. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Balance Display | int Balance Display | Variable |  |
| intValue | int Balance | int Balance |  |  |
| everyFrame | false | false |  |  |

##### 3. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Balance | int Balance | Variable |  |
| add | int Deposit Amount | int Deposit Amount |  |  |
| everyFrame | false | false |  |  |

##### 4. SetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intName | "bankerBalance" | "bankerBalance" |  |  |
| value | int Balance | int Balance |  |  |

### Set Roller

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. ConvertIntToFloat

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Deposit Amount | int Deposit Amount | Variable |  |
| floatVariable | float Roller Float | float Roller Float | Variable |  |
| everyFrame | false | false |  |  |

##### 2. FloatMultiply

Full Name: HutongGames.PlayMaker.Actions.FloatMultiply
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Roller Float | float Roller Float | Variable |  |
| multiplyBy | 0.025f | 0.025f |  |  |
| everyFrame | false | false |  |  |

##### 3. FloatMultiply

Full Name: HutongGames.PlayMaker.Actions.FloatMultiply
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Roller Float | float Roller Float | Variable |  |
| multiplyBy | 1.75f | 1.75f |  |  |
| everyFrame | false | false |  |  |

##### 4. ConvertFloatToInt

Full Name: HutongGames.PlayMaker.Actions.ConvertFloatToInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Roller Float | float Roller Float | Variable |  |
| intVariable | int Roller Int | int Roller Int | Variable |  |
| rounding | HutongGames.PlayMaker.Actions.ConvertFloatToInt/FloatRounding::RoundUp | 1 |  |  |
| everyFrame | false | false |  |  |

### Roll Time

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.025f | 0.025f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

##### 2. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Balance Display | int Balance Display |  |  |
| integer2 | int Balance | int Balance |  |  |
| equal | Event(END) | Event(END) |  |  |
| lessThan | Event() | Event() |  |  |
| greaterThan | Event(END) | Event(END) |  |  |
| everyFrame | false | false |  |  |

### Roll Down

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Balance Display | int Balance Display | Variable |  |
| add | int Roller Int | int Roller Int |  |  |
| everyFrame | false | false |  |  |

##### 2. ConvertIntToString

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Balance Display | int Balance Display | Variable |  |
| stringVariable | string Balance String | string Balance String | Variable |  |
| format | "" | "" |  |  |
| everyFrame | false | false |  |  |

##### 3. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Balance Txt | OwnerDefault Balance Txt |  |  |
| textString | string Balance String | string Balance String |  |  |

### Set Correct

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Balance Display | int Balance Display | Variable |  |
| intValue | int Balance | int Balance |  |  |
| everyFrame | false | false |  |  |

##### 2. ConvertIntToString

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Balance Display | int Balance Display | Variable |  |
| stringVariable | string Balance String | string Balance String | Variable |  |
| format | "" | "" |  |  |
| everyFrame | false | false |  |  |

##### 3. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Balance Txt | OwnerDefault Balance Txt |  |  |
| textString | string Balance String | string Balance String |  |  |

##### 4. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.5f | 0.5f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Check Balance Limit

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int New Balance | int New Balance | Variable |  |
| intValue | int Balance | int Balance |  |  |
| everyFrame | false | false |  |  |

##### 2. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int New Balance | int New Balance | Variable |  |
| add | int Deposit Amount | int Deposit Amount |  |  |
| everyFrame | false | false |  |  |

##### 3. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int New Balance | int New Balance |  |  |
| integer2 | int Balance Limit | int Balance Limit |  |  |
| equal | Event(FINISHED) | Event(FINISHED) |  |  |
| lessThan | Event(FINISHED) | Event(FINISHED) |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 4. IntOperator

Full Name: HutongGames.PlayMaker.Actions.IntOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int New Balance | int New Balance |  |  |
| integer2 | int Balance Limit | int Balance Limit |  |  |
| operation | HutongGames.PlayMaker.Actions.IntOperator/Operation::Subtract | 1 |  |  |
| storeResult | int Balance Over | int Balance Over | Variable |  |
| everyFrame | false | false |  |  |

##### 5. IntOperator

Full Name: HutongGames.PlayMaker.Actions.IntOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Deposit Amount | int Deposit Amount |  |  |
| integer2 | int Balance Over | int Balance Over |  |  |
| operation | HutongGames.PlayMaker.Actions.IntOperator/Operation::Subtract | 1 |  |  |
| storeResult | int Deposit Amount | int Deposit Amount | Variable |  |
| everyFrame | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Init | FINISHED | Pause | 0 | 0 | 0 |
| Menu Up | FINISHED | Idle | 0 | 0 | 0 |
| Idle | UI UP | Repeats? | 0 | 0 | 0 |
| Idle | UI DOWN | Repeats? D | 0 | 0 | 0 |
| Idle | UI CONFIRM | Confirm | 0 | 0 | 0 |
| Idle | UI CANCEL | Cancel amount | 0 | 0 | 0 |
| Idle | UI RS UP | Up Pressed Rpt 2 | 0 | 0 | 0 |
| Idle | UI RS DOWN | Down Pressed 3 | 0 | 0 | 0 |
| Up Pressed | FINISHED | Check Balance Limit | 0 | 0 | 0 |
| Down Pressed | FINISHED | Stop at 0 | 0 | 0 | 0 |
| Refresh Amount | FINISHED | Idle | 0 | 0 | 0 |
| Repeats? | FINISHED | Up Pressed | 0 | 0 | 0 |
| Repeats? | REPEAT | Up Pressed Rpt | 0 | 0 | 0 |
| Repeats? | REPEAT 2 | Up Pressed Rpt 2 | 0 | 0 | 0 |
| Up Pressed Rpt | FINISHED | Check Balance Limit | 0 | 0 | 0 |
| Up Pressed Rpt | CANCEL | Up Pressed | 0 | 0 | 0 |
| Down Pressed 2 | FINISHED | Stop at 0 | 0 | 0 | 0 |
| Repeats? D | FINISHED | Down Pressed | 0 | 0 | 0 |
| Repeats? D | REPEAT | Down Pressed 2 | 0 | 0 | 0 |
| Repeats? D | REPEAT 2 | Down Pressed 3 | 0 | 0 | 0 |
| Stop at 0 | FINISHED | Refresh Amount | 0 | 0 | 0 |
| Up Pressed Rpt 2 | FINISHED | Check Balance Limit | 0 | 0 | 0 |
| Up Pressed Rpt 2 | CANCEL | Up Pressed Rpt | 0 | 0 | 0 |
| Down Pressed 3 | FINISHED | Stop at 0 | 0 | 0 | 0 |
| Confirm | FINISHED | Not Zero? | 0 | 0 | 0 |
| Cancel amount | FINISHED | Confirm | 0 | 0 | 0 |
| Not Zero? | END | Menu Down | 0 | 0 | 0 |
| Not Zero? | FINISHED | Take Geo | 0 | 0 | 0 |
| Menu Down | FINISHED | Menu 1 Up | 0 | 0 | 0 |
| Pause | FINISHED | Menu Up | 0 | 0 | 0 |
| Take Geo | FINISHED | Confirm Down | 0 | 0 | 0 |
| Confirm Down | FINISHED | Increment Balance | 0 | 0 | 0 |
| Increment Balance | FINISHED | Set Roller | 0 | 0 | 0 |
| Set Roller | FINISHED | Roll Time | 0 | 0 | 0 |
| Roll Time | FINISHED | Roll Down | 0 | 0 | 0 |
| Roll Time | END | Set Correct | 0 | 0 | 0 |
| Roll Down | FINISHED | Roll Time | 0 | 0 | 0 |
| Set Correct | FINISHED | Menu 1 Up | 0 | 0 | 0 |
| Check Balance Limit | FINISHED | Refresh Amount | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| CANCEL | false |
| END | false |
| FAIL | false |
| REPEAT | false |
| REPEAT 2 | false |
| UI CANCEL | false |
| UI CONFIRM | false |
| UI DOWN | false |
| UI RS DOWN | false |
| UI RS UP | false |
| UI UP | false |

