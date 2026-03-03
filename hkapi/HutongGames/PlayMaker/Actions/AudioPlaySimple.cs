using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B2C RID: 2860
	[ActionCategory(ActionCategory.Audio)]
	[Tooltip("Plays the Audio Clip set with Set Audio Clip or in the Audio Source inspector on a Game Object. Optionally plays a one shot Audio Clip.")]
	public class AudioPlaySimple : FsmStateAction
	{
		// Token: 0x06003D35 RID: 15669 RVA: 0x0016038C File Offset: 0x0015E58C
		public override void Reset()
		{
			this.gameObject = null;
			this.volume = 1f;
			this.oneShotClip = null;
		}

		// Token: 0x06003D36 RID: 15670 RVA: 0x001603AC File Offset: 0x0015E5AC
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget != null)
			{
				this.audio = ownerDefaultTarget.GetComponent<AudioSource>();
				if (this.audio != null)
				{
					AudioClip audioClip = this.oneShotClip.Value as AudioClip;
					if (audioClip == null)
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
					if (!this.volume.IsNone)
					{
						this.audio.PlayOneShot(audioClip, this.volume.Value);
					}
					else
					{
						this.audio.PlayOneShot(audioClip);
					}
				}
			}
			base.Finish();
		}

		// Token: 0x0400413F RID: 16703
		[RequiredField]
		[CheckForComponent(typeof(AudioSource))]
		[Tooltip("The GameObject with an AudioSource component.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004140 RID: 16704
		[HasFloatSlider(0f, 1f)]
		[Tooltip("Set the volume.")]
		public FsmFloat volume;

		// Token: 0x04004141 RID: 16705
		[ObjectType(typeof(AudioClip))]
		[Tooltip("Optionally play a 'one shot' AudioClip. NOTE: Volume cannot be adjusted while playing a 'one shot' AudioClip.")]
		public FsmObject oneShotClip;

		// Token: 0x04004142 RID: 16706
		private AudioSource audio;
	}
}
