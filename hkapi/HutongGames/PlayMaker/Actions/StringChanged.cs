using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CF6 RID: 3318
	[ActionCategory(ActionCategory.Logic)]
	[Tooltip("Tests if the value of a string variable has changed. Use this to send an event on change, or store a bool that can be used in other operations.")]
	public class StringChanged : FsmStateAction
	{
		// Token: 0x060044ED RID: 17645 RVA: 0x001779EB File Offset: 0x00175BEB
		public override void Reset()
		{
			this.stringVariable = null;
			this.changedEvent = null;
			this.storeResult = null;
		}

		// Token: 0x060044EE RID: 17646 RVA: 0x00177A02 File Offset: 0x00175C02
		public override void OnEnter()
		{
			if (this.stringVariable.IsNone)
			{
				base.Finish();
				return;
			}
			this.previousValue = this.stringVariable.Value;
		}

		// Token: 0x060044EF RID: 17647 RVA: 0x00177A29 File Offset: 0x00175C29
		public override void OnUpdate()
		{
			if (this.stringVariable.Value != this.previousValue)
			{
				this.storeResult.Value = true;
				base.Fsm.Event(this.changedEvent);
			}
		}

		// Token: 0x0400493D RID: 18749
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmString stringVariable;

		// Token: 0x0400493E RID: 18750
		public FsmEvent changedEvent;

		// Token: 0x0400493F RID: 18751
		[UIHint(UIHint.Variable)]
		public FsmBool storeResult;

		// Token: 0x04004940 RID: 18752
		private string previousValue;
	}
}
