using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000973 RID: 2419
	[ActionCategory("2D Toolkit/TextMesh")]
	[Tooltip("Get the colors of a TextMesh. \nNOTE: The Game Object must have a tk2dTextMesh attached.")]
	public class Tk2dTextMeshGetColors : FsmStateAction
	{
		// Token: 0x0600351A RID: 13594 RVA: 0x0013B43C File Offset: 0x0013963C
		private void _getTextMesh()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			this._textMesh = ownerDefaultTarget.GetComponent<tk2dTextMesh>();
		}

		// Token: 0x0600351B RID: 13595 RVA: 0x0013B471 File Offset: 0x00139671
		public override void Reset()
		{
			this.gameObject = null;
			this.mainColor = null;
			this.gradientColor = null;
			this.useGradient = false;
			this.everyframe = false;
		}

		// Token: 0x0600351C RID: 13596 RVA: 0x0013B49B File Offset: 0x0013969B
		public override void OnEnter()
		{
			this._getTextMesh();
			this.DoGetColors();
			if (!this.everyframe)
			{
				base.Finish();
			}
		}

		// Token: 0x0600351D RID: 13597 RVA: 0x0013B4B7 File Offset: 0x001396B7
		public override void OnUpdate()
		{
			this.DoGetColors();
		}

		// Token: 0x0600351E RID: 13598 RVA: 0x0013B4C0 File Offset: 0x001396C0
		private void DoGetColors()
		{
			if (this._textMesh == null)
			{
				base.LogWarning("Missing tk2dTextMesh component: ");
				return;
			}
			this.useGradient.Value = this._textMesh.useGradient;
			this.mainColor.Value = this._textMesh.color;
			this.gradientColor.Value = this._textMesh.color2;
		}

		// Token: 0x040036B4 RID: 14004
		[RequiredField]
		[Tooltip("The Game Object to work with. NOTE: The Game Object must have a tk2dTextMesh component attached.")]
		[CheckForComponent(typeof(tk2dTextMesh))]
		public FsmOwnerDefault gameObject;

		// Token: 0x040036B5 RID: 14005
		[Tooltip("Main color")]
		[UIHint(UIHint.Variable)]
		public FsmColor mainColor;

		// Token: 0x040036B6 RID: 14006
		[Tooltip("Gradient color. Only used if gradient is true")]
		[UIHint(UIHint.Variable)]
		public FsmColor gradientColor;

		// Token: 0x040036B7 RID: 14007
		[Tooltip("Use gradient.")]
		[UIHint(UIHint.Variable)]
		public FsmBool useGradient;

		// Token: 0x040036B8 RID: 14008
		[ActionSection("")]
		[Tooltip("Repeat every frame.")]
		public bool everyframe;

		// Token: 0x040036B9 RID: 14009
		private tk2dTextMesh _textMesh;
	}
}
