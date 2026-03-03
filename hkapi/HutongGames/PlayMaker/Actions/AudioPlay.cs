using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B2A RID: 2858
	[ActionCategory(ActionCategory.Audio)]
	[ActionTarget(typeof(AudioSource), "gameObject", false)]
	[ActionTarget(typeof(AudioClip), "oneShotClip", false)]
	[Tooltip("Plays the Audio Clip set with Set Audio Clip or in the Audio Source inspector on a Game Object. Optionally plays a one shot Audio Clip.")]
	public class AudioPlay : FsmStateAction
	{
		// Token: 0x06003D2D RID: 15661 RVA: 0x00160154 File Offset: 0x0015E354
		public override void Reset()
		{
			this.gameObject = null;
			this.volume = 1f;
			this.oneShotClip = null;
			this.finishedEvent = null;
		}

		// Token: 0x06003D2E RID: 15662 RVA: 0x0016017C File Offset: 0x0015E37C
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget != null)
			{
				this.audio = ownerDefaultTarget.GetComponent<AudioSource>();
				if (this.audio != null && this.audio.enabled)
				{
					AudioClip audioClip = this.oneShotClip.Value as AudioClip;
					if (audioClip == null)
					{
						this.audio.Play();
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

		// Token: 0x06003D2F RID: 15663 RVA: 0x00160258 File Offset: 0x0015E458
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

		// Token: 0x04004137 RID: 16695
		[RequiredField]
		[CheckForComponent(typeof(AudioSource))]
		[Tooltip("The GameObject with an AudioSource component.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004138 RID: 16696
		[HasFloatSlider(0f, 1f)]
		[Tooltip("Set the volume.")]
		public FsmFloat volume;

		// Token: 0x04004139 RID: 16697
		[ObjectType(typeof(AudioClip))]
		[Tooltip("Optionally play a 'one shot' AudioClip. NOTE: Volume cannot be adjusted while playing a 'one shot' AudioClip.")]
		public FsmObject oneShotClip;

		// Token: 0x0400413A RID: 16698
		[Tooltip("Event to send when the AudioClip finishes playing.")]
		public FsmEvent finishedEvent;

		// Token: 0x0400413B RID: 16699
		private AudioSource audio;
	}
}
