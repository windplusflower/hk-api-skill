using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CE1 RID: 3297
	[ActionCategory(ActionCategory.Lights)]
	[Tooltip("Sets the strength of the shadows cast by a Light.")]
	public class SetShadowStrength : ComponentAction<Light>
	{
		// Token: 0x0600448E RID: 17550 RVA: 0x001762E8 File Offset: 0x001744E8
		public override void Reset()
		{
			this.gameObject = null;
			this.shadowStrength = 0.8f;
			this.everyFrame = false;
		}

		// Token: 0x0600448F RID: 17551 RVA: 0x00176308 File Offset: 0x00174508
		public override void OnEnter()
		{
			this.DoSetShadowStrength();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004490 RID: 17552 RVA: 0x0017631E File Offset: 0x0017451E
		public override void OnUpdate()
		{
			this.DoSetShadowStrength();
		}

		// Token: 0x06004491 RID: 17553 RVA: 0x00176328 File Offset: 0x00174528
		private void DoSetShadowStrength()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (base.UpdateCache(ownerDefaultTarget))
			{
				base.light.shadowStrength = this.shadowStrength.Value;
			}
		}

		// Token: 0x040048D7 RID: 18647
		[RequiredField]
		[CheckForComponent(typeof(Light))]
		public FsmOwnerDefault gameObject;

		// Token: 0x040048D8 RID: 18648
		public FsmFloat shadowStrength;

		// Token: 0x040048D9 RID: 18649
		public bool everyFrame;
	}
}
