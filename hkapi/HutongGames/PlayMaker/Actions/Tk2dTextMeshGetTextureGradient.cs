using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x0200097D RID: 2429
	[ActionCategory("2D Toolkit/TextMesh")]
	[Tooltip("Set the texture gradient of the font currently applied to a TextMesh. \nChanges will not be updated if commit is OFF. This is so you can change multiple parameters without reconstructing the mesh repeatedly.\n Use tk2dtextMeshCommit or set commit to true on your last change for that mesh. \nNOTE: The Game Object must have a tk2dTextMesh attached.")]
	public class Tk2dTextMeshGetTextureGradient : FsmStateAction
	{
		// Token: 0x06003551 RID: 13649 RVA: 0x0013BC4C File Offset: 0x00139E4C
		private void _getTextMesh()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			this._textMesh = ownerDefaultTarget.GetComponent<tk2dTextMesh>();
		}

		// Token: 0x06003552 RID: 13650 RVA: 0x0013BC81 File Offset: 0x00139E81
		public override void Reset()
		{
			this.gameObject = null;
			this.textureGradient = 0;
			this.everyframe = false;
		}

		// Token: 0x06003553 RID: 13651 RVA: 0x0013BC9D File Offset: 0x00139E9D
		public override void OnEnter()
		{
			this._getTextMesh();
			this.DoGetTextureGradient();
			if (!this.everyframe)
			{
				base.Finish();
			}
		}

		// Token: 0x06003554 RID: 13652 RVA: 0x0013BCB9 File Offset: 0x00139EB9
		public override void OnUpdate()
		{
			this.DoGetTextureGradient();
		}

		// Token: 0x06003555 RID: 13653 RVA: 0x0013BCC4 File Offset: 0x00139EC4
		private void DoGetTextureGradient()
		{
			if (this._textMesh == null)
			{
				base.LogWarning("Missing tk2dTextMesh component: " + this._textMesh.gameObject.name);
				return;
			}
			this.textureGradient.Value = this._textMesh.textureGradient;
		}

		// Token: 0x040036E5 RID: 14053
		[RequiredField]
		[Tooltip("The Game Object to work with. NOTE: The Game Object must have a tk2dTextMesh component attached.")]
		[CheckForComponent(typeof(tk2dTextMesh))]
		public FsmOwnerDefault gameObject;

		// Token: 0x040036E6 RID: 14054
		[Tooltip("The Gradient Id")]
		[UIHint(UIHint.Variable)]
		public FsmInt textureGradient;

		// Token: 0x040036E7 RID: 14055
		[ActionSection("")]
		[Tooltip("Repeat every frame.")]
		public bool everyframe;

		// Token: 0x040036E8 RID: 14056
		private tk2dTextMesh _textMesh;
	}
}
