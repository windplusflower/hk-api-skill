using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BAC RID: 2988
	[ActionCategory(ActionCategory.GUILayout)]
	[Tooltip("Close a GUILayout group started with BeginArea.")]
	public class GUILayoutEndArea : FsmStateAction
	{
		// Token: 0x06003F39 RID: 16185 RVA: 0x00003603 File Offset: 0x00001803
		public override void Reset()
		{
		}

		// Token: 0x06003F3A RID: 16186 RVA: 0x00166AD2 File Offset: 0x00164CD2
		public override void OnGUI()
		{
			GUILayout.EndArea();
		}
	}
}
