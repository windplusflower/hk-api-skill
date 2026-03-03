using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CA2 RID: 3234
	[ActionCategory(ActionCategory.RenderSettings)]
	[Tooltip("Sets the intensity of all Flares in the scene.")]
	public class SetFlareStrength : FsmStateAction
	{
		// Token: 0x06004376 RID: 17270 RVA: 0x00173219 File Offset: 0x00171419
		public override void Reset()
		{
			this.flareStrength = 0.2f;
			this.everyFrame = false;
		}

		// Token: 0x06004377 RID: 17271 RVA: 0x00173232 File Offset: 0x00171432
		public override void OnEnter()
		{
			this.DoSetFlareStrength();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004378 RID: 17272 RVA: 0x00173248 File Offset: 0x00171448
		public override void OnUpdate()
		{
			this.DoSetFlareStrength();
		}

		// Token: 0x06004379 RID: 17273 RVA: 0x00173250 File Offset: 0x00171450
		private void DoSetFlareStrength()
		{
			RenderSettings.flareStrength = this.flareStrength.Value;
		}

		// Token: 0x040047BD RID: 18365
		[RequiredField]
		public FsmFloat flareStrength;

		// Token: 0x040047BE RID: 18366
		public bool everyFrame;
	}
}
