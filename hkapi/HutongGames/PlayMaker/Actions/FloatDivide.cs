using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B8D RID: 2957
	[ActionCategory(ActionCategory.Math)]
	[Tooltip("Divides one Float by another.")]
	public class FloatDivide : FsmStateAction
	{
		// Token: 0x06003ECE RID: 16078 RVA: 0x001653F3 File Offset: 0x001635F3
		public override void Reset()
		{
			this.floatVariable = null;
			this.divideBy = null;
			this.everyFrame = false;
		}

		// Token: 0x06003ECF RID: 16079 RVA: 0x0016540A File Offset: 0x0016360A
		public override void OnEnter()
		{
			this.floatVariable.Value /= this.divideBy.Value;
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003ED0 RID: 16080 RVA: 0x00165437 File Offset: 0x00163637
		public override void OnUpdate()
		{
			this.floatVariable.Value /= this.divideBy.Value;
		}

		// Token: 0x040042D8 RID: 17112
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The float variable to divide.")]
		public FsmFloat floatVariable;

		// Token: 0x040042D9 RID: 17113
		[RequiredField]
		[Tooltip("Divide the float variable by this value.")]
		public FsmFloat divideBy;

		// Token: 0x040042DA RID: 17114
		[Tooltip("Repeate every frame. Useful if the variables are changing.")]
		public bool everyFrame;
	}
}
