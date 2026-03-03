using System;
using UnityEngine;

// Token: 0x020000B4 RID: 180
public class MatchMasterTimeSample : MonoBehaviour
{
	// Token: 0x060003CB RID: 971 RVA: 0x00013980 File Offset: 0x00011B80
	private void Update()
	{
		this.slave1.timeSamples = this.master.timeSamples;
		this.slave2.timeSamples = this.master.timeSamples;
		this.slave3.timeSamples = this.master.timeSamples;
		this.slave4.timeSamples = this.master.timeSamples;
	}

	// Token: 0x04000351 RID: 849
	public AudioSource master;

	// Token: 0x04000352 RID: 850
	public AudioSource slave1;

	// Token: 0x04000353 RID: 851
	public AudioSource slave2;

	// Token: 0x04000354 RID: 852
	public AudioSource slave3;

	// Token: 0x04000355 RID: 853
	public AudioSource slave4;
}
