using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CB8 RID: 3256
	[ActionCategory(ActionCategory.GUI)]
	[Tooltip("Sets the Tinting Color for all background elements rendered by the GUI. By default only effects GUI rendered by this FSM, check Apply Globally to effect all GUI controls.")]
	public class SetGUIBackgroundColor : FsmStateAction
	{
		// Token: 0x060043DF RID: 17375 RVA: 0x00174893 File Offset: 0x00172A93
		public override void Reset()
		{
			this.backgroundColor = Color.white;
		}

		// Token: 0x060043E0 RID: 17376 RVA: 0x001748A5 File Offset: 0x00172AA5
		public override void OnGUI()
		{
			GUI.backgroundColor = this.backgroundColor.Value;
			if (this.applyGlobally.Value)
			{
				PlayMakerGUI.GUIBackgroundColor = GUI.backgroundColor;
			}
		}

		// Token: 0x0400484E RID: 18510
		[RequiredField]
		public FsmColor backgroundColor;

		// Token: 0x0400484F RID: 18511
		public FsmBool applyGlobally;
	}
}
