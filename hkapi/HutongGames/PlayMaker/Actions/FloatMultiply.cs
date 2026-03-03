using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B8F RID: 2959
	[ActionCategory(ActionCategory.Math)]
	[Tooltip("Multiplies one Float by another.")]
	public class FloatMultiply : FsmStateAction
	{
		// Token: 0x06003ED6 RID: 16086 RVA: 0x001655A5 File Offset: 0x001637A5
		public override void Reset()
		{
			this.floatVariable = null;
			this.multiplyBy = null;
			this.everyFrame = false;
		}

		// Token: 0x06003ED7 RID: 16087 RVA: 0x001655BC File Offset: 0x001637BC
		public override void OnEnter()
		{
			this.floatVariable.Value *= this.multiplyBy.Value;
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003ED8 RID: 16088 RVA: 0x001655E9 File Offset: 0x001637E9
		public override void OnUpdate()
		{
			this.floatVariable.Value *= this.multiplyBy.Value;
		}

		// Token: 0x040042E4 RID: 17124
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The float variable to multiply.")]
		public FsmFloat floatVariable;

		// Token: 0x040042E5 RID: 17125
		[RequiredField]
		[Tooltip("Multiply the float variable by this value.")]
		public FsmFloat multiplyBy;

		// Token: 0x040042E6 RID: 17126
		[Tooltip("Repeat every frame. Useful if the variables are changing.")]
		public bool everyFrame;
	}
}
