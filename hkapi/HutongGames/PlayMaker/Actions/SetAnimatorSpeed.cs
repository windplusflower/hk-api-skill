using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000907 RID: 2311
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Sets the playback speed of the Animator. 1 is normal playback speed")]
	public class SetAnimatorSpeed : FsmStateAction
	{
		// Token: 0x06003341 RID: 13121 RVA: 0x00134C33 File Offset: 0x00132E33
		public override void Reset()
		{
			this.gameObject = null;
			this.speed = null;
			this.everyFrame = false;
		}

		// Token: 0x06003342 RID: 13122 RVA: 0x00134C4C File Offset: 0x00132E4C
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
			this.DoPlaybackSpeed();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003343 RID: 13123 RVA: 0x00134CB0 File Offset: 0x00132EB0
		public override void OnUpdate()
		{
			this.DoPlaybackSpeed();
		}

		// Token: 0x06003344 RID: 13124 RVA: 0x00134CB8 File Offset: 0x00132EB8
		private void DoPlaybackSpeed()
		{
			if (this._animator == null)
			{
				return;
			}
			this._animator.speed = this.speed.Value;
		}

		// Token: 0x040034AC RID: 13484
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The Target. An Animator component is required")]
		public FsmOwnerDefault gameObject;

		// Token: 0x040034AD RID: 13485
		[Tooltip("The playBack speed")]
		public FsmFloat speed;

		// Token: 0x040034AE RID: 13486
		[Tooltip("Repeat every frame. Useful for changing over time.")]
		public bool everyFrame;

		// Token: 0x040034AF RID: 13487
		private Animator _animator;
	}
}
