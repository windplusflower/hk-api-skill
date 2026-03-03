using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A5F RID: 2655
	[ActionCategory("Enemy AI")]
	[Tooltip("Flies and keeps a certain distance from target, with smoother movement")]
	public class SmoothFlyTo : RigidBody2dActionBase
	{
		// Token: 0x0600395D RID: 14685 RVA: 0x0014E0C9 File Offset: 0x0014C2C9
		public override void Reset()
		{
			this.gameObject = null;
			this.target = null;
			this.accelerationForce = 0f;
			this.speedMax = 0f;
		}

		// Token: 0x0600395E RID: 14686 RVA: 0x00070581 File Offset: 0x0006E781
		public override void Awake()
		{
			base.Fsm.HandleFixedUpdate = true;
		}

		// Token: 0x0600395F RID: 14687 RVA: 0x00070581 File Offset: 0x0006E781
		public override void OnPreprocess()
		{
			base.Fsm.HandleFixedUpdate = true;
		}

		// Token: 0x06003960 RID: 14688 RVA: 0x0014E0F9 File Offset: 0x0014C2F9
		public override void OnEnter()
		{
			base.CacheRigidBody2d(base.Fsm.GetOwnerDefaultTarget(this.gameObject));
			this.self = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			this.DoChase();
		}

		// Token: 0x06003961 RID: 14689 RVA: 0x0014E134 File Offset: 0x0014C334
		public override void OnFixedUpdate()
		{
			this.DoChase();
		}

		// Token: 0x06003962 RID: 14690 RVA: 0x0014E13C File Offset: 0x0014C33C
		private void DoChase()
		{
			if (this.rb2d == null)
			{
				return;
			}
			this.distanceAway = Mathf.Sqrt(Mathf.Pow(this.self.Value.transform.position.x - (this.target.Value.transform.position.x + this.offset.Value.x), 2f) + Mathf.Pow(this.self.Value.transform.position.y - (this.target.Value.transform.position.y + this.offset.Value.y), 2f));
			Vector2 vector = this.rb2d.velocity;
			if (this.distanceAway <= this.distance.Value - this.targetRadius.Value || this.distanceAway >= this.distance.Value + this.targetRadius.Value)
			{
				Vector2 vector2 = new Vector2(this.target.Value.transform.position.x + this.offset.Value.x - this.self.Value.transform.position.x, this.target.Value.transform.position.y + this.offset.Value.y - this.self.Value.transform.position.y);
				vector2 = Vector2.ClampMagnitude(vector2, 1f);
				vector2 = new Vector2(vector2.x * this.accelerationForce.Value, vector2.y * this.accelerationForce.Value);
				if (this.distanceAway < this.distance.Value)
				{
					vector2 = new Vector2(-vector2.x, -vector2.y);
				}
				this.rb2d.AddForce(vector2);
				vector = Vector2.ClampMagnitude(vector, this.speedMax.Value);
				this.rb2d.velocity = vector;
				return;
			}
			vector = this.rb2d.velocity;
			if (vector.x < 0f)
			{
				vector.x *= this.deceleration.Value;
				if (vector.x > 0f)
				{
					vector.x = 0f;
				}
			}
			else if (vector.x > 0f)
			{
				vector.x *= this.deceleration.Value;
				if (vector.x < 0f)
				{
					vector.x = 0f;
				}
			}
			if (vector.y < 0f)
			{
				vector.y *= this.deceleration.Value;
				if (vector.y > 0f)
				{
					vector.y = 0f;
				}
			}
			else if (vector.y > 0f)
			{
				vector.y *= this.deceleration.Value;
				if (vector.y < 0f)
				{
					vector.y = 0f;
				}
			}
			this.rb2d.velocity = vector;
		}

		// Token: 0x04003C02 RID: 15362
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody2D))]
		[UIHint(UIHint.Variable)]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003C03 RID: 15363
		[UIHint(UIHint.Variable)]
		public FsmGameObject target;

		// Token: 0x04003C04 RID: 15364
		public FsmFloat distance;

		// Token: 0x04003C05 RID: 15365
		public FsmFloat speedMax;

		// Token: 0x04003C06 RID: 15366
		public FsmFloat accelerationForce;

		// Token: 0x04003C07 RID: 15367
		public FsmFloat targetRadius;

		// Token: 0x04003C08 RID: 15368
		public FsmFloat deceleration;

		// Token: 0x04003C09 RID: 15369
		public FsmVector3 offset;

		// Token: 0x04003C0A RID: 15370
		private float distanceAway;

		// Token: 0x04003C0B RID: 15371
		private FsmGameObject self;
	}
}
