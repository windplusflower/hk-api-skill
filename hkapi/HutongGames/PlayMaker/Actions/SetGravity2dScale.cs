using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000AE0 RID: 2784
	[ActionCategory(ActionCategory.Physics2D)]
	[Tooltip("Sets The degree to which this object is affected by gravity.  NOTE: Game object must have a rigidbody 2D.")]
	public class SetGravity2dScale : ComponentAction<Rigidbody2D>
	{
		// Token: 0x06003BCF RID: 15311 RVA: 0x00158F15 File Offset: 0x00157115
		public override void Reset()
		{
			this.gameObject = null;
			this.gravityScale = 1f;
		}

		// Token: 0x06003BD0 RID: 15312 RVA: 0x00158F2E File Offset: 0x0015712E
		public override void OnEnter()
		{
			this.DoSetGravityScale();
			base.Finish();
		}

		// Token: 0x06003BD1 RID: 15313 RVA: 0x00158F3C File Offset: 0x0015713C
		private void DoSetGravityScale()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (!base.UpdateCache(ownerDefaultTarget))
			{
				return;
			}
			base.rigidbody2d.gravityScale = this.gravityScale.Value;
		}

		// Token: 0x04003F81 RID: 16257
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody2D))]
		[Tooltip("The GameObject with a Rigidbody 2d attached")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003F82 RID: 16258
		[RequiredField]
		[Tooltip("The gravity scale effect")]
		public FsmFloat gravityScale;
	}
}
