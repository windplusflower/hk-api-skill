using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CA6 RID: 3238
	[ActionCategory(ActionCategory.RenderSettings)]
	[Tooltip("Sets the density of the Fog in the scene.")]
	public class SetFogDensity : FsmStateAction
	{
		// Token: 0x06004388 RID: 17288 RVA: 0x00173390 File Offset: 0x00171590
		public override void Reset()
		{
			this.fogDensity = 0.5f;
			this.everyFrame = false;
		}

		// Token: 0x06004389 RID: 17289 RVA: 0x001733A9 File Offset: 0x001715A9
		public override void OnEnter()
		{
			this.DoSetFogDensity();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x0600438A RID: 17290 RVA: 0x001733BF File Offset: 0x001715BF
		public override void OnUpdate()
		{
			this.DoSetFogDensity();
		}

		// Token: 0x0600438B RID: 17291 RVA: 0x001733C7 File Offset: 0x001715C7
		private void DoSetFogDensity()
		{
			RenderSettings.fogDensity = this.fogDensity.Value;
		}

		// Token: 0x040047C8 RID: 18376
		[RequiredField]
		public FsmFloat fogDensity;

		// Token: 0x040047C9 RID: 18377
		public bool everyFrame;
	}
}
