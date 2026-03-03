using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CEC RID: 3308
	[ActionCategory(ActionCategory.Physics)]
	[Tooltip("Forces a Game Object's Rigid Body to Sleep at least one frame.")]
	public class Sleep : ComponentAction<Rigidbody>
	{
		// Token: 0x060044C3 RID: 17603 RVA: 0x00176C7E File Offset: 0x00174E7E
		public override void Reset()
		{
			this.gameObject = null;
		}

		// Token: 0x060044C4 RID: 17604 RVA: 0x00176C87 File Offset: 0x00174E87
		public override void OnEnter()
		{
			this.DoSleep();
			base.Finish();
		}

		// Token: 0x060044C5 RID: 17605 RVA: 0x00176C98 File Offset: 0x00174E98
		private void DoSleep()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (base.UpdateCache(ownerDefaultTarget))
			{
				base.rigidbody.Sleep();
			}
		}

		// Token: 0x04004906 RID: 18694
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody))]
		public FsmOwnerDefault gameObject;
	}
}
