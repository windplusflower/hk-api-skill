using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CE4 RID: 3300
	[ActionCategory(ActionCategory.GameObject)]
	[Tooltip("Sets a Game Object's Tag.")]
	public class SetTag : FsmStateAction
	{
		// Token: 0x0600449C RID: 17564 RVA: 0x00176400 File Offset: 0x00174600
		public override void Reset()
		{
			this.gameObject = null;
			this.tag = "Untagged";
		}

		// Token: 0x0600449D RID: 17565 RVA: 0x0017641C File Offset: 0x0017461C
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget != null)
			{
				ownerDefaultTarget.tag = this.tag.Value;
			}
			base.Finish();
		}

		// Token: 0x040048DF RID: 18655
		public FsmOwnerDefault gameObject;

		// Token: 0x040048E0 RID: 18656
		[UIHint(UIHint.Tag)]
		public FsmString tag;
	}
}
