using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CCC RID: 3276
	[ActionCategory(ActionCategory.Lights)]
	[Tooltip("Sets the Spot Angle of a Light.")]
	public class SetLightSpotAngle : ComponentAction<Light>
	{
		// Token: 0x0600442F RID: 17455 RVA: 0x0017502E File Offset: 0x0017322E
		public override void Reset()
		{
			this.gameObject = null;
			this.lightSpotAngle = 20f;
			this.everyFrame = false;
		}

		// Token: 0x06004430 RID: 17456 RVA: 0x0017504E File Offset: 0x0017324E
		public override void OnEnter()
		{
			this.DoSetLightRange();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004431 RID: 17457 RVA: 0x00175064 File Offset: 0x00173264
		public override void OnUpdate()
		{
			this.DoSetLightRange();
		}

		// Token: 0x06004432 RID: 17458 RVA: 0x0017506C File Offset: 0x0017326C
		private void DoSetLightRange()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (base.UpdateCache(ownerDefaultTarget))
			{
				base.light.spotAngle = this.lightSpotAngle.Value;
			}
		}

		// Token: 0x0400487F RID: 18559
		[RequiredField]
		[CheckForComponent(typeof(Light))]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004880 RID: 18560
		public FsmFloat lightSpotAngle;

		// Token: 0x04004881 RID: 18561
		public bool everyFrame;
	}
}
