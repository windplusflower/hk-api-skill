using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000977 RID: 2423
	[ActionCategory("2D Toolkit/TextMesh")]
	[Tooltip("Get the maximum characters number of a TextMesh. \nNOTE: The Game Object must have a tk2dTextMesh attached.")]
	public class Tk2dTextMeshGetMaxChars : FsmStateAction
	{
		// Token: 0x06003531 RID: 13617 RVA: 0x0013B750 File Offset: 0x00139950
		private void _getTextMesh()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			this._textMesh = ownerDefaultTarget.GetComponent<tk2dTextMesh>();
		}

		// Token: 0x06003532 RID: 13618 RVA: 0x0013B785 File Offset: 0x00139985
		public override void Reset()
		{
			this.gameObject = null;
			this.maxChars = null;
			this.everyframe = false;
		}

		// Token: 0x06003533 RID: 13619 RVA: 0x0013B79C File Offset: 0x0013999C
		public override void OnEnter()
		{
			this._getTextMesh();
			this.DoGetMaxChars();
			if (!this.everyframe)
			{
				base.Finish();
			}
		}

		// Token: 0x06003534 RID: 13620 RVA: 0x0013B7B8 File Offset: 0x001399B8
		public override void OnUpdate()
		{
			this.DoGetMaxChars();
		}

		// Token: 0x06003535 RID: 13621 RVA: 0x0013B7C0 File Offset: 0x001399C0
		private void DoGetMaxChars()
		{
			if (this._textMesh == null)
			{
				base.LogWarning("Missing tk2dTextMesh component: ");
				return;
			}
			this.maxChars.Value = this._textMesh.maxChars;
		}

		// Token: 0x040036C5 RID: 14021
		[RequiredField]
		[Tooltip("The Game Object to work with. NOTE: The Game Object must have a tk2dTextMesh component attached.")]
		[CheckForComponent(typeof(tk2dTextMesh))]
		public FsmOwnerDefault gameObject;

		// Token: 0x040036C6 RID: 14022
		[Tooltip("The max number of characters")]
		[UIHint(UIHint.Variable)]
		public FsmInt maxChars;

		// Token: 0x040036C7 RID: 14023
		[ActionSection("")]
		[Tooltip("Repeat every frame.")]
		public bool everyframe;

		// Token: 0x040036C8 RID: 14024
		private tk2dTextMesh _textMesh;
	}
}
