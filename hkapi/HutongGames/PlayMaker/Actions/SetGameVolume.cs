using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CBF RID: 3263
	[ActionCategory(ActionCategory.Audio)]
	[Tooltip("Sets the global sound volume.")]
	public class SetGameVolume : FsmStateAction
	{
		// Token: 0x060043F7 RID: 17399 RVA: 0x00174A9F File Offset: 0x00172C9F
		public override void Reset()
		{
			this.volume = 1f;
			this.everyFrame = false;
		}

		// Token: 0x060043F8 RID: 17400 RVA: 0x00174AB8 File Offset: 0x00172CB8
		public override void OnEnter()
		{
			AudioListener.volume = this.volume.Value;
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060043F9 RID: 17401 RVA: 0x00174AD8 File Offset: 0x00172CD8
		public override void OnUpdate()
		{
			AudioListener.volume = this.volume.Value;
		}

		// Token: 0x0400485D RID: 18525
		[RequiredField]
		[HasFloatSlider(0f, 1f)]
		public FsmFloat volume;

		// Token: 0x0400485E RID: 18526
		public bool everyFrame;
	}
}
