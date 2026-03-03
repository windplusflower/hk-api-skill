using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CA3 RID: 3235
	[ActionCategory(ActionCategory.Math)]
	[Tooltip("Sets the value of a Float Variable.")]
	public class SetFloatValue : FsmStateAction
	{
		// Token: 0x0600437B RID: 17275 RVA: 0x00173262 File Offset: 0x00171462
		public override void Reset()
		{
			this.floatVariable = null;
			this.floatValue = null;
			this.everyFrame = false;
		}

		// Token: 0x0600437C RID: 17276 RVA: 0x00173279 File Offset: 0x00171479
		public override void OnEnter()
		{
			this.floatVariable.Value = this.floatValue.Value;
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x0600437D RID: 17277 RVA: 0x0017329F File Offset: 0x0017149F
		public override void OnUpdate()
		{
			this.floatVariable.Value = this.floatValue.Value;
		}

		// Token: 0x040047BF RID: 18367
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmFloat floatVariable;

		// Token: 0x040047C0 RID: 18368
		[RequiredField]
		public FsmFloat floatValue;

		// Token: 0x040047C1 RID: 18369
		public bool everyFrame;
	}
}
