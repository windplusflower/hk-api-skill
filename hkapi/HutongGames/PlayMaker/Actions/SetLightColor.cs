using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CC7 RID: 3271
	[ActionCategory(ActionCategory.Lights)]
	[Tooltip("Sets the Color of a Light.")]
	public class SetLightColor : ComponentAction<Light>
	{
		// Token: 0x06004418 RID: 17432 RVA: 0x00174DFD File Offset: 0x00172FFD
		public override void Reset()
		{
			this.gameObject = null;
			this.lightColor = Color.white;
			this.everyFrame = false;
		}

		// Token: 0x06004419 RID: 17433 RVA: 0x00174E1D File Offset: 0x0017301D
		public override void OnEnter()
		{
			this.DoSetLightColor();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x0600441A RID: 17434 RVA: 0x00174E33 File Offset: 0x00173033
		public override void OnUpdate()
		{
			this.DoSetLightColor();
		}

		// Token: 0x0600441B RID: 17435 RVA: 0x00174E3C File Offset: 0x0017303C
		private void DoSetLightColor()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (base.UpdateCache(ownerDefaultTarget))
			{
				base.light.color = this.lightColor.Value;
			}
		}

		// Token: 0x04004872 RID: 18546
		[RequiredField]
		[CheckForComponent(typeof(Light))]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004873 RID: 18547
		[RequiredField]
		public FsmColor lightColor;

		// Token: 0x04004874 RID: 18548
		public bool everyFrame;
	}
}
