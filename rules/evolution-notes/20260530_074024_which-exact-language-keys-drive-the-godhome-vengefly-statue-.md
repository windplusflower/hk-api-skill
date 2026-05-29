# Evolution Note - 2026-05-30 07:40:24

- Question: Which exact language keys drive the Godhome Vengefly statue/difficulty-select name vs the in-battle roar title, and how do I override both?
- Target: `rules/systems/game-modification-patterns.md`
- Risk: `low`
- Status: `applied to target rule`
- Marker: `<!-- evolution:4e5c4951c565 -->`

## Learned Facts

- The Godhome Vengefly boss reuses the vanilla 'Big Buzzer' statue: its difficulty-select (BossChallengeUI) name comes from key NAME_BIGBUZZER (zh '反击蝇之王') and its descriptor from GG_S_BIGBUZZ (zh '凶恶的领土之神'). It is NOT a 'GG_S_VENG' style key. Override NAME_BIGBUZZER via ModHooks.LanguageGetHook (scene-gate to GG_Workshop/boss scene so the journal stays vanilla) to rename the statue/difficulty screen.
- The in-battle boss roar title is a separate path: code sets the persistent 'Area Title' object's FSM 'Area Title Control' var 'Area Event' = 'VENGEFLY' and sends an event. The FSM Init routes unknown area events to the 'Other' state, which builds keys <AreaEvent>_MAIN/_SUB/_SUPER in sheet 'Titles' (e.g. VENGEFLY_MAIN). VENGEFLY_MAIN already ships as '复仇蝇之王', so a boss-name override must target VENGEFLY_MAIN in the Titles sheet — a DIFFERENT key/sheet from the statue's NAME_BIGBUZZER.
- Renaming a Godhome boss requires overriding at least two distinct language keys (statue name key + Area Title <event>_MAIN) because the difficulty-select UI and the roar title resolve names independently.
- Language-aware mod display names: Language.Language.CurrentLanguage() returns a LanguageCode enum; Chinese locales are ZH, ZH_CN, ZH_TW, ZH_HK, ZH_SG (check name.StartsWith('ZH') to cover all).

## Sources

- `data/gameDic.json:3011`
- `data/gameDic.json:3918`
- `data/gameDic.json:3718`
- `fsm-export/Ungrouped/Menu_Title.unity/Area_Title__Area_Title_Control__fsm_9398.md:123`
- `fsm-export/Ungrouped/Menu_Title.unity/Area_Title__Area_Title_Control__fsm_9398.md:1774`
- `fsm-export/Ungrouped/Menu_Title.unity/Area_Title__Area_Title_Control__fsm_9398.md:1854`
- `hkapi/BossChallengeUI.cs:47`
- `hkapi/Language/Language.cs:232`
- `hkapi/Language/LanguageCode.cs:407`
