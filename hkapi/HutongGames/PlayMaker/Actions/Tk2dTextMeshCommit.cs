using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000971 RID: 2417
	[ActionCategory("2D Toolkit/TextMesh")]
	[Tooltip("Commit a TextMesh. This is so you can change multiple parameters without reconstructing the mesh repeatedly, simply use that after you have set all the different properties. \nNOTE: The Game Object must have a tk2dTextMesh attached.")]
	[HelpUrl("https://hutonggames.fogbugz.com/default.asp?W723")]
	public class Tk2dTextMeshCommit : FsmStateAction
	{
		// Token: 0x0600350F RID: 13583 RVA: 0x0013B2E4 File Offset: 0x001394E4
		private void _getTextMesh()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			this._textMesh = ownerDefaultTarget.GetComponent<tk2dTextMesh>();
		}

		// Token: 0x06003510 RID: 13584 RVA: 0x0013B319 File Offset: 0x00139519
		public override void Reset()
		{
			this.gameObject = null;
		}

		// Token: 0x06003511 RID: 13585 RVA: 0x0013B322 File Offset: 0x00139522
		public override void OnEnter()
		{
			this._getTextMesh();
			this.DoCommit();
			base.Finish();
		}

		// Token: 0x06003512 RID: 13586 RVA: 0x0013B336 File Offset: 0x00139536
		private void DoCommit()
		{
			if (this._textMesh == null)
			{
				base.LogWarning("Missing tk2dTextMesh component: " + this._textMesh.gameObject.name);
				return;
			}
			this._textMesh.Commit();
		}

		// Token: 0x040036AE RID: 13998
		[RequiredField]
		[Tooltip("The Game Object to work with. NOTE: The Game Object must have a tk2dTextMesh component attached.")]
		[CheckForComponent(typeof(tk2dTextMesh))]
		public FsmOwnerDefault gameObject;

		// Token: 0x040036AF RID: 13999
		private tk2dTextMesh _textMesh;
	}
}
