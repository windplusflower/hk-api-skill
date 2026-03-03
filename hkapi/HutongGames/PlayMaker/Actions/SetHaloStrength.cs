using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CC1 RID: 3265
	[ActionCategory(ActionCategory.RenderSettings)]
	[Tooltip("Sets the size of light halos.")]
	public class SetHaloStrength : FsmStateAction
	{
		// Token: 0x06004400 RID: 17408 RVA: 0x00174BD8 File Offset: 0x00172DD8
		public override void Reset()
		{
			this.haloStrength = 0.5f;
			this.everyFrame = false;
		}

		// Token: 0x06004401 RID: 17409 RVA: 0x00174BF1 File Offset: 0x00172DF1
		public override void OnEnter()
		{
			this.DoSetHaloStrength();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004402 RID: 17410 RVA: 0x00174C07 File Offset: 0x00172E07
		public override void OnUpdate()
		{
			this.DoSetHaloStrength();
		}

		// Token: 0x06004403 RID: 17411 RVA: 0x00174C0F File Offset: 0x00172E0F
		private void DoSetHaloStrength()
		{
			RenderSettings.haloStrength = this.haloStrength.Value;
		}

		// Token: 0x04004864 RID: 18532
		[RequiredField]
		public FsmFloat haloStrength;

		// Token: 0x04004865 RID: 18533
		public bool everyFrame;
	}
}
