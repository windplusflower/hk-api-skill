using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C5D RID: 3165
	[ActionCategory(ActionCategory.Quaternion)]
	[Tooltip("Get the vector3 from a quaternion multiplied by a vector.")]
	public class GetQuaternionMultipliedByVector : QuaternionBaseAction
	{
		// Token: 0x0600422C RID: 16940 RVA: 0x0016F561 File Offset: 0x0016D761
		public override void Reset()
		{
			this.quaternion = null;
			this.vector3 = null;
			this.result = null;
			this.everyFrame = false;
			this.everyFrameOption = QuaternionBaseAction.everyFrameOptions.Update;
		}

		// Token: 0x0600422D RID: 16941 RVA: 0x0016F586 File Offset: 0x0016D786
		public override void OnEnter()
		{
			this.DoQuatMult();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x0600422E RID: 16942 RVA: 0x0016F59C File Offset: 0x0016D79C
		public override void OnUpdate()
		{
			if (this.everyFrameOption == QuaternionBaseAction.everyFrameOptions.Update)
			{
				this.DoQuatMult();
			}
		}

		// Token: 0x0600422F RID: 16943 RVA: 0x0016F5AC File Offset: 0x0016D7AC
		public override void OnLateUpdate()
		{
			if (this.everyFrameOption == QuaternionBaseAction.everyFrameOptions.LateUpdate)
			{
				this.DoQuatMult();
			}
		}

		// Token: 0x06004230 RID: 16944 RVA: 0x0016F5BD File Offset: 0x0016D7BD
		public override void OnFixedUpdate()
		{
			if (this.everyFrameOption == QuaternionBaseAction.everyFrameOptions.FixedUpdate)
			{
				this.DoQuatMult();
			}
		}

		// Token: 0x06004231 RID: 16945 RVA: 0x0016F5CE File Offset: 0x0016D7CE
		private void DoQuatMult()
		{
			this.result.Value = this.quaternion.Value * this.vector3.Value;
		}

		// Token: 0x04004693 RID: 18067
		[RequiredField]
		[Tooltip("The quaternion to multiply")]
		public FsmQuaternion quaternion;

		// Token: 0x04004694 RID: 18068
		[RequiredField]
		[Tooltip("The vector3 to multiply")]
		public FsmVector3 vector3;

		// Token: 0x04004695 RID: 18069
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The resulting vector3")]
		public FsmVector3 result;
	}
}
