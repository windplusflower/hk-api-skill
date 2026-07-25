# Evolution Note - 2026-06-13 07:51:49

- Question: How does Hollow Knight decide whether to show completion percentage on the ending screen versus normal UI?
- Target: `rules/core/core-classes.md`
- Risk: `low`
- Status: `applied to target rule`
- Marker: `<!-- evolution:adb98ee2e8f9 -->`

## Learned Facts

- End_Game_Completion uses GameCompletionScreen.Start, calls PlayerData.CountGameCompletion, and writes SaveStats.GetCompletionPercentage directly to percentageNumber.
- SaveStats.GetCompletionPercentage only formats completionPercentage with a percent sign; it does not check unlockedCompletionRate.
- Save-slot UI hides completionText unless SaveStats.unlockedCompletionRate is true.
- The Black Egg Temple lore tablet in Room_Final_Boss_Atrium has Completion Rate Prompt=true and sets PlayerData bool unlockedCompletionRate to true.
- Inventory and Journal FSMs test unlockedCompletionRate before activating their completion text.

## Sources

- `hkapi/GameCompletionScreen.cs:10`
- `hkapi/SaveStats.cs:94`
- `hkapi/UnityEngine/UI/SaveSlotButton.cs:642`
- `fsm-export/Ungrouped/Room_Final_Boss_Atrium.unity/Tut_tablet_top__Inspection__fsm_2211.md:38`
- `fsm-export/Ungrouped/Room_Final_Boss_Atrium.unity/Tut_tablet_top__Inspection__fsm_2211.md:1952`
- `fsm-export/Ungrouped/Menu_Title.unity/Inv__UI_Inventory__fsm_9127.md:7675`
- `fsm-export/Ungrouped/Menu_Title.unity/Journal__UI_Journal__fsm_8969.md:202`
