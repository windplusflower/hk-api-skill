using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CA9 RID: 3241
	[ActionCategory(ActionCategory.StateMachine)]
	[ActionTarget(typeof(PlayMakerFSM), "gameObject,fsmName", false)]
	[Tooltip("Set the value of a String Variable in another FSM.")]
	public class SetFsmEnum : FsmStateAction
	{
		// Token: 0x06004397 RID: 17303 RVA: 0x00173651 File Offset: 0x00171851
		public override void Reset()
		{
			this.gameObject = null;
			this.fsmName = "";
			this.setValue = null;
		}

		// Token: 0x06004398 RID: 17304 RVA: 0x00173671 File Offset: 0x00171871
		public override void OnEnter()
		{
			this.DoSetFsmEnum();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004399 RID: 17305 RVA: 0x00173688 File Offset: 0x00171888
		private void DoSetFsmEnum()
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
			FsmEnum fsmEnum = this.fsm.FsmVariables.GetFsmEnum(this.variableName.Value);
			if (fsmEnum != null)
			{
				fsmEnum.Value = this.setValue.Value;
				return;
			}
			base.LogWarning("Could not find variable: " + this.variableName.Value);
		}

		// Token: 0x0600439A RID: 17306 RVA: 0x00173785 File Offset: 0x00171985
		public override void OnUpdate()
		{
			this.DoSetFsmEnum();
		}

		// Token: 0x040047DA RID: 18394
		[RequiredField]
		[Tooltip("The GameObject that owns the FSM.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x040047DB RID: 18395
		[UIHint(UIHint.FsmName)]
		[Tooltip("Optional name of FSM on Game Object.")]
		public FsmString fsmName;

		// Token: 0x040047DC RID: 18396
		[RequiredField]
		[UIHint(UIHint.FsmEnum)]
		[Tooltip("Enum variable name needs to match the FSM variable name on Game Object.")]
		public FsmString variableName;

		// Token: 0x040047DD RID: 18397
		[RequiredField]
		public FsmEnum setValue;

		// Token: 0x040047DE RID: 18398
		[Tooltip("Repeat every frame. Useful if the value is changing.")]
		public bool everyFrame;

		// Token: 0x040047DF RID: 18399
		private GameObject goLastFrame;

		// Token: 0x040047E0 RID: 18400
		private string fsmNameLastFrame;

		// Token: 0x040047E1 RID: 18401
		private PlayMakerFSM fsm;
	}
}
