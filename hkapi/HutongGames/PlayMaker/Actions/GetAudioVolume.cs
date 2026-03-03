using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009CF RID: 2511
	[ActionCategory(ActionCategory.Audio)]
	[Tooltip("Sets the Volume of the Audio Clip played by the AudioSource component on a Game Object.")]
	public class GetAudioVolume : ComponentAction<AudioSource>
	{
		// Token: 0x060036ED RID: 14061 RVA: 0x00143F03 File Offset: 0x00142103
		public override void Reset()
		{
			this.gameObject = null;
			this.storeVolume = null;
			this.everyFrame = false;
		}

		// Token: 0x060036EE RID: 14062 RVA: 0x00143F1A File Offset: 0x0014211A
		public override void OnEnter()
		{
			this.DoGetAudioVolume();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060036EF RID: 14063 RVA: 0x00143F30 File Offset: 0x00142130
		public override void OnUpdate()
		{
			this.DoGetAudioVolume();
		}

		// Token: 0x060036F0 RID: 14064 RVA: 0x00143F38 File Offset: 0x00142138
		private void DoGetAudioVolume()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (base.UpdateCache(ownerDefaultTarget))
			{
				this.storeVolume.Value = base.audio.volume;
			}
		}

		// Token: 0x0400390B RID: 14603
		[RequiredField]
		[CheckForComponent(typeof(AudioSource))]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400390C RID: 14604
		public FsmFloat storeVolume;

		// Token: 0x0400390D RID: 14605
		public bool everyFrame;
	}
}
