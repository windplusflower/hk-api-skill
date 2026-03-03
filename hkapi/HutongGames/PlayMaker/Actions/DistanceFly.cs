using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009B7 RID: 2487
	[ActionCategory("Enemy AI")]
	[Tooltip("Try to keep a certain distance from target.")]
	public class DistanceFly : RigidBody2dActionBase
	{
		// Token: 0x0600366D RID: 13933 RVA: 0x00140C61 File Offset: 0x0013EE61
		public override void Reset()
		{
			this.gameObject = null;
			this.target = null;
			this.targetsHeight = false;
			this.height = null;
			this.acceleration = 0f;
			this.speedMax = 0f;
		}

		// Token: 0x0600366E RID: 13934 RVA: 0x00070581 File Offset: 0x0006E781
		public override void Awake()
		{
			base.Fsm.HandleFixedUpdate = true;
		}

		// Token: 0x0600366F RID: 13935 RVA: 0x00070581 File Offset: 0x0006E781
		public override void OnPreprocess()
		{
			base.Fsm.HandleFixedUpdate = true;
		}

		// Token: 0x06003670 RID: 13936 RVA: 0x00140C9F File Offset: 0x0013EE9F
		public override void OnEnter()
		{
			base.CacheRigidBody2d(base.Fsm.GetOwnerDefaultTarget(this.gameObject));
			this.self = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			this.DoBuzz();
		}

		// Token: 0x06003671 RID: 13937 RVA: 0x00140CDA File Offset: 0x0013EEDA
		public override void OnFixedUpdate()
		{
			this.DoBuzz();
		}

		// Token: 0x06003672 RID: 13938 RVA: 0x00140CE4 File Offset: 0x0013EEE4
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
				if (this.self.Value.transform.position.x < this.target.Value.transform.position.x)
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
				if (this.self.Value.transform.position.x < this.target.Value.transform.position.x)
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

		// Token: 0x04003836 RID: 14390
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody2D))]
		[UIHint(UIHint.Variable)]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003837 RID: 14391
		[UIHint(UIHint.Variable)]
		public FsmGameObject target;

		// Token: 0x04003838 RID: 14392
		public FsmFloat distance;

		// Token: 0x04003839 RID: 14393
		public FsmFloat speedMax;

		// Token: 0x0400383A RID: 14394
		public FsmFloat acceleration;

		// Token: 0x0400383B RID: 14395
		[Tooltip("If true, object tries to keep to a certain height relative to target")]
		public bool targetsHeight;

		// Token: 0x0400383C RID: 14396
		public FsmFloat height;

		// Token: 0x0400383D RID: 14397
		private float distanceAway;

		// Token: 0x0400383E RID: 14398
		private FsmGameObject self;
	}
}
