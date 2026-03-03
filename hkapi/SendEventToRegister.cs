using System;
using HutongGames.PlayMaker;

// Token: 0x020001E7 RID: 487
[ActionCategory("Hollow Knight")]
public class SendEventToRegister : FsmStateAction
{
	// Token: 0x06000A9E RID: 2718 RVA: 0x000395D2 File Offset: 0x000377D2
	public override void Reset()
	{
		this.eventName = new FsmString();
	}

	// Token: 0x06000A9F RID: 2719 RVA: 0x000395DF File Offset: 0x000377DF
	public override void OnEnter()
	{
		if (this.eventName.Value != "")
		{
			EventRegister.SendEvent(this.eventName.Value);
		}
		base.Finish();
	}

	// Token: 0x04000BB7 RID: 2999
	public FsmString eventName;
}
