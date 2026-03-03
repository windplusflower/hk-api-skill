using System;
using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000AB9 RID: 2745
	[ActionCategory("uGui")]
	[Tooltip("Gets the text value of a UGui Text component.")]
	public class uGuiTextGetText : FsmStateAction
	{
		// Token: 0x06003B14 RID: 15124 RVA: 0x001558F7 File Offset: 0x00153AF7
		public override void Reset()
		{
			this.text = null;
			this.everyFrame = false;
		}

		// Token: 0x06003B15 RID: 15125 RVA: 0x00155908 File Offset: 0x00153B08
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget != null)
			{
				this._text = ownerDefaultTarget.GetComponent<Text>();
			}
			this.DoGetTextValue();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003B16 RID: 15126 RVA: 0x00155950 File Offset: 0x00153B50
		public override void OnUpdate()
		{
			this.DoGetTextValue();
		}

		// Token: 0x06003B17 RID: 15127 RVA: 0x00155958 File Offset: 0x00153B58
		private void DoGetTextValue()
		{
			if (this._text != null)
			{
				this.text.Value = this._text.text;
			}
		}

		// Token: 0x04003E60 RID: 15968
		[RequiredField]
		[CheckForComponent(typeof(Text))]
		[Tooltip("The GameObject with the text ui component.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003E61 RID: 15969
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The text value of the UGui Text component.")]
		public FsmString text;

		// Token: 0x04003E62 RID: 15970
		[Tooltip("Runs everyframe. Useful to animate values over time.")]
		public bool everyFrame;

		// Token: 0x04003E63 RID: 15971
		private Text _text;
	}
}
