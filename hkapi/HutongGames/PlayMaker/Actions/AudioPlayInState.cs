using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B2B RID: 2859
	[ActionCategory(ActionCategory.Audio)]
	[Tooltip("Plays the Audio Clip set with Set Audio Clip or in the Audio Source inspector on a Game Object. Stops audio when state exited.")]
	public class AudioPlayInState : FsmStateAction
	{
		// Token: 0x06003D31 RID: 15665 RVA: 0x001602DA File Offset: 0x0015E4DA
		public override void Reset()
		{
			this.gameObject = null;
			this.volume = 1f;
		}

		// Token: 0x06003D32 RID: 15666 RVA: 0x001602F4 File Offset: 0x0015E4F4
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget != null)
			{
				this.audio = ownerDefaultTarget.GetComponent<AudioSource>();
				if (this.audio != null)
				{
					if (!this.audio.isPlaying)
					{
						this.audio.Play();
					}
					if (!this.volume.IsNone)
					{
						this.audio.volume = this.volume.Value;
					}
				}
			}
		}

		// Token: 0x06003D33 RID: 15667 RVA: 0x00160371 File Offset: 0x0015E571
		public override void OnExit()
		{
			if (this.audio != null)
			{
				this.audio.Stop();
			}
		}

		// Token: 0x0400413C RID: 16700
		[RequiredField]
		[CheckForComponent(typeof(AudioSource))]
		[Tooltip("The GameObject with an AudioSource component.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400413D RID: 16701
		[HasFloatSlider(0f, 1f)]
		[Tooltip("Set the volume.")]
		public FsmFloat volume;

		// Token: 0x0400413E RID: 16702
		private AudioSource audio;
	}
}
