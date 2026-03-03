using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A5B RID: 2651
	[ActionCategory("Physics 2d")]
	[Tooltip("Sets the 2d Velocity of a Game Object, using an angle and a speed value. For the angle, 0 is to the right and the degrees increase clockwise.")]
	public class SetVelocityAsAngle : RigidBody2dActionBase
	{
		// Token: 0x06003946 RID: 14662 RVA: 0x0014DB2D File Offset: 0x0014BD2D
		public override void Reset()
		{
			this.gameObject = null;
			this.angle = new FsmFloat
			{
				UseVariable = true
			};
			this.speed = new FsmFloat
			{
				UseVariable = true
			};
			this.everyFrame = false;
		}

		// Token: 0x06003947 RID: 14663 RVA: 0x00070581 File Offset: 0x0006E781
		public override void Awake()
		{
			base.Fsm.HandleFixedUpdate = true;
		}

		// Token: 0x06003948 RID: 14664 RVA: 0x00070581 File Offset: 0x0006E781
		public override void OnPreprocess()
		{
			base.Fsm.HandleFixedUpdate = true;
		}

		// Token: 0x06003949 RID: 14665 RVA: 0x0014DB61 File Offset: 0x0014BD61
		public override void OnEnter()
		{
			base.CacheRigidBody2d(base.Fsm.GetOwnerDefaultTarget(this.gameObject));
			this.DoSetVelocity();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x0600394A RID: 14666 RVA: 0x0014DB8E File Offset: 0x0014BD8E
		public override void OnFixedUpdate()
		{
			this.DoSetVelocity();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x0600394B RID: 14667 RVA: 0x0014DBA4 File Offset: 0x0014BDA4
		private void DoSetVelocity()
		{
			if (this.rb2d == null)
			{
				return;
			}
			this.x = this.speed.Value * Mathf.Cos(this.angle.Value * 0.017453292f);
			this.y = this.speed.Value * Mathf.Sin(this.angle.Value * 0.017453292f);
			Vector2 velocity;
			velocity.x = this.x.Value;
			velocity.y = this.y.Value;
			this.rb2d.velocity = velocity;
		}

		// Token: 0x04003BE8 RID: 15336
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody2D))]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003BE9 RID: 15337
		[RequiredField]
		public FsmFloat angle;

		// Token: 0x04003BEA RID: 15338
		[RequiredField]
		public FsmFloat speed;

		// Token: 0x04003BEB RID: 15339
		private FsmFloat x;

		// Token: 0x04003BEC RID: 15340
		private FsmFloat y;

		// Token: 0x04003BED RID: 15341
		public bool everyFrame;
	}
}
