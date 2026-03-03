using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CB3 RID: 3251
	[ActionCategory(ActionCategory.StateMachine)]
	[ActionTarget(typeof(PlayMakerFSM), "gameObject,fsmName", false)]
	[Tooltip("Set the value of a Texture Variable in another FSM.")]
	public class SetFsmTexture : FsmStateAction
	{
		// Token: 0x060043C8 RID: 17352 RVA: 0x001742E1 File Offset: 0x001724E1
		public override void Reset()
		{
			this.gameObject = null;
			this.fsmName = "";
			this.variableName = "";
			this.setValue = null;
			this.everyFrame = false;
		}

		// Token: 0x060043C9 RID: 17353 RVA: 0x00174318 File Offset: 0x00172518
		public override void OnEnter()
		{
			this.DoSetFsmBool();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060043CA RID: 17354 RVA: 0x00174330 File Offset: 0x00172530
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
			FsmTexture fsmTexture = this.fsm.FsmVariables.FindFsmTexture(this.variableName.Value);
			if (fsmTexture != null)
			{
				fsmTexture.Value = this.setValue.Value;
				return;
			}
			base.LogWarning("Could not find variable: " + this.variableName.Value);
		}

		// Token: 0x060043CB RID: 17355 RVA: 0x0017442D File Offset: 0x0017262D
		public override void OnUpdate()
		{
			this.DoSetFsmBool();
		}

		// Token: 0x04004829 RID: 18473
		[RequiredField]
		[Tooltip("The GameObject that owns the FSM.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400482A RID: 18474
		[UIHint(UIHint.FsmName)]
		[Tooltip("Optional name of FSM on Game Object")]
		public FsmString fsmName;

		// Token: 0x0400482B RID: 18475
		[RequiredField]
		[UIHint(UIHint.FsmTexture)]
		[Tooltip("The name of the FSM variable.")]
		public FsmString variableName;

		// Token: 0x0400482C RID: 18476
		[Tooltip("Set the value of the variable.")]
		public FsmTexture setValue;

		// Token: 0x0400482D RID: 18477
		[Tooltip("Repeat every frame. Useful if the value is changing.")]
		public bool everyFrame;

		// Token: 0x0400482E RID: 18478
		private GameObject goLastFrame;

		// Token: 0x0400482F RID: 18479
		private string fsmNameLastFrame;

		// Token: 0x04004830 RID: 18480
		private PlayMakerFSM fsm;
	}
}
