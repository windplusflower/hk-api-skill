using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BE5 RID: 3045
	[ActionCategory(ActionCategory.StateMachine)]
	[ActionTarget(typeof(PlayMakerFSM), "gameObject,fsmName", false)]
	[Tooltip("Get the value of an Object Variable from another FSM.")]
	public class GetFsmObject : FsmStateAction
	{
		// Token: 0x06004015 RID: 16405 RVA: 0x001694EC File Offset: 0x001676EC
		public override void Reset()
		{
			this.gameObject = null;
			this.fsmName = "";
			this.variableName = "";
			this.storeValue = null;
			this.everyFrame = false;
		}

		// Token: 0x06004016 RID: 16406 RVA: 0x00169523 File Offset: 0x00167723
		public override void OnEnter()
		{
			this.DoGetFsmVariable();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004017 RID: 16407 RVA: 0x00169539 File Offset: 0x00167739
		public override void OnUpdate()
		{
			this.DoGetFsmVariable();
		}

		// Token: 0x06004018 RID: 16408 RVA: 0x00169544 File Offset: 0x00167744
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
			FsmObject fsmObject = this.fsm.FsmVariables.GetFsmObject(this.variableName.Value);
			if (fsmObject != null)
			{
				this.storeValue.Value = fsmObject.Value;
			}
		}

		// Token: 0x04004467 RID: 17511
		[RequiredField]
		[Tooltip("The GameObject that owns the FSM.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004468 RID: 17512
		[UIHint(UIHint.FsmName)]
		[Tooltip("Optional name of FSM on Game Object")]
		public FsmString fsmName;

		// Token: 0x04004469 RID: 17513
		[RequiredField]
		[UIHint(UIHint.FsmObject)]
		public FsmString variableName;

		// Token: 0x0400446A RID: 17514
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmObject storeValue;

		// Token: 0x0400446B RID: 17515
		[Tooltip("Repeat every frame.")]
		public bool everyFrame;

		// Token: 0x0400446C RID: 17516
		private GameObject goLastFrame;

		// Token: 0x0400446D RID: 17517
		protected PlayMakerFSM fsm;
	}
}
