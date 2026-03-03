using System;
using UnityEngine;

// Token: 0x02000413 RID: 1043
internal class ProfilerRecording
{
	// Token: 0x06001795 RID: 6037 RVA: 0x0006F7C2 File Offset: 0x0006D9C2
	public ProfilerRecording(string id)
	{
		this.id = id;
	}

	// Token: 0x06001796 RID: 6038 RVA: 0x0006F7D1 File Offset: 0x0006D9D1
	public void Start()
	{
		if (this.started)
		{
			this.BalanceError();
		}
		this.count++;
		this.started = true;
		this.startTime = Time.realtimeSinceStartup;
	}

	// Token: 0x06001797 RID: 6039 RVA: 0x0006F804 File Offset: 0x0006DA04
	public void Stop()
	{
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		if (!this.started)
		{
			this.BalanceError();
		}
		this.started = false;
		float num = realtimeSinceStartup - this.startTime;
		this.accumulatedTime += num;
	}

	// Token: 0x06001798 RID: 6040 RVA: 0x0006F841 File Offset: 0x0006DA41
	public void Reset()
	{
		this.accumulatedTime = 0f;
		this.count = 0;
		this.started = false;
	}

	// Token: 0x06001799 RID: 6041 RVA: 0x0006F85C File Offset: 0x0006DA5C
	private void BalanceError()
	{
		Debug.LogError("ProfilerRecording start/stops not balanced for '" + this.id + "'");
	}

	// Token: 0x1700030F RID: 783
	// (get) Token: 0x0600179A RID: 6042 RVA: 0x0006F878 File Offset: 0x0006DA78
	public float Seconds
	{
		get
		{
			return this.accumulatedTime;
		}
	}

	// Token: 0x17000310 RID: 784
	// (get) Token: 0x0600179B RID: 6043 RVA: 0x0006F880 File Offset: 0x0006DA80
	public int Count
	{
		get
		{
			return this.count;
		}
	}

	// Token: 0x04001C56 RID: 7254
	private int count;

	// Token: 0x04001C57 RID: 7255
	private float startTime;

	// Token: 0x04001C58 RID: 7256
	private float accumulatedTime;

	// Token: 0x04001C59 RID: 7257
	private bool started;

	// Token: 0x04001C5A RID: 7258
	public string id;
}
