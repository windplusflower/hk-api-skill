using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009F1 RID: 2545
	[ActionCategory("Controls")]
	[Tooltip("Listens for an action button press (using HeroActions InControl mappings).")]
	public class ListenForJump : FsmStateAction
	{
		// Token: 0x06003783 RID: 14211 RVA: 0x00146F15 File Offset: 0x00145115
		public override void Reset()
		{
			this.eventTarget = null;
		}

		// Token: 0x06003784 RID: 14212 RVA: 0x00146F1E File Offset: 0x0014511E
		public override void OnEnter()
		{
			this.gm = GameManager.instance;
			this.inputHandler = this.gm.GetComponent<InputHandler>();
		}

		// Token: 0x06003785 RID: 14213 RVA: 0x00146F3C File Offset: 0x0014513C
		public override void OnUpdate()
		{
			if (!this.gm.isPaused)
			{
				if (this.inputHandler.inputActions.jump.WasPressed)
				{
					base.Fsm.Event(this.wasPressed);
				}
				if (this.inputHandler.inputActions.jump.WasReleased)
				{
					base.Fsm.Event(this.wasReleased);
				}
				if (this.inputHandler.inputActions.jump.IsPressed)
				{
					base.Fsm.Event(this.isPressed);
				}
				if (!this.inputHandler.inputActions.jump.IsPressed)
				{
					base.Fsm.Event(this.isNotPressed);
				}
			}
		}

		// Token: 0x040039D8 RID: 14808
		[Tooltip("Where to send the event.")]
		public FsmEventTarget eventTarget;

		// Token: 0x040039D9 RID: 14809
		public FsmEvent wasPressed;

		// Token: 0x040039DA RID: 14810
		public FsmEvent wasReleased;

		// Token: 0x040039DB RID: 14811
		public FsmEvent isPressed;

		// Token: 0x040039DC RID: 14812
		public FsmEvent isNotPressed;

		// Token: 0x040039DD RID: 14813
		private GameManager gm;

		// Token: 0x040039DE RID: 14814
		private InputHandler inputHandler;
	}
}
