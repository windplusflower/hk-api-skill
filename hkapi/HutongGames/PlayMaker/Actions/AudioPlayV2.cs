using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020008CA RID: 2250
	[ActionCategory(ActionCategory.Audio)]
	[Tooltip("Plays the Audio Clip set with Set Audio Clip or in the Audio Source inspector on a Game Object. Optionally plays a one shot Audio Clip.")]
	public class AudioPlayV2 : FsmStateAction
	{
		// Token: 0x06003228 RID: 12840 RVA: 0x00130DAA File Offset: 0x0012EFAA
		public override void Reset()
		{
			this.gameObject = null;
			this.volume = 1f;
			this.oneShotClip = null;
			this.finishedEvent = null;
		}

		// Token: 0x06003229 RID: 12841 RVA: 0x00130DD4 File Offset: 0x0012EFD4
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
						return;
					}
					if (!this.volume.IsNone)
					{
						this.audio.PlayOneShot(audioClip, this.volume.Value);
						return;
					}
					this.audio.PlayOneShot(audioClip);
					return;
				}
			}
			base.Finish();
		}

		// Token: 0x0600322A RID: 12842 RVA: 0x00130EAC File Offset: 0x0012F0AC
		public override void OnUpdate()
		{
			if (this.audio == null)
			{
				base.Finish();
				return;
			}
			if (!this.audio.isPlaying)
			{
				base.Fsm.Event(this.finishedEvent);
				base.Finish();
				return;
			}
			if (!this.volume.IsNone && this.volume.Value != this.audio.volume)
			{
				this.audio.volume = this.volume.Value;
			}
		}

		// Token: 0x0400336F RID: 13167
		[RequiredField]
		[CheckForComponent(typeof(AudioSource))]
		[Tooltip("The GameObject with an AudioSource component.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003370 RID: 13168
		[HasFloatSlider(0f, 1f)]
		[Tooltip("Set the volume.")]
		public FsmFloat volume;

		// Token: 0x04003371 RID: 13169
		[ObjectType(typeof(AudioClip))]
		[Tooltip("Optionally play a 'one shot' AudioClip. NOTE: Volume cannot be adjusted while playing a 'one shot' AudioClip.")]
		public FsmObject oneShotClip;

		// Token: 0x04003372 RID: 13170
		[Tooltip("Event to send when the AudioClip finishes playing.")]
		public FsmEvent finishedEvent;

		// Token: 0x04003373 RID: 13171
		private AudioSource audio;
	}
}
