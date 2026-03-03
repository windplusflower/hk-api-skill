using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B50 RID: 2896
	[ActionCategory(ActionCategory.Convert)]
	[Tooltip("Converts a Bool value to an Integer value.")]
	public class ConvertBoolToInt : FsmStateAction
	{
		// Token: 0x06003DDB RID: 15835 RVA: 0x00162C4F File Offset: 0x00160E4F
		public override void Reset()
		{
			this.boolVariable = null;
			this.intVariable = null;
			this.falseValue = 0;
			this.trueValue = 1;
			this.everyFrame = false;
		}

		// Token: 0x06003DDC RID: 15836 RVA: 0x00162C7E File Offset: 0x00160E7E
		public override void OnEnter()
		{
			this.DoConvertBoolToInt();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003DDD RID: 15837 RVA: 0x00162C94 File Offset: 0x00160E94
		public override void OnUpdate()
		{
			this.DoConvertBoolToInt();
		}

		// Token: 0x06003DDE RID: 15838 RVA: 0x00162C9C File Offset: 0x00160E9C
		private void DoConvertBoolToInt()
		{
			this.intVariable.Value = (this.boolVariable.Value ? this.trueValue.Value : this.falseValue.Value);
		}

		// Token: 0x040041FB RID: 16891
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The Bool variable to test.")]
		public FsmBool boolVariable;

		// Token: 0x040041FC RID: 16892
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The Integer variable to set based on the Bool variable value.")]
		public FsmInt intVariable;

		// Token: 0x040041FD RID: 16893
		[Tooltip("Integer value if Bool variable is false.")]
		public FsmInt falseValue;

		// Token: 0x040041FE RID: 16894
		[Tooltip("Integer value if Bool variable is false.")]
		public FsmInt trueValue;

		// Token: 0x040041FF RID: 16895
		[Tooltip("Repeat every frame. Useful if the Bool variable is changing.")]
		public bool everyFrame;
	}
}
