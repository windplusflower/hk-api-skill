using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C5C RID: 3164
	[ActionCategory(ActionCategory.Quaternion)]
	[Tooltip("Get the quaternion from a quaternion multiplied by a quaternion.")]
	public class GetQuaternionMultipliedByQuaternion : QuaternionBaseAction
	{
		// Token: 0x06004225 RID: 16933 RVA: 0x0016F4CC File Offset: 0x0016D6CC
		public override void Reset()
		{
			this.quaternionA = null;
			this.quaternionB = null;
			this.result = null;
			this.everyFrame = false;
			this.everyFrameOption = QuaternionBaseAction.everyFrameOptions.Update;
		}

		// Token: 0x06004226 RID: 16934 RVA: 0x0016F4F1 File Offset: 0x0016D6F1
		public override void OnEnter()
		{
			this.DoQuatMult();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004227 RID: 16935 RVA: 0x0016F507 File Offset: 0x0016D707
		public override void OnUpdate()
		{
			if (this.everyFrameOption == QuaternionBaseAction.everyFrameOptions.Update)
			{
				this.DoQuatMult();
			}
		}

		// Token: 0x06004228 RID: 16936 RVA: 0x0016F517 File Offset: 0x0016D717
		public override void OnLateUpdate()
		{
			if (this.everyFrameOption == QuaternionBaseAction.everyFrameOptions.LateUpdate)
			{
				this.DoQuatMult();
			}
		}

		// Token: 0x06004229 RID: 16937 RVA: 0x0016F528 File Offset: 0x0016D728
		public override void OnFixedUpdate()
		{
			if (this.everyFrameOption == QuaternionBaseAction.everyFrameOptions.FixedUpdate)
			{
				this.DoQuatMult();
			}
		}

		// Token: 0x0600422A RID: 16938 RVA: 0x0016F539 File Offset: 0x0016D739
		private void DoQuatMult()
		{
			this.result.Value = this.quaternionA.Value * this.quaternionB.Value;
		}

		// Token: 0x04004690 RID: 18064
		[RequiredField]
		[Tooltip("The first quaternion to multiply")]
		public FsmQuaternion quaternionA;

		// Token: 0x04004691 RID: 18065
		[RequiredField]
		[Tooltip("The second quaternion to multiply")]
		public FsmQuaternion quaternionB;

		// Token: 0x04004692 RID: 18066
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The resulting quaternion")]
		public FsmQuaternion result;
	}
}
