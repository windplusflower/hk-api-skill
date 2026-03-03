using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CB1 RID: 3249
	[ActionCategory(ActionCategory.StateMachine)]
	[ActionTarget(typeof(PlayMakerFSM), "gameObject,fsmName", false)]
	[Tooltip("Set the value of a String Variable in another FSM.")]
	public class SetFsmString : FsmStateAction
	{
		// Token: 0x060043BF RID: 17343 RVA: 0x00174081 File Offset: 0x00172281
		public override void Reset()
		{
			this.gameObject = null;
			this.fsmName = "";
			this.setValue = null;
		}

		// Token: 0x060043C0 RID: 17344 RVA: 0x001740A1 File Offset: 0x001722A1
		public override void OnEnter()
		{
			this.DoSetFsmString();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060043C1 RID: 17345 RVA: 0x001740B8 File Offset: 0x001722B8
		private void DoSetFsmString()
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
			FsmString fsmString = this.fsm.FsmVariables.GetFsmString(this.variableName.Value);
			if (fsmString != null)
			{
				fsmString.Value = this.setValue.Value;
				return;
			}
			base.LogWarning("Could not find variable: " + this.variableName.Value);
		}

		// Token: 0x060043C2 RID: 17346 RVA: 0x001741B5 File Offset: 0x001723B5
		public override void OnUpdate()
		{
			this.DoSetFsmString();
		}

		// Token: 0x0400481A RID: 18458
		[RequiredField]
		[Tooltip("The GameObject that owns the FSM.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400481B RID: 18459
		[UIHint(UIHint.FsmName)]
		[Tooltip("Optional name of FSM on Game Object.")]
		public FsmString fsmName;

		// Token: 0x0400481C RID: 18460
		[RequiredField]
		[UIHint(UIHint.FsmString)]
		[Tooltip("The name of the FSM variable.")]
		public FsmString variableName;

		// Token: 0x0400481D RID: 18461
		[Tooltip("Set the value of the variable.")]
		public FsmString setValue;

		// Token: 0x0400481E RID: 18462
		[Tooltip("Repeat every frame. Useful if the value is changing.")]
		public bool everyFrame;

		// Token: 0x0400481F RID: 18463
		private GameObject goLastFrame;

		// Token: 0x04004820 RID: 18464
		private string fsmNameLastFrame;

		// Token: 0x04004821 RID: 18465
		private PlayMakerFSM fsm;
	}
}
