using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000983 RID: 2435
	[ActionCategory("2D Toolkit/TextMesh")]
	[Tooltip("Set the maximum characters number of a TextMesh. \nChanges will not be updated if commit is OFF. This is so you can change multiple parameters without reconstructing the mesh repeatedly.\n Use tk2dtextMeshCommit or set commit to true on your last change for that mesh. \nNOTE: The Game Object must have a tk2dTextMesh attached.")]
	public class Tk2dTextMeshSetMaxChars : FsmStateAction
	{
		// Token: 0x06003573 RID: 13683 RVA: 0x0013C3CC File Offset: 0x0013A5CC
		private void _getTextMesh()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			this._textMesh = ownerDefaultTarget.GetComponent<tk2dTextMesh>();
		}

		// Token: 0x06003574 RID: 13684 RVA: 0x0013C401 File Offset: 0x0013A601
		public override void Reset()
		{
			this.gameObject = null;
			this.maxChars = 30;
			this.commit = true;
			this.everyframe = false;
		}

		// Token: 0x06003575 RID: 13685 RVA: 0x0013C42A File Offset: 0x0013A62A
		public override void OnEnter()
		{
			this._getTextMesh();
			this.DoSetMaxChars();
			if (!this.everyframe)
			{
				base.Finish();
			}
		}

		// Token: 0x06003576 RID: 13686 RVA: 0x0013C446 File Offset: 0x0013A646
		public override void OnUpdate()
		{
			this.DoSetMaxChars();
		}

		// Token: 0x06003577 RID: 13687 RVA: 0x0013C450 File Offset: 0x0013A650
		private void DoSetMaxChars()
		{
			if (this._textMesh == null)
			{
				base.LogWarning("Missing tk2dTextMesh component: ");
				return;
			}
			if (this._textMesh.maxChars != this.maxChars.Value)
			{
				this._textMesh.maxChars = this.maxChars.Value;
				if (this.commit.Value)
				{
					this._textMesh.Commit();
				}
			}
		}

		// Token: 0x040036FF RID: 14079
		[RequiredField]
		[Tooltip("The Game Object to work with. NOTE: The Game Object must have a tk2dTextMesh component attached.")]
		[CheckForComponent(typeof(tk2dTextMesh))]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003700 RID: 14080
		[Tooltip("The max number of characters")]
		[UIHint(UIHint.FsmInt)]
		public FsmInt maxChars;

		// Token: 0x04003701 RID: 14081
		[Tooltip("Commit changes")]
		[UIHint(UIHint.FsmString)]
		public FsmBool commit;

		// Token: 0x04003702 RID: 14082
		[ActionSection("")]
		[Tooltip("Repeat every frame.")]
		public bool everyframe;

		// Token: 0x04003703 RID: 14083
		private tk2dTextMesh _textMesh;
	}
}
