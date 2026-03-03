using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000AE1 RID: 2785
	[Obsolete("This action is obsolete; use Constraints instead.")]
	[ActionCategory(ActionCategory.Physics2D)]
	[Tooltip("Controls whether the rigidbody 2D should be prevented from rotating")]
	public class SetIsFixedAngle2d : ComponentAction<Rigidbody2D>
	{
		// Token: 0x06003BD3 RID: 15315 RVA: 0x00158F7B File Offset: 0x0015717B
		public override void Reset()
		{
			this.gameObject = null;
			this.isFixedAngle = false;
			this.everyFrame = false;
		}

		// Token: 0x06003BD4 RID: 15316 RVA: 0x00158F97 File Offset: 0x00157197
		public override void OnEnter()
		{
			this.DoSetIsFixedAngle();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003BD5 RID: 15317 RVA: 0x00158FAD File Offset: 0x001571AD
		public override void OnUpdate()
		{
			this.DoSetIsFixedAngle();
		}

		// Token: 0x06003BD6 RID: 15318 RVA: 0x00158FB8 File Offset: 0x001571B8
		private void DoSetIsFixedAngle()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (!base.UpdateCache(ownerDefaultTarget))
			{
				return;
			}
			if (this.isFixedAngle.Value)
			{
				base.rigidbody2d.constraints = (base.rigidbody2d.constraints | RigidbodyConstraints2D.FreezeRotation);
				return;
			}
			base.rigidbody2d.constraints = (base.rigidbody2d.constraints & ~RigidbodyConstraints2D.FreezeRotation);
		}

		// Token: 0x04003F83 RID: 16259
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody2D))]
		[Tooltip("The GameObject with the Rigidbody2D attached")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003F84 RID: 16260
		[RequiredField]
		[Tooltip("The flag value")]
		public FsmBool isFixedAngle;

		// Token: 0x04003F85 RID: 16261
		[Tooltip("Repeat every frame.")]
		public bool everyFrame;
	}
}
