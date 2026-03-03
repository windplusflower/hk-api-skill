using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B9B RID: 2971
	[Tooltip("GUI base action - don't use!")]
	public abstract class GUIAction : FsmStateAction
	{
		// Token: 0x06003F07 RID: 16135 RVA: 0x00165CC0 File Offset: 0x00163EC0
		public override void Reset()
		{
			this.screenRect = null;
			this.left = 0f;
			this.top = 0f;
			this.width = 1f;
			this.height = 1f;
			this.normalized = true;
		}

		// Token: 0x06003F08 RID: 16136 RVA: 0x00165D20 File Offset: 0x00163F20
		public override void OnGUI()
		{
			this.rect = ((!this.screenRect.IsNone) ? this.screenRect.Value : default(Rect));
			if (!this.left.IsNone)
			{
				this.rect.x = this.left.Value;
			}
			if (!this.top.IsNone)
			{
				this.rect.y = this.top.Value;
			}
			if (!this.width.IsNone)
			{
				this.rect.width = this.width.Value;
			}
			if (!this.height.IsNone)
			{
				this.rect.height = this.height.Value;
			}
			if (this.normalized.Value)
			{
				this.rect.x = this.rect.x * (float)Screen.width;
				this.rect.width = this.rect.width * (float)Screen.width;
				this.rect.y = this.rect.y * (float)Screen.height;
				this.rect.height = this.rect.height * (float)Screen.height;
			}
		}

		// Token: 0x0400431F RID: 17183
		[UIHint(UIHint.Variable)]
		public FsmRect screenRect;

		// Token: 0x04004320 RID: 17184
		public FsmFloat left;

		// Token: 0x04004321 RID: 17185
		public FsmFloat top;

		// Token: 0x04004322 RID: 17186
		public FsmFloat width;

		// Token: 0x04004323 RID: 17187
		public FsmFloat height;

		// Token: 0x04004324 RID: 17188
		[RequiredField]
		public FsmBool normalized;

		// Token: 0x04004325 RID: 17189
		internal Rect rect;
	}
}
