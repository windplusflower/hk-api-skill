using System;
using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A99 RID: 2713
	[ActionCategory("uGui")]
	[Tooltip("Gets the text value of a UGui InputField component.")]
	public class uGuiInputFieldGetText : FsmStateAction
	{
		// Token: 0x06003A6A RID: 14954 RVA: 0x00153EC6 File Offset: 0x001520C6
		public override void Reset()
		{
			this.text = null;
			this.everyFrame = false;
		}

		// Token: 0x06003A6B RID: 14955 RVA: 0x00153ED8 File Offset: 0x001520D8
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget != null)
			{
				this._inputField = ownerDefaultTarget.GetComponent<InputField>();
			}
			this.DoGetTextValue();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003A6C RID: 14956 RVA: 0x00153F20 File Offset: 0x00152120
		public override void OnUpdate()
		{
			this.DoGetTextValue();
		}

		// Token: 0x06003A6D RID: 14957 RVA: 0x00153F28 File Offset: 0x00152128
		private void DoGetTextValue()
		{
			if (this._inputField != null)
			{
				this.text.Value = this._inputField.text;
			}
		}

		// Token: 0x04003DC3 RID: 15811
		[RequiredField]
		[CheckForComponent(typeof(InputField))]
		[Tooltip("The GameObject with the InputField ui component.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003DC4 RID: 15812
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The text value of the UGui InputField component.")]
		public FsmString text;

		// Token: 0x04003DC5 RID: 15813
		public bool everyFrame;

		// Token: 0x04003DC6 RID: 15814
		private InputField _inputField;
	}
}
