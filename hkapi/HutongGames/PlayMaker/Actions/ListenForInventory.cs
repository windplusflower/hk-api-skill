using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009F0 RID: 2544
	[ActionCategory("Controls")]
	[Tooltip("Listens for an action button press (using HeroActions InControl mappings).")]
	public class ListenForInventory : FsmStateAction
	{
		// Token: 0x0600377F RID: 14207 RVA: 0x00146E2E File Offset: 0x0014502E
		public override void Reset()
		{
			this.eventTarget = null;
		}

		// Token: 0x06003780 RID: 14208 RVA: 0x00146E37 File Offset: 0x00145037
		public override void OnEnter()
		{
			this.gm = GameManager.instance;
			this.inputHandler = this.gm.GetComponent<InputHandler>();
		}

		// Token: 0x06003781 RID: 14209 RVA: 0x00146E58 File Offset: 0x00145058
		public override void OnUpdate()
		{
			if (!this.gm.isPaused)
			{
				if (this.inputHandler.inputActions.openInventory.WasPressed)
				{
					base.Fsm.Event(this.wasPressed);
				}
				if (this.inputHandler.inputActions.openInventory.WasReleased)
				{
					base.Fsm.Event(this.wasReleased);
				}
				if (this.inputHandler.inputActions.openInventory.IsPressed)
				{
					base.Fsm.Event(this.isPressed);
				}
				if (!this.inputHandler.inputActions.openInventory.IsPressed)
				{
					base.Fsm.Event(this.isNotPressed);
				}
			}
		}

		// Token: 0x040039D1 RID: 14801
		[Tooltip("Where to send the event.")]
		public FsmEventTarget eventTarget;

		// Token: 0x040039D2 RID: 14802
		public FsmEvent wasPressed;

		// Token: 0x040039D3 RID: 14803
		public FsmEvent wasReleased;

		// Token: 0x040039D4 RID: 14804
		public FsmEvent isPressed;

		// Token: 0x040039D5 RID: 14805
		public FsmEvent isNotPressed;

		// Token: 0x040039D6 RID: 14806
		private GameManager gm;

		// Token: 0x040039D7 RID: 14807
		private InputHandler inputHandler;
	}
}
