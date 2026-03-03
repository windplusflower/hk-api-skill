using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009CA RID: 2506
	[ActionCategory(ActionCategory.Math)]
	[Tooltip("Get a Float Variable square root value")]
	public class FloatSquareRoot : FsmStateAction
	{
		// Token: 0x060036D5 RID: 14037 RVA: 0x00143A4F File Offset: 0x00141C4F
		public override void Reset()
		{
			this.floatVariable = null;
			this.result = null;
			this.everyFrame = false;
		}

		// Token: 0x060036D6 RID: 14038 RVA: 0x00143A66 File Offset: 0x00141C66
		public override void OnEnter()
		{
			this.DoFloatSquareRoot();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060036D7 RID: 14039 RVA: 0x00143A7C File Offset: 0x00141C7C
		public override void OnUpdate()
		{
			this.DoFloatSquareRoot();
		}

		// Token: 0x060036D8 RID: 14040 RVA: 0x00143A84 File Offset: 0x00141C84
		private void DoFloatSquareRoot()
		{
			if (!this.result.IsNone)
			{
				this.result.Value = Mathf.Sqrt(this.floatVariable.Value);
			}
		}

		// Token: 0x040038EF RID: 14575
		public FsmFloat floatVariable;

		// Token: 0x040038F0 RID: 14576
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmFloat result;

		// Token: 0x040038F1 RID: 14577
		public bool everyFrame;
	}
}
