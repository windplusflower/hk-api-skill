using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009FE RID: 2558
	[ActionCategory("Controls")]
	[Tooltip("Listens for an action button press (using HeroActions InControl mappings).")]
	public class ListenForUp : FsmStateAction
	{
		// Token: 0x060037B7 RID: 14263 RVA: 0x00147B05 File Offset: 0x00145D05
		public override void Reset()
		{
			this.eventTarget = null;
		}

		// Token: 0x060037B8 RID: 14264 RVA: 0x00147B0E File Offset: 0x00145D0E
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

		// Token: 0x060037B9 RID: 14265 RVA: 0x00147B40 File Offset: 0x00145D40
		public override void OnUpdate()
		{
			this.CheckForInput();
		}

		// Token: 0x060037BA RID: 14266 RVA: 0x00147B48 File Offset: 0x00145D48
		private void CheckForInput()
		{
			if (!this.gm.isPaused)
			{
				if (this.inputHandler.inputActions.up.WasPressed)
				{
					base.Fsm.Event(this.wasPressed);
				}
				if (this.inputHandler.inputActions.up.WasReleased)
				{
					base.Fsm.Event(this.wasReleased);
				}
				if (this.inputHandler.inputActions.up.IsPressed)
				{
					base.Fsm.Event(this.isPressed);
					if (!this.isPressedBool.IsNone)
					{
						this.isPressedBool.Value = true;
					}
				}
				if (!this.inputHandler.inputActions.up.IsPressed)
				{
					base.Fsm.Event(this.isNotPressed);
					if (!this.isPressedBool.IsNone)
					{
						this.isPressedBool.Value = false;
					}
				}
			}
		}

		// Token: 0x04003A32 RID: 14898
		[Tooltip("Where to send the event.")]
		public FsmEventTarget eventTarget;

		// Token: 0x04003A33 RID: 14899
		public FsmEvent wasPressed;

		// Token: 0x04003A34 RID: 14900
		public FsmEvent wasReleased;

		// Token: 0x04003A35 RID: 14901
		public FsmEvent isPressed;

		// Token: 0x04003A36 RID: 14902
		public FsmEvent isNotPressed;

		// Token: 0x04003A37 RID: 14903
		[UIHint(UIHint.Variable)]
		public FsmBool isPressedBool;

		// Token: 0x04003A38 RID: 14904
		public bool stateEntryOnly;

		// Token: 0x04003A39 RID: 14905
		private GameManager gm;

		// Token: 0x04003A3A RID: 14906
		private InputHandler inputHandler;
	}
}
