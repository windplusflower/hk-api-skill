using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CAF RID: 3247
	[ActionCategory(ActionCategory.StateMachine)]
	[ActionTarget(typeof(PlayMakerFSM), "gameObject,fsmName", false)]
	[Tooltip("Set the value of a Quaternion Variable in another FSM.")]
	public class SetFsmQuaternion : FsmStateAction
	{
		// Token: 0x060043B5 RID: 17333 RVA: 0x00173DD9 File Offset: 0x00171FD9
		public override void Reset()
		{
			this.gameObject = null;
			this.fsmName = "";
			this.variableName = "";
			this.setValue = null;
			this.everyFrame = false;
		}

		// Token: 0x060043B6 RID: 17334 RVA: 0x00173E10 File Offset: 0x00172010
		public override void OnEnter()
		{
			this.DoSetFsmQuaternion();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060043B7 RID: 17335 RVA: 0x00173E28 File Offset: 0x00172028
		private void DoSetFsmQuaternion()
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
			FsmQuaternion fsmQuaternion = this.fsm.FsmVariables.GetFsmQuaternion(this.variableName.Value);
			if (fsmQuaternion != null)
			{
				fsmQuaternion.Value = this.setValue.Value;
				return;
			}
			base.LogWarning("Could not find variable: " + this.variableName.Value);
		}

		// Token: 0x060043B8 RID: 17336 RVA: 0x00173F25 File Offset: 0x00172125
		public override void OnUpdate()
		{
			this.DoSetFsmQuaternion();
		}

		// Token: 0x0400480A RID: 18442
		[RequiredField]
		[Tooltip("The GameObject that owns the FSM.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400480B RID: 18443
		[UIHint(UIHint.FsmName)]
		[Tooltip("Optional name of FSM on Game Object")]
		public FsmString fsmName;

		// Token: 0x0400480C RID: 18444
		[RequiredField]
		[UIHint(UIHint.FsmQuaternion)]
		[Tooltip("The name of the FSM variable.")]
		public FsmString variableName;

		// Token: 0x0400480D RID: 18445
		[RequiredField]
		[Tooltip("Set the value of the variable.")]
		public FsmQuaternion setValue;

		// Token: 0x0400480E RID: 18446
		[Tooltip("Repeat every frame. Useful if the value is changing.")]
		public bool everyFrame;

		// Token: 0x0400480F RID: 18447
		private GameObject goLastFrame;

		// Token: 0x04004810 RID: 18448
		private string fsmNameLastFrame;

		// Token: 0x04004811 RID: 18449
		private PlayMakerFSM fsm;
	}
}
