using System;
using UnityEngine;

// Token: 0x02000402 RID: 1026
public class SendPlaymakerEventOnEnable : MonoBehaviour
{
	// Token: 0x06001750 RID: 5968 RVA: 0x0006E457 File Offset: 0x0006C657
	private void OnEnable()
	{
		if (this.eventName != "")
		{
			PlayMakerFSM.BroadcastEvent(this.eventName);
		}
	}

	// Token: 0x06001751 RID: 5969 RVA: 0x0006E476 File Offset: 0x0006C676
	public SendPlaymakerEventOnEnable()
	{
		this.eventName = "";
		base..ctor();
	}

	// Token: 0x04001C13 RID: 7187
	public string eventName;
}
