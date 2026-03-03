using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C47 RID: 3143
	[ActionCategory(ActionCategory.Physics2D)]
	[Tooltip("Gets info on the last joint break 2D event.")]
	public class GetJointBreak2dInfo : FsmStateAction
	{
		// Token: 0x060041CB RID: 16843 RVA: 0x0016DEAE File Offset: 0x0016C0AE
		public override void Reset()
		{
			this.brokenJoint = null;
			this.reactionForce = null;
			this.reactionTorque = null;
		}

		// Token: 0x060041CC RID: 16844 RVA: 0x0016DEC8 File Offset: 0x0016C0C8
		private void StoreInfo()
		{
			if (base.Fsm.BrokenJoint2D == null)
			{
				return;
			}
			this.brokenJoint.Value = base.Fsm.BrokenJoint2D;
			this.reactionForce.Value = base.Fsm.BrokenJoint2D.reactionForce;
			this.reactionForceMagnitude.Value = base.Fsm.BrokenJoint2D.reactionForce.magnitude;
			this.reactionTorque.Value = base.Fsm.BrokenJoint2D.reactionTorque;
		}

		// Token: 0x060041CD RID: 16845 RVA: 0x0016DF58 File Offset: 0x0016C158
		public override void OnEnter()
		{
			this.StoreInfo();
			base.Finish();
		}

		// Token: 0x0400462E RID: 17966
		[UIHint(UIHint.Variable)]
		[ObjectType(typeof(Joint2D))]
		[Tooltip("Get the broken joint.")]
		public FsmObject brokenJoint;

		// Token: 0x0400462F RID: 17967
		[UIHint(UIHint.Variable)]
		[Tooltip("Get the reaction force exerted by the broken joint. Unity 5.3+")]
		public FsmVector2 reactionForce;

		// Token: 0x04004630 RID: 17968
		[UIHint(UIHint.Variable)]
		[Tooltip("Get the magnitude of the reaction force exerted by the broken joint. Unity 5.3+")]
		public FsmFloat reactionForceMagnitude;

		// Token: 0x04004631 RID: 17969
		[UIHint(UIHint.Variable)]
		[Tooltip("Get the reaction torque exerted by the broken joint. Unity 5.3+")]
		public FsmFloat reactionTorque;
	}
}
