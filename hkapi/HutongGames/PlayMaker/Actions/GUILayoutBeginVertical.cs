using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BA7 RID: 2983
	[ActionCategory(ActionCategory.GUILayout)]
	[Tooltip("Begins a vertical control group. The group must be closed with GUILayoutEndVertical action.")]
	public class GUILayoutBeginVertical : GUILayoutAction
	{
		// Token: 0x06003F2A RID: 16170 RVA: 0x001666D5 File Offset: 0x001648D5
		public override void Reset()
		{
			base.Reset();
			this.text = "";
			this.image = null;
			this.tooltip = "";
			this.style = "";
		}

		// Token: 0x06003F2B RID: 16171 RVA: 0x00166714 File Offset: 0x00164914
		public override void OnGUI()
		{
			GUILayout.BeginVertical(new GUIContent(this.text.Value, this.image.Value, this.tooltip.Value), this.style.Value, base.LayoutOptions);
		}

		// Token: 0x0400434E RID: 17230
		public FsmTexture image;

		// Token: 0x0400434F RID: 17231
		public FsmString text;

		// Token: 0x04004350 RID: 17232
		public FsmString tooltip;

		// Token: 0x04004351 RID: 17233
		public FsmString style;
	}
}
