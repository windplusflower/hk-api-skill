using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C51 RID: 3153
	[ActionCategory("PlayerPrefs")]
	[Tooltip("Returns the value corresponding to key in the preference file if it exists.")]
	public class PlayerPrefsGetFloat : FsmStateAction
	{
		// Token: 0x060041FA RID: 16890 RVA: 0x0016EBB8 File Offset: 0x0016CDB8
		public override void Reset()
		{
			this.keys = new FsmString[1];
			this.variables = new FsmFloat[1];
		}

		// Token: 0x060041FB RID: 16891 RVA: 0x0016EBD4 File Offset: 0x0016CDD4
		public override void OnEnter()
		{
			for (int i = 0; i < this.keys.Length; i++)
			{
				if (!this.keys[i].IsNone || !this.keys[i].Value.Equals(""))
				{
					this.variables[i].Value = PlayerPrefs.GetFloat(this.keys[i].Value, this.variables[i].IsNone ? 0f : this.variables[i].Value);
				}
			}
			base.Finish();
		}

		// Token: 0x04004668 RID: 18024
		[CompoundArray("Count", "Key", "Variable")]
		[Tooltip("Case sensitive key.")]
		public FsmString[] keys;

		// Token: 0x04004669 RID: 18025
		[UIHint(UIHint.Variable)]
		public FsmFloat[] variables;
	}
}
