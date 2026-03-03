using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CAA RID: 3242
	[ActionCategory(ActionCategory.StateMachine)]
	[ActionTarget(typeof(PlayMakerFSM), "gameObject,fsmName", false)]
	[Tooltip("Set the value of a Float Variable in another FSM.")]
	public class SetFsmFloat : FsmStateAction
	{
		// Token: 0x0600439C RID: 17308 RVA: 0x0017378D File Offset: 0x0017198D
		public override void Reset()
		{
			this.gameObject = null;
			this.fsmName = "";
			this.setValue = null;
		}

		// Token: 0x0600439D RID: 17309 RVA: 0x001737AD File Offset: 0x001719AD
		public override void OnEnter()
		{
			this.DoSetFsmFloat();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x0600439E RID: 17310 RVA: 0x001737C4 File Offset: 0x001719C4
		private void DoSetFsmFloat()
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
			FsmFloat fsmFloat = this.fsm.FsmVariables.GetFsmFloat(this.variableName.Value);
			if (fsmFloat != null)
			{
				fsmFloat.Value = this.setValue.Value;
				return;
			}
			base.LogWarning("Could not find variable: " + this.variableName.Value);
		}

		// Token: 0x0600439F RID: 17311 RVA: 0x001738C1 File Offset: 0x00171AC1
		public override void OnUpdate()
		{
			this.DoSetFsmFloat();
		}

		// Token: 0x040047E2 RID: 18402
		[RequiredField]
		[Tooltip("The GameObject that owns the FSM.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x040047E3 RID: 18403
		[UIHint(UIHint.FsmName)]
		[Tooltip("Optional name of FSM on Game Object")]
		public FsmString fsmName;

		// Token: 0x040047E4 RID: 18404
		[RequiredField]
		[UIHint(UIHint.FsmFloat)]
		[Tooltip("The name of the FSM variable.")]
		public FsmString variableName;

		// Token: 0x040047E5 RID: 18405
		[RequiredField]
		[Tooltip("Set the value of the variable.")]
		public FsmFloat setValue;

		// Token: 0x040047E6 RID: 18406
		[Tooltip("Repeat every frame. Useful if the value is changing.")]
		public bool everyFrame;

		// Token: 0x040047E7 RID: 18407
		private GameObject goLastFrame;

		// Token: 0x040047E8 RID: 18408
		private string fsmNameLastFrame;

		// Token: 0x040047E9 RID: 18409
		private PlayMakerFSM fsm;
	}
}
