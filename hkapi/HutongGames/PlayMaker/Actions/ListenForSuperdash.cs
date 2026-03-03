using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009FD RID: 2557
	[ActionCategory("Controls")]
	[Tooltip("Listens for an action button press (using HeroActions InControl mappings).")]
	public class ListenForSuperdash : FsmStateAction
	{
		// Token: 0x060037B3 RID: 14259 RVA: 0x00147A21 File Offset: 0x00145C21
		public override void Reset()
		{
			this.eventTarget = null;
		}

		// Token: 0x060037B4 RID: 14260 RVA: 0x00147A2A File Offset: 0x00145C2A
		public override void OnEnter()
		{
			this.gm = GameManager.instance;
			this.inputHandler = this.gm.GetComponent<InputHandler>();
		}

		// Token: 0x060037B5 RID: 14261 RVA: 0x00147A48 File Offset: 0x00145C48
		public override void OnUpdate()
		{
			if (!this.gm.isPaused)
			{
				if (this.inputHandler.inputActions.superDash.WasPressed)
				{
					base.Fsm.Event(this.wasPressed);
				}
				if (this.inputHandler.inputActions.superDash.WasReleased)
				{
					base.Fsm.Event(this.wasReleased);
				}
				if (this.inputHandler.inputActions.superDash.IsPressed)
				{
					base.Fsm.Event(this.isPressed);
				}
				if (!this.inputHandler.inputActions.superDash.IsPressed)
				{
					base.Fsm.Event(this.isNotPressed);
				}
			}
		}

		// Token: 0x04003A2B RID: 14891
		[Tooltip("Where to send the event.")]
		public FsmEventTarget eventTarget;

		// Token: 0x04003A2C RID: 14892
		public FsmEvent wasPressed;

		// Token: 0x04003A2D RID: 14893
		public FsmEvent wasReleased;

		// Token: 0x04003A2E RID: 14894
		public FsmEvent isPressed;

		// Token: 0x04003A2F RID: 14895
		public FsmEvent isNotPressed;

		// Token: 0x04003A30 RID: 14896
		private GameManager gm;

		// Token: 0x04003A31 RID: 14897
		private InputHandler inputHandler;
	}
}
