using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B80 RID: 2944
	[ActionCategory(ActionCategory.Audio)]
	[Tooltip("Sets the Volume of the Audio Clip played by the AudioSource component on a Game Object.")]
	public class FadeAudio : ComponentAction<AudioSource>
	{
		// Token: 0x06003E90 RID: 16016 RVA: 0x001648F4 File Offset: 0x00162AF4
		public override void Reset()
		{
			this.gameObject = null;
			this.startVolume = 1f;
			this.endVolume = 0f;
			this.time = 1f;
		}

		// Token: 0x06003E91 RID: 16017 RVA: 0x00164930 File Offset: 0x00162B30
		public override void OnEnter()
		{
			if (this.startVolume.Value > this.endVolume.Value)
			{
				this.fadingDown = true;
			}
			else
			{
				this.fadingDown = false;
			}
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (base.UpdateCache(ownerDefaultTarget))
			{
				base.audio.volume = this.startVolume.Value;
			}
		}

		// Token: 0x06003E92 RID: 16018 RVA: 0x00164998 File Offset: 0x00162B98
		public override void OnExit()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (base.UpdateCache(ownerDefaultTarget))
			{
				base.audio.volume = this.endVolume.Value;
			}
		}

		// Token: 0x06003E93 RID: 16019 RVA: 0x001649D6 File Offset: 0x00162BD6
		public override void OnUpdate()
		{
			this.DoSetAudioVolume();
		}

		// Token: 0x06003E94 RID: 16020 RVA: 0x001649E0 File Offset: 0x00162BE0
		private void DoSetAudioVolume()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (base.UpdateCache(ownerDefaultTarget))
			{
				this.timeElapsed += Time.deltaTime;
				this.timePercentage = this.timeElapsed / this.time.Value * 100f;
				float num = (this.endVolume.Value - this.startVolume.Value) * (this.timePercentage / 100f);
				base.audio.volume = base.audio.volume + num;
				if (this.fadingDown && base.audio.volume <= this.endVolume.Value)
				{
					base.audio.volume = this.endVolume.Value;
					base.Finish();
				}
				else if (!this.fadingDown && base.audio.volume >= this.endVolume.Value)
				{
					base.audio.volume = this.endVolume.Value;
					base.Finish();
				}
				this.timeElapsed = 0f;
			}
		}

		// Token: 0x040042A0 RID: 17056
		[RequiredField]
		[CheckForComponent(typeof(AudioSource))]
		public FsmOwnerDefault gameObject;

		// Token: 0x040042A1 RID: 17057
		public FsmFloat startVolume;

		// Token: 0x040042A2 RID: 17058
		public FsmFloat endVolume;

		// Token: 0x040042A3 RID: 17059
		public FsmFloat time;

		// Token: 0x040042A4 RID: 17060
		private float timeElapsed;

		// Token: 0x040042A5 RID: 17061
		private float timePercentage;

		// Token: 0x040042A6 RID: 17062
		private bool fadingDown;
	}
}
