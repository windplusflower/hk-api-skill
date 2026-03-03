using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B51 RID: 2897
	[ActionCategory(ActionCategory.Convert)]
	[Tooltip("Converts a Bool value to a String value.")]
	public class ConvertBoolToString : FsmStateAction
	{
		// Token: 0x06003DE0 RID: 15840 RVA: 0x00162CCE File Offset: 0x00160ECE
		public override void Reset()
		{
			this.boolVariable = null;
			this.stringVariable = null;
			this.falseString = "False";
			this.trueString = "True";
			this.everyFrame = false;
		}

		// Token: 0x06003DE1 RID: 15841 RVA: 0x00162D05 File Offset: 0x00160F05
		public override void OnEnter()
		{
			this.DoConvertBoolToString();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003DE2 RID: 15842 RVA: 0x00162D1B File Offset: 0x00160F1B
		public override void OnUpdate()
		{
			this.DoConvertBoolToString();
		}

		// Token: 0x06003DE3 RID: 15843 RVA: 0x00162D23 File Offset: 0x00160F23
		private void DoConvertBoolToString()
		{
			this.stringVariable.Value = (this.boolVariable.Value ? this.trueString.Value : this.falseString.Value);
		}

		// Token: 0x04004200 RID: 16896
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The Bool variable to test.")]
		public FsmBool boolVariable;

		// Token: 0x04004201 RID: 16897
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The String variable to set based on the Bool variable value.")]
		public FsmString stringVariable;

		// Token: 0x04004202 RID: 16898
		[Tooltip("String value if Bool variable is false.")]
		public FsmString falseString;

		// Token: 0x04004203 RID: 16899
		[Tooltip("String value if Bool variable is true.")]
		public FsmString trueString;

		// Token: 0x04004204 RID: 16900
		[Tooltip("Repeat every frame. Useful if the Bool variable is changing.")]
		public bool everyFrame;
	}
}
