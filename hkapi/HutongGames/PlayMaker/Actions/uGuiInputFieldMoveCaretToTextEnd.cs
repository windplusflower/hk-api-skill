using System;
using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A9A RID: 2714
	[ActionCategory("uGui")]
	[Tooltip("Move Caret to text end on a UGui InputField component. Optionaly select from the current caret position")]
	public class uGuiInputFieldMoveCaretToTextEnd : FsmStateAction
	{
		// Token: 0x06003A6F RID: 14959 RVA: 0x00153F4E File Offset: 0x0015214E
		public override void Reset()
		{
			this.gameObject = null;
			this.shift = true;
		}

		// Token: 0x06003A70 RID: 14960 RVA: 0x00153F64 File Offset: 0x00152164
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

		// Token: 0x06003A71 RID: 14961 RVA: 0x00153FA4 File Offset: 0x001521A4
		private void DoAction()
		{
			if (this._inputField != null)
			{
				this._inputField.MoveTextEnd(this.shift.Value);
			}
		}

		// Token: 0x04003DC7 RID: 15815
		[RequiredField]
		[CheckForComponent(typeof(InputField))]
		[Tooltip("The GameObject with the InputField ui component.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003DC8 RID: 15816
		[Tooltip("Define if we select or not from the current caret position. Default is true = no selection")]
		public FsmBool shift;

		// Token: 0x04003DC9 RID: 15817
		private InputField _inputField;
	}
}
