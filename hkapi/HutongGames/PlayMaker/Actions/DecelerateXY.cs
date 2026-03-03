using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009B1 RID: 2481
	[ActionCategory("Enemy AI")]
	[Tooltip("Decelerate X and Y separately. Uses multiplication.")]
	public class DecelerateXY : RigidBody2dActionBase
	{
		// Token: 0x0600364D RID: 13901 RVA: 0x00140450 File Offset: 0x0013E650
		public override void Reset()
		{
			this.gameObject = null;
			this.decelerationX = null;
			this.decelerationY = null;
		}

		// Token: 0x0600364E RID: 13902 RVA: 0x00070581 File Offset: 0x0006E781
		public override void Awake()
		{
			base.Fsm.HandleFixedUpdate = true;
		}

		// Token: 0x0600364F RID: 13903 RVA: 0x00070581 File Offset: 0x0006E781
		public override void OnPreprocess()
		{
			base.Fsm.HandleFixedUpdate = true;
		}

		// Token: 0x06003650 RID: 13904 RVA: 0x00140467 File Offset: 0x0013E667
		public override void OnEnter()
		{
			base.CacheRigidBody2d(base.Fsm.GetOwnerDefaultTarget(this.gameObject));
			this.DecelerateSelf();
		}

		// Token: 0x06003651 RID: 13905 RVA: 0x00140486 File Offset: 0x0013E686
		public override void OnFixedUpdate()
		{
			this.DecelerateSelf();
		}

		// Token: 0x06003652 RID: 13906 RVA: 0x00140490 File Offset: 0x0013E690
		private void DecelerateSelf()
		{
			if (this.rb2d == null)
			{
				return;
			}
			Vector2 velocity = this.rb2d.velocity;
			if (!this.decelerationX.IsNone)
			{
				if (velocity.x < 0f)
				{
					velocity.x *= this.decelerationX.Value;
					if (velocity.x > 0f)
					{
						velocity.x = 0f;
					}
				}
				else if (velocity.x > 0f)
				{
					velocity.x *= this.decelerationX.Value;
					if (velocity.x < 0f)
					{
						velocity.x = 0f;
					}
				}
				if (velocity.x < 0.001f && velocity.x > -0.001f)
				{
					velocity.x = 0f;
				}
			}
			if (!this.decelerationY.IsNone)
			{
				if (velocity.y < 0f)
				{
					velocity.y *= this.decelerationY.Value;
					if (velocity.y > 0f)
					{
						velocity.y = 0f;
					}
				}
				else if (velocity.y > 0f)
				{
					velocity.y *= this.decelerationY.Value;
					if (velocity.y < 0f)
					{
						velocity.y = 0f;
					}
				}
				if (velocity.y < 0.001f && velocity.y > -0.001f)
				{
					velocity.y = 0f;
				}
			}
			this.rb2d.velocity = velocity;
		}

		// Token: 0x04003820 RID: 14368
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody2D))]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003821 RID: 14369
		public FsmFloat decelerationX;

		// Token: 0x04003822 RID: 14370
		public FsmFloat decelerationY;
	}
}
