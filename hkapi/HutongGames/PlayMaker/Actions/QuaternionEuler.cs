using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C62 RID: 3170
	[ActionCategory(ActionCategory.Quaternion)]
	[Tooltip("Returns a rotation that rotates z degrees around the z axis, x degrees around the x axis, and y degrees around the y axis (in that order).")]
	public class QuaternionEuler : QuaternionBaseAction
	{
		// Token: 0x06004243 RID: 16963 RVA: 0x0016F7CB File Offset: 0x0016D9CB
		public override void Reset()
		{
			this.eulerAngles = null;
			this.result = null;
			this.everyFrame = true;
			this.everyFrameOption = QuaternionBaseAction.everyFrameOptions.Update;
		}

		// Token: 0x06004244 RID: 16964 RVA: 0x0016F7E9 File Offset: 0x0016D9E9
		public override void OnEnter()
		{
			this.DoQuatEuler();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004245 RID: 16965 RVA: 0x0016F7FF File Offset: 0x0016D9FF
		public override void OnUpdate()
		{
			if (this.everyFrameOption == QuaternionBaseAction.everyFrameOptions.Update)
			{
				this.DoQuatEuler();
			}
		}

		// Token: 0x06004246 RID: 16966 RVA: 0x0016F80F File Offset: 0x0016DA0F
		public override void OnLateUpdate()
		{
			if (this.everyFrameOption == QuaternionBaseAction.everyFrameOptions.LateUpdate)
			{
				this.DoQuatEuler();
			}
		}

		// Token: 0x06004247 RID: 16967 RVA: 0x0016F820 File Offset: 0x0016DA20
		public override void OnFixedUpdate()
		{
			if (this.everyFrameOption == QuaternionBaseAction.everyFrameOptions.FixedUpdate)
			{
				this.DoQuatEuler();
			}
		}

		// Token: 0x06004248 RID: 16968 RVA: 0x0016F831 File Offset: 0x0016DA31
		private void DoQuatEuler()
		{
			this.result.Value = Quaternion.Euler(this.eulerAngles.Value);
		}

		// Token: 0x040046A4 RID: 18084
		[RequiredField]
		[Tooltip("The Euler angles.")]
		public FsmVector3 eulerAngles;

		// Token: 0x040046A5 RID: 18085
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the euler angles of this quaternion variable.")]
		public FsmQuaternion result;
	}
}
