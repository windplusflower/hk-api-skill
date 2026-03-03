using System;
using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000AA0 RID: 2720
	[ActionCategory("uGui")]
	[Tooltip("Sets the caret's blink rate of a UGui InputField component.")]
	public class uGuiInputfieldSetCaretBlinkRate : FsmStateAction
	{
		// Token: 0x06003A8C RID: 14988 RVA: 0x001543AE File Offset: 0x001525AE
		public override void Reset()
		{
			this.gameObject = null;
			this.caretBlinkRate = null;
			this.resetOnExit = null;
			this.everyFrame = false;
		}

		// Token: 0x06003A8D RID: 14989 RVA: 0x001543CC File Offset: 0x001525CC
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget != null)
			{
				this._inputField = ownerDefaultTarget.GetComponent<InputField>();
			}
			if (this.resetOnExit.Value)
			{
				this._originalValue = this._inputField.caretBlinkRate;
			}
			this.DoSetValue();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003A8E RID: 14990 RVA: 0x00154432 File Offset: 0x00152632
		public override void OnUpdate()
		{
			this.DoSetValue();
		}

		// Token: 0x06003A8F RID: 14991 RVA: 0x0015443A File Offset: 0x0015263A
		private void DoSetValue()
		{
			if (this._inputField != null)
			{
				this._inputField.caretBlinkRate = (float)this.caretBlinkRate.Value;
			}
		}

		// Token: 0x06003A90 RID: 14992 RVA: 0x00154461 File Offset: 0x00152661
		public override void OnExit()
		{
			if (this._inputField == null)
			{
				return;
			}
			if (this.resetOnExit.Value)
			{
				this._inputField.caretBlinkRate = this._originalValue;
			}
		}

		// Token: 0x04003DDE RID: 15838
		[RequiredField]
		[CheckForComponent(typeof(InputField))]
		[Tooltip("The GameObject with the InputField ui component.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003DDF RID: 15839
		[RequiredField]
		[Tooltip("The caret's blink rate for the UGui InputField component.")]
		public FsmInt caretBlinkRate;

		// Token: 0x04003DE0 RID: 15840
		[Tooltip("Deactivate when exiting this state.")]
		public FsmBool resetOnExit;

		// Token: 0x04003DE1 RID: 15841
		[Tooltip("Repeats every frame")]
		public bool everyFrame;

		// Token: 0x04003DE2 RID: 15842
		private InputField _inputField;

		// Token: 0x04003DE3 RID: 15843
		private float _originalValue;
	}
}
