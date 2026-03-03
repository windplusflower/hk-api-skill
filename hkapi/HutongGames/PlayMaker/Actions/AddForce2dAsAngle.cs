using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x0200098C RID: 2444
	[ActionCategory("Physics 2d")]
	[Tooltip("Adds a 2d force to a Game Object. Use Vector2 variable and/or Float variables for each axis. I added the ability to limit speed.")]
	public class AddForce2dAsAngle : RigidBody2dActionBase
	{
		// Token: 0x060035A3 RID: 13731 RVA: 0x0013CD94 File Offset: 0x0013AF94
		public override void Reset()
		{
			this.gameObject = null;
			this.atPosition = new FsmVector2
			{
				UseVariable = true
			};
			this.angle = null;
			this.speed = null;
			this.maxSpeed = null;
			this.maxSpeedX = null;
			this.maxSpeedY = null;
			this.everyFrame = false;
		}

		// Token: 0x060035A4 RID: 13732 RVA: 0x00070581 File Offset: 0x0006E781
		public override void Awake()
		{
			base.Fsm.HandleFixedUpdate = true;
		}

		// Token: 0x060035A5 RID: 13733 RVA: 0x00070581 File Offset: 0x0006E781
		public override void OnPreprocess()
		{
			base.Fsm.HandleFixedUpdate = true;
		}

		// Token: 0x060035A6 RID: 13734 RVA: 0x0013CDE4 File Offset: 0x0013AFE4
		public override void OnEnter()
		{
			base.CacheRigidBody2d(base.Fsm.GetOwnerDefaultTarget(this.gameObject));
			this.DoAddForce();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060035A7 RID: 13735 RVA: 0x0013CE11 File Offset: 0x0013B011
		public override void OnFixedUpdate()
		{
			this.DoAddForce();
		}

		// Token: 0x060035A8 RID: 13736 RVA: 0x0013CE1C File Offset: 0x0013B01C
		private void DoAddForce()
		{
			this.x = this.speed.Value * Mathf.Cos(this.angle.Value * 0.017453292f);
			this.y = this.speed.Value * Mathf.Sin(this.angle.Value * 0.017453292f);
			if (!this.rb2d)
			{
				return;
			}
			Vector2 force = new Vector2(this.x, this.y);
			if (!this.atPosition.IsNone)
			{
				this.rb2d.AddForceAtPosition(force, this.atPosition.Value);
			}
			else
			{
				this.rb2d.AddForce(force);
			}
			if (!this.maxSpeedX.IsNone)
			{
				Vector2 velocity = this.rb2d.velocity;
				if (velocity.x > this.maxSpeedX.Value)
				{
					velocity = new Vector2(this.maxSpeedX.Value, velocity.y);
				}
				if (velocity.x < -this.maxSpeedX.Value)
				{
					velocity = new Vector2(-this.maxSpeedX.Value, velocity.y);
				}
				this.rb2d.velocity = velocity;
			}
			if (!this.maxSpeedY.IsNone)
			{
				Vector2 velocity2 = this.rb2d.velocity;
				if (velocity2.y > this.maxSpeedY.Value)
				{
					velocity2 = new Vector2(velocity2.x, this.maxSpeedY.Value);
				}
				if (velocity2.y < -this.maxSpeedY.Value)
				{
					velocity2 = new Vector2(velocity2.x, -this.maxSpeedY.Value);
				}
				this.rb2d.velocity = velocity2;
			}
			if (!this.maxSpeed.IsNone)
			{
				Vector2 vector = this.rb2d.velocity;
				vector = Vector2.ClampMagnitude(vector, this.maxSpeed.Value);
				this.rb2d.velocity = vector;
			}
		}

		// Token: 0x04003730 RID: 14128
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody2D))]
		[Tooltip("The GameObject to apply the force to.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003731 RID: 14129
		[UIHint(UIHint.Variable)]
		[Tooltip("Optionally apply the force at a position on the object. This will also add some torque. The position is often returned from MousePick or GetCollision2dInfo actions.")]
		public FsmVector2 atPosition;

		// Token: 0x04003732 RID: 14130
		[RequiredField]
		public FsmFloat angle;

		// Token: 0x04003733 RID: 14131
		[RequiredField]
		public FsmFloat speed;

		// Token: 0x04003734 RID: 14132
		private float x;

		// Token: 0x04003735 RID: 14133
		private float y;

		// Token: 0x04003736 RID: 14134
		public FsmFloat maxSpeed;

		// Token: 0x04003737 RID: 14135
		public FsmFloat maxSpeedX;

		// Token: 0x04003738 RID: 14136
		public FsmFloat maxSpeedY;

		// Token: 0x04003739 RID: 14137
		[Tooltip("Repeat every frame while the state is active.")]
		public bool everyFrame;
	}
}
