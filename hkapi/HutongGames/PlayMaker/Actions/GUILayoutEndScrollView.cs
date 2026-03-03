using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BAF RID: 2991
	[ActionCategory(ActionCategory.GUILayout)]
	[Tooltip("Close a group started with GUILayout Begin ScrollView.")]
	public class GUILayoutEndScrollView : FsmStateAction
	{
		// Token: 0x06003F42 RID: 16194 RVA: 0x00166AFB File Offset: 0x00164CFB
		public override void OnGUI()
		{
			GUILayout.EndScrollView();
		}
	}
}
