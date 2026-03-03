using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CCB RID: 3275
	[ActionCategory(ActionCategory.Lights)]
	[Tooltip("Sets the Range of a Light.")]
	public class SetLightRange : ComponentAction<Light>
	{
		// Token: 0x0600442A RID: 17450 RVA: 0x00174FB2 File Offset: 0x001731B2
		public override void Reset()
		{
			this.gameObject = null;
			this.lightRange = 20f;
			this.everyFrame = false;
		}

		// Token: 0x0600442B RID: 17451 RVA: 0x00174FD2 File Offset: 0x001731D2
		public override void OnEnter()
		{
			this.DoSetLightRange();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x0600442C RID: 17452 RVA: 0x00174FE8 File Offset: 0x001731E8
		public override void OnUpdate()
		{
			this.DoSetLightRange();
		}

		// Token: 0x0600442D RID: 17453 RVA: 0x00174FF0 File Offset: 0x001731F0
		private void DoSetLightRange()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (base.UpdateCache(ownerDefaultTarget))
			{
				base.light.range = this.lightRange.Value;
			}
		}

		// Token: 0x0400487C RID: 18556
		[RequiredField]
		[CheckForComponent(typeof(Light))]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400487D RID: 18557
		public FsmFloat lightRange;

		// Token: 0x0400487E RID: 18558
		public bool everyFrame;
	}
}
