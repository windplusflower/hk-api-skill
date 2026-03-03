using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BB0 RID: 2992
	[ActionCategory(ActionCategory.GUILayout)]
	[Tooltip("Close a group started with BeginVertical.")]
	public class GUILayoutEndVertical : FsmStateAction
	{
		// Token: 0x06003F44 RID: 16196 RVA: 0x00003603 File Offset: 0x00001803
		public override void Reset()
		{
		}

		// Token: 0x06003F45 RID: 16197 RVA: 0x00166B02 File Offset: 0x00164D02
		public override void OnGUI()
		{
			GUILayout.EndVertical();
		}
	}
}
