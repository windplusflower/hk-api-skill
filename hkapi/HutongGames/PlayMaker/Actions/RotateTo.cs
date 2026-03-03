using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000ADD RID: 2781
	[ActionCategory("Physics 2d")]
	[Tooltip("Rotate to a specific z angle over time")]
	public class RotateTo : RigidBody2dActionBase
	{
		// Token: 0x06003BC1 RID: 15297 RVA: 0x00158AF6 File Offset: 0x00156CF6
		public override void Reset()
		{
			this.gameObject = null;
		}

		// Token: 0x06003BC2 RID: 15298 RVA: 0x00158AFF File Offset: 0x00156CFF
		public override void OnUpdate()
		{
			this.DoRotateTo();
		}

		// Token: 0x06003BC3 RID: 15299 RVA: 0x00158B08 File Offset: 0x00156D08
		private void DoRotateTo()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			float num = this.targetAngle.Value - ownerDefaultTarget.transform.localEulerAngles.z;
			bool flag;
			if (num < 0f)
			{
				flag = (num < -180f);
			}
			else
			{
				flag = (num <= 180f);
			}
			if (flag)
			{
				ownerDefaultTarget.transform.Rotate(0f, 0f, this.speed.Value * Time.deltaTime);
				if (ownerDefaultTarget.transform.localEulerAngles.z > this.targetAngle.Value)
				{
					ownerDefaultTarget.transform.localEulerAngles = new Vector3(ownerDefaultTarget.transform.rotation.x, ownerDefaultTarget.transform.rotation.y, this.targetAngle.Value);
					return;
				}
			}
			else
			{
				ownerDefaultTarget.transform.Rotate(0f, 0f, -this.speed.Value * Time.deltaTime);
				if (ownerDefaultTarget.transform.localEulerAngles.z < this.targetAngle.Value)
				{
					ownerDefaultTarget.transform.localEulerAngles = new Vector3(ownerDefaultTarget.transform.rotation.x, ownerDefaultTarget.transform.rotation.y, this.targetAngle.Value);
				}
			}
		}

		// Token: 0x04003F70 RID: 16240
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody2D))]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003F71 RID: 16241
		public FsmFloat targetAngle;

		// Token: 0x04003F72 RID: 16242
		public FsmFloat speed;
	}
}
