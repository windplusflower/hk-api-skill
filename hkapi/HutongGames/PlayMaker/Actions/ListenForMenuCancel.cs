using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009F4 RID: 2548
	[ActionCategory("Controls")]
	[Tooltip("Listens for an action button press (using HeroActions InControl mappings).")]
	public class ListenForMenuCancel : FsmStateAction
	{
		// Token: 0x0600378F RID: 14223 RVA: 0x0014721A File Offset: 0x0014541A
		public override void Reset()
		{
			this.eventTarget = null;
		}

		// Token: 0x06003790 RID: 14224 RVA: 0x00147223 File Offset: 0x00145423
		public override void OnEnter()
		{
			this.gm = GameManager.instance;
			this.inputHandler = this.gm.GetComponent<InputHandler>();
		}

		// Token: 0x06003791 RID: 14225 RVA: 0x00147244 File Offset: 0x00145444
		public override void OnUpdate()
		{
			if (!this.gm.isPaused)
			{
				if (this.inputHandler.inputActions.menuCancel.WasPressed)
				{
					base.Fsm.Event(this.wasPressed);
				}
				if (this.inputHandler.inputActions.menuCancel.WasReleased)
				{
					base.Fsm.Event(this.wasReleased);
				}
				if (this.inputHandler.inputActions.menuCancel.IsPressed)
				{
					base.Fsm.Event(this.isPressed);
				}
				if (!this.inputHandler.inputActions.menuCancel.IsPressed)
				{
					base.Fsm.Event(this.isNotPressed);
				}
			}
		}

		// Token: 0x040039EC RID: 14828
		[Tooltip("Where to send the event.")]
		public FsmEventTarget eventTarget;

		// Token: 0x040039ED RID: 14829
		public FsmEvent wasPressed;

		// Token: 0x040039EE RID: 14830
		public FsmEvent wasReleased;

		// Token: 0x040039EF RID: 14831
		public FsmEvent isPressed;

		// Token: 0x040039F0 RID: 14832
		public FsmEvent isNotPressed;

		// Token: 0x040039F1 RID: 14833
		private GameManager gm;

		// Token: 0x040039F2 RID: 14834
		private InputHandler inputHandler;
	}
}
