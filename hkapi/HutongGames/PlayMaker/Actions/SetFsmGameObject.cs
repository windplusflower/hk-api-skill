using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CAB RID: 3243
	[ActionCategory(ActionCategory.StateMachine)]
	[ActionTarget(typeof(PlayMakerFSM), "gameObject,fsmName", false)]
	[Tooltip("Set the value of a Game Object Variable in another FSM. Accept null reference")]
	public class SetFsmGameObject : FsmStateAction
	{
		// Token: 0x060043A1 RID: 17313 RVA: 0x001738C9 File Offset: 0x00171AC9
		public override void Reset()
		{
			this.gameObject = null;
			this.fsmName = "";
			this.setValue = null;
			this.everyFrame = false;
		}

		// Token: 0x060043A2 RID: 17314 RVA: 0x001738F0 File Offset: 0x00171AF0
		public override void OnEnter()
		{
			this.DoSetFsmGameObject();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060043A3 RID: 17315 RVA: 0x00173908 File Offset: 0x00171B08
		private void DoSetFsmGameObject()
		{
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
				return;
			}
			FsmGameObject fsmGameObject = this.fsm.FsmVariables.FindFsmGameObject(this.variableName.Value);
			if (fsmGameObject != null)
			{
				fsmGameObject.Value = ((this.setValue == null) ? null : this.setValue.Value);
				return;
			}
			base.LogWarning("Could not find variable: " + this.variableName.Value);
		}

		// Token: 0x060043A4 RID: 17316 RVA: 0x001739EC File Offset: 0x00171BEC
		public override void OnUpdate()
		{
			this.DoSetFsmGameObject();
		}

		// Token: 0x040047EA RID: 18410
		[RequiredField]
		[Tooltip("The GameObject that owns the FSM.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x040047EB RID: 18411
		[UIHint(UIHint.FsmName)]
		[Tooltip("Optional name of FSM on Game Object")]
		public FsmString fsmName;

		// Token: 0x040047EC RID: 18412
		[RequiredField]
		[UIHint(UIHint.FsmGameObject)]
		[Tooltip("The name of the FSM variable.")]
		public FsmString variableName;

		// Token: 0x040047ED RID: 18413
		[Tooltip("Set the value of the variable.")]
		public FsmGameObject setValue;

		// Token: 0x040047EE RID: 18414
		[Tooltip("Repeat every frame. Useful if the value is changing.")]
		public bool everyFrame;

		// Token: 0x040047EF RID: 18415
		private GameObject goLastFrame;

		// Token: 0x040047F0 RID: 18416
		private string fsmNameLastFrame;

		// Token: 0x040047F1 RID: 18417
		private PlayMakerFSM fsm;
	}
}
