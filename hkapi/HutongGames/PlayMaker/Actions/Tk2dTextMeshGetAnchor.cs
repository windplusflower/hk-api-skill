using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000972 RID: 2418
	[ActionCategory("2D Toolkit/TextMesh")]
	[Tooltip("Get the anchor of a TextMesh. \nThe anchor is stored as a string. tk2dTextMeshSetAnchor can work with this string. \nNOTE: The Game Object must have a tk2dTextMesh attached.")]
	public class Tk2dTextMeshGetAnchor : FsmStateAction
	{
		// Token: 0x06003514 RID: 13588 RVA: 0x0013B374 File Offset: 0x00139574
		private void _getTextMesh()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			this._textMesh = ownerDefaultTarget.GetComponent<tk2dTextMesh>();
		}

		// Token: 0x06003515 RID: 13589 RVA: 0x0013B3A9 File Offset: 0x001395A9
		public override void Reset()
		{
			this.gameObject = null;
			this.textAnchorAsString = "";
			this.everyframe = false;
		}

		// Token: 0x06003516 RID: 13590 RVA: 0x0013B3C9 File Offset: 0x001395C9
		public override void OnEnter()
		{
			this._getTextMesh();
			this.DoGetAnchor();
			if (!this.everyframe)
			{
				base.Finish();
			}
		}

		// Token: 0x06003517 RID: 13591 RVA: 0x0013B3E5 File Offset: 0x001395E5
		public override void OnUpdate()
		{
			this.DoGetAnchor();
		}

		// Token: 0x06003518 RID: 13592 RVA: 0x0013B3F0 File Offset: 0x001395F0
		private void DoGetAnchor()
		{
			if (this._textMesh == null)
			{
				base.LogWarning("Missing tk2dTextMesh component");
				return;
			}
			this.textAnchorAsString.Value = this._textMesh.anchor.ToString();
		}

		// Token: 0x040036B0 RID: 14000
		[RequiredField]
		[Tooltip("The Game Object to work with. NOTE: The Game Object must have a tk2dTextMesh component attached.")]
		[CheckForComponent(typeof(tk2dTextMesh))]
		public FsmOwnerDefault gameObject;

		// Token: 0x040036B1 RID: 14001
		[RequiredField]
		[Tooltip("The anchor as a string. \npossible values: LowerLeft,LowerCenter,LowerRight,MiddleLeft,MiddleCenter,MiddleRight,UpperLeft,UpperCenter or UpperRight ")]
		[UIHint(UIHint.Variable)]
		public FsmString textAnchorAsString;

		// Token: 0x040036B2 RID: 14002
		[ActionSection("")]
		[Tooltip("Repeat every frame.")]
		public bool everyframe;

		// Token: 0x040036B3 RID: 14003
		private tk2dTextMesh _textMesh;
	}
}
