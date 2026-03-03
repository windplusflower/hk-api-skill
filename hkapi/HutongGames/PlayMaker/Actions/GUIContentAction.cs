using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B9E RID: 2974
	[Tooltip("GUI base action - don't use!")]
	public abstract class GUIContentAction : GUIAction
	{
		// Token: 0x06003F0F RID: 16143 RVA: 0x00165F37 File Offset: 0x00164137
		public override void Reset()
		{
			base.Reset();
			this.image = null;
			this.text = "";
			this.tooltip = "";
			this.style = "";
		}

		// Token: 0x06003F10 RID: 16144 RVA: 0x00165F76 File Offset: 0x00164176
		public override void OnGUI()
		{
			base.OnGUI();
			this.content = new GUIContent(this.text.Value, this.image.Value, this.tooltip.Value);
		}

		// Token: 0x04004328 RID: 17192
		public FsmTexture image;

		// Token: 0x04004329 RID: 17193
		public FsmString text;

		// Token: 0x0400432A RID: 17194
		public FsmString tooltip;

		// Token: 0x0400432B RID: 17195
		public FsmString style;

		// Token: 0x0400432C RID: 17196
		internal GUIContent content;
	}
}
