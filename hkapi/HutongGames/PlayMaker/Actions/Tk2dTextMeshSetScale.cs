using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000985 RID: 2437
	[ActionCategory("2D Toolkit/TextMesh")]
	[Tooltip("Set the scale of a TextMesh. \nChanges will not be updated if commit is OFF. This is so you can change multiple parameters without reconstructing the mesh repeatedly.\n Use tk2dtextMeshCommit or set commit to true on your last change for that mesh. \nNOTE: The Game Object must have a tk2dTextMesh attached.")]
	public class Tk2dTextMeshSetScale : FsmStateAction
	{
		// Token: 0x0600357F RID: 13695 RVA: 0x0013C59C File Offset: 0x0013A79C
		private void _getTextMesh()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			this._textMesh = ownerDefaultTarget.GetComponent<tk2dTextMesh>();
		}

		// Token: 0x06003580 RID: 13696 RVA: 0x0013C5D1 File Offset: 0x0013A7D1
		public override void Reset()
		{
			this.gameObject = null;
			this.scale = null;
			this.commit = true;
			this.everyframe = false;
		}

		// Token: 0x06003581 RID: 13697 RVA: 0x0013C5F4 File Offset: 0x0013A7F4
		public override void OnEnter()
		{
			this._getTextMesh();
			this.DoSetScale();
			if (!this.everyframe)
			{
				base.Finish();
			}
		}

		// Token: 0x06003582 RID: 13698 RVA: 0x0013C610 File Offset: 0x0013A810
		public override void OnUpdate()
		{
			this.DoSetScale();
		}

		// Token: 0x06003583 RID: 13699 RVA: 0x0013C618 File Offset: 0x0013A818
		private void DoSetScale()
		{
			if (this._textMesh == null)
			{
				base.LogWarning("Missing tk2dTextMesh component: " + this._textMesh.gameObject.name);
				return;
			}
			if (this._textMesh.scale != this.scale.Value)
			{
				this._textMesh.scale = this.scale.Value;
				if (this.commit.Value)
				{
					this._textMesh.Commit();
				}
			}
		}

		// Token: 0x04003709 RID: 14089
		[RequiredField]
		[Tooltip("The Game Object to work with. NOTE: The Game Object must have a tk2dTextMesh component attached.")]
		[CheckForComponent(typeof(tk2dTextMesh))]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400370A RID: 14090
		[Tooltip("The scale")]
		[UIHint(UIHint.FsmVector3)]
		public FsmVector3 scale;

		// Token: 0x0400370B RID: 14091
		[Tooltip("Commit changes")]
		[UIHint(UIHint.FsmBool)]
		public FsmBool commit;

		// Token: 0x0400370C RID: 14092
		[ActionSection("")]
		[Tooltip("Repeat every frame.")]
		public bool everyframe;

		// Token: 0x0400370D RID: 14093
		private tk2dTextMesh _textMesh;
	}
}
