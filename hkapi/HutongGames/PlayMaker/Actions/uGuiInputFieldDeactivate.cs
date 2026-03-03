using System;
using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A93 RID: 2707
	[ActionCategory("uGui")]
	[Tooltip("Deactivate to begin processing Events for a UGui InputField component. Optionally Activate on state exit")]
	public class uGuiInputFieldDeactivate : FsmStateAction
	{
		// Token: 0x06003A4E RID: 14926 RVA: 0x00153AD0 File Offset: 0x00151CD0
		public override void Reset()
		{
			this.gameObject = null;
			this.activateOnExit = null;
		}

		// Token: 0x06003A4F RID: 14927 RVA: 0x00153AE0 File Offset: 0x00151CE0
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget != null)
			{
				this._inputField = ownerDefaultTarget.GetComponent<InputField>();
			}
			this.DoAction();
			base.Finish();
		}

		// Token: 0x06003A50 RID: 14928 RVA: 0x00153B20 File Offset: 0x00151D20
		private void DoAction()
		{
			if (this._inputField != null)
			{
				this._inputField.DeactivateInputField();
			}
		}

		// Token: 0x06003A51 RID: 14929 RVA: 0x00153B3B File Offset: 0x00151D3B
		public override void OnExit()
		{
			if (this._inputField == null)
			{
				return;
			}
			if (this.activateOnExit.Value)
			{
				this._inputField.ActivateInputField();
			}
		}

		// Token: 0x04003DA7 RID: 15783
		[RequiredField]
		[CheckForComponent(typeof(InputField))]
		[Tooltip("The GameObject with the InputField ui component.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003DA8 RID: 15784
		[Tooltip("Activate when exiting this state.")]
		public FsmBool activateOnExit;

		// Token: 0x04003DA9 RID: 15785
		private InputField _inputField;
	}
}
