using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CB4 RID: 3252
	[ActionCategory(ActionCategory.StateMachine)]
	[ActionTarget(typeof(PlayMakerFSM), "gameObject,fsmName", false)]
	[Tooltip("Set the value of a variable in another FSM.")]
	public class SetFsmVariable : FsmStateAction
	{
		// Token: 0x060043CD RID: 17357 RVA: 0x00174435 File Offset: 0x00172635
		public override void Reset()
		{
			this.gameObject = null;
			this.fsmName = "";
			this.setValue = new FsmVar();
		}

		// Token: 0x060043CE RID: 17358 RVA: 0x00174459 File Offset: 0x00172659
		public override void OnEnter()
		{
			this.DoSetFsmVariable();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060043CF RID: 17359 RVA: 0x0017446F File Offset: 0x0017266F
		public override void OnUpdate()
		{
			this.DoSetFsmVariable();
		}

		// Token: 0x060043D0 RID: 17360 RVA: 0x00174478 File Offset: 0x00172678
		private void DoSetFsmVariable()
		{
			if (this.setValue.IsNone || string.IsNullOrEmpty(this.variableName.Value))
			{
				return;
			}
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			if (ownerDefaultTarget != this.cachedGameObject || this.fsmName.Value != this.cachedFsmName)
			{
				this.targetFsm = ActionHelpers.GetGameObjectFsm(ownerDefaultTarget, this.fsmName.Value);
				if (this.targetFsm == null)
				{
					return;
				}
				this.cachedGameObject = ownerDefaultTarget;
				this.cachedFsmName = this.fsmName.Value;
			}
			if (this.variableName.Value != this.cachedVariableName)
			{
				this.targetVariable = this.targetFsm.FsmVariables.FindVariable(this.setValue.Type, this.variableName.Value);
				this.cachedVariableName = this.variableName.Value;
			}
			if (this.targetVariable == null)
			{
				base.LogWarning("Missing Variable: " + this.variableName.Value);
				return;
			}
			this.setValue.ApplyValueTo(this.targetVariable);
		}

		// Token: 0x04004831 RID: 18481
		[RequiredField]
		[Tooltip("The GameObject that owns the FSM")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004832 RID: 18482
		[UIHint(UIHint.FsmName)]
		[Tooltip("Optional name of FSM on Game Object")]
		public FsmString fsmName;

		// Token: 0x04004833 RID: 18483
		[Tooltip("The name of the variable in the target FSM.")]
		public FsmString variableName;

		// Token: 0x04004834 RID: 18484
		[RequiredField]
		public FsmVar setValue;

		// Token: 0x04004835 RID: 18485
		[Tooltip("Repeat every frame.")]
		public bool everyFrame;

		// Token: 0x04004836 RID: 18486
		private PlayMakerFSM targetFsm;

		// Token: 0x04004837 RID: 18487
		private NamedVariable targetVariable;

		// Token: 0x04004838 RID: 18488
		private INamedVariable sourceVariable;

		// Token: 0x04004839 RID: 18489
		private GameObject cachedGameObject;

		// Token: 0x0400483A RID: 18490
		private string cachedFsmName;

		// Token: 0x0400483B RID: 18491
		private string cachedVariableName;
	}
}
