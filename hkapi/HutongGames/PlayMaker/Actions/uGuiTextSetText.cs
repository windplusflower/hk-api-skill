using System;
using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000ABA RID: 2746
	[ActionCategory("uGui")]
	[Tooltip("Sets the text value of a UGui Text component.")]
	public class uGuiTextSetText : FsmStateAction
	{
		// Token: 0x06003B19 RID: 15129 RVA: 0x0015597E File Offset: 0x00153B7E
		public override void Reset()
		{
			this.gameObject = null;
			this.text = null;
			this.resetOnExit = null;
			this.everyFrame = false;
		}

		// Token: 0x06003B1A RID: 15130 RVA: 0x0015599C File Offset: 0x00153B9C
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget != null)
			{
				this._text = ownerDefaultTarget.GetComponent<Text>();
			}
			if (this.resetOnExit.Value)
			{
				this._originalString = this._text.text;
			}
			this.DoSetTextValue();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003B1B RID: 15131 RVA: 0x00155A02 File Offset: 0x00153C02
		public override void OnUpdate()
		{
			this.DoSetTextValue();
		}

		// Token: 0x06003B1C RID: 15132 RVA: 0x00155A0A File Offset: 0x00153C0A
		private void DoSetTextValue()
		{
			if (this._text != null)
			{
				this._text.text = this.text.Value;
			}
		}

		// Token: 0x06003B1D RID: 15133 RVA: 0x00155A30 File Offset: 0x00153C30
		public override void OnExit()
		{
			if (this._text == null)
			{
				return;
			}
			if (this.resetOnExit.Value)
			{
				this._text.text = this._originalString;
			}
		}

		// Token: 0x04003E64 RID: 15972
		[RequiredField]
		[CheckForComponent(typeof(Text))]
		[Tooltip("The GameObject with the text ui component.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003E65 RID: 15973
		[RequiredField]
		[UIHint(UIHint.TextArea)]
		[Tooltip("The text of the UGui Text component.")]
		public FsmString text;

		// Token: 0x04003E66 RID: 15974
		[Tooltip("Reset when exiting this state.")]
		public FsmBool resetOnExit;

		// Token: 0x04003E67 RID: 15975
		[Tooltip("Repeats every frame")]
		public bool everyFrame;

		// Token: 0x04003E68 RID: 15976
		private Text _text;

		// Token: 0x04003E69 RID: 15977
		private string _originalString;
	}
}
