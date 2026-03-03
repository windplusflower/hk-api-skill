using System;
using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A92 RID: 2706
	[ActionCategory("uGui")]
	[Tooltip("Activate a UGui InputField component to begin processing Events. Optionally Deactivate on state exit")]
	public class uGuiInputFieldActivate : FsmStateAction
	{
		// Token: 0x06003A49 RID: 14921 RVA: 0x00153A3C File Offset: 0x00151C3C
		public override void Reset()
		{
			this.gameObject = null;
			this.deactivateOnExit = null;
		}

		// Token: 0x06003A4A RID: 14922 RVA: 0x00153A4C File Offset: 0x00151C4C
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

		// Token: 0x06003A4B RID: 14923 RVA: 0x00153A8C File Offset: 0x00151C8C
		private void DoAction()
		{
			if (this._inputField != null)
			{
				this._inputField.ActivateInputField();
			}
		}

		// Token: 0x06003A4C RID: 14924 RVA: 0x00153AA7 File Offset: 0x00151CA7
		public override void OnExit()
		{
			if (this._inputField == null)
			{
				return;
			}
			if (this.deactivateOnExit.Value)
			{
				this._inputField.DeactivateInputField();
			}
		}

		// Token: 0x04003DA4 RID: 15780
		[RequiredField]
		[CheckForComponent(typeof(InputField))]
		[Tooltip("The GameObject with the InputField ui component.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003DA5 RID: 15781
		[Tooltip("Reset when exiting this state.")]
		public FsmBool deactivateOnExit;

		// Token: 0x04003DA6 RID: 15782
		private InputField _inputField;
	}
}
