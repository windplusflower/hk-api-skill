using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020008C9 RID: 2249
	[ActionCategory("Physics 2d")]
	[Tooltip("Adds a 2d force to a Game Object. Use Vector2 variable and/or Float variables for each axis. I added the ability to limit speed.")]
	public class AddForce2dV2 : RigidBody2dActionBase
	{
		// Token: 0x06003222 RID: 12834 RVA: 0x00130ABC File Offset: 0x0012ECBC
		public override void Reset()
		{
			this.gameObject = null;
			this.atPosition = new FsmVector2
			{
				UseVariable = true
			};
			this.vector = null;
			this.vector3 = new FsmVector3
			{
				UseVariable = true
			};
			this.x = new FsmFloat
			{
				UseVariable = true
			};
			this.y = new FsmFloat
			{
				UseVariable = true
			};
			this.maxSpeed = null;
			this.maxSpeedX = null;
			this.maxSpeedY = null;
			this.everyFrame = false;
		}

		// Token: 0x06003223 RID: 12835 RVA: 0x00130B3B File Offset: 0x0012ED3B
		public override void OnPreprocess()
		{
			base.OnPreprocess();
			base.Fsm.HandleFixedUpdate = true;
		}

		// Token: 0x06003224 RID: 12836 RVA: 0x00130B4F File Offset: 0x0012ED4F
		public override void OnEnter()
		{
			base.CacheRigidBody2d(base.Fsm.GetOwnerDefaultTarget(this.gameObject));
			this.DoAddForce();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003225 RID: 12837 RVA: 0x00130B7C File Offset: 0x0012ED7C
		public override void OnFixedUpdate()
		{
			this.DoAddForce();
		}

		// Token: 0x06003226 RID: 12838 RVA: 0x00130B84 File Offset: 0x0012ED84
		private void DoAddForce()
		{
			if (!this.rb2d)
			{
				return;
			}
			Vector2 force = this.vector.IsNone ? new Vector2(this.x.Value, this.y.Value) : this.vector.Value;
			if (!this.vector3.IsNone)
			{
				force.x = this.vector3.Value.x;
				force.y = this.vector3.Value.y;
			}
			if (!this.x.IsNone)
			{
				force.x = this.x.Value;
			}
			if (!this.y.IsNone)
			{
				force.y = this.y.Value;
			}
			if (!this.atPosition.IsNone)
			{
				this.rb2d.AddForceAtPosition(force, this.atPosition.Value);
			}
			else
			{
				this.rb2d.AddForce(force);
			}
			if (this.maxSpeedX != null)
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
			if (this.maxSpeedY != null)
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
			if (this.maxSpeed != null)
			{
				Vector2 velocity3 = this.rb2d.velocity;
				velocity3 = Vector2.ClampMagnitude(velocity3, this.maxSpeed.Value);
				this.rb2d.velocity = velocity3;
			}
		}

		// Token: 0x04003365 RID: 13157
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody2D))]
		[Tooltip("The GameObject to apply the force to.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003366 RID: 13158
		[UIHint(UIHint.Variable)]
		[Tooltip("Optionally apply the force at a position on the object. This will also add some torque. The position is often returned from MousePick or GetCollision2dInfo actions.")]
		public FsmVector2 atPosition;

		// Token: 0x04003367 RID: 13159
		[UIHint(UIHint.Variable)]
		[Tooltip("A Vector2 force to add. Optionally override any axis with the X, Y parameters.")]
		public FsmVector2 vector;

		// Token: 0x04003368 RID: 13160
		[Tooltip("Force along the X axis. To leave unchanged, set to 'None'.")]
		public FsmFloat x;

		// Token: 0x04003369 RID: 13161
		[Tooltip("Force along the Y axis. To leave unchanged, set to 'None'.")]
		public FsmFloat y;

		// Token: 0x0400336A RID: 13162
		[Tooltip("A Vector3 force to add. z is ignored")]
		public FsmVector3 vector3;

		// Token: 0x0400336B RID: 13163
		public FsmFloat maxSpeed;

		// Token: 0x0400336C RID: 13164
		public FsmFloat maxSpeedX;

		// Token: 0x0400336D RID: 13165
		public FsmFloat maxSpeedY;

		// Token: 0x0400336E RID: 13166
		[Tooltip("Repeat every frame while the state is active.")]
		public bool everyFrame;
	}
}
