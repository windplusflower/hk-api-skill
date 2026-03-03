using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B3E RID: 2878
	[ActionCategory(ActionCategory.String)]
	[Tooltip("Builds a String from other Strings.")]
	public class BuildString : FsmStateAction
	{
		// Token: 0x06003D76 RID: 15734 RVA: 0x00160FB6 File Offset: 0x0015F1B6
		public override void Reset()
		{
			this.stringParts = new FsmString[3];
			this.separator = null;
			this.addToEnd = true;
			this.storeResult = null;
			this.everyFrame = false;
		}

		// Token: 0x06003D77 RID: 15735 RVA: 0x00160FE5 File Offset: 0x0015F1E5
		public override void OnEnter()
		{
			this.DoBuildString();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003D78 RID: 15736 RVA: 0x00160FFB File Offset: 0x0015F1FB
		public override void OnUpdate()
		{
			this.DoBuildString();
		}

		// Token: 0x06003D79 RID: 15737 RVA: 0x00161004 File Offset: 0x0015F204
		private void DoBuildString()
		{
			if (this.storeResult == null)
			{
				return;
			}
			this.result = "";
			for (int i = 0; i < this.stringParts.Length - 1; i++)
			{
				this.result += this.stringParts[i].Value.Replace("\\n", "\n");
				this.result += this.separator.Value;
			}
			string str = this.result;
			FsmString fsmString = this.stringParts[this.stringParts.Length - 1];
			this.result = str + ((fsmString != null) ? fsmString.ToString() : null);
			if (this.addToEnd.Value)
			{
				this.result += this.separator.Value;
			}
			this.storeResult.Value = this.result;
		}

		// Token: 0x0400418A RID: 16778
		[RequiredField]
		[Tooltip("Array of Strings to combine.")]
		public FsmString[] stringParts;

		// Token: 0x0400418B RID: 16779
		[Tooltip("Separator to insert between each String. E.g. space character.")]
		public FsmString separator;

		// Token: 0x0400418C RID: 16780
		[Tooltip("Add Separator to end of built string.")]
		public FsmBool addToEnd;

		// Token: 0x0400418D RID: 16781
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the final String in a variable.")]
		public FsmString storeResult;

		// Token: 0x0400418E RID: 16782
		[Tooltip("Repeat every frame while the state is active.")]
		public bool everyFrame;

		// Token: 0x0400418F RID: 16783
		private string result;
	}
}
