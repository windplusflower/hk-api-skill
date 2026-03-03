using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020008FB RID: 2299
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Sets the position and rotation of the body. A GameObject can be set to control the position and rotation, or it can be manually expressed.")]
	public class SetAnimatorBody : FsmStateAction
	{
		// Token: 0x06003305 RID: 13061 RVA: 0x00133E7B File Offset: 0x0013207B
		public override void Reset()
		{
			this.gameObject = null;
			this.target = null;
			this.position = new FsmVector3
			{
				UseVariable = true
			};
			this.rotation = new FsmQuaternion
			{
				UseVariable = true
			};
			this.everyFrame = false;
		}

		// Token: 0x06003306 RID: 13062 RVA: 0x00133EB6 File Offset: 0x001320B6
		public override void OnPreprocess()
		{
			base.Fsm.HandleAnimatorIK = true;
		}

		// Token: 0x06003307 RID: 13063 RVA: 0x00133EC4 File Offset: 0x001320C4
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
			GameObject value = this.target.Value;
			if (value != null)
			{
				this._transform = value.transform;
			}
		}

		// Token: 0x06003308 RID: 13064 RVA: 0x00133F35 File Offset: 0x00132135
		public override void DoAnimatorIK(int layerIndex)
		{
			this.DoSetBody();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003309 RID: 13065 RVA: 0x00133F4C File Offset: 0x0013214C
		private void DoSetBody()
		{
			if (this._animator == null)
			{
				return;
			}
			if (!(this._transform != null))
			{
				if (!this.position.IsNone)
				{
					this._animator.bodyPosition = this.position.Value;
				}
				if (!this.rotation.IsNone)
				{
					this._animator.bodyRotation = this.rotation.Value;
				}
				return;
			}
			if (this.position.IsNone)
			{
				this._animator.bodyPosition = this._transform.position;
			}
			else
			{
				this._animator.bodyPosition = this._transform.position + this.position.Value;
			}
			if (this.rotation.IsNone)
			{
				this._animator.bodyRotation = this._transform.rotation;
				return;
			}
			this._animator.bodyRotation = this._transform.rotation * this.rotation.Value;
		}

		// Token: 0x0400346A RID: 13418
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The target. An Animator component is required")]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400346B RID: 13419
		[Tooltip("The gameObject target of the ik goal")]
		public FsmGameObject target;

		// Token: 0x0400346C RID: 13420
		[Tooltip("The position of the ik goal. If Goal GameObject set, position is used as an offset from Goal")]
		public FsmVector3 position;

		// Token: 0x0400346D RID: 13421
		[Tooltip("The rotation of the ik goal.If Goal GameObject set, rotation is used as an offset from Goal")]
		public FsmQuaternion rotation;

		// Token: 0x0400346E RID: 13422
		[Tooltip("Repeat every frame.")]
		public bool everyFrame;

		// Token: 0x0400346F RID: 13423
		private Animator _animator;

		// Token: 0x04003470 RID: 13424
		private Transform _transform;
	}
}
