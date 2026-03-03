using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BAE RID: 2990
	[ActionCategory(ActionCategory.GUILayout)]
	[Tooltip("Close a group started with BeginHorizontal.")]
	public class GUILayoutEndHorizontal : FsmStateAction
	{
		// Token: 0x06003F3F RID: 16191 RVA: 0x00003603 File Offset: 0x00001803
		public override void Reset()
		{
		}

		// Token: 0x06003F40 RID: 16192 RVA: 0x00166AF4 File Offset: 0x00164CF4
		public override void OnGUI()
		{
			GUILayout.EndHorizontal();
		}
	}
}
