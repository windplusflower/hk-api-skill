using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000988 RID: 2440
	[ActionCategory("2D Toolkit/TextMesh")]
	[Tooltip("Set the textMesh properties in one go just for convenience. \nNOTE: The Game Object must have a tk2dTextMesh attached.")]
	public class Tk2dTextMeshSetProperties : FsmStateAction
	{
		// Token: 0x06003591 RID: 13713 RVA: 0x0013C8B8 File Offset: 0x0013AAB8
		private void _getTextMesh()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			this._textMesh = ownerDefaultTarget.GetComponent<tk2dTextMesh>();
		}

		// Token: 0x06003592 RID: 13714 RVA: 0x0013C8F0 File Offset: 0x0013AAF0
		public override void Reset()
		{
			this.gameObject = null;
			this.text = null;
			this.inlineStyling = null;
			this.textureGradient = null;
			this.mainColor = null;
			this.gradientColor = null;
			this.useGradient = null;
			this.anchor = TextAnchor.LowerLeft;
			this.scale = null;
			this.kerning = null;
			this.maxChars = null;
			this.NumDrawnCharacters = null;
			this.commit = true;
		}

		// Token: 0x06003593 RID: 13715 RVA: 0x0013C95D File Offset: 0x0013AB5D
		public override void OnEnter()
		{
			this._getTextMesh();
			this.DoSetProperties();
			base.Finish();
		}

		// Token: 0x06003594 RID: 13716 RVA: 0x0013C974 File Offset: 0x0013AB74
		private void DoSetProperties()
		{
			if (this._textMesh == null)
			{
				base.LogWarning("Missing tk2dTextMesh component: " + this._textMesh.gameObject.name);
				return;
			}
			bool flag = false;
			if (this._textMesh.text != this.text.Value)
			{
				this._textMesh.text = this.text.Value;
				flag = true;
			}
			if (this._textMesh.inlineStyling != this.inlineStyling.Value)
			{
				this._textMesh.inlineStyling = this.inlineStyling.Value;
				flag = true;
			}
			if (this._textMesh.textureGradient != this.textureGradient.Value)
			{
				this._textMesh.textureGradient = this.textureGradient.Value;
				flag = true;
			}
			if (this._textMesh.useGradient != this.useGradient.Value)
			{
				this._textMesh.useGradient = this.useGradient.Value;
				flag = true;
			}
			if (this._textMesh.color != this.mainColor.Value)
			{
				this._textMesh.color = this.mainColor.Value;
				flag = true;
			}
			if (this._textMesh.color2 != this.gradientColor.Value)
			{
				this._textMesh.color2 = this.gradientColor.Value;
				flag = true;
			}
			this.scale.Value = this._textMesh.scale;
			this.kerning.Value = this._textMesh.kerning;
			this.maxChars.Value = this._textMesh.maxChars;
			this.NumDrawnCharacters.Value = this._textMesh.NumDrawnCharacters();
			this.textureGradient.Value = this._textMesh.textureGradient;
			if (this.commit.Value && flag)
			{
				this._textMesh.Commit();
			}
		}

		// Token: 0x04003718 RID: 14104
		[RequiredField]
		[Tooltip("The Game Object to work with. NOTE: The Game Object must have a tk2dTextMesh component attached.")]
		[CheckForComponent(typeof(tk2dTextMesh))]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003719 RID: 14105
		[Tooltip("The Text")]
		[UIHint(UIHint.Variable)]
		public FsmString text;

		// Token: 0x0400371A RID: 14106
		[Tooltip("InlineStyling")]
		[UIHint(UIHint.Variable)]
		public FsmBool inlineStyling;

		// Token: 0x0400371B RID: 14107
		[Tooltip("anchor")]
		public TextAnchor anchor;

		// Token: 0x0400371C RID: 14108
		[Tooltip("The anchor as a string (text Anchor setting will be ignore if set). \npossible values ( case insensitive): LowerLeft,LowerCenter,LowerRight,MiddleLeft,MiddleCenter,MiddleRight,UpperLeft,UpperCenter or UpperRight ")]
		[UIHint(UIHint.FsmString)]
		public FsmString OrTextAnchorString;

		// Token: 0x0400371D RID: 14109
		[Tooltip("Kerning")]
		[UIHint(UIHint.Variable)]
		public FsmBool kerning;

		// Token: 0x0400371E RID: 14110
		[Tooltip("maxChars")]
		[UIHint(UIHint.Variable)]
		public FsmInt maxChars;

		// Token: 0x0400371F RID: 14111
		[Tooltip("number of drawn characters")]
		[UIHint(UIHint.Variable)]
		public FsmInt NumDrawnCharacters;

		// Token: 0x04003720 RID: 14112
		[Tooltip("The Main Color")]
		[UIHint(UIHint.Variable)]
		public FsmColor mainColor;

		// Token: 0x04003721 RID: 14113
		[Tooltip("The Gradient Color. Only used if gradient is true")]
		[UIHint(UIHint.Variable)]
		public FsmColor gradientColor;

		// Token: 0x04003722 RID: 14114
		[Tooltip("Use gradient")]
		[UIHint(UIHint.Variable)]
		public FsmBool useGradient;

		// Token: 0x04003723 RID: 14115
		[Tooltip("Texture gradient")]
		[UIHint(UIHint.Variable)]
		public FsmInt textureGradient;

		// Token: 0x04003724 RID: 14116
		[Tooltip("Scale")]
		[UIHint(UIHint.Variable)]
		public FsmVector3 scale;

		// Token: 0x04003725 RID: 14117
		[Tooltip("Commit changes")]
		[UIHint(UIHint.FsmString)]
		public FsmBool commit;

		// Token: 0x04003726 RID: 14118
		private tk2dTextMesh _textMesh;
	}
}
