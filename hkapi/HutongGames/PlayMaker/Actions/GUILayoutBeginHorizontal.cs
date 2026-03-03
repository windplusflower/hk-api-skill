using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BA5 RID: 2981
	[ActionCategory(ActionCategory.GUILayout)]
	[Tooltip("GUILayout BeginHorizontal.")]
	public class GUILayoutBeginHorizontal : GUILayoutAction
	{
		// Token: 0x06003F24 RID: 16164 RVA: 0x0016654D File Offset: 0x0016474D
		public override void Reset()
		{
			base.Reset();
			this.text = "";
			this.image = null;
			this.tooltip = "";
			this.style = "";
		}

		// Token: 0x06003F25 RID: 16165 RVA: 0x0016658C File Offset: 0x0016478C
		public override void OnGUI()
		{
			GUILayout.BeginHorizontal(new GUIContent(this.text.Value, this.image.Value, this.tooltip.Value), this.style.Value, base.LayoutOptions);
		}

		// Token: 0x04004343 RID: 17219
		public FsmTexture image;

		// Token: 0x04004344 RID: 17220
		public FsmString text;

		// Token: 0x04004345 RID: 17221
		public FsmString tooltip;

		// Token: 0x04004346 RID: 17222
		public FsmString style;
	}
}
