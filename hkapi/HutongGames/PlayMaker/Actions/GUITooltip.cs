using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BC0 RID: 3008
	[ActionCategory(ActionCategory.GUI)]
	[Tooltip("Gets the Tooltip of the control the mouse is currently over and store it in a String Variable.")]
	public class GUITooltip : FsmStateAction
	{
		// Token: 0x06003F78 RID: 16248 RVA: 0x0016776C File Offset: 0x0016596C
		public override void Reset()
		{
			this.storeTooltip = null;
		}

		// Token: 0x06003F79 RID: 16249 RVA: 0x00167775 File Offset: 0x00165975
		public override void OnGUI()
		{
			this.storeTooltip.Value = GUI.tooltip;
		}

		// Token: 0x040043A1 RID: 17313
		[UIHint(UIHint.Variable)]
		public FsmString storeTooltip;
	}
}
