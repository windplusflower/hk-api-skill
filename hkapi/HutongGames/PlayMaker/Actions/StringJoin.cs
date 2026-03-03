using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CF4 RID: 3316
	[ActionCategory(ActionCategory.String)]
	[Tooltip("Join an array of strings into a single string.")]
	public class StringJoin : FsmStateAction
	{
		// Token: 0x060044E8 RID: 17640 RVA: 0x0017787C File Offset: 0x00175A7C
		public override void OnEnter()
		{
			if (!this.stringArray.IsNone && !this.storeResult.IsNone)
			{
				this.storeResult.Value = string.Join(this.separator.Value, this.stringArray.stringValues);
			}
			base.Finish();
		}

		// Token: 0x04004935 RID: 18741
		[UIHint(UIHint.Variable)]
		[ArrayEditor(VariableType.String, "", 0, 0, 65536)]
		[Tooltip("Array of string to join into a single string.")]
		public FsmArray stringArray;

		// Token: 0x04004936 RID: 18742
		[Tooltip("Seperator to add between each string.")]
		public FsmString separator;

		// Token: 0x04004937 RID: 18743
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the joined string in string variable.")]
		public FsmString storeResult;
	}
}
