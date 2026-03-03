using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020008D4 RID: 2260
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Stops the animator record mode. It will lock the recording buffer's contents in its current state. The data get saved for subsequent playback with StartPlayback.")]
	public class AnimatorStopRecording : FsmStateAction
	{
		// Token: 0x06003253 RID: 12883 RVA: 0x00131A9F File Offset: 0x0012FC9F
		public override void Reset()
		{
			this.gameObject = null;
			this.recorderStartTime = null;
			this.recorderStopTime = null;
		}

		// Token: 0x06003254 RID: 12884 RVA: 0x00131AB8 File Offset: 0x0012FCB8
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
				component.StopRecording();
				this.recorderStartTime.Value = component.recorderStartTime;
				this.recorderStopTime.Value = component.recorderStopTime;
			}
			base.Finish();
		}

		// Token: 0x040033A3 RID: 13219
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The target. An Animator component and a PlayMakerAnimatorProxy component are required")]
		public FsmOwnerDefault gameObject;

		// Token: 0x040033A4 RID: 13220
		[ActionSection("Results")]
		[UIHint(UIHint.Variable)]
		[Tooltip("The recorder StartTime")]
		public FsmFloat recorderStartTime;

		// Token: 0x040033A5 RID: 13221
		[UIHint(UIHint.Variable)]
		[Tooltip("The recorder StopTime")]
		public FsmFloat recorderStopTime;
	}
}
