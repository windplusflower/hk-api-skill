using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CA5 RID: 3237
	[ActionCategory(ActionCategory.RenderSettings)]
	[Tooltip("Sets the color of the Fog in the scene.")]
	public class SetFogColor : FsmStateAction
	{
		// Token: 0x06004383 RID: 17283 RVA: 0x00173347 File Offset: 0x00171547
		public override void Reset()
		{
			this.fogColor = Color.white;
			this.everyFrame = false;
		}

		// Token: 0x06004384 RID: 17284 RVA: 0x00173360 File Offset: 0x00171560
		public override void OnEnter()
		{
			this.DoSetFogColor();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004385 RID: 17285 RVA: 0x00173376 File Offset: 0x00171576
		public override void OnUpdate()
		{
			this.DoSetFogColor();
		}

		// Token: 0x06004386 RID: 17286 RVA: 0x0017337E File Offset: 0x0017157E
		private void DoSetFogColor()
		{
			RenderSettings.fogColor = this.fogColor.Value;
		}

		// Token: 0x040047C6 RID: 18374
		[RequiredField]
		public FsmColor fogColor;

		// Token: 0x040047C7 RID: 18375
		public bool everyFrame;
	}
}
