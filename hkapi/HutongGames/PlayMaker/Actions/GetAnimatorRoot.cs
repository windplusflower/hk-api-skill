using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020008F6 RID: 2294
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Gets the avatar body mass center position and rotation.Optionally accept a GameObject to get the body transform. \nThe position and rotation are local to the gameobject")]
	public class GetAnimatorRoot : FsmStateActionAnimatorBase
	{
		// Token: 0x060032ED RID: 13037 RVA: 0x00133A06 File Offset: 0x00131C06
		public override void Reset()
		{
			base.Reset();
			this.gameObject = null;
			this.rootPosition = null;
			this.rootRotation = null;
			this.bodyGameObject = null;
		}

		// Token: 0x060032EE RID: 13038 RVA: 0x00133A2C File Offset: 0x00131C2C
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
			GameObject value = this.bodyGameObject.Value;
			if (value != null)
			{
				this._transform = value.transform;
			}
			this.DoGetBodyPosition();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060032EF RID: 13039 RVA: 0x00133AB1 File Offset: 0x00131CB1
		public override void OnActionUpdate()
		{
			this.DoGetBodyPosition();
		}

		// Token: 0x060032F0 RID: 13040 RVA: 0x00133ABC File Offset: 0x00131CBC
		private void DoGetBodyPosition()
		{
			if (this._animator == null)
			{
				return;
			}
			this.rootPosition.Value = this._animator.rootPosition;
			this.rootRotation.Value = this._animator.rootRotation;
			if (this._transform != null)
			{
				this._transform.position = this._animator.rootPosition;
				this._transform.rotation = this._animator.rootRotation;
			}
		}

		// Token: 0x04003454 RID: 13396
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The target.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003455 RID: 13397
		[ActionSection("Results")]
		[UIHint(UIHint.Variable)]
		[Tooltip("The avatar body mass center")]
		public FsmVector3 rootPosition;

		// Token: 0x04003456 RID: 13398
		[UIHint(UIHint.Variable)]
		[Tooltip("The avatar body mass center")]
		public FsmQuaternion rootRotation;

		// Token: 0x04003457 RID: 13399
		[Tooltip("If set, apply the body mass center position and rotation to this gameObject")]
		public FsmGameObject bodyGameObject;

		// Token: 0x04003458 RID: 13400
		private Animator _animator;

		// Token: 0x04003459 RID: 13401
		private Transform _transform;
	}
}
