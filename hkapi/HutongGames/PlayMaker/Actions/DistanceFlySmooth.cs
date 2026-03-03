using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009B8 RID: 2488
	[ActionCategory("Enemy AI")]
	[Tooltip("Flies and keeps a certain distance from target, with smoother movement")]
	public class DistanceFlySmooth : RigidBody2dActionBase
	{
		// Token: 0x06003674 RID: 13940 RVA: 0x001410B6 File Offset: 0x0013F2B6
		public override void Reset()
		{
			this.gameObject = null;
			this.target = null;
			this.accelerationForce = 0f;
			this.speedMax = 0f;
		}

		// Token: 0x06003675 RID: 13941 RVA: 0x00070581 File Offset: 0x0006E781
		public override void Awake()
		{
			base.Fsm.HandleFixedUpdate = true;
		}

		// Token: 0x06003676 RID: 13942 RVA: 0x00070581 File Offset: 0x0006E781
		public override void OnPreprocess()
		{
			base.Fsm.HandleFixedUpdate = true;
		}

		// Token: 0x06003677 RID: 13943 RVA: 0x001410E6 File Offset: 0x0013F2E6
		public override void OnEnter()
		{
			base.CacheRigidBody2d(base.Fsm.GetOwnerDefaultTarget(this.gameObject));
			this.self = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			this.DoChase();
		}

		// Token: 0x06003678 RID: 13944 RVA: 0x00141121 File Offset: 0x0013F321
		public override void OnFixedUpdate()
		{
			this.DoChase();
		}

		// Token: 0x06003679 RID: 13945 RVA: 0x0014112C File Offset: 0x0013F32C
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

		// Token: 0x0400383F RID: 14399
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody2D))]
		[UIHint(UIHint.Variable)]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003840 RID: 14400
		[UIHint(UIHint.Variable)]
		public FsmGameObject target;

		// Token: 0x04003841 RID: 14401
		public FsmFloat distance;

		// Token: 0x04003842 RID: 14402
		public FsmFloat speedMax;

		// Token: 0x04003843 RID: 14403
		public FsmFloat accelerationForce;

		// Token: 0x04003844 RID: 14404
		public FsmFloat targetRadius;

		// Token: 0x04003845 RID: 14405
		public FsmFloat deceleration;

		// Token: 0x04003846 RID: 14406
		public FsmVector3 offset;

		// Token: 0x04003847 RID: 14407
		private float distanceAway;

		// Token: 0x04003848 RID: 14408
		private FsmGameObject self;
	}
}
