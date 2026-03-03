using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B87 RID: 2951
	[ActionCategory(ActionCategory.Math)]
	[Tooltip("Sets a Float variable to its absolute value.")]
	public class FloatAbs : FsmStateAction
	{
		// Token: 0x06003EB0 RID: 16048 RVA: 0x0016504D File Offset: 0x0016324D
		public override void Reset()
		{
			this.floatVariable = null;
			this.everyFrame = false;
		}

		// Token: 0x06003EB1 RID: 16049 RVA: 0x0016505D File Offset: 0x0016325D
		public override void OnEnter()
		{
			this.DoFloatAbs();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003EB2 RID: 16050 RVA: 0x00165073 File Offset: 0x00163273
		public override void OnUpdate()
		{
			this.DoFloatAbs();
		}

		// Token: 0x06003EB3 RID: 16051 RVA: 0x0016507B File Offset: 0x0016327B
		private void DoFloatAbs()
		{
			this.floatVariable.Value = Mathf.Abs(this.floatVariable.Value);
		}

		// Token: 0x040042C0 RID: 17088
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The Float variable.")]
		public FsmFloat floatVariable;

		// Token: 0x040042C1 RID: 17089
		[Tooltip("Repeat every frame. Useful if the Float variable is changing.")]
		public bool everyFrame;
	}
}
