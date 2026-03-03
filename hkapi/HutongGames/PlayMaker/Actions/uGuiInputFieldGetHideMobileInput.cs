using System;
using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A96 RID: 2710
	[ActionCategory("uGui")]
	[Tooltip("Gets the hide Mobile Input value of a UGui InputField component.")]
	public class uGuiInputFieldGetHideMobileInput : FsmStateAction
	{
		// Token: 0x06003A5D RID: 14941 RVA: 0x00153CAE File Offset: 0x00151EAE
		public override void Reset()
		{
			this.hideMobileInput = null;
			this.mobileInputHiddenEvent = null;
			this.mobileInputShownEvent = null;
		}

		// Token: 0x06003A5E RID: 14942 RVA: 0x00153CC8 File Offset: 0x00151EC8
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget != null)
			{
				this._inputField = ownerDefaultTarget.GetComponent<InputField>();
			}
			this.DoGetValue();
			base.Finish();
		}

		// Token: 0x06003A5F RID: 14943 RVA: 0x00153D08 File Offset: 0x00151F08
		private void DoGetValue()
		{
			if (this._inputField != null)
			{
				this.hideMobileInput.Value = this._inputField.shouldHideMobileInput;
				if (this._inputField.shouldHideMobileInput)
				{
					base.Fsm.Event(this.mobileInputHiddenEvent);
					return;
				}
				base.Fsm.Event(this.mobileInputShownEvent);
			}
		}

		// Token: 0x04003DB4 RID: 15796
		[RequiredField]
		[CheckForComponent(typeof(InputField))]
		[Tooltip("The GameObject with the InputField ui component.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003DB5 RID: 15797
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The hide Mobile flag value of the UGui InputField component.")]
		public FsmBool hideMobileInput;

		// Token: 0x04003DB6 RID: 15798
		[Tooltip("Event sent if hide mobile input property is true")]
		public FsmEvent mobileInputHiddenEvent;

		// Token: 0x04003DB7 RID: 15799
		[Tooltip("Event sent if hide mobile input property is false")]
		public FsmEvent mobileInputShownEvent;

		// Token: 0x04003DB8 RID: 15800
		private InputField _inputField;
	}
}
