using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x0200097A RID: 2426
	[ActionCategory("2D Toolkit/TextMesh")]
	[Tooltip("Get the textMesh properties in one go just for convenience. \nNOTE: The Game Object must have a tk2dTextMesh attached.")]
	public class Tk2dTextMeshGetProperties : FsmStateAction
	{
		// Token: 0x06003540 RID: 13632 RVA: 0x0013B8A8 File Offset: 0x00139AA8
		private void _getTextMesh()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			this._textMesh = ownerDefaultTarget.GetComponent<tk2dTextMesh>();
		}

		// Token: 0x06003541 RID: 13633 RVA: 0x0013B8E0 File Offset: 0x00139AE0
		public override void Reset()
		{
			this.gameObject = null;
			this.text = null;
			this.inlineStyling = null;
			this.textureGradient = null;
			this.mainColor = null;
			this.gradientColor = null;
			this.useGradient = null;
			this.anchor = null;
			this.scale = null;
			this.kerning = null;
			this.maxChars = null;
			this.NumDrawnCharacters = null;
		}

		// Token: 0x06003542 RID: 13634 RVA: 0x0013B941 File Offset: 0x00139B41
		public override void OnEnter()
		{
			this._getTextMesh();
			this.DoGetProperties();
			base.Finish();
		}

		// Token: 0x06003543 RID: 13635 RVA: 0x0013B958 File Offset: 0x00139B58
		private void DoGetProperties()
		{
			if (this._textMesh == null)
			{
				base.LogWarning("Missing tk2dTextMesh component: " + this._textMesh.gameObject.name);
				return;
			}
			this.text.Value = this._textMesh.text;
			this.inlineStyling.Value = this._textMesh.inlineStyling;
			this.textureGradient.Value = this._textMesh.textureGradient;
			this.mainColor.Value = this._textMesh.color;
			this.gradientColor.Value = this._textMesh.color2;
			this.useGradient.Value = this._textMesh.useGradient;
			this.anchor.Value = this._textMesh.anchor.ToString();
			this.scale.Value = this._textMesh.scale;
			this.kerning.Value = this._textMesh.kerning;
			this.maxChars.Value = this._textMesh.maxChars;
			this.NumDrawnCharacters.Value = this._textMesh.NumDrawnCharacters();
			this.textureGradient.Value = this._textMesh.textureGradient;
		}

		// Token: 0x040036CF RID: 14031
		[RequiredField]
		[Tooltip("The Game Object to work with. NOTE: The Game Object must have a tk2dTextMesh component attached.")]
		[CheckForComponent(typeof(tk2dTextMesh))]
		public FsmOwnerDefault gameObject;

		// Token: 0x040036D0 RID: 14032
		[Tooltip("The Text")]
		[UIHint(UIHint.Variable)]
		public FsmString text;

		// Token: 0x040036D1 RID: 14033
		[Tooltip("InlineStyling")]
		[UIHint(UIHint.Variable)]
		public FsmBool inlineStyling;

		// Token: 0x040036D2 RID: 14034
		[Tooltip("Anchor")]
		[UIHint(UIHint.Variable)]
		public FsmString anchor;

		// Token: 0x040036D3 RID: 14035
		[Tooltip("Kerning")]
		[UIHint(UIHint.Variable)]
		public FsmBool kerning;

		// Token: 0x040036D4 RID: 14036
		[Tooltip("maxChars")]
		[UIHint(UIHint.Variable)]
		public FsmInt maxChars;

		// Token: 0x040036D5 RID: 14037
		[Tooltip("number of drawn characters")]
		[UIHint(UIHint.Variable)]
		public FsmInt NumDrawnCharacters;

		// Token: 0x040036D6 RID: 14038
		[Tooltip("The Main Color")]
		[UIHint(UIHint.Variable)]
		public FsmColor mainColor;

		// Token: 0x040036D7 RID: 14039
		[Tooltip("The Gradient Color. Only used if gradient is true")]
		[UIHint(UIHint.Variable)]
		public FsmColor gradientColor;

		// Token: 0x040036D8 RID: 14040
		[Tooltip("Use gradient")]
		[UIHint(UIHint.Variable)]
		public FsmBool useGradient;

		// Token: 0x040036D9 RID: 14041
		[Tooltip("Texture gradient")]
		[UIHint(UIHint.Variable)]
		public FsmInt textureGradient;

		// Token: 0x040036DA RID: 14042
		[Tooltip("Scale")]
		[UIHint(UIHint.Variable)]
		public FsmVector3 scale;

		// Token: 0x040036DB RID: 14043
		private tk2dTextMesh _textMesh;
	}
}
