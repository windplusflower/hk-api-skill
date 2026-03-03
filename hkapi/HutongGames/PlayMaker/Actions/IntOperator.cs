using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C2F RID: 3119
	[ActionCategory(ActionCategory.Math)]
	[Tooltip("Performs math operation on 2 Integers: Add, Subtract, Multiply, Divide, Min, Max.")]
	public class IntOperator : FsmStateAction
	{
		// Token: 0x0600415B RID: 16731 RVA: 0x0016C4E6 File Offset: 0x0016A6E6
		public override void Reset()
		{
			this.integer1 = null;
			this.integer2 = null;
			this.operation = IntOperator.Operation.Add;
			this.storeResult = null;
			this.everyFrame = false;
		}

		// Token: 0x0600415C RID: 16732 RVA: 0x0016C50B File Offset: 0x0016A70B
		public override void OnEnter()
		{
			this.DoIntOperator();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x0600415D RID: 16733 RVA: 0x0016C521 File Offset: 0x0016A721
		public override void OnUpdate()
		{
			this.DoIntOperator();
		}

		// Token: 0x0600415E RID: 16734 RVA: 0x0016C52C File Offset: 0x0016A72C
		private void DoIntOperator()
		{
			int value = this.integer1.Value;
			int value2 = this.integer2.Value;
			switch (this.operation)
			{
			case IntOperator.Operation.Add:
				this.storeResult.Value = value + value2;
				return;
			case IntOperator.Operation.Subtract:
				this.storeResult.Value = value - value2;
				return;
			case IntOperator.Operation.Multiply:
				this.storeResult.Value = value * value2;
				return;
			case IntOperator.Operation.Divide:
				this.storeResult.Value = value / value2;
				return;
			case IntOperator.Operation.Min:
				this.storeResult.Value = Mathf.Min(value, value2);
				return;
			case IntOperator.Operation.Max:
				this.storeResult.Value = Mathf.Max(value, value2);
				return;
			default:
				return;
			}
		}

		// Token: 0x0400459A RID: 17818
		[RequiredField]
		public FsmInt integer1;

		// Token: 0x0400459B RID: 17819
		[RequiredField]
		public FsmInt integer2;

		// Token: 0x0400459C RID: 17820
		public IntOperator.Operation operation;

		// Token: 0x0400459D RID: 17821
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmInt storeResult;

		// Token: 0x0400459E RID: 17822
		public bool everyFrame;

		// Token: 0x02000C30 RID: 3120
		public enum Operation
		{
			// Token: 0x040045A0 RID: 17824
			Add,
			// Token: 0x040045A1 RID: 17825
			Subtract,
			// Token: 0x040045A2 RID: 17826
			Multiply,
			// Token: 0x040045A3 RID: 17827
			Divide,
			// Token: 0x040045A4 RID: 17828
			Min,
			// Token: 0x040045A5 RID: 17829
			Max
		}
	}
}
