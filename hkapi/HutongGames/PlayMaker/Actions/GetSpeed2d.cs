using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000ACF RID: 2767
	[ActionCategory(ActionCategory.Physics2D)]
	[Tooltip("Gets the 2d Speed of a Game Object and stores it in a Float Variable. NOTE: The Game Object must have a rigid body 2D.")]
	public class GetSpeed2d : ComponentAction<Rigidbody2D>
	{
		// Token: 0x06003B7E RID: 15230 RVA: 0x0015790E File Offset: 0x00155B0E
		public override void Reset()
		{
			this.gameObject = null;
			this.storeResult = null;
			this.everyFrame = false;
		}

		// Token: 0x06003B7F RID: 15231 RVA: 0x00157925 File Offset: 0x00155B25
		public override void OnEnter()
		{
			this.DoGetSpeed();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003B80 RID: 15232 RVA: 0x0015793B File Offset: 0x00155B3B
		public override void OnUpdate()
		{
			this.DoGetSpeed();
		}

		// Token: 0x06003B81 RID: 15233 RVA: 0x00157944 File Offset: 0x00155B44
		private void DoGetSpeed()
		{
			if (this.storeResult.IsNone)
			{
				return;
			}
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (!base.UpdateCache(ownerDefaultTarget))
			{
				return;
			}
			this.storeResult.Value = base.rigidbody2d.velocity.magnitude;
		}

		// Token: 0x04003F0B RID: 16139
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody2D))]
		[Tooltip("The GameObject with the Rigidbody2D attached")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003F0C RID: 16140
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The speed, or in technical terms: velocity magnitude")]
		public FsmFloat storeResult;

		// Token: 0x04003F0D RID: 16141
		[Tooltip("Repeat every frame.")]
		public bool everyFrame;
	}
}
