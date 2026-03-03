using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C75 RID: 3189
	[ActionCategory(ActionCategory.GUI)]
	[Tooltip("Resets the GUI matrix. Useful if you've rotated or scaled the GUI and now want to reset it.")]
	public class ResetGUIMatrix : FsmStateAction
	{
		// Token: 0x060042A6 RID: 17062 RVA: 0x00170B54 File Offset: 0x0016ED54
		public override void OnGUI()
		{
			PlayMakerGUI.GUIMatrix = (GUI.matrix = Matrix4x4.identity);
		}
	}
}
