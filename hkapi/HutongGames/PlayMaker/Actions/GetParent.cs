using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C04 RID: 3076
	[ActionCategory(ActionCategory.GameObject)]
	[Tooltip("Gets the Parent of a Game Object.")]
	public class GetParent : FsmStateAction
	{
		// Token: 0x0600409C RID: 16540 RVA: 0x0016A907 File Offset: 0x00168B07
		public override void Reset()
		{
			this.gameObject = null;
			this.storeResult = null;
		}

		// Token: 0x0600409D RID: 16541 RVA: 0x0016A918 File Offset: 0x00168B18
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget != null)
			{
				this.storeResult.Value = ((ownerDefaultTarget.transform.parent == null) ? null : ownerDefaultTarget.transform.parent.gameObject);
			}
			else
			{
				this.storeResult.Value = null;
			}
			base.Finish();
		}

		// Token: 0x040044EF RID: 17647
		[RequiredField]
		public FsmOwnerDefault gameObject;

		// Token: 0x040044F0 RID: 17648
		[UIHint(UIHint.Variable)]
		public FsmGameObject storeResult;
	}
}
