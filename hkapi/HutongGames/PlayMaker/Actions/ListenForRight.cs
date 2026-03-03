using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009FA RID: 2554
	[ActionCategory("Controls")]
	[Tooltip("Listens for an action button press (using HeroActions InControl mappings).")]
	public class ListenForRight : FsmStateAction
	{
		// Token: 0x060037A7 RID: 14247 RVA: 0x00147775 File Offset: 0x00145975
		public override void Reset()
		{
			this.eventTarget = null;
		}

		// Token: 0x060037A8 RID: 14248 RVA: 0x0014777E File Offset: 0x0014597E
		public override void OnEnter()
		{
			this.gm = GameManager.instance;
			this.inputHandler = this.gm.GetComponent<InputHandler>();
		}

		// Token: 0x060037A9 RID: 14249 RVA: 0x0014779C File Offset: 0x0014599C
		public override void OnUpdate()
		{
			if (!this.gm.isPaused)
			{
				if (this.inputHandler.inputActions.right.WasPressed)
				{
					base.Fsm.Event(this.wasPressed);
				}
				if (this.inputHandler.inputActions.right.WasReleased)
				{
					base.Fsm.Event(this.wasReleased);
				}
				if (this.inputHandler.inputActions.right.IsPressed)
				{
					base.Fsm.Event(this.isPressed);
				}
				if (!this.inputHandler.inputActions.right.IsPressed)
				{
					base.Fsm.Event(this.isNotPressed);
				}
			}
		}

		// Token: 0x04003A16 RID: 14870
		[Tooltip("Where to send the event.")]
		public FsmEventTarget eventTarget;

		// Token: 0x04003A17 RID: 14871
		public FsmEvent wasPressed;

		// Token: 0x04003A18 RID: 14872
		public FsmEvent wasReleased;

		// Token: 0x04003A19 RID: 14873
		public FsmEvent isPressed;

		// Token: 0x04003A1A RID: 14874
		public FsmEvent isNotPressed;

		// Token: 0x04003A1B RID: 14875
		private GameManager gm;

		// Token: 0x04003A1C RID: 14876
		private InputHandler inputHandler;
	}
}
