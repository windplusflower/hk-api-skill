using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CAD RID: 3245
	[ActionCategory(ActionCategory.StateMachine)]
	[ActionTarget(typeof(PlayMakerFSM), "gameObject,fsmName", false)]
	[Tooltip("Set the value of a Material Variable in another FSM.")]
	public class SetFsmMaterial : FsmStateAction
	{
		// Token: 0x060043AB RID: 17323 RVA: 0x00173B31 File Offset: 0x00171D31
		public override void Reset()
		{
			this.gameObject = null;
			this.fsmName = "";
			this.variableName = "";
			this.setValue = null;
			this.everyFrame = false;
		}

		// Token: 0x060043AC RID: 17324 RVA: 0x00173B68 File Offset: 0x00171D68
		public override void OnEnter()
		{
			this.DoSetFsmBool();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060043AD RID: 17325 RVA: 0x00173B80 File Offset: 0x00171D80
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
			FsmMaterial fsmMaterial = this.fsm.FsmVariables.GetFsmMaterial(this.variableName.Value);
			if (fsmMaterial != null)
			{
				fsmMaterial.Value = this.setValue.Value;
				return;
			}
			base.LogWarning("Could not find variable: " + this.variableName.Value);
		}

		// Token: 0x060043AE RID: 17326 RVA: 0x00173C7D File Offset: 0x00171E7D
		public override void OnUpdate()
		{
			this.DoSetFsmBool();
		}

		// Token: 0x040047FA RID: 18426
		[RequiredField]
		[Tooltip("The GameObject that owns the FSM.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x040047FB RID: 18427
		[UIHint(UIHint.FsmName)]
		[Tooltip("Optional name of FSM on Game Object")]
		public FsmString fsmName;

		// Token: 0x040047FC RID: 18428
		[RequiredField]
		[UIHint(UIHint.FsmMaterial)]
		[Tooltip("The name of the FSM variable.")]
		public FsmString variableName;

		// Token: 0x040047FD RID: 18429
		[RequiredField]
		[Tooltip("Set the value of the variable.")]
		public FsmMaterial setValue;

		// Token: 0x040047FE RID: 18430
		[Tooltip("Repeat every frame. Useful if the value is changing.")]
		public bool everyFrame;

		// Token: 0x040047FF RID: 18431
		private GameObject goLastFrame;

		// Token: 0x04004800 RID: 18432
		private string fsmNameLastFrame;

		// Token: 0x04004801 RID: 18433
		private PlayMakerFSM fsm;
	}
}
