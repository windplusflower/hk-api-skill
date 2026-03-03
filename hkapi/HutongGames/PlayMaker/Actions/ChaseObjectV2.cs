using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009A1 RID: 2465
	[ActionCategory("Enemy AI")]
	[Tooltip("Object moves more directly toward target")]
	public class ChaseObjectV2 : RigidBody2dActionBase
	{
		// Token: 0x06003604 RID: 13828 RVA: 0x0013E734 File Offset: 0x0013C934
		public override void Reset()
		{
			this.gameObject = null;
			this.target = null;
			this.accelerationForce = 0f;
			this.speedMax = 0f;
			this.offsetX = 0f;
			this.offsetY = 0f;
		}

		// Token: 0x06003605 RID: 13829 RVA: 0x00070581 File Offset: 0x0006E781
		public override void Awake()
		{
			base.Fsm.HandleFixedUpdate = true;
		}

		// Token: 0x06003606 RID: 13830 RVA: 0x00070581 File Offset: 0x0006E781
		public override void OnPreprocess()
		{
			base.Fsm.HandleFixedUpdate = true;
		}

		// Token: 0x06003607 RID: 13831 RVA: 0x0013E78F File Offset: 0x0013C98F
		public override void OnEnter()
		{
			base.CacheRigidBody2d(base.Fsm.GetOwnerDefaultTarget(this.gameObject));
			this.self = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			this.DoChase();
		}

		// Token: 0x06003608 RID: 13832 RVA: 0x0013E7CA File Offset: 0x0013C9CA
		public override void OnFixedUpdate()
		{
			this.DoChase();
		}

		// Token: 0x06003609 RID: 13833 RVA: 0x0013E7D4 File Offset: 0x0013C9D4
		private void DoChase()
		{
			if (this.rb2d == null)
			{
				return;
			}
			Vector2 vector = new Vector2(this.target.Value.transform.position.x + this.offsetX.Value - this.self.Value.transform.position.x, this.target.Value.transform.position.y + this.offsetY.Value - this.self.Value.transform.position.y);
			vector = Vector2.ClampMagnitude(vector, 1f);
			vector = new Vector2(vector.x * this.accelerationForce.Value, vector.y * this.accelerationForce.Value);
			this.rb2d.AddForce(vector);
			Vector2 vector2 = this.rb2d.velocity;
			vector2 = Vector2.ClampMagnitude(vector2, this.speedMax.Value);
			this.rb2d.velocity = vector2;
		}

		// Token: 0x040037B3 RID: 14259
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody2D))]
		[UIHint(UIHint.Variable)]
		public FsmOwnerDefault gameObject;

		// Token: 0x040037B4 RID: 14260
		[UIHint(UIHint.Variable)]
		public FsmGameObject target;

		// Token: 0x040037B5 RID: 14261
		public FsmFloat speedMax;

		// Token: 0x040037B6 RID: 14262
		public FsmFloat accelerationForce;

		// Token: 0x040037B7 RID: 14263
		public FsmFloat offsetX;

		// Token: 0x040037B8 RID: 14264
		public FsmFloat offsetY;

		// Token: 0x040037B9 RID: 14265
		private FsmGameObject self;
	}
}
