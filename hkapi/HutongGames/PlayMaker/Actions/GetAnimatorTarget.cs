using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020008F8 RID: 2296
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Gets the position and rotation of the target specified by SetTarget(AvatarTarget targetIndex, float targetNormalizedTime)).\nThe position and rotation are only valid when a frame has being evaluated after the SetTarget call")]
	public class GetAnimatorTarget : FsmStateActionAnimatorBase
	{
		// Token: 0x060032F7 RID: 13047 RVA: 0x00133BEE File Offset: 0x00131DEE
		public override void Reset()
		{
			base.Reset();
			this.gameObject = null;
			this.targetPosition = null;
			this.targetRotation = null;
			this.targetGameObject = null;
			this.everyFrame = false;
		}

		// Token: 0x060032F8 RID: 13048 RVA: 0x00133C1C File Offset: 0x00131E1C
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
			GameObject value = this.targetGameObject.Value;
			if (value != null)
			{
				this._transform = value.transform;
			}
			this.DoGetTarget();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060032F9 RID: 13049 RVA: 0x00133CA1 File Offset: 0x00131EA1
		public override void OnActionUpdate()
		{
			this.DoGetTarget();
		}

		// Token: 0x060032FA RID: 13050 RVA: 0x00133CAC File Offset: 0x00131EAC
		private void DoGetTarget()
		{
			if (this._animator == null)
			{
				return;
			}
			this.targetPosition.Value = this._animator.targetPosition;
			this.targetRotation.Value = this._animator.targetRotation;
			if (this._transform != null)
			{
				this._transform.position = this._animator.targetPosition;
				this._transform.rotation = this._animator.targetRotation;
			}
		}

		// Token: 0x0400345D RID: 13405
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The target. An Animator component is required")]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400345E RID: 13406
		[ActionSection("Results")]
		[UIHint(UIHint.Variable)]
		[Tooltip("The target position")]
		public FsmVector3 targetPosition;

		// Token: 0x0400345F RID: 13407
		[UIHint(UIHint.Variable)]
		[Tooltip("The target rotation")]
		public FsmQuaternion targetRotation;

		// Token: 0x04003460 RID: 13408
		[Tooltip("If set, apply the position and rotation to this gameObject")]
		public FsmGameObject targetGameObject;

		// Token: 0x04003461 RID: 13409
		private Animator _animator;

		// Token: 0x04003462 RID: 13410
		private Transform _transform;
	}
}
