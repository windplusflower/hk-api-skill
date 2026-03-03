using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009F8 RID: 2552
	[ActionCategory("Controls")]
	[Tooltip("Listens for an action button press (using HeroActions InControl mappings).")]
	public class ListenForQuickCast : FsmStateAction
	{
		// Token: 0x0600379F RID: 14239 RVA: 0x001475AD File Offset: 0x001457AD
		public override void Reset()
		{
			this.eventTarget = null;
		}

		// Token: 0x060037A0 RID: 14240 RVA: 0x001475B6 File Offset: 0x001457B6
		public override void OnEnter()
		{
			this.gm = GameManager.instance;
			this.inputHandler = this.gm.GetComponent<InputHandler>();
		}

		// Token: 0x060037A1 RID: 14241 RVA: 0x001475D4 File Offset: 0x001457D4
		public override void OnUpdate()
		{
			if (!this.gm.isPaused)
			{
				if (this.inputHandler.inputActions.quickCast.WasPressed)
				{
					base.Fsm.Event(this.wasPressed);
				}
				if (this.inputHandler.inputActions.quickCast.WasReleased)
				{
					base.Fsm.Event(this.wasReleased);
				}
				if (this.inputHandler.inputActions.quickCast.IsPressed)
				{
					base.Fsm.Event(this.isPressed);
				}
				if (!this.inputHandler.inputActions.quickCast.IsPressed)
				{
					base.Fsm.Event(this.isNotPressed);
				}
			}
		}

		// Token: 0x04003A08 RID: 14856
		[Tooltip("Where to send the event.")]
		public FsmEventTarget eventTarget;

		// Token: 0x04003A09 RID: 14857
		public FsmEvent wasPressed;

		// Token: 0x04003A0A RID: 14858
		public FsmEvent wasReleased;

		// Token: 0x04003A0B RID: 14859
		public FsmEvent isPressed;

		// Token: 0x04003A0C RID: 14860
		public FsmEvent isNotPressed;

		// Token: 0x04003A0D RID: 14861
		private GameManager gm;

		// Token: 0x04003A0E RID: 14862
		private InputHandler inputHandler;
	}
}
