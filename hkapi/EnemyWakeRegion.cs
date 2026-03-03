using System;
using UnityEngine;

// Token: 0x02000191 RID: 401
public class EnemyWakeRegion : MonoBehaviour
{
	// Token: 0x060008FB RID: 2299 RVA: 0x0003226B File Offset: 0x0003046B
	private void OnTriggerEnter2D(Collider2D collision)
	{
		this.fsm.SendEvent(this.enterEvent);
	}

	// Token: 0x060008FC RID: 2300 RVA: 0x0003227E File Offset: 0x0003047E
	private void OnTriggerExit2D(Collider2D collision)
	{
		this.fsm.SendEvent(this.exitEvent);
	}

	// Token: 0x060008FD RID: 2301 RVA: 0x00032291 File Offset: 0x00030491
	public EnemyWakeRegion()
	{
		this.enterEvent = "WAKE";
		this.exitEvent = "SLEEP";
		base..ctor();
	}

	// Token: 0x04000A0E RID: 2574
	public PlayMakerFSM fsm;

	// Token: 0x04000A0F RID: 2575
	public string enterEvent;

	// Token: 0x04000A10 RID: 2576
	public string exitEvent;
}
