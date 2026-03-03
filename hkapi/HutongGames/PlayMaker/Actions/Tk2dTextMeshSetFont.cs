using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000981 RID: 2433
	[ActionCategory("2D Toolkit/TextMesh")]
	[Tooltip("Set the font of a TextMesh. \nChanges will not be updated if commit is OFF. This is so you can change multiple parameters without reconstructing the mesh repeatedly.\n Use tk2dtextMeshCommit or set commit to true on your last change for that mesh. \nNOTE: The Game Object must have a tk2dTextMesh attached.")]
	public class Tk2dTextMeshSetFont : FsmStateAction
	{
		// Token: 0x06003569 RID: 13673 RVA: 0x0013C1F0 File Offset: 0x0013A3F0
		private void _getTextMesh()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			this._textMesh = ownerDefaultTarget.GetComponent<tk2dTextMesh>();
		}

		// Token: 0x0600356A RID: 13674 RVA: 0x0013C225 File Offset: 0x0013A425
		public override void Reset()
		{
			this.gameObject = null;
			this.font = null;
			this.commit = true;
		}

		// Token: 0x0600356B RID: 13675 RVA: 0x0013C241 File Offset: 0x0013A441
		public override void OnEnter()
		{
			this._getTextMesh();
			this.DoSetFont();
			base.Finish();
		}

		// Token: 0x0600356C RID: 13676 RVA: 0x0013C258 File Offset: 0x0013A458
		private void DoSetFont()
		{
			if (this._textMesh == null)
			{
				base.LogWarning("Missing tk2dTextMesh component: " + this._textMesh.gameObject.name);
				return;
			}
			GameObject value = this.font.Value;
			if (value == null)
			{
				return;
			}
			tk2dFont component = value.GetComponent<tk2dFont>();
			if (component == null)
			{
				return;
			}
			this._textMesh.font = component.data;
			this._textMesh.GetComponent<Renderer>().material = component.material;
			this._textMesh.Init(true);
		}

		// Token: 0x040036F7 RID: 14071
		[RequiredField]
		[Tooltip("The Game Object to work with. NOTE: The Game Object must have a tk2dTextMesh component attached.")]
		[CheckForComponent(typeof(tk2dTextMesh))]
		public FsmOwnerDefault gameObject;

		// Token: 0x040036F8 RID: 14072
		[RequiredField]
		[Tooltip("The font gameObject")]
		[UIHint(UIHint.FsmGameObject)]
		[CheckForComponent(typeof(tk2dFont))]
		public FsmGameObject font;

		// Token: 0x040036F9 RID: 14073
		[Tooltip("Commit changes")]
		[UIHint(UIHint.FsmString)]
		public FsmBool commit;

		// Token: 0x040036FA RID: 14074
		private tk2dTextMesh _textMesh;
	}
}
