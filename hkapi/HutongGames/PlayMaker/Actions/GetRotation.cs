using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C0F RID: 3087
	[ActionCategory(ActionCategory.Transform)]
	[Tooltip("Gets the Rotation of a Game Object and stores it in a Vector3 Variable or each Axis in a Float Variable")]
	public class GetRotation : FsmStateAction
	{
		// Token: 0x060040CB RID: 16587 RVA: 0x0016AFAC File Offset: 0x001691AC
		public override void Reset()
		{
			this.gameObject = null;
			this.quaternion = null;
			this.vector = null;
			this.xAngle = null;
			this.yAngle = null;
			this.zAngle = null;
			this.space = Space.World;
			this.everyFrame = false;
		}

		// Token: 0x060040CC RID: 16588 RVA: 0x0016AFE6 File Offset: 0x001691E6
		public override void OnEnter()
		{
			this.DoGetRotation();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060040CD RID: 16589 RVA: 0x0016AFFC File Offset: 0x001691FC
		public override void OnUpdate()
		{
			this.DoGetRotation();
		}

		// Token: 0x060040CE RID: 16590 RVA: 0x0016B004 File Offset: 0x00169204
		private void DoGetRotation()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			if (this.space == Space.World)
			{
				this.quaternion.Value = ownerDefaultTarget.transform.rotation;
				Vector3 eulerAngles = ownerDefaultTarget.transform.eulerAngles;
				this.vector.Value = eulerAngles;
				this.xAngle.Value = eulerAngles.x;
				this.yAngle.Value = eulerAngles.y;
				this.zAngle.Value = eulerAngles.z;
				return;
			}
			Vector3 localEulerAngles = ownerDefaultTarget.transform.localEulerAngles;
			this.quaternion.Value = Quaternion.Euler(localEulerAngles);
			this.vector.Value = localEulerAngles;
			this.xAngle.Value = localEulerAngles.x;
			this.yAngle.Value = localEulerAngles.y;
			this.zAngle.Value = localEulerAngles.z;
		}

		// Token: 0x04004513 RID: 17683
		[RequiredField]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004514 RID: 17684
		[UIHint(UIHint.Variable)]
		public FsmQuaternion quaternion;

		// Token: 0x04004515 RID: 17685
		[UIHint(UIHint.Variable)]
		[Title("Euler Angles")]
		public FsmVector3 vector;

		// Token: 0x04004516 RID: 17686
		[UIHint(UIHint.Variable)]
		public FsmFloat xAngle;

		// Token: 0x04004517 RID: 17687
		[UIHint(UIHint.Variable)]
		public FsmFloat yAngle;

		// Token: 0x04004518 RID: 17688
		[UIHint(UIHint.Variable)]
		public FsmFloat zAngle;

		// Token: 0x04004519 RID: 17689
		public Space space;

		// Token: 0x0400451A RID: 17690
		public bool everyFrame;
	}
}
