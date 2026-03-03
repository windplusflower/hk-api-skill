using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020008D9 RID: 2265
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Returns the culling of this Animator component. Optionnaly sends events.\nIf true ('AlwaysAnimate'): always animate the entire character. Object is animated even when offscreen.\nIf False ('BasedOnRenderers') animation is disabled when renderers are not visible.")]
	public class GetAnimatorCullingMode : FsmStateAction
	{
		// Token: 0x06003268 RID: 12904 RVA: 0x00131EB2 File Offset: 0x001300B2
		public override void Reset()
		{
			this.gameObject = null;
			this.alwaysAnimate = null;
			this.alwaysAnimateEvent = null;
			this.basedOnRenderersEvent = null;
		}

		// Token: 0x06003269 RID: 12905 RVA: 0x00131ED0 File Offset: 0x001300D0
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
			this.DoCheckCulling();
			base.Finish();
		}

		// Token: 0x0600326A RID: 12906 RVA: 0x00131F2C File Offset: 0x0013012C
		private void DoCheckCulling()
		{
			if (this._animator == null)
			{
				return;
			}
			bool flag = this._animator.cullingMode == AnimatorCullingMode.AlwaysAnimate;
			this.alwaysAnimate.Value = flag;
			if (flag)
			{
				base.Fsm.Event(this.alwaysAnimateEvent);
				return;
			}
			base.Fsm.Event(this.basedOnRenderersEvent);
		}

		// Token: 0x040033BA RID: 13242
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The Target. An Animator component is required")]
		public FsmOwnerDefault gameObject;

		// Token: 0x040033BB RID: 13243
		[ActionSection("Results")]
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("If true, always animate the entire character, else animation is disabled when renderers are not visible")]
		public FsmBool alwaysAnimate;

		// Token: 0x040033BC RID: 13244
		[Tooltip("Event send if culling mode is 'AlwaysAnimate'")]
		public FsmEvent alwaysAnimateEvent;

		// Token: 0x040033BD RID: 13245
		[Tooltip("Event send if culling mode is 'BasedOnRenders'")]
		public FsmEvent basedOnRenderersEvent;

		// Token: 0x040033BE RID: 13246
		private Animator _animator;
	}
}
