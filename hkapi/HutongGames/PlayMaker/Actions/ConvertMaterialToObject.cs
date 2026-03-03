using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B58 RID: 2904
	[ActionCategory(ActionCategory.Convert)]
	[Tooltip("Converts a Material variable to an Object variable. Useful if you want to use Set Property (which only works on Object variables).")]
	public class ConvertMaterialToObject : FsmStateAction
	{
		// Token: 0x06003DFE RID: 15870 RVA: 0x00163024 File Offset: 0x00161224
		public override void Reset()
		{
			this.materialVariable = null;
			this.objectVariable = null;
			this.everyFrame = false;
		}

		// Token: 0x06003DFF RID: 15871 RVA: 0x0016303B File Offset: 0x0016123B
		public override void OnEnter()
		{
			this.DoConvertMaterialToObject();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003E00 RID: 15872 RVA: 0x00163051 File Offset: 0x00161251
		public override void OnUpdate()
		{
			this.DoConvertMaterialToObject();
		}

		// Token: 0x06003E01 RID: 15873 RVA: 0x00163059 File Offset: 0x00161259
		private void DoConvertMaterialToObject()
		{
			this.objectVariable.Value = this.materialVariable.Value;
		}

		// Token: 0x0400421B RID: 16923
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The Material variable to convert to an Object.")]
		public FsmMaterial materialVariable;

		// Token: 0x0400421C RID: 16924
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the result in an Object variable.")]
		public FsmObject objectVariable;

		// Token: 0x0400421D RID: 16925
		[Tooltip("Repeat every frame. Useful if the Material variable is changing.")]
		public bool everyFrame;
	}
}
