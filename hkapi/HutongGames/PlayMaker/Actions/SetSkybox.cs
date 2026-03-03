using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CE2 RID: 3298
	[ActionCategory(ActionCategory.RenderSettings)]
	[Tooltip("Sets the global Skybox.")]
	public class SetSkybox : FsmStateAction
	{
		// Token: 0x06004493 RID: 17555 RVA: 0x00176366 File Offset: 0x00174566
		public override void Reset()
		{
			this.skybox = null;
		}

		// Token: 0x06004494 RID: 17556 RVA: 0x0017636F File Offset: 0x0017456F
		public override void OnEnter()
		{
			RenderSettings.skybox = this.skybox.Value;
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004495 RID: 17557 RVA: 0x0017638F File Offset: 0x0017458F
		public override void OnUpdate()
		{
			RenderSettings.skybox = this.skybox.Value;
		}

		// Token: 0x040048DA RID: 18650
		public FsmMaterial skybox;

		// Token: 0x040048DB RID: 18651
		[Tooltip("Repeat every frame. Useful if the Skybox is changing.")]
		public bool everyFrame;
	}
}
