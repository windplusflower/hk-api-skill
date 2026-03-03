using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BED RID: 3053
	[ActionCategory(ActionCategory.StateMachine)]
	[ActionTarget(typeof(PlayMakerFSM), "gameObject,fsmName", false)]
	[Tooltip("Get the value of a Vector2 Variable from another FSM.")]
	public class GetFsmVector2 : FsmStateAction
	{
		// Token: 0x0600403F RID: 16447 RVA: 0x00169D90 File Offset: 0x00167F90
		public override void Reset()
		{
			this.gameObject = null;
			this.fsmName = "";
			this.storeValue = null;
		}

		// Token: 0x06004040 RID: 16448 RVA: 0x00169DB0 File Offset: 0x00167FB0
		public override void OnEnter()
		{
			this.DoGetFsmVector2();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004041 RID: 16449 RVA: 0x00169DC6 File Offset: 0x00167FC6
		public override void OnUpdate()
		{
			this.DoGetFsmVector2();
		}

		// Token: 0x06004042 RID: 16450 RVA: 0x00169DD0 File Offset: 0x00167FD0
		private void DoGetFsmVector2()
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
			FsmVector2 fsmVector = this.fsm.FsmVariables.GetFsmVector2(this.variableName.Value);
			if (fsmVector == null)
			{
				return;
			}
			this.storeValue.Value = fsmVector.Value;
		}

		// Token: 0x040044A0 RID: 17568
		[RequiredField]
		public FsmOwnerDefault gameObject;

		// Token: 0x040044A1 RID: 17569
		[UIHint(UIHint.FsmName)]
		[Tooltip("Optional name of FSM on Game Object")]
		public FsmString fsmName;

		// Token: 0x040044A2 RID: 17570
		[RequiredField]
		[UIHint(UIHint.FsmVector2)]
		public FsmString variableName;

		// Token: 0x040044A3 RID: 17571
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmVector2 storeValue;

		// Token: 0x040044A4 RID: 17572
		public bool everyFrame;

		// Token: 0x040044A5 RID: 17573
		private GameObject goLastFrame;

		// Token: 0x040044A6 RID: 17574
		private PlayMakerFSM fsm;
	}
}
