using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000986 RID: 2438
	[ActionCategory("2D Toolkit/TextMesh")]
	[Tooltip("Set the text of a TextMesh. \nChanges will not be updated if commit is OFF. This is so you can change multiple parameters without reconstructing the mesh repeatedly.\n Use tk2dtextMeshCommit or set commit to true on your last change for that mesh. \nNOTE: The Game Object must have a tk2dTextMesh attached.")]
	[HelpUrl("https://hutonggames.fogbugz.com/default.asp?W719")]
	public class Tk2dTextMeshSetText : FsmStateAction
	{
		// Token: 0x06003585 RID: 13701 RVA: 0x0013C6A0 File Offset: 0x0013A8A0
		private void _getTextMesh()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			this._textMesh = ownerDefaultTarget.GetComponent<tk2dTextMesh>();
		}

		// Token: 0x06003586 RID: 13702 RVA: 0x0013C6D5 File Offset: 0x0013A8D5
		public override void Reset()
		{
			this.gameObject = null;
			this.text = "";
			this.commit = true;
			this.everyframe = false;
		}

		// Token: 0x06003587 RID: 13703 RVA: 0x0013C701 File Offset: 0x0013A901
		public override void OnEnter()
		{
			this._getTextMesh();
			this.DoSetText();
			if (!this.everyframe)
			{
				base.Finish();
			}
		}

		// Token: 0x06003588 RID: 13704 RVA: 0x0013C71D File Offset: 0x0013A91D
		public override void OnUpdate()
		{
			this.DoSetText();
		}

		// Token: 0x06003589 RID: 13705 RVA: 0x0013C728 File Offset: 0x0013A928
		private void DoSetText()
		{
			if (this._textMesh == null)
			{
				base.LogWarning("Missing tk2dTextMesh component: " + this._textMesh.gameObject.name);
				return;
			}
			if (this._textMesh.text != this.text.Value)
			{
				this._textMesh.text = this.text.Value;
				if (this.commit.Value)
				{
					this._textMesh.Commit();
				}
			}
		}

		// Token: 0x0400370E RID: 14094
		[RequiredField]
		[Tooltip("The Game Object to work with. NOTE: The Game Object must have a tk2dTextMesh component attached.")]
		[CheckForComponent(typeof(tk2dTextMesh))]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400370F RID: 14095
		[Tooltip("The text")]
		[UIHint(UIHint.FsmString)]
		public FsmString text;

		// Token: 0x04003710 RID: 14096
		[Tooltip("Commit changes")]
		[UIHint(UIHint.FsmString)]
		public FsmBool commit;

		// Token: 0x04003711 RID: 14097
		[ActionSection("")]
		[Tooltip("Repeat every frame.")]
		public bool everyframe;

		// Token: 0x04003712 RID: 14098
		private tk2dTextMesh _textMesh;
	}
}
