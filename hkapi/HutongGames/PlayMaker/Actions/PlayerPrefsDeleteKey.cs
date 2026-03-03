using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C50 RID: 3152
	[ActionCategory("PlayerPrefs")]
	[Tooltip("Removes key and its corresponding value from the preferences.")]
	public class PlayerPrefsDeleteKey : FsmStateAction
	{
		// Token: 0x060041F7 RID: 16887 RVA: 0x0016EB6A File Offset: 0x0016CD6A
		public override void Reset()
		{
			this.key = "";
		}

		// Token: 0x060041F8 RID: 16888 RVA: 0x0016EB7C File Offset: 0x0016CD7C
		public override void OnEnter()
		{
			if (!this.key.IsNone && !this.key.Value.Equals(""))
			{
				PlayerPrefs.DeleteKey(this.key.Value);
			}
			base.Finish();
		}

		// Token: 0x04004667 RID: 18023
		public FsmString key;
	}
}
