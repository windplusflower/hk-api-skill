using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B7D RID: 2941
	[ActionCategory(ActionCategory.Logic)]
	[Tooltip("Compares 2 Enum values and sends Events based on the result.")]
	public class EnumCompare : FsmStateAction
	{
		// Token: 0x06003E7F RID: 15999 RVA: 0x00164664 File Offset: 0x00162864
		public override void Reset()
		{
			this.enumVariable = null;
			this.compareTo = null;
			this.equalEvent = null;
			this.notEqualEvent = null;
			this.storeResult = null;
			this.everyFrame = false;
		}

		// Token: 0x06003E80 RID: 16000 RVA: 0x00164690 File Offset: 0x00162890
		public override void OnEnter()
		{
			this.DoEnumCompare();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003E81 RID: 16001 RVA: 0x001646A6 File Offset: 0x001628A6
		public override void OnUpdate()
		{
			this.DoEnumCompare();
		}

		// Token: 0x06003E82 RID: 16002 RVA: 0x001646B0 File Offset: 0x001628B0
		private void DoEnumCompare()
		{
			if (this.enumVariable == null || this.compareTo == null)
			{
				return;
			}
			bool flag = object.Equals(this.enumVariable.Value, this.compareTo.Value);
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

		// Token: 0x0400428D RID: 17037
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmEnum enumVariable;

		// Token: 0x0400428E RID: 17038
		[MatchFieldType("enumVariable")]
		public FsmEnum compareTo;

		// Token: 0x0400428F RID: 17039
		public FsmEvent equalEvent;

		// Token: 0x04004290 RID: 17040
		public FsmEvent notEqualEvent;

		// Token: 0x04004291 RID: 17041
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the true/false result in a bool variable.")]
		public FsmBool storeResult;

		// Token: 0x04004292 RID: 17042
		[Tooltip("Repeat every frame. Useful if the enum is changing over time.")]
		public bool everyFrame;
	}
}
