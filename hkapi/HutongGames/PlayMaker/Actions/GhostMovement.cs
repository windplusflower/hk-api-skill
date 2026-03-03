using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009E0 RID: 2528
	[ActionCategory("Enemy AI")]
	[Tooltip("Movement for swaying ghosts, like zote salubra")]
	public class GhostMovement : RigidBody2dActionBase
	{
		// Token: 0x0600372D RID: 14125 RVA: 0x00144AE0 File Offset: 0x00142CE0
		public override void Reset()
		{
			this.gameObject = null;
			this.xPosMin = null;
			this.xPosMax = null;
			this.accel_x = null;
			this.speedMax_x = null;
			this.yPosMin = null;
			this.yPosMax = null;
			this.accel_y = null;
			this.speedMax_y = null;
			this.target = null;
			this.direction_x = null;
			this.direction_y = null;
		}

		// Token: 0x0600372E RID: 14126 RVA: 0x00070581 File Offset: 0x0006E781
		public override void Awake()
		{
			base.Fsm.HandleFixedUpdate = true;
		}

		// Token: 0x0600372F RID: 14127 RVA: 0x00070581 File Offset: 0x0006E781
		public override void OnPreprocess()
		{
			base.Fsm.HandleFixedUpdate = true;
		}

		// Token: 0x06003730 RID: 14128 RVA: 0x00144B44 File Offset: 0x00142D44
		public override void OnEnter()
		{
			base.CacheRigidBody2d(base.Fsm.GetOwnerDefaultTarget(this.gameObject));
			this.target = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			this.transform = this.target.Value.GetComponent<Transform>();
			this.DoMove();
		}

		// Token: 0x06003731 RID: 14129 RVA: 0x00144BA0 File Offset: 0x00142DA0
		public override void OnFixedUpdate()
		{
			this.DoMove();
		}

		// Token: 0x06003732 RID: 14130 RVA: 0x00144BA8 File Offset: 0x00142DA8
		private void DoMove()
		{
			if (this.rb2d == null)
			{
				return;
			}
			Vector2 velocity = this.rb2d.velocity;
			Vector3 position = this.transform.position;
			if (this.direction_x.Value == 0)
			{
				if (velocity.x > -this.speedMax_x.Value)
				{
					velocity.x -= this.accel_x.Value;
					if (velocity.x < -this.speedMax_x.Value)
					{
						velocity.x = -this.speedMax_x.Value;
					}
				}
				if (position.x < this.xPosMin.Value)
				{
					this.direction_x.Value = 1;
				}
			}
			else
			{
				if (velocity.x < this.speedMax_x.Value)
				{
					velocity.x += this.accel_x.Value;
					if (velocity.x > this.speedMax_x.Value)
					{
						velocity.x = this.speedMax_x.Value;
					}
				}
				if (position.x > this.xPosMax.Value)
				{
					this.direction_x.Value = 0;
				}
			}
			if (this.direction_y.Value == 0)
			{
				if (velocity.y > -this.speedMax_y.Value)
				{
					velocity.y -= this.accel_y.Value;
					if (velocity.y < -this.speedMax_y.Value)
					{
						velocity.y = -this.speedMax_y.Value;
					}
				}
				if (position.y < this.yPosMin.Value)
				{
					this.direction_y.Value = 1;
				}
			}
			else
			{
				if (velocity.y < this.speedMax_y.Value)
				{
					velocity.y += this.accel_y.Value;
					if (velocity.y > this.speedMax_y.Value)
					{
						velocity.y = this.speedMax_y.Value;
					}
				}
				if (position.y > this.yPosMax.Value)
				{
					this.direction_y.Value = 0;
				}
			}
			this.rb2d.velocity = velocity;
		}

		// Token: 0x04003945 RID: 14661
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody2D))]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003946 RID: 14662
		public FsmFloat xPosMin;

		// Token: 0x04003947 RID: 14663
		public FsmFloat xPosMax;

		// Token: 0x04003948 RID: 14664
		public FsmFloat accel_x;

		// Token: 0x04003949 RID: 14665
		public FsmFloat speedMax_x;

		// Token: 0x0400394A RID: 14666
		public FsmFloat yPosMin;

		// Token: 0x0400394B RID: 14667
		public FsmFloat yPosMax;

		// Token: 0x0400394C RID: 14668
		public FsmFloat accel_y;

		// Token: 0x0400394D RID: 14669
		public FsmFloat speedMax_y;

		// Token: 0x0400394E RID: 14670
		private FsmGameObject target;

		// Token: 0x0400394F RID: 14671
		private Transform transform;

		// Token: 0x04003950 RID: 14672
		public FsmInt direction_x;

		// Token: 0x04003951 RID: 14673
		public FsmInt direction_y;
	}
}
