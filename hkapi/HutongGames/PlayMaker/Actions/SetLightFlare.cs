using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CC9 RID: 3273
	[ActionCategory(ActionCategory.Lights)]
	[Tooltip("Sets the Flare effect used by a Light.")]
	public class SetLightFlare : ComponentAction<Light>
	{
		// Token: 0x06004421 RID: 17441 RVA: 0x00174EDE File Offset: 0x001730DE
		public override void Reset()
		{
			this.gameObject = null;
			this.lightFlare = null;
		}

		// Token: 0x06004422 RID: 17442 RVA: 0x00174EEE File Offset: 0x001730EE
		public override void OnEnter()
		{
			this.DoSetLightRange();
			base.Finish();
		}

		// Token: 0x06004423 RID: 17443 RVA: 0x00174EFC File Offset: 0x001730FC
		private void DoSetLightRange()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (base.UpdateCache(ownerDefaultTarget))
			{
				base.light.flare = this.lightFlare;
			}
		}

		// Token: 0x04004877 RID: 18551
		[RequiredField]
		[CheckForComponent(typeof(Light))]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004878 RID: 18552
		public Flare lightFlare;
	}
}
