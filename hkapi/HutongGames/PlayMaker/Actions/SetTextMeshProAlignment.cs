using System;
using TMPro;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A55 RID: 2645
	[ActionCategory("TextMeshPro")]
	[Tooltip("Set TextMeshPro color.")]
	public class SetTextMeshProAlignment : FsmStateAction
	{
		// Token: 0x0600392F RID: 14639 RVA: 0x0014D57B File Offset: 0x0014B77B
		public override void Reset()
		{
			this.gameObject = null;
		}

		// Token: 0x06003930 RID: 14640 RVA: 0x0014D584 File Offset: 0x0014B784
		public override void OnEnter()
		{
			this.go = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (this.gameObject != null)
			{
				this.go = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
				this.textMesh = this.go.GetComponent<TextMeshPro>();
				if (this.textMesh != null)
				{
					if (this.topLeft.Value)
					{
						this.textMesh.alignment = TextAlignmentOptions.TopLeft;
					}
					if (this.topRight.Value)
					{
						this.textMesh.alignment = TextAlignmentOptions.TopRight;
					}
					if (this.topCentre.Value)
					{
						this.textMesh.alignment = TextAlignmentOptions.Top;
					}
					if (this.topJustified.Value)
					{
						this.textMesh.alignment = TextAlignmentOptions.TopJustified;
					}
					if (this.centreLeft.Value)
					{
						this.textMesh.alignment = TextAlignmentOptions.Left;
					}
					if (this.centreRight.Value)
					{
						this.textMesh.alignment = TextAlignmentOptions.Right;
					}
					if (this.centreCentre.Value)
					{
						this.textMesh.alignment = TextAlignmentOptions.Center;
					}
					if (this.centreJustified.Value)
					{
						this.textMesh.alignment = TextAlignmentOptions.Justified;
					}
					if (this.bottomLeft.Value)
					{
						this.textMesh.alignment = TextAlignmentOptions.BottomLeft;
					}
					if (this.bottomRight.Value)
					{
						this.textMesh.alignment = TextAlignmentOptions.BottomRight;
					}
					if (this.bottomCentre.Value)
					{
						this.textMesh.alignment = TextAlignmentOptions.Bottom;
					}
					if (this.bottomJustified.Value)
					{
						this.textMesh.alignment = TextAlignmentOptions.BottomJustified;
					}
				}
			}
			base.Finish();
		}

		// Token: 0x04003BC2 RID: 15298
		[RequiredField]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003BC3 RID: 15299
		[RequiredField]
		public FsmBool topLeft;

		// Token: 0x04003BC4 RID: 15300
		public FsmBool topRight;

		// Token: 0x04003BC5 RID: 15301
		public FsmBool topCentre;

		// Token: 0x04003BC6 RID: 15302
		public FsmBool topJustified;

		// Token: 0x04003BC7 RID: 15303
		public FsmBool centreLeft;

		// Token: 0x04003BC8 RID: 15304
		public FsmBool centreRight;

		// Token: 0x04003BC9 RID: 15305
		public FsmBool centreCentre;

		// Token: 0x04003BCA RID: 15306
		public FsmBool centreJustified;

		// Token: 0x04003BCB RID: 15307
		public FsmBool bottomLeft;

		// Token: 0x04003BCC RID: 15308
		public FsmBool bottomRight;

		// Token: 0x04003BCD RID: 15309
		public FsmBool bottomCentre;

		// Token: 0x04003BCE RID: 15310
		public FsmBool bottomJustified;

		// Token: 0x04003BCF RID: 15311
		private GameObject go;

		// Token: 0x04003BD0 RID: 15312
		private TextMeshPro textMesh;
	}
}
