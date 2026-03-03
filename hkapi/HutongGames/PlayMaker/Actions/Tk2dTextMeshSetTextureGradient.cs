using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000987 RID: 2439
	[ActionCategory("2D Toolkit/TextMesh")]
	[Tooltip("Set the texture gradient of the font currently applied to a TextMesh. \nChanges will not be updated if commit is OFF. This is so you can change multiple parameters without reconstructing the mesh repeatedly.\n Use tk2dtextMeshCommit or set commit to true on your last change for that mesh. \nNOTE: The Game Object must have a tk2dTextMesh attached.")]
	public class Tk2dTextMeshSetTextureGradient : FsmStateAction
	{
		// Token: 0x0600358B RID: 13707 RVA: 0x0013C7B0 File Offset: 0x0013A9B0
		private void _getTextMesh()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			this._textMesh = ownerDefaultTarget.GetComponent<tk2dTextMesh>();
		}

		// Token: 0x0600358C RID: 13708 RVA: 0x0013C7E5 File Offset: 0x0013A9E5
		public override void Reset()
		{
			this.gameObject = null;
			this.textureGradient = 0;
			this.commit = true;
			this.everyframe = false;
		}

		// Token: 0x0600358D RID: 13709 RVA: 0x0013C80D File Offset: 0x0013AA0D
		public override void OnEnter()
		{
			this._getTextMesh();
			this.DoSetTextureGradient();
			if (!this.everyframe)
			{
				base.Finish();
			}
		}

		// Token: 0x0600358E RID: 13710 RVA: 0x0013C829 File Offset: 0x0013AA29
		public override void OnUpdate()
		{
			this.DoSetTextureGradient();
		}

		// Token: 0x0600358F RID: 13711 RVA: 0x0013C834 File Offset: 0x0013AA34
		private void DoSetTextureGradient()
		{
			if (this._textMesh == null)
			{
				base.LogWarning("Missing tk2dTextMesh component: " + this._textMesh.gameObject.name);
				return;
			}
			if (this._textMesh.textureGradient != this.textureGradient.Value)
			{
				this._textMesh.textureGradient = this.textureGradient.Value;
				if (this.commit.Value)
				{
					this._textMesh.Commit();
				}
			}
		}

		// Token: 0x04003713 RID: 14099
		[RequiredField]
		[Tooltip("The Game Object to work with. NOTE: The Game Object must have a tk2dTextMesh component attached.")]
		[CheckForComponent(typeof(tk2dTextMesh))]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003714 RID: 14100
		[Tooltip("The Gradient Id")]
		[UIHint(UIHint.FsmInt)]
		public FsmInt textureGradient;

		// Token: 0x04003715 RID: 14101
		[Tooltip("Commit changes")]
		[UIHint(UIHint.FsmString)]
		public FsmBool commit;

		// Token: 0x04003716 RID: 14102
		[ActionSection("")]
		[Tooltip("Repeat every frame.")]
		public bool everyframe;

		// Token: 0x04003717 RID: 14103
		private tk2dTextMesh _textMesh;
	}
}
