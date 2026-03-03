using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BE6 RID: 3046
	[ActionCategory(ActionCategory.StateMachine)]
	[ActionTarget(typeof(PlayMakerFSM), "gameObject,fsmName", false)]
	[Tooltip("Get the value of a Quaternion Variable from another FSM.")]
	public class GetFsmQuaternion : FsmStateAction
	{
		// Token: 0x0600401A RID: 16410 RVA: 0x001695E0 File Offset: 0x001677E0
		public override void Reset()
		{
			this.gameObject = null;
			this.fsmName = "";
			this.variableName = "";
			this.storeValue = null;
			this.everyFrame = false;
		}

		// Token: 0x0600401B RID: 16411 RVA: 0x00169617 File Offset: 0x00167817
		public override void OnEnter()
		{
			this.DoGetFsmVariable();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x0600401C RID: 16412 RVA: 0x0016962D File Offset: 0x0016782D
		public override void OnUpdate()
		{
			this.DoGetFsmVariable();
		}

		// Token: 0x0600401D RID: 16413 RVA: 0x00169638 File Offset: 0x00167838
		private void DoGetFsmVariable()
		{
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
			if (this.fsm == null || this.storeValue == null)
			{
				return;
			}
			FsmQuaternion fsmQuaternion = this.fsm.FsmVariables.GetFsmQuaternion(this.variableName.Value);
			if (fsmQuaternion != null)
			{
				this.storeValue.Value = fsmQuaternion.Value;
			}
		}

		// Token: 0x0400446E RID: 17518
		[RequiredField]
		[Tooltip("The GameObject that owns the FSM.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400446F RID: 17519
		[UIHint(UIHint.FsmName)]
		[Tooltip("Optional name of FSM on Game Object")]
		public FsmString fsmName;

		// Token: 0x04004470 RID: 17520
		[RequiredField]
		[UIHint(UIHint.FsmQuaternion)]
		public FsmString variableName;

		// Token: 0x04004471 RID: 17521
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmQuaternion storeValue;

		// Token: 0x04004472 RID: 17522
		[Tooltip("Repeat every frame.")]
		public bool everyFrame;

		// Token: 0x04004473 RID: 17523
		private GameObject goLastFrame;

		// Token: 0x04004474 RID: 17524
		protected PlayMakerFSM fsm;
	}
}
