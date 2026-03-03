using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C29 RID: 3113
	[ActionCategory(ActionCategory.StateMachine)]
	[Tooltip("Immediately return to the previously active state.")]
	public class GotoPreviousState : FsmStateAction
	{
		// Token: 0x0600413F RID: 16703 RVA: 0x00003603 File Offset: 0x00001803
		public override void Reset()
		{
		}

		// Token: 0x06004140 RID: 16704 RVA: 0x0016C0C0 File Offset: 0x0016A2C0
		public override void OnEnter()
		{
			if (base.Fsm.PreviousActiveState != null)
			{
				base.Log("Goto Previous State: " + base.Fsm.PreviousActiveState.Name);
				base.Fsm.GotoPreviousState();
			}
			base.Finish();
		}
	}
}
