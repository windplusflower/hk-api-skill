using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BEF RID: 3055
	[ActionCategory(ActionCategory.GameObject)]
	[Tooltip("Gets the parent of a Game Object's parent (the grandparent).")]
	public class GetGrandparent : FsmStateAction
	{
		// Token: 0x06004049 RID: 16457 RVA: 0x00169F4A File Offset: 0x0016814A
		public override void Reset()
		{
			this.gameObject = null;
			this.storeResult = null;
		}

		// Token: 0x0600404A RID: 16458 RVA: 0x00169F5C File Offset: 0x0016815C
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget != null)
			{
				this.storeResult.Value = ((ownerDefaultTarget.transform.parent.parent == null) ? null : ownerDefaultTarget.transform.parent.parent.gameObject);
			}
			else
			{
				this.storeResult.Value = null;
			}
			base.Finish();
		}

		// Token: 0x040044AE RID: 17582
		[RequiredField]
		public FsmOwnerDefault gameObject;

		// Token: 0x040044AF RID: 17583
		[UIHint(UIHint.Variable)]
		public FsmGameObject storeResult;
	}
}
