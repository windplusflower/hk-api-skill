using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000975 RID: 2421
	[ActionCategory("2D Toolkit/TextMesh")]
	[Tooltip("Get the inline styling flag of a TextMesh. \nNOTE: The Game Object must have a tk2dTextMesh attached.")]
	public class Tk2dTextMeshGetInlineStyling : FsmStateAction
	{
		// Token: 0x06003525 RID: 13605 RVA: 0x0013B5E8 File Offset: 0x001397E8
		private void _getTextMesh()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			this._textMesh = ownerDefaultTarget.GetComponent<tk2dTextMesh>();
		}

		// Token: 0x06003526 RID: 13606 RVA: 0x0013B61D File Offset: 0x0013981D
		public override void Reset()
		{
			this.gameObject = null;
			this.inlineStyling = null;
			this.everyframe = false;
		}

		// Token: 0x06003527 RID: 13607 RVA: 0x0013B634 File Offset: 0x00139834
		public override void OnEnter()
		{
			this._getTextMesh();
			this.DoGetInlineStyling();
			if (!this.everyframe)
			{
				base.Finish();
			}
		}

		// Token: 0x06003528 RID: 13608 RVA: 0x0013B650 File Offset: 0x00139850
		public override void OnUpdate()
		{
			this.DoGetInlineStyling();
		}

		// Token: 0x06003529 RID: 13609 RVA: 0x0013B658 File Offset: 0x00139858
		private void DoGetInlineStyling()
		{
			if (this._textMesh == null)
			{
				base.LogWarning("Missing tk2dTextMesh component: ");
				return;
			}
			this.inlineStyling.Value = this._textMesh.inlineStyling;
		}

		// Token: 0x040036BD RID: 14013
		[RequiredField]
		[Tooltip("The Game Object to work with. NOTE: The Game Object must have a tk2dTextMesh component attached.")]
		[CheckForComponent(typeof(tk2dTextMesh))]
		public FsmOwnerDefault gameObject;

		// Token: 0x040036BE RID: 14014
		[RequiredField]
		[Tooltip("The max number of characters")]
		[UIHint(UIHint.Variable)]
		public FsmBool inlineStyling;

		// Token: 0x040036BF RID: 14015
		[ActionSection("")]
		[Tooltip("Repeat every frame.")]
		public bool everyframe;

		// Token: 0x040036C0 RID: 14016
		private tk2dTextMesh _textMesh;
	}
}
