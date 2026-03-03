using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009FB RID: 2555
	[ActionCategory("Controls")]
	[Tooltip("Listens for an action button press (using HeroActions InControl mappings).")]
	public class ListenForRsDown : FsmStateAction
	{
		// Token: 0x060037AB RID: 14251 RVA: 0x00147859 File Offset: 0x00145A59
		public override void Reset()
		{
			this.eventTarget = null;
		}

		// Token: 0x060037AC RID: 14252 RVA: 0x00147862 File Offset: 0x00145A62
		public override void OnEnter()
		{
			this.gm = GameManager.instance;
			this.inputHandler = this.gm.GetComponent<InputHandler>();
		}

		// Token: 0x060037AD RID: 14253 RVA: 0x00147880 File Offset: 0x00145A80
		public override void OnUpdate()
		{
			if (!this.gm.isPaused)
			{
				if (this.inputHandler.inputActions.rs_down.WasPressed)
				{
					base.Fsm.Event(this.wasPressed);
				}
				if (this.inputHandler.inputActions.rs_down.WasReleased)
				{
					base.Fsm.Event(this.wasReleased);
				}
				if (this.inputHandler.inputActions.rs_down.IsPressed)
				{
					base.Fsm.Event(this.isPressed);
				}
				if (!this.inputHandler.inputActions.rs_down.IsPressed)
				{
					base.Fsm.Event(this.isNotPressed);
				}
			}
		}

		// Token: 0x04003A1D RID: 14877
		[Tooltip("Where to send the event.")]
		public FsmEventTarget eventTarget;

		// Token: 0x04003A1E RID: 14878
		public FsmEvent wasPressed;

		// Token: 0x04003A1F RID: 14879
		public FsmEvent wasReleased;

		// Token: 0x04003A20 RID: 14880
		public FsmEvent isPressed;

		// Token: 0x04003A21 RID: 14881
		public FsmEvent isNotPressed;

		// Token: 0x04003A22 RID: 14882
		private GameManager gm;

		// Token: 0x04003A23 RID: 14883
		private InputHandler inputHandler;
	}
}
