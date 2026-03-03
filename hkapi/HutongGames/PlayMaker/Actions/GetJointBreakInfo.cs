using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BF1 RID: 3057
	[ActionCategory(ActionCategory.Physics)]
	[Tooltip("Gets info on the last joint break event.")]
	public class GetJointBreakInfo : FsmStateAction
	{
		// Token: 0x0600404F RID: 16463 RVA: 0x00169FFF File Offset: 0x001681FF
		public override void Reset()
		{
			this.breakForce = null;
		}

		// Token: 0x06004050 RID: 16464 RVA: 0x0016A008 File Offset: 0x00168208
		public override void OnEnter()
		{
			this.breakForce.Value = base.Fsm.JointBreakForce;
			base.Finish();
		}

		// Token: 0x040044B6 RID: 17590
		[UIHint(UIHint.Variable)]
		[Tooltip("Get the force that broke the joint.")]
		public FsmFloat breakForce;
	}
}
