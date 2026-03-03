using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009E9 RID: 2537
	[ActionCategory(ActionCategory.Math)]
	[Tooltip("Sets the value of a Float Variable.")]
	public class KeepFloatPositive : FsmStateAction
	{
		// Token: 0x06003760 RID: 14176 RVA: 0x001467CE File Offset: 0x001449CE
		public override void Reset()
		{
			this.floatVariable = null;
			this.everyFrame = false;
		}

		// Token: 0x06003761 RID: 14177 RVA: 0x001467DE File Offset: 0x001449DE
		public override void OnEnter()
		{
			this.KeepPositive();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003762 RID: 14178 RVA: 0x001467F4 File Offset: 0x001449F4
		public override void OnUpdate()
		{
			this.KeepPositive();
		}

		// Token: 0x06003763 RID: 14179 RVA: 0x001467FC File Offset: 0x001449FC
		private void KeepPositive()
		{
			if (this.floatVariable.Value < 0f)
			{
				this.floatVariable.Value *= -1f;
			}
		}

		// Token: 0x040039A0 RID: 14752
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmFloat floatVariable;

		// Token: 0x040039A1 RID: 14753
		public bool everyFrame;
	}
}
