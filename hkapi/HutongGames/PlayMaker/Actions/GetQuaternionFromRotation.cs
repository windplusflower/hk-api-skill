using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C5B RID: 3163
	[ActionCategory(ActionCategory.Quaternion)]
	[Tooltip("Creates a rotation which rotates from fromDirection to toDirection. Usually you use this to rotate a transform so that one of its axes eg. the y-axis - follows a target direction toDirection in world space.")]
	public class GetQuaternionFromRotation : QuaternionBaseAction
	{
		// Token: 0x0600421E RID: 16926 RVA: 0x0016F437 File Offset: 0x0016D637
		public override void Reset()
		{
			this.fromDirection = null;
			this.toDirection = null;
			this.result = null;
			this.everyFrame = false;
			this.everyFrameOption = QuaternionBaseAction.everyFrameOptions.Update;
		}

		// Token: 0x0600421F RID: 16927 RVA: 0x0016F45C File Offset: 0x0016D65C
		public override void OnEnter()
		{
			this.DoQuatFromRotation();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004220 RID: 16928 RVA: 0x0016F472 File Offset: 0x0016D672
		public override void OnUpdate()
		{
			if (this.everyFrameOption == QuaternionBaseAction.everyFrameOptions.Update)
			{
				this.DoQuatFromRotation();
			}
		}

		// Token: 0x06004221 RID: 16929 RVA: 0x0016F482 File Offset: 0x0016D682
		public override void OnLateUpdate()
		{
			if (this.everyFrameOption == QuaternionBaseAction.everyFrameOptions.LateUpdate)
			{
				this.DoQuatFromRotation();
			}
		}

		// Token: 0x06004222 RID: 16930 RVA: 0x0016F493 File Offset: 0x0016D693
		public override void OnFixedUpdate()
		{
			if (this.everyFrameOption == QuaternionBaseAction.everyFrameOptions.FixedUpdate)
			{
				this.DoQuatFromRotation();
			}
		}

		// Token: 0x06004223 RID: 16931 RVA: 0x0016F4A4 File Offset: 0x0016D6A4
		private void DoQuatFromRotation()
		{
			this.result.Value = Quaternion.FromToRotation(this.fromDirection.Value, this.toDirection.Value);
		}

		// Token: 0x0400468D RID: 18061
		[RequiredField]
		[Tooltip("the 'from' direction")]
		public FsmVector3 fromDirection;

		// Token: 0x0400468E RID: 18062
		[RequiredField]
		[Tooltip("the 'to' direction")]
		public FsmVector3 toDirection;

		// Token: 0x0400468F RID: 18063
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("the resulting quaternion")]
		public FsmQuaternion result;
	}
}
