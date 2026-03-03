using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x02000030 RID: 48
public class TimeLimitCheck : FsmStateAction
{
	// Token: 0x06000112 RID: 274 RVA: 0x000065A8 File Offset: 0x000047A8
	public override void Reset()
	{
		this.storedValue = null;
		this.aboveEvent = null;
		this.belowEvent = null;
	}

	// Token: 0x06000113 RID: 275 RVA: 0x000065BF File Offset: 0x000047BF
	public override void OnEnter()
	{
		base.Fsm.Event((Time.time >= this.storedValue.Value) ? this.aboveEvent : this.belowEvent);
		base.Finish();
	}

	// Token: 0x040000D7 RID: 215
	[UIHint(UIHint.Variable)]
	public FsmFloat storedValue;

	// Token: 0x040000D8 RID: 216
	public FsmEvent aboveEvent;

	// Token: 0x040000D9 RID: 217
	public FsmEvent belowEvent;
}
