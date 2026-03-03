using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BEE RID: 3054
	[ActionCategory(ActionCategory.StateMachine)]
	[ActionTarget(typeof(PlayMakerFSM), "gameObject,fsmName", false)]
	[Tooltip("Get the value of a Vector3 Variable from another FSM.")]
	public class GetFsmVector3 : FsmStateAction
	{
		// Token: 0x06004044 RID: 16452 RVA: 0x00169E6E File Offset: 0x0016806E
		public override void Reset()
		{
			this.gameObject = null;
			this.fsmName = "";
			this.storeValue = null;
		}

		// Token: 0x06004045 RID: 16453 RVA: 0x00169E8E File Offset: 0x0016808E
		public override void OnEnter()
		{
			this.DoGetFsmVector3();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004046 RID: 16454 RVA: 0x00169EA4 File Offset: 0x001680A4
		public override void OnUpdate()
		{
			this.DoGetFsmVector3();
		}

		// Token: 0x06004047 RID: 16455 RVA: 0x00169EAC File Offset: 0x001680AC
		private void DoGetFsmVector3()
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
			FsmVector3 fsmVector = this.fsm.FsmVariables.GetFsmVector3(this.variableName.Value);
			if (fsmVector == null)
			{
				return;
			}
			this.storeValue.Value = fsmVector.Value;
		}

		// Token: 0x040044A7 RID: 17575
		[RequiredField]
		public FsmOwnerDefault gameObject;

		// Token: 0x040044A8 RID: 17576
		[UIHint(UIHint.FsmName)]
		[Tooltip("Optional name of FSM on Game Object")]
		public FsmString fsmName;

		// Token: 0x040044A9 RID: 17577
		[RequiredField]
		[UIHint(UIHint.FsmVector3)]
		public FsmString variableName;

		// Token: 0x040044AA RID: 17578
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmVector3 storeValue;

		// Token: 0x040044AB RID: 17579
		public bool everyFrame;

		// Token: 0x040044AC RID: 17580
		private GameObject goLastFrame;

		// Token: 0x040044AD RID: 17581
		private PlayMakerFSM fsm;
	}
}
