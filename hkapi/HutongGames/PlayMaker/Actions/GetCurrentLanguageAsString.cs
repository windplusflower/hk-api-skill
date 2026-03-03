using System;
using Language;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009D2 RID: 2514
	[ActionCategory(ActionCategory.String)]
	[Tooltip("Get currently set language as a string.")]
	public class GetCurrentLanguageAsString : FsmStateAction
	{
		// Token: 0x060036FC RID: 14076 RVA: 0x001440B8 File Offset: 0x001422B8
		public override void Reset()
		{
			this.stringVariable = null;
		}

		// Token: 0x060036FD RID: 14077 RVA: 0x001440C4 File Offset: 0x001422C4
		public override void OnEnter()
		{
			this.stringVariable.Value = Language.CurrentLanguage().ToString();
			base.Finish();
		}

		// Token: 0x04003917 RID: 14615
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmString stringVariable;
	}
}
