using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020008F4 RID: 2292
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Gets the playback position in the recording buffer. When in playback mode (use  AnimatorStartPlayback), this value is used for controlling the current playback position in the buffer (in seconds). The value can range between recordingStartTime and recordingStopTime See Also: StartPlayback, StopPlayback.")]
	public class GetAnimatorPlayBackTime : FsmStateAction
	{
		// Token: 0x060032E3 RID: 13027 RVA: 0x001338AA File Offset: 0x00131AAA
		public override void Reset()
		{
			this.gameObject = null;
			this.playBackTime = null;
			this.everyFrame = false;
		}

		// Token: 0x060032E4 RID: 13028 RVA: 0x001338C4 File Offset: 0x00131AC4
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
			this.GetPlayBackTime();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060032E5 RID: 13029 RVA: 0x00133928 File Offset: 0x00131B28
		public override void OnUpdate()
		{
			this.GetPlayBackTime();
		}

		// Token: 0x060032E6 RID: 13030 RVA: 0x00133930 File Offset: 0x00131B30
		private void GetPlayBackTime()
		{
			if (this._animator != null)
			{
				this.playBackTime.Value = this._animator.playbackTime;
			}
		}

		// Token: 0x0400344C RID: 13388
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The Target. An Animator component is required")]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400344D RID: 13389
		[ActionSection("Result")]
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The playBack time of the animator.")]
		public FsmFloat playBackTime;

		// Token: 0x0400344E RID: 13390
		[Tooltip("Repeat every frame. Useful when value is subject to change over time.")]
		public bool everyFrame;

		// Token: 0x0400344F RID: 13391
		private Animator _animator;
	}
}
