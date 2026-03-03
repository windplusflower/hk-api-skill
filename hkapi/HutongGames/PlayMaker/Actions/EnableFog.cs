using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B7B RID: 2939
	[ActionCategory(ActionCategory.RenderSettings)]
	[Tooltip("Enables/Disables Fog in the scene.")]
	public class EnableFog : FsmStateAction
	{
		// Token: 0x06003E78 RID: 15992 RVA: 0x001645F2 File Offset: 0x001627F2
		public override void Reset()
		{
			this.enableFog = true;
			this.everyFrame = false;
		}

		// Token: 0x06003E79 RID: 15993 RVA: 0x00164607 File Offset: 0x00162807
		public override void OnEnter()
		{
			RenderSettings.fog = this.enableFog.Value;
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003E7A RID: 15994 RVA: 0x00164627 File Offset: 0x00162827
		public override void OnUpdate()
		{
			RenderSettings.fog = this.enableFog.Value;
		}

		// Token: 0x0400428A RID: 17034
		[Tooltip("Set to True to enable, False to disable.")]
		public FsmBool enableFog;

		// Token: 0x0400428B RID: 17035
		[Tooltip("Repeat every frame. Useful if the Enable Fog setting is changing.")]
		public bool everyFrame;
	}
}
