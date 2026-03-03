using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C49 RID: 3145
	[ActionCategory(ActionCategory.Physics2D)]
	[Tooltip("Sets the various properties of a HingeJoint2d component")]
	public class SetHingeJoint2dProperties : FsmStateAction
	{
		// Token: 0x060041D3 RID: 16851 RVA: 0x0016E010 File Offset: 0x0016C210
		public override void Reset()
		{
			this.useLimits = new FsmBool
			{
				UseVariable = true
			};
			this.min = new FsmFloat
			{
				UseVariable = true
			};
			this.max = new FsmFloat
			{
				UseVariable = true
			};
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
			this.everyFrame = false;
		}

		// Token: 0x060041D4 RID: 16852 RVA: 0x0016E090 File Offset: 0x0016C290
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget != null)
			{
				this._joint = ownerDefaultTarget.GetComponent<HingeJoint2D>();
				if (this._joint != null)
				{
					this._motor = this._joint.motor;
					this._limits = this._joint.limits;
				}
			}
			this.SetProperties();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060041D5 RID: 16853 RVA: 0x0016E108 File Offset: 0x0016C308
		public override void OnUpdate()
		{
			this.SetProperties();
		}

		// Token: 0x060041D6 RID: 16854 RVA: 0x0016E110 File Offset: 0x0016C310
		private void SetProperties()
		{
			if (this._joint == null)
			{
				return;
			}
			if (!this.useMotor.IsNone)
			{
				this._joint.useMotor = this.useMotor.Value;
			}
			if (!this.motorSpeed.IsNone)
			{
				this._motor.motorSpeed = this.motorSpeed.Value;
				this._joint.motor = this._motor;
			}
			if (!this.maxMotorTorque.IsNone)
			{
				this._motor.maxMotorTorque = this.maxMotorTorque.Value;
				this._joint.motor = this._motor;
			}
			if (!this.useLimits.IsNone)
			{
				this._joint.useLimits = this.useLimits.Value;
			}
			if (!this.min.IsNone)
			{
				this._limits.min = this.min.Value;
				this._joint.limits = this._limits;
			}
			if (!this.max.IsNone)
			{
				this._limits.max = this.max.Value;
				this._joint.limits = this._limits;
			}
		}

		// Token: 0x04004635 RID: 17973
		[RequiredField]
		[Tooltip("The HingeJoint2d target")]
		[CheckForComponent(typeof(HingeJoint2D))]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004636 RID: 17974
		[ActionSection("Limits")]
		[Tooltip("Should limits be placed on the range of rotation?")]
		public FsmBool useLimits;

		// Token: 0x04004637 RID: 17975
		[Tooltip("Lower angular limit of rotation.")]
		public FsmFloat min;

		// Token: 0x04004638 RID: 17976
		[Tooltip("Upper angular limit of rotation")]
		public FsmFloat max;

		// Token: 0x04004639 RID: 17977
		[ActionSection("Motor")]
		[Tooltip("Should a motor force be applied automatically to the Rigidbody2D?")]
		public FsmBool useMotor;

		// Token: 0x0400463A RID: 17978
		[Tooltip("The desired speed for the Rigidbody2D to reach as it moves with the joint.")]
		public FsmFloat motorSpeed;

		// Token: 0x0400463B RID: 17979
		[Tooltip("The maximum force that can be applied to the Rigidbody2D at the joint to attain the target speed.")]
		public FsmFloat maxMotorTorque;

		// Token: 0x0400463C RID: 17980
		[Tooltip("Repeat every frame while the state is active.")]
		public bool everyFrame;

		// Token: 0x0400463D RID: 17981
		private HingeJoint2D _joint;

		// Token: 0x0400463E RID: 17982
		private JointMotor2D _motor;

		// Token: 0x0400463F RID: 17983
		private JointAngleLimits2D _limits;
	}
}
