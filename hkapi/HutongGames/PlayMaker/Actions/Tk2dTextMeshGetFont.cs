using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000974 RID: 2420
	[ActionCategory("2D Toolkit/TextMesh")]
	[Tooltip("Get the font of a TextMesh. \nNOTE: The Game Object must have a tk2dTextMesh attached.")]
	public class Tk2dTextMeshGetFont : FsmStateAction
	{
		// Token: 0x06003520 RID: 13600 RVA: 0x0013B52C File Offset: 0x0013972C
		private void _getTextMesh()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			this._textMesh = ownerDefaultTarget.GetComponent<tk2dTextMesh>();
		}

		// Token: 0x06003521 RID: 13601 RVA: 0x0013B561 File Offset: 0x00139761
		public override void Reset()
		{
			this.gameObject = null;
			this.font = null;
		}

		// Token: 0x06003522 RID: 13602 RVA: 0x0013B571 File Offset: 0x00139771
		public override void OnEnter()
		{
			this._getTextMesh();
			this.DoGetFont();
			base.Finish();
		}

		// Token: 0x06003523 RID: 13603 RVA: 0x0013B588 File Offset: 0x00139788
		private void DoGetFont()
		{
			if (this._textMesh == null)
			{
				base.LogWarning("Missing tk2dTextMesh component: " + this._textMesh.gameObject.name);
				return;
			}
			GameObject value = this.font.Value;
			if (value == null)
			{
				return;
			}
			value.GetComponent<tk2dFont>() == null;
		}

		// Token: 0x040036BA RID: 14010
		[RequiredField]
		[Tooltip("The Game Object to work with. NOTE: The Game Object must have a tk2dTextMesh component attached.")]
		[CheckForComponent(typeof(tk2dTextMesh))]
		public FsmOwnerDefault gameObject;

		// Token: 0x040036BB RID: 14011
		[RequiredField]
		[Tooltip("The font gameObject")]
		[UIHint(UIHint.FsmGameObject)]
		public FsmGameObject font;

		// Token: 0x040036BC RID: 14012
		private tk2dTextMesh _textMesh;
	}
}
