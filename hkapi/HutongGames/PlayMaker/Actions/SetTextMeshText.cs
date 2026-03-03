using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A58 RID: 2648
	[ActionCategory("TextMesh")]
	[Tooltip("Set TextMesh text.")]
	public class SetTextMeshText : FsmStateAction
	{
		// Token: 0x06003939 RID: 14649 RVA: 0x0014D8BE File Offset: 0x0014BABE
		public override void Reset()
		{
			this.gameObject = null;
			this.textString = null;
		}

		// Token: 0x0600393A RID: 14650 RVA: 0x0014D8D0 File Offset: 0x0014BAD0
		public override void OnEnter()
		{
			if (this.gameObject != null)
			{
				GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
				this.textMesh = ownerDefaultTarget.GetComponent<TextMesh>();
				if (this.textMesh != null)
				{
					this.textMesh.text = this.textString.Value;
				}
			}
			base.Finish();
		}

		// Token: 0x04003BDA RID: 15322
		[RequiredField]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003BDB RID: 15323
		public FsmString textString;

		// Token: 0x04003BDC RID: 15324
		private TextMesh textMesh;
	}
}
