using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CB0 RID: 3248
	[ActionCategory(ActionCategory.StateMachine)]
	[ActionTarget(typeof(PlayMakerFSM), "gameObject,fsmName", false)]
	[Tooltip("Set the value of a Rect Variable in another FSM.")]
	public class SetFsmRect : FsmStateAction
	{
		// Token: 0x060043BA RID: 17338 RVA: 0x00173F2D File Offset: 0x0017212D
		public override void Reset()
		{
			this.gameObject = null;
			this.fsmName = "";
			this.variableName = "";
			this.setValue = null;
			this.everyFrame = false;
		}

		// Token: 0x060043BB RID: 17339 RVA: 0x00173F64 File Offset: 0x00172164
		public override void OnEnter()
		{
			this.DoSetFsmBool();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060043BC RID: 17340 RVA: 0x00173F7C File Offset: 0x0017217C
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
			FsmRect fsmRect = this.fsm.FsmVariables.GetFsmRect(this.variableName.Value);
			if (fsmRect != null)
			{
				fsmRect.Value = this.setValue.Value;
				return;
			}
			base.LogWarning("Could not find variable: " + this.variableName.Value);
		}

		// Token: 0x060043BD RID: 17341 RVA: 0x00174079 File Offset: 0x00172279
		public override void OnUpdate()
		{
			this.DoSetFsmBool();
		}

		// Token: 0x04004812 RID: 18450
		[RequiredField]
		[Tooltip("The GameObject that owns the FSM.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004813 RID: 18451
		[UIHint(UIHint.FsmName)]
		[Tooltip("Optional name of FSM on Game Object")]
		public FsmString fsmName;

		// Token: 0x04004814 RID: 18452
		[RequiredField]
		[UIHint(UIHint.FsmRect)]
		[Tooltip("The name of the FSM variable.")]
		public FsmString variableName;

		// Token: 0x04004815 RID: 18453
		[RequiredField]
		[Tooltip("Set the value of the variable.")]
		public FsmRect setValue;

		// Token: 0x04004816 RID: 18454
		[Tooltip("Repeat every frame. Useful if the value is changing.")]
		public bool everyFrame;

		// Token: 0x04004817 RID: 18455
		private GameObject goLastFrame;

		// Token: 0x04004818 RID: 18456
		private string fsmNameLastFrame;

		// Token: 0x04004819 RID: 18457
		private PlayMakerFSM fsm;
	}
}
