using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C94 RID: 3220
	[ActionCategory(ActionCategory.Audio)]
	[Tooltip("Sets the Audio Clip played by the AudioSource component on a Game Object.")]
	public class SetAudioClip : ComponentAction<AudioSource>
	{
		// Token: 0x06004339 RID: 17209 RVA: 0x001729EC File Offset: 0x00170BEC
		public override void Reset()
		{
			this.gameObject = null;
			this.audioClip = null;
		}

		// Token: 0x0600433A RID: 17210 RVA: 0x001729FC File Offset: 0x00170BFC
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (base.UpdateCache(ownerDefaultTarget))
			{
				base.audio.clip = (this.audioClip.Value as AudioClip);
			}
			base.Finish();
		}

		// Token: 0x04004789 RID: 18313
		[RequiredField]
		[CheckForComponent(typeof(AudioSource))]
		[Tooltip("The GameObject with the AudioSource component.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400478A RID: 18314
		[ObjectType(typeof(AudioClip))]
		[Tooltip("The AudioClip to set.")]
		public FsmObject audioClip;
	}
}
