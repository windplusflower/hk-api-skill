using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C15 RID: 3093
	[ActionCategory(ActionCategory.String)]
	[Tooltip("Gets the Length of a String.")]
	public class GetStringLength : FsmStateAction
	{
		// Token: 0x060040E5 RID: 16613 RVA: 0x0016B352 File Offset: 0x00169552
		public override void Reset()
		{
			this.stringVariable = null;
			this.storeResult = null;
			this.everyFrame = false;
		}

		// Token: 0x060040E6 RID: 16614 RVA: 0x0016B369 File Offset: 0x00169569
		public override void OnEnter()
		{
			this.DoGetStringLength();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060040E7 RID: 16615 RVA: 0x0016B37F File Offset: 0x0016957F
		public override void OnUpdate()
		{
			this.DoGetStringLength();
		}

		// Token: 0x060040E8 RID: 16616 RVA: 0x0016B387 File Offset: 0x00169587
		private void DoGetStringLength()
		{
			if (this.stringVariable == null)
			{
				return;
			}
			if (this.storeResult == null)
			{
				return;
			}
			this.storeResult.Value = this.stringVariable.Value.Length;
		}

		// Token: 0x0400452B RID: 17707
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmString stringVariable;

		// Token: 0x0400452C RID: 17708
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmInt storeResult;

		// Token: 0x0400452D RID: 17709
		public bool everyFrame;
	}
}
