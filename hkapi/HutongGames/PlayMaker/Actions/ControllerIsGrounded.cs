using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B4A RID: 2890
	[ActionCategory(ActionCategory.Character)]
	[Tooltip("Tests if a Character Controller on a Game Object was touching the ground during the last move.")]
	public class ControllerIsGrounded : FsmStateAction
	{
		// Token: 0x06003DC1 RID: 15809 RVA: 0x001626DE File Offset: 0x001608DE
		public override void Reset()
		{
			this.gameObject = null;
			this.trueEvent = null;
			this.falseEvent = null;
			this.storeResult = null;
			this.everyFrame = false;
		}

		// Token: 0x06003DC2 RID: 15810 RVA: 0x00162703 File Offset: 0x00160903
		public override void OnEnter()
		{
			this.DoControllerIsGrounded();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003DC3 RID: 15811 RVA: 0x00162719 File Offset: 0x00160919
		public override void OnUpdate()
		{
			this.DoControllerIsGrounded();
		}

		// Token: 0x06003DC4 RID: 15812 RVA: 0x00162724 File Offset: 0x00160924
		private void DoControllerIsGrounded()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			if (ownerDefaultTarget != this.previousGo)
			{
				this.controller = ownerDefaultTarget.GetComponent<CharacterController>();
				this.previousGo = ownerDefaultTarget;
			}
			if (this.controller == null)
			{
				return;
			}
			bool isGrounded = this.controller.isGrounded;
			this.storeResult.Value = isGrounded;
			base.Fsm.Event(isGrounded ? this.trueEvent : this.falseEvent);
		}

		// Token: 0x040041D4 RID: 16852
		[RequiredField]
		[CheckForComponent(typeof(CharacterController))]
		[Tooltip("The GameObject to check.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x040041D5 RID: 16853
		[Tooltip("Event to send if touching the ground.")]
		public FsmEvent trueEvent;

		// Token: 0x040041D6 RID: 16854
		[Tooltip("Event to send if not touching the ground.")]
		public FsmEvent falseEvent;

		// Token: 0x040041D7 RID: 16855
		[Tooltip("Store the result in a bool variable.")]
		[UIHint(UIHint.Variable)]
		public FsmBool storeResult;

		// Token: 0x040041D8 RID: 16856
		[Tooltip("Repeat every frame while the state is active.")]
		public bool everyFrame;

		// Token: 0x040041D9 RID: 16857
		private GameObject previousGo;

		// Token: 0x040041DA RID: 16858
		private CharacterController controller;
	}
}
