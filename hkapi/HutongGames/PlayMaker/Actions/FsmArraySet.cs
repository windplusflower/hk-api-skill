using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B23 RID: 2851
	[ActionCategory(ActionCategory.Array)]
	[ActionTarget(typeof(PlayMakerFSM), "gameObject,fsmName", false)]
	[Obsolete("This action was wip and accidentally released.")]
	[Tooltip("Set an item in an Array Variable in another FSM.")]
	public class FsmArraySet : FsmStateAction
	{
		// Token: 0x06003D10 RID: 15632 RVA: 0x0015FA67 File Offset: 0x0015DC67
		public override void Reset()
		{
			this.gameObject = null;
			this.fsmName = "";
			this.setValue = null;
		}

		// Token: 0x06003D11 RID: 15633 RVA: 0x0015FA87 File Offset: 0x0015DC87
		public override void OnEnter()
		{
			this.DoSetFsmString();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003D12 RID: 15634 RVA: 0x0015FAA0 File Offset: 0x0015DCA0
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
			if (ownerDefaultTarget != this.goLastFrame)
			{
				this.goLastFrame = ownerDefaultTarget;
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

		// Token: 0x06003D13 RID: 15635 RVA: 0x0015FB74 File Offset: 0x0015DD74
		public override void OnUpdate()
		{
			this.DoSetFsmString();
		}

		// Token: 0x04004117 RID: 16663
		[RequiredField]
		[Tooltip("The GameObject that owns the FSM.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004118 RID: 16664
		[UIHint(UIHint.FsmName)]
		[Tooltip("Optional name of FSM on Game Object.")]
		public FsmString fsmName;

		// Token: 0x04004119 RID: 16665
		[RequiredField]
		[Tooltip("The name of the FSM variable.")]
		public FsmString variableName;

		// Token: 0x0400411A RID: 16666
		[Tooltip("Set the value of the variable.")]
		public FsmString setValue;

		// Token: 0x0400411B RID: 16667
		[Tooltip("Repeat every frame. Useful if the value is changing.")]
		public bool everyFrame;

		// Token: 0x0400411C RID: 16668
		private GameObject goLastFrame;

		// Token: 0x0400411D RID: 16669
		private PlayMakerFSM fsm;
	}
}
