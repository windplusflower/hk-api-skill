using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009EC RID: 2540
	[ActionCategory("Controls")]
	[Tooltip("Listens for an action button press (using HeroActions InControl mappings).")]
	public class ListenForCast : FsmStateAction
	{
		// Token: 0x0600376D RID: 14189 RVA: 0x001469E1 File Offset: 0x00144BE1
		public override void Reset()
		{
			this.eventTarget = null;
			this.activeBool = new FsmBool
			{
				UseVariable = true
			};
		}

		// Token: 0x0600376E RID: 14190 RVA: 0x001469FC File Offset: 0x00144BFC
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

		// Token: 0x0600376F RID: 14191 RVA: 0x00146A2E File Offset: 0x00144C2E
		public override void OnUpdate()
		{
			this.CheckForInput();
		}

		// Token: 0x06003770 RID: 14192 RVA: 0x00146A38 File Offset: 0x00144C38
		public void CheckForInput()
		{
			if (!this.gm.isPaused && (this.activeBool.IsNone || this.activeBool.Value))
			{
				if (this.inputHandler.inputActions.cast.WasPressed)
				{
					base.Fsm.Event(this.wasPressed);
				}
				if (this.inputHandler.inputActions.cast.WasReleased)
				{
					base.Fsm.Event(this.wasReleased);
				}
				if (this.inputHandler.inputActions.cast.IsPressed)
				{
					base.Fsm.Event(this.isPressed);
				}
				if (!this.inputHandler.inputActions.cast.IsPressed)
				{
					base.Fsm.Event(this.isNotPressed);
				}
			}
		}

		// Token: 0x040039B0 RID: 14768
		[Tooltip("Where to send the event.")]
		public FsmEventTarget eventTarget;

		// Token: 0x040039B1 RID: 14769
		public FsmEvent wasPressed;

		// Token: 0x040039B2 RID: 14770
		public FsmEvent wasReleased;

		// Token: 0x040039B3 RID: 14771
		public FsmEvent isPressed;

		// Token: 0x040039B4 RID: 14772
		public FsmEvent isNotPressed;

		// Token: 0x040039B5 RID: 14773
		public FsmBool activeBool;

		// Token: 0x040039B6 RID: 14774
		public bool stateEntryOnly;

		// Token: 0x040039B7 RID: 14775
		private GameManager gm;

		// Token: 0x040039B8 RID: 14776
		private InputHandler inputHandler;
	}
}
