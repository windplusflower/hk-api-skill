using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000993 RID: 2451
	[ActionCategory(ActionCategory.Audio)]
	public class AudioPlayRandomSingle : FsmStateAction
	{
		// Token: 0x060035BE RID: 13758 RVA: 0x0013D41F File Offset: 0x0013B61F
		public override void Reset()
		{
			this.gameObject = null;
			this.audioClip = null;
			this.pitchMin = 1f;
			this.pitchMax = 1f;
		}

		// Token: 0x060035BF RID: 13759 RVA: 0x0013D44F File Offset: 0x0013B64F
		public override void OnEnter()
		{
			this.DoPlayRandomClip();
			base.Finish();
		}

		// Token: 0x060035C0 RID: 13760 RVA: 0x0013D460 File Offset: 0x0013B660
		private void DoPlayRandomClip()
		{
			AudioClip clip = this.audioClip.Value as AudioClip;
			this.audio = this.gameObject.Value.GetComponent<AudioSource>();
			float pitch = UnityEngine.Random.Range(this.pitchMin.Value, this.pitchMax.Value);
			this.audio.pitch = pitch;
			this.audio.PlayOneShot(clip);
		}

		// Token: 0x060035C1 RID: 13761 RVA: 0x0013D4C8 File Offset: 0x0013B6C8
		public AudioPlayRandomSingle()
		{
			this.pitchMin = 1f;
			this.pitchMax = 2f;
			base..ctor();
		}

		// Token: 0x0400374D RID: 14157
		[RequiredField]
		[CheckForComponent(typeof(AudioSource))]
		[Tooltip("The GameObject with an AudioSource component.")]
		public FsmGameObject gameObject;

		// Token: 0x0400374E RID: 14158
		[ObjectType(typeof(AudioClip))]
		public FsmObject audioClip;

		// Token: 0x0400374F RID: 14159
		public FsmFloat pitchMin;

		// Token: 0x04003750 RID: 14160
		public FsmFloat pitchMax;

		// Token: 0x04003751 RID: 14161
		private AudioSource audio;
	}
}
