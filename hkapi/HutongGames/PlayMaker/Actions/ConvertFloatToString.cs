using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B55 RID: 2901
	[ActionCategory(ActionCategory.Convert)]
	[Tooltip("Converts a Float value to a String value with optional format.")]
	public class ConvertFloatToString : FsmStateAction
	{
		// Token: 0x06003DEF RID: 15855 RVA: 0x00162E72 File Offset: 0x00161072
		public override void Reset()
		{
			this.floatVariable = null;
			this.stringVariable = null;
			this.everyFrame = false;
			this.format = null;
		}

		// Token: 0x06003DF0 RID: 15856 RVA: 0x00162E90 File Offset: 0x00161090
		public override void OnEnter()
		{
			this.DoConvertFloatToString();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003DF1 RID: 15857 RVA: 0x00162EA6 File Offset: 0x001610A6
		public override void OnUpdate()
		{
			this.DoConvertFloatToString();
		}

		// Token: 0x06003DF2 RID: 15858 RVA: 0x00162EB0 File Offset: 0x001610B0
		private void DoConvertFloatToString()
		{
			if (this.format.IsNone || string.IsNullOrEmpty(this.format.Value))
			{
				this.stringVariable.Value = this.floatVariable.Value.ToString();
				return;
			}
			this.stringVariable.Value = this.floatVariable.Value.ToString(this.format.Value);
		}

		// Token: 0x04004210 RID: 16912
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The float variable to convert.")]
		public FsmFloat floatVariable;

		// Token: 0x04004211 RID: 16913
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("A string variable to store the converted value.")]
		public FsmString stringVariable;

		// Token: 0x04004212 RID: 16914
		[Tooltip("Optional Format, allows for leading zeroes. E.g., 0000")]
		public FsmString format;

		// Token: 0x04004213 RID: 16915
		[Tooltip("Repeat every frame. Useful if the float variable is changing.")]
		public bool everyFrame;
	}
}
