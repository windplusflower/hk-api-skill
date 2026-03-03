using System;
using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000AA4 RID: 2724
	[ActionCategory("uGui")]
	[Tooltip("Sets the selection's color of a UGui InputField component. This is the color of the highlighter to show what characters are selected")]
	public class uGuiInputFieldSetSelectionColor : FsmStateAction
	{
		// Token: 0x06003AA2 RID: 15010 RVA: 0x00154735 File Offset: 0x00152935
		public override void Reset()
		{
			this.gameObject = null;
			this.selectionColor = null;
			this.resetOnExit = null;
			this.everyFrame = false;
		}

		// Token: 0x06003AA3 RID: 15011 RVA: 0x00154754 File Offset: 0x00152954
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget != null)
			{
				this._inputField = ownerDefaultTarget.GetComponent<InputField>();
			}
			if (this.resetOnExit.Value)
			{
				this._originalValue = this._inputField.selectionColor;
			}
			this.DoSetValue();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003AA4 RID: 15012 RVA: 0x001547BA File Offset: 0x001529BA
		public override void OnUpdate()
		{
			this.DoSetValue();
		}

		// Token: 0x06003AA5 RID: 15013 RVA: 0x001547C2 File Offset: 0x001529C2
		private void DoSetValue()
		{
			if (this._inputField != null)
			{
				this._inputField.selectionColor = this.selectionColor.Value;
			}
		}

		// Token: 0x06003AA6 RID: 15014 RVA: 0x001547E8 File Offset: 0x001529E8
		public override void OnExit()
		{
			if (this._inputField == null)
			{
				return;
			}
			if (this.resetOnExit.Value)
			{
				this._inputField.selectionColor = this._originalValue;
			}
		}

		// Token: 0x04003DF4 RID: 15860
		[RequiredField]
		[CheckForComponent(typeof(InputField))]
		[Tooltip("The GameObject with the InputField ui component.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003DF5 RID: 15861
		[RequiredField]
		[Tooltip("The color of the highlighter to show what characters are selected for the UGui InputField component.")]
		public FsmColor selectionColor;

		// Token: 0x04003DF6 RID: 15862
		[Tooltip("Reset when exiting this state.")]
		public FsmBool resetOnExit;

		// Token: 0x04003DF7 RID: 15863
		[Tooltip("Repeats every frame")]
		public bool everyFrame;

		// Token: 0x04003DF8 RID: 15864
		private InputField _inputField;

		// Token: 0x04003DF9 RID: 15865
		private Color _originalValue;
	}
}
