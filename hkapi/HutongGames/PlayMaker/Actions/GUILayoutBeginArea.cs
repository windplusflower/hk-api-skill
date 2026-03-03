using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BA2 RID: 2978
	[ActionCategory(ActionCategory.GUILayout)]
	[Tooltip("Begin a GUILayout block of GUI controls in a fixed screen area. NOTE: Block must end with a corresponding GUILayoutEndArea.")]
	public class GUILayoutBeginArea : FsmStateAction
	{
		// Token: 0x06003F1A RID: 16154 RVA: 0x00166180 File Offset: 0x00164380
		public override void Reset()
		{
			this.screenRect = null;
			this.left = 0f;
			this.top = 0f;
			this.width = 1f;
			this.height = 1f;
			this.normalized = true;
			this.style = "";
		}

		// Token: 0x06003F1B RID: 16155 RVA: 0x001661F0 File Offset: 0x001643F0
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
			GUILayout.BeginArea(this.rect, GUIContent.none, this.style.Value);
		}

		// Token: 0x04004334 RID: 17204
		[UIHint(UIHint.Variable)]
		public FsmRect screenRect;

		// Token: 0x04004335 RID: 17205
		public FsmFloat left;

		// Token: 0x04004336 RID: 17206
		public FsmFloat top;

		// Token: 0x04004337 RID: 17207
		public FsmFloat width;

		// Token: 0x04004338 RID: 17208
		public FsmFloat height;

		// Token: 0x04004339 RID: 17209
		public FsmBool normalized;

		// Token: 0x0400433A RID: 17210
		public FsmString style;

		// Token: 0x0400433B RID: 17211
		private Rect rect;
	}
}
