using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CB2 RID: 3250
	[ActionCategory(ActionCategory.StateMachine)]
	[ActionTarget(typeof(PlayMakerFSM), "gameObject,fsmName", false)]
	[Tooltip("Set the value of a String Variable in another FSM, and returns it to it's previous value on exit.")]
	public class SetFsmStringReturn : FsmStateAction
	{
		// Token: 0x060043C4 RID: 17348 RVA: 0x001741BD File Offset: 0x001723BD
		public override void Reset()
		{
			this.gameObject = null;
			this.fsmName = "";
			this.setValue = null;
		}

		// Token: 0x060043C5 RID: 17349 RVA: 0x001741E0 File Offset: 0x001723E0
		public override void OnEnter()
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
			this.fsm = ActionHelpers.GetGameObjectFsm(ownerDefaultTarget, this.fsmName.Value);
			if (this.fsm == null)
			{
				base.LogWarning("Could not find FSM: " + this.fsmName.Value);
				return;
			}
			this.fsmString = this.fsm.FsmVariables.GetFsmString(this.variableName.Value);
			if (this.fsmString != null)
			{
				this.previousValue = this.fsmString.Value;
				this.fsmString.Value = this.setValue.Value;
			}
			else
			{
				base.LogWarning("Could not find variable: " + this.variableName.Value);
			}
			base.Finish();
		}

		// Token: 0x060043C6 RID: 17350 RVA: 0x001742C6 File Offset: 0x001724C6
		public override void OnExit()
		{
			if (this.fsmString != null)
			{
				this.fsmString.Value = this.previousValue;
			}
		}

		// Token: 0x04004822 RID: 18466
		[RequiredField]
		[Tooltip("The GameObject that owns the FSM.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004823 RID: 18467
		[UIHint(UIHint.FsmName)]
		[Tooltip("Optional name of FSM on Game Object.")]
		public FsmString fsmName;

		// Token: 0x04004824 RID: 18468
		[RequiredField]
		[UIHint(UIHint.FsmString)]
		[Tooltip("The name of the FSM variable.")]
		public FsmString variableName;

		// Token: 0x04004825 RID: 18469
		[Tooltip("Set the value of the variable.")]
		public FsmString setValue;

		// Token: 0x04004826 RID: 18470
		private PlayMakerFSM fsm;

		// Token: 0x04004827 RID: 18471
		private FsmString fsmString;

		// Token: 0x04004828 RID: 18472
		private string previousValue;
	}
}
