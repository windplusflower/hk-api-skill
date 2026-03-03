using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CB5 RID: 3253
	[ActionCategory(ActionCategory.StateMachine)]
	[ActionTarget(typeof(PlayMakerFSM), "gameObject,fsmName", false)]
	[Tooltip("Set the value of a Vector2 Variable in another FSM.")]
	public class SetFsmVector2 : FsmStateAction
	{
		// Token: 0x060043D2 RID: 17362 RVA: 0x001745AF File Offset: 0x001727AF
		public override void Reset()
		{
			this.gameObject = null;
			this.fsmName = "";
			this.setValue = null;
		}

		// Token: 0x060043D3 RID: 17363 RVA: 0x001745CF File Offset: 0x001727CF
		public override void OnEnter()
		{
			this.DoSetFsmVector2();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060043D4 RID: 17364 RVA: 0x001745E8 File Offset: 0x001727E8
		private void DoSetFsmVector2()
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
			FsmVector2 fsmVector = this.fsm.FsmVariables.GetFsmVector2(this.variableName.Value);
			if (fsmVector != null)
			{
				fsmVector.Value = this.setValue.Value;
				return;
			}
			base.LogWarning("Could not find variable: " + this.variableName.Value);
		}

		// Token: 0x060043D5 RID: 17365 RVA: 0x001746E5 File Offset: 0x001728E5
		public override void OnUpdate()
		{
			this.DoSetFsmVector2();
		}

		// Token: 0x0400483C RID: 18492
		[RequiredField]
		[Tooltip("The GameObject that owns the FSM.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400483D RID: 18493
		[UIHint(UIHint.FsmName)]
		[Tooltip("Optional name of FSM on Game Object")]
		public FsmString fsmName;

		// Token: 0x0400483E RID: 18494
		[RequiredField]
		[UIHint(UIHint.FsmVector2)]
		[Tooltip("The name of the FSM variable.")]
		public FsmString variableName;

		// Token: 0x0400483F RID: 18495
		[RequiredField]
		[Tooltip("Set the value of the variable.")]
		public FsmVector2 setValue;

		// Token: 0x04004840 RID: 18496
		[Tooltip("Repeat every frame. Useful if the value is changing.")]
		public bool everyFrame;

		// Token: 0x04004841 RID: 18497
		private GameObject goLastFrame;

		// Token: 0x04004842 RID: 18498
		private string fsmNameLastFrame;

		// Token: 0x04004843 RID: 18499
		private PlayMakerFSM fsm;
	}
}
