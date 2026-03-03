using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A45 RID: 2629
	[ActionCategory(ActionCategory.Physics2D)]
	[Tooltip("Set rigidbody 2D interpolation mode to Extrapolate")]
	public class SetInterpolateNone : ComponentAction<Rigidbody2D>
	{
		// Token: 0x060038F7 RID: 14583 RVA: 0x0014CD25 File Offset: 0x0014AF25
		public override void Reset()
		{
			this.gameObject = null;
		}

		// Token: 0x060038F8 RID: 14584 RVA: 0x0014CD2E File Offset: 0x0014AF2E
		public override void OnEnter()
		{
			this.DoSetExtrapolate();
			base.Finish();
		}

		// Token: 0x060038F9 RID: 14585 RVA: 0x0014CD3C File Offset: 0x0014AF3C
		private void DoSetExtrapolate()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (!base.UpdateCache(ownerDefaultTarget))
			{
				return;
			}
			base.rigidbody2d.interpolation = RigidbodyInterpolation2D.None;
		}

		// Token: 0x04003B98 RID: 15256
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody2D))]
		[Tooltip("The GameObject with the Rigidbody2D attached")]
		public FsmOwnerDefault gameObject;
	}
}
