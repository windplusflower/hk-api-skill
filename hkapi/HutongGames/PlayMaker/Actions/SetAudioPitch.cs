using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C96 RID: 3222
	[ActionCategory(ActionCategory.Audio)]
	[Tooltip("Sets the Pitch of the Audio Clip played by the AudioSource component on a Game Object.")]
	public class SetAudioPitch : ComponentAction<AudioSource>
	{
		// Token: 0x0600433F RID: 17215 RVA: 0x00172AA0 File Offset: 0x00170CA0
		public override void Reset()
		{
			this.gameObject = null;
			this.pitch = 1f;
			this.everyFrame = false;
		}

		// Token: 0x06004340 RID: 17216 RVA: 0x00172AC0 File Offset: 0x00170CC0
		public override void OnEnter()
		{
			this.DoSetAudioPitch();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004341 RID: 17217 RVA: 0x00172AD6 File Offset: 0x00170CD6
		public override void OnUpdate()
		{
			this.DoSetAudioPitch();
		}

		// Token: 0x06004342 RID: 17218 RVA: 0x00172AE0 File Offset: 0x00170CE0
		private void DoSetAudioPitch()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (base.UpdateCache(ownerDefaultTarget) && !this.pitch.IsNone)
			{
				base.audio.pitch = this.pitch.Value;
			}
		}

		// Token: 0x0400478D RID: 18317
		[RequiredField]
		[CheckForComponent(typeof(AudioSource))]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400478E RID: 18318
		public FsmFloat pitch;

		// Token: 0x0400478F RID: 18319
		public bool everyFrame;
	}
}
