using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000AE6 RID: 2790
	[ActionCategory(ActionCategory.Physics2D)]
	[Tooltip("Forces a Game Object's Rigid Body 2D to Sleep at least one frame.")]
	public class Sleep2d : ComponentAction<Rigidbody2D>
	{
		// Token: 0x06003BEC RID: 15340 RVA: 0x00159321 File Offset: 0x00157521
		public override void Reset()
		{
			this.gameObject = null;
		}

		// Token: 0x06003BED RID: 15341 RVA: 0x0015932A File Offset: 0x0015752A
		public override void OnEnter()
		{
			this.DoSleep();
			base.Finish();
		}

		// Token: 0x06003BEE RID: 15342 RVA: 0x00159338 File Offset: 0x00157538
		private void DoSleep()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (!base.UpdateCache(ownerDefaultTarget))
			{
				return;
			}
			base.rigidbody2d.Sleep();
		}

		// Token: 0x04003F95 RID: 16277
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody2D))]
		[Tooltip("The GameObject with a Rigidbody2d attached")]
		public FsmOwnerDefault gameObject;
	}
}
