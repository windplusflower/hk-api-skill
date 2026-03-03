using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B3A RID: 2874
	[ActionCategory(ActionCategory.Math)]
	[Tooltip("Performs boolean operations on 2 Bool Variables.")]
	public class BoolOperator : FsmStateAction
	{
		// Token: 0x06003D6A RID: 15722 RVA: 0x00160DAF File Offset: 0x0015EFAF
		public override void Reset()
		{
			this.bool1 = false;
			this.bool2 = false;
			this.operation = BoolOperator.Operation.AND;
			this.storeResult = null;
			this.everyFrame = false;
		}

		// Token: 0x06003D6B RID: 15723 RVA: 0x00160DDE File Offset: 0x0015EFDE
		public override void OnEnter()
		{
			this.DoBoolOperator();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003D6C RID: 15724 RVA: 0x00160DF4 File Offset: 0x0015EFF4
		public override void OnUpdate()
		{
			this.DoBoolOperator();
		}

		// Token: 0x06003D6D RID: 15725 RVA: 0x00160DFC File Offset: 0x0015EFFC
		private void DoBoolOperator()
		{
			bool value = this.bool1.Value;
			bool value2 = this.bool2.Value;
			switch (this.operation)
			{
			case BoolOperator.Operation.AND:
				this.storeResult.Value = (value && value2);
				return;
			case BoolOperator.Operation.NAND:
				this.storeResult.Value = (!value || !value2);
				return;
			case BoolOperator.Operation.OR:
				this.storeResult.Value = (value || value2);
				return;
			case BoolOperator.Operation.XOR:
				this.storeResult.Value = (value ^ value2);
				return;
			default:
				return;
			}
		}

		// Token: 0x04004178 RID: 16760
		[RequiredField]
		[Tooltip("The first Bool variable.")]
		public FsmBool bool1;

		// Token: 0x04004179 RID: 16761
		[RequiredField]
		[Tooltip("The second Bool variable.")]
		public FsmBool bool2;

		// Token: 0x0400417A RID: 16762
		[Tooltip("Boolean Operation.")]
		public BoolOperator.Operation operation;

		// Token: 0x0400417B RID: 16763
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the result in a Bool Variable.")]
		public FsmBool storeResult;

		// Token: 0x0400417C RID: 16764
		[Tooltip("Repeat every frame while the state is active.")]
		public bool everyFrame;

		// Token: 0x02000B3B RID: 2875
		public enum Operation
		{
			// Token: 0x0400417E RID: 16766
			AND,
			// Token: 0x0400417F RID: 16767
			NAND,
			// Token: 0x04004180 RID: 16768
			OR,
			// Token: 0x04004181 RID: 16769
			XOR
		}
	}
}
