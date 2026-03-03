using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x0200099F RID: 2463
	[ActionCategory("Enemy AI")]
	[Tooltip("Object buzzes towards target")]
	public class ChaseObject : RigidBody2dActionBase
	{
		// Token: 0x060035F6 RID: 13814 RVA: 0x0013E18A File Offset: 0x0013C38A
		public override void Reset()
		{
			this.gameObject = null;
			this.target = null;
			this.acceleration = 0f;
			this.speedMax = 0f;
		}

		// Token: 0x060035F7 RID: 13815 RVA: 0x00070581 File Offset: 0x0006E781
		public override void Awake()
		{
			base.Fsm.HandleFixedUpdate = true;
		}

		// Token: 0x060035F8 RID: 13816 RVA: 0x00070581 File Offset: 0x0006E781
		public override void OnPreprocess()
		{
			base.Fsm.HandleFixedUpdate = true;
		}

		// Token: 0x060035F9 RID: 13817 RVA: 0x0013E1BA File Offset: 0x0013C3BA
		public override void OnEnter()
		{
			base.CacheRigidBody2d(base.Fsm.GetOwnerDefaultTarget(this.gameObject));
			this.self = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			this.DoBuzz();
		}

		// Token: 0x060035FA RID: 13818 RVA: 0x0013E1F5 File Offset: 0x0013C3F5
		public override void OnFixedUpdate()
		{
			this.DoBuzz();
		}

		// Token: 0x060035FB RID: 13819 RVA: 0x0013E200 File Offset: 0x0013C400
		private void DoBuzz()
		{
			if (this.rb2d == null)
			{
				return;
			}
			if (this.targetSpread.Value > 0f)
			{
				if (this.timer >= this.spreadResetTime)
				{
					this.spreadX = UnityEngine.Random.Range(-this.targetSpread.Value, this.targetSpread.Value);
					this.spreadY = UnityEngine.Random.Range(-this.targetSpread.Value, this.targetSpread.Value);
					this.timer = 0f;
					this.spreadResetTime = UnityEngine.Random.Range(this.spreadResetTimeMin.Value, this.spreadResetTimeMax.Value);
				}
				else
				{
					this.timer += Time.deltaTime;
				}
			}
			Vector2 velocity = this.rb2d.velocity;
			if (this.self.Value.transform.position.x < this.target.Value.transform.position.x + this.spreadX)
			{
				velocity.x += this.acceleration.Value;
			}
			else
			{
				velocity.x -= this.acceleration.Value;
			}
			if (this.self.Value.transform.position.y < this.target.Value.transform.position.y + this.spreadY)
			{
				velocity.y += this.acceleration.Value;
			}
			else
			{
				velocity.y -= this.acceleration.Value;
			}
			if (velocity.x > this.speedMax.Value)
			{
				velocity.x = this.speedMax.Value;
			}
			if (velocity.x < -this.speedMax.Value)
			{
				velocity.x = -this.speedMax.Value;
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

		// Token: 0x0400379A RID: 14234
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody2D))]
		[UIHint(UIHint.Variable)]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400379B RID: 14235
		[UIHint(UIHint.Variable)]
		public FsmGameObject target;

		// Token: 0x0400379C RID: 14236
		public FsmFloat speedMax;

		// Token: 0x0400379D RID: 14237
		public FsmFloat acceleration;

		// Token: 0x0400379E RID: 14238
		public FsmFloat targetSpread;

		// Token: 0x0400379F RID: 14239
		public FsmFloat spreadResetTimeMin;

		// Token: 0x040037A0 RID: 14240
		public FsmFloat spreadResetTimeMax;

		// Token: 0x040037A1 RID: 14241
		private bool spreadSet;

		// Token: 0x040037A2 RID: 14242
		private float spreadResetTime;

		// Token: 0x040037A3 RID: 14243
		private float spreadX;

		// Token: 0x040037A4 RID: 14244
		private float spreadY;

		// Token: 0x040037A5 RID: 14245
		private FsmGameObject self;

		// Token: 0x040037A6 RID: 14246
		private float timer;

		// Token: 0x040037A7 RID: 14247
		private float spreadResetTimer;
	}
}
