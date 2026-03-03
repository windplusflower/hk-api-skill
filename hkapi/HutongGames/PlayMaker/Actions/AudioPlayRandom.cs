using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000992 RID: 2450
	[ActionCategory(ActionCategory.Audio)]
	public class AudioPlayRandom : FsmStateAction
	{
		// Token: 0x060035BA RID: 13754 RVA: 0x0013D2F0 File Offset: 0x0013B4F0
		public override void Reset()
		{
			this.gameObject = null;
			this.audioClips = new AudioClip[3];
			this.weights = new FsmFloat[]
			{
				1f,
				1f,
				1f
			};
			this.pitchMin = 1f;
			this.pitchMax = 1f;
		}

		// Token: 0x060035BB RID: 13755 RVA: 0x0013D363 File Offset: 0x0013B563
		public override void OnEnter()
		{
			this.DoPlayRandomClip();
			base.Finish();
		}

		// Token: 0x060035BC RID: 13756 RVA: 0x0013D374 File Offset: 0x0013B574
		private void DoPlayRandomClip()
		{
			if (this.audioClips.Length == 0)
			{
				return;
			}
			this.audio = this.gameObject.Value.GetComponent<AudioSource>();
			int randomWeightedIndex = ActionHelpers.GetRandomWeightedIndex(this.weights);
			if (randomWeightedIndex != -1)
			{
				AudioClip audioClip = this.audioClips[randomWeightedIndex];
				if (audioClip != null)
				{
					float pitch = UnityEngine.Random.Range(this.pitchMin.Value, this.pitchMax.Value);
					this.audio.pitch = pitch;
					this.audio.PlayOneShot(audioClip);
				}
			}
		}

		// Token: 0x060035BD RID: 13757 RVA: 0x0013D3F7 File Offset: 0x0013B5F7
		public AudioPlayRandom()
		{
			this.pitchMin = 1f;
			this.pitchMax = 2f;
			base..ctor();
		}

		// Token: 0x04003747 RID: 14151
		[RequiredField]
		[CheckForComponent(typeof(AudioSource))]
		[Tooltip("The GameObject with an AudioSource component.")]
		public FsmGameObject gameObject;

		// Token: 0x04003748 RID: 14152
		[CompoundArray("Audio Clips", "Audio Clip", "Weight")]
		public AudioClip[] audioClips;

		// Token: 0x04003749 RID: 14153
		[HasFloatSlider(0f, 1f)]
		public FsmFloat[] weights;

		// Token: 0x0400374A RID: 14154
		public FsmFloat pitchMin;

		// Token: 0x0400374B RID: 14155
		public FsmFloat pitchMax;

		// Token: 0x0400374C RID: 14156
		private AudioSource audio;
	}
}
