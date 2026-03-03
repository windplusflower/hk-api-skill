using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BE7 RID: 3047
	[ActionCategory(ActionCategory.StateMachine)]
	[ActionTarget(typeof(PlayMakerFSM), "gameObject,fsmName", false)]
	[Tooltip("Get the value of a Rect Variable from another FSM.")]
	public class GetFsmRect : FsmStateAction
	{
		// Token: 0x0600401F RID: 16415 RVA: 0x001696D4 File Offset: 0x001678D4
		public override void Reset()
		{
			this.gameObject = null;
			this.fsmName = "";
			this.variableName = "";
			this.storeValue = null;
			this.everyFrame = false;
		}

		// Token: 0x06004020 RID: 16416 RVA: 0x0016970B File Offset: 0x0016790B
		public override void OnEnter()
		{
			this.DoGetFsmVariable();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004021 RID: 16417 RVA: 0x00169721 File Offset: 0x00167921
		public override void OnUpdate()
		{
			this.DoGetFsmVariable();
		}

		// Token: 0x06004022 RID: 16418 RVA: 0x0016972C File Offset: 0x0016792C
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
			FsmRect fsmRect = this.fsm.FsmVariables.GetFsmRect(this.variableName.Value);
			if (fsmRect != null)
			{
				this.storeValue.Value = fsmRect.Value;
			}
		}

		// Token: 0x04004475 RID: 17525
		[RequiredField]
		[Tooltip("The GameObject that owns the FSM.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004476 RID: 17526
		[UIHint(UIHint.FsmName)]
		[Tooltip("Optional name of FSM on Game Object")]
		public FsmString fsmName;

		// Token: 0x04004477 RID: 17527
		[RequiredField]
		[UIHint(UIHint.FsmRect)]
		public FsmString variableName;

		// Token: 0x04004478 RID: 17528
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmRect storeValue;

		// Token: 0x04004479 RID: 17529
		[Tooltip("Repeat every frame.")]
		public bool everyFrame;

		// Token: 0x0400447A RID: 17530
		private GameObject goLastFrame;

		// Token: 0x0400447B RID: 17531
		protected PlayMakerFSM fsm;
	}
}
