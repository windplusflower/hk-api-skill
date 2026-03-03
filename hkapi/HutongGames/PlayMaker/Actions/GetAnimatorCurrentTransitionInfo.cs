using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020008DD RID: 2269
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Gets the current transition information on a specified layer. Only valid when during a transition.")]
	public class GetAnimatorCurrentTransitionInfo : FsmStateActionAnimatorBase
	{
		// Token: 0x0600327B RID: 12923 RVA: 0x00132401 File Offset: 0x00130601
		public override void Reset()
		{
			base.Reset();
			this.gameObject = null;
			this.layerIndex = null;
			this.name = null;
			this.nameHash = null;
			this.userNameHash = null;
			this.normalizedTime = null;
			this.everyFrame = false;
		}

		// Token: 0x0600327C RID: 12924 RVA: 0x0013243C File Offset: 0x0013063C
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
			this.GetTransitionInfo();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x0600327D RID: 12925 RVA: 0x001324A0 File Offset: 0x001306A0
		public override void OnActionUpdate()
		{
			this.GetTransitionInfo();
		}

		// Token: 0x0600327E RID: 12926 RVA: 0x001324A8 File Offset: 0x001306A8
		private void GetTransitionInfo()
		{
			if (this._animator != null)
			{
				AnimatorTransitionInfo animatorTransitionInfo = this._animator.GetAnimatorTransitionInfo(this.layerIndex.Value);
				if (!this.name.IsNone)
				{
					this.name.Value = this._animator.GetLayerName(this.layerIndex.Value);
				}
				if (!this.nameHash.IsNone)
				{
					this.nameHash.Value = animatorTransitionInfo.nameHash;
				}
				if (!this.userNameHash.IsNone)
				{
					this.userNameHash.Value = animatorTransitionInfo.userNameHash;
				}
				if (!this.normalizedTime.IsNone)
				{
					this.normalizedTime.Value = animatorTransitionInfo.normalizedTime;
				}
			}
		}

		// Token: 0x040033D8 RID: 13272
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The target. An Animator component is required")]
		public FsmOwnerDefault gameObject;

		// Token: 0x040033D9 RID: 13273
		[RequiredField]
		[Tooltip("The layer's index")]
		public FsmInt layerIndex;

		// Token: 0x040033DA RID: 13274
		[ActionSection("Results")]
		[UIHint(UIHint.Variable)]
		[Tooltip("The unique name of the Transition")]
		public FsmString name;

		// Token: 0x040033DB RID: 13275
		[UIHint(UIHint.Variable)]
		[Tooltip("The unique name of the Transition")]
		public FsmInt nameHash;

		// Token: 0x040033DC RID: 13276
		[UIHint(UIHint.Variable)]
		[Tooltip("The user-specidied name of the Transition")]
		public FsmInt userNameHash;

		// Token: 0x040033DD RID: 13277
		[UIHint(UIHint.Variable)]
		[Tooltip("Normalized time of the Transition")]
		public FsmFloat normalizedTime;

		// Token: 0x040033DE RID: 13278
		private Animator _animator;
	}
}
