using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A32 RID: 2610
	[ActionCategory("Hollow Knight")]
	public class SendEventToGameObjectOptimized : FsmStateAction
	{
		// Token: 0x060038A8 RID: 14504 RVA: 0x0014B74C File Offset: 0x0014994C
		public override void Reset()
		{
			this.target = null;
			this.sendEvent = null;
			this.everyFrame = false;
		}

		// Token: 0x060038A9 RID: 14505 RVA: 0x0014B764 File Offset: 0x00149964
		public override void OnEnter()
		{
			GameObject safe = this.target.GetSafe(this);
			if (safe != null)
			{
				FSMUtility.SendEventToGameObject(safe, this.sendEvent.Value, false);
			}
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060038AA RID: 14506 RVA: 0x0014B7A8 File Offset: 0x001499A8
		public override void OnUpdate()
		{
			GameObject safe = this.target.GetSafe(this);
			if (safe != null)
			{
				FSMUtility.SendEventToGameObject(safe, this.sendEvent.Value, false);
			}
		}

		// Token: 0x04003B50 RID: 15184
		public FsmOwnerDefault target;

		// Token: 0x04003B51 RID: 15185
		[RequiredField]
		public FsmString sendEvent;

		// Token: 0x04003B52 RID: 15186
		public bool everyFrame;
	}
}
