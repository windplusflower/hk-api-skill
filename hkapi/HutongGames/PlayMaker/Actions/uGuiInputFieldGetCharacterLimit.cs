using System;
using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A95 RID: 2709
	[ActionCategory("uGui")]
	[Tooltip("Gets the Character Limit value of a UGui InputField component. This is the maximum number of characters that the user can type into the field.")]
	public class uGuiInputFieldGetCharacterLimit : FsmStateAction
	{
		// Token: 0x06003A58 RID: 14936 RVA: 0x00153BEA File Offset: 0x00151DEA
		public override void Reset()
		{
			this.characterLimit = null;
			this.everyFrame = false;
		}

		// Token: 0x06003A59 RID: 14937 RVA: 0x00153BFC File Offset: 0x00151DFC
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

		// Token: 0x06003A5A RID: 14938 RVA: 0x00153C44 File Offset: 0x00151E44
		public override void OnUpdate()
		{
			this.DoGetValue();
		}

		// Token: 0x06003A5B RID: 14939 RVA: 0x00153C4C File Offset: 0x00151E4C
		private void DoGetValue()
		{
			if (this._inputField != null)
			{
				this.characterLimit.Value = this._inputField.characterLimit;
				if (this._inputField.characterLimit > 0)
				{
					base.Fsm.Event(this.isLimitedEvent);
					return;
				}
				base.Fsm.Event(this.hasNoLimitEvent);
			}
		}

		// Token: 0x04003DAE RID: 15790
		[RequiredField]
		[CheckForComponent(typeof(InputField))]
		[Tooltip("The GameObject with the InputField ui component.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003DAF RID: 15791
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The maximum number of characters that the user can type into the UGui InputField component.")]
		public FsmInt characterLimit;

		// Token: 0x04003DB0 RID: 15792
		[Tooltip("Event sent if limit is infinite (equal to 0)")]
		public FsmEvent hasNoLimitEvent;

		// Token: 0x04003DB1 RID: 15793
		[Tooltip("Event sent if limit is more than 0")]
		public FsmEvent isLimitedEvent;

		// Token: 0x04003DB2 RID: 15794
		[Tooltip("Repeats every frame, useful for animation")]
		public bool everyFrame;

		// Token: 0x04003DB3 RID: 15795
		private InputField _inputField;
	}
}
