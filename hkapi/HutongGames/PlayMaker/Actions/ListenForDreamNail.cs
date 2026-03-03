using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009EF RID: 2543
	[ActionCategory("Controls")]
	[Tooltip("Listens for an action button press (using HeroActions InControl mappings).")]
	public class ListenForDreamNail : FsmStateAction
	{
		// Token: 0x0600377B RID: 14203 RVA: 0x00146D1B File Offset: 0x00144F1B
		public override void Reset()
		{
			this.eventTarget = null;
			this.activeBool = new FsmBool
			{
				UseVariable = true
			};
		}

		// Token: 0x0600377C RID: 14204 RVA: 0x00146D36 File Offset: 0x00144F36
		public override void OnEnter()
		{
			this.gm = GameManager.instance;
			this.inputHandler = this.gm.GetComponent<InputHandler>();
		}

		// Token: 0x0600377D RID: 14205 RVA: 0x00146D54 File Offset: 0x00144F54
		public override void OnUpdate()
		{
			if (!this.gm.isPaused && (this.activeBool.Value || this.activeBool.IsNone))
			{
				if (this.inputHandler.inputActions.dreamNail.WasPressed)
				{
					base.Fsm.Event(this.wasPressed);
				}
				if (this.inputHandler.inputActions.dreamNail.WasReleased)
				{
					base.Fsm.Event(this.wasReleased);
				}
				if (this.inputHandler.inputActions.dreamNail.IsPressed)
				{
					base.Fsm.Event(this.isPressed);
				}
				if (!this.inputHandler.inputActions.dreamNail.IsPressed)
				{
					base.Fsm.Event(this.isNotPressed);
				}
			}
		}

		// Token: 0x040039C9 RID: 14793
		[Tooltip("Where to send the event.")]
		public FsmEventTarget eventTarget;

		// Token: 0x040039CA RID: 14794
		public FsmEvent wasPressed;

		// Token: 0x040039CB RID: 14795
		public FsmEvent wasReleased;

		// Token: 0x040039CC RID: 14796
		public FsmEvent isPressed;

		// Token: 0x040039CD RID: 14797
		public FsmEvent isNotPressed;

		// Token: 0x040039CE RID: 14798
		public FsmBool activeBool;

		// Token: 0x040039CF RID: 14799
		private GameManager gm;

		// Token: 0x040039D0 RID: 14800
		private InputHandler inputHandler;
	}
}
