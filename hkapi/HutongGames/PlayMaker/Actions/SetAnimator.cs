using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x0200098E RID: 2446
	public class SetAnimator : FsmStateAction
	{
		// Token: 0x060035AE RID: 13742 RVA: 0x0013D117 File Offset: 0x0013B317
		public override void Reset()
		{
			this.target = null;
			this.active = null;
		}

		// Token: 0x060035AF RID: 13743 RVA: 0x0013D128 File Offset: 0x0013B328
		public override void OnEnter()
		{
			GameObject safe = this.target.GetSafe(this);
			if (safe)
			{
				Animator component = safe.GetComponent<Animator>();
				if (component)
				{
					component.enabled = this.active.Value;
				}
			}
			base.Finish();
		}

		// Token: 0x04003740 RID: 14144
		public FsmOwnerDefault target;

		// Token: 0x04003741 RID: 14145
		public FsmBool active;
	}
}
