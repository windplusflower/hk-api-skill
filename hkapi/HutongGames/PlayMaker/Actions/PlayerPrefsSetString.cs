using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C57 RID: 3159
	[ActionCategory("PlayerPrefs")]
	[Tooltip("Sets the value of the preference identified by key.")]
	public class PlayerPrefsSetString : FsmStateAction
	{
		// Token: 0x0600420C RID: 16908 RVA: 0x0016EF8B File Offset: 0x0016D18B
		public override void Reset()
		{
			this.keys = new FsmString[1];
			this.values = new FsmString[1];
		}

		// Token: 0x0600420D RID: 16909 RVA: 0x0016EFA8 File Offset: 0x0016D1A8
		public override void OnEnter()
		{
			for (int i = 0; i < this.keys.Length; i++)
			{
				if (!this.keys[i].IsNone || !this.keys[i].Value.Equals(""))
				{
					PlayerPrefs.SetString(this.keys[i].Value, this.values[i].IsNone ? "" : this.values[i].Value);
				}
			}
			base.Finish();
		}

		// Token: 0x04004676 RID: 18038
		[CompoundArray("Count", "Key", "Value")]
		[Tooltip("Case sensitive key.")]
		public FsmString[] keys;

		// Token: 0x04004677 RID: 18039
		public FsmString[] values;
	}
}
