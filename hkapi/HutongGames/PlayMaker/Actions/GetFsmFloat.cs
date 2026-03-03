using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BE1 RID: 3041
	[ActionCategory(ActionCategory.StateMachine)]
	[ActionTarget(typeof(PlayMakerFSM), "gameObject,fsmName", false)]
	[Tooltip("Get the value of a Float Variable from another FSM.")]
	public class GetFsmFloat : FsmStateAction
	{
		// Token: 0x06004001 RID: 16385 RVA: 0x0016915E File Offset: 0x0016735E
		public override void Reset()
		{
			this.gameObject = null;
			this.fsmName = "";
			this.storeValue = null;
		}

		// Token: 0x06004002 RID: 16386 RVA: 0x0016917E File Offset: 0x0016737E
		public override void OnEnter()
		{
			this.DoGetFsmFloat();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004003 RID: 16387 RVA: 0x00169194 File Offset: 0x00167394
		public override void OnUpdate()
		{
			this.DoGetFsmFloat();
		}

		// Token: 0x06004004 RID: 16388 RVA: 0x0016919C File Offset: 0x0016739C
		private void DoGetFsmFloat()
		{
			if (this.storeValue.IsNone)
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
				this.fsm = ActionHelpers.GetGameObjectFsm(ownerDefaultTarget, this.fsmName.Value);
				this.goLastFrame = ownerDefaultTarget;
			}
			if (this.fsm == null)
			{
				return;
			}
			FsmFloat fsmFloat = this.fsm.FsmVariables.GetFsmFloat(this.variableName.Value);
			if (fsmFloat == null)
			{
				return;
			}
			this.storeValue.Value = fsmFloat.Value;
		}

		// Token: 0x0400444B RID: 17483
		[RequiredField]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400444C RID: 17484
		[UIHint(UIHint.FsmName)]
		[Tooltip("Optional name of FSM on Game Object")]
		public FsmString fsmName;

		// Token: 0x0400444D RID: 17485
		[RequiredField]
		[UIHint(UIHint.FsmFloat)]
		public FsmString variableName;

		// Token: 0x0400444E RID: 17486
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmFloat storeValue;

		// Token: 0x0400444F RID: 17487
		public bool everyFrame;

		// Token: 0x04004450 RID: 17488
		private GameObject goLastFrame;

		// Token: 0x04004451 RID: 17489
		private PlayMakerFSM fsm;
	}
}
