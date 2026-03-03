using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009CB RID: 2507
	[ActionCategory(ActionCategory.Logic)]
	[Tooltip("Set bools based on the comparison of 2 Floats.")]
	public class FloatTestToBool : FsmStateAction
	{
		// Token: 0x060036DA RID: 14042 RVA: 0x00143AAE File Offset: 0x00141CAE
		public override void Reset()
		{
			this.float1 = 0f;
			this.float2 = 0f;
			this.tolerance = 0f;
			this.everyFrame = false;
		}

		// Token: 0x060036DB RID: 14043 RVA: 0x00143AE7 File Offset: 0x00141CE7
		public override void OnEnter()
		{
			this.DoCompare();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060036DC RID: 14044 RVA: 0x00143AFD File Offset: 0x00141CFD
		public override void OnUpdate()
		{
			this.DoCompare();
		}

		// Token: 0x060036DD RID: 14045 RVA: 0x00143B08 File Offset: 0x00141D08
		private void DoCompare()
		{
			if (Mathf.Abs(this.float1.Value - this.float2.Value) <= this.tolerance.Value)
			{
				this.equalBool.Value = true;
			}
			else
			{
				this.equalBool.Value = false;
			}
			if (this.float1.Value < this.float2.Value)
			{
				this.lessThanBool.Value = true;
			}
			else
			{
				this.lessThanBool.Value = false;
			}
			if (this.float1.Value > this.float2.Value)
			{
				this.greaterThanBool.Value = true;
				return;
			}
			this.greaterThanBool.Value = false;
		}

		// Token: 0x040038F2 RID: 14578
		[RequiredField]
		[Tooltip("The first float variable.")]
		public FsmFloat float1;

		// Token: 0x040038F3 RID: 14579
		[RequiredField]
		[Tooltip("The second float variable.")]
		public FsmFloat float2;

		// Token: 0x040038F4 RID: 14580
		[RequiredField]
		[Tooltip("Tolerance for the Equal test (almost equal).")]
		public FsmFloat tolerance;

		// Token: 0x040038F5 RID: 14581
		[Tooltip("Bool set if Float 1 equals Float 2")]
		[UIHint(UIHint.Variable)]
		public FsmBool equalBool;

		// Token: 0x040038F6 RID: 14582
		[Tooltip("Bool set if Float 1 is less than Float 2")]
		[UIHint(UIHint.Variable)]
		public FsmBool lessThanBool;

		// Token: 0x040038F7 RID: 14583
		[Tooltip("Bool set if Float 1 is greater than Float 2")]
		[UIHint(UIHint.Variable)]
		public FsmBool greaterThanBool;

		// Token: 0x040038F8 RID: 14584
		[Tooltip("Repeat every frame. Useful if the variables are changing and you're waiting for a particular result.")]
		public bool everyFrame;
	}
}
