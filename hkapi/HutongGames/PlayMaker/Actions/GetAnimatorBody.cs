using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020008D6 RID: 2262
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Gets the avatar body mass center position and rotation. Optionally accepts a GameObject to get the body transform. \nThe position and rotation are local to the gameobject")]
	public class GetAnimatorBody : FsmStateActionAnimatorBase
	{
		// Token: 0x0600325A RID: 12890 RVA: 0x00131BF9 File Offset: 0x0012FDF9
		public override void Reset()
		{
			this.gameObject = null;
			this.bodyPosition = null;
			this.bodyRotation = null;
			this.bodyGameObject = null;
			this.everyFrame = false;
		}

		// Token: 0x0600325B RID: 12891 RVA: 0x00131C20 File Offset: 0x0012FE20
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

		// Token: 0x0600325C RID: 12892 RVA: 0x00131CA5 File Offset: 0x0012FEA5
		public override void OnActionUpdate()
		{
			this.DoGetBodyPosition();
		}

		// Token: 0x0600325D RID: 12893 RVA: 0x00131CB0 File Offset: 0x0012FEB0
		private void DoGetBodyPosition()
		{
			if (this._animator == null)
			{
				return;
			}
			this.bodyPosition.Value = this._animator.bodyPosition;
			this.bodyRotation.Value = this._animator.bodyRotation;
			if (this._transform != null)
			{
				this._transform.position = this._animator.bodyPosition;
				this._transform.rotation = this._animator.bodyRotation;
			}
		}

		// Token: 0x040033AB RID: 13227
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The target. An Animator component is required")]
		public FsmOwnerDefault gameObject;

		// Token: 0x040033AC RID: 13228
		[ActionSection("Results")]
		[UIHint(UIHint.Variable)]
		[Tooltip("The avatar body mass center")]
		public FsmVector3 bodyPosition;

		// Token: 0x040033AD RID: 13229
		[UIHint(UIHint.Variable)]
		[Tooltip("The avatar body mass center")]
		public FsmQuaternion bodyRotation;

		// Token: 0x040033AE RID: 13230
		[Tooltip("If set, apply the body mass center position and rotation to this gameObject")]
		public FsmGameObject bodyGameObject;

		// Token: 0x040033AF RID: 13231
		private Animator _animator;

		// Token: 0x040033B0 RID: 13232
		private Transform _transform;
	}
}
