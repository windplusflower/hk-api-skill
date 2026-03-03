using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020008D5 RID: 2261
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Gets the value of ApplyRootMotion of an avatar. If true, root is controlled by animations")]
	public class GetAnimatorApplyRootMotion : FsmStateAction
	{
		// Token: 0x06003256 RID: 12886 RVA: 0x00131B25 File Offset: 0x0012FD25
		public override void Reset()
		{
			this.gameObject = null;
			this.rootMotionApplied = null;
			this.rootMotionIsAppliedEvent = null;
			this.rootMotionIsNotAppliedEvent = null;
		}

		// Token: 0x06003257 RID: 12887 RVA: 0x00131B44 File Offset: 0x0012FD44
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
			this.GetApplyMotionRoot();
			base.Finish();
		}

		// Token: 0x06003258 RID: 12888 RVA: 0x00131BA0 File Offset: 0x0012FDA0
		private void GetApplyMotionRoot()
		{
			if (this._animator != null)
			{
				bool applyRootMotion = this._animator.applyRootMotion;
				this.rootMotionApplied.Value = applyRootMotion;
				if (applyRootMotion)
				{
					base.Fsm.Event(this.rootMotionIsAppliedEvent);
					return;
				}
				base.Fsm.Event(this.rootMotionIsNotAppliedEvent);
			}
		}

		// Token: 0x040033A6 RID: 13222
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The Target. An Animator component is required")]
		public FsmOwnerDefault gameObject;

		// Token: 0x040033A7 RID: 13223
		[ActionSection("Results")]
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Is the rootMotionapplied. If true, root is controlled by animations")]
		public FsmBool rootMotionApplied;

		// Token: 0x040033A8 RID: 13224
		[Tooltip("Event send if the root motion is applied")]
		public FsmEvent rootMotionIsAppliedEvent;

		// Token: 0x040033A9 RID: 13225
		[Tooltip("Event send if the root motion is not applied")]
		public FsmEvent rootMotionIsNotAppliedEvent;

		// Token: 0x040033AA RID: 13226
		private Animator _animator;
	}
}
