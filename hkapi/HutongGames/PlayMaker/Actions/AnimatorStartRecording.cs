using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020008D2 RID: 2258
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Sets the animator in recording mode, and allocates a circular buffer of size frameCount. After this call, the recorder starts collecting up to frameCount frames in the buffer. Note it is not possible to start playback until a call to StopRecording is made")]
	public class AnimatorStartRecording : FsmStateAction
	{
		// Token: 0x0600324D RID: 12877 RVA: 0x001319DF File Offset: 0x0012FBDF
		public override void Reset()
		{
			this.gameObject = null;
			this.frameCount = 0;
		}

		// Token: 0x0600324E RID: 12878 RVA: 0x001319F4 File Offset: 0x0012FBF4
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				base.Finish();
				return;
			}
			Animator component = ownerDefaultTarget.GetComponent<Animator>();
			if (component != null)
			{
				component.StartRecording(this.frameCount.Value);
			}
			base.Finish();
		}

		// Token: 0x040033A0 RID: 13216
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The target. An Animator component is required")]
		public FsmOwnerDefault gameObject;

		// Token: 0x040033A1 RID: 13217
		[RequiredField]
		[Tooltip("The number of frames (updates) that will be recorded. If frameCount is 0, the recording will continue until the user calls StopRecording. The maximum value for frameCount is 10000.")]
		public FsmInt frameCount;
	}
}
