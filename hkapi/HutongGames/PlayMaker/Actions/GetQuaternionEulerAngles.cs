using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C5A RID: 3162
	[ActionCategory(ActionCategory.Quaternion)]
	[Tooltip("Gets a quaternion as euler angles.")]
	public class GetQuaternionEulerAngles : QuaternionBaseAction
	{
		// Token: 0x06004217 RID: 16919 RVA: 0x0016F39D File Offset: 0x0016D59D
		public override void Reset()
		{
			this.quaternion = null;
			this.eulerAngles = null;
			this.everyFrame = true;
			this.everyFrameOption = QuaternionBaseAction.everyFrameOptions.Update;
		}

		// Token: 0x06004218 RID: 16920 RVA: 0x0016F3BB File Offset: 0x0016D5BB
		public override void OnEnter()
		{
			this.GetQuatEuler();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004219 RID: 16921 RVA: 0x0016F3D1 File Offset: 0x0016D5D1
		public override void OnUpdate()
		{
			if (this.everyFrameOption == QuaternionBaseAction.everyFrameOptions.Update)
			{
				this.GetQuatEuler();
			}
		}

		// Token: 0x0600421A RID: 16922 RVA: 0x0016F3E1 File Offset: 0x0016D5E1
		public override void OnLateUpdate()
		{
			if (this.everyFrameOption == QuaternionBaseAction.everyFrameOptions.LateUpdate)
			{
				this.GetQuatEuler();
			}
		}

		// Token: 0x0600421B RID: 16923 RVA: 0x0016F3F2 File Offset: 0x0016D5F2
		public override void OnFixedUpdate()
		{
			if (this.everyFrameOption == QuaternionBaseAction.everyFrameOptions.FixedUpdate)
			{
				this.GetQuatEuler();
			}
		}

		// Token: 0x0600421C RID: 16924 RVA: 0x0016F404 File Offset: 0x0016D604
		private void GetQuatEuler()
		{
			this.eulerAngles.Value = this.quaternion.Value.eulerAngles;
		}

		// Token: 0x0400468B RID: 18059
		[RequiredField]
		[Tooltip("The rotation")]
		public FsmQuaternion quaternion;

		// Token: 0x0400468C RID: 18060
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The euler angles of the quaternion.")]
		public FsmVector3 eulerAngles;
	}
}
