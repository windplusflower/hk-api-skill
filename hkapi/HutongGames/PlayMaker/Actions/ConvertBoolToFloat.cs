using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B4F RID: 2895
	[ActionCategory(ActionCategory.Convert)]
	[Tooltip("Converts a Bool value to a Float value.")]
	public class ConvertBoolToFloat : FsmStateAction
	{
		// Token: 0x06003DD6 RID: 15830 RVA: 0x00162BC8 File Offset: 0x00160DC8
		public override void Reset()
		{
			this.boolVariable = null;
			this.floatVariable = null;
			this.falseValue = 0f;
			this.trueValue = 1f;
			this.everyFrame = false;
		}

		// Token: 0x06003DD7 RID: 15831 RVA: 0x00162BFF File Offset: 0x00160DFF
		public override void OnEnter()
		{
			this.DoConvertBoolToFloat();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003DD8 RID: 15832 RVA: 0x00162C15 File Offset: 0x00160E15
		public override void OnUpdate()
		{
			this.DoConvertBoolToFloat();
		}

		// Token: 0x06003DD9 RID: 15833 RVA: 0x00162C1D File Offset: 0x00160E1D
		private void DoConvertBoolToFloat()
		{
			this.floatVariable.Value = (this.boolVariable.Value ? this.trueValue.Value : this.falseValue.Value);
		}

		// Token: 0x040041F6 RID: 16886
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The Bool variable to test.")]
		public FsmBool boolVariable;

		// Token: 0x040041F7 RID: 16887
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The Float variable to set based on the Bool variable value.")]
		public FsmFloat floatVariable;

		// Token: 0x040041F8 RID: 16888
		[Tooltip("Float value if Bool variable is false.")]
		public FsmFloat falseValue;

		// Token: 0x040041F9 RID: 16889
		[Tooltip("Float value if Bool variable is true.")]
		public FsmFloat trueValue;

		// Token: 0x040041FA RID: 16890
		[Tooltip("Repeat every frame. Useful if the Bool variable is changing.")]
		public bool everyFrame;
	}
}
