using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CC8 RID: 3272
	[ActionCategory(ActionCategory.Lights)]
	[Tooltip("Sets the Texture projected by a Light.")]
	public class SetLightCookie : ComponentAction<Light>
	{
		// Token: 0x0600441D RID: 17437 RVA: 0x00174E82 File Offset: 0x00173082
		public override void Reset()
		{
			this.gameObject = null;
			this.lightCookie = null;
		}

		// Token: 0x0600441E RID: 17438 RVA: 0x00174E92 File Offset: 0x00173092
		public override void OnEnter()
		{
			this.DoSetLightCookie();
			base.Finish();
		}

		// Token: 0x0600441F RID: 17439 RVA: 0x00174EA0 File Offset: 0x001730A0
		private void DoSetLightCookie()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (base.UpdateCache(ownerDefaultTarget))
			{
				base.light.cookie = this.lightCookie.Value;
			}
		}

		// Token: 0x04004875 RID: 18549
		[RequiredField]
		[CheckForComponent(typeof(Light))]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004876 RID: 18550
		public FsmTexture lightCookie;
	}
}
