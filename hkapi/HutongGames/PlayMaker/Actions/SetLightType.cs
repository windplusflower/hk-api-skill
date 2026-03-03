using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CCD RID: 3277
	[ActionCategory(ActionCategory.Lights)]
	[Tooltip("Set Spot, Directional, or Point Light type.")]
	public class SetLightType : ComponentAction<Light>
	{
		// Token: 0x06004434 RID: 17460 RVA: 0x001750AA File Offset: 0x001732AA
		public override void Reset()
		{
			this.gameObject = null;
			this.lightType = LightType.Point;
		}

		// Token: 0x06004435 RID: 17461 RVA: 0x001750C4 File Offset: 0x001732C4
		public override void OnEnter()
		{
			this.DoSetLightType();
			base.Finish();
		}

		// Token: 0x06004436 RID: 17462 RVA: 0x001750D4 File Offset: 0x001732D4
		private void DoSetLightType()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (base.UpdateCache(ownerDefaultTarget))
			{
				base.light.type = (LightType)this.lightType.Value;
			}
		}

		// Token: 0x04004882 RID: 18562
		[RequiredField]
		[CheckForComponent(typeof(Light))]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004883 RID: 18563
		[ObjectType(typeof(LightType))]
		public FsmEnum lightType;
	}
}
