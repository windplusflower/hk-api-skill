using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BA4 RID: 2980
	[ActionCategory(ActionCategory.GUILayout)]
	[Tooltip("Begin a centered GUILayout block. The block is centered inside a parent GUILayout Area. So to place the block in the center of the screen, first use a GULayout Area the size of the whole screen (the default setting). NOTE: Block must end with a corresponding GUILayoutEndCentered.")]
	public class GUILayoutBeginCentered : FsmStateAction
	{
		// Token: 0x06003F21 RID: 16161 RVA: 0x00003603 File Offset: 0x00001803
		public override void Reset()
		{
		}

		// Token: 0x06003F22 RID: 16162 RVA: 0x00166523 File Offset: 0x00164723
		public override void OnGUI()
		{
			GUILayout.BeginVertical(Array.Empty<GUILayoutOption>());
			GUILayout.FlexibleSpace();
			GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
			GUILayout.FlexibleSpace();
			GUILayout.BeginVertical(Array.Empty<GUILayoutOption>());
		}
	}
}
