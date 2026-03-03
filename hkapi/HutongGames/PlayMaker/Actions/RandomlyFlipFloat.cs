using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C6F RID: 3183
	[ActionCategory(ActionCategory.Math)]
	[Tooltip("50/50 chance to either leave a flaot as is or multiply it by -1")]
	public class RandomlyFlipFloat : FsmStateAction
	{
		// Token: 0x06004289 RID: 17033 RVA: 0x001701F4 File Offset: 0x0016E3F4
		public override void Reset()
		{
			this.storeResult = null;
		}

		// Token: 0x0600428A RID: 17034 RVA: 0x001701FD File Offset: 0x0016E3FD
		public override void OnEnter()
		{
			if ((double)UnityEngine.Random.value >= 0.5)
			{
				this.storeResult.Value = this.storeResult.Value * -1f;
			}
			base.Finish();
		}

		// Token: 0x040046D1 RID: 18129
		[UIHint(UIHint.Variable)]
		public FsmFloat storeResult;
	}
}
