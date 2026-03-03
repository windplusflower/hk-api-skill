using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000994 RID: 2452
	[ActionCategory(ActionCategory.Audio)]
	[Tooltip("Instantiate an Audio Player object and play a oneshot sound via its Audio Source.")]
	public class AudioPlayerOneShot : FsmStateAction
	{
		// Token: 0x060035C2 RID: 13762 RVA: 0x0013D4F0 File Offset: 0x0013B6F0
		public override void Reset()
		{
			this.spawnPoint = null;
			this.audioClips = new AudioClip[3];
			this.weights = new FsmFloat[]
			{
				1f,
				1f,
				1f
			};
			this.pitchMin = 1f;
			this.pitchMax = 1f;
			this.volume = 1f;
			this.timer = 0f;
		}

		// Token: 0x060035C3 RID: 13763 RVA: 0x0013D57E File Offset: 0x0013B77E
		public override void OnEnter()
		{
			this.timer = 0f;
			if (this.delay.Value == 0f)
			{
				this.DoPlayRandomClip();
				base.Finish();
			}
		}

		// Token: 0x060035C4 RID: 13764 RVA: 0x0013D5AC File Offset: 0x0013B7AC
		public override void OnUpdate()
		{
			if (this.delay.Value > 0f)
			{
				if (this.timer < this.delay.Value)
				{
					this.timer += Time.deltaTime;
					return;
				}
				this.DoPlayRandomClip();
				base.Finish();
			}
		}

		// Token: 0x060035C5 RID: 13765 RVA: 0x0013D600 File Offset: 0x0013B800
		private void DoPlayRandomClip()
		{
			if (this.audioClips.Length == 0)
			{
				return;
			}
			GameObject value = this.audioPlayer.Value;
			Vector3 position = this.spawnPoint.Value.transform.position;
			Vector3 up = Vector3.up;
			GameObject gameObject = this.audioPlayer.Value.Spawn(position, Quaternion.Euler(up));
			this.audio = gameObject.GetComponent<AudioSource>();
			this.storePlayer.Value = gameObject;
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
			this.audio.volume = this.volume.Value;
		}

		// Token: 0x060035C6 RID: 13766 RVA: 0x0013D6E0 File Offset: 0x0013B8E0
		public AudioPlayerOneShot()
		{
			this.pitchMin = 1f;
			this.pitchMax = 2f;
			base..ctor();
		}

		// Token: 0x04003752 RID: 14162
		[RequiredField]
		[CheckForComponent(typeof(AudioSource))]
		[Tooltip("The object to spawn. Select Audio Player prefab.")]
		public FsmGameObject audioPlayer;

		// Token: 0x04003753 RID: 14163
		[RequiredField]
		[Tooltip("Object to use as the spawn point of Audio Player")]
		public FsmGameObject spawnPoint;

		// Token: 0x04003754 RID: 14164
		[CompoundArray("Audio Clips", "Audio Clip", "Weight")]
		public AudioClip[] audioClips;

		// Token: 0x04003755 RID: 14165
		[HasFloatSlider(0f, 1f)]
		public FsmFloat[] weights;

		// Token: 0x04003756 RID: 14166
		public FsmFloat pitchMin;

		// Token: 0x04003757 RID: 14167
		public FsmFloat pitchMax;

		// Token: 0x04003758 RID: 14168
		public FsmFloat volume;

		// Token: 0x04003759 RID: 14169
		public FsmFloat delay;

		// Token: 0x0400375A RID: 14170
		public FsmGameObject storePlayer;

		// Token: 0x0400375B RID: 14171
		private AudioSource audio;

		// Token: 0x0400375C RID: 14172
		private float timer;
	}
}
