using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020008E0 RID: 2272
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Gets the avatar delta position and rotation for the last evaluated frame.")]
	public class GetAnimatorDelta : FsmStateActionAnimatorBase
	{
		// Token: 0x0600328A RID: 12938 RVA: 0x001327AC File Offset: 0x001309AC
		public override void Reset()
		{
			base.Reset();
			this.gameObject = null;
			this.deltaPosition = null;
			this.deltaRotation = null;
		}

		// Token: 0x0600328B RID: 12939 RVA: 0x001327CC File Offset: 0x001309CC
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
			this.DoGetDeltaPosition();
			base.Finish();
		}

		// Token: 0x0600328C RID: 12940 RVA: 0x00132828 File Offset: 0x00130A28
		public override void OnActionUpdate()
		{
			this.DoGetDeltaPosition();
		}

		// Token: 0x0600328D RID: 12941 RVA: 0x00132830 File Offset: 0x00130A30
		private void DoGetDeltaPosition()
		{
			if (this._animator == null)
			{
				return;
			}
			this.deltaPosition.Value = this._animator.deltaPosition;
			this.deltaRotation.Value = this._animator.deltaRotation;
		}

		// Token: 0x040033ED RID: 13293
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The target. An Animator component is required")]
		public FsmOwnerDefault gameObject;

		// Token: 0x040033EE RID: 13294
		[UIHint(UIHint.Variable)]
		[Tooltip("The avatar delta position for the last evaluated frame")]
		public FsmVector3 deltaPosition;

		// Token: 0x040033EF RID: 13295
		[UIHint(UIHint.Variable)]
		[Tooltip("The avatar delta position for the last evaluated frame")]
		public FsmQuaternion deltaRotation;

		// Token: 0x040033F0 RID: 13296
		private Transform _transform;

		// Token: 0x040033F1 RID: 13297
		private Animator _animator;
	}
}
