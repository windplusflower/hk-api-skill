using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CB9 RID: 3257
	[ActionCategory(ActionCategory.GUI)]
	[Tooltip("Sets the Tinting Color for the GUI. By default only effects GUI rendered by this FSM, check Apply Globally to effect all GUI controls.")]
	public class SetGUIColor : FsmStateAction
	{
		// Token: 0x060043E2 RID: 17378 RVA: 0x001748CE File Offset: 0x00172ACE
		public override void Reset()
		{
			this.color = Color.white;
		}

		// Token: 0x060043E3 RID: 17379 RVA: 0x001748E0 File Offset: 0x00172AE0
		public override void OnGUI()
		{
			GUI.color = this.color.Value;
			if (this.applyGlobally.Value)
			{
				PlayMakerGUI.GUIColor = GUI.color;
			}
		}

		// Token: 0x04004850 RID: 18512
		[RequiredField]
		public FsmColor color;

		// Token: 0x04004851 RID: 18513
		public FsmBool applyGlobally;
	}
}
