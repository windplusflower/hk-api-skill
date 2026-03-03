using System;
using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A94 RID: 2708
	[ActionCategory("uGui")]
	[Tooltip("Gets the caret's blink rate of a UGui InputField component.")]
	public class uGuiInputFieldGetCaretBlinkRate : FsmStateAction
	{
		// Token: 0x06003A53 RID: 14931 RVA: 0x00153B64 File Offset: 0x00151D64
		public override void Reset()
		{
			this.caretBlinkRate = null;
			this.everyFrame = false;
		}

		// Token: 0x06003A54 RID: 14932 RVA: 0x00153B74 File Offset: 0x00151D74
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget != null)
			{
				this._inputField = ownerDefaultTarget.GetComponent<InputField>();
			}
			this.DoGetValue();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003A55 RID: 14933 RVA: 0x00153BBC File Offset: 0x00151DBC
		public override void OnUpdate()
		{
			this.DoGetValue();
		}

		// Token: 0x06003A56 RID: 14934 RVA: 0x00153BC4 File Offset: 0x00151DC4
		private void DoGetValue()
		{
			if (this._inputField != null)
			{
				this.caretBlinkRate.Value = this._inputField.caretBlinkRate;
			}
		}

		// Token: 0x04003DAA RID: 15786
		[RequiredField]
		[CheckForComponent(typeof(InputField))]
		[Tooltip("The GameObject with the InputField ui component.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003DAB RID: 15787
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The caret's blink rate for the UGui InputField component.")]
		public FsmFloat caretBlinkRate;

		// Token: 0x04003DAC RID: 15788
		[Tooltip("Repeats every frame, useful for animation")]
		public bool everyFrame;

		// Token: 0x04003DAD RID: 15789
		private InputField _inputField;
	}
}
