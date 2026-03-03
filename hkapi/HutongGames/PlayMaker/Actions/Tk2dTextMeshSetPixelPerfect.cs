using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000984 RID: 2436
	[ActionCategory("2D Toolkit/TextMesh")]
	[Tooltip("Set the pixelPerfect flag of a TextMesh. \nChanges will not be updated if commit is OFF. This is so you can change multiple parameters without reconstructing the mesh repeatedly.\n Use tk2dtextMeshCommit or set commit to true on your last change for that mesh. \nNOTE: The Game Object must have a tk2dTextMesh attached.")]
	public class Tk2dTextMeshSetPixelPerfect : FsmStateAction
	{
		// Token: 0x06003579 RID: 13689 RVA: 0x0013C4C0 File Offset: 0x0013A6C0
		private void _getTextMesh()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			this._textMesh = ownerDefaultTarget.GetComponent<tk2dTextMesh>();
		}

		// Token: 0x0600357A RID: 13690 RVA: 0x0013C4F5 File Offset: 0x0013A6F5
		public override void Reset()
		{
			this.gameObject = null;
			this.pixelPerfect = true;
			this.commit = true;
			this.everyframe = false;
		}

		// Token: 0x0600357B RID: 13691 RVA: 0x0013C51D File Offset: 0x0013A71D
		public override void OnEnter()
		{
			this._getTextMesh();
			this.DoSetPixelPerfect();
			if (!this.everyframe)
			{
				base.Finish();
			}
		}

		// Token: 0x0600357C RID: 13692 RVA: 0x0013C539 File Offset: 0x0013A739
		public override void OnUpdate()
		{
			this.DoSetPixelPerfect();
		}

		// Token: 0x0600357D RID: 13693 RVA: 0x0013C544 File Offset: 0x0013A744
		private void DoSetPixelPerfect()
		{
			if (this._textMesh == null)
			{
				base.LogWarning("Missing tk2dTextMesh component: ");
				return;
			}
			if (this.pixelPerfect.Value)
			{
				this._textMesh.MakePixelPerfect();
				if (this.commit.Value)
				{
					this._textMesh.Commit();
				}
			}
		}

		// Token: 0x04003704 RID: 14084
		[RequiredField]
		[Tooltip("The Game Object to work with. NOTE: The Game Object must have a tk2dTextMesh component attached.")]
		[CheckForComponent(typeof(tk2dTextMesh))]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003705 RID: 14085
		[Tooltip("Does the text needs to be pixelPerfect")]
		[UIHint(UIHint.FsmBool)]
		public FsmBool pixelPerfect;

		// Token: 0x04003706 RID: 14086
		[Tooltip("Commit changes")]
		[UIHint(UIHint.FsmString)]
		public FsmBool commit;

		// Token: 0x04003707 RID: 14087
		[ActionSection("")]
		[Tooltip("Repeat every frame.")]
		public bool everyframe;

		// Token: 0x04003708 RID: 14088
		private tk2dTextMesh _textMesh;
	}
}
