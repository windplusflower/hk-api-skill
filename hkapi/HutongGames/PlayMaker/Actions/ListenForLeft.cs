using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009F2 RID: 2546
	[ActionCategory("Controls")]
	[Tooltip("Listens for an action button press (using HeroActions InControl mappings).")]
	public class ListenForLeft : FsmStateAction
	{
		// Token: 0x06003787 RID: 14215 RVA: 0x00146FF9 File Offset: 0x001451F9
		public override void Reset()
		{
			this.eventTarget = null;
		}

		// Token: 0x06003788 RID: 14216 RVA: 0x00147002 File Offset: 0x00145202
		public override void OnEnter()
		{
			this.gm = GameManager.instance;
			this.inputHandler = this.gm.GetComponent<InputHandler>();
		}

		// Token: 0x06003789 RID: 14217 RVA: 0x00147020 File Offset: 0x00145220
		public override void OnUpdate()
		{
			if (!this.gm.isPaused)
			{
				if (this.inputHandler.inputActions.left.WasPressed)
				{
					base.Fsm.Event(this.wasPressed);
				}
				if (this.inputHandler.inputActions.left.WasReleased)
				{
					base.Fsm.Event(this.wasReleased);
				}
				if (this.inputHandler.inputActions.left.IsPressed)
				{
					base.Fsm.Event(this.isPressed);
				}
				if (!this.inputHandler.inputActions.left.IsPressed)
				{
					base.Fsm.Event(this.isNotPressed);
				}
			}
		}

		// Token: 0x040039DF RID: 14815
		[Tooltip("Where to send the event.")]
		public FsmEventTarget eventTarget;

		// Token: 0x040039E0 RID: 14816
		public FsmEvent wasPressed;

		// Token: 0x040039E1 RID: 14817
		public FsmEvent wasReleased;

		// Token: 0x040039E2 RID: 14818
		public FsmEvent isPressed;

		// Token: 0x040039E3 RID: 14819
		public FsmEvent isNotPressed;

		// Token: 0x040039E4 RID: 14820
		private GameManager gm;

		// Token: 0x040039E5 RID: 14821
		private InputHandler inputHandler;
	}
}
