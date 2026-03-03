using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009AF RID: 2479
	[ActionCategory("Enemy AI")]
	[Tooltip("Decelerate X and Y until 0 reached.")]
	public class Decelerate : RigidBody2dActionBase
	{
		// Token: 0x0600363F RID: 13887 RVA: 0x0014017F File Offset: 0x0013E37F
		public override void Reset()
		{
			this.gameObject = null;
			this.deceleration = 0f;
		}

		// Token: 0x06003640 RID: 13888 RVA: 0x00070581 File Offset: 0x0006E781
		public override void OnPreprocess()
		{
			base.Fsm.HandleFixedUpdate = true;
		}

		// Token: 0x06003641 RID: 13889 RVA: 0x00070581 File Offset: 0x0006E781
		public override void Awake()
		{
			base.Fsm.HandleFixedUpdate = true;
		}

		// Token: 0x06003642 RID: 13890 RVA: 0x00140198 File Offset: 0x0013E398
		public override void OnEnter()
		{
			base.CacheRigidBody2d(base.Fsm.GetOwnerDefaultTarget(this.gameObject));
			this.DecelerateSelf();
		}

		// Token: 0x06003643 RID: 13891 RVA: 0x001401B7 File Offset: 0x0013E3B7
		public override void OnFixedUpdate()
		{
			this.DecelerateSelf();
		}

		// Token: 0x06003644 RID: 13892 RVA: 0x001401C0 File Offset: 0x0013E3C0
		private void DecelerateSelf()
		{
			if (this.rb2d == null)
			{
				return;
			}
			Vector2 velocity = this.rb2d.velocity;
			if (velocity.x < 0f)
			{
				velocity.x += this.deceleration.Value;
				if (velocity.x > 0f)
				{
					velocity.x = 0f;
				}
			}
			else if (velocity.x > 0f)
			{
				velocity.x -= this.deceleration.Value;
				if (velocity.x < 0f)
				{
					velocity.x = 0f;
				}
			}
			if (velocity.y < 0f)
			{
				velocity.y += this.deceleration.Value;
				if (velocity.y > 0f)
				{
					velocity.y = 0f;
				}
			}
			else if (velocity.y > 0f)
			{
				velocity.y -= this.deceleration.Value;
				if (velocity.y < 0f)
				{
					velocity.y = 0f;
				}
			}
			this.rb2d.velocity = velocity;
		}

		// Token: 0x0400381C RID: 14364
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody2D))]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400381D RID: 14365
		public FsmFloat deceleration;
	}
}
