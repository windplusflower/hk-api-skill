using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009E8 RID: 2536
	[ActionCategory(ActionCategory.Logic)]
	[Tooltip("Set bools based on the comparison of 2 ints.")]
	public class IntTestToBool : FsmStateAction
	{
		// Token: 0x0600375B RID: 14171 RVA: 0x001466ED File Offset: 0x001448ED
		public override void Reset()
		{
			this.int1 = 0;
			this.int2 = 0;
			this.everyFrame = false;
		}

		// Token: 0x0600375C RID: 14172 RVA: 0x0014670E File Offset: 0x0014490E
		public override void OnEnter()
		{
			this.DoCompare();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x0600375D RID: 14173 RVA: 0x00146724 File Offset: 0x00144924
		public override void OnUpdate()
		{
			this.DoCompare();
		}

		// Token: 0x0600375E RID: 14174 RVA: 0x0014672C File Offset: 0x0014492C
		private void DoCompare()
		{
			if (this.int1.Value == this.int2.Value)
			{
				this.equalBool.Value = true;
			}
			else
			{
				this.equalBool.Value = false;
			}
			if (this.int1.Value < this.int2.Value)
			{
				this.lessThanBool.Value = true;
			}
			else
			{
				this.lessThanBool.Value = false;
			}
			if (this.int1.Value > this.int2.Value)
			{
				this.greaterThanBool.Value = true;
				return;
			}
			this.greaterThanBool.Value = false;
		}

		// Token: 0x0400399A RID: 14746
		[RequiredField]
		[Tooltip("The first int variable.")]
		public FsmInt int1;

		// Token: 0x0400399B RID: 14747
		[RequiredField]
		[Tooltip("The second int variable.")]
		public FsmInt int2;

		// Token: 0x0400399C RID: 14748
		[Tooltip("Bool set if Int 1 equals Int 2")]
		[UIHint(UIHint.Variable)]
		public FsmBool equalBool;

		// Token: 0x0400399D RID: 14749
		[Tooltip("Bool set if Int 1 is less than Int 2")]
		[UIHint(UIHint.Variable)]
		public FsmBool lessThanBool;

		// Token: 0x0400399E RID: 14750
		[Tooltip("Bool set if Int 1 is greater than Int 2")]
		[UIHint(UIHint.Variable)]
		public FsmBool greaterThanBool;

		// Token: 0x0400399F RID: 14751
		[Tooltip("Repeat every frame. Useful if the variables are changing and you're waiting for a particular result.")]
		public bool everyFrame;
	}
}
