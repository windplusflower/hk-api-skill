using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000AD2 RID: 2770
	[ActionCategory("Physics 2d")]
	[Tooltip("Gets the 2d Velocity of a Game Object and stores it in a Vector2 Variable or each Axis in a Float Variable. NOTE: The Game Object must have a Rigid Body 2D.")]
	public class GetVelocityAsAngle : RigidBody2dActionBase
	{
		// Token: 0x06003B8C RID: 15244 RVA: 0x00157B28 File Offset: 0x00155D28
		public override void Reset()
		{
			this.storeAngle = null;
			this.everyFrame = false;
		}

		// Token: 0x06003B8D RID: 15245 RVA: 0x00157B38 File Offset: 0x00155D38
		public override void OnEnter()
		{
			base.CacheRigidBody2d(base.Fsm.GetOwnerDefaultTarget(this.gameObject));
			this.DoGetVelocity();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003B8E RID: 15246 RVA: 0x00157B65 File Offset: 0x00155D65
		public override void OnUpdate()
		{
			this.DoGetVelocity();
		}

		// Token: 0x06003B8F RID: 15247 RVA: 0x00157B70 File Offset: 0x00155D70
		private void DoGetVelocity()
		{
			if (this.rb2d == null)
			{
				return;
			}
			Vector2 velocity = this.rb2d.velocity;
			float num = Mathf.Atan2(velocity.x, -velocity.y) * 180f / 3.1415927f - 90f;
			if (num < 0f)
			{
				num += 360f;
			}
			this.storeAngle.Value = num;
		}

		// Token: 0x04003F17 RID: 16151
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody2D))]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003F18 RID: 16152
		[UIHint(UIHint.Variable)]
		public FsmFloat storeAngle;

		// Token: 0x04003F19 RID: 16153
		public bool everyFrame;
	}
}
