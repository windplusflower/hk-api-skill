using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000906 RID: 2310
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Sets the playback position in the recording buffer. When in playback mode (use AnimatorStartPlayback), this value is used for controlling the current playback position in the buffer (in seconds). The value can range between recordingStartTime and recordingStopTime ")]
	public class SetAnimatorPlayBackTime : FsmStateAction
	{
		// Token: 0x0600333C RID: 13116 RVA: 0x00134B87 File Offset: 0x00132D87
		public override void Reset()
		{
			this.gameObject = null;
			this.playbackTime = null;
			this.everyFrame = false;
		}

		// Token: 0x0600333D RID: 13117 RVA: 0x00134BA0 File Offset: 0x00132DA0
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
			this.DoPlaybackTime();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x0600333E RID: 13118 RVA: 0x00134C04 File Offset: 0x00132E04
		public override void OnUpdate()
		{
			this.DoPlaybackTime();
		}

		// Token: 0x0600333F RID: 13119 RVA: 0x00134C0C File Offset: 0x00132E0C
		private void DoPlaybackTime()
		{
			if (this._animator == null)
			{
				return;
			}
			this._animator.playbackTime = this.playbackTime.Value;
		}

		// Token: 0x040034A8 RID: 13480
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The Target. An Animator component is required")]
		public FsmOwnerDefault gameObject;

		// Token: 0x040034A9 RID: 13481
		[Tooltip("The playBack time")]
		public FsmFloat playbackTime;

		// Token: 0x040034AA RID: 13482
		[Tooltip("Repeat every frame. Useful for changing over time.")]
		public bool everyFrame;

		// Token: 0x040034AB RID: 13483
		private Animator _animator;
	}
}
