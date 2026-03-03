using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BB1 RID: 2993
	[ActionCategory(ActionCategory.GUILayout)]
	[Tooltip("Inserts a flexible space element.")]
	public class GUILayoutFlexibleSpace : FsmStateAction
	{
		// Token: 0x06003F47 RID: 16199 RVA: 0x00003603 File Offset: 0x00001803
		public override void Reset()
		{
		}

		// Token: 0x06003F48 RID: 16200 RVA: 0x00166B09 File Offset: 0x00164D09
		public override void OnGUI()
		{
			GUILayout.FlexibleSpace();
		}
	}
}
