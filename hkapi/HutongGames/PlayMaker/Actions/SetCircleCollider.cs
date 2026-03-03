using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000D44 RID: 3396
	[ActionCategory("Physics 2d")]
	[Tooltip("Set BoxCollider2D to active or inactive. Can only be one collider on object. ")]
	public class SetCircleCollider : FsmStateAction
	{
		// Token: 0x06004646 RID: 17990 RVA: 0x0017EFF2 File Offset: 0x0017D1F2
		public override void Reset()
		{
			this.gameObject = null;
			this.active = false;
		}

		// Token: 0x06004647 RID: 17991 RVA: 0x0017F008 File Offset: 0x0017D208
		public override void OnEnter()
		{
			if (this.gameObject != null)
			{
				CircleCollider2D component = base.Fsm.GetOwnerDefaultTarget(this.gameObject).GetComponent<CircleCollider2D>();
				if (component != null)
				{
					component.enabled = this.active.Value;
				}
			}
			base.Finish();
		}

		// Token: 0x04004B23 RID: 19235
		[RequiredField]
		[Tooltip("The particle emitting GameObject")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004B24 RID: 19236
		public FsmBool active;
	}
}
