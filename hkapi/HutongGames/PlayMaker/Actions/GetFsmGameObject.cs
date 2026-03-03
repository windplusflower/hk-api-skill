using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BE2 RID: 3042
	[ActionCategory(ActionCategory.StateMachine)]
	[ActionTarget(typeof(PlayMakerFSM), "gameObject,fsmName", false)]
	[Tooltip("Get the value of a Game Object Variable from another FSM.")]
	public class GetFsmGameObject : FsmStateAction
	{
		// Token: 0x06004006 RID: 16390 RVA: 0x0016923F File Offset: 0x0016743F
		public override void Reset()
		{
			this.gameObject = null;
			this.fsmName = "";
			this.storeValue = null;
		}

		// Token: 0x06004007 RID: 16391 RVA: 0x0016925F File Offset: 0x0016745F
		public override void OnEnter()
		{
			this.DoGetFsmGameObject();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004008 RID: 16392 RVA: 0x00169275 File Offset: 0x00167475
		public override void OnUpdate()
		{
			this.DoGetFsmGameObject();
		}

		// Token: 0x06004009 RID: 16393 RVA: 0x00169280 File Offset: 0x00167480
		private void DoGetFsmGameObject()
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
			FsmGameObject fsmGameObject = this.fsm.FsmVariables.GetFsmGameObject(this.variableName.Value);
			if (fsmGameObject == null)
			{
				return;
			}
			this.storeValue.Value = fsmGameObject.Value;
		}

		// Token: 0x04004452 RID: 17490
		[RequiredField]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004453 RID: 17491
		[UIHint(UIHint.FsmName)]
		[Tooltip("Optional name of FSM on Game Object")]
		public FsmString fsmName;

		// Token: 0x04004454 RID: 17492
		[RequiredField]
		[UIHint(UIHint.FsmGameObject)]
		public FsmString variableName;

		// Token: 0x04004455 RID: 17493
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmGameObject storeValue;

		// Token: 0x04004456 RID: 17494
		public bool everyFrame;

		// Token: 0x04004457 RID: 17495
		private GameObject goLastFrame;

		// Token: 0x04004458 RID: 17496
		private PlayMakerFSM fsm;
	}
}
