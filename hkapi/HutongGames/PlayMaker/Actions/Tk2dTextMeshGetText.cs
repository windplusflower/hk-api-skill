using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x0200097C RID: 2428
	[ActionCategory("2D Toolkit/TextMesh")]
	[Tooltip("Get the text of a TextMesh. \nNOTE: The Game Object must have a tk2dTextMesh attached.")]
	public class Tk2dTextMeshGetText : FsmStateAction
	{
		// Token: 0x0600354B RID: 13643 RVA: 0x0013BB88 File Offset: 0x00139D88
		private void _getTextMesh()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			this._textMesh = ownerDefaultTarget.GetComponent<tk2dTextMesh>();
		}

		// Token: 0x0600354C RID: 13644 RVA: 0x0013BBBD File Offset: 0x00139DBD
		public override void Reset()
		{
			this.gameObject = null;
			this.text = null;
			this.everyframe = false;
		}

		// Token: 0x0600354D RID: 13645 RVA: 0x0013BBD4 File Offset: 0x00139DD4
		public override void OnEnter()
		{
			this._getTextMesh();
			this.DoGetText();
			if (!this.everyframe)
			{
				base.Finish();
			}
		}

		// Token: 0x0600354E RID: 13646 RVA: 0x0013BBF0 File Offset: 0x00139DF0
		public override void OnUpdate()
		{
			this.DoGetText();
		}

		// Token: 0x0600354F RID: 13647 RVA: 0x0013BBF8 File Offset: 0x00139DF8
		private void DoGetText()
		{
			if (this._textMesh == null)
			{
				base.LogWarning("Missing tk2dTextMesh component: " + this._textMesh.gameObject.name);
				return;
			}
			this.text.Value = this._textMesh.text;
		}

		// Token: 0x040036E1 RID: 14049
		[RequiredField]
		[Tooltip("The Game Object to work with. NOTE: The Game Object must have a tk2dTextMesh component attached.")]
		[CheckForComponent(typeof(tk2dTextMesh))]
		public FsmOwnerDefault gameObject;

		// Token: 0x040036E2 RID: 14050
		[Tooltip("The text")]
		[UIHint(UIHint.Variable)]
		public FsmString text;

		// Token: 0x040036E3 RID: 14051
		[ActionSection("")]
		[Tooltip("Repeat every frame.")]
		public bool everyframe;

		// Token: 0x040036E4 RID: 14052
		private tk2dTextMesh _textMesh;
	}
}
