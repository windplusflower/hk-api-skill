using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000905 RID: 2309
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Sets the playback speed of the Animator. 1 is normal playback speed")]
	public class SetAnimatorPlayBackSpeed : FsmStateAction
	{
		// Token: 0x06003337 RID: 13111 RVA: 0x00134ADB File Offset: 0x00132CDB
		public override void Reset()
		{
			this.gameObject = null;
			this.playBackSpeed = null;
			this.everyFrame = false;
		}

		// Token: 0x06003338 RID: 13112 RVA: 0x00134AF4 File Offset: 0x00132CF4
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
			this.DoPlayBackSpeed();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003339 RID: 13113 RVA: 0x00134B58 File Offset: 0x00132D58
		public override void OnUpdate()
		{
			this.DoPlayBackSpeed();
		}

		// Token: 0x0600333A RID: 13114 RVA: 0x00134B60 File Offset: 0x00132D60
		private void DoPlayBackSpeed()
		{
			if (this._animator == null)
			{
				return;
			}
			this._animator.speed = this.playBackSpeed.Value;
		}

		// Token: 0x040034A4 RID: 13476
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The Target. An Animator component is required")]
		public FsmOwnerDefault gameObject;

		// Token: 0x040034A5 RID: 13477
		[Tooltip("If true, automaticly stabilize feet during transition and blending")]
		public FsmFloat playBackSpeed;

		// Token: 0x040034A6 RID: 13478
		[Tooltip("Repeat every frame. Useful for changing over time.")]
		public bool everyFrame;

		// Token: 0x040034A7 RID: 13479
		private Animator _animator;
	}
}
