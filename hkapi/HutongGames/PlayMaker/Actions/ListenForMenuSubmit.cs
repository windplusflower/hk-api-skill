using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009F5 RID: 2549
	[ActionCategory("Controls")]
	[Tooltip("Listens for an action button press (using HeroActions InControl mappings).")]
	public class ListenForMenuSubmit : FsmStateAction
	{
		// Token: 0x06003793 RID: 14227 RVA: 0x00147301 File Offset: 0x00145501
		public override void Reset()
		{
			this.eventTarget = null;
		}

		// Token: 0x06003794 RID: 14228 RVA: 0x0014730A File Offset: 0x0014550A
		public override void OnEnter()
		{
			this.gm = GameManager.instance;
			this.inputHandler = this.gm.GetComponent<InputHandler>();
		}

		// Token: 0x06003795 RID: 14229 RVA: 0x00147328 File Offset: 0x00145528
		public override void OnUpdate()
		{
			if (!this.gm.isPaused)
			{
				if (this.inputHandler.inputActions.menuSubmit.WasPressed)
				{
					base.Fsm.Event(this.wasPressed);
				}
				if (this.inputHandler.inputActions.menuSubmit.WasReleased)
				{
					base.Fsm.Event(this.wasReleased);
				}
				if (this.inputHandler.inputActions.menuSubmit.IsPressed)
				{
					base.Fsm.Event(this.isPressed);
				}
				if (!this.inputHandler.inputActions.menuSubmit.IsPressed)
				{
					base.Fsm.Event(this.isNotPressed);
				}
			}
		}

		// Token: 0x040039F3 RID: 14835
		[Tooltip("Where to send the event.")]
		public FsmEventTarget eventTarget;

		// Token: 0x040039F4 RID: 14836
		public FsmEvent wasPressed;

		// Token: 0x040039F5 RID: 14837
		public FsmEvent wasReleased;

		// Token: 0x040039F6 RID: 14838
		public FsmEvent isPressed;

		// Token: 0x040039F7 RID: 14839
		public FsmEvent isNotPressed;

		// Token: 0x040039F8 RID: 14840
		private GameManager gm;

		// Token: 0x040039F9 RID: 14841
		private InputHandler inputHandler;
	}
}
