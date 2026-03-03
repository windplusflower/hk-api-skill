using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C52 RID: 3154
	[ActionCategory("PlayerPrefs")]
	[Tooltip("Returns the value corresponding to key in the preference file if it exists.")]
	public class PlayerPrefsGetInt : FsmStateAction
	{
		// Token: 0x060041FD RID: 16893 RVA: 0x0016EC67 File Offset: 0x0016CE67
		public override void Reset()
		{
			this.keys = new FsmString[1];
			this.variables = new FsmInt[1];
		}

		// Token: 0x060041FE RID: 16894 RVA: 0x0016EC84 File Offset: 0x0016CE84
		public override void OnEnter()
		{
			for (int i = 0; i < this.keys.Length; i++)
			{
				if (!this.keys[i].IsNone || !this.keys[i].Value.Equals(""))
				{
					this.variables[i].Value = PlayerPrefs.GetInt(this.keys[i].Value, this.variables[i].IsNone ? 0 : this.variables[i].Value);
				}
			}
			base.Finish();
		}

		// Token: 0x0400466A RID: 18026
		[CompoundArray("Count", "Key", "Variable")]
		[Tooltip("Case sensitive key.")]
		public FsmString[] keys;

		// Token: 0x0400466B RID: 18027
		[UIHint(UIHint.Variable)]
		public FsmInt[] variables;
	}
}
