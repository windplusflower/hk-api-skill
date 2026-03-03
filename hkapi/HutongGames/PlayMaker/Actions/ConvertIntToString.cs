using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B57 RID: 2903
	[ActionCategory(ActionCategory.Convert)]
	[Tooltip("Converts an Integer value to a String value with an optional format.")]
	public class ConvertIntToString : FsmStateAction
	{
		// Token: 0x06003DF9 RID: 15865 RVA: 0x00162F72 File Offset: 0x00161172
		public override void Reset()
		{
			this.intVariable = null;
			this.stringVariable = null;
			this.everyFrame = false;
			this.format = null;
		}

		// Token: 0x06003DFA RID: 15866 RVA: 0x00162F90 File Offset: 0x00161190
		public override void OnEnter()
		{
			this.DoConvertIntToString();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003DFB RID: 15867 RVA: 0x00162FA6 File Offset: 0x001611A6
		public override void OnUpdate()
		{
			this.DoConvertIntToString();
		}

		// Token: 0x06003DFC RID: 15868 RVA: 0x00162FB0 File Offset: 0x001611B0
		private void DoConvertIntToString()
		{
			if (this.format.IsNone || string.IsNullOrEmpty(this.format.Value))
			{
				this.stringVariable.Value = this.intVariable.Value.ToString();
				return;
			}
			this.stringVariable.Value = this.intVariable.Value.ToString(this.format.Value);
		}

		// Token: 0x04004217 RID: 16919
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The Int variable to convert.")]
		public FsmInt intVariable;

		// Token: 0x04004218 RID: 16920
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("A String variable to store the converted value.")]
		public FsmString stringVariable;

		// Token: 0x04004219 RID: 16921
		[Tooltip("Optional Format, allows for leading zeroes. E.g., 0000")]
		public FsmString format;

		// Token: 0x0400421A RID: 16922
		[Tooltip("Repeat every frame. Useful if the Int variable is changing.")]
		public bool everyFrame;
	}
}
