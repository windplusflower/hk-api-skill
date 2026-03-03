using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C14 RID: 3092
	[ActionCategory(ActionCategory.String)]
	[Tooltip("Gets the Left n characters from a String Variable.")]
	public class GetStringLeft : FsmStateAction
	{
		// Token: 0x060040E0 RID: 16608 RVA: 0x0016B2AB File Offset: 0x001694AB
		public override void Reset()
		{
			this.stringVariable = null;
			this.charCount = 0;
			this.storeResult = null;
			this.everyFrame = false;
		}

		// Token: 0x060040E1 RID: 16609 RVA: 0x0016B2CE File Offset: 0x001694CE
		public override void OnEnter()
		{
			this.DoGetStringLeft();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060040E2 RID: 16610 RVA: 0x0016B2E4 File Offset: 0x001694E4
		public override void OnUpdate()
		{
			this.DoGetStringLeft();
		}

		// Token: 0x060040E3 RID: 16611 RVA: 0x0016B2EC File Offset: 0x001694EC
		private void DoGetStringLeft()
		{
			if (this.stringVariable.IsNone)
			{
				return;
			}
			if (this.storeResult.IsNone)
			{
				return;
			}
			this.storeResult.Value = this.stringVariable.Value.Substring(0, Mathf.Clamp(this.charCount.Value, 0, this.stringVariable.Value.Length));
		}

		// Token: 0x04004527 RID: 17703
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmString stringVariable;

		// Token: 0x04004528 RID: 17704
		[Tooltip("Number of characters to get.")]
		public FsmInt charCount;

		// Token: 0x04004529 RID: 17705
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmString storeResult;

		// Token: 0x0400452A RID: 17706
		[Tooltip("Repeat every frame.")]
		public bool everyFrame;
	}
}
