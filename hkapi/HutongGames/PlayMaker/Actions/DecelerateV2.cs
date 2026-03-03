using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009B0 RID: 2480
	[ActionCategory("Enemy AI")]
	[Tooltip("Decelerate X and Y until 0 reached. Multiplies instead of adds.")]
	public class DecelerateV2 : RigidBody2dActionBase
	{
		// Token: 0x06003646 RID: 13894 RVA: 0x001402E8 File Offset: 0x0013E4E8
		public override void Reset()
		{
			this.gameObject = null;
			this.deceleration = 0f;
		}

		// Token: 0x06003647 RID: 13895 RVA: 0x00070581 File Offset: 0x0006E781
		public override void Awake()
		{
			base.Fsm.HandleFixedUpdate = true;
		}

		// Token: 0x06003648 RID: 13896 RVA: 0x00070581 File Offset: 0x0006E781
		public override void OnPreprocess()
		{
			base.Fsm.HandleFixedUpdate = true;
		}

		// Token: 0x06003649 RID: 13897 RVA: 0x00140301 File Offset: 0x0013E501
		public override void OnEnter()
		{
			base.CacheRigidBody2d(base.Fsm.GetOwnerDefaultTarget(this.gameObject));
			this.DecelerateSelf();
		}

		// Token: 0x0600364A RID: 13898 RVA: 0x00140320 File Offset: 0x0013E520
		public override void OnFixedUpdate()
		{
			this.DecelerateSelf();
		}

		// Token: 0x0600364B RID: 13899 RVA: 0x00140328 File Offset: 0x0013E528
		private void DecelerateSelf()
		{
			if (this.rb2d == null)
			{
				return;
			}
			Vector2 velocity = this.rb2d.velocity;
			if (velocity.x < 0f)
			{
				velocity.x *= this.deceleration.Value;
				if (velocity.x > 0f)
				{
					velocity.x = 0f;
				}
			}
			else if (velocity.x > 0f)
			{
				velocity.x *= this.deceleration.Value;
				if (velocity.x < 0f)
				{
					velocity.x = 0f;
				}
			}
			if (velocity.y < 0f)
			{
				velocity.y *= this.deceleration.Value;
				if (velocity.y > 0f)
				{
					velocity.y = 0f;
				}
			}
			else if (velocity.y > 0f)
			{
				velocity.y *= this.deceleration.Value;
				if (velocity.y < 0f)
				{
					velocity.y = 0f;
				}
			}
			this.rb2d.velocity = velocity;
		}

		// Token: 0x0400381E RID: 14366
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody2D))]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400381F RID: 14367
		public FsmFloat deceleration;
	}
}
