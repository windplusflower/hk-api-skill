using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C55 RID: 3157
	[ActionCategory("PlayerPrefs")]
	[Tooltip("Sets the value of the preference identified by key.")]
	public class PlayerPrefsSetFloat : FsmStateAction
	{
		// Token: 0x06004206 RID: 16902 RVA: 0x0016EE50 File Offset: 0x0016D050
		public override void Reset()
		{
			this.keys = new FsmString[1];
			this.values = new FsmFloat[1];
		}

		// Token: 0x06004207 RID: 16903 RVA: 0x0016EE6C File Offset: 0x0016D06C
		public override void OnEnter()
		{
			for (int i = 0; i < this.keys.Length; i++)
			{
				if (!this.keys[i].IsNone || !this.keys[i].Value.Equals(""))
				{
					PlayerPrefs.SetFloat(this.keys[i].Value, this.values[i].IsNone ? 0f : this.values[i].Value);
				}
			}
			base.Finish();
		}

		// Token: 0x04004672 RID: 18034
		[CompoundArray("Count", "Key", "Value")]
		[Tooltip("Case sensitive key.")]
		public FsmString[] keys;

		// Token: 0x04004673 RID: 18035
		public FsmFloat[] values;
	}
}
