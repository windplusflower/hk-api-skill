using System;
using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A9F RID: 2719
	[ActionCategory("uGui")]
	[Tooltip("Sets the Asterix Character of a UGui InputField component.")]
	public class uGuiInputFieldSetAsterixChar : FsmStateAction
	{
		// Token: 0x06003A86 RID: 14982 RVA: 0x001542A1 File Offset: 0x001524A1
		public override void Reset()
		{
			this.gameObject = null;
			this.asterixChar = "*";
			this.resetOnExit = null;
		}

		// Token: 0x06003A87 RID: 14983 RVA: 0x001542C4 File Offset: 0x001524C4
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget != null)
			{
				this._inputField = ownerDefaultTarget.GetComponent<InputField>();
			}
			if (this.resetOnExit.Value)
			{
				this._originalValue = this._inputField.asteriskChar;
			}
			this.DoSetValue();
			base.Finish();
		}

		// Token: 0x06003A88 RID: 14984 RVA: 0x00154324 File Offset: 0x00152524
		private void DoSetValue()
		{
			char asteriskChar = uGuiInputFieldSetAsterixChar.__char__;
			if (this.asterixChar.Value.Length > 0)
			{
				asteriskChar = this.asterixChar.Value[0];
			}
			if (this._inputField != null)
			{
				this._inputField.asteriskChar = asteriskChar;
			}
		}

		// Token: 0x06003A89 RID: 14985 RVA: 0x00154376 File Offset: 0x00152576
		public override void OnExit()
		{
			if (this._inputField == null)
			{
				return;
			}
			if (this.resetOnExit.Value)
			{
				this._inputField.asteriskChar = this._originalValue;
			}
		}

		// Token: 0x06003A8B RID: 14987 RVA: 0x001543A5 File Offset: 0x001525A5
		// Note: this type is marked as 'beforefieldinit'.
		static uGuiInputFieldSetAsterixChar()
		{
			uGuiInputFieldSetAsterixChar.__char__ = ' ';
		}

		// Token: 0x04003DD8 RID: 15832
		[RequiredField]
		[CheckForComponent(typeof(InputField))]
		[Tooltip("The GameObject with the InputField ui component.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003DD9 RID: 15833
		[RequiredField]
		[UIHint(UIHint.TextArea)]
		[Tooltip("The asterix Character used for password field type of the UGui InputField component. Only the first character will be used, the rest of the string will be ignored")]
		public FsmString asterixChar;

		// Token: 0x04003DDA RID: 15834
		[Tooltip("Reset when exiting this state.")]
		public FsmBool resetOnExit;

		// Token: 0x04003DDB RID: 15835
		private InputField _inputField;

		// Token: 0x04003DDC RID: 15836
		private char _originalValue;

		// Token: 0x04003DDD RID: 15837
		private static char __char__;
	}
}
