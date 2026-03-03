using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A41 RID: 2625
	[ActionCategory(ActionCategory.Math)]
	[Tooltip("Sets the value of a Float Variable to the highest of two values.")]
	public class SetFloatToHighest : FsmStateAction
	{
		// Token: 0x060038E7 RID: 14567 RVA: 0x0014CA59 File Offset: 0x0014AC59
		public override void Reset()
		{
			this.floatVariable = null;
			this.value1 = null;
			this.value2 = null;
			this.everyFrame = false;
		}

		// Token: 0x060038E8 RID: 14568 RVA: 0x0014CA78 File Offset: 0x0014AC78
		public override void OnEnter()
		{
			if (this.value1.Value > this.value2.Value)
			{
				this.floatVariable.Value = this.value1.Value;
			}
			else
			{
				this.floatVariable.Value = this.value2.Value;
			}
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060038E9 RID: 14569 RVA: 0x0014CADC File Offset: 0x0014ACDC
		public override void OnUpdate()
		{
			if (this.value1.Value > this.value2.Value)
			{
				this.floatVariable.Value = this.value1.Value;
				return;
			}
			this.floatVariable.Value = this.value2.Value;
		}

		// Token: 0x04003B8B RID: 15243
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmFloat floatVariable;

		// Token: 0x04003B8C RID: 15244
		[RequiredField]
		public FsmFloat value1;

		// Token: 0x04003B8D RID: 15245
		[RequiredField]
		public FsmFloat value2;

		// Token: 0x04003B8E RID: 15246
		public bool everyFrame;
	}
}
