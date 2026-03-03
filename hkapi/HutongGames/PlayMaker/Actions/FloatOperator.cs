using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B90 RID: 2960
	[ActionCategory(ActionCategory.Math)]
	[Tooltip("Performs math operations on 2 Floats: Add, Subtract, Multiply, Divide, Min, Max.")]
	public class FloatOperator : FsmStateAction
	{
		// Token: 0x06003EDA RID: 16090 RVA: 0x00165608 File Offset: 0x00163808
		public override void Reset()
		{
			this.float1 = null;
			this.float2 = null;
			this.operation = FloatOperator.Operation.Add;
			this.storeResult = null;
			this.everyFrame = false;
		}

		// Token: 0x06003EDB RID: 16091 RVA: 0x0016562D File Offset: 0x0016382D
		public override void OnEnter()
		{
			this.DoFloatOperator();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003EDC RID: 16092 RVA: 0x00165643 File Offset: 0x00163843
		public override void OnUpdate()
		{
			this.DoFloatOperator();
		}

		// Token: 0x06003EDD RID: 16093 RVA: 0x0016564C File Offset: 0x0016384C
		private void DoFloatOperator()
		{
			float value = this.float1.Value;
			float value2 = this.float2.Value;
			switch (this.operation)
			{
			case FloatOperator.Operation.Add:
				this.storeResult.Value = value + value2;
				return;
			case FloatOperator.Operation.Subtract:
				this.storeResult.Value = value - value2;
				return;
			case FloatOperator.Operation.Multiply:
				this.storeResult.Value = value * value2;
				return;
			case FloatOperator.Operation.Divide:
				this.storeResult.Value = value / value2;
				return;
			case FloatOperator.Operation.Min:
				this.storeResult.Value = Mathf.Min(value, value2);
				return;
			case FloatOperator.Operation.Max:
				this.storeResult.Value = Mathf.Max(value, value2);
				return;
			default:
				return;
			}
		}

		// Token: 0x040042E7 RID: 17127
		[RequiredField]
		[Tooltip("The first float.")]
		public FsmFloat float1;

		// Token: 0x040042E8 RID: 17128
		[RequiredField]
		[Tooltip("The second float.")]
		public FsmFloat float2;

		// Token: 0x040042E9 RID: 17129
		[Tooltip("The math operation to perform on the floats.")]
		public FloatOperator.Operation operation;

		// Token: 0x040042EA RID: 17130
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the result of the operation in a float variable.")]
		public FsmFloat storeResult;

		// Token: 0x040042EB RID: 17131
		[Tooltip("Repeat every frame. Useful if the variables are changing.")]
		public bool everyFrame;

		// Token: 0x02000B91 RID: 2961
		public enum Operation
		{
			// Token: 0x040042ED RID: 17133
			Add,
			// Token: 0x040042EE RID: 17134
			Subtract,
			// Token: 0x040042EF RID: 17135
			Multiply,
			// Token: 0x040042F0 RID: 17136
			Divide,
			// Token: 0x040042F1 RID: 17137
			Min,
			// Token: 0x040042F2 RID: 17138
			Max
		}
	}
}
