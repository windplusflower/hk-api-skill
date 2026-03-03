using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BDF RID: 3039
	[ActionCategory(ActionCategory.StateMachine)]
	[ActionTarget(typeof(PlayMakerFSM), "gameObject,fsmName", false)]
	[Tooltip("Get the value of a Color Variable from another FSM.")]
	public class GetFsmColor : FsmStateAction
	{
		// Token: 0x06003FF7 RID: 16375 RVA: 0x00168FA6 File Offset: 0x001671A6
		public override void Reset()
		{
			this.gameObject = null;
			this.fsmName = "";
			this.storeValue = null;
		}

		// Token: 0x06003FF8 RID: 16376 RVA: 0x00168FC6 File Offset: 0x001671C6
		public override void OnEnter()
		{
			this.DoGetFsmColor();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003FF9 RID: 16377 RVA: 0x00168FDC File Offset: 0x001671DC
		public override void OnUpdate()
		{
			this.DoGetFsmColor();
		}

		// Token: 0x06003FFA RID: 16378 RVA: 0x00168FE4 File Offset: 0x001671E4
		private void DoGetFsmColor()
		{
			if (this.storeValue == null)
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
				return;
			}
			FsmColor fsmColor = this.fsm.FsmVariables.GetFsmColor(this.variableName.Value);
			if (fsmColor == null)
			{
				return;
			}
			this.storeValue.Value = fsmColor.Value;
		}

		// Token: 0x0400443D RID: 17469
		[RequiredField]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400443E RID: 17470
		[UIHint(UIHint.FsmName)]
		[Tooltip("Optional name of FSM on Game Object")]
		public FsmString fsmName;

		// Token: 0x0400443F RID: 17471
		[RequiredField]
		[UIHint(UIHint.FsmColor)]
		public FsmString variableName;

		// Token: 0x04004440 RID: 17472
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmColor storeValue;

		// Token: 0x04004441 RID: 17473
		public bool everyFrame;

		// Token: 0x04004442 RID: 17474
		private GameObject goLastFrame;

		// Token: 0x04004443 RID: 17475
		private PlayMakerFSM fsm;
	}
}
