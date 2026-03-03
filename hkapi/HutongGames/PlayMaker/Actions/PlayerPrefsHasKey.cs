using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C54 RID: 3156
	[ActionCategory("PlayerPrefs")]
	[Tooltip("Returns true if key exists in the preferences.")]
	public class PlayerPrefsHasKey : FsmStateAction
	{
		// Token: 0x06004203 RID: 16899 RVA: 0x0016EDC3 File Offset: 0x0016CFC3
		public override void Reset()
		{
			this.key = "";
		}

		// Token: 0x06004204 RID: 16900 RVA: 0x0016EDD8 File Offset: 0x0016CFD8
		public override void OnEnter()
		{
			base.Finish();
			if (!this.key.IsNone && !this.key.Value.Equals(""))
			{
				this.variable.Value = PlayerPrefs.HasKey(this.key.Value);
			}
			base.Fsm.Event(this.variable.Value ? this.trueEvent : this.falseEvent);
		}

		// Token: 0x0400466E RID: 18030
		[RequiredField]
		public FsmString key;

		// Token: 0x0400466F RID: 18031
		[UIHint(UIHint.Variable)]
		[Title("Store Result")]
		public FsmBool variable;

		// Token: 0x04004670 RID: 18032
		[Tooltip("Event to send if key exists.")]
		public FsmEvent trueEvent;

		// Token: 0x04004671 RID: 18033
		[Tooltip("Event to send if key does not exist.")]
		public FsmEvent falseEvent;
	}
}
