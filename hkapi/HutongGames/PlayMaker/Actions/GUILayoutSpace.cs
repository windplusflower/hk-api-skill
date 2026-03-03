using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BBA RID: 3002
	[ActionCategory(ActionCategory.GUILayout)]
	[Tooltip("Inserts a space in the current layout group.")]
	public class GUILayoutSpace : FsmStateAction
	{
		// Token: 0x06003F62 RID: 16226 RVA: 0x001671B5 File Offset: 0x001653B5
		public override void Reset()
		{
			this.space = 10f;
		}

		// Token: 0x06003F63 RID: 16227 RVA: 0x001671C7 File Offset: 0x001653C7
		public override void OnGUI()
		{
			GUILayout.Space(this.space.Value);
		}

		// Token: 0x04004387 RID: 17287
		public FsmFloat space;
	}
}
