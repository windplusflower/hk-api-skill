using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CB6 RID: 3254
	[ActionCategory(ActionCategory.StateMachine)]
	[ActionTarget(typeof(PlayMakerFSM), "gameObject,fsmName", false)]
	[Tooltip("Set the value of a Vector3 Variable in another FSM.")]
	public class SetFsmVector3 : FsmStateAction
	{
		// Token: 0x060043D7 RID: 17367 RVA: 0x001746ED File Offset: 0x001728ED
		public override void Reset()
		{
			this.gameObject = null;
			this.fsmName = "";
			this.setValue = null;
		}

		// Token: 0x060043D8 RID: 17368 RVA: 0x0017470D File Offset: 0x0017290D
		public override void OnEnter()
		{
			this.DoSetFsmVector3();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060043D9 RID: 17369 RVA: 0x00174724 File Offset: 0x00172924
		private void DoSetFsmVector3()
		{
			if (this.setValue == null)
			{
				return;
			}
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			if (ownerDefaultTarget != this.goLastFrame || this.fsmName.Value != this.fsmNameLastFrame)
			{
				this.goLastFrame = ownerDefaultTarget;
				this.fsmNameLastFrame = this.fsmName.Value;
				this.fsm = ActionHelpers.GetGameObjectFsm(ownerDefaultTarget, this.fsmName.Value);
			}
			if (this.fsm == null)
			{
				base.LogWarning("Could not find FSM: " + this.fsmName.Value);
				return;
			}
			FsmVector3 fsmVector = this.fsm.FsmVariables.GetFsmVector3(this.variableName.Value);
			if (fsmVector != null)
			{
				fsmVector.Value = this.setValue.Value;
				return;
			}
			base.LogWarning("Could not find variable: " + this.variableName.Value);
		}

		// Token: 0x060043DA RID: 17370 RVA: 0x00174821 File Offset: 0x00172A21
		public override void OnUpdate()
		{
			this.DoSetFsmVector3();
		}

		// Token: 0x04004844 RID: 18500
		[RequiredField]
		[Tooltip("The GameObject that owns the FSM.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004845 RID: 18501
		[UIHint(UIHint.FsmName)]
		[Tooltip("Optional name of FSM on Game Object")]
		public FsmString fsmName;

		// Token: 0x04004846 RID: 18502
		[RequiredField]
		[UIHint(UIHint.FsmVector3)]
		[Tooltip("The name of the FSM variable.")]
		public FsmString variableName;

		// Token: 0x04004847 RID: 18503
		[RequiredField]
		[Tooltip("Set the value of the variable.")]
		public FsmVector3 setValue;

		// Token: 0x04004848 RID: 18504
		[Tooltip("Repeat every frame. Useful if the value is changing.")]
		public bool everyFrame;

		// Token: 0x04004849 RID: 18505
		private GameObject goLastFrame;

		// Token: 0x0400484A RID: 18506
		private string fsmNameLastFrame;

		// Token: 0x0400484B RID: 18507
		private PlayMakerFSM fsm;
	}
}
