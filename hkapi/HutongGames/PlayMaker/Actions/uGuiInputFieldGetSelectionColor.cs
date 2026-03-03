using System;
using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A98 RID: 2712
	[ActionCategory("uGui")]
	[Tooltip("Gets the selection's color of a UGui InputField component. This is the color of the highlighter to show what characters are selected")]
	public class uGuiInputFieldGetSelectionColor : FsmStateAction
	{
		// Token: 0x06003A65 RID: 14949 RVA: 0x00153E3E File Offset: 0x0015203E
		public override void Reset()
		{
			this.selectionColor = null;
			this.everyFrame = false;
		}

		// Token: 0x06003A66 RID: 14950 RVA: 0x00153E50 File Offset: 0x00152050
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

		// Token: 0x06003A67 RID: 14951 RVA: 0x00153E98 File Offset: 0x00152098
		public override void OnUpdate()
		{
			this.DoGetValue();
		}

		// Token: 0x06003A68 RID: 14952 RVA: 0x00153EA0 File Offset: 0x001520A0
		private void DoGetValue()
		{
			if (this._inputField != null)
			{
				this.selectionColor.Value = this._inputField.selectionColor;
			}
		}

		// Token: 0x04003DBF RID: 15807
		[RequiredField]
		[CheckForComponent(typeof(InputField))]
		[Tooltip("The GameObject with the InputField ui component.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003DC0 RID: 15808
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("This is the color of the highlighter to show what characters are selected of the UGui InputField component.")]
		public FsmColor selectionColor;

		// Token: 0x04003DC1 RID: 15809
		[Tooltip("Repeats every frame")]
		public bool everyFrame;

		// Token: 0x04003DC2 RID: 15810
		private InputField _inputField;
	}
}
