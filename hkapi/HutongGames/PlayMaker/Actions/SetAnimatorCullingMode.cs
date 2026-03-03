using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020008FD RID: 2301
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Controls culling of this Animator component.\nIf true, set to 'AlwaysAnimate': always animate the entire character. Object is animated even when offscreen.\nIf False, set to 'BasedOnRenderes' or CullUpdateTransforms ( On Unity 5) animation is disabled when renderers are not visible.")]
	public class SetAnimatorCullingMode : FsmStateAction
	{
		// Token: 0x06003310 RID: 13072 RVA: 0x00134122 File Offset: 0x00132322
		public override void Reset()
		{
			this.gameObject = null;
			this.alwaysAnimate = null;
		}

		// Token: 0x06003311 RID: 13073 RVA: 0x00134134 File Offset: 0x00132334
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
			this.SetCullingMode();
			base.Finish();
		}

		// Token: 0x06003312 RID: 13074 RVA: 0x00134190 File Offset: 0x00132390
		private void SetCullingMode()
		{
			if (this._animator == null)
			{
				return;
			}
			this._animator.cullingMode = (this.alwaysAnimate.Value ? AnimatorCullingMode.AlwaysAnimate : AnimatorCullingMode.CullUpdateTransforms);
		}

		// Token: 0x04003476 RID: 13430
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The Target. An Animator component is required")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003477 RID: 13431
		[Tooltip("If true, always animate the entire character, else animation is disabled when renderers are not visible")]
		public FsmBool alwaysAnimate;

		// Token: 0x04003478 RID: 13432
		private Animator _animator;
	}
}
