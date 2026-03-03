using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BE0 RID: 3040
	[ActionCategory(ActionCategory.StateMachine)]
	[ActionTarget(typeof(PlayMakerFSM), "gameObject,fsmName", false)]
	[Tooltip("Get the value of an Enum Variable from another FSM.")]
	public class GetFsmEnum : FsmStateAction
	{
		// Token: 0x06003FFC RID: 16380 RVA: 0x00169082 File Offset: 0x00167282
		public override void Reset()
		{
			this.gameObject = null;
			this.fsmName = "";
			this.storeValue = null;
		}

		// Token: 0x06003FFD RID: 16381 RVA: 0x001690A2 File Offset: 0x001672A2
		public override void OnEnter()
		{
			this.DoGetFsmEnum();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003FFE RID: 16382 RVA: 0x001690B8 File Offset: 0x001672B8
		public override void OnUpdate()
		{
			this.DoGetFsmEnum();
		}

		// Token: 0x06003FFF RID: 16383 RVA: 0x001690C0 File Offset: 0x001672C0
		private void DoGetFsmEnum()
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
			FsmEnum fsmEnum = this.fsm.FsmVariables.GetFsmEnum(this.variableName.Value);
			if (fsmEnum == null)
			{
				return;
			}
			this.storeValue.Value = fsmEnum.Value;
		}

		// Token: 0x04004444 RID: 17476
		[RequiredField]
		[Tooltip("The target FSM")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004445 RID: 17477
		[UIHint(UIHint.FsmName)]
		[Tooltip("Optional name of FSM on Game Object")]
		public FsmString fsmName;

		// Token: 0x04004446 RID: 17478
		[RequiredField]
		[UIHint(UIHint.FsmBool)]
		public FsmString variableName;

		// Token: 0x04004447 RID: 17479
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmEnum storeValue;

		// Token: 0x04004448 RID: 17480
		[Tooltip("Repeat every frame")]
		public bool everyFrame;

		// Token: 0x04004449 RID: 17481
		private GameObject goLastFrame;

		// Token: 0x0400444A RID: 17482
		private PlayMakerFSM fsm;
	}
}
