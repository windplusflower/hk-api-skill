using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C5E RID: 3166
	[ActionCategory(ActionCategory.Quaternion)]
	[Tooltip("Creates a rotation which rotates angle degrees around axis.")]
	public class QuaternionAngleAxis : QuaternionBaseAction
	{
		// Token: 0x06004233 RID: 16947 RVA: 0x0016F5F6 File Offset: 0x0016D7F6
		public override void Reset()
		{
			this.angle = null;
			this.axis = null;
			this.result = null;
			this.everyFrame = true;
			this.everyFrameOption = QuaternionBaseAction.everyFrameOptions.Update;
		}

		// Token: 0x06004234 RID: 16948 RVA: 0x0016F61B File Offset: 0x0016D81B
		public override void OnEnter()
		{
			this.DoQuatAngleAxis();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004235 RID: 16949 RVA: 0x0016F631 File Offset: 0x0016D831
		public override void OnUpdate()
		{
			if (this.everyFrameOption == QuaternionBaseAction.everyFrameOptions.Update)
			{
				this.DoQuatAngleAxis();
			}
		}

		// Token: 0x06004236 RID: 16950 RVA: 0x0016F641 File Offset: 0x0016D841
		public override void OnLateUpdate()
		{
			if (this.everyFrameOption == QuaternionBaseAction.everyFrameOptions.LateUpdate)
			{
				this.DoQuatAngleAxis();
			}
		}

		// Token: 0x06004237 RID: 16951 RVA: 0x0016F652 File Offset: 0x0016D852
		public override void OnFixedUpdate()
		{
			if (this.everyFrameOption == QuaternionBaseAction.everyFrameOptions.FixedUpdate)
			{
				this.DoQuatAngleAxis();
			}
		}

		// Token: 0x06004238 RID: 16952 RVA: 0x0016F663 File Offset: 0x0016D863
		private void DoQuatAngleAxis()
		{
			this.result.Value = Quaternion.AngleAxis(this.angle.Value, this.axis.Value);
		}

		// Token: 0x04004696 RID: 18070
		[RequiredField]
		[Tooltip("The angle.")]
		public FsmFloat angle;

		// Token: 0x04004697 RID: 18071
		[RequiredField]
		[Tooltip("The rotation axis.")]
		public FsmVector3 axis;

		// Token: 0x04004698 RID: 18072
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the rotation of this quaternion variable.")]
		public FsmQuaternion result;
	}
}
