using System;
using TMPro;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A57 RID: 2647
	[ActionCategory("TextMeshPro")]
	[Tooltip("Set TextMeshPro color.")]
	public class SetTextMeshProText : FsmStateAction
	{
		// Token: 0x06003936 RID: 14646 RVA: 0x0014D82F File Offset: 0x0014BA2F
		public override void Reset()
		{
			this.gameObject = null;
			this.textString = null;
		}

		// Token: 0x06003937 RID: 14647 RVA: 0x0014D840 File Offset: 0x0014BA40
		public override void OnEnter()
		{
			this.go = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (this.gameObject != null)
			{
				this.go = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
				this.textMesh = this.go.GetComponent<TextMeshPro>();
				if (this.textMesh != null)
				{
					this.textMesh.text = this.textString.Value;
				}
			}
			base.Finish();
		}

		// Token: 0x04003BD6 RID: 15318
		[RequiredField]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003BD7 RID: 15319
		[RequiredField]
		public FsmString textString;

		// Token: 0x04003BD8 RID: 15320
		private GameObject go;

		// Token: 0x04003BD9 RID: 15321
		private TextMeshPro textMesh;
	}
}
