using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020008FA RID: 2298
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Set Apply Root Motion: If true, Root is controlled by animations")]
	public class SetAnimatorApplyRootMotion : FsmStateAction
	{
		// Token: 0x06003301 RID: 13057 RVA: 0x00133DE8 File Offset: 0x00131FE8
		public override void Reset()
		{
			this.gameObject = null;
			this.applyRootMotion = null;
		}

		// Token: 0x06003302 RID: 13058 RVA: 0x00133DF8 File Offset: 0x00131FF8
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				base.Finish();
				return;
			}
			this._animator = ownerDefaultTarget.GetComponent<Animator>();
			if (this._animator == null)
			{
				base.Finish();
				return;
			}
			this.DoApplyRootMotion();
			base.Finish();
		}

		// Token: 0x06003303 RID: 13059 RVA: 0x00133E54 File Offset: 0x00132054
		private void DoApplyRootMotion()
		{
			if (this._animator == null)
			{
				return;
			}
			this._animator.applyRootMotion = this.applyRootMotion.Value;
		}

		// Token: 0x04003467 RID: 13415
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The Target. An Animator component is required")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003468 RID: 13416
		[Tooltip("If true, Root is controlled by animations")]
		public FsmBool applyRootMotion;

		// Token: 0x04003469 RID: 13417
		private Animator _animator;
	}
}
