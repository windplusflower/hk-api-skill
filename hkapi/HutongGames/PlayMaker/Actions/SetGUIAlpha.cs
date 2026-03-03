using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CB7 RID: 3255
	[ActionCategory(ActionCategory.GUI)]
	[Tooltip("Sets the global Alpha for the GUI. Useful for fading GUI up/down. By default only effects GUI rendered by this FSM, check Apply Globally to effect all GUI controls.")]
	public class SetGUIAlpha : FsmStateAction
	{
		// Token: 0x060043DC RID: 17372 RVA: 0x00174829 File Offset: 0x00172A29
		public override void Reset()
		{
			this.alpha = 1f;
		}

		// Token: 0x060043DD RID: 17373 RVA: 0x0017483C File Offset: 0x00172A3C
		public override void OnGUI()
		{
			GUI.color = new Color(GUI.color.r, GUI.color.g, GUI.color.b, this.alpha.Value);
			if (this.applyGlobally.Value)
			{
				PlayMakerGUI.GUIColor = GUI.color;
			}
		}

		// Token: 0x0400484C RID: 18508
		[RequiredField]
		public FsmFloat alpha;

		// Token: 0x0400484D RID: 18509
		public FsmBool applyGlobally;
	}
}
