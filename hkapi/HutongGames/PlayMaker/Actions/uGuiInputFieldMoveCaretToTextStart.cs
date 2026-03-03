using System;
using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A9B RID: 2715
	[ActionCategory("uGui")]
	[Tooltip("Move Caret to text start on a UGui InputField component. Optionaly select from the current caret position")]
	public class uGuiInputFieldMoveCaretToTextStart : FsmStateAction
	{
		// Token: 0x06003A73 RID: 14963 RVA: 0x00153FCA File Offset: 0x001521CA
		public override void Reset()
		{
			this.gameObject = null;
			this.shift = true;
		}

		// Token: 0x06003A74 RID: 14964 RVA: 0x00153FE0 File Offset: 0x001521E0
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

		// Token: 0x06003A75 RID: 14965 RVA: 0x00154020 File Offset: 0x00152220
		private void DoAction()
		{
			if (this._inputField != null)
			{
				this._inputField.MoveTextStart(this.shift.Value);
			}
		}

		// Token: 0x04003DCA RID: 15818
		[RequiredField]
		[CheckForComponent(typeof(InputField))]
		[Tooltip("The GameObject with the InputField ui component.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003DCB RID: 15819
		[Tooltip("Define if we select or not from the current caret position. Default is true = no selection")]
		public FsmBool shift;

		// Token: 0x04003DCC RID: 15820
		private InputField _inputField;
	}
}
