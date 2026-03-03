using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CA7 RID: 3239
	[ActionCategory(ActionCategory.StateMachine)]
	[ActionTarget(typeof(PlayMakerFSM), "gameObject,fsmName", false)]
	[Tooltip("Set the value of a Bool Variable in another FSM.")]
	public class SetFsmBool : FsmStateAction
	{
		// Token: 0x0600438D RID: 17293 RVA: 0x001733D9 File Offset: 0x001715D9
		public override void Reset()
		{
			this.gameObject = null;
			this.fsmName = "";
			this.setValue = null;
		}

		// Token: 0x0600438E RID: 17294 RVA: 0x001733F9 File Offset: 0x001715F9
		public override void OnEnter()
		{
			this.DoSetFsmBool();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x0600438F RID: 17295 RVA: 0x00173410 File Offset: 0x00171610
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
			FsmBool fsmBool = this.fsm.FsmVariables.FindFsmBool(this.variableName.Value);
			if (fsmBool != null)
			{
				fsmBool.Value = this.setValue.Value;
				return;
			}
			base.LogWarning("Could not find variable: " + this.variableName.Value);
		}

		// Token: 0x06004390 RID: 17296 RVA: 0x0017350D File Offset: 0x0017170D
		public override void OnUpdate()
		{
			this.DoSetFsmBool();
		}

		// Token: 0x040047CA RID: 18378
		[RequiredField]
		[Tooltip("The GameObject that owns the FSM.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x040047CB RID: 18379
		[UIHint(UIHint.FsmName)]
		[Tooltip("Optional name of FSM on Game Object")]
		public FsmString fsmName;

		// Token: 0x040047CC RID: 18380
		[RequiredField]
		[UIHint(UIHint.FsmBool)]
		[Tooltip("The name of the FSM variable.")]
		public FsmString variableName;

		// Token: 0x040047CD RID: 18381
		[RequiredField]
		[Tooltip("Set the value of the variable.")]
		public FsmBool setValue;

		// Token: 0x040047CE RID: 18382
		[Tooltip("Repeat every frame. Useful if the value is changing.")]
		public bool everyFrame;

		// Token: 0x040047CF RID: 18383
		private GameObject goLastFrame;

		// Token: 0x040047D0 RID: 18384
		private string fsmNameLastFrame;

		// Token: 0x040047D1 RID: 18385
		private PlayMakerFSM fsm;
	}
}
