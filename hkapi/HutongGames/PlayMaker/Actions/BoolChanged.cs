using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B37 RID: 2871
	[ActionCategory(ActionCategory.Logic)]
	[Tooltip("Tests if the value of a Bool Variable has changed. Use this to send an event on change, or store a bool that can be used in other operations.")]
	public class BoolChanged : FsmStateAction
	{
		// Token: 0x06003D5E RID: 15710 RVA: 0x00160C6B File Offset: 0x0015EE6B
		public override void Reset()
		{
			this.boolVariable = null;
			this.changedEvent = null;
			this.storeResult = null;
		}

		// Token: 0x06003D5F RID: 15711 RVA: 0x00160C82 File Offset: 0x0015EE82
		public override void OnEnter()
		{
			if (this.boolVariable.IsNone)
			{
				base.Finish();
				return;
			}
			this.previousValue = this.boolVariable.Value;
		}

		// Token: 0x06003D60 RID: 15712 RVA: 0x00160CA9 File Offset: 0x0015EEA9
		public override void OnUpdate()
		{
			this.storeResult.Value = false;
			if (this.boolVariable.Value != this.previousValue)
			{
				this.storeResult.Value = true;
				base.Fsm.Event(this.changedEvent);
			}
		}

		// Token: 0x0400416F RID: 16751
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The Bool variable to watch for changes.")]
		public FsmBool boolVariable;

		// Token: 0x04004170 RID: 16752
		[Tooltip("Event to send if the variable changes.")]
		public FsmEvent changedEvent;

		// Token: 0x04004171 RID: 16753
		[UIHint(UIHint.Variable)]
		[Tooltip("Set to True if changed.")]
		public FsmBool storeResult;

		// Token: 0x04004172 RID: 16754
		private bool previousValue;
	}
}
