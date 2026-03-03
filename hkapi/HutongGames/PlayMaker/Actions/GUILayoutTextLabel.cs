using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BBC RID: 3004
	[ActionCategory(ActionCategory.GUILayout)]
	[Tooltip("GUILayout Label for simple text.")]
	public class GUILayoutTextLabel : GUILayoutAction
	{
		// Token: 0x06003F68 RID: 16232 RVA: 0x00167285 File Offset: 0x00165485
		public override void Reset()
		{
			base.Reset();
			this.text = "";
			this.style = "";
		}

		// Token: 0x06003F69 RID: 16233 RVA: 0x001672B0 File Offset: 0x001654B0
		public override void OnGUI()
		{
			if (string.IsNullOrEmpty(this.style.Value))
			{
				GUILayout.Label(new GUIContent(this.text.Value), base.LayoutOptions);
				return;
			}
			GUILayout.Label(new GUIContent(this.text.Value), this.style.Value, base.LayoutOptions);
		}

		// Token: 0x0400438C RID: 17292
		[Tooltip("Text to display.")]
		public FsmString text;

		// Token: 0x0400438D RID: 17293
		[Tooltip("Optional GUIStyle in the active GUISkin.")]
		public FsmString style;
	}
}
