using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A3E RID: 2622
	[ActionCategory("Physics 2d")]
	[Tooltip("Set BoxCollider2D to active or inactive. Can only be one collider on object. ")]
	public class SetBoxColliderTrigger : FsmStateAction
	{
		// Token: 0x060038DD RID: 14557 RVA: 0x0014C93E File Offset: 0x0014AB3E
		public override void Reset()
		{
			this.gameObject = null;
			this.trigger = false;
		}

		// Token: 0x060038DE RID: 14558 RVA: 0x0014C954 File Offset: 0x0014AB54
		public override void OnEnter()
		{
			if (this.gameObject != null)
			{
				BoxCollider2D component = base.Fsm.GetOwnerDefaultTarget(this.gameObject).GetComponent<BoxCollider2D>();
				if (component != null)
				{
					component.isTrigger = this.trigger.Value;
				}
			}
			base.Finish();
		}

		// Token: 0x04003B86 RID: 15238
		[RequiredField]
		[Tooltip("The particle emitting GameObject")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003B87 RID: 15239
		public FsmBool trigger;
	}
}
