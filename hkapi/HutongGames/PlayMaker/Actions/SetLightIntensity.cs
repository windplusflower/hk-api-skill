using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CCA RID: 3274
	[ActionCategory(ActionCategory.Lights)]
	[Tooltip("Sets the Intensity of a Light.")]
	public class SetLightIntensity : ComponentAction<Light>
	{
		// Token: 0x06004425 RID: 17445 RVA: 0x00174F35 File Offset: 0x00173135
		public override void Reset()
		{
			this.gameObject = null;
			this.lightIntensity = 1f;
			this.everyFrame = false;
		}

		// Token: 0x06004426 RID: 17446 RVA: 0x00174F55 File Offset: 0x00173155
		public override void OnEnter()
		{
			this.DoSetLightIntensity();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004427 RID: 17447 RVA: 0x00174F6B File Offset: 0x0017316B
		public override void OnUpdate()
		{
			this.DoSetLightIntensity();
		}

		// Token: 0x06004428 RID: 17448 RVA: 0x00174F74 File Offset: 0x00173174
		private void DoSetLightIntensity()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (base.UpdateCache(ownerDefaultTarget))
			{
				base.light.intensity = this.lightIntensity.Value;
			}
		}

		// Token: 0x04004879 RID: 18553
		[RequiredField]
		[CheckForComponent(typeof(Light))]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400487A RID: 18554
		public FsmFloat lightIntensity;

		// Token: 0x0400487B RID: 18555
		public bool everyFrame;
	}
}
