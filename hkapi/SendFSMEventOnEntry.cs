using System;
using UnityEngine;

// Token: 0x020001CD RID: 461
public class SendFSMEventOnEntry : MonoBehaviour
{
	// Token: 0x06000A29 RID: 2601 RVA: 0x00037ACE File Offset: 0x00035CCE
	private void OnTriggerEnter2D(Collider2D collision)
	{
		this.fsm.SendEvent(this.fsmEvent);
	}

	// Token: 0x04000B3D RID: 2877
	public PlayMakerFSM fsm;

	// Token: 0x04000B3E RID: 2878
	public string fsmEvent;
}
