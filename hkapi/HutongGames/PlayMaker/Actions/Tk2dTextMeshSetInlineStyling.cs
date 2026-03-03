using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000982 RID: 2434
	[ActionCategory("2D Toolkit/TextMesh")]
	[Tooltip("Set the inlineStyling flag of a TextMesh. \nChanges will not be updated if commit is OFF. This is so you can change multiple parameters without reconstructing the mesh repeatedly.\n Use tk2dtextMeshCommit or set commit to true on your last change for that mesh. \nNOTE: The Game Object must have a tk2dTextMesh attached.")]
	public class Tk2dTextMeshSetInlineStyling : FsmStateAction
	{
		// Token: 0x0600356E RID: 13678 RVA: 0x0013C2F0 File Offset: 0x0013A4F0
		private void _getTextMesh()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			this._textMesh = ownerDefaultTarget.GetComponent<tk2dTextMesh>();
		}

		// Token: 0x0600356F RID: 13679 RVA: 0x0013C325 File Offset: 0x0013A525
		public override void Reset()
		{
			this.gameObject = null;
			this.inlineStyling = true;
			this.commit = true;
		}

		// Token: 0x06003570 RID: 13680 RVA: 0x0013C346 File Offset: 0x0013A546
		public override void OnEnter()
		{
			this._getTextMesh();
			this.DoSetInlineStyling();
			base.Finish();
		}

		// Token: 0x06003571 RID: 13681 RVA: 0x0013C35C File Offset: 0x0013A55C
		private void DoSetInlineStyling()
		{
			if (this._textMesh == null)
			{
				base.LogWarning("Missing tk2dTextMesh component: ");
				return;
			}
			if (this._textMesh.inlineStyling != this.inlineStyling.Value)
			{
				this._textMesh.inlineStyling = this.inlineStyling.Value;
				if (this.commit.Value)
				{
					this._textMesh.Commit();
				}
			}
		}

		// Token: 0x040036FB RID: 14075
		[RequiredField]
		[Tooltip("The Game Object to work with. NOTE: The Game Object must have a tk2dTextMesh component attached.")]
		[CheckForComponent(typeof(tk2dTextMesh))]
		public FsmOwnerDefault gameObject;

		// Token: 0x040036FC RID: 14076
		[Tooltip("Does the text features inline styling?")]
		[UIHint(UIHint.FsmBool)]
		public FsmBool inlineStyling;

		// Token: 0x040036FD RID: 14077
		[Tooltip("Commit changes")]
		[UIHint(UIHint.FsmString)]
		public FsmBool commit;

		// Token: 0x040036FE RID: 14078
		private tk2dTextMesh _textMesh;
	}
}
