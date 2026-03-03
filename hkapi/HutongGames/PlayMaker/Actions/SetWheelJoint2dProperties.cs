using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C4A RID: 3146
	[ActionCategory(ActionCategory.Physics2D)]
	[Tooltip("Sets the various properties of a WheelJoint2d component")]
	public class SetWheelJoint2dProperties : FsmStateAction
	{
		// Token: 0x060041D8 RID: 16856 RVA: 0x0016E244 File Offset: 0x0016C444
		public override void Reset()
		{
			this.useMotor = new FsmBool
			{
				UseVariable = true
			};
			this.motorSpeed = new FsmFloat
			{
				UseVariable = true
			};
			this.maxMotorTorque = new FsmFloat
			{
				UseVariable = true
			};
			this.angle = new FsmFloat
			{
				UseVariable = true
			};
			this.dampingRatio = new FsmFloat
			{
				UseVariable = true
			};
			this.frequency = new FsmFloat
			{
				UseVariable = true
			};
			this.everyFrame = false;
		}

		// Token: 0x060041D9 RID: 16857 RVA: 0x0016E2C4 File Offset: 0x0016C4C4
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget != null)
			{
				this._wj2d = ownerDefaultTarget.GetComponent<WheelJoint2D>();
				if (this._wj2d != null)
				{
					this._motor = this._wj2d.motor;
					this._suspension = this._wj2d.suspension;
				}
			}
			this.SetProperties();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060041DA RID: 16858 RVA: 0x0016E33C File Offset: 0x0016C53C
		public override void OnUpdate()
		{
			this.SetProperties();
		}

		// Token: 0x060041DB RID: 16859 RVA: 0x0016E344 File Offset: 0x0016C544
		private void SetProperties()
		{
			if (this._wj2d == null)
			{
				return;
			}
			if (!this.useMotor.IsNone)
			{
				this._wj2d.useMotor = this.useMotor.Value;
			}
			if (!this.motorSpeed.IsNone)
			{
				this._motor.motorSpeed = this.motorSpeed.Value;
				this._wj2d.motor = this._motor;
			}
			if (!this.maxMotorTorque.IsNone)
			{
				this._motor.maxMotorTorque = this.maxMotorTorque.Value;
				this._wj2d.motor = this._motor;
			}
			if (!this.angle.IsNone)
			{
				this._suspension.angle = this.angle.Value;
				this._wj2d.suspension = this._suspension;
			}
			if (!this.dampingRatio.IsNone)
			{
				this._suspension.dampingRatio = this.dampingRatio.Value;
				this._wj2d.suspension = this._suspension;
			}
			if (!this.frequency.IsNone)
			{
				this._suspension.frequency = this.frequency.Value;
				this._wj2d.suspension = this._suspension;
			}
		}

		// Token: 0x04004640 RID: 17984
		[RequiredField]
		[Tooltip("The WheelJoint2d target")]
		[CheckForComponent(typeof(WheelJoint2D))]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004641 RID: 17985
		[ActionSection("Motor")]
		[Tooltip("Should a motor force be applied automatically to the Rigidbody2D?")]
		public FsmBool useMotor;

		// Token: 0x04004642 RID: 17986
		[Tooltip("The desired speed for the Rigidbody2D to reach as it moves with the joint.")]
		public FsmFloat motorSpeed;

		// Token: 0x04004643 RID: 17987
		[Tooltip("The maximum force that can be applied to the Rigidbody2D at the joint to attain the target speed.")]
		public FsmFloat maxMotorTorque;

		// Token: 0x04004644 RID: 17988
		[ActionSection("Suspension")]
		[Tooltip("The world angle along which the suspension will move. This provides 2D constrained motion similar to a SliderJoint2D. This is typically how suspension works in the real world.")]
		public FsmFloat angle;

		// Token: 0x04004645 RID: 17989
		[Tooltip("The amount by which the suspension spring force is reduced in proportion to the movement speed.")]
		public FsmFloat dampingRatio;

		// Token: 0x04004646 RID: 17990
		[Tooltip("The frequency at which the suspension spring oscillates.")]
		public FsmFloat frequency;

		// Token: 0x04004647 RID: 17991
		[Tooltip("Repeat every frame while the state is active.")]
		public bool everyFrame;

		// Token: 0x04004648 RID: 17992
		private WheelJoint2D _wj2d;

		// Token: 0x04004649 RID: 17993
		private JointMotor2D _motor;

		// Token: 0x0400464A RID: 17994
		private JointSuspension2D _suspension;
	}
}
