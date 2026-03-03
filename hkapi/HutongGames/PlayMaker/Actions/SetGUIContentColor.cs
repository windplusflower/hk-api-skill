using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CBA RID: 3258
	[ActionCategory(ActionCategory.GUI)]
	[Tooltip("Sets the Tinting Color for all text rendered by the GUI. By default only effects GUI rendered by this FSM, check Apply Globally to effect all GUI controls.")]
	public class SetGUIContentColor : FsmStateAction
	{
		// Token: 0x060043E5 RID: 17381 RVA: 0x00174909 File Offset: 0x00172B09
		public override void Reset()
		{
			this.contentColor = Color.white;
		}

		// Token: 0x060043E6 RID: 17382 RVA: 0x0017491B File Offset: 0x00172B1B
		public override void OnGUI()
		{
			GUI.contentColor = this.contentColor.Value;
			if (this.applyGlobally.Value)
			{
				PlayMakerGUI.GUIContentColor = GUI.contentColor;
			}
		}

		// Token: 0x04004852 RID: 18514
		[RequiredField]
		public FsmColor contentColor;

		// Token: 0x04004853 RID: 18515
		public FsmBool applyGlobally;
	}
}
