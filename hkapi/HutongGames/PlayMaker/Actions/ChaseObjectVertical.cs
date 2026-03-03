using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009A2 RID: 2466
	[ActionCategory("Enemy AI")]
	[Tooltip("Object chases target on Y axis")]
	public class ChaseObjectVertical : RigidBody2dActionBase
	{
		// Token: 0x0600360B RID: 13835 RVA: 0x0013E8E6 File Offset: 0x0013CAE6
		public override void Reset()
		{
			this.gameObject = null;
			this.target = null;
			this.acceleration = 0f;
			this.speedMax = 0f;
		}

		// Token: 0x0600360C RID: 13836 RVA: 0x00070581 File Offset: 0x0006E781
		public override void Awake()
		{
			base.Fsm.HandleFixedUpdate = true;
		}

		// Token: 0x0600360D RID: 13837 RVA: 0x00070581 File Offset: 0x0006E781
		public override void OnPreprocess()
		{
			base.Fsm.HandleFixedUpdate = true;
		}

		// Token: 0x0600360E RID: 13838 RVA: 0x0013E916 File Offset: 0x0013CB16
		public override void OnEnter()
		{
			base.CacheRigidBody2d(base.Fsm.GetOwnerDefaultTarget(this.gameObject));
			this.self = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			this.DoChase();
		}

		// Token: 0x0600360F RID: 13839 RVA: 0x0013E951 File Offset: 0x0013CB51
		public override void OnFixedUpdate()
		{
			this.DoChase();
		}

		// Token: 0x06003610 RID: 13840 RVA: 0x0013E95C File Offset: 0x0013CB5C
		private void DoChase()
		{
			if (this.rb2d == null)
			{
				return;
			}
			Vector2 velocity = this.rb2d.velocity;
			if (this.self.Value.transform.position.y < this.target.Value.transform.position.y || this.self.Value.transform.position.y > this.target.Value.transform.position.y)
			{
				if (this.self.Value.transform.position.y < this.target.Value.transform.position.y)
				{
					velocity.y += this.acceleration.Value;
				}
				else
				{
					velocity.y -= this.acceleration.Value;
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
		}

		// Token: 0x040037BA RID: 14266
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody2D))]
		[UIHint(UIHint.Variable)]
		public FsmOwnerDefault gameObject;

		// Token: 0x040037BB RID: 14267
		[UIHint(UIHint.Variable)]
		public FsmGameObject target;

		// Token: 0x040037BC RID: 14268
		public FsmFloat speedMax;

		// Token: 0x040037BD RID: 14269
		public FsmFloat acceleration;

		// Token: 0x040037BE RID: 14270
		private FsmGameObject self;

		// Token: 0x040037BF RID: 14271
		private bool turning;
	}
}
