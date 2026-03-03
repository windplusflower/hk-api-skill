using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020008F7 RID: 2295
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Gets the playback speed of the Animator. 1 is normal playback speed")]
	public class GetAnimatorSpeed : FsmStateActionAnimatorBase
	{
		// Token: 0x060032F2 RID: 13042 RVA: 0x00133B3E File Offset: 0x00131D3E
		public override void Reset()
		{
			base.Reset();
			this.gameObject = null;
			this.speed = null;
			this.everyFrame = false;
		}

		// Token: 0x060032F3 RID: 13043 RVA: 0x00133B5C File Offset: 0x00131D5C
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
			this.GetPlaybackSpeed();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060032F4 RID: 13044 RVA: 0x00133BC0 File Offset: 0x00131DC0
		public override void OnActionUpdate()
		{
			this.GetPlaybackSpeed();
		}

		// Token: 0x060032F5 RID: 13045 RVA: 0x00133BC8 File Offset: 0x00131DC8
		private void GetPlaybackSpeed()
		{
			if (this._animator != null)
			{
				this.speed.Value = this._animator.speed;
			}
		}

		// Token: 0x0400345A RID: 13402
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The Target. An Animator component is required")]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400345B RID: 13403
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The playBack speed of the animator. 1 is normal playback speed")]
		public FsmFloat speed;

		// Token: 0x0400345C RID: 13404
		private Animator _animator;
	}
}
