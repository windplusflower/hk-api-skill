using System;
using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000AA2 RID: 2722
	[ActionCategory("uGui")]
	[Tooltip("Sets the hide mobile Input value of a UGui InputField component.")]
	public class uGuiInputFieldSetHideMobileInput : FsmStateAction
	{
		// Token: 0x06003A98 RID: 15000 RVA: 0x00154573 File Offset: 0x00152773
		public override void Reset()
		{
			this.gameObject = null;
			this.hideMobileInput = null;
			this.resetOnExit = null;
		}

		// Token: 0x06003A99 RID: 15001 RVA: 0x0015458C File Offset: 0x0015278C
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget != null)
			{
				this._inputField = ownerDefaultTarget.GetComponent<InputField>();
			}
			if (this.resetOnExit.Value)
			{
				this._originalValue = this._inputField.shouldHideMobileInput;
			}
			this.DoSetValue();
			base.Finish();
		}

		// Token: 0x06003A9A RID: 15002 RVA: 0x001545EA File Offset: 0x001527EA
		private void DoSetValue()
		{
			if (this._inputField != null)
			{
				this._inputField.shouldHideMobileInput = this.hideMobileInput.Value;
			}
		}

		// Token: 0x06003A9B RID: 15003 RVA: 0x00154610 File Offset: 0x00152810
		public override void OnExit()
		{
			if (this._inputField == null)
			{
				return;
			}
			if (this.resetOnExit.Value)
			{
				this._inputField.shouldHideMobileInput = this._originalValue;
			}
		}

		// Token: 0x04003DEA RID: 15850
		[RequiredField]
		[CheckForComponent(typeof(InputField))]
		[Tooltip("The GameObject with the InputField ui component.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003DEB RID: 15851
		[RequiredField]
		[UIHint(UIHint.TextArea)]
		[Tooltip("The hide Mobile flag value of the UGui InputField component.")]
		public FsmBool hideMobileInput;

		// Token: 0x04003DEC RID: 15852
		[Tooltip("Reset when exiting this state.")]
		public FsmBool resetOnExit;

		// Token: 0x04003DED RID: 15853
		private InputField _inputField;

		// Token: 0x04003DEE RID: 15854
		private bool _originalValue;
	}
}
