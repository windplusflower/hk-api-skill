using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009ED RID: 2541
	[ActionCategory("Controls")]
	[Tooltip("Listens for an action button press (using HeroActions InControl mappings).")]
	public class ListenForDash : FsmStateAction
	{
		// Token: 0x06003772 RID: 14194 RVA: 0x00146B12 File Offset: 0x00144D12
		public override void Reset()
		{
			this.eventTarget = null;
		}

		// Token: 0x06003773 RID: 14195 RVA: 0x00146B1B File Offset: 0x00144D1B
		public override void OnEnter()
		{
			this.gm = GameManager.instance;
			this.inputHandler = this.gm.GetComponent<InputHandler>();
		}

		// Token: 0x06003774 RID: 14196 RVA: 0x00146B3C File Offset: 0x00144D3C
		public override void OnUpdate()
		{
			if (this.inputHandler.inputActions.dash.WasPressed)
			{
				base.Fsm.Event(this.wasPressed);
			}
			if (this.inputHandler.inputActions.dash.WasReleased)
			{
				base.Fsm.Event(this.wasReleased);
			}
			if (this.inputHandler.inputActions.dash.IsPressed)
			{
				base.Fsm.Event(this.isPressed);
			}
			if (!this.inputHandler.inputActions.dash.IsPressed)
			{
				base.Fsm.Event(this.isNotPressed);
			}
		}

		// Token: 0x040039B9 RID: 14777
		[Tooltip("Where to send the event.")]
		public FsmEventTarget eventTarget;

		// Token: 0x040039BA RID: 14778
		public FsmEvent wasPressed;

		// Token: 0x040039BB RID: 14779
		public FsmEvent wasReleased;

		// Token: 0x040039BC RID: 14780
		public FsmEvent isPressed;

		// Token: 0x040039BD RID: 14781
		public FsmEvent isNotPressed;

		// Token: 0x040039BE RID: 14782
		private GameManager gm;

		// Token: 0x040039BF RID: 14783
		private InputHandler inputHandler;
	}
}
