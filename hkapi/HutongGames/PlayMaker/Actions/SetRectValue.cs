using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CDE RID: 3294
	[ActionCategory(ActionCategory.Rect)]
	[Tooltip("Sets the value of a Rect Variable.")]
	public class SetRectValue : FsmStateAction
	{
		// Token: 0x0600447C RID: 17532 RVA: 0x00175F47 File Offset: 0x00174147
		public override void Reset()
		{
			this.rectVariable = null;
			this.rectValue = null;
			this.everyFrame = false;
		}

		// Token: 0x0600447D RID: 17533 RVA: 0x00175F5E File Offset: 0x0017415E
		public override void OnEnter()
		{
			this.rectVariable.Value = this.rectValue.Value;
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x0600447E RID: 17534 RVA: 0x00175F84 File Offset: 0x00174184
		public override void OnUpdate()
		{
			this.rectVariable.Value = this.rectValue.Value;
		}

		// Token: 0x040048C4 RID: 18628
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmRect rectVariable;

		// Token: 0x040048C5 RID: 18629
		[RequiredField]
		public FsmRect rectValue;

		// Token: 0x040048C6 RID: 18630
		public bool everyFrame;
	}
}
