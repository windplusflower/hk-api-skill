using System;
using UnityEngine;

// Token: 0x020000C8 RID: 200
public class AudioLoopMaster : MonoBehaviour
{
	// Token: 0x06000418 RID: 1048 RVA: 0x0001448E File Offset: 0x0001268E
	private void Start()
	{
		this.audioSource = base.GetComponent<AudioSource>();
	}

	// Token: 0x06000419 RID: 1049 RVA: 0x0001449C File Offset: 0x0001269C
	private void Update()
	{
		float time = this.audioSource.time;
		if (time >= 0f && time <= 2f && !this.reset)
		{
			int timeSamples = this.audioSource.timeSamples;
			if (this.syncAction)
			{
				this.action.timeSamples = timeSamples;
			}
			if (this.syncSub)
			{
				this.sub.timeSamples = timeSamples;
			}
			if (this.syncMainAlt)
			{
				this.mainAlt.timeSamples = timeSamples;
			}
			if (this.syncTension)
			{
				this.tension.timeSamples = timeSamples;
			}
			if (this.syncExtra)
			{
				this.extra.timeSamples = timeSamples;
			}
			this.reset = true;
		}
		if (time > 1f && this.reset)
		{
			this.reset = false;
		}
	}

	// Token: 0x0600041A RID: 1050 RVA: 0x00014564 File Offset: 0x00012764
	public void SetSyncAction(bool set)
	{
		this.syncAction = set;
	}

	// Token: 0x0600041B RID: 1051 RVA: 0x0001456D File Offset: 0x0001276D
	public void SetSyncSub(bool set)
	{
		this.syncSub = set;
	}

	// Token: 0x0600041C RID: 1052 RVA: 0x00014576 File Offset: 0x00012776
	public void SetSyncMainAlt(bool set)
	{
		this.syncMainAlt = set;
	}

	// Token: 0x0600041D RID: 1053 RVA: 0x0001457F File Offset: 0x0001277F
	public void SetSyncTension(bool set)
	{
		this.syncTension = set;
	}

	// Token: 0x0600041E RID: 1054 RVA: 0x00014588 File Offset: 0x00012788
	public void SetSyncExtra(bool set)
	{
		this.syncExtra = set;
	}

	// Token: 0x04000397 RID: 919
	private AudioSource audioSource;

	// Token: 0x04000398 RID: 920
	public AudioSource action;

	// Token: 0x04000399 RID: 921
	public AudioSource sub;

	// Token: 0x0400039A RID: 922
	public AudioSource mainAlt;

	// Token: 0x0400039B RID: 923
	public AudioSource tension;

	// Token: 0x0400039C RID: 924
	public AudioSource extra;

	// Token: 0x0400039D RID: 925
	private bool reset;

	// Token: 0x0400039E RID: 926
	private bool syncAction;

	// Token: 0x0400039F RID: 927
	private bool syncSub;

	// Token: 0x040003A0 RID: 928
	private bool syncMainAlt;

	// Token: 0x040003A1 RID: 929
	private bool syncTension;

	// Token: 0x040003A2 RID: 930
	private bool syncExtra;
}
