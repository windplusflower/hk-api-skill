using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B9C RID: 2972
	[ActionCategory(ActionCategory.GUI)]
	[Tooltip("GUI Box.")]
	public class GUIBox : GUIContentAction
	{
		// Token: 0x06003F0A RID: 16138 RVA: 0x00165E50 File Offset: 0x00164050
		public override void OnGUI()
		{
			base.OnGUI();
			if (string.IsNullOrEmpty(this.style.Value))
			{
				GUI.Box(this.rect, this.content);
				return;
			}
			GUI.Box(this.rect, this.content, this.style.Value);
		}
	}
}
