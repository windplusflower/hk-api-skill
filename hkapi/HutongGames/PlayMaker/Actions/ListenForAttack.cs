using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009EA RID: 2538
	[ActionCategory("Controls")]
	[Tooltip("Listens for an action button press (using HeroActions InControl mappings).")]
	public class ListenForAttack : FsmStateAction
	{
		// Token: 0x06003765 RID: 14181 RVA: 0x00146827 File Offset: 0x00144A27
		public override void Reset()
		{
			this.eventTarget = null;
		}

		// Token: 0x06003766 RID: 14182 RVA: 0x00146830 File Offset: 0x00144A30
		public override void OnEnter()
		{
			this.gm = GameManager.instance;
			this.inputHandler = this.gm.GetComponent<InputHandler>();
		}

		// Token: 0x06003767 RID: 14183 RVA: 0x00146850 File Offset: 0x00144A50
		public override void OnUpdate()
		{
			if (!this.gm.isPaused)
			{
				if (this.inputHandler.inputActions.attack.WasPressed)
				{
					base.Fsm.Event(this.wasPressed);
				}
				if (this.inputHandler.inputActions.attack.WasReleased)
				{
					base.Fsm.Event(this.wasReleased);
				}
				if (this.inputHandler.inputActions.attack.IsPressed)
				{
					base.Fsm.Event(this.isPressed);
				}
				if (!this.inputHandler.inputActions.attack.IsPressed)
				{
					base.Fsm.Event(this.isNotPressed);
				}
			}
		}

		// Token: 0x040039A2 RID: 14754
		[Tooltip("Where to send the event.")]
		public FsmEventTarget eventTarget;

		// Token: 0x040039A3 RID: 14755
		public FsmEvent wasPressed;

		// Token: 0x040039A4 RID: 14756
		public FsmEvent wasReleased;

		// Token: 0x040039A5 RID: 14757
		public FsmEvent isPressed;

		// Token: 0x040039A6 RID: 14758
		public FsmEvent isNotPressed;

		// Token: 0x040039A7 RID: 14759
		private GameManager gm;

		// Token: 0x040039A8 RID: 14760
		private InputHandler inputHandler;
	}
}
