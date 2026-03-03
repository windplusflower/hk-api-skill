using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C56 RID: 3158
	[ActionCategory("PlayerPrefs")]
	[Tooltip("Sets the value of the preference identified by key.")]
	public class PlayerPrefsSetInt : FsmStateAction
	{
		// Token: 0x06004209 RID: 16905 RVA: 0x0016EEEF File Offset: 0x0016D0EF
		public override void Reset()
		{
			this.keys = new FsmString[1];
			this.values = new FsmInt[1];
		}

		// Token: 0x0600420A RID: 16906 RVA: 0x0016EF0C File Offset: 0x0016D10C
		public override void OnEnter()
		{
			for (int i = 0; i < this.keys.Length; i++)
			{
				if (!this.keys[i].IsNone || !this.keys[i].Value.Equals(""))
				{
					PlayerPrefs.SetInt(this.keys[i].Value, this.values[i].IsNone ? 0 : this.values[i].Value);
				}
			}
			base.Finish();
		}

		// Token: 0x04004674 RID: 18036
		[CompoundArray("Count", "Key", "Value")]
		[Tooltip("Case sensitive key.")]
		public FsmString[] keys;

		// Token: 0x04004675 RID: 18037
		public FsmInt[] values;
	}
}
