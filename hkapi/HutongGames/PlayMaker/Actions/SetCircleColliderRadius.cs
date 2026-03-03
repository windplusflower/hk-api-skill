using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000D45 RID: 3397
	[ActionCategory("Physics 2d")]
	[Tooltip("Set BoxCollider2D to active or inactive. Can only be one collider on object. ")]
	public class SetCircleColliderRadius : FsmStateAction
	{
		// Token: 0x06004649 RID: 17993 RVA: 0x0017F054 File Offset: 0x0017D254
		public override void Reset()
		{
			this.gameObject = null;
			this.radius = null;
		}

		// Token: 0x0600464A RID: 17994 RVA: 0x0017F064 File Offset: 0x0017D264
		public override void OnEnter()
		{
			this.SetRadius();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x0600464B RID: 17995 RVA: 0x0017F07A File Offset: 0x0017D27A
		public override void OnUpdate()
		{
			this.SetRadius();
		}

		// Token: 0x0600464C RID: 17996 RVA: 0x0017F084 File Offset: 0x0017D284
		private void SetRadius()
		{
			if (this.gameObject != null)
			{
				CircleCollider2D component = base.Fsm.GetOwnerDefaultTarget(this.gameObject).GetComponent<CircleCollider2D>();
				if (component != null)
				{
					component.radius = this.radius.Value;
				}
			}
		}

		// Token: 0x04004B25 RID: 19237
		[RequiredField]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004B26 RID: 19238
		public FsmFloat radius;

		// Token: 0x04004B27 RID: 19239
		public bool everyFrame;
	}
}
