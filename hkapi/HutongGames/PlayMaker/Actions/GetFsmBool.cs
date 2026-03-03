using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BDE RID: 3038
	[ActionCategory(ActionCategory.StateMachine)]
	[ActionTarget(typeof(PlayMakerFSM), "gameObject,fsmName", false)]
	[Tooltip("Get the value of a Bool Variable from another FSM.")]
	public class GetFsmBool : FsmStateAction
	{
		// Token: 0x06003FF2 RID: 16370 RVA: 0x00168ECA File Offset: 0x001670CA
		public override void Reset()
		{
			this.gameObject = null;
			this.fsmName = "";
			this.storeValue = null;
		}

		// Token: 0x06003FF3 RID: 16371 RVA: 0x00168EEA File Offset: 0x001670EA
		public override void OnEnter()
		{
			this.DoGetFsmBool();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003FF4 RID: 16372 RVA: 0x00168F00 File Offset: 0x00167100
		public override void OnUpdate()
		{
			this.DoGetFsmBool();
		}

		// Token: 0x06003FF5 RID: 16373 RVA: 0x00168F08 File Offset: 0x00167108
		private void DoGetFsmBool()
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
			FsmBool fsmBool = this.fsm.FsmVariables.GetFsmBool(this.variableName.Value);
			if (fsmBool == null)
			{
				return;
			}
			this.storeValue.Value = fsmBool.Value;
		}

		// Token: 0x04004436 RID: 17462
		[RequiredField]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004437 RID: 17463
		[UIHint(UIHint.FsmName)]
		[Tooltip("Optional name of FSM on Game Object")]
		public FsmString fsmName;

		// Token: 0x04004438 RID: 17464
		[RequiredField]
		[UIHint(UIHint.FsmBool)]
		public FsmString variableName;

		// Token: 0x04004439 RID: 17465
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmBool storeValue;

		// Token: 0x0400443A RID: 17466
		public bool everyFrame;

		// Token: 0x0400443B RID: 17467
		private GameObject goLastFrame;

		// Token: 0x0400443C RID: 17468
		private PlayMakerFSM fsm;
	}
}
