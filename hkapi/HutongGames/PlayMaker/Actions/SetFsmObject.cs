using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CAE RID: 3246
	[ActionCategory(ActionCategory.StateMachine)]
	[ActionTarget(typeof(PlayMakerFSM), "gameObject,fsmName", false)]
	[Tooltip("Set the value of an Object Variable in another FSM.")]
	public class SetFsmObject : FsmStateAction
	{
		// Token: 0x060043B0 RID: 17328 RVA: 0x00173C85 File Offset: 0x00171E85
		public override void Reset()
		{
			this.gameObject = null;
			this.fsmName = "";
			this.variableName = "";
			this.setValue = null;
			this.everyFrame = false;
		}

		// Token: 0x060043B1 RID: 17329 RVA: 0x00173CBC File Offset: 0x00171EBC
		public override void OnEnter()
		{
			this.DoSetFsmBool();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060043B2 RID: 17330 RVA: 0x00173CD4 File Offset: 0x00171ED4
		private void DoSetFsmBool()
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
			FsmObject fsmObject = this.fsm.FsmVariables.GetFsmObject(this.variableName.Value);
			if (fsmObject != null)
			{
				fsmObject.Value = this.setValue.Value;
				return;
			}
			base.LogWarning("Could not find variable: " + this.variableName.Value);
		}

		// Token: 0x060043B3 RID: 17331 RVA: 0x00173DD1 File Offset: 0x00171FD1
		public override void OnUpdate()
		{
			this.DoSetFsmBool();
		}

		// Token: 0x04004802 RID: 18434
		[RequiredField]
		[Tooltip("The GameObject that owns the FSM.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004803 RID: 18435
		[UIHint(UIHint.FsmName)]
		[Tooltip("Optional name of FSM on Game Object")]
		public FsmString fsmName;

		// Token: 0x04004804 RID: 18436
		[RequiredField]
		[UIHint(UIHint.FsmObject)]
		[Tooltip("The name of the FSM variable.")]
		public FsmString variableName;

		// Token: 0x04004805 RID: 18437
		[Tooltip("Set the value of the variable.")]
		public FsmObject setValue;

		// Token: 0x04004806 RID: 18438
		[Tooltip("Repeat every frame. Useful if the value is changing.")]
		public bool everyFrame;

		// Token: 0x04004807 RID: 18439
		private GameObject goLastFrame;

		// Token: 0x04004808 RID: 18440
		private string fsmNameLastFrame;

		// Token: 0x04004809 RID: 18441
		private PlayMakerFSM fsm;
	}
}
