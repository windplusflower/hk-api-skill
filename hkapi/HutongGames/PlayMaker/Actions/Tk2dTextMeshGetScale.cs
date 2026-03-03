using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x0200097B RID: 2427
	[ActionCategory("2D Toolkit/TextMesh")]
	[Tooltip("Get the scale of a TextMesh. \nNOTE: The Game Object must have a tk2dTextMesh attached.")]
	public class Tk2dTextMeshGetScale : FsmStateAction
	{
		// Token: 0x06003545 RID: 13637 RVA: 0x0013BAAA File Offset: 0x00139CAA
		private void _getTextMesh()
		{
			this.go = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (this.go == null)
			{
				return;
			}
			this._textMesh = this.go.GetComponent<tk2dTextMesh>();
		}

		// Token: 0x06003546 RID: 13638 RVA: 0x0013BAE3 File Offset: 0x00139CE3
		public override void Reset()
		{
			this.gameObject = null;
			this.scale = null;
			this.everyframe = false;
		}

		// Token: 0x06003547 RID: 13639 RVA: 0x0013BAFA File Offset: 0x00139CFA
		public override void OnEnter()
		{
			this._getTextMesh();
			this.DoGetScale();
			if (!this.everyframe)
			{
				base.Finish();
			}
		}

		// Token: 0x06003548 RID: 13640 RVA: 0x0013BB16 File Offset: 0x00139D16
		public override void OnUpdate()
		{
			this.DoGetScale();
		}

		// Token: 0x06003549 RID: 13641 RVA: 0x0013BB20 File Offset: 0x00139D20
		private void DoGetScale()
		{
			if (this.go == null)
			{
				return;
			}
			if (this._textMesh == null)
			{
				Debug.Log(this._textMesh);
				base.LogError("Missing tk2dTextMesh component: " + this.go.name);
				return;
			}
			this.scale.Value = this._textMesh.scale;
		}

		// Token: 0x040036DC RID: 14044
		[RequiredField]
		[Tooltip("The Game Object to work with. NOTE: The Game Object must have a tk2dTextMesh component attached.")]
		[CheckForComponent(typeof(tk2dTextMesh))]
		public FsmOwnerDefault gameObject;

		// Token: 0x040036DD RID: 14045
		[RequiredField]
		[Tooltip("The scale")]
		[UIHint(UIHint.Variable)]
		public FsmVector3 scale;

		// Token: 0x040036DE RID: 14046
		[ActionSection("")]
		[Tooltip("Repeat every frame.")]
		public bool everyframe;

		// Token: 0x040036DF RID: 14047
		private GameObject go;

		// Token: 0x040036E0 RID: 14048
		private tk2dTextMesh _textMesh;
	}
}
