using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009F6 RID: 2550
	[ActionCategory("Controls")]
	[Tooltip("Listens for an action button press (using HeroActions InControl mappings).")]
	public class ListenForPaneLeft : FsmStateAction
	{
		// Token: 0x06003797 RID: 14231 RVA: 0x001473E5 File Offset: 0x001455E5
		public override void Reset()
		{
			this.eventTarget = null;
		}

		// Token: 0x06003798 RID: 14232 RVA: 0x001473EE File Offset: 0x001455EE
		public override void OnEnter()
		{
			this.gm = GameManager.instance;
			this.inputHandler = this.gm.GetComponent<InputHandler>();
		}

		// Token: 0x06003799 RID: 14233 RVA: 0x0014740C File Offset: 0x0014560C
		public override void OnUpdate()
		{
			if (!this.gm.isPaused)
			{
				if (this.inputHandler.inputActions.paneLeft.WasPressed)
				{
					base.Fsm.Event(this.wasPressed);
				}
				if (this.inputHandler.inputActions.paneLeft.WasReleased)
				{
					base.Fsm.Event(this.wasReleased);
				}
				if (this.inputHandler.inputActions.paneLeft.IsPressed)
				{
					base.Fsm.Event(this.isPressed);
				}
				if (!this.inputHandler.inputActions.paneLeft.IsPressed)
				{
					base.Fsm.Event(this.isNotPressed);
				}
			}
		}

		// Token: 0x040039FA RID: 14842
		[Tooltip("Where to send the event.")]
		public FsmEventTarget eventTarget;

		// Token: 0x040039FB RID: 14843
		public FsmEvent wasPressed;

		// Token: 0x040039FC RID: 14844
		public FsmEvent wasReleased;

		// Token: 0x040039FD RID: 14845
		public FsmEvent isPressed;

		// Token: 0x040039FE RID: 14846
		public FsmEvent isNotPressed;

		// Token: 0x040039FF RID: 14847
		private GameManager gm;

		// Token: 0x04003A00 RID: 14848
		private InputHandler inputHandler;
	}
}
