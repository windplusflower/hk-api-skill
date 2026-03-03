using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BEA RID: 3050
	[ActionCategory(ActionCategory.StateMachine)]
	[ActionTarget(typeof(PlayMakerFSM), "gameObject,fsmName", false)]
	[Tooltip("Get the value of a Texture Variable from another FSM.")]
	public class GetFsmTexture : FsmStateAction
	{
		// Token: 0x0600402E RID: 16430 RVA: 0x0016998E File Offset: 0x00167B8E
		public override void Reset()
		{
			this.gameObject = null;
			this.fsmName = "";
			this.variableName = "";
			this.storeValue = null;
			this.everyFrame = false;
		}

		// Token: 0x0600402F RID: 16431 RVA: 0x001699C5 File Offset: 0x00167BC5
		public override void OnEnter()
		{
			this.DoGetFsmVariable();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004030 RID: 16432 RVA: 0x001699DB File Offset: 0x00167BDB
		public override void OnUpdate()
		{
			this.DoGetFsmVariable();
		}

		// Token: 0x06004031 RID: 16433 RVA: 0x001699E4 File Offset: 0x00167BE4
		private void DoGetFsmVariable()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			if (ownerDefaultTarget != this.goLastFrame)
			{
				this.goLastFrame = ownerDefaultTarget;
				this.fsm = ActionHelpers.GetGameObjectFsm(ownerDefaultTarget, this.fsmName.Value);
			}
			if (this.fsm == null || this.storeValue == null)
			{
				return;
			}
			FsmTexture fsmTexture = this.fsm.FsmVariables.GetFsmTexture(this.variableName.Value);
			if (fsmTexture != null)
			{
				this.storeValue.Value = fsmTexture.Value;
			}
		}

		// Token: 0x04004489 RID: 17545
		[RequiredField]
		[Tooltip("The GameObject that owns the FSM.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400448A RID: 17546
		[UIHint(UIHint.FsmName)]
		[Tooltip("Optional name of FSM on Game Object")]
		public FsmString fsmName;

		// Token: 0x0400448B RID: 17547
		[RequiredField]
		[UIHint(UIHint.FsmTexture)]
		public FsmString variableName;

		// Token: 0x0400448C RID: 17548
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmTexture storeValue;

		// Token: 0x0400448D RID: 17549
		[Tooltip("Repeat every frame.")]
		public bool everyFrame;

		// Token: 0x0400448E RID: 17550
		private GameObject goLastFrame;

		// Token: 0x0400448F RID: 17551
		protected PlayMakerFSM fsm;
	}
}
