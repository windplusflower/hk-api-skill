using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C63 RID: 3171
	[ActionCategory(ActionCategory.Quaternion)]
	[Tooltip("Inverse a quaternion")]
	public class QuaternionInverse : QuaternionBaseAction
	{
		// Token: 0x0600424A RID: 16970 RVA: 0x0016F84E File Offset: 0x0016DA4E
		public override void Reset()
		{
			this.rotation = null;
			this.result = null;
			this.everyFrame = true;
			this.everyFrameOption = QuaternionBaseAction.everyFrameOptions.Update;
		}

		// Token: 0x0600424B RID: 16971 RVA: 0x0016F86C File Offset: 0x0016DA6C
		public override void OnEnter()
		{
			this.DoQuatInverse();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x0600424C RID: 16972 RVA: 0x0016F882 File Offset: 0x0016DA82
		public override void OnUpdate()
		{
			if (this.everyFrameOption == QuaternionBaseAction.everyFrameOptions.Update)
			{
				this.DoQuatInverse();
			}
		}

		// Token: 0x0600424D RID: 16973 RVA: 0x0016F892 File Offset: 0x0016DA92
		public override void OnLateUpdate()
		{
			if (this.everyFrameOption == QuaternionBaseAction.everyFrameOptions.LateUpdate)
			{
				this.DoQuatInverse();
			}
		}

		// Token: 0x0600424E RID: 16974 RVA: 0x0016F8A3 File Offset: 0x0016DAA3
		public override void OnFixedUpdate()
		{
			if (this.everyFrameOption == QuaternionBaseAction.everyFrameOptions.FixedUpdate)
			{
				this.DoQuatInverse();
			}
		}

		// Token: 0x0600424F RID: 16975 RVA: 0x0016F8B4 File Offset: 0x0016DAB4
		private void DoQuatInverse()
		{
			this.result.Value = Quaternion.Inverse(this.rotation.Value);
		}

		// Token: 0x040046A6 RID: 18086
		[RequiredField]
		[Tooltip("the rotation")]
		public FsmQuaternion rotation;

		// Token: 0x040046A7 RID: 18087
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the inverse of the rotation variable.")]
		public FsmQuaternion result;
	}
}
