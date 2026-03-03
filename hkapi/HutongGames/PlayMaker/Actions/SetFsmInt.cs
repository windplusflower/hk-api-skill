using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CAC RID: 3244
	[ActionCategory(ActionCategory.StateMachine)]
	[ActionTarget(typeof(PlayMakerFSM), "gameObject,fsmName", false)]
	[Tooltip("Set the value of an Integer Variable in another FSM.")]
	public class SetFsmInt : FsmStateAction
	{
		// Token: 0x060043A6 RID: 17318 RVA: 0x001739F4 File Offset: 0x00171BF4
		public override void Reset()
		{
			this.gameObject = null;
			this.fsmName = "";
			this.setValue = null;
		}

		// Token: 0x060043A7 RID: 17319 RVA: 0x00173A14 File Offset: 0x00171C14
		public override void OnEnter()
		{
			this.DoSetFsmInt();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060043A8 RID: 17320 RVA: 0x00173A2C File Offset: 0x00171C2C
		private void DoSetFsmInt()
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
			FsmInt fsmInt = this.fsm.FsmVariables.GetFsmInt(this.variableName.Value);
			if (fsmInt != null)
			{
				fsmInt.Value = this.setValue.Value;
				return;
			}
			base.LogWarning("Could not find variable: " + this.variableName.Value);
		}

		// Token: 0x060043A9 RID: 17321 RVA: 0x00173B29 File Offset: 0x00171D29
		public override void OnUpdate()
		{
			this.DoSetFsmInt();
		}

		// Token: 0x040047F2 RID: 18418
		[RequiredField]
		[Tooltip("The GameObject that owns the FSM.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x040047F3 RID: 18419
		[UIHint(UIHint.FsmName)]
		[Tooltip("Optional name of FSM on Game Object")]
		public FsmString fsmName;

		// Token: 0x040047F4 RID: 18420
		[RequiredField]
		[UIHint(UIHint.FsmInt)]
		[Tooltip("The name of the FSM variable.")]
		public FsmString variableName;

		// Token: 0x040047F5 RID: 18421
		[RequiredField]
		[Tooltip("Set the value of the variable.")]
		public FsmInt setValue;

		// Token: 0x040047F6 RID: 18422
		[Tooltip("Repeat every frame. Useful if the value is changing.")]
		public bool everyFrame;

		// Token: 0x040047F7 RID: 18423
		private GameObject goLastFrame;

		// Token: 0x040047F8 RID: 18424
		private string fsmNameLastFrame;

		// Token: 0x040047F9 RID: 18425
		private PlayMakerFSM fsm;
	}
}
