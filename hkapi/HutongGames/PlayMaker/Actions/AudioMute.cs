using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B28 RID: 2856
	[ActionCategory(ActionCategory.Audio)]
	[Tooltip("Mute/unmute the Audio Clip played by an Audio Source component on a Game Object.")]
	public class AudioMute : FsmStateAction
	{
		// Token: 0x06003D27 RID: 15655 RVA: 0x001600A0 File Offset: 0x0015E2A0
		public override void Reset()
		{
			this.gameObject = null;
			this.mute = false;
		}

		// Token: 0x06003D28 RID: 15656 RVA: 0x001600B8 File Offset: 0x0015E2B8
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget != null)
			{
				AudioSource component = ownerDefaultTarget.GetComponent<AudioSource>();
				if (component != null)
				{
					component.mute = this.mute.Value;
				}
			}
			base.Finish();
		}

		// Token: 0x04004134 RID: 16692
		[RequiredField]
		[CheckForComponent(typeof(AudioSource))]
		[Tooltip("The GameObject with an Audio Source component.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004135 RID: 16693
		[RequiredField]
		[Tooltip("Check to mute, uncheck to unmute.")]
		public FsmBool mute;
	}
}
