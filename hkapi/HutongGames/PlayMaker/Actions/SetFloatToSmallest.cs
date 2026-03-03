using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A42 RID: 2626
	[ActionCategory(ActionCategory.Math)]
	[Tooltip("Sets the value of a Float Variable to the smallest of two values.")]
	public class SetFloatToSmallest : FsmStateAction
	{
		// Token: 0x060038EB RID: 14571 RVA: 0x0014CB2E File Offset: 0x0014AD2E
		public override void Reset()
		{
			this.floatVariable = null;
			this.value1 = null;
			this.value2 = null;
			this.everyFrame = false;
		}

		// Token: 0x060038EC RID: 14572 RVA: 0x0014CB4C File Offset: 0x0014AD4C
		public override void OnEnter()
		{
			if (this.value1.Value < this.value2.Value)
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

		// Token: 0x060038ED RID: 14573 RVA: 0x0014CBB0 File Offset: 0x0014ADB0
		public override void OnUpdate()
		{
			if (this.value1.Value < this.value2.Value)
			{
				this.floatVariable.Value = this.value1.Value;
				return;
			}
			this.floatVariable.Value = this.value2.Value;
		}

		// Token: 0x04003B8F RID: 15247
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmFloat floatVariable;

		// Token: 0x04003B90 RID: 15248
		[RequiredField]
		public FsmFloat value1;

		// Token: 0x04003B91 RID: 15249
		[RequiredField]
		public FsmFloat value2;

		// Token: 0x04003B92 RID: 15250
		public bool everyFrame;
	}
}
