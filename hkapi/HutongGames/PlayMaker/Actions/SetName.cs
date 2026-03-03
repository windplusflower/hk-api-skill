using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CD5 RID: 3285
	[ActionCategory(ActionCategory.GameObject)]
	[Tooltip("Sets a Game Object's Name.")]
	public class SetName : FsmStateAction
	{
		// Token: 0x06004455 RID: 17493 RVA: 0x00175786 File Offset: 0x00173986
		public override void Reset()
		{
			this.gameObject = null;
			this.name = null;
		}

		// Token: 0x06004456 RID: 17494 RVA: 0x00175796 File Offset: 0x00173996
		public override void OnEnter()
		{
			this.DoSetLayer();
			base.Finish();
		}

		// Token: 0x06004457 RID: 17495 RVA: 0x001757A4 File Offset: 0x001739A4
		private void DoSetLayer()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			ownerDefaultTarget.name = this.name.Value;
		}

		// Token: 0x0400489F RID: 18591
		[RequiredField]
		public FsmOwnerDefault gameObject;

		// Token: 0x040048A0 RID: 18592
		[RequiredField]
		public FsmString name;
	}
}
