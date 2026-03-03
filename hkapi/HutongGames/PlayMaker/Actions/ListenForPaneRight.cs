using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009F7 RID: 2551
	[ActionCategory("Controls")]
	[Tooltip("Listens for an action button press (using HeroActions InControl mappings).")]
	public class ListenForPaneRight : FsmStateAction
	{
		// Token: 0x0600379B RID: 14235 RVA: 0x001474C9 File Offset: 0x001456C9
		public override void Reset()
		{
			this.eventTarget = null;
		}

		// Token: 0x0600379C RID: 14236 RVA: 0x001474D2 File Offset: 0x001456D2
		public override void OnEnter()
		{
			this.gm = GameManager.instance;
			this.inputHandler = this.gm.GetComponent<InputHandler>();
		}

		// Token: 0x0600379D RID: 14237 RVA: 0x001474F0 File Offset: 0x001456F0
		public override void OnUpdate()
		{
			if (!this.gm.isPaused)
			{
				if (this.inputHandler.inputActions.paneRight.WasPressed)
				{
					base.Fsm.Event(this.wasPressed);
				}
				if (this.inputHandler.inputActions.paneRight.WasReleased)
				{
					base.Fsm.Event(this.wasReleased);
				}
				if (this.inputHandler.inputActions.paneRight.IsPressed)
				{
					base.Fsm.Event(this.isPressed);
				}
				if (!this.inputHandler.inputActions.paneRight.IsPressed)
				{
					base.Fsm.Event(this.isNotPressed);
				}
			}
		}

		// Token: 0x04003A01 RID: 14849
		[Tooltip("Where to send the event.")]
		public FsmEventTarget eventTarget;

		// Token: 0x04003A02 RID: 14850
		public FsmEvent wasPressed;

		// Token: 0x04003A03 RID: 14851
		public FsmEvent wasReleased;

		// Token: 0x04003A04 RID: 14852
		public FsmEvent isPressed;

		// Token: 0x04003A05 RID: 14853
		public FsmEvent isNotPressed;

		// Token: 0x04003A06 RID: 14854
		private GameManager gm;

		// Token: 0x04003A07 RID: 14855
		private InputHandler inputHandler;
	}
}
