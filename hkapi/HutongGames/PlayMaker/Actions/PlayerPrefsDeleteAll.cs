using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C4F RID: 3151
	[ActionCategory("PlayerPrefs")]
	[Tooltip("Removes all keys and values from the preferences. Use with caution.")]
	public class PlayerPrefsDeleteAll : FsmStateAction
	{
		// Token: 0x060041F4 RID: 16884 RVA: 0x00003603 File Offset: 0x00001803
		public override void Reset()
		{
		}

		// Token: 0x060041F5 RID: 16885 RVA: 0x0016EB5D File Offset: 0x0016CD5D
		public override void OnEnter()
		{
			PlayerPrefs.DeleteAll();
			base.Finish();
		}
	}
}
