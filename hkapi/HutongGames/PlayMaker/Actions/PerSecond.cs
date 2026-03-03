using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C45 RID: 3141
	[ActionCategory(ActionCategory.Time)]
	[Tooltip("Multiplies a Float by Time.deltaTime to use in frame-rate independent operations. E.g., 10 becomes 10 units per second.")]
	public class PerSecond : FsmStateAction
	{
		// Token: 0x060041C0 RID: 16832 RVA: 0x0016DCE5 File Offset: 0x0016BEE5
		public override void Reset()
		{
			this.floatValue = null;
			this.storeResult = null;
			this.everyFrame = false;
		}

		// Token: 0x060041C1 RID: 16833 RVA: 0x0016DCFC File Offset: 0x0016BEFC
		public override void OnEnter()
		{
			this.DoPerSecond();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060041C2 RID: 16834 RVA: 0x0016DD12 File Offset: 0x0016BF12
		public override void OnUpdate()
		{
			this.DoPerSecond();
		}

		// Token: 0x060041C3 RID: 16835 RVA: 0x0016DD1A File Offset: 0x0016BF1A
		private void DoPerSecond()
		{
			if (this.storeResult == null)
			{
				return;
			}
			this.storeResult.Value = this.floatValue.Value * Time.deltaTime;
		}

		// Token: 0x04004624 RID: 17956
		[RequiredField]
		public FsmFloat floatValue;

		// Token: 0x04004625 RID: 17957
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmFloat storeResult;

		// Token: 0x04004626 RID: 17958
		public bool everyFrame;
	}
}
