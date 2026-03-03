using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A51 RID: 2641
	[ActionCategory("GameObject")]
	[Tooltip("Set sprite renderer to active or inactive. Can only be one sprite renderer on object. ")]
	public class SetSpriteRenderer : FsmStateAction
	{
		// Token: 0x06003920 RID: 14624 RVA: 0x0014D29C File Offset: 0x0014B49C
		public override void Reset()
		{
			this.gameObject = null;
			this.active = false;
		}

		// Token: 0x06003921 RID: 14625 RVA: 0x0014D2B4 File Offset: 0x0014B4B4
		public override void OnEnter()
		{
			if (this.gameObject != null)
			{
				GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
				if (ownerDefaultTarget != null)
				{
					SpriteRenderer component = ownerDefaultTarget.GetComponent<SpriteRenderer>();
					if (component != null)
					{
						component.enabled = this.active.Value;
					}
				}
			}
			base.Finish();
		}

		// Token: 0x04003BB6 RID: 15286
		[RequiredField]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003BB7 RID: 15287
		public FsmBool active;
	}
}
