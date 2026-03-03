using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A40 RID: 2624
	[ActionCategory(ActionCategory.Physics2D)]
	[Tooltip("Set rigidbody 2D interpolation mode to Extrapolate")]
	public class SetExtrapolate : ComponentAction<Rigidbody2D>
	{
		// Token: 0x060038E3 RID: 14563 RVA: 0x0014CA04 File Offset: 0x0014AC04
		public override void Reset()
		{
			this.gameObject = null;
		}

		// Token: 0x060038E4 RID: 14564 RVA: 0x0014CA0D File Offset: 0x0014AC0D
		public override void OnEnter()
		{
			this.DoSetExtrapolate();
			base.Finish();
		}

		// Token: 0x060038E5 RID: 14565 RVA: 0x0014CA1C File Offset: 0x0014AC1C
		private void DoSetExtrapolate()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (!base.UpdateCache(ownerDefaultTarget))
			{
				return;
			}
			base.rigidbody2d.interpolation = RigidbodyInterpolation2D.Extrapolate;
		}

		// Token: 0x04003B8A RID: 15242
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody2D))]
		[Tooltip("The GameObject with the Rigidbody2D attached")]
		public FsmOwnerDefault gameObject;
	}
}
