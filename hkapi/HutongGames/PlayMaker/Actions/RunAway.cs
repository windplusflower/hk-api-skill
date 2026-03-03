using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A2D RID: 2605
	[ActionCategory("Enemy AI")]
	[Tooltip("Object runs away from target")]
	public class RunAway : RigidBody2dActionBase
	{
		// Token: 0x06003891 RID: 14481 RVA: 0x0014B233 File Offset: 0x00149433
		public override void Reset()
		{
			this.gameObject = null;
			this.target = null;
			this.acceleration = 0f;
			this.speedMax = 0f;
		}

		// Token: 0x06003892 RID: 14482 RVA: 0x00070581 File Offset: 0x0006E781
		public override void Awake()
		{
			base.Fsm.HandleFixedUpdate = true;
		}

		// Token: 0x06003893 RID: 14483 RVA: 0x00070581 File Offset: 0x0006E781
		public override void OnPreprocess()
		{
			base.Fsm.HandleFixedUpdate = true;
		}

		// Token: 0x06003894 RID: 14484 RVA: 0x0014B264 File Offset: 0x00149464
		public override void OnEnter()
		{
			base.CacheRigidBody2d(base.Fsm.GetOwnerDefaultTarget(this.gameObject));
			this.self = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			this.animator = this.self.Value.GetComponent<tk2dSpriteAnimator>();
			this.DoChase();
		}

		// Token: 0x06003895 RID: 14485 RVA: 0x0014B2C0 File Offset: 0x001494C0
		public override void OnFixedUpdate()
		{
			this.DoChase();
		}

		// Token: 0x06003896 RID: 14486 RVA: 0x0014B2C8 File Offset: 0x001494C8
		private void DoChase()
		{
			if (this.rb2d == null)
			{
				return;
			}
			Vector2 velocity = this.rb2d.velocity;
			if (this.self.Value.transform.position.x < this.target.Value.transform.position.x)
			{
				velocity.x -= this.acceleration.Value;
				if (this.animateTurnAndRun)
				{
					if (velocity.x < 0f && !this.turning)
					{
						this.animator.Play(this.turnAnimation.Value);
						this.turning = true;
					}
					if (velocity.x > 0f && this.turning)
					{
						this.animator.Play(this.runAnimation.Value);
						this.turning = false;
					}
				}
			}
			else
			{
				velocity.x += this.acceleration.Value;
				if (this.animateTurnAndRun)
				{
					if (velocity.x > 0f && !this.turning)
					{
						this.animator.Play(this.turnAnimation.Value);
						this.turning = true;
					}
					if (velocity.x < 0f && this.turning)
					{
						this.animator.Play(this.runAnimation.Value);
						this.turning = false;
					}
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
			this.rb2d.velocity = velocity;
		}

		// Token: 0x04003B37 RID: 15159
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody2D))]
		[UIHint(UIHint.Variable)]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003B38 RID: 15160
		[UIHint(UIHint.Variable)]
		public FsmGameObject target;

		// Token: 0x04003B39 RID: 15161
		public FsmFloat speedMax;

		// Token: 0x04003B3A RID: 15162
		public FsmFloat acceleration;

		// Token: 0x04003B3B RID: 15163
		public bool animateTurnAndRun;

		// Token: 0x04003B3C RID: 15164
		public FsmString runAnimation;

		// Token: 0x04003B3D RID: 15165
		public FsmString turnAnimation;

		// Token: 0x04003B3E RID: 15166
		private FsmGameObject self;

		// Token: 0x04003B3F RID: 15167
		private tk2dSpriteAnimator animator;

		// Token: 0x04003B40 RID: 15168
		private bool turning;
	}
}
