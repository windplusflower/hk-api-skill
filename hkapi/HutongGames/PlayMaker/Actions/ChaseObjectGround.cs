using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009A0 RID: 2464
	[ActionCategory("Enemy AI")]
	[Tooltip("Object runs towards target")]
	public class ChaseObjectGround : RigidBody2dActionBase
	{
		// Token: 0x060035FD RID: 13821 RVA: 0x0013E449 File Offset: 0x0013C649
		public override void Reset()
		{
			this.gameObject = null;
			this.target = null;
			this.acceleration = 0f;
			this.speedMax = 0f;
		}

		// Token: 0x060035FE RID: 13822 RVA: 0x00070581 File Offset: 0x0006E781
		public override void Awake()
		{
			base.Fsm.HandleFixedUpdate = true;
		}

		// Token: 0x060035FF RID: 13823 RVA: 0x0013E47C File Offset: 0x0013C67C
		public override void OnEnter()
		{
			base.CacheRigidBody2d(base.Fsm.GetOwnerDefaultTarget(this.gameObject));
			this.self = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			this.animator = this.self.Value.GetComponent<tk2dSpriteAnimator>();
			this.DoChase();
		}

		// Token: 0x06003600 RID: 13824 RVA: 0x00070581 File Offset: 0x0006E781
		public override void OnPreprocess()
		{
			base.Fsm.HandleFixedUpdate = true;
		}

		// Token: 0x06003601 RID: 13825 RVA: 0x0013E4D8 File Offset: 0x0013C6D8
		public override void OnFixedUpdate()
		{
			this.DoChase();
		}

		// Token: 0x06003602 RID: 13826 RVA: 0x0013E4E0 File Offset: 0x0013C6E0
		private void DoChase()
		{
			if (this.rb2d == null)
			{
				return;
			}
			Vector2 velocity = this.rb2d.velocity;
			if (this.self.Value.transform.position.x < this.target.Value.transform.position.x - this.turnRange.Value || this.self.Value.transform.position.x > this.target.Value.transform.position.x + this.turnRange.Value)
			{
				if (this.self.Value.transform.position.x < this.target.Value.transform.position.x)
				{
					velocity.x += this.acceleration.Value;
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
					velocity.x -= this.acceleration.Value;
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
		}

		// Token: 0x040037A8 RID: 14248
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody2D))]
		[UIHint(UIHint.Variable)]
		public FsmOwnerDefault gameObject;

		// Token: 0x040037A9 RID: 14249
		[UIHint(UIHint.Variable)]
		public FsmGameObject target;

		// Token: 0x040037AA RID: 14250
		public FsmFloat speedMax;

		// Token: 0x040037AB RID: 14251
		public FsmFloat acceleration;

		// Token: 0x040037AC RID: 14252
		public bool animateTurnAndRun;

		// Token: 0x040037AD RID: 14253
		public FsmString runAnimation;

		// Token: 0x040037AE RID: 14254
		public FsmString turnAnimation;

		// Token: 0x040037AF RID: 14255
		public FsmFloat turnRange;

		// Token: 0x040037B0 RID: 14256
		private FsmGameObject self;

		// Token: 0x040037B1 RID: 14257
		private tk2dSpriteAnimator animator;

		// Token: 0x040037B2 RID: 14258
		private bool turning;
	}
}
