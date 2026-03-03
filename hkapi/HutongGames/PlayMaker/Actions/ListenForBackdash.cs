using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009EB RID: 2539
	[ActionCategory("Controls")]
	[Tooltip("Listens for an action button press (using HeroActions InControl mappings).")]
	public class ListenForBackdash : FsmStateAction
	{
		// Token: 0x06003769 RID: 14185 RVA: 0x0014690D File Offset: 0x00144B0D
		public override void Reset()
		{
			this.eventTarget = null;
		}

		// Token: 0x0600376A RID: 14186 RVA: 0x00146916 File Offset: 0x00144B16
		public override void OnEnter()
		{
			this.gm = GameManager.instance;
			this.inputHandler = this.gm.GetComponent<InputHandler>();
		}

		// Token: 0x0600376B RID: 14187 RVA: 0x00146934 File Offset: 0x00144B34
		public override void OnUpdate()
		{
			if (this.inputHandler.inputActions.evade.WasPressed)
			{
				base.Fsm.Event(this.wasPressed);
			}
			if (this.inputHandler.inputActions.evade.WasReleased)
			{
				base.Fsm.Event(this.wasReleased);
			}
			if (this.inputHandler.inputActions.evade.IsPressed)
			{
				base.Fsm.Event(this.isPressed);
			}
			if (!this.inputHandler.inputActions.evade.IsPressed)
			{
				base.Fsm.Event(this.isNotPressed);
			}
		}

		// Token: 0x040039A9 RID: 14761
		[Tooltip("Where to send the event.")]
		public FsmEventTarget eventTarget;

		// Token: 0x040039AA RID: 14762
		public FsmEvent wasPressed;

		// Token: 0x040039AB RID: 14763
		public FsmEvent wasReleased;

		// Token: 0x040039AC RID: 14764
		public FsmEvent isPressed;

		// Token: 0x040039AD RID: 14765
		public FsmEvent isNotPressed;

		// Token: 0x040039AE RID: 14766
		private GameManager gm;

		// Token: 0x040039AF RID: 14767
		private InputHandler inputHandler;
	}
}
