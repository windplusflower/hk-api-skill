using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CA8 RID: 3240
	[ActionCategory(ActionCategory.StateMachine)]
	[ActionTarget(typeof(PlayMakerFSM), "gameObject,fsmName", false)]
	[Tooltip("Set the value of a Color Variable in another FSM.")]
	public class SetFsmColor : FsmStateAction
	{
		// Token: 0x06004392 RID: 17298 RVA: 0x00173515 File Offset: 0x00171715
		public override void Reset()
		{
			this.gameObject = null;
			this.fsmName = "";
			this.setValue = null;
		}

		// Token: 0x06004393 RID: 17299 RVA: 0x00173535 File Offset: 0x00171735
		public override void OnEnter()
		{
			this.DoSetFsmColor();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004394 RID: 17300 RVA: 0x0017354C File Offset: 0x0017174C
		private void DoSetFsmColor()
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
			FsmColor fsmColor = this.fsm.FsmVariables.GetFsmColor(this.variableName.Value);
			if (fsmColor != null)
			{
				fsmColor.Value = this.setValue.Value;
				return;
			}
			base.LogWarning("Could not find variable: " + this.variableName.Value);
		}

		// Token: 0x06004395 RID: 17301 RVA: 0x00173649 File Offset: 0x00171849
		public override void OnUpdate()
		{
			this.DoSetFsmColor();
		}

		// Token: 0x040047D2 RID: 18386
		[RequiredField]
		[Tooltip("The GameObject that owns the FSM.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x040047D3 RID: 18387
		[UIHint(UIHint.FsmName)]
		[Tooltip("Optional name of FSM on Game Object")]
		public FsmString fsmName;

		// Token: 0x040047D4 RID: 18388
		[RequiredField]
		[UIHint(UIHint.FsmColor)]
		[Tooltip("The name of the FSM variable.")]
		public FsmString variableName;

		// Token: 0x040047D5 RID: 18389
		[RequiredField]
		[Tooltip("Set the value of the variable.")]
		public FsmColor setValue;

		// Token: 0x040047D6 RID: 18390
		[Tooltip("Repeat every frame. Useful if the value is changing.")]
		public bool everyFrame;

		// Token: 0x040047D7 RID: 18391
		private GameObject goLastFrame;

		// Token: 0x040047D8 RID: 18392
		private string fsmNameLastFrame;

		// Token: 0x040047D9 RID: 18393
		private PlayMakerFSM fsm;
	}
}
