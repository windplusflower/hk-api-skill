using System;
using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000AA3 RID: 2723
	[ActionCategory("uGui")]
	[Tooltip("Sets the playceholder of a UGui InputField component. Optionally reset on exit")]
	public class uGuiInputFieldSetPlaceHolder : FsmStateAction
	{
		// Token: 0x06003A9D RID: 15005 RVA: 0x0015463F File Offset: 0x0015283F
		public override void Reset()
		{
			this.gameObject = null;
			this.placeholder = null;
			this.resetOnExit = null;
		}

		// Token: 0x06003A9E RID: 15006 RVA: 0x00154658 File Offset: 0x00152858
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget != null)
			{
				this._inputField = ownerDefaultTarget.GetComponent<InputField>();
			}
			if (this.resetOnExit.Value)
			{
				this._originalValue = this._inputField.placeholder;
			}
			this.DoSetValue();
			base.Finish();
		}

		// Token: 0x06003A9F RID: 15007 RVA: 0x001546B8 File Offset: 0x001528B8
		private void DoSetValue()
		{
			if (this._inputField != null)
			{
				GameObject value = this.placeholder.Value;
				if (value == null)
				{
					this._inputField.placeholder = null;
					return;
				}
				this._inputField.placeholder = value.GetComponent<Graphic>();
			}
		}

		// Token: 0x06003AA0 RID: 15008 RVA: 0x00154706 File Offset: 0x00152906
		public override void OnExit()
		{
			if (this._inputField == null)
			{
				return;
			}
			if (this.resetOnExit.Value)
			{
				this._inputField.placeholder = this._originalValue;
			}
		}

		// Token: 0x04003DEF RID: 15855
		[RequiredField]
		[CheckForComponent(typeof(InputField))]
		[Tooltip("The GameObject with the InputField ui component.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003DF0 RID: 15856
		[RequiredField]
		[CheckForComponent(typeof(Graphic))]
		[Tooltip("The placeholder ( any graphic extended uGui Component) for the UGui InputField component.")]
		public FsmGameObject placeholder;

		// Token: 0x04003DF1 RID: 15857
		[Tooltip("Reset when exiting this state.")]
		public FsmBool resetOnExit;

		// Token: 0x04003DF2 RID: 15858
		private InputField _inputField;

		// Token: 0x04003DF3 RID: 15859
		private Graphic _originalValue;
	}
}
