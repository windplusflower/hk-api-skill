using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009F9 RID: 2553
	[ActionCategory("Controls")]
	[Tooltip("Listens for an action button press (using HeroActions InControl mappings).")]
	public class ListenForQuickMap : FsmStateAction
	{
		// Token: 0x060037A3 RID: 14243 RVA: 0x00147691 File Offset: 0x00145891
		public override void Reset()
		{
			this.eventTarget = null;
		}

		// Token: 0x060037A4 RID: 14244 RVA: 0x0014769A File Offset: 0x0014589A
		public override void OnEnter()
		{
			this.gm = GameManager.instance;
			this.inputHandler = this.gm.GetComponent<InputHandler>();
		}

		// Token: 0x060037A5 RID: 14245 RVA: 0x001476B8 File Offset: 0x001458B8
		public override void OnUpdate()
		{
			if (!this.gm.isPaused)
			{
				if (this.inputHandler.inputActions.quickMap.WasPressed)
				{
					base.Fsm.Event(this.wasPressed);
				}
				if (this.inputHandler.inputActions.quickMap.WasReleased)
				{
					base.Fsm.Event(this.wasReleased);
				}
				if (this.inputHandler.inputActions.quickMap.IsPressed)
				{
					base.Fsm.Event(this.isPressed);
				}
				if (!this.inputHandler.inputActions.quickMap.IsPressed)
				{
					base.Fsm.Event(this.isNotPressed);
				}
			}
		}

		// Token: 0x04003A0F RID: 14863
		[Tooltip("Where to send the event.")]
		public FsmEventTarget eventTarget;

		// Token: 0x04003A10 RID: 14864
		public FsmEvent wasPressed;

		// Token: 0x04003A11 RID: 14865
		public FsmEvent wasReleased;

		// Token: 0x04003A12 RID: 14866
		public FsmEvent isPressed;

		// Token: 0x04003A13 RID: 14867
		public FsmEvent isNotPressed;

		// Token: 0x04003A14 RID: 14868
		private GameManager gm;

		// Token: 0x04003A15 RID: 14869
		private InputHandler inputHandler;
	}
}
