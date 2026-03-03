using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B5A RID: 2906
	[ActionCategory(ActionCategory.Convert)]
	[Tooltip("Converts an String value to an Int value.")]
	public class ConvertStringToInt : FsmStateAction
	{
		// Token: 0x06003E08 RID: 15880 RVA: 0x001631BB File Offset: 0x001613BB
		public override void Reset()
		{
			this.intVariable = null;
			this.stringVariable = null;
			this.everyFrame = false;
		}

		// Token: 0x06003E09 RID: 15881 RVA: 0x001631D2 File Offset: 0x001613D2
		public override void OnEnter()
		{
			this.DoConvertStringToInt();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003E0A RID: 15882 RVA: 0x001631E8 File Offset: 0x001613E8
		public override void OnUpdate()
		{
			this.DoConvertStringToInt();
		}

		// Token: 0x06003E0B RID: 15883 RVA: 0x001631F0 File Offset: 0x001613F0
		private void DoConvertStringToInt()
		{
			this.intVariable.Value = int.Parse(this.stringVariable.Value);
		}

		// Token: 0x04004222 RID: 16930
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The String variable to convert to an integer.")]
		public FsmString stringVariable;

		// Token: 0x04004223 RID: 16931
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the result in an Int variable.")]
		public FsmInt intVariable;

		// Token: 0x04004224 RID: 16932
		[Tooltip("Repeat every frame. Useful if the String variable is changing.")]
		public bool everyFrame;
	}
}
