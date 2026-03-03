using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BE9 RID: 3049
	[ActionCategory(ActionCategory.StateMachine)]
	[ActionTarget(typeof(PlayMakerFSM), "gameObject,fsmName", false)]
	[Tooltip("Get the value of a String Variable from another FSM.")]
	public class GetFsmString : FsmStateAction
	{
		// Token: 0x06004029 RID: 16425 RVA: 0x001698B2 File Offset: 0x00167AB2
		public override void Reset()
		{
			this.gameObject = null;
			this.fsmName = "";
			this.storeValue = null;
		}

		// Token: 0x0600402A RID: 16426 RVA: 0x001698D2 File Offset: 0x00167AD2
		public override void OnEnter()
		{
			this.DoGetFsmString();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x0600402B RID: 16427 RVA: 0x001698E8 File Offset: 0x00167AE8
		public override void OnUpdate()
		{
			this.DoGetFsmString();
		}

		// Token: 0x0600402C RID: 16428 RVA: 0x001698F0 File Offset: 0x00167AF0
		private void DoGetFsmString()
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
			FsmString fsmString = this.fsm.FsmVariables.GetFsmString(this.variableName.Value);
			if (fsmString == null)
			{
				return;
			}
			this.storeValue.Value = fsmString.Value;
		}

		// Token: 0x04004482 RID: 17538
		[RequiredField]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004483 RID: 17539
		[UIHint(UIHint.FsmName)]
		[Tooltip("Optional name of FSM on Game Object")]
		public FsmString fsmName;

		// Token: 0x04004484 RID: 17540
		[RequiredField]
		[UIHint(UIHint.FsmString)]
		public FsmString variableName;

		// Token: 0x04004485 RID: 17541
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmString storeValue;

		// Token: 0x04004486 RID: 17542
		public bool everyFrame;

		// Token: 0x04004487 RID: 17543
		private GameObject goLastFrame;

		// Token: 0x04004488 RID: 17544
		private PlayMakerFSM fsm;
	}
}
