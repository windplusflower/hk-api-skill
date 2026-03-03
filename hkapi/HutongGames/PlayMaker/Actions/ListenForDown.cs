using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009EE RID: 2542
	[ActionCategory("Controls")]
	[Tooltip("Listens for an action button press (using HeroActions InControl mappings).")]
	public class ListenForDown : FsmStateAction
	{
		// Token: 0x06003776 RID: 14198 RVA: 0x00146BE9 File Offset: 0x00144DE9
		public override void Reset()
		{
			this.eventTarget = null;
		}

		// Token: 0x06003777 RID: 14199 RVA: 0x00146BF2 File Offset: 0x00144DF2
		public override void OnEnter()
		{
			this.gm = GameManager.instance;
			this.inputHandler = this.gm.GetComponent<InputHandler>();
			this.CheckForInput();
			if (this.stateEntryOnly)
			{
				base.Finish();
			}
		}

		// Token: 0x06003778 RID: 14200 RVA: 0x00146C24 File Offset: 0x00144E24
		public override void OnUpdate()
		{
			this.CheckForInput();
		}

		// Token: 0x06003779 RID: 14201 RVA: 0x00146C2C File Offset: 0x00144E2C
		private void CheckForInput()
		{
			if (!this.gm.isPaused)
			{
				if (this.inputHandler.inputActions.down.WasPressed)
				{
					base.Fsm.Event(this.wasPressed);
				}
				if (this.inputHandler.inputActions.down.WasReleased)
				{
					base.Fsm.Event(this.wasReleased);
				}
				if (this.inputHandler.inputActions.down.IsPressed)
				{
					base.Fsm.Event(this.isPressed);
					if (!this.isPressedBool.IsNone)
					{
						this.isPressedBool.Value = true;
					}
				}
				if (!this.inputHandler.inputActions.down.IsPressed)
				{
					base.Fsm.Event(this.isNotPressed);
					if (!this.isPressedBool.IsNone)
					{
						this.isPressedBool.Value = false;
					}
				}
			}
		}

		// Token: 0x040039C0 RID: 14784
		[Tooltip("Where to send the event.")]
		public FsmEventTarget eventTarget;

		// Token: 0x040039C1 RID: 14785
		public FsmEvent wasPressed;

		// Token: 0x040039C2 RID: 14786
		public FsmEvent wasReleased;

		// Token: 0x040039C3 RID: 14787
		public FsmEvent isPressed;

		// Token: 0x040039C4 RID: 14788
		public FsmEvent isNotPressed;

		// Token: 0x040039C5 RID: 14789
		[UIHint(UIHint.Variable)]
		public FsmBool isPressedBool;

		// Token: 0x040039C6 RID: 14790
		public bool stateEntryOnly;

		// Token: 0x040039C7 RID: 14791
		private GameManager gm;

		// Token: 0x040039C8 RID: 14792
		private InputHandler inputHandler;
	}
}
