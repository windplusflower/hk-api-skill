using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000978 RID: 2424
	[ActionCategory("2D Toolkit/TextMesh")]
	[Tooltip("Get the number of drawn characters of a TextMesh. \nNOTE: The Game Object must have a tk2dTextMesh attached.")]
	public class Tk2dTextMeshGetNumDrawnCharacters : FsmStateAction
	{
		// Token: 0x06003537 RID: 13623 RVA: 0x0013B7F4 File Offset: 0x001399F4
		private void _getTextMesh()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			this._textMesh = ownerDefaultTarget.GetComponent<tk2dTextMesh>();
		}

		// Token: 0x06003538 RID: 13624 RVA: 0x0013B829 File Offset: 0x00139A29
		public override void Reset()
		{
			this.gameObject = null;
			this.numDrawnCharacters = null;
			this.everyframe = false;
		}

		// Token: 0x06003539 RID: 13625 RVA: 0x0013B840 File Offset: 0x00139A40
		public override void OnEnter()
		{
			this._getTextMesh();
			this.DoGetNumDrawnCharacters();
			if (!this.everyframe)
			{
				base.Finish();
			}
		}

		// Token: 0x0600353A RID: 13626 RVA: 0x0013B85C File Offset: 0x00139A5C
		public override void OnUpdate()
		{
			this.DoGetNumDrawnCharacters();
		}

		// Token: 0x0600353B RID: 13627 RVA: 0x0013B864 File Offset: 0x00139A64
		private void DoGetNumDrawnCharacters()
		{
			if (this._textMesh == null)
			{
				base.LogWarning("Missing tk2dTextMesh component");
				return;
			}
			this.numDrawnCharacters.Value = this._textMesh.NumDrawnCharacters();
		}

		// Token: 0x040036C9 RID: 14025
		[RequiredField]
		[Tooltip("The Game Object to work with. NOTE: The Game Object must have a tk2dTextMesh component attached.")]
		[CheckForComponent(typeof(tk2dTextMesh))]
		public FsmOwnerDefault gameObject;

		// Token: 0x040036CA RID: 14026
		[RequiredField]
		[Tooltip("The number of drawn characters")]
		[UIHint(UIHint.Variable)]
		public FsmInt numDrawnCharacters;

		// Token: 0x040036CB RID: 14027
		[ActionSection("")]
		[Tooltip("Repeat every frame.")]
		public bool everyframe;

		// Token: 0x040036CC RID: 14028
		private tk2dTextMesh _textMesh;
	}
}
