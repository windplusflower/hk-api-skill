using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000995 RID: 2453
	[ActionCategory(ActionCategory.Audio)]
	[Tooltip("Instantiate an Audio Player object and play a oneshot sound via its Audio Source.")]
	public class AudioPlayerOneShotSingle : FsmStateAction
	{
		// Token: 0x060035C7 RID: 13767 RVA: 0x0013D708 File Offset: 0x0013B908
		public override void Reset()
		{
			this.spawnPoint = null;
			this.pitchMin = 1f;
			this.pitchMax = 1f;
			this.volume = 1f;
		}

		// Token: 0x060035C8 RID: 13768 RVA: 0x0013D741 File Offset: 0x0013B941
		public override void OnEnter()
		{
			this.timer = 0f;
			if (this.delay.Value == 0f)
			{
				this.DoPlayRandomClip();
				base.Finish();
			}
		}

		// Token: 0x060035C9 RID: 13769 RVA: 0x0013D76C File Offset: 0x0013B96C
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

		// Token: 0x060035CA RID: 13770 RVA: 0x0013D7C0 File Offset: 0x0013B9C0
		private void DoPlayRandomClip()
		{
			if (!this.audioPlayer.IsNone && !this.spawnPoint.IsNone && this.spawnPoint.Value != null)
			{
				GameObject value = this.audioPlayer.Value;
				Vector3 position = this.spawnPoint.Value.transform.position;
				Vector3 up = Vector3.up;
				if (this.audioPlayer.Value != null)
				{
					GameObject gameObject = this.audioPlayer.Value.Spawn(position, Quaternion.Euler(up));
					this.audio = gameObject.GetComponent<AudioSource>();
					this.storePlayer.Value = gameObject;
					AudioClip audioClip = this.audioClip.Value as AudioClip;
					float pitch = UnityEngine.Random.Range(this.pitchMin.Value, this.pitchMax.Value);
					this.audio.pitch = pitch;
					this.audio.volume = this.volume.Value;
					if (audioClip != null)
					{
						this.audio.PlayOneShot(audioClip);
						return;
					}
				}
				else
				{
					Debug.LogError("AudioPlayer object not set!");
				}
			}
		}

		// Token: 0x060035CB RID: 13771 RVA: 0x0013D8E2 File Offset: 0x0013BAE2
		public AudioPlayerOneShotSingle()
		{
			this.volume = 1f;
			base..ctor();
		}

		// Token: 0x0400375D RID: 14173
		[RequiredField]
		[Tooltip("The object to spawn. Select Audio Player prefab.")]
		public FsmGameObject audioPlayer;

		// Token: 0x0400375E RID: 14174
		[RequiredField]
		[Tooltip("Object to use as the spawn point of Audio Player")]
		public FsmGameObject spawnPoint;

		// Token: 0x0400375F RID: 14175
		[ObjectType(typeof(AudioClip))]
		public FsmObject audioClip;

		// Token: 0x04003760 RID: 14176
		public FsmFloat pitchMin;

		// Token: 0x04003761 RID: 14177
		public FsmFloat pitchMax;

		// Token: 0x04003762 RID: 14178
		public FsmFloat volume;

		// Token: 0x04003763 RID: 14179
		public FsmFloat delay;

		// Token: 0x04003764 RID: 14180
		public FsmGameObject storePlayer;

		// Token: 0x04003765 RID: 14181
		private AudioSource audio;

		// Token: 0x04003766 RID: 14182
		private float timer;
	}
}
