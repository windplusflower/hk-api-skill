using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BE3 RID: 3043
	[ActionCategory(ActionCategory.StateMachine)]
	[ActionTarget(typeof(PlayMakerFSM), "gameObject,fsmName", false)]
	[Tooltip("Get the value of an Integer Variable from another FSM.")]
	public class GetFsmInt : FsmStateAction
	{
		// Token: 0x0600400B RID: 16395 RVA: 0x0016931E File Offset: 0x0016751E
		public override void Reset()
		{
			this.gameObject = null;
			this.fsmName = "";
			this.storeValue = null;
		}

		// Token: 0x0600400C RID: 16396 RVA: 0x0016933E File Offset: 0x0016753E
		public override void OnEnter()
		{
			this.DoGetFsmInt();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x0600400D RID: 16397 RVA: 0x00169354 File Offset: 0x00167554
		public override void OnUpdate()
		{
			this.DoGetFsmInt();
		}

		// Token: 0x0600400E RID: 16398 RVA: 0x0016935C File Offset: 0x0016755C
		private void DoGetFsmInt()
		{
			if (this.storeValue == null)
			{
				return;
			}
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			if (ownerDefaultTarget != this.goLastFrame)
			{
				this.goLastFrame = ownerDefaultTarget;
				this.fsm = ActionHelpers.GetGameObjectFsm(ownerDefaultTarget, this.fsmName.Value);
			}
			if (this.fsm == null)
			{
				return;
			}
			FsmInt fsmInt = this.fsm.FsmVariables.GetFsmInt(this.variableName.Value);
			if (fsmInt == null)
			{
				return;
			}
			this.storeValue.Value = fsmInt.Value;
		}

		// Token: 0x04004459 RID: 17497
		[RequiredField]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400445A RID: 17498
		[UIHint(UIHint.FsmName)]
		[Tooltip("Optional name of FSM on Game Object")]
		public FsmString fsmName;

		// Token: 0x0400445B RID: 17499
		[RequiredField]
		[UIHint(UIHint.FsmInt)]
		public FsmString variableName;

		// Token: 0x0400445C RID: 17500
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmInt storeValue;

		// Token: 0x0400445D RID: 17501
		public bool everyFrame;

		// Token: 0x0400445E RID: 17502
		private GameObject goLastFrame;

		// Token: 0x0400445F RID: 17503
		private PlayMakerFSM fsm;
	}
}
