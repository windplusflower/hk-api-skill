using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000976 RID: 2422
	[ActionCategory("2D Toolkit/TextMesh")]
	[Tooltip("Check that inline styling can indeed be used ( the font needs to have texture gradients for inline styling to work). \nNOTE: The Game Object must have a tk2dTextMesh attached.")]
	public class Tk2dTextMeshGetInlineStylingIsAvailable : FsmStateAction
	{
		// Token: 0x0600352B RID: 13611 RVA: 0x0013B68C File Offset: 0x0013988C
		private void _getTextMesh()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			this._textMesh = ownerDefaultTarget.GetComponent<tk2dTextMesh>();
		}

		// Token: 0x0600352C RID: 13612 RVA: 0x0013B6C1 File Offset: 0x001398C1
		public override void Reset()
		{
			this.gameObject = null;
			this.InlineStylingAvailable = null;
			this.everyframe = false;
		}

		// Token: 0x0600352D RID: 13613 RVA: 0x0013B6D8 File Offset: 0x001398D8
		public override void OnEnter()
		{
			this._getTextMesh();
			this.DoGetInlineStylingAvailable();
			if (!this.everyframe)
			{
				base.Finish();
			}
		}

		// Token: 0x0600352E RID: 13614 RVA: 0x0013B6F4 File Offset: 0x001398F4
		public override void OnUpdate()
		{
			this.DoGetInlineStylingAvailable();
		}

		// Token: 0x0600352F RID: 13615 RVA: 0x0013B6FC File Offset: 0x001398FC
		private void DoGetInlineStylingAvailable()
		{
			if (this._textMesh == null)
			{
				base.LogWarning("Missing tk2dTextMesh component: ");
				return;
			}
			this.InlineStylingAvailable.Value = (this._textMesh.inlineStyling && this._textMesh.font.textureGradients);
		}

		// Token: 0x040036C1 RID: 14017
		[RequiredField]
		[Tooltip("The Game Object to work with. NOTE: The Game Object must have a tk2dTextMesh component attached.")]
		[CheckForComponent(typeof(tk2dTextMesh))]
		public FsmOwnerDefault gameObject;

		// Token: 0x040036C2 RID: 14018
		[RequiredField]
		[Tooltip("Is inline styling available? true if inlineStyling is true AND the font texturGradients is true")]
		[UIHint(UIHint.Variable)]
		public FsmBool InlineStylingAvailable;

		// Token: 0x040036C3 RID: 14019
		[ActionSection("")]
		[Tooltip("Repeat every frame.")]
		public bool everyframe;

		// Token: 0x040036C4 RID: 14020
		private tk2dTextMesh _textMesh;
	}
}
