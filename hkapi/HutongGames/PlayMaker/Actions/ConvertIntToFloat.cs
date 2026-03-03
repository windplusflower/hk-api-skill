using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B56 RID: 2902
	[ActionCategory(ActionCategory.Convert)]
	[Tooltip("Converts an Integer value to a Float value.")]
	public class ConvertIntToFloat : FsmStateAction
	{
		// Token: 0x06003DF4 RID: 15860 RVA: 0x00162F24 File Offset: 0x00161124
		public override void Reset()
		{
			this.intVariable = null;
			this.floatVariable = null;
			this.everyFrame = false;
		}

		// Token: 0x06003DF5 RID: 15861 RVA: 0x00162F3B File Offset: 0x0016113B
		public override void OnEnter()
		{
			this.DoConvertIntToFloat();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003DF6 RID: 15862 RVA: 0x00162F51 File Offset: 0x00161151
		public override void OnUpdate()
		{
			this.DoConvertIntToFloat();
		}

		// Token: 0x06003DF7 RID: 15863 RVA: 0x00162F59 File Offset: 0x00161159
		private void DoConvertIntToFloat()
		{
			this.floatVariable.Value = (float)this.intVariable.Value;
		}

		// Token: 0x04004214 RID: 16916
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The Integer variable to convert to a float.")]
		public FsmInt intVariable;

		// Token: 0x04004215 RID: 16917
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the result in a Float variable.")]
		public FsmFloat floatVariable;

		// Token: 0x04004216 RID: 16918
		[Tooltip("Repeat every frame. Useful if the Integer variable is changing.")]
		public bool everyFrame;
	}
}
