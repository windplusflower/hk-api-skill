using System;
using UnityEngine;

// Token: 0x020002A1 RID: 673
public class UnlockGGMode : MonoBehaviour
{
	// Token: 0x06000E14 RID: 3604 RVA: 0x0004540A File Offset: 0x0004360A
	private void Start()
	{
		this.SetUnlocked();
	}

	// Token: 0x06000E15 RID: 3605 RVA: 0x00045412 File Offset: 0x00043612
	public void SetUnlocked()
	{
		GameManager.instance.SetStatusRecordInt("RecBossRushMode", 1);
		GameManager.instance.SaveStatusRecords();
	}
}
