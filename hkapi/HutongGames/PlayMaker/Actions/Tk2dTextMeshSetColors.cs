using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000980 RID: 2432
	[ActionCategory("2D Toolkit/TextMesh")]
	[Tooltip("Set the colors of a TextMesh. \nChanges will not be updated if commit is OFF. This is so you can change multiple parameters without reconstructing the mesh repeatedly.\n Use tk2dtextMeshCommit or set commit to true on your last change for that mesh. \nNOTE: The Game Object must have a tk2dTextMesh attached.")]
	public class Tk2dTextMeshSetColors : FsmStateAction
	{
		// Token: 0x06003563 RID: 13667 RVA: 0x0013C06C File Offset: 0x0013A26C
		private void _getTextMesh()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			this._textMesh = ownerDefaultTarget.GetComponent<tk2dTextMesh>();
		}

		// Token: 0x06003564 RID: 13668 RVA: 0x0013C0A1 File Offset: 0x0013A2A1
		public override void Reset()
		{
			this.gameObject = null;
			this.mainColor = null;
			this.gradientColor = null;
			this.useGradient = false;
			this.commit = true;
			this.everyframe = false;
		}

		// Token: 0x06003565 RID: 13669 RVA: 0x0013C0D7 File Offset: 0x0013A2D7
		public override void OnEnter()
		{
			this._getTextMesh();
			this.DoSetColors();
			if (!this.everyframe)
			{
				base.Finish();
			}
		}

		// Token: 0x06003566 RID: 13670 RVA: 0x0013C0F3 File Offset: 0x0013A2F3
		public override void OnUpdate()
		{
			this.DoSetColors();
		}

		// Token: 0x06003567 RID: 13671 RVA: 0x0013C0FC File Offset: 0x0013A2FC
		private void DoSetColors()
		{
			if (this._textMesh == null)
			{
				base.LogWarning("Missing tk2dTextMesh component: " + this._textMesh.gameObject.name);
				return;
			}
			bool flag = false;
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
			if (this.commit.Value && flag)
			{
				this._textMesh.Commit();
			}
		}

		// Token: 0x040036F0 RID: 14064
		[RequiredField]
		[Tooltip("The Game Object to work with. NOTE: The Game Object must have a tk2dTextMesh component attached.")]
		[CheckForComponent(typeof(tk2dTextMesh))]
		public FsmOwnerDefault gameObject;

		// Token: 0x040036F1 RID: 14065
		[Tooltip("Main color")]
		[UIHint(UIHint.FsmColor)]
		public FsmColor mainColor;

		// Token: 0x040036F2 RID: 14066
		[Tooltip("Gradient color. Only used if gradient is true")]
		[UIHint(UIHint.FsmColor)]
		public FsmColor gradientColor;

		// Token: 0x040036F3 RID: 14067
		[Tooltip("Use gradient.")]
		[UIHint(UIHint.FsmBool)]
		public FsmBool useGradient;

		// Token: 0x040036F4 RID: 14068
		[Tooltip("Commit changes")]
		[UIHint(UIHint.FsmString)]
		public FsmBool commit;

		// Token: 0x040036F5 RID: 14069
		[ActionSection("")]
		[Tooltip("Repeat every frame.")]
		public bool everyframe;

		// Token: 0x040036F6 RID: 14070
		private tk2dTextMesh _textMesh;
	}
}
