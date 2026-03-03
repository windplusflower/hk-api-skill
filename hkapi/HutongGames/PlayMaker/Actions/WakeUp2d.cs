using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000AEB RID: 2795
	[ActionCategory(ActionCategory.Physics2D)]
	[Tooltip("Forces a Game Object's Rigid Body 2D to wake up.")]
	public class WakeUp2d : ComponentAction<Rigidbody2D>
	{
		// Token: 0x06003C07 RID: 15367 RVA: 0x00159C0D File Offset: 0x00157E0D
		public override void Reset()
		{
			this.gameObject = null;
		}

		// Token: 0x06003C08 RID: 15368 RVA: 0x00159C16 File Offset: 0x00157E16
		public override void OnEnter()
		{
			this.DoWakeUp();
			base.Finish();
		}

		// Token: 0x06003C09 RID: 15369 RVA: 0x00159C24 File Offset: 0x00157E24
		private void DoWakeUp()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (!base.UpdateCache(ownerDefaultTarget))
			{
				return;
			}
			base.rigidbody2d.WakeUp();
		}

		// Token: 0x04003FB2 RID: 16306
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody2D))]
		[Tooltip("The GameObject with a Rigidbody2d attached")]
		public FsmOwnerDefault gameObject;
	}
}
