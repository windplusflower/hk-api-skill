using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x0200098B RID: 2443
	[ActionCategory("Trail Renderer")]
	[Tooltip("Set trail renderer parameters")]
	public class ActivateTrailRenderer : FsmStateAction
	{
		// Token: 0x060035A0 RID: 13728 RVA: 0x0013CD44 File Offset: 0x0013AF44
		public override void Reset()
		{
			this.gameObject = null;
			this.activate = null;
		}

		// Token: 0x060035A1 RID: 13729 RVA: 0x0013CD54 File Offset: 0x0013AF54
		public override void OnEnter()
		{
			if (this.gameObject != null)
			{
				base.Fsm.GetOwnerDefaultTarget(this.gameObject).GetComponent<TrailRenderer>().enabled = this.activate.Value;
				base.Finish();
				return;
			}
			base.Finish();
		}

		// Token: 0x0400372E RID: 14126
		[RequiredField]
		[Tooltip("The particle emitting GameObject")]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400372F RID: 14127
		public FsmBool activate;
	}
}
