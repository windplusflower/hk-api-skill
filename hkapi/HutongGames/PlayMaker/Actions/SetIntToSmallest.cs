using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A43 RID: 2627
	[ActionCategory(ActionCategory.Math)]
	[Tooltip("Sets the value of an Int Variable to the smallest of two values.")]
	public class SetIntToSmallest : FsmStateAction
	{
		// Token: 0x060038EF RID: 14575 RVA: 0x0014CC02 File Offset: 0x0014AE02
		public override void Reset()
		{
			this.intVariable = null;
			this.value1 = null;
			this.value2 = null;
			this.everyFrame = false;
		}

		// Token: 0x060038F0 RID: 14576 RVA: 0x0014CC20 File Offset: 0x0014AE20
		public override void OnEnter()
		{
			if (this.value1.Value < this.value2.Value)
			{
				this.intVariable.Value = this.value1.Value;
			}
			else
			{
				this.intVariable.Value = this.value2.Value;
			}
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060038F1 RID: 14577 RVA: 0x0014CC84 File Offset: 0x0014AE84
		public override void OnUpdate()
		{
			if (this.value1.Value < this.value2.Value)
			{
				this.intVariable.Value = this.value1.Value;
				return;
			}
			this.intVariable.Value = this.value2.Value;
		}

		// Token: 0x04003B93 RID: 15251
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmInt intVariable;

		// Token: 0x04003B94 RID: 15252
		[RequiredField]
		public FsmInt value1;

		// Token: 0x04003B95 RID: 15253
		[RequiredField]
		public FsmInt value2;

		// Token: 0x04003B96 RID: 15254
		public bool everyFrame;
	}
}
