using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C07 RID: 3079
	[ActionCategory(ActionCategory.StateMachine)]
	[Tooltip("Gets the name of the previously active state and stores it in a String Variable.")]
	public class GetPreviousStateName : FsmStateAction
	{
		// Token: 0x060040A8 RID: 16552 RVA: 0x0016AA91 File Offset: 0x00168C91
		public override void Reset()
		{
			this.storeName = null;
		}

		// Token: 0x060040A9 RID: 16553 RVA: 0x0016AA9A File Offset: 0x00168C9A
		public override void OnEnter()
		{
			this.storeName.Value = ((base.Fsm.PreviousActiveState == null) ? null : base.Fsm.PreviousActiveState.Name);
			base.Finish();
		}

		// Token: 0x040044F9 RID: 17657
		[UIHint(UIHint.Variable)]
		public FsmString storeName;
	}
}
