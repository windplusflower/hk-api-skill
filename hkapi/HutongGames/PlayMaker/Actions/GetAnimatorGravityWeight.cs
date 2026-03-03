using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020008E3 RID: 2275
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Returns The current gravity weight based on current animations that are played")]
	public class GetAnimatorGravityWeight : FsmStateActionAnimatorBase
	{
		// Token: 0x06003298 RID: 12952 RVA: 0x001329CE File Offset: 0x00130BCE
		public override void Reset()
		{
			base.Reset();
			this.gameObject = null;
			this.gravityWeight = null;
			this.everyFrame = false;
		}

		// Token: 0x06003299 RID: 12953 RVA: 0x001329EC File Offset: 0x00130BEC
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
			this.DoGetGravityWeight();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x0600329A RID: 12954 RVA: 0x00132A50 File Offset: 0x00130C50
		public override void OnActionUpdate()
		{
			this.DoGetGravityWeight();
		}

		// Token: 0x0600329B RID: 12955 RVA: 0x00132A58 File Offset: 0x00130C58
		private void DoGetGravityWeight()
		{
			if (this._animator == null)
			{
				return;
			}
			this.gravityWeight.Value = this._animator.gravityWeight;
		}

		// Token: 0x040033FA RID: 13306
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The target. An Animator component is required")]
		public FsmOwnerDefault gameObject;

		// Token: 0x040033FB RID: 13307
		[ActionSection("Results")]
		[UIHint(UIHint.Variable)]
		[Tooltip("The current gravity weight based on current animations that are played")]
		public FsmFloat gravityWeight;

		// Token: 0x040033FC RID: 13308
		private Animator _animator;
	}
}
