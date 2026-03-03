using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B95 RID: 2965
	[ActionCategory(ActionCategory.String)]
	[Tooltip("Replaces each format item in a specified string with the text equivalent of variable's value. Stores the result in a string variable.")]
	public class FormatString : FsmStateAction
	{
		// Token: 0x06003EEF RID: 16111 RVA: 0x001658D0 File Offset: 0x00163AD0
		public override void Reset()
		{
			this.format = null;
			this.variables = null;
			this.storeResult = null;
			this.everyFrame = false;
		}

		// Token: 0x06003EF0 RID: 16112 RVA: 0x001658EE File Offset: 0x00163AEE
		public override void OnEnter()
		{
			this.objectArray = new object[this.variables.Length];
			this.DoFormatString();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003EF1 RID: 16113 RVA: 0x00165917 File Offset: 0x00163B17
		public override void OnUpdate()
		{
			this.DoFormatString();
		}

		// Token: 0x06003EF2 RID: 16114 RVA: 0x00165920 File Offset: 0x00163B20
		private void DoFormatString()
		{
			for (int i = 0; i < this.variables.Length; i++)
			{
				this.variables[i].UpdateValue();
				this.objectArray[i] = this.variables[i].GetValue();
			}
			try
			{
				this.storeResult.Value = string.Format(this.format.Value, this.objectArray);
			}
			catch (FormatException ex)
			{
				base.LogError(ex.Message);
				base.Finish();
			}
		}

		// Token: 0x040042FF RID: 17151
		[RequiredField]
		[Tooltip("E.g. Hello {0} and {1}\nWith 2 variables that replace {0} and {1}\nSee C# string.Format docs.")]
		public FsmString format;

		// Token: 0x04004300 RID: 17152
		[Tooltip("Variables to use for each formatting item.")]
		public FsmVar[] variables;

		// Token: 0x04004301 RID: 17153
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the formatted result in a string variable.")]
		public FsmString storeResult;

		// Token: 0x04004302 RID: 17154
		[Tooltip("Repeat every frame. This is useful if the variables are changing.")]
		public bool everyFrame;

		// Token: 0x04004303 RID: 17155
		private object[] objectArray;
	}
}
