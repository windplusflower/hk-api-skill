using System;
using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000AA5 RID: 2725
	[ActionCategory("uGui")]
	[Tooltip("Sets the text value of a UGui InputField component.")]
	public class uGuiInputFieldSetText : FsmStateAction
	{
		// Token: 0x06003AA8 RID: 15016 RVA: 0x00154817 File Offset: 0x00152A17
		public override void Reset()
		{
			this.gameObject = null;
			this.text = null;
			this.resetOnExit = null;
			this.everyFrame = false;
		}

		// Token: 0x06003AA9 RID: 15017 RVA: 0x00154838 File Offset: 0x00152A38
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget != null)
			{
				this._inputField = ownerDefaultTarget.GetComponent<InputField>();
			}
			if (this.resetOnExit.Value)
			{
				this._originalString = this._inputField.text;
			}
			this.DoSetTextValue();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003AAA RID: 15018 RVA: 0x0015489E File Offset: 0x00152A9E
		public override void OnUpdate()
		{
			this.DoSetTextValue();
		}

		// Token: 0x06003AAB RID: 15019 RVA: 0x001548A6 File Offset: 0x00152AA6
		private void DoSetTextValue()
		{
			if (this._inputField != null)
			{
				this._inputField.text = this.text.Value;
			}
		}

		// Token: 0x06003AAC RID: 15020 RVA: 0x001548CC File Offset: 0x00152ACC
		public override void OnExit()
		{
			if (this._inputField == null)
			{
				return;
			}
			if (this.resetOnExit.Value)
			{
				this._inputField.text = this._originalString;
			}
		}

		// Token: 0x04003DFA RID: 15866
		[RequiredField]
		[CheckForComponent(typeof(InputField))]
		[Tooltip("The GameObject with the InputField ui component.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003DFB RID: 15867
		[RequiredField]
		[UIHint(UIHint.TextArea)]
		[Tooltip("The text of the UGui InputField component.")]
		public FsmString text;

		// Token: 0x04003DFC RID: 15868
		[Tooltip("Reset when exiting this state.")]
		public FsmBool resetOnExit;

		// Token: 0x04003DFD RID: 15869
		[Tooltip("Repeats every frame")]
		public bool everyFrame;

		// Token: 0x04003DFE RID: 15870
		private InputField _inputField;

		// Token: 0x04003DFF RID: 15871
		private string _originalString;
	}
}
