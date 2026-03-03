using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C5F RID: 3167
	public abstract class QuaternionBaseAction : FsmStateAction
	{
		// Token: 0x0600423A RID: 16954 RVA: 0x0016F68C File Offset: 0x0016D88C
		public override void Awake()
		{
			if (this.everyFrame)
			{
				QuaternionBaseAction.everyFrameOptions everyFrameOptions = this.everyFrameOption;
				if (everyFrameOptions == QuaternionBaseAction.everyFrameOptions.FixedUpdate)
				{
					base.Fsm.HandleFixedUpdate = true;
					return;
				}
				if (everyFrameOptions != QuaternionBaseAction.everyFrameOptions.LateUpdate)
				{
					return;
				}
				base.Fsm.HandleLateUpdate = true;
			}
		}

		// Token: 0x04004699 RID: 18073
		[Tooltip("Repeat every frame. Useful if any of the values are changing.")]
		public bool everyFrame;

		// Token: 0x0400469A RID: 18074
		[Tooltip("Defines how to perform the action when 'every Frame' is enabled.")]
		public QuaternionBaseAction.everyFrameOptions everyFrameOption;

		// Token: 0x02000C60 RID: 3168
		public enum everyFrameOptions
		{
			// Token: 0x0400469C RID: 18076
			Update,
			// Token: 0x0400469D RID: 18077
			FixedUpdate,
			// Token: 0x0400469E RID: 18078
			LateUpdate
		}
	}
}
