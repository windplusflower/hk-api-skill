using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CF7 RID: 3319
	[ActionCategory(ActionCategory.Logic)]
	[Tooltip("Compares 2 Strings and sends Events based on the result.")]
	public class StringCompare : FsmStateAction
	{
		// Token: 0x060044F1 RID: 17649 RVA: 0x00177A60 File Offset: 0x00175C60
		public override void Reset()
		{
			this.stringVariable = null;
			this.compareTo = "";
			this.equalEvent = null;
			this.notEqualEvent = null;
			this.storeResult = null;
			this.everyFrame = false;
		}

		// Token: 0x060044F2 RID: 17650 RVA: 0x00177A95 File Offset: 0x00175C95
		public override void OnEnter()
		{
			this.DoStringCompare();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060044F3 RID: 17651 RVA: 0x00177AAB File Offset: 0x00175CAB
		public override void OnUpdate()
		{
			this.DoStringCompare();
		}

		// Token: 0x060044F4 RID: 17652 RVA: 0x00177AB4 File Offset: 0x00175CB4
		private void DoStringCompare()
		{
			if (this.stringVariable == null || this.compareTo == null)
			{
				return;
			}
			bool flag = this.stringVariable.Value == this.compareTo.Value;
			if (this.storeResult != null)
			{
				this.storeResult.Value = flag;
			}
			if (flag && this.equalEvent != null)
			{
				base.Fsm.Event(this.equalEvent);
				return;
			}
			if (!flag && this.notEqualEvent != null)
			{
				base.Fsm.Event(this.notEqualEvent);
			}
		}

		// Token: 0x04004941 RID: 18753
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmString stringVariable;

		// Token: 0x04004942 RID: 18754
		public FsmString compareTo;

		// Token: 0x04004943 RID: 18755
		public FsmEvent equalEvent;

		// Token: 0x04004944 RID: 18756
		public FsmEvent notEqualEvent;

		// Token: 0x04004945 RID: 18757
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the true/false result in a bool variable.")]
		public FsmBool storeResult;

		// Token: 0x04004946 RID: 18758
		[Tooltip("Repeat every frame. Useful if any of the strings are changing over time.")]
		public bool everyFrame;
	}
}
