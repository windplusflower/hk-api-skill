using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A44 RID: 2628
	[ActionCategory(ActionCategory.Physics2D)]
	[Tooltip("Set rigidbody 2D interpolation mode to Interpolate")]
	public class SetInterpolate : ComponentAction<Rigidbody2D>
	{
		// Token: 0x060038F3 RID: 14579 RVA: 0x0014CCD6 File Offset: 0x0014AED6
		public override void Reset()
		{
			this.gameObject = null;
		}

		// Token: 0x060038F4 RID: 14580 RVA: 0x0014CCDF File Offset: 0x0014AEDF
		public override void OnEnter()
		{
			this.DoSetInterpolate();
			base.Finish();
		}

		// Token: 0x060038F5 RID: 14581 RVA: 0x0014CCF0 File Offset: 0x0014AEF0
		private void DoSetInterpolate()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (!base.UpdateCache(ownerDefaultTarget))
			{
				return;
			}
			base.rigidbody2d.interpolation = RigidbodyInterpolation2D.Interpolate;
		}

		// Token: 0x04003B97 RID: 15255
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody2D))]
		[Tooltip("The GameObject with the Rigidbody2D attached")]
		public FsmOwnerDefault gameObject;
	}
}
