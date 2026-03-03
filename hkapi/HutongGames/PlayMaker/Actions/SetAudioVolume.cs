using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C97 RID: 3223
	[ActionCategory(ActionCategory.Audio)]
	[Tooltip("Sets the Volume of the Audio Clip played by the AudioSource component on a Game Object.")]
	public class SetAudioVolume : ComponentAction<AudioSource>
	{
		// Token: 0x06004344 RID: 17220 RVA: 0x00172B2B File Offset: 0x00170D2B
		public override void Reset()
		{
			this.gameObject = null;
			this.volume = 1f;
			this.everyFrame = false;
		}

		// Token: 0x06004345 RID: 17221 RVA: 0x00172B4B File Offset: 0x00170D4B
		public override void OnEnter()
		{
			this.DoSetAudioVolume();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004346 RID: 17222 RVA: 0x00172B61 File Offset: 0x00170D61
		public override void OnUpdate()
		{
			this.DoSetAudioVolume();
		}

		// Token: 0x06004347 RID: 17223 RVA: 0x00172B6C File Offset: 0x00170D6C
		private void DoSetAudioVolume()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (base.UpdateCache(ownerDefaultTarget) && !this.volume.IsNone)
			{
				base.audio.volume = this.volume.Value;
			}
		}

		// Token: 0x04004790 RID: 18320
		[RequiredField]
		[CheckForComponent(typeof(AudioSource))]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004791 RID: 18321
		[HasFloatSlider(0f, 1f)]
		public FsmFloat volume;

		// Token: 0x04004792 RID: 18322
		public bool everyFrame;
	}
}
