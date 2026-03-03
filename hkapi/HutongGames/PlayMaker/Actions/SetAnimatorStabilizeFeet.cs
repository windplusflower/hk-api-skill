using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000908 RID: 2312
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("If true, automaticaly stabilize feet during transition and blending")]
	public class SetAnimatorStabilizeFeet : FsmStateAction
	{
		// Token: 0x06003346 RID: 13126 RVA: 0x00134CDF File Offset: 0x00132EDF
		public override void Reset()
		{
			this.gameObject = null;
			this.stabilizeFeet = null;
		}

		// Token: 0x06003347 RID: 13127 RVA: 0x00134CF0 File Offset: 0x00132EF0
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
			this.DoStabilizeFeet();
			base.Finish();
		}

		// Token: 0x06003348 RID: 13128 RVA: 0x00134D4C File Offset: 0x00132F4C
		private void DoStabilizeFeet()
		{
			if (this._animator == null)
			{
				return;
			}
			this._animator.stabilizeFeet = this.stabilizeFeet.Value;
		}

		// Token: 0x040034B0 RID: 13488
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The Target. An Animator component is required")]
		public FsmOwnerDefault gameObject;

		// Token: 0x040034B1 RID: 13489
		[Tooltip("If true, automaticaly stabilize feet during transition and blending")]
		public FsmBool stabilizeFeet;

		// Token: 0x040034B2 RID: 13490
		private Animator _animator;
	}
}
