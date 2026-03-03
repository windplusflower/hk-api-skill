using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C53 RID: 3155
	[ActionCategory("PlayerPrefs")]
	[Tooltip("Returns the value corresponding to key in the preference file if it exists.")]
	public class PlayerPrefsGetString : FsmStateAction
	{
		// Token: 0x06004200 RID: 16896 RVA: 0x0016ED13 File Offset: 0x0016CF13
		public override void Reset()
		{
			this.keys = new FsmString[1];
			this.variables = new FsmString[1];
		}

		// Token: 0x06004201 RID: 16897 RVA: 0x0016ED30 File Offset: 0x0016CF30
		public override void OnEnter()
		{
			for (int i = 0; i < this.keys.Length; i++)
			{
				if (!this.keys[i].IsNone || !this.keys[i].Value.Equals(""))
				{
					this.variables[i].Value = PlayerPrefs.GetString(this.keys[i].Value, this.variables[i].IsNone ? "" : this.variables[i].Value);
				}
			}
			base.Finish();
		}

		// Token: 0x0400466C RID: 18028
		[CompoundArray("Count", "Key", "Variable")]
		[Tooltip("Case sensitive key.")]
		public FsmString[] keys;

		// Token: 0x0400466D RID: 18029
		[UIHint(UIHint.Variable)]
		public FsmString[] variables;
	}
}
