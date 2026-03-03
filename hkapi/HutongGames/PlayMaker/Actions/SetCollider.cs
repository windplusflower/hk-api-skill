using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A3F RID: 2623
	[ActionCategory("Physics 2d")]
	[Tooltip("Set BoxCollider2D to active or inactive. Can only be one collider on object. ")]
	public class SetCollider : FsmStateAction
	{
		// Token: 0x060038E0 RID: 14560 RVA: 0x0014C9A0 File Offset: 0x0014ABA0
		public override void Reset()
		{
			this.gameObject = null;
			this.active = false;
		}

		// Token: 0x060038E1 RID: 14561 RVA: 0x0014C9B8 File Offset: 0x0014ABB8
		public override void OnEnter()
		{
			if (this.gameObject != null)
			{
				BoxCollider2D component = base.Fsm.GetOwnerDefaultTarget(this.gameObject).GetComponent<BoxCollider2D>();
				if (component != null)
				{
					component.enabled = this.active.Value;
				}
			}
			base.Finish();
		}

		// Token: 0x04003B88 RID: 15240
		[RequiredField]
		[Tooltip("The particle emitting GameObject")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003B89 RID: 15241
		public FsmBool active;
	}
}
