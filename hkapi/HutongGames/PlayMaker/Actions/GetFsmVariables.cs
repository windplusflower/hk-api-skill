using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BEC RID: 3052
	[ActionCategory(ActionCategory.StateMachine)]
	[ActionTarget(typeof(PlayMakerFSM), "gameObject,fsmName", false)]
	[Tooltip("Get the values of multiple variables in another FSM and store in variables of the same name in this FSM.")]
	public class GetFsmVariables : FsmStateAction
	{
		// Token: 0x06004039 RID: 16441 RVA: 0x00169BE5 File Offset: 0x00167DE5
		public override void Reset()
		{
			this.gameObject = null;
			this.fsmName = "";
			this.getVariables = null;
		}

		// Token: 0x0600403A RID: 16442 RVA: 0x00169C08 File Offset: 0x00167E08
		private void InitFsmVars()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			if (ownerDefaultTarget != this.cachedGO)
			{
				this.sourceVariables = new INamedVariable[this.getVariables.Length];
				this.targetVariables = new NamedVariable[this.getVariables.Length];
				for (int i = 0; i < this.getVariables.Length; i++)
				{
					string variableName = this.getVariables[i].variableName;
					this.sourceFsm = ActionHelpers.GetGameObjectFsm(ownerDefaultTarget, this.fsmName.Value);
					this.sourceVariables[i] = this.sourceFsm.FsmVariables.GetVariable(variableName);
					this.targetVariables[i] = base.Fsm.Variables.GetVariable(variableName);
					this.getVariables[i].Type = this.targetVariables[i].VariableType;
					if (!string.IsNullOrEmpty(variableName) && this.sourceVariables[i] == null)
					{
						base.LogWarning("Missing Variable: " + variableName);
					}
					this.cachedGO = ownerDefaultTarget;
				}
			}
		}

		// Token: 0x0600403B RID: 16443 RVA: 0x00169D1C File Offset: 0x00167F1C
		public override void OnEnter()
		{
			this.InitFsmVars();
			this.DoGetFsmVariables();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x0600403C RID: 16444 RVA: 0x00169D38 File Offset: 0x00167F38
		public override void OnUpdate()
		{
			this.DoGetFsmVariables();
		}

		// Token: 0x0600403D RID: 16445 RVA: 0x00169D40 File Offset: 0x00167F40
		private void DoGetFsmVariables()
		{
			this.InitFsmVars();
			for (int i = 0; i < this.getVariables.Length; i++)
			{
				this.getVariables[i].GetValueFrom(this.sourceVariables[i]);
				this.getVariables[i].ApplyValueTo(this.targetVariables[i]);
			}
		}

		// Token: 0x04004498 RID: 17560
		[RequiredField]
		[Tooltip("The GameObject that owns the FSM")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004499 RID: 17561
		[UIHint(UIHint.FsmName)]
		[Tooltip("Optional name of FSM on Game Object")]
		public FsmString fsmName;

		// Token: 0x0400449A RID: 17562
		[RequiredField]
		[HideTypeFilter]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the values of the FsmVariables")]
		public FsmVar[] getVariables;

		// Token: 0x0400449B RID: 17563
		[Tooltip("Repeat every frame.")]
		public bool everyFrame;

		// Token: 0x0400449C RID: 17564
		private GameObject cachedGO;

		// Token: 0x0400449D RID: 17565
		private PlayMakerFSM sourceFsm;

		// Token: 0x0400449E RID: 17566
		private INamedVariable[] sourceVariables;

		// Token: 0x0400449F RID: 17567
		private NamedVariable[] targetVariables;
	}
}
