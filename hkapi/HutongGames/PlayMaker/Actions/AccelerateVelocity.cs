using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000989 RID: 2441
	[ActionCategory("Physics 2d")]
	[Tooltip("Accelerates objects velocity, and clamps top speed")]
	public class AccelerateVelocity : RigidBody2dActionBase
	{
		// Token: 0x06003596 RID: 13718 RVA: 0x0013CB6C File Offset: 0x0013AD6C
		public override void Reset()
		{
			this.gameObject = null;
			this.xAccel = new FsmFloat
			{
				UseVariable = true
			};
			this.yAccel = new FsmFloat
			{
				UseVariable = true
			};
			this.xMaxSpeed = new FsmFloat
			{
				UseVariable = true
			};
			this.yMaxSpeed = new FsmFloat
			{
				UseVariable = true
			};
		}

		// Token: 0x06003597 RID: 13719 RVA: 0x00070581 File Offset: 0x0006E781
		public override void Awake()
		{
			base.Fsm.HandleFixedUpdate = true;
		}

		// Token: 0x06003598 RID: 13720 RVA: 0x0013CBC8 File Offset: 0x0013ADC8
		public override void OnEnter()
		{
			base.CacheRigidBody2d(base.Fsm.GetOwnerDefaultTarget(this.gameObject));
		}

		// Token: 0x06003599 RID: 13721 RVA: 0x00070581 File Offset: 0x0006E781
		public override void OnPreprocess()
		{
			base.Fsm.HandleFixedUpdate = true;
		}

		// Token: 0x0600359A RID: 13722 RVA: 0x0013CBE1 File Offset: 0x0013ADE1
		public override void OnFixedUpdate()
		{
			this.DoSetVelocity();
		}

		// Token: 0x0600359B RID: 13723 RVA: 0x0013CBEC File Offset: 0x0013ADEC
		private void DoSetVelocity()
		{
			if (this.rb2d == null)
			{
				return;
			}
			Vector2 velocity = this.rb2d.velocity;
			if (!this.xAccel.IsNone)
			{
				float num = velocity.x + this.xAccel.Value;
				num = Mathf.Clamp(num, -this.xMaxSpeed.Value, this.xMaxSpeed.Value);
				velocity = new Vector2(num, velocity.y);
			}
			if (!this.yAccel.IsNone)
			{
				float num2 = velocity.y + this.yAccel.Value;
				num2 = Mathf.Clamp(num2, -this.yMaxSpeed.Value, this.yMaxSpeed.Value);
				velocity = new Vector2(velocity.x, num2);
			}
			this.rb2d.velocity = velocity;
		}

		// Token: 0x04003727 RID: 14119
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody2D))]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003728 RID: 14120
		public FsmFloat xAccel;

		// Token: 0x04003729 RID: 14121
		public FsmFloat yAccel;

		// Token: 0x0400372A RID: 14122
		public FsmFloat xMaxSpeed;

		// Token: 0x0400372B RID: 14123
		public FsmFloat yMaxSpeed;
	}
}
