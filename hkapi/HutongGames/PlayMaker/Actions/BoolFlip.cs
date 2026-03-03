using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B38 RID: 2872
	[ActionCategory(ActionCategory.Math)]
	[Tooltip("Flips the value of a Bool Variable.")]
	public class BoolFlip : FsmStateAction
	{
		// Token: 0x06003D62 RID: 15714 RVA: 0x00160CE7 File Offset: 0x0015EEE7
		public override void Reset()
		{
			this.boolVariable = null;
		}

		// Token: 0x06003D63 RID: 15715 RVA: 0x00160CF0 File Offset: 0x0015EEF0
		public override void OnEnter()
		{
			this.boolVariable.Value = !this.boolVariable.Value;
			base.Finish();
		}

		// Token: 0x04004173 RID: 16755
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Bool variable to flip.")]
		public FsmBool boolVariable;
	}
}
