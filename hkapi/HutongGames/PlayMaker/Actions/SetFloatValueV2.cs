using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CA4 RID: 3236
	[ActionCategory(ActionCategory.Math)]
	[Tooltip("Sets the value of a Float Variable.")]
	public class SetFloatValueV2 : FsmStateAction
	{
		// Token: 0x0600437F RID: 17279 RVA: 0x001732B7 File Offset: 0x001714B7
		public override void Reset()
		{
			this.floatVariable = null;
			this.floatValue = null;
			this.everyFrame = false;
			this.activeBool = null;
		}

		// Token: 0x06004380 RID: 17280 RVA: 0x001732D5 File Offset: 0x001714D5
		public override void OnEnter()
		{
			if (this.activeBool.IsNone || this.activeBool.Value)
			{
				this.floatVariable.Value = this.floatValue.Value;
			}
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004381 RID: 17281 RVA: 0x00173315 File Offset: 0x00171515
		public override void OnUpdate()
		{
			if (this.activeBool.IsNone || this.activeBool.Value)
			{
				this.floatVariable.Value = this.floatValue.Value;
			}
		}

		// Token: 0x040047C2 RID: 18370
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmFloat floatVariable;

		// Token: 0x040047C3 RID: 18371
		[RequiredField]
		public FsmFloat floatValue;

		// Token: 0x040047C4 RID: 18372
		public bool everyFrame;

		// Token: 0x040047C5 RID: 18373
		public FsmBool activeBool;
	}
}
