# Evolution Note - 2026-04-11 06:58:28

- Question: 修复 SpellDetectAction 法术方向判定时，HK mod 应该读取哪个输入系统
- Target: `rules/systems/spell-system.md`
- Risk: `low`
- Status: `applied to target rule`
- Marker: `<!-- evolution:3990162f446c -->`

## Learned Facts

- 不要在施法拦截里默认使用 UnityEngine.Input.GetAxisRaw 来判定上下法术方向，Hollow Knight 的动作输入主链是 InputHandler.Instance.inputActions / HeroActions。
- InputHandler 会在 Awake 中初始化 inputActions = new HeroActions()，因此运行时应优先从 InputHandler/HeroActions 读取当前输入状态。
- 原版 PlayMaker 的 ListenForUp / ListenForDown 动作也是通过 inputHandler.inputActions.up/down 的 WasPressed、WasReleased、IsPressed 来驱动 FSM 事件和布尔值。
- 自定义 SpellDetectAction 只需要区分上、下、默认三分支时，可直接读取 inputActions.up.IsPressed 和 inputActions.down.IsPressed；DeVect 的修复已验证该模式。

## Sources

- `hkapi/InputHandler.cs:46`
- `hkapi/HeroActions.cs:8`
- `hkapi/HutongGames/PlayMaker/Actions/ListenForUp.cs:35`
- `hkapi/HutongGames/PlayMaker/Actions/ListenForDown.cs:35`
- `custom mod implementation: SpellDetectAction.cs:20`
- `custom mod spec: DeVectSpellInputHandlerFixAndPush.md:20`
