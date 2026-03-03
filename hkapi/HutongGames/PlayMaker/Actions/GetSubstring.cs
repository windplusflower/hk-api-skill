using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C17 RID: 3095
	[ActionCategory(ActionCategory.String)]
	[Tooltip("Gets a sub-string from a String Variable.")]
	public class GetSubstring : FsmStateAction
	{
		// Token: 0x060040EF RID: 16623 RVA: 0x0016B45F File Offset: 0x0016965F
		public override void Reset()
		{
			this.stringVariable = null;
			this.startIndex = 0;
			this.length = 1;
			this.storeResult = null;
			this.everyFrame = false;
		}

		// Token: 0x060040F0 RID: 16624 RVA: 0x0016B48E File Offset: 0x0016968E
		public override void OnEnter()
		{
			this.DoGetSubstring();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060040F1 RID: 16625 RVA: 0x0016B4A4 File Offset: 0x001696A4
		public override void OnUpdate()
		{
			this.DoGetSubstring();
		}

		// Token: 0x060040F2 RID: 16626 RVA: 0x0016B4AC File Offset: 0x001696AC
		private void DoGetSubstring()
		{
			if (this.stringVariable == null)
			{
				return;
			}
			if (this.storeResult == null)
			{
				return;
			}
			this.storeResult.Value = this.stringVariable.Value.Substring(this.startIndex.Value, this.length.Value);
		}

		// Token: 0x04004532 RID: 17714
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmString stringVariable;

		// Token: 0x04004533 RID: 17715
		[RequiredField]
		public FsmInt startIndex;

		// Token: 0x04004534 RID: 17716
		[RequiredField]
		public FsmInt length;

		// Token: 0x04004535 RID: 17717
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmString storeResult;

		// Token: 0x04004536 RID: 17718
		public bool everyFrame;
	}
}
