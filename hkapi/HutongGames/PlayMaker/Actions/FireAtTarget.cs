using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009BF RID: 2495
	[ActionCategory("Enemy AI")]
	[Tooltip("Travel in a straight line towards target at set speed.")]
	public class FireAtTarget : RigidBody2dActionBase
	{
		// Token: 0x060036A2 RID: 13986 RVA: 0x0014274E File Offset: 0x0014094E
		public override void Reset()
		{
			this.gameObject = null;
			this.target = null;
			this.speed = new FsmFloat
			{
				UseVariable = true
			};
			this.everyFrame = false;
		}

		// Token: 0x060036A3 RID: 13987 RVA: 0x00070581 File Offset: 0x0006E781
		public override void Awake()
		{
			base.Fsm.HandleFixedUpdate = true;
		}

		// Token: 0x060036A4 RID: 13988 RVA: 0x00070581 File Offset: 0x0006E781
		public override void OnPreprocess()
		{
			base.Fsm.HandleFixedUpdate = true;
		}

		// Token: 0x060036A5 RID: 13989 RVA: 0x00142778 File Offset: 0x00140978
		public override void OnEnter()
		{
			this.self = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			base.CacheRigidBody2d(base.Fsm.GetOwnerDefaultTarget(this.gameObject));
			this.DoSetVelocity();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060036A6 RID: 13990 RVA: 0x001427CC File Offset: 0x001409CC
		public override void OnFixedUpdate()
		{
			this.DoSetVelocity();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060036A7 RID: 13991 RVA: 0x001427E4 File Offset: 0x001409E4
		private void DoSetVelocity()
		{
			if (this.rb2d == null)
			{
				return;
			}
			float num = this.target.Value.transform.position.y + this.position.Value.y - this.self.Value.transform.position.y;
			float num2 = this.target.Value.transform.position.x + this.position.Value.x - this.self.Value.transform.position.x;
			float num3 = Mathf.Atan2(num, num2) * 57.295776f;
			if (!this.spread.IsNone)
			{
				num3 += UnityEngine.Random.Range(-this.spread.Value, this.spread.Value);
			}
			this.x = this.speed.Value * Mathf.Cos(num3 * 0.017453292f);
			this.y = this.speed.Value * Mathf.Sin(num3 * 0.017453292f);
			Vector2 velocity;
			velocity.x = this.x.Value;
			velocity.y = this.y.Value;
			this.rb2d.velocity = velocity;
		}

		// Token: 0x04003882 RID: 14466
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody2D))]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003883 RID: 14467
		[RequiredField]
		public FsmGameObject target;

		// Token: 0x04003884 RID: 14468
		[RequiredField]
		public FsmFloat speed;

		// Token: 0x04003885 RID: 14469
		public FsmVector3 position;

		// Token: 0x04003886 RID: 14470
		public FsmFloat spread;

		// Token: 0x04003887 RID: 14471
		private FsmGameObject self;

		// Token: 0x04003888 RID: 14472
		private FsmFloat x;

		// Token: 0x04003889 RID: 14473
		private FsmFloat y;

		// Token: 0x0400388A RID: 14474
		public bool everyFrame;
	}
}
