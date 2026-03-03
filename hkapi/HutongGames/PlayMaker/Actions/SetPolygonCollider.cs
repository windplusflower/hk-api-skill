using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A50 RID: 2640
	[ActionCategory("Physics 2d")]
	[Tooltip("Set PolygonCollider to active or inactive. Can only be one collider on object. ")]
	public class SetPolygonCollider : FsmStateAction
	{
		// Token: 0x0600391D RID: 14621 RVA: 0x0014D23A File Offset: 0x0014B43A
		public override void Reset()
		{
			this.gameObject = null;
			this.active = false;
		}

		// Token: 0x0600391E RID: 14622 RVA: 0x0014D250 File Offset: 0x0014B450
		public override void OnEnter()
		{
			if (this.gameObject != null)
			{
				PolygonCollider2D component = base.Fsm.GetOwnerDefaultTarget(this.gameObject).GetComponent<PolygonCollider2D>();
				if (component != null)
				{
					component.enabled = this.active.Value;
				}
			}
			base.Finish();
		}

		// Token: 0x04003BB4 RID: 15284
		[RequiredField]
		[Tooltip("The particle emitting GameObject")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003BB5 RID: 15285
		public FsmBool active;
	}
}
