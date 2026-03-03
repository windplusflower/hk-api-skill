using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x0200002F RID: 47
public class TimeLimitSet : FsmStateAction
{
	// Token: 0x0600010F RID: 271 RVA: 0x00006574 File Offset: 0x00004774
	public override void Reset()
	{
		this.timeDelay = null;
		this.storeValue = null;
	}

	// Token: 0x06000110 RID: 272 RVA: 0x00006584 File Offset: 0x00004784
	public override void OnEnter()
	{
		this.storeValue.Value = Time.time + this.timeDelay.Value;
		base.Finish();
	}

	// Token: 0x040000D5 RID: 213
	public FsmFloat timeDelay;

	// Token: 0x040000D6 RID: 214
	[UIHint(UIHint.Variable)]
	public FsmFloat storeValue;
}
