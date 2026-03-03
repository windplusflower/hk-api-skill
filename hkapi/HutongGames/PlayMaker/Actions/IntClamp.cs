using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C2D RID: 3117
	[ActionCategory(ActionCategory.Math)]
	[Tooltip("Clamp the value of an Integer Variable to a Min/Max range.")]
	public class IntClamp : FsmStateAction
	{
		// Token: 0x06004150 RID: 16720 RVA: 0x0016C362 File Offset: 0x0016A562
		public override void Reset()
		{
			this.intVariable = null;
			this.minValue = null;
			this.maxValue = null;
			this.everyFrame = false;
		}

		// Token: 0x06004151 RID: 16721 RVA: 0x0016C380 File Offset: 0x0016A580
		public override void OnEnter()
		{
			this.DoClamp();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004152 RID: 16722 RVA: 0x0016C396 File Offset: 0x0016A596
		public override void OnUpdate()
		{
			this.DoClamp();
		}

		// Token: 0x06004153 RID: 16723 RVA: 0x0016C39E File Offset: 0x0016A59E
		private void DoClamp()
		{
			this.intVariable.Value = Mathf.Clamp(this.intVariable.Value, this.minValue.Value, this.maxValue.Value);
		}

		// Token: 0x04004590 RID: 17808
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmInt intVariable;

		// Token: 0x04004591 RID: 17809
		[RequiredField]
		public FsmInt minValue;

		// Token: 0x04004592 RID: 17810
		[RequiredField]
		public FsmInt maxValue;

		// Token: 0x04004593 RID: 17811
		public bool everyFrame;
	}
}
