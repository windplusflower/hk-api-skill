using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000909 RID: 2313
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Sets an AvatarTarget and a targetNormalizedTime for the current state")]
	public class SetAnimatorTarget : FsmStateAction
	{
		// Token: 0x0600334A RID: 13130 RVA: 0x00134D73 File Offset: 0x00132F73
		public override void Reset()
		{
			this.gameObject = null;
			this.avatarTarget = AvatarTarget.Body;
			this.targetNormalizedTime = null;
			this.everyFrame = false;
		}

		// Token: 0x0600334B RID: 13131 RVA: 0x00133D37 File Offset: 0x00131F37
		public override void OnPreprocess()
		{
			base.Fsm.HandleAnimatorMove = true;
		}

		// Token: 0x0600334C RID: 13132 RVA: 0x00134D94 File Offset: 0x00132F94
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
			this.SetTarget();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x0600334D RID: 13133 RVA: 0x00134DF8 File Offset: 0x00132FF8
		public override void DoAnimatorMove()
		{
			this.SetTarget();
		}

		// Token: 0x0600334E RID: 13134 RVA: 0x00134E00 File Offset: 0x00133000
		private void SetTarget()
		{
			if (this._animator != null)
			{
				this._animator.SetTarget(this.avatarTarget, this.targetNormalizedTime.Value);
			}
		}

		// Token: 0x040034B3 RID: 13491
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The target.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x040034B4 RID: 13492
		[Tooltip("The avatar target")]
		public AvatarTarget avatarTarget;

		// Token: 0x040034B5 RID: 13493
		[Tooltip("The current state Time that is queried")]
		public FsmFloat targetNormalizedTime;

		// Token: 0x040034B6 RID: 13494
		[Tooltip("Repeat every frame during OnAnimatorMove. Useful when changing over time.")]
		public bool everyFrame;

		// Token: 0x040034B7 RID: 13495
		private Animator _animator;
	}
}
