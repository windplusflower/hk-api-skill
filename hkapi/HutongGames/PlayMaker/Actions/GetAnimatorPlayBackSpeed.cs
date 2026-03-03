using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020008F3 RID: 2291
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Gets the playback speed of the Animator. 1 is normal playback speed")]
	public class GetAnimatorPlayBackSpeed : FsmStateAction
	{
		// Token: 0x060032DE RID: 13022 RVA: 0x001337FE File Offset: 0x001319FE
		public override void Reset()
		{
			this.gameObject = null;
			this.playBackSpeed = null;
			this.everyFrame = false;
		}

		// Token: 0x060032DF RID: 13023 RVA: 0x00133818 File Offset: 0x00131A18
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
			this.GetPlayBackSpeed();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060032E0 RID: 13024 RVA: 0x0013387C File Offset: 0x00131A7C
		public override void OnUpdate()
		{
			this.GetPlayBackSpeed();
		}

		// Token: 0x060032E1 RID: 13025 RVA: 0x00133884 File Offset: 0x00131A84
		private void GetPlayBackSpeed()
		{
			if (this._animator != null)
			{
				this.playBackSpeed.Value = this._animator.speed;
			}
		}

		// Token: 0x04003448 RID: 13384
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The Target. An Animator component is required")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003449 RID: 13385
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The playBack speed of the animator. 1 is normal playback speed")]
		public FsmFloat playBackSpeed;

		// Token: 0x0400344A RID: 13386
		[Tooltip("Repeat every frame. Useful when value is subject to change over time.")]
		public bool everyFrame;

		// Token: 0x0400344B RID: 13387
		private Animator _animator;
	}
}
