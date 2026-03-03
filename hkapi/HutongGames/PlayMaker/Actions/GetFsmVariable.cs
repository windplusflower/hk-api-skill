using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BEB RID: 3051
	[ActionCategory(ActionCategory.StateMachine)]
	[ActionTarget(typeof(PlayMakerFSM), "gameObject,fsmName", false)]
	[Tooltip("Get the value of a variable in another FSM and store it in a variable of the same name in this FSM.")]
	public class GetFsmVariable : FsmStateAction
	{
		// Token: 0x06004033 RID: 16435 RVA: 0x00169A80 File Offset: 0x00167C80
		public override void Reset()
		{
			this.gameObject = null;
			this.fsmName = "";
			this.storeValue = new FsmVar();
		}

		// Token: 0x06004034 RID: 16436 RVA: 0x00169AA4 File Offset: 0x00167CA4
		public override void OnEnter()
		{
			this.InitFsmVar();
			this.DoGetFsmVariable();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004035 RID: 16437 RVA: 0x00169AC0 File Offset: 0x00167CC0
		public override void OnUpdate()
		{
			this.DoGetFsmVariable();
		}

		// Token: 0x06004036 RID: 16438 RVA: 0x00169AC8 File Offset: 0x00167CC8
		private void InitFsmVar()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			if (ownerDefaultTarget != this.cachedGO)
			{
				this.sourceFsm = ActionHelpers.GetGameObjectFsm(ownerDefaultTarget, this.fsmName.Value);
				this.sourceVariable = this.sourceFsm.FsmVariables.GetVariable(this.storeValue.variableName);
				this.targetVariable = base.Fsm.Variables.GetVariable(this.storeValue.variableName);
				this.storeValue.Type = this.targetVariable.VariableType;
				if (!string.IsNullOrEmpty(this.storeValue.variableName) && this.sourceVariable == null)
				{
					base.LogWarning("Missing Variable: " + this.storeValue.variableName);
				}
				this.cachedGO = ownerDefaultTarget;
			}
		}

		// Token: 0x06004037 RID: 16439 RVA: 0x00169BAD File Offset: 0x00167DAD
		private void DoGetFsmVariable()
		{
			if (this.storeValue.IsNone)
			{
				return;
			}
			this.InitFsmVar();
			this.storeValue.GetValueFrom(this.sourceVariable);
			this.storeValue.ApplyValueTo(this.targetVariable);
		}

		// Token: 0x04004490 RID: 17552
		[RequiredField]
		[Tooltip("The GameObject that owns the FSM")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004491 RID: 17553
		[UIHint(UIHint.FsmName)]
		[Tooltip("Optional name of FSM on Game Object")]
		public FsmString fsmName;

		// Token: 0x04004492 RID: 17554
		[RequiredField]
		[HideTypeFilter]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the value of the FsmVariable")]
		public FsmVar storeValue;

		// Token: 0x04004493 RID: 17555
		[Tooltip("Repeat every frame.")]
		public bool everyFrame;

		// Token: 0x04004494 RID: 17556
		private GameObject cachedGO;

		// Token: 0x04004495 RID: 17557
		private PlayMakerFSM sourceFsm;

		// Token: 0x04004496 RID: 17558
		private INamedVariable sourceVariable;

		// Token: 0x04004497 RID: 17559
		private NamedVariable targetVariable;
	}
}
