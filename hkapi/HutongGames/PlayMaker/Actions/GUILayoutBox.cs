using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BA8 RID: 2984
	[ActionCategory(ActionCategory.GUILayout)]
	[Tooltip("GUILayout Box.")]
	public class GUILayoutBox : GUILayoutAction
	{
		// Token: 0x06003F2D RID: 16173 RVA: 0x00166762 File Offset: 0x00164962
		public override void Reset()
		{
			base.Reset();
			this.text = "";
			this.image = null;
			this.tooltip = "";
			this.style = "";
		}

		// Token: 0x06003F2E RID: 16174 RVA: 0x001667A4 File Offset: 0x001649A4
		public override void OnGUI()
		{
			if (string.IsNullOrEmpty(this.style.Value))
			{
				GUILayout.Box(new GUIContent(this.text.Value, this.image.Value, this.tooltip.Value), base.LayoutOptions);
				return;
			}
			GUILayout.Box(new GUIContent(this.text.Value, this.image.Value, this.tooltip.Value), this.style.Value, base.LayoutOptions);
		}

		// Token: 0x04004352 RID: 17234
		[Tooltip("Image to display in the Box.")]
		public FsmTexture image;

		// Token: 0x04004353 RID: 17235
		[Tooltip("Text to display in the Box.")]
		public FsmString text;

		// Token: 0x04004354 RID: 17236
		[Tooltip("Optional Tooltip string.")]
		public FsmString tooltip;

		// Token: 0x04004355 RID: 17237
		[Tooltip("Optional GUIStyle in the active GUISkin.")]
		public FsmString style;
	}
}
