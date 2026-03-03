using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009F3 RID: 2547
	[ActionCategory("Controls")]
	[Tooltip("Listens for menu actions, and safely disambiguates jump/submit/attack/cancel/cast.")]
	public class ListenForMenuActions : FsmStateAction
	{
		// Token: 0x0600378B RID: 14219 RVA: 0x001470DD File Offset: 0x001452DD
		public override void Reset()
		{
			this.eventTarget = null;
		}

		// Token: 0x0600378C RID: 14220 RVA: 0x001470E8 File Offset: 0x001452E8
		public override void OnEnter()
		{
			this.gm = GameManager.instance;
			if (this.gm == null)
			{
				base.LogError("Cannot listen for buttons without game manager.");
				return;
			}
			this.inputHandler = this.gm.inputHandler;
			if (this.inputHandler == null)
			{
				base.LogError("Cannot listen for buttons without input handler.");
			}
		}

		// Token: 0x0600378D RID: 14221 RVA: 0x00147144 File Offset: 0x00145344
		public override void OnUpdate()
		{
			if (this.gm != null && !this.gm.isPaused && this.inputHandler != null)
			{
				HeroActions inputActions = this.inputHandler.inputActions;
				bool attackInput = !this.ignoreAttack.Value && inputActions.attack.WasPressed;
				Platform.MenuActions menuAction = Platform.Current.GetMenuAction(inputActions.menuSubmit.WasPressed, inputActions.menuCancel.WasPressed, inputActions.jump.WasPressed, attackInput, inputActions.cast.WasPressed);
				if (menuAction == Platform.MenuActions.Submit)
				{
					base.Fsm.Event(this.eventTarget, this.submitPressed);
					return;
				}
				if (menuAction == Platform.MenuActions.Cancel)
				{
					base.Fsm.Event(this.eventTarget, this.cancelPressed);
				}
			}
		}

		// Token: 0x040039E6 RID: 14822
		public FsmEventTarget eventTarget;

		// Token: 0x040039E7 RID: 14823
		public FsmEvent submitPressed;

		// Token: 0x040039E8 RID: 14824
		public FsmEvent cancelPressed;

		// Token: 0x040039E9 RID: 14825
		public FsmBool ignoreAttack;

		// Token: 0x040039EA RID: 14826
		private GameManager gm;

		// Token: 0x040039EB RID: 14827
		private InputHandler inputHandler;
	}
}
