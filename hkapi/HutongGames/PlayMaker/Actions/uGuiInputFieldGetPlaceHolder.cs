using System;
using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A97 RID: 2711
	[ActionCategory("uGui")]
	[Tooltip("Gets the placeHolder GameObject of a UGui InputField component.")]
	public class uGuiInputFieldGetPlaceHolder : FsmStateAction
	{
		// Token: 0x06003A61 RID: 14945 RVA: 0x00153D69 File Offset: 0x00151F69
		public override void Reset()
		{
			this.placeHolder = null;
			this.placeHolderDefined = null;
			this.foundEvent = null;
			this.notFoundEvent = null;
		}

		// Token: 0x06003A62 RID: 14946 RVA: 0x00153D88 File Offset: 0x00151F88
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

		// Token: 0x06003A63 RID: 14947 RVA: 0x00153DC8 File Offset: 0x00151FC8
		private void DoGetValue()
		{
			if (this._inputField != null)
			{
				Graphic placeholder = this._inputField.placeholder;
				this.placeHolderDefined.Value = (placeholder != null);
				if (placeholder != null)
				{
					this.placeHolder.Value = placeholder.gameObject;
					base.Fsm.Event(this.foundEvent);
					return;
				}
				base.Fsm.Event(this.notFoundEvent);
			}
		}

		// Token: 0x04003DB9 RID: 15801
		[RequiredField]
		[CheckForComponent(typeof(InputField))]
		[Tooltip("The GameObject with the InputField ui component.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003DBA RID: 15802
		[UIHint(UIHint.Variable)]
		[Tooltip("The placeholder of the UGui InputField component.")]
		public FsmGameObject placeHolder;

		// Token: 0x04003DBB RID: 15803
		[Tooltip("true if placeholder is found")]
		public FsmBool placeHolderDefined;

		// Token: 0x04003DBC RID: 15804
		[Tooltip("Event sent if no placeholder is defined")]
		public FsmEvent foundEvent;

		// Token: 0x04003DBD RID: 15805
		[Tooltip("Event sent if a placeholder is defined")]
		public FsmEvent notFoundEvent;

		// Token: 0x04003DBE RID: 15806
		private InputField _inputField;
	}
}
