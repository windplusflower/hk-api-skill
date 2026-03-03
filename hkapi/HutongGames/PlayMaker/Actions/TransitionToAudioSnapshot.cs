using System;
using UnityEngine;
using UnityEngine.Audio;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A72 RID: 2674
	[ActionCategory(ActionCategory.Audio)]
	[Tooltip("Transition to an audio snapshot. Easy and fun.")]
	public class TransitionToAudioSnapshot : ComponentAction<AudioSource>
	{
		// Token: 0x060039A3 RID: 14755 RVA: 0x00150113 File Offset: 0x0014E313
		public override void Reset()
		{
			this.snapshot = null;
			this.transitionTime = 1f;
		}

		// Token: 0x060039A4 RID: 14756 RVA: 0x0015012C File Offset: 0x0014E32C
		public override void OnEnter()
		{
			AudioMixerSnapshot audioMixerSnapshot = this.snapshot.Value as AudioMixerSnapshot;
			if (audioMixerSnapshot != null)
			{
				audioMixerSnapshot.TransitionTo(this.transitionTime.Value);
			}
			base.Finish();
		}

		// Token: 0x04003CA2 RID: 15522
		[ObjectType(typeof(AudioMixerSnapshot))]
		public FsmObject snapshot;

		// Token: 0x04003CA3 RID: 15523
		public FsmFloat transitionTime;
	}
}
