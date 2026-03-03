using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BE4 RID: 3044
	[ActionCategory(ActionCategory.StateMachine)]
	[ActionTarget(typeof(PlayMakerFSM), "gameObject,fsmName", false)]
	[Tooltip("Get the value of a Material Variable from another FSM.")]
	public class GetFsmMaterial : FsmStateAction
	{
		// Token: 0x06004010 RID: 16400 RVA: 0x001693FA File Offset: 0x001675FA
		public override void Reset()
		{
			this.gameObject = null;
			this.fsmName = "";
			this.variableName = "";
			this.storeValue = null;
			this.everyFrame = false;
		}

		// Token: 0x06004011 RID: 16401 RVA: 0x00169431 File Offset: 0x00167631
		public override void OnEnter()
		{
			this.DoGetFsmVariable();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004012 RID: 16402 RVA: 0x00169447 File Offset: 0x00167647
		public override void OnUpdate()
		{
			this.DoGetFsmVariable();
		}

		// Token: 0x06004013 RID: 16403 RVA: 0x00169450 File Offset: 0x00167650
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
			FsmMaterial fsmMaterial = this.fsm.FsmVariables.GetFsmMaterial(this.variableName.Value);
			if (fsmMaterial != null)
			{
				this.storeValue.Value = fsmMaterial.Value;
			}
		}

		// Token: 0x04004460 RID: 17504
		[RequiredField]
		[Tooltip("The GameObject that owns the FSM.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004461 RID: 17505
		[UIHint(UIHint.FsmName)]
		[Tooltip("Optional name of FSM on Game Object")]
		public FsmString fsmName;

		// Token: 0x04004462 RID: 17506
		[RequiredField]
		[UIHint(UIHint.FsmMaterial)]
		public FsmString variableName;

		// Token: 0x04004463 RID: 17507
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmMaterial storeValue;

		// Token: 0x04004464 RID: 17508
		[Tooltip("Repeat every frame.")]
		public bool everyFrame;

		// Token: 0x04004465 RID: 17509
		private GameObject goLastFrame;

		// Token: 0x04004466 RID: 17510
		protected PlayMakerFSM fsm;
	}
}
