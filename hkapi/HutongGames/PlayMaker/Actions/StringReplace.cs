using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CF9 RID: 3321
	[ActionCategory(ActionCategory.String)]
	[Tooltip("Replace a substring with a new String.")]
	public class StringReplace : FsmStateAction
	{
		// Token: 0x060044FB RID: 17659 RVA: 0x00177C21 File Offset: 0x00175E21
		public override void Reset()
		{
			this.stringVariable = null;
			this.replace = "";
			this.with = "";
			this.storeResult = null;
			this.everyFrame = false;
		}

		// Token: 0x060044FC RID: 17660 RVA: 0x00177C58 File Offset: 0x00175E58
		public override void OnEnter()
		{
			this.DoReplace();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060044FD RID: 17661 RVA: 0x00177C6E File Offset: 0x00175E6E
		public override void OnUpdate()
		{
			this.DoReplace();
		}

		// Token: 0x060044FE RID: 17662 RVA: 0x00177C78 File Offset: 0x00175E78
		private void DoReplace()
		{
			if (this.stringVariable == null)
			{
				return;
			}
			if (this.storeResult == null)
			{
				return;
			}
			this.storeResult.Value = this.stringVariable.Value.Replace(this.replace.Value, this.with.Value);
		}

		// Token: 0x0400494D RID: 18765
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmString stringVariable;

		// Token: 0x0400494E RID: 18766
		public FsmString replace;

		// Token: 0x0400494F RID: 18767
		public FsmString with;

		// Token: 0x04004950 RID: 18768
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmString storeResult;

		// Token: 0x04004951 RID: 18769
		public bool everyFrame;
	}
}
