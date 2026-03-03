using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x0200097E RID: 2430
	[ActionCategory("2D Toolkit/TextMesh")]
	[Tooltip("Make a TextMesh pixelPerfect. \nNOTE: The Game Object must have a tk2dTextMesh attached.")]
	public class Tk2dTextMeshMakePixelPerfect : FsmStateAction
	{
		// Token: 0x06003557 RID: 13655 RVA: 0x0013BD18 File Offset: 0x00139F18
		private void _getTextMesh()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			this._textMesh = ownerDefaultTarget.GetComponent<tk2dTextMesh>();
		}

		// Token: 0x06003558 RID: 13656 RVA: 0x0013BD4D File Offset: 0x00139F4D
		public override void Reset()
		{
			this.gameObject = null;
		}

		// Token: 0x06003559 RID: 13657 RVA: 0x0013BD56 File Offset: 0x00139F56
		public override void OnEnter()
		{
			this._getTextMesh();
			this.MakePixelPerfect();
			base.Finish();
		}

		// Token: 0x0600355A RID: 13658 RVA: 0x0013BD6A File Offset: 0x00139F6A
		private void MakePixelPerfect()
		{
			if (this._textMesh == null)
			{
				base.LogWarning("Missing tk2dTextMesh component ");
				return;
			}
			this._textMesh.MakePixelPerfect();
		}

		// Token: 0x040036E9 RID: 14057
		[RequiredField]
		[Tooltip("The Game Object to work with. NOTE: The Game Object must have a tk2dTextMesh component attached.")]
		[CheckForComponent(typeof(tk2dTextMesh))]
		public FsmOwnerDefault gameObject;

		// Token: 0x040036EA RID: 14058
		private tk2dTextMesh _textMesh;
	}
}
