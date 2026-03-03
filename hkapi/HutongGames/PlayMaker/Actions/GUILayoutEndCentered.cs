using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BAD RID: 2989
	[ActionCategory(ActionCategory.GUILayout)]
	[Tooltip("End a centered GUILayout block started with GUILayoutBeginCentered.")]
	public class GUILayoutEndCentered : FsmStateAction
	{
		// Token: 0x06003F3C RID: 16188 RVA: 0x00003603 File Offset: 0x00001803
		public override void Reset()
		{
		}

		// Token: 0x06003F3D RID: 16189 RVA: 0x00166AD9 File Offset: 0x00164CD9
		public override void OnGUI()
		{
			GUILayout.EndVertical();
			GUILayout.FlexibleSpace();
			GUILayout.EndHorizontal();
			GUILayout.FlexibleSpace();
			GUILayout.EndVertical();
		}
	}
}
