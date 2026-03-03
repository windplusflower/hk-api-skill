using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009FC RID: 2556
	[ActionCategory("Controls")]
	[Tooltip("Listens for an action button press (using HeroActions InControl mappings).")]
	public class ListenForRsUp : FsmStateAction
	{
		// Token: 0x060037AF RID: 14255 RVA: 0x0014793D File Offset: 0x00145B3D
		public override void Reset()
		{
			this.eventTarget = null;
		}

		// Token: 0x060037B0 RID: 14256 RVA: 0x00147946 File Offset: 0x00145B46
		public override void OnEnter()
		{
			this.gm = GameManager.instance;
			this.inputHandler = this.gm.GetComponent<InputHandler>();
		}

		// Token: 0x060037B1 RID: 14257 RVA: 0x00147964 File Offset: 0x00145B64
		public override void OnUpdate()
		{
			if (!this.gm.isPaused)
			{
				if (this.inputHandler.inputActions.rs_up.WasPressed)
				{
					base.Fsm.Event(this.wasPressed);
				}
				if (this.inputHandler.inputActions.rs_up.WasReleased)
				{
					base.Fsm.Event(this.wasReleased);
				}
				if (this.inputHandler.inputActions.rs_up.IsPressed)
				{
					base.Fsm.Event(this.isPressed);
				}
				if (!this.inputHandler.inputActions.rs_up.IsPressed)
				{
					base.Fsm.Event(this.isNotPressed);
				}
			}
		}

		// Token: 0x04003A24 RID: 14884
		[Tooltip("Where to send the event.")]
		public FsmEventTarget eventTarget;

		// Token: 0x04003A25 RID: 14885
		public FsmEvent wasPressed;

		// Token: 0x04003A26 RID: 14886
		public FsmEvent wasReleased;

		// Token: 0x04003A27 RID: 14887
		public FsmEvent isPressed;

		// Token: 0x04003A28 RID: 14888
		public FsmEvent isNotPressed;

		// Token: 0x04003A29 RID: 14889
		private GameManager gm;

		// Token: 0x04003A2A RID: 14890
		private InputHandler inputHandler;
	}
}
