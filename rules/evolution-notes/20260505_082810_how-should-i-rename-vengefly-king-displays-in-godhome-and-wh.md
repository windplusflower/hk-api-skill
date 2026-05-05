# Evolution Note - 2026-05-05 08:28:10

- Question: How should I rename Vengefly King displays in Godhome and where can I verify localization keys?
- Target: `rules/systems/game-modification-patterns.md`
- Risk: `low`
- Status: `applied to target rule`
- Marker: `<!-- evolution:506ba52af36e -->`

## Learned Facts

- Godhome Vengefly challenge UI uses ShowBossChallengeUI and passes bossNameSheet/bossNameKey into BossChallengeUI.Setup, so display-name overrides should prefer ModHooks.LanguageGetHook over scene-local string edits.
- GG_Vengefly.unity contains Giant_Buzzer_Col with FSM Big Buzzer, while the in-game display name Vengefly King is not the primary GameObject name.
- GG_Workshop contains GG_Statue_Vengefly/Inspect with the GG Boss UI FSM, which is the relevant Godhome statue path for Vengefly challenge name display.
- The hk-api skill now carries an internal lookup table at `data/gameDic.json`, which can be used to verify language keys, sheets, and original localized strings during boss-name overrides.

## Sources

- `C:/Users/33361/.config/opencode/skills/hk-api/hkapi/ShowBossChallengeUI.cs:21`
- `C:/Users/33361/.config/opencode/skills/hk-api/hkapi/ShowBossChallengeUI.cs:51`
- `C:/Users/33361/.config/opencode/skills/hk-api/fsm-export/Gods_Glory/GG_Vengefly.unity/Giant_Buzzer_Col__Big_Buzzer__fsm_1381.md:7`
- `C:/Users/33361/.config/opencode/skills/hk-api/fsm-export/Gods_Glory/GG_Workshop.unity/Inspect__GG_Boss_UI__fsm_12621.md:7`
- `C:/Users/33361/.config/opencode/skills/hk-api/data/gameDic.json:1`
