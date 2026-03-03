using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B52 RID: 2898
	[ActionCategory(ActionCategory.Convert)]
	[Tooltip("Converts an Enum value to a String value.")]
	public class ConvertEnumToString : FsmStateAction
	{
		// Token: 0x06003DE5 RID: 15845 RVA: 0x00162D55 File Offset: 0x00160F55
		public override void Reset()
		{
			this.enumVariable = null;
			this.stringVariable = null;
			this.everyFrame = false;
		}

		// Token: 0x06003DE6 RID: 15846 RVA: 0x00162D6C File Offset: 0x00160F6C
		public override void OnEnter()
		{
			this.DoConvertEnumToString();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003DE7 RID: 15847 RVA: 0x00162D82 File Offset: 0x00160F82
		public override void OnUpdate()
		{
			this.DoConvertEnumToString();
		}

		// Token: 0x06003DE8 RID: 15848 RVA: 0x00162D8A File Offset: 0x00160F8A
		private void DoConvertEnumToString()
		{
			this.stringVariable.Value = ((this.enumVariable.Value != null) ? this.enumVariable.Value.ToString() : "");
		}

		// Token: 0x04004205 RID: 16901
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The Enum variable to convert.")]
		public FsmEnum enumVariable;

		// Token: 0x04004206 RID: 16902
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The String variable to store the converted value.")]
		public FsmString stringVariable;

		// Token: 0x04004207 RID: 16903
		[Tooltip("Repeat every frame. Useful if the Enum variable is changing.")]
		public bool everyFrame;
	}
}
