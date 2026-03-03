using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BA0 RID: 2976
	[ActionCategory(ActionCategory.GUI)]
	[Tooltip("GUI Label.")]
	public class GUILabel : GUIContentAction
	{
		// Token: 0x06003F15 RID: 16149 RVA: 0x001660C4 File Offset: 0x001642C4
		public override void OnGUI()
		{
			base.OnGUI();
			if (string.IsNullOrEmpty(this.style.Value))
			{
				GUI.Label(this.rect, this.content);
				return;
			}
			GUI.Label(this.rect, this.content, this.style.Value);
		}
	}
}
