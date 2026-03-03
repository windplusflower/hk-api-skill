using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BB7 RID: 2999
	[ActionCategory(ActionCategory.GUILayout)]
	[Tooltip("GUILayout Label.")]
	public class GUILayoutLabel : GUILayoutAction
	{
		// Token: 0x06003F59 RID: 16217 RVA: 0x00166F16 File Offset: 0x00165116
		public override void Reset()
		{
			base.Reset();
			this.text = "";
			this.image = null;
			this.tooltip = "";
			this.style = "";
		}

		// Token: 0x06003F5A RID: 16218 RVA: 0x00166F58 File Offset: 0x00165158
		public override void OnGUI()
		{
			if (string.IsNullOrEmpty(this.style.Value))
			{
				GUILayout.Label(new GUIContent(this.text.Value, this.image.Value, this.tooltip.Value), base.LayoutOptions);
				return;
			}
			GUILayout.Label(new GUIContent(this.text.Value, this.image.Value, this.tooltip.Value), this.style.Value, base.LayoutOptions);
		}

		// Token: 0x04004378 RID: 17272
		public FsmTexture image;

		// Token: 0x04004379 RID: 17273
		public FsmString text;

		// Token: 0x0400437A RID: 17274
		public FsmString tooltip;

		// Token: 0x0400437B RID: 17275
		public FsmString style;
	}
}
