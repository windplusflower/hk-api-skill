using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009B9 RID: 2489
	[ActionCategory("Enemy AI")]
	[Tooltip("Try to keep a certain distance from target. Optionally try to stay on left or right of target")]
	public class DistanceFlyV2 : RigidBody2dActionBase
	{
		// Token: 0x0600367B RID: 13947 RVA: 0x0014146A File Offset: 0x0013F66A
		public override void Reset()
		{
			this.gameObject = null;
			this.target = null;
			this.targetsHeight = false;
			this.height = null;
			this.acceleration = 0f;
			this.speedMax = 0f;
		}

		// Token: 0x0600367C RID: 13948 RVA: 0x00070581 File Offset: 0x0006E781
		public override void Awake()
		{
			base.Fsm.HandleFixedUpdate = true;
		}

		// Token: 0x0600367D RID: 13949 RVA: 0x00070581 File Offset: 0x0006E781
		public override void OnPreprocess()
		{
			base.Fsm.HandleFixedUpdate = true;
		}

		// Token: 0x0600367E RID: 13950 RVA: 0x001414A8 File Offset: 0x0013F6A8
		public override void OnEnter()
		{
			base.CacheRigidBody2d(base.Fsm.GetOwnerDefaultTarget(this.gameObject));
			this.self = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			this.DoBuzz();
		}

		// Token: 0x0600367F RID: 13951 RVA: 0x001414E3 File Offset: 0x0013F6E3
		public override void OnFixedUpdate()
		{
			this.DoBuzz();
		}

		// Token: 0x06003680 RID: 13952 RVA: 0x001414EC File Offset: 0x0013F6EC
		private void DoBuzz()
		{
			if (this.rb2d == null)
			{
				return;
			}
			this.distanceAway = Mathf.Sqrt(Mathf.Pow(this.self.Value.transform.position.x - this.target.Value.transform.position.x, 2f) + Mathf.Pow(this.self.Value.transform.position.y - this.target.Value.transform.position.y, 2f));
			Vector2 velocity = this.rb2d.velocity;
			if (this.distanceAway > this.distance.Value)
			{
				if (this.stayLeft.Value && this.self.Value.transform.position.x > this.target.Value.transform.position.x + 1f)
				{
					velocity.x -= this.acceleration.Value;
				}
				else if (this.stayRight.Value && this.self.Value.transform.position.x < this.target.Value.transform.position.x - 1f)
				{
					velocity.x += this.acceleration.Value;
				}
				else if (this.self.Value.transform.position.x < this.target.Value.transform.position.x)
				{
					velocity.x += this.acceleration.Value;
				}
				else
				{
					velocity.x -= this.acceleration.Value;
				}
				if (!this.targetsHeight)
				{
					if (this.self.Value.transform.position.y < this.target.Value.transform.position.y)
					{
						velocity.y += this.acceleration.Value;
					}
					else
					{
						velocity.y -= this.acceleration.Value;
					}
				}
			}
			else
			{
				if (this.stayLeft.Value && this.self.Value.transform.position.x > this.target.Value.transform.position.x + 1f)
				{
					velocity.x -= this.acceleration.Value;
				}
				else if (this.stayRight.Value && this.self.Value.transform.position.x < this.target.Value.transform.position.x - 1f)
				{
					velocity.x += this.acceleration.Value;
				}
				else if (this.self.Value.transform.position.x < this.target.Value.transform.position.x)
				{
					velocity.x -= this.acceleration.Value;
				}
				else
				{
					velocity.x += this.acceleration.Value;
				}
				if (!this.targetsHeight)
				{
					if (this.self.Value.transform.position.y < this.target.Value.transform.position.y)
					{
						velocity.y -= this.acceleration.Value;
					}
					else
					{
						velocity.y += this.acceleration.Value;
					}
				}
			}
			if (this.targetsHeight)
			{
				if (this.self.Value.transform.position.y < this.target.Value.transform.position.y + this.height.Value)
				{
					velocity.y += this.acceleration.Value;
				}
				if (this.self.Value.transform.position.y > this.target.Value.transform.position.y + this.height.Value)
				{
					velocity.y -= this.acceleration.Value;
				}
			}
			if (velocity.x > this.speedMax.Value)
			{
				velocity.x = this.speedMax.Value;
			}
			if (velocity.x < -this.speedMax.Value)
			{
				velocity.x = -this.speedMax.Value;
			}
			if (velocity.y > this.speedMax.Value)
			{
				velocity.y = this.speedMax.Value;
			}
			if (velocity.y < -this.speedMax.Value)
			{
				velocity.y = -this.speedMax.Value;
			}
			this.rb2d.velocity = velocity;
		}

		// Token: 0x04003849 RID: 14409
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody2D))]
		[UIHint(UIHint.Variable)]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400384A RID: 14410
		[UIHint(UIHint.Variable)]
		public FsmGameObject target;

		// Token: 0x0400384B RID: 14411
		public FsmFloat distance;

		// Token: 0x0400384C RID: 14412
		public FsmFloat speedMax;

		// Token: 0x0400384D RID: 14413
		public FsmFloat acceleration;

		// Token: 0x0400384E RID: 14414
		[Tooltip("If true, object tries to keep to a certain height relative to target")]
		public bool targetsHeight;

		// Token: 0x0400384F RID: 14415
		public FsmFloat height;

		// Token: 0x04003850 RID: 14416
		public FsmBool stayLeft;

		// Token: 0x04003851 RID: 14417
		public FsmBool stayRight;

		// Token: 0x04003852 RID: 14418
		private float distanceAway;

		// Token: 0x04003853 RID: 14419
		private FsmGameObject self;
	}
}
