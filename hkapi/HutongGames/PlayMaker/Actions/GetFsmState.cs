using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BE8 RID: 3048
	[ActionCategory(ActionCategory.StateMachine)]
	[ActionTarget(typeof(PlayMakerFSM), "fsmComponent", false)]
	[Tooltip("Gets the name of the specified FSMs current state. Either reference the fsm component directly, or find it on a game object.")]
	public class GetFsmState : FsmStateAction
	{
		// Token: 0x06004024 RID: 16420 RVA: 0x001697C8 File Offset: 0x001679C8
		public override void Reset()
		{
			this.fsmComponent = null;
			this.gameObject = null;
			this.fsmName = "";
			this.storeResult = null;
			this.everyFrame = false;
		}

		// Token: 0x06004025 RID: 16421 RVA: 0x001697F6 File Offset: 0x001679F6
		public override void OnEnter()
		{
			this.DoGetFsmState();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004026 RID: 16422 RVA: 0x0016980C File Offset: 0x00167A0C
		public override void OnUpdate()
		{
			this.DoGetFsmState();
		}

		// Token: 0x06004027 RID: 16423 RVA: 0x00169814 File Offset: 0x00167A14
		private void DoGetFsmState()
		{
			if (this.fsm == null)
			{
				if (this.fsmComponent != null)
				{
					this.fsm = this.fsmComponent;
				}
				else
				{
					GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
					if (ownerDefaultTarget != null)
					{
						this.fsm = ActionHelpers.GetGameObjectFsm(ownerDefaultTarget, this.fsmName.Value);
					}
				}
				if (this.fsm == null)
				{
					this.storeResult.Value = "";
					return;
				}
			}
			this.storeResult.Value = this.fsm.ActiveStateName;
		}

		// Token: 0x0400447C RID: 17532
		[Tooltip("Drag a PlayMakerFSM component here.")]
		public PlayMakerFSM fsmComponent;

		// Token: 0x0400447D RID: 17533
		[Tooltip("If not specifyng the component above, specify the GameObject that owns the FSM")]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400447E RID: 17534
		[UIHint(UIHint.FsmName)]
		[Tooltip("Optional name of Fsm on Game Object. If left blank it will find the first PlayMakerFSM on the GameObject.")]
		public FsmString fsmName;

		// Token: 0x0400447F RID: 17535
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the state name in a string variable.")]
		public FsmString storeResult;

		// Token: 0x04004480 RID: 17536
		[Tooltip("Repeat every frame. E.g.,  useful if you're waiting for the state to change.")]
		public bool everyFrame;

		// Token: 0x04004481 RID: 17537
		private PlayMakerFSM fsm;
	}
}
